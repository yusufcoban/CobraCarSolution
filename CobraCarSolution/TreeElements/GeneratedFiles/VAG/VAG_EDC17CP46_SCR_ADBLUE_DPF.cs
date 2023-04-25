using ToolBoxNameSpace;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace CobraCarSolution.TreeElements.VAG
{
    class VAG_EDC17CP46 : MenuItem, ITreeItem
    {
        public VAG_EDC17CP46()
        {
            Title = "EDC17CP46";
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

            }
            return validationEgrInFile;
        }
        public override async Task<bool> checkFileForDpf()
        {
            bool validationEgrInFile = true;
            //Algo for checking dpf solution
            if (ToolBox.array.Length > 0)
            {
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 11 }, 137970);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 10, 3, 9, 9, 9 }, 137996);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 9, 9 }, 138003);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 3, 3 }, 138026);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 1 }, 138029);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 10 }, 138041);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 3 }, 138292);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 3, 3, 3, 3 }, 138294);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 3, 3, 3, 3, 3, 3, 3, 3, 3, 3 }, 138309);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 3 }, 138321);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 3, 3 }, 138426);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 11, 3, 11, 11, 11, 11, 11, 11, 11, 3, 11, 11, 11, 11 }, 138522);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 3 }, 138575);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 3, 3 }, 138580);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 9, 9 }, 138587);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 9 }, 138590);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 3, 3 }, 138600);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 9, 3, 3 }, 138604);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 3, 3 }, 138610);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 3 }, 138736);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 3 }, 138832);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 11 }, 138844);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 3, 3 }, 138868);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 1, 1, 1, 1, 1, 1 }, 138876);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 10 }, 138899);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 3, 3 }, 138926);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 2, 2 }, 138967);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 2, 2 }, 138970);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 9 }, 139028);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 9 }, 139030);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 9, 0, 9, 0, 9, 0 }, 173968);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 0, 0 }, 174026);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 241, 13 }, 174054);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 253, 3 }, 174556);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 253, 3, 253, 3, 253, 3, 253, 3 }, 174560);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 253, 2, 253, 2, 253, 2, 253, 2, 253, 2, 253, 2, 253, 2, 253, 2, 252, 3, 252, 3 }, 174590);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 253, 2 }, 174614);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 0, 0, 0, 0 }, 174824);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 0, 0, 0, 0 }, 175146);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 253, 3, 253, 3 }, 175166);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 253, 3 }, 175172);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 252, 3 }, 175192);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 252, 3 }, 175446);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 252, 3 }, 175710);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 77, 3, 77, 3 }, 175824);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 33, 0, 33, 0 }, 175912);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 32, 0 }, 176028);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 32, 0 }, 176032);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 1 }, 261334);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 1, 1, 1 }, 261337);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 1, 1, 1, 1, 1, 1 }, 261341);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 1 }, 355887);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 246, 2, 93, 97 }, 365984);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 246, 2, 93, 97, 246, 2 }, 365992);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 139, 57 }, 366144);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 139, 57 }, 366152);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 139, 57 }, 366156);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 1, 1 }, 437251);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 42, 255, 33, 4, 234, 3, 192, 95 }, 445246);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 1 }, 445388);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 5, 1 }, 445390);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 2 }, 482758);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 232, 3 }, 482762);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 156, 255, 1 }, 482766);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 7 }, 482771);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 1, 100, 3, 14 }, 482773);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 14, 11 }, 482779);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 15, 1 }, 482782);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 1, 1, 1 }, 482785);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 1 }, 482789);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 0 }, 506193);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 0 }, 506195);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 0, 0 }, 506203);
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
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 11 }, 137970);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 10, 3, 9, 9, 9 }, 137996);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 9, 9 }, 138003);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 3, 3 }, 138026);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 1 }, 138029);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 10 }, 138041);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 3 }, 138292);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 3, 3, 3, 3 }, 138294);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 3, 3, 3, 3, 3, 3, 3, 3, 3, 3 }, 138309);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 3 }, 138321);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 3, 3 }, 138426);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 11, 3, 11, 11, 11, 11, 11, 11, 11, 3, 11, 11, 11, 11 }, 138522);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 3 }, 138575);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 3, 3 }, 138580);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 9, 9 }, 138587);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 9 }, 138590);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 3, 3 }, 138600);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 9, 3, 3 }, 138604);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 3, 3 }, 138610);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 3 }, 138736);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 3 }, 138832);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 11 }, 138844);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 3, 3 }, 138868);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 1, 1, 1, 1, 1, 1 }, 138876);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 10 }, 138899);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 3, 3 }, 138926);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 2, 2 }, 138967);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 2, 2 }, 138970);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 9 }, 139028);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 9 }, 139030);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 9, 0, 9, 0, 9, 0 }, 173968);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 0, 0 }, 174026);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 241, 13 }, 174054);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 253, 3 }, 174556);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 253, 3, 253, 3, 253, 3, 253, 3 }, 174560);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 253, 2, 253, 2, 253, 2, 253, 2, 253, 2, 253, 2, 253, 2, 253, 2, 252, 3, 252, 3 }, 174590);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 253, 2 }, 174614);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 0, 0, 0, 0 }, 174824);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 0, 0, 0, 0 }, 175146);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 253, 3, 253, 3 }, 175166);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 253, 3 }, 175172);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 252, 3 }, 175192);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 252, 3 }, 175446);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 252, 3 }, 175710);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 77, 3, 77, 3 }, 175824);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 33, 0, 33, 0 }, 175912);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 32, 0 }, 176028);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 32, 0 }, 176032);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 1 }, 261334);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 1, 1, 1 }, 261337);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 1, 1, 1, 1, 1, 1 }, 261341);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 1 }, 355887);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 246, 2, 93, 97 }, 365984);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 246, 2, 93, 97, 246, 2 }, 365992);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 139, 57 }, 366144);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 139, 57 }, 366152);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 139, 57 }, 366156);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 1, 1 }, 437251);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 42, 255, 33, 4, 234, 3, 192, 95 }, 445246);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 1 }, 445388);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 5, 1 }, 445390);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 2 }, 482758);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 232, 3 }, 482762);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 156, 255, 1 }, 482766);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 7 }, 482771);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 1, 100, 3, 14 }, 482773);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 14, 11 }, 482779);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 15, 1 }, 482782);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 1, 1, 1 }, 482785);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 1 }, 482789);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 0 }, 506193);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 0 }, 506195);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 0, 0 }, 506203);
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

            base.egrOffSolution();
        }
        public override void dpfOffSolution()
        {
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 11 },
         new byte[] { 0 }, 137970, 137970, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 10, 3, 9, 9, 9 },
             new byte[] { 0, 0, 0, 0, 0 }, 137996, 138000, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 9, 9 },
             new byte[] { 0, 0 }, 138003, 138004, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 3, 3 },
             new byte[] { 0, 0 }, 138026, 138027, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 1 },
             new byte[] { 0 }, 138029, 138029, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 10 },
             new byte[] { 0 }, 138041, 138041, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 3 },
             new byte[] { 0 }, 138292, 138292, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 3, 3, 3, 3 },
             new byte[] { 0, 0, 0, 0 }, 138294, 138297, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 3, 3, 3, 3, 3, 3, 3, 3, 3, 3 },
             new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, 138309, 138318, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 3 },
             new byte[] { 0 }, 138321, 138321, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 3, 3 },
             new byte[] { 0, 0 }, 138426, 138427, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 11, 3, 11, 11, 11, 11, 11, 11, 11, 3, 11, 11, 11, 11 },
             new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, 138522, 138535, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 3 },
             new byte[] { 0 }, 138575, 138575, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 3, 3 },
             new byte[] { 0, 0 }, 138580, 138581, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 9, 9 },
             new byte[] { 0, 0 }, 138587, 138588, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 9 },
             new byte[] { 0 }, 138590, 138590, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 3, 3 },
             new byte[] { 0, 0 }, 138600, 138601, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 9, 3, 3 },
             new byte[] { 0, 0, 0 }, 138604, 138606, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 3, 3 },
             new byte[] { 0, 0 }, 138610, 138611, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 3 },
             new byte[] { 0 }, 138736, 138736, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 3 },
             new byte[] { 0 }, 138832, 138832, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 11 },
             new byte[] { 0 }, 138844, 138844, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 3, 3 },
             new byte[] { 0, 0 }, 138868, 138869, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 1, 1, 1, 1, 1, 1 },
             new byte[] { 0, 0, 0, 0, 0, 0 }, 138876, 138881, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 10 },
             new byte[] { 0 }, 138899, 138899, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 3, 3 },
             new byte[] { 0, 0 }, 138926, 138927, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 2, 2 },
             new byte[] { 0, 0 }, 138967, 138968, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 2, 2 },
             new byte[] { 0, 0 }, 138970, 138971, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 9 },
             new byte[] { 0 }, 139028, 139028, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 9 },
             new byte[] { 0 }, 139030, 139030, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 9, 0, 9, 0, 9, 0 },
             new byte[] { 255, 255, 255, 255, 255, 255 }, 173968, 173973, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 0, 0 },
             new byte[] { 255, 255 }, 174026, 174027, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 241, 13 },
             new byte[] { 255, 255 }, 174054, 174055, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 253, 3 },
             new byte[] { 255, 255 }, 174556, 174557, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 253, 3, 253, 3, 253, 3, 253, 3 },
             new byte[] { 255, 255, 255, 255, 255, 255, 255, 255 }, 174560, 174567, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 253, 2, 253, 2, 253, 2, 253, 2, 253, 2, 253, 2, 253, 2, 253, 2, 252, 3, 252, 3 },
             new byte[] { 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255 }, 174590, 174609, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 253, 2 },
             new byte[] { 255, 255 }, 174614, 174615, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 0, 0, 0, 0 },
             new byte[] { 255, 255, 255, 255 }, 174824, 174827, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 0, 0, 0, 0 },
             new byte[] { 255, 255, 255, 255 }, 175146, 175149, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 253, 3, 253, 3 },
             new byte[] { 255, 255, 255, 255 }, 175166, 175169, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 253, 3 },
             new byte[] { 255, 255 }, 175172, 175173, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 252, 3 },
             new byte[] { 255, 255 }, 175192, 175193, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 252, 3 },
             new byte[] { 255, 255 }, 175446, 175447, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 252, 3 },
             new byte[] { 255, 255 }, 175710, 175711, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 77, 3, 77, 3 },
             new byte[] { 255, 255, 255, 255 }, 175824, 175827, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 33, 0, 33, 0 },
             new byte[] { 255, 255, 255, 255 }, 175912, 175915, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 32, 0 },
             new byte[] { 255, 255 }, 176028, 176029, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 32, 0 },
             new byte[] { 255, 255 }, 176032, 176033, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 1 },
             new byte[] { 0 }, 261334, 261334, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 1, 1, 1 },
             new byte[] { 0, 0, 0 }, 261337, 261339, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 1, 1, 1, 1, 1, 1 },
             new byte[] { 0, 0, 0, 0, 0, 0 }, 261341, 261346, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 1 },
             new byte[] { 0 }, 355887, 355887, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 246, 2, 93, 97 },
             new byte[] { 0, 128, 255, 127 }, 365984, 365987, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 246, 2, 93, 97, 246, 2 },
             new byte[] { 0, 128, 255, 127, 0, 128 }, 365992, 365997, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 139, 57 },
             new byte[] { 171, 10 }, 366144, 366145, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 139, 57 },
             new byte[] { 171, 10 }, 366152, 366153, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 139, 57 },
             new byte[] { 171, 10 }, 366156, 366157, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 1, 1 },
             new byte[] { 0, 0 }, 437251, 437252, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 42, 255, 33, 4, 234, 3, 192, 95 },
             new byte[] { 0, 0, 0, 0, 128, 0, 255, 127 }, 445246, 445253, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 1 },
             new byte[] { 0 }, 445388, 445388, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 5, 1 },
             new byte[] { 0, 0 }, 445390, 445391, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 2 },
             new byte[] { 0 }, 482758, 482758, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 232, 3 },
             new byte[] { 0, 0 }, 482762, 482763, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 156, 255, 1 },
             new byte[] { 0, 0, 0 }, 482766, 482768, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 7 },
             new byte[] { 0 }, 482771, 482771, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 1, 100, 3, 14 },
             new byte[] { 0, 0, 0, 0 }, 482773, 482776, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 14, 11 },
             new byte[] { 0, 0 }, 482779, 482780, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 15, 1 },
             new byte[] { 0, 0 }, 482782, 482783, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 1, 1, 1 },
             new byte[] { 0, 0, 0 }, 482785, 482787, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 1 },
             new byte[] { 0 }, 482789, 482789, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 0 },
             new byte[] { 1 }, 506193, 506193, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 0 },
             new byte[] { 1 }, 506195, 506195, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 0, 0 },
             new byte[] { 1, 1 }, 506203, 506204, "Found dpf map...Delete map");
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
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 11 },
         new byte[] { 0 }, 137970, 137970, "Found startstop map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 10, 3, 9, 9, 9 },
             new byte[] { 0, 0, 0, 0, 0 }, 137996, 138000, "Found startstop map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 9, 9 },
             new byte[] { 0, 0 }, 138003, 138004, "Found startstop map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 3, 3 },
             new byte[] { 0, 0 }, 138026, 138027, "Found startstop map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 1 },
             new byte[] { 0 }, 138029, 138029, "Found startstop map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 10 },
             new byte[] { 0 }, 138041, 138041, "Found startstop map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 3 },
             new byte[] { 0 }, 138292, 138292, "Found startstop map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 3, 3, 3, 3 },
             new byte[] { 0, 0, 0, 0 }, 138294, 138297, "Found startstop map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 3, 3, 3, 3, 3, 3, 3, 3, 3, 3 },
             new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, 138309, 138318, "Found startstop map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 3 },
             new byte[] { 0 }, 138321, 138321, "Found startstop map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 3, 3 },
             new byte[] { 0, 0 }, 138426, 138427, "Found startstop map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 11, 3, 11, 11, 11, 11, 11, 11, 11, 3, 11, 11, 11, 11 },
             new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, 138522, 138535, "Found startstop map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 3 },
             new byte[] { 0 }, 138575, 138575, "Found startstop map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 3, 3 },
             new byte[] { 0, 0 }, 138580, 138581, "Found startstop map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 9, 9 },
             new byte[] { 0, 0 }, 138587, 138588, "Found startstop map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 9 },
             new byte[] { 0 }, 138590, 138590, "Found startstop map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 3, 3 },
             new byte[] { 0, 0 }, 138600, 138601, "Found startstop map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 9, 3, 3 },
             new byte[] { 0, 0, 0 }, 138604, 138606, "Found startstop map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 3, 3 },
             new byte[] { 0, 0 }, 138610, 138611, "Found startstop map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 3 },
             new byte[] { 0 }, 138736, 138736, "Found startstop map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 3 },
             new byte[] { 0 }, 138832, 138832, "Found startstop map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 11 },
             new byte[] { 0 }, 138844, 138844, "Found startstop map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 3, 3 },
             new byte[] { 0, 0 }, 138868, 138869, "Found startstop map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 1, 1, 1, 1, 1, 1 },
             new byte[] { 0, 0, 0, 0, 0, 0 }, 138876, 138881, "Found startstop map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 10 },
             new byte[] { 0 }, 138899, 138899, "Found startstop map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 3, 3 },
             new byte[] { 0, 0 }, 138926, 138927, "Found startstop map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 2, 2 },
             new byte[] { 0, 0 }, 138967, 138968, "Found startstop map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 2, 2 },
             new byte[] { 0, 0 }, 138970, 138971, "Found startstop map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 9 },
             new byte[] { 0 }, 139028, 139028, "Found startstop map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 9 },
             new byte[] { 0 }, 139030, 139030, "Found startstop map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 9, 0, 9, 0, 9, 0 },
             new byte[] { 255, 255, 255, 255, 255, 255 }, 173968, 173973, "Found startstop map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 0, 0 },
             new byte[] { 255, 255 }, 174026, 174027, "Found startstop map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 241, 13 },
             new byte[] { 255, 255 }, 174054, 174055, "Found startstop map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 253, 3 },
             new byte[] { 255, 255 }, 174556, 174557, "Found startstop map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 253, 3, 253, 3, 253, 3, 253, 3 },
             new byte[] { 255, 255, 255, 255, 255, 255, 255, 255 }, 174560, 174567, "Found startstop map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 253, 2, 253, 2, 253, 2, 253, 2, 253, 2, 253, 2, 253, 2, 253, 2, 252, 3, 252, 3 },
             new byte[] { 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255 }, 174590, 174609, "Found startstop map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 253, 2 },
             new byte[] { 255, 255 }, 174614, 174615, "Found startstop map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 0, 0, 0, 0 },
             new byte[] { 255, 255, 255, 255 }, 174824, 174827, "Found startstop map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 0, 0, 0, 0 },
             new byte[] { 255, 255, 255, 255 }, 175146, 175149, "Found startstop map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 253, 3, 253, 3 },
             new byte[] { 255, 255, 255, 255 }, 175166, 175169, "Found startstop map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 253, 3 },
             new byte[] { 255, 255 }, 175172, 175173, "Found startstop map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 252, 3 },
             new byte[] { 255, 255 }, 175192, 175193, "Found startstop map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 252, 3 },
             new byte[] { 255, 255 }, 175446, 175447, "Found startstop map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 252, 3 },
             new byte[] { 255, 255 }, 175710, 175711, "Found startstop map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 77, 3, 77, 3 },
             new byte[] { 255, 255, 255, 255 }, 175824, 175827, "Found startstop map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 33, 0, 33, 0 },
             new byte[] { 255, 255, 255, 255 }, 175912, 175915, "Found startstop map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 32, 0 },
             new byte[] { 255, 255 }, 176028, 176029, "Found startstop map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 32, 0 },
             new byte[] { 255, 255 }, 176032, 176033, "Found startstop map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 1 },
             new byte[] { 0 }, 261334, 261334, "Found startstop map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 1, 1, 1 },
             new byte[] { 0, 0, 0 }, 261337, 261339, "Found startstop map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 1, 1, 1, 1, 1, 1 },
             new byte[] { 0, 0, 0, 0, 0, 0 }, 261341, 261346, "Found startstop map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 1 },
             new byte[] { 0 }, 355887, 355887, "Found startstop map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 246, 2, 93, 97 },
             new byte[] { 0, 128, 255, 127 }, 365984, 365987, "Found startstop map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 246, 2, 93, 97, 246, 2 },
             new byte[] { 0, 128, 255, 127, 0, 128 }, 365992, 365997, "Found startstop map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 139, 57 },
             new byte[] { 171, 10 }, 366144, 366145, "Found startstop map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 139, 57 },
             new byte[] { 171, 10 }, 366152, 366153, "Found startstop map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 139, 57 },
             new byte[] { 171, 10 }, 366156, 366157, "Found startstop map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 1, 1 },
             new byte[] { 0, 0 }, 437251, 437252, "Found startstop map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 42, 255, 33, 4, 234, 3, 192, 95 },
             new byte[] { 0, 0, 0, 0, 128, 0, 255, 127 }, 445246, 445253, "Found startstop map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 1 },
             new byte[] { 0 }, 445388, 445388, "Found startstop map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 5, 1 },
             new byte[] { 0, 0 }, 445390, 445391, "Found startstop map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 2 },
             new byte[] { 0 }, 482758, 482758, "Found startstop map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 232, 3 },
             new byte[] { 0, 0 }, 482762, 482763, "Found startstop map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 156, 255, 1 },
             new byte[] { 0, 0, 0 }, 482766, 482768, "Found startstop map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 7 },
             new byte[] { 0 }, 482771, 482771, "Found startstop map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 1, 100, 3, 14 },
             new byte[] { 0, 0, 0, 0 }, 482773, 482776, "Found startstop map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 14, 11 },
             new byte[] { 0, 0 }, 482779, 482780, "Found startstop map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 15, 1 },
             new byte[] { 0, 0 }, 482782, 482783, "Found startstop map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 1, 1, 1 },
             new byte[] { 0, 0, 0 }, 482785, 482787, "Found startstop map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 1 },
             new byte[] { 0 }, 482789, 482789, "Found startstop map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 0 },
             new byte[] { 1 }, 506193, 506193, "Found startstop map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 0 },
             new byte[] { 1 }, 506195, 506195, "Found startstop map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 0, 0 },
             new byte[] { 1, 1 }, 506203, 506204, "Found startstop map...Delete map");

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