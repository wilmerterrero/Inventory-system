namespace PROG1_PROYECTO_FINAL
{
    partial class Reporte_Entradas_Fecha
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
            this.Filtro_Entrada_Fecha = new PROG1_PROYECTO_FINAL.Filtro_Entrada_Fecha();
            this.EntradasFechaFiltroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.EntradasFechaFiltroTableAdapter = new PROG1_PROYECTO_FINAL.Filtro_Entrada_FechaTableAdapters.EntradasFechaFiltroTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Filtro_Entrada_Fecha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EntradasFechaFiltroBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.EntradasFechaFiltroBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PROG1_PROYECTO_FINAL.Reporte_Filtro_Entrada_Fecha.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // Filtro_Entrada_Fecha
            // 
            this.Filtro_Entrada_Fecha.DataSetName = "Filtro_Entrada_Fecha";
            this.Filtro_Entrada_Fecha.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // EntradasFechaFiltroBindingSource
            // 
            this.EntradasFechaFiltroBindingSource.DataMember = "EntradasFechaFiltro";
            this.EntradasFechaFiltroBindingSource.DataSource = this.Filtro_Entrada_Fecha;
            // 
            // EntradasFechaFiltroTableAdapter
            // 
            this.EntradasFechaFiltroTableAdapter.ClearBeforeFill = true;
            // 
            // Reporte_Entradas_Fecha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Reporte_Entradas_Fecha";
            this.Text = "Reporte_Entradas_Fecha";
            this.Load += new System.EventHandler(this.Reporte_Entradas_Fecha_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Filtro_Entrada_Fecha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EntradasFechaFiltroBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource EntradasFechaFiltroBindingSource;
        private Filtro_Entrada_Fecha Filtro_Entrada_Fecha;
        private Filtro_Entrada_FechaTableAdapters.EntradasFechaFiltroTableAdapter EntradasFechaFiltroTableAdapter;
    }
}