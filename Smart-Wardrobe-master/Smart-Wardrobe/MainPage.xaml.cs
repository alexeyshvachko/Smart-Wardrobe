﻿using Classes;
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
    /// Interaction logic for MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        List<Cloth> _clothes;

        public MainPage()
        {
            InitializeComponent();   

            _clothes = new List<Cloth>
            {
                new Cloth
                {
                    Type="Bottoms",
                    Name = "hhjhj",
                    Size=50,
                    Condition = false
                },

                new Cloth
                {
                    Type="Tops",
                    Name  = "hjsdjdhjhj",
                    Size=46,
                    Condition = true
                }
    
            };

            DataGridItemSources();
        }


        private void DataGridItemSources( )
        {
            cleanGrid.ItemsSource = _clothes
                .Where(c => c.Condition);

            dirtyGrid.ItemsSource = _clothes
                .Where(c => !c.Condition);
        }

    
  }
}
