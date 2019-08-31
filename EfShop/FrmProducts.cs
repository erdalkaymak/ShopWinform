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
    public partial class FrmProducts : BaseForm
    {
        ProductRepository rep;

        public FrmProducts()
        {
            InitializeComponent();
            rep = new ProductRepository();
            dataGridView1.DataSource = rep.List();
        }
    }
}
