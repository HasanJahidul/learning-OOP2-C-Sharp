namespace DemoLog
{
    partial class Form3
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtbalance = new System.Windows.Forms.TextBox();
            this.txtpaid = new System.Windows.Forms.TextBox();
            this.btnrmv = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.txtsubtotal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnet = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtdis = new System.Windows.Forms.TextBox();
            this.lblsub = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblpcu = new System.Windows.Forms.Label();
            this.lblqty = new System.Windows.Forms.Label();
            this.lblpro = new System.Windows.Forms.Label();
            this.txtpuc = new System.Windows.Forms.TextBox();
            this.txtqty = new System.Windows.Forms.TextBox();
            this.txtitem = new System.Windows.Forms.TextBox();
            this.lstvcart = new System.Windows.Forms.ListView();
            this.Product = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Quantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Unit_Cost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Total = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtSB = new System.Windows.Forms.TextBox();
            this.dgvshop = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvshop)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.txtbalance);
            this.panel1.Controls.Add(this.txtpaid);
            this.panel1.Controls.Add(this.btnrmv);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txttotal);
            this.panel1.Controls.Add(this.txtsubtotal);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtnet);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtdis);
            this.panel1.Controls.Add(this.lblsub);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lblpcu);
            this.panel1.Controls.Add(this.lblqty);
            this.panel1.Controls.Add(this.lblpro);
            this.panel1.Controls.Add(this.txtpuc);
            this.panel1.Controls.Add(this.txtqty);
            this.panel1.Controls.Add(this.txtitem);
            this.panel1.Controls.Add(this.lstvcart);
            this.panel1.Controls.Add(this.txtSB);
            this.panel1.Controls.Add(this.dgvshop);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1241, 689);
            this.panel1.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(939, 588);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 20);
            this.label6.TabIndex = 27;
            this.label6.Text = "Balance";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(939, 533);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 20);
            this.label5.TabIndex = 26;
            this.label5.Text = "Paid";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1129, 627);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 54);
            this.button2.TabIndex = 25;
            this.button2.Text = "Done";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(646, 627);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 54);
            this.button1.TabIndex = 24;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtbalance
            // 
            this.txtbalance.Location = new System.Drawing.Point(1012, 574);
            this.txtbalance.Multiline = true;
            this.txtbalance.Name = "txtbalance";
            this.txtbalance.Size = new System.Drawing.Size(100, 34);
            this.txtbalance.TabIndex = 23;
            this.txtbalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtpaid
            // 
            this.txtpaid.Location = new System.Drawing.Point(1012, 519);
            this.txtpaid.Multiline = true;
            this.txtpaid.Name = "txtpaid";
            this.txtpaid.Size = new System.Drawing.Size(100, 34);
            this.txtpaid.TabIndex = 22;
            this.txtpaid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtpaid.TextChanged += new System.EventHandler(this.txtbalance_TextChanged);
            // 
            // btnrmv
            // 
            this.btnrmv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrmv.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnrmv.Location = new System.Drawing.Point(1153, 189);
            this.btnrmv.Name = "btnrmv";
            this.btnrmv.Size = new System.Drawing.Size(85, 58);
            this.btnrmv.TabIndex = 21;
            this.btnrmv.Text = "Remove From Cart";
            this.btnrmv.UseVisualStyleBackColor = true;
            this.btnrmv.Click += new System.EventHandler(this.btnrmv_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Search by Name";
            // 
            // txttotal
            // 
            this.txttotal.Location = new System.Drawing.Point(1055, 125);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(92, 20);
            this.txttotal.TabIndex = 19;
            // 
            // txtsubtotal
            // 
            this.txtsubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsubtotal.Location = new System.Drawing.Point(632, 468);
            this.txtsubtotal.Multiline = true;
            this.txtsubtotal.Name = "txtsubtotal";
            this.txtsubtotal.Size = new System.Drawing.Size(100, 34);
            this.txtsubtotal.TabIndex = 18;
            this.txtsubtotal.Text = "0";
            this.txtsubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1025, 445);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Net Total";
            // 
            // txtnet
            // 
            this.txtnet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnet.Location = new System.Drawing.Point(1012, 468);
            this.txtnet.Multiline = true;
            this.txtnet.Name = "txtnet";
            this.txtnet.Size = new System.Drawing.Size(100, 34);
            this.txtnet.TabIndex = 16;
            this.txtnet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(758, 445);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Discount";
            // 
            // txtdis
            // 
            this.txtdis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdis.Location = new System.Drawing.Point(749, 468);
            this.txtdis.Multiline = true;
            this.txtdis.Name = "txtdis";
            this.txtdis.Size = new System.Drawing.Size(100, 34);
            this.txtdis.TabIndex = 14;
            this.txtdis.Text = "0";
            this.txtdis.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtdis.TextChanged += new System.EventHandler(this.txtdis_TextChanged);
            // 
            // lblsub
            // 
            this.lblsub.AutoSize = true;
            this.lblsub.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsub.Location = new System.Drawing.Point(642, 445);
            this.lblsub.Name = "lblsub";
            this.lblsub.Size = new System.Drawing.Size(77, 20);
            this.lblsub.TabIndex = 13;
            this.lblsub.Text = "Sub Total";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(1153, 125);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(85, 58);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Add To Cart";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1081, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Total";
            // 
            // lblpcu
            // 
            this.lblpcu.AutoSize = true;
            this.lblpcu.Location = new System.Drawing.Point(959, 109);
            this.lblpcu.Name = "lblpcu";
            this.lblpcu.Size = new System.Drawing.Size(69, 13);
            this.lblpcu.TabIndex = 9;
            this.lblpcu.Text = "Per Unit Cost";
            // 
            // lblqty
            // 
            this.lblqty.AutoSize = true;
            this.lblqty.Location = new System.Drawing.Point(891, 109);
            this.lblqty.Name = "lblqty";
            this.lblqty.Size = new System.Drawing.Size(46, 13);
            this.lblqty.TabIndex = 8;
            this.lblqty.Text = "Quantity";
            // 
            // lblpro
            // 
            this.lblpro.AutoSize = true;
            this.lblpro.Location = new System.Drawing.Point(690, 109);
            this.lblpro.Name = "lblpro";
            this.lblpro.Size = new System.Drawing.Size(44, 13);
            this.lblpro.TabIndex = 7;
            this.lblpro.Text = "Product";
            // 
            // txtpuc
            // 
            this.txtpuc.Location = new System.Drawing.Point(951, 125);
            this.txtpuc.Name = "txtpuc";
            this.txtpuc.Size = new System.Drawing.Size(92, 20);
            this.txtpuc.TabIndex = 5;
            // 
            // txtqty
            // 
            this.txtqty.Location = new System.Drawing.Point(885, 125);
            this.txtqty.Name = "txtqty";
            this.txtqty.Size = new System.Drawing.Size(60, 20);
            this.txtqty.TabIndex = 4;
            this.txtqty.TextChanged += new System.EventHandler(this.txtqty_TextChanged);
            // 
            // txtitem
            // 
            this.txtitem.Location = new System.Drawing.Point(632, 125);
            this.txtitem.Name = "txtitem";
            this.txtitem.Size = new System.Drawing.Size(247, 20);
            this.txtitem.TabIndex = 3;
            // 
            // lstvcart
            // 
            this.lstvcart.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Product,
            this.Quantity,
            this.Unit_Cost,
            this.Total});
            this.lstvcart.Location = new System.Drawing.Point(632, 151);
            this.lstvcart.MultiSelect = false;
            this.lstvcart.Name = "lstvcart";
            this.lstvcart.Size = new System.Drawing.Size(515, 262);
            this.lstvcart.TabIndex = 2;
            this.lstvcart.UseCompatibleStateImageBehavior = false;
            this.lstvcart.View = System.Windows.Forms.View.Details;
            // 
            // Product
            // 
            this.Product.Text = "Product";
            this.Product.Width = 250;
            // 
            // Quantity
            // 
            this.Quantity.Text = "Quantity";
            // 
            // Unit_Cost
            // 
            this.Unit_Cost.Text = "Per Unit Cost";
            this.Unit_Cost.Width = 100;
            // 
            // Total
            // 
            this.Total.Text = "Total";
            this.Total.Width = 100;
            // 
            // txtSB
            // 
            this.txtSB.Location = new System.Drawing.Point(177, 125);
            this.txtSB.Name = "txtSB";
            this.txtSB.Size = new System.Drawing.Size(244, 20);
            this.txtSB.TabIndex = 1;
            this.txtSB.TextChanged += new System.EventHandler(this.txtSB_TextChanged_1);
            // 
            // dgvshop
            // 
            this.dgvshop.AllowUserToAddRows = false;
            this.dgvshop.AllowUserToDeleteRows = false;
            this.dgvshop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvshop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.brand,
            this.stock,
            this.price});
            this.dgvshop.Location = new System.Drawing.Point(5, 151);
            this.dgvshop.Name = "dgvshop";
            this.dgvshop.ReadOnly = true;
            this.dgvshop.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvshop.Size = new System.Drawing.Size(621, 535);
            this.dgvshop.TabIndex = 0;
            this.dgvshop.DoubleClick += new System.EventHandler(this.dgvshop_DoubleClick);
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id.DataPropertyName = "id";
            this.id.FillWeight = 123.565F;
            this.id.HeaderText = "Product ID";
            this.id.MinimumWidth = 35;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.DataPropertyName = "name";
            this.name.FillWeight = 249.6507F;
            this.name.HeaderText = "Item";
            this.name.MinimumWidth = 100;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // brand
            // 
            this.brand.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.brand.DataPropertyName = "brand";
            this.brand.FillWeight = 69.0041F;
            this.brand.HeaderText = "Brand";
            this.brand.MinimumWidth = 20;
            this.brand.Name = "brand";
            this.brand.ReadOnly = true;
            // 
            // stock
            // 
            this.stock.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.stock.DataPropertyName = "stock";
            this.stock.FillWeight = 50.76142F;
            this.stock.HeaderText = "Stock";
            this.stock.MinimumWidth = 20;
            this.stock.Name = "stock";
            this.stock.ReadOnly = true;
            // 
            // price
            // 
            this.price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.price.DataPropertyName = "price";
            this.price.FillWeight = 7.01875F;
            this.price.HeaderText = "Price in BDT";
            this.price.MinimumWidth = 80;
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 695);
            this.Controls.Add(this.panel1);
            this.Name = "Form3";
            this.Text = "Digital PC Shop";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form3_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvshop)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvshop;
        private System.Windows.Forms.TextBox txtSB;
        private System.Windows.Forms.ListView lstvcart;
        private System.Windows.Forms.ColumnHeader Product;
        private System.Windows.Forms.ColumnHeader Quantity;
        private System.Windows.Forms.ColumnHeader Unit_Cost;
        private System.Windows.Forms.ColumnHeader Total;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblpcu;
        private System.Windows.Forms.Label lblqty;
        private System.Windows.Forms.Label lblpro;
        private System.Windows.Forms.TextBox txtpuc;
        private System.Windows.Forms.TextBox txtqty;
        private System.Windows.Forms.TextBox txtitem;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtdis;
        private System.Windows.Forms.Label lblsub;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnet;
        private System.Windows.Forms.TextBox txtsubtotal;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.Button btnrmv;
        private System.Windows.Forms.TextBox txtbalance;
        private System.Windows.Forms.TextBox txtpaid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;

    }
}