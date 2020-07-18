namespace PROG1_PROYECTO_FINAL
{
    partial class C_Child_Pedidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(C_Child_Pedidos));
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBxCliente = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBxProducto = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.iconBtnInsert = new FontAwesome.Sharp.IconButton();
            this.iconBtnEntradas = new FontAwesome.Sharp.IconButton();
            this.comboBxCantidad = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(322, 601);
            this.panel1.TabIndex = 12;
            // 
            // comboBxCliente
            // 
            this.comboBxCliente.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBxCliente.FormattingEnabled = true;
            this.comboBxCliente.Location = new System.Drawing.Point(378, 147);
            this.comboBxCliente.Name = "comboBxCliente";
            this.comboBxCliente.Size = new System.Drawing.Size(376, 29);
            this.comboBxCliente.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(374, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 23);
            this.label2.TabIndex = 17;
            this.label2.Text = "Cliente";
            // 
            // comboBxProducto
            // 
            this.comboBxProducto.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBxProducto.FormattingEnabled = true;
            this.comboBxProducto.Location = new System.Drawing.Point(378, 268);
            this.comboBxProducto.Name = "comboBxProducto";
            this.comboBxProducto.Size = new System.Drawing.Size(376, 29);
            this.comboBxProducto.TabIndex = 16;
            this.comboBxProducto.SelectedIndexChanged += new System.EventHandler(this.comboBxProducto_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(374, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 15;
            this.label1.Text = "Producto";
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
            this.iconBtnInsert.Location = new System.Drawing.Point(864, 467);
            this.iconBtnInsert.Name = "iconBtnInsert";
            this.iconBtnInsert.Rotation = 0D;
            this.iconBtnInsert.Size = new System.Drawing.Size(147, 53);
            this.iconBtnInsert.TabIndex = 37;
            this.iconBtnInsert.Text = "AGREGAR";
            this.iconBtnInsert.UseVisualStyleBackColor = false;
            this.iconBtnInsert.Click += new System.EventHandler(this.iconBtnInsert_Click);
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
            this.iconBtnEntradas.Location = new System.Drawing.Point(859, 244);
            this.iconBtnEntradas.Name = "iconBtnEntradas";
            this.iconBtnEntradas.Rotation = 0D;
            this.iconBtnEntradas.Size = new System.Drawing.Size(152, 53);
            this.iconBtnEntradas.TabIndex = 38;
            this.iconBtnEntradas.Text = "VER PEDIDOS";
            this.iconBtnEntradas.UseVisualStyleBackColor = false;
            // 
            // comboBxCantidad
            // 
            this.comboBxCantidad.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBxCantidad.FormattingEnabled = true;
            this.comboBxCantidad.Location = new System.Drawing.Point(378, 386);
            this.comboBxCantidad.Name = "comboBxCantidad";
            this.comboBxCantidad.Size = new System.Drawing.Size(376, 29);
            this.comboBxCantidad.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(374, 343);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 23);
            this.label3.TabIndex = 39;
            this.label3.Text = "Cantidad";
            // 
            // C_Child_Pedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(1111, 601);
            this.Controls.Add(this.comboBxCantidad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.iconBtnEntradas);
            this.Controls.Add(this.iconBtnInsert);
            this.Controls.Add(this.comboBxCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBxProducto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "C_Child_Pedidos";
            this.Text = "C_Child_Pedidos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBxCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBxProducto;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton iconBtnInsert;
        private FontAwesome.Sharp.IconButton iconBtnEntradas;
        private System.Windows.Forms.ComboBox comboBxCantidad;
        private System.Windows.Forms.Label label3;
    }
}