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
    class Edc17TestFile : MenuItem, ITreeItem
    {
        public Edc17TestFile()
        {
            Title = "Edc17TestFile";
            IsSolutionItem = true;
            hasDtcSolution = false;
            hasEgrSolution = true;
            hasTVASolution = false;
            hasFileCheckSize = false;
            hasDpfSolution = true;
            hasLamdaSolution = false;
            hasFLAPSSolution = false;
            hasStartStopSolution = false;
            hasADBlueSolution = false;
            hasReadinessSolution = false;
            hasImmoSolution = false;
            hasSpecialISolution = false;
            hasSpecialIISolution = false;
            hasSpecialIIISolution = false;
            specialISolutionDescription = "";
            specialIISolutionDescription = "";
            specialIIISolutionDescription = "";
            desciption = "";
            FileSizeArray = new int[] { 4194304 };
        }

        public override async Task<bool> checkFileForEgr()
        {
            bool validationEgrInFile = false;
            //Algo for checking dpf solution
            if (ToolBox.array.Length > 0)
            {
                validationEgrInFile = true;
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 1 }, 3417255);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 1, 1, 1 }, 3417258);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 1, 1, 1 }, 3417263);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 3, 3, 3, 1 }, 3417267);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 11 }, 3417282);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 11 }, 3417287);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 1 }, 3417294);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 1 }, 3417344);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 6 }, 3417363);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 3 }, 3417490);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 3 }, 3417492);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 11 }, 3417621);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 1 }, 3417624);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 3, 3, 3 }, 3417626);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 3, 3, 3, 3, 3 }, 3417630);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 1, 3, 3, 11 }, 3417637);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 3 }, 3417700);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 3, 3, 1 }, 3417860);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 1 }, 3417977);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 1, 1 }, 3418060);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 1 }, 3418149);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 3, 1 }, 3418170);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 4, 4, 1 }, 3418174);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 3 }, 3418262);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 253, 3 }, 3461960);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 253, 3, 253, 3, 253, 3 }, 3461966);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 253, 3 }, 3461976);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 189, 3, 189, 3 }, 3461988);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 253, 3 }, 3462038);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 253, 3 }, 3462430);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 253, 3 }, 3462434);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 253, 3 }, 3462692);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 253, 3 }, 3462698);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 245, 3 }, 3462704);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 245, 3, 245, 3, 245, 3, 245, 3, 245, 3 }, 3462710);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 245, 3 }, 3462724);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 245, 3, 245, 3 }, 3462728);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 245, 3, 245, 3 }, 3462850);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 73, 246 }, 3463170);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 252, 3 }, 3463404);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 253, 3 }, 3463790);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 253, 3, 253, 3, 253, 3, 253, 3 }, 3463796);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 245, 1 }, 3463974);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 196, 9, 128, 12, 216, 14, 216, 14, 52, 8 }, 3780042);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 196, 9, 128, 12, 216, 14, 136, 19, 136, 19, 136, 19, 232, 3, 244, 1 }, 3780150);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 140, 10, 160, 15, 160, 15, 252, 8 }, 3780180);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 220, 5, 140, 10, 72, 13, 4, 16, 148, 17, 236, 19, 236, 19, 100 }, 3780394);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 152, 8, 184, 11, 16, 14, 16, 14, 8, 7 }, 3780422);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 120, 5, 40, 10, 228, 12, 160, 15, 48, 17, 136, 19, 136, 19 }, 3780634);
            }
            return validationEgrInFile;
        }
        public override async Task<bool> checkFileForDpf()
        {
            bool validationEgrInFile = false;
            //Algo for checking dpf solution
            if (ToolBox.array.Length > 0)
            {
                validationEgrInFile = true;

                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 3, 1, 1, 9, 3, 1, 1, 3, 3, 3, 3 }, 3417301);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 3, 3 }, 3417313);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 3, 4, 4, 1, 3, 1, 4, 4, 1, 1, 4, 1, 2 }, 3417339);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 2 }, 3417353);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 5 }, 3417370);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 1 }, 3417445);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 1, 6 }, 3417533);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 4, 6 }, 3417558);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 1, 3, 1, 1 }, 3417570);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 1 }, 3417586);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 1 }, 3417591);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 3 }, 3417610);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 1, 3 }, 3417637);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 3 }, 3417663);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 1 }, 3417666);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 1, 3, 1, 3 }, 3417679);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 3 }, 3417684);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 1 }, 3417686);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 1 }, 3417689);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 3, 3, 3 }, 3417695);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 3 }, 3417723);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 1 }, 3417762);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 1 }, 3417859);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 1 }, 3417863);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 1 }, 3417977);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 3 }, 3417986);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 11 }, 3418024);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 1, 1, 3, 3, 3, 1 }, 3418103);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 1, 1, 4, 1, 1 }, 3418127);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 1 }, 3418134);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 1, 1 }, 3418147);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 3, 1 }, 3418170);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 1 }, 3418193);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 2 }, 3418206);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 1, 1 }, 3418234);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 3, 3 }, 3418243);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 13, 1 }, 3462072);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 253, 3 }, 3462156);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 73, 242, 73, 242 }, 3462516);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 173, 2, 173, 2 }, 3462566);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 61, 3 }, 3462590);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 61, 3 }, 3462596);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 173, 2 }, 3462670);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 245, 3 }, 3462724);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 73, 242 }, 3462776);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 61, 3 }, 3462822);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 61, 3, 61, 3, 61, 3 }, 3462840);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 245, 3 }, 3462896);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 73, 246 }, 3463168);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 252, 3 }, 3463404);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 252, 3 }, 3463422);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 1, 240 }, 3463704);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 189, 3, 189, 3 }, 3463712);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 253, 3 }, 3463790);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 1, 0 }, 3463836);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 0, 0 }, 3463862);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 61, 3 }, 3463938);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 4, 1 }, 3971914);
            }
            return validationEgrInFile;

        }
        public override async Task<bool> checkFileForTva()
        {
            bool validationEgrInFile = false;
            //Algo for checking dpf solution
            if (ToolBox.array.Length > 0)
            {

            }
            return validationEgrInFile;
        }

        public override async Task<bool> checkFileForLamda()
        {
            bool validationEgrInFile = false;
            //Algo for checking dpf solution
            if (ToolBox.array.Length > 0)
            {

            }
            return validationEgrInFile;
        }

        public override async Task<bool> checkFileForFlaps()
        {
            bool validationEgrInFile = false;
            //Algo for checking dpf solution
            if (ToolBox.array.Length > 0)
            {

            }
            return validationEgrInFile;
        }

        public override async Task<bool> checkFileForStartStop()
        {
            bool validationEgrInFile = false;
            //Algo for checking dpf solution
            if (ToolBox.array.Length > 0)
            {

            }
            return validationEgrInFile;
        }

        public override async Task<bool> checkFileForAdBlue()
        {
            bool validationEgrInFile = false;
            //Algo for checking dpf solution
            if (ToolBox.array.Length > 0)
            {

            }
            return validationEgrInFile;
        }

        public override async Task<bool> checkFileForReadiness()
        {
            bool validationEgrInFile = false;
            //Algo for checking dpf solution
            if (ToolBox.array.Length > 0)
            {

            }
            return validationEgrInFile;
        }

        public override async Task<bool> checkFileForImmo()
        {
            bool validationEgrInFile = false;
            //Algo for checking dpf solution
            if (ToolBox.array.Length > 0)
            {

            }
            return validationEgrInFile;
        }

        public override async Task<bool> checkFileForSpecialI()
        {
            bool validationEgrInFile = false;
            //Algo for checking dpf solution
            if (ToolBox.array.Length > 0)
            {

            }
            return validationEgrInFile;
        }

        public override async Task<bool> checkFileForSpecialII()
        {
            bool validationEgrInFile = false;
            //Algo for checking dpf solution
            if (ToolBox.array.Length > 0)
            {

            }
            return validationEgrInFile;
        }

        public override async Task<bool> checkFileForSpecialIII()
        {
            bool validationEgrInFile = false;
            //Algo for checking dpf solution
            if (ToolBox.array.Length > 0)
            {

            }
            return validationEgrInFile;
        }

        public override void egrOffSolution()
        {
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 1 },
         new byte[] { 0 }, 3417255, 3417255, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 1, 1, 1 },
             new byte[] { 0, 0, 0 }, 3417258, 3417260, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 1, 1, 1 },
             new byte[] { 0, 0, 0 }, 3417263, 3417265, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 3, 3, 3, 1 },
             new byte[] { 0, 0, 0, 0 }, 3417267, 3417270, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 11 },
             new byte[] { 0 }, 3417282, 3417282, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 11 },
             new byte[] { 0 }, 3417287, 3417287, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 1 },
             new byte[] { 0 }, 3417294, 3417294, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 1 },
             new byte[] { 0 }, 3417344, 3417344, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 6 },
             new byte[] { 0 }, 3417363, 3417363, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 3 },
             new byte[] { 0 }, 3417490, 3417490, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 3 },
             new byte[] { 0 }, 3417492, 3417492, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 11 },
             new byte[] { 0 }, 3417621, 3417621, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 1 },
             new byte[] { 0 }, 3417624, 3417624, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 3, 3, 3 },
             new byte[] { 0, 0, 0 }, 3417626, 3417628, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 3, 3, 3, 3, 3 },
             new byte[] { 0, 0, 0, 0, 0 }, 3417630, 3417634, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 1, 3, 3, 11 },
             new byte[] { 0, 0, 0, 0 }, 3417637, 3417640, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 3 },
             new byte[] { 0 }, 3417700, 3417700, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 3, 3, 1 },
             new byte[] { 0, 0, 0 }, 3417860, 3417862, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 1 },
             new byte[] { 0 }, 3417977, 3417977, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 1, 1 },
             new byte[] { 0, 0 }, 3418060, 3418061, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 1 },
             new byte[] { 0 }, 3418149, 3418149, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 3, 1 },
             new byte[] { 0, 0 }, 3418170, 3418171, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 4, 4, 1 },
             new byte[] { 0, 0, 0 }, 3418174, 3418176, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 3 },
             new byte[] { 0 }, 3418262, 3418262, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 253, 3 },
             new byte[] { 255, 255 }, 3461960, 3461961, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 253, 3, 253, 3, 253, 3 },
             new byte[] { 255, 255, 255, 255, 255, 255 }, 3461966, 3461971, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 253, 3 },
             new byte[] { 255, 255 }, 3461976, 3461977, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 189, 3, 189, 3 },
             new byte[] { 255, 255, 255, 255 }, 3461988, 3461991, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 253, 3 },
             new byte[] { 255, 255 }, 3462038, 3462039, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 253, 3 },
             new byte[] { 255, 255 }, 3462430, 3462431, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 253, 3 },
             new byte[] { 255, 255 }, 3462434, 3462435, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 253, 3 },
             new byte[] { 255, 255 }, 3462692, 3462693, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 253, 3 },
             new byte[] { 255, 255 }, 3462698, 3462699, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 245, 3 },
             new byte[] { 255, 255 }, 3462704, 3462705, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 245, 3, 245, 3, 245, 3, 245, 3, 245, 3 },
             new byte[] { 255, 255, 255, 255, 255, 255, 255, 255, 255, 255 }, 3462710, 3462719, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 245, 3 },
             new byte[] { 255, 255 }, 3462724, 3462725, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 245, 3, 245, 3 },
             new byte[] { 255, 255, 255, 255 }, 3462728, 3462731, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 245, 3, 245, 3 },
             new byte[] { 255, 255, 255, 255 }, 3462850, 3462853, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 73, 246 },
             new byte[] { 255, 255 }, 3463170, 3463171, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 252, 3 },
             new byte[] { 255, 255 }, 3463404, 3463405, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 253, 3 },
             new byte[] { 255, 255 }, 3463790, 3463791, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 253, 3, 253, 3, 253, 3, 253, 3 },
             new byte[] { 255, 255, 255, 255, 255, 255, 255, 255 }, 3463796, 3463803, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 245, 1 },
             new byte[] { 255, 255 }, 3463974, 3463975, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 196, 9, 128, 12, 216, 14, 216, 14, 52, 8 },
             new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, 3780042, 3780051, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 196, 9, 128, 12, 216, 14, 136, 19, 136, 19, 136, 19, 232, 3, 244, 1 },
             new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, 3780150, 3780165, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 140, 10, 160, 15, 160, 15, 252, 8 },
             new byte[] { 0, 0, 0, 0, 0, 0, 0, 0 }, 3780180, 3780187, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 220, 5, 140, 10, 72, 13, 4, 16, 148, 17, 236, 19, 236, 19, 100 },
             new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, 3780394, 3780408, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 152, 8, 184, 11, 16, 14, 16, 14, 8, 7 },
             new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, 3780422, 3780431, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 120, 5, 40, 10, 228, 12, 160, 15, 48, 17, 136, 19, 136, 19 },
             new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, 3780634, 3780647, "Found egr map...Delete map");
            base.egrOffSolution();
        }
        public override void dpfOffSolution()
        {
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 3, 1, 1, 9, 3, 1, 1, 3, 3, 3, 3 },
         new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, 3417301, 3417311, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 3, 3 },
             new byte[] { 0, 0 }, 3417313, 3417314, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 3, 4, 4, 1, 3, 1, 4, 4, 1, 1, 4, 1, 2 },
             new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, 3417339, 3417351, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 2 },
             new byte[] { 0 }, 3417353, 3417353, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 5 },
             new byte[] { 0 }, 3417370, 3417370, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 1 },
             new byte[] { 0 }, 3417445, 3417445, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 1, 6 },
             new byte[] { 0, 0 }, 3417533, 3417534, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 4, 6 },
             new byte[] { 0, 0 }, 3417558, 3417559, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 1, 3, 1, 1 },
             new byte[] { 0, 0, 0, 0 }, 3417570, 3417573, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 1 },
             new byte[] { 0 }, 3417586, 3417586, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 1 },
             new byte[] { 0 }, 3417591, 3417591, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 3 },
             new byte[] { 0 }, 3417610, 3417610, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 1, 3 },
             new byte[] { 0, 0 }, 3417637, 3417638, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 3 },
             new byte[] { 0 }, 3417663, 3417663, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 1 },
             new byte[] { 0 }, 3417666, 3417666, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 1, 3, 1, 3 },
             new byte[] { 0, 0, 0, 0 }, 3417679, 3417682, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 3 },
             new byte[] { 0 }, 3417684, 3417684, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 1 },
             new byte[] { 0 }, 3417686, 3417686, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 1 },
             new byte[] { 0 }, 3417689, 3417689, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 3, 3, 3 },
             new byte[] { 0, 0, 0 }, 3417695, 3417697, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 3 },
             new byte[] { 0 }, 3417723, 3417723, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 1 },
             new byte[] { 0 }, 3417762, 3417762, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 1 },
             new byte[] { 0 }, 3417859, 3417859, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 1 },
             new byte[] { 0 }, 3417863, 3417863, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 1 },
             new byte[] { 0 }, 3417977, 3417977, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 3 },
             new byte[] { 0 }, 3417986, 3417986, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 11 },
             new byte[] { 0 }, 3418024, 3418024, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 1, 1, 3, 3, 3, 1 },
             new byte[] { 0, 0, 0, 0, 0, 0 }, 3418103, 3418108, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 1, 1, 4, 1, 1 },
             new byte[] { 0, 0, 0, 0, 0 }, 3418127, 3418131, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 1 },
             new byte[] { 0 }, 3418134, 3418134, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 1, 1 },
             new byte[] { 0, 0 }, 3418147, 3418148, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 3, 1 },
             new byte[] { 0, 0 }, 3418170, 3418171, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 1 },
             new byte[] { 0 }, 3418193, 3418193, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 2 },
             new byte[] { 0 }, 3418206, 3418206, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 1, 1 },
             new byte[] { 0, 0 }, 3418234, 3418235, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 3, 3 },
             new byte[] { 0, 0 }, 3418243, 3418244, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 13, 1 },
             new byte[] { 255, 255 }, 3462072, 3462073, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 253, 3 },
             new byte[] { 255, 255 }, 3462156, 3462157, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 73, 242, 73, 242 },
             new byte[] { 255, 255, 255, 255 }, 3462516, 3462519, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 173, 2, 173, 2 },
             new byte[] { 255, 255, 255, 255 }, 3462566, 3462569, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 61, 3 },
             new byte[] { 255, 255 }, 3462590, 3462591, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 61, 3 },
             new byte[] { 255, 255 }, 3462596, 3462597, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 173, 2 },
             new byte[] { 255, 255 }, 3462670, 3462671, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 245, 3 },
             new byte[] { 255, 255 }, 3462724, 3462725, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 73, 242 },
             new byte[] { 255, 255 }, 3462776, 3462777, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 61, 3 },
             new byte[] { 255, 255 }, 3462822, 3462823, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 61, 3, 61, 3, 61, 3 },
             new byte[] { 255, 255, 255, 255, 255, 255 }, 3462840, 3462845, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 245, 3 },
             new byte[] { 255, 255 }, 3462896, 3462897, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 73, 246 },
             new byte[] { 255, 255 }, 3463168, 3463169, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 252, 3 },
             new byte[] { 255, 255 }, 3463404, 3463405, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 252, 3 },
             new byte[] { 255, 255 }, 3463422, 3463423, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 1, 240 },
             new byte[] { 255, 255 }, 3463704, 3463705, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 189, 3, 189, 3 },
             new byte[] { 255, 255, 255, 255 }, 3463712, 3463715, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 253, 3 },
             new byte[] { 255, 255 }, 3463790, 3463791, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 1, 0 },
             new byte[] { 255, 255 }, 3463836, 3463837, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 0, 0 },
             new byte[] { 255, 255 }, 3463862, 3463863, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 61, 3 },
             new byte[] { 255, 255 }, 3463938, 3463939, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 4, 1 },
             new byte[] { 0, 0 }, 3971914, 3971915, "Found dpf map...Delete map");
            base.dpfOffSolution();
        }
        public override void lamdaOfffSolution()
        {

            base.lamdaOfffSolution();

        }

        public override void flapsOfffSolution()
        {


            base.flapsOfffSolution();
        }
        public override void startStopSolution()
        {


            base.startStopSolution();
        }

        public override void adBlueSolution()
        {


            base.adBlueSolution();
        }

        public override void readnissSolution()
        {


            base.readnissSolution();
        }
        public override void immoSolution()
        {

            base.immoSolution();

        }

        public override void tvaoffSolution()
        {


            base.tvaoffSolution();
        }

        public override void specialISolution()
        {


            base.specialISolution();
        }
        public override void specialIISolution()
        {

            base.specialIISolution();

        }

        public override void specialIIISolution()
        {

            base.specialIIISolution();

        }

        public List<string> getListOfDtcCodes()
        {
            return null;
        }

        public override void RemoveDtcFromFile(string dtcCode)
        {

            base.RemoveDtcFromFile(dtcCode);
        }

    }
}