using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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

namespace BAselEid05522008
{
    /// <summary>
    /// Interaction logic for Profile.xaml
    /// </summary>
    public partial class Profile : Page
    {
        FaceBookEntities1 db = new FaceBookEntities1();
        public Profile(string name,string num )
        {
            InitializeComponent();
            Userr user = new Userr();
       
            Dg.ItemsSource = db.Userrs.Where(x=> x.U_Ph == num).ToList();
            
            label1.Content = "Welcome " +name;
          
        }

        private void Log_butt_Click(object sender, RoutedEventArgs e)
        {
            Choose choosep = new Choose();
            string name =Name;
            this.NavigationService.Navigate(choosep);
        }
    }
}
