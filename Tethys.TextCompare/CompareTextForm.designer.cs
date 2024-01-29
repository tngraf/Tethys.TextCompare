namespace Tethys.TextCompare
{
    partial class CompareTextForm
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
            this.splitContainerHorizontal = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblSimilarity = new System.Windows.Forms.Label();
            this.diffLeft = new Tethys.TextCompare.DiffFileControl();
            this.diffRight = new Tethys.TextCompare.DiffFileControl();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerHorizontal)).BeginInit();
            this.splitContainerHorizontal.Panel1.SuspendLayout();
            this.splitContainerHorizontal.Panel2.SuspendLayout();
            this.splitContainerHorizontal.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerHorizontal
            // 
            this.splitContainerHorizontal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainerHorizontal.Location = new System.Drawing.Point(0, 0);
            this.splitContainerHorizontal.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.splitContainerHorizontal.Name = "splitContainerHorizontal";
            // 
            // splitContainerHorizontal.Panel1
            // 
            this.splitContainerHorizontal.Panel1.Controls.Add(this.diffLeft);
            // 
            // splitContainerHorizontal.Panel2
            // 
            this.splitContainerHorizontal.Panel2.Controls.Add(this.diffRight);
            this.splitContainerHorizontal.Size = new System.Drawing.Size(1010, 556);
            this.splitContainerHorizontal.SplitterDistance = 518;
            this.splitContainerHorizontal.SplitterWidth = 6;
            this.splitContainerHorizontal.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(16, 569);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(47, 17);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 569);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "identical text";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(236, 569);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "text added on the right side";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.Color.Blue;
            this.panel2.Location = new System.Drawing.Point(181, 569);
            this.panel2.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(47, 17);
            this.panel2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(491, 569);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = " text removed on the right side";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel3.BackColor = System.Drawing.Color.Red;
            this.panel3.Location = new System.Drawing.Point(436, 569);
            this.panel3.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(47, 17);
            this.panel3.TabIndex = 5;
            // 
            // lblSimilarity
            // 
            this.lblSimilarity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSimilarity.Location = new System.Drawing.Point(783, 569);
            this.lblSimilarity.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblSimilarity.Name = "lblSimilarity";
            this.lblSimilarity.Size = new System.Drawing.Size(210, 17);
            this.lblSimilarity.TabIndex = 7;
            this.lblSimilarity.Text = "Similarity x%";
            this.lblSimilarity.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // diffLeft
            // 
            this.diffLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.diffLeft.ItemName = "";
            this.diffLeft.ItemSize = "<Size>";
            this.diffLeft.Location = new System.Drawing.Point(0, 0);
            this.diffLeft.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.diffLeft.Name = "diffLeft";
            this.diffLeft.Size = new System.Drawing.Size(518, 556);
            this.diffLeft.TabIndex = 0;
            // 
            // diffRight
            // 
            this.diffRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.diffRight.ItemName = "";
            this.diffRight.ItemSize = "<Size>";
            this.diffRight.Location = new System.Drawing.Point(0, 0);
            this.diffRight.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.diffRight.Name = "diffRight";
            this.diffRight.Size = new System.Drawing.Size(486, 556);
            this.diffRight.TabIndex = 0;
            // 
            // CompareTextForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 603);
            this.Controls.Add(this.lblSimilarity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.splitContainerHorizontal);
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Name = "CompareTextForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Compare Licenses";
            this.Load += new System.EventHandler(this.CompareTextFormLoad);
            this.splitContainerHorizontal.Panel1.ResumeLayout(false);
            this.splitContainerHorizontal.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerHorizontal)).EndInit();
            this.splitContainerHorizontal.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainerHorizontal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblSimilarity;
        private DiffFileControl diffLeft;
        private DiffFileControl diffRight;
    }
}