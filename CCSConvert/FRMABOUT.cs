using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CCSConvert
{
    public partial class frmAbout : Form
    {
        public static int version_number = 3;
        public static string version_name = "1.2";
        public static string release_date = "2016.12.30";
        public static string program_name = "CCSConvert";
        public static string program_description = "Convert between Cylinderical and Cube Crushing Strengths of Concrete";


        public frmAbout()
        {
            InitializeComponent();
        }

        private void bttnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAbout_Load(object sender, EventArgs e)
        {
            lbl_program_title.Text = program_name;
            lbl_program_description.Text = program_description;

        }

        private void lbl_facebook_page_Click(object sender, EventArgs e)
        {

        }

        private void lbl_company_email_Click(object sender, EventArgs e)
        {

        }
    }
}
