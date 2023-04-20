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
        public byte[] orgFile = new byte[0];


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
                if (isPathSet(egrPath.Text))
                {
                    DiffCollection egrCollection = new DiffCollection();
                    egrCollection.solutionName = "egrSolution";
                    egrCollection.compare = File.ReadAllBytes(egrPath.Text);
                    diffCollectionFromUI.Add(egrCollection);
                }

                if (isPathSet(dpfPath.Text))
                {
                    DiffCollection egrCollection = new DiffCollection();
                    egrCollection.solutionName = "dpfSolution";
                    egrCollection.compare = File.ReadAllBytes(dpfPath.Text);
                    diffCollectionFromUI.Add(egrCollection);
                }
                if (isPathSet(lamdaPath.Text))
                {
                    DiffCollection egrCollection = new DiffCollection();
                    egrCollection.solutionName = "lamdaSolution";
                    egrCollection.compare = File.ReadAllBytes(lamdaPath.Text);
                    diffCollectionFromUI.Add(egrCollection);
                }
                if (isPathSet(lamdaPath.Text))
                {
                    DiffCollection egrCollection = new DiffCollection();
                    egrCollection.solutionName = "lamdaSolution";
                    egrCollection.compare = File.ReadAllBytes(lamdaPath.Text);
                    diffCollectionFromUI.Add(egrCollection);
                }
                if (isPathSet(lamdaPath.Text))
                {
                    DiffCollection egrCollection = new DiffCollection();
                    egrCollection.solutionName = "lamdaSolution";
                    egrCollection.compare = File.ReadAllBytes(lamdaPath.Text);
                    diffCollectionFromUI.Add(egrCollection);
                }
                if (isPathSet(flapsPath.Text))
                {
                    DiffCollection egrCollection = new DiffCollection();
                    egrCollection.solutionName = "flapsSolution";
                    egrCollection.compare = File.ReadAllBytes(lamdaPath.Text);
                    diffCollectionFromUI.Add(egrCollection);
                }
                if (isPathSet(startstopPath.Text))
                {
                    DiffCollection egrCollection = new DiffCollection();
                    egrCollection.solutionName = "startStopSolution";
                    egrCollection.compare = File.ReadAllBytes(startstopPath.Text);
                    diffCollectionFromUI.Add(egrCollection);
                }

                if (isPathSet(adbluePath.Text))
                {
                    DiffCollection egrCollection = new DiffCollection();
                    egrCollection.solutionName = "adblueSolution";
                    egrCollection.compare = File.ReadAllBytes(adbluePath.Text);
                    diffCollectionFromUI.Add(egrCollection);
                }
                if (isPathSet(readinessPath.Text))
                {
                    DiffCollection egrCollection = new DiffCollection();
                    egrCollection.solutionName = "readinessSolution";
                    egrCollection.compare = File.ReadAllBytes(readinessPath.Text);
                    diffCollectionFromUI.Add(egrCollection);
                }
                if (isPathSet(immoPath.Text))
                {
                    DiffCollection egrCollection = new DiffCollection();
                    egrCollection.solutionName = "immoSolution";
                    egrCollection.compare = File.ReadAllBytes(immoPath.Text);
                    diffCollectionFromUI.Add(egrCollection);
                }
                if (isPathSet(specialiPath.Text))
                {
                    DiffCollection egrCollection = new DiffCollection();
                    egrCollection.solutionName = "specialiSolution";
                    egrCollection.compare = File.ReadAllBytes(specialiPath.Text);
                    diffCollectionFromUI.Add(egrCollection);
                }
                if (isPathSet(specialiiPath.Text))
                {
                    DiffCollection egrCollection = new DiffCollection();
                    egrCollection.solutionName = "specialiiSolution";
                    egrCollection.compare = File.ReadAllBytes(specialiiPath.Text);
                    diffCollectionFromUI.Add(egrCollection);
                }
                if (isPathSet(specialiiiPath.Text))
                {
                    DiffCollection egrCollection = new DiffCollection();
                    egrCollection.solutionName = "specialiiiSolution";
                    egrCollection.compare = File.ReadAllBytes(specialiiiPath.Text);
                    diffCollectionFromUI.Add(egrCollection);
                }

                FileCombreResult newComparer = new FileCombreResult(orgFile, diffCollectionFromUI, ecuFileName.Text);
                if (newComparer != null)
                {

                }

            }
        }

        private async void Button_Click_1(object sender, RoutedEventArgs e)
        {

            await Task.Run(() =>
            {
                Application.Current.Dispatcher.Invoke(() =>
                {

                    Microsoft.Win32.OpenFileDialog openFileDialog = new Microsoft.Win32.OpenFileDialog();
                    if (openFileDialog.ShowDialog() == true)
                    {
                        orgFilePath = openFileDialog.FileName;
                        orgFile = File.ReadAllBytes(openFileDialog.FileName);

                    }
                    else
                    {
                        orgFilePath = "";
                        orgFile = new byte[0];
                    }
                });

            });


        }

        private async void Button_Click_2(object sender, RoutedEventArgs e)
        {
            await Task.Run(() =>
            {
                Application.Current.Dispatcher.Invoke(() =>
                {

                    Microsoft.Win32.OpenFileDialog openFileDialog = new Microsoft.Win32.OpenFileDialog();
                    if (openFileDialog.ShowDialog() == true)
                    {
                        egrPath.Text = openFileDialog.FileName;
                    }
                    else
                    {
                        egrPath.Text = "file not selected...";
                    }
                });

            });
        }

        private async void Button_Click_3(object sender, RoutedEventArgs e)
        {
            await Task.Run(() =>
            {
                Application.Current.Dispatcher.Invoke(() =>
                {

                    Microsoft.Win32.OpenFileDialog openFileDialog = new Microsoft.Win32.OpenFileDialog();
                    if (openFileDialog.ShowDialog() == true)
                    {
                        dpfPath.Text = openFileDialog.FileName;


                    }
                    else
                    {
                        dpfPath.Text = "file not selected...";
                    }
                });

            });
        }

        private async void Button_Click_4(object sender, RoutedEventArgs e)
        {
            await Task.Run(() =>
            {
                Application.Current.Dispatcher.Invoke(() =>
                {

                    Microsoft.Win32.OpenFileDialog openFileDialog = new Microsoft.Win32.OpenFileDialog();
                    if (openFileDialog.ShowDialog() == true)
                    {
                        tvaPath.Text = openFileDialog.FileName;


                    }
                    else
                    {
                        tvaPath.Text = "file not selected...";
                    }
                });

            });
        }

        private async void Button_Click_5(object sender, RoutedEventArgs e)
        {
            await Task.Run(() =>
            {
                Application.Current.Dispatcher.Invoke(() =>
                {

                    Microsoft.Win32.OpenFileDialog openFileDialog = new Microsoft.Win32.OpenFileDialog();
                    if (openFileDialog.ShowDialog() == true)
                    {
                        lamdaPath.Text = openFileDialog.FileName;
                    }
                    else
                    {
                        lamdaPath.Text = "file not selected...";
                    }
                });

            });
        }

        private async void Button_Click_6(object sender, RoutedEventArgs e)
        {
            await Task.Run(() =>
            {
                Application.Current.Dispatcher.Invoke(() =>
                {

                    Microsoft.Win32.OpenFileDialog openFileDialog = new Microsoft.Win32.OpenFileDialog();
                    if (openFileDialog.ShowDialog() == true)
                    {
                        flapsPath.Text = openFileDialog.FileName;
                    }
                    else
                    {
                        flapsPath.Text = "file not selected...";
                    }
                });

            });
        }

        private async void Button_Click_7(object sender, RoutedEventArgs e)
        {
            await Task.Run(() =>
            {
                Application.Current.Dispatcher.Invoke(() =>
                {

                    Microsoft.Win32.OpenFileDialog openFileDialog = new Microsoft.Win32.OpenFileDialog();
                    if (openFileDialog.ShowDialog() == true)
                    {
                        startstopPath.Text = openFileDialog.FileName;
                    }
                    else
                    {
                        startstopPath.Text = "file not selected...";
                    }
                });

            });
        }

        private async void Button_Click_8(object sender, RoutedEventArgs e)
        {
            await Task.Run(() =>
            {
                Application.Current.Dispatcher.Invoke(() =>
                {

                    Microsoft.Win32.OpenFileDialog openFileDialog = new Microsoft.Win32.OpenFileDialog();
                    if (openFileDialog.ShowDialog() == true)
                    {
                        adbluePath.Text = openFileDialog.FileName;
                    }
                    else
                    {
                        adbluePath.Text = "file not selected...";
                    }
                });

            });
        }

        private async void Button_Click_9(object sender, RoutedEventArgs e)
        {
            await Task.Run(() =>
            {
                Application.Current.Dispatcher.Invoke(() =>
                {

                    Microsoft.Win32.OpenFileDialog openFileDialog = new Microsoft.Win32.OpenFileDialog();
                    if (openFileDialog.ShowDialog() == true)
                    {
                        readinessPath.Text = openFileDialog.FileName;
                    }
                    else
                    {
                        readinessPath.Text = "file not selected...";
                    }
                });

            });
        }

        private async void Button_Click_10(object sender, RoutedEventArgs e)
        {
            await Task.Run(() =>
            {
                Application.Current.Dispatcher.Invoke(() =>
                {

                    Microsoft.Win32.OpenFileDialog openFileDialog = new Microsoft.Win32.OpenFileDialog();
                    if (openFileDialog.ShowDialog() == true)
                    {
                        immoPath.Text = openFileDialog.FileName;
                    }
                    else
                    {
                        immoPath.Text = "file not selected...";
                    }
                });

            });
        }

        private async void Button_Click_11(object sender, RoutedEventArgs e)
        {
            await Task.Run(() =>
            {
                Application.Current.Dispatcher.Invoke(() =>
                {

                    Microsoft.Win32.OpenFileDialog openFileDialog = new Microsoft.Win32.OpenFileDialog();
                    if (openFileDialog.ShowDialog() == true)
                    {
                        specialiPath.Text = openFileDialog.FileName;
                    }
                    else
                    {
                        specialiPath.Text = "file not selected...";
                    }
                });

            });
        }
    }
}
