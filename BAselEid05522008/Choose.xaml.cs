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

namespace BAselEid05522008
{
    /// <summary>
    /// Interaction logic for Choose.xaml
    /// </summary>
    public partial class Choose : Page
    {
        FaceBookEntities1 db =new FaceBookEntities1();
        public Choose()
        {
            InitializeComponent();
           
        }

        private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {

        }

        private void Hyperlink_RequestNavigate_1(object sender, RequestNavigateEventArgs e)
        {

        }

        private void Signin_butt_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Userr user = new Userr();
                string num = Name_Txt.Text;
                string name = N_Txt.Text;
                user = db.Userrs.First(x => x.U_Ph == Name_Txt.Text && x.U_Password == Pass_Txt.Password);
                Profile profilep = new Profile(name,num);
                this.NavigationService.Navigate(profilep);
            }
            catch
            {
                MessageBox.Show("Wrong data");
            }
        }

        private void Name_Txt_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void SigninA_butt_Click(object sender, RoutedEventArgs e)
        {
            A_Login a_Login = new A_Login();
            this.NavigationService.Navigate(a_Login);
        }
    }
}
