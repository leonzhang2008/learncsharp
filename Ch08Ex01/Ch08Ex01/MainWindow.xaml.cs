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

namespace Ch08Ex01
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ((Button)sender).Content = "Clicked!";
            Button newButton = new Button();
            newButton.Content = "New Button!";
            newButton.Click += new EventHandler(newButton_Click);
            Controls.Add(newButton);
        }
        private void newButton_Click(object sender, System.EventArgs e)
        {
            ((Button)sender).Content = "Clicked!";
        }
    }
}
