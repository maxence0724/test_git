using ConsoleApp.PostgreSQL;
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
using GestImmo.DATA.Models;

namespace GestImmo.Views.SubView
{
    /// <summary>
    /// Logique d'interaction pour ListBienView.xaml
    /// </summary>
    public partial class ListBienView : Page
    {
        GestImmoContext gestImmocontext = GestImmoContext.getInstance();

        public ListBienView()
        {
            InitializeComponent();

        }

        private void ListeBien_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           



        }
    }
}
