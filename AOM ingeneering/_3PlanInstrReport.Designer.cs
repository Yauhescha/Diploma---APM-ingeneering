namespace AOM_ingeneering
{
    partial class _3PlanInstrReport
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
            this.планинструктажейBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.movedbDataSet = new AOM_ingeneering.movedbDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.планинструктажейTableAdapter = new AOM_ingeneering.movedbDataSetTableAdapters.планинструктажейTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.планинструктажейBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movedbDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // планинструктажейBindingSource
            // 
            this.планинструктажейBindingSource.DataMember = "планинструктажей";
            this.планинструктажейBindingSource.DataSource = this.movedbDataSet;
            // 
            // movedbDataSet
            // 
            this.movedbDataSet.DataSetName = "movedbDataSet";
            this.movedbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "planInstr";
            reportDataSource1.Value = this.планинструктажейBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "AOM_ingeneering._3PlanInstrReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // планинструктажейTableAdapter
            // 
            this.планинструктажейTableAdapter.ClearBeforeFill = true;
            // 
            // _3PlanInstrReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "_3PlanInstrReport";
            this.Text = "Отчет";
            this.Load += new System.EventHandler(this._3PlanInstrReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.планинструктажейBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movedbDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource планинструктажейBindingSource;
        private movedbDataSet movedbDataSet;
        private movedbDataSetTableAdapters.планинструктажейTableAdapter планинструктажейTableAdapter;
    }
}