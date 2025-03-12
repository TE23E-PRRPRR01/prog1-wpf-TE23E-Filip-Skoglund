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

namespace JulklappApp;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{

    // Initierar vi våra varabler
    int maxJulklappar = 0;
    List<string> listaJulklappar = [];

    public MainWindow()
    {
        InitializeComponent();

        // Lås gränssnitt
        stpInmatning.IsEnabled = false;
        stpListan.IsEnabled = false;
    }


    private void KlickAnge(object sender, RoutedEventArgs e)
    {
        // Läs av rutan
        string antal = txbAntal.Text;

        // Enkel kontroll
        if (string.IsNullOrWhiteSpace(antal))
        {
            txbStatus.Text = "Ange antal julklappar";
        }
        else
        {
            bool lyckades = int.TryParse(antal, out int talet);
            // Om lyckades
            if (lyckades)
            {
                // Sätt max julklappar till talet som inmatades
                maxJulklappar = talet;

                // Lås upp gränssnitt
                stpInmatning.IsEnabled = true;
                stpListan.IsEnabled = true;
                stpMax.IsEnabled = false;
            }
            else
            {
                txbStatus.Text = "Vg ange ett heltal";
            }
        }
    }

    private void KlickLäggTill(object sender, RoutedEventArgs e)
    {
        
    }

    private void KlickBytUt(object sender, RoutedEventArgs e)
    {

    }
}