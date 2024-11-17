using System.Drawing;
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

          
           StringBuilder sb = new StringBuilder();

           Random rnd = new Random();
           string color1 = RandomColor(rnd);
           string color2 = RandomColor(rnd);
           string color3 = RandomColor(rnd);
           string color4 = RandomColor(rnd);
           Title = $"MasterMind({color1},{color2},{color3},{color4},)";
         
        }
        private string RandomColor (Random rnd)
        {
            int randomNumber = rnd.Next(1, 7);
            switch (randomNumber)
            {
                case 1:
                    return "Blue";
                    
                case 2:
                    return "Red";
                    
                case 3:
                    return "White";
                    
                case 4:
                    return "Yellow";
                    
                case 5:
                    return "Orange";
                    
                case 6:
                    return "Green"; 
                default: return "";
            }
        }
        private void NewLabelColor(Label label, string color)
        {
            switch (color)
            {
                case "Blue":
                    label.Background = new SolidColorBrush(Colors.Blue);
                    break;
                case "Red":
                    label.Background = new SolidColorBrush(Colors.Red);
                    break;
                case "White":
                    label.Background = new SolidColorBrush(Colors.White);
                    break;
                case "Yellow":
                    label.Background = new SolidColorBrush(Colors.Yellow);
                    break;
                case "Orange":
                    label.Background = new SolidColorBrush(Colors.Orange);
                    break;
                case "Green":
                    label.Background = new SolidColorBrush(Colors.Green);
                    break;
                default:
                    label.Background = new SolidColorBrush(Colors.Gray);
                    break;
            }
        }
       private void ComboBox1Collor(object sender, SelectionChangedEventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                string newColor = (comboBox1.SelectedItem as ComboBoxItem).Content.ToString();
                NewLabelColor(colorLabel1, newColor);
            }
            
        }
        private void ComboBox2Collor(object sender, SelectionChangedEventArgs e)
        {
            if (comboBox2.SelectedItem != null)
            {
                string newColor = (comboBox2.SelectedItem as ComboBoxItem).Content.ToString();
                NewLabelColor(colorLabel2, newColor);
            }

        }
        private void ComboBox3Collor(object sender, SelectionChangedEventArgs e)
        {
            if (comboBox3.SelectedItem != null)
            {
                string newColor = (comboBox3.SelectedItem as ComboBoxItem).Content.ToString();
                NewLabelColor(colorLabel3, newColor);
            }

        }
        private void ComboBox4Collor(object sender, SelectionChangedEventArgs e)
        {
            if (comboBox4.SelectedItem != null)
            {
                string newColor = (comboBox4.SelectedItem as ComboBoxItem).Content.ToString();
                NewLabelColor(colorLabel4, newColor);
            }

        }
        private void valideButton_Click(object sender, RoutedEventArgs e)
        {
            
           
        }
    }

}
 