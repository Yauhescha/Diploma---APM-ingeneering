using AOM_ingeneering.movedbDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AOM_ingeneering
{
    public partial class InzidentCRUD : Form
    {
        private инцидентTableAdapter tableAdapter;
        private BindingSource bindingSource;
        DataGridViewRow currentRow;
        movedbDataSet movedb;
        private bool isNew = false;
        public InzidentCRUD(инцидентTableAdapter tableAdapter, BindingSource bindingSource, movedbDataSet movedb, DataGridViewRow currentRow)
        {
            InitializeComponent();
            this.tableAdapter = tableAdapter;
            this.bindingSource = bindingSource;
            this.currentRow = currentRow;
            this.movedb = movedb;
        }

        private void InzidentCRUD_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "movedbDataSet.сотрудник". При необходимости она может быть перемещена или удалена.
            this.сотрудникTableAdapter.Fill(this.movedbDataSet.сотрудник);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "movedbDataSet.видинцидента". При необходимости она может быть перемещена или удалена.
            this.видинцидентаTableAdapter.Fill(this.movedbDataSet.видинцидента);
            if (currentRow == null) isNew = true;
            else
            {
                comboBox1.SelectedValue = currentRow.Cells[1].Value.ToString();
                dateTimePicker1.Text = currentRow.Cells[3].Value.ToString();
                textBox2.Text = currentRow.Cells[4].Value.ToString();
                comboBox2.SelectedValue = currentRow.Cells[5].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isNew) insert(); else update();

        }
        private void insert()
        {
            try
            {

                DataRowView row = (DataRowView)bindingSource.AddNew();

                row[1] = dateTimePicker1.Value;
                row[2] = comboBox2.SelectedValue;
                row[3] = comboBox1.SelectedValue;
                row[4] = textBox2.Text;
                bindingSource.EndEdit();
                this.tableAdapter.Update(movedb);
                
                MessageBox.Show("Сохранено");

                this.Close();
            }
            catch (Exception ex) { MessageBox.Show("Ошибка введенных данных"); }
        }
        private void update()
        {
            try
            {
                currentRow.Cells[1].Value = comboBox1.SelectedValue;
                currentRow.Cells[2].Value = comboBox1.Text;
                currentRow.Cells[3].Value = dateTimePicker1.Value;
                currentRow.Cells[4].Value = textBox2.Text;
                currentRow.Cells[5].Value = comboBox2.SelectedValue;
                currentRow.Cells[6].Value = comboBox2.Text;
                bindingSource.EndEdit();
                _7Inzident.update = 1;
                this.tableAdapter.Update(((DataRowView)currentRow.DataBoundItem).Row);
                movedb.AcceptChanges();
                MessageBox.Show("Сохранено");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка введенных данных");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
