using System;
using PdfDocumentHandler.UserControls;

namespace PdfDocumentHandler
{
    partial class PdfDocumentHandlerForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PdfDocumentHandlerForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pdfViewerControl = new PdfDocumentHandler.UserControls.PdfViewerControl();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.sourceControl = new PdfDocumentHandler.UserControls.SourceControl();
            this.destinationControl = new PdfDocumentHandler.UserControls.DestinationControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.AutoScrollMinSize = new System.Drawing.Size(100, 100);
            this.splitContainer1.Panel1.Controls.Add(this.pdfViewerControl);
            this.splitContainer1.Panel1MinSize = 300;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Panel2MinSize = 300;
            this.splitContainer1.Size = new System.Drawing.Size(1234, 637);
            this.splitContainer1.SplitterDistance = 791;
            this.splitContainer1.TabIndex = 2;
            // 
            // pdfViewerControl
            // 
            this.pdfViewerControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pdfViewerControl.Location = new System.Drawing.Point(0, 0);
            this.pdfViewerControl.Name = "pdfViewerControl";
            this.pdfViewerControl.Size = new System.Drawing.Size(791, 637);
            this.pdfViewerControl.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.sourceControl);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.destinationControl);
            this.splitContainer2.Size = new System.Drawing.Size(439, 606);
            this.splitContainer2.SplitterDistance = 295;
            this.splitContainer2.TabIndex = 14;
            // 
            // sourceControl
            // 
            this.sourceControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sourceControl.Location = new System.Drawing.Point(0, 0);
            this.sourceControl.Name = "sourceControl";
            this.sourceControl.Size = new System.Drawing.Size(439, 295);
            this.sourceControl.TabIndex = 0;
            this.sourceControl.MoveFile += new PdfDocumentHandler.UserControls.MoveFileEventHandler(this.SourceControl_MoveFile);
            this.sourceControl.CopyFile += new PdfDocumentHandler.UserControls.CopyFileEventHandler(this.SourceControl_CopyFile);
            this.sourceControl.SelectedIndexChanged += new PdfDocumentHandler.UserControls.SelectedIndexChangedEventHandler(this.SourceControl_SelectedIndexChanged);
            // 
            // destinationControl
            // 
            this.destinationControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.destinationControl.Location = new System.Drawing.Point(0, 0);
            this.destinationControl.Name = "destinationControl";
            this.destinationControl.Size = new System.Drawing.Size(439, 307);
            this.destinationControl.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonReset);
            this.panel1.Controls.Add(this.buttonClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 606);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(439, 31);
            this.panel1.TabIndex = 13;
            // 
            // buttonReset
            // 
            this.buttonReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonReset.Location = new System.Drawing.Point(280, 5);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 23);
            this.buttonReset.TabIndex = 12;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(361, 5);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 11;
            this.buttonClose.Text = "Afsluiten";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // PdfDocumentHandlerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 637);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "PdfDocumentHandlerForm";
            this.Text = "PdfDocumentHandler";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PdfDocumentHandlerForm_FormClosing);
            this.Load += new System.EventHandler(this.PdfDocumentHandlerForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonClose;
        private PdfViewerControl pdfViewerControl;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Panel panel1;
        private SourceControl sourceControl;
        private DestinationControl destinationControl;
    }
}
