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
        string text = tbxMeddelande.Text;

        if (epost.Length == 0)
        {
            lblStatus.Text = "Du måste ange en epostadress!";
        }
        else
        {
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.EnableSsl = true;
            smtp.Credentials = new NetworkCredential("user", "pass");
            smtp.Send(id, epost, "Meddelande från WPF", text);

            lblStatus.Text = "Meddelandet skickades!";
        }
    }
}
