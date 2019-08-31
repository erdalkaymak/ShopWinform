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
    public partial class FrmCategoryEdit : Form
    {
        int id;
        public FrmCategoryEdit()
        {
            id = -1;
            InitializeComponent();
        }
        public FrmCategoryEdit(Categories entity)
        {
            InitializeComponent();
            textBoxCatOrder.Text = entity.CatOrder.ToString();
            textBoxDescription.Text = entity.Description.ToString();
            textBoxName.Text = entity.Name.ToString();
            id = entity.Id;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Categories ct = new Categories();
            ct.CatOrder = Convert.ToInt32(textBoxCatOrder.Text);
            ct.Name = textBoxName.Text;
            ct.Description = textBoxDescription.Text;

            CategoryRepository ctg = new CategoryRepository();
            if (id == -1)
            {
                ctg.Insert(ct);
            }
            else
            {
                ct.Id = id;
                ctg.Update(ct);
            }
            
            Close();

        }
    }
}
