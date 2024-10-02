using System.Text;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MassRenameFilesView massRenameFilesView = new MassRenameFilesView();

        MergeImagesView mergeImagesView = new MergeImagesView();

        public MainWindow()
        {
            InitializeComponent();

            this.CurrentTabContentPresenter.Content = this.massRenameFilesView;
        }

        private void OnMassRenameFilesTabClick(object sender, RoutedEventArgs e)
        {
            this.CurrentTabContentPresenter.Content = this.massRenameFilesView;
        }

        private void OnMergeImagesTabClick(object sender, RoutedEventArgs e)
        {
            this.CurrentTabContentPresenter.Content = this.mergeImagesView;
        }
    }
}