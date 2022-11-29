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

namespace Week12WPFDialog
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnAdd(object sender, RoutedEventArgs e)
        {
            Gundam g = new Gundam();
            if (g.ShowDialog() != true)
                return;

            Result.Text += $"{g.MSParty}의 {g.MSModel} {g.MSName}{(HasJongsung(g.MSName) ? "이" : "가")} 추가되었습니다.\n";
        }

        public bool HasJongsung(string str)
        {
            if (str.Length < 1)
                return true;
            char last = str[str.Length - 1];
            return (last - 44032) % 28 != 0 ? true : false;
        }
    }
}
