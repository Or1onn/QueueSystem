using QueueSystem.Models;
using System;
using System.Collections;
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
using static SQLite.SQLite3;

namespace QueueSystem.View
{
    /// <summary>
    /// Interaction logic for AddingDialog.xaml
    /// </summary>
    public partial class AddingDialog : Window
    {
        public QueueModel? NewUser { get; set; }
        public bool IsRadioButtonsSelected { get; set; } = false;
        public bool IsPaymentSelected { get; set; }

        public AddingDialog()
        {
            InitializeComponent();
        }

        public AddingDialog(QueueModel model)
        {
            InitializeComponent();
            FullName.Text = model.FullName;
            FIN.Text = model.FIN;

            switch (model.IsPaid)
            {
                case true:
                    Paid.IsChecked = true;
                    break;
                default:
                    NotPaid.IsChecked = true;
                    break;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }

        public void InputsCheck(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(FIN.Text) || string.IsNullOrEmpty(FullName.Text) || IsRadioButtonsSelected == false)
            {
                Submit.IsEnabled = false;
            }
            else
            {
                Submit.IsEnabled = true;
            }
        }

        void RadioButtonSelected(object sender, EventArgs e)
        {
            IsRadioButtonsSelected = true;

            var value = sender as RadioButton;

            switch (value!.Content)
            {
                case "Ödənilib":
                    IsPaymentSelected = true;
                    break;
                default:
                    IsPaymentSelected = false;
                    break;
            }

            InputsCheck(sender, e);
        }

        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            if (FIN.Text.Length == 7)
            {
                NewUser = new() { FIN = FIN.Text.ToUpper(), FullName = FullName.Text, IsPaid = IsPaymentSelected };
                DialogResult = true;

                Close();
            }
            else
            {
                FIN_Border.BorderThickness = new Thickness(2);
                FIN_Border.BorderBrush = Brushes.Red;
                FIN.Text = "";
                FIN.Tag = "FİN uzunluğu 7-ə bərabər olmalıdır";
            }

        }
    }
}
