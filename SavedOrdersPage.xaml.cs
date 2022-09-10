using Formatka.ViewModel;
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

namespace Formatka
{
    /// <summary>
    /// Interaction logic for SavedOrdersPage.xaml
    /// </summary>
    public partial class SavedOrdersPage : Page
    {
        FormatkaViewModel FormatkaVM;
        Frame Frame;
        public SavedOrdersPage()
        {
            InitializeComponent();
        }
        public SavedOrdersPage(Frame frame2, FormatkaViewModel FormatkaVM)
        {
            InitializeComponent();
            this.Frame = frame2;
            this.FormatkaVM = FormatkaVM;
        }
        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            //TODO: stosować wymiennie
            //Frame.Navigate(new FormatkaHome(Frame, FormatkaVM));
            this.Frame.NavigationService.GoBack();
        }
    }
}
