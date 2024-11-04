using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class LoginForm : Form
    {

        private Employee Authenticate(string username, string password, List<Employee> us) //авторизация
        {
            //LINQ
            var user = us.FirstOrDefault(u => u.name == username && u.pass == password);

            return user;
        }
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            string username = loginbox.Text;
            string password = passbox.Text;
            Routine routine = new Routine();
            List<Employee> users = routine.ParseUsers();

            Employee authenticateduser = Authenticate(username, password, users);

            if (authenticateduser != null)
            {
                int accesslevel = authenticateduser.occupation;

                MessageBox.Show($"Авторизация успешна! Уровень доступа: {accesslevel}");
                if (accesslevel == 3)
                {
                    AdminForm form = new AdminForm();
                    form.Show();
                }
                else if (accesslevel == 2)
                {
                    ManagerForm form = new ManagerForm();
                    form.Show();
                }
                else if (accesslevel == 1)
                {
                    SellerForm form = new SellerForm();
                    form.Show();
                }
                Hide();
            }
            else
            {
                //некорректные учетные данные или пользователь не найден
                MessageBox.Show("Некорректные учетные данные!");
            }

        }
    }
}
