using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AOM_ingeneering.movedbDataSetTableAdapters;

namespace AOM_ingeneering
{
    public partial class SostavGroupCRUD : Form
    {
        составгруппыTableAdapter tableAdapter;
        private BindingSource bindingSource;
        private movedbDataSet movedbDataSet;
        private DataGridViewRow currentRow;
        private bool isNew = false;


        public SostavGroupCRUD(составгруппыTableAdapter составгруппыTableAdapter, BindingSource bindingSource, movedbDataSet movedbDataSet, DataGridViewRow currentRow)
        {
            InitializeComponent();
            this.tableAdapter = составгруппыTableAdapter;
            this.bindingSource = bindingSource;
            this.movedbDataSet = movedbDataSet;
            this.currentRow = currentRow;

            if (currentRow == null) isNew = true;
            else {
                textBox1.Text = currentRow.Cells[0].Value.ToString();
                textBox2.Text = currentRow.Cells[1].Value.ToString();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (isNew) insert(); else update();
            }
            catch (Exception ex) { MessageBox.Show("Проверьте вводимые значения. Возможно таких ИД не существует"); }
        }
        private void insert()
        {
            DataRowView row = (DataRowView)bindingSource.AddNew();

            row[0] = textBox1.Text;
            row[1] = textBox2.Text;

            bindingSource.EndEdit();
            this.tableAdapter.Update(movedbDataSet);
            this.tableAdapter.Fill(this.movedbDataSet.составгруппы);
            MessageBox.Show("Сохранено");

            this.Close();
        }
        private void update()
        {
            currentRow.Cells[0].Value = textBox1.Text;
            currentRow.Cells[1].Value = textBox2.Text;
            this.tableAdapter.Update(((DataRowView)currentRow.DataBoundItem).Row);
            MessageBox.Show("Сохранено");
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
