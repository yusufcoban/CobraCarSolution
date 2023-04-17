using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using ToggleSwitch;

namespace CobraCarSolution.Toolbox
{
    static class ToolBox
    {
        public static byte[] array = new byte[0];
        public static string filename = "";
        public static string filepath = "";
        public static void AddLineToConsoleBox(string newLine)
        {
            Window mainWindow = Application.Current.MainWindow;
            TextBox consoleCurrent = mainWindow.FindName("consoleBox") as TextBox;
            consoleCurrent.Text += "\r\n" + newLine;
            consoleCurrent.ScrollToEnd();
        }

        public static void setEgrButtonState(int state)
        {
            Window mainWindow = Application.Current.MainWindow;
            HorizontalToggleSwitch egrSwitch = mainWindow.FindName("toggleSwitch1") as HorizontalToggleSwitch;
            if (state == 0)
            {
                egrSwitch.IsEnabled = false;
            }
            else if (state == 1)
            {
                egrSwitch.IsEnabled = true;
                egrSwitch.IsChecked = false;
            }
            else if (state == 2)
            {
                egrSwitch.IsEnabled = true;
                egrSwitch.IsChecked = true;
            }
        }

        public static bool ExistsInFile(byte[] findBytes)
        {
            if (FindStartAdressesInFile(findBytes).Any())
            {
                return true;
            }
            return false;
        }

        public static IEnumerable<int> FindStartAdressesInFile(byte[] pattern)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array.Skip(i).Take(pattern.Length).SequenceEqual(pattern))
                {
                    yield return i;
                }
            }
        }

        public static void ReplaceBytes(byte[] search, byte[] repl)
        {
            //if (repl == null) return array;
            int index = FindBytes(search);
            //if (index < 0) return array;
            byte[] dst = new byte[array.Length];
            Buffer.BlockCopy(array, 0, dst, 0, index);
            Buffer.BlockCopy(repl, 0, dst, index, repl.Length);
            Buffer.BlockCopy(array, index + search.Length, dst, index + repl.Length, array.Length - (index + search.Length));
            array = dst;
        }

        public static int FindBytes(byte[] find)
        {
            if (array == null || find == null || array.Length == 0 || find.Length == 0 || find.Length > array.Length) return -1;
            for (int i = 0; i < array.Length - find.Length + 1; i++)
            {
                if (array[i] == find[0])
                {
                    for (int m = 1; m < find.Length; m++)
                    {
                        if (array[i + m] != find[m]) break;
                        if (m == find.Length - 1) return i;
                    }
                }
            }
            return -1;
        }

        public static bool ReplaceInFile(byte[] findBytes, byte[] replaceBytes, string successMessage = "")
        {
            ReplaceBytes(findBytes, replaceBytes);
            if (!string.IsNullOrEmpty(successMessage))
            {
                AddLineToConsoleBox(successMessage);
            }
            return true;

        }


    }
}
