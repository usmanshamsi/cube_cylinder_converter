namespace CCSConvert
{
    partial class frm_disclaimer
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
            this.bttnOK = new System.Windows.Forms.Button();
            this.lbl_program_title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_references_list = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bttnOK
            // 
            this.bttnOK.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bttnOK.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bttnOK.Location = new System.Drawing.Point(212, 412);
            this.bttnOK.Name = "bttnOK";
            this.bttnOK.Size = new System.Drawing.Size(151, 30);
            this.bttnOK.TabIndex = 9;
            this.bttnOK.Text = "OK";
            this.bttnOK.UseVisualStyleBackColor = true;
            // 
            // lbl_program_title
            // 
            this.lbl_program_title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_program_title.Font = new System.Drawing.Font("Century Gothic", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_program_title.ForeColor = System.Drawing.Color.Blue;
            this.lbl_program_title.Location = new System.Drawing.Point(13, 10);
            this.lbl_program_title.Name = "lbl_program_title";
            this.lbl_program_title.Size = new System.Drawing.Size(548, 31);
            this.lbl_program_title.TabIndex = 11;
            this.lbl_program_title.Text = "REFERENCES";
            this.lbl_program_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(548, 23);
            this.label1.TabIndex = 12;
            this.label1.Text = "Following Documents have been used for preparation of this program.";
            // 
            // lbl_references_list
            // 
            this.lbl_references_list.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_references_list.Location = new System.Drawing.Point(13, 90);
            this.lbl_references_list.Multiline = true;
            this.lbl_references_list.Name = "lbl_references_list";
            this.lbl_references_list.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.lbl_references_list.Size = new System.Drawing.Size(548, 304);
            this.lbl_references_list.TabIndex = 13;
            // 
            // frm_disclaimer
            // 
            this.AcceptButton = this.bttnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(574, 455);
            this.Controls.Add(this.lbl_references_list);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_program_title);
            this.Controls.Add(this.bttnOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_disclaimer";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Disclaimer";
            this.Load += new System.EventHandler(this.frm_disclaimer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttnOK;
        private System.Windows.Forms.Label lbl_program_title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lbl_references_list;
    }
}