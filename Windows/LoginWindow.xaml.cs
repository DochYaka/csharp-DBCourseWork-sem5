using csharp_DBCourseWork_sem5.Pages;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace csharp_DBCourseWork_sem5
{
    /// <summary>
    /// Логика взаимодействия для LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        private bool isFirstHover = true;

        public LoginWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Открыть страницу
        /// </summary>
        private void OpenPage_Click(object sender, RoutedEventArgs e)
        {
            if (sender is not MenuItem item) return;
            if (item.Header is not string name) return;

            grdLogin.Visibility = Visibility.Collapsed;
            fmPage.Visibility = Visibility.Visible;

            OpenPageService.OpenPage(name, fmPage);
        }

        /// <summary>
        /// Закрыть страницу/окно
        /// </summary>
        private void Close_Click(object sender, MouseButtonEventArgs e)
        {
            if (fmPage.Content != null)
            {
                grdLogin.Visibility = Visibility.Visible;
                fmPage.Visibility = Visibility.Collapsed;

                fmPage.Content = null;
            }
            else Close();
        }

        /// <summary>
        /// Войти
        /// </summary>
        private void Login_Click(object sender, RoutedEventArgs e)
        {
            var mainWindow = new MainWindow();
            mainWindow.Owner = this;
            Hide();
            mainWindow.Show();
            Show();
        }

        /// <summary>
        /// Очистка превью данных из txtLogin
        /// </summary>
        private void txtLoginPass_MouseEnter(object sender, MouseEventArgs e)
        {
            if (isFirstHover)
            {
                txtLogin.Clear();
                txtPass.Clear();
                isFirstHover = false;
            }
        }

        /// <summary>
        /// Изменение размеров кнопки brdLogin
        /// </summary>
        private void brdLogin_MouseEnter(object sender, MouseEventArgs e)
        {
            ScaleTransform scale = (ScaleTransform)brdLogin.RenderTransform;
            scale.ScaleX = 1.05;
            scale.ScaleY = 1.05;
        }

        /// <summary>
        /// Изменение размеров кнопки brdLogin
        /// </summary>
        private void brdLogin_MouseLeave(object sender, MouseEventArgs e)
        {
            ScaleTransform scale = (ScaleTransform)brdLogin.RenderTransform;
            scale.ScaleX = 1.00;
            scale.ScaleY = 1.00;
        }
    }
}
