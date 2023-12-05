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
    /// Interaction logic for Signup.xaml
    /// </summary>
    public partial class Signup : Page
    {
        FaceBookEntities1 db = new FaceBookEntities1();
        public Signup()
        {
            InitializeComponent();
        }

        private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {

        }
        bool ISValid (string pass)
        {
            bool lower, upper, digit, symbol;
            lower = upper = digit = symbol = false;
            string Special = "!@#$%^&*()";
            foreach (char c in pass)
            {
                if (c >=  '0' && c <= '9')
                {
                    digit = true;
                }
                if (c >= 'a' && c <= 'z')
                {
                    lower = true;
                }
                if (c >= 'A' && c <= 'Z')
                {
                    upper = true;
                }
                if(Special.Contains(c))
                {
                    symbol = true;
                }
            }
            return lower && upper && digit && symbol;
        }
        private void SignUp_butt_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (ISValid(PAss_Txt.Password))
                {
                    int age = int.Parse(Age_Txt.Text);
                    if (age > 18 && age < 60 && Phone_Txt.Text.Length == 11)
                    {
                        if (Male.IsChecked != null)
                        { //&& Female.IsChecked == null
                            Userr user = new Userr();
                            user.U_Name = Name_Txt.Text;
                            user.U_Password = PAss_Txt.Password;
                            user.U_City = combo.Text;
                            user.U_Ph = Phone_Txt.Text;
                            user.U_Age = int.Parse(Age_Txt.Text);
                            user.U_Gender = ComboG.Text;
                            db.Userrs.Add(user);
                            db.SaveChanges();
                            MessageBox.Show("Data is Added");
                        }
                       

                        /*   else if (Male.IsChecked != null )
                           { //&& Male.IsChecked == null
                               Userr user = new Userr();
                               user.U_Name = Name_Txt.Text;
                               user.U_Password = PAss_Txt.Password;
                               user.U_City = combo.Text;
                               user.U_Ph = Phone_Txt.Text;
                               user.U_Age = int.Parse(Age_Txt.Text);
                               user.U_Gender = "Male";
                               db.Userrs.Add(user);
                               db.SaveChanges();
                               MessageBox.Show("Data is Added");
                           }
                       }
                       else
                       {
                           MessageBox.Show("Age must be older than 18 and phone number must be 11 digits");
                       }*/

                    }
                    else
                    {
                        MessageBox.Show("Pass must contain lower ,upper ,digit , special chars");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Wrong input");
            }
           
        }

        private void Female_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
