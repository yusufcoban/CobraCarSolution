using CobraCarSolution.TreeElements.GenerateTemplate;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

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
                    template.specialISolutionDescription = specialIDesc.Text;
                    DiffCollection egrCollection = new DiffCollection();
                    egrCollection.solutionName = "specialiSolution";
                    egrCollection.compare = File.ReadAllBytes(specialiPath.Text);

                    diffCollectionFromUI.Add(egrCollection);
                }
                if (isPathSet(specialiiPath.Text))
                {
                    template.hasSpecialIISolution = true;
                    template.specialIISolutionDescription = specialIIDesc.Text;

                    DiffCollection egrCollection = new DiffCollection();
                    egrCollection.solutionName = "specialiiSolution";
                    egrCollection.compare = File.ReadAllBytes(specialiiPath.Text);
                    diffCollectionFromUI.Add(egrCollection);
                }
                if (isPathSet(specialiiiPath.Text))
                {
                    template.hasSpecialIIISolution = true;
                    template.specialIIISolutionDescription = specialIIIDesc.Text;

                    DiffCollection egrCollection = new DiffCollection();
                    egrCollection.solutionName = "specialiiiSolution";
                    egrCollection.compare = File.ReadAllBytes(specialiiiPath.Text);
                    diffCollectionFromUI.Add(egrCollection);
                }

                FileCombreResult newComparer = new FileCombreResult(orgFile, diffCollectionFromUI, ecuFileName.Text);
                bool ignoreThisFile = false;

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
                                    if (item.collectionDifference.Any())
                                    {
                                        ignoreThisFile = true;
                                        MessageBox.Show("NO DIFFERENCES IN AT LEAST ONE COMBARING FILE!");
                                    }
                                    else
                                    {
                                        List<string> templateForCheck = new List<string>();
                                        List<string> templateForReplace = new List<string>();
                                        switch (item.solutionName)
                                        {
                                            case "egrSolution":


                                                for (int i = 0; i < item.collectionDifference.Count(); i++)
                                                {
                                                    templateForCheck.Add("validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[] doubleBrackedOpen" + String.Join(",", item.collectionDifference[i].orginal) + " doubleBrackedClosed,  " + item.collectionDifference[i].startAdress + "    );");
                                                    templateForReplace.Add("ToolBox.ReplaceInFileWithStartStop(new byte[] doubleBrackedOpen" + String.Join(",", item.collectionDifference[i].orginal) + " },\r\n new byte[] doubleBrackedOpen " + String.Join(",", item.collectionDifference[i].difference) + " doubleBrackedClosed," + item.collectionDifference[i].startAdress + "," + item.collectionDifference[i].endAdress + "," + " \"Found egr map...Delete map\");");
                                                }
                                                template.checkFileForEgrCODE = String.Join("\r\n", templateForCheck);
                                                template.FileForEgrCODE = String.Join("\r\n", templateForReplace);

                                                break;

                                            case "dpfSolution":
                                                for (int i = 0; i < item.collectionDifference.Count(); i++)
                                                {
                                                    templateForCheck.Add("validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[] doubleBrackedOpen" + String.Join(",", item.collectionDifference[i].orginal) + " doubleBrackedClosed,  " + item.collectionDifference[i].startAdress + "    );");
                                                    templateForReplace.Add("ToolBox.ReplaceInFileWithStartStop(new byte[] doubleBrackedOpen" + String.Join(",", item.collectionDifference[i].orginal) + " },\r\n new byte[] doubleBrackedOpen " + String.Join(",", item.collectionDifference[i].difference) + " doubleBrackedClosed," + item.collectionDifference[i].startAdress + "," + item.collectionDifference[i].endAdress + "," + " \"Found dpf map...Delete map\");");
                                                }
                                                template.checkFileForDpfCODE = String.Join("\r\n", templateForCheck);
                                                template.FileForDpfCODE = String.Join("\r\n", templateForReplace);

                                                break;
                                            case "tvaSolution":
                                                for (int i = 0; i < item.collectionDifference.Count(); i++)
                                                {
                                                    templateForCheck.Add("validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[] doubleBrackedOpen" + String.Join(",", item.collectionDifference[i].orginal) + " doubleBrackedClosed,  " + item.collectionDifference[i].startAdress + "    );");
                                                    templateForReplace.Add("ToolBox.ReplaceInFileWithStartStop(new byte[] doubleBrackedOpen" + String.Join(",", item.collectionDifference[i].orginal) + " },\r\n new byte[] doubleBrackedOpen " + String.Join(",", item.collectionDifference[i].difference) + " doubleBrackedClosed," + item.collectionDifference[i].startAdress + "," + item.collectionDifference[i].endAdress + "," + " \"Found tva map...Delete map\");");
                                                }
                                                template.checkFileForTvaCODE = String.Join("\r\n", templateForCheck);
                                                template.FileForTvaCODE = String.Join("\r\n", templateForReplace);

                                                break;
                                            case "lamdaSolution":
                                                for (int i = 0; i < item.collectionDifference.Count(); i++)
                                                {
                                                    templateForCheck.Add("validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[] doubleBrackedOpen" + String.Join(",", item.collectionDifference[i].orginal) + " doubleBrackedClosed,  " + item.collectionDifference[i].startAdress + "    );");
                                                    templateForReplace.Add("ToolBox.ReplaceInFileWithStartStop(new byte[] doubleBrackedOpen" + String.Join(",", item.collectionDifference[i].orginal) + " },\r\n new byte[] doubleBrackedOpen " + String.Join(",", item.collectionDifference[i].difference) + " doubleBrackedClosed," + item.collectionDifference[i].startAdress + "," + item.collectionDifference[i].endAdress + "," + " \"Found lamda map...Delete map\");");
                                                }
                                                template.checkFileForLamdaCODE = String.Join("\r\n", templateForCheck);
                                                template.FileForLamdaCODE = String.Join("\r\n", templateForReplace);

                                                break;
                                            case "flapsSolution":
                                                for (int i = 0; i < item.collectionDifference.Count(); i++)
                                                {
                                                    templateForCheck.Add("validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[] doubleBrackedOpen" + String.Join(",", item.collectionDifference[i].orginal) + " doubleBrackedClosed,  " + item.collectionDifference[i].startAdress + "    );");
                                                    templateForReplace.Add("ToolBox.ReplaceInFileWithStartStop(new byte[] doubleBrackedOpen" + String.Join(",", item.collectionDifference[i].orginal) + " },\r\n new byte[] doubleBrackedOpen " + String.Join(",", item.collectionDifference[i].difference) + " doubleBrackedClosed," + item.collectionDifference[i].startAdress + "," + item.collectionDifference[i].endAdress + "," + " \"Found flaps map...Delete map\");");
                                                }
                                                template.checkFileForFlapsCODE = String.Join("\r\n", templateForCheck);
                                                template.FileForFlapsCODE = String.Join("\r\n", templateForReplace);

                                                break;
                                            case "startStopSolution":
                                                for (int i = 0; i < item.collectionDifference.Count(); i++)
                                                {
                                                    templateForCheck.Add("validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[] doubleBrackedOpen" + String.Join(",", item.collectionDifference[i].orginal) + " doubleBrackedClosed,  " + item.collectionDifference[i].startAdress + "    );");
                                                    templateForReplace.Add("ToolBox.ReplaceInFileWithStartStop(new byte[] doubleBrackedOpen" + String.Join(",", item.collectionDifference[i].orginal) + " },\r\n new byte[] doubleBrackedOpen " + String.Join(",", item.collectionDifference[i].difference) + " doubleBrackedClosed," + item.collectionDifference[i].startAdress + "," + item.collectionDifference[i].endAdress + "," + " \"Found startstop map...Delete map\");");
                                                }
                                                template.checkFileForStartStopCODE = String.Join("\r\n", templateForCheck);
                                                template.FileForStartStopCODE = String.Join("\r\n", templateForReplace);

                                                break;
                                            case "adblueSolution":
                                                for (int i = 0; i < item.collectionDifference.Count(); i++)
                                                {
                                                    templateForCheck.Add("validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[] doubleBrackedOpen" + String.Join(",", item.collectionDifference[i].orginal) + " doubleBrackedClosed,  " + item.collectionDifference[i].startAdress + "    );");
                                                    templateForReplace.Add("ToolBox.ReplaceInFileWithStartStop(new byte[] doubleBrackedOpen" + String.Join(",", item.collectionDifference[i].orginal) + " },\r\n new byte[] doubleBrackedOpen " + String.Join(",", item.collectionDifference[i].difference) + " doubleBrackedClosed," + item.collectionDifference[i].startAdress + "," + item.collectionDifference[i].endAdress + "," + " \"Found startstop map...Delete map\");");
                                                }
                                                template.checkFileForStartStopCODE = String.Join("\r\n", templateForCheck);
                                                template.FileForStartStopCODE = String.Join("\r\n", templateForReplace);

                                                break;
                                            case "readinessSolution":
                                                for (int i = 0; i < item.collectionDifference.Count(); i++)
                                                {
                                                    templateForCheck.Add("validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[] doubleBrackedOpen" + String.Join(",", item.collectionDifference[i].orginal) + " doubleBrackedClosed,  " + item.collectionDifference[i].startAdress + "    );");
                                                    templateForReplace.Add("ToolBox.ReplaceInFileWithStartStop(new byte[] doubleBrackedOpen" + String.Join(",", item.collectionDifference[i].orginal) + " },\r\n new byte[] doubleBrackedOpen " + String.Join(",", item.collectionDifference[i].difference) + " doubleBrackedClosed," + item.collectionDifference[i].startAdress + "," + item.collectionDifference[i].endAdress + "," + " \"Found readiness map...Delete map\");");
                                                }
                                                template.checkFileForReadinessCODE = String.Join("\r\n", templateForCheck);
                                                template.FileForReadinessCODE = String.Join("\r\n", templateForReplace);

                                                break;
                                            case "immoSolution":
                                                for (int i = 0; i < item.collectionDifference.Count(); i++)
                                                {
                                                    templateForCheck.Add("validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[] doubleBrackedOpen" + String.Join(",", item.collectionDifference[i].orginal) + " doubleBrackedClosed,  " + item.collectionDifference[i].startAdress + "    );");
                                                    templateForReplace.Add("ToolBox.ReplaceInFileWithStartStop(new byte[] doubleBrackedOpen" + String.Join(",", item.collectionDifference[i].orginal) + " },\r\n new byte[] doubleBrackedOpen " + String.Join(",", item.collectionDifference[i].difference) + " doubleBrackedClosed," + item.collectionDifference[i].startAdress + "," + item.collectionDifference[i].endAdress + "," + " \"Found immo map...Delete map\");");
                                                }
                                                template.checkFileForImmoCODE = String.Join("\r\n", templateForCheck);
                                                template.FileForImmoCODE = String.Join("\r\n", templateForReplace);

                                                break;
                                            case "specialiSolution":
                                                for (int i = 0; i < item.collectionDifference.Count(); i++)
                                                {
                                                    templateForCheck.Add("validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[] doubleBrackedOpen" + String.Join(",", item.collectionDifference[i].orginal) + " doubleBrackedClosed,  " + item.collectionDifference[i].startAdress + "    );");
                                                    templateForReplace.Add("ToolBox.ReplaceInFileWithStartStop(new byte[] doubleBrackedOpen" + String.Join(",", item.collectionDifference[i].orginal) + " },\r\n new byte[] doubleBrackedOpen " + String.Join(",", item.collectionDifference[i].difference) + " doubleBrackedClosed," + item.collectionDifference[i].startAdress + "," + item.collectionDifference[i].endAdress + "," + " \"Found immo map...Delete map\");");
                                                }
                                                template.checkFileForSpecialICODE = String.Join("\r\n", templateForCheck);
                                                template.FileForSpecialICODE = String.Join("\r\n", templateForReplace);

                                                break;

                                            case "specialiiSolution":
                                                for (int i = 0; i < item.collectionDifference.Count(); i++)
                                                {
                                                    templateForCheck.Add("validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[] doubleBrackedOpen" + String.Join(",", item.collectionDifference[i].orginal) + " doubleBrackedClosed,  " + item.collectionDifference[i].startAdress + "    );");
                                                    templateForReplace.Add("ToolBox.ReplaceInFileWithStartStop(new byte[] doubleBrackedOpen" + String.Join(",", item.collectionDifference[i].orginal) + " },\r\n new byte[] doubleBrackedOpen " + String.Join(",", item.collectionDifference[i].difference) + " doubleBrackedClosed," + item.collectionDifference[i].startAdress + "," + item.collectionDifference[i].endAdress + "," + " \"Found immo map...Delete map\");");
                                                }
                                                template.checkFileForSpecialIICODE = String.Join("\r\n", templateForCheck);
                                                template.FileForSpecialIICODE = String.Join("\r\n", templateForReplace);

                                                break;

                                            case "specialiiiSolution":
                                                for (int i = 0; i < item.collectionDifference.Count(); i++)
                                                {
                                                    templateForCheck.Add("validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[] doubleBrackedOpen" + String.Join(",", item.collectionDifference[i].orginal) + " doubleBrackedClosed,  " + item.collectionDifference[i].startAdress + "    );");
                                                    templateForReplace.Add("ToolBox.ReplaceInFileWithStartStop(new byte[] doubleBrackedOpen" + String.Join(",", item.collectionDifference[i].orginal) + " },\r\n new byte[] doubleBrackedOpen " + String.Join(",", item.collectionDifference[i].difference) + " doubleBrackedClosed," + item.collectionDifference[i].startAdress + "," + item.collectionDifference[i].endAdress + "," + " \"Found immo map...Delete map\");");
                                                }
                                                template.checkFileForSpecialIIICODE = String.Join("\r\n", templateForCheck);
                                                template.FileForSpecialIIICODE = String.Join("\r\n", templateForReplace);

                                                break;
                                        }

                                    }
                                }
                            }

                        }
                    }
                    template.TitleECU = ecuFileName.Text;
                    if (!ignoreThisFile)
                    {
                                                GenerateCSFile.GenerateFile(template, orgFilePath);
                    }
                    ResetAll();
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
                        orgPath.Text = openFileDialog.FileName;
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

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            ResetAll();
        }
        private void ResetAll()
        {

            orgPath.Text = "file not selected...";
            egrPath.Text = "file not selected...";
            dpfPath.Text = "file not selected...";
            ecuFileName.Text = "EcuName";
            tvaPath.Text = "file not selected...";
            lamdaPath.Text = "file not selected...";
            flapsPath.Text = "file not selected...";
            startstopPath.Text = "file not selected...";
            adbluePath.Text = "file not selected...";
            readinessPath.Text = "file not selected...";
            immoPath.Text = "file not selected...";
            specialiPath.Text = "file not selected...";
            specialiiPath.Text = "file not selected...";
            specialiiiPath.Text = "file not selected...";
            specialIIIDesc.Text = "Desciption";
            specialIDesc.Text = "Desciption";
            specialIIDesc.Text = "Desciption";
            checkedFileSize.IsChecked = false;
            orgFilePath = "";
            orgFile = new byte[0];
        }
    }
}
