using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermUIProject
{
    internal class ShareData
    {
        public static string name_show = "";

        public static void showWarnigMSG(string msg)
        {
            MessageBox.Show(
                msg,
                "คำเดือน",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning

                );
        }
    }
}
