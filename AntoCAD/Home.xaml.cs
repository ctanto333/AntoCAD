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

namespace AntoCAD
{
    /// <summary>
    /// Interaction logic for Home.xaml
    /// </summary>
    public partial class Home : Page
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Form_4_W_O_BUS_COUPLER_Click(object sender, RoutedEventArgs e)
        {
            Uri uri = new Uri("\\Form_4_W_O_BUS_COUPLER.xaml", UriKind.Relative);
            this.NavigationService.Navigate(uri);
        }
    }
}
