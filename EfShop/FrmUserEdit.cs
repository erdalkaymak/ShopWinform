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
    public partial class FrmUserEdit : Form
    {
        int id;
        public FrmUserEdit()
        {
            id = -1;
            InitializeComponent();
        }
        public FrmUserEdit(Users entity)
        {
            InitializeComponent();
            textBoxFullName.Text=entity.FullName;
            textBoxUsername.Text=entity.UserName;
            textBoxPassword.Text=entity.Password;
            textBoxCredit.Text =entity.Credit.ToString();
            id = entity.Id;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Users usr = new Users();
            usr.FullName = textBoxFullName.Text;
            usr.UserName = textBoxUsername.Text;
            usr.Password = textBoxPassword.Text;
            usr.Credit = Convert.ToDecimal(textBoxCredit.Text);


            UserRepository rep = new UserRepository();
            if (id == -1)
            {
                usr = rep.Insert(usr);
            }
            else
            {
                usr.Id = id;
                usr = rep.Update(usr);
            }
           
            Close();
        }
    }
}
