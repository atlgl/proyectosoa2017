namespace EjemploNorthWindEmpleados.Guis.shippers
{
    partial class ShipperEF
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
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtCom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.shipperBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shipperBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.shipperBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.shipperBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.btnInsertar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipperBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipperBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipperBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipperBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.shipperBindingSource1, "ShipperID", true));
            this.textBox1.Location = new System.Drawing.Point(100, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "ShippersID";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(100, 71);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(100, 20);
            this.txtPhone.TabIndex = 15;
            this.txtPhone.TextChanged += new System.EventHandler(this.txtPhone_TextChanged);
            // 
            // txtCom
            // 
            this.txtCom.Location = new System.Drawing.Point(100, 39);
            this.txtCom.Name = "txtCom";
            this.txtCom.Size = new System.Drawing.Size(100, 20);
            this.txtCom.TabIndex = 14;
            this.txtCom.TextChanged += new System.EventHandler(this.txtCom_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Phone:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "CompanyName:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DataSource = this.shipperBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 99);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(322, 150);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // shipperBindingSource1
            // 
            this.shipperBindingSource1.DataSource = typeof(AccesoDatos.Entidades.Shipper);
            // 
            // shipperBindingSource2
            // 
            this.shipperBindingSource2.DataSource = typeof(AccesoDatos.Entidades.Shipper);
            // 
            // shipperBindingSource3
            // 
            this.shipperBindingSource3.DataSource = typeof(AccesoDatos.Entidades.Shipper);
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(248, 19);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(75, 23);
            this.btnInsertar.TabIndex = 19;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // ShipperEF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 261);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtCom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ShipperEF";
            this.Text = "ShipperEF";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipperBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipperBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipperBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipperBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtCom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn shipperIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource shipperBindingSource;
        private System.Windows.Forms.BindingSource shipperBindingSource1;
        private System.Windows.Forms.BindingSource shipperBindingSource3;
        private System.Windows.Forms.BindingSource shipperBindingSource2;
        private System.Windows.Forms.Button btnInsertar;
    }
}