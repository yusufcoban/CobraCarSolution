using ToolBoxNameSpace;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace CobraCarSolution.TreeElements.VAG
{
    class nissan_denso : MenuItem, ITreeItem
    {
        public nissan_denso()
        {
            Title = "Denso";
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
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 10, 0, 10, 0, 10, 0, 10, 0, 10, 0, 10, 0, 10, 0, 10, 0, 10, 0, 10, 0, 10, 0, 10, 0, 10, 0, 10, 0, 8, 154, 8, 97, 8, 18, 8, 28, 8 }, 604148);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 7, 200 }, 604186);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 189 }, 604305);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 204 }, 604307);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 219, 0, 251 }, 604309);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 32 }, 604313);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 8, 231, 8, 115, 8, 22, 7, 185, 7, 129, 7, 72 }, 631132);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 8, 231, 8, 123, 8, 35, 7, 203, 7, 141, 7, 79 }, 631178);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 9, 13, 8, 128, 8, 51, 7, 218, 7, 154, 7, 85 }, 631224);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 37, 128, 45, 0 }, 637848);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 0 }, 637853);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 67, 128, 67, 128, 67, 128, 67, 128, 50, 0, 50, 0 }, 637862);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 37, 128, 45, 0, 60, 0, 63, 192 }, 637894);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 128, 67, 128 }, 637903);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 128, 67, 128, 67, 128, 67, 128, 67, 128, 50, 0, 50, 0 }, 637907);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 37, 128, 45, 0, 60, 0, 63, 192 }, 637940);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 128, 67, 128 }, 637949);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 128, 67, 128, 67, 128, 67, 128, 67, 128, 50, 0, 50, 0 }, 637953);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 37, 128, 45, 0, 60, 0, 63, 192 }, 637986);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 128, 67, 128 }, 637995);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 128, 67, 128, 67, 128, 67, 128, 67, 128, 50, 0, 50, 0 }, 637999);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 37, 128, 45, 0, 60, 0, 63, 192 }, 638032);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 128, 67, 128 }, 638041);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 128, 67, 128, 67, 128, 67, 128, 67, 128, 50, 0, 50, 0 }, 638045);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 37, 128, 45, 0 }, 638892);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 0 }, 638897);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 67, 128, 67, 128, 67, 128, 67, 128, 50, 0, 50, 0 }, 638906);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 37, 128, 45, 0, 60, 0, 63, 192 }, 638938);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 128 }, 638947);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 128 }, 638949);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 128, 67, 128, 67, 128, 67, 128, 67, 128, 50, 0, 50, 0 }, 638951);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 37, 128, 45, 0, 60, 0, 63, 192 }, 638984);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 128 }, 638993);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 128 }, 638995);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 128, 67, 128, 67, 128, 67, 128, 67, 128, 50, 0, 50, 0 }, 638997);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 37, 128, 45, 0, 60, 0, 63, 192 }, 639030);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 128 }, 639039);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 128 }, 639041);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 128, 67, 128, 67, 128, 67, 128, 67, 128, 50, 0, 50, 0 }, 639043);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 37, 128, 45, 0, 60, 0, 63, 192 }, 639076);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 128 }, 639085);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 128 }, 639087);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 128, 67, 128, 67, 128, 67, 128, 67, 128, 50, 0, 50, 0 }, 639089);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 37, 128, 45, 0 }, 639936);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 0 }, 639941);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 67, 128, 67, 128, 67, 128, 67, 128, 50, 0, 50, 0 }, 639950);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 37, 128, 45, 0, 60, 0, 63, 192 }, 639982);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 128, 67, 128 }, 639991);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 128, 67, 128, 67, 128, 67, 128, 67, 128, 50, 0, 50, 0 }, 639995);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 37, 128, 45, 0, 60, 0, 63, 192 }, 640028);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 128, 67, 128 }, 640037);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 128, 67, 128, 67, 128, 67, 128, 67, 128, 50, 0, 50, 0 }, 640041);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 37, 128, 45, 0, 60, 0, 63, 192 }, 640074);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 128, 67, 128 }, 640083);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 128, 67, 128, 67, 128, 67, 128, 67, 128, 50, 0, 50, 0 }, 640087);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 37, 128, 45, 0, 60, 0, 63, 192 }, 640120);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 128, 67, 128 }, 640129);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 128, 67, 128, 67, 128, 67, 128, 67, 128, 50, 0, 50, 0 }, 640133);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 42, 128, 45, 0, 47, 128, 50, 0, 55, 0, 60, 0 }, 640980);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 73, 192, 82, 128, 90, 0, 90, 0, 66, 128, 55, 0 }, 640994);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 47, 128, 50, 0, 52, 128, 55, 0, 60, 0, 67, 128 }, 641026);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 82, 128, 90, 0, 90, 0, 90, 0, 66, 128, 55, 0 }, 641040);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 50, 0, 55, 0, 57, 128, 62, 128, 70, 0, 75, 0 }, 641072);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 90, 0, 90, 0, 90, 0, 90, 0, 66, 128, 55, 0 }, 641086);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 55, 0, 60, 0, 67, 128, 70, 0, 75, 0, 77, 128 }, 641118);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 90, 0, 90, 0, 90, 0, 90, 0, 66, 128, 55, 0 }, 641132);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 55, 0, 60, 0, 70, 0, 73, 128, 77, 128, 77, 128 }, 641164);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 90, 0, 90, 0, 90, 0, 90, 0, 66, 128, 55, 0 }, 641178);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 42, 128, 45, 0, 47, 128, 50, 0, 55, 0, 60, 0 }, 642024);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 73, 192, 82, 128, 90, 0, 90, 0, 66, 128, 55, 0 }, 642038);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 47, 128, 50, 0, 52, 128, 55, 0, 60, 0, 67, 128 }, 642070);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 82, 128, 90, 0, 90, 0, 90, 0, 66, 128, 55, 0 }, 642084);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 50, 0, 55, 0, 57, 128, 62, 128, 70, 0, 75, 0 }, 642116);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 90, 0, 90, 0, 90, 0, 90, 0, 66, 128, 55, 0 }, 642130);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 55, 0, 60, 0, 67, 128, 70, 0, 75, 0, 77, 128 }, 642162);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 90, 0, 90, 0, 90, 0, 90, 0, 66, 128, 55, 0 }, 642176);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 55, 0, 60, 0, 70, 0, 73, 128, 77, 128, 77, 128 }, 642208);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 90, 0, 90, 0, 90, 0, 90, 0, 66, 128, 55, 0 }, 642222);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 42, 128, 45, 0, 47, 128, 50, 0, 55, 0, 60, 0 }, 643068);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 73, 192, 82, 128, 90, 0, 90, 0, 66, 128, 55, 0 }, 643082);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 47, 128, 50, 0, 52, 128, 55, 0, 60, 0, 67, 128 }, 643114);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 82, 128, 90, 0, 90, 0, 90, 0, 66, 128, 55, 0 }, 643128);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 50, 0, 55, 0, 57, 128, 62, 128, 70, 0, 75, 0 }, 643160);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 90, 0, 90, 0, 90, 0, 90, 0, 66, 128, 55, 0 }, 643174);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 55, 0, 60, 0, 67, 128, 70, 0, 75, 0, 77, 128 }, 643206);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 90, 0, 90, 0, 90, 0, 90, 0, 66, 128, 55, 0 }, 643220);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 55, 0, 60, 0, 70, 0, 73, 128, 77, 128, 77, 128 }, 643252);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 90, 0, 90, 0, 90, 0, 90, 0, 66, 128, 55, 0 }, 643266);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 45, 0, 50, 0, 52, 128, 55, 0, 60, 0, 67, 128 }, 645200);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 80, 0, 90, 0, 90, 0, 90, 0, 66, 128, 55, 0 }, 645214);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 50, 0, 55, 0, 57, 128, 62, 128, 70, 0, 75, 0 }, 645246);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 90, 0, 90, 0, 90, 0, 90, 0, 66, 128, 55, 0 }, 645260);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 55, 0, 60, 0, 67, 128, 70, 0, 75, 0, 77, 128 }, 645292);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 90, 0, 90, 0, 90, 0, 90, 0, 66, 128, 55, 0 }, 645306);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 55, 0, 60, 0, 70, 0, 73, 128, 77, 128, 77, 128 }, 645338);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 90, 0, 90, 0, 90, 0, 90, 0, 66, 128, 55, 0 }, 645352);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 55, 0, 60, 0, 70, 0, 73, 128, 77, 128, 77, 128 }, 645384);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 90, 0, 90, 0, 90, 0, 90, 0, 66, 128, 55, 0 }, 645398);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 43, 192, 43, 192, 47, 48, 56, 224, 63, 192, 65, 0, 68, 32 }, 666494);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 56, 64, 56, 64, 59, 96, 62, 208, 69, 96, 69, 96, 70, 0 }, 666530);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 62, 128, 63, 192, 65, 160, 69, 96, 70, 0, 70, 240, 71, 224 }, 666566);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 65, 160, 68, 192, 68, 192, 71, 64, 71, 224, 72, 128, 73, 112 }, 666602);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 67, 208, 70, 160, 71, 224, 72, 208, 73, 112, 74, 16, 75, 80 }, 666638);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 63, 192, 66, 224, 69, 96, 71, 224, 73, 112, 75, 0, 75, 80, 75, 160, 77, 48, 76, 224, 76, 64 }, 666670);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 66, 64, 69, 96, 71, 224, 73, 32, 74, 176, 76, 144, 76, 224, 77, 48, 79, 16, 78, 192, 78, 112, 81, 64 }, 666706);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 67, 208, 71, 224, 73, 112, 75, 0, 76, 96, 78, 112, 78, 192, 79, 16, 80, 160, 80, 160, 82, 128, 81, 64 }, 666742);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 73, 192, 74, 176, 75, 160, 76, 144, 78, 112, 79, 16, 80, 160, 81, 64, 82, 48, 82, 128, 82, 128, 81, 64 }, 666778);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 73, 192, 74, 176, 75, 160, 76, 144, 78, 112, 80, 160, 80, 160, 81, 64, 82, 48, 82, 128, 82, 128, 81, 64 }, 666814);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 73, 192, 74, 176, 75, 160, 76, 144, 78, 112, 80, 160, 80, 160, 81, 64, 82, 48, 82, 128, 82, 128, 81, 64 }, 666850);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 35, 44, 36, 102, 37, 128, 42, 41, 44, 96, 56, 61, 62, 239 }, 667566);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 43, 192, 44, 63, 47, 186, 50, 0, 58, 227, 68, 30, 67, 40 }, 667602);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 48, 192, 53, 68, 57, 186, 62, 128, 68, 192, 72, 93, 73, 180 }, 667638);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 62, 224, 68, 72, 67, 176, 69, 80, 72, 104, 73, 151, 75, 0 }, 667674);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 69, 231, 72, 17, 74, 67, 75, 41, 73, 163, 74, 209, 75, 240 }, 667710);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 0 }, 667743);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 83, 70, 87, 72, 208, 73, 112, 75, 0, 75, 80, 75, 224, 78, 0, 78, 80, 76, 232 }, 667745);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 60, 224, 70, 25, 71, 228, 73, 232, 74, 176, 76, 144, 76, 224, 78, 0, 79, 80, 80, 104, 78, 112, 81, 64 }, 667778);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 67, 208, 71, 224, 73, 112, 75, 0, 75, 240, 76, 96, 77, 16, 79 }, 667814);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 80, 160, 82, 128, 82, 128, 81, 64 }, 667830);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 73, 192, 74, 176, 75, 160, 76, 144, 78, 112, 79, 16, 80, 160, 81, 64, 82, 48, 82, 128, 82, 128, 81, 64 }, 667850);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 73, 192, 74, 176, 75, 160, 76, 144, 78, 112, 80, 160, 80, 160, 81, 64, 82, 48, 82, 128, 82, 128, 81, 64 }, 667886);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 73, 192, 74, 176, 75, 160, 76, 144, 78, 112, 80, 160, 80, 160, 81, 64, 82, 48, 82, 128, 82, 128, 81, 64 }, 667922);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 35, 44, 36, 102, 37, 128, 42, 41, 44, 96, 56, 61, 62, 239 }, 668638);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 43, 192, 44, 63, 47, 186, 50, 0, 58, 227, 68, 30, 67, 40 }, 668674);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 48, 192, 53, 68, 57, 186, 62, 128, 68, 192, 72, 93, 73, 180 }, 668710);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 62, 224, 68, 72, 67, 176, 69, 80, 72, 104, 73, 151, 75, 0 }, 668746);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 69, 231, 72, 17, 74, 67, 75, 41, 73, 163, 74, 209, 75, 240 }, 668782);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 0 }, 668815);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 83, 70, 87, 72, 208, 73, 112, 75, 0, 75, 80, 75, 224, 78, 0, 78, 80, 76, 232 }, 668817);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 60, 224, 70, 25, 71, 228, 73, 232, 74, 176, 76, 144, 76, 224, 78, 0, 79, 80, 80, 104, 78, 112, 81, 64 }, 668850);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 67, 208, 71, 224, 73, 112, 75, 0, 75, 240, 76, 96, 77, 16, 79, 16, 80, 160, 82, 128, 82, 128, 81, 64 }, 668886);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 73, 192, 74, 176, 75, 160, 76, 144, 78, 112, 79, 16, 80, 160, 81, 64, 82, 48, 82, 128, 82, 128, 81, 64 }, 668922);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 73, 192, 74, 176, 75, 160, 76, 144, 78, 112, 80, 160, 80, 160, 81, 64, 82, 48, 82, 128, 82, 128, 81, 64 }, 668958);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 73, 192, 74, 176, 75, 160, 76, 144, 78, 112, 80, 160, 80, 160, 81, 64, 82, 48, 82, 128, 82, 128, 81, 64 }, 668994);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 43, 192, 43, 192, 47, 48, 56, 224, 63, 192, 65, 0, 68, 32 }, 669710);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 56, 64, 56, 64, 59, 96, 62, 208, 69, 96, 69, 96, 70, 0 }, 669746);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 62, 128, 63, 192, 65, 160, 69, 96, 70, 0, 70, 240, 71, 224 }, 669782);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 65, 160, 68, 192, 68, 192, 71, 64, 71, 224, 72, 128, 73, 112 }, 669818);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 67, 208, 70, 160, 71, 224, 72, 208, 73, 112, 74, 16, 75, 80 }, 669854);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 63, 192, 66, 224, 69, 96, 71, 224, 73, 112, 75, 0, 75, 80, 75, 160, 77, 48, 76, 224, 76, 64 }, 669886);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 66, 64, 69, 96, 71, 224, 73, 32, 74, 176, 76, 144, 76, 224, 77, 48, 79, 16, 78, 192, 78, 112, 81, 64 }, 669922);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 67, 208, 71, 224, 73, 112, 75, 0, 76, 96, 78, 112, 78, 192, 79, 16, 80, 160, 80, 160, 82, 128, 81, 64 }, 669958);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 73, 192, 74, 176, 75, 160, 76, 144, 78, 112, 79, 16, 80, 160, 81, 64, 82, 48, 82, 128, 82, 128, 81, 64 }, 669994);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 73, 192, 74, 176, 75, 160, 76, 144, 78, 112, 80, 160, 80, 160, 81, 64, 82, 48, 82, 128, 82, 128, 81, 64 }, 670030);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 73, 192, 74, 176, 75, 160, 76, 144, 78, 112, 80, 160, 80, 160, 81, 64, 82, 48, 82, 128, 82, 128, 81, 64 }, 670066);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 56, 224, 60, 160, 60, 0, 57, 128, 56, 224, 56, 144, 56, 224 }, 670782);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 67, 128, 70, 0, 70, 160, 67, 224, 65, 64, 63, 160, 63, 64 }, 670818);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 75, 176, 76, 64, 73, 192, 71, 224, 69, 176, 67, 224, 67, 16 }, 670854);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 77, 128, 76, 64, 74, 192, 73, 32, 72, 32, 71, 80, 70, 80 }, 670890);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 77, 128, 76, 64, 76, 48, 75, 0, 74, 48, 73, 96, 72, 192 }, 670926);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 77, 128 }, 670958);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 32, 78, 32, 78, 32, 77, 48, 76, 208, 76, 48, 76, 0, 76, 64, 75, 80, 71, 224 }, 670961);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 78, 112, 78, 192, 78, 232, 79, 16, 78, 160, 78, 208, 78, 32, 77, 128, 76, 64, 75, 80, 71, 224, 68, 192 }, 670994);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 78, 112, 78, 192, 78, 232, 79, 16, 78, 232, 78, 192, 78, 32, 77, 128, 76, 64, 75, 80, 71, 224, 68, 192 }, 671030);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 78, 112, 78, 192, 78, 232, 79, 16, 78, 232, 78, 192, 78, 32, 77, 128, 76, 64, 75, 80, 71, 224, 68, 192 }, 671066);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 78, 112, 78, 192, 78, 232, 79, 16, 78, 232, 78, 192, 78, 32, 77, 128, 76, 64, 75, 80, 71, 224, 68, 192 }, 671102);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 78, 112, 78, 192, 78, 232, 79, 16, 78, 232, 78, 192, 78, 32, 77, 128, 76, 64, 75, 80, 71, 224, 68, 192 }, 671138);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 56, 224, 60, 160, 60, 0, 57, 128, 56, 224, 56, 144, 56, 224 }, 671854);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 67, 128, 70, 0, 70, 160, 67, 224, 65, 64, 63, 160, 63, 64 }, 671890);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 75, 176, 76, 64, 73, 192, 71, 224, 69, 176, 67, 224, 67, 16 }, 671926);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 77, 128, 76, 64, 74, 192, 73, 32, 72, 32, 71, 80, 70, 80 }, 671962);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 77, 128, 76, 64, 76, 48, 75, 0, 74, 48, 73, 96, 72, 192 }, 671998);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 77, 128 }, 672030);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 32, 78, 32, 78, 32, 77, 48, 76, 208, 76, 48, 76, 0, 76, 64, 75, 80, 71, 224 }, 672033);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 78, 112, 78, 192, 78, 232, 79, 16, 78, 160, 78, 208, 78, 32, 77, 128, 76, 64, 75, 80, 71, 224, 68, 192 }, 672066);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 78, 112, 78, 192, 78, 232, 79, 16, 78, 232, 78, 192, 78, 32, 77, 128, 76, 64, 75, 80, 71, 224, 68, 192 }, 672102);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 78, 112, 78, 192, 78, 232, 79, 16, 78, 232, 78, 192, 78, 32, 77, 128, 76, 64, 75, 80, 71, 224, 68, 192 }, 672138);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 78, 112, 78, 192, 78, 232, 79, 16, 78, 232, 78, 192, 78, 32, 77, 128, 76, 64, 75, 80, 71, 224, 68, 192 }, 672174);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 78, 112, 78, 192, 78, 232, 79, 16, 78, 232, 78, 192, 78, 32, 77, 128, 76, 64, 75, 80, 71, 224, 68, 192 }, 672210);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 56, 224, 60, 160, 60, 0, 57, 128, 56, 224, 56, 144, 56, 224 }, 672926);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 67, 128, 70, 0, 70, 160, 67, 224, 65, 64, 63, 160, 63, 64 }, 672962);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 75, 176, 76, 64, 73, 192, 71, 224, 69, 176, 67, 224, 67, 16 }, 672998);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 77, 128, 76, 64, 74, 192, 73, 32, 72, 32, 71, 80, 70, 80 }, 673034);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 77, 128, 76, 64, 76, 48, 75, 0, 74, 48, 73, 96, 72, 192 }, 673070);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 77, 128 }, 673102);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 32, 78, 32, 78, 32, 77, 48, 76, 208, 76, 48, 76, 0, 76, 64, 75, 80, 71, 224 }, 673105);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 78, 112, 78, 192, 78, 232, 79, 16, 78, 160, 78, 208, 78, 32, 77, 128, 76, 64, 75, 80, 71, 224, 68, 192 }, 673138);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 78, 112, 78, 192, 78, 232, 79, 16, 78, 232, 78, 192, 78, 32, 77, 128, 76, 64, 75, 80, 71, 224, 68, 192 }, 673174);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 78, 112, 78, 192, 78, 232, 79, 16, 78, 232, 78, 192, 78, 32, 77, 128, 76, 64, 75, 80, 71, 224, 68, 192 }, 673210);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 78, 112, 78, 192, 78, 232, 79, 16, 78, 232, 78, 192, 78, 32, 77, 128, 76, 64, 75, 80, 71, 224, 68, 192 }, 673246);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 78, 112, 78, 192, 78, 232, 79, 16, 78, 232, 78, 192, 78, 32, 77, 128, 76, 64, 75, 80, 71, 224, 68, 192 }, 673282);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 56, 224, 60, 160, 60, 0, 57, 128, 56, 224, 56, 144, 56, 224 }, 673998);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 67, 128, 70, 0, 70, 160, 67, 224, 65, 64, 63, 160, 63, 64 }, 674034);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 75, 176, 76, 64, 73, 192, 71, 224, 69, 176, 67, 224, 67, 16 }, 674070);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 77, 128, 76, 64, 74, 192, 73, 32, 72, 32, 71, 80, 70, 80 }, 674106);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 77, 128, 76, 64, 76, 48, 75, 0, 74, 48, 73, 96, 72, 192 }, 674142);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 77, 128 }, 674174);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 32, 78, 32, 78, 32, 77, 48, 76, 208, 76, 48, 76, 0, 76, 64, 75, 80, 71, 224 }, 674177);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 78, 112, 78, 192, 78, 232, 79, 16, 78, 160, 78, 208, 78, 32, 77, 128, 76, 64, 75, 80, 71, 224, 68, 192 }, 674210);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 78, 112, 78, 192, 78, 232, 79, 16, 78, 232, 78, 192, 78, 32, 77, 128, 76, 64, 75, 80, 71, 224, 68, 192 }, 674246);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 78, 112, 78, 192, 78, 232, 79, 16, 78, 232, 78, 192, 78, 32, 77, 128, 76, 64, 75, 80, 71, 224, 68, 192 }, 674282);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 78, 112, 78, 192, 78, 232, 79, 16, 78, 232, 78, 192, 78, 32, 77, 128, 76, 64, 75, 80, 71, 224, 68, 192 }, 674318);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 78, 112, 78, 192, 78, 232, 79, 16, 78, 232, 78, 192, 78, 32, 77, 128, 76, 64, 75, 80, 71, 224, 68, 192 }, 674354);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 72, 16, 76, 144, 78, 160, 80, 160, 81, 112, 82, 48, 82, 128, 82, 208 }, 674504);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 74, 176, 76, 144, 78, 160, 80, 160, 81, 112, 82, 48, 82, 128, 82, 208 }, 674524);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 82, 128, 82, 128, 82, 128, 82, 128, 82, 128, 82, 128, 82, 128, 82, 128, 82, 128, 82, 128, 69, 176, 63, 16, 58, 32, 55, 0, 51, 64 }, 674590);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 233 }, 682523);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 82, 6, 109, 6, 128, 6, 148, 6, 143 }, 685401);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 44, 5, 172, 5, 102 }, 685411);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 108 }, 685417);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 74 }, 685419);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 3 }, 685421);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 151 }, 685423);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 59, 7, 159, 7, 230 }, 685447);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 0 }, 685453);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 13, 7, 128 }, 685455);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 0, 6, 131 }, 685459);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 18, 5, 220 }, 685463);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 141 }, 685467);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 100 }, 685469);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 7, 230, 8, 77, 8, 179, 8, 184, 8, 182, 8, 33, 7, 105, 7, 20, 6, 215, 6, 123 }, 685492);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 49 }, 685513);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 64 }, 685515);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 9, 148, 9, 179, 9, 154, 9, 102, 9, 51, 9, 92, 8, 220, 7, 236, 7, 77, 6, 230, 6, 151, 6, 133 }, 685538);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 9, 148, 9, 179, 9, 154, 9, 102, 9, 51, 9, 92, 9, 13, 8, 128, 8, 51, 7, 218, 7, 154, 7, 85 }, 685584);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 8, 195, 8, 223, 8, 200, 8, 210, 8, 218, 8, 218, 8, 182, 8, 105, 8, 51, 7, 131 }, 686188);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 8, 195, 8, 223, 8, 200, 8, 210, 8, 218, 8, 218, 8, 182, 8, 105, 8, 51, 7, 131 }, 686234);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 48 }, 763957);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 80 }, 763961);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 152 }, 763965);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 48 }, 764049);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 80 }, 764053);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 152 }, 764057);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 200 }, 764061);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 192 }, 764065);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 160 }, 764069);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 148 }, 764073);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 148 }, 764077);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 148 }, 764081);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 148 }, 764085);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 148 }, 764089);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 160 }, 764093);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 168 }, 764097);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 48 }, 764141);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 96 }, 764145);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 160 }, 764149);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 200 }, 764153);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 192 }, 764157);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 160 }, 764161);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 148 }, 764165);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 148 }, 764169);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 148 }, 764173);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 148 }, 764177);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 148 }, 764181);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 160 }, 764185);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 168 }, 764189);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 64 }, 764233);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 128 }, 764237);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 176 }, 764241);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 200 }, 764245);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 192 }, 764249);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 160 }, 764253);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 148 }, 764257);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 148 }, 764261);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 148 }, 764265);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 148 }, 764269);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 148 }, 764273);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 160 }, 764277);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 168 }, 764281);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 96 }, 764325);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 144 }, 764329);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 176 }, 764333);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 192 }, 764337);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 192 }, 764341);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 160 }, 764345);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 148 }, 764349);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 148 }, 764353);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 148 }, 764357);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 148 }, 764361);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 148 }, 764365);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 160 }, 764369);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 168 }, 764373);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 144 }, 764417);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 148 }, 764421);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 160 }, 764425);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 184 }, 764429);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 192 }, 764433);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 160 }, 764437);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 148 }, 764441);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 148 }, 764445);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 148 }, 764449);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 148 }, 764453);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 148 }, 764457);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 160 }, 764461);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 168 }, 764465);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 144 }, 764509);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 148 }, 764513);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 160 }, 764517);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 184 }, 764521);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 192 }, 764525);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 160 }, 764529);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 148 }, 764533);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 148 }, 764537);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 148 }, 764541);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 148 }, 764545);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 148 }, 764549);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 160 }, 764553);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 168 }, 764557);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 144 }, 764601);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 148 }, 764605);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 160 }, 764609);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 184 }, 764613);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 192 }, 764617);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 160 }, 764621);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 148 }, 764625);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 148 }, 764629);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 148 }, 764633);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 148 }, 764637);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 148 }, 764641);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 160 }, 764645);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 168 }, 764649);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 200 }, 765977);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 160 }, 765985);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 148 }, 765989);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 148 }, 765993);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 148 }, 765997);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 148 }, 766001);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 148 }, 766005);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 160 }, 766009);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 48 }, 766057);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 96 }, 766061);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 160 }, 766065);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 200 }, 766069);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 192 }, 766073);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 160 }, 766077);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 148 }, 766081);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 148 }, 766085);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 148 }, 766089);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 148 }, 766093);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 148 }, 766097);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 160 }, 766101);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 168 }, 766105);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 64 }, 766149);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 128 }, 766153);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 176 }, 766157);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 200 }, 766161);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 192 }, 766165);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 160 }, 766169);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 148 }, 766173);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 148 }, 766177);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 148 }, 766181);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 148 }, 766185);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 148 }, 766189);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 160 }, 766193);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 168 }, 766197);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 96 }, 766241);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 144 }, 766245);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 176 }, 766249);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 192 }, 766253);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 192 }, 766257);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 160 }, 766261);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 148 }, 766265);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 148 }, 766269);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 148 }, 766273);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 148 }, 766277);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 148 }, 766281);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 160 }, 766285);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 168 }, 766289);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 144 }, 766333);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 148 }, 766337);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 160 }, 766341);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 184 }, 766345);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 192 }, 766349);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 160 }, 766353);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 148 }, 766357);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 148 }, 766361);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 148 }, 766365);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 148 }, 766369);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 148 }, 766373);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 160 }, 766377);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 168 }, 766381);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 144 }, 766425);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 148 }, 766429);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 160 }, 766433);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 184 }, 766437);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 192 }, 766441);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 160 }, 766445);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 148 }, 766449);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 148 }, 766453);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 148 }, 766457);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 148 }, 766461);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 148 }, 766465);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 160 }, 766469);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 168 }, 766473);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 144 }, 766517);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 148 }, 766521);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 160 }, 766525);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 184 }, 766529);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 192 }, 766533);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 160 }, 766537);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 148 }, 766541);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 148 }, 766545);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 148 }, 766549);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 148 }, 766553);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 148 }, 766557);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 160 }, 766561);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 168 }, 766565);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 200 }, 767893);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 160 }, 767901);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 148 }, 767905);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 148 }, 767909);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 148 }, 767913);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 148 }, 767917);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 148 }, 767921);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 160 }, 767925);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 48 }, 767973);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 96 }, 767977);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 160 }, 767981);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 200 }, 767985);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 192 }, 767989);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 160 }, 767993);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 148 }, 767997);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 148 }, 768001);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 148 }, 768005);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 148 }, 768009);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 148 }, 768013);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 160 }, 768017);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 168 }, 768021);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 64 }, 768065);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 128 }, 768069);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 176 }, 768073);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 200 }, 768077);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 192 }, 768081);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 160 }, 768085);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 148 }, 768089);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 148 }, 768093);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 148 }, 768097);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 148 }, 768101);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 148 }, 768105);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 160 }, 768109);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 168 }, 768113);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 96 }, 768157);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 144 }, 768161);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 176 }, 768165);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 192 }, 768169);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 192 }, 768173);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 160 }, 768177);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 148 }, 768181);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 148 }, 768185);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 148 }, 768189);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 148 }, 768193);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 148 }, 768197);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 160 }, 768201);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 168 }, 768205);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 144 }, 768249);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 148 }, 768253);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 160 }, 768257);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 184 }, 768261);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 192 }, 768265);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 160 }, 768269);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 148 }, 768273);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 148 }, 768277);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 148 }, 768281);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 148 }, 768285);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 148 }, 768289);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 160 }, 768293);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 168 }, 768297);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 144 }, 768341);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 148 }, 768345);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 160 }, 768349);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 184 }, 768353);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 192 }, 768357);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 160 }, 768361);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 148 }, 768365);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 148 }, 768369);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 148 }, 768373);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 148 }, 768377);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 148 }, 768381);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 160 }, 768385);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 168 }, 768389);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 144 }, 768433);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 148 }, 768437);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 160 }, 768441);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 184 }, 768445);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 192 }, 768449);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 160 }, 768453);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 148 }, 768457);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 148 }, 768461);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 148 }, 768465);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 148 }, 768469);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 148 }, 768473);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 160 }, 768477);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 168 }, 768481);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 218, 225, 72 }, 769737);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 216 }, 769741);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 216 }, 769745);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 216 }, 769749);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 216 }, 769753);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 200, 163, 215 }, 769801);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 213, 30, 184 }, 769805);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224, 163, 215 }, 769809);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 228, 122, 225 }, 769813);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 230, 102, 102 }, 769817);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 230, 102, 102 }, 769821);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224, 163, 215 }, 769825);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 218, 225, 72 }, 769829);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 216 }, 769833);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 216 }, 769837);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 216 }, 769841);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 216 }, 769845);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 200, 163, 215 }, 769893);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 213, 30, 184 }, 769897);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224, 163, 215 }, 769901);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 228, 122, 225 }, 769905);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 230, 102, 102 }, 769909);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 230, 102, 102 }, 769913);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224, 163, 215 }, 769917);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 218, 225, 72 }, 769921);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 216 }, 769925);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 769929);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 769933);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 769937);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 200, 163, 215 }, 769985);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 213, 30, 184 }, 769989);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 218, 102, 102 }, 769993);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 221, 194, 143 }, 769997);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 223, 51, 51 }, 770001);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 222, 184, 82 }, 770005);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 770009);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 770013);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 770017);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 770021);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 770025);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 770029);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 193, 63, 125 }, 770077);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 200 }, 770081);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 208 }, 770085);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 215, 251, 22 }, 770089);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 223, 51, 51 }, 770093);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 770097);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 770101);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 770105);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 770109);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 770113);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 770117);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 770121);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 192 }, 770169);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 200 }, 770173);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 208 }, 770177);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 216 }, 770181);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 770185);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 770189);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 770193);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 770197);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 770201);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 770205);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 770209);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 770213);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 192 }, 770261);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 200 }, 770265);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 208 }, 770269);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 770273);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 770277);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 770281);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 770285);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 770289);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 770293);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 770297);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 770301);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 770305);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 192 }, 770353);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 200 }, 770357);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 208 }, 770361);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 770365);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 770369);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 770373);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 770377);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 770381);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 770385);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 770389);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 770393);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 770397);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 218, 225, 72 }, 771653);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 216 }, 771657);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 216 }, 771661);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 216 }, 771665);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 216 }, 771669);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 200, 163, 215 }, 771717);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 213, 30, 184 }, 771721);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224, 163, 215 }, 771725);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 228, 122, 225 }, 771729);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 230, 102, 102 }, 771733);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 230, 102, 102 }, 771737);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224, 163, 215 }, 771741);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 218, 225, 72 }, 771745);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 216 }, 771749);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 216 }, 771753);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 216 }, 771757);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 216 }, 771761);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 200, 163, 215 }, 771809);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 213, 30, 184 }, 771813);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224, 163, 215 }, 771817);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 228, 122, 225 }, 771821);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 230, 102, 102 }, 771825);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 230, 102, 102 }, 771829);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224, 163, 215 }, 771833);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 218, 225, 72 }, 771837);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 216 }, 771841);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 771845);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 771849);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 771853);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 200, 163, 215 }, 771901);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 213, 30, 184 }, 771905);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 218, 102, 102 }, 771909);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 221, 194, 143 }, 771913);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 223, 51, 51 }, 771917);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 222, 184, 82 }, 771921);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 771925);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 771929);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 771933);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 771937);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 771941);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 771945);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 193, 63, 125 }, 771993);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 200 }, 771997);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 208 }, 772001);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 215, 251, 22 }, 772005);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 223, 51, 51 }, 772009);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 772013);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 772017);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 772021);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 772025);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 772029);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 772033);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 772037);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 192 }, 772085);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 200 }, 772089);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 208 }, 772093);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 216 }, 772097);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 772101);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 772105);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 772109);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 772113);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 772117);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 772121);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 772125);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 772129);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 192 }, 772177);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 200 }, 772181);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 208 }, 772185);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 772189);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 772193);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 772197);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 772201);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 772205);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 772209);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 772213);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 772217);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 772221);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 192 }, 772269);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 200 }, 772273);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 208 }, 772277);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 772281);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 772285);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 772289);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 772293);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 772297);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 772301);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 772305);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 772309);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 772313);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 218, 225, 72 }, 773569);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 216 }, 773573);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 216 }, 773577);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 216 }, 773581);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 216 }, 773585);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 200, 163, 215 }, 773633);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 213, 30, 184 }, 773637);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224, 163, 215 }, 773641);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 228, 122, 225 }, 773645);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 230, 102, 102 }, 773649);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 230, 102, 102 }, 773653);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224, 163, 215 }, 773657);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 218, 225, 72 }, 773661);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 216 }, 773665);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 216 }, 773669);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 216 }, 773673);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 216 }, 773677);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 200, 163, 215 }, 773725);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 213, 30, 184 }, 773729);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224, 163, 215 }, 773733);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 228, 122, 225 }, 773737);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 230, 102, 102 }, 773741);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 230, 102, 102 }, 773745);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224, 163, 215 }, 773749);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 218, 225, 72 }, 773753);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 216 }, 773757);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 773761);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 773765);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 773769);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 200, 163, 215 }, 773817);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 213, 30, 184 }, 773821);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 218, 102, 102 }, 773825);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 221, 194, 143 }, 773829);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 223, 51, 51 }, 773833);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 222, 184, 82 }, 773837);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 773841);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 773845);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 773849);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 773853);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 773857);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 773861);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 193, 63, 125 }, 773909);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 200 }, 773913);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 208 }, 773917);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 215, 251, 22 }, 773921);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 223, 51, 51 }, 773925);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 773929);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 773933);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 773937);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 773941);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 773945);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 773949);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 773953);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 192 }, 774001);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 200 }, 774005);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 208 }, 774009);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 216 }, 774013);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 774017);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 774021);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 774025);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 774029);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 774033);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 774037);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 774041);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 774045);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 192 }, 774093);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 200 }, 774097);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 208 }, 774101);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 774105);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 774109);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 774113);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 774117);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 774121);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 774125);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 774129);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 774133);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 774137);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 192 }, 774185);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 200 }, 774189);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 208 }, 774193);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 774197);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 774201);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 774205);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 774209);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 774213);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 774217);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 774221);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 774225);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 774229);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 785485);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 785489);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 785493);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 785497);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 785501);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 138, 128 }, 785549);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 161 }, 785553);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 181, 187, 130 }, 785557);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 202, 119, 4 }, 785561);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 209, 198, 230 }, 785565);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 225, 103, 76 }, 785569);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 785573);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 785577);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 785581);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 785585);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 785589);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 785593);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 141 }, 785641);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 167, 128 }, 785645);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 187, 34, 207 }, 785649);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 206, 197, 157 }, 785653);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 212, 159, 30 }, 785657);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 785661);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 785665);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 785669);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 785673);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 785677);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 785681);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 785685);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 159 }, 785733);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 180, 128 }, 785737);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 197, 241, 104 }, 785741);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 215, 98, 207 }, 785745);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 218, 79, 143 }, 785749);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 785753);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 785757);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 785761);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 785765);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 785769);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 785773);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 785777);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 181 }, 785825);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 193, 128 }, 785829);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 206, 192 }, 785833);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 220 }, 785837);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 785841);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 785845);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 785849);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 785853);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 785857);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 785861);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 785865);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 785869);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 192 }, 785917);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 200 }, 785921);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 208 }, 785925);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 785929);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 785933);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 785937);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 785941);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 785945);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 785949);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 785953);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 785957);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 785961);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 192 }, 786009);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 200 }, 786013);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 208 }, 786017);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 786021);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 786025);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 786029);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 786033);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 786037);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 786041);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 786045);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 786049);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 786053);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 192 }, 786101);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 200 }, 786105);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 208 }, 786109);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 786113);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 786117);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 786121);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 786125);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 786129);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 786133);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 786137);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 786141);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 786145);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 787401);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 787405);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 787409);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 787413);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 787417);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 138, 128 }, 787465);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 161 }, 787469);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 181, 187, 130 }, 787473);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 202, 119, 4 }, 787477);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 209, 198, 230 }, 787481);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 225, 103, 76 }, 787485);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 787489);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 787493);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 787497);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 787501);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 787505);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 787509);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 141 }, 787557);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 167, 128 }, 787561);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 187, 34, 207 }, 787565);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 206, 197, 157 }, 787569);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 212, 159, 30 }, 787573);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 787577);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 787581);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 787585);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 787589);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 787593);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 787597);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 787601);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 159 }, 787649);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 180, 128 }, 787653);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 197, 241, 104 }, 787657);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 215, 98, 207 }, 787661);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 218, 79, 143 }, 787665);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 787669);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 787673);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 787677);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 787681);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 787685);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 787689);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 787693);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 181 }, 787741);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 193, 128 }, 787745);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 206, 192 }, 787749);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 220 }, 787753);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 787757);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 787761);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 787765);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 787769);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 787773);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 787777);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 787781);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 787785);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 192 }, 787833);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 200 }, 787837);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 208 }, 787841);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 787845);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 787849);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 787853);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 787857);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 787861);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 787865);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 787869);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 787873);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 787877);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 192 }, 787925);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 200 }, 787929);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 208 }, 787933);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 787937);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 787941);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 787945);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 787949);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 787953);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 787957);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 787961);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 787965);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 787969);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 192 }, 788017);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 200 }, 788021);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 208 }, 788025);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 788029);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 788033);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 788037);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 788041);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 788045);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 788049);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 788053);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 788057);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 788061);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 218, 225, 72 }, 789317);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 216 }, 789321);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 216 }, 789325);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 216 }, 789329);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 216 }, 789333);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 200, 163, 215 }, 789381);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 213, 30, 184 }, 789385);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224, 163, 215 }, 789389);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 228, 122, 225 }, 789393);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 230, 102, 102 }, 789397);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 230, 102, 102 }, 789401);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224, 163, 215 }, 789405);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 218, 225, 72 }, 789409);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 216 }, 789413);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 216 }, 789417);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 216 }, 789421);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 216 }, 789425);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 200, 163, 215 }, 789473);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 213, 30, 184 }, 789477);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224, 163, 215 }, 789481);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 228, 122, 225 }, 789485);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 230, 102, 102 }, 789489);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 230, 102, 102 }, 789493);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224, 163, 215 }, 789497);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 218, 225, 72 }, 789501);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 216 }, 789505);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 789509);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 789513);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 789517);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 200, 163, 215 }, 789565);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 213, 30, 184 }, 789569);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 218, 102, 102 }, 789573);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 221, 194, 143 }, 789577);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 223, 51, 51 }, 789581);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 222, 184, 82 }, 789585);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 789589);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 789593);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 789597);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 789601);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 789605);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 789609);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 193, 63, 125 }, 789657);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 200 }, 789661);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 208 }, 789665);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 215, 251, 22 }, 789669);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 223, 51, 51 }, 789673);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 789677);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 789681);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 789685);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 789689);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 789693);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 789697);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 789701);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 192 }, 789749);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 200 }, 789753);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 208 }, 789757);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 216 }, 789761);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 789765);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 789769);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 789773);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 789777);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 789781);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 789785);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 789789);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 789793);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 192 }, 789841);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 200 }, 789845);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 208 }, 789849);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 789853);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 789857);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 789861);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 789865);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 789869);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 789873);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 789877);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 789881);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 789885);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 192 }, 789933);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 200 }, 789937);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 208 }, 789941);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 789945);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 789949);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 789953);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 789957);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 789961);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 789965);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 789969);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 789973);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224 }, 789977);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 52 }, 821965);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 52 }, 821969);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 52 }, 821973);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 52 }, 821977);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 52 }, 821981);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 52 }, 821985);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 52 }, 821989);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 52 }, 821993);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 52 }, 821997);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 52 }, 822001);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 52 }, 822005);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 52 }, 822009);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 52 }, 822013);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 52 }, 822017);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 39 }, 822021);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 39 }, 822025);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 39 }, 822029);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 39 }, 822033);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 39 }, 822037);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 39 }, 822041);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 39 }, 822045);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 32 }, 822049);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 32 }, 822053);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 32 }, 822057);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 32 }, 822061);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 32 }, 822065);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 32 }, 822069);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 32 }, 822073);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 32 }, 822077);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 32 }, 822081);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 32 }, 822085);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 32 }, 822089);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 32 }, 822093);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 32 }, 822097);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 32 }, 822101);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 60, 192, 0 }, 834521);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 44, 192, 0 }, 834525);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 34, 128 }, 834529);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 67, 192, 0 }, 834577);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 52 }, 834581);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 40, 144, 0 }, 834585);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 74, 192, 0 }, 834633);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 57, 128, 0 }, 834637);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 46, 160, 0 }, 834641);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 88, 192, 0 }, 834689);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 68, 64, 0 }, 834693);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 58, 192, 0 }, 834697);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 102, 192, 0 }, 834745);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 79, 64, 0 }, 834749);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 72, 128, 0 }, 834753);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 116, 192, 0 }, 834801);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 90, 64, 0 }, 834805);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 85 }, 834809);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 129, 96, 0 }, 834857);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 101 }, 834861);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 97, 64, 0 }, 834865);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 136, 96, 0 }, 834913);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 112 }, 834917);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 109, 128 }, 834921);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 143, 96, 0 }, 834969);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 123 }, 834973);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 121, 192, 0 }, 834977);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 177, 128 }, 885141);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 183, 217, 154 }, 885145);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 186 }, 885149);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 185 }, 885153);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 178, 128 }, 885157);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 172, 128 }, 885161);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 166 }, 885165);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 182 }, 885177);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 198 }, 885181);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 67, 204, 76, 205, 67, 206 }, 885184);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 67, 200 }, 885192);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 193 }, 885197);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 189, 128 }, 885201);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 175 }, 885205);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 67, 252, 128, 0 }, 885220);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 1, 198, 102 }, 885225);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 1, 64, 0, 67, 246 }, 885229);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 67, 231, 128, 0, 67, 222 }, 885236);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 194 }, 885245);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 173, 222, 122 }, 885621);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 177, 108, 216 }, 885625);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 177, 123, 104 }, 885629);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 177, 219, 251 }, 885633);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 178, 128 }, 885637);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 172, 128 }, 885641);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 166 }, 885645);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 182 }, 885657);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 198 }, 885661);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 67, 204, 76, 205, 67, 206 }, 885664);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 67, 200 }, 885672);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 193 }, 885677);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 189, 128 }, 885681);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 175 }, 885685);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 67, 252, 128 }, 885700);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 1, 198, 102 }, 885705);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 1, 64 }, 885709);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 67, 246 }, 885712);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 67, 231, 128 }, 885716);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 67, 222 }, 885720);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 194 }, 885725);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 173, 222, 122 }, 886101);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 177, 108, 216 }, 886105);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 177, 123, 104 }, 886109);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 177, 219, 251 }, 886113);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 178 }, 886117);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 172, 128 }, 886121);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 166 }, 886125);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 182 }, 886137);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 198 }, 886141);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 67, 204, 76, 205, 67, 206 }, 886144);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 67, 200 }, 886152);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 193 }, 886157);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 189, 128 }, 886161);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 175 }, 886165);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 67, 252, 128 }, 886180);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 1, 198, 102 }, 886185);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 1, 64 }, 886189);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 67, 246 }, 886192);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 67, 231, 128 }, 886196);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 67, 222 }, 886200);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 194 }, 886205);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 177, 128 }, 886581);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 183, 217, 154 }, 886585);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 186 }, 886589);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 185 }, 886593);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 178, 128 }, 886597);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 172, 128 }, 886601);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 166 }, 886605);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 182 }, 886617);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 198 }, 886621);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 67, 204, 76, 205, 67, 206 }, 886624);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 67, 200 }, 886632);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 193 }, 886637);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 189, 128 }, 886641);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 175 }, 886645);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 67, 252, 128 }, 886660);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 1, 198, 102 }, 886665);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 1, 64 }, 886669);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 67, 246 }, 886672);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 67, 231, 128 }, 886676);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 67, 222 }, 886680);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 194 }, 886685);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 177, 128 }, 896321);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 183, 217, 154 }, 896325);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 186 }, 896329);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 185 }, 896333);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 178, 128 }, 896337);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 172, 128 }, 896341);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 166 }, 896345);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 182 }, 896357);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 198 }, 896361);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 67, 204, 76, 205, 67, 206 }, 896364);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 67, 200 }, 896372);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 193 }, 896377);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 189, 128 }, 896381);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 175 }, 896385);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 67, 252, 128 }, 896400);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 1, 198, 102 }, 896405);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 1, 64 }, 896409);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 67, 246 }, 896412);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 67, 231, 128 }, 896416);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 67, 222 }, 896420);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 194 }, 896425);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 177, 128 }, 896801);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 183, 217, 154 }, 896805);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 186 }, 896809);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 185 }, 896813);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 178, 128 }, 896817);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 172, 128 }, 896821);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 166 }, 896825);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 182 }, 896837);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 198 }, 896841);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 67, 204, 76, 205, 67, 206 }, 896844);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 67, 200 }, 896852);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 193 }, 896857);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 189, 128 }, 896861);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 175 }, 896865);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 67, 252, 128 }, 896880);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 1, 198, 102 }, 896885);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 1, 64 }, 896889);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 67, 246 }, 896892);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 67, 231, 128 }, 896896);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 67, 222 }, 896900);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 194 }, 896905);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 173, 222, 122 }, 897601);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 177, 108, 216 }, 897605);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 177, 123, 104 }, 897609);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 177, 219, 251 }, 897613);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 178, 128 }, 897617);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 172, 128 }, 897621);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 166 }, 897625);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 182 }, 897637);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 198 }, 897641);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 67, 204, 76, 205, 67, 206 }, 897644);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 67, 200 }, 897652);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 193 }, 897657);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 189, 128 }, 897661);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 175 }, 897665);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 67, 252, 128 }, 897680);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 1, 198, 102 }, 897685);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 1, 64 }, 897689);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 67, 246 }, 897692);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 67, 231, 128 }, 897696);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 67, 222 }, 897700);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 194 }, 897705);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 173, 222, 122 }, 898081);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 177, 108, 216 }, 898085);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 177, 123, 104 }, 898089);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 177, 219, 251 }, 898093);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 178, 128 }, 898097);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 172, 128 }, 898101);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 166 }, 898105);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 182 }, 898117);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 198 }, 898121);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 67, 204, 76, 205, 67, 206 }, 898124);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 67, 200 }, 898132);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 193 }, 898137);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 189, 128 }, 898141);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 175 }, 898145);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 67, 252, 128 }, 898160);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 1, 198, 102 }, 898165);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 1, 64 }, 898169);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 67, 246 }, 898172);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 67, 231, 128 }, 898176);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 67, 222 }, 898180);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 194 }, 898185);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 148 }, 899525);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 148 }, 899529);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 145, 102, 102 }, 899533);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 145, 102, 102 }, 899537);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 145, 102, 102 }, 899541);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 145, 102, 102 }, 899545);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 61, 51, 51 }, 899549);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 142, 204, 205 }, 899609);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 148, 204, 205 }, 899613);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 155, 102, 102 }, 899617);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 155, 102, 102 }, 899621);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 152, 153, 154 }, 899625);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 152, 153, 154 }, 899629);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 152, 153, 154 }, 899633);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 152, 153, 154 }, 899637);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 70, 204, 205 }, 899641);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 152, 204, 205 }, 899697);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 151, 153, 154 }, 899701);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 155, 204, 205 }, 899705);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 162, 204, 205 }, 899709);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 162, 204, 205 }, 899713);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 160, 0, 0 }, 899717);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 160, 0, 0 }, 899721);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 160, 0, 0 }, 899725);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 160, 0, 0 }, 899729);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 80, 102, 102 }, 899733);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 51, 51 }, 899790);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 160 }, 899793);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 163, 0, 0 }, 899797);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 170, 51, 51 }, 899801);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 170, 51, 51 }, 899805);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 167, 51, 51 }, 899809);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 167, 51, 51 }, 899813);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 167, 51, 51 }, 899817);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 167, 51, 51 }, 899821);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 89, 153, 154 }, 899825);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 171, 102, 102 }, 899881);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 169, 204, 205 }, 899885);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 172, 0, 0 }, 899889);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 177, 153, 154 }, 899893);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 177, 153, 154 }, 899897);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 174, 102, 102 }, 899901);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 174, 102, 102 }, 899905);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 174, 102, 102 }, 899909);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 174, 102, 102 }, 899913);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 99, 51, 51 }, 899917);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 177, 102, 102 }, 899977);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 179, 0, 0 }, 899981);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 185, 0, 0 }, 899985);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 185, 0, 0 }, 899989);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 181, 204, 205 }, 899993);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 181, 204, 205 }, 899997);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 181, 204, 205 }, 900001);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 181, 204, 205 }, 900005);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 108, 102, 102 }, 900009);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 189 }, 900065);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 187 }, 900069);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 187, 0, 0 }, 900073);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 191, 102, 102 }, 900077);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 192, 102, 102 }, 900081);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 189, 0, 0 }, 900085);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 189, 0, 0 }, 900089);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 189, 0, 0 }, 900093);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 189, 0, 0 }, 900097);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 118, 0, 0 }, 900101);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 204, 51, 51 }, 900157);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 203, 153, 154, 66, 205, 153, 154, 66, 207, 51, 51, 66, 207, 51, 51, 66, 203, 153, 154, 66, 203, 153, 154, 66, 203, 153, 154 }, 900161);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 203, 153, 154 }, 900189);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 132 }, 900193);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 148 }, 901537);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 148 }, 901541);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 145, 102, 102 }, 901545);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 145, 102, 102 }, 901549);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 145, 102, 102 }, 901553);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 145, 102, 102 }, 901557);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 61, 51, 51 }, 901561);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 148, 204, 205 }, 901625);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 155, 102, 102 }, 901629);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 155, 102, 102 }, 901633);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 152, 153, 154 }, 901637);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 152, 153, 154 }, 901641);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 152, 153, 154 }, 901645);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 152, 153, 154 }, 901649);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 70, 204, 205 }, 901653);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 151, 153, 154 }, 901713);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 155, 204, 205 }, 901717);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 162, 204, 205 }, 901721);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 162, 204, 205 }, 901725);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 160 }, 901729);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 160 }, 901733);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 160 }, 901737);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 160 }, 901741);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 80, 102, 102 }, 901745);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 160 }, 901805);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 163 }, 901809);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 170, 51, 51 }, 901813);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 170, 51, 51 }, 901817);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 167, 51, 51 }, 901821);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 167, 51, 51 }, 901825);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 167, 51, 51 }, 901829);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 167, 51, 51 }, 901833);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 89, 153, 154 }, 901837);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 169, 204, 205 }, 901897);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 172 }, 901901);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 177, 153, 154 }, 901905);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 177, 153, 154 }, 901909);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 174, 102, 102 }, 901913);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 174, 102, 102 }, 901917);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 174, 102, 102 }, 901921);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 174, 102, 102 }, 901925);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 99, 51, 51 }, 901929);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 177, 102, 102 }, 901989);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 179 }, 901993);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 185 }, 901997);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 185 }, 902001);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 181, 204, 205 }, 902005);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 181, 204, 205 }, 902009);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 181, 204, 205 }, 902013);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 181, 204, 205 }, 902017);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 108, 102, 102 }, 902021);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 187 }, 902081);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 187 }, 902085);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 191, 102, 102 }, 902089);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 192, 102, 102 }, 902093);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 189, 0, 0 }, 902097);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 189, 0, 0 }, 902101);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 189 }, 902105);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 189 }, 902109);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 118 }, 902113);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 203, 153, 154, 66, 205, 153, 154, 66, 207, 51, 51, 66, 207, 51, 51, 66, 203, 153, 154, 66, 203, 153, 154, 66, 203, 153, 154 }, 902173);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 203, 153, 154 }, 902201);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 132 }, 902205);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 148 }, 903549);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 148 }, 903553);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 145, 102 }, 903557);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 145, 102 }, 903561);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 145, 102 }, 903565);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 145, 102 }, 903569);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 61, 51 }, 903573);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 148, 204 }, 903637);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 155, 102 }, 903641);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 155, 102 }, 903645);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 152, 153 }, 903649);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 152, 153 }, 903653);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 152, 153 }, 903657);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 152, 153 }, 903661);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 70, 204 }, 903665);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 151, 153 }, 903725);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 155, 204 }, 903729);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 162, 204 }, 903733);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 162, 204 }, 903737);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 160 }, 903741);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 160 }, 903745);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 160 }, 903749);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 160 }, 903753);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 80, 102 }, 903757);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 160 }, 903817);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 163 }, 903821);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 170, 51 }, 903825);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 170, 51 }, 903829);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 167, 51 }, 903833);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 167, 51 }, 903837);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 167, 51 }, 903841);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 167, 51 }, 903845);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 89, 153 }, 903849);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 169, 204 }, 903909);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 172 }, 903913);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 177, 153 }, 903917);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 177, 153 }, 903921);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 174, 102 }, 903925);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 174, 102 }, 903929);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 174, 102 }, 903933);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 174, 102 }, 903937);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 99, 51, 51 }, 903941);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 177, 102 }, 904001);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 179 }, 904005);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 185 }, 904009);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 185 }, 904013);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 181, 204 }, 904017);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 181, 204 }, 904021);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 181, 204 }, 904025);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 181, 204 }, 904029);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 108, 102, 102 }, 904033);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 187 }, 904093);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 187 }, 904097);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 191, 102 }, 904101);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 192, 102 }, 904105);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 189, 0 }, 904109);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 189, 0 }, 904113);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 189 }, 904117);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 189 }, 904121);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 118 }, 904125);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 203, 153 }, 904185);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 66, 205, 153, 154, 66, 207, 51, 51, 66, 207, 51, 51, 66, 203, 153, 154, 66, 203, 153, 154, 66, 203, 153, 154 }, 904188);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 203, 153 }, 904213);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 132, 102 }, 904217);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 67, 225, 0 }, 905776);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 67, 225, 0 }, 905780);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 67, 225, 0 }, 905784);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 67, 225, 0 }, 905788);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 67, 225, 0 }, 905792);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 67, 225, 0 }, 905796);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 67, 225, 0 }, 905800);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 67, 225, 0 }, 905804);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 67, 225, 0 }, 905808);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 67, 225, 0 }, 905812);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 67, 225, 0 }, 905816);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 67, 225, 0 }, 905820);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 67, 225, 0 }, 905824);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 67, 225, 0 }, 905828);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 67, 225, 0 }, 905832);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 67, 225, 0 }, 905836);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 67, 225, 0 }, 905840);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 67, 225, 0 }, 905844);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 67, 225, 0 }, 905848);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 67, 225, 0 }, 905852);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 67, 225, 0 }, 905856);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 67, 225, 0 }, 905860);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 67, 225, 0 }, 905864);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 67, 225, 0 }, 905868);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 67, 225, 0 }, 905872);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 67, 225, 0 }, 905876);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 67, 225, 0 }, 905880);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 67, 225, 0 }, 905884);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 67, 225, 0 }, 905888);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 67, 225, 0 }, 905892);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 67, 225, 0 }, 905896);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 67, 225, 0 }, 905900);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 67, 225, 0 }, 905904);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 67, 225, 0 }, 905908);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 67, 225, 0 }, 905912);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 67, 225, 0 }, 905916);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 67, 225, 0 }, 905920);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 67, 225, 0 }, 905924);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 67, 225, 0 }, 905928);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 67, 225, 0 }, 905932);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 67, 225, 0 }, 905936);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 67, 225, 0 }, 905940);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 67, 225, 0 }, 905944);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 67, 225, 0 }, 905948);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 67, 225, 0 }, 905952);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 67, 225, 0 }, 905956);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 67, 225, 0 }, 905960);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 67, 225, 0 }, 905964);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 67, 225, 0 }, 905968);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 67, 225, 0 }, 905972);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 67, 225, 0 }, 905976);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 67, 225, 0 }, 905980);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 67, 225, 0 }, 905984);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 67, 225, 0 }, 905988);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 67, 225, 0 }, 905992);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 67, 225, 0 }, 905996);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 67, 225, 0 }, 906000);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 67, 225, 0 }, 906004);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 67, 225, 0 }, 906008);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 67, 225, 0 }, 906012);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 67, 225, 0 }, 906016);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 67, 225, 0 }, 906020);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 67, 225, 0 }, 906024);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 67, 225, 0 }, 906028);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 67, 225, 0 }, 906032);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 67, 225, 0 }, 906036);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 67, 225, 0 }, 906040);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 67, 225, 0 }, 906044);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 67, 225, 0 }, 906048);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 67, 225, 0 }, 906052);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 67, 225, 0 }, 906056);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 67, 225, 0 }, 906060);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 67, 225, 0 }, 906064);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 67, 225, 0 }, 906068);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 67, 225, 0 }, 906072);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 67, 225, 0 }, 906076);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 67, 225, 0 }, 906080);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 67, 225, 0 }, 906084);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 67, 225, 0 }, 906088);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 67, 225, 0 }, 906092);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 67, 225, 0 }, 906096);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 67, 225, 0 }, 906100);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 67, 225, 0 }, 906104);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 67, 225, 0 }, 906108);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 67, 225, 0 }, 906112);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 67, 225, 0 }, 906116);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 67, 225, 0 }, 906120);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 67, 225, 0 }, 906124);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 2, 13 }, 942610);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 255, 255, 255, 255 }, 942614);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 255, 255 }, 942658);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 255, 255 }, 942688);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 255, 255, 255, 255 }, 942692);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 2, 13 }, 943278);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 255, 255, 255, 255 }, 943282);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 255, 255 }, 943326);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 189, 250, 120, 90 }, 1047432);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 195, 18, 8, 191 }, 1047444);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 5, 194, 4, 45 }, 1047468);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 132, 240, 67, 84 }, 1047504);
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
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 10, 0, 10, 0, 10, 0, 10, 0, 10, 0, 10, 0, 10, 0, 10, 0, 10, 0, 10, 0, 10, 0, 10, 0, 10, 0, 10, 0, 8, 154, 8, 97, 8, 18, 8, 28, 8 },
         new byte[] { 12, 128, 12, 128, 12, 128, 12, 128, 12, 128, 12, 128, 12, 128, 12, 128, 12, 128, 12, 128, 12, 128, 12, 128, 12, 128, 12, 128, 12, 127, 12, 128, 12, 127, 12, 128, 12 }, 604148, 604184, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 7, 200 },
             new byte[] { 10, 204 }, 604186, 604187, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 189 },
             new byte[] { 218 }, 604305, 604305, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 204 },
             new byte[] { 235 }, 604307, 604307, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 219, 0, 251 },
             new byte[] { 253, 1, 34 }, 604309, 604311, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 32 },
             new byte[] { 77 }, 604313, 604313, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 8, 231, 8, 115, 8, 22, 7, 185, 7, 129, 7, 72 },
             new byte[] { 15, 0, 15, 0, 15, 0, 15, 0, 15, 0, 15, 0 }, 631132, 631143, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 8, 231, 8, 123, 8, 35, 7, 203, 7, 141, 7, 79 },
             new byte[] { 15, 0, 15, 0, 15, 0, 15, 0, 15, 0, 15, 0 }, 631178, 631189, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 9, 13, 8, 128, 8, 51, 7, 218, 7, 154, 7, 85 },
             new byte[] { 15, 0, 15, 0, 15, 0, 15, 0, 15, 0, 15, 0 }, 631224, 631235, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 37, 128, 45, 0 },
             new byte[] { 38, 160, 46, 88 }, 637848, 637851, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 0 },
             new byte[] { 2 }, 637853, 637853, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 67, 128, 67, 128, 67, 128, 67, 128, 50, 0, 50, 0 },
             new byte[] { 69, 133, 69, 133, 69, 133, 69, 133, 51, 128, 51, 128 }, 637862, 637873, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 37, 128, 45, 0, 60, 0, 63, 192 },
             new byte[] { 38, 160, 46, 88, 61, 203, 65, 168 }, 637894, 637901, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 128, 67, 128 },
             new byte[] { 129, 68, 1 }, 637903, 637905, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 128, 67, 128, 67, 128, 67, 128, 67, 128, 50, 0, 50, 0 },
             new byte[] { 249, 69, 133, 69, 133, 69, 133, 69, 133, 51, 128, 51, 128 }, 637907, 637919, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 37, 128, 45, 0, 60, 0, 63, 192 },
             new byte[] { 38, 160, 46, 88, 61, 203, 65, 168 }, 637940, 637947, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 128, 67, 128 },
             new byte[] { 129, 68, 1 }, 637949, 637951, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 128, 67, 128, 67, 128, 67, 128, 67, 128, 50, 0, 50, 0 },
             new byte[] { 249, 69, 133, 69, 133, 69, 133, 69, 133, 51, 128, 51, 128 }, 637953, 637965, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 37, 128, 45, 0, 60, 0, 63, 192 },
             new byte[] { 38, 160, 46, 88, 61, 203, 65, 168 }, 637986, 637993, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 128, 67, 128 },
             new byte[] { 129, 68, 1 }, 637995, 637997, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 128, 67, 128, 67, 128, 67, 128, 67, 128, 50, 0, 50, 0 },
             new byte[] { 249, 69, 133, 69, 133, 69, 133, 69, 133, 51, 128, 51, 128 }, 637999, 638011, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 37, 128, 45, 0, 60, 0, 63, 192 },
             new byte[] { 38, 160, 46, 88, 61, 203, 65, 168 }, 638032, 638039, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 128, 67, 128 },
             new byte[] { 129, 68, 1 }, 638041, 638043, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 128, 67, 128, 67, 128, 67, 128, 67, 128, 50, 0, 50, 0 },
             new byte[] { 249, 69, 133, 69, 133, 69, 133, 69, 133, 51, 128, 51, 128 }, 638045, 638057, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 37, 128, 45, 0 },
             new byte[] { 38, 97, 46, 13 }, 638892, 638895, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 0 },
             new byte[] { 1 }, 638897, 638897, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 67, 128, 67, 128, 67, 128, 67, 128, 50, 0, 50, 0 },
             new byte[] { 69, 19, 69, 19, 69, 19, 69, 19, 51, 44, 51, 44 }, 638906, 638917, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 37, 128, 45, 0, 60, 0, 63, 192 },
             new byte[] { 38, 97, 46, 13, 61, 103, 65, 62 }, 638938, 638945, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 128 },
             new byte[] { 129 }, 638947, 638947, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 128 },
             new byte[] { 228 }, 638949, 638949, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 128, 67, 128, 67, 128, 67, 128, 67, 128, 50, 0, 50, 0 },
             new byte[] { 222, 69, 19, 69, 19, 69, 19, 69, 19, 51, 44, 51, 44 }, 638951, 638963, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 37, 128, 45, 0, 60, 0, 63, 192 },
             new byte[] { 38, 97, 46, 13, 61, 103, 65, 62 }, 638984, 638991, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 128 },
             new byte[] { 129 }, 638993, 638993, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 128 },
             new byte[] { 228 }, 638995, 638995, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 128, 67, 128, 67, 128, 67, 128, 67, 128, 50, 0, 50, 0 },
             new byte[] { 222, 69, 19, 69, 19, 69, 19, 69, 19, 51, 44, 51, 44 }, 638997, 639009, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 37, 128, 45, 0, 60, 0, 63, 192 },
             new byte[] { 38, 97, 46, 13, 61, 103, 65, 62 }, 639030, 639037, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 128 },
             new byte[] { 129 }, 639039, 639039, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 128 },
             new byte[] { 228 }, 639041, 639041, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 128, 67, 128, 67, 128, 67, 128, 67, 128, 50, 0, 50, 0 },
             new byte[] { 222, 69, 19, 69, 19, 69, 19, 69, 19, 51, 44, 51, 44 }, 639043, 639055, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 37, 128, 45, 0, 60, 0, 63, 192 },
             new byte[] { 38, 97, 46, 13, 61, 103, 65, 62 }, 639076, 639083, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 128 },
             new byte[] { 129 }, 639085, 639085, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 128 },
             new byte[] { 228 }, 639087, 639087, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 128, 67, 128, 67, 128, 67, 128, 67, 128, 50, 0, 50, 0 },
             new byte[] { 222, 69, 19, 69, 19, 69, 19, 69, 19, 51, 44, 51, 44 }, 639089, 639101, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 37, 128, 45, 0 },
             new byte[] { 38, 160, 46, 88 }, 639936, 639939, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 0 },
             new byte[] { 2 }, 639941, 639941, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 67, 128, 67, 128, 67, 128, 67, 128, 50, 0, 50, 0 },
             new byte[] { 69, 133, 69, 133, 69, 133, 69, 133, 51, 128, 51, 128 }, 639950, 639961, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 37, 128, 45, 0, 60, 0, 63, 192 },
             new byte[] { 38, 160, 46, 88, 61, 203, 65, 168 }, 639982, 639989, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 128, 67, 128 },
             new byte[] { 129, 68, 1 }, 639991, 639993, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 128, 67, 128, 67, 128, 67, 128, 67, 128, 50, 0, 50, 0 },
             new byte[] { 249, 69, 133, 69, 133, 69, 133, 69, 133, 51, 128, 51, 128 }, 639995, 640007, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 37, 128, 45, 0, 60, 0, 63, 192 },
             new byte[] { 38, 160, 46, 88, 61, 203, 65, 168 }, 640028, 640035, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 128, 67, 128 },
             new byte[] { 129, 68, 1 }, 640037, 640039, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 128, 67, 128, 67, 128, 67, 128, 67, 128, 50, 0, 50, 0 },
             new byte[] { 249, 69, 133, 69, 133, 69, 133, 69, 133, 51, 128, 51, 128 }, 640041, 640053, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 37, 128, 45, 0, 60, 0, 63, 192 },
             new byte[] { 38, 160, 46, 88, 61, 203, 65, 168 }, 640074, 640081, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 128, 67, 128 },
             new byte[] { 129, 68, 1 }, 640083, 640085, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 128, 67, 128, 67, 128, 67, 128, 67, 128, 50, 0, 50, 0 },
             new byte[] { 249, 69, 133, 69, 133, 69, 133, 69, 133, 51, 128, 51, 128 }, 640087, 640099, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 37, 128, 45, 0, 60, 0, 63, 192 },
             new byte[] { 38, 160, 46, 88, 61, 203, 65, 168 }, 640120, 640127, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 128, 67, 128 },
             new byte[] { 129, 68, 1 }, 640129, 640131, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 128, 67, 128, 67, 128, 67, 128, 67, 128, 50, 0, 50, 0 },
             new byte[] { 249, 69, 133, 69, 133, 69, 133, 69, 133, 51, 128, 51, 128 }, 640133, 640145, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 42, 128, 45, 0, 47, 128, 50, 0, 55, 0, 60, 0 },
             new byte[] { 43, 197, 46, 88, 48, 235, 51, 128, 56, 165, 61, 203 }, 640980, 640991, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 73, 192, 82, 128, 90, 0, 90, 0, 66, 128, 55, 0 },
             new byte[] { 75, 245, 85, 185, 93, 114, 92, 179, 68, 125, 56, 165 }, 640994, 641005, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 47, 128, 50, 0, 52, 128, 55, 0, 60, 0, 67, 128 },
             new byte[] { 48, 235, 51, 128, 54, 18, 56, 165, 61, 203, 69, 133 }, 641026, 641037, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 82, 128, 90, 0, 90, 0, 90, 0, 66, 128, 55, 0 },
             new byte[] { 84, 248, 93, 114, 93, 114, 92, 179, 68, 125, 56, 165 }, 641040, 641051, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 50, 0, 55, 0, 57, 128, 62, 128, 70, 0, 75, 0 },
             new byte[] { 51, 128, 56, 165, 59, 56, 64, 96, 72, 24, 77, 64 }, 641072, 641083, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 90, 0, 90, 0, 90, 0, 90, 0, 66, 128, 55, 0 },
             new byte[] { 92, 179, 93, 114, 93, 114, 92, 179, 68, 125, 56, 165 }, 641086, 641097, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 55, 0, 60, 0, 67, 128, 70, 0, 75, 0, 77, 128 },
             new byte[] { 56, 165, 61, 203, 69, 133, 72, 24, 77, 64, 79, 211 }, 641118, 641129, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 90, 0, 90, 0, 90, 0, 90, 0, 66, 128, 55, 0 },
             new byte[] { 92, 179, 93, 114, 93, 114, 92, 179, 68, 125, 56, 165 }, 641132, 641143, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 55, 0, 60, 0, 70, 0, 73, 128, 77, 128, 77, 128 },
             new byte[] { 56, 165, 61, 203, 72, 24, 75, 180, 79, 211, 79, 211 }, 641164, 641175, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 90, 0, 90, 0, 90, 0, 90, 0, 66, 128, 55, 0 },
             new byte[] { 92, 179, 93, 114, 93, 114, 92, 179, 68, 125, 56, 165 }, 641178, 641189, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 42, 128, 45, 0, 47, 128, 50, 0, 55, 0, 60, 0 },
             new byte[] { 43, 197, 46, 88, 48, 235, 51, 128, 56, 165, 61, 203 }, 642024, 642035, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 73, 192, 82, 128, 90, 0, 90, 0, 66, 128, 55, 0 },
             new byte[] { 75, 245, 85, 185, 93, 114, 92, 179, 68, 125, 56, 165 }, 642038, 642049, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 47, 128, 50, 0, 52, 128, 55, 0, 60, 0, 67, 128 },
             new byte[] { 48, 235, 51, 128, 54, 18, 56, 165, 61, 203, 69, 133 }, 642070, 642081, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 82, 128, 90, 0, 90, 0, 90, 0, 66, 128, 55, 0 },
             new byte[] { 84, 248, 93, 114, 93, 114, 92, 179, 68, 125, 56, 165 }, 642084, 642095, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 50, 0, 55, 0, 57, 128, 62, 128, 70, 0, 75, 0 },
             new byte[] { 51, 128, 56, 165, 59, 56, 64, 96, 72, 24, 77, 64 }, 642116, 642127, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 90, 0, 90, 0, 90, 0, 90, 0, 66, 128, 55, 0 },
             new byte[] { 92, 179, 93, 114, 93, 114, 92, 179, 68, 125, 56, 165 }, 642130, 642141, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 55, 0, 60, 0, 67, 128, 70, 0, 75, 0, 77, 128 },
             new byte[] { 56, 165, 61, 203, 69, 133, 72, 24, 77, 64, 79, 211 }, 642162, 642173, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 90, 0, 90, 0, 90, 0, 90, 0, 66, 128, 55, 0 },
             new byte[] { 92, 179, 93, 114, 93, 114, 92, 179, 68, 125, 56, 165 }, 642176, 642187, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 55, 0, 60, 0, 70, 0, 73, 128, 77, 128, 77, 128 },
             new byte[] { 56, 165, 61, 203, 72, 24, 75, 180, 79, 211, 79, 211 }, 642208, 642219, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 90, 0, 90, 0, 90, 0, 90, 0, 66, 128, 55, 0 },
             new byte[] { 92, 179, 93, 114, 93, 114, 92, 179, 68, 125, 56, 165 }, 642222, 642233, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 42, 128, 45, 0, 47, 128, 50, 0, 55, 0, 60, 0 },
             new byte[] { 46, 70, 51, 89, 53, 236, 56, 127, 61, 166, 69, 76 }, 643068, 643079, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 73, 192, 82, 128, 90, 0, 90, 0, 66, 128, 55, 0 },
             new byte[] { 82, 54, 93, 56, 93, 114, 92, 179, 68, 125, 56, 165 }, 643082, 643093, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 47, 128, 50, 0, 52, 128, 55, 0, 60, 0, 67, 128 },
             new byte[] { 51, 108, 56, 127, 59, 18, 64, 38, 71, 203, 77, 5 }, 643114, 643125, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 82, 128, 90, 0, 90, 0, 90, 0, 66, 128, 55, 0 },
             new byte[] { 92, 121, 93, 114, 93, 114, 92, 179, 68, 125, 56, 165 }, 643128, 643139, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 50, 0, 55, 0, 57, 128, 62, 128, 70, 0, 75, 0 },
             new byte[] { 56, 127, 61, 166, 69, 57, 71, 223, 77, 25, 79, 192 }, 643160, 643171, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 90, 0, 90, 0, 90, 0, 90, 0, 66, 128, 55, 0 },
             new byte[] { 92, 179, 93, 114, 93, 114, 92, 179, 68, 125, 56, 165 }, 643174, 643185, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 55, 0, 60, 0, 67, 128, 70, 0, 75, 0, 77, 128 },
             new byte[] { 56, 165, 61, 203, 72, 6, 75, 152, 79, 192, 79, 211 }, 643206, 643217, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 90, 0, 90, 0, 90, 0, 90, 0, 66, 128, 55, 0 },
             new byte[] { 92, 179, 93, 114, 93, 114, 92, 179, 68, 125, 56, 165 }, 643220, 643231, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 55, 0, 60, 0, 70, 0, 73, 128, 77, 128, 77, 128 },
             new byte[] { 56, 165, 61, 203, 72, 24, 75, 180, 79, 211, 79, 211 }, 643252, 643263, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 90, 0, 90, 0, 90, 0, 90, 0, 66, 128, 55, 0 },
             new byte[] { 92, 179, 93, 114, 93, 114, 92, 179, 68, 125, 56, 165 }, 643266, 643277, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 45, 0, 50, 0, 52, 128, 55, 0, 60, 0, 67, 128 },
             new byte[] { 46, 70, 51, 89, 53, 236, 56, 127, 61, 166, 69, 76 }, 645200, 645211, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 80, 0, 90, 0, 90, 0, 90, 0, 66, 128, 55, 0 },
             new byte[] { 82, 54, 93, 56, 93, 114, 92, 179, 68, 125, 56, 165 }, 645214, 645225, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 50, 0, 55, 0, 57, 128, 62, 128, 70, 0, 75, 0 },
             new byte[] { 51, 108, 56, 127, 59, 18, 64, 38, 71, 203, 77, 5 }, 645246, 645257, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 90, 0, 90, 0, 90, 0, 90, 0, 66, 128, 55, 0 },
             new byte[] { 92, 121, 93, 114, 93, 114, 92, 179, 68, 125, 56, 165 }, 645260, 645271, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 55, 0, 60, 0, 67, 128, 70, 0, 75, 0, 77, 128 },
             new byte[] { 56, 127, 61, 166, 69, 57, 71, 223, 77, 25, 79, 192 }, 645292, 645303, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 90, 0, 90, 0, 90, 0, 90, 0, 66, 128, 55, 0 },
             new byte[] { 92, 179, 93, 114, 93, 114, 92, 179, 68, 125, 56, 165 }, 645306, 645317, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 55, 0, 60, 0, 70, 0, 73, 128, 77, 128, 77, 128 },
             new byte[] { 56, 165, 61, 203, 72, 6, 75, 152, 79, 192, 79, 211 }, 645338, 645349, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 90, 0, 90, 0, 90, 0, 90, 0, 66, 128, 55, 0 },
             new byte[] { 92, 179, 93, 114, 93, 114, 92, 179, 68, 125, 56, 165 }, 645352, 645363, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 55, 0, 60, 0, 70, 0, 73, 128, 77, 128, 77, 128 },
             new byte[] { 56, 165, 61, 203, 72, 24, 75, 180, 79, 211, 79, 211 }, 645384, 645395, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 90, 0, 90, 0, 90, 0, 90, 0, 66, 128, 55, 0 },
             new byte[] { 92, 179, 93, 114, 93, 114, 92, 179, 68, 125, 56, 165 }, 645398, 645409, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 43, 192, 43, 192, 47, 48, 56, 224, 63, 192, 65, 0, 68, 32 },
             new byte[] { 45, 16, 45, 16, 48, 154, 58, 148, 65, 168, 66, 243, 70, 42 }, 666494, 666507, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 56, 64, 56, 64, 59, 96, 62, 208, 69, 96, 69, 96, 70, 0 },
             new byte[] { 57, 240, 57, 240, 61, 40, 64, 177, 71, 115, 71, 115, 72, 24 }, 666530, 666543, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 62, 128, 63, 192, 65, 160, 69, 96, 70, 0, 70, 240, 71, 224 },
             new byte[] { 64, 96, 65, 168, 67, 152, 71, 115, 72, 24, 73, 16, 74, 8 }, 666566, 666579, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 65, 160, 68, 192, 68, 192, 71, 64, 71, 224, 72, 128, 73, 112 },
             new byte[] { 67, 152, 70, 208, 70, 208, 73, 98, 74, 8, 74, 171, 75, 164 }, 666602, 666615, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 67, 208, 70, 160, 71, 224, 72, 208, 73, 112, 74, 16, 75, 80 },
             new byte[] { 69, 216, 72, 189, 74, 8, 74, 255, 75, 164, 76, 71, 77, 146 }, 666638, 666651, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 63, 192, 66, 224, 69, 96, 71, 224, 73, 112, 75, 0, 75, 80, 75, 160, 77, 48, 76, 224, 76, 64 },
             new byte[] { 64, 130, 67, 156, 71, 133, 74, 8, 75, 164, 77, 64, 77, 146, 78, 127, 79, 127, 78, 105, 77, 198 }, 666670, 666691, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 66, 64, 69, 96, 71, 224, 73, 32, 74, 176, 76, 144, 76, 224, 77, 48, 79, 16, 78, 192, 78, 112, 81, 64 },
             new byte[] { 67, 147, 71, 115, 75, 71, 76, 148, 78, 51, 80, 40, 80, 105, 81, 189, 83, 187, 83, 100, 81, 126, 83, 218 }, 666706, 666729, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 67, 208, 71, 224, 73, 112, 75, 0, 76, 96, 78, 112, 78, 192, 79, 16, 80, 160, 80, 160, 82, 128, 81, 64 },
             new byte[] { 69, 43, 74, 8, 76, 232, 78, 135, 79, 246, 82, 26, 81, 191, 83, 26, 85, 74, 85, 67, 85, 143, 83, 218 }, 666742, 666765, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 73, 192, 74, 176, 75, 160, 76, 144, 78, 112, 79, 16, 80, 160, 81, 64, 82, 48, 82, 128, 82, 128, 81, 64 },
             new byte[] { 75, 57, 76, 237, 79, 45, 80, 38, 82, 17, 82, 186, 84, 55, 85, 174, 86, 218, 87, 36, 85, 143, 83, 218 }, 666778, 666801, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 73, 192, 74, 176, 75, 160, 76, 144, 78, 112, 80, 160, 80, 160, 81, 64, 82, 48, 82, 128, 82, 128, 81, 64 },
             new byte[] { 75, 57, 76, 237, 79, 45, 80, 135, 82, 115, 84, 75, 84, 55, 85, 174, 86, 218, 87, 36, 85, 143, 83, 218 }, 666814, 666837, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 73, 192, 74, 176, 75, 160, 76, 144, 78, 112, 80, 160, 80, 160, 81, 64, 82, 48, 82, 128, 82, 128, 81, 64 },
             new byte[] { 75, 57, 76, 237, 79, 45, 80, 135, 82, 115, 84, 75, 84, 55, 85, 174, 86, 218, 87, 36, 85, 143, 83, 218 }, 666850, 666873, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 35, 44, 36, 102, 37, 128, 42, 41, 44, 96, 56, 61, 62, 239 },
             new byte[] { 36, 123, 37, 181, 38, 222, 43, 207, 46, 56, 58, 30, 64, 232 }, 667566, 667579, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 43, 192, 44, 63, 47, 186, 50, 0, 58, 227, 68, 30, 67, 40 },
             new byte[] { 45, 112, 45, 238, 49, 130, 51, 210, 60, 229, 70, 32, 69, 47 }, 667602, 667615, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 48, 192, 53, 68, 57, 186, 62, 128, 68, 192, 72, 93, 73, 180 },
             new byte[] { 50, 160, 55, 29, 59, 177, 64, 131, 70, 198, 74, 107, 75, 219 }, 667638, 667651, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 62, 224, 68, 72, 67, 176, 69, 80, 72, 104, 73, 151, 75, 0 },
             new byte[] { 64, 216, 70, 88, 69, 192, 71, 95, 74, 143, 75, 176, 77, 52 }, 667674, 667687, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 69, 231, 72, 17, 74, 67, 75, 41, 73, 163, 74, 209, 75, 240 },
             new byte[] { 71, 222, 74, 29, 76, 106, 77, 68, 75, 214, 76, 245, 78, 30 }, 667710, 667723, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 0 },
             new byte[] { 178 }, 667743, 667743, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 83, 70, 87, 72, 208, 73, 112, 75, 0, 75, 80, 75, 224, 78, 0, 78, 80, 76, 232 },
             new byte[] { 253, 72, 107, 74, 247, 75, 164, 77, 64, 77, 126, 78, 172, 80, 61, 79, 197, 78, 90 }, 667745, 667763, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 60, 224, 70, 25, 71, 228, 73, 232, 74, 176, 76, 144, 76, 224, 78, 0, 79, 80, 80, 104, 78, 112, 81, 64 },
             new byte[] { 62, 34, 72, 28, 74, 195, 76, 193, 77, 153, 79, 120, 80, 55, 82, 122, 83, 250, 85, 10, 81, 106, 83, 202 }, 667778, 667801, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 67, 208, 71, 224, 73, 112, 75, 0, 75, 240, 76, 96, 77, 16, 79 },
             new byte[] { 69, 25, 74, 8, 77, 39, 78, 200, 79, 177, 80, 54, 80, 254, 83 }, 667814, 667828, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 80, 160, 82, 128, 82, 128, 81, 64 },
             new byte[] { 85, 74, 87, 36, 85, 123, 83, 202 }, 667830, 667837, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 73, 192, 74, 176, 75, 160, 76, 144, 78, 112, 79, 16, 80, 160, 81, 64, 82, 48, 82, 128, 82, 128, 81, 64 },
             new byte[] { 75, 37, 76, 218, 79, 191, 80, 182, 82, 161, 83, 75, 84, 235, 85, 155, 86, 218, 87, 36, 85, 123, 83, 202 }, 667850, 667873, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 73, 192, 74, 176, 75, 160, 76, 144, 78, 112, 80, 160, 80, 160, 81, 64, 82, 48, 82, 128, 82, 128, 81, 64 },
             new byte[] { 75, 37, 76, 218, 79, 191, 81, 23, 83, 1, 84, 218, 84, 235, 85, 155, 86, 218, 87, 36, 85, 123, 83, 202 }, 667886, 667909, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 73, 192, 74, 176, 75, 160, 76, 144, 78, 112, 80, 160, 80, 160, 81, 64, 82, 48, 82, 128, 82, 128, 81, 64 },
             new byte[] { 75, 37, 76, 218, 79, 191, 81, 23, 83, 1, 84, 218, 84, 235, 85, 155, 86, 218, 87, 36, 85, 123, 83, 202 }, 667922, 667945, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 35, 44, 36, 102, 37, 128, 42, 41, 44, 96, 56, 61, 62, 239 },
             new byte[] { 36, 123, 37, 181, 38, 222, 43, 207, 46, 56, 58, 30, 64, 232 }, 668638, 668651, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 43, 192, 44, 63, 47, 186, 50, 0, 58, 227, 68, 30, 67, 40 },
             new byte[] { 45, 112, 45, 238, 49, 130, 51, 210, 60, 229, 70, 32, 69, 47 }, 668674, 668687, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 48, 192, 53, 68, 57, 186, 62, 128, 68, 192, 72, 93, 73, 180 },
             new byte[] { 50, 160, 55, 29, 59, 177, 64, 131, 70, 198, 74, 107, 75, 219 }, 668710, 668723, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 62, 224, 68, 72, 67, 176, 69, 80, 72, 104, 73, 151, 75, 0 },
             new byte[] { 64, 216, 70, 88, 69, 192, 71, 95, 74, 143, 75, 176, 77, 52 }, 668746, 668759, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 69, 231, 72, 17, 74, 67, 75, 41, 73, 163, 74, 209, 75, 240 },
             new byte[] { 71, 222, 74, 29, 76, 106, 77, 68, 75, 214, 76, 245, 78, 30 }, 668782, 668795, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 0 },
             new byte[] { 178 }, 668815, 668815, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 83, 70, 87, 72, 208, 73, 112, 75, 0, 75, 80, 75, 224, 78, 0, 78, 80, 76, 232 },
             new byte[] { 253, 72, 107, 74, 247, 75, 164, 77, 64, 77, 126, 78, 172, 80, 61, 79, 197, 78, 90 }, 668817, 668835, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 60, 224, 70, 25, 71, 228, 73, 232, 74, 176, 76, 144, 76, 224, 78, 0, 79, 80, 80, 104, 78, 112, 81, 64 },
             new byte[] { 62, 34, 72, 28, 74, 195, 76, 193, 77, 153, 79, 120, 80, 35, 82, 122, 83, 250, 85, 10, 81, 106, 83, 202 }, 668850, 668873, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 67, 208, 71, 224, 73, 112, 75, 0, 75, 240, 76, 96, 77, 16, 79, 16, 80, 160, 82, 128, 82, 128, 81, 64 },
             new byte[] { 69, 25, 74, 8, 77, 70, 78, 230, 79, 207, 80, 85, 81, 29, 83, 6, 85, 74, 87, 36, 85, 123, 83, 202 }, 668886, 668909, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 73, 192, 74, 176, 75, 160, 76, 144, 78, 112, 79, 16, 80, 160, 81, 64, 82, 48, 82, 128, 82, 128, 81, 64 },
             new byte[] { 75, 37, 76, 218, 79, 121, 80, 113, 82, 91, 83, 4, 85, 10, 85, 155, 86, 218, 87, 36, 85, 123, 83, 202 }, 668922, 668945, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 73, 192, 74, 176, 75, 160, 76, 144, 78, 112, 80, 160, 80, 160, 81, 64, 82, 48, 82, 128, 82, 128, 81, 64 },
             new byte[] { 75, 37, 76, 218, 79, 121, 80, 210, 82, 187, 84, 148, 85, 10, 85, 155, 86, 218, 87, 36, 85, 123, 83, 202 }, 668958, 668981, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 73, 192, 74, 176, 75, 160, 76, 144, 78, 112, 80, 160, 80, 160, 81, 64, 82, 48, 82, 128, 82, 128, 81, 64 },
             new byte[] { 75, 37, 76, 218, 79, 121, 80, 210, 82, 187, 84, 148, 85, 10, 85, 155, 86, 218, 87, 36, 85, 123, 83, 202 }, 668994, 669017, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 43, 192, 43, 192, 47, 48, 56, 224, 63, 192, 65, 0, 68, 32 },
             new byte[] { 45, 16, 45, 16, 48, 141, 58, 133, 65, 153, 66, 226, 70, 24 }, 669710, 669723, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 56, 64, 56, 64, 59, 96, 62, 208, 69, 96, 69, 96, 70, 0 },
             new byte[] { 57, 240, 57, 240, 61, 40, 64, 161, 71, 99, 71, 99, 72, 7 }, 669746, 669759, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 62, 128, 63, 192, 65, 160, 69, 96, 70, 0, 70, 240, 71, 224 },
             new byte[] { 64, 96, 65, 153, 67, 152, 71, 99, 72, 7, 72, 253, 74, 8 }, 669782, 669795, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 65, 160, 68, 192, 68, 192, 71, 64, 71, 224, 72, 128, 73, 112 },
             new byte[] { 67, 152, 70, 208, 70, 208, 73, 80, 74, 8, 74, 154, 75, 164 }, 669818, 669831, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 67, 208, 70, 160, 71, 224, 72, 208, 73, 112, 74, 16, 75, 80 },
             new byte[] { 69, 198, 72, 171, 74, 8, 74, 236, 75, 164, 76, 52, 77, 126 }, 669854, 669867, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 63, 192, 66, 224, 69, 96, 71, 224, 73, 112, 75, 0, 75, 80, 75, 160, 77, 48, 76, 224, 76, 64 },
             new byte[] { 64, 115, 67, 139, 71, 115, 74, 8, 75, 164, 77, 64, 77, 126, 78, 107, 79, 109, 78, 84, 77, 177 }, 669886, 669907, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 66, 64, 69, 96, 71, 224, 73, 32, 74, 176, 76, 144, 76, 224, 77, 48, 79, 16, 78, 192, 78, 112, 81, 64 },
             new byte[] { 67, 130, 71, 99, 74, 192, 75, 249, 77, 153, 79, 160, 80, 85, 81, 169, 83, 187, 83, 100, 81, 106, 83, 202 }, 669922, 669945, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 67, 208, 71, 224, 73, 112, 75, 0, 76, 96, 78, 112, 78, 192, 79, 16, 80, 160, 80, 160, 82, 128, 81, 64 },
             new byte[] { 69, 25, 74, 8, 77, 60, 78, 219, 80, 54, 82, 91, 82, 135, 83, 6, 85, 74, 85, 67, 85, 123, 83, 202 }, 669958, 669981, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 73, 192, 74, 176, 75, 160, 76, 144, 78, 112, 79, 16, 80, 160, 81, 64, 82, 48, 82, 128, 82, 128, 81, 64 },
             new byte[] { 75, 37, 76, 218, 79, 110, 80, 103, 82, 80, 82, 250, 84, 255, 85, 155, 86, 218, 87, 36, 85, 123, 83, 202 }, 669994, 670017, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 73, 192, 74, 176, 75, 160, 76, 144, 78, 112, 80, 160, 80, 160, 81, 64, 82, 48, 82, 128, 82, 128, 81, 64 },
             new byte[] { 75, 37, 76, 218, 79, 110, 80, 200, 82, 178, 84, 138, 84, 255, 85, 155, 86, 218, 87, 36, 85, 123, 83, 202 }, 670030, 670053, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 73, 192, 74, 176, 75, 160, 76, 144, 78, 112, 80, 160, 80, 160, 81, 64, 82, 48, 82, 128, 82, 128, 81, 64 },
             new byte[] { 75, 37, 76, 218, 79, 110, 80, 200, 82, 178, 84, 138, 84, 255, 85, 155, 86, 218, 87, 36, 85, 123, 83, 202 }, 670066, 670089, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 56, 224, 60, 160, 60, 0, 57, 128, 56, 224, 56, 144, 56, 224 },
             new byte[] { 58, 148, 62, 113, 61, 188, 59, 41, 58, 133, 58, 50, 58, 133 }, 670782, 670795, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 67, 128, 70, 0, 70, 160, 67, 224, 65, 64, 63, 160, 63, 64 },
             new byte[] { 69, 133, 72, 24, 72, 189, 69, 215, 67, 36, 65, 119, 65, 21 }, 670818, 670831, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 75, 176, 76, 64, 73, 192, 71, 224, 69, 176, 67, 224, 67, 16 },
             new byte[] { 77, 244, 78, 118, 75, 245, 73, 245, 71, 181, 69, 215, 69, 18 }, 670854, 670867, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 77, 128, 76, 64, 74, 192, 73, 32, 72, 32, 71, 80, 70, 80 },
             new byte[] { 79, 211, 78, 136, 76, 254, 75, 61, 74, 73, 73, 97, 72, 108 }, 670890, 670903, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 77, 128, 76, 64, 76, 48, 75, 0, 74, 48, 73, 96, 72, 192 },
             new byte[] { 79, 190, 78, 118, 78, 120, 77, 44, 76, 105, 75, 128, 74, 219 }, 670926, 670939, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 77, 128 },
             new byte[] { 78, 90 }, 670958, 670959, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 32, 78, 32, 78, 32, 77, 48, 76, 208, 76, 48, 76, 0, 76, 64, 75, 80, 71, 224 },
             new byte[] { 232, 80, 120, 80, 120, 79, 127, 79, 28, 78, 100, 78, 207, 78, 118, 76, 189, 73, 61 }, 670961, 670979, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 78, 112, 78, 192, 78, 232, 79, 16, 78, 160, 78, 208, 78, 32, 77, 128, 76, 64, 75, 80, 71, 224, 68, 192 },
             new byte[] { 79, 237, 81, 7, 82, 16, 82, 36, 81, 193, 81, 217, 81, 214, 81, 114, 80, 234, 79, 239, 74, 173, 71, 110 }, 670994, 671017, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 78, 112, 78, 192, 78, 232, 79, 16, 78, 232, 78, 192, 78, 32, 77, 128, 76, 64, 75, 80, 71, 224, 68, 192 },
             new byte[] { 79, 237, 81, 28, 82, 195, 82, 237, 82, 175, 82, 132, 82, 138, 81, 114, 80, 234, 79, 239, 74, 173, 71, 110 }, 671030, 671053, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 78, 112, 78, 192, 78, 232, 79, 16, 78, 232, 78, 192, 78, 32, 77, 128, 76, 64, 75, 80, 71, 224, 68, 192 },
             new byte[] { 79, 237, 81, 7, 82, 175, 82, 216, 82, 175, 82, 132, 82, 138, 81, 213, 80, 234, 79, 239, 74, 173, 71, 110 }, 671066, 671089, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 78, 112, 78, 192, 78, 232, 79, 16, 78, 232, 78, 192, 78, 32, 77, 128, 76, 64, 75, 80, 71, 224, 68, 192 },
             new byte[] { 79, 237, 81, 7, 82, 175, 83, 62, 83, 20, 82, 132, 82, 138, 81, 213, 80, 234, 79, 239, 74, 173, 71, 110 }, 671102, 671125, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 78, 112, 78, 192, 78, 232, 79, 16, 78, 232, 78, 192, 78, 32, 77, 128, 76, 64, 75, 80, 71, 224, 68, 192 },
             new byte[] { 79, 237, 81, 7, 82, 175, 83, 62, 83, 20, 82, 132, 82, 138, 81, 213, 80, 234, 79, 239, 74, 173, 71, 110 }, 671138, 671161, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 56, 224, 60, 160, 60, 0, 57, 128, 56, 224, 56, 144, 56, 224 },
             new byte[] { 58, 148, 62, 113, 61, 188, 59, 41, 58, 133, 58, 50, 58, 133 }, 671854, 671867, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 67, 128, 70, 0, 70, 160, 67, 224, 65, 64, 63, 160, 63, 64 },
             new byte[] { 69, 133, 72, 24, 72, 189, 69, 215, 67, 36, 65, 119, 65, 21 }, 671890, 671903, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 75, 176, 76, 64, 73, 192, 71, 224, 69, 176, 67, 224, 67, 16 },
             new byte[] { 77, 244, 78, 118, 75, 245, 73, 245, 71, 181, 69, 215, 69, 18 }, 671926, 671939, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 77, 128, 76, 64, 74, 192, 73, 32, 72, 32, 71, 80, 70, 80 },
             new byte[] { 79, 211, 78, 136, 76, 254, 75, 61, 74, 73, 73, 97, 72, 108 }, 671962, 671975, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 77, 128, 76, 64, 76, 48, 75, 0, 74, 48, 73, 96, 72, 192 },
             new byte[] { 79, 190, 78, 118, 78, 120, 77, 44, 76, 105, 75, 128, 74, 219 }, 671998, 672011, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 77, 128 },
             new byte[] { 78, 90 }, 672030, 672031, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 32, 78, 32, 78, 32, 77, 48, 76, 208, 76, 48, 76, 0, 76, 64, 75, 80, 71, 224 },
             new byte[] { 232, 80, 120, 80, 120, 79, 127, 79, 28, 78, 100, 78, 207, 78, 118, 76, 189, 73, 61 }, 672033, 672051, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 78, 112, 78, 192, 78, 232, 79, 16, 78, 160, 78, 208, 78, 32, 77, 128, 76, 64, 75, 80, 71, 224, 68, 192 },
             new byte[] { 79, 237, 81, 7, 82, 16, 82, 36, 81, 184, 81, 217, 81, 214, 81, 114, 80, 234, 79, 239, 74, 173, 71, 110 }, 672066, 672089, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 78, 112, 78, 192, 78, 232, 79, 16, 78, 232, 78, 192, 78, 32, 77, 128, 76, 64, 75, 80, 71, 224, 68, 192 },
             new byte[] { 79, 237, 81, 28, 82, 165, 82, 206, 82, 145, 82, 102, 82, 108, 81, 114, 80, 234, 79, 239, 74, 173, 71, 110 }, 672102, 672125, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 78, 112, 78, 192, 78, 232, 79, 16, 78, 232, 78, 192, 78, 32, 77, 128, 76, 64, 75, 80, 71, 224, 68, 192 },
             new byte[] { 79, 237, 81, 7, 82, 145, 82, 186, 82, 145, 82, 102, 82, 108, 81, 213, 80, 234, 79, 239, 74, 173, 71, 110 }, 672138, 672161, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 78, 112, 78, 192, 78, 232, 79, 16, 78, 232, 78, 192, 78, 32, 77, 128, 76, 64, 75, 80, 71, 224, 68, 192 },
             new byte[] { 79, 237, 81, 7, 82, 145, 83, 31, 82, 246, 82, 102, 82, 108, 81, 213, 80, 234, 79, 239, 74, 173, 71, 110 }, 672174, 672197, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 78, 112, 78, 192, 78, 232, 79, 16, 78, 232, 78, 192, 78, 32, 77, 128, 76, 64, 75, 80, 71, 224, 68, 192 },
             new byte[] { 79, 237, 81, 7, 82, 145, 83, 31, 82, 246, 82, 102, 82, 108, 81, 213, 80, 234, 79, 239, 74, 173, 71, 110 }, 672210, 672233, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 56, 224, 60, 160, 60, 0, 57, 128, 56, 224, 56, 144, 56, 224 },
             new byte[] { 58, 148, 62, 113, 61, 188, 59, 41, 58, 133, 58, 50, 58, 133 }, 672926, 672939, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 67, 128, 70, 0, 70, 160, 67, 224, 65, 64, 63, 160, 63, 64 },
             new byte[] { 69, 133, 72, 24, 72, 189, 69, 215, 67, 36, 65, 119, 65, 21 }, 672962, 672975, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 75, 176, 76, 64, 73, 192, 71, 224, 69, 176, 67, 224, 67, 16 },
             new byte[] { 77, 244, 78, 118, 75, 245, 73, 245, 71, 181, 69, 215, 69, 18 }, 672998, 673011, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 77, 128, 76, 64, 74, 192, 73, 32, 72, 32, 71, 80, 70, 80 },
             new byte[] { 79, 211, 78, 136, 76, 254, 75, 61, 74, 73, 73, 97, 72, 108 }, 673034, 673047, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 77, 128, 76, 64, 76, 48, 75, 0, 74, 48, 73, 96, 72, 192 },
             new byte[] { 79, 190, 78, 118, 78, 120, 77, 44, 76, 105, 75, 128, 74, 219 }, 673070, 673083, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 77, 128 },
             new byte[] { 78, 90 }, 673102, 673103, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 32, 78, 32, 78, 32, 77, 48, 76, 208, 76, 48, 76, 0, 76, 64, 75, 80, 71, 224 },
             new byte[] { 232, 80, 120, 80, 120, 79, 127, 79, 28, 78, 100, 78, 207, 78, 118, 76, 189, 73, 61 }, 673105, 673123, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 78, 112, 78, 192, 78, 232, 79, 16, 78, 160, 78, 208, 78, 32, 77, 128, 76, 64, 75, 80, 71, 224, 68, 192 },
             new byte[] { 79, 237, 81, 7, 82, 16, 82, 36, 81, 193, 81, 217, 81, 214, 81, 114, 80, 234, 79, 239, 74, 173, 71, 110 }, 673138, 673161, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 78, 112, 78, 192, 78, 232, 79, 16, 78, 232, 78, 192, 78, 32, 77, 128, 76, 64, 75, 80, 71, 224, 68, 192 },
             new byte[] { 79, 237, 81, 28, 82, 165, 82, 206, 82, 145, 82, 102, 82, 108, 81, 114, 80, 234, 79, 239, 74, 173, 71, 110 }, 673174, 673197, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 78, 112, 78, 192, 78, 232, 79, 16, 78, 232, 78, 192, 78, 32, 77, 128, 76, 64, 75, 80, 71, 224, 68, 192 },
             new byte[] { 79, 237, 81, 7, 82, 145, 82, 186, 82, 145, 82, 102, 82, 108, 81, 213, 80, 234, 79, 239, 74, 173, 71, 110 }, 673210, 673233, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 78, 112, 78, 192, 78, 232, 79, 16, 78, 232, 78, 192, 78, 32, 77, 128, 76, 64, 75, 80, 71, 224, 68, 192 },
             new byte[] { 79, 237, 81, 7, 82, 145, 83, 31, 82, 246, 82, 102, 82, 108, 81, 213, 80, 234, 79, 239, 74, 173, 71, 110 }, 673246, 673269, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 78, 112, 78, 192, 78, 232, 79, 16, 78, 232, 78, 192, 78, 32, 77, 128, 76, 64, 75, 80, 71, 224, 68, 192 },
             new byte[] { 79, 237, 81, 7, 82, 145, 83, 31, 82, 246, 82, 102, 82, 108, 81, 213, 80, 234, 79, 239, 74, 173, 71, 110 }, 673282, 673305, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 56, 224, 60, 160, 60, 0, 57, 128, 56, 224, 56, 144, 56, 224 },
             new byte[] { 58, 148, 62, 113, 61, 188, 59, 41, 58, 133, 58, 50, 58, 133 }, 673998, 674011, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 67, 128, 70, 0, 70, 160, 67, 224, 65, 64, 63, 160, 63, 64 },
             new byte[] { 69, 133, 72, 24, 72, 189, 69, 215, 67, 36, 65, 119, 65, 21 }, 674034, 674047, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 75, 176, 76, 64, 73, 192, 71, 224, 69, 176, 67, 224, 67, 16 },
             new byte[] { 77, 244, 78, 118, 75, 245, 73, 245, 71, 181, 69, 215, 69, 18 }, 674070, 674083, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 77, 128, 76, 64, 74, 192, 73, 32, 72, 32, 71, 80, 70, 80 },
             new byte[] { 79, 211, 78, 136, 76, 254, 75, 61, 74, 73, 73, 97, 72, 108 }, 674106, 674119, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 77, 128, 76, 64, 76, 48, 75, 0, 74, 48, 73, 96, 72, 192 },
             new byte[] { 79, 190, 78, 118, 78, 120, 77, 44, 76, 105, 75, 128, 74, 219 }, 674142, 674155, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 77, 128 },
             new byte[] { 78, 90 }, 674174, 674175, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 32, 78, 32, 78, 32, 77, 48, 76, 208, 76, 48, 76, 0, 76, 64, 75, 80, 71, 224 },
             new byte[] { 232, 80, 120, 80, 120, 79, 127, 79, 28, 78, 100, 78, 207, 78, 118, 76, 189, 73, 61 }, 674177, 674195, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 78, 112, 78, 192, 78, 232, 79, 16, 78, 160, 78, 208, 78, 32, 77, 128, 76, 64, 75, 80, 71, 224, 68, 192 },
             new byte[] { 79, 237, 81, 7, 82, 16, 82, 36, 81, 176, 81, 217, 81, 214, 81, 114, 80, 234, 79, 239, 74, 173, 71, 110 }, 674210, 674233, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 78, 112, 78, 192, 78, 232, 79, 16, 78, 232, 78, 192, 78, 32, 77, 128, 76, 64, 75, 80, 71, 224, 68, 192 },
             new byte[] { 79, 237, 81, 28, 82, 165, 82, 206, 82, 145, 82, 102, 82, 108, 81, 114, 80, 234, 79, 239, 74, 173, 71, 110 }, 674246, 674269, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 78, 112, 78, 192, 78, 232, 79, 16, 78, 232, 78, 192, 78, 32, 77, 128, 76, 64, 75, 80, 71, 224, 68, 192 },
             new byte[] { 79, 237, 81, 7, 82, 145, 82, 186, 82, 145, 82, 102, 82, 108, 81, 213, 80, 234, 79, 239, 74, 173, 71, 110 }, 674282, 674305, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 78, 112, 78, 192, 78, 232, 79, 16, 78, 232, 78, 192, 78, 32, 77, 128, 76, 64, 75, 80, 71, 224, 68, 192 },
             new byte[] { 79, 237, 81, 7, 82, 145, 83, 31, 82, 246, 82, 102, 82, 108, 81, 213, 80, 234, 79, 239, 74, 173, 71, 110 }, 674318, 674341, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 78, 112, 78, 192, 78, 232, 79, 16, 78, 232, 78, 192, 78, 32, 77, 128, 76, 64, 75, 80, 71, 224, 68, 192 },
             new byte[] { 79, 237, 81, 7, 82, 145, 83, 31, 82, 246, 82, 102, 82, 108, 81, 213, 80, 234, 79, 239, 74, 173, 71, 110 }, 674354, 674377, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 72, 16, 76, 144, 78, 160, 80, 160, 81, 112, 82, 48, 82, 128, 82, 208 },
             new byte[] { 76, 117, 81, 46, 83, 89, 85, 115, 86, 167, 87, 112, 87, 149, 87, 142 }, 674504, 674519, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 74, 176, 76, 144, 78, 160, 80, 160, 81, 112, 82, 48, 82, 128, 82, 208 },
             new byte[] { 79, 55, 81, 46, 83, 89, 85, 115, 86, 167, 87, 112, 87, 149, 87, 142 }, 674524, 674539, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 82, 128, 82, 128, 82, 128, 82, 128, 82, 128, 82, 128, 82, 128, 82, 128, 82, 128, 82, 128, 69, 176, 63, 16, 58, 32, 55, 0, 51, 64 },
             new byte[] { 87, 149, 87, 149, 87, 149, 87, 149, 87, 149, 87, 149, 87, 149, 87, 149, 87, 149, 87, 149, 73, 240, 66, 250, 62, 66, 58, 248, 54, 144 }, 674590, 674619, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 233 },
             new byte[] { 244 }, 682523, 682523, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 82, 6, 109, 6, 128, 6, 148, 6, 143 },
             new byte[] { 202, 7, 3, 7, 40, 7, 51, 7, 43 }, 685401, 685409, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 44, 5, 172, 5, 102 },
             new byte[] { 242, 6, 150, 6, 82 }, 685411, 685415, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 108 },
             new byte[] { 241 }, 685417, 685417, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 74 },
             new byte[] { 142 }, 685419, 685419, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 3 },
             new byte[] { 19 }, 685421, 685421, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 151 },
             new byte[] { 232 }, 685423, 685423, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 59, 7, 159, 7, 230 },
             new byte[] { 192, 8, 10, 8, 51 }, 685447, 685451, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 0 },
             new byte[] { 70 }, 685453, 685453, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 13, 7, 128 },
             new byte[] { 76, 8, 16 }, 685455, 685457, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 0, 6, 131 },
             new byte[] { 194, 7, 84 }, 685459, 685461, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 18, 5, 220 },
             new byte[] { 250, 6, 115 }, 685463, 685465, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 141 },
             new byte[] { 191 }, 685467, 685467, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 100 },
             new byte[] { 154 }, 685469, 685469, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 7, 230, 8, 77, 8, 179, 8, 184, 8, 182, 8, 33, 7, 105, 7, 20, 6, 215, 6, 123 },
             new byte[] { 8, 234, 9, 115, 9, 241, 10, 55, 10, 73, 10, 57, 9, 192, 9, 42, 8, 137, 7, 173 }, 685492, 685511, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 49 },
             new byte[] { 208 }, 685513, 685513, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 64 },
             new byte[] { 226 }, 685515, 685515, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 9, 148, 9, 179, 9, 154, 9, 102, 9, 51, 9, 92, 8, 220, 7, 236, 7, 77, 6, 230, 6, 151, 6, 133 },
             new byte[] { 10, 42, 11, 3, 11, 73, 11, 76, 11, 89, 11, 56, 11, 6, 10, 190, 10, 109, 9, 238, 9, 50, 7, 216 }, 685538, 685561, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 9, 148, 9, 179, 9, 154, 9, 102, 9, 51, 9, 92, 9, 13, 8, 128, 8, 51, 7, 218, 7, 154, 7, 85 },
             new byte[] { 10, 42, 11, 3, 11, 73, 11, 76, 11, 89, 11, 56, 11, 6, 10, 191, 10, 110, 9, 238, 9, 49, 8, 68 }, 685584, 685607, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 8, 195, 8, 223, 8, 200, 8, 210, 8, 218, 8, 218, 8, 182, 8, 105, 8, 51, 7, 131 },
             new byte[] { 10, 40, 11, 5, 11, 4, 11, 7, 11, 10, 10, 226, 10, 200, 10, 108, 9, 213, 8, 39 }, 686188, 686207, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 8, 195, 8, 223, 8, 200, 8, 210, 8, 218, 8, 218, 8, 182, 8, 105, 8, 51, 7, 131 },
             new byte[] { 10, 40, 11, 5, 11, 4, 11, 7, 11, 10, 10, 226, 10, 200, 10, 108, 9, 213, 8, 39 }, 686234, 686253, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 48 },
             new byte[] { 64 }, 763957, 763957, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 80 },
             new byte[] { 96 }, 763961, 763961, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 152 },
             new byte[] { 160 }, 763965, 763965, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 48 },
             new byte[] { 64 }, 764049, 764049, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 80 },
             new byte[] { 112 }, 764053, 764053, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 152 },
             new byte[] { 168 }, 764057, 764057, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 200 },
             new byte[] { 208 }, 764061, 764061, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 192 },
             new byte[] { 200 }, 764065, 764065, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 160 },
             new byte[] { 168 }, 764069, 764069, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 148 },
             new byte[] { 151 }, 764073, 764073, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 148 },
             new byte[] { 151 }, 764077, 764077, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 148 },
             new byte[] { 151 }, 764081, 764081, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 148 },
             new byte[] { 151 }, 764085, 764085, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 148 },
             new byte[] { 151 }, 764089, 764089, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 160 },
             new byte[] { 168 }, 764093, 764093, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 168 },
             new byte[] { 176 }, 764097, 764097, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 48 },
             new byte[] { 80 }, 764141, 764141, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 96 },
             new byte[] { 127 }, 764145, 764145, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 160 },
             new byte[] { 175 }, 764149, 764149, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 200 },
             new byte[] { 208 }, 764153, 764153, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 192 },
             new byte[] { 207 }, 764157, 764157, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 160 },
             new byte[] { 175 }, 764161, 764161, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 148 },
             new byte[] { 160 }, 764165, 764165, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 148 },
             new byte[] { 160 }, 764169, 764169, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 148 },
             new byte[] { 160 }, 764173, 764173, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 148 },
             new byte[] { 160 }, 764177, 764177, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 148 },
             new byte[] { 160 }, 764181, 764181, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 160 },
             new byte[] { 175 }, 764185, 764185, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 168 },
             new byte[] { 184 }, 764189, 764189, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 64 },
             new byte[] { 96 }, 764233, 764233, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 128 },
             new byte[] { 144 }, 764237, 764237, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 176 },
             new byte[] { 191 }, 764241, 764241, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 200 },
             new byte[] { 208 }, 764245, 764245, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 192 },
             new byte[] { 207 }, 764249, 764249, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 160 },
             new byte[] { 175 }, 764253, 764253, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 148 },
             new byte[] { 160 }, 764257, 764257, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 148 },
             new byte[] { 160 }, 764261, 764261, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 148 },
             new byte[] { 160 }, 764265, 764265, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 148 },
             new byte[] { 160 }, 764269, 764269, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 148 },
             new byte[] { 160 }, 764273, 764273, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 160 },
             new byte[] { 175 }, 764277, 764277, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 168 },
             new byte[] { 184 }, 764281, 764281, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 96 },
             new byte[] { 127 }, 764325, 764325, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 144 },
             new byte[] { 160 }, 764329, 764329, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 176 },
             new byte[] { 191 }, 764333, 764333, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 192 },
             new byte[] { 200 }, 764337, 764337, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 192 },
             new byte[] { 207 }, 764341, 764341, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 160 },
             new byte[] { 175 }, 764345, 764345, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 148 },
             new byte[] { 160 }, 764349, 764349, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 148 },
             new byte[] { 160 }, 764353, 764353, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 148 },
             new byte[] { 160 }, 764357, 764357, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 148 },
             new byte[] { 160 }, 764361, 764361, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 148 },
             new byte[] { 160 }, 764365, 764365, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 160 },
             new byte[] { 175 }, 764369, 764369, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 168 },
             new byte[] { 184 }, 764373, 764373, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 144 },
             new byte[] { 152 }, 764417, 764417, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 148 },
             new byte[] { 160 }, 764421, 764421, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 160 },
             new byte[] { 175 }, 764425, 764425, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 184 },
             new byte[] { 199 }, 764429, 764429, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 192 },
             new byte[] { 207 }, 764433, 764433, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 160 },
             new byte[] { 175 }, 764437, 764437, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 148 },
             new byte[] { 160 }, 764441, 764441, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 148 },
             new byte[] { 160 }, 764445, 764445, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 148 },
             new byte[] { 160 }, 764449, 764449, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 148 },
             new byte[] { 160 }, 764453, 764453, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 148 },
             new byte[] { 160 }, 764457, 764457, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 160 },
             new byte[] { 175 }, 764461, 764461, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 168 },
             new byte[] { 184 }, 764465, 764465, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 144 },
             new byte[] { 152 }, 764509, 764509, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 148 },
             new byte[] { 160 }, 764513, 764513, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 160 },
             new byte[] { 175 }, 764517, 764517, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 184 },
             new byte[] { 199 }, 764521, 764521, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 192 },
             new byte[] { 207 }, 764525, 764525, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 160 },
             new byte[] { 175 }, 764529, 764529, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 148 },
             new byte[] { 160 }, 764533, 764533, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 148 },
             new byte[] { 160 }, 764537, 764537, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 148 },
             new byte[] { 160 }, 764541, 764541, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 148 },
             new byte[] { 160 }, 764545, 764545, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 148 },
             new byte[] { 160 }, 764549, 764549, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 160 },
             new byte[] { 175 }, 764553, 764553, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 168 },
             new byte[] { 184 }, 764557, 764557, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 144 },
             new byte[] { 152 }, 764601, 764601, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 148 },
             new byte[] { 160 }, 764605, 764605, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 160 },
             new byte[] { 175 }, 764609, 764609, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 184 },
             new byte[] { 199 }, 764613, 764613, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 192 },
             new byte[] { 207 }, 764617, 764617, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 160 },
             new byte[] { 175 }, 764621, 764621, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 148 },
             new byte[] { 160 }, 764625, 764625, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 148 },
             new byte[] { 160 }, 764629, 764629, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 148 },
             new byte[] { 160 }, 764633, 764633, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 148 },
             new byte[] { 160 }, 764637, 764637, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 148 },
             new byte[] { 160 }, 764641, 764641, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 160 },
             new byte[] { 175 }, 764645, 764645, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 168 },
             new byte[] { 184 }, 764649, 764649, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 200 },
             new byte[] { 208 }, 765977, 765977, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 160 },
             new byte[] { 168 }, 765985, 765985, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 148 },
             new byte[] { 151 }, 765989, 765989, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 148 },
             new byte[] { 151 }, 765993, 765993, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 148 },
             new byte[] { 151 }, 765997, 765997, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 148 },
             new byte[] { 151 }, 766001, 766001, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 148 },
             new byte[] { 151 }, 766005, 766005, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 160 },
             new byte[] { 168 }, 766009, 766009, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 48 },
             new byte[] { 64 }, 766057, 766057, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 96 },
             new byte[] { 112 }, 766061, 766061, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 160 },
             new byte[] { 168 }, 766065, 766065, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 200 },
             new byte[] { 208 }, 766069, 766069, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 192 },
             new byte[] { 200 }, 766073, 766073, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 160 },
             new byte[] { 175 }, 766077, 766077, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 148 },
             new byte[] { 160 }, 766081, 766081, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 148 },
             new byte[] { 160 }, 766085, 766085, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 148 },
             new byte[] { 160 }, 766089, 766089, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 148 },
             new byte[] { 160 }, 766093, 766093, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 148 },
             new byte[] { 160 }, 766097, 766097, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 160 },
             new byte[] { 175 }, 766101, 766101, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 168 },
             new byte[] { 176 }, 766105, 766105, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 64 },
             new byte[] { 80 }, 766149, 766149, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 128 },
             new byte[] { 136 }, 766153, 766153, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 176 },
             new byte[] { 184 }, 766157, 766157, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 200 },
             new byte[] { 216 }, 766161, 766161, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 192 },
             new byte[] { 200 }, 766165, 766165, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 160 },
             new byte[] { 175 }, 766169, 766169, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 148 },
             new byte[] { 160 }, 766173, 766173, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 148 },
             new byte[] { 160 }, 766177, 766177, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 148 },
             new byte[] { 160 }, 766181, 766181, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 148 },
             new byte[] { 160 }, 766185, 766185, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 148 },
             new byte[] { 160 }, 766189, 766189, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 160 },
             new byte[] { 175 }, 766193, 766193, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 168 },
             new byte[] { 176 }, 766197, 766197, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 96 },
             new byte[] { 112 }, 766241, 766241, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 144 },
             new byte[] { 152 }, 766245, 766245, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 176 },
             new byte[] { 191 }, 766249, 766249, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 192 },
             new byte[] { 207 }, 766253, 766253, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 192 },
             new byte[] { 200 }, 766257, 766257, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 160 },
             new byte[] { 175 }, 766261, 766261, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 148 },
             new byte[] { 160 }, 766265, 766265, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 148 },
             new byte[] { 160 }, 766269, 766269, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 148 },
             new byte[] { 160 }, 766273, 766273, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 148 },
             new byte[] { 160 }, 766277, 766277, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 148 },
             new byte[] { 160 }, 766281, 766281, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 160 },
             new byte[] { 175 }, 766285, 766285, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 168 },
             new byte[] { 176 }, 766289, 766289, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 144 },
             new byte[] { 152 }, 766333, 766333, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 148 },
             new byte[] { 160 }, 766337, 766337, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 160 },
             new byte[] { 175 }, 766341, 766341, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 184 },
             new byte[] { 199 }, 766345, 766345, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 192 },
             new byte[] { 207 }, 766349, 766349, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 160 },
             new byte[] { 175 }, 766353, 766353, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 148 },
             new byte[] { 160 }, 766357, 766357, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 148 },
             new byte[] { 160 }, 766361, 766361, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 148 },
             new byte[] { 160 }, 766365, 766365, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 148 },
             new byte[] { 160 }, 766369, 766369, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 148 },
             new byte[] { 160 }, 766373, 766373, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 160 },
             new byte[] { 175 }, 766377, 766377, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 168 },
             new byte[] { 176 }, 766381, 766381, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 144 },
             new byte[] { 152 }, 766425, 766425, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 148 },
             new byte[] { 160 }, 766429, 766429, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 160 },
             new byte[] { 175 }, 766433, 766433, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 184 },
             new byte[] { 199 }, 766437, 766437, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 192 },
             new byte[] { 207 }, 766441, 766441, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 160 },
             new byte[] { 175 }, 766445, 766445, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 148 },
             new byte[] { 160 }, 766449, 766449, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 148 },
             new byte[] { 160 }, 766453, 766453, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 148 },
             new byte[] { 160 }, 766457, 766457, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 148 },
             new byte[] { 160 }, 766461, 766461, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 148 },
             new byte[] { 160 }, 766465, 766465, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 160 },
             new byte[] { 175 }, 766469, 766469, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 168 },
             new byte[] { 176 }, 766473, 766473, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 144 },
             new byte[] { 152 }, 766517, 766517, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 148 },
             new byte[] { 160 }, 766521, 766521, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 160 },
             new byte[] { 175 }, 766525, 766525, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 184 },
             new byte[] { 199 }, 766529, 766529, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 192 },
             new byte[] { 207 }, 766533, 766533, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 160 },
             new byte[] { 175 }, 766537, 766537, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 148 },
             new byte[] { 160 }, 766541, 766541, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 148 },
             new byte[] { 160 }, 766545, 766545, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 148 },
             new byte[] { 160 }, 766549, 766549, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 148 },
             new byte[] { 160 }, 766553, 766553, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 148 },
             new byte[] { 160 }, 766557, 766557, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 160 },
             new byte[] { 175 }, 766561, 766561, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 168 },
             new byte[] { 176 }, 766565, 766565, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 200 },
             new byte[] { 208 }, 767893, 767893, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 160 },
             new byte[] { 168 }, 767901, 767901, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 148 },
             new byte[] { 151 }, 767905, 767905, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 148 },
             new byte[] { 151 }, 767909, 767909, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 148 },
             new byte[] { 151 }, 767913, 767913, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 148 },
             new byte[] { 151 }, 767917, 767917, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 148 },
             new byte[] { 151 }, 767921, 767921, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 160 },
             new byte[] { 168 }, 767925, 767925, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 48 },
             new byte[] { 64 }, 767973, 767973, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 96 },
             new byte[] { 112 }, 767977, 767977, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 160 },
             new byte[] { 168 }, 767981, 767981, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 200 },
             new byte[] { 208 }, 767985, 767985, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 192 },
             new byte[] { 200 }, 767989, 767989, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 160 },
             new byte[] { 175 }, 767993, 767993, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 148 },
             new byte[] { 160 }, 767997, 767997, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 148 },
             new byte[] { 160 }, 768001, 768001, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 148 },
             new byte[] { 160 }, 768005, 768005, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 148 },
             new byte[] { 160 }, 768009, 768009, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 148 },
             new byte[] { 160 }, 768013, 768013, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 160 },
             new byte[] { 175 }, 768017, 768017, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 168 },
             new byte[] { 176 }, 768021, 768021, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 64 },
             new byte[] { 80 }, 768065, 768065, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 128 },
             new byte[] { 136 }, 768069, 768069, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 176 },
             new byte[] { 184 }, 768073, 768073, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 200 },
             new byte[] { 216 }, 768077, 768077, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 192 },
             new byte[] { 200 }, 768081, 768081, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 160 },
             new byte[] { 175 }, 768085, 768085, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 148 },
             new byte[] { 160 }, 768089, 768089, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 148 },
             new byte[] { 160 }, 768093, 768093, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 148 },
             new byte[] { 160 }, 768097, 768097, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 148 },
             new byte[] { 160 }, 768101, 768101, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 148 },
             new byte[] { 160 }, 768105, 768105, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 160 },
             new byte[] { 175 }, 768109, 768109, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 168 },
             new byte[] { 176 }, 768113, 768113, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 96 },
             new byte[] { 112 }, 768157, 768157, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 144 },
             new byte[] { 152 }, 768161, 768161, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 176 },
             new byte[] { 191 }, 768165, 768165, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 192 },
             new byte[] { 207 }, 768169, 768169, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 192 },
             new byte[] { 200 }, 768173, 768173, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 160 },
             new byte[] { 175 }, 768177, 768177, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 148 },
             new byte[] { 160 }, 768181, 768181, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 148 },
             new byte[] { 160 }, 768185, 768185, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 148 },
             new byte[] { 160 }, 768189, 768189, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 148 },
             new byte[] { 160 }, 768193, 768193, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 148 },
             new byte[] { 160 }, 768197, 768197, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 160 },
             new byte[] { 175 }, 768201, 768201, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 168 },
             new byte[] { 176 }, 768205, 768205, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 144 },
             new byte[] { 152 }, 768249, 768249, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 148 },
             new byte[] { 160 }, 768253, 768253, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 160 },
             new byte[] { 175 }, 768257, 768257, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 184 },
             new byte[] { 199 }, 768261, 768261, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 192 },
             new byte[] { 207 }, 768265, 768265, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 160 },
             new byte[] { 175 }, 768269, 768269, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 148 },
             new byte[] { 160 }, 768273, 768273, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 148 },
             new byte[] { 160 }, 768277, 768277, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 148 },
             new byte[] { 160 }, 768281, 768281, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 148 },
             new byte[] { 160 }, 768285, 768285, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 148 },
             new byte[] { 160 }, 768289, 768289, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 160 },
             new byte[] { 175 }, 768293, 768293, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 168 },
             new byte[] { 176 }, 768297, 768297, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 144 },
             new byte[] { 152 }, 768341, 768341, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 148 },
             new byte[] { 160 }, 768345, 768345, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 160 },
             new byte[] { 175 }, 768349, 768349, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 184 },
             new byte[] { 199 }, 768353, 768353, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 192 },
             new byte[] { 207 }, 768357, 768357, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 160 },
             new byte[] { 175 }, 768361, 768361, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 148 },
             new byte[] { 160 }, 768365, 768365, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 148 },
             new byte[] { 160 }, 768369, 768369, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 148 },
             new byte[] { 160 }, 768373, 768373, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 148 },
             new byte[] { 160 }, 768377, 768377, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 148 },
             new byte[] { 160 }, 768381, 768381, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 160 },
             new byte[] { 175 }, 768385, 768385, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 168 },
             new byte[] { 176 }, 768389, 768389, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 144 },
             new byte[] { 152 }, 768433, 768433, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 148 },
             new byte[] { 160 }, 768437, 768437, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 160 },
             new byte[] { 175 }, 768441, 768441, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 184 },
             new byte[] { 199 }, 768445, 768445, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 192 },
             new byte[] { 207 }, 768449, 768449, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 160 },
             new byte[] { 175 }, 768453, 768453, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 148 },
             new byte[] { 160 }, 768457, 768457, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 148 },
             new byte[] { 160 }, 768461, 768461, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 148 },
             new byte[] { 160 }, 768465, 768465, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 148 },
             new byte[] { 160 }, 768469, 768469, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 148 },
             new byte[] { 160 }, 768473, 768473, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 160 },
             new byte[] { 175 }, 768477, 768477, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 168 },
             new byte[] { 176 }, 768481, 768481, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 218, 225, 72 },
             new byte[] { 224, 0, 0 }, 769737, 769739, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 216 },
             new byte[] { 224 }, 769741, 769741, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 216 },
             new byte[] { 224 }, 769745, 769745, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 216 },
             new byte[] { 224 }, 769749, 769749, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 216 },
             new byte[] { 224 }, 769753, 769753, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 200, 163, 215 },
             new byte[] { 208, 0, 0 }, 769801, 769803, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 213, 30, 184 },
             new byte[] { 216, 0, 0 }, 769805, 769807, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224, 163, 215 },
             new byte[] { 232, 0, 0 }, 769809, 769811, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 228, 122, 225 },
             new byte[] { 232, 0, 0 }, 769813, 769815, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 230, 102, 102 },
             new byte[] { 240, 0, 0 }, 769817, 769819, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 230, 102, 102 },
             new byte[] { 240, 0, 0 }, 769821, 769823, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224, 163, 215 },
             new byte[] { 232, 0, 0 }, 769825, 769827, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 218, 225, 72 },
             new byte[] { 232, 0, 0 }, 769829, 769831, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 216 },
             new byte[] { 232 }, 769833, 769833, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 216 },
             new byte[] { 232 }, 769837, 769837, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 216 },
             new byte[] { 232 }, 769841, 769841, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 216 },
             new byte[] { 232 }, 769845, 769845, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 200, 163, 215 },
             new byte[] { 216, 0, 0 }, 769893, 769895, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 213, 30, 184 },
             new byte[] { 223, 0, 0 }, 769897, 769899, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224, 163, 215 },
             new byte[] { 240, 0, 0 }, 769901, 769903, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 228, 122, 225 },
             new byte[] { 239, 0, 0 }, 769905, 769907, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 230, 102, 102 },
             new byte[] { 240, 0, 0 }, 769909, 769911, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 230, 102, 102 },
             new byte[] { 240, 0, 0 }, 769913, 769915, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224, 163, 215 },
             new byte[] { 240, 0, 0 }, 769917, 769919, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 218, 225, 72 },
             new byte[] { 232, 0, 0 }, 769921, 769923, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 216 },
             new byte[] { 232 }, 769925, 769925, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 769929, 769929, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 769933, 769933, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 769937, 769937, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 200, 163, 215 },
             new byte[] { 216, 0, 0 }, 769985, 769987, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 213, 30, 184 },
             new byte[] { 223, 0, 0 }, 769989, 769991, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 218, 102, 102 },
             new byte[] { 232, 0, 0 }, 769993, 769995, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 221, 194, 143 },
             new byte[] { 232, 0, 0 }, 769997, 769999, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 223, 51, 51 },
             new byte[] { 232, 0, 0 }, 770001, 770003, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 222, 184, 82 },
             new byte[] { 232, 0, 0 }, 770005, 770007, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 770009, 770009, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 770013, 770013, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 770017, 770017, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 770021, 770021, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 770025, 770025, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 770029, 770029, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 193, 63, 125 },
             new byte[] { 207, 0, 0 }, 770077, 770079, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 200 },
             new byte[] { 216 }, 770081, 770081, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 208 },
             new byte[] { 224 }, 770085, 770085, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 215, 251, 22 },
             new byte[] { 224, 0, 0 }, 770089, 770091, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 223, 51, 51 },
             new byte[] { 232, 0, 0 }, 770093, 770095, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 770097, 770097, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 770101, 770101, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 770105, 770105, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 770109, 770109, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 770113, 770113, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 770117, 770117, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 770121, 770121, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 192 },
             new byte[] { 207 }, 770169, 770169, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 200 },
             new byte[] { 216 }, 770173, 770173, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 208 },
             new byte[] { 224 }, 770177, 770177, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 216 },
             new byte[] { 232 }, 770181, 770181, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 770185, 770185, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 770189, 770189, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 770193, 770193, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 770197, 770197, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 770201, 770201, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 770205, 770205, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 770209, 770209, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 770213, 770213, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 192 },
             new byte[] { 207 }, 770261, 770261, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 200 },
             new byte[] { 216 }, 770265, 770265, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 208 },
             new byte[] { 224 }, 770269, 770269, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 770273, 770273, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 770277, 770277, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 770281, 770281, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 770285, 770285, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 770289, 770289, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 770293, 770293, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 770297, 770297, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 770301, 770301, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 770305, 770305, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 192 },
             new byte[] { 207 }, 770353, 770353, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 200 },
             new byte[] { 216 }, 770357, 770357, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 208 },
             new byte[] { 224 }, 770361, 770361, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 770365, 770365, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 770369, 770369, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 770373, 770373, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 770377, 770377, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 770381, 770381, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 770385, 770385, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 770389, 770389, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 770393, 770393, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 770397, 770397, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 218, 225, 72 },
             new byte[] { 224, 0, 0 }, 771653, 771655, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 216 },
             new byte[] { 224 }, 771657, 771657, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 216 },
             new byte[] { 224 }, 771661, 771661, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 216 },
             new byte[] { 224 }, 771665, 771665, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 216 },
             new byte[] { 224 }, 771669, 771669, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 200, 163, 215 },
             new byte[] { 208, 0, 0 }, 771717, 771719, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 213, 30, 184 },
             new byte[] { 216, 0, 0 }, 771721, 771723, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224, 163, 215 },
             new byte[] { 232, 0, 0 }, 771725, 771727, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 228, 122, 225 },
             new byte[] { 232, 0, 0 }, 771729, 771731, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 230, 102, 102 },
             new byte[] { 240, 0, 0 }, 771733, 771735, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 230, 102, 102 },
             new byte[] { 240, 0, 0 }, 771737, 771739, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224, 163, 215 },
             new byte[] { 232, 0, 0 }, 771741, 771743, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 218, 225, 72 },
             new byte[] { 232, 0, 0 }, 771745, 771747, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 216 },
             new byte[] { 232 }, 771749, 771749, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 216 },
             new byte[] { 232 }, 771753, 771753, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 216 },
             new byte[] { 232 }, 771757, 771757, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 216 },
             new byte[] { 232 }, 771761, 771761, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 200, 163, 215 },
             new byte[] { 216, 0, 0 }, 771809, 771811, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 213, 30, 184 },
             new byte[] { 223, 0, 0 }, 771813, 771815, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224, 163, 215 },
             new byte[] { 240, 0, 0 }, 771817, 771819, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 228, 122, 225 },
             new byte[] { 239, 0, 0 }, 771821, 771823, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 230, 102, 102 },
             new byte[] { 240, 0, 0 }, 771825, 771827, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 230, 102, 102 },
             new byte[] { 240, 0, 0 }, 771829, 771831, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224, 163, 215 },
             new byte[] { 240, 0, 0 }, 771833, 771835, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 218, 225, 72 },
             new byte[] { 232, 0, 0 }, 771837, 771839, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 216 },
             new byte[] { 232 }, 771841, 771841, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 771845, 771845, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 771849, 771849, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 771853, 771853, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 200, 163, 215 },
             new byte[] { 216, 0, 0 }, 771901, 771903, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 213, 30, 184 },
             new byte[] { 223, 0, 0 }, 771905, 771907, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 218, 102, 102 },
             new byte[] { 232, 0, 0 }, 771909, 771911, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 221, 194, 143 },
             new byte[] { 232, 0, 0 }, 771913, 771915, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 223, 51, 51 },
             new byte[] { 232, 0, 0 }, 771917, 771919, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 222, 184, 82 },
             new byte[] { 232, 0, 0 }, 771921, 771923, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 771925, 771925, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 771929, 771929, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 771933, 771933, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 771937, 771937, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 771941, 771941, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 771945, 771945, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 193, 63, 125 },
             new byte[] { 207, 0, 0 }, 771993, 771995, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 200 },
             new byte[] { 216 }, 771997, 771997, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 208 },
             new byte[] { 224 }, 772001, 772001, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 215, 251, 22 },
             new byte[] { 224, 0, 0 }, 772005, 772007, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 223, 51, 51 },
             new byte[] { 232, 0, 0 }, 772009, 772011, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 772013, 772013, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 772017, 772017, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 772021, 772021, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 772025, 772025, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 772029, 772029, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 772033, 772033, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 772037, 772037, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 192 },
             new byte[] { 207 }, 772085, 772085, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 200 },
             new byte[] { 216 }, 772089, 772089, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 208 },
             new byte[] { 224 }, 772093, 772093, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 216 },
             new byte[] { 232 }, 772097, 772097, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 772101, 772101, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 772105, 772105, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 772109, 772109, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 772113, 772113, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 772117, 772117, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 772121, 772121, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 772125, 772125, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 772129, 772129, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 192 },
             new byte[] { 207 }, 772177, 772177, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 200 },
             new byte[] { 216 }, 772181, 772181, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 208 },
             new byte[] { 224 }, 772185, 772185, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 772189, 772189, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 772193, 772193, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 772197, 772197, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 772201, 772201, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 772205, 772205, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 772209, 772209, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 772213, 772213, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 772217, 772217, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 772221, 772221, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 192 },
             new byte[] { 207 }, 772269, 772269, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 200 },
             new byte[] { 216 }, 772273, 772273, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 208 },
             new byte[] { 224 }, 772277, 772277, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 772281, 772281, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 772285, 772285, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 772289, 772289, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 772293, 772293, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 772297, 772297, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 772301, 772301, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 772305, 772305, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 772309, 772309, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 772313, 772313, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 218, 225, 72 },
             new byte[] { 224, 0, 0 }, 773569, 773571, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 216 },
             new byte[] { 224 }, 773573, 773573, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 216 },
             new byte[] { 224 }, 773577, 773577, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 216 },
             new byte[] { 224 }, 773581, 773581, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 216 },
             new byte[] { 224 }, 773585, 773585, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 200, 163, 215 },
             new byte[] { 208, 0, 0 }, 773633, 773635, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 213, 30, 184 },
             new byte[] { 216, 0, 0 }, 773637, 773639, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224, 163, 215 },
             new byte[] { 232, 0, 0 }, 773641, 773643, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 228, 122, 225 },
             new byte[] { 232, 0, 0 }, 773645, 773647, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 230, 102, 102 },
             new byte[] { 240, 0, 0 }, 773649, 773651, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 230, 102, 102 },
             new byte[] { 240, 0, 0 }, 773653, 773655, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224, 163, 215 },
             new byte[] { 232, 0, 0 }, 773657, 773659, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 218, 225, 72 },
             new byte[] { 232, 0, 0 }, 773661, 773663, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 216 },
             new byte[] { 232 }, 773665, 773665, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 216 },
             new byte[] { 232 }, 773669, 773669, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 216 },
             new byte[] { 232 }, 773673, 773673, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 216 },
             new byte[] { 232 }, 773677, 773677, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 200, 163, 215 },
             new byte[] { 216, 0, 0 }, 773725, 773727, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 213, 30, 184 },
             new byte[] { 223, 0, 0 }, 773729, 773731, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224, 163, 215 },
             new byte[] { 240, 0, 0 }, 773733, 773735, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 228, 122, 225 },
             new byte[] { 239, 0, 0 }, 773737, 773739, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 230, 102, 102 },
             new byte[] { 240, 0, 0 }, 773741, 773743, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 230, 102, 102 },
             new byte[] { 240, 0, 0 }, 773745, 773747, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224, 163, 215 },
             new byte[] { 240, 0, 0 }, 773749, 773751, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 218, 225, 72 },
             new byte[] { 232, 0, 0 }, 773753, 773755, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 216 },
             new byte[] { 232 }, 773757, 773757, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 773761, 773761, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 773765, 773765, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 773769, 773769, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 200, 163, 215 },
             new byte[] { 216, 0, 0 }, 773817, 773819, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 213, 30, 184 },
             new byte[] { 223, 0, 0 }, 773821, 773823, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 218, 102, 102 },
             new byte[] { 232, 0, 0 }, 773825, 773827, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 221, 194, 143 },
             new byte[] { 232, 0, 0 }, 773829, 773831, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 223, 51, 51 },
             new byte[] { 232, 0, 0 }, 773833, 773835, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 222, 184, 82 },
             new byte[] { 232, 0, 0 }, 773837, 773839, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 773841, 773841, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 773845, 773845, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 773849, 773849, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 773853, 773853, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 773857, 773857, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 773861, 773861, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 193, 63, 125 },
             new byte[] { 207, 0, 0 }, 773909, 773911, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 200 },
             new byte[] { 216 }, 773913, 773913, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 208 },
             new byte[] { 224 }, 773917, 773917, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 215, 251, 22 },
             new byte[] { 224, 0, 0 }, 773921, 773923, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 223, 51, 51 },
             new byte[] { 232, 0, 0 }, 773925, 773927, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 773929, 773929, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 773933, 773933, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 773937, 773937, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 773941, 773941, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 773945, 773945, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 773949, 773949, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 773953, 773953, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 192 },
             new byte[] { 207 }, 774001, 774001, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 200 },
             new byte[] { 216 }, 774005, 774005, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 208 },
             new byte[] { 224 }, 774009, 774009, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 216 },
             new byte[] { 232 }, 774013, 774013, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 774017, 774017, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 774021, 774021, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 774025, 774025, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 774029, 774029, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 774033, 774033, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 774037, 774037, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 774041, 774041, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 774045, 774045, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 192 },
             new byte[] { 207 }, 774093, 774093, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 200 },
             new byte[] { 216 }, 774097, 774097, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 208 },
             new byte[] { 224 }, 774101, 774101, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 774105, 774105, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 774109, 774109, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 774113, 774113, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 774117, 774117, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 774121, 774121, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 774125, 774125, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 774129, 774129, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 774133, 774133, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 774137, 774137, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 192 },
             new byte[] { 207 }, 774185, 774185, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 200 },
             new byte[] { 216 }, 774189, 774189, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 208 },
             new byte[] { 224 }, 774193, 774193, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 774197, 774197, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 774201, 774201, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 774205, 774205, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 774209, 774209, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 774213, 774213, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 774217, 774217, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 774221, 774221, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 774225, 774225, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 774229, 774229, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 232 }, 785485, 785485, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 232 }, 785489, 785489, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 232 }, 785493, 785493, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 232 }, 785497, 785497, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 232 }, 785501, 785501, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 138, 128 },
             new byte[] { 144, 0 }, 785549, 785550, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 161 },
             new byte[] { 168 }, 785553, 785553, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 181, 187, 130 },
             new byte[] { 192, 0, 0 }, 785557, 785559, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 202, 119, 4 },
             new byte[] { 208, 0, 0 }, 785561, 785563, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 209, 198, 230 },
             new byte[] { 216, 0, 0 }, 785565, 785567, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 225, 103, 76 },
             new byte[] { 232, 0, 0 }, 785569, 785571, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 232 }, 785573, 785573, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 232 }, 785577, 785577, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 785581, 785581, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 785585, 785585, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 785589, 785589, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 785593, 785593, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 141 },
             new byte[] { 152 }, 785641, 785641, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 167, 128 },
             new byte[] { 176, 0 }, 785645, 785646, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 187, 34, 207 },
             new byte[] { 200, 0, 0 }, 785649, 785651, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 206, 197, 157 },
             new byte[] { 216, 0, 0 }, 785653, 785655, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 212, 159, 30 },
             new byte[] { 224, 0, 0 }, 785657, 785659, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 785661, 785661, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 785665, 785665, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 785669, 785669, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 785673, 785673, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 785677, 785677, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 785681, 785681, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 785685, 785685, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 159 },
             new byte[] { 168 }, 785733, 785733, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 180, 128 },
             new byte[] { 192, 0 }, 785737, 785738, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 197, 241, 104 },
             new byte[] { 207, 0, 0 }, 785741, 785743, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 215, 98, 207 },
             new byte[] { 224, 0, 0 }, 785745, 785747, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 218, 79, 143 },
             new byte[] { 232, 0, 0 }, 785749, 785751, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 785753, 785753, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 785757, 785757, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 785761, 785761, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 785765, 785765, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 785769, 785769, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 785773, 785773, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 785777, 785777, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 181 },
             new byte[] { 192 }, 785825, 785825, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 193, 128 },
             new byte[] { 207, 0 }, 785829, 785830, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 206, 192 },
             new byte[] { 216, 0 }, 785833, 785834, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 220 },
             new byte[] { 232 }, 785837, 785837, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 785841, 785841, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 785845, 785845, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 785849, 785849, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 785853, 785853, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 785857, 785857, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 785861, 785861, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 785865, 785865, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 785869, 785869, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 192 },
             new byte[] { 207 }, 785917, 785917, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 200 },
             new byte[] { 216 }, 785921, 785921, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 208 },
             new byte[] { 224 }, 785925, 785925, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 785929, 785929, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 785933, 785933, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 785937, 785937, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 785941, 785941, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 785945, 785945, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 785949, 785949, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 785953, 785953, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 785957, 785957, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 785961, 785961, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 192 },
             new byte[] { 207 }, 786009, 786009, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 200 },
             new byte[] { 216 }, 786013, 786013, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 208 },
             new byte[] { 224 }, 786017, 786017, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 786021, 786021, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 786025, 786025, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 786029, 786029, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 786033, 786033, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 786037, 786037, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 786041, 786041, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 786045, 786045, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 786049, 786049, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 786053, 786053, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 192 },
             new byte[] { 207 }, 786101, 786101, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 200 },
             new byte[] { 216 }, 786105, 786105, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 208 },
             new byte[] { 224 }, 786109, 786109, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 786113, 786113, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 786117, 786117, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 786121, 786121, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 786125, 786125, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 786129, 786129, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 786133, 786133, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 786137, 786137, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 786141, 786141, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 786145, 786145, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 232 }, 787401, 787401, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 232 }, 787405, 787405, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 232 }, 787409, 787409, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 232 }, 787413, 787413, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 232 }, 787417, 787417, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 138, 128 },
             new byte[] { 144, 0 }, 787465, 787466, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 161 },
             new byte[] { 168 }, 787469, 787469, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 181, 187, 130 },
             new byte[] { 192, 0, 0 }, 787473, 787475, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 202, 119, 4 },
             new byte[] { 208, 0, 0 }, 787477, 787479, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 209, 198, 230 },
             new byte[] { 216, 0, 0 }, 787481, 787483, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 225, 103, 76 },
             new byte[] { 232, 0, 0 }, 787485, 787487, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 232 }, 787489, 787489, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 232 }, 787493, 787493, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 787497, 787497, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 787501, 787501, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 787505, 787505, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 787509, 787509, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 141 },
             new byte[] { 152 }, 787557, 787557, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 167, 128 },
             new byte[] { 176, 0 }, 787561, 787562, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 187, 34, 207 },
             new byte[] { 200, 0, 0 }, 787565, 787567, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 206, 197, 157 },
             new byte[] { 216, 0, 0 }, 787569, 787571, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 212, 159, 30 },
             new byte[] { 224, 0, 0 }, 787573, 787575, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 787577, 787577, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 787581, 787581, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 787585, 787585, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 787589, 787589, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 787593, 787593, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 787597, 787597, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 787601, 787601, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 159 },
             new byte[] { 168 }, 787649, 787649, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 180, 128 },
             new byte[] { 192, 0 }, 787653, 787654, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 197, 241, 104 },
             new byte[] { 207, 0, 0 }, 787657, 787659, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 215, 98, 207 },
             new byte[] { 224, 0, 0 }, 787661, 787663, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 218, 79, 143 },
             new byte[] { 232, 0, 0 }, 787665, 787667, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 787669, 787669, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 787673, 787673, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 787677, 787677, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 787681, 787681, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 787685, 787685, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 787689, 787689, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 787693, 787693, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 181 },
             new byte[] { 192 }, 787741, 787741, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 193, 128 },
             new byte[] { 207, 0 }, 787745, 787746, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 206, 192 },
             new byte[] { 216, 0 }, 787749, 787750, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 220 },
             new byte[] { 232 }, 787753, 787753, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 787757, 787757, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 787761, 787761, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 787765, 787765, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 787769, 787769, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 787773, 787773, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 787777, 787777, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 787781, 787781, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 787785, 787785, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 192 },
             new byte[] { 207 }, 787833, 787833, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 200 },
             new byte[] { 216 }, 787837, 787837, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 208 },
             new byte[] { 224 }, 787841, 787841, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 787845, 787845, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 787849, 787849, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 787853, 787853, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 787857, 787857, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 787861, 787861, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 787865, 787865, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 787869, 787869, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 787873, 787873, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 787877, 787877, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 192 },
             new byte[] { 207 }, 787925, 787925, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 200 },
             new byte[] { 216 }, 787929, 787929, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 208 },
             new byte[] { 224 }, 787933, 787933, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 787937, 787937, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 787941, 787941, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 787945, 787945, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 787949, 787949, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 787953, 787953, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 787957, 787957, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 787961, 787961, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 787965, 787965, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 787969, 787969, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 192 },
             new byte[] { 207 }, 788017, 788017, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 200 },
             new byte[] { 216 }, 788021, 788021, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 208 },
             new byte[] { 224 }, 788025, 788025, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 788029, 788029, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 788033, 788033, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 788037, 788037, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 788041, 788041, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 788045, 788045, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 788049, 788049, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 788053, 788053, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 788057, 788057, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 788061, 788061, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 218, 225, 72 },
             new byte[] { 224, 0, 0 }, 789317, 789319, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 216 },
             new byte[] { 224 }, 789321, 789321, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 216 },
             new byte[] { 224 }, 789325, 789325, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 216 },
             new byte[] { 224 }, 789329, 789329, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 216 },
             new byte[] { 224 }, 789333, 789333, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 200, 163, 215 },
             new byte[] { 208, 0, 0 }, 789381, 789383, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 213, 30, 184 },
             new byte[] { 216, 0, 0 }, 789385, 789387, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224, 163, 215 },
             new byte[] { 232, 0, 0 }, 789389, 789391, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 228, 122, 225 },
             new byte[] { 232, 0, 0 }, 789393, 789395, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 230, 102, 102 },
             new byte[] { 240, 0, 0 }, 789397, 789399, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 230, 102, 102 },
             new byte[] { 240, 0, 0 }, 789401, 789403, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224, 163, 215 },
             new byte[] { 232, 0, 0 }, 789405, 789407, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 218, 225, 72 },
             new byte[] { 232, 0, 0 }, 789409, 789411, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 216 },
             new byte[] { 232 }, 789413, 789413, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 216 },
             new byte[] { 232 }, 789417, 789417, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 216 },
             new byte[] { 232 }, 789421, 789421, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 216 },
             new byte[] { 232 }, 789425, 789425, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 200, 163, 215 },
             new byte[] { 216, 0, 0 }, 789473, 789475, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 213, 30, 184 },
             new byte[] { 223, 0, 0 }, 789477, 789479, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224, 163, 215 },
             new byte[] { 240, 0, 0 }, 789481, 789483, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 228, 122, 225 },
             new byte[] { 239, 0, 0 }, 789485, 789487, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 230, 102, 102 },
             new byte[] { 240, 0, 0 }, 789489, 789491, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 230, 102, 102 },
             new byte[] { 240, 0, 0 }, 789493, 789495, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224, 163, 215 },
             new byte[] { 240, 0, 0 }, 789497, 789499, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 218, 225, 72 },
             new byte[] { 232, 0, 0 }, 789501, 789503, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 216 },
             new byte[] { 232 }, 789505, 789505, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 789509, 789509, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 789513, 789513, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 789517, 789517, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 200, 163, 215 },
             new byte[] { 216, 0, 0 }, 789565, 789567, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 213, 30, 184 },
             new byte[] { 223, 0, 0 }, 789569, 789571, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 218, 102, 102 },
             new byte[] { 232, 0, 0 }, 789573, 789575, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 221, 194, 143 },
             new byte[] { 232, 0, 0 }, 789577, 789579, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 223, 51, 51 },
             new byte[] { 232, 0, 0 }, 789581, 789583, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 222, 184, 82 },
             new byte[] { 232, 0, 0 }, 789585, 789587, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 789589, 789589, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 789593, 789593, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 789597, 789597, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 789601, 789601, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 789605, 789605, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 789609, 789609, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 193, 63, 125 },
             new byte[] { 207, 0, 0 }, 789657, 789659, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 200 },
             new byte[] { 216 }, 789661, 789661, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 208 },
             new byte[] { 224 }, 789665, 789665, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 215, 251, 22 },
             new byte[] { 224, 0, 0 }, 789669, 789671, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 223, 51, 51 },
             new byte[] { 232, 0, 0 }, 789673, 789675, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 789677, 789677, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 789681, 789681, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 789685, 789685, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 789689, 789689, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 789693, 789693, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 789697, 789697, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 789701, 789701, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 192 },
             new byte[] { 207 }, 789749, 789749, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 200 },
             new byte[] { 216 }, 789753, 789753, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 208 },
             new byte[] { 224 }, 789757, 789757, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 216 },
             new byte[] { 232 }, 789761, 789761, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 789765, 789765, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 789769, 789769, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 789773, 789773, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 789777, 789777, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 789781, 789781, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 789785, 789785, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 789789, 789789, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 789793, 789793, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 192 },
             new byte[] { 207 }, 789841, 789841, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 200 },
             new byte[] { 216 }, 789845, 789845, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 208 },
             new byte[] { 224 }, 789849, 789849, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 789853, 789853, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 789857, 789857, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 789861, 789861, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 789865, 789865, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 789869, 789869, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 789873, 789873, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 789877, 789877, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 789881, 789881, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 789885, 789885, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 192 },
             new byte[] { 207 }, 789933, 789933, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 200 },
             new byte[] { 216 }, 789937, 789937, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 208 },
             new byte[] { 224 }, 789941, 789941, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 789945, 789945, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 789949, 789949, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 789953, 789953, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 789957, 789957, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 789961, 789961, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 789965, 789965, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 789969, 789969, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 789973, 789973, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224 },
             new byte[] { 240 }, 789977, 789977, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 52 },
             new byte[] { 61 }, 821965, 821965, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 52 },
             new byte[] { 61 }, 821969, 821969, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 52 },
             new byte[] { 61 }, 821973, 821973, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 52 },
             new byte[] { 61 }, 821977, 821977, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 52 },
             new byte[] { 61 }, 821981, 821981, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 52 },
             new byte[] { 61 }, 821985, 821985, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 52 },
             new byte[] { 61 }, 821989, 821989, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 52 },
             new byte[] { 61 }, 821993, 821993, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 52 },
             new byte[] { 61 }, 821997, 821997, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 52 },
             new byte[] { 61 }, 822001, 822001, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 52 },
             new byte[] { 61 }, 822005, 822005, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 52 },
             new byte[] { 61 }, 822009, 822009, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 52 },
             new byte[] { 61 }, 822013, 822013, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 52 },
             new byte[] { 61 }, 822017, 822017, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 39 },
             new byte[] { 53 }, 822021, 822021, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 39 },
             new byte[] { 53 }, 822025, 822025, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 39 },
             new byte[] { 53 }, 822029, 822029, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 39 },
             new byte[] { 53 }, 822033, 822033, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 39 },
             new byte[] { 53 }, 822037, 822037, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 39 },
             new byte[] { 53 }, 822041, 822041, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 39 },
             new byte[] { 53 }, 822045, 822045, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 32 },
             new byte[] { 42 }, 822049, 822049, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 32 },
             new byte[] { 42 }, 822053, 822053, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 32 },
             new byte[] { 42 }, 822057, 822057, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 32 },
             new byte[] { 42 }, 822061, 822061, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 32 },
             new byte[] { 42 }, 822065, 822065, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 32 },
             new byte[] { 42 }, 822069, 822069, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 32 },
             new byte[] { 42 }, 822073, 822073, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 32 },
             new byte[] { 33 }, 822077, 822077, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 32 },
             new byte[] { 33 }, 822081, 822081, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 32 },
             new byte[] { 33 }, 822085, 822085, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 32 },
             new byte[] { 33 }, 822089, 822089, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 32 },
             new byte[] { 33 }, 822093, 822093, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 32 },
             new byte[] { 33 }, 822097, 822097, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 32 },
             new byte[] { 33 }, 822101, 822101, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 60, 192, 0 },
             new byte[] { 66, 105, 153 }, 834521, 834523, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 44, 192, 0 },
             new byte[] { 48, 238, 182 }, 834525, 834527, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 34, 128 },
             new byte[] { 36, 192 }, 834529, 834530, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 67, 192, 0 },
             new byte[] { 75, 42, 62 }, 834577, 834579, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 52 },
             new byte[] { 58 }, 834581, 834581, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 40, 144, 0 },
             new byte[] { 46, 239, 133 }, 834585, 834587, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 74, 192, 0 },
             new byte[] { 84, 206, 19 }, 834633, 834635, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 57, 128, 0 },
             new byte[] { 66, 154, 225 }, 834637, 834639, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 46, 160, 0 },
             new byte[] { 54, 191, 10 }, 834641, 834643, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 88, 192, 0 },
             new byte[] { 99, 85, 194 }, 834689, 834691, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 68, 64, 0 },
             new byte[] { 77, 182, 102 }, 834693, 834695, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 58, 192, 0 },
             new byte[] { 67, 222, 19 }, 834697, 834699, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 102, 192, 0 },
             new byte[] { 112, 14, 184 }, 834745, 834747, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 79, 64, 0 },
             new byte[] { 89, 82, 143 }, 834749, 834751, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 72, 128, 0 },
             new byte[] { 82, 129, 72 }, 834753, 834755, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 116, 192, 0 },
             new byte[] { 128, 82, 143 }, 834801, 834803, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 90, 64, 0 },
             new byte[] { 100, 238, 184 }, 834805, 834807, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 85 },
             new byte[] { 95 }, 834809, 834809, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 129, 96, 0 },
             new byte[] { 135, 182, 101 }, 834857, 834859, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 101 },
             new byte[] { 111 }, 834861, 834861, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 97, 64, 0 },
             new byte[] { 107, 128, 164 }, 834865, 834867, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 136, 96, 0 },
             new byte[] { 143, 26, 62 }, 834913, 834915, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 112 },
             new byte[] { 122 }, 834917, 834917, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 109, 128 },
             new byte[] { 121, 32 }, 834921, 834922, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 143, 96, 0 },
             new byte[] { 150, 94, 20 }, 834969, 834971, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 123 },
             new byte[] { 131 }, 834973, 834973, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 121, 192, 0 },
             new byte[] { 130, 223, 173 }, 834977, 834979, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 177, 128 },
             new byte[] { 183, 0 }, 885141, 885142, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 183, 217, 154 },
             new byte[] { 201, 128, 0 }, 885145, 885147, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 186 },
             new byte[] { 210 }, 885149, 885149, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 185 },
             new byte[] { 211 }, 885153, 885153, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 178, 128 },
             new byte[] { 207, 0 }, 885157, 885158, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 172, 128 },
             new byte[] { 197, 0 }, 885161, 885162, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 166 },
             new byte[] { 179 }, 885165, 885165, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 182 },
             new byte[] { 196 }, 885177, 885177, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 198 },
             new byte[] { 228 }, 885181, 885181, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 67, 204, 76, 205, 67, 206 },
             new byte[] { 68, 2, 128, 0, 68, 5 }, 885184, 885189, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 67, 200 },
             new byte[] { 68, 3 }, 885192, 885193, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 193 },
             new byte[] { 255 }, 885197, 885197, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 189, 128 },
             new byte[] { 244, 0 }, 885201, 885202, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 175 },
             new byte[] { 220 }, 885205, 885205, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 67, 252, 128, 0 },
             new byte[] { 68, 10, 204, 204 }, 885220, 885223, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 1, 198, 102 },
             new byte[] { 25, 112, 228 }, 885225, 885227, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 1, 64, 0, 67, 246 },
             new byte[] { 24, 235, 132, 68, 21 }, 885229, 885233, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 67, 231, 128, 0, 67, 222 },
             new byte[] { 68, 16, 225, 72, 68, 9 }, 885236, 885241, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 194 },
             new byte[] { 241 }, 885245, 885245, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 173, 222, 122 },
             new byte[] { 179, 0, 0 }, 885621, 885623, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 177, 108, 216 },
             new byte[] { 195, 0, 0 }, 885625, 885627, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 177, 123, 104 },
             new byte[] { 201, 127, 255 }, 885629, 885631, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 177, 219, 251 },
             new byte[] { 203, 127, 255 }, 885633, 885635, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 178, 128 },
             new byte[] { 201, 0 }, 885637, 885638, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 172, 128 },
             new byte[] { 197, 0 }, 885641, 885642, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 166 },
             new byte[] { 179 }, 885645, 885645, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 182 },
             new byte[] { 196 }, 885657, 885657, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 198 },
             new byte[] { 228 }, 885661, 885661, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 67, 204, 76, 205, 67, 206 },
             new byte[] { 68, 2, 128, 0, 68, 5 }, 885664, 885669, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 67, 200 },
             new byte[] { 68, 3 }, 885672, 885673, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 193 },
             new byte[] { 255 }, 885677, 885677, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 189, 128 },
             new byte[] { 244, 0 }, 885681, 885682, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 175 },
             new byte[] { 220 }, 885685, 885685, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 67, 252, 128 },
             new byte[] { 68, 10, 192 }, 885700, 885702, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 1, 198, 102 },
             new byte[] { 25, 63, 255 }, 885705, 885707, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 1, 64 },
             new byte[] { 24, 192 }, 885709, 885710, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 67, 246 },
             new byte[] { 68, 21 }, 885712, 885713, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 67, 231, 128 },
             new byte[] { 68, 16, 192 }, 885716, 885718, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 67, 222 },
             new byte[] { 68, 9 }, 885720, 885721, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 194 },
             new byte[] { 241 }, 885725, 885725, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 173, 222, 122 },
             new byte[] { 179, 0, 0 }, 886101, 886103, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 177, 108, 216 },
             new byte[] { 195, 0, 0 }, 886105, 886107, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 177, 123, 104 },
             new byte[] { 201, 127, 255 }, 886109, 886111, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 177, 219, 251 },
             new byte[] { 203, 127, 255 }, 886113, 886115, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 178 },
             new byte[] { 200 }, 886117, 886117, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 172, 128 },
             new byte[] { 197, 0 }, 886121, 886122, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 166 },
             new byte[] { 179 }, 886125, 886125, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 182 },
             new byte[] { 196 }, 886137, 886137, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 198 },
             new byte[] { 228 }, 886141, 886141, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 67, 204, 76, 205, 67, 206 },
             new byte[] { 68, 2, 128, 0, 68, 5 }, 886144, 886149, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 67, 200 },
             new byte[] { 68, 3 }, 886152, 886153, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 193 },
             new byte[] { 255 }, 886157, 886157, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 189, 128 },
             new byte[] { 244, 0 }, 886161, 886162, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 175 },
             new byte[] { 220 }, 886165, 886165, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 67, 252, 128 },
             new byte[] { 68, 10, 192 }, 886180, 886182, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 1, 198, 102 },
             new byte[] { 25, 63, 255 }, 886185, 886187, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 1, 64 },
             new byte[] { 24, 192 }, 886189, 886190, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 67, 246 },
             new byte[] { 68, 21 }, 886192, 886193, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 67, 231, 128 },
             new byte[] { 68, 16, 192 }, 886196, 886198, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 67, 222 },
             new byte[] { 68, 9 }, 886200, 886201, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 194 },
             new byte[] { 241 }, 886205, 886205, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 177, 128 },
             new byte[] { 183, 0 }, 886581, 886582, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 183, 217, 154 },
             new byte[] { 201, 128, 0 }, 886585, 886587, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 186 },
             new byte[] { 210 }, 886589, 886589, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 185 },
             new byte[] { 211 }, 886593, 886593, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 178, 128 },
             new byte[] { 207, 0 }, 886597, 886598, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 172, 128 },
             new byte[] { 197, 0 }, 886601, 886602, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 166 },
             new byte[] { 179 }, 886605, 886605, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 182 },
             new byte[] { 196 }, 886617, 886617, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 198 },
             new byte[] { 228 }, 886621, 886621, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 67, 204, 76, 205, 67, 206 },
             new byte[] { 68, 2, 128, 0, 68, 5 }, 886624, 886629, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 67, 200 },
             new byte[] { 68, 3 }, 886632, 886633, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 193 },
             new byte[] { 255 }, 886637, 886637, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 189, 128 },
             new byte[] { 244, 0 }, 886641, 886642, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 175 },
             new byte[] { 220 }, 886645, 886645, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 67, 252, 128 },
             new byte[] { 68, 10, 192 }, 886660, 886662, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 1, 198, 102 },
             new byte[] { 25, 63, 255 }, 886665, 886667, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 1, 64 },
             new byte[] { 24, 192 }, 886669, 886670, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 67, 246 },
             new byte[] { 68, 21 }, 886672, 886673, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 67, 231, 128 },
             new byte[] { 68, 16, 192 }, 886676, 886678, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 67, 222 },
             new byte[] { 68, 9 }, 886680, 886681, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 194 },
             new byte[] { 241 }, 886685, 886685, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 177, 128 },
             new byte[] { 183, 0 }, 896321, 896322, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 183, 217, 154 },
             new byte[] { 201, 128, 0 }, 896325, 896327, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 186 },
             new byte[] { 210 }, 896329, 896329, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 185 },
             new byte[] { 211 }, 896333, 896333, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 178, 128 },
             new byte[] { 207, 0 }, 896337, 896338, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 172, 128 },
             new byte[] { 197, 0 }, 896341, 896342, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 166 },
             new byte[] { 179 }, 896345, 896345, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 182 },
             new byte[] { 196 }, 896357, 896357, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 198 },
             new byte[] { 228 }, 896361, 896361, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 67, 204, 76, 205, 67, 206 },
             new byte[] { 68, 2, 128, 0, 68, 5 }, 896364, 896369, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 67, 200 },
             new byte[] { 68, 3 }, 896372, 896373, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 193 },
             new byte[] { 255 }, 896377, 896377, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 189, 128 },
             new byte[] { 244, 0 }, 896381, 896382, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 175 },
             new byte[] { 220 }, 896385, 896385, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 67, 252, 128 },
             new byte[] { 68, 10, 192 }, 896400, 896402, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 1, 198, 102 },
             new byte[] { 25, 63, 255 }, 896405, 896407, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 1, 64 },
             new byte[] { 24, 192 }, 896409, 896410, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 67, 246 },
             new byte[] { 68, 21 }, 896412, 896413, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 67, 231, 128 },
             new byte[] { 68, 16, 192 }, 896416, 896418, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 67, 222 },
             new byte[] { 68, 9 }, 896420, 896421, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 194 },
             new byte[] { 241 }, 896425, 896425, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 177, 128 },
             new byte[] { 183, 0 }, 896801, 896802, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 183, 217, 154 },
             new byte[] { 201, 128, 0 }, 896805, 896807, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 186 },
             new byte[] { 210 }, 896809, 896809, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 185 },
             new byte[] { 211 }, 896813, 896813, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 178, 128 },
             new byte[] { 207, 0 }, 896817, 896818, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 172, 128 },
             new byte[] { 197, 0 }, 896821, 896822, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 166 },
             new byte[] { 179 }, 896825, 896825, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 182 },
             new byte[] { 196 }, 896837, 896837, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 198 },
             new byte[] { 228 }, 896841, 896841, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 67, 204, 76, 205, 67, 206 },
             new byte[] { 68, 2, 128, 0, 68, 5 }, 896844, 896849, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 67, 200 },
             new byte[] { 68, 3 }, 896852, 896853, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 193 },
             new byte[] { 255 }, 896857, 896857, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 189, 128 },
             new byte[] { 244, 0 }, 896861, 896862, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 175 },
             new byte[] { 220 }, 896865, 896865, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 67, 252, 128 },
             new byte[] { 68, 10, 192 }, 896880, 896882, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 1, 198, 102 },
             new byte[] { 25, 63, 255 }, 896885, 896887, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 1, 64 },
             new byte[] { 24, 192 }, 896889, 896890, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 67, 246 },
             new byte[] { 68, 21 }, 896892, 896893, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 67, 231, 128 },
             new byte[] { 68, 16, 192 }, 896896, 896898, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 67, 222 },
             new byte[] { 68, 9 }, 896900, 896901, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 194 },
             new byte[] { 241 }, 896905, 896905, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 173, 222, 122 },
             new byte[] { 179, 0, 0 }, 897601, 897603, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 177, 108, 216 },
             new byte[] { 195, 0, 0 }, 897605, 897607, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 177, 123, 104 },
             new byte[] { 201, 127, 255 }, 897609, 897611, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 177, 219, 251 },
             new byte[] { 203, 127, 255 }, 897613, 897615, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 178, 128 },
             new byte[] { 203, 0 }, 897617, 897618, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 172, 128 },
             new byte[] { 197, 0 }, 897621, 897622, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 166 },
             new byte[] { 179 }, 897625, 897625, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 182 },
             new byte[] { 196 }, 897637, 897637, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 198 },
             new byte[] { 228 }, 897641, 897641, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 67, 204, 76, 205, 67, 206 },
             new byte[] { 68, 2, 128, 0, 68, 5 }, 897644, 897649, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 67, 200 },
             new byte[] { 68, 3 }, 897652, 897653, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 193 },
             new byte[] { 255 }, 897657, 897657, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 189, 128 },
             new byte[] { 244, 0 }, 897661, 897662, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 175 },
             new byte[] { 220 }, 897665, 897665, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 67, 252, 128 },
             new byte[] { 68, 10, 192 }, 897680, 897682, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 1, 198, 102 },
             new byte[] { 25, 63, 255 }, 897685, 897687, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 1, 64 },
             new byte[] { 24, 192 }, 897689, 897690, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 67, 246 },
             new byte[] { 68, 21 }, 897692, 897693, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 67, 231, 128 },
             new byte[] { 68, 16, 192 }, 897696, 897698, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 67, 222 },
             new byte[] { 68, 9 }, 897700, 897701, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 194 },
             new byte[] { 241 }, 897705, 897705, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 173, 222, 122 },
             new byte[] { 179, 0, 0 }, 898081, 898083, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 177, 108, 216 },
             new byte[] { 195, 0, 0 }, 898085, 898087, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 177, 123, 104 },
             new byte[] { 201, 127, 255 }, 898089, 898091, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 177, 219, 251 },
             new byte[] { 203, 127, 255 }, 898093, 898095, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 178, 128 },
             new byte[] { 207, 0 }, 898097, 898098, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 172, 128 },
             new byte[] { 197, 0 }, 898101, 898102, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 166 },
             new byte[] { 179 }, 898105, 898105, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 182 },
             new byte[] { 196 }, 898117, 898117, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 198 },
             new byte[] { 228 }, 898121, 898121, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 67, 204, 76, 205, 67, 206 },
             new byte[] { 68, 2, 128, 0, 68, 5 }, 898124, 898129, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 67, 200 },
             new byte[] { 68, 3 }, 898132, 898133, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 193 },
             new byte[] { 255 }, 898137, 898137, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 189, 128 },
             new byte[] { 244, 0 }, 898141, 898142, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 175 },
             new byte[] { 220 }, 898145, 898145, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 67, 252, 128 },
             new byte[] { 68, 10, 192 }, 898160, 898162, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 1, 198, 102 },
             new byte[] { 25, 63, 255 }, 898165, 898167, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 1, 64 },
             new byte[] { 24, 192 }, 898169, 898170, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 67, 246 },
             new byte[] { 68, 21 }, 898172, 898173, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 67, 231, 128 },
             new byte[] { 68, 16, 192 }, 898176, 898178, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 67, 222 },
             new byte[] { 68, 9 }, 898180, 898181, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 194 },
             new byte[] { 241 }, 898185, 898185, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 148 },
             new byte[] { 159 }, 899525, 899525, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 148 },
             new byte[] { 159 }, 899529, 899529, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 145, 102, 102 },
             new byte[] { 154, 112, 202 }, 899533, 899535, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 145, 102, 102 },
             new byte[] { 154, 112, 202 }, 899537, 899539, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 145, 102, 102 },
             new byte[] { 154, 112, 202 }, 899541, 899543, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 145, 102, 102 },
             new byte[] { 154, 112, 202 }, 899545, 899547, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 61, 51, 51 },
             new byte[] { 68, 0, 0 }, 899549, 899551, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 142, 204, 205 },
             new byte[] { 144, 112, 146 }, 899609, 899611, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 148, 204, 205 },
             new byte[] { 166, 103, 99 }, 899613, 899615, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 155, 102, 102 },
             new byte[] { 176, 96, 141 }, 899617, 899619, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 155, 102, 102 },
             new byte[] { 176, 96, 141 }, 899621, 899623, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 152, 153, 154 },
             new byte[] { 176, 156, 159 }, 899625, 899627, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 152, 153, 154 },
             new byte[] { 176, 156, 159 }, 899629, 899631, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 152, 153, 154 },
             new byte[] { 174, 154, 24 }, 899633, 899635, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 152, 153, 154 },
             new byte[] { 168, 146, 128 }, 899637, 899639, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 70, 204, 205 },
             new byte[] { 99, 7, 226 }, 899641, 899643, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 152, 204, 205 },
             new byte[] { 154, 78, 59 }, 899697, 899699, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 151, 153, 154 },
             new byte[] { 160, 33, 192 }, 899701, 899703, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 155, 204, 205 },
             new byte[] { 183, 170, 153 }, 899705, 899707, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 162, 204, 205 },
             new byte[] { 191, 126, 17 }, 899709, 899711, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 162, 204, 205 },
             new byte[] { 193, 146, 76 }, 899713, 899715, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 160, 0, 0 },
             new byte[] { 193, 114, 38 }, 899717, 899719, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 160, 0, 0 },
             new byte[] { 197, 114, 38 }, 899721, 899723, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 160, 0, 0 },
             new byte[] { 193, 114, 38 }, 899725, 899727, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 160, 0, 0 },
             new byte[] { 179, 114, 38 }, 899729, 899731, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 80, 102, 102 },
             new byte[] { 107, 153, 23 }, 899733, 899735, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 51, 51 },
             new byte[] { 152, 150 }, 899790, 899791, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 160 },
             new byte[] { 170 }, 899793, 899793, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 163, 0, 0 },
             new byte[] { 192, 66, 251 }, 899797, 899799, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 170, 51, 51 },
             new byte[] { 204, 46, 215 }, 899801, 899803, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 170, 51, 51 },
             new byte[] { 206, 69, 182 }, 899805, 899807, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 167, 51, 51 },
             new byte[] { 204, 138, 15 }, 899809, 899811, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 167, 51, 51 },
             new byte[] { 205, 117, 197 }, 899813, 899815, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 167, 51, 51 },
             new byte[] { 203, 94, 231 }, 899817, 899819, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 167, 51, 51 },
             new byte[] { 186, 73, 58 }, 899821, 899823, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 89, 153, 154 },
             new byte[] { 115, 42, 75 }, 899825, 899827, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 171, 102, 102 },
             new byte[] { 172, 92, 76 }, 899881, 899883, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 169, 204, 205 },
             new byte[] { 183, 234, 179 }, 899885, 899887, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 172, 0, 0 },
             new byte[] { 207, 113, 90 }, 899889, 899891, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 177, 153, 154 },
             new byte[] { 218, 150, 104 }, 899893, 899895, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 177, 153, 154 },
             new byte[] { 220, 151, 79 }, 899897, 899899, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 174, 102, 102 },
             new byte[] { 215, 100, 202 }, 899901, 899903, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 174, 102, 102 },
             new byte[] { 214, 100, 76 }, 899905, 899907, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 174, 102, 102 },
             new byte[] { 212, 98, 242 }, 899909, 899911, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 174, 102, 102 },
             new byte[] { 194, 107, 52 }, 899913, 899915, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 99, 51, 51 },
             new byte[] { 128, 130, 12 }, 899917, 899919, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 177, 102, 102 },
             new byte[] { 195, 179, 169 }, 899977, 899979, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 179, 0, 0 },
             new byte[] { 222, 15, 118 }, 899981, 899983, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 185, 0, 0 },
             new byte[] { 231, 46, 86 }, 899985, 899987, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 185, 0, 0 },
             new byte[] { 233, 46, 86 }, 899989, 899991, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 181, 204, 205 },
             new byte[] { 232, 158, 152 }, 899993, 899995, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 181, 204, 205 },
             new byte[] { 229, 168, 118 }, 899997, 899999, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 181, 204, 205 },
             new byte[] { 224, 209, 244 }, 900001, 900003, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 181, 204, 205 },
             new byte[] { 205, 193, 245 }, 900005, 900007, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 108, 102, 102 },
             new byte[] { 134, 236, 198 }, 900009, 900011, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 189 },
             new byte[] { 190 }, 900065, 900065, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 187 },
             new byte[] { 214 }, 900069, 900069, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 187, 0, 0 },
             new byte[] { 239, 6, 50 }, 900073, 900075, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 191, 102, 102 },
             new byte[] { 248, 96, 192 }, 900077, 900079, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 192, 102, 102 },
             new byte[] { 250, 101, 138 }, 900081, 900083, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 189, 0, 0 },
             new byte[] { 254, 37, 221 }, 900085, 900087, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 189, 0, 0 },
             new byte[] { 252, 37, 221 }, 900089, 900091, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 189, 0, 0 },
             new byte[] { 244, 12, 159 }, 900093, 900095, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 189, 0, 0 },
             new byte[] { 214, 12, 159 }, 900097, 900099, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 118, 0, 0 },
             new byte[] { 142, 51, 51 }, 900101, 900103, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 204, 51, 51 },
             new byte[] { 205, 220, 130 }, 900157, 900159, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 203, 153, 154, 66, 205, 153, 154, 66, 207, 51, 51, 66, 207, 51, 51, 66, 203, 153, 154, 66, 203, 153, 154, 66, 203, 153, 154 },
             new byte[] { 232, 34, 72, 67, 10, 84, 121, 67, 9, 198, 66, 67, 10, 198, 66, 67, 12, 237, 191, 67, 11, 249, 117, 67, 9, 193, 171 }, 900161, 900187, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 203, 153, 154 },
             new byte[] { 233, 113, 167 }, 900189, 900191, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 132 },
             new byte[] { 145 }, 900193, 900193, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 148 },
             new byte[] { 157 }, 901537, 901537, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 148 },
             new byte[] { 157 }, 901541, 901541, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 145, 102, 102 },
             new byte[] { 152, 112, 202 }, 901545, 901547, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 145, 102, 102 },
             new byte[] { 152, 112, 202 }, 901549, 901551, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 145, 102, 102 },
             new byte[] { 152, 112, 202 }, 901553, 901555, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 145, 102, 102 },
             new byte[] { 152, 112, 202 }, 901557, 901559, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 61, 51, 51 },
             new byte[] { 63, 0, 0 }, 901561, 901563, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 148, 204, 205 },
             new byte[] { 163, 254, 146 }, 901625, 901627, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 155, 102, 102 },
             new byte[] { 175, 91, 177 }, 901629, 901631, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 155, 102, 102 },
             new byte[] { 175, 91, 177 }, 901633, 901635, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 152, 153, 154 },
             new byte[] { 175, 142, 229 }, 901637, 901639, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 152, 153, 154 },
             new byte[] { 175, 142, 229 }, 901641, 901643, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 152, 153, 154 },
             new byte[] { 173, 142, 229 }, 901645, 901647, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 152, 153, 154 },
             new byte[] { 165, 142, 229 }, 901649, 901651, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 70, 204, 205 },
             new byte[] { 96, 0, 0 }, 901653, 901655, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 151, 153, 154 },
             new byte[] { 158, 33, 192 }, 901713, 901715, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 155, 204, 205 },
             new byte[] { 182, 60, 12 }, 901717, 901719, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 162, 204, 205 },
             new byte[] { 191, 90, 167 }, 901721, 901723, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 162, 204, 205 },
             new byte[] { 191, 90, 167 }, 901725, 901727, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 160 },
             new byte[] { 191 }, 901729, 901729, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 160 },
             new byte[] { 196 }, 901733, 901733, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 160 },
             new byte[] { 191 }, 901737, 901737, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 160 },
             new byte[] { 178 }, 901741, 901741, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 80, 102, 102 },
             new byte[] { 104, 0, 0 }, 901745, 901747, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 160 },
             new byte[] { 168 }, 901805, 901805, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 163 },
             new byte[] { 190 }, 901809, 901809, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 170, 51, 51 },
             new byte[] { 203, 18, 242 }, 901813, 901815, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 170, 51, 51 },
             new byte[] { 203, 18, 242 }, 901817, 901819, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 167, 51, 51 },
             new byte[] { 202, 18, 242 }, 901821, 901823, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 167, 51, 51 },
             new byte[] { 202, 18, 242 }, 901825, 901827, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 167, 51, 51 },
             new byte[] { 202, 18, 242 }, 901829, 901831, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 167, 51, 51 },
             new byte[] { 184, 18, 242 }, 901833, 901835, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 89, 153, 154 },
             new byte[] { 112, 0, 0 }, 901837, 901839, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 169, 204, 205 },
             new byte[] { 181, 234, 179 }, 901897, 901899, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 172 },
             new byte[] { 206 }, 901901, 901901, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 177, 153, 154 },
             new byte[] { 216, 149, 201 }, 901905, 901907, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 177, 153, 154 },
             new byte[] { 220, 149, 201 }, 901909, 901911, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 174, 102, 102 },
             new byte[] { 214, 98, 149 }, 901913, 901915, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 174, 102, 102 },
             new byte[] { 212, 98, 149 }, 901917, 901919, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 174, 102, 102 },
             new byte[] { 210, 98, 149 }, 901921, 901923, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 174, 102, 102 },
             new byte[] { 192, 98, 149 }, 901925, 901927, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 99, 51, 51 },
             new byte[] { 128, 0, 0 }, 901929, 901931, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 177, 102, 102 },
             new byte[] { 193, 179, 169 }, 901989, 901991, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 179 },
             new byte[] { 220 }, 901993, 901993, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 185 },
             new byte[] { 228 }, 901997, 901997, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 185 },
             new byte[] { 232 }, 902001, 902001, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 181, 204, 205 },
             new byte[] { 230, 158, 119 }, 902005, 902007, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 181, 204, 205 },
             new byte[] { 228, 158, 119 }, 902009, 902011, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 181, 204, 205 },
             new byte[] { 222, 158, 119 }, 902013, 902015, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 181, 204, 205 },
             new byte[] { 204, 158, 119 }, 902017, 902019, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 108, 102, 102 },
             new byte[] { 134, 153, 154 }, 902021, 902023, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 187 },
             new byte[] { 212 }, 902081, 902081, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 187 },
             new byte[] { 238 }, 902085, 902085, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 191, 102, 102 },
             new byte[] { 246, 89, 199 }, 902089, 902091, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 192, 102, 102 },
             new byte[] { 250, 89, 199 }, 902093, 902095, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 189, 0, 0 },
             new byte[] { 248, 12, 159 }, 902097, 902099, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 189, 0, 0 },
             new byte[] { 248, 12, 159 }, 902101, 902103, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 189 },
             new byte[] { 242 }, 902105, 902105, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 189 },
             new byte[] { 212 }, 902109, 902109, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 118 },
             new byte[] { 141 }, 902113, 902113, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 203, 153, 154, 66, 205, 153, 154, 66, 207, 51, 51, 66, 207, 51, 51, 66, 203, 153, 154, 66, 203, 153, 154, 66, 203, 153, 154 },
             new byte[] { 230, 34, 72, 67, 10, 69, 77, 67, 8, 198, 66, 67, 9, 198, 66, 67, 11, 249, 118, 67, 10, 249, 118, 67, 8, 249, 118 }, 902173, 902199, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 203, 153, 154 },
             new byte[] { 231, 242, 236 }, 902201, 902203, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 132 },
             new byte[] { 144 }, 902205, 902205, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 148 },
             new byte[] { 157 }, 903549, 903549, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 148 },
             new byte[] { 157 }, 903553, 903553, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 145, 102 },
             new byte[] { 152, 106 }, 903557, 903558, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 145, 102 },
             new byte[] { 152, 106 }, 903561, 903562, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 145, 102 },
             new byte[] { 152, 106 }, 903565, 903566, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 145, 102 },
             new byte[] { 152, 106 }, 903569, 903570, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 61, 51 },
             new byte[] { 62, 251 }, 903573, 903574, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 148, 204 },
             new byte[] { 162, 212 }, 903637, 903638, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 155, 102 },
             new byte[] { 174, 110 }, 903641, 903642, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 155, 102 },
             new byte[] { 174, 110 }, 903645, 903646, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 152, 153 },
             new byte[] { 174, 161 }, 903649, 903650, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 152, 153 },
             new byte[] { 174, 161 }, 903653, 903654, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 152, 153 },
             new byte[] { 172, 161 }, 903657, 903658, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 152, 153 },
             new byte[] { 164, 161 }, 903661, 903662, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 70, 204 },
             new byte[] { 96, 12 }, 903665, 903666, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 151, 153 },
             new byte[] { 158, 53 }, 903725, 903726, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 155, 204 },
             new byte[] { 182, 104 }, 903729, 903730, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 162, 204 },
             new byte[] { 191, 104 }, 903733, 903734, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 162, 204 },
             new byte[] { 191, 104 }, 903737, 903738, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 160 },
             new byte[] { 191 }, 903741, 903741, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 160 },
             new byte[] { 196 }, 903745, 903745, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 160 },
             new byte[] { 191 }, 903749, 903749, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 160 },
             new byte[] { 178 }, 903753, 903753, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 80, 102 },
             new byte[] { 103, 246 }, 903757, 903758, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 160 },
             new byte[] { 168 }, 903817, 903817, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 163 },
             new byte[] { 190 }, 903821, 903821, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 170, 51 },
             new byte[] { 202, 251 }, 903825, 903826, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 170, 51 },
             new byte[] { 202, 251 }, 903829, 903830, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 167, 51 },
             new byte[] { 201, 251 }, 903833, 903834, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 167, 51 },
             new byte[] { 201, 251 }, 903837, 903838, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 167, 51 },
             new byte[] { 201, 251 }, 903841, 903842, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 167, 51 },
             new byte[] { 183, 251 }, 903845, 903846, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 89, 153 },
             new byte[] { 111, 241 }, 903849, 903850, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 169, 204 },
             new byte[] { 181, 212 }, 903909, 903910, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 172 },
             new byte[] { 206 }, 903913, 903913, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 177, 153 },
             new byte[] { 214, 161 }, 903917, 903918, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 177, 153 },
             new byte[] { 218, 161 }, 903921, 903922, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 174, 102 },
             new byte[] { 213, 110 }, 903925, 903926, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 174, 102 },
             new byte[] { 211, 110 }, 903929, 903930, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 174, 102 },
             new byte[] { 209, 110 }, 903933, 903934, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 174, 102 },
             new byte[] { 191, 110 }, 903937, 903938, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 99, 51, 51 },
             new byte[] { 128, 1, 154 }, 903941, 903943, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 177, 102 },
             new byte[] { 194, 50 }, 904001, 904002, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 179 },
             new byte[] { 220 }, 904005, 904005, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 185 },
             new byte[] { 228 }, 904009, 904009, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 185 },
             new byte[] { 232 }, 904013, 904013, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 181, 204 },
             new byte[] { 230, 152 }, 904017, 904018, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 181, 204 },
             new byte[] { 228, 152 }, 904021, 904022, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 181, 204 },
             new byte[] { 222, 152 }, 904025, 904026, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 181, 204 },
             new byte[] { 204, 152 }, 904029, 904030, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 108, 102, 102 },
             new byte[] { 134, 159, 51 }, 904033, 904035, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 187 },
             new byte[] { 212 }, 904093, 904093, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 187 },
             new byte[] { 238 }, 904097, 904097, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 191, 102 },
             new byte[] { 246, 94 }, 904101, 904102, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 192, 102 },
             new byte[] { 250, 94 }, 904105, 904106, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 189, 0 },
             new byte[] { 248, 8 }, 904109, 904110, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 189, 0 },
             new byte[] { 248, 8 }, 904113, 904114, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 189 },
             new byte[] { 242 }, 904117, 904117, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 189 },
             new byte[] { 212 }, 904121, 904121, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 118 },
             new byte[] { 141 }, 904125, 904125, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 203, 153 },
             new byte[] { 229, 249 }, 904185, 904186, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 66, 205, 153, 154, 66, 207, 51, 51, 66, 207, 51, 51, 66, 203, 153, 154, 66, 203, 153, 154, 66, 203, 153, 154 },
             new byte[] { 67, 6, 252, 205, 67, 8, 201, 154, 67, 9, 201, 154, 67, 11, 252, 205, 67, 10, 252, 205, 67, 8, 252, 205 }, 904188, 904211, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 203, 153 },
             new byte[] { 231, 249 }, 904213, 904214, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 132, 102 },
             new byte[] { 144, 98 }, 904217, 904218, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 67, 225, 0 },
             new byte[] { 68, 9, 128 }, 905776, 905778, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 67, 225, 0 },
             new byte[] { 68, 9, 128 }, 905780, 905782, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 67, 225, 0 },
             new byte[] { 68, 9, 128 }, 905784, 905786, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 67, 225, 0 },
             new byte[] { 68, 9, 128 }, 905788, 905790, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 67, 225, 0 },
             new byte[] { 68, 9, 128 }, 905792, 905794, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 67, 225, 0 },
             new byte[] { 68, 9, 128 }, 905796, 905798, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 67, 225, 0 },
             new byte[] { 68, 9, 128 }, 905800, 905802, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 67, 225, 0 },
             new byte[] { 68, 9, 128 }, 905804, 905806, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 67, 225, 0 },
             new byte[] { 68, 9, 128 }, 905808, 905810, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 67, 225, 0 },
             new byte[] { 68, 9, 128 }, 905812, 905814, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 67, 225, 0 },
             new byte[] { 68, 9, 128 }, 905816, 905818, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 67, 225, 0 },
             new byte[] { 68, 9, 128 }, 905820, 905822, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 67, 225, 0 },
             new byte[] { 68, 9, 128 }, 905824, 905826, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 67, 225, 0 },
             new byte[] { 68, 9, 128 }, 905828, 905830, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 67, 225, 0 },
             new byte[] { 68, 9, 128 }, 905832, 905834, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 67, 225, 0 },
             new byte[] { 68, 9, 128 }, 905836, 905838, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 67, 225, 0 },
             new byte[] { 68, 9, 128 }, 905840, 905842, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 67, 225, 0 },
             new byte[] { 68, 9, 128 }, 905844, 905846, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 67, 225, 0 },
             new byte[] { 68, 9, 128 }, 905848, 905850, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 67, 225, 0 },
             new byte[] { 68, 9, 128 }, 905852, 905854, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 67, 225, 0 },
             new byte[] { 68, 9, 128 }, 905856, 905858, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 67, 225, 0 },
             new byte[] { 68, 9, 128 }, 905860, 905862, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 67, 225, 0 },
             new byte[] { 68, 9, 128 }, 905864, 905866, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 67, 225, 0 },
             new byte[] { 68, 9, 128 }, 905868, 905870, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 67, 225, 0 },
             new byte[] { 68, 9, 128 }, 905872, 905874, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 67, 225, 0 },
             new byte[] { 68, 9, 128 }, 905876, 905878, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 67, 225, 0 },
             new byte[] { 68, 9, 128 }, 905880, 905882, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 67, 225, 0 },
             new byte[] { 68, 9, 128 }, 905884, 905886, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 67, 225, 0 },
             new byte[] { 68, 9, 128 }, 905888, 905890, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 67, 225, 0 },
             new byte[] { 68, 9, 128 }, 905892, 905894, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 67, 225, 0 },
             new byte[] { 68, 9, 128 }, 905896, 905898, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 67, 225, 0 },
             new byte[] { 68, 9, 128 }, 905900, 905902, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 67, 225, 0 },
             new byte[] { 68, 9, 128 }, 905904, 905906, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 67, 225, 0 },
             new byte[] { 68, 9, 128 }, 905908, 905910, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 67, 225, 0 },
             new byte[] { 68, 9, 128 }, 905912, 905914, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 67, 225, 0 },
             new byte[] { 68, 9, 128 }, 905916, 905918, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 67, 225, 0 },
             new byte[] { 68, 9, 128 }, 905920, 905922, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 67, 225, 0 },
             new byte[] { 68, 9, 128 }, 905924, 905926, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 67, 225, 0 },
             new byte[] { 68, 9, 128 }, 905928, 905930, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 67, 225, 0 },
             new byte[] { 68, 9, 128 }, 905932, 905934, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 67, 225, 0 },
             new byte[] { 68, 9, 128 }, 905936, 905938, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 67, 225, 0 },
             new byte[] { 68, 9, 128 }, 905940, 905942, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 67, 225, 0 },
             new byte[] { 68, 9, 128 }, 905944, 905946, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 67, 225, 0 },
             new byte[] { 68, 9, 128 }, 905948, 905950, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 67, 225, 0 },
             new byte[] { 68, 9, 128 }, 905952, 905954, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 67, 225, 0 },
             new byte[] { 68, 9, 128 }, 905956, 905958, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 67, 225, 0 },
             new byte[] { 68, 9, 128 }, 905960, 905962, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 67, 225, 0 },
             new byte[] { 68, 9, 128 }, 905964, 905966, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 67, 225, 0 },
             new byte[] { 68, 9, 128 }, 905968, 905970, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 67, 225, 0 },
             new byte[] { 68, 9, 128 }, 905972, 905974, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 67, 225, 0 },
             new byte[] { 68, 9, 128 }, 905976, 905978, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 67, 225, 0 },
             new byte[] { 68, 9, 128 }, 905980, 905982, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 67, 225, 0 },
             new byte[] { 68, 9, 128 }, 905984, 905986, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 67, 225, 0 },
             new byte[] { 68, 9, 128 }, 905988, 905990, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 67, 225, 0 },
             new byte[] { 68, 9, 128 }, 905992, 905994, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 67, 225, 0 },
             new byte[] { 68, 9, 128 }, 905996, 905998, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 67, 225, 0 },
             new byte[] { 68, 9, 128 }, 906000, 906002, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 67, 225, 0 },
             new byte[] { 68, 9, 128 }, 906004, 906006, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 67, 225, 0 },
             new byte[] { 68, 9, 128 }, 906008, 906010, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 67, 225, 0 },
             new byte[] { 68, 9, 128 }, 906012, 906014, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 67, 225, 0 },
             new byte[] { 68, 9, 128 }, 906016, 906018, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 67, 225, 0 },
             new byte[] { 68, 9, 128 }, 906020, 906022, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 67, 225, 0 },
             new byte[] { 68, 9, 128 }, 906024, 906026, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 67, 225, 0 },
             new byte[] { 68, 9, 128 }, 906028, 906030, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 67, 225, 0 },
             new byte[] { 68, 9, 128 }, 906032, 906034, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 67, 225, 0 },
             new byte[] { 68, 9, 128 }, 906036, 906038, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 67, 225, 0 },
             new byte[] { 68, 9, 128 }, 906040, 906042, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 67, 225, 0 },
             new byte[] { 68, 9, 128 }, 906044, 906046, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 67, 225, 0 },
             new byte[] { 68, 9, 128 }, 906048, 906050, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 67, 225, 0 },
             new byte[] { 68, 9, 128 }, 906052, 906054, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 67, 225, 0 },
             new byte[] { 68, 9, 128 }, 906056, 906058, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 67, 225, 0 },
             new byte[] { 68, 9, 128 }, 906060, 906062, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 67, 225, 0 },
             new byte[] { 68, 9, 128 }, 906064, 906066, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 67, 225, 0 },
             new byte[] { 68, 9, 128 }, 906068, 906070, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 67, 225, 0 },
             new byte[] { 68, 9, 128 }, 906072, 906074, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 67, 225, 0 },
             new byte[] { 68, 9, 128 }, 906076, 906078, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 67, 225, 0 },
             new byte[] { 68, 9, 128 }, 906080, 906082, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 67, 225, 0 },
             new byte[] { 68, 9, 128 }, 906084, 906086, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 67, 225, 0 },
             new byte[] { 68, 9, 128 }, 906088, 906090, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 67, 225, 0 },
             new byte[] { 68, 9, 128 }, 906092, 906094, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 67, 225, 0 },
             new byte[] { 68, 9, 128 }, 906096, 906098, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 67, 225, 0 },
             new byte[] { 68, 9, 128 }, 906100, 906102, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 67, 225, 0 },
             new byte[] { 68, 9, 128 }, 906104, 906106, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 67, 225, 0 },
             new byte[] { 68, 9, 128 }, 906108, 906110, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 67, 225, 0 },
             new byte[] { 68, 9, 128 }, 906112, 906114, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 67, 225, 0 },
             new byte[] { 68, 9, 128 }, 906116, 906118, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 67, 225, 0 },
             new byte[] { 68, 9, 128 }, 906120, 906122, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 67, 225, 0 },
             new byte[] { 68, 9, 128 }, 906124, 906126, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 2, 13 },
             new byte[] { 0, 0 }, 942610, 942611, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 255, 255, 255, 255 },
             new byte[] { 0, 0, 0, 0 }, 942614, 942617, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 255, 255 },
             new byte[] { 0, 0 }, 942658, 942659, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 255, 255 },
             new byte[] { 0, 0 }, 942688, 942689, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 255, 255, 255, 255 },
             new byte[] { 0, 0, 0, 0 }, 942692, 942695, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 2, 13 },
             new byte[] { 0, 0 }, 943278, 943279, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 255, 255, 255, 255 },
             new byte[] { 0, 0, 0, 0 }, 943282, 943285, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 255, 255 },
             new byte[] { 0, 0 }, 943326, 943327, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 189, 250, 120, 90 },
             new byte[] { 40, 131, 125, 9 }, 1047432, 1047435, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 195, 18, 8, 191 },
             new byte[] { 237, 255, 255, 97 }, 1047444, 1047447, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 5, 194, 4, 45 },
             new byte[] { 112, 75, 8, 220 }, 1047468, 1047471, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 132, 240, 67, 84 },
             new byte[] { 239, 121, 72, 3 }, 1047504, 1047507, "Found egr map...Delete map");
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