/* libPlushie is a class library I use.
Copyright (C) 2013 Koihime Nakamura

This program is free software; you can redistribute it and/or
modify it under the terms of the GNU General Public License
as published by the Free Software Foundation; either version 2
of the License, or (at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with this program; if not, write to the Free Software
Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301, USA. */



namespace TwilightShards.genLibrary
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Windows.Forms;

    /// <summary>
    /// This class provides a prebuilt about box.
    /// </summary>
    public partial class AboutBox : Form
    {
        /// <summary>
        /// The default constructor for this class
        /// </summary>
        public AboutBox()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Function designed to initiate all of the about box parameters
        /// </summary>
        /// <param name="title">Title of the About Box</param>
        /// <param name="name">The Name of the Program</param>
        /// <param name="version">The version text of the program</param>
        /// <param name="about">The about text</param>
        public void setAboutBoxOpt(string title, string name, string version, string about)
        {
            this.setTitle(title);
            this.setProgramName(name);
            this.setVersionText(version);
            this.setAboutText(about);
        }

        /// <summary>
        /// This function sets the title of the about box
        /// </summary>
        /// <param name="title">The new title</param>
        public void setTitle(string title)
        {
            this.Text = title;
        }

        /// <summary>
        /// This sets the title of the program
        /// </summary>
        /// <param name="name">The Program's Name</param>
        public void setProgramName(string name)
        {
            this.lblPrgName.Text = name;
        }

        /// <summary>
        /// This function sets the version text for the program
        /// </summary>
        /// <param name="verText">The version text</param>
        public void setVersionText(string verText)
        {
            this.lblVerText.Text = verText;
        }

        /// <summary>
        /// Sets the about text for the about close
        /// </summary>
        /// <param name="abtText">The text to be set in the about box</param>
        public void setAboutText(string abtText)
        {
            this.lblAboutText.Text = abtText;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
