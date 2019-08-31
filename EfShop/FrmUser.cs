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
    public partial class FrmUser : BaseForm
    {
        UserRepository rep;
        public FrmUser()
        {
            InitializeComponent();
            rep = new UserRepository();
            refresh();
        }

        protected override void refresh()
        {
            dataGridView1.DataSource = rep.List();
        }

        protected override void btnAdd_Click(object sender, EventArgs e)
        {
            FrmUserEdit frm = new FrmUserEdit();
            frm.ShowDialog();
            refresh();
        }

        protected override void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count <= 0)
            {
                MessageBox.Show("select row to edit");
                return;
            }

            Users entity = (Users)dataGridView1.SelectedRows[0].DataBoundItem;
            FrmUserEdit frm = new FrmUserEdit(entity);
            frm.ShowDialog();
            refresh();
        }

        protected override void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count <= 0)
            {
                MessageBox.Show("select row to delete");
                return;
            }
            Users entity = (Users)dataGridView1.SelectedRows[0].DataBoundItem;
            rep.Delete(entity.Id);
            refresh();
        }
    }
}
