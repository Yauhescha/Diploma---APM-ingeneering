using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AOM_ingeneering
{
    public partial class _2NormDoc : Form
    {
       

        public _2NormDoc()
        {
            InitializeComponent();
            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void _2NormDoc_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "movedbDataSet.документ". При необходимости она может быть перемещена или удалена.
            this.документTableAdapter.Fill(this.movedbDataSet.документ);

        }
        //add
        private void button1_Click(object sender, EventArgs e)
        {
            new NormDocCRUD(документTableAdapter, документBindingSource, movedbDataSet, null).Show();
        }
        //update
        private void button2_Click(object sender, EventArgs e)
        {
            if(dataGridView1.RowCount>0)
                new NormDocCRUD(документTableAdapter, документBindingSource, movedbDataSet, dataGridView1.CurrentRow).Show();
        }
        //delete
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (DataGridError.isRemove())
                    if (dataGridView1.RowCount > 0 && dataGridView1.SelectedCells.Count > 0)
                    {
                        документBindingSource.RemoveAt(dataGridView1.CurrentRow.Index);
                        документTableAdapter.Update(movedbDataSet.документ);
                    }
            }
            catch (Exception ex) { MessageBox.Show("Ошибка. Возможно вы пытаетесь удалить используемый объект"); }
        }
       

        void printDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Bitmap bmp = new Bitmap(dataGridView1.Size.Width, this.dataGridView1.Height*2);
            dataGridView1.DrawToBitmap(bmp, new Rectangle(0, 0, this.dataGridView1.Width, this.dataGridView1.Height*2));
            e.Graphics.DrawImage(bmp, 0, 0);
        }
        //print
        private void button5_Click(object sender, EventArgs e)
        {
            ClsPrint _ClsPrint = new ClsPrint(dataGridView1, this.Text);
            _ClsPrint.PrintForm();
        }
       

        //exit
        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void radioButton4_Click(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns[1],ListSortDirection.Ascending);
        }

        private void radioButton3_Click(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns[2], ListSortDirection.Ascending);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") this.документTableAdapter.Fill(this.movedbDataSet.документ);
            else {
                if(radioButton1.Checked) this.документTableAdapter.FillByDoc(this.movedbDataSet.документ,$"%{textBox1.Text}%");
                else this.документTableAdapter.FillByName(this.movedbDataSet.документ, $"%{textBox1.Text}%");
            }
        }


        private void шрифтСтолбцовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            fd.ShowDialog();
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
                dataGridView1.Columns[i].DefaultCellStyle.Font = fd.Font;
        }

        private void шрифтЗаголовковToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            fd.ShowDialog();
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = fd.Font;
        }

        private void фонСтолбцаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.ShowDialog();
            int x = dataGridView1.CurrentCellAddress.X;
            dataGridView1.Columns[x].DefaultCellStyle.BackColor = cd.Color;
        }


        private void фонЗаголовкаСтолбцаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.ShowDialog();
            int x = dataGridView1.CurrentCellAddress.X;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Columns[x].HeaderCell.Style.BackColor = cd.Color;
        }

        private void шрифтСтолбцаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            fd.ShowDialog();
            int x = dataGridView1.CurrentCellAddress.X;
            dataGridView1.Columns[x].DefaultCellStyle.Font = fd.Font;
        }

        private void _2NormDoc_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Hide();
            }
        }

        private void отчетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new _2NormDocReport().Show();
        }
    }
}
