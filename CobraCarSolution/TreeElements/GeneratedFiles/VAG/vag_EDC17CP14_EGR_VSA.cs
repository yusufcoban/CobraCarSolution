using ToolBoxNameSpace;

namespace CobraCarSolution.TreeElements.VAG
{
    class vag_EDC17CP14 : MenuItem, ITreeItem
    {
        public vag_EDC17CP14()
        {
            Title = "EDC17CP14";
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
            hasSpecialISolution = true;
            hasSpecialIISolution = false;
            hasSpecialIIISolution = false;
            specialISolutionDescription = "VSA OFF";
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
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 3, 3 }, 1714279);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 3, 3 }, 1714621);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 3, 3, 3, 3, 3 }, 1714624);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 3, 3 }, 1714630);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 3, 3, 3, 3 }, 1714633);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 3, 3, 3, 3 }, 1714760);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 3, 3, 3, 3, 3, 3, 3, 3, 3, 3 }, 1714766);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 3, 3, 3, 3 }, 1714778);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3 }, 1714784);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 3, 3 }, 1714939);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 1 }, 1715176);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 4, 4, 3, 3, 3 }, 1715190);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 3, 3, 3, 3, 4, 4 }, 1715249);
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
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 3, 3 }, 1714279);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 3, 3 }, 1714621);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 3, 3, 3, 3, 3 }, 1714624);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 3, 3 }, 1714630);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 3, 3, 3, 3 }, 1714633);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 3, 3, 3, 3 }, 1714760);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 3, 3, 3, 3, 3, 3, 3, 3, 3, 3 }, 1714766);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 3, 3, 3, 3 }, 1714778);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3 }, 1714784);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 3, 3 }, 1714939);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 1 }, 1715176);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 4, 4, 3, 3, 3 }, 1715190);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 3, 3, 3, 3, 4, 4 }, 1715249);
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
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 3, 3 },
         new byte[] { 0, 0 }, 1714279, 1714280, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 3, 3 },
             new byte[] { 0, 0 }, 1714621, 1714622, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 3, 3, 3, 3, 3 },
             new byte[] { 0, 0, 0, 0, 0 }, 1714624, 1714628, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 3, 3 },
             new byte[] { 0, 0 }, 1714630, 1714631, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 3, 3, 3, 3 },
             new byte[] { 0, 0, 0, 0 }, 1714633, 1714636, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 3, 3, 3, 3 },
             new byte[] { 0, 0, 0, 0 }, 1714760, 1714763, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 3, 3, 3, 3, 3, 3, 3, 3, 3, 3 },
             new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, 1714766, 1714775, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 3, 3, 3, 3 },
             new byte[] { 0, 0, 0, 0 }, 1714778, 1714781, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3 },
             new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, 1714784, 1714797, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 3, 3 },
             new byte[] { 0, 0 }, 1714939, 1714940, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 1 },
             new byte[] { 0 }, 1715176, 1715176, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 4, 4, 3, 3, 3 },
             new byte[] { 0, 0, 0, 0, 0 }, 1715190, 1715194, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 3, 3, 3, 3, 4, 4 },
             new byte[] { 0, 0, 0, 0, 0, 0 }, 1715249, 1715254, "Found egr map...Delete map");
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
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 3, 3 },
         new byte[] { 0, 0 }, 1714279, 1714280, "Found immo map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 3, 3 },
             new byte[] { 0, 0 }, 1714621, 1714622, "Found immo map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 3, 3, 3, 3, 3 },
             new byte[] { 0, 0, 0, 0, 0 }, 1714624, 1714628, "Found immo map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 3, 3 },
             new byte[] { 0, 0 }, 1714630, 1714631, "Found immo map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 3, 3, 3, 3 },
             new byte[] { 0, 0, 0, 0 }, 1714633, 1714636, "Found immo map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 3, 3, 3, 3 },
             new byte[] { 0, 0, 0, 0 }, 1714760, 1714763, "Found immo map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 3, 3, 3, 3, 3, 3, 3, 3, 3, 3 },
             new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, 1714766, 1714775, "Found immo map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 3, 3, 3, 3 },
             new byte[] { 0, 0, 0, 0 }, 1714778, 1714781, "Found immo map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3 },
             new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, 1714784, 1714797, "Found immo map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 3, 3 },
             new byte[] { 0, 0 }, 1714939, 1714940, "Found immo map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 1 },
             new byte[] { 0 }, 1715176, 1715176, "Found immo map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 4, 4, 3, 3, 3 },
             new byte[] { 0, 0, 0, 0, 0 }, 1715190, 1715194, "Found immo map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 3, 3, 3, 3, 4, 4 },
             new byte[] { 0, 0, 0, 0, 0, 0 }, 1715249, 1715254, "Found immo map...Delete map");

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