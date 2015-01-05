namespace NS_Personal.Forms
{
    partial class Teste
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listPolish = new System.Windows.Forms.ListView();
            this.idPolish = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.namePolish = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Color = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Brand = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Finish = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tab2 = new System.Windows.Forms.TabControl();
            this.tab1 = new System.Windows.Forms.TabPage();
            this.comboFinish = new System.Windows.Forms.ComboBox();
            this.btnFormBrand = new System.Windows.Forms.Button();
            this.comboBrands = new System.Windows.Forms.ComboBox();
            this.btnFormFinish = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblBrand = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblFinish = new System.Windows.Forms.Label();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnFind = new System.Windows.Forms.Button();
            this.comboFilterFinish = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboFilterBrand = new System.Windows.Forms.ComboBox();
            this.tab2.SuspendLayout();
            this.tab1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listPolish
            // 
            this.listPolish.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idPolish,
            this.namePolish,
            this.Color,
            this.Brand,
            this.Finish});
            this.listPolish.FullRowSelect = true;
            this.listPolish.Location = new System.Drawing.Point(12, 211);
            this.listPolish.MultiSelect = false;
            this.listPolish.Name = "listPolish";
            this.listPolish.Size = new System.Drawing.Size(602, 240);
            this.listPolish.TabIndex = 11;
            this.listPolish.UseCompatibleStateImageBehavior = false;
            this.listPolish.View = System.Windows.Forms.View.Details;
            this.listPolish.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.listPolish_ColumnWidthChanging);
            // 
            // idPolish
            // 
            this.idPolish.Text = "id";
            this.idPolish.Width = 0;
            // 
            // namePolish
            // 
            this.namePolish.Text = "Name";
            this.namePolish.Width = 230;
            // 
            // Color
            // 
            this.Color.Text = "Color";
            this.Color.Width = 117;
            // 
            // Brand
            // 
            this.Brand.Text = "Brand";
            this.Brand.Width = 96;
            // 
            // Finish
            // 
            this.Finish.Text = "Finish";
            this.Finish.Width = 152;
            // 
            // tab2
            // 
            this.tab2.Controls.Add(this.tab1);
            this.tab2.Controls.Add(this.tabPage2);
            this.tab2.Location = new System.Drawing.Point(12, 12);
            this.tab2.Name = "tab2";
            this.tab2.SelectedIndex = 0;
            this.tab2.Size = new System.Drawing.Size(602, 183);
            this.tab2.TabIndex = 12;
            // 
            // tab1
            // 
            this.tab1.Controls.Add(this.comboFinish);
            this.tab1.Controls.Add(this.btnFormBrand);
            this.tab1.Controls.Add(this.comboBrands);
            this.tab1.Controls.Add(this.btnFormFinish);
            this.tab1.Controls.Add(this.btnInsert);
            this.tab1.Controls.Add(this.lblName);
            this.tab1.Controls.Add(this.lblColor);
            this.tab1.Controls.Add(this.lblBrand);
            this.tab1.Controls.Add(this.txtName);
            this.tab1.Controls.Add(this.lblFinish);
            this.tab1.Controls.Add(this.txtColor);
            this.tab1.Location = new System.Drawing.Point(4, 22);
            this.tab1.Name = "tab1";
            this.tab1.Padding = new System.Windows.Forms.Padding(3);
            this.tab1.Size = new System.Drawing.Size(594, 157);
            this.tab1.TabIndex = 0;
            this.tab1.Text = "Insert";
            this.tab1.UseVisualStyleBackColor = true;
            // 
            // comboFinish
            // 
            this.comboFinish.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboFinish.FormattingEnabled = true;
            this.comboFinish.Location = new System.Drawing.Point(67, 115);
            this.comboFinish.Name = "comboFinish";
            this.comboFinish.Size = new System.Drawing.Size(190, 21);
            this.comboFinish.TabIndex = 27;
            // 
            // btnFormBrand
            // 
            this.btnFormBrand.Location = new System.Drawing.Point(276, 84);
            this.btnFormBrand.Name = "btnFormBrand";
            this.btnFormBrand.Size = new System.Drawing.Size(75, 23);
            this.btnFormBrand.TabIndex = 26;
            this.btnFormBrand.Text = "new";
            this.btnFormBrand.UseVisualStyleBackColor = true;
            this.btnFormBrand.Click += new System.EventHandler(this.btnFormBrand_Click);
            // 
            // comboBrands
            // 
            this.comboBrands.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBrands.FormattingEnabled = true;
            this.comboBrands.Location = new System.Drawing.Point(67, 84);
            this.comboBrands.Name = "comboBrands";
            this.comboBrands.Size = new System.Drawing.Size(190, 21);
            this.comboBrands.TabIndex = 25;
            // 
            // btnFormFinish
            // 
            this.btnFormFinish.Location = new System.Drawing.Point(276, 116);
            this.btnFormFinish.Name = "btnFormFinish";
            this.btnFormFinish.Size = new System.Drawing.Size(75, 23);
            this.btnFormFinish.TabIndex = 24;
            this.btnFormFinish.Text = "new";
            this.btnFormFinish.UseVisualStyleBackColor = true;
            this.btnFormFinish.Click += new System.EventHandler(this.btnFormFinish_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(401, 92);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(137, 44);
            this.btnInsert.TabIndex = 22;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(23, 24);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 16;
            this.lblName.Text = "Name:";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(27, 56);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(34, 13);
            this.lblColor.TabIndex = 17;
            this.lblColor.Text = "Color:";
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Location = new System.Drawing.Point(23, 88);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(38, 13);
            this.lblBrand.TabIndex = 18;
            this.lblBrand.Text = "Brand:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(67, 21);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(298, 20);
            this.txtName.TabIndex = 21;
            // 
            // lblFinish
            // 
            this.lblFinish.AutoSize = true;
            this.lblFinish.Location = new System.Drawing.Point(24, 120);
            this.lblFinish.Name = "lblFinish";
            this.lblFinish.Size = new System.Drawing.Size(37, 13);
            this.lblFinish.TabIndex = 19;
            this.lblFinish.Text = "Finish:";
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(67, 53);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(298, 20);
            this.txtColor.TabIndex = 20;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnFind);
            this.tabPage2.Controls.Add(this.comboFilterFinish);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.comboFilterBrand);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(594, 157);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Find";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(56, 85);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(190, 39);
            this.btnFind.TabIndex = 30;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // comboFilterFinish
            // 
            this.comboFilterFinish.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboFilterFinish.FormattingEnabled = true;
            this.comboFilterFinish.Location = new System.Drawing.Point(56, 44);
            this.comboFilterFinish.Name = "comboFilterFinish";
            this.comboFilterFinish.Size = new System.Drawing.Size(190, 21);
            this.comboFilterFinish.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Finish:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Brand:";
            // 
            // comboFilterBrand
            // 
            this.comboFilterBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboFilterBrand.FormattingEnabled = true;
            this.comboFilterBrand.Location = new System.Drawing.Point(56, 17);
            this.comboFilterBrand.Name = "comboFilterBrand";
            this.comboFilterBrand.Size = new System.Drawing.Size(190, 21);
            this.comboFilterBrand.TabIndex = 26;
            // 
            // Teste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 463);
            this.Controls.Add(this.tab2);
            this.Controls.Add(this.listPolish);
            this.Name = "Teste";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nail Scientist - Personal";
            this.tab2.ResumeLayout(false);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listPolish;
        private System.Windows.Forms.ColumnHeader namePolish;
        private System.Windows.Forms.ColumnHeader Color;
        private System.Windows.Forms.ColumnHeader Brand;
        private System.Windows.Forms.ColumnHeader Finish;
        private System.Windows.Forms.ColumnHeader idPolish;
        private System.Windows.Forms.TabControl tab2;
        private System.Windows.Forms.TabPage tab1;
        private System.Windows.Forms.ComboBox comboFinish;
        private System.Windows.Forms.Button btnFormBrand;
        private System.Windows.Forms.ComboBox comboBrands;
        private System.Windows.Forms.Button btnFormFinish;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblFinish;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox comboFilterFinish;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboFilterBrand;
        private System.Windows.Forms.Button btnFind;    

    }
}