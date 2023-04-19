using BusyIndicator;

using CobraCarSolution.TreeElements.VAG;

using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
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
            MenuItem root = new MenuItem() { Title = "Menu" };
            MenuItem childItem1 = new MenuItem() { Title = "Child item #1" };
            childItem1.Items.Add(new MenuItem() { Title = "Child item #1.1" });
            childItem1.Items.Add(new MenuItem() { Title = "Child item #1.2" });
            root.Items.Add(childItem1);
            root.Items.Add(new MenuItem() { Title = "Child item #2" });
            MenuItem root2 = new MenuItem() { Title = "VAG" };
            root2.Items.Add(new VAG_EDC17CP14());
            root2.Items.Add(new VAG_EDC16CP45());
            root2.Items.Add(new VAG_EDC17CP44());
            root2.Items.Add(new VAG_EDC16U1());
            root2.Items.Add(new VAG_EDC17C46());



            MenuItem renault = new MenuItem() { Title = "Renault" };
            MenuItem renault_clio = new MenuItem() { Title = "ClioSpezialSolution" };
            renault_clio.Items.Add(new VAG_EDC16CP45());
            renault.Items.Add(new VAG_EDC17CP14());
            renault.Items.Add(new VAG_EDC16CP45());
            renault.Items.Add(renault_clio);

            trvMenu.Items.Add(root);
            trvMenu.Items.Add(root2);
            trvMenu.Items.Add(renault);
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
                        if (selcted.hasDtcSolution)
                        {
                            ToolBox.AddLineToConsoleBox($"Module has dtc off solution...");
                            dtcList.IsEnabled = true;
                        }


                        /*
                        using (SaveFileDialog saveFileDialog1 = new SaveFileDialog())
                        {
                            saveFileDialog1.FileName = filename;
                            if (DialogResult.OK != saveFileDialog1.ShowDialog())
                                return;
                            File.WriteAllBytes(array);
                        }*/
                        ToolBox.AddLineToConsoleBox($"End loaded module...");
                         await OpenFileDialog();
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

        public async Task OpenFileDialog()
        {
            BusyIndicator.IsBusy = true;
            // Start task on a background thread
           
            await Task.Run(() =>
            {
                Application.Current.Dispatcher.Invoke(() =>
                {
                    MenuItem selcted = (MenuItem)trvMenu.SelectedItem;
                    if (selcted != null && selcted.hasDpfSolution)
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

                });

            });
           

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

        private void dtcList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

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
            ToolBox.AddLineToConsoleBox("Base method called");
        }
        public string Title { get; set; }
        public string Image { get; set; }
        public bool IsSolutionItem { get; set; }
        public bool hasEgrSolution { get; set; }
        public bool hasDpfSolution { get; set; }
        public bool hasDtcSolution { get; set; }
        public string desciption { get; set; }

        public virtual void checkFileForEgr()
        {

        }

        public virtual void egrOffSolution()
        {


        }

        public virtual void dpfOffSolution()
        {


        }
        public virtual void checkFileForDPF()
        {

        }

        public virtual void RemoveDtcFromFile(string dtcCode)
        {
            ToolBox.AddLineToConsoleBox(dtcCode + " error code removed from file...");
        }

        public ObservableCollection<MenuItem> Items { get; set; }
    }
}
