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
  public partial class AddPage : Page
  {
        public const string type1 = "Tops";
        public const string type2 = "Bottoms";
        public const string type3 = "Shoes";

        public const string condition1 = "Clean";
        public const string condition2 = "Dirty";


        public Cloth _cloth;


        public AddPage()
        {
            

            InitializeComponent();
            mainGrid.DataContext = this;
            SizeTextBox.Text = "";
            ConditionComboBox.ItemsSource = new string[] { condition1, condition2 };
            TypeComboBox.ItemsSource = new string[] { type1, type2, type3 };

        }
        public string Type { get; set; }
        public string Name { get; set; }
        public int Size { get; set; }
        public bool Condition { get; set; }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
          if (TypeComboBox.Text == "")
          {
            MessageBox.Show("Enter the type of clothing");
            return;
          }
          if (NameTextBox.Text == "")
          {
            MessageBox.Show("Enter the name of clothing");
            return;
          }
          if (SizeTextBox.Text == "")
          {
            MessageBox.Show("Enter the size of clothing");
            return;
          }
          if (ConditionComboBox.Text == "")
          {
            MessageBox.Show("Enter the condition of clothing");
            return;
          }
                try
                {
                    _cloth = new Cloth
                    {
                        Name = NameTextBox.Text,
                        Size = int.Parse(SizeTextBox.Text),
                        Type = TypeComboBox.Text
                    };

                    if (ConditionComboBox.SelectedIndex == 0)
                    {
                        _cloth.Condition = true;
                    }
                    else
                    {
                        _cloth.Condition = false;
                    }

                    using (Context context = new Context())
                    {
                        context.Clothes.Add(_cloth);
                    context.SaveChanges();
                    }

                }
                catch (Exception excep)
                {
                    MessageBox.Show($" {excep.Message}", "Error!");
                }
        }
        private void Back_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("StartingPage.xaml", UriKind.RelativeOrAbsolute));
        }

       

        private void TypeComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (_cloth != null)
            {

                int index = ConditionComboBox.SelectedIndex;

                if (index == 0)
                {
                    _cloth.Condition = false;
                }
                else
                    _cloth.Condition = true;

            }
        }
    }
}

