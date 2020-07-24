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
    public partial class _2NormDocReport : Form
    {
        public _2NormDocReport()
        {
            InitializeComponent();
        }

        private void _2NormDocReport_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "movedbDataSet.документ". При необходимости она может быть перемещена или удалена.
            this.документTableAdapter.Fill(this.movedbDataSet.документ);

            this.reportViewer1.RefreshReport();
        }
    }
}
