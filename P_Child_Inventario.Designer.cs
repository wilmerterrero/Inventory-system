namespace PROG1_PROYECTO_FINAL
{
    partial class P_Child_Inventario
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBxProveedor = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBxProduct = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.iconBtnDel = new FontAwesome.Sharp.IconButton();
            this.iconBtnEdit = new FontAwesome.Sharp.IconButton();
            this.iconBtnInsert = new FontAwesome.Sharp.IconButton();
            this.comboBxCantidad = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(520, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(520, 292);
            this.dataGridView1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(60, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 23);
            this.label4.TabIndex = 26;
            this.label4.Text = "Cantidad";
            // 
            // comboBxProveedor
            // 
            this.comboBxProveedor.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBxProveedor.FormattingEnabled = true;
            this.comboBxProveedor.Location = new System.Drawing.Point(64, 212);
            this.comboBxProveedor.Name = "comboBxProveedor";
            this.comboBxProveedor.Size = new System.Drawing.Size(376, 29);
            this.comboBxProveedor.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(60, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 23);
            this.label2.TabIndex = 22;
            this.label2.Text = "Proveedor";
            // 
            // comboBxProduct
            // 
            this.comboBxProduct.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBxProduct.FormattingEnabled = true;
            this.comboBxProduct.Location = new System.Drawing.Point(64, 104);
            this.comboBxProduct.Name = "comboBxProduct";
            this.comboBxProduct.Size = new System.Drawing.Size(376, 29);
            this.comboBxProduct.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(60, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 20;
            this.label1.Text = "Producto";
            // 
            // iconBtnDel
            // 
            this.iconBtnDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.iconBtnDel.FlatAppearance.BorderSize = 0;
            this.iconBtnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnDel.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconBtnDel.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconBtnDel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconBtnDel.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconBtnDel.IconColor = System.Drawing.Color.Black;
            this.iconBtnDel.IconSize = 16;
            this.iconBtnDel.Location = new System.Drawing.Point(716, 414);
            this.iconBtnDel.Name = "iconBtnDel";
            this.iconBtnDel.Rotation = 0D;
            this.iconBtnDel.Size = new System.Drawing.Size(147, 53);
            this.iconBtnDel.TabIndex = 30;
            this.iconBtnDel.Text = "ELIMINAR";
            this.iconBtnDel.UseVisualStyleBackColor = false;
            // 
            // iconBtnEdit
            // 
            this.iconBtnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.iconBtnEdit.FlatAppearance.BorderSize = 0;
            this.iconBtnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnEdit.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconBtnEdit.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconBtnEdit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconBtnEdit.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconBtnEdit.IconColor = System.Drawing.Color.Black;
            this.iconBtnEdit.IconSize = 16;
            this.iconBtnEdit.Location = new System.Drawing.Point(457, 414);
            this.iconBtnEdit.Name = "iconBtnEdit";
            this.iconBtnEdit.Rotation = 0D;
            this.iconBtnEdit.Size = new System.Drawing.Size(147, 53);
            this.iconBtnEdit.TabIndex = 29;
            this.iconBtnEdit.Text = "EDITAR";
            this.iconBtnEdit.UseVisualStyleBackColor = false;
            // 
            // iconBtnInsert
            // 
            this.iconBtnInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.iconBtnInsert.FlatAppearance.BorderSize = 0;
            this.iconBtnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnInsert.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconBtnInsert.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconBtnInsert.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconBtnInsert.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconBtnInsert.IconColor = System.Drawing.Color.Black;
            this.iconBtnInsert.IconSize = 16;
            this.iconBtnInsert.Location = new System.Drawing.Point(212, 414);
            this.iconBtnInsert.Name = "iconBtnInsert";
            this.iconBtnInsert.Rotation = 0D;
            this.iconBtnInsert.Size = new System.Drawing.Size(147, 53);
            this.iconBtnInsert.TabIndex = 28;
            this.iconBtnInsert.Text = "INSERTAR";
            this.iconBtnInsert.UseVisualStyleBackColor = false;
            // 
            // comboBxCantidad
            // 
            this.comboBxCantidad.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBxCantidad.FormattingEnabled = true;
            this.comboBxCantidad.Location = new System.Drawing.Point(64, 324);
            this.comboBxCantidad.Name = "comboBxCantidad";
            this.comboBxCantidad.Size = new System.Drawing.Size(376, 29);
            this.comboBxCantidad.TabIndex = 31;
            // 
            // P_Child_Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(1089, 536);
            this.Controls.Add(this.comboBxCantidad);
            this.Controls.Add(this.iconBtnDel);
            this.Controls.Add(this.iconBtnEdit);
            this.Controls.Add(this.iconBtnInsert);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBxProveedor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBxProduct);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "P_Child_Inventario";
            this.Text = "P_Child_Inventario";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBxProveedor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBxProduct;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton iconBtnDel;
        private FontAwesome.Sharp.IconButton iconBtnEdit;
        private FontAwesome.Sharp.IconButton iconBtnInsert;
        private System.Windows.Forms.ComboBox comboBxCantidad;
    }
}