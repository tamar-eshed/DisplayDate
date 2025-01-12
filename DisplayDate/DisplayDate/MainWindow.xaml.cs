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

namespace DisplayDate
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Loaded += MainWindow_Loaded; // הוספת אירוע טעינת הטופס

        }
        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            // קבלת התאריך והשעה הנוכחיים
            DateTime currentDateTime = DateTime.Now;

            // עדכון תוכן ה-Label
            DateLabel.Content = currentDateTime.ToString("dd/MM/yyyy HH:mm:ss");
        }

    }
}

