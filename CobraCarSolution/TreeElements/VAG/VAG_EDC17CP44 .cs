﻿using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToolBoxNameSpace;

namespace CobraCarSolution.TreeElements.VAG
{
    class VAG_EDC17CP44 : MenuItem, ITreeItem
    {
        public VAG_EDC17CP44()
        {
            Title = "EDC17CP44";
            IsSolutionItem = true;
            hasEgrSolution = true;
            hasDpfSolution = true;
            hasDtcSolution = false;
            FileSizeArray = new int[] { 0 };
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

        public override async Task<bool> checkFileForEgr()
        {
            bool validationEgrInFile = false;
            //Algo for checking dpf solution
            if (ToolBox.array.Length > 0)
            {
                if (ToolBox.ExistsInFile(new byte[] { 0x78, 0x05, 0x28, 0x0A, 0xE4, 0x0C, 0xA0, 0x0F, 0x30, 0x11, 0x88, 0x13, 0x88, 0x13 }))
                {
                    if (ToolBox.ExistsInFile(new byte[] { 0x98, 0x08, 0xB8, 0x0B, 0x10, 0x0E, 0x10, 0x0E, 0x08, 0x07 }))
                    {
                        if (ToolBox.ExistsInFile(new byte[] { 0xDC, 0x05, 0x8C, 0x0A, 0x48, 0x0D, 0x04, 0x10, 0x94, 0x11, 0xEC, 0x13, 0xEC, 0x13, 0x64 }))
                        {
                            if (ToolBox.ExistsInFile(new byte[] { 0x8C, 0x0A, 0xA0, 0x0F, 0xA0, 0x0F, 0xFC, 0x08 }))
                            {
                                if (ToolBox.ExistsInFile(new byte[] { 0xC4, 0x09, 0x80, 0x0C, 0xD8, 0x0E, 0xD8, 0x0E, 0x34, 0x08 }))
                                {
                                    if (ToolBox.ExistsInFile(new byte[] { 0x7D, 0x03, 0xF5, 0x01, 0xF5, 0x01, 0xF5, 0x01 }))
                                    {
                                        if (ToolBox.ExistsInFile(new byte[] { 0xFD, 0x03, 0xFF, 0xFF, 0xFF, 0xFF, 0xFD, 0x03, 0xFD, 0x03, 0xFD, 0x03, 0xFD, 0x03 }))
                                        {
                                            if (ToolBox.ExistsInFile(new byte[] { 0x49, 0xF6, 0x49, 0xF6 }))
                                            {
                                                if (ToolBox.ExistsInFile(new byte[] { 0xF5, 0x03, 0xF5, 0x03, 0xF5, 0x03 }))
                                                {
                                                    if (ToolBox.ExistsInFile(new byte[] { 0xFD, 0x03, 0xFD, 0x03, 0xFF, 0xFF, 0xFD, 0x03, 0xFF, 0xFF, 0xFF, 0xFF, 0xF5, 0x03, 0xFF, 0xFF, 0xFF, 0xFF, 0xF5, 0x03, 0xF5, 0x03, 0xF5, 0x03, 0xF5, 0x03, 0xF5, 0x03, 0xFF, 0xFF, 0xF5, 0x03, 0xF5, 0x03, 0xFF, 0xFF, 0xF5, 0x03, 0xF5, 0x03 }))
                                                    {
                                                        if (ToolBox.ExistsInFile(new byte[] { 0xFD, 0x03, 0xFD, 0x03, 0xFD, 0x03 }))
                                                        {
                                                            if (ToolBox.ExistsInFile(new byte[] { 0x01, 0x01, 0x01, 0x01, 0x01, 0x01, 0x01, 0x01, 0x01, 0x01, 0x01, 0x03, 0x03, 0x03, 0x03, 0x01 }))
                                                            {
                                                                if (ToolBox.ExistsInFile(new byte[] { 0x0B, 0x0B, 0x0B, 0x01, 0x01, 0x0B, 0x01, 0x00, 0x0B, 0x0B, 0x01, 0x01, 0x01 }))
                                                                {
                                                                    validationEgrInFile = true;
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
            return validationEgrInFile;
        }
        public override async Task<bool> checkFileForDpf()
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
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return validationEgrInFile;

        }
        public override void egrOffSolution()
        {
            ToolBox.ReplaceInFile(new byte[] { 0x78, 0x05, 0x28, 0x0A, 0xE4, 0x0C, 0xA0, 0x0F, 0x30, 0x11, 0x88, 0x13, 0x88, 0x13 },
                                  new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 }, "Found egr map...Delete map");
            ToolBox.ReplaceInFile(new byte[] { 0x98, 0x08, 0xB8, 0x0B, 0x10, 0x0E, 0x10, 0x0E, 0x08, 0x07 },
                                  new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 }, "Found egr map...Delete map");
            ToolBox.ReplaceInFile(new byte[] { 0xDC, 0x05, 0x8C, 0x0A, 0x48, 0x0D, 0x04, 0x10, 0x94, 0x11, 0xEC, 0x13, 0xEC, 0x13, 0x64 },
                                  new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 }, "Found egr map...Delete map");
            ToolBox.ReplaceInFile(new byte[] { 0x8C, 0x0A, 0xA0, 0x0F, 0xA0, 0x0F, 0xFC, 0x08 },
                                  new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 }, "Found egr map...Delete map");
            ToolBox.ReplaceInFile(new byte[] { 0xC4, 0x09, 0x80, 0x0C, 0xD8, 0x0E, 0xD8, 0x0E, 0x34, 0x08 },
                                  new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 }, "Found egr map...Delete map");

            ToolBox.ReplaceInFile(new byte[] { 0x7D, 0x03, 0xF5, 0x01, 0xF5, 0x01, 0xF5, 0x01 },
                                  new byte[] { 0x7D, 0x03, 0xF5, 0x01, 0xF5, 0x01, 0xFF, 0xFF }, "Found egr map...Delete map");
            ToolBox.ReplaceInFile(new byte[] { 0xFD, 0x03, 0xFF, 0xFF, 0xFF, 0xFF, 0xFD, 0x03, 0xFD, 0x03, 0xFD, 0x03, 0xFD, 0x03 },
                                  new byte[] { 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF }, "Found egr map...Delete map");
            ToolBox.ReplaceInFile(new byte[] { 0x49, 0xF6, 0x49, 0xF6 },
                                  new byte[] { 0x49, 0xF6, 0xFF, 0xFF }, "Found egr map...Delete map");
            ToolBox.ReplaceInFile(new byte[] { 0xF5, 0x03, 0xF5, 0x03, 0xF5, 0x03 },
                                  new byte[] { 0xF5, 0x03, 0xFF, 0xFF, 0xFF, 0xFF }, "Found egr map...Delete map");

            ToolBox.ReplaceInFile(new byte[] { 0xFD, 0x03, 0xFD, 0x03, 0xFF, 0xFF, 0xFD, 0x03, 0xFF, 0xFF, 0xFF, 0xFF, 0xF5, 0x03, 0xFF, 0xFF, 0xFF, 0xFF, 0xF5, 0x03, 0xF5, 0x03, 0xF5, 0x03, 0xF5, 0x03, 0xF5, 0x03, 0xFF, 0xFF, 0xF5, 0x03, 0xF5, 0x03, 0xFF, 0xFF, 0xF5, 0x03, 0xF5, 0x03 },
                                  new byte[] { 0xFF, 0xFF, 0xFD, 0x03, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xF5, 0x03, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF }, "Found egr map...Delete map");

            ToolBox.ReplaceInFile(new byte[] { 0xFD, 0x03, 0xFD, 0x03, 0xFD, 0x03 },
                                  new byte[] { 0xFF, 0xFF, 0xFD, 0x03, 0xFF, 0xFF }, "Found egr map...Delete map");

            ToolBox.ReplaceInFile(new byte[] { 0x01, 0x01, 0x01, 0x01, 0x01, 0x01, 0x01, 0x01, 0x01, 0x01, 0x01, 0x03, 0x03, 0x03, 0x03, 0x01 },
                                  new byte[] { 0x00, 0x01, 0x01, 0x00, 0x00, 0x00, 0x01, 0x01, 0x00, 0x00, 0x00, 0x03, 0x00, 0x00, 0x00, 0x00 }, "Found egr map...Delete map");

            ToolBox.ReplaceInFile(new byte[] { 0x0B, 0x0B, 0x0B, 0x01, 0x01, 0x0B, 0x01, 0x00, 0x0B, 0x0B, 0x01, 0x01, 0x01 },
                                  new byte[] { 0x00, 0x0B, 0x0B, 0x01, 0x01, 0x00, 0x01, 0x00, 0x0B, 0x0B, 0x01, 0x01, 0x00 }, "Found egr map...Delete map");
            base.egrOffSolution();
        }
        public override void dpfOffSolution()
        {
            ToolBox.ReplaceInFile(new byte[] { 0x0A, 0x00, 0x48, 0x0D, 0x02, 0x01, 0x00, 0x00, 0x00, 0x00, 0x04, 0x01, 0x00, 0x00, 0x00, 0x00 }, new byte[] { 0x0A, 0x00, 0x48, 0x0D, 0x02, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 }, "Found dpf map...Delete map");
            ToolBox.ReplaceInFile(new byte[] { 0xFF, 0xFF, 0x3D, 0x03, 0xF5, 0x03 }, new byte[] { 0xFF, 0xFF, 0xFF, 0xFF, 0xF5, 0x03 }, "Found dpf map...Delete map");
            ToolBox.ReplaceInFile(new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 }, new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xFF, 0xFF }, "Found dpf map...Delete map");
            ToolBox.ReplaceInFile(new byte[] { 0x01, 0xF0, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xBD, 0x03, 0xBD, 0x03 }, new byte[] { 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF }, "Found dpf map...Delete map");
            ToolBox.ReplaceInFile(new byte[] { 0xFF, 0xFF, 0x00, 0x00, 0x3D, 0x03, 0x3D, 0x03, 0x3D, 0x03 }, new byte[] { 0xFF, 0xFF, 0x00, 0x00, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF }, "Found dpf map...Delete map");
            ToolBox.ReplaceInFile(new byte[] { 0x3D, 0x03, 0x3D, 0x03, 0x3D, 0x03 }, new byte[] { 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF }, "Found dpf map...Delete map");

            base.dpfOffSolution();
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
