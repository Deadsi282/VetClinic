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
using static VeterinaryClinic13.ClassHelper.AppData;

namespace VeterinaryClinic13.windows
{
    /// <summary>
    /// Логика взаимодействия для Auth.xaml
    /// </summary>
    public partial class Auth : Window
    {
        public Auth()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, RoutedEventArgs e)
        {
            var empl = context.Employee.FirstOrDefault
                (i => i.Login == txtLogin.Text && i.Password == txtPassword.Text);

            if(empl != null)
            {
                switch(empl.Role)
                {
                    case 1:
                        DoctorMain docMain = new DoctorMain();
                        docMain.Show();
                        Application.Current.MainWindow.Close();
                    break;

                    case 2:
                        ManagerMain mMain = new ManagerMain();
                        mMain.Show();
                        Application.Current.MainWindow.Close();
                        break;

                    case 3:
                        AdminMain admMain = new AdminMain();
                        admMain.Show();
                        Application.Current.MainWindow.Close();
                        break;

                    default:
                        break;
                }
            }
            else
            {
                MessageBox.Show("Пользователь не найден");
            }
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

    }
}
