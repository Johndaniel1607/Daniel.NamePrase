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

namespace Daniel.NameParse
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

        private void btnCalulate_Click(object sender, RoutedEventArgs e)
        {
            string Fullname = TxtFullname.Text;

            var firstcomma = Fullname.IndexOf(",");
            var Lastname = Fullname.Substring(0, firstcomma);
            lblLastName.Content = " Lastname:" + Lastname;

            var Secondcomma = Fullname.IndexOf(",");
            var Firstname = Fullname.Substring(firstcomma + 1, Secondcomma);
            lblFirstName.Content = " Firstname " + Firstname;
        }
    }
}
