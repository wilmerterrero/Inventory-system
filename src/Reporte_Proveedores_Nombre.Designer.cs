namespace PROG1_PROYECTO_FINAL
{
    partial class Reporte_Proveedores_Nombre
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
            this.Filtro_Proveedor_Nombre = new PROG1_PROYECTO_FINAL.Filtro_Proveedor_Nombre();
            this.ProveedorNombreFiltroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ProveedorNombreFiltroTableAdapter = new PROG1_PROYECTO_FINAL.Filtro_Proveedor_NombreTableAdapters.ProveedorNombreFiltroTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Filtro_Proveedor_Nombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProveedorNombreFiltroBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "FiltroProveedorNombre";
            reportDataSource1.Value = this.ProveedorNombreFiltroBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PROG1_PROYECTO_FINAL.Reporte_Proveedor_Nombre.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // Filtro_Proveedor_Nombre
            // 
            this.Filtro_Proveedor_Nombre.DataSetName = "Filtro_Proveedor_Nombre";
            this.Filtro_Proveedor_Nombre.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ProveedorNombreFiltroBindingSource
            // 
            this.ProveedorNombreFiltroBindingSource.DataMember = "ProveedorNombreFiltro";
            this.ProveedorNombreFiltroBindingSource.DataSource = this.Filtro_Proveedor_Nombre;
            // 
            // ProveedorNombreFiltroTableAdapter
            // 
            this.ProveedorNombreFiltroTableAdapter.ClearBeforeFill = true;
            // 
            // Reporte_Proveedores_Nombre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Reporte_Proveedores_Nombre";
            this.Text = "Reporte_Proveedores_Nombre";
            this.Load += new System.EventHandler(this.Reporte_Proveedores_Nombre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Filtro_Proveedor_Nombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProveedorNombreFiltroBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ProveedorNombreFiltroBindingSource;
        private Filtro_Proveedor_Nombre Filtro_Proveedor_Nombre;
        private Filtro_Proveedor_NombreTableAdapters.ProveedorNombreFiltroTableAdapter ProveedorNombreFiltroTableAdapter;
    }
}