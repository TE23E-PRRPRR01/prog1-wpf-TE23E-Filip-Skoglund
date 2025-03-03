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
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace EpostApp;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    // Hantera klick på knappen Skicka
    private void KlickSkicka(object sender, RoutedEventArgs e)
    {
        string epost = tbxEpost.Text;
        string meddelande = tbxMeddelande.Text;

        // Kontrollera att användaren har skrivit in en epostadress
        string regexEpost = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
        if (!Regex.IsMatch(epost, regexEpost))
        {
            // Visa felmeddelande
            lblStatus.Content = "Du måste ange en giltig epostadress!";
        }
        else
        {
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.EnableSsl = true;
            smtp.Credentials = new NetworkCredential("filip.skoglund@elev.ga.ntig.se", "");
            smtp.Send("filip.skoglund@elev.ga.ntig.se", epost, "Meddelande från WPF", meddelande);

             lblStatus.Content = "Meddelandet skickades!";
        }
    }
}
