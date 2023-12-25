namespace PdfDocumentHandler.UserControls
{
    partial class PdfViewerControl
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
            this.panelPdfViewerContents = new System.Windows.Forms.Panel();
            this.pictureBoxPdfImage = new System.Windows.Forms.PictureBox();
            this.panelPdfViewerButtons = new System.Windows.Forms.Panel();
            this.labelPages = new System.Windows.Forms.Label();
            this.buttonNextPage = new System.Windows.Forms.Button();
            this.buttonRotateRight = new System.Windows.Forms.Button();
            this.buttonRotateLeft = new System.Windows.Forms.Button();
            this.buttonPreviousPage = new System.Windows.Forms.Button();
            this.panelPdfViewerContents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPdfImage)).BeginInit();
            this.panelPdfViewerButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPdfViewerContents
            // 
            this.panelPdfViewerContents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelPdfViewerContents.AutoScroll = true;
            this.panelPdfViewerContents.Controls.Add(this.pictureBoxPdfImage);
            this.panelPdfViewerContents.Location = new System.Drawing.Point(0, 0);
            this.panelPdfViewerContents.Name = "panelPdfViewerContents";
            this.panelPdfViewerContents.Size = new System.Drawing.Size(932, 525);
            this.panelPdfViewerContents.TabIndex = 0;
            // 
            // pictureBoxPdfImage
            // 
            this.pictureBoxPdfImage.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxPdfImage.Name = "pictureBoxPdfImage";
            this.pictureBoxPdfImage.Size = new System.Drawing.Size(100, 50);
            this.pictureBoxPdfImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxPdfImage.TabIndex = 0;
            this.pictureBoxPdfImage.TabStop = false;
            // 
            // panelPdfViewerButtons
            // 
            this.panelPdfViewerButtons.Controls.Add(this.labelPages);
            this.panelPdfViewerButtons.Controls.Add(this.buttonNextPage);
            this.panelPdfViewerButtons.Controls.Add(this.buttonRotateRight);
            this.panelPdfViewerButtons.Controls.Add(this.buttonRotateLeft);
            this.panelPdfViewerButtons.Controls.Add(this.buttonPreviousPage);
            this.panelPdfViewerButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelPdfViewerButtons.Location = new System.Drawing.Point(0, 531);
            this.panelPdfViewerButtons.Name = "panelPdfViewerButtons";
            this.panelPdfViewerButtons.Size = new System.Drawing.Size(932, 29);
            this.panelPdfViewerButtons.TabIndex = 1;
            // 
            // labelPages
            // 
            this.labelPages.AutoSize = true;
            this.labelPages.Location = new System.Drawing.Point(433, 8);
            this.labelPages.Name = "labelPages";
            this.labelPages.Size = new System.Drawing.Size(58, 13);
            this.labelPages.TabIndex = 4;
            this.labelPages.Text = "Pagina x/y";
            // 
            // buttonNextPage
            // 
            this.buttonNextPage.Location = new System.Drawing.Point(507, 3);
            this.buttonNextPage.Name = "buttonNextPage";
            this.buttonNextPage.Size = new System.Drawing.Size(75, 23);
            this.buttonNextPage.TabIndex = 3;
            this.buttonNextPage.Text = "Volgende";
            this.buttonNextPage.UseVisualStyleBackColor = true;
            this.buttonNextPage.Click += new System.EventHandler(this.buttonNextPage_Click);
            // 
            // buttonRotateRight
            // 
            this.buttonRotateRight.Location = new System.Drawing.Point(165, 3);
            this.buttonRotateRight.Name = "buttonRotateRight";
            this.buttonRotateRight.Size = new System.Drawing.Size(75, 23);
            this.buttonRotateRight.TabIndex = 2;
            this.buttonRotateRight.Text = "Draai rechts";
            this.buttonRotateRight.UseVisualStyleBackColor = true;
            this.buttonRotateRight.Click += new System.EventHandler(this.buttonRotateClockWise_Click);
            // 
            // buttonRotateLeft
            // 
            this.buttonRotateLeft.Location = new System.Drawing.Point(84, 3);
            this.buttonRotateLeft.Name = "buttonRotateLeft";
            this.buttonRotateLeft.Size = new System.Drawing.Size(75, 23);
            this.buttonRotateLeft.TabIndex = 1;
            this.buttonRotateLeft.Text = "Draai links";
            this.buttonRotateLeft.UseVisualStyleBackColor = true;
            this.buttonRotateLeft.Click += new System.EventHandler(this.buttonRotateCounterClockWise_Click);
            // 
            // buttonPreviousPage
            // 
            this.buttonPreviousPage.Location = new System.Drawing.Point(352, 3);
            this.buttonPreviousPage.Name = "buttonPreviousPage";
            this.buttonPreviousPage.Size = new System.Drawing.Size(75, 23);
            this.buttonPreviousPage.TabIndex = 0;
            this.buttonPreviousPage.Text = "Vorige";
            this.buttonPreviousPage.UseVisualStyleBackColor = true;
            this.buttonPreviousPage.Click += new System.EventHandler(this.buttonPreviousPage_Click);
            // 
            // PdfViewerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelPdfViewerButtons);
            this.Controls.Add(this.panelPdfViewerContents);
            this.Name = "PdfViewerControl";
            this.Size = new System.Drawing.Size(932, 560);
            this.Load += new System.EventHandler(this.PdfViewerControl_Load);
            this.panelPdfViewerContents.ResumeLayout(false);
            this.panelPdfViewerContents.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPdfImage)).EndInit();
            this.panelPdfViewerButtons.ResumeLayout(false);
            this.panelPdfViewerButtons.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPdfViewerContents;
        private System.Windows.Forms.Panel panelPdfViewerButtons;
        private System.Windows.Forms.Button buttonNextPage;
        private System.Windows.Forms.Button buttonRotateRight;
        private System.Windows.Forms.Button buttonRotateLeft;
        private System.Windows.Forms.Button buttonPreviousPage;
        private System.Windows.Forms.PictureBox pictureBoxPdfImage;
        private System.Windows.Forms.Label labelPages;
    }
}
