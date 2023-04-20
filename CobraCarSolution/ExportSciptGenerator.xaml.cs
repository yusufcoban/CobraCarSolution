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
    public partial class ExportSciptGenerator : Window
    {
        public bool egrOffEffected = false;
        public bool dpfOffEffected = false;
        public bool dtcOffEffected = false;


        public ExportSciptGenerator()
        {
            InitializeComponent();

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
