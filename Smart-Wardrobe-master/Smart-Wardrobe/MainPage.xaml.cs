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

namespace Smart_Wardrobe
{
    /// <summary>
    /// Interaction logic for MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public const string type1 = "Tops";
        public const string type2 = "Bottoms";
        public const string type3 = "Shoes";

        public Cloth _cloth;

        public Repository Store { get; set; }

        public MainPage()
        {
            InitializeComponent();
            Store = new Repository();
            DataGridItemSources();
            TypesComboBox.ItemsSource = new string[] { type1, type2, type3 };
        }

        private void DataGridItemSources()
        {
            using (Context context = new Context())
            {
                CleanGrid.ItemsSource = context.Clothes
                .Where(c => c.Condition).ToList();

                DirtyGrid.ItemsSource = context.Clothes
                    .Where(c => !c.Condition).ToList();
            }
        }

        private void Action_Click(object sender, RoutedEventArgs e)
        {
            var clean = CleanGrid.SelectedItem as Cloth;
            var dirty = DirtyGrid.SelectedItem as Cloth;
            if (clean != null && dirty == null)
            {

                using (Context context = new Context())
                {
                    clean.Condition = false;
                    context.Clothes.AddOrUpdate(clean);
                    context.SaveChanges();
                    DataGridItemSources();
                }
            }
            if (clean == null && dirty != null)
            {
                using (Context context = new Context())
                {
                    dirty.Condition = true;
                    context.Clothes.AddOrUpdate(dirty);
                    context.SaveChanges();
                    DataGridItemSources();
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("StartingPage.xaml", UriKind.RelativeOrAbsolute));
        }

        private void TypesComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (_cloth != null)
            {
                string item = TypesComboBox.SelectedItem as string;
                using (Context context = new Context())
                {
                    if (_cloth.Type == item)
                    {                       
                        CleanGrid.ItemsSource = context.Clothes.
                               Where(c => c.Type == item).ToList();

                        DirtyGrid.ItemsSource = context.Clothes.
                            Where(c => c.Type == item).ToList();
                    }
                }
            }
        }
    }
}

