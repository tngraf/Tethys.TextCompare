
namespace Tethys.TextCompare.Demo
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.rtfLogView = new Tethys.Logging.Controls.RtfLogView();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.splitContainerVertical = new System.Windows.Forms.SplitContainer();
            this.diffLeft = new Tethys.TextCompare.DiffFileControl();
            this.diffRight = new Tethys.TextCompare.DiffFileControl();
            this.panelDescription = new System.Windows.Forms.Panel();
            this.chkRemoved = new System.Windows.Forms.CheckBox();
            this.chkAdded = new System.Windows.Forms.CheckBox();
            this.chkIdentical = new System.Windows.Forms.CheckBox();
            this.lblSimilarity = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileSelectInput = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHidden = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHiddenDebugTrace = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerVertical)).BeginInit();
            this.splitContainerVertical.Panel1.SuspendLayout();
            this.splitContainerVertical.Panel2.SuspendLayout();
            this.splitContainerVertical.SuspendLayout();
            this.panelDescription.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            //
            // rtfLogView
            //
            this.rtfLogView.AddAtTail = true;
            this.rtfLogView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtfLogView.LabelText = "Status:";
            this.rtfLogView.Location = new System.Drawing.Point(4, 3);
            this.rtfLogView.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rtfLogView.MaxLogLength = -1;
            this.rtfLogView.Name = "rtfLogView";
            this.rtfLogView.Padding = new System.Windows.Forms.Padding(3);
            this.rtfLogView.ShowDebugEvents = false;
            this.rtfLogView.Size = new System.Drawing.Size(1080, 120);
            this.rtfLogView.TabIndex = 0;
            this.rtfLogView.TextColor = System.Drawing.Color.Black;
            //
            // splitContainer
            //
            this.splitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer.Location = new System.Drawing.Point(0, 27);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            //
            // splitContainer.Panel1
            //
            this.splitContainer.Panel1.Controls.Add(this.splitContainerVertical);
            this.splitContainer.Panel1.Controls.Add(this.panelDescription);
            //
            // splitContainer.Panel2
            //
            this.splitContainer.Panel2.Controls.Add(this.rtfLogView);
            this.splitContainer.Size = new System.Drawing.Size(1088, 565);
            this.splitContainer.SplitterDistance = 435;
            this.splitContainer.TabIndex = 1;
            //
            // splitContainerVertical
            //
            this.splitContainerVertical.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainerVertical.Location = new System.Drawing.Point(0, 0);
            this.splitContainerVertical.Name = "splitContainerVertical";
            //
            // splitContainerVertical.Panel1
            //
            this.splitContainerVertical.Panel1.Controls.Add(this.diffLeft);
            //
            // splitContainerVertical.Panel2
            //
            this.splitContainerVertical.Panel2.Controls.Add(this.diffRight);
            this.splitContainerVertical.Size = new System.Drawing.Size(1088, 397);
            this.splitContainerVertical.SplitterDistance = 544;
            this.splitContainerVertical.TabIndex = 1;
            //
            // diffLeft
            //
            this.diffLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.diffLeft.ItemSize = "<Size>";
            this.diffLeft.Location = new System.Drawing.Point(0, 0);
            this.diffLeft.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.diffLeft.Name = "diffLeft";
            this.diffLeft.Size = new System.Drawing.Size(544, 397);
            this.diffLeft.TabIndex = 0;
            //
            // diffRight
            //
            this.diffRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.diffRight.ItemSize = "<Size>";
            this.diffRight.Location = new System.Drawing.Point(0, 0);
            this.diffRight.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.diffRight.Name = "diffRight";
            this.diffRight.Size = new System.Drawing.Size(540, 397);
            this.diffRight.TabIndex = 0;
            //
            // panelDescription
            //
            this.panelDescription.Controls.Add(this.chkRemoved);
            this.panelDescription.Controls.Add(this.chkAdded);
            this.panelDescription.Controls.Add(this.chkIdentical);
            this.panelDescription.Controls.Add(this.lblSimilarity);
            this.panelDescription.Controls.Add(this.label3);
            this.panelDescription.Controls.Add(this.panel3);
            this.panelDescription.Controls.Add(this.label2);
            this.panelDescription.Controls.Add(this.panel2);
            this.panelDescription.Controls.Add(this.label1);
            this.panelDescription.Controls.Add(this.panel1);
            this.panelDescription.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelDescription.Location = new System.Drawing.Point(0, 400);
            this.panelDescription.Name = "panelDescription";
            this.panelDescription.Size = new System.Drawing.Size(1088, 35);
            this.panelDescription.TabIndex = 0;
            //
            // chkRemoved
            //
            this.chkRemoved.AutoSize = true;
            this.chkRemoved.Location = new System.Drawing.Point(359, 13);
            this.chkRemoved.Name = "chkRemoved";
            this.chkRemoved.Size = new System.Drawing.Size(15, 14);
            this.chkRemoved.TabIndex = 10;
            this.chkRemoved.UseVisualStyleBackColor = true;
            this.chkRemoved.CheckedChanged += new System.EventHandler(this.OnTypeCheckedChanged);
            //
            // chkAdded
            //
            this.chkAdded.AutoSize = true;
            this.chkAdded.Location = new System.Drawing.Point(143, 14);
            this.chkAdded.Name = "chkAdded";
            this.chkAdded.Size = new System.Drawing.Size(15, 14);
            this.chkAdded.TabIndex = 9;
            this.chkAdded.UseVisualStyleBackColor = true;
            this.chkAdded.CheckedChanged += new System.EventHandler(this.OnTypeCheckedChanged);
            //
            // chkIdentical
            //
            this.chkIdentical.AutoSize = true;
            this.chkIdentical.Location = new System.Drawing.Point(7, 13);
            this.chkIdentical.Name = "chkIdentical";
            this.chkIdentical.Size = new System.Drawing.Size(15, 14);
            this.chkIdentical.TabIndex = 8;
            this.chkIdentical.UseVisualStyleBackColor = true;
            this.chkIdentical.CheckedChanged += new System.EventHandler(this.OnTypeCheckedChanged);
            //
            // lblSimilarity
            //
            this.lblSimilarity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSimilarity.Location = new System.Drawing.Point(1067, 403);
            this.lblSimilarity.Name = "lblSimilarity";
            this.lblSimilarity.Size = new System.Drawing.Size(154, 13);
            this.lblSimilarity.TabIndex = 7;
            this.lblSimilarity.Text = "Similarity x%";
            this.lblSimilarity.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            //
            // label3
            //
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(412, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = " text removed on the right side";
            //
            // panel3
            //
            this.panel3.BackColor = System.Drawing.Color.Red;
            this.panel3.Location = new System.Drawing.Point(380, 13);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(34, 13);
            this.panel3.TabIndex = 5;
            //
            // label2
            //
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "text added on the right side";
            //
            // panel2
            //
            this.panel2.BackColor = System.Drawing.Color.Blue;
            this.panel2.Location = new System.Drawing.Point(164, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(34, 13);
            this.panel2.TabIndex = 3;
            //
            // label1
            //
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "identical text";
            //
            // panel1
            //
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(28, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(34, 13);
            this.panel1.TabIndex = 1;
            //
            // statusStrip
            //
            this.statusStrip.Location = new System.Drawing.Point(0, 595);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1088, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip1";
            //
            // menuStrip
            //
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuHelp,
            this.menuHidden});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1088, 24);
            this.menuStrip.TabIndex = 3;
            this.menuStrip.Text = "menuStrip";
            //
            // menuFile
            //
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFileSelectInput,
            this.toolStripSeparator2,
            this.menuFileExit});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(37, 20);
            this.menuFile.Text = "&File";
            //
            // menuFileSelectInput
            //
            this.menuFileSelectInput.Image = ((System.Drawing.Image)(resources.GetObject("menuFileSelectInput.Image")));
            this.menuFileSelectInput.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuFileSelectInput.Name = "menuFileSelectInput";
            this.menuFileSelectInput.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.menuFileSelectInput.Size = new System.Drawing.Size(179, 22);
            this.menuFileSelectInput.Text = "&Select Input";
            this.menuFileSelectInput.Click += new System.EventHandler(this.MenuFileSelectInputClick);
            //
            // toolStripSeparator2
            //
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(176, 6);
            //
            // menuFileExit
            //
            this.menuFileExit.Name = "menuFileExit";
            this.menuFileExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.menuFileExit.Size = new System.Drawing.Size(179, 22);
            this.menuFileExit.Text = "E&xit";
            this.menuFileExit.Click += new System.EventHandler(this.MenuFileExitClick);
            //
            // menuHidden
            //
            this.menuHidden.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuHiddenDebugTrace});
            this.menuHidden.Name = "menuHidden";
            this.menuHidden.Size = new System.Drawing.Size(58, 20);
            this.menuHidden.Text = "Hidden";
            this.menuHidden.Visible = false;
            //
            // menuHiddenDebugTrace
            //
            this.menuHiddenDebugTrace.Name = "menuHiddenDebugTrace";
            this.menuHiddenDebugTrace.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift)
            | System.Windows.Forms.Keys.D)));
            this.menuHiddenDebugTrace.Size = new System.Drawing.Size(304, 22);
            this.menuHiddenDebugTrace.Text = "Toggle Debug Trace";
            this.menuHiddenDebugTrace.Click += new System.EventHandler(this.MenuHiddenDebugTraceClick);
            //
            // MainForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 617);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.splitContainer);
            this.Name = "MainForm";
            this.Text = "Simple Text Comparer";
            this.Activated += new System.EventHandler(this.MainFormActivated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFormFormClosing);
            this.Load += new System.EventHandler(this.MainFormLoad);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.splitContainerVertical.Panel1.ResumeLayout(false);
            this.splitContainerVertical.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerVertical)).EndInit();
            this.splitContainerVertical.ResumeLayout(false);
            this.panelDescription.ResumeLayout(false);
            this.panelDescription.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Tethys.Logging.Controls.RtfLogView rtfLogView;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.Panel panelDescription;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblSimilarity;
        private System.Windows.Forms.SplitContainer splitContainerVertical;
        private Tethys.TextCompare.DiffFileControl diffLeft;
        private Tethys.TextCompare.DiffFileControl diffRight;
        private System.Windows.Forms.ToolStripMenuItem menuFileSelectInput;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuHelp;
        private System.Windows.Forms.ToolStripMenuItem menuHidden;
        private System.Windows.Forms.ToolStripMenuItem menuFileExit;
        private System.Windows.Forms.ToolStripMenuItem menuHiddenDebugTrace;
        private System.Windows.Forms.CheckBox chkRemoved;
        private System.Windows.Forms.CheckBox chkAdded;
        private System.Windows.Forms.CheckBox chkIdentical;
    }
}

