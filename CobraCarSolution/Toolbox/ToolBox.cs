using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace CobraCarSolution.Toolbox
{
    static class ToolBox
    {
        public static void AddLineToConsoleBox(string newLine)
        {
            Window mainWindow = Application.Current.MainWindow;
            TextBox consoleCurrent = mainWindow.FindName("consoleBox") as TextBox;
            consoleCurrent.Text += "\r\n" + newLine;
            consoleCurrent.ScrollToEnd();
        }
    }
}
