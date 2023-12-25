using System;
using System.Drawing;
using System.Windows.Forms;
using PdfDocumentHandler.Models;


namespace PdfDocumentHandler.Forms
{
    public partial class FormDestination : Form
    {
        private Destination _destination;


        public FormDestination()
        {
            InitializeComponent();

            if (FormLocation.Equals(new Point(0, 0)))
            {
                StartPosition = FormStartPosition.CenterParent;
            }
            else
            {
                StartPosition = FormStartPosition.Manual;
                Location = FormLocation;
                Size = FormSize;
            }
        }


        public new DialogResult ShowDialog()
        {
            return ShowDialog(new Destination());
        }


        public DialogResult ShowDialog(Destination destination)
        {
            _destination = destination;
            PopulateFields();
            return base.ShowDialog();
        }


        public Destination GetDestination()
        {
            _destination.Name              = textBoxName.Text;
            _destination.Description       = textBoxDescription.Text;
            _destination.Location          = textBoxLocation.Text;
            _destination.Template          = textBoxTemplate.Text;
            _destination.AddYearToLocation = checkBoxAddYearToLocation.Checked;

            return _destination;
        }


        private void PopulateFields()
        {
            if (_destination == null)
            {
                return;
            }

            textBoxName.Text                  = _destination.Name;
            textBoxDescription.Text           = _destination.Description;
            textBoxLocation.Text              = _destination.Location;
            textBoxTemplate.Text              = _destination.Template;
            checkBoxAddYearToLocation.Checked = _destination.AddYearToLocation;
        }


        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.SelectedPath        = textBoxLocation.Text;
            folderBrowserDialog.ShowNewFolderButton = true;

            var dialogResult = folderBrowserDialog.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                var folder = folderBrowserDialog.SelectedPath;

                _destination.Location = folder;
                textBoxLocation.Text  = folder;
            }
        }

        #region Form events

        private static Point FormLocation { get; set; }
        private static Size FormSize { get; set; }


        private void FormDestination_Move(object sender, EventArgs e)
        {
            FormLocation = Location;
        }

        private void FormDestination_Resize(object sender, EventArgs e)
        {
            FormSize = Size;
        }

        #endregion

    }
}
