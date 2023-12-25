namespace PdfDocumentHandler.UserControls
{
    partial class SourceControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listViewSource = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CopyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CopyAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MoveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MoveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.DeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonBrowseSourceDirectory = new System.Windows.Forms.Button();
            this.comboBoxSourceFolders = new System.Windows.Forms.ComboBox();
            this.labelSourceDirectory = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonCopy = new System.Windows.Forms.Button();
            this.buttonMove = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewSource
            // 
            this.listViewSource.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewSource.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listViewSource.ContextMenuStrip = this.contextMenuStrip1;
            this.listViewSource.FullRowSelect = true;
            this.listViewSource.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewSource.HideSelection = false;
            this.listViewSource.Location = new System.Drawing.Point(3, 36);
            this.listViewSource.MultiSelect = false;
            this.listViewSource.Name = "listViewSource";
            this.listViewSource.Size = new System.Drawing.Size(392, 174);
            this.listViewSource.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listViewSource.TabIndex = 3;
            this.listViewSource.UseCompatibleStateImageBehavior = false;
            this.listViewSource.View = System.Windows.Forms.View.Details;
            this.listViewSource.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.ListViewSource_ItemDrag);
            this.listViewSource.SelectedIndexChanged += new System.EventHandler(this.ListViewSource_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Bestandsnaam";
            this.columnHeader1.Width = 169;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Volledige pad";
            this.columnHeader2.Width = 187;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CopyToolStripMenuItem,
            this.CopyAsToolStripMenuItem,
            this.MoveToolStripMenuItem,
            this.MoveAsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.DeleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 142);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.ContextMenuStrip1_Opening);
            // 
            // CopyToolStripMenuItem
            // 
            this.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem";
            this.CopyToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.CopyToolStripMenuItem.Text = "Kopieren";
            this.CopyToolStripMenuItem.Click += new System.EventHandler(this.CopyToolStripMenuItem_Click);
            // 
            // CopyAsToolStripMenuItem
            // 
            this.CopyAsToolStripMenuItem.Name = "CopyAsToolStripMenuItem";
            this.CopyAsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.CopyAsToolStripMenuItem.Text = "Kopieren als";
            this.CopyAsToolStripMenuItem.Click += new System.EventHandler(this.CopyAsToolStripMenuItem_Click);
            // 
            // MoveToolStripMenuItem
            // 
            this.MoveToolStripMenuItem.Name = "MoveToolStripMenuItem";
            this.MoveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.MoveToolStripMenuItem.Text = "Verplaatsen";
            this.MoveToolStripMenuItem.Click += new System.EventHandler(this.MoveToolStripMenuItem_Click);
            // 
            // MoveAsToolStripMenuItem
            // 
            this.MoveAsToolStripMenuItem.Name = "MoveAsToolStripMenuItem";
            this.MoveAsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.MoveAsToolStripMenuItem.Text = "Verplaatsen als";
            this.MoveAsToolStripMenuItem.Click += new System.EventHandler(this.MoveAsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 6);
            // 
            // DeleteToolStripMenuItem
            // 
            this.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
            this.DeleteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.DeleteToolStripMenuItem.Text = "Verwijderen";
            this.DeleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
            // 
            // buttonBrowseSourceDirectory
            // 
            this.buttonBrowseSourceDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBrowseSourceDirectory.Location = new System.Drawing.Point(320, 3);
            this.buttonBrowseSourceDirectory.Name = "buttonBrowseSourceDirectory";
            this.buttonBrowseSourceDirectory.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowseSourceDirectory.TabIndex = 2;
            this.buttonBrowseSourceDirectory.Text = "Browse";
            this.buttonBrowseSourceDirectory.UseVisualStyleBackColor = true;
            this.buttonBrowseSourceDirectory.Click += new System.EventHandler(this.ButtonBrowseSourceDirectory_Click);
            // 
            // comboBoxSourceFolders
            // 
            this.comboBoxSourceFolders.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxSourceFolders.FormattingEnabled = true;
            this.comboBoxSourceFolders.Location = new System.Drawing.Point(96, 5);
            this.comboBoxSourceFolders.Name = "comboBoxSourceFolders";
            this.comboBoxSourceFolders.Size = new System.Drawing.Size(218, 21);
            this.comboBoxSourceFolders.TabIndex = 1;
            this.comboBoxSourceFolders.SelectionChangeCommitted += new System.EventHandler(this.ComboBoxSourceFolders_SelectionChangeCommitted);
            this.comboBoxSourceFolders.Leave += new System.EventHandler(this.ComboBoxSourceFolders_Leave);
            // 
            // labelSourceDirectory
            // 
            this.labelSourceDirectory.AutoSize = true;
            this.labelSourceDirectory.Location = new System.Drawing.Point(3, 8);
            this.labelSourceDirectory.Name = "labelSourceDirectory";
            this.labelSourceDirectory.Size = new System.Drawing.Size(87, 13);
            this.labelSourceDirectory.TabIndex = 0;
            this.labelSourceDirectory.Text = "Source directory:";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonDelete.Location = new System.Drawing.Point(165, 215);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 6;
            this.buttonDelete.Text = "Verwijderen";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // buttonCopy
            // 
            this.buttonCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonCopy.Location = new System.Drawing.Point(3, 215);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(75, 23);
            this.buttonCopy.TabIndex = 4;
            this.buttonCopy.Text = "Kopiëren";
            this.buttonCopy.UseVisualStyleBackColor = true;
            this.buttonCopy.Click += new System.EventHandler(this.ButtonCopy_Click);
            // 
            // buttonMove
            // 
            this.buttonMove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonMove.Location = new System.Drawing.Point(84, 215);
            this.buttonMove.Name = "buttonMove";
            this.buttonMove.Size = new System.Drawing.Size(75, 23);
            this.buttonMove.TabIndex = 5;
            this.buttonMove.Text = "Verplaatsen";
            this.buttonMove.UseVisualStyleBackColor = true;
            this.buttonMove.Click += new System.EventHandler(this.ButtonMove_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonRefresh.Location = new System.Drawing.Point(246, 215);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(75, 23);
            this.buttonRefresh.TabIndex = 7;
            this.buttonRefresh.Text = "Verversen";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.ButtonRefresh_Click);
            // 
            // SourceControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonCopy);
            this.Controls.Add(this.buttonMove);
            this.Controls.Add(this.listViewSource);
            this.Controls.Add(this.buttonBrowseSourceDirectory);
            this.Controls.Add(this.comboBoxSourceFolders);
            this.Controls.Add(this.labelSourceDirectory);
            this.Name = "SourceControl";
            this.Size = new System.Drawing.Size(398, 241);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SourceControl_KeyUp);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewSource;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button buttonBrowseSourceDirectory;
        private System.Windows.Forms.ComboBox comboBoxSourceFolders;
        private System.Windows.Forms.Label labelSourceDirectory;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonCopy;
        private System.Windows.Forms.Button buttonMove;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem CopyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CopyAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MoveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MoveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem DeleteToolStripMenuItem;
    }
}
