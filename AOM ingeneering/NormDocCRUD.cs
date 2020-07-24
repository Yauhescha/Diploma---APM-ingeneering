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
    public partial class NormDocCRUD : Form
    {
        private документTableAdapter tableAdapter;
        private BindingSource bindingSource;
        private movedbDataSet movedbDataSet;
        DataGridViewRow currentRow;
        private bool isNew = false;
        public NormDocCRUD(документTableAdapter tableAdapter, BindingSource bindingSource, movedbDataSet movedbDataSet, DataGridViewRow currentRow)
        {
            InitializeComponent();
            this.tableAdapter = tableAdapter;
            this.bindingSource = bindingSource;
            this.movedbDataSet = movedbDataSet;
            this.currentRow = currentRow;
            if (currentRow == null) isNew = true;
            else
            {
                textBox1.Text = currentRow.Cells[1].Value.ToString();
                textBox2.Text = currentRow.Cells[2].Value.ToString();
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

            row[1] = textBox1.Text;
            row[2] = textBox2.Text;
            bindingSource.EndEdit();
            this.tableAdapter.Update(movedbDataSet);
            this.tableAdapter.Fill(this.movedbDataSet.документ);
            MessageBox.Show("Сохранено");

            this.Close();
        }
        private void update()
        {
            currentRow.Cells[1].Value = textBox1.Text;
            currentRow.Cells[2].Value = textBox2.Text;
            this.tableAdapter.Update(((DataRowView)currentRow.DataBoundItem).Row);
            MessageBox.Show("Сохранено");
            this.Close();
        }
    }
}
