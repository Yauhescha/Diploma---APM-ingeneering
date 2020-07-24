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
    public partial class VidachaSrCRUD : Form
    {
        private выдачасизTableAdapter tableAdapter;
        private BindingSource bindingSource;
        movedbDataSet movedb;
        DataGridViewRow currentRow;
        private bool isNew = false;
        public VidachaSrCRUD(выдачасизTableAdapter tableAdapter, BindingSource bindingSource, movedbDataSet movedb, DataGridViewRow currentRow)
        {
            InitializeComponent();
            this.tableAdapter = tableAdapter;
            this.bindingSource = bindingSource;
            this.currentRow = currentRow;
            this.movedb = movedb;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }

        private void VidachaSrCRUD_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "movedbDataSet.сотрудник". При необходимости она может быть перемещена или удалена.
            this.сотрудникTableAdapter.Fill(this.movedbDataSet.сотрудник);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "movedbDataSet.сиз". При необходимости она может быть перемещена или удалена.
            this.сизTableAdapter.Fill(this.movedbDataSet.сиз);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "movedbDataSet.ответственный". При необходимости она может быть перемещена или удалена.
            this.ответственныйTableAdapter.Fill(this.movedbDataSet.ответственный);
            if (currentRow == null) isNew = true;
            else
            {
                comboBox3.SelectedValue =  currentRow.Cells[0].Value.ToString();
                comboBox2.SelectedValue = currentRow.Cells[1].Value.ToString();
                comboBox1.SelectedValue = currentRow.Cells[2].Value.ToString();
                dateTimePicker1.Text = currentRow.Cells[4].Value.ToString();
                numericUpDown1.Value = int.Parse(currentRow.Cells[5].Value.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isNew) insert(); else update();

        }
        private void insert()
        {
            DataRowView row = (DataRowView)bindingSource.AddNew();

            row[0] = dateTimePicker1.Value;
            row[1] = comboBox3.SelectedValue;
            row[2] = comboBox2.SelectedValue;
            row[3] = numericUpDown1.Value;
            row[4] = comboBox1.SelectedValue;
            row[5] = 0;

            bindingSource.EndEdit();
            this.tableAdapter.Update(movedb);
            _5VidachaSr.update = 1;
            MessageBox.Show("Сохранено");

            this.Close();
        }
        private void update()
        {            
            currentRow.Cells[0].Value = comboBox3.SelectedValue;
            currentRow.Cells[1].Value = comboBox2.SelectedValue;
            currentRow.Cells[2].Value = comboBox1.SelectedValue;
            currentRow.Cells[3].Value = dateTimePicker1.Value;
            currentRow.Cells[5].Value = numericUpDown1.Value;

            currentRow.Cells[6].Value = comboBox1.Text;
            currentRow.Cells[7].Value = comboBox1.Text;
            currentRow.Cells[8].Value = comboBox1.Text;
            bindingSource.EndEdit();
            this.tableAdapter.Update(((DataRowView)currentRow.DataBoundItem).Row);
            _5VidachaSr.update = 1;
            MessageBox.Show("Сохранено");
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
