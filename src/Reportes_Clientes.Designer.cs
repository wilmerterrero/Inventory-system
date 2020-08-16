namespace PROG1_PROYECTO_FINAL
{
    partial class Reportes_Clientes
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
            this.MostrarClientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sys_inventarioDataSet = new PROG1_PROYECTO_FINAL.sys_inventarioDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.MostrarClientesTableAdapter = new PROG1_PROYECTO_FINAL.sys_inventarioDataSetTableAdapters.MostrarClientesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.MostrarClientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sys_inventarioDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // MostrarClientesBindingSource
            // 
            this.MostrarClientesBindingSource.DataMember = "MostrarClientes";
            this.MostrarClientesBindingSource.DataSource = this.sys_inventarioDataSet;
            // 
            // sys_inventarioDataSet
            // 
            this.sys_inventarioDataSet.DataSetName = "sys_inventarioDataSet";
            this.sys_inventarioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(53)))));
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.MostrarClientesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PROG1_PROYECTO_FINAL.ReporteClientes.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(842, 491);
            this.reportViewer1.TabIndex = 0;
            // 
            // MostrarClientesTableAdapter
            // 
            this.MostrarClientesTableAdapter.ClearBeforeFill = true;
            // 
            // Reportes_Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 491);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Reportes_Clientes";
            this.Text = "Reportes_Clientes";
            this.Load += new System.EventHandler(this.Reportes_Clientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MostrarClientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sys_inventarioDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource MostrarClientesBindingSource;
        private sys_inventarioDataSet sys_inventarioDataSet;
        private sys_inventarioDataSetTableAdapters.MostrarClientesTableAdapter MostrarClientesTableAdapter;
    }
}