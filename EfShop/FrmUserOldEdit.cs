using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EfShop
{
    public partial class FrmUserOldEdit : Form
    {
        int id;
        public FrmUserOldEdit()
        {
            id = -1;
            InitializeComponent();
        }

        public FrmUserOldEdit(UsersOld entity)
        {
            InitializeComponent();
            txtFullName.Text = entity.FullName;
            txtPassword.Text = entity.Password;
            txtCredit.Text = entity.Bakiye.ToString();
            txtUsername.Text = entity.UserName;
            id = entity.Id;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            UsersOld users = new UsersOld();
            users.FullName = txtFullName.Text;
            users.Password = txtPassword.Text;
            users.UserName = txtUsername.Text;
            users.Bakiye = Convert.ToDecimal(txtCredit.Text);


            UsersOldRepository rep = new UsersOldRepository();

            if (id == -1)
            {
                rep.Insert(users);
            }
            else
            {
                users.Id = id;
                rep.Update(users);
            }
            Close();
        }
    }
}
