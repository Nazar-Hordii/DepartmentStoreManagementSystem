﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DepartStoreManagementSystem.UI
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUser user = new frmUser();
            user.Show();
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProduct product = new frmProduct();
            product.Show();
        }

        private void purchaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPurchase purchase = new frmPurchase();
            purchase.Show();
        }

        private void salesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSale sale = new frmSale();
            sale.Show();
        }
    }
}
