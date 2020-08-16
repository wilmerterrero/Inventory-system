namespace PROG1_PROYECTO_FINAL
{
    partial class Reporte_Clientes_Nombre
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
            this.Filtro_Clientes_Nombre = new PROG1_PROYECTO_FINAL.Filtro_Clientes_Nombre();
            this.ClientesNombreFiltroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ClientesNombreFiltroTableAdapter = new PROG1_PROYECTO_FINAL.Filtro_Clientes_NombreTableAdapters.ClientesNombreFiltroTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Filtro_Clientes_Nombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientesNombreFiltroBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "ClienteNombre";
            reportDataSource1.Value = this.ClientesNombreFiltroBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PROG1_PROYECTO_FINAL.Reporte_Cliente_Nombre.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // Filtro_Clientes_Nombre
            // 
            this.Filtro_Clientes_Nombre.DataSetName = "Filtro_Clientes_Nombre";
            this.Filtro_Clientes_Nombre.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ClientesNombreFiltroBindingSource
            // 
            this.ClientesNombreFiltroBindingSource.DataMember = "ClientesNombreFiltro";
            this.ClientesNombreFiltroBindingSource.DataSource = this.Filtro_Clientes_Nombre;
            // 
            // ClientesNombreFiltroTableAdapter
            // 
            this.ClientesNombreFiltroTableAdapter.ClearBeforeFill = true;
            // 
            // Reporte_Clientes_Nombre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Reporte_Clientes_Nombre";
            this.Text = "Reporte_Clientes_Nombre";
            this.Load += new System.EventHandler(this.Reporte_Clientes_Nombre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Filtro_Clientes_Nombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientesNombreFiltroBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ClientesNombreFiltroBindingSource;
        private Filtro_Clientes_Nombre Filtro_Clientes_Nombre;
        private Filtro_Clientes_NombreTableAdapters.ClientesNombreFiltroTableAdapter ClientesNombreFiltroTableAdapter;
    }
}