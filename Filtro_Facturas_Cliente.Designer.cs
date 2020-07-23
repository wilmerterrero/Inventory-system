namespace PROG1_PROYECTO_FINAL
{
    partial class Filtro_Facturas_Cliente
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
            this.Filtro_Factura_Cliente = new PROG1_PROYECTO_FINAL.Filtro_Factura_Cliente();
            this.FiltroFacturaClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.FiltroFacturaClienteTableAdapter = new PROG1_PROYECTO_FINAL.Filtro_Factura_ClienteTableAdapters.FiltroFacturaClienteTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Filtro_Factura_Cliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FiltroFacturaClienteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.FiltroFacturaClienteBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PROG1_PROYECTO_FINAL.Reporte_Filtro_Factura_Cliente.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1430, 357);
            this.reportViewer1.TabIndex = 0;
            // 
            // Filtro_Factura_Cliente
            // 
            this.Filtro_Factura_Cliente.DataSetName = "Filtro_Factura_Cliente";
            this.Filtro_Factura_Cliente.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FiltroFacturaClienteBindingSource
            // 
            this.FiltroFacturaClienteBindingSource.DataMember = "FiltroFacturaCliente";
            this.FiltroFacturaClienteBindingSource.DataSource = this.Filtro_Factura_Cliente;
            // 
            // FiltroFacturaClienteTableAdapter
            // 
            this.FiltroFacturaClienteTableAdapter.ClearBeforeFill = true;
            // 
            // Filtro_Facturas_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1430, 357);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Filtro_Facturas_Cliente";
            this.Text = "Filtro_Facturas_Cliente";
            this.Load += new System.EventHandler(this.Filtro_Facturas_Cliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Filtro_Factura_Cliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FiltroFacturaClienteBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource FiltroFacturaClienteBindingSource;
        private Filtro_Factura_Cliente Filtro_Factura_Cliente;
        private Filtro_Factura_ClienteTableAdapters.FiltroFacturaClienteTableAdapter FiltroFacturaClienteTableAdapter;
    }
}