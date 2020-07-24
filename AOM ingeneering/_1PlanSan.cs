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
    public partial class _1PlanSan : Form
    {
        public _1PlanSan()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _1PlanSan_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "movedbDataSet.планзанятий". При необходимости она может быть перемещена или удалена.
            this.планзанятийTableAdapter.Fill(this.movedbDataSet.планзанятий);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "movedbDataSet.ответственный". При необходимости она может быть перемещена или удалена.
            this.ответственныйTableAdapter.Fill(this.movedbDataSet.ответственный);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "movedbDataSet.темазанятий". При необходимости она может быть перемещена или удалена.
            this.темазанятийTableAdapter.Fill(this.movedbDataSet.темазанятий);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "movedbDataSet.планзанятий". При необходимости она может быть перемещена или удалена.
            this.планзанятийTableAdapter.Fill(this.movedbDataSet.планзанятий);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "movedbDataSet.составгруппы". При необходимости она может быть перемещена или удалена.
            this.составгруппыTableAdapter.Fill(this.movedbDataSet.составгруппы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "movedbDataSet.группа". При необходимости она может быть перемещена или удалена.
            this.группаTableAdapter.Fill(this.movedbDataSet.группа);

        }
        //add group
        private void button1_Click(object sender, EventArgs e)
        {
            new _1PlanSanCRUD(группаTableAdapter, группаBindingSource, movedbDataSet, null).Show(); ;
        }
        //update group
        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount>0)
            new _1PlanSanCRUD(группаTableAdapter, группаBindingSource, movedbDataSet,dataGridView1.CurrentRow).Show();;

        }
        //remove group
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
            if (DataGridError.isRemove())
                if (dataGridView1.RowCount > 0 && dataGridView1.SelectedCells.Count > 0) {
                    группаBindingSource.RemoveAt(dataGridView1.CurrentRow.Index);
                    группаTableAdapter.Update(movedbDataSet.группа);
                }
            }
            catch (Exception ex) { MessageBox.Show("Ошибка. Возможно вы пытаетесь удалить используемый объект"); }
        }

        private void _1PlanSan_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Hide();
            }
        }
        //add sost group
        private void button6_Click(object sender, EventArgs e)
        {
            
                new SostavGroupCRUD(составгруппыTableAdapter, составгруппыBindingSource, movedbDataSet, null).Show();
        }
        // update sost group
        private void button5_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
                new SostavGroupCRUD(составгруппыTableAdapter, составгруппыBindingSource, movedbDataSet, dataGridView2.CurrentRow).Show();
        }
        // remove sostGroup
        private void button4_Click(object sender, EventArgs e)
        {
            if (DataGridError.isRemove())
                if (dataGridView2.RowCount > 0 && dataGridView2.SelectedCells.Count > 0)
                {
                    составгруппыBindingSource.RemoveAt(dataGridView2.CurrentRow.Index);
                    составгруппыTableAdapter.Update(movedbDataSet.составгруппы);
                }
        }
        // addPlan
        private void button9_Click(object sender, EventArgs e)
        {
            new PlanSanCRUD(планзанятийTableAdapter, планзанятийBindingSource, movedbDataSet, null).Show();
        }
        //updatePlan
        private void button8_Click(object sender, EventArgs e)
        {
            if (dataGridView3.RowCount > 0 && dataGridView3.SelectedCells.Count > 0)
                new PlanSanCRUD(планзанятийTableAdapter, планзанятийBindingSource, movedbDataSet, dataGridView3.CurrentRow).Show();
        }
        // removePlan
        private void button7_Click(object sender, EventArgs e)
        {
            fixNamePlanSanTable();

            if (DataGridError.isRemove())
                if (dataGridView3.RowCount > 0 && dataGridView3.SelectedCells.Count > 0)
                {
                    планзанятийBindingSource.RemoveAt(dataGridView3.CurrentRow.Index);
                    планзанятийTableAdapter.Update(movedbDataSet.планзанятий);
                }
        }
        private void fixNamePlanSanTable() {


            for (int grid3 = 0; grid3 < dataGridView3.RowCount; grid3++)
            {
                //group name
                for (int grnam = 0; grnam < dataGridView1.RowCount; grnam++)
                {
                    if (dataGridView3[0, grid3].Value.ToString().Equals(dataGridView1[0, grnam].Value.ToString()))
                    {
                        dataGridView3[1, grid3].Value = dataGridView1[1, grnam].Value.ToString();
                        break;
                    }
                }
                //theme name
                for (int theme = 0; theme < dataGridView4.RowCount; theme++)
                {
                    if (dataGridView3[2, grid3].Value.ToString().Equals(dataGridView4[0, theme].Value.ToString()))
                    {
                        dataGridView3[5, grid3].Value = dataGridView4[2, theme].Value.ToString();
                        break;
                    }
                }
                // fio name
                for (int name = 0; name < dataGridView5.RowCount - 1; name++)
                {
                    if (dataGridView3[3, grid3].Value.ToString().Equals(dataGridView5[0, name].Value.ToString()))
                    {
                        dataGridView3[6, grid3].Value = dataGridView5[1, name].Value.ToString();
                        break;
                    }
                }
                }
            }

        private void _1PlanSan_Shown(object sender, EventArgs e)
        {
            
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void dataGridView3_Paint(object sender, PaintEventArgs e)
        {
            fixNamePlanSanTable();
        }

        private void шрифтСтолбцовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            fd.ShowDialog();
            for(int i=0; i<dataGridView1.Columns.Count;i++)
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
            dataGridView1.EnableHeadersVisualStyles = false ;
            dataGridView1.Columns[x].HeaderCell.Style.BackColor = cd.Color;
        }

        private void шрифтСтолбцаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            fd.ShowDialog();
            int x = dataGridView1.CurrentCellAddress.X;
            dataGridView1.Columns[x].DefaultCellStyle.Font = fd.Font;
        }
    }
}
