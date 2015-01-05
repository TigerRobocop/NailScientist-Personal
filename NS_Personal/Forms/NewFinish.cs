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
    public partial class NewFinish : Form
    {
        Teste parent;

        public NewFinish(Teste main)
        {
            InitializeComponent();
            this.parent = main;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DAL_Finish dao = DAL_Finish.getInstancia();

            string finish = txtFinish.Text;

            dao.InsertFinish(finish);

            MessageBox.Show("Finish inserted!");
            parent.LoadFinish();

            this.Dispose();
        }


    }
}
