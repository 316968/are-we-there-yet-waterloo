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

namespace are_we_there_yet
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        

        private void BtnDoThing_Click(object sender, RoutedEventArgs e)
        {
            
            

            string[] distance = txtInput.Text.Split(' ');
            int[] d = new int[distance.Length];
            for (int i=0; i < distance.Length; i++)
            {
                d[i] = Convert.ToInt32(distance[i]);
            }

            int[] c = new int[5];

            c[0] = 0;
            for(int i = 1; i < 5; i++)
            {
                c[i] = c[i - 1] + d[i - 1];
            }

            for(int a = 0; a < 5; a++)
            {
                for(int q = 0; q < 5; q++)
                {
                    int di = c[a] - c[q];              
                    lblOutput.Content = (di + ' ').ToString();
                }
                lblOutput.Content = lblOutput.Content + "\n";
            }
        }
        
    }
}
