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

namespace Kritter.UI
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            //TODO
            //Search for cultureInfo in BDD
            String language = "";

            KritterLib.Resources.Kritter.Culture = new System.Globalization.CultureInfo(language);

            LoginForm lf = new LoginForm();
            lf.ShowDialog();

            //KritterLib.Helpers.DatabaseHelper dh = new KritterLib.Helpers.DatabaseHelper();
            //dh.Up();

            KritterLib.Helpers.DatabaseHelper.FunctionResult();

            InitializeComponent();
        }
    }
}
