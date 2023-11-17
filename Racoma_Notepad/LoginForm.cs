using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Racoma_Notepad
{
    public partial class LoginForm : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            int result;
            result = db.userlogin(tbuser.Text, tbpass.Text).Count();

            if (db.user_type(tbuser.Text, tbpass.Text)==0)
            {
                MessageBox.Show("Welcome Admin");
            }
            else
            {
                MessageBox.Show("Welcome Staff");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Register userRegister = new Register();
            userRegister.ShowDialog();

        }
    }
}
