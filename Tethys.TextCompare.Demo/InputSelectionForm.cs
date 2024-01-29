// ---------------------------------------------------------------------------
// <copyright file="InputSelectionForm.cs" company="Tethys">
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
    using System.IO;
    using System.Windows.Forms;
    using Tethys.Logging;

    /// <summary>
    /// Dialog to select the data to be compared.
    /// </summary>
    public partial class InputSelectionForm : Form
    {
        #region PRIVATE PROPERTIES
        /// <summary>
        /// The maximum pre view length.
        /// </summary>
        private const int MaxPreViewLength = 1000;

        /// <summary>
        /// The logger for this class.
        /// </summary>
        private static readonly ILog Log = LogManager.GetLogger(typeof(InputSelectionForm));
        #endregion // PRIVATE PROPERTIES

        //// ---------------------------------------------------------------------

        #region PUBLIC PROPERTIES
        /// <summary>
        /// Gets or sets the left side text.
        /// </summary>
        public string LeftSide { get; set; }

        /// <summary>
        /// Gets or sets the right side text.
        /// </summary>
        public string RightSide { get; set; }
        #endregion // PUBLIC PROPERTIES

        //// ---------------------------------------------------------------------

        #region CONSTRUCTION
        /// <summary>
        /// Initializes a new instance of the <see cref="InputSelectionForm"/> class.
        /// </summary>
        public InputSelectionForm()
        {
            this.InitializeComponent();
        } // InputSelectionForm()
        #endregion // CONSTRUCTION

        //// ---------------------------------------------------------------------

        #region UI METHODS
        /// <summary>
        /// Handles the Load event of the InputSelectionForm control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void InputSelectionFormLoad(object sender, EventArgs e)
        {
        } // InputSelectionFormLoad()

        /// <summary>
        /// Handles the Click event of the btnBrowseLeft control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void BtnBrowseLeftClick(object sender, EventArgs e)
        {
            var file = this.BrowseForFile();
            if (string.IsNullOrEmpty(file))
            {
                return;
            } // if

            this.LoadLeftSideFile(file);
        } // BtnBrowseLeftClick()

        /// <summary>
        /// Handles the DragEnter event of the txtPreviewLeft control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DragEventArgs"/> instance containing the event data.</param>
        private void OnPreviewLeftDragEnter(object sender, DragEventArgs e)
        {
            if (e.Data == null)
            {
                return;
            } // if

            e.Effect = e.Data.GetDataPresent(DataFormats.FileDrop)
                ? DragDropEffects.Copy : DragDropEffects.None;
        } // OnPreviewLeftDragEnter()

        /// <summary>
        /// Handles the DragDrop event of the txtPreviewLeft control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DragEventArgs"/> instance containing the event data.</param>
        private void OnTxtPreviewLeftDragDrop(object sender, DragEventArgs e)
        {
            if (e.Data == null)
            {
                return;
            } // if

            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                var files = (string[])e.Data.GetData(DataFormats.FileDrop);
                this.LoadLeftSideFile(files[0]);
                return;
            } // if

            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                this.LeftSide = (string)e.Data.GetData(DataFormats.Text);
                this.ShowPreviewLeftSide();

                return;
            } // if

            Log.Warn("Dropped data can't get processed!");
        } // OnTxtPreviewLeftDragDrop()

        /// <summary>
        /// Handles the Click event of the btnPasteTextLeft control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void BtnPasteTextLeftClick(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText(TextDataFormat.Text))
            {
                this.LeftSide = Clipboard.GetText(TextDataFormat.Text);
                this.ShowPreviewLeftSide();
                return;
            } // if

            Log.Warn("Clipboard does not contain plain text!!");
        } // BtnPasteTextLeftClick()

        /// <summary>
        /// Handles the Click event of the btnBrowseRight control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void BtnBrowseRightClick(object sender, EventArgs e)
        {
            var file = this.BrowseForFile();
            if (string.IsNullOrEmpty(file))
            {
                return;
            } // if

            this.LoadRightSideFile(file);
        } // BtnBrowseRightClick()

        /// <summary>
        /// Handles the DragEnter event of the txtPreviewRight control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DragEventArgs"/> instance containing the event data.</param>
        private void OnPreviewRightDragEnter(object sender, DragEventArgs e)
        {
            if (e.Data == null)
            {
                return;
            } // if

            e.Effect = e.Data.GetDataPresent(DataFormats.FileDrop)
                ? DragDropEffects.Copy : DragDropEffects.None;
        } // OnPreviewLeftDragEnter()

        /// <summary>
        /// Handles the DragDrop event of the txtPreviewRight control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DragEventArgs"/> instance containing the event data.</param>
        private void OnTxtPreviewRightDragDrop(object sender, DragEventArgs e)
        {
            if (e.Data == null)
            {
                return;
            } // if

            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                var files = (string[])e.Data.GetData(DataFormats.FileDrop);
                this.LoadRightSideFile(files[0]);
                return;
            } // if

            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                this.LeftSide = (string)e.Data.GetData(DataFormats.Text);
                this.ShowPreviewRightSide();

                return;
            } // if

            Log.Warn("Dropped data can't get processed!");
        } // OnTxtPreviewLeftDragDrop()

        /// <summary>
        /// Handles the Click event of the btnPasteTextRight control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void BtnPasteTextRightClick(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText(TextDataFormat.Text))
            {
                this.RightSide = Clipboard.GetText(TextDataFormat.Text);
                this.ShowPreviewRightSide();
                return;
            } // if

            Log.Warn("Clipboard does not contain plain text!!");
        } // BtnPasteTextRightClick()

        /// <summary>
        /// Handles the Click event of the btnCompare control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void BtnCompareClick(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        } // BtnCompareClick()
        #endregion // UI METHODS

        //// ---------------------------------------------------------------------

        #region PRIVATE METHODS
        /// <summary>
        /// Loads the left side file.
        /// </summary>
        /// <param name="filename">The filename.</param>
        private void LoadLeftSideFile(string filename)
        {
            try
            {
                this.LeftSide = File.ReadAllText(filename);
                this.ShowPreviewLeftSide();
            }
            catch
            {
                Log.Error("Error reading dropped file!");
            } // catch
        } // LoadLeftSideFile()

        /// <summary>
        /// Shows the preview left side.
        /// </summary>
        private void ShowPreviewLeftSide()
        {
            var len = MaxPreViewLength;
            if (this.LeftSide.Length < MaxPreViewLength)
            {
                len = this.LeftSide.Length;
            } // if

            this.txtPreviewLeft.Text = this.LeftSide.Substring(0, len);
        } // ShowPreviewLeftSide()

        /// <summary>
        /// Loads the right side file.
        /// </summary>
        /// <param name="filename">The filename.</param>
        private void LoadRightSideFile(string filename)
        {
            try
            {
                this.RightSide = File.ReadAllText(filename);
                this.ShowPreviewRightSide();
            }
            catch
            {
                Log.Error("Error reading dropped file!");
            } // catch
        } // LoadRightSideFile()

        /// <summary>
        /// Shows the preview right side.
        /// </summary>
        private void ShowPreviewRightSide()
        {
            var len = MaxPreViewLength;
            if (this.RightSide.Length < MaxPreViewLength)
            {
                len = this.RightSide.Length;
            } // if

            this.txtPreviewRight.Text = this.RightSide.Substring(0, len);
        } // ShowPreviewRightSide()

        /// <summary>
        /// Browses for file.
        /// </summary>
        /// <returns>The filename.</returns>
        private string BrowseForFile()
        {
            var dlg = new OpenFileDialog
            {
                InitialDirectory = ".",
                RestoreDirectory = true,
                Filter = @"Text Files (*.txt) |*.text|"
                         + @"All Files (*.*) |*.*||",
            };

            if (dlg.ShowDialog(this) != DialogResult.OK)
            {
                return string.Empty;
            } // if

            return dlg.FileName;
        } // BrowseForFile()
        #endregion // PRIVATE METHODS
    } // InputSelectionForm
}
