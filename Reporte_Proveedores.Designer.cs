namespace PROG1_PROYECTO_FINAL
{
    partial class Reporte_Proveedores
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
            this.DataSetProveedores = new PROG1_PROYECTO_FINAL.DataSetProveedores();
            this.MostrarProveedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MostrarProveedoresTableAdapter = new PROG1_PROYECTO_FINAL.DataSetProveedoresTableAdapters.MostrarProveedoresTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetProveedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MostrarProveedoresBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(53)))));
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "MostrarProveedores";
            reportDataSource1.Value = this.MostrarProveedoresBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PROG1_PROYECTO_FINAL.ReporteProveedores.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1095, 684);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataSetProveedores
            // 
            this.DataSetProveedores.DataSetName = "DataSetProveedores";
            this.DataSetProveedores.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // MostrarProveedoresBindingSource
            // 
            this.MostrarProveedoresBindingSource.DataMember = "MostrarProveedores";
            this.MostrarProveedoresBindingSource.DataSource = this.DataSetProveedores;
            // 
            // MostrarProveedoresTableAdapter
            // 
            this.MostrarProveedoresTableAdapter.ClearBeforeFill = true;
            // 
            // Reporte_Proveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 684);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Reporte_Proveedores";
            this.Text = "Reporte_Proveedores";
            this.Load += new System.EventHandler(this.Reporte_Proveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSetProveedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MostrarProveedoresBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource MostrarProveedoresBindingSource;
        private DataSetProveedores DataSetProveedores;
        private DataSetProveedoresTableAdapters.MostrarProveedoresTableAdapter MostrarProveedoresTableAdapter;
    }
}