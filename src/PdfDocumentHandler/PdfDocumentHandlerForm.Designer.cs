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
            splitContainer1 = new SplitContainer();
            pdfViewerControl = new PdfViewerControl();
            splitContainer2 = new SplitContainer();
            sourceControl = new SourceControl();
            destinationControl = new DestinationControl();
            buttonClose = new Button();
            buttonReset = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Margin = new Padding(4, 3, 4, 3);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.AutoScroll = true;
            splitContainer1.Panel1.AutoScrollMinSize = new Size(100, 100);
            splitContainer1.Panel1.Controls.Add(pdfViewerControl);
            splitContainer1.Panel1MinSize = 300;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(splitContainer2);
            splitContainer1.Panel2.Controls.Add(panel1);
            splitContainer1.Panel2MinSize = 300;
            splitContainer1.Size = new Size(1440, 735);
            splitContainer1.SplitterDistance = 946;
            splitContainer1.SplitterWidth = 5;
            splitContainer1.TabIndex = 2;
            // 
            // pdfViewerControl
            // 
            pdfViewerControl.Dock = DockStyle.Fill;
            pdfViewerControl.Location = new Point(0, 0);
            pdfViewerControl.Margin = new Padding(5, 3, 5, 3);
            pdfViewerControl.Name = "pdfViewerControl";
            pdfViewerControl.Size = new Size(946, 735);
            pdfViewerControl.TabIndex = 0;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Margin = new Padding(4, 3, 4, 3);
            splitContainer2.Name = "splitContainer2";
            splitContainer2.Orientation = Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(sourceControl);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(destinationControl);
            splitContainer2.Size = new Size(489, 699);
            splitContainer2.SplitterDistance = 340;
            splitContainer2.SplitterWidth = 5;
            splitContainer2.TabIndex = 14;
            // 
            // sourceControl
            // 
            sourceControl.Dock = DockStyle.Fill;
            sourceControl.Location = new Point(0, 0);
            sourceControl.Margin = new Padding(5, 3, 5, 3);
            sourceControl.Name = "sourceControl";
            sourceControl.Size = new Size(489, 340);
            sourceControl.TabIndex = 0;
            sourceControl.MoveFile += SourceControl_MoveFile;
            sourceControl.CopyFile += SourceControl_CopyFile;
            sourceControl.SelectedIndexChanged += SourceControl_SelectedIndexChanged;
            // 
            // destinationControl
            // 
            destinationControl.Dock = DockStyle.Fill;
            destinationControl.Location = new Point(0, 0);
            destinationControl.Margin = new Padding(5, 3, 5, 3);
            destinationControl.Name = "destinationControl";
            destinationControl.Size = new Size(489, 354);
            destinationControl.TabIndex = 0;
            // 
            // buttonClose
            // 
            buttonClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonClose.Location = new Point(386, 6);
            buttonClose.Margin = new Padding(4, 3, 4, 3);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(88, 27);
            buttonClose.TabIndex = 11;
            buttonClose.Text = "Afsluiten";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += ButtonClose_Click;
            // 
            // buttonReset
            // 
            buttonReset.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonReset.Location = new Point(291, 6);
            buttonReset.Margin = new Padding(4, 3, 4, 3);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(88, 27);
            buttonReset.TabIndex = 12;
            buttonReset.Text = "Reset";
            buttonReset.UseVisualStyleBackColor = true;
            buttonReset.Click += buttonReset_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonReset);
            panel1.Controls.Add(buttonClose);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 699);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(489, 36);
            panel1.TabIndex = 13;
            // 
            // PdfDocumentHandlerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1440, 735);
            Controls.Add(splitContainer1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Margin = new Padding(4, 3, 4, 3);
            Name = "PdfDocumentHandlerForm";
            Text = "PdfDocumentHandler";
            FormClosing += PdfDocumentHandlerForm_FormClosing;
            Load += PdfDocumentHandlerForm_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private PdfViewerControl pdfViewerControl;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private SourceControl sourceControl;
        private DestinationControl destinationControl;
        private Panel panel1;
        private Button buttonReset;
        private Button buttonClose;
    }
}
