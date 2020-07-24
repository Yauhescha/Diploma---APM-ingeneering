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
    public partial class _9GrafikMeroprReport : Form
    {
        public _9GrafikMeroprReport()
        {
            InitializeComponent();
        }

        private void _9GrafikMeroprCRUD_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "movedbDataSet.график". При необходимости она может быть перемещена или удалена.
            this.графикTableAdapter.Fill(this.movedbDataSet.график);

            this.reportViewer1.RefreshReport();
        }
    }
}
