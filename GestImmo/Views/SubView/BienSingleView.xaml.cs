﻿using System;
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
using GestImmo.DATA.Models;
using GestImmo.Views.Forms;

namespace GestImmo.Views.SubView
{
    /// <summary>
    /// Logique d'interaction pour BienSingleView.xaml
    /// </summary>
    public partial class BienSingleView : Page
    {
        public BienSingleView()
        {
            InitializeComponent();
        }

        private void FrameSingleView_Navigated(object sender, NavigationEventArgs e)
        {

        }

        private void ListAffichage_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
