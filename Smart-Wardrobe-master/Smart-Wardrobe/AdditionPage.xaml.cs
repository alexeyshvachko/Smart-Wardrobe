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

namespace Smart_Wardrobe
{
  /// <summary>
  /// Interaction logic for AdditionPage.xaml
  /// </summary>
  public partial class AddPage : Page {
    public AddPage() {
      InitializeComponent();
      mainGrid.DataContext = this;
    }

    private void Add_Click(object sender, RoutedEventArgs e) {

    }

    private void Back_Click(object sender, RoutedEventArgs e) {
      this.NavigationService.Navigate(new Uri("StartingPage.xaml", UriKind.RelativeOrAbsolute));
    }

    
  }
}

