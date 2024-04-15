using OdemePlanı_11.UI;
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

namespace OdemePlanı_11
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        UserUI UserUI;
        public MainWindow()
        {
            InitializeComponent();
            
        }

        
        private void payPlanEntry_btn_Click(object sender, RoutedEventArgs e)
        {
            UserUI = new UserUI();
            UserUI.Show();
            UserUI.UserName = "Bora".ToUpper();
            this.Close();

        }


    }
}