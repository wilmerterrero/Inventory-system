namespace PROG1_PROYECTO_FINAL
{
    partial class Reporte_Productos
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
            this.sys_inventarioDataSet1 = new PROG1_PROYECTO_FINAL.sys_inventarioDataSet1();
            this.MostrarProductosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MostrarProductosTableAdapter = new PROG1_PROYECTO_FINAL.sys_inventarioDataSet1TableAdapters.MostrarProductosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sys_inventarioDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MostrarProductosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(53)))));
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "MostrarProductos";
            reportDataSource1.Value = this.MostrarProductosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PROG1_PROYECTO_FINAL.ReporteProductos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1095, 684);
            this.reportViewer1.TabIndex = 0;
            // 
            // sys_inventarioDataSet1
            // 
            this.sys_inventarioDataSet1.DataSetName = "sys_inventarioDataSet1";
            this.sys_inventarioDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // MostrarProductosBindingSource
            // 
            this.MostrarProductosBindingSource.DataMember = "MostrarProductos";
            this.MostrarProductosBindingSource.DataSource = this.sys_inventarioDataSet1;
            // 
            // MostrarProductosTableAdapter
            // 
            this.MostrarProductosTableAdapter.ClearBeforeFill = true;
            // 
            // Reporte_Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 684);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Reporte_Productos";
            this.Text = "Reporte_Productos";
            this.Load += new System.EventHandler(this.Reporte_Productos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sys_inventarioDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MostrarProductosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource MostrarProductosBindingSource;
        private sys_inventarioDataSet1 sys_inventarioDataSet1;
        private sys_inventarioDataSet1TableAdapters.MostrarProductosTableAdapter MostrarProductosTableAdapter;
    }
}