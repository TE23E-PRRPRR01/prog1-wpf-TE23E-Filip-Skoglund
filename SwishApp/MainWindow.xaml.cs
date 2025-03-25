using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SwishApp;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    // Globala variabler
    int saldo;

    public MainWindow()
    {
        InitializeComponent();
        tbxSaldo.IsEnabled = false;
        saldo = Random.Shared.Next(100, 301);
        tbxSaldo.Text = $"{saldo}";
    }


    private void KlickaSwisha(object sender, RoutedEventArgs e)
    {
        if (int.TryParse(tbxÖnskat.Text, out int amount) && amount <= saldo)
        {
            // Skriv ut meddelnade
            lblOutput.Content = $"Swishat {amount}";

            // Räkna ut nytt saldo och updatera det
            saldo -= amount;
            tbxSaldo.Text = $"{saldo}";
        }
        else if (amount > saldo)
        {
            lblOutput.Content = $"För lite pengar på kontot. \nDu saknar {amount - saldo}kr för att kunna swisha.";
        }
        else
        {
            lblOutput.Content = $"Ogiltigt belopp, \nGiltigt belopp: 0 - {saldo}kr";
        }
    }
}