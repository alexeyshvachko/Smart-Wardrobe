using Classes;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
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
    public int Size { get; set; }
    public bool Condition { get; set; }

    private void Add_Click(object sender, RoutedEventArgs e) {
    if (Type == null) {
      MessageBox.Show("Enter the type of clothing");
      return;
      }
      if (NameTextBox.Text == "") {
        MessageBox.Show("Enter the name of clothing");
        return;
      }
      if (SizeTextBox.Text == "") {
        MessageBox.Show("Enter the size of clothing");
        return;
      }
        if (ConditionTextBox.Text == "") {
        MessageBox.Show("Enter the condition of clothing");
        return;
        }
            try
            {
                var a = new Cloth
                {
                    Name = NameTextBox.Text,
                    Size = int.Parse(SizeTextBox.Text),
                    Condition = bool.Parse(ConditionTextBox.Text),
                    Type = TypeTexBox.Text
                };
                using (Context context = new Context())
                {
                    if (!context.Clothes.Contains(a))
                    {
                        context.Clothes.AddOrUpdate(a);
                    }

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Size is an int value" +
                    "Condition is bool", "Error!");
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

