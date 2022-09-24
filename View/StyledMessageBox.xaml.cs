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
using System.Windows.Shapes;

namespace QueueSystem.View
{
    /// <summary>
    /// Interaction logic for StyledMessageBox.xaml
    /// </summary>
    public partial class StyledMessageBox : Window
    {
        public StyledMessageBox(string HeaderText, string MainText)
        {
            InitializeComponent();
            this.HeaderText.Content = HeaderText;
            this.MainContent.Text = MainText;
        }

        public StyledMessageBox(string HeaderText, string MainText, int Opacity)
        {
            InitializeComponent();
            this.HeaderText.Content = HeaderText;
            this.MainContent.Text = MainText;
            SubmitButton.Opacity = Opacity;
            if (Opacity == 0)
                SubmitButton.IsEnabled = false;
            else
                SubmitButton.IsEnabled = true;
        }

        private void ExitButtonCLick(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close(); 
        }
        private void SubmitButtonClick(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
            Close();
        }
    }
}
