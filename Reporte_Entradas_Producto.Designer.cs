namespace PROG1_PROYECTO_FINAL
{
    partial class Reporte_Entradas_Producto
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
            this.sys_inventarioDataSet4 = new PROG1_PROYECTO_FINAL.sys_inventarioDataSet4();
            this.MostrarEntradasProductosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MostrarEntradasProductosTableAdapter = new PROG1_PROYECTO_FINAL.sys_inventarioDataSet4TableAdapters.MostrarEntradasProductosTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sys_inventarioDataSet6 = new PROG1_PROYECTO_FINAL.sys_inventarioDataSet6();
            this.EntradasProductoFiltroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.EntradasProductoFiltroTableAdapter = new PROG1_PROYECTO_FINAL.sys_inventarioDataSet6TableAdapters.EntradasProductoFiltroTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sys_inventarioDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MostrarEntradasProductosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sys_inventarioDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EntradasProductoFiltroBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // sys_inventarioDataSet4
            // 
            this.sys_inventarioDataSet4.DataSetName = "sys_inventarioDataSet4";
            this.sys_inventarioDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // MostrarEntradasProductosBindingSource
            // 
            this.MostrarEntradasProductosBindingSource.DataMember = "MostrarEntradasProductos";
            this.MostrarEntradasProductosBindingSource.DataSource = this.sys_inventarioDataSet4;
            // 
            // MostrarEntradasProductosTableAdapter
            // 
            this.MostrarEntradasProductosTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "FiltroEntradasProductos";
            reportDataSource1.Value = this.EntradasProductoFiltroBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PROG1_PROYECTO_FINAL.ReporteEntradasProducto.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // sys_inventarioDataSet6
            // 
            this.sys_inventarioDataSet6.DataSetName = "sys_inventarioDataSet6";
            this.sys_inventarioDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // EntradasProductoFiltroBindingSource
            // 
            this.EntradasProductoFiltroBindingSource.DataMember = "EntradasProductoFiltro";
            this.EntradasProductoFiltroBindingSource.DataSource = this.sys_inventarioDataSet6;
            // 
            // EntradasProductoFiltroTableAdapter
            // 
            this.EntradasProductoFiltroTableAdapter.ClearBeforeFill = true;
            // 
            // Reporte_Entradas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Reporte_Entradas";
            this.Text = "Reporte_Entradas";
            this.Load += new System.EventHandler(this.Reporte_Entradas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sys_inventarioDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MostrarEntradasProductosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sys_inventarioDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EntradasProductoFiltroBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource MostrarEntradasProductosBindingSource;
        private sys_inventarioDataSet4 sys_inventarioDataSet4;
        private sys_inventarioDataSet4TableAdapters.MostrarEntradasProductosTableAdapter MostrarEntradasProductosTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource EntradasProductoFiltroBindingSource;
        private sys_inventarioDataSet6 sys_inventarioDataSet6;
        private sys_inventarioDataSet6TableAdapters.EntradasProductoFiltroTableAdapter EntradasProductoFiltroTableAdapter;
    }
}