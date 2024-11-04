using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace c_project_mastermind_1_12001591
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
           
            string color = "";
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 4; i++)
            {
                Random rnd = new Random();
                int randomNumber = rnd.Next(1, 7);
                switch (randomNumber)
                {
                    case 1:
                        color = "Blue";
                        break;
                    case 2:
                        color = "Red";
                        break;
                    case 3:
                        color = "White";
                        break;
                    case 4:
                        color = "Yellow";
                        break;
                    case 5:
                        color = "Orange";
                        break;
                    case 6:
                        color = "Green";
                        break;
                }
                sb.Append(color +",");
            }
            Title = "MasterMind (" + sb.ToString() + ")";
        
        }
            
    }

}
