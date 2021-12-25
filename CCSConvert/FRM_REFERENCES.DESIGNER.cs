namespace CCSConvert
{
    partial class frm_references
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
            this.lbl_ref = new System.Windows.Forms.Label();
            this.txt_reference_list = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // bttnOK
            // 
            this.bttnOK.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bttnOK.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bttnOK.Location = new System.Drawing.Point(210, 397);
            this.bttnOK.Name = "bttnOK";
            this.bttnOK.Size = new System.Drawing.Size(151, 30);
            this.bttnOK.TabIndex = 9;
            this.bttnOK.Text = "OK";
            this.bttnOK.UseVisualStyleBackColor = true;
            // 
            // lbl_ref
            // 
            this.lbl_ref.Font = new System.Drawing.Font("Century Gothic", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ref.ForeColor = System.Drawing.Color.Blue;
            this.lbl_ref.Location = new System.Drawing.Point(13, 10);
            this.lbl_ref.Name = "lbl_ref";
            this.lbl_ref.Size = new System.Drawing.Size(548, 31);
            this.lbl_ref.TabIndex = 11;
            this.lbl_ref.Text = "REFERENCES";
            this.lbl_ref.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_reference_list
            // 
            this.txt_reference_list.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_reference_list.BackColor = System.Drawing.SystemColors.Window;
            this.txt_reference_list.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_reference_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_reference_list.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_reference_list.Location = new System.Drawing.Point(17, 44);
            this.txt_reference_list.Name = "txt_reference_list";
            this.txt_reference_list.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txt_reference_list.Size = new System.Drawing.Size(544, 347);
            this.txt_reference_list.TabIndex = 12;
            this.txt_reference_list.Text = "1-\tBook:\tProperties of Concrete\n\tAuthor:\tA M Neville\n\tEdition:\tSecond Edition\n\tCh" +
                "apter:\t8\n\tTable:\t8.2\n";
            // 
            // frm_references
            // 
            this.AcceptButton = this.bttnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(574, 440);
            this.Controls.Add(this.txt_reference_list);
            this.Controls.Add(this.lbl_ref);
            this.Controls.Add(this.bttnOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_references";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Disclaimer";
            this.Load += new System.EventHandler(this.frm_disclaimer_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bttnOK;
        private System.Windows.Forms.Label lbl_ref;
        private System.Windows.Forms.RichTextBox txt_reference_list;
    }
}