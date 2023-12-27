using System.ComponentModel;
using Microsoft.VisualBasic.FileIO;
using SearchOption = System.IO.SearchOption;


namespace PdfDocumentHandler.UserControls;

public partial class SourceControl : UserControl
{
    public event MoveFileEventHandler MoveFile;
    public event CopyFileEventHandler CopyFile;
    public event SelectedIndexChangedEventHandler SelectedIndexChanged;


    public SourceControl()
    {
        InitializeComponent();
    }


    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public List<string> SourceFolders
    {
        get
        {
            return GetSourceFoldersFromComboBox();
        }
        set
        {
            PopulateComboBox(value);
        }
    }


    public override void Refresh()
    {
        base.Refresh();
        RefreshFiles();
    }


    public void Clear()
    {
        listViewSource.Items.Clear();
        comboBoxSourceFolders.Items.Clear();
    }


    #region ComboBox Source Folders methods

    private void PopulateComboBox(IReadOnlyCollection<string> sourceFolders)
    {
        comboBoxSourceFolders.Items.Clear();

        if (sourceFolders != null && sourceFolders.Count > 0)
        {
            var counter = 0;
            foreach (var sourceFolder in sourceFolders)
            {
                comboBoxSourceFolders.Items.Add(sourceFolder);

                // No more than 10 items in the list. (Why? Why not 20?)
                if (++counter > 10)
                {
                    break;
                }
            }
            // Set selected item
            comboBoxSourceFolders.SelectedIndex = 0;
        }
        else
        {
            comboBoxSourceFolders.SelectedIndex = -1;
        }
    }


    private List<string> GetSourceFoldersFromComboBox()
    {
        return comboBoxSourceFolders.Items.Cast<string>().ToList();
    }


    private static void AddDirectoryToComboBox(ComboBox comboBox, string directory)
    {
        comboBox.SelectedIndex = -1;

        var items = comboBox.Items;
        var indexOf = IndexOf(comboBox, directory);

        if (indexOf >= 0)
        {
            items.RemoveAt(indexOf);
        }

        items.Insert(0, directory);

        if (items.Count > 10)
        {
            items.RemoveAt(10);
        }

        comboBox.SelectedIndex = 0;
    }


    private static void ReorderComboBoxItems(ComboBox comboBox, string directory)
    {
        var items = comboBox.Items;
        var indexOf = IndexOf(comboBox, directory);

        if (indexOf <= 0)
        {
            return;
        }

        comboBox.SelectedIndex = -1;

        items.RemoveAt(indexOf);
        items.Insert(0, directory);

        comboBox.SelectedIndex = 0;
    }


    private static int IndexOf(ComboBox comboBox, string directory)
    {
        var result = -1;

        foreach (string comboBoxItem in comboBox.Items)
        {
            result++;

            if (comboBoxItem.Equals(directory, StringComparison.OrdinalIgnoreCase))
            {
                return result;
            }
        }

        return -1;
    }


    private string GetSelectedSourceFolder()
    {
        if (comboBoxSourceFolders.SelectedIndex >= 0)
        {
            return comboBoxSourceFolders.SelectedItem as string;
        }
        return comboBoxSourceFolders.Text;
    }

    #endregion


    #region ListView PDF files methods

    private string GetSelectedSourceFile()
    {
        if (listViewSource.SelectedIndices.Count == 1)
        {
            return listViewSource.SelectedItems[0].SubItems[1].Text;
        }
        return null;
    }


    private void RemoveSelectedSourceFile()
    {
        if (listViewSource.SelectedIndices.Count == 1)
        {
            var currentIndex = CurrentIndex;

            listViewSource.Items.RemoveAt(listViewSource.SelectedIndices[0]);

            CurrentIndex = currentIndex;
        }
    }


    private int CurrentIndex
    {
        get
        {
            if (listViewSource.SelectedIndices.Count > 0)
            {
                return listViewSource.SelectedIndices[0];
            }
            return -1;
        }
        set
        {
            listViewSource.SelectedIndices.Clear();
            listViewSource.SelectedItems.Clear();

            if (listViewSource.Items.Count > 0)
            {
                var index = Math.Min(value, listViewSource.Items.Count - 1);

                if (index >= 0)
                {
                    // Er gaat hier iets fout als de pdf te groot is.
                    listViewSource.Items[index].Selected = true;
                }
            }
        }
    }


    private void FillListViewWithPdfDocumentsFromDirectory(string directory)
    {
        if (string.IsNullOrEmpty(directory))
        {
            return;
        }

        if (!Directory.Exists(directory))
        {
            return;
        }

        var files = Directory.GetFiles(directory, "*.pdf", SearchOption.TopDirectoryOnly);

        listViewSource.Items.Clear();

        foreach (var file in files)
        {
            var fileName = Path.GetFileName(file);

            var listItem = new ListViewItem {Text = fileName};
            listItem.SubItems.Add(file);

            listViewSource.Items.Add(listItem);
        }
    }

    #endregion


    private void OnMoveFile()
    {
        var moveEventArgs = new MoveEventArgs
        {
            FolderName = GetSelectedSourceFolder(),
            FileName   = GetSelectedSourceFile()
        };

        if (MoveFile != null)
        {
            MoveFile(this, moveEventArgs);

            if (moveEventArgs.Canceled == false)
            {
                RemoveSelectedSourceFile();
                OnSelectedIndexChanged();
            }
        }
    }


    private void MoveFileAs()
    {
        saveFileDialog1.OverwritePrompt = true;
        saveFileDialog1.FileName        = Path.GetFileName(GetSelectedSourceFile());
        saveFileDialog1.DefaultExt      = "pdf";
        saveFileDialog1.Filter          = @"Pdf files (*.pdf)|*.pdf|All files (*.*)|*.*";

        if (saveFileDialog1.ShowDialog(this) == DialogResult.OK)
        {
            var sourceFileName = GetSelectedSourceFile();
            var destinationFileName = saveFileDialog1.FileName;

            MoveFileInternal(sourceFileName, destinationFileName, true);

            RemoveSelectedSourceFile();
            OnSelectedIndexChanged();
        }
    }


    private void MoveFileInternal(string sourceFullPath, string destinationFullPath, bool overwrite)
    {
        const string messageBoxCaption = "Verplaats bestand";

        try
        {
            IO.File.Move(sourceFullPath, destinationFullPath, overwrite);
        }
        catch (FileNotFoundException)
        {
            MessageBox.Show(@"Kon het bronbestand niet vinden.", messageBoxCaption, MessageBoxButtons.OK);
        }
        catch (IOException ioException)
        {
            MessageBox.Show(@"Het bestand bestaat al, kies een andere bestandsnaam. " + ioException.Message, messageBoxCaption, MessageBoxButtons.OK);
        }
        catch (Exception exception)
        {
            MessageBox.Show(@"Er ging iets fout: " + exception.Message, messageBoxCaption, MessageBoxButtons.OK);
        }
    }


    private void OnCopyFile()
    {
        var copyEventArgs = new CopyEventArgs
        {
            FolderName = GetSelectedSourceFolder(),
            FileName = GetSelectedSourceFile()
        };

        CopyFile?.Invoke(this, copyEventArgs);
    }


    private void CopyFileAs()
    {
        saveFileDialog1.OverwritePrompt = true;
        saveFileDialog1.FileName        = Path.GetFileName(GetSelectedSourceFile());
        saveFileDialog1.DefaultExt      = "pdf";
        saveFileDialog1.Filter          = @"Pdf files (*.pdf)|*.pdf|All files (*.*)|*.*";

        if (saveFileDialog1.ShowDialog(this) == DialogResult.OK)
        {
            var sourceFileName = GetSelectedSourceFile();
            var destinationFileName = saveFileDialog1.FileName;
            CopyFileInternal(sourceFileName, destinationFileName, true);
        }
    }


    private static void CopyFileInternal(string sourceFullPath, string destinationFullPath, bool overwrite)
    {
        const string messageBoxCaption = "Kopieer bestand";

        try
        {
            IO.File.Copy(sourceFullPath, destinationFullPath, overwrite);
        }
        catch (FileNotFoundException)
        {
            MessageBox.Show(@"Kon het bronbestand niet vinden.", messageBoxCaption, MessageBoxButtons.OK);
        }
        catch (IOException ioException)
        {
            MessageBox.Show(@"Het bestand bestaat al, kies een andere bestandsnaam. " + ioException.Message, messageBoxCaption, MessageBoxButtons.OK);
        }
        catch (Exception exception)
        {
            MessageBox.Show(@"Er ging iets fout: " + exception.Message, messageBoxCaption, MessageBoxButtons.OK);
        }
    }


    private void OnSelectedIndexChanged()
    {
        var selectedIndexChangedEventArgs = new SelectedIndexChangedEventArgs
        {
            FolderName = GetSelectedSourceFolder(),
            FileName   = GetSelectedSourceFile()
        };

        SelectedIndexChanged?.Invoke(this, selectedIndexChangedEventArgs);
    }


    public void RefreshFiles()
    {
        var directory    = GetSelectedSourceFolder();
        var currentIndex = CurrentIndex;
        FillListViewWithPdfDocumentsFromDirectory(directory);
        CurrentIndex = currentIndex;
    }


    private void DeleteFile()
    {
        const string messageBoxCaption = "Verwijder bestand";

        var sourceFolder = GetSelectedSourceFolder();
        var sourceFile   = GetSelectedSourceFile();

        var path = Path.Combine(sourceFolder, sourceFile ?? "");

        try
        {
            var result = MessageBox.Show(@"Bestand verwijderen?", @"Verwijder bestand", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                if (File.Exists(path))
                {
                    FileSystem.DeleteFile(path, UIOption.OnlyErrorDialogs, RecycleOption.SendToRecycleBin);
                }

                RemoveSelectedSourceFile();
                OnSelectedIndexChanged();
            }
        }
        catch (DirectoryNotFoundException)
        {
            MessageBox.Show($@"Kon het bestand {path} niet vinden.", messageBoxCaption, MessageBoxButtons.OK);
        }
        catch (Exception exception)
        {
            MessageBox.Show(@"Er ging iets fout: " + exception.Message, messageBoxCaption, MessageBoxButtons.OK);
        }
    }


    #region Control events

    private void ButtonBrowseSourceDirectory_Click(object sender, EventArgs e)
    {
        // Open the directory browser
        folderBrowserDialog1.SelectedPath = GetSelectedSourceFolder();
        folderBrowserDialog1.ShowNewFolderButton = false;

        var dialogResult = folderBrowserDialog1.ShowDialog(this);

        if (dialogResult == DialogResult.OK)
        {
            var directory = folderBrowserDialog1.SelectedPath;
            AddDirectoryToComboBox(comboBoxSourceFolders, directory);
            RefreshFiles();
        }
    }

    private void ComboBoxSourceFolders_Leave(object sender, EventArgs e)
    {
        if (comboBoxSourceFolders.SelectedIndex < 0)
        {
            // No selected item.
            if (!string.IsNullOrEmpty(comboBoxSourceFolders.Text))
            {
                var directory = comboBoxSourceFolders.Text;

                if (Directory.Exists(directory))
                {
                    AddDirectoryToComboBox(comboBoxSourceFolders, directory);
                    RefreshFiles();
                }
            }
        }
    }

    private void ComboBoxSourceFolders_SelectionChangeCommitted(object sender, EventArgs e)
    {
        var directory = GetSelectedSourceFolder();

        if (!string.IsNullOrEmpty(directory))
        {
            ReorderComboBoxItems(comboBoxSourceFolders, directory);
            RefreshFiles();
        }
    }

    private void ListViewSource_SelectedIndexChanged(object sender, EventArgs e)
    {
        OnSelectedIndexChanged();
    }

    private void ButtonCopy_Click(object sender, EventArgs e)
    {
        OnCopyFile();
    }

    private void ButtonMove_Click(object sender, EventArgs e)
    {
        OnMoveFile();
    }

    private void ButtonDelete_Click(object sender, EventArgs e)
    {
        DeleteFile();
    }

    private void ButtonRefresh_Click(object sender, EventArgs e)
    {
        RefreshFiles();
    }

    internal void SourceControl_KeyUp(object sender, KeyEventArgs e)
    {
        if (e.KeyData == Keys.F5)
        {
            OnCopyFile();
            e.Handled = true;
        }
        else if (e.KeyData == (Keys.F5 | Keys.Shift))
        {
            CopyFileAs();
            e.Handled = true;
        }
        else if (e.KeyData == Keys.F6)
        {
            OnMoveFile();
            e.Handled = true;
        }
        else if (e.KeyData == (Keys.F6 | Keys.Shift))
        {
            MoveFileAs();
            e.Handled = true;
        }
        else if (e.KeyData == Keys.F8)
        {
            DeleteFile();
            e.Handled = true;
        }
        else if (e.KeyData == (Keys.R | Keys.Control))
        {
            RefreshFiles();
            e.Handled = true;
        }
    }

    private void ListViewSource_ItemDrag(object sender, ItemDragEventArgs e)
    {
        var item = e.Item as ListViewItem;

        if (item == null) return;

        var sourceFile = item.SubItems[1].Text;
        var result = DoDragDrop(sourceFile, DragDropEffects.Copy | DragDropEffects.Move | DragDropEffects.Scroll);

        if (result == DragDropEffects.Move)
        {
            // File itself already deleted, remove the item from the listview.
            RemoveSelectedSourceFile();
        }
    }

    #endregion


    #region Context menu events

    private void ContextMenuStrip1_Opening(object sender, CancelEventArgs e)
    {
        if (listViewSource.SelectedItems.Count == 0)
        {
            e.Cancel = true;
        }
    }

    private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
    {
        OnCopyFile();
    }

    private void CopyAsToolStripMenuItem_Click(object sender, EventArgs e)
    {
        CopyFileAs();
    }

    private void MoveToolStripMenuItem_Click(object sender, EventArgs e)
    {
        OnMoveFile();
    }

    private void MoveAsToolStripMenuItem_Click(object sender, EventArgs e)
    {
        MoveFileAs();
    }

    private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
    {
        DeleteFile();
    }

    #endregion
}


public delegate void MoveFileEventHandler(object sender, MoveEventArgs e);
public delegate void CopyFileEventHandler(object sender, CopyEventArgs e);
public delegate void SelectedIndexChangedEventHandler(object sender, SelectedIndexChangedEventArgs e);


public class MoveEventArgs : EventArgs
{
    public bool Canceled { get; set; }
    public string FolderName { get; set; }
    public string FileName { get; set; }
}

public class CopyEventArgs : EventArgs
{
    public bool Canceled { get; set; }
    public string FolderName { get; set; }
    public string FileName { get; set; }
}

public class SelectedIndexChangedEventArgs : EventArgs
{
    public string FolderName { get; set; }
    public string FileName { get; set; }
}
