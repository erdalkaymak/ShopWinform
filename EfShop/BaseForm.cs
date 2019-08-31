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
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            InitializeComponent();
        }

        protected virtual void refresh()
        {
            
        }

        protected virtual void btnAdd_Click(object sender, EventArgs e)
        {

        }

        protected virtual void btnEdit_Click(object sender, EventArgs e)
        {

        }

        protected virtual void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
