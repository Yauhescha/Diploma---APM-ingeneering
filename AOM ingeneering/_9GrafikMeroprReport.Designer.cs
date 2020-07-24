namespace AOM_ingeneering
{
    partial class _9GrafikMeroprReport
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.movedbDataSet = new AOM_ingeneering.movedbDataSet();
            this.графикBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.графикTableAdapter = new AOM_ingeneering.movedbDataSetTableAdapters.графикTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.movedbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.графикBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "graphik";
            reportDataSource2.Value = this.графикBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "AOM_ingeneering._9GrafikMeropr.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // movedbDataSet
            // 
            this.movedbDataSet.DataSetName = "movedbDataSet";
            this.movedbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // графикBindingSource
            // 
            this.графикBindingSource.DataMember = "график";
            this.графикBindingSource.DataSource = this.movedbDataSet;
            // 
            // графикTableAdapter
            // 
            this.графикTableAdapter.ClearBeforeFill = true;
            // 
            // _9GrafikMeroprReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "_9GrafikMeroprReport";
            this.Text = "Отчет";
            this.Load += new System.EventHandler(this._9GrafikMeroprCRUD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.movedbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.графикBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource графикBindingSource;
        private movedbDataSet movedbDataSet;
        private movedbDataSetTableAdapters.графикTableAdapter графикTableAdapter;
    }
}