using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EpuletNyilvantarto
{
    static class Program
    {
        public static Form1 form1 = null;
        public static Form_Csaladihaz form_Csaladihaz = null;
        public static Form_Tombhaz form_Tombhaz = null;
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            form1 = new Form1();
            form_Csaladihaz = new Form_Csaladihaz();
            form_Tombhaz = new Form_Tombhaz();

            Application.Run(form1);
        }
    }
}
