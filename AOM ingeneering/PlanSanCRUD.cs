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
    public partial class PlanSanCRUD : Form
    {
        private планзанятийTableAdapter tableAdapter;
        private BindingSource bindingSource;
        private movedbDataSet movedbDataSet;
        DataGridViewRow currentRow;
        private bool isNew = false;
        public PlanSanCRUD(планзанятийTableAdapter планзанятийTableAdapter, BindingSource bindingSource, movedbDataSet movedbDataSet, DataGridViewRow currentRow)
        {
            InitializeComponent();
            this.tableAdapter = планзанятийTableAdapter;
            this.bindingSource = bindingSource;
            this.movedbDataSet = movedbDataSet;
            this.currentRow = currentRow;

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (isNew) insert(); else update();
            }
            catch (Exception ex) { MessageBox.Show("Проверьте вводимые значения"); }
        }
        private void insert()
        {
            DataRowView row = (DataRowView)bindingSource.AddNew();

            row[0] = comboBox1.SelectedValue;
            row[1] = comboBox2.SelectedValue;
            row[2] = dateTimePicker1.Text;
            row[3] = comboBox3.SelectedValue;
            bindingSource.EndEdit();
            this.tableAdapter.Update(movedbDataSet);
            this.tableAdapter.Fill(this.movedbDataSet.планзанятий);
            MessageBox.Show("Сохранено");

            this.Close();
        }
        private void update()
        {
            currentRow.Cells[0].Value = comboBox1.SelectedValue;
            currentRow.Cells[1].Value = comboBox1.Text;
            currentRow.Cells[2].Value = comboBox2.SelectedValue;
            currentRow.Cells[3].Value = comboBox3.SelectedValue;
            currentRow.Cells[4].Value = dateTimePicker1.Text;
            currentRow.Cells[5].Value = comboBox2.Text;
            currentRow.Cells[6].Value = comboBox3.Text;
            this.tableAdapter.Update(((DataRowView)currentRow.DataBoundItem).Row);
            MessageBox.Show("Сохранено");
            this.Close();
        }

        private void PlanSanCRUD_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "movedbDataSet1.ответственный". При необходимости она может быть перемещена или удалена.
            this.ответственныйTableAdapter.Fill(this.movedbDataSet1.ответственный);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "movedbDataSet1.темазанятий". При необходимости она может быть перемещена или удалена.
            this.темазанятийTableAdapter.Fill(this.movedbDataSet1.темазанятий);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "movedbDataSet1.группа". При необходимости она может быть перемещена или удалена.
            this.группаTableAdapter.Fill(this.movedbDataSet1.группа);
            if (currentRow == null) isNew = true;
            else
            {
                comboBox1.SelectedValue = currentRow.Cells[0].Value.ToString();
                comboBox2.SelectedValue = currentRow.Cells[2].Value.ToString();
                comboBox3.SelectedValue = currentRow.Cells[3].Value.ToString();
                dateTimePicker1.Text = currentRow.Cells[4].Value.ToString();
            }
        }
    }
}
