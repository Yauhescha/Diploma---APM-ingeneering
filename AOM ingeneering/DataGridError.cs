using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AOM_ingeneering
{
    static class DataGridError
    {
        private static DialogResult DialogResult;

        public static void Msg()
        {
            MessageBox.Show("Убедитесь, что формат данных совпадает с тем, что вводите");
        }
        public static bool isRemove()
        {
            return (DialogResult = MessageBox.Show("Удалить выбранное?", "Удаление", MessageBoxButtons.YesNo)) == DialogResult.Yes;
        }

    }
}
