using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NS_Personal.DAL;

namespace NS_Personal.Forms
{
    public partial class NewBrand : Form
    {
        Teste parent;

        public NewBrand(Teste main)
        {
            InitializeComponent();
            this.parent = main;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DAL_Brand dao = DAL_Brand.getInstancia();

            string brand = txtBrand.Text;

            dao.InsertBrand(brand);

           

            MessageBox.Show("Brand inserted");
            parent.LoadBrands();

            this.Dispose();
        }
    }
}
