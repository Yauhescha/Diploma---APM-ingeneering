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
    public partial class _1PlanSanCRUD : Form
    {
        private группаTableAdapter группаTableAdapter;
        private BindingSource группаBindingSource;
        private movedbDataSet movedbDataSet;
        DataGridViewRow currentRow;
        private bool isNew = false; 

        public _1PlanSanCRUD(группаTableAdapter группаTableAdapter, BindingSource группаBindingSource, movedbDataSet movedbDataSet, DataGridViewRow currentRow)
        {
            InitializeComponent();
            this.группаTableAdapter = группаTableAdapter;
            this.группаBindingSource = группаBindingSource;
            this.movedbDataSet = movedbDataSet;
            if (currentRow == null)
                isNew = true;
            else
            {
                textBox1.Text = currentRow.Cells[0].Value.ToString();
                textBox2.Text = currentRow.Cells[1].Value.ToString();
                this.currentRow = currentRow;
            }
            
        }

        private void _1PlanSanCRUD_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (isNew) insert(); else update();
            }
            catch (Exception ex) { MessageBox.Show("Проверьте вводимые значения"); }
        }
        private void insert() {
            DataRowView row = (DataRowView)группаBindingSource.AddNew();

            row[1] = textBox2.Text;

            группаBindingSource.EndEdit();
            this.группаTableAdapter.Update(movedbDataSet);
            this.группаTableAdapter.Fill(this.movedbDataSet.группа);
            MessageBox.Show("Сохранено");

            this.Close();
        }
        private void update() {
            currentRow.Cells[1].Value = textBox2.Text;
            this.группаTableAdapter.Update(((DataRowView)currentRow.DataBoundItem).Row);
            MessageBox.Show("Сохранено");
            this.Close();
        }

    }
}

