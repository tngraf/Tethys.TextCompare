// ---------------------------------------------------------------------------
// <copyright file="DiffFileControl.cs" company="Tethys">
//   Copyright (C) 2020 T. Graf
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

namespace Tethys.TextCompare
{
    using System.Windows.Forms;

    /// <summary>
    /// Implements a control to show differences of a text.
    /// </summary>
    /// <seealso cref="UserControl" />
    public partial class DiffFileControl : UserControl
    {
        #region PUBLIC PROPERTIES
        /// <summary>
        /// Gets or sets the name of the item.
        /// </summary>
        public string ItemName
        {
            get => this.txtName.Text;
            set => this.txtName.Text = value;
        }

        /// <summary>
        /// Gets or sets the size of the item.
        /// </summary>
        public string ItemSize
        {
            get => this.lblSize.Text;
            set => this.lblSize.Text = value;
        }

        /// <summary>
        /// Gets the RTF control.
        /// </summary>
        // ReSharper disable once ConvertToAutoProperty
        public RichTextBox Rtf
        {
            get { return this.rtf; }
        }
        #endregion // PUBLIC PROPERTIES

        //// ---------------------------------------------------------------------

        #region CONSTRUCTION
        /// <summary>
        /// Initializes a new instance of the <see cref="DiffFileControl"/> class.
        /// </summary>
        public DiffFileControl()
        {
            this.InitializeComponent();
        } // DiffFileControl()
        #endregion // CONSTRUCTION

        //// ---------------------------------------------------------------------

        #region PUBLIC METHODS
        /// <summary>
        /// Adds a peer.
        /// </summary>
        /// <param name="peer">The peer.</param>
        public void AddPeer(DiffFileControl peer)
        {
            this.rtf.AddPeer(peer.rtf);
        } // AddPeer()
        #endregion // PUBLIC METHODS
    } // DiffFileControl()
}
