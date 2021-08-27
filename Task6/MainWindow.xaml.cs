using System;
using System.Collections.Generic;
using System.IO;
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

namespace Task6
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

        private void checkBtn_Click(object sender, RoutedEventArgs e)
        {
            if ((bool)printRadioButton.IsChecked)
            {
                Task[] tasks = new Task[5];
                tasks[0] = Task.Run(() =>
                {
                    Dispatcher.Invoke(() => { wordsLbl.Content = textTxtBox.Text.Count(el => el == ' ') + 1; });
                }
                );
                tasks[1] = Task.Run(() =>
                {
                    Dispatcher.Invoke(() => { exlamationMarkLbl.Content = textTxtBox.Text.Count(el => el == '!'); });
                }
                );
                tasks[2] = Task.Run(() =>
                {
                    Dispatcher.Invoke(() => { questionMarkLbl.Content = textTxtBox.Text.Count(el => el == '?'); });
                }
                );
                tasks[3] = Task.Run(() =>
                {
                    Dispatcher.Invoke(() => { symbolsLbl.Content = textTxtBox.Text.Length; });
                }
                );
                tasks[4] = Task.Run(() =>
                {
                    Dispatcher.Invoke(() => { sentencesLbl.Content = textTxtBox.Text.Count(el => el == ' ') + 1; });
                }
                );
            }
            else
            {
                int ques=0, exlam=0, symb=0, sent=0, words=0;
                Task[] tasks = new Task[5];
                tasks[0] = Task.Run(() =>
                {
                    Dispatcher.Invoke(() => { words = textTxtBox.Text.Count(el => el == ' ') + 1; });
                }
                );
                tasks[1] = Task.Run(() =>
                {
                    Dispatcher.Invoke(() => { exlam = textTxtBox.Text.Count(el => el == '!'); });
                }
                );
                tasks[2] = Task.Run(() =>
                {
                    Dispatcher.Invoke(() => { ques = textTxtBox.Text.Count(el => el == '?'); });
                }
                );
                tasks[3] = Task.Run(() =>
                {
                    Dispatcher.Invoke(() => { symb = textTxtBox.Text.Length; });
                }
                );
                tasks[4] = Task.Run(() =>
                {
                    Dispatcher.Invoke(() => { sent = textTxtBox.Text.Count(el => el == ' ') + 1; });
                }
                );
                File.WriteAllText("result.dat",$"Question marks: {ques}\n Words: {words}\n Exlamataion marks: {exlam}\n Symbols: {symb}\n Sentences: {sent}");
            }
        }

        private void printRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
