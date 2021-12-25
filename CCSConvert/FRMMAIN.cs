using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Xml.Serialization;
using sdu;
using sdu_custom_types;
using custom_io_functions;
using FormSerialisation;

namespace CCSConvert
{
    public partial class frmMain : Form
    {

        //  validation flag
        //private int invalidCount = 0;

        //  Constructor
        public frmMain()
        {
            InitializeComponent();
        }

        //  Calculation
        private void Calculate(object sender, EventArgs e)
        {

            //  get input
            double input_compressive_strength = customIO.atof(ref txt_input);
            double output_compressive_strength = 0.0;

            //  get conversion factor and display answer
            double conversion_factor;
            if (rad_Cube_To_Cylinder.Checked)
            {
                conversion_factor = Concrete.cube_to_cylinder_factor_01(input_compressive_strength);
                output_compressive_strength = conversion_factor * input_compressive_strength;

                txt_output.Text = output_compressive_strength.ToString("0");
                txt_ratio.Text = conversion_factor.ToString("0.000");


                //rtf_output.Clear();
                //put_rtf_output_label("Cube Crushing Strength");
                //put_rtf_output_value(input_compressive_strength.ToString("0") + " psi");
                //put_rtf_output_label("\r\nCylinderical Strength");
                //put_rtf_output_value(output_compressive_strength.ToString("0") + " psi");
                //put_rtf_output_label("\r\nComputed ratio of cylinder/cube strength");
                //put_rtf_output_value(conversion_factor.ToString("0.000"));
            }
            else if (rad_Cylinder_to_Cube.Checked)
            {
                conversion_factor = Concrete.cube_to_cylinder_factor_02(input_compressive_strength);
                output_compressive_strength = (1 / conversion_factor) * input_compressive_strength;

                txt_output.Text = output_compressive_strength.ToString("0");
                txt_ratio.Text = conversion_factor.ToString("0.000");


                //rtf_output.Clear();
                //put_rtf_output_label("Cylinderical Strength");
                //put_rtf_output_value(input_compressive_strength.ToString("0") + " psi");
                //put_rtf_output_label("\r\nCube Crushing Strength");
                //put_rtf_output_value(output_compressive_strength.ToString("0") + " psi");
                //put_rtf_output_label("\r\nComputed ratio of cylinder/cube strength");
                //put_rtf_output_value(conversion_factor.ToString("0.000"));
            }
        }

        //private void set_rtf_label_font()
        //{
        //    rtf_output.SelectionFont = new Font("Arial", 9f);
        //    rtf_output.SelectionAlignment = HorizontalAlignment.Left;
        //    rtf_output.SelectionColor = Color.Black;
        //}
        //private void set_rtf_value_font()
        //{
        //    rtf_output.SelectionFont = new Font("Arial", 18f);
        //    rtf_output.SelectionAlignment = HorizontalAlignment.Right;
        //    rtf_output.SelectionColor = Color.Blue;
        //}
            

        private void frm_main_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormSerialisor.Serialise(this, Application.StartupPath + @"\CCSConvert_frmMain_state.xml");
        }

        private void frm_main_Load(object sender, EventArgs e)
        {
            FormSerialisor.Deserialise(this, Application.StartupPath + @"\CCSConvert_frmMain_state.xml");
            GUI_Update();
        }

        private void list_bar_designation_DoubleClick(object sender, EventArgs e)
        {
            bttn_Convert.PerformClick();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Form frmabout = new frmAbout();
            frmabout.ShowDialog();
        }

        private void disclaimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_disclaimer fd = new frm_disclaimer();
            fd.ShowDialog();
        }

        private void referencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_references fr = new frm_references();
            fr.ShowDialog();
        }

        //private void put_rtf_output_label(string text_to_append)
        //{
        //    int length = rtf_output.TextLength;
        //    rtf_output.AppendText(text_to_append);
        //    rtf_output.AppendText(Environment.NewLine);
        //    rtf_output.SelectionStart = length;
        //    rtf_output.SelectionLength = text_to_append.Length;
        //    rtf_output.SelectionFont = new Font("Arial", 9f);
        //    rtf_output.SelectionAlignment = HorizontalAlignment.Left;
        //    rtf_output.SelectionColor = Color.Black;
        //}
        //private void put_rtf_output_value(string text_to_append)
        //{
        //    int length = rtf_output.TextLength;
        //    rtf_output.AppendText(text_to_append);
        //    rtf_output.AppendText(Environment.NewLine);
        //    rtf_output.SelectionStart = length;
        //    rtf_output.SelectionLength = text_to_append.Length;
        //    rtf_output.SelectionFont = new Font("Arial", 20f);
        //    rtf_output.SelectionAlignment = HorizontalAlignment.Right;
        //    rtf_output.SelectionColor = Color.Blue;
        //}

        private void rad_Cube_To_Cylinder_CheckedChanged(object sender, EventArgs e)
        {
            GUI_Update();
        }

        private void GUI_Update()
        {
            if (rad_Cube_To_Cylinder.Checked)
            {
                lbl_input_strength.Text = "Cube Crushing Strength";
                lbl_output_strength.Text = "Cylinder Crushing Strength";
            }
            else
            {
                lbl_input_strength.Text = "Cylinder Crushing Strength";
                lbl_output_strength.Text = "Cube Crushing Strength";
            }
        }
                             
    }
}
