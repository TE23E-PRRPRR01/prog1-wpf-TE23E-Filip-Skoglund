using System.Collections;
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

namespace AritmetikApp;

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
        if (double.TryParse(tbxTal1.Text.Trim(), out double tal1) && double.TryParse(tbxTal2.Text.Trim(), out double tal2))
        {
            switch (tbxOperator.Text.Trim())
            {
                case "+":
                    lblResultat.Content = $"{tal1} + {tal2} = {tal1 + tal2}";
                    break;
                case "-":
                    lblResultat.Content = $"{tal1} - {tal2} = {tal1 - tal2}";
                    break;
                case "*":
                    lblResultat.Content = $"{tal1} * {tal2} = {Math.Round(tal1 * tal2, 2)}";
                    break;
                case "/":
                    if (tal2 != 0)
                    {
                        lblResultat.Content = $"{tal1} / {tal2} = {Math.Round(tal1 / tal2, 2)}";
                    }
                    else
                    {

                        lblResultat.Content = "Division by 0 is illegal";
                    }
                    break;
                default:
                    lblResultat.Content = "Ogiltig operatör";
                    break;
            }
        }
        else
        {
            lblResultat.Content = "Ogiltig inmatning";
        }
    }
}