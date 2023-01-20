using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace LostFocus
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void aaa(object sender, RoutedEventArgs e)
        {

        }

        private void bbb(object sender, RoutedEventArgs e)
        {

        }

        private void ccc(object sender, KeyboardFocusChangedEventArgs e)
        {
            Debug.WriteLine("lost focus...");
            
        }

        private void ddd(object sender, MouseEventArgs e)
        {
            
        }

        private void eee(object sender, StylusEventArgs e)
        {

        }

        private void fff(object sender, TouchEventArgs e)
        {

        }
    }
}
