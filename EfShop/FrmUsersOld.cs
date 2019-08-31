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
    public partial class FrmUsersOld : BaseForm
    {
        UsersOldRepository rep;
        public FrmUsersOld()
        {
            rep = new UsersOldRepository();
            InitializeComponent();
            refresh();
        }

        protected override void refresh()
        {
            dataGridView1.DataSource = rep.List();
        }

        protected override void btnAdd_Click(object sender, EventArgs e)
        {
            FrmUserOldEdit frm = new FrmUserOldEdit();
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
            UsersOld entity = (UsersOld)dataGridView1.SelectedRows[0].DataBoundItem;
            rep.Delete(entity.Id);
            refresh();
        }

        protected override void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count <= 0)
            {
                MessageBox.Show("select row to delete");
                return;
            }
            UsersOld entity = (UsersOld)dataGridView1.SelectedRows[0].DataBoundItem;
            FrmUserOldEdit frm = new FrmUserOldEdit(entity);
            frm.ShowDialog();
            refresh();
        }
    }
}
