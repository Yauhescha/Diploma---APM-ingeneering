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
    public partial class _6Otwetstwen : Form
    {
        public _6Otwetstwen()
        {
            InitializeComponent();
        }

        private void _6Otwetstwen_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "movedbDataSet.ответственный". При необходимости она может быть перемещена или удалена.
            this.ответственныйTableAdapter.Fill(this.movedbDataSet.ответственный);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void сохранитьToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
            ответственныйTableAdapter.Update(movedbDataSet.ответственный);  
            }
            catch (Exception ex) { MessageBox.Show("Ошибка. Возможно вы пытаетесь удалить используемый объект"); }
        }
        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            DataGridError.Msg();
        }
    }
}
