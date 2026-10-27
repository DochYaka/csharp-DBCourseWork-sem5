using csharp_DBCourseWork_sem5.Models;
using csharp_DBCourseWork_sem5.Pages;
using Microsoft.EntityFrameworkCore;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace csharp_DBCourseWork_sem5
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Loaded += MainWindow_Loaded;
        }

        /// <summary>
        /// Действия при загрузке окна
        /// </summary>
        private async void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                await using (BookStoreDbContext bookStore = new BookStoreDbContext())
                {
                    var books = await bookStore.Books.ToListAsync();

                    dgBooks.ItemsSource = books;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка подключения",
                                MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

        /// <summary>
        /// Открыть страницу
        /// </summary>
        private void OpenPage_Click(object sender, RoutedEventArgs e)
        {
            if (sender is not MenuItem item) return;
            if (item.Header is not string name) return;

            OpenPageService.OpenPage(name, fmPage);
        }

        /// <summary>
        /// Закрыть окно
        /// </summary>
        private void Close_Click(object sender, MouseButtonEventArgs e)
        {
            if (fmPage.Content != null) fmPage.Content = null;
            else Close();
        }
    }
}