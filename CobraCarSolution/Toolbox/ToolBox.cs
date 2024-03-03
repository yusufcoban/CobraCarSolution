using BusyIndicator;

using CobraCarSolution;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Sockets;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

using ToggleSwitch;

namespace ToolBoxNameSpace
{
    public static class ToolBox
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

        public static async void setAllSwitchButtonState(int state, bool locked = false)
        {
            await Task.Run(() =>
            {
                Application.Current.Dispatcher.Invoke(() =>
                {
                    setEgrButtonState(state, locked);
                    setDpfButtonState(state, locked);
                    setNoxButtonState(state, locked);
                    setImmoButtonState(state, locked);
                    setADBLUEButtonState(state, locked);
                    setSPECIALIButtonState(state, locked);
                    setSPECIALIIButtonState(state, locked);
                    setSPECIALIIIButtonState(state, locked);
                    setFLAPSButtonState(state, locked);
                    setTVAButtonState(state, locked);
                    setREADINESSButtonState(state, locked);
                    setSTARTSTOPButtonState(state, locked);
                    setLAMDAButtonState(state, locked);
                });

            });

        }

        public static void ResetStateAndFile()
        {
            //AddLineToConsoleBox("Resetting everything...");
            MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;
            TextBlock textSpecial = mainWindow.FindName("textSPECIALI") as TextBlock;
            textSpecial.Text = "Special1:";
            textSpecial = mainWindow.FindName("textSPECIALII") as TextBlock;
            textSpecial.Text = "Special2:";
            textSpecial = mainWindow.FindName("textSPECIALIII") as TextBlock;
            textSpecial.Text = "Special3:";

            ToolBox.filename = "";
            ToolBox.array = new byte[0];
            ToolBox.filepath = "";
            setAllSwitchButtonState(0, true);
            setSaveButton(false);
        }

        public static void setEgrButtonState(int state, bool locked = false)
        {
            MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;
            CheckBox egrSwitch = mainWindow.FindName("toggleSwitch1") as CheckBox;

            mainWindow.RemoveSwitchHandler(egrSwitch, "testCallEgr");

            if (state == 0)
            {
                egrSwitch.IsChecked = false;
            }
            else if (state == 1)
            {
                egrSwitch.IsChecked = true;
            }

            if (locked)
            {
                egrSwitch.IsEnabled = false;
            }
            else
            {
                egrSwitch.IsEnabled = true;
            }

            mainWindow.AddSwitchHandler(egrSwitch, "testCallEgr");

        }

        public static void setDpfButtonState(int state, bool locked = false)
        {
            MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;
            HorizontalToggleSwitch egrSwitch = mainWindow.FindName("toggleSwitch2") as HorizontalToggleSwitch;
            mainWindow.RemoveSwitchHandler(egrSwitch, "callDpfFunction");
            if (state == 0)
            {
                egrSwitch.IsChecked = false;
            }
            else if (state == 1)
            {
                egrSwitch.IsChecked = true;
            }

            if (locked)
            {
                egrSwitch.IsEnabled = false;
            }
            else
            {
                egrSwitch.IsEnabled = true;
            }
            mainWindow.AddSwitchHandler(egrSwitch, "callDpfFunction");
        }

        public static void setNoxButtonState(int state, bool locked = false)
        {
            Window mainWindow = Application.Current.MainWindow;
            HorizontalToggleSwitch egrSwitch = mainWindow.FindName("toggleSwitchLAMDA") as HorizontalToggleSwitch;

            if (state == 0)
            {
                egrSwitch.IsChecked = false;
            }
            else if (state == 1)
            {
                egrSwitch.IsEnabled = true;
            }

            if (locked)
            {
                egrSwitch.IsEnabled = false;
            }
            else
            {
                egrSwitch.IsEnabled = true;
            }
        }


        public static void setImmoButtonState(int state, bool locked = false)
        {
            Window mainWindow = Application.Current.MainWindow;
            HorizontalToggleSwitch egrSwitch = mainWindow.FindName("toggleSwitchIMMO") as HorizontalToggleSwitch;

            if (state == 0)
            {
                egrSwitch.IsChecked = false;
            }
            else if (state == 1)
            {
                egrSwitch.IsEnabled = true;
            }

            if (locked)
            {
                egrSwitch.IsEnabled = false;
            }
            else
            {
                egrSwitch.IsEnabled = true;
            }
        }

        public static void setSaveButton(bool state)
        {
            Window mainWindow = Application.Current.MainWindow;
            Button saveButton = mainWindow.FindName("saveButton") as Button;

            saveButton.IsEnabled = state;
        }

        public static bool ExistsInFile(byte[] findBytes)
        {
            if (CheckInFile(findBytes))
            {
                return true;
            }
            return false;
        }

        public static bool ExistsInFileMultiple(byte[] findBytes, int startAdress, int endAdress = 0)
        {
            if (endAdress == 0)
            {
                endAdress = startAdress + (findBytes.Count() - 1);
            }
            if (endAdress > array.Count())
            {
                ToolBox.AddLineToConsoleBox("Filesize not correct!");
                ToolBox.ResetStateAndFile();
                return false;
            }
            return CheckInFileWithStartStopAdress(findBytes, startAdress, endAdress);
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

        public static bool CheckInFile(byte[] pattern)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array.Skip(i).Take(pattern.Length).SequenceEqual(pattern))
                {
                    return true;
                }
            }
            return false;
        }

        public static bool CheckInFileWithStartStopAdress(byte[] pattern, int startAdress, int endAdress)
        {
            if (startAdress < 0)
            {
                startAdress = 0;
            }

            if (endAdress > (array.Count() - 1))
            {
                endAdress = array.Count() - 1;
            }

            byte[] cutted = new List<byte>(array).GetRange(startAdress, (endAdress - startAdress) + 1).ToArray();
            for (int i = 0; i < endAdress - startAdress + 1; i++)
            {
                if (cutted.Skip(i).Take(pattern.Length).SequenceEqual(pattern))
                {
                    return true;
                }
            }
            return false;
        }

        public static void ReplaceBytes(byte[] search, byte[] repl, int? minAdress = null, int? maxadress = null)
        {
            //if (repl == null) return array;
            int index = FindBytesMinStart(search, minAdress);
            if (index > -1)
            {
                if (validateReplace(index, minAdress, maxadress))
                {
                    //if (index < 0) return array;
                    byte[] dst = new byte[array.Length];
                    Buffer.BlockCopy(array, 0, dst, 0, index);
                    Buffer.BlockCopy(repl, 0, dst, index, repl.Length);
                    Buffer.BlockCopy(array, index + search.Length, dst, index + repl.Length, array.Length - (index + search.Length));
                    array = dst;
                }
            }
        }

        public static void CopyArrayByteToFile(byte[] input, int startAdressInt)
        {
            Buffer.BlockCopy(input, 0, array, startAdressInt, input.Count());
        }

        public static void FillBytesToFile(byte input, int startAdressInt, int counter)
        {
            for (int i = 0; i < counter; i++)
            {
                Buffer.BlockCopy(new byte[1] { input }, 0, array, startAdressInt + i, 1);
            }
        }

        public static void FillBytesFromToOneByte(byte input, int startAdressInt, int endAdress)
        {
            int counter = endAdress - startAdressInt;
            for (int i = 0; i < counter; i++)
            {
                Buffer.BlockCopy(new byte[1] { input }, 0, array, startAdressInt + i, 1);
            }
        }

        private static bool validateReplace(int index, int? minAdress, int? maxadress)
        {
            bool valid = false;
            if (minAdress != null && maxadress == null && index >= minAdress)
            {
                valid = true;
            }
            if (maxadress != null && minAdress == null && index <= maxadress)
            {
                valid = true;
            }
            if (minAdress != null && maxadress != null && index >= minAdress && index <= maxadress)
            {
                valid = true;
            }
            if (minAdress == null && maxadress == null)
            {
                valid = true;
            }
            return valid;
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

        public static int FindBytesMinStart(byte[] find, int? min)
        {
            if (min == null)
            {
                return FindBytes(find);
            }
            if (array == null || find == null || array.Length == 0 || find.Length == 0 || find.Length > array.Length) return -1;
            for (int i = min.Value; i < array.Length - find.Length + 1; i++)
            {
                if (array[i] == find[0])
                {
                    for (int m = 0; m < find.Length; m++)
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

        public static bool ReplaceInFileWithStartStop(byte[] findBytes, byte[] replaceBytes, int startAdress, int endAdress, string successMessage = "", int buffer = 0)
        {
            if (startAdress - buffer < 0)
            {
                startAdress = 0;
            }
            else
            {
                startAdress = startAdress - buffer;
            }
            if (endAdress + buffer > array.Count())
            {
                endAdress = array.Count();
            }
            else
            {
                endAdress = endAdress + buffer;
            }
            if(endAdress> array.Count())
            {
                ToolBox.AddLineToConsoleBox("Filesize not correct!");
                ToolBox.ResetStateAndFile();
                return false;
            }
            ReplaceBytes(findBytes, replaceBytes, startAdress, endAdress);
            if (!string.IsNullOrEmpty(successMessage))
            {
                AddLineToConsoleBox(successMessage);
            }
            return true;

        }

        internal static void setTVAButtonState(int state, bool locked)
        {
            MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;
            HorizontalToggleSwitch egrSwitch = mainWindow.FindName("toggleSwitchTVA") as HorizontalToggleSwitch;

            mainWindow.RemoveSwitchHandler(egrSwitch, "callTVAFunction"); if (state == 0)
            {
                egrSwitch.IsChecked = false;
            }
            else if (state == 1)
            {
                egrSwitch.IsChecked = true;
            }

            if (locked)
            {
                egrSwitch.IsEnabled = false;
            }
            else
            {
                egrSwitch.IsEnabled = true;
            }

            mainWindow.AddSwitchHandler(egrSwitch, "callTVAFunction");
        }

        internal static void setLAMDAButtonState(int state, bool locked)
        {
            MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;
            HorizontalToggleSwitch egrSwitch = mainWindow.FindName("toggleSwitchLAMDA") as HorizontalToggleSwitch;

            mainWindow.RemoveSwitchHandler(egrSwitch, "callLAMDAFunction"); if (state == 0)
            {
                egrSwitch.IsChecked = false;
            }
            else if (state == 1)
            {
                egrSwitch.IsChecked = true;
            }

            if (locked)
            {
                egrSwitch.IsEnabled = false;
            }
            else
            {
                egrSwitch.IsEnabled = true;
            }

            mainWindow.AddSwitchHandler(egrSwitch, "callLAMDAFunction");
        }

        internal static void setFLAPSButtonState(int state, bool locked)
        {
            MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;
            HorizontalToggleSwitch egrSwitch = mainWindow.FindName("toggleSwitchFLAPS") as HorizontalToggleSwitch;

            mainWindow.RemoveSwitchHandler(egrSwitch, "callFLAPSFunction"); if (state == 0)
            {
                egrSwitch.IsChecked = false;
            }
            else if (state == 1)
            {
                egrSwitch.IsChecked = true;
            }

            if (locked)
            {
                egrSwitch.IsEnabled = false;
            }
            else
            {
                egrSwitch.IsEnabled = true;
            }

            mainWindow.AddSwitchHandler(egrSwitch, "callFLAPSFunction");
        }

        internal static void setSTARTSTOPButtonState(int state, bool locked)
        {
            MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;
            HorizontalToggleSwitch egrSwitch = mainWindow.FindName("toggleSwitchSTARTSTOP") as HorizontalToggleSwitch;

            mainWindow.RemoveSwitchHandler(egrSwitch, "callSTARTSTOPFunction"); if (state == 0)
            {
                egrSwitch.IsChecked = false;
            }
            else if (state == 1)
            {
                egrSwitch.IsChecked = true;
            }

            if (locked)
            {
                egrSwitch.IsEnabled = false;
            }
            else
            {
                egrSwitch.IsEnabled = true;
            }

            mainWindow.AddSwitchHandler(egrSwitch, "callSTARTSTOPFunction");
        }

        internal static void setADBLUEButtonState(int state, bool locked)
        {
            MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;
            HorizontalToggleSwitch egrSwitch = mainWindow.FindName("toggleSwitchADBLUE") as HorizontalToggleSwitch;

            mainWindow.RemoveSwitchHandler(egrSwitch, "callADBLUEFunction"); if (state == 0)
            {
                egrSwitch.IsChecked = false;
            }
            else if (state == 1)
            {
                egrSwitch.IsChecked = true;
            }

            if (locked)
            {
                egrSwitch.IsEnabled = false;
            }
            else
            {
                egrSwitch.IsEnabled = true;
            }

            mainWindow.AddSwitchHandler(egrSwitch, "callADBLUEFunction");
        }

        internal static void setREADINESSButtonState(int state, bool locked)
        {
            MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;
            HorizontalToggleSwitch egrSwitch = mainWindow.FindName("toggleSwitchREADINESS") as HorizontalToggleSwitch;

            mainWindow.RemoveSwitchHandler(egrSwitch, "callREADINESSFunction"); if (state == 0)
            {
                egrSwitch.IsChecked = false;
            }
            else if (state == 1)
            {
                egrSwitch.IsChecked = true;
            }

            if (locked)
            {
                egrSwitch.IsEnabled = false;
            }
            else
            {
                egrSwitch.IsEnabled = true;
            }

            mainWindow.AddSwitchHandler(egrSwitch, "callREADINESSFunction");
        }

        internal static void setIMMOButtonState(int state, bool locked)
        {
            MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;
            HorizontalToggleSwitch egrSwitch = mainWindow.FindName("toggleSwitchIMMO") as HorizontalToggleSwitch;

            mainWindow.RemoveSwitchHandler(egrSwitch, "callIMMOFunction"); if (state == 0)
            {
                egrSwitch.IsChecked = false;
            }
            else if (state == 1)
            {
                egrSwitch.IsChecked = true;
            }

            if (locked)
            {
                egrSwitch.IsEnabled = false;
            }
            else
            {
                egrSwitch.IsEnabled = true;
            }

            mainWindow.AddSwitchHandler(egrSwitch, "callIMMOFunction");
        }

        internal static void setSPECIALIButtonState(int state, bool locked)
        {
            MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;
            HorizontalToggleSwitch egrSwitch = mainWindow.FindName("toggleSwitchSPECIALI") as HorizontalToggleSwitch;

            mainWindow.RemoveSwitchHandler(egrSwitch, "callSPECIALIFunction"); if (state == 0)
            {
                egrSwitch.IsChecked = false;
            }
            else if (state == 1)
            {
                egrSwitch.IsChecked = true;
            }

            if (locked)
            {
                egrSwitch.IsEnabled = false;
            }
            else
            {
                egrSwitch.IsEnabled = true;
            }

            mainWindow.AddSwitchHandler(egrSwitch, "callSPECIALIFunction");
        }

        internal static void setSPECIALIIButtonState(int state, bool locked)
        {
            MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;
            HorizontalToggleSwitch egrSwitch = mainWindow.FindName("toggleSwitchSPECIALII") as HorizontalToggleSwitch;

            mainWindow.RemoveSwitchHandler(egrSwitch, "callSPECIALIIFunction"); if (state == 0)
            {
                egrSwitch.IsChecked = false;
            }
            else if (state == 1)
            {
                egrSwitch.IsChecked = true;
            }

            if (locked)
            {
                egrSwitch.IsEnabled = false;
            }
            else
            {
                egrSwitch.IsEnabled = true;
            }

            mainWindow.AddSwitchHandler(egrSwitch, "callSPECIALIIFunction");
        }

        internal static void setSPECIALIIIButtonState(int state, bool locked)
        {
            MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;
            HorizontalToggleSwitch egrSwitch = mainWindow.FindName("toggleSwitchSPECIALIII") as HorizontalToggleSwitch;

            mainWindow.RemoveSwitchHandler(egrSwitch, "callSPECIALIIIFunction"); if (state == 0)
            {
                egrSwitch.IsChecked = false;
            }
            else if (state == 1)
            {
                egrSwitch.IsChecked = true;
            }

            if (locked)
            {
                egrSwitch.IsEnabled = false;
            }
            else
            {
                egrSwitch.IsEnabled = true;
            }

            mainWindow.AddSwitchHandler(egrSwitch, "callSPECIALIIIFunction");
        }
    }

    public class MultipleCheckBytesInFile
    {
        public byte[] bytesToCheck = new byte[0];
        public int startAdress;
        public int endAdress;
    }
}
