namespace AOM_ingeneering
{
    partial class PlanSanCRUD
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.movedbDataSet1 = new AOM_ingeneering.movedbDataSet();
            this.группаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.группаTableAdapter = new AOM_ingeneering.movedbDataSetTableAdapters.группаTableAdapter();
            this.темазанятийBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.темазанятийTableAdapter = new AOM_ingeneering.movedbDataSetTableAdapters.темазанятийTableAdapter();
            this.ответственныйBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ответственныйTableAdapter = new AOM_ingeneering.movedbDataSetTableAdapters.ответственныйTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.movedbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.группаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.темазанятийBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ответственныйBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(161, 147);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 26);
            this.button2.TabIndex = 19;
            this.button2.Text = "Выход";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(13, 147);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 26);
            this.button1.TabIndex = 18;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(10, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Группа";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(10, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Дата";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(10, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 21;
            this.label3.Text = "ФИО";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(10, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "Тема";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(113, 13);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(154, 20);
            this.dateTimePicker1.TabIndex = 24;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.группаBindingSource;
            this.comboBox1.DisplayMember = "Группа";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(113, 40);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(154, 21);
            this.comboBox1.TabIndex = 25;
            this.comboBox1.ValueMember = "ID";
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.темазанятийBindingSource;
            this.comboBox2.DisplayMember = "Тема";
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(113, 76);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(154, 21);
            this.comboBox2.TabIndex = 26;
            this.comboBox2.ValueMember = "ID";
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.ответственныйBindingSource;
            this.comboBox3.DisplayMember = "ФИО";
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(113, 110);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(154, 21);
            this.comboBox3.TabIndex = 27;
            this.comboBox3.ValueMember = "ID";
            // 
            // movedbDataSet1
            // 
            this.movedbDataSet1.DataSetName = "movedbDataSet";
            this.movedbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // группаBindingSource
            // 
            this.группаBindingSource.DataMember = "группа";
            this.группаBindingSource.DataSource = this.movedbDataSet1;
            // 
            // группаTableAdapter
            // 
            this.группаTableAdapter.ClearBeforeFill = true;
            // 
            // темазанятийBindingSource
            // 
            this.темазанятийBindingSource.DataMember = "темазанятий";
            this.темазанятийBindingSource.DataSource = this.movedbDataSet1;
            // 
            // темазанятийTableAdapter
            // 
            this.темазанятийTableAdapter.ClearBeforeFill = true;
            // 
            // ответственныйBindingSource
            // 
            this.ответственныйBindingSource.DataMember = "ответственный";
            this.ответственныйBindingSource.DataSource = this.movedbDataSet1;
            // 
            // ответственныйTableAdapter
            // 
            this.ответственныйTableAdapter.ClearBeforeFill = true;
            // 
            // PlanSanCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 182);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PlanSanCRUD";
            this.Text = "Работа с записью в таблице План занятий";
            this.Load += new System.EventHandler(this.PlanSanCRUD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.movedbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.группаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.темазанятийBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ответственныйBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private movedbDataSet movedbDataSet1;
        private System.Windows.Forms.BindingSource группаBindingSource;
        private movedbDataSetTableAdapters.группаTableAdapter группаTableAdapter;
        private System.Windows.Forms.BindingSource темазанятийBindingSource;
        private movedbDataSetTableAdapters.темазанятийTableAdapter темазанятийTableAdapter;
        private System.Windows.Forms.BindingSource ответственныйBindingSource;
        private movedbDataSetTableAdapters.ответственныйTableAdapter ответственныйTableAdapter;
    }
}