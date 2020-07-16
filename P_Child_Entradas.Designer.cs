namespace PROG1_PROYECTO_FINAL
{
    partial class P_Child_Entradas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(P_Child_Entradas));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBxProducto = new System.Windows.Forms.ComboBox();
            this.comboBxProveedor = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.iconBtnInsert = new FontAwesome.Sharp.IconButton();
            this.textBoxCantidad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.iconBtnEntradas = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(322, 536);
            this.panel1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(364, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "Producto";
            // 
            // comboBxProducto
            // 
            this.comboBxProducto.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBxProducto.FormattingEnabled = true;
            this.comboBxProducto.Location = new System.Drawing.Point(368, 143);
            this.comboBxProducto.Name = "comboBxProducto";
            this.comboBxProducto.Size = new System.Drawing.Size(376, 29);
            this.comboBxProducto.TabIndex = 12;
            this.comboBxProducto.SelectedIndexChanged += new System.EventHandler(this.comboBxProducto_SelectedIndexChanged);
            // 
            // comboBxProveedor
            // 
            this.comboBxProveedor.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBxProveedor.FormattingEnabled = true;
            this.comboBxProveedor.Location = new System.Drawing.Point(368, 251);
            this.comboBxProveedor.Name = "comboBxProveedor";
            this.comboBxProveedor.Size = new System.Drawing.Size(376, 29);
            this.comboBxProveedor.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(364, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 23);
            this.label2.TabIndex = 13;
            this.label2.Text = "Proveedor";
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
            this.iconBtnInsert.Location = new System.Drawing.Point(833, 456);
            this.iconBtnInsert.Name = "iconBtnInsert";
            this.iconBtnInsert.Rotation = 0D;
            this.iconBtnInsert.Size = new System.Drawing.Size(198, 53);
            this.iconBtnInsert.TabIndex = 17;
            this.iconBtnInsert.Text = "AGREGAR";
            this.iconBtnInsert.UseVisualStyleBackColor = false;
            this.iconBtnInsert.Click += new System.EventHandler(this.iconBtnInsert_Click);
            // 
            // textBoxCantidad
            // 
            this.textBoxCantidad.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCantidad.Location = new System.Drawing.Point(368, 364);
            this.textBoxCantidad.Name = "textBoxCantidad";
            this.textBoxCantidad.Size = new System.Drawing.Size(376, 28);
            this.textBoxCantidad.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(364, 322);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 23);
            this.label4.TabIndex = 18;
            this.label4.Text = "Cantidad";
            // 
            // iconBtnEntradas
            // 
            this.iconBtnEntradas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.iconBtnEntradas.FlatAppearance.BorderSize = 0;
            this.iconBtnEntradas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnEntradas.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconBtnEntradas.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconBtnEntradas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconBtnEntradas.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconBtnEntradas.IconColor = System.Drawing.Color.Black;
            this.iconBtnEntradas.IconSize = 16;
            this.iconBtnEntradas.Location = new System.Drawing.Point(879, 227);
            this.iconBtnEntradas.Name = "iconBtnEntradas";
            this.iconBtnEntradas.Rotation = 0D;
            this.iconBtnEntradas.Size = new System.Drawing.Size(152, 53);
            this.iconBtnEntradas.TabIndex = 20;
            this.iconBtnEntradas.Text = "VER TABLA";
            this.iconBtnEntradas.UseVisualStyleBackColor = false;
            this.iconBtnEntradas.Click += new System.EventHandler(this.iconBtnEntradas_Click);
            // 
            // P_Child_Entradas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(1089, 536);
            this.Controls.Add(this.iconBtnEntradas);
            this.Controls.Add(this.textBoxCantidad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.iconBtnInsert);
            this.Controls.Add(this.comboBxProveedor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBxProducto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "P_Child_Entradas";
            this.Text = "P_Child_Entradas";
            this.Load += new System.EventHandler(this.P_Child_Entradas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBxProducto;
        private System.Windows.Forms.ComboBox comboBxProveedor;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton iconBtnInsert;
        private System.Windows.Forms.TextBox textBoxCantidad;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconButton iconBtnEntradas;
    }
}