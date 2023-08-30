using System;
using System.Windows.Forms;

namespace TagReader
{
    static class Program
    {
        /// <summary>
        /// 어플 메인포털입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormTagReader());
        }
    }
}
