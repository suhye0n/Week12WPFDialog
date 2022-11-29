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

namespace Week12WPFDialog
{
    public partial class Gundam : Window
    {
        public Gundam()
        {
            InitializeComponent();
            Name2.Focus();
        }

        private int myVar;

        public int MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }

        public string MSName
        {
            get { return Name2.Text; }
        }


        public string MSModel
        {
            get { return Model.Text; }
        }

        public string MSParty => Party.Text;


        private void OnOK(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }

        private void OnCancel(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }
    }
}
