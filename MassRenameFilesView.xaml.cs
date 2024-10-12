using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Mass_Image_Merging_And_Renaming_Tool
{
    /// <summary>
    /// Interaction logic for MassRenameFilesView.xaml
    /// </summary>
    public partial class MassRenameFilesView : UserControl
    {
        public ObservableCollection<FilesToRenameTableEntry> FilesToRenameTableEntries { get; set; } = [];

        public MassRenameFilesView()
        {
            this.DataContext = this;

            InitializeComponent();
        }

        private void OnAddFilesButtonClick(object sender, RoutedEventArgs e)
        {
            OpenFileDialog fileSelectionDialog = new OpenFileDialog()
            {
                Multiselect = true,
            };

            bool? didUserClickOkButton = fileSelectionDialog.ShowDialog();

            if (didUserClickOkButton == null || didUserClickOkButton == false)
            {
                return;
            }

            foreach (string selectedFilePath in fileSelectionDialog.FileNames)
            {
                this.FilesToRenameTableEntries.Add(
                    new FilesToRenameTableEntry()
                    {
                        filesToRenameTableEntries = this.FilesToRenameTableEntries,
                        FilePath = selectedFilePath,

                    }
                );
            }
        }

        public class FilesToRenameTableEntry
        {
            public ObservableCollection<FilesToRenameTableEntry> filesToRenameTableEntries;

            public string FilePath { get; set; } = "";

            public DateTime DateTimeOfLatestUpdate
            {
                get
                {
                    return File.GetLastWriteTime(this.FilePath);
                }
            }

            public string DateTimeOfLatestUpdateAsString
            {
                get
                {
                    string dateTimeOfLatestUpdateAsString = this.DateTimeOfLatestUpdate.ToString("dd/MM/yyyy hh:mm:ss tt");

                    return dateTimeOfLatestUpdateAsString;
                }
            }

            public string NewFileName
            {
                get
                {
                    return Convert.ToString(
                        this.filesToRenameTableEntries.IndexOf(this)
                    );
                }
            }
        }
    }
}
