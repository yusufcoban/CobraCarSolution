using System.Collections.Generic;
using System.Threading.Tasks;

namespace CobraCarSolution.TreeElements.VAG
{
    class HONDA_EDC17CP16 : MenuItem, ITreeItem
    {
        public HONDA_EDC17CP16()
        {
            Title = "HONDA_EDC17CP16";
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
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 136, 138, 19, 32, 3, 3 }, 98050);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 254 }, 98061);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 118 }, 98067);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 101, 32 }, 98069);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 32, 51, 39 }, 98073);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 175, 180, 30, 199, 193, 7, 109, 8, 177, 156, 162, 240, 51, 217, 27, 85, 205, 120, 157, 229, 175, 180, 30, 199, 193, 7, 109, 8, 177, 156, 162, 240, 51, 217, 27, 85, 205, 120, 157, 229 }, 98080);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 107, 95, 221, 21, 182, 145, 30, 130, 192, 174, 51, 11, 129, 180, 39, 57, 211, 73, 199, 148, 211, 194, 189, 65 }, 98140);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 172, 13, 172, 13, 172, 13, 172, 13, 40, 15, 164, 16, 32, 18, 136, 19, 136, 19, 136, 19, 136, 19, 136, 19, 136, 19, 200 }, 1733170);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 200 }, 1733198);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 200 }, 1733200);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 200 }, 1733202);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 200 }, 1733204);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 200 }, 1733206);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 200 }, 1733208);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16, 39, 16, 39, 16, 39, 16, 39, 16, 39 }, 1733210);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 172, 13, 172, 13, 172, 13, 172, 13, 40, 15, 164, 16, 32, 18, 136, 19, 136, 19, 136, 19, 136, 19, 136, 19, 136, 19 }, 1733374);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 228, 12, 228, 12, 228, 12, 228, 12, 96, 14, 230, 15, 78, 17, 192, 18, 192, 18, 192, 18, 192, 18, 192, 18, 192, 18 }, 1733476);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 28, 37, 28, 37, 28, 37, 28, 37, 28, 37, 25 }, 1733516);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 228, 12, 228, 12, 228, 12, 228, 12, 96, 14, 230, 15, 78, 17, 192, 18, 192, 18, 192, 18, 192, 18, 192, 18, 192, 18, 56, 255, 56, 255, 56, 255, 56, 255, 56, 255, 56, 255, 56, 255, 56, 255, 56, 255, 56, 255, 56, 255, 56, 255, 250 }, 1733680);
            }
            return validationEgrInFile;
        }
        public override async Task<bool> checkFileForDpf()
        {
            bool validationEgrInFile = false; if (ToolBox.array.Length > 0) { }
            return validationEgrInFile;

        }
        public override async Task<bool> checkFileForTva()
        {
            bool validationEgrInFile = false; if (ToolBox.array.Length > 0) { }
            return validationEgrInFile;
        }

        public override async Task<bool> checkFileForLamda()
        {
            bool validationEgrInFile = false; if (ToolBox.array.Length > 0) { }
            return validationEgrInFile;
        }

        public override async Task<bool> checkFileForFlaps()
        {
            bool validationEgrInFile = false; if (ToolBox.array.Length > 0) { }
            return validationEgrInFile;
        }

        public override async Task<bool> checkFileForStartStop()
        {
            bool validationEgrInFile = false; if (ToolBox.array.Length > 0) { }
            return validationEgrInFile;
        }

        public override async Task<bool> checkFileForAdBlue()
        {
            bool validationEgrInFile = false; if (ToolBox.array.Length > 0) { }
            return validationEgrInFile;
        }

        public override async Task<bool> checkFileForReadiness()
        {
            bool validationEgrInFile = false; if (ToolBox.array.Length > 0) { }
            return validationEgrInFile;
        }

        public override async Task<bool> checkFileForImmo()
        {
            bool validationEgrInFile = false; if (ToolBox.array.Length > 0) { }
            return validationEgrInFile;
        }

        public override async Task<bool> checkFileForSpecialI()
        {
            bool validationEgrInFile = false; if (ToolBox.array.Length > 0) { }
            return validationEgrInFile;
        }

        public override async Task<bool> checkFileForSpecialII()
        {
            bool validationEgrInFile = false; if (ToolBox.array.Length > 0) { }
            return validationEgrInFile;
        }

        public override async Task<bool> checkFileForSpecialIII()
        {
            bool validationEgrInFile = false; if (ToolBox.array.Length > 0) { }
            return validationEgrInFile;
        }

        public override void egrOffSolution()
        {
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 136, 138, 19, 32, 3, 3 },
         new byte[] { 135, 130, 24, 128, 6, 5 }, 98050, 98055, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 254 },
             new byte[] { 7 }, 98061, 98061, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 118 },
             new byte[] { 117 }, 98067, 98067, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 101, 32 },
             new byte[] { 96, 7 }, 98069, 98070, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 32, 51, 39 },
             new byte[] { 33, 65, 24 }, 98073, 98075, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 175, 180, 30, 199, 193, 7, 109, 8, 177, 156, 162, 240, 51, 217, 27, 85, 205, 120, 157, 229, 175, 180, 30, 199, 193, 7, 109, 8, 177, 156, 162, 240, 51, 217, 27, 85, 205, 120, 157, 229 },
             new byte[] { 82, 30, 92, 45, 154, 201, 51, 133, 149, 47, 121, 199, 127, 22, 153, 255, 84, 54, 245, 9, 82, 30, 92, 45, 154, 201, 51, 133, 149, 47, 121, 199, 127, 22, 153, 255, 84, 54, 245, 9 }, 98080, 98119, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 107, 95, 221, 21, 182, 145, 30, 130, 192, 174, 51, 11, 129, 180, 39, 57, 211, 73, 199, 148, 211, 194, 189, 65 },
             new byte[] { 139, 31, 198, 48, 114, 68, 26, 216, 44, 90, 0, 152, 154, 51, 204, 91, 154, 203, 19, 110, 160, 131, 151, 4 }, 98140, 98163, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 172, 13, 172, 13, 172, 13, 172, 13, 40, 15, 164, 16, 32, 18, 136, 19, 136, 19, 136, 19, 136, 19, 136, 19, 136, 19, 200 },
             new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, 1733170, 1733196, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 200 },
             new byte[] { 0 }, 1733198, 1733198, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 200 },
             new byte[] { 0 }, 1733200, 1733200, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 200 },
             new byte[] { 0 }, 1733202, 1733202, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 200 },
             new byte[] { 0 }, 1733204, 1733204, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 200 },
             new byte[] { 0 }, 1733206, 1733206, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 200 },
             new byte[] { 0 }, 1733208, 1733208, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16, 39, 16, 39, 16, 39, 16, 39, 16, 39 },
             new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, 1733210, 1733219, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 172, 13, 172, 13, 172, 13, 172, 13, 40, 15, 164, 16, 32, 18, 136, 19, 136, 19, 136, 19, 136, 19, 136, 19, 136, 19 },
             new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, 1733374, 1733399, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 228, 12, 228, 12, 228, 12, 228, 12, 96, 14, 230, 15, 78, 17, 192, 18, 192, 18, 192, 18, 192, 18, 192, 18, 192, 18 },
             new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, 1733476, 1733501, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 28, 37, 28, 37, 28, 37, 28, 37, 28, 37, 25 },
             new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, 1733516, 1733526, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 228, 12, 228, 12, 228, 12, 228, 12, 96, 14, 230, 15, 78, 17, 192, 18, 192, 18, 192, 18, 192, 18, 192, 18, 192, 18, 56, 255, 56, 255, 56, 255, 56, 255, 56, 255, 56, 255, 56, 255, 56, 255, 56, 255, 56, 255, 56, 255, 56, 255, 250 },
             new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, 1733680, 1733730, "Found egr map...Delete map");
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