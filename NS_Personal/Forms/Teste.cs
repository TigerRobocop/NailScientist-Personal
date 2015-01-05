using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NS_Personal.DAL;
using NS_Personal.Basicas;

namespace NS_Personal.Forms
{
    public partial class Teste : Form
    {
        public Teste()
        {
            InitializeComponent();

            //lock column width
            listPolish.ColumnWidthChanging += new ColumnWidthChangingEventHandler(listPolish_ColumnWidthChanging);

            LoadBrands();
            LoadFinish();
            LoadPolish();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (comboBrands.SelectedIndex == -1)
            {
                MessageBox.Show("Select a BRAND");
            }
            else if (comboFinish.SelectedIndex == -1)
            {
                MessageBox.Show("Select a FINISH");
            }
            else
            {
                DAL_Polish dao = DAL_Polish.getInstancia();

                Polish p = new Polish();
                p.Name = txtName.Text;
                p.Color = txtColor.Text;
                p.Brand = comboBrands.SelectedValue.ToString();
                p.Finish = comboFinish.SelectedValue.ToString();

                dao.InsertPolish(p);

                MessageBox.Show("Inserted!");

                txtName.Text = "";
                txtColor.Text = "";
                comboBrands.SelectedIndex = -1;
                comboFinish.SelectedIndex = -1;

                LoadPolish();
            }

        }

        private void btnFormBrand_Click(object sender, EventArgs e)
        {
            new NewBrand(this).ShowDialog();
        }

        private void btnFormFinish_Click(object sender, EventArgs e)
        {
            new NewFinish(this).ShowDialog();
        }

        public void LoadBrands()
        {
            DAL_Brand dao = DAL_Brand.getInstancia();
            comboBrands.DisplayMember = "Brand";
            comboBrands.ValueMember = "ID";
            comboFilterBrand.DisplayMember = "Brand";
            comboFilterBrand.ValueMember = "ID";

            comboBrands.DataSource = dao.GetBrands();
            comboFilterBrand.DataSource = dao.GetBrands();
            
            comboBrands.SelectedIndex = -1;
            comboFilterBrand.SelectedIndex = -1;
        }

        public void LoadFinish()
        {
            DAL_Finish dao = DAL_Finish.getInstancia();
            comboFinish.ValueMember = "ID";
            comboFinish.DisplayMember = "Finish";
            comboFilterFinish.ValueMember = "ID";
            comboFilterFinish.DisplayMember = "Finish";

            comboFinish.DataSource = dao.GetFinish();
            comboFilterFinish.DataSource = dao.GetFinish();

            comboFinish.SelectedIndex = -1;
            comboFilterFinish.SelectedIndex = -1;
        }

        public void LoadPolish()
        {
            DAL_Polish dao = DAL_Polish.getInstancia();

            //    gridPolish.DataSource = dao.GetPolish();

            listPolish.Items.Clear();
            DataTable _dt = new DataTable();

            try
            {
                _dt = dao.GetPolish();

                if (_dt == null)
                {
                    throw new Exception("No polish to display");
                }

                else
                {
                    foreach (DataRow item in _dt.Rows)
                    {
                        ListViewItem polish = new ListViewItem();
                        polish.Text = item["ID"].ToString();//0
                        polish.SubItems.Add(item["Name"].ToString()); //1
                        polish.SubItems.Add(item["Color"].ToString()); //2
                        polish.SubItems.Add(item["Brand"].ToString()); //3
                        polish.SubItems.Add(item["Finish"].ToString()); //4


                        listPolish.Items.Add(polish);

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void listPolish_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = listPolish.Columns[e.ColumnIndex].Width;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            DAL_Polish dao = DAL_Polish.getInstancia();

            //    gridPolish.DataSource = dao.GetPolish();

            listPolish.Items.Clear();
            DataTable _dt = new DataTable();

            try
            {
                string brand = comboFilterBrand.SelectedValue.ToString();
                string finish = comboFilterFinish.SelectedValue.ToString();

                if (string.IsNullOrEmpty(brand) && string.IsNullOrEmpty(finish))
                {
                    _dt = dao.FindPolish(null, null);
                }
                else if (!string.IsNullOrEmpty(brand) && string.IsNullOrEmpty(finish))
                {
                    _dt = dao.FindPolish(brand, null);
                }
                else if (string.IsNullOrEmpty(brand) && !string.IsNullOrEmpty(finish))
                {
                    _dt = dao.FindPolish(null, finish);
                }
                else
                {
                    _dt = dao.FindPolish(brand, finish);
                }

              

                if (_dt == null)
                {
                    throw new Exception("No polish to display");
                }

                else
                {
                    foreach (DataRow item in _dt.Rows)
                    {
                        ListViewItem polish = new ListViewItem();
                        polish.Text = item["ID"].ToString();//0
                        polish.SubItems.Add(item["Name"].ToString()); //1
                        polish.SubItems.Add(item["Color"].ToString()); //2
                        polish.SubItems.Add(item["Brand"].ToString()); //3
                        polish.SubItems.Add(item["Finish"].ToString()); //4


                        listPolish.Items.Add(polish);

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

   
    }
}
