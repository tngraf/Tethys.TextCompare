// ---------------------------------------------------------------------------
// <copyright file="SynchronizedRichTextBox.cs" company="Tethys">
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
    using System.Collections.Generic;
    using System.Windows.Forms;

    /// <summary>
    /// A RichTextBox that can synchronize its vertical scroll with other controls.
    /// Implements the <see cref="RichTextBox" />.
    /// </summary>
    /// <seealso cref="RichTextBox" />
    public class SynchronizedRichTextBox : RichTextBox
    {
        #region PRIVATE PROPERTIES
        /// <summary>
        /// The Window message for the vertical scroll.
        /// </summary>
        private const int WmVscroll = 0x115;

        /// <summary>
        /// The list of peers.
        /// </summary>
        private readonly List<SynchronizedRichTextBox> peers;
        #endregion // PRIVATE PROPERTIES

        //// ---------------------------------------------------------------------

        #region CONSTRUCTION
        /// <summary>
        /// Initializes a new instance of the <see cref="SynchronizedRichTextBox"/> class.
        /// </summary>
        public SynchronizedRichTextBox()
        {
            this.peers = new List<SynchronizedRichTextBox>();
        } // SynchronizedRichTextBox()
        #endregion // CONSTRUCTION

        //// ---------------------------------------------------------------------

        #region PUBLIC METHODS
        /// <summary>
        /// Adds a peer.
        /// </summary>
        /// <param name="peer">The peer.</param>
        public void AddPeer(SynchronizedRichTextBox peer)
        {
            this.peers.Add(peer);
        } // AddPeer()
        #endregion // PUBLIC METHODS

        //// ---------------------------------------------------------------------

        #region PROTECTED METHODS
        /// <summary>
        /// Processes Windows messages.
        /// </summary>
        /// <param name="m">A Windows Message object.</param>
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WmVscroll)
            {
                foreach (var peer in this.peers)
                {
                    var peerMessage = Message.Create(peer.Handle, m.Msg, m.WParam, m.LParam);
                    peer.DirectWndProc(ref peerMessage);
                } // foreach
            } // if

            base.WndProc(ref m);
        } // WndProc()
        #endregion // PROTECTED METHODS

        //// ---------------------------------------------------------------------

        #region PRIVATE METHODS
        /// <summary>
        /// Processes Windows messages.
        /// </summary>
        /// <param name="m">A Windows Message object.</param>
        private void DirectWndProc(ref Message m)
        {
            base.WndProc(ref m);
        } // DirectWndProc()
        #endregion // PRIVATE METHODS
    } // SynchronizedRichTextBox
}
