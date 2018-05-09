using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CodeCreateWPFApp
{
    class program :Application
    {
        [STAThread()] // 单线程
        static void Main()
        {
            program app = new program();
            app.MainWindow = new Window1();
            app.MainWindow.ShowDialog();
        }
    }
}
