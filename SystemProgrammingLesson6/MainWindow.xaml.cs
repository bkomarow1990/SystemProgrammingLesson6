using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace SystemProgrammingLesson6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //Timer timer = new
            Task task = Task.Run(() => {
                while (true)
                {
                    Dispatcher.Invoke(() =>
                    {

                        dateLbl.Text = DateTime.Now.ToString();
                        


                    });
                    Thread.Sleep(1000);
                }
            });

        }

        private void startBtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("1");
            
        }
    }
}
