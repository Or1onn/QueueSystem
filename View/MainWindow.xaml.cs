using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Common;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
using Microsoft.VisualBasic;
using QueueSystem.Models;
using QueueSystem.View;
using SQLite;
using static SQLite.SQLite3;

namespace QueueSystem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<QueueModel> Queues { get; set; }
        public SQLiteAsyncConnection? connection;
        #region TitleButtons
        private void MinimizeWindow(object sender, RoutedEventArgs e)
        {
            App.Current.MainWindow.WindowState = WindowState.Minimized;
        }

        private void MaximizeClick(object sender, RoutedEventArgs e)
        {
            AdjustWindowSize();
        }

        private void StackPanel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                if (e.ClickCount == 2)
                {
                    AdjustWindowSize();
                }
                else
                {
                    App.Current.MainWindow.DragMove();
                    App.Current.MainWindow.WindowState = WindowState.Normal;
                    MaximizeButton.Content = "";
                }
            }
        }

        private void AdjustWindowSize()
        {
            if (App.Current.MainWindow.WindowState == WindowState.Maximized)
            {
                App.Current.MainWindow.WindowState = WindowState.Normal;
                MaximizeButton.Content = "";
            }
            else if (App.Current.MainWindow.WindowState == WindowState.Normal)
            {
                App.Current.MainWindow.WindowState = WindowState.Maximized;
                MaximizeButton.Content = "";
            }
        }


        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            App.Current.MainWindow.Close();
        }
        #endregion
        #region ResizeWindows
        bool ResizeInProcess = false;
        private void Resize_Init(object sender, MouseButtonEventArgs e)
        {
            Rectangle? senderRect = sender as Rectangle;
            if (senderRect != null)
            {
                ResizeInProcess = true;
                senderRect.CaptureMouse();
            }
        }

        private void Resize_End(object sender, MouseButtonEventArgs e)
        {
            Rectangle? senderRect = sender as Rectangle;
            if (senderRect != null)
            {
                ResizeInProcess = false; ;
                senderRect.ReleaseMouseCapture();
            }
        }

        private void Resizeing_Form(object sender, MouseEventArgs e)
        {
            if (ResizeInProcess)
            {
                Rectangle? senderRect = sender as Rectangle;
                Window? mainWindow = senderRect!.Tag as Window;
                if (senderRect != null)
                {
                    double width = e.GetPosition(mainWindow).X;
                    double height = e.GetPosition(mainWindow).Y;
                    senderRect.CaptureMouse();
                    if (senderRect.Name.ToLower().Contains("right"))
                    {
                        width += 5;
                        if (width > 0)
                            mainWindow!.Width = width;
                    }
                    if (senderRect.Name.ToLower().Contains("left"))
                    {
                        width -= 5;
                        mainWindow!.Left += width;
                        width = mainWindow.Width - width;
                        if (width > 0)
                        {
                            mainWindow.Width = width;
                        }
                    }
                    if (senderRect.Name.ToLower().Contains("bottom"))
                    {
                        height += 5;
                        if (height > 0)
                            mainWindow!.Height = height;
                    }
                    if (senderRect.Name.ToLower().Contains("top"))
                    {
                        height -= 5;
                        mainWindow!.Top += height;
                        height = mainWindow.Height - height;
                        if (height > 0)
                        {
                            mainWindow.Height = height;
                        }
                    }
                }
            }
        }
        #endregion

        public MainWindow()
        {
            InitializeComponent();
            MaxHeight = SystemParameters.MaximizedPrimaryScreenHeight;
            MaxWidth = SystemParameters.MaximizedPrimaryScreenWidth;
            Queues = new();
            list.ItemsSource = Queues;
            DBConnection();
        }

        public async void DBConnection()
        {
            if (connection != null)
                return;

            connection = new SQLiteAsyncConnection(Environment.CurrentDirectory + "\\QueueDB.db3");
            await connection.CreateTableAsync<QueueModel>();

            var users = await connection.Table<QueueModel>().ToListAsync();

            Queues = new();
            foreach (var item in users)
            {
                Queues.Add(item);
            }

            list.ItemsSource = Queues;
        }

        async void OnAddButtonTapped(object sender, EventArgs args)
        {
            var popup = new AddingDialog();
            popup.Owner = this;
            this.Opacity = 0.4;
            bool? dialogResult = popup.ShowDialog();
            this.Opacity = 1;

            switch (dialogResult)
            {
                case true:
                    if (Queues.Any(obj => obj.FIN == popup.NewUser!.FIN))
                    {
                        var AlertDialog = new StyledMessageBox("Diqqət!", "Belə bir şəxs artıq mövcuddur");
                        AlertDialog.ShowDialog();
                    }
                    else
                    {
                        if (Queues.Any())
                            popup.NewUser!.Queue = Queues.Last().Queue + 1;
                        else
                            popup.NewUser!.Queue = 1;

                        Queues.Add(popup.NewUser);
                        await connection!.InsertAsync(popup.NewUser);
                    }
                    break;
                default:
                    break;
            }
        }

        async void OnEditButtonTapped(object sender, EventArgs e)
        {
            var obj = Queues[(int)((Button)sender).Tag - 1];
            var popup = new AddingDialog(obj);
            popup.Owner = this;
            bool? result = popup.ShowDialog();

            switch (result)
            {
                case true:
                    if (Queues.Any(obj => obj.FIN == popup.NewUser!.FIN && obj != Queues[(int)((Button)sender).Tag - 1]))
                    {
                        var AlertDialog = new StyledMessageBox("Diqqət!", "Belə bir şəxs artıq mövcuddur", 0);
                        AlertDialog.ShowDialog();
                    }
                    else
                    {
                        obj.FIN = popup.NewUser!.FIN;
                        obj.FullName = popup.NewUser.FullName;
                        obj.IsPaid = popup.NewUser.IsPaid;

                        list.ItemsSource = null;
                        list.ItemsSource = Queues;
                        await connection!.InsertOrReplaceAsync(obj);
                    }
                    break;
                default:
                    break;
            }
        }

        async void OnDeleteButtonTapped(object sender, EventArgs e)
        {
            int position = (int)((Button)sender).Tag - 1;
            for (int i = position + 1; i < Queues.Count; i++)
            {
                Queues[i].Queue--;
            }

            await connection!.DeleteAsync<QueueModel>(Queues[position].Id);
            await connection.UpdateAllAsync(Queues);
            Queues.RemoveAt(position);
            list.Items.Refresh();
        }

        async void OnAllDeleteButtonTapped(object sender, EventArgs e)
        {
            var AlertDialog = new StyledMessageBox("Diqqət!", "Siz dəqiq siyahısı bütün öğeleri aradan qaldırılması istəyirsiniz?", 1);
            bool? answer = AlertDialog.ShowDialog();

            switch (answer)
            {
                case true:
                        await connection!.DeleteAllAsync<QueueModel>();
                        Queues.Clear();
                        list.ItemsSource = Queues;
                        break;
                default:
                    break;
            }

        }
        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            list.ItemsSource = (from items in Queues
                                where items.FullName!.ToLower().Contains(SearchBar.Text.ToLower()) ||
                                items.FIN!.ToLower().Contains(SearchBar.Text.ToLower())
                                select items);

        }
    }
}
