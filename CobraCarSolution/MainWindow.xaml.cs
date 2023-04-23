using CobraCarSolution.TreeElements.VAG;

using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using ToggleSwitch;

using ToolBoxNameSpace;

namespace CobraCarSolution
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public bool egrOffEffected = false;
        public bool dpfOffEffected = false;
        public bool dtcOffEffected = false;

        public MainWindow()
        {
            InitializeComponent();
            MenuItem hondaEntry = new MenuItem() { Title = "Honda" };
            // MenuItem childItem1 = new MenuItem() { Title = "Child item #1" };
            hondaEntry.Items.Add(new HONDA_EDC17CP16());

            MenuItem ivecoEntry = new MenuItem() { Title = "Iveco" };
            // MenuItem childItem1 = new MenuItem() { Title = "Child item #1" };
            ivecoEntry.Items.Add(new IVECO_EDC17C1());
            ivecoEntry.Items.Add(new IVECO_EDC17C49());
            ivecoEntry.Items.Add(new IVECO_EDC17C52());
            ivecoEntry.Items.Add(new IVECO_EDC17C54());
            ivecoEntry.Items.Add(new Iveco_edc17U31());
            ivecoEntry.Items.Add(new IVECO_EDC39());
            ivecoEntry.Items.Add(new Iveco_EDC7C1());
            ivecoEntry.Items.Add(new Iveco_EDC7C1());


            MenuItem jeepEntry = new MenuItem() { Title = "Jeep" };
            // MenuItem childItem1 = new MenuItem() { Title = "Child item #1" };
            jeepEntry.Items.Add(new jeep_edc16C31());
            jeepEntry.Items.Add(new JEEP_edc16CP31());
            jeepEntry.Items.Add(new JEEP_edc16U31());

            MenuItem landRoverEntry = new MenuItem() { Title = "LandRover" };
            // MenuItem childItem1 = new MenuItem() { Title = "Child item #1" };
            landRoverEntry.Items.Add(new LANDROVER_edc16cp39());


            MenuItem mercedesEntry = new MenuItem() { Title = "Mercedes" };
            // MenuItem childItem1 = new MenuItem() { Title = "Child item #1" };
            mercedesEntry.Items.Add(new Mercedes_ME2_7());
            mercedesEntry.Items.Add(new Mercedes_ME2_7_2());
            mercedesEntry.Items.Add(new Mercedes_ME2_8());
            mercedesEntry.Items.Add(new Mercedes_ME2_8_1());
            mercedesEntry.Items.Add(new Mercedes_Benz_EDC16C2());
            mercedesEntry.Items.Add(new Mercedes_Benz_EDC16C31());

            MenuItem mitsubushiEntry = new MenuItem() { Title = "Mitsubushi" };
            // MenuItem childItem1 = new MenuItem() { Title = "Child item #1" };
            mitsubushiEntry.Items.Add(new MITSUBISHI_EDC16C31());
            mitsubushiEntry.Items.Add(new MITSUBISHI_EDC16C39());
            mitsubushiEntry.Items.Add(new MITSUBISHI_EDC16U31());
            mitsubushiEntry.Items.Add(new MITSUBISHI_EDC16U34());

            MenuItem SuzukiEntry = new MenuItem() { Title = "Suzuki" };
            // MenuItem childItem1 = new MenuItem() { Title = "Child item #1" };
            SuzukiEntry.Items.Add(new Suzuki_MagnetiMarelli_MJD6J());

            MenuItem toyotaEntry = new MenuItem() { Title = "Toyota" };
            // MenuItem childItem1 = new MenuItem() { Title = "Child item #1" };
            toyotaEntry.Items.Add(new Toyota_edc16c10());
            toyotaEntry.Items.Add(new Toyota_edc16c31());
            toyotaEntry.Items.Add(new Toyota_edc17cp07());




            MenuItem root2 = new MenuItem() { Title = "VAG" };
            root2.Items.Add(new VAG_EDC15());
            root2.Items.Add(new VAG_EDC17CP14());
            root2.Items.Add(new VAG_EDC17U01());
            root2.Items.Add(new VAG_EDC17U04());
            root2.Items.Add(new VAG_EDC16CP34());
            root2.Items.Add(new VAG_EDC16U31());
            root2.Items.Add(new VAG_EDC16U34());

            MenuItem volvoEntry = new MenuItem() { Title = "Volvo" };
           volvoEntry.Items.Add(new Volvo_XC90_ME7_0());
           volvoEntry.Items.Add(new Volvo_EDC16C31());
           volvoEntry.Items.Add(new Volvo_EDC16C34());








            trvMenu.Items.Add(hondaEntry);
            trvMenu.Items.Add(ivecoEntry);
            trvMenu.Items.Add(jeepEntry);
            trvMenu.Items.Add(landRoverEntry);
            trvMenu.Items.Add(mercedesEntry);
            trvMenu.Items.Add(mitsubushiEntry);
            trvMenu.Items.Add(SuzukiEntry);
            trvMenu.Items.Add(toyotaEntry);
            trvMenu.Items.Add(volvoEntry);












            trvMenu.Items.Add(root2);
        }

        private async void trvMenu_Click(object sender, EventArgs e)
        {
            await Task.Run(() =>
            {
                Application.Current.Dispatcher.Invoke(async () =>
               {
                   ToolBox.ResetStateAndFile();
                   MenuItem selcted = (MenuItem)trvMenu.SelectedItem;

                   if (selcted != null && selcted.IsSolutionItem)
                   {
                       if (!String.IsNullOrEmpty(selcted.desciption))
                       {
                           ToolBox.AddLineToConsoleBox($"Additional Infos: {selcted.desciption}. ");
                       }
                       if (selcted.hasEgrSolution)
                       {
                           ToolBox.AddLineToConsoleBox($"Module has egr off solution...");
                           ToolBox.setEgrButtonState(1, false);
                       }
                       if (selcted.hasDpfSolution)
                       {
                           ToolBox.AddLineToConsoleBox($"Module has dpf off solution...");
                           ToolBox.setDpfButtonState(1, false);
                       }
                       if (selcted.hasLamdaSolution)
                       {
                           ToolBox.AddLineToConsoleBox($"Module has lamda off solution...");
                           ToolBox.setLAMDAButtonState(1, false);
                       }
                       if (selcted.hasTVASolution)
                       {
                           ToolBox.AddLineToConsoleBox($"Module has tva off solution...");
                           ToolBox.setTVAButtonState(1, false);
                       }
                       if (selcted.hasStartStopSolution)
                       {
                           ToolBox.AddLineToConsoleBox($"Module has start stop solution...");
                           ToolBox.setSTARTSTOPButtonState(1, false);
                       }
                       if (selcted.hasFLAPSSolution)
                       {
                           ToolBox.AddLineToConsoleBox($"Module has flaps off solution...");
                           ToolBox.setFLAPSButtonState(1, false);
                       }
                       if (selcted.hasReadinessSolution)
                       {
                           ToolBox.AddLineToConsoleBox($"Module has readness solution...");
                           ToolBox.setREADINESSButtonState(1, false);
                       }
                       if (selcted.hasImmoSolution)
                       {
                           ToolBox.AddLineToConsoleBox($"Module has immo solution...");
                           ToolBox.setIMMOButtonState(1, false);
                       }
                       if (selcted.hasADBlueSolution)
                       {
                           ToolBox.AddLineToConsoleBox($"Module has adblue off solution...");
                           ToolBox.setADBLUEButtonState(1, false);
                       }
                       if (selcted.hasSpecialISolution)
                       {
                           ToolBox.AddLineToConsoleBox($"Module has specialI  solution...");
                           ToolBox.setSPECIALIButtonState(1, false);
                       }
                       if (selcted.hasSpecialIISolution)
                       {
                           ToolBox.AddLineToConsoleBox($"Module has specialII  solution...");
                           ToolBox.setSPECIALIIButtonState(1, false);
                       }
                       if (selcted.hasSpecialISolution)
                       {
                           ToolBox.AddLineToConsoleBox($"Module has specialIII  solution...");
                           ToolBox.setSPECIALIIIButtonState(1, false);
                       }











                       if (selcted.hasDtcSolution)
                       {
                           ToolBox.AddLineToConsoleBox($"Module has dtc off solution...");
                           //dtcList.IsEnabled = true;
                       }

                       ToolBox.AddLineToConsoleBox($"End loaded module...");
                       OpenFileDialog();
                       selcted.initFunction();
                   }

               });

            });

        }
        public void RemoveSwitchHandler(HorizontalToggleSwitch switchControl, string handlerName)
        {
            // Get a reference to the current MainWindow instance
            MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;

            // Get a reference to the event handler method using reflection
            MethodInfo methodInfo = mainWindow.GetType().GetMethod(handlerName);
            RoutedEventHandler handler = (RoutedEventHandler)Delegate.CreateDelegate(typeof(RoutedEventHandler), mainWindow, methodInfo);

            // Add the event handler back to the Checked event of the switch control in the current MainWindow
            switchControl.Unchecked -= handler;
        }
        public void AddSwitchHandler(HorizontalToggleSwitch switchControl, string handlerName)
        {
            // Get a reference to the current MainWindow instance
            MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;

            // Get a reference to the event handler method using reflection
            MethodInfo methodInfo = mainWindow.GetType().GetMethod(handlerName);
            RoutedEventHandler handler = (RoutedEventHandler)Delegate.CreateDelegate(typeof(RoutedEventHandler), mainWindow, methodInfo);

            // Remove the event handler from the Checked event of the switch control in the current MainWindow
            switchControl.Unchecked += handler;
        }
        public void OpenFileDialog()
        {
            BusyIndicator.IsBusy = true;
            // Start task on a background thread


            MenuItem selcted = (MenuItem)trvMenu.SelectedItem;
            if (selcted != null && selcted.IsSolutionItem)
            {
                ToolBox.setSaveButton(false);

                ToolBox.AddLineToConsoleBox($"Opening file...");
                Microsoft.Win32.OpenFileDialog openFileDialog = new Microsoft.Win32.OpenFileDialog();
                if (openFileDialog.ShowDialog() == true)
                {
                    ToolBox.AddLineToConsoleBox($"File selected...");
                    ToolBox.filename = openFileDialog.FileName;
                    ToolBox.filepath = openFileDialog.InitialDirectory;
                    ToolBox.array = File.ReadAllBytes(openFileDialog.FileName);

                }
                else
                {
                    ToolBox.filename = "";
                    ToolBox.array = new byte[0];
                    ToolBox.filepath = "";
                }
            }


            BusyIndicator.IsBusy = false;

        }
        public async void testCallEgr(object sender, EventArgs e)
        {
            BusyIndicator.IsBusy = true;

            await Task.Run(() =>
            {
                Application.Current.Dispatcher.Invoke(() =>
                {
                    MenuItem selcted = (MenuItem)trvMenu.SelectedItem;

                    if (selcted != null && selcted.hasEgrSolution)
                    {
                        selcted.egrOffSolution();
                        ToolBox.setEgrButtonState(0, true);
                        ToolBox.setSaveButton(true);
                    }// Do your work here
                });

            });
            BusyIndicator.IsBusy = false;


        }
        public async void callDpfFunction(object sender, EventArgs e)
        {
            BusyIndicator.IsBusy = true;
            await Task.Run(() =>
            {
                Application.Current.Dispatcher.Invoke(() =>
                {
                    MenuItem selcted = (MenuItem)trvMenu.SelectedItem;
                    if (selcted != null && selcted.hasDpfSolution)
                    {
                        selcted.dpfOffSolution();
                        ToolBox.setDpfButtonState(0, true);
                        ToolBox.setSaveButton(true);
                    }
                });


            });

            BusyIndicator.IsBusy = false;

        }
        public async void callTVAFunction(object sender, EventArgs e)
        {
            BusyIndicator.IsBusy = true;
            await Task.Run(() =>
            {
                Application.Current.Dispatcher.Invoke(() =>
                {
                    MenuItem selcted = (MenuItem)trvMenu.SelectedItem;
                    if (selcted != null && selcted.hasTVASolution)
                    {
                        selcted.tvaoffSolution();
                        ToolBox.setTVAButtonState(0, true);
                        ToolBox.setSaveButton(true);
                    }
                });


            });

            BusyIndicator.IsBusy = false;

        }
        public async void callLAMDAFunction(object sender, EventArgs e)
        {
            BusyIndicator.IsBusy = true;
            await Task.Run(() =>
            {
                Application.Current.Dispatcher.Invoke(() =>
                {
                    MenuItem selcted = (MenuItem)trvMenu.SelectedItem;
                    if (selcted != null && selcted.hasLamdaSolution)
                    {
                        selcted.lamdaOfffSolution();
                        ToolBox.setLAMDAButtonState(0, true);
                        ToolBox.setSaveButton(true);
                    }
                });


            });

            BusyIndicator.IsBusy = false;

        }
        public async void callFLAPSFunction(object sender, EventArgs e)
        {
            BusyIndicator.IsBusy = true;
            await Task.Run(() =>
            {
                Application.Current.Dispatcher.Invoke(() =>
                {
                    MenuItem selcted = (MenuItem)trvMenu.SelectedItem;
                    if (selcted != null && selcted.hasFLAPSSolution)
                    {
                        selcted.flapsOfffSolution();
                        ToolBox.setFLAPSButtonState(0, true);
                        ToolBox.setSaveButton(true);
                    }
                });


            });

            BusyIndicator.IsBusy = false;

        }
        public async void callSTARTSTOPFunction(object sender, EventArgs e)
        {
            BusyIndicator.IsBusy = true;
            await Task.Run(() =>
            {
                Application.Current.Dispatcher.Invoke(() =>
                {
                    MenuItem selcted = (MenuItem)trvMenu.SelectedItem;
                    if (selcted != null && selcted.hasStartStopSolution)
                    {
                        selcted.startStopSolution();
                        ToolBox.setSTARTSTOPButtonState(0, true);
                        ToolBox.setSaveButton(true);
                    }
                });


            });

            BusyIndicator.IsBusy = false;

        }
        public async void callADBLUEFunction(object sender, EventArgs e)
        {
            BusyIndicator.IsBusy = true;
            await Task.Run(() =>
            {
                Application.Current.Dispatcher.Invoke(() =>
                {
                    MenuItem selcted = (MenuItem)trvMenu.SelectedItem;
                    if (selcted != null && selcted.hasADBlueSolution)
                    {
                        selcted.adBlueSolution();
                        ToolBox.setADBLUEButtonState(0, true);
                        ToolBox.setSaveButton(true);
                    }
                });


            });

            BusyIndicator.IsBusy = false;

        }
        public async void callREADINESSFunction(object sender, EventArgs e)
        {
            BusyIndicator.IsBusy = true;
            await Task.Run(() =>
            {
                Application.Current.Dispatcher.Invoke(() =>
                {
                    MenuItem selcted = (MenuItem)trvMenu.SelectedItem;
                    if (selcted != null && selcted.hasReadinessSolution)
                    {
                        selcted.readnissSolution();
                        ToolBox.setREADINESSButtonState(0, true);
                        ToolBox.setSaveButton(true);
                    }
                });


            });

            BusyIndicator.IsBusy = false;

        }
        public async void callIMMOFunction(object sender, EventArgs e)
        {
            BusyIndicator.IsBusy = true;
            await Task.Run(() =>
            {
                Application.Current.Dispatcher.Invoke(() =>
                {
                    MenuItem selcted = (MenuItem)trvMenu.SelectedItem;
                    if (selcted != null && selcted.hasImmoSolution)
                    {
                        selcted.immoSolution();
                        ToolBox.setIMMOButtonState(0, true);
                        ToolBox.setSaveButton(true);
                    }
                });


            });

            BusyIndicator.IsBusy = false;

        }
        public async void callSPECIALIFunction(object sender, EventArgs e)
        {
            BusyIndicator.IsBusy = true;
            await Task.Run(() =>
            {
                Application.Current.Dispatcher.Invoke(() =>
                {
                    MenuItem selcted = (MenuItem)trvMenu.SelectedItem;
                    if (selcted != null && selcted.hasSpecialISolution)
                    {
                        selcted.specialISolution();
                        ToolBox.setSPECIALIButtonState(0, true);
                        ToolBox.setSaveButton(true);
                    }
                });


            });

            BusyIndicator.IsBusy = false;

        }
        public async void callSPECIALIIFunction(object sender, EventArgs e)
        {
            BusyIndicator.IsBusy = true;
            await Task.Run(() =>
            {
                Application.Current.Dispatcher.Invoke(() =>
                {
                    MenuItem selcted = (MenuItem)trvMenu.SelectedItem;
                    if (selcted != null && selcted.hasSpecialIISolution)
                    {
                        selcted.specialIISolution();
                        ToolBox.setSPECIALIIButtonState(0, true);
                        ToolBox.setSaveButton(true);
                    }
                });


            });

            BusyIndicator.IsBusy = false;

        }
        public async void callSPECIALIIIFunction(object sender, EventArgs e)
        {
            BusyIndicator.IsBusy = true;
            await Task.Run(() =>
            {
                Application.Current.Dispatcher.Invoke(() =>
                {
                    MenuItem selcted = (MenuItem)trvMenu.SelectedItem;
                    if (selcted != null && selcted.hasSpecialIIISolution)
                    {
                        selcted.specialIIISolution();
                        ToolBox.setSPECIALIIIButtonState(0, true);
                        ToolBox.setSaveButton(true);
                    }
                });


            });

            BusyIndicator.IsBusy = false;

        }
        private void dtcList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        private void OpenAdminArea(object sender, RoutedEventArgs e)
        {
            ExportSciptGenerator exportSciptGenerator = new ExportSciptGenerator();
            exportSciptGenerator.Show();
        }
        private void saveButton_Click(object sender, RoutedEventArgs e)
        {
            ToolBox.setSaveButton(false);

            ToolBox.AddLineToConsoleBox($"Export file...");
            Microsoft.Win32.SaveFileDialog saveDialog = new Microsoft.Win32.SaveFileDialog();
            string extension = System.IO.Path.GetExtension(ToolBox.filename);
            string result = ToolBox.filename.Substring(0, ToolBox.filename.Length - extension.Length);
            saveDialog.FileName = result + "_modded_NoChk";
            saveDialog.InitialDirectory = ToolBox.filepath; // set the default directory
            saveDialog.Filter = "Bin (*.bin)|*.bin";
            if (saveDialog.ShowDialog() == true)
            {
                File.WriteAllBytes(saveDialog.FileName, ToolBox.array); // Requires System.IO
                ToolBox.filename = "";
                ToolBox.array = new byte[0];
                ToolBox.filepath = "";
                ToolBox.setAllSwitchButtonState(0, true);
                ToolBox.AddLineToConsoleBox($"Exported with success...");
            }
            else
            {
                ToolBox.setSaveButton(true);

            }
        }
        private void consoleBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }

    public interface ITreeItem
    {
        void egrOffSolution();
        void dpfOffSolution();

    }

    public class MenuItem
    {
        public Window mainWindow = Application.Current.MainWindow;

        public MenuItem()
        {
            this.Items = new ObservableCollection<MenuItem>();
        }
        public virtual void initFunction()
        {
            bool prepare = true;

            ToolBox.AddLineToConsoleBox(Title);
            if (hasFileCheckSize)
            {
                prepare = checkFileForSize();
            }

            if (prepare)
            {
                if (hasEgrSolution)
                {
                    BaseCheckFileForEgr();
                }
                if (hasDpfSolution)
                {
                    BaseCheckFileForDPF();
                }
                if (hasTVASolution)
                {
                    BasecheckFileForTVA();
                }
                if (hasLamdaSolution)
                {
                    BasecheckFileForLamda();
                }
                if (hasFLAPSSolution)
                {
                    BasecheckFileForFlaps();
                }
                if (hasStartStopSolution)
                {
                    BasecheckFileForStartStop();
                }
                if (hasADBlueSolution)
                {
                    BasecheckFileForAdblue();
                }
                if (hasReadinessSolution)
                {
                    BasecheckFileForReadiness();
                }
                if (hasImmoSolution)
                {
                    BasecheckFileForImmo();
                }
                if (hasSpecialISolution)
                {
                    BasecheckFileForSpecialI();
                }
                if (hasSpecialIISolution)
                {
                    BasecheckFileForSpecialII();
                }
                if (hasSpecialIIISolution)
                {
                    BasecheckFileForSpecialIII();
                }
            }
            else
            {
                ToolBox.ResetStateAndFile();

            }
            ToolBox.AddLineToConsoleBox("Base method called");
        }
        public string Title { get; set; }
        public int[] FileSizeArray { get; set; }
        public string Image { get; set; }
        public bool IsSolutionItem { get; set; }
        public bool hasEgrSolution { get; set; }
        public bool hasTVASolution { get; set; }

        public bool hasFileCheckSize { get; set; }

        public bool hasDpfSolution { get; set; }
        public bool hasDtcSolution { get; set; }

        public bool hasLamdaSolution { get; set; }
        public bool hasFLAPSSolution { get; set; }

        public bool hasStartStopSolution { get; set; }
        public bool hasADBlueSolution { get; set; }

        public bool hasReadinessSolution { get; set; }
        public bool hasImmoSolution { get; set; }

        public bool hasSpecialISolution { get; set; }

        public bool hasSpecialIISolution { get; set; }
        public bool hasSpecialIIISolution { get; set; }

        public string specialISolutionDescription { get; set; }
        public string specialIISolutionDescription { get; set; }
        public string specialIIISolutionDescription { get; set; }


        public string desciption { get; set; }

        /**
         * 
         * Check
         * 
         * 
         */

        public virtual bool checkFileForSize()
        {
            if (FileSizeArray != null && FileSizeArray.Count() > 0 && FileSizeArray.Select(x => x > 0).Any())
            {
                if (FileSizeArray.Contains(ToolBox.array.Count()))
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            else
            {
                return true;
            }
        }

        public async void BaseCheckFileForEgr()
        {
            ToolBox.setEgrButtonState(0, true);
            bool fileHasEgrMaps = false;
            ToolBox.AddLineToConsoleBox("Searching egr maps...");
            await Task.Run(() =>
            {
                Application.Current.Dispatcher.Invoke(async () =>
                {
                    fileHasEgrMaps = await this.checkFileForEgr();

                });

            });
            if (fileHasEgrMaps)
            {
                ToolBox.AddLineToConsoleBox("Egr maps found...");
                ToolBox.setEgrButtonState(1, false);
            }
            else
            {
                ToolBox.AddLineToConsoleBox("Egr maps not found...");
                ToolBox.setEgrButtonState(1, true);
            }

        }
        public async void BaseCheckFileForDPF()
        {
            ToolBox.setDpfButtonState(0, true);
            bool fileHasEgrMaps = false;
            ToolBox.AddLineToConsoleBox("Searching dpf maps...");
            await Task.Run(() =>
            {
                Application.Current.Dispatcher.Invoke(async () =>
                {
                    fileHasEgrMaps = await this.checkFileForDpf();

                });

            });
            if (fileHasEgrMaps)
            {
                ToolBox.AddLineToConsoleBox("Dpf maps found...");
                ToolBox.setDpfButtonState(1, false);
            }
            else
            {
                ToolBox.AddLineToConsoleBox("Dpf maps not found...");
                ToolBox.setDpfButtonState(1, true);
            }
        }
        public async void BasecheckFileForTVA()
        {

        }
        public async void BasecheckFileForLamda()
        {

        }
        public async void BasecheckFileForFlaps()
        {

        }
        public async void BasecheckFileForStartStop()
        {

        }
        public async void BasecheckFileForAdblue()
        {

        }
        public async void BasecheckFileForReadiness()
        {

        }
        public async void BasecheckFileForImmo()
        {

        }
        public async void BasecheckFileForSpecialI()
        {

        }
        public async void BasecheckFileForSpecialII()
        {

        }
        public async void BasecheckFileForSpecialIII()
        {

        }
        public virtual async Task<bool> checkFileForEgr()
        {
            return false;
        }
        public virtual async Task<bool> checkFileForDpf()
        {
            return false;
        }
        public virtual async Task<bool> checkFileForTva()
        {
            return false;
        }

        public virtual async Task<bool> checkFileForLamda()
        {
            return false;
        }

        public virtual async Task<bool> checkFileForFlaps()
        {
            return false;
        }

        public virtual async Task<bool> checkFileForStartStop()
        {
            return false;
        }

        public virtual async Task<bool> checkFileForAdBlue()
        {
            return false;
        }

        public virtual async Task<bool> checkFileForReadiness()
        {
            return false;
        }

        public virtual async Task<bool> checkFileForImmo()
        {
            return false;
        }

        public virtual async Task<bool> checkFileForSpecialI()
        {
            return false;
        }

        public virtual async Task<bool> checkFileForSpecialII()
        {
            return false;
        }

        public virtual async Task<bool> checkFileForSpecialIII()
        {
            return false;
        }
        /**
         * 
         * 
         * SOLUTIONS
         * 
         * 
         */
        public virtual void egrOffSolution()
        {


        }

        public virtual void dpfOffSolution()
        {


        }


        public virtual void lamdaOfffSolution()
        {


        }

        public virtual void flapsOfffSolution()
        {


        }
        public virtual void startStopSolution()
        {


        }

        public virtual void adBlueSolution()
        {


        }

        public virtual void readnissSolution()
        {


        }
        public virtual void immoSolution()
        {


        }

        public virtual void tvaoffSolution()
        {


        }

        public virtual void specialISolution()
        {


        }
        public virtual void specialIISolution()
        {


        }

        public virtual void specialIIISolution()
        {


        }

        /**
         * 
         * 
         * DTCs
         * 
         * 
         */

        public virtual void RemoveDtcFromFile(string dtcCode)
        {
            ToolBox.AddLineToConsoleBox(dtcCode + " error code removed from file...");
        }


        public ObservableCollection<MenuItem> Items { get; set; }
    }
}
