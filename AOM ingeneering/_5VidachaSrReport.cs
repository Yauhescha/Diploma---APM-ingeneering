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
    public partial class _5VidachaSrReport : Form
    {
        public _5VidachaSrReport()
        {
            InitializeComponent();
        }

        private void _5VidachaSrReport_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "movedbDataSet.выдачасиз". При необходимости она может быть перемещена или удалена.
            this.выдачасизTableAdapter.Fill(this.movedbDataSet.выдачасиз);
            

            this.reportViewer1.RefreshReport();
        }
    }
}
