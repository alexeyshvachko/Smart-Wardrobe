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
using static Classes.Repository;

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
    public string Type { get; set; }
    public string Name { get; set; }
    public string Size { get; set; }
    public string Condition { get; set; }

    private void Add_Click(object sender, RoutedEventArgs e) {
    if (Type == null || Type.Equals(string.Empty)) {
      MessageBox.Show("Enter the type of clothing");
      return;
      }
      if (Name == null || Name.Equals(string.Empty)) {
        MessageBox.Show("Enter the name of clothing");
        return;
      }
      if (Size == null || Size.Equals(string.Empty)) {
        MessageBox.Show("Enter the size of clothing");
        return;
        }
        if (Condition == null || !Condition.Equals(string.Empty)) {
        MessageBox.Show("Enter the condition of clothing");
        return;
        }

      //  var err = this.AddPage.AddClothes(Type, Name, Size, Condition);
      //  if (err != null) {
      //    MessageBox.Show(err);
      //  }
    }
    private void Back_Click(object sender, RoutedEventArgs e) {
      this.NavigationService.Navigate(new Uri("StartingPage.xaml", UriKind.RelativeOrAbsolute));
      }
    }
  }

