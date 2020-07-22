namespace PROG1_PROYECTO_FINAL
{
    partial class Facturas_Modal
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTittleBar = new System.Windows.Forms.Panel();
            this.agrandar = new FontAwesome.Sharp.IconButton();
            this.cerrar = new FontAwesome.Sharp.IconButton();
            this.minimizar = new FontAwesome.Sharp.IconButton();
            this.iconBtnReload = new FontAwesome.Sharp.IconButton();
            this.comboBxTipo = new System.Windows.Forms.ComboBox();
            this.iconBtnSearch = new FontAwesome.Sharp.IconButton();
            this.textBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panelTittleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTittleBar
            // 
            this.panelTittleBar.BackColor = System.Drawing.Color.OrangeRed;
            this.panelTittleBar.Controls.Add(this.agrandar);
            this.panelTittleBar.Controls.Add(this.cerrar);
            this.panelTittleBar.Controls.Add(this.minimizar);
            this.panelTittleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTittleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTittleBar.Name = "panelTittleBar";
            this.panelTittleBar.Size = new System.Drawing.Size(915, 45);
            this.panelTittleBar.TabIndex = 23;
            // 
            // agrandar
            // 
            this.agrandar.FlatAppearance.BorderSize = 0;
            this.agrandar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.agrandar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.agrandar.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.agrandar.IconChar = FontAwesome.Sharp.IconChar.WindowRestore;
            this.agrandar.IconColor = System.Drawing.Color.White;
            this.agrandar.IconSize = 22;
            this.agrandar.Location = new System.Drawing.Point(827, 3);
            this.agrandar.Name = "agrandar";
            this.agrandar.Rotation = 0D;
            this.agrandar.Size = new System.Drawing.Size(33, 23);
            this.agrandar.TabIndex = 4;
            this.agrandar.UseVisualStyleBackColor = true;
            // 
            // cerrar
            // 
            this.cerrar.FlatAppearance.BorderSize = 0;
            this.cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cerrar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.cerrar.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.cerrar.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.cerrar.IconColor = System.Drawing.Color.White;
            this.cerrar.IconSize = 22;
            this.cerrar.Location = new System.Drawing.Point(866, 3);
            this.cerrar.Name = "cerrar";
            this.cerrar.Rotation = 0D;
            this.cerrar.Size = new System.Drawing.Size(33, 23);
            this.cerrar.TabIndex = 3;
            this.cerrar.UseVisualStyleBackColor = true;
            this.cerrar.Click += new System.EventHandler(this.cerrar_Click);
            // 
            // minimizar
            // 
            this.minimizar.FlatAppearance.BorderSize = 0;
            this.minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.minimizar.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.minimizar.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.minimizar.IconColor = System.Drawing.Color.White;
            this.minimizar.IconSize = 22;
            this.minimizar.Location = new System.Drawing.Point(788, 3);
            this.minimizar.Name = "minimizar";
            this.minimizar.Rotation = 0D;
            this.minimizar.Size = new System.Drawing.Size(33, 23);
            this.minimizar.TabIndex = 2;
            this.minimizar.UseVisualStyleBackColor = true;
            // 
            // iconBtnReload
            // 
            this.iconBtnReload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.iconBtnReload.FlatAppearance.BorderSize = 0;
            this.iconBtnReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnReload.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconBtnReload.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconBtnReload.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconBtnReload.IconChar = FontAwesome.Sharp.IconChar.RedoAlt;
            this.iconBtnReload.IconColor = System.Drawing.Color.White;
            this.iconBtnReload.IconSize = 22;
            this.iconBtnReload.Location = new System.Drawing.Point(715, 153);
            this.iconBtnReload.Name = "iconBtnReload";
            this.iconBtnReload.Rotation = 0D;
            this.iconBtnReload.Size = new System.Drawing.Size(63, 32);
            this.iconBtnReload.TabIndex = 42;
            this.iconBtnReload.UseVisualStyleBackColor = false;
            this.iconBtnReload.Click += new System.EventHandler(this.iconBtnReload_Click);
            // 
            // comboBxTipo
            // 
            this.comboBxTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBxTipo.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBxTipo.FormattingEnabled = true;
            this.comboBxTipo.Location = new System.Drawing.Point(442, 153);
            this.comboBxTipo.Name = "comboBxTipo";
            this.comboBxTipo.Size = new System.Drawing.Size(160, 29);
            this.comboBxTipo.TabIndex = 41;
            // 
            // iconBtnSearch
            // 
            this.iconBtnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.iconBtnSearch.FlatAppearance.BorderSize = 0;
            this.iconBtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnSearch.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconBtnSearch.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconBtnSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconBtnSearch.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconBtnSearch.IconColor = System.Drawing.Color.White;
            this.iconBtnSearch.IconSize = 22;
            this.iconBtnSearch.Location = new System.Drawing.Point(608, 153);
            this.iconBtnSearch.Name = "iconBtnSearch";
            this.iconBtnSearch.Rotation = 0D;
            this.iconBtnSearch.Size = new System.Drawing.Size(101, 32);
            this.iconBtnSearch.TabIndex = 40;
            this.iconBtnSearch.UseVisualStyleBackColor = false;
            this.iconBtnSearch.Click += new System.EventHandler(this.iconBtnSearch_Click);
            // 
            // textBox
            // 
            this.textBox.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox.Location = new System.Drawing.Point(95, 153);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(341, 28);
            this.textBox.TabIndex = 39;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.MediumBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.MenuBar;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.Location = new System.Drawing.Point(35, 200);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.ShowCellErrors = false;
            this.dataGridView1.ShowCellToolTips = false;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(825, 323);
            this.dataGridView1.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(366, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 40);
            this.label1.TabIndex = 38;
            this.label1.Text = "Pedidos";
            // 
            // Facturas_Modal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(915, 585);
            this.Controls.Add(this.iconBtnReload);
            this.Controls.Add(this.comboBxTipo);
            this.Controls.Add(this.iconBtnSearch);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelTittleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Facturas_Modal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facturas_Modal";
            this.Load += new System.EventHandler(this.Facturas_Modal_Load);
            this.panelTittleBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTittleBar;
        private FontAwesome.Sharp.IconButton agrandar;
        private FontAwesome.Sharp.IconButton cerrar;
        private FontAwesome.Sharp.IconButton minimizar;
        private FontAwesome.Sharp.IconButton iconBtnReload;
        private System.Windows.Forms.ComboBox comboBxTipo;
        private FontAwesome.Sharp.IconButton iconBtnSearch;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
    }
}