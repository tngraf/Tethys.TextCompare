
namespace Tethys.TextCompare.Demo
{
    partial class InputSelectionForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCompare = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupLeft = new System.Windows.Forms.GroupBox();
            this.btnPasteTextLeft = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPreviewLeft = new System.Windows.Forms.TextBox();
            this.btnBrowseLeft = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPasteTextRight = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPreviewRight = new System.Windows.Forms.TextBox();
            this.btnBrowseRight = new System.Windows.Forms.Button();
            this.groupLeft.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCompare
            // 
            this.btnCompare.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCompare.Location = new System.Drawing.Point(421, 269);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(120, 40);
            this.btnCompare.TabIndex = 0;
            this.btnCompare.Text = "Compare";
            this.btnCompare.UseVisualStyleBackColor = true;
            this.btnCompare.Click += new System.EventHandler(this.BtnCompareClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select the input for the left and right side of the comparison.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(524, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Browse for a file, drag&&drop a file or paste plain text. Then press Compare to s" +
    "tart the comparison.";
            // 
            // groupLeft
            // 
            this.groupLeft.Controls.Add(this.btnPasteTextLeft);
            this.groupLeft.Controls.Add(this.label3);
            this.groupLeft.Controls.Add(this.txtPreviewLeft);
            this.groupLeft.Controls.Add(this.btnBrowseLeft);
            this.groupLeft.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupLeft.Location = new System.Drawing.Point(12, 60);
            this.groupLeft.Name = "groupLeft";
            this.groupLeft.Size = new System.Drawing.Size(260, 200);
            this.groupLeft.TabIndex = 3;
            this.groupLeft.TabStop = false;
            this.groupLeft.Text = " Left Side";
            // 
            // btnPasteTextLeft
            // 
            this.btnPasteTextLeft.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPasteTextLeft.Location = new System.Drawing.Point(91, 22);
            this.btnPasteTextLeft.Name = "btnPasteTextLeft";
            this.btnPasteTextLeft.Size = new System.Drawing.Size(75, 23);
            this.btnPasteTextLeft.TabIndex = 7;
            this.btnPasteTextLeft.Text = "Paste Text";
            this.btnPasteTextLeft.UseVisualStyleBackColor = true;
            this.btnPasteTextLeft.Click += new System.EventHandler(this.BtnPasteTextLeftClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(10, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Preview";
            // 
            // txtPreviewLeft
            // 
            this.txtPreviewLeft.AllowDrop = true;
            this.txtPreviewLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPreviewLeft.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPreviewLeft.Location = new System.Drawing.Point(10, 76);
            this.txtPreviewLeft.Multiline = true;
            this.txtPreviewLeft.Name = "txtPreviewLeft";
            this.txtPreviewLeft.ReadOnly = true;
            this.txtPreviewLeft.Size = new System.Drawing.Size(244, 122);
            this.txtPreviewLeft.TabIndex = 5;
            this.txtPreviewLeft.DragDrop += new System.Windows.Forms.DragEventHandler(this.OnTxtPreviewLeftDragDrop);
            this.txtPreviewLeft.DragEnter += new System.Windows.Forms.DragEventHandler(this.OnPreviewLeftDragEnter);
            // 
            // btnBrowseLeft
            // 
            this.btnBrowseLeft.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBrowseLeft.Location = new System.Drawing.Point(10, 22);
            this.btnBrowseLeft.Name = "btnBrowseLeft";
            this.btnBrowseLeft.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseLeft.TabIndex = 4;
            this.btnBrowseLeft.Text = "Browse";
            this.btnBrowseLeft.UseVisualStyleBackColor = true;
            this.btnBrowseLeft.Click += new System.EventHandler(this.BtnBrowseLeftClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPasteTextRight);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtPreviewRight);
            this.groupBox1.Controls.Add(this.btnBrowseRight);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(278, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 200);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Right Side";
            // 
            // btnPasteTextRight
            // 
            this.btnPasteTextRight.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPasteTextRight.Location = new System.Drawing.Point(91, 22);
            this.btnPasteTextRight.Name = "btnPasteTextRight";
            this.btnPasteTextRight.Size = new System.Drawing.Size(75, 23);
            this.btnPasteTextRight.TabIndex = 8;
            this.btnPasteTextRight.Text = "Paste Text";
            this.btnPasteTextRight.UseVisualStyleBackColor = true;
            this.btnPasteTextRight.Click += new System.EventHandler(this.BtnPasteTextRightClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(10, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Preview";
            // 
            // txtPreviewRight
            // 
            this.txtPreviewRight.AllowDrop = true;
            this.txtPreviewRight.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPreviewRight.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPreviewRight.Location = new System.Drawing.Point(10, 76);
            this.txtPreviewRight.Multiline = true;
            this.txtPreviewRight.Name = "txtPreviewRight";
            this.txtPreviewRight.ReadOnly = true;
            this.txtPreviewRight.Size = new System.Drawing.Size(244, 118);
            this.txtPreviewRight.TabIndex = 5;
            this.txtPreviewRight.DragDrop += new System.Windows.Forms.DragEventHandler(this.OnTxtPreviewRightDragDrop);
            this.txtPreviewRight.DragEnter += new System.Windows.Forms.DragEventHandler(this.OnPreviewRightDragEnter);
            // 
            // btnBrowseRight
            // 
            this.btnBrowseRight.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBrowseRight.Location = new System.Drawing.Point(10, 22);
            this.btnBrowseRight.Name = "btnBrowseRight";
            this.btnBrowseRight.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseRight.TabIndex = 4;
            this.btnBrowseRight.Text = "Browse";
            this.btnBrowseRight.UseVisualStyleBackColor = true;
            this.btnBrowseRight.Click += new System.EventHandler(this.BtnBrowseRightClick);
            // 
            // InputSelectionForm
            // 
            this.AcceptButton = this.btnCompare;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 321);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupLeft);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCompare);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InputSelectionForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Select Input";
            this.Load += new System.EventHandler(this.InputSelectionFormLoad);
            this.groupLeft.ResumeLayout(false);
            this.groupLeft.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCompare;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupLeft;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPreviewLeft;
        private System.Windows.Forms.Button btnBrowseLeft;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPreviewRight;
        private System.Windows.Forms.Button btnBrowseRight;
        private System.Windows.Forms.Button btnPasteTextLeft;
        private System.Windows.Forms.Button btnPasteTextRight;
    }
}