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
    public partial class frm_references: Form
    {
        public frm_references()
        {
            InitializeComponent();
        }

        private void frm_disclaimer_Load(object sender, EventArgs e)
        {
            txt_reference_list.SelectAll();
            txt_reference_list.SelectionTabs = new int[] {25, 90, 500 };
        }
    }
}
