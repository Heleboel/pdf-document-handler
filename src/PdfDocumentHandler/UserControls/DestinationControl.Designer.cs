namespace PdfDocumentHandler.UserControls
{
    partial class DestinationControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DestinationControl));
            this.listViewDestinations = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.buttonAddDestination = new System.Windows.Forms.Button();
            this.buttonEditDestination = new System.Windows.Forms.Button();
            this.buttonDeleteDestination = new System.Windows.Forms.Button();
            this.buttonCopy = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.AddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CopyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.DeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewDestinations
            // 
            this.listViewDestinations.AllowDrop = true;
            this.listViewDestinations.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewDestinations.ContextMenuStrip = this.contextMenuStrip1;
            this.listViewDestinations.HideSelection = false;
            this.listViewDestinations.LargeImageList = this.imageList1;
            this.listViewDestinations.Location = new System.Drawing.Point(3, 33);
            this.listViewDestinations.MultiSelect = false;
            this.listViewDestinations.Name = "listViewDestinations";
            this.listViewDestinations.ShowGroups = false;
            this.listViewDestinations.ShowItemToolTips = true;
            this.listViewDestinations.Size = new System.Drawing.Size(475, 273);
            this.listViewDestinations.SmallImageList = this.imageList1;
            this.listViewDestinations.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listViewDestinations.TabIndex = 4;
            this.listViewDestinations.UseCompatibleStateImageBehavior = false;
            this.listViewDestinations.View = System.Windows.Forms.View.Tile;
            this.listViewDestinations.DragDrop += new System.Windows.Forms.DragEventHandler(this.ListViewDestinations_DragDrop);
            this.listViewDestinations.DragOver += new System.Windows.Forms.DragEventHandler(this.ListViewDestinations_DragOver);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Folder.ico");
            // 
            // buttonAddDestination
            // 
            this.buttonAddDestination.Location = new System.Drawing.Point(3, 3);
            this.buttonAddDestination.Name = "buttonAddDestination";
            this.buttonAddDestination.Size = new System.Drawing.Size(75, 23);
            this.buttonAddDestination.TabIndex = 0;
            this.buttonAddDestination.Text = "Toevoegen";
            this.buttonAddDestination.UseVisualStyleBackColor = true;
            this.buttonAddDestination.Click += new System.EventHandler(this.ButtonAddDestination_Click);
            // 
            // buttonEditDestination
            // 
            this.buttonEditDestination.Location = new System.Drawing.Point(165, 3);
            this.buttonEditDestination.Name = "buttonEditDestination";
            this.buttonEditDestination.Size = new System.Drawing.Size(75, 23);
            this.buttonEditDestination.TabIndex = 2;
            this.buttonEditDestination.Text = "Bewerken";
            this.buttonEditDestination.UseVisualStyleBackColor = true;
            this.buttonEditDestination.Click += new System.EventHandler(this.ButtonEditDestination_Click);
            // 
            // buttonDeleteDestination
            // 
            this.buttonDeleteDestination.Location = new System.Drawing.Point(246, 3);
            this.buttonDeleteDestination.Name = "buttonDeleteDestination";
            this.buttonDeleteDestination.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteDestination.TabIndex = 3;
            this.buttonDeleteDestination.Text = "Verwijderen";
            this.buttonDeleteDestination.UseVisualStyleBackColor = true;
            this.buttonDeleteDestination.Click += new System.EventHandler(this.ButtonDeleteDestination_Click);
            // 
            // buttonCopy
            // 
            this.buttonCopy.Location = new System.Drawing.Point(84, 3);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(75, 23);
            this.buttonCopy.TabIndex = 1;
            this.buttonCopy.Text = "Kopiëren";
            this.buttonCopy.UseVisualStyleBackColor = true;
            this.buttonCopy.Click += new System.EventHandler(this.ButtonCopy_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddToolStripMenuItem,
            this.CopyToolStripMenuItem,
            this.EditToolStripMenuItem,
            this.toolStripMenuItem1,
            this.DeleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 120);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // AddToolStripMenuItem
            // 
            this.AddToolStripMenuItem.Name = "AddToolStripMenuItem";
            this.AddToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.AddToolStripMenuItem.Text = "Toevoegen";
            this.AddToolStripMenuItem.Click += new System.EventHandler(this.AddToolStripMenuItem_Click);
            // 
            // CopyToolStripMenuItem
            // 
            this.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem";
            this.CopyToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.CopyToolStripMenuItem.Text = "Kopieren";
            this.CopyToolStripMenuItem.Click += new System.EventHandler(this.CopyToolStripMenuItem_Click);
            // 
            // EditToolStripMenuItem
            // 
            this.EditToolStripMenuItem.Name = "EditToolStripMenuItem";
            this.EditToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.EditToolStripMenuItem.Text = "Bewerken";
            this.EditToolStripMenuItem.Click += new System.EventHandler(this.EditToolStripMenuItem_Click);
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
            // DestinationControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonCopy);
            this.Controls.Add(this.buttonDeleteDestination);
            this.Controls.Add(this.buttonEditDestination);
            this.Controls.Add(this.buttonAddDestination);
            this.Controls.Add(this.listViewDestinations);
            this.Name = "DestinationControl";
            this.Size = new System.Drawing.Size(481, 309);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewDestinations;
        private System.Windows.Forms.Button buttonAddDestination;
        private System.Windows.Forms.Button buttonEditDestination;
        private System.Windows.Forms.Button buttonDeleteDestination;
        private System.Windows.Forms.Button buttonCopy;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem AddToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CopyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem DeleteToolStripMenuItem;
    }
}
