namespace PROG1_PROYECTO_FINAL
{
    partial class Reporte_Producto_Nombre
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
            this.Filtro_Producto_Nombre = new PROG1_PROYECTO_FINAL.Filtro_Producto_Nombre();
            this.FiltroProductosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.FiltroProductosTableAdapter = new PROG1_PROYECTO_FINAL.Filtro_Producto_NombreTableAdapters.FiltroProductosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Filtro_Producto_Nombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FiltroProductosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.FiltroProductosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PROG1_PROYECTO_FINAL.Reporte_Filtro_Producto_Nombre.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // Filtro_Producto_Nombre
            // 
            this.Filtro_Producto_Nombre.DataSetName = "Filtro_Producto_Nombre";
            this.Filtro_Producto_Nombre.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FiltroProductosBindingSource
            // 
            this.FiltroProductosBindingSource.DataMember = "FiltroProductos";
            this.FiltroProductosBindingSource.DataSource = this.Filtro_Producto_Nombre;
            // 
            // FiltroProductosTableAdapter
            // 
            this.FiltroProductosTableAdapter.ClearBeforeFill = true;
            // 
            // Reporte_Producto_Nombre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Reporte_Producto_Nombre";
            this.Text = "Reporte_Producto_Nombre";
            this.Load += new System.EventHandler(this.Reporte_Producto_Nombre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Filtro_Producto_Nombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FiltroProductosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource FiltroProductosBindingSource;
        private Filtro_Producto_Nombre Filtro_Producto_Nombre;
        private Filtro_Producto_NombreTableAdapters.FiltroProductosTableAdapter FiltroProductosTableAdapter;
    }
}