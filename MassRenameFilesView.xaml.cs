using Microsoft.Win32;
using System;
using System.Collections.Generic;
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
        List<FilesToRenameTableEntry> filesToRenameTableEntries = [];

        public MassRenameFilesView()
        {
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

            // TODO
        }

        private class FilesToRenameTableEntry
        {
            public string filePath = "";

            public DateTime dateTimeOfLatestUpdate;

            public string newFileName = "";
        }
    }
}
