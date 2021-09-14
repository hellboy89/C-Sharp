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
using System.Diagnostics;

namespace combo_artsoft
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

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void botaoSap(object sender, RoutedEventArgs e)
        {
            Process.Start("ncpa.cpl");
        }

        private void butaoNotepad(object sender, RoutedEventArgs e)
        {
            Process.Start("notepad.exe");
        }

        private void butaoPaint(object sender, RoutedEventArgs e)
        {
            Process.Start("mspaint.exe");
        }

        private void butaoLogoff(object sender, RoutedEventArgs e)
        {
            Process.Start("logoff");
        }
    }
}
