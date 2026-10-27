using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace csharp_DBCourseWork_sem5.Pages
{
    public static class PageFactory
    {
        public static Page Create(string name, Frame frame) => name switch
        {
            "Руководство пользователя" => new UserManualPage(),
            "О программе" => new AboutPage(),
            _ => throw new ArgumentException($"Нет страницы «{name}»")
        };
    }
}
