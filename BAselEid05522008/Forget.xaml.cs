using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
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
    /// Interaction logic for Forget.xaml
    /// </summary>
    public partial class Forget : Page
    {
        FaceBookEntities1 db = new FaceBookEntities1();
        public Forget()
        {
            InitializeComponent();
        }

        private void Up_butt_Click(object sender, RoutedEventArgs e)
        {
            Userr user = new Userr();
           
            try
            {
                user = db.Userrs.First(x => x.U_Ph == Name_Txt.Text);
                if (Pass_Txt.Password == Con_Txt.Password)
                {
                    
                    user.U_Password = Pass_Txt.Password;
                    db.Userrs.AddOrUpdate(user);
                    MessageBox.Show("Password changed succesfully");
                    Choose choosep = new Choose();
                    this.NavigationService.Navigate(choosep);
                }
                else
                {
                    MessageBox.Show("Pass and con must be the same");
                }
            }
            catch
            {
                MessageBox.Show("Wrong input");
            }
           
        }
    }
}
