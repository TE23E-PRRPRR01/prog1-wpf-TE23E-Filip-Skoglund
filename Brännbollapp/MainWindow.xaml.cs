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

namespace Brännbollapp;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    // Skapa variablerna för lagen
    int poängInne = 0;
    int poängUte = 0;
    
    List<string> historik = [];

    private void KlickFrivarv(object sender, RoutedEventArgs e)
    {
        // Lägg till 5 poäng
        poängInne += 5;

        // Skriv ut poäng
        txbInne.Text = $"{poängInne}";

        // Vad är klockan just nu?
        DateTime nu = DateTime.Now;

        // Skriv i historiken
        txbHistory.Text += $"{nu} Lag inne + 5, totalt: {poängInne}\n";
    }

    private void KlickBränn(object sender, RoutedEventArgs e)
    {
        // Lägg till 2 poäng
        poängUte += 2;

        // Skriv ut poäng
        txbUte.Text = $"{poängUte}";// Skapa variablerna för lagen

        // Vad är klockan just nu?
        DateTime nu = DateTime.Now;

        // Skriv i historiken
        txbHistory.Text += $"{nu} Lag ute + 2, totalt: {poängUte}\n";
    }

    private void KlickLyra(object sender, RoutedEventArgs e)
    {
        // Lägg till 3 poäng
        poängUte += 3;

        // Skriv ut poäng
        txbUte.Text = $"{poängUte}";

        // Vad är klockan just nu?
        DateTime nu = DateTime.Now;

        // Skriv i historiken
        txbHistory.Text += $"{nu} Lag ute + 3, totalt: {poängUte}\n";
    }


    private void KlickVarv(object sender, RoutedEventArgs e)
    {
        // Lägg till 1 poäng
        poängInne += 1;

        // Skriv ut poäng
        txbInne.Text = $"{poängInne}";

        // Vad är klockan just nu?
        DateTime nu = DateTime.Now;

        // Skriv i historiken
        txbHistory.Text += $"{nu} Lag inne + 1, totalt: {poängInne}\n";
    }
}