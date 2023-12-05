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
    /// Interaction logic for A_Login.xaml
    /// </summary>
    public partial class A_Login : Page
    {
        FaceBookEntities1 db = new FaceBookEntities1();
        public A_Login()
        {
            InitializeComponent();
        }

        private void L_butt_Click(object sender, RoutedEventArgs e)
        {
            try 
            {
                Admin admin = new Admin();
                int id = int.Parse(ID_Txt.Text);
                admin = db.Admins.First(x => x.A_Name == Name_Txt.Text && x.A_Pass == Pass_Txt.Password && x.A_ID == id);
                MessageBox.Show("Signid in Successfully");
                Delete deletep = new Delete();
                this.NavigationService.Navigate(deletep);
            }
            catch
            {
                MessageBox.Show("Wrong input");
            }
        }
    }
}
