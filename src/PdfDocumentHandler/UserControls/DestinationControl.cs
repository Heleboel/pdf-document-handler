using System.ComponentModel;
using PdfDocumentHandler.Forms;
using PdfDocumentHandler.Models;


namespace PdfDocumentHandler.UserControls;

public partial class DestinationControl : UserControl
{
    private const string MoveFileText = "Verplaats bestand";
    private const string CopyFileText = "Kopieer bestand";


    private List<Destination> _destinations = new List<Destination>();


    public DestinationControl()
    {
        InitializeComponent();
    }


    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public List<Destination> Destinations
    {
        get { return _destinations; }
        set
        {
            _destinations = value ?? new List<Destination>();
            PopulateListView();
        }
    }


    public bool CopyFile(string sourceFile)
    {
        var destination = GetSelectedDestination();
        var newFileName = GetNewFileName(sourceFile, destination, CopyFileText);
        var overwrite = GetOverwrite(newFileName, CopyFileText);
        return CopyFileInternal(sourceFile, newFileName, overwrite);
    }


    public bool MoveFile(string sourceFile)
    {
        var destination = GetSelectedDestination();
        var newFileName = GetNewFileName(sourceFile, destination, MoveFileText);
        var overwrite = GetOverwrite(newFileName, MoveFileText);
        return MoveFileInternal(sourceFile, newFileName, overwrite);
    }


    private Destination GetSelectedDestination()
    {
        if (listViewDestinations.SelectedItems.Count > 0)
        {
            return listViewDestinations.SelectedItems[0].Tag as Destination;
        }
        return null;
    }


    private static bool GetOverwrite(string filename, string caption)
    {
        if (string.IsNullOrEmpty(filename))
        {
            return false;
        }

        if (File.Exists(filename))
        {
            return MessageBox.Show($@"Het bestand {filename} bestaat al. Overschrijven?", caption, MessageBoxButtons.YesNo) == DialogResult.Yes;
        }

        return false;
    }


    #region ListView methods

    public void Clear()
    {
        listViewDestinations.Items.Clear();
        _destinations = new List<Destination>();
    }


    private void PopulateListView()
    {
        listViewDestinations.Items.Clear();
        if (_destinations != null && _destinations.Count > 0)
        {
            foreach (var destination in _destinations)
            {
                AddDestinationToListView(destination);
            }
            listViewDestinations.Refresh();
        }
    }

    private void AddDestinationToListView(Destination destination)
    {
        var listViewItem = new ListViewItem
        {
            Text        = destination.Name,
            Name        = destination.Name,
            Tag         = destination,
            ToolTipText = destination.Description,
            ImageIndex  = 0
        };

        listViewDestinations.Items.Add(listViewItem);
        listViewDestinations.Refresh();
    }


    private void UpdateDestinationInListView(Destination destination)
    {
        if (listViewDestinations.SelectedItems.Count > 0)
        {
            var listViewItem = listViewDestinations.SelectedItems[0];
            var destinationInListView = listViewItem.Tag as Destination;

            if (destinationInListView != null && destinationInListView.Id == destination.Id)
            {
                listViewItem.Text        = destination.Name;
                listViewItem.Name        = destination.Name;
                listViewItem.Tag         = destination;
                listViewItem.ToolTipText = destination.Description;
            }

            listViewDestinations.Refresh();
        }
    }


    private void DeleteDestinationInListView(Destination destination)
    {
        if (listViewDestinations.SelectedItems.Count > 0)
        {
            var listViewItem = listViewDestinations.SelectedItems[0];
            var destinationInListView = listViewItem.Tag as Destination;

            if (destinationInListView != null && destinationInListView.Id == destination.Id)
            {
                listViewItem.Remove();
            }

            listViewDestinations.Refresh();
        }
    }

    #endregion


    private void ButtonAddDestination_Click(object sender, EventArgs e)
    {
        AddDestination();
    }


    private void ButtonCopy_Click(object sender, EventArgs e)
    {
        CopyDestination();
    }


    private void ButtonEditDestination_Click(object sender, EventArgs e)
    {
        // Show form to edit a destination
        EditDestination();
    }


    private void ButtonDeleteDestination_Click(object sender, EventArgs e)
    {
        DeleteDestination();
    }


    private void AddDestination()
    {
        // Show form to add a destination
        var formDestination = new FormDestination();

        if (formDestination.ShowDialog() == DialogResult.OK)
        {
            var destination = formDestination.GetDestination();
            AddDestination(destination);
        }
    }


    private void CopyDestination()
    {
        if (listViewDestinations.SelectedItems.Count > 0)
        {
            var formDestination = new FormDestination();
            var destination = new Destination(listViewDestinations.SelectedItems[0].Tag as Destination);

            if (formDestination.ShowDialog(destination) == DialogResult.OK)
            {
                destination = formDestination.GetDestination();
                AddDestination(destination);
            }
        }
    }


    private void EditDestination()
    {
        if (listViewDestinations.SelectedItems.Count > 0)
        {
            var formDestination = new FormDestination();
            var destination = listViewDestinations.SelectedItems[0].Tag as Destination;

            if (formDestination.ShowDialog(destination) == DialogResult.OK)
            {
                destination = formDestination.GetDestination();
                UpdateDestination(destination);
            }
        }
    }


    private void DeleteDestination()
    {
        // Show dialog to ask for acknowledge.
        if (listViewDestinations.SelectedItems.Count == 1)
        {
            var result = MessageBox.Show(@"Bestemming verwijderen?", @"Verwijder bestemming", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                // Delete selected destination
                var destination = listViewDestinations.SelectedItems[0].Tag as Destination;
                DeleteDestination(destination);
            }
        }
    }


    private void AddDestination(Destination destination)
    {
        _destinations.Add(destination);
        AddDestinationToListView(destination);
    }


    private void UpdateDestination(Destination destination)
    {
        var destinationToUpdate = _destinations.Find(d => d.Id == destination.Id);

        if (destinationToUpdate != null)
        {
            destinationToUpdate.Name        = destination.Name;
            destinationToUpdate.Description = destination.Description;
            destinationToUpdate.Location    = destination.Location;

            UpdateDestinationInListView(destinationToUpdate);
        }
    }


    private void DeleteDestination(Destination destination)
    {
        var destinationToDelete = _destinations.Find(d => d.Id == destination.Id);

        if (destinationToDelete != null)
        {
            _destinations.Remove(destinationToDelete);
            DeleteDestinationInListView(destinationToDelete);
        }
    }


    #region Drag & Drop methods

    private void ListViewDestinations_DragDrop(object sender, DragEventArgs e)
    {
        if (e.Data.GetDataPresent(typeof(string)))
        {
            var sourceFile = e.Data.GetData(typeof(string)) as string;

            if (e.Effect == DragDropEffects.Copy)
            {
                if (!CopyFile(sourceFile))
                {
                    e.Effect = DragDropEffects.None;
                }
            }

            if (e.Effect == DragDropEffects.Move)
            {
                if (!MoveFile(sourceFile))
                {
                    e.Effect = DragDropEffects.None;
                }
            }
        }
    }


    private void ListViewDestinations_DragOver(object sender, DragEventArgs e)
    {
        if (!e.Data.GetDataPresent(typeof(string)))
        {
            e.Effect = DragDropEffects.None;
            return;
        }

        var localPoint = listViewDestinations.PointToClient(new Point(e.X, e.Y));
        var indexOfItemUnderMouseToDrop = listViewDestinations.GetItemAt(localPoint.X, localPoint.Y)?.Index ?? -1;

        if (indexOfItemUnderMouseToDrop < 0)
        {
            e.Effect = DragDropEffects.None;
            return;
        }

        listViewDestinations.Items[indexOfItemUnderMouseToDrop].Selected = true;

        if ((e.KeyState & 4) == 4 && (e.AllowedEffect & DragDropEffects.Move) == DragDropEffects.Move)
        {
            // SHIFT keystate for move
            e.Effect = DragDropEffects.Move;
        }
        else if ((e.KeyState & 8) == 8 && (e.AllowedEffect & DragDropEffects.Copy) == DragDropEffects.Copy)
        {
            // CTRL keystate for copy
            e.Effect = DragDropEffects.Copy;
        }
        else if ((e.AllowedEffect & DragDropEffects.Move) == DragDropEffects.Move)
        {
            // Default operation is Move.
            e.Effect = DragDropEffects.Move;
        }
        else
        {
            e.Effect = DragDropEffects.None;
        }
    }

    #endregion


    private static string GetNewFileName(string sourceFile, Destination destination, string captionText)
    {
        if (string.IsNullOrEmpty(sourceFile) || destination == null)
        {
            MessageBox.Show(@"Geen bron of bestemming geselecteerd.", captionText, MessageBoxButtons.OK, MessageBoxIcon.Error);
            return null;
        }

        var formNewFileName = new FormNewFilename(sourceFile, destination);

        var result = formNewFileName.ShowDialog();

        if (result != DialogResult.OK)
        {
            return null;
        }

        return formNewFileName.GetNewFileName();
    }


    private static bool MoveFileInternal(string sourceFullPath, string destinationFullPath, bool overwrite)
    {
        try
        {
            return IO.File.Move(sourceFullPath, destinationFullPath, overwrite);
        }
        catch (FileNotFoundException)
        {
            MessageBox.Show(@"Kon het bronbestand niet vinden.", MoveFileText, MessageBoxButtons.OK);
        }
        catch (IOException ioException)
        {
            MessageBox.Show(@"Het bestand bestaat al, kies een andere bestandsnaam. " + ioException.Message, MoveFileText, MessageBoxButtons.OK);
        }
        catch (Exception exception)
        {
            MessageBox.Show(@"Er ging iets fout: " + exception.Message, MoveFileText, MessageBoxButtons.OK);
        }
        return false;
    }


    private static bool CopyFileInternal(string sourceFullPath, string destinationFullPath, bool overwrite)
    {
        try
        {
            return IO.File.Copy(sourceFullPath, destinationFullPath, overwrite);
        }
        catch (FileNotFoundException)
        {
            MessageBox.Show(@"Kon het bronbestand niet vinden.", CopyFileText, MessageBoxButtons.OK);
        }
        catch (IOException ioException)
        {
            MessageBox.Show(@"Het bestand bestaat al, kies een andere bestandsnaam. " + ioException.Message, CopyFileText, MessageBoxButtons.OK);
        }
        catch (Exception exception)
        {
            MessageBox.Show(@"Er ging iets fout: " + exception.Message, CopyFileText, MessageBoxButtons.OK);
        }

        return false;
    }

    #region Contextmenu events

    private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
    {
        if (listViewDestinations.SelectedItems.Count == 0)
        {
            CopyToolStripMenuItem.Enabled = false;
            EditToolStripMenuItem.Enabled = false;
            DeleteToolStripMenuItem.Enabled = false;
        }
        else
        {
            CopyToolStripMenuItem.Enabled = true;
            EditToolStripMenuItem.Enabled = true;
            DeleteToolStripMenuItem.Enabled = true;
        }
    }

    private void AddToolStripMenuItem_Click(object sender, EventArgs e)
    {
        AddDestination();
    }

    private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
    {
        CopyDestination();
    }

    private void EditToolStripMenuItem_Click(object sender, EventArgs e)
    {
        EditDestination();
    }

    private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
    {
        DeleteDestination();
    }

    #endregion
}
