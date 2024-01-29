namespace Tethys.TextCompare
{
    partial class DiffFileControl
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
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.rtf = new Tethys.TextCompare.SynchronizedRichTextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblSize = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // rtf
            // 
            this.rtf.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtf.Location = new System.Drawing.Point(8, 55);
            this.rtf.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.rtf.Name = "rtf";
            this.rtf.ReadOnly = true;
            this.rtf.Size = new System.Drawing.Size(304, 193);
            this.rtf.TabIndex = 1;
            this.rtf.Text = "";
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Location = new System.Drawing.Point(64, 3);
            this.txtName.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(248, 23);
            this.txtName.TabIndex = 2;
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(8, 35);
            this.lblSize.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(43, 15);
            this.lblSize.TabIndex = 3;
            this.lblSize.Text = "<Size>";
            // 
            // DiffFileControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.rtf);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Name = "DiffFileControl";
            this.Size = new System.Drawing.Size(318, 255);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblSize;
        private SynchronizedRichTextBox rtf;
    }
}
