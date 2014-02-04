namespace TwilightShards.genLibrary
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Xml.Linq;
    using System.Xml;
    using System.Text;
    using System.IO;
    using System.Security.AccessControl;

    /// <summary>
    /// A collection of general helper functions
    /// </summary>
    public static class genHelper
    {

        /// <summary>
        /// This prints a variable number of lines to the Console. (ONLY call when you are using the Console.)
        /// </summary>
        /// <param name="lines">Number of lines to be printed</param>
        public static void printMultipleLines(int lines)
        {
            for (int i = 0; i < lines; i++)
            {
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Finds if the program has write permissions to this folder
        /// </summary>
        /// <param name="path">The folder to be tested</param>
        /// <returns>True for write permissions; False for none</returns>
        public static bool HasWritePermissionOnDir(string path)
        {
            var writeAllow = false;
            var writeDeny = false;
            try
            {
                var accessControlList = Directory.GetAccessControl(path);
                if (accessControlList == null)
                    return false;
                var accessRules = accessControlList.GetAccessRules(true, true,
                                            typeof(System.Security.Principal.SecurityIdentifier));
                if (accessRules == null)
                    return false;

                foreach (FileSystemAccessRule rule in accessRules)
                {
                    if ((FileSystemRights.Write & rule.FileSystemRights) != FileSystemRights.Write)
                        continue;

                    if (rule.AccessControlType == AccessControlType.Allow)
                        writeAllow = true;
                    else if (rule.AccessControlType == AccessControlType.Deny)
                        writeDeny = true;
                }

                return writeAllow && !writeDeny;
            }
            catch (UnauthorizedAccessException)
            {
                //the user cannot access the rights.
                return false; 
            }
        }

        /// <summary>
        /// Finds if this program has read permissions in this folder
        /// </summary>
        /// <param name="path">The folder to be tested</param>
        /// <returns>True for read permissions; False for none</returns>
        public static bool HasReadPermissionOnDir(string path)
        {
            var readAllow = false;
            var readDeny = false;
            try
            {
                var accessControlList = Directory.GetAccessControl(path);
                if (accessControlList == null)
                    return false;
                var accessRules = accessControlList.GetAccessRules(true, true,
                                            typeof(System.Security.Principal.SecurityIdentifier));
                if (accessRules == null)
                    return false;

                foreach (FileSystemAccessRule rule in accessRules)
                {
                    if ((FileSystemRights.Read & rule.FileSystemRights) != FileSystemRights.Read)
                        continue;

                    if (rule.AccessControlType == AccessControlType.Allow)
                        readAllow = true;
                    else if (rule.AccessControlType == AccessControlType.Deny)
                        readDeny = true;
                }

                return readAllow && !readDeny;
            }
            catch (UnauthorizedAccessException)
            {
                //the user cannot access the rights.
                return false;
            }
        }

    }
}
