using BusyIndicator;

using CobraCarSolution.TreeElements.VAG;

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Security.Cryptography;
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
    public partial class ExportSciptGenerator : Window
    {
        public string orgFilePath = "";

        public ExportSciptGenerator()
        {
            InitializeComponent();

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private bool isPathSet(string pathname)
        {
            if (!string.IsNullOrEmpty(pathname) && !pathname.StartsWith("file not"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (isPathSet(orgFilePath))
            {
                List<DiffCollection> diffCollectionFromUI = new List<DiffCollection>();
                byte[] org = File.ReadAllBytes(egrPath.Text);
                if (isPathSet(egrPath.Text))
                {
                    DiffCollection egrCollection = new DiffCollection();
                    egrCollection.solutionName = "egrSolution";
                    egrCollection.compare = File.ReadAllBytes(egrPath.Text);
                }
            }
        }
    }
}
