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
using AssemblyPC.PCComponents;

namespace AssemblyPC
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SelectComponents(object sender, RoutedEventArgs e)
        {
        //    Button fieldComponent = (Button)sender;

        //    MessageBox.Show(fieldComponent.Content.ToString());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AddComponentDB secondWindow = new AddComponentDB();
            secondWindow.Show();
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            Application.Current.Shutdown();
        }

    }
}
