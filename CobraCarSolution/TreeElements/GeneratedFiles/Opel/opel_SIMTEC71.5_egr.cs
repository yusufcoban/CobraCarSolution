using ToolBoxNameSpace;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace CobraCarSolution.TreeElements.VAG
{
    class opel_SIMTEC71_5 : MenuItem, ITreeItem
    {
        public opel_SIMTEC71_5()
        {
            Title = "SIMTEC71_5";
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
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 150, 153, 149, 140, 123, 103 }, 470394);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 153, 154, 150, 141, 126, 107 }, 470406);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 154, 154, 151, 142, 129, 110 }, 470418);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 153, 154, 151, 142, 132, 115 }, 470430);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 151, 151, 148, 140, 132, 116 }, 470442);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 146, 144, 141, 134, 127, 112 }, 470454);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 149, 148, 144, 136, 128, 111 }, 470466);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 156, 156, 152, 144, 136, 119 }, 470478);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 160, 159, 156, 148, 140, 124 }, 470490);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 161, 159, 155, 148, 141, 127 }, 470502);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 128, 128, 127, 127, 127, 127, 127 }, 472867);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 130, 127, 127, 127, 127, 129, 129 }, 472879);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 134, 128, 126, 125, 124, 123, 123 }, 472891);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 134, 126, 123, 123, 122, 122, 122 }, 472903);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 126, 131, 126, 124, 123, 125, 127 }, 472915);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 128, 124, 129, 127, 127, 127, 127 }, 472927);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 205, 164, 172, 171, 108, 156, 205, 140, 68, 148, 0, 136, 205, 124, 102, 118, 0, 112, 12, 108, 94, 106, 82, 104, 168, 102, 102, 102, 195, 101, 195, 101, 205, 164, 172, 171, 108, 156, 205, 140, 68, 148, 0, 136, 0, 152, 137, 144, 0, 136, 215, 131, 92, 127, 205, 124, 225, 122, 61, 122, 88, 121, 246, 120, 205, 164, 172, 171, 108, 156, 205, 140, 68, 148, 0, 136, 0, 152, 137, 144, 0, 136, 215, 131, 54, 150, 99, 147, 66, 146, 33, 145, 111, 143, 111, 143 }, 477092);
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
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 150, 153, 149, 140, 123, 103 },
         new byte[] { 156, 160, 157, 148, 131, 111 }, 470394, 470399, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 153, 154, 150, 141, 126, 107 },
             new byte[] { 159, 161, 158, 150, 135, 115 }, 470406, 470411, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 154, 154, 151, 142, 129, 110 },
             new byte[] { 160, 161, 159, 151, 138, 118 }, 470418, 470423, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 153, 154, 151, 142, 132, 115 },
             new byte[] { 159, 161, 159, 151, 141, 124 }, 470430, 470435, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 151, 151, 148, 140, 132, 116 },
             new byte[] { 157, 158, 156, 148, 141, 125 }, 470442, 470447, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 146, 144, 141, 134, 127, 112 },
             new byte[] { 151, 150, 148, 142, 136, 120 }, 470454, 470459, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 149, 148, 144, 136, 128, 111 },
             new byte[] { 154, 155, 152, 144, 137, 119 }, 470466, 470471, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 156, 156, 152, 144, 136, 119 },
             new byte[] { 162, 163, 160, 153, 145, 128 }, 470478, 470483, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 160, 159, 156, 148, 140, 124 },
             new byte[] { 166, 166, 164, 157, 150, 133 }, 470490, 470495, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 161, 159, 155, 148, 141, 127 },
             new byte[] { 167, 166, 163, 157, 151, 137 }, 470502, 470507, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 128, 128, 127, 127, 127, 127, 127 },
             new byte[] { 131, 131, 130, 130, 130, 130, 130 }, 472867, 472873, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 130, 127, 127, 127, 127, 129, 129 },
             new byte[] { 133, 130, 130, 130, 130, 132, 132 }, 472879, 472885, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 134, 128, 126, 125, 124, 123, 123 },
             new byte[] { 138, 131, 129, 128, 127, 126, 126 }, 472891, 472897, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 134, 126, 123, 123, 122, 122, 122 },
             new byte[] { 138, 129, 126, 126, 125, 125, 125 }, 472903, 472909, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 126, 131, 126, 124, 123, 125, 127 },
             new byte[] { 129, 134, 129, 127, 126, 128, 130 }, 472915, 472921, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 128, 124, 129, 127, 127, 127, 127 },
             new byte[] { 131, 127, 132, 130, 130, 130, 130 }, 472927, 472933, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 205, 164, 172, 171, 108, 156, 205, 140, 68, 148, 0, 136, 205, 124, 102, 118, 0, 112, 12, 108, 94, 106, 82, 104, 168, 102, 102, 102, 195, 101, 195, 101, 205, 164, 172, 171, 108, 156, 205, 140, 68, 148, 0, 136, 0, 152, 137, 144, 0, 136, 215, 131, 92, 127, 205, 124, 225, 122, 61, 122, 88, 121, 246, 120, 205, 164, 172, 171, 108, 156, 205, 140, 68, 148, 0, 136, 0, 152, 137, 144, 0, 136, 215, 131, 54, 150, 99, 147, 66, 146, 33, 145, 111, 143, 111, 143 },
             new byte[] { 252, 177, 103, 185, 239, 168, 16, 152, 32, 160, 225, 146, 200, 134, 222, 127, 245, 120, 176, 116, 224, 114, 170, 112, 222, 110, 151, 110, 231, 109, 231, 109, 252, 177, 103, 185, 239, 168, 16, 152, 32, 160, 225, 146, 40, 164, 25, 156, 225, 146, 99, 142, 140, 137, 200, 134, 181, 132, 4, 132, 13, 131, 163, 130, 252, 177, 103, 185, 239, 168, 16, 152, 32, 160, 225, 146, 40, 164, 25, 156, 225, 146, 99, 142, 58, 162, 45, 159, 245, 157, 189, 156, 232, 154, 232, 154 }, 477092, 477187, "Found egr map...Delete map");
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