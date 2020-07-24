namespace AOM_ingeneering
{
    partial class _7inzidentReport
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
            this.инцидентBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.movedbDataSet = new AOM_ingeneering.movedbDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.инцидентTableAdapter = new AOM_ingeneering.movedbDataSetTableAdapters.инцидентTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.инцидентBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movedbDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // инцидентBindingSource
            // 
            this.инцидентBindingSource.DataMember = "инцидент";
            this.инцидентBindingSource.DataSource = this.movedbDataSet;
            // 
            // movedbDataSet
            // 
            this.movedbDataSet.DataSetName = "movedbDataSet";
            this.movedbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "inzident";
            reportDataSource1.Value = this.инцидентBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "AOM_ingeneering._7inzidentReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // инцидентTableAdapter
            // 
            this.инцидентTableAdapter.ClearBeforeFill = true;
            // 
            // _7inzidentReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "_7inzidentReport";
            this.Text = "Отчет";
            this.Load += new System.EventHandler(this._7inzidentReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.инцидентBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movedbDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource инцидентBindingSource;
        private movedbDataSet movedbDataSet;
        private movedbDataSetTableAdapters.инцидентTableAdapter инцидентTableAdapter;
    }
}