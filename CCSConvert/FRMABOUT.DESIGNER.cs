namespace CCSConvert
{
    partial class frmAbout
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
            this.lbl_program_title = new System.Windows.Forms.Label();
            this.lbl_program_description = new System.Windows.Forms.Label();
            this.bttnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_program_title
            // 
            this.lbl_program_title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_program_title.Font = new System.Drawing.Font("Century Gothic", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_program_title.ForeColor = System.Drawing.Color.Blue;
            this.lbl_program_title.Location = new System.Drawing.Point(10, 9);
            this.lbl_program_title.Name = "lbl_program_title";
            this.lbl_program_title.Size = new System.Drawing.Size(519, 31);
            this.lbl_program_title.TabIndex = 0;
            this.lbl_program_title.Text = "<Program Title>";
            this.lbl_program_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_program_description
            // 
            this.lbl_program_description.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_program_description.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_program_description.Location = new System.Drawing.Point(10, 40);
            this.lbl_program_description.Name = "lbl_program_description";
            this.lbl_program_description.Size = new System.Drawing.Size(519, 64);
            this.lbl_program_description.TabIndex = 2;
            this.lbl_program_description.Text = "<Program_Description>";
            this.lbl_program_description.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bttnOK
            // 
            this.bttnOK.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.bttnOK.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bttnOK.Location = new System.Drawing.Point(211, 145);
            this.bttnOK.Name = "bttnOK";
            this.bttnOK.Size = new System.Drawing.Size(120, 30);
            this.bttnOK.TabIndex = 8;
            this.bttnOK.Text = "OK";
            this.bttnOK.UseVisualStyleBackColor = true;
            this.bttnOK.Click += new System.EventHandler(this.bttnOK_Click);
            // 
            // frmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.CancelButton = this.bttnOK;
            this.ClientSize = new System.Drawing.Size(543, 198);
            this.Controls.Add(this.bttnOK);
            this.Controls.Add(this.lbl_program_description);
            this.Controls.Add(this.lbl_program_title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About...";
            this.Load += new System.EventHandler(this.frmAbout_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_program_title;
        private System.Windows.Forms.Label lbl_program_description;
        private System.Windows.Forms.Button bttnOK;
    }
}