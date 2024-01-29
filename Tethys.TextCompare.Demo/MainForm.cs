// ---------------------------------------------------------------------------
// <copyright file="MainForm.cs" company="Tethys">
//   Copyright (C) 2021-2024 T. Graf
// </copyright>
//
// Licensed under the Apache License, Version 2.0.
// SPDX-License-Identifier: Apache-2.0
//
// Unless required by applicable law or agreed to in writing,
// software distributed under the License is distributed on an
// "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND,
// either express or implied.
// ---------------------------------------------------------------------------

namespace Tethys.TextCompare.Demo
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Windows.Forms;
    using AbrarJahin.DiffMatchPatch;
    using Tethys.Logging;

    /// <summary>
    /// Main form of the application.
    /// </summary>
    /// <seealso cref="Form" />
    public partial class MainForm : Form
    {
        #region PRIVATE PROPERTIES
        /// <summary>
        /// The logger for this class.
        /// </summary>
        private static ILog log;

        /// <summary>
        /// The left side text.
        /// </summary>
        private string leftSide;

        /// <summary>
        /// The right side text.
        /// </summary>
        private string rightSide;

        /// <summary>
        /// The 'first activation' flag.
        /// </summary>
        private bool firstActivation;

        /// <summary>
        /// The 'peers added' flag.
        /// </summary>
        private bool peersAdded;
        #endregion // PRIVATE PROPERTIES

        //// ---------------------------------------------------------------------

        #region CONSTRUCTION
        /// <summary>
        /// Initializes a new instance of the <see cref="MainForm"/> class.
        /// </summary>
        public MainForm()
        {
            this.InitializeComponent();
            this.ConfigureLogging();
            this.firstActivation = true;
            this.peersAdded = false;
        } // MainForm()
        #endregion // CONSTRUCTION

        //// ---------------------------------------------------------------------

        #region UI HANDLING
        /// <summary>
        /// Handles the Load event of the MainForm control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing
        /// the event data.</param>
        private void MainFormLoad(object sender, EventArgs e)
        {
            this.InitializeIconDisplay();

#if DEBUG
            this.splitContainer.Panel2Collapsed = false;
#else
            this.splitContainer.Panel2Collapsed = true;
#endif
            this.chkAdded.Checked = true;
            this.chkRemoved.Checked = true;
            this.chkIdentical.Checked = true;

            log.Info("Ready.");
        } // MainFormLoad()

        /// <summary>
        /// Handles the Activated event of the MainForm control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void MainFormActivated(object sender, EventArgs e)
        {
            if (!this.firstActivation)
            {
                return;
            } // if

            this.GetInputAndCompare();
        } // MainFormActivated()

        /// <summary>
        /// Handles the FormClosing event of the MainForm control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="FormClosingEventArgs"/> instance
        /// containing the event data.</param>
        private void MainFormFormClosing(object sender, FormClosingEventArgs e)
        {
        } // MainFormFormClosing()

        /// <summary>
        /// Handles the CheckedChanged event of the chkIdentical control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnTypeCheckedChanged(object sender, EventArgs e)
        {
            this.CompareTexts();
        } // OnTypeCheckedChanged()

        #region MENU
        /// <summary>
        /// Handles the Click event of the menuFileSelectInput control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void MenuFileSelectInputClick(object sender, EventArgs e)
        {
            this.GetInputAndCompare();
        } // MenuFileSelectInputClick()

        /// <summary>
        /// Handles the Click event of the menuFileExit control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void MenuFileExitClick(object sender, EventArgs e)
        {
            this.Close();
        } // MenuFileExitClick()

        /// <summary>
        /// Handles the Click event of the menuHiddenDebugTrace control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void MenuHiddenDebugTraceClick(object sender, EventArgs e)
        {
            this.splitContainer.Panel2Collapsed = !this.splitContainer.Panel2Collapsed;
        } // MenuHiddenDebugTraceClick()
        #endregion // MENU
        #endregion // UI HANDLING

        //// ---------------------------------------------------------------------

        #region PRIVATE METHODS
        /// <summary>
        /// Gets the input and compare.
        /// </summary>
        private void GetInputAndCompare()
        {
            var dlg = new InputSelectionForm();
            if (dlg.ShowDialog(this) != DialogResult.OK)
            {
                this.Close();
            } // if

            this.leftSide = dlg.LeftSide;
            this.rightSide = dlg.RightSide;
            this.firstActivation = false;

            this.CompareTexts();

            if (!this.peersAdded)
            {
                this.diffRight.AddPeer(this.diffLeft);
                this.diffLeft.AddPeer(this.diffRight);
                this.peersAdded = true;
            } // if
        } // GetInputAndCompare()

        /// <summary>
        /// Appends text in the given color.
        /// </summary>
        /// <param name="rtfControl">The RTF control.</param>
        /// <param name="text">The text.</param>
        /// <param name="color">The color.</param>
        private static void AppendText(RichTextBox rtfControl, string text, Color color)
        {
            rtfControl.SelectionStart = rtfControl.TextLength;
            rtfControl.SelectionLength = 0;

            rtfControl.SelectionColor = color;
            rtfControl.AppendText(text);
            rtfControl.SelectionColor = rtfControl.ForeColor;
        } // AppendText()

        /// <summary>
        /// Compares the texts.
        /// </summary>
        private void CompareTexts()
        {
            if (this.diffLeft.Rtf.IsDisposed)
            {
                return;
            } // if

            this.diffLeft.Rtf.Clear();
            this.diffRight.Rtf.Clear();

            var sameChars = 0;
            var differentChars = 0;

            var left = this.leftSide;
            if (string.IsNullOrEmpty(this.leftSide))
            {
                this.diffLeft.Rtf.AppendText("<empty>");
                left = string.Empty;
            } // if

            var right = this.rightSide;
            if (string.IsNullOrEmpty(this.rightSide))
            {
                this.diffRight.Rtf.AppendText("<empty>");
                right = string.Empty;
            } // if

            this.diffLeft.ItemSize = $"{left.Length} characters";
            this.diffRight.ItemSize = $"{right.Length} characters";

            var d = new diff_match_patch();
            var diffs = d.diff_main(left, right);

            foreach (var diff in diffs)
            {
                if ((diff.operation == Operation.INSERT) && this.chkAdded.Checked)
                {
                    log.Debug($"Insert: '{diff.text}'");
                    AppendText(this.diffRight.Rtf, diff.text, Color.Blue);
                    differentChars += diff.text.Length;
                } // if

                if ((diff.operation == Operation.DELETE) && this.chkRemoved.Checked)
                {
                    log.Debug($"Delete: '{diff.text}'");
                    AppendText(this.diffLeft.Rtf, diff.text, Color.Red);
                    differentChars += diff.text.Length;
                } // if

                if ((diff.operation == Operation.EQUAL) && this.chkIdentical.Checked)
                {
                    log.Debug($"Same: '{diff.text}'");
                    this.diffLeft.Rtf.AppendText(diff.text);
                    this.diffRight.Rtf.AppendText(diff.text);
                    sameChars += diff.text.Length;
                } // if
            } // foreach

            double similarity = left.Length;
            if ((left.Length == sameChars) && (differentChars > 0))
            {
                similarity = left.Length + differentChars;
            } // if

            similarity = sameChars / similarity;
            this.lblSimilarity.Text = $"Similarity = {similarity:F2}%";
        } // CompareTexts()

        /// <summary>
        /// Initializes the icon display.
        /// </summary>
        private void InitializeIconDisplay()
        {
            var assem = this.GetType().Assembly;
            var stream = assem.GetManifestResourceStream(
                "SimpleTextCompare.SimpleTextCompare.ico");
            if (stream != null)
            {
                this.Icon = new Icon(stream, 32, 32);
            } // if
        } // InitializeIconDisplay()

        /// <summary>
        /// Configures the logging.
        /// </summary>
        private void ConfigureLogging()
        {
            this.rtfLogView.AddAtTail = true;
#if !DEBUG
            this.rtfLogView.MaxLogLength = 10000;
#endif
            this.rtfLogView.ShowDebugEvents = true;

            var settings = new Dictionary<string, string>();
            settings.Add("AddTime", "false");
            settings.Add("AddLevel", "false");
            LogManager.Adapter = new LogViewFactoryAdapter(this.rtfLogView, settings);
            log = LogManager.GetLogger(typeof(MainForm));
        } // ConfigureLogging()
        #endregion // PRIVATE METHODS
    }
}
