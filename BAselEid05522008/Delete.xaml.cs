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
    /// Interaction logic for Delete.xaml
    /// </summary>
    public partial class Delete : Page
    {
        FaceBookEntities1 db = new FaceBookEntities1 ();
        public Delete()
        {
            InitializeComponent();
        }

        private void D_butt_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Userr userr = new Userr();
                Admin admin = new Admin();
                userr = db.Userrs.First(x => x.U_Ph == Ph_Txt.Text);
                db.Userrs.Remove(userr);
                db.SaveChanges();
                MessageBox.Show("Deleted successfully");
            }
            catch
            {
                MessageBox.Show("Wrong input");
            }
        }

        private void S_butt_Click(object sender, RoutedEventArgs e)
        {
            Userr userr = new Userr ();
            DG.ItemsSource= db.Userrs.Where(x=> x.U_City == City_Txt.Text).ToList();
        }
    }
}
