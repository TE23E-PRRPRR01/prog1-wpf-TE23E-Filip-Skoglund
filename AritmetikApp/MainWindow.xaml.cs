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
            lblResultat.Content = UtförBeräkning(tal1, tal2);
        }
        else
        {
            lblResultat.Content = "Ogiltig inmatning";
        }
    }


    // ============== METODER ==============

    /// <summary>
    /// Metod som utför beräkningar
    /// </summary>
    /// <param name="tal1"></param>
    /// <param name="tal2"></param>
    /// <returns></returns>
    public string UtförBeräkning(double tal1, double tal2)
    {
        switch (tbxOperator.Text.Trim())
        {
            case "+":
                return $"{tal1} + {tal2} = {tal1 + tal2}";
            case "-":
                return $"{tal1} - {tal2} = {tal1 - tal2}";
            case "*":
                return $"{tal1} * {tal2} = {Math.Round(tal1 * tal2, 2)}";
            case "/":
                if (tal2 != 0)
                {
                    return $"{tal1} / {tal2} = {Math.Round(tal1 / tal2, 2)}";
                }
                else
                {
                    return "Division by 0 is illegal";
                }
            default:
                return "Ogiltig operatör";
        }
    }
}