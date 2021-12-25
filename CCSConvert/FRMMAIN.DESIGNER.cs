namespace CCSConvert
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rad_Cylinder_to_Cube = new System.Windows.Forms.RadioButton();
            this.rad_Cube_To_Cylinder = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disclaimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.referencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_input = new System.Windows.Forms.TextBox();
            this.lbl_input_strength = new System.Windows.Forms.Label();
            this.txt_ratio = new System.Windows.Forms.TextBox();
            this.lbl_ratio = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_output = new System.Windows.Forms.TextBox();
            this.lbl_output_strength = new System.Windows.Forms.Label();
            this.bttn_Convert = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rad_Cylinder_to_Cube);
            this.groupBox1.Controls.Add(this.rad_Cube_To_Cylinder);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 103);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Conversion Type";
            // 
            // rad_Cylinder_to_Cube
            // 
            this.rad_Cylinder_to_Cube.AutoSize = true;
            this.rad_Cylinder_to_Cube.Location = new System.Drawing.Point(22, 60);
            this.rad_Cylinder_to_Cube.Name = "rad_Cylinder_to_Cube";
            this.rad_Cylinder_to_Cube.Size = new System.Drawing.Size(138, 22);
            this.rad_Cylinder_to_Cube.TabIndex = 1;
            this.rad_Cylinder_to_Cube.Text = "Cylinder to Cube";
            this.rad_Cylinder_to_Cube.UseVisualStyleBackColor = true;
            // 
            // rad_Cube_To_Cylinder
            // 
            this.rad_Cube_To_Cylinder.AutoSize = true;
            this.rad_Cube_To_Cylinder.Checked = true;
            this.rad_Cube_To_Cylinder.Location = new System.Drawing.Point(22, 32);
            this.rad_Cube_To_Cylinder.Name = "rad_Cube_To_Cylinder";
            this.rad_Cube_To_Cylinder.Size = new System.Drawing.Size(138, 22);
            this.rad_Cube_To_Cylinder.TabIndex = 0;
            this.rad_Cube_To_Cylinder.TabStop = true;
            this.rad_Cube_To_Cylinder.Text = "Cube to Cylinder";
            this.rad_Cube_To_Cylinder.UseVisualStyleBackColor = true;
            this.rad_Cube_To_Cylinder.CheckedChanged += new System.EventHandler(this.rad_Cube_To_Cylinder_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(476, 28);
            this.menuStrip1.TabIndex = 40;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.disclaimerToolStripMenuItem,
            this.toolStripMenuItem2,
            this.referencesToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.menuToolStripMenuItem.Text = "&Menu";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(157, 24);
            this.aboutToolStripMenuItem.Text = "About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // disclaimerToolStripMenuItem
            // 
            this.disclaimerToolStripMenuItem.Name = "disclaimerToolStripMenuItem";
            this.disclaimerToolStripMenuItem.Size = new System.Drawing.Size(157, 24);
            this.disclaimerToolStripMenuItem.Text = "Disclaimer...";
            this.disclaimerToolStripMenuItem.Click += new System.EventHandler(this.disclaimerToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(154, 6);
            // 
            // referencesToolStripMenuItem
            // 
            this.referencesToolStripMenuItem.Name = "referencesToolStripMenuItem";
            this.referencesToolStripMenuItem.Size = new System.Drawing.Size(157, 24);
            this.referencesToolStripMenuItem.Text = "References";
            this.referencesToolStripMenuItem.Click += new System.EventHandler(this.referencesToolStripMenuItem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txt_input);
            this.groupBox2.Controls.Add(this.lbl_input_strength);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(450, 76);
            this.groupBox2.TabIndex = 48;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Input";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_ratio);
            this.groupBox3.Controls.Add(this.lbl_ratio);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txt_output);
            this.groupBox3.Controls.Add(this.lbl_output_strength);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 222);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(450, 115);
            this.groupBox3.TabIndex = 49;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Output";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(392, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 18);
            this.label1.TabIndex = 46;
            this.label1.Text = "psi";
            // 
            // txt_input
            // 
            this.txt_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_input.Location = new System.Drawing.Point(251, 30);
            this.txt_input.Name = "txt_input";
            this.txt_input.Size = new System.Drawing.Size(133, 24);
            this.txt_input.TabIndex = 45;
            this.txt_input.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbl_input_strength
            // 
            this.lbl_input_strength.AutoSize = true;
            this.lbl_input_strength.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lbl_input_strength.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_input_strength.Location = new System.Drawing.Point(19, 33);
            this.lbl_input_strength.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_input_strength.Name = "lbl_input_strength";
            this.lbl_input_strength.Size = new System.Drawing.Size(188, 18);
            this.lbl_input_strength.TabIndex = 44;
            this.lbl_input_strength.Text = "Compressive Strength (psi)";
            // 
            // txt_ratio
            // 
            this.txt_ratio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ratio.Location = new System.Drawing.Point(251, 70);
            this.txt_ratio.Name = "txt_ratio";
            this.txt_ratio.Size = new System.Drawing.Size(133, 24);
            this.txt_ratio.TabIndex = 52;
            this.txt_ratio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbl_ratio
            // 
            this.lbl_ratio.AutoSize = true;
            this.lbl_ratio.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lbl_ratio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ratio.Location = new System.Drawing.Point(19, 75);
            this.lbl_ratio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ratio.Name = "lbl_ratio";
            this.lbl_ratio.Size = new System.Drawing.Size(206, 18);
            this.lbl_ratio.TabIndex = 51;
            this.lbl_ratio.Text = "Cylinder / Cube Strength Ratio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(392, 35);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 18);
            this.label2.TabIndex = 50;
            this.label2.Text = "psi";
            // 
            // txt_output
            // 
            this.txt_output.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_output.Location = new System.Drawing.Point(251, 35);
            this.txt_output.Name = "txt_output";
            this.txt_output.Size = new System.Drawing.Size(133, 24);
            this.txt_output.TabIndex = 49;
            this.txt_output.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbl_output_strength
            // 
            this.lbl_output_strength.AutoSize = true;
            this.lbl_output_strength.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lbl_output_strength.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_output_strength.Location = new System.Drawing.Point(19, 40);
            this.lbl_output_strength.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_output_strength.Name = "lbl_output_strength";
            this.lbl_output_strength.Size = new System.Drawing.Size(188, 18);
            this.lbl_output_strength.TabIndex = 48;
            this.lbl_output_strength.Text = "Compressive Strength (psi)";
            // 
            // bttn_Convert
            // 
            this.bttn_Convert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttn_Convert.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bttn_Convert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_Convert.Location = new System.Drawing.Point(309, 184);
            this.bttn_Convert.Margin = new System.Windows.Forms.Padding(4);
            this.bttn_Convert.Name = "bttn_Convert";
            this.bttn_Convert.Size = new System.Drawing.Size(153, 31);
            this.bttn_Convert.TabIndex = 50;
            this.bttn_Convert.Text = "Convert";
            this.bttn_Convert.UseVisualStyleBackColor = true;
            this.bttn_Convert.Click += new System.EventHandler(this.Calculate);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(476, 354);
            this.Controls.Add(this.bttn_Convert);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CCSConvert (Cylinder-Cube Strength Converter)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_main_FormClosing);
            this.Load += new System.EventHandler(this.frm_main_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rad_Cylinder_to_Cube;
        private System.Windows.Forms.RadioButton rad_Cube_To_Cylinder;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disclaimerToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem referencesToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_input;
        private System.Windows.Forms.Label lbl_input_strength;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_ratio;
        private System.Windows.Forms.Label lbl_ratio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_output;
        private System.Windows.Forms.Label lbl_output_strength;
        private System.Windows.Forms.Button bttn_Convert;
    }
}

