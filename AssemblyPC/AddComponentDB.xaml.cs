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
using System.Windows.Shapes;
using AssemblyPC.Creators;

namespace AssemblyPC
{
    /// <summary>
    /// Logika interakcji dla klasy AddComponentDB.xaml
    /// </summary>
    public partial class AddComponentDB : Window
    {
        Grid prevItem;
        ComboBoxItem item;
        ComponentCreator creator;
        public AddComponentDB()
        {
            InitializeComponent();
            prevItem = AddCPUGrid;
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            item = ComboComponents.SelectedItem as ComboBoxItem;

            if (prevItem != null)
            {
                switch (item.Name)
                {
                    case "CB_CPU":
                        changeGridView(AddCPUGrid);
                        break;
                    case "CB_GPU":
                        changeGridView(AddGPUGrid);
                        break;
                    case "CB_MOBA":
                        changeGridView(AddMOBAGrid);
                        break;
                    case "CB_RAM":
                        changeGridView(AddRAMGrid);
                        break;
                    case "CB_POWER":
                        changeGridView(AddPowerSupplyGrid);
                        break;
                    case "CB_ENCLOSURE":
                        changeGridView(AddEnclosureGrid);
                        break;
                    case "CB_DISK":
                        changeGridView(AddHardDiskGrid);
                        break;            
                }
            }
        }
        private void changeGridView(Grid gridComponent)
        {
            prevItem.Visibility = Visibility.Collapsed;
            gridComponent.Visibility = Visibility.Visible;
            prevItem = gridComponent;
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                creator = new ComponentCreator(ProducentTXT.Text.ToString(), ModelTXT.Text.ToString(), decimal.Parse(PriceTXT.Text.ToString()), AddInfoTXT.Text.ToString(), int.Parse(MaxMOCTXT.Text.ToString()), FormatTXT.Text.ToString());
                await creator.SendToDBAsync();
                MessageBox.Show("Udało się!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

    }
}
