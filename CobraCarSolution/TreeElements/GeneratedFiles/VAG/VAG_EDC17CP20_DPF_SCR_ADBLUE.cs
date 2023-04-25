using ToolBoxNameSpace;

namespace CobraCarSolution.TreeElements.VAG
{
    class VAG_EDC17CP20 : MenuItem, ITreeItem
    {
        public VAG_EDC17CP20()
        {
            Title = "EDC17CP20";
            IsSolutionItem = true;
            hasDtcSolution = false;
            hasEgrSolution = false;
            hasTVASolution = false;
            hasFileCheckSize = false;
            hasDpfSolution = true;
            hasLamdaSolution = false;
            hasFLAPSSolution = false;
            hasStartStopSolution = false;
            hasADBlueSolution = true;
            hasReadinessSolution = false;
            hasImmoSolution = false;
            hasSpecialISolution = true;
            hasSpecialIISolution = false;
            hasSpecialIIISolution = false;
            specialISolutionDescription = "SCR OFF";
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

            }
            return validationEgrInFile;
        }
        public override async Task<bool> checkFileForDpf()
        {
            bool validationEgrInFile = true;
            //Algo for checking dpf solution
            if (ToolBox.array.Length > 0)
            {
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 4 }, 1596705);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 29, 29 }, 1596889);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 3 }, 1596978);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 1, 1 }, 1998663);
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
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 4 }, 1596705);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 29, 29 }, 1596889);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 3 }, 1596978);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 1, 1 }, 1998663);
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
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 4 }, 1596705);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 29, 29 }, 1596889);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 3 }, 1596978);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 1, 1 }, 1998663);
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

            base.egrOffSolution();
        }
        public override void dpfOffSolution()
        {
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 4 },
         new byte[] { 0 }, 1596705, 1596705, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 29, 29 },
             new byte[] { 0, 0 }, 1596889, 1596890, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 3 },
             new byte[] { 0 }, 1596978, 1596978, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 1, 1 },
             new byte[] { 0, 0 }, 1998663, 1998664, "Found dpf map...Delete map");
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
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 4 },
         new byte[] { 0 }, 1596705, 1596705, "Found startstop map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 29, 29 },
             new byte[] { 0, 0 }, 1596889, 1596890, "Found startstop map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 3 },
             new byte[] { 0 }, 1596978, 1596978, "Found startstop map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 1, 1 },
             new byte[] { 0, 0 }, 1998663, 1998664, "Found startstop map...Delete map");

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
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 4 },
         new byte[] { 0 }, 1596705, 1596705, "Found immo map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 29, 29 },
             new byte[] { 0, 0 }, 1596889, 1596890, "Found immo map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 3 },
             new byte[] { 0 }, 1596978, 1596978, "Found immo map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 1, 1 },
             new byte[] { 0, 0 }, 1998663, 1998664, "Found immo map...Delete map");

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