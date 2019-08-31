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
    public partial class FrmCategory : BaseForm
    {
        CategoryRepository rep;
        public FrmCategory()
        {
            InitializeComponent();
            rep = new CategoryRepository();
            refresh();
        }

        protected override void refresh()
        {
            dataGridView1.DataSource = rep.List();
        }
        protected override void btnAdd_Click(object sender, EventArgs e)
        {
            FrmCategoryEdit frm = new FrmCategoryEdit();
            frm.ShowDialog();
            refresh();
        }

        protected override void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count <= 0)
            {
                MessageBox.Show("selet row to delete");
                return;
            }
            Categories ctg = (Categories) dataGridView1.SelectedRows[0].DataBoundItem;
            rep.Delete(ctg.Id);
            refresh();
        }

        protected override void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count <= 0)
            {
                MessageBox.Show("select row to Update");
                return;
            }
            Categories ctg = (Categories)dataGridView1.SelectedRows[0].DataBoundItem;
            FrmCategoryEdit frm = new FrmCategoryEdit(ctg);
            frm.ShowDialog();
            refresh();
        }

      
    }
}
