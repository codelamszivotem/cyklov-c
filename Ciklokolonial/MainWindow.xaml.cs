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

namespace Ciklokolonial
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Kolo kolo;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click_Objednavka(object sender, RoutedEventArgs e)
        {
            NewOrderWindow newWindow = new NewOrderWindow();

            // Subscribe to the OrderCreated event
            newWindow.OrderCreated += NewOrderReceived;

            // Show the new window
            newWindow.Show();
        }

        private void NewOrderReceived(Kolo newOrder)
        {
            string jmeno = JmenoTextbox.Text;
            string prijmeni = PrijmeniTextbox.Text;

            // Kontrola na validní věk
            if (!int.TryParse(VekTextbox.Text, out int vek))
            {
                throw new FormatException("Věk musí být celé číslo.");
            }

            string orderDescription =
                $"Kupující: {jmeno} {prijmeni}, {vek} let\n" +
                $"Sedadlo: {newOrder.Sedadlo}, Barva: {newOrder.Barva}, Velikost kol: {newOrder.VelikostKol}, Blatníky: {(newOrder.Blatniky ? "Ano" : "Ne")}";

            // Přidat popis objednávky do ListBoxu
            ObjednavkyListbox.Items.Add(orderDescription);
        }


        private void Button_Click_Update(object sender, RoutedEventArgs e)
        {
            string jmeno = JmenoTextbox.Text;  
            string prijmeni = PrijmeniTextbox.Text; 
            string vek = VekTextbox.Text;

            string updatedAccountInfo = $"Účet: {jmeno} {prijmeni}, {vek} let";
            ObjednavkyListbox.Items.Add(updatedAccountInfo);
        }

    }
}
