namespace PdfDocumentHandler.Forms
{
    partial class FormNewFilename
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
            this.textBoxOriginalFileName = new System.Windows.Forms.TextBox();
            this.labelOriginalFileName = new System.Windows.Forms.Label();
            this.textBoxNewFileName = new System.Windows.Forms.TextBox();
            this.labelNewFileName = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.textBoxCompany = new System.Windows.Forms.TextBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelCompany = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.labelPreviewText = new System.Windows.Forms.Label();
            this.labelDestinationName = new System.Windows.Forms.Label();
            this.labelDestinationNameText = new System.Windows.Forms.Label();
            this.labelDestinationFolder = new System.Windows.Forms.Label();
            this.labelDestinationFolderText = new System.Windows.Forms.Label();
            this.labelPreview = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxOriginalFileName
            // 
            this.textBoxOriginalFileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxOriginalFileName.Enabled = false;
            this.textBoxOriginalFileName.Location = new System.Drawing.Point(142, 58);
            this.textBoxOriginalFileName.Name = "textBoxOriginalFileName";
            this.textBoxOriginalFileName.Size = new System.Drawing.Size(454, 20);
            this.textBoxOriginalFileName.TabIndex = 5;
            // 
            // labelOriginalFileName
            // 
            this.labelOriginalFileName.AutoSize = true;
            this.labelOriginalFileName.Location = new System.Drawing.Point(13, 61);
            this.labelOriginalFileName.Name = "labelOriginalFileName";
            this.labelOriginalFileName.Size = new System.Drawing.Size(123, 13);
            this.labelOriginalFileName.TabIndex = 4;
            this.labelOriginalFileName.Text = "Originele bestandsnaam:";
            // 
            // textBoxNewFileName
            // 
            this.textBoxNewFileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNewFileName.Location = new System.Drawing.Point(142, 84);
            this.textBoxNewFileName.Name = "textBoxNewFileName";
            this.textBoxNewFileName.Size = new System.Drawing.Size(454, 20);
            this.textBoxNewFileName.TabIndex = 7;
            this.textBoxNewFileName.TextChanged += new System.EventHandler(this.TextBoxNewFileName_TextChanged);
            // 
            // labelNewFileName
            // 
            this.labelNewFileName.AutoSize = true;
            this.labelNewFileName.Location = new System.Drawing.Point(18, 87);
            this.labelNewFileName.Name = "labelNewFileName";
            this.labelNewFileName.Size = new System.Drawing.Size(118, 13);
            this.labelNewFileName.TabIndex = 6;
            this.labelNewFileName.Text = "Nieuwe bestandsnaam:";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(142, 110);
            this.dateTimePicker.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 9;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.DateTimePicker_ValueChanged);
            // 
            // textBoxCompany
            // 
            this.textBoxCompany.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCompany.Location = new System.Drawing.Point(142, 136);
            this.textBoxCompany.Name = "textBoxCompany";
            this.textBoxCompany.Size = new System.Drawing.Size(454, 20);
            this.textBoxCompany.TabIndex = 11;
            this.textBoxCompany.TextChanged += new System.EventHandler(this.TextBoxCompany_TextChanged);
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDescription.Location = new System.Drawing.Point(142, 162);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(454, 20);
            this.textBoxDescription.TabIndex = 13;
            this.textBoxDescription.TextChanged += new System.EventHandler(this.TextBoxDescription_TextChanged);
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(95, 113);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(41, 13);
            this.labelDate.TabIndex = 8;
            this.labelDate.Text = "Datum:";
            // 
            // labelCompany
            // 
            this.labelCompany.AutoSize = true;
            this.labelCompany.Location = new System.Drawing.Point(97, 139);
            this.labelCompany.Name = "labelCompany";
            this.labelCompany.Size = new System.Drawing.Size(39, 13);
            this.labelCompany.TabIndex = 10;
            this.labelCompany.Text = "Bedrijf:";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(66, 165);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(70, 13);
            this.labelDescription.TabIndex = 12;
            this.labelDescription.Text = "Omschrijving:";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(466, 226);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 16;
            this.buttonCancel.Text = "Annuleren";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonOk
            // 
            this.buttonOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOk.Location = new System.Drawing.Point(547, 226);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 17;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            // 
            // labelPreviewText
            // 
            this.labelPreviewText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPreviewText.Location = new System.Drawing.Point(142, 191);
            this.labelPreviewText.Name = "labelPreviewText";
            this.labelPreviewText.Size = new System.Drawing.Size(454, 13);
            this.labelPreviewText.TabIndex = 15;
            this.labelPreviewText.Text = "voorbeeld";
            // 
            // labelDestinationName
            // 
            this.labelDestinationName.AutoSize = true;
            this.labelDestinationName.Location = new System.Drawing.Point(40, 9);
            this.labelDestinationName.Name = "labelDestinationName";
            this.labelDestinationName.Size = new System.Drawing.Size(96, 13);
            this.labelDestinationName.TabIndex = 0;
            this.labelDestinationName.Text = "Bestemming naam:";
            // 
            // labelDestinationNameText
            // 
            this.labelDestinationNameText.Location = new System.Drawing.Point(142, 9);
            this.labelDestinationNameText.Name = "labelDestinationNameText";
            this.labelDestinationNameText.Size = new System.Drawing.Size(462, 13);
            this.labelDestinationNameText.TabIndex = 1;
            this.labelDestinationNameText.Text = "Naam";
            // 
            // labelDestinationFolder
            // 
            this.labelDestinationFolder.AutoSize = true;
            this.labelDestinationFolder.Location = new System.Drawing.Point(40, 35);
            this.labelDestinationFolder.Name = "labelDestinationFolder";
            this.labelDestinationFolder.Size = new System.Drawing.Size(96, 13);
            this.labelDestinationFolder.TabIndex = 2;
            this.labelDestinationFolder.Text = "Bestemming folder:";
            // 
            // labelDestinationFolderText
            // 
            this.labelDestinationFolderText.Location = new System.Drawing.Point(142, 35);
            this.labelDestinationFolderText.Name = "labelDestinationFolderText";
            this.labelDestinationFolderText.Size = new System.Drawing.Size(462, 13);
            this.labelDestinationFolderText.TabIndex = 3;
            this.labelDestinationFolderText.Text = "Folder";
            // 
            // labelPreview
            // 
            this.labelPreview.AutoSize = true;
            this.labelPreview.Location = new System.Drawing.Point(78, 191);
            this.labelPreview.Name = "labelPreview";
            this.labelPreview.Size = new System.Drawing.Size(58, 13);
            this.labelPreview.TabIndex = 14;
            this.labelPreview.Text = "Voorbeeld:";
            // 
            // FormNewFilename
            // 
            this.AcceptButton = this.buttonOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(634, 261);
            this.Controls.Add(this.labelPreview);
            this.Controls.Add(this.labelDestinationFolderText);
            this.Controls.Add(this.labelDestinationFolder);
            this.Controls.Add(this.labelDestinationNameText);
            this.Controls.Add(this.labelDestinationName);
            this.Controls.Add(this.labelPreviewText);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelCompany);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.textBoxCompany);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.labelNewFileName);
            this.Controls.Add(this.textBoxNewFileName);
            this.Controls.Add(this.labelOriginalFileName);
            this.Controls.Add(this.textBoxOriginalFileName);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(650, 300);
            this.Name = "FormNewFilename";
            this.Text = "Nieuwe bestandsnaam";
            this.Move += new System.EventHandler(this.FormNewFilename_Move);
            this.Resize += new System.EventHandler(this.FormNewFilename_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxOriginalFileName;
        private System.Windows.Forms.Label labelOriginalFileName;
        private System.Windows.Forms.TextBox textBoxNewFileName;
        private System.Windows.Forms.Label labelNewFileName;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.TextBox textBoxCompany;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelCompany;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Label labelPreviewText;
        private System.Windows.Forms.Label labelDestinationName;
        private System.Windows.Forms.Label labelDestinationNameText;
        private System.Windows.Forms.Label labelDestinationFolder;
        private System.Windows.Forms.Label labelDestinationFolderText;
        private System.Windows.Forms.Label labelPreview;
    }
}