using CobraCarSolution.Toolbox;
using CobraCarSolution.TreeElements.VAG;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
                selcted.initFunction();
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
                ToolBox.AddLineToConsoleBox($"End loaded module...");
            }
        }

        public void testCallEgr(object sender, EventArgs e)
        {
            MenuItem selcted = (MenuItem)trvMenu.SelectedItem;
            if (selcted != null)
            {
                selcted.initFunction();

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
