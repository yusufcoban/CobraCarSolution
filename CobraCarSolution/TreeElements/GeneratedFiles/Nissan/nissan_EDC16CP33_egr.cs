using ToolBoxNameSpace;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace CobraCarSolution.TreeElements.VAG
{
    class nissan_EDC16CP33 : MenuItem, ITreeItem
    {
        public nissan_EDC16CP33()
        {
            Title = "EDC16CP33";
            IsSolutionItem = true;
            hasDtcSolution = false;
            hasEgrSolution = true;
            hasTVASolution = false;
            hasFileCheckSize = false;
            hasDpfSolution = false;
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
            FileSizeArray = new int[] { 0 };
        }

        public override async Task<bool> checkFileForEgr()
        {
            bool validationEgrInFile = true;
            //Algo for checking dpf solution
            if (ToolBox.array.Length > 0)
            {
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 21 }, 1836687);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 21 }, 1836845);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 21 }, 1836849);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 21 }, 1836853);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 10, 10 }, 1836858);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 10, 10, 10, 10, 10 }, 1836864);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 10, 10, 8 }, 1836870);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 10 }, 1836889);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 21 }, 1836893);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16, 16 }, 1838146);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 241, 13, 241, 14, 241, 10, 241, 18, 240, 195, 241, 17, 241, 189, 240, 21 }, 1847408);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 241, 13, 240, 54, 240, 56, 240, 63, 240, 154, 240, 149, 241, 30, 240, 69, 240, 64, 240, 142, 240, 254, 241, 10, 241, 18, 240, 62, 240, 154, 240, 45, 240, 2, 240, 195, 241, 17, 241, 14 }, 1848516);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 241, 13, 241, 14, 240, 17, 240, 54, 240, 56, 240, 63, 240, 64, 240, 69, 240, 151, 240, 149, 241, 30, 240, 142, 241, 18, 240, 62, 240, 45, 240, 154, 240, 2, 240, 195, 241, 17, 241, 10 }, 1848566);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 241, 13, 241, 14, 240, 17, 240, 54, 240, 56, 240, 63, 240, 64, 240, 69, 241, 10, 240, 149, 241, 30, 240, 142, 241, 18, 240, 62, 240, 45, 240, 154, 240, 2, 240, 195, 241, 17 }, 1848616);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 240, 16, 240, 153, 240, 64, 241, 13, 241, 14, 240, 149, 240, 158, 240, 142, 240, 54, 240, 44, 240, 63, 240, 62, 240, 45, 240, 50, 240, 144, 241, 10, 240, 141, 240, 2, 241, 17, 241, 18, 240, 56 }, 1848716);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 240, 142, 240, 153, 241, 13, 240, 149, 240, 62, 240, 45, 240, 44, 240, 63, 240, 50, 240, 141, 240, 2, 241, 10, 241, 17, 241, 18, 240, 195, 241, 14, 240, 144 }, 1848762);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 240, 142, 240, 144, 240, 153, 240, 149, 240, 62, 240, 45, 240, 44, 240, 63, 240, 50, 240, 141, 240, 2, 241, 10, 241, 17, 241, 18, 240, 195, 241, 14, 241, 13 }, 1848802);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 240, 142, 240, 144, 240, 153, 240, 149, 240, 62, 240, 45, 240, 44, 240, 63, 240, 50, 240, 141, 240, 2, 241, 10, 241, 17, 241, 18, 240, 195, 241, 14, 241, 13 }, 1848842);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 241, 13, 240, 54, 240, 63, 240, 64, 240, 56, 240, 62, 240, 45, 241, 14, 240, 151, 240, 2, 241, 17, 241, 18, 241, 10, 240, 195 }, 1848952);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 240, 64, 240, 149, 241, 128, 240, 54, 240, 63 }, 1848992);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 240, 56, 240, 62, 240, 45, 240, 152, 240, 2 }, 1849004);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 241, 13, 240, 195, 241, 14, 241, 18, 241, 17, 240, 21 }, 1849018);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 240, 1, 240, 5, 240, 6, 240, 8, 240, 9, 240, 16 }, 1856494);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 240, 35, 240, 75, 240, 123 }, 1856508);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 240, 44, 240, 50, 240, 63, 128, 84, 240, 133, 241, 28, 241, 128 }, 1856516);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 241, 69 }, 1856532);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 241, 103, 241, 121, 241, 134, 241, 175 }, 1856540);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 241, 135 }, 1856554);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 241, 184, 241, 181, 241, 189, 240, 2 }, 1856560);
            }
            return validationEgrInFile;
        }
        public override async Task<bool> checkFileForDpf()
        {
            bool validationEgrInFile = true;
            //Algo for checking dpf solution
            if (ToolBox.array.Length > 0)
            {

            }
            return validationEgrInFile;

        }
        public override async Task<bool> checkFileForTva()
        {
            bool validationEgrInFile = true;
            //Algo for checking dpf solution
            if (ToolBox.array.Length > 0)
            {

            }
            return validationEgrInFile;
        }

        public override async Task<bool> checkFileForLamda()
        {
            bool validationEgrInFile = true;
            //Algo for checking dpf solution
            if (ToolBox.array.Length > 0)
            {

            }
            return validationEgrInFile;
        }

        public override async Task<bool> checkFileForFlaps()
        {
            bool validationEgrInFile = true;
            //Algo for checking dpf solution
            if (ToolBox.array.Length > 0)
            {

            }
            return validationEgrInFile;
        }

        public override async Task<bool> checkFileForStartStop()
        {
            bool validationEgrInFile = true;
            //Algo for checking dpf solution
            if (ToolBox.array.Length > 0)
            {

            }
            return validationEgrInFile;
        }

        public override async Task<bool> checkFileForAdBlue()
        {
            bool validationEgrInFile = true;
            //Algo for checking dpf solution
            if (ToolBox.array.Length > 0)
            {

            }
            return validationEgrInFile;
        }

        public override async Task<bool> checkFileForReadiness()
        {
            bool validationEgrInFile = true;
            //Algo for checking dpf solution
            if (ToolBox.array.Length > 0)
            {

            }
            return validationEgrInFile;
        }

        public override async Task<bool> checkFileForImmo()
        {
            bool validationEgrInFile = true;
            //Algo for checking dpf solution
            if (ToolBox.array.Length > 0)
            {

            }
            return validationEgrInFile;
        }

        public override async Task<bool> checkFileForSpecialI()
        {
            bool validationEgrInFile = true;
            //Algo for checking dpf solution
            if (ToolBox.array.Length > 0)
            {

            }
            return validationEgrInFile;
        }

        public override async Task<bool> checkFileForSpecialII()
        {
            bool validationEgrInFile = true;
            //Algo for checking dpf solution
            if (ToolBox.array.Length > 0)
            {

            }
            return validationEgrInFile;
        }

        public override async Task<bool> checkFileForSpecialIII()
        {
            bool validationEgrInFile = true;
            //Algo for checking dpf solution
            if (ToolBox.array.Length > 0)
            {

            }
            return validationEgrInFile;
        }

        public override void egrOffSolution()
        {
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 21 },
         new byte[] { 0 }, 1836687, 1836687, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 21 },
             new byte[] { 0 }, 1836845, 1836845, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 21 },
             new byte[] { 0 }, 1836849, 1836849, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 21 },
             new byte[] { 0 }, 1836853, 1836853, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 10, 10 },
             new byte[] { 0, 0 }, 1836858, 1836859, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 10, 10, 10, 10, 10 },
             new byte[] { 0, 0, 0, 0, 0 }, 1836864, 1836868, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 10, 10, 8 },
             new byte[] { 0, 0, 0 }, 1836870, 1836872, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 10 },
             new byte[] { 0 }, 1836889, 1836889, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 21 },
             new byte[] { 0 }, 1836893, 1836893, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16, 16 },
             new byte[] { 0, 0 }, 1838146, 1838147, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 241, 13, 241, 14, 241, 10, 241, 18, 240, 195, 241, 17, 241, 189, 240, 21 },
             new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, 1847408, 1847423, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 241, 13, 240, 54, 240, 56, 240, 63, 240, 154, 240, 149, 241, 30, 240, 69, 240, 64, 240, 142, 240, 254, 241, 10, 241, 18, 240, 62, 240, 154, 240, 45, 240, 2, 240, 195, 241, 17, 241, 14 },
             new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, 1848516, 1848555, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 241, 13, 241, 14, 240, 17, 240, 54, 240, 56, 240, 63, 240, 64, 240, 69, 240, 151, 240, 149, 241, 30, 240, 142, 241, 18, 240, 62, 240, 45, 240, 154, 240, 2, 240, 195, 241, 17, 241, 10 },
             new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, 1848566, 1848605, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 241, 13, 241, 14, 240, 17, 240, 54, 240, 56, 240, 63, 240, 64, 240, 69, 241, 10, 240, 149, 241, 30, 240, 142, 241, 18, 240, 62, 240, 45, 240, 154, 240, 2, 240, 195, 241, 17 },
             new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, 1848616, 1848653, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 240, 16, 240, 153, 240, 64, 241, 13, 241, 14, 240, 149, 240, 158, 240, 142, 240, 54, 240, 44, 240, 63, 240, 62, 240, 45, 240, 50, 240, 144, 241, 10, 240, 141, 240, 2, 241, 17, 241, 18, 240, 56 },
             new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, 1848716, 1848757, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 240, 142, 240, 153, 241, 13, 240, 149, 240, 62, 240, 45, 240, 44, 240, 63, 240, 50, 240, 141, 240, 2, 241, 10, 241, 17, 241, 18, 240, 195, 241, 14, 240, 144 },
             new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, 1848762, 1848795, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 240, 142, 240, 144, 240, 153, 240, 149, 240, 62, 240, 45, 240, 44, 240, 63, 240, 50, 240, 141, 240, 2, 241, 10, 241, 17, 241, 18, 240, 195, 241, 14, 241, 13 },
             new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, 1848802, 1848835, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 240, 142, 240, 144, 240, 153, 240, 149, 240, 62, 240, 45, 240, 44, 240, 63, 240, 50, 240, 141, 240, 2, 241, 10, 241, 17, 241, 18, 240, 195, 241, 14, 241, 13 },
             new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, 1848842, 1848875, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 241, 13, 240, 54, 240, 63, 240, 64, 240, 56, 240, 62, 240, 45, 241, 14, 240, 151, 240, 2, 241, 17, 241, 18, 241, 10, 240, 195 },
             new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, 1848952, 1848979, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 240, 64, 240, 149, 241, 128, 240, 54, 240, 63 },
             new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, 1848992, 1849001, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 240, 56, 240, 62, 240, 45, 240, 152, 240, 2 },
             new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, 1849004, 1849013, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 241, 13, 240, 195, 241, 14, 241, 18, 241, 17, 240, 21 },
             new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, 1849018, 1849029, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 240, 1, 240, 5, 240, 6, 240, 8, 240, 9, 240, 16 },
             new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, 1856494, 1856505, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 240, 35, 240, 75, 240, 123 },
             new byte[] { 0, 0, 0, 0, 0, 0 }, 1856508, 1856513, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 240, 44, 240, 50, 240, 63, 128, 84, 240, 133, 241, 28, 241, 128 },
             new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, 1856516, 1856529, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 241, 69 },
             new byte[] { 0, 0 }, 1856532, 1856533, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 241, 103, 241, 121, 241, 134, 241, 175 },
             new byte[] { 0, 0, 0, 0, 0, 0, 0, 0 }, 1856540, 1856547, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 241, 135 },
             new byte[] { 0, 0 }, 1856554, 1856555, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 241, 184, 241, 181, 241, 189, 240, 2 },
             new byte[] { 0, 0, 0, 0, 0, 0, 0, 0 }, 1856560, 1856567, "Found egr map...Delete map");
            base.egrOffSolution();
        }
        public override void dpfOffSolution()
        {

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