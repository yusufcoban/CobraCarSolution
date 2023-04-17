using CobraCarSolution.Toolbox;
using CobraCarSolution.TreeElements.VAG;
using Microsoft.Win32;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using ToggleSwitch;

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
            root2.Items.Add(new VAG_EDC16U1());

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

        private void ResetChangesAndModule()
        {
            ToolBox.AddLineToConsoleBox($"Back to Start... ");
            // Disable the toggle button
            toggleSwitch1.IsEnabled = false;
            toggleSwitch1.IsChecked = false;
            toggleSwitch2.IsEnabled = false;
            toggleSwitch2.IsChecked = false;

            dtcList.IsEnabled = false;
            egrOffEffected = false;
            dpfOffEffected = false;
            dtcOffEffected = false;
        }
        private void trvMenu_Click(object sender, EventArgs e)
        {
            ResetChangesAndModule();
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
                    toggleSwitch1.IsEnabled = true;
                    toggleSwitch1.IsChecked = true;
                }
                if (selcted.hasDpfSolution)
                {
                    ToolBox.AddLineToConsoleBox($"Module has dpf off solution...");
                    toggleSwitch2.IsEnabled = true;
                    toggleSwitch2.IsChecked = true;
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
                OpenFileDialog();
                selcted.initFunction();
            }
        }

        public void OpenFileDialog()
        {
            ToolBox.AddLineToConsoleBox($"Opening file...");
            OpenFileDialog openFileDialog = new OpenFileDialog();
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

        public void testCallEgr(object sender, EventArgs e)
        {
            MenuItem selcted = (MenuItem)trvMenu.SelectedItem;
            if (selcted != null && selcted.hasEgrSolution && selcted.checkFileForEgr())
            {
                selcted.egrOffSolution();
            }
        }

        public void callDpfFunction(object sender, EventArgs e)
        {
            MenuItem selcted = (MenuItem)trvMenu.SelectedItem;
            selcted.initFunction();
        }

        private void dtcList_SelectionChanged(object sender, SelectionChangedEventArgs e)
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
            ToolBox.AddLineToConsoleBox("Base method called");
        }
        public string Title { get; set; }
        public string Image { get; set; }
        public bool IsSolutionItem { get; set; }
        public bool hasEgrSolution { get; set; }
        public bool hasDpfSolution { get; set; }
        public bool hasDtcSolution { get; set; }
        public string desciption { get; set; }

        public virtual bool checkFileForEgr()
        {
            return false;
        }

        public virtual void egrOffSolution()
        {

        }
        public virtual bool checkFileForDPF()
        {
            return false;
        }

        public virtual void RemoveDtcFromFile(string dtcCode)
        {
            ToolBox.AddLineToConsoleBox(dtcCode + " error code removed from file...");
        }

        public ObservableCollection<MenuItem> Items { get; set; }
    }
}
