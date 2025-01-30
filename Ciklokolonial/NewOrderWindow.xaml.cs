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

namespace Ciklokolonial
{
    /// <summary>
    /// Interakční logika pro NewOrderWindow.xaml
    /// </summary>
    public partial class NewOrderWindow : Window
    {

        public Kolo CreatedOrder { get; private set; }

        public event Action<Kolo> OrderCreated;

        public NewOrderWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Get the selected values from each ComboBox
            string sedadlo = (comboBox1.SelectedItem as ComboBoxItem)?.Content.ToString();
            string barva = (comboBox2.SelectedItem as ComboBoxItem)?.Content.ToString();
            int velikost = int.TryParse((comboBox3.SelectedItem as ComboBoxItem)?.Content.ToString(), out int result) ? result : 0;
            bool blatniky = (comboBox4.SelectedItem as ComboBoxItem)?.Content.ToString() == "True";

            // Create a new bike object
            CreatedOrder = new Kolo(sedadlo, barva, velikost, blatniky);

            // Notify the main window about the new order
            OrderCreated?.Invoke(CreatedOrder);

            // Close the window
            this.Close();
        }
    }
}
