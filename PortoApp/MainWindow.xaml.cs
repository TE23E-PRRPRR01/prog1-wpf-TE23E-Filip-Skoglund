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

namespace PortoApp;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void KlickBeräkna(object sender, RoutedEventArgs e)
    {
        if (int.TryParse(tbxVikt.Text, out int vikt))
        {
            switch (vikt)
            {
                case <= 0:
                    resultat.Content = "Ogiltig vikt, (1-2000g)";
                    break;
                case <= 50:
                    resultat.Content = $"Brev som väger {vikt} g kostar 22 kr (1 frimärke)";
                    break;
                case <= 100:
                    resultat.Content = $"Brev som väger {vikt} g kostar 44 kr (2 frimärke)";
                    break;
                case <= 250:
                    resultat.Content = $"Brev som väger {vikt} g kostar 66 kr (3 frimärke)";
                    break;
                case <= 500:
                    resultat.Content = $"Brev som väger {vikt} g kostar 88 kr (4 frimärke)";
                    break;
                case <= 1000:
                    resultat.Content = $"Brev som väger {vikt} g kostar 132 kr (6 frimärke)";
                    break;
                case <= 2000:
                    resultat.Content = $"Brev som väger {vikt} g kostar 154 kr (7 frimärke)";
                    break;
                default:
                    resultat.Content = "Ogiltig vikt, (1-2000g)";
                    break;
            }
        }
        else
        {
            resultat.Content = "Ogiltig vikt, (1-2000g)";
        }
    }
}