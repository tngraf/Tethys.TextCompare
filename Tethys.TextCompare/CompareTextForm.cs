// ---------------------------------------------------------------------------
// <copyright file="CompareTextForm.cs" company="Tethys">
//   Copyright (C) 2020-2024 T. Graf
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

////#define SHOW_DIFF_IN_LOG

namespace Tethys.TextCompare
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;
    using AbrarJahin.DiffMatchPatch;
#if SHOW_DIFF_IN_LOG
    using Tethys.Logging;
#endif

    /// <summary>
    /// A simple diff viewer for texts.
    /// </summary>
    /// <seealso cref="Form" />
    public partial class CompareTextForm : Form
    {
#if SHOW_DIFF_IN_LOG
        /// <summary>
        /// The logger for this class.
        /// </summary>
        private static readonly ILog Log = LogManager.GetLogger(typeof(CompareTextForm));
#endif

        #region PUBLIC PROPERTIES
        /// <summary>
        /// Gets or sets the left side text.
        /// </summary>
        public string LeftSide { get; set; }

        /// <summary>
        /// Gets or sets the right side text.
        /// </summary>
        public string RightSide { get; set; }

        /// <summary>
        /// Gets or sets the left side name.
        /// </summary>
        public string LeftSideName
        {
            get => this.diffLeft.ItemName;

            set => this.diffLeft.ItemName = value;
        }

        /// <summary>
        /// Gets or sets the right side name.
        /// </summary>
        public string RightSideName
        {
            get => this.diffRight.ItemName;

            set => this.diffRight.ItemName = value;
        }
        #endregion // PUBLIC PROPERTIES

        //// ---------------------------------------------------------------------

        #region CONSTRUCTION
        /// <summary>
        /// Initializes a new instance of the <see cref="CompareTextForm"/> class.
        /// </summary>
        public CompareTextForm()
        {
            this.InitializeComponent();
        } // CompareTextForm()
        #endregion // CONSTRUCTION

        //// ---------------------------------------------------------------------

        #region UI HANDLING
        /// <summary>
        /// Handles the Load event of the CompareTextForm control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void CompareTextFormLoad(object sender, EventArgs e)
        {
            this.CompareTexts();

            this.diffRight.AddPeer(this.diffLeft);
            this.diffLeft.AddPeer(this.diffRight);
        } // CompareTextFormLoad()
        #endregion // UI HANDLING

        //// ---------------------------------------------------------------------

        #region PRIVATE METHODS
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
            var sameChars = 0;
            var differentChars = 0;

            var left = this.LeftSide;
            if (string.IsNullOrEmpty(this.LeftSide))
            {
                this.diffLeft.Rtf.AppendText("<empty>");
                left = string.Empty;
            } // if

            var right = this.RightSide;
            if (string.IsNullOrEmpty(this.RightSide))
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
                if (diff.operation == Operation.INSERT)
                {
#if SHOW_DIFF_IN_LOG
                    Log.Debug($"Insert: '{diff.text}'");
#endif
                    AppendText(this.diffRight.Rtf, diff.text, Color.Blue);
                    differentChars += diff.text.Length;
                } // if

                if (diff.operation == Operation.DELETE)
                {
#if SHOW_DIFF_IN_LOG
                    Log.Debug($"Delete: '{diff.text}'");
#endif
                    AppendText(this.diffLeft.Rtf, diff.text, Color.Red);
                    differentChars += diff.text.Length;
                } // if

                if (diff.operation == Operation.EQUAL)
                {
#if SHOW_DIFF_IN_LOG
                    Log.Debug($"Same: '{diff.text}'");
#endif
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
#endregion // PRIVATE METHODS
    } // CompareTextForm()
}
