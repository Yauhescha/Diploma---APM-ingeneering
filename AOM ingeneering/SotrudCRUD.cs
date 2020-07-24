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
    public partial class SotrudCRUD : Form
    {
        private сотрудникTableAdapter tableAdapter;
        private BindingSource bindingSource;
        private movedbDataSet movedbDataSet;
        DataGridViewRow currentRow;
        private bool isNew = false;
        public SotrudCRUD(сотрудникTableAdapter tableAdapter, BindingSource bindingSource, movedbDataSet movedbDataSet,DataGridViewRow currentRow)
        {
            InitializeComponent();
            this.tableAdapter = tableAdapter;
            this.bindingSource = bindingSource;
            this.currentRow = currentRow;
            this.movedbDataSet = movedbDataSet;
            if (currentRow == null) isNew = true;
            else
            {
                textBox1.Text= currentRow.Cells[0].Value.ToString();
                textBox2.Text = currentRow.Cells[1].Value.ToString();
                dateTimePicker1.Text = currentRow.Cells[2].Value.ToString();
                dateTimePicker2.Text = currentRow.Cells[3].Value.ToString();
                textBox3.Text = currentRow.Cells[4].Value.ToString();
                if (currentRow.Cells[5].Value.ToString().Length > 0)
                {
                    dateTimePicker3.Text = currentRow.Cells[5].Value.ToString();
                    checkBox1.Checked = true;
                }
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
            DataRowView row = (DataRowView)bindingSource.AddNew();

            
            row[1] = textBox2.Text;
            row[2] = dateTimePicker1.Value;
            row[3] = dateTimePicker2.Value;
            row[4] = textBox3.Text;
            if (checkBox1.Checked)
                row[5] = dateTimePicker3.Text;
            
            bindingSource.EndEdit();
            this.tableAdapter.Update(movedbDataSet);
            this.tableAdapter.Fill(this.movedbDataSet.сотрудник);
            MessageBox.Show("Сохранено");

            this.Close();
        }
        private void update()
        {
            currentRow.Cells[1].Value = textBox2.Text;
            currentRow.Cells[2].Value = dateTimePicker1.Text;
            currentRow.Cells[3].Value = dateTimePicker2.Text;
            currentRow.Cells[4].Value = textBox3.Text;
            if (checkBox1.Checked)
                currentRow.Cells[5].Value = dateTimePicker3.Value;
            bindingSource.EndEdit();
            this.tableAdapter.Update(((DataRowView)currentRow.DataBoundItem).Row);
            MessageBox.Show("Сохранено");
            this.Close();
        }
    }
}
