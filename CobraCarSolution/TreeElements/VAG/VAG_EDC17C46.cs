using ToolBoxNameSpace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;
using System.IO;

namespace CobraCarSolution.TreeElements.VAG
{
    class VAG_EDC17C46 : MenuItem, ITreeItem
    {
        public VAG_EDC17C46()
        {
            Title = "EDC17C46";
            IsSolutionItem = true;
            hasEgrSolution = true;
            hasDpfSolution = false;
            hasDtcSolution = false;
        }

        public bool checkForFileSize()
        {
            if (ToolBox.array.Count() > 55000)
            {
                ToolBox.AddLineToConsoleBox("Flash loaded with success...");
                return true;
            }
            ToolBox.AddLineToConsoleBox("File not recognized...");

            return false;
        }

        public override void initFunction()
        {

            ToolBox.AddLineToConsoleBox("VAG_EDC17C46 selected...");
            if (checkForFileSize())
            {
                checkFileForEgr();
            }
            else
            {
                ToolBox.ResetStateAndFile();
            }
        }

        public override void checkFileForEgr()
        {
            bool validationEgrInFile = false;
            //Algo for checking dpf solution
            if (ToolBox.array.Length > 0)
            {
                if (ToolBox.ExistsInFile(new byte[] { 0x01, 0x01, 0x01, 0x01, 0x01, 0x01, 0x0B, 0x02, 0x02, 0x01, 0x01, 0x01, 0x04, 0x04, 0x03, 0x09 }))
                {
                    if (ToolBox.ExistsInFile(new byte[] { 0x0B, 0x0B, 0x0B, 0x01, 0x01, 0x0B, 0x01, 0x00, 0x0B, 0x0B, 0x0B, 0x01 }))
                    {
                        if (ToolBox.ExistsInFile(new byte[] { 0x04, 0x09, 0x01, 0x01, 0x03, 0x03, 0x03 }))
                        {
                            if (ToolBox.ExistsInFile(new byte[] { 0x03, 0x03, 0x0B, 0x0B, 0x0B, 0x0B }))
                            {
                                if (ToolBox.ExistsInFile(new byte[] { 0x09, 0x01, 0x01, 0x03, 0x03, 0x03, 0x03, 0x03 }))
                                {
                                    if (ToolBox.ExistsInFile(new byte[] { 0x04, 0x09, 0x01, 0x01, 0x03, 0x03, 0x03, 0x03, 0x03 }))
                                    {
                                        if (ToolBox.ExistsInFile(new byte[] { 0x01, 0x0B, 0x01, 0x01, 0x01, 0x01, 0x01, 0x03, 0x03, 0x03, 0x00, 0x03, 0x03, 0x03, 0x03, 0x03, 0x03, 0x03, 0x03, 0x03, 0x03, 0x03, 0x03, 0x03, 0x03 }))
                                        {
                                            if (ToolBox.ExistsInFile(new byte[] { 0x09, 0x09, 0x09, 0x09, 0x09, 0x09, 0x01, 0x01, 0x01, 0x03, 0x0B, 0x03, 0x0B, 0x0B, 0x03, 0x03 }))
                                            {
                                                if (ToolBox.ExistsInFile(new byte[] { 0x0B, 0x00, 0x03, 0x01, 0x01, 0x03, 0x03, 0x02, 0x02, 0x0B, 0x0B, 0x0B, 0x0B, 0x0B, 0x0B, 0x0B }))
                                                {
                                                    if (ToolBox.ExistsInFile(new byte[] { 0x04, 0x04, 0x04, 0x04, 0x04, 0x03, 0x03, 0x03, 0x00, 0x00, 0x09, 0x04, 0x03, 0x03, 0x03, 0x03 }))
                                                    {
                                                        if (ToolBox.ExistsInFile(new byte[] { 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0x09, 0x00, 0x09, 0x00, 0x09, 0x00, 0x09, 0x00, 0xFF, 0xFF }))
                                                        {
                                                            if (ToolBox.ExistsInFile(new byte[] { 0xED, 0x03, 0xED, 0x03, 0xED, 0x03 }))
                                                            {
                                                                if (ToolBox.ExistsInFile(new byte[] { 0xED, 0x03, 0xFD, 0x03, 0xFF, 0xFF, 0x4D, 0x02, 0xD5, 0x01, 0xFF, 0xFF, 0xD5, 0x01, 0xD5, 0x01, 0xD5, 0x01, 0xD5, 0x01, 0xD5, 0x01, 0xD5, 0x01 }))
                                                                {
                                                                    if (ToolBox.ExistsInFile(new byte[] { 0xD5, 0x01, 0xD5, 0x01 }))
                                                                    {
                                                                        if (ToolBox.ExistsInFile(new byte[] { 0xDD, 0x03, 0xDD, 0x03 }))
                                                                        {
                                                                            validationEgrInFile = true;
                                                                            ToolBox.AddLineToConsoleBox("EGR Maps found in data...");
                                                                            ToolBox.setEgrButtonState(1);
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }

                                    }
                                }
                            }
                        }
                    }
                }
            }
            if (!validationEgrInFile)
            {
                ToolBox.AddLineToConsoleBox("EGR Maps not found in data...");
                ToolBox.setEgrButtonState(1, true);
            }

        }

        public override void checkFileForDPF()
        {
            bool validationEgrInFile = false;
            //Algo for checking dpf solution
            if (ToolBox.array.Length > 0)
            {
                if (ToolBox.ExistsInFile(new byte[] { 0x0A, 0x00, 0x48, 0x0D, 0x02, 0x01, 0x00, 0x00, 0x00, 0x00, 0x04, 0x01, 0x00, 0x00, 0x00, 0x00 }))
                {
                    if (ToolBox.ExistsInFile(new byte[] { 0xFF, 0xFF, 0x3D, 0x03, 0xF5, 0x03 }))
                    {
                        if (ToolBox.ExistsInFile(new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 }))
                        {
                            if (ToolBox.ExistsInFile(new byte[] { 0x01, 0xF0, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xBD, 0x03, 0xBD, 0x03 }))
                            {
                                if (ToolBox.ExistsInFile(new byte[] { 0xFF, 0xFF, 0x00, 0x00, 0x3D, 0x03, 0x3D, 0x03, 0x3D, 0x03 }))
                                {
                                    if (ToolBox.ExistsInFile(new byte[] { 0x3D, 0x03, 0x3D, 0x03, 0x3D, 0x03 }))
                                    {
                                        validationEgrInFile = true;
                                        ToolBox.AddLineToConsoleBox("DPF Maps found in data...");
                                        ToolBox.setDpfButtonState(1);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            if (!validationEgrInFile)
            {
                ToolBox.AddLineToConsoleBox("DPF Maps not found in data...");
                ToolBox.setDpfButtonState(1, true);
            }

        }

        public override void egrOffSolution()
        {
            ToolBox.ReplaceInFile(new byte[] { 0x01, 0x01, 0x01, 0x01, 0x01, 0x01, 0x0B, 0x02, 0x02, 0x01, 0x01, 0x01, 0x04, 0x04, 0x03, 0x09 },
                                  new byte[] { 0x00, 0x01, 0x01, 0x00, 0x00, 0x00, 0x0B, 0x02, 0x00, 0x00, 0x00, 0x01, 0x00, 0x00, 0x00, 0x00 }, "Found egr map...Delete map");
            ToolBox.ReplaceInFile(new byte[] { 0x0B, 0x0B, 0x0B, 0x01, 0x01, 0x0B, 0x01, 0x00, 0x0B, 0x0B, 0x0B, 0x01 },
                                  new byte[] { 0x0B, 0x0B, 0x0B, 0x01, 0x00, 0x0B, 0x00, 0x00, 0x0B, 0x0B, 0x0B, 0x00 }, "Found egr map...Delete map");

            ToolBox.FillBytesFromToOneByte(0x00, 137705, 137705);
            ToolBox.FillBytesFromToOneByte(0x00, 137689, 137689);

            ToolBox.ReplaceInFile(new byte[] { 0x04, 0x09, 0x01, 0x01, 0x03, 0x03, 0x03 },
                                  new byte[] { 0x04, 0x09, 0x01, 0x01, 0x00, 0x03, 0x00 }, "Found egr map...Delete map");
            ToolBox.ReplaceInFile(new byte[] { 0x03, 0x03, 0x0B, 0x0B, 0x0B, 0x0B },
                                  new byte[] { 0x03, 0x00, 0x00, 0x00, 0x0B }, "Found egr map...Delete map");
            ToolBox.ReplaceInFile(new byte[] { 0x09, 0x01, 0x01, 0x03, 0x03, 0x03, 0x03, 0x03 },
                                  new byte[] { 0x09, 0x01, 0x01, 0x00, 0x03, 0x00, 0x03, 0x03 }, "Found egr map...Delete map");

            ToolBox.ReplaceInFile(new byte[] { 0x04, 0x09, 0x01, 0x01, 0x03, 0x03, 0x03, 0x03, 0x03 },
                                  new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 }, "Found egr map...Delete map");
            ToolBox.ReplaceInFile(new byte[] { 0x01, 0x0B, 0x01, 0x01, 0x01, 0x01, 0x01, 0x03, 0x03, 0x03, 0x00, 0x03, 0x03, 0x03, 0x03, 0x03, 0x03, 0x03, 0x03, 0x03, 0x03, 0x03, 0x03, 0x03, 0x03 },
                                  new byte[] { 0x00, 0x0B, 0x01, 0x01, 0x01, 0x01, 0x01, 0x00, 0x03, 0x03, 0x00, 0x00, 0x00, 0x03, 0x00, 0x00, 0x00, 0x00, 0x00, 0x03, 0x03, 0x00, 0x00, 0x00, 0x00 }, "Found egr map...Delete map");
            ToolBox.ReplaceInFile(new byte[] { 0x09, 0x09, 0x09, 0x09, 0x09, 0x09, 0x01, 0x01, 0x01, 0x03, 0x0B, 0x03, 0x0B, 0x0B, 0x03, 0x03 },
                                  new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 }, "Found egr map...Delete map");
            ToolBox.ReplaceInFile(new byte[] { 0x09, 0x09, 0x09, 0x09, 0x09, 0x09, 0x01, 0x01, 0x01, 0x03, 0x0B, 0x03, 0x0B, 0x0B, 0x03, 0x03 },
                                  new byte[] { 0x09, 0x09, 0x09, 0x09, 0x09, 0x00, 0x00, 0x00, 0x01, 0x03, 0x0B, 0x03, 0x0B, 0x0B, 0x03, 0x03 });
            ToolBox.ReplaceInFile(new byte[] { 0x0B, 0x00, 0x03, 0x01, 0x01, 0x03, 0x03, 0x02, 0x02, 0x0B, 0x0B, 0x0B, 0x0B, 0x0B, 0x0B, 0x0B },
                                  new byte[] { 0x0B, 0x00, 0x03, 0x00, 0x00, 0x03, 0x03, 0x02, 0x02, 0x0B, 0x0B, 0x0B, 0x0B, 0x0B, 0x0B, 0x0B }, "Found egr map...Delete map");


            ToolBox.FillBytesFromToOneByte(0x00, 138539, 138540);


            ToolBox.ReplaceInFile(new byte[] { 0x04, 0x04, 0x04, 0x04, 0x04, 0x03, 0x03, 0x03, 0x00, 0x00, 0x09, 0x04, 0x03, 0x03, 0x03, 0x03 },
                                  new byte[] { 0x04, 0x04, 0x04, 0x04, 0x04, 0x00, 0x00, 0x03, 0x00, 0x00, 0x00, 0x00, 0x03, 0x03, 0x03, 0x03 }, "Found egr map...Delete map");

            ToolBox.ReplaceInFile(new byte[] { 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0x09, 0x00, 0x09, 0x00, 0x09, 0x00, 0x09, 0x00, 0xFF, 0xFF },
                                  new byte[] { 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF }, "Found egr map...Delete map");


            ToolBox.FillBytesFromToOneByte(0xFF, 173268, 173269);
            ToolBox.FillBytesFromToOneByte(0xFF, 173292, 173293);
            ToolBox.FillBytesFromToOneByte(0xFF, 173976, 173977);
            ToolBox.FillBytesFromToOneByte(0xFF, 175084, 175085);
            ToolBox.FillBytesFromToOneByte(0xFF, 175136, 175137);



            ToolBox.ReplaceInFile(new byte[] { 0xED, 0x03, 0xED, 0x03, 0xED, 0x03 },
                                  new byte[] { 0xFF, 0xFF, 0xED, 0x03, 0xFF, 0xFF }, "Found egr map...Delete map");
            ToolBox.ReplaceInFile(new byte[] { 0xED, 0x03, 0xFD, 0x03, 0xFF, 0xFF, 0x4D, 0x02, 0xD5, 0x01, 0xFF, 0xFF, 0xD5, 0x01, 0xD5, 0x01, 0xD5, 0x01, 0xD5, 0x01, 0xD5, 0x01, 0xD5, 0x01 },
                                  new byte[] { 0xFF, 0xFF, 0xFD, 0x03, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xD5, 0x01, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF }, "Found egr map...Delete map");
            ToolBox.ReplaceInFile(new byte[] { 0xD5, 0x01, 0xD5, 0x01 },
                                  new byte[] { 0xFF, 0xFF, 0xFF, 0xFF }, "Found egr map...Delete map");
            ToolBox.ReplaceInFile(new byte[] { 0xDD, 0x03, 0xDD, 0x03 },
                                  new byte[] { 0xFF, 0xFF, 0xFF, 0xFF }, "Found egr map...Delete map");
            base.egrOffSolution();
        }
        public override void dpfOffSolution()
        {
        }

        public List<string> getListOfDtcCodes()
        {
            // get list of all dtcs, Dtc code, mask, current state
            return null;
        }
        public override void RemoveDtcFromFile(string dtcCode)
        {
            //Find dtccodes
            //show how often found in file
            //+
            //36from file and call base function
            base.RemoveDtcFromFile(dtcCode);
        }

    }
}
