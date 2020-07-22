namespace PROG1_PROYECTO_FINAL
{
    partial class Reporte_Producto_Inventario
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Reporte_Inventario = new PROG1_PROYECTO_FINAL.Reporte_Inventario();
            this.MostrarInventarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MostrarInventarioTableAdapter = new PROG1_PROYECTO_FINAL.Reporte_InventarioTableAdapters.MostrarInventarioTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Reporte_Inventario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MostrarInventarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(53)))));
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "MostrarInventario";
            reportDataSource1.Value = this.MostrarInventarioBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PROG1_PROYECTO_FINAL.Reporte_Productos_Inventario.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // Reporte_Inventario
            // 
            this.Reporte_Inventario.DataSetName = "Reporte_Inventario";
            this.Reporte_Inventario.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // MostrarInventarioBindingSource
            // 
            this.MostrarInventarioBindingSource.DataMember = "MostrarInventario";
            this.MostrarInventarioBindingSource.DataSource = this.Reporte_Inventario;
            // 
            // MostrarInventarioTableAdapter
            // 
            this.MostrarInventarioTableAdapter.ClearBeforeFill = true;
            // 
            // Reporte_Producto_Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Reporte_Producto_Inventario";
            this.Text = "Reporte_Producto_Inventario";
            this.Load += new System.EventHandler(this.Reporte_Producto_Inventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Reporte_Inventario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MostrarInventarioBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource MostrarInventarioBindingSource;
        private Reporte_Inventario Reporte_Inventario;
        private Reporte_InventarioTableAdapters.MostrarInventarioTableAdapter MostrarInventarioTableAdapter;
    }
}