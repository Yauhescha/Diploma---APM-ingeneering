using AOM_ingeneering.movedbDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AOM_ingeneering
{
    public partial class PlanInstrCRUD : Form
    {
        private планинструктажейTableAdapter tableAdapter;
        private BindingSource bindingSource;
        movedbDataSet movedb;
        DataGridViewRow currentRow;
        private bool isNew = false;
        public PlanInstrCRUD(планинструктажейTableAdapter tableAdapter, BindingSource bindingSource, movedbDataSet movedb, DataGridViewRow currentRow)
        {
            InitializeComponent();
            this.tableAdapter = tableAdapter;
            this.bindingSource = bindingSource;
            this.currentRow = currentRow;
            this.movedb = movedb;
        }

        private void PlanInstrCRUD_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "movedbDataSet.ответственный". При необходимости она может быть перемещена или удалена.
            this.ответственныйTableAdapter.Fill(this.movedbDataSet.ответственный);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "movedbDataSet.сотрудник". При необходимости она может быть перемещена или удалена.
            this.сотрудникTableAdapter.Fill(this.movedbDataSet.сотрудник);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "movedbDataSet.инструктаж". При необходимости она может быть перемещена или удалена.
            this.инструктажTableAdapter.Fill(this.movedbDataSet.инструктаж);
            if (currentRow == null) isNew = true;
            else
            {
                comboBox1.SelectedValue = currentRow.Cells[0].Value.ToString();
                comboBox2.SelectedValue = currentRow.Cells[1].Value.ToString();
                dateTimePicker1.Text = currentRow.Cells[2].Value.ToString();
                dateTimePicker2.Text = currentRow.Cells[3].Value.ToString();
                comboBox3.SelectedValue = currentRow.Cells[4].Value.ToString();
                checkBox1.Checked = bool.Parse(currentRow.Cells[5].Value.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
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

                row[0] = comboBox1.SelectedValue;
                row[1] = comboBox2.SelectedValue;
                row[2] = dateTimePicker1.Value;
                row[3] = dateTimePicker2.Value;
                row[4] = comboBox3.SelectedValue;
                row[5] = checkBox1.Checked;
                bindingSource.EndEdit();
                this.tableAdapter.Update(movedb);
                _3PlanInstr.update = 1;
                MessageBox.Show("Сохранено");

                this.Close();
            }
            catch (Exception ex) { MessageBox.Show("Ошибка введенных данных"); }
        }
        private void update()
        {
            try { 
                currentRow.Cells[0].Value = comboBox1.SelectedValue;
                currentRow.Cells[1].Value = comboBox2.SelectedValue;
                currentRow.Cells[2].Value = dateTimePicker1.Text;
                currentRow.Cells[3].Value = dateTimePicker2.Text;
                currentRow.Cells[4].Value = comboBox3.SelectedValue;
                currentRow.Cells[5].Value = checkBox1.Checked;
                bindingSource.EndEdit();
                this.tableAdapter.Update(((DataRowView)currentRow.DataBoundItem).Row);
                MessageBox.Show("Сохранено");
                _3PlanInstr.update = 1;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка введенных данных");
            }
        }
    }
}
