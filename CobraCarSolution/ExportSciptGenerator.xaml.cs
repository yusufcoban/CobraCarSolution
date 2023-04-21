using BusyIndicator;
using CobraCarSolution.TreeElements.GenerateTemplate;
using CobraCarSolution.TreeElements.VAG;

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
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
                string specialItext = specialIDesc.Text;
                string specialIItext = specialIIDesc.Text;
                string specialIIItext = specialIIIDesc.Text;

                List<DiffCollection> diffCollectionFromUI = new List<DiffCollection>();
                GeneralTemplate template = new GeneralTemplate();
                if (checkedFileSize.IsChecked == true)
                {
                    template.fileSize = orgFile.Length;
                }


                if (isPathSet(egrPath.Text))
                {
                    template.hasEgrSolution = true;
                    DiffCollection egrCollection = new DiffCollection();
                    egrCollection.solutionName = "egrSolution";
                    egrCollection.compare = File.ReadAllBytes(egrPath.Text);
                    diffCollectionFromUI.Add(egrCollection);

                }

                if (isPathSet(dpfPath.Text))
                {
                    template.hasDpfSolution = true;

                    DiffCollection egrCollection = new DiffCollection();
                    egrCollection.solutionName = "dpfSolution";
                    egrCollection.compare = File.ReadAllBytes(dpfPath.Text);
                    diffCollectionFromUI.Add(egrCollection);
                }
                if (isPathSet(tvaPath.Text))
                {
                    template.hasTVASolution = true;
                    DiffCollection egrCollection = new DiffCollection();
                    egrCollection.solutionName = "tvaSolution";
                    egrCollection.compare = File.ReadAllBytes(tvaPath.Text);
                    diffCollectionFromUI.Add(egrCollection);
                }
                if (isPathSet(lamdaPath.Text))
                {
                    template.hasLamdaSolution = true;

                    DiffCollection egrCollection = new DiffCollection();
                    egrCollection.solutionName = "lamdaSolution";
                    egrCollection.compare = File.ReadAllBytes(lamdaPath.Text);
                    diffCollectionFromUI.Add(egrCollection);
                }
                if (isPathSet(flapsPath.Text))
                {
                    template.hasFLAPSSolution = true;

                    DiffCollection egrCollection = new DiffCollection();
                    egrCollection.solutionName = "flapsSolution";
                    egrCollection.compare = File.ReadAllBytes(lamdaPath.Text);
                    diffCollectionFromUI.Add(egrCollection);
                }
                if (isPathSet(startstopPath.Text))
                {
                    template.hasStartStopSolution = true;

                    DiffCollection egrCollection = new DiffCollection();
                    egrCollection.solutionName = "startStopSolution";
                    egrCollection.compare = File.ReadAllBytes(startstopPath.Text);
                    diffCollectionFromUI.Add(egrCollection);
                }

                if (isPathSet(adbluePath.Text))
                {
                    template.hasADBlueSolution = true;

                    DiffCollection egrCollection = new DiffCollection();
                    egrCollection.solutionName = "adblueSolution";
                    egrCollection.compare = File.ReadAllBytes(adbluePath.Text);
                    diffCollectionFromUI.Add(egrCollection);
                }
                if (isPathSet(readinessPath.Text))
                {
                    template.hasEgrSolution = true;
                    DiffCollection egrCollection = new DiffCollection();
                    egrCollection.solutionName = "readinessSolution";
                    egrCollection.compare = File.ReadAllBytes(readinessPath.Text);
                    diffCollectionFromUI.Add(egrCollection);
                }
                if (isPathSet(immoPath.Text))
                {
                    template.hasImmoSolution = true;
                    DiffCollection egrCollection = new DiffCollection();
                    egrCollection.solutionName = "immoSolution";
                    egrCollection.compare = File.ReadAllBytes(immoPath.Text);
                    diffCollectionFromUI.Add(egrCollection);
                }
                if (isPathSet(specialiPath.Text))
                {
                    template.hasSpecialISolution = true;

                    DiffCollection egrCollection = new DiffCollection();
                    egrCollection.solutionName = "specialiSolution";
                    egrCollection.compare = File.ReadAllBytes(specialiPath.Text);
                    diffCollectionFromUI.Add(egrCollection);
                }
                if (isPathSet(specialiiPath.Text))
                {
                    template.hasSpecialIISolution = true;

                    DiffCollection egrCollection = new DiffCollection();
                    egrCollection.solutionName = "specialiiSolution";
                    egrCollection.compare = File.ReadAllBytes(specialiiPath.Text);
                    diffCollectionFromUI.Add(egrCollection);
                }
                if (isPathSet(specialiiiPath.Text))
                {
                    template.hasSpecialIIISolution = true;

                    DiffCollection egrCollection = new DiffCollection();
                    egrCollection.solutionName = "specialiiiSolution";
                    egrCollection.compare = File.ReadAllBytes(specialiiiPath.Text);
                    diffCollectionFromUI.Add(egrCollection);
                }

                FileCombreResult newComparer = new FileCombreResult(orgFile, diffCollectionFromUI, ecuFileName.Text);


                if (newComparer != null)
                {

                    if (newComparer.allDifferencesForEcu.Any())
                    {
                        foreach (CombareCreator combareCreator in newComparer.allDifferencesForEcu)
                        {
                            if (combareCreator.results != null)
                            {
                                foreach (Combarer item in combareCreator.results.allCompareResult)
                                {
                                    switch (item.solutionName)
                                    {
                                        case "egrSolution":
                                            List<string> templateForCheck = new List<string>();
                                            List<string> templateForReplace = new List<string>();

                                            for (int i = 0; i < item.collectionDifference.Count(); i++)
                                            {
                                                templateForCheck.Add("ToolBox.ExistsInFileMultiple(new byte[] doubleBrackedOpen" + String.Join(",", item.collectionDifference[i].orginal) + " doubleBrackedClosed,  " + item.collectionDifference[i].startAdress + "    );");
                                                templateForReplace.Add("ToolBox.ReplaceInFileWithStartStop(new byte[] doubleBrackedOpen" + String.Join(",", item.collectionDifference[i].orginal) + " },\r\n new byte[] doubleBrackedOpen " + String.Join(",", item.collectionDifference[i].difference) + " doubleBrackedClosed," + item.collectionDifference[i].startAdress + "," + item.collectionDifference[i].endAdress + "," + " \"Found egr map...Delete map\");");
                                            }
                                            template.checkFileForEgrCODE = String.Join("\r\n", templateForCheck);
                                            template.FileForEgrCODE = String.Join("\r\n", templateForReplace);

                                            break;

                                        case "dpfSolution":
                                            Console.WriteLine("Subject is C++");
                                            break;
                                        case "tvaSolution":
                                            Console.WriteLine("Subject is C++");
                                            break;
                                        case "lamdaSolution":
                                            Console.WriteLine("Subject is C++");
                                            break;
                                        case "flapsSolution":
                                            Console.WriteLine("Subject is C++");
                                            break;
                                        case "startStopSolution":
                                            Console.WriteLine("Subject is C++");
                                            break;
                                        case "adblueSolution":
                                            Console.WriteLine("Subject is C++");
                                            break;
                                        case "readinessSolution":
                                            Console.WriteLine("Subject is C++");
                                            break;
                                        case "immoSolution":
                                            Console.WriteLine("Subject is C++");
                                            break;
                                    }
                                }
                            }

                        }
                    }
                    template.TitleECU = ecuFileName.Text;
                    GenerateCSFile.GenerateFile(template, orgFilePath);
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
