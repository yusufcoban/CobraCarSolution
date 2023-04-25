using ToolBoxNameSpace;

namespace CobraCarSolution.TreeElements.VAG
{
    class nissan_EDC16CP42 : MenuItem, ITreeItem
    {
        public nissan_EDC16CP42()
        {
            Title = "EDC16CP42";
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
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 22, 108 }, 1776216);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 24, 216, 25, 100 }, 1776222);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 22, 108 }, 1776248);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 24, 216, 25, 100 }, 1776254);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 22, 108 }, 1776280);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 24, 216, 25, 100 }, 1776286);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 22, 108 }, 1776312);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 24, 216, 25, 100 }, 1776318);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 22, 108 }, 1776344);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 24, 216, 25, 100 }, 1776350);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 22, 108 }, 1776376);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 24, 216, 25, 100 }, 1776382);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 22, 58 }, 1776408);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 2, 23, 162, 24, 216, 25, 100 }, 1776411);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 21, 124, 22, 68 }, 1776440);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 2, 24, 126, 25, 100 }, 1776445);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 20, 230, 21, 124, 22, 118, 24, 16, 25, 100 }, 1776472);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 19, 36, 20, 120, 21, 54, 22, 88, 23, 142, 25, 100 }, 1776502);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 18, 102, 19, 246, 20, 210, 22, 38, 23, 62, 25, 100 }, 1776534);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 17, 48, 18, 172, 19, 216 }, 1776566);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 24, 22, 98, 24, 176 }, 1776573);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 12, 198, 15, 160, 17, 108, 18, 202 }, 1776596);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 0, 21, 124, 23, 72 }, 1776605);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 11, 234, 14, 176, 16, 104 }, 1776628);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 12, 19, 46, 20, 150, 22, 78 }, 1776635);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 10, 210, 13, 92 }, 1776660);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 10, 16, 214, 17, 218, 19, 36, 20, 160 }, 1776665);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 9, 166, 11, 184, 13, 162 }, 1776692);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 4, 16, 244, 18, 32, 19, 136 }, 1776699);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 28, 122, 30, 240, 34, 106 }, 1793122);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 30, 140, 32, 78, 35, 140 }, 1793154);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 31, 124, 33, 132, 36, 124 }, 1793186);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 32, 108, 34, 66, 37, 118 }, 1793218);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 33, 62, 35, 230, 38, 62 }, 1793250);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 33, 232, 36, 164, 38, 132 }, 1793282);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 35, 70, 37, 228, 39, 206 }, 1793314);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 38, 197 }, 1793346);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 29, 46, 32, 228, 38, 172 }, 1793702);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 30, 140, 34, 106, 40, 60 }, 1793734);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 31, 54, 36, 4, 41, 104 }, 1793766);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 32, 58, 37, 28, 42, 148 }, 1793798);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 33, 82, 38, 82, 42, 248 }, 1793830);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 34, 66, 39, 136, 43, 92 }, 1793862);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 36, 74, 40, 90, 43, 92 }, 1793894);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 38, 197 }, 1793926);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 26, 224, 28, 162, 31, 114 }, 1794282);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 27, 58, 29, 46, 31, 214 }, 1794314);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 27, 88, 29, 146, 32, 108 }, 1794346);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 27, 228, 29, 236, 32, 228 }, 1794378);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 28, 162, 30, 120, 33, 132 }, 1794410);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 29, 46, 31, 144, 34, 76 }, 1794442);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 30, 220, 32, 228, 35, 160 }, 1794474);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 33, 152 }, 1794506);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 26, 165, 28, 142, 30, 120 }, 1794862);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 27, 38, 29, 166, 31, 84 }, 1794894);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 28, 162, 30, 30, 32, 88 }, 1794926);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 29, 76, 31, 74, 33, 32 }, 1794958);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 30, 30, 31, 224, 34, 66 }, 1794990);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 30, 240, 32, 198, 34, 206 }, 1795022);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 32, 38, 34, 36, 35, 240 }, 1795054);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 34, 106 }, 1795086);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 26, 144, 29, 236, 34, 116 }, 1795442);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 29, 66, 32, 58, 36, 194 }, 1795474);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 30, 70, 34, 16, 38, 52 }, 1795506);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 30, 140, 35, 160, 38, 172 }, 1795538);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 31, 4, 36, 124, 38, 172 }, 1795570);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 30, 240, 36, 54, 38, 132 }, 1795602);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 32, 38, 35, 240, 38, 102 }, 1795634);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 34, 106 }, 1795666);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 27, 109, 29, 186, 33, 6 }, 1796022);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 27, 64, 29, 241, 33, 110 }, 1796054);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 27, 151, 30, 42, 33, 214 }, 1796086);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 28, 52, 31, 24, 34, 62 }, 1796118);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 28, 46, 31, 58, 34, 176 }, 1796150);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 30, 160, 33, 72, 36, 114 }, 1796182);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 32, 238, 36, 184, 39, 46 }, 1796214);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 35, 50 }, 1796246);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 41, 54, 43, 158, 46, 146 }, 1796602);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 43, 132, 47, 52, 49, 197 }, 1796634);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 44, 46, 49, 13, 51, 239 }, 1796666);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 44, 206, 50, 228, 53, 172 }, 1796698);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 45, 150, 51, 161, 54, 135 }, 1796730);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 49, 240, 52, 244, 55, 123 }, 1796762);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 49, 240, 53, 28, 56, 97 }, 1796794);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 50, 47 }, 1796826);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 1 }, 1807302);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 6, 64, 6, 64, 6, 64, 6, 64, 6, 64, 6, 64, 6, 64, 6, 64, 6, 64, 6, 64, 6, 64, 6, 64, 6, 64, 6, 64, 6, 64, 6, 64, 6, 64, 6, 64, 6, 64, 6, 64, 6, 64, 6, 64, 6, 64, 6, 64, 6, 164, 6, 164, 6, 164, 6, 164, 6, 164, 6, 164, 6, 164, 6, 164, 6, 164, 6, 164, 6, 164, 6, 164, 6, 164, 6, 164, 6, 164, 6, 164, 6, 164, 6, 164, 6, 164, 6, 164, 6, 164, 6, 164, 6, 164, 6, 164, 6, 164, 6, 164, 6, 164, 6, 164, 6, 164, 6, 164, 6, 164, 6, 164, 6, 164, 6, 164, 6, 164, 6, 164, 6, 164, 6, 164, 6, 164, 6, 164, 6, 164, 6, 164, 6, 164, 6, 164, 6, 164, 6, 164, 6, 164, 6, 164, 6, 164, 6, 164, 6, 164, 6, 164, 6, 164, 6, 164, 6, 164, 6, 164, 6, 164, 6, 164, 6, 164, 6, 164, 6, 164, 6, 164, 6, 164, 6, 164, 6, 164, 6, 164, 6, 164, 6, 164, 6, 164, 6, 164, 6, 164, 6, 164, 6, 164, 6, 164, 6, 164, 6, 164, 6, 164, 6, 164, 6, 164, 6, 164 }, 1807612);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 7, 8, 7, 8, 7, 8, 6, 164, 5, 220, 4, 176, 5, 20, 4, 226, 7, 208, 7, 208, 7, 208, 8, 52, 7, 8, 7, 8, 8, 152, 5, 220, 9, 96, 9, 96, 9, 96, 10, 140, 9, 196, 13, 72, 13, 172, 13, 72, 9, 96, 9, 96, 9, 96, 11, 84, 12, 28, 12, 228, 13, 172, 13, 172, 7, 208, 7, 208, 7, 208, 10, 140, 11, 184, 12, 28, 11, 184, 14, 16 }, 1807952);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 5, 220, 8, 252, 9, 196, 3, 232, 14, 16 }, 1808038);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 10, 240, 10, 240, 11, 184, 6, 214, 5, 220, 6, 214, 5, 220, 3, 232, 6, 164, 6, 164, 11, 184, 6, 214, 5, 220, 6, 214, 5, 220, 3, 232, 6, 164, 6, 164, 10, 190, 8, 202, 5, 220, 6, 214, 5, 220, 3, 232, 6, 164, 6, 164, 10, 190, 10, 190, 11, 184, 14, 166, 17, 148, 15, 160, 6, 164, 6, 164, 10, 190, 10, 190, 11, 184, 14, 166, 17, 148, 15, 160, 6, 164, 6, 164, 10, 190, 10, 190, 11, 184, 12, 178, 17, 148, 15, 160, 6, 164, 6, 164, 6, 164, 10, 190, 11, 184, 10, 190, 10, 190, 17, 148, 5, 220, 5, 220, 5, 220, 9, 196, 9, 196, 9, 196, 9, 196, 17, 148, 5, 220, 5, 220, 5, 220, 7, 208, 7, 208, 7, 208, 7, 208, 15, 160, 3, 232, 3, 232, 3, 232 }, 1808280);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 40, 0, 100 }, 1808767);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 0, 100, 255, 255 }, 1808772);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 37, 28 }, 1822646);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 37, 28 }, 1822670);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 37, 28 }, 1822694);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 23, 112, 25, 50 }, 1822712);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 37, 28 }, 1822718);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 22, 108, 23, 202, 26, 224, 37, 28 }, 1822736);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 21, 124, 23, 2, 25, 170, 37, 28 }, 1822760);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 24, 22, 88 }, 1822785);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 0, 37, 28 }, 1822789);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 20, 180, 21, 224, 24, 116, 37, 28 }, 1822808);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 11, 34 }, 1825500);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 134, 12, 30 }, 1825505);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 13, 222 }, 1825512);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 160, 16, 199, 16, 199 }, 1825517);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 8, 16, 4, 17, 198 }, 1825523);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 142 }, 1825529);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 161, 20, 155, 21, 14, 16, 254, 19, 36, 19, 236 }, 1825531);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 206, 21, 200, 23, 42, 17, 48 }, 1825543);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 186 }, 1825551);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 130 }, 1825553);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 48, 21, 234, 23, 56, 17, 58 }, 1825555);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 186 }, 1825563);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 130 }, 1825565);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 21, 21, 201, 23, 99, 16, 244, 19, 96, 20, 30, 20, 183, 21, 107, 23, 25, 15, 0 }, 1825567);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 92 }, 1825587);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 86, 19, 239, 20, 173, 21, 214, 13, 22, 16, 204, 17, 198, 18, 242, 19, 236, 21, 114, 10, 140, 14, 16, 15, 10, 16, 31, 17, 25, 19, 56, 8, 252, 11, 184, 12, 178, 13, 149, 14, 143, 17, 18 }, 1825589);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16, 51, 16, 199 }, 1825702);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 8, 10, 40, 15, 160, 16, 187, 17, 215, 18, 242, 21, 14, 10, 40, 15, 160, 17, 48, 18, 192, 20, 80, 23, 42, 13, 172, 17, 248, 18, 225, 19, 203, 20, 180, 23, 56, 13, 172, 17, 248, 18, 225, 19, 203, 20, 180, 23, 99, 12, 128, 17, 148, 18, 159, 19, 169, 20, 180, 23, 25, 11, 84, 16, 204, 18, 23, 19, 98, 20, 173, 21, 214, 11, 84, 16, 104, 17, 148, 18, 192, 19, 236, 21, 114, 9, 196, 14, 16, 15, 19, 16, 22, 17, 25, 19, 56, 7, 208, 11, 184, 12, 170, 13, 157, 14, 143, 17, 18 }, 1825707);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 132 }, 1835071);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 18, 17, 19, 73 }, 1835218);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 151 }, 1835229);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 246 }, 1835233);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 245 }, 1835237);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 21, 17 }, 1835242);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 25, 73, 18, 17, 242 }, 1835248);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 18, 17, 19 }, 1835254);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 56, 56, 56, 56, 18, 17, 19, 73, 55, 54 }, 1835258);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 49 }, 1835269);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 115 }, 1835273);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 114 }, 1835277);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 21 }, 1836687);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 10, 10, 10, 10 }, 1836834);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 21 }, 1836845);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 21 }, 1836849);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 21 }, 1836853);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 10, 10 }, 1836858);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 10, 10, 10, 10, 10 }, 1836864);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 10, 10, 8 }, 1836870);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16, 16, 16, 16, 17, 17 }, 1836878);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 17 }, 1836885);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 10 }, 1836889);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 21 }, 1836893);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 0, 0 }, 1859344);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 10, 0, 20 }, 1859347);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 30, 0, 40 }, 1859351);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 50, 0, 60 }, 1859355);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 70 }, 1859359);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 0, 100 }, 1859378);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 50, 0, 40 }, 1859381);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 50, 0, 40 }, 1859385);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 50, 0, 40 }, 1859389);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 50 }, 1859393);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 0, 50 }, 1859410);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 50, 0, 50 }, 1859413);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 200, 0, 50 }, 1859417);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 20, 0, 50 }, 1859421);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 20, 0, 50 }, 1859425);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 20, 0, 50 }, 1859429);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 20, 0, 50 }, 1859433);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 50, 0, 50 }, 1859437);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 200 }, 1859441);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 0, 0 }, 1859446);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 10 }, 1859449);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 110, 3, 151 }, 1859481);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 0, 82 }, 1859498);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 0, 40 }, 1859506);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 40, 0, 40 }, 1859509);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 40 }, 1859513);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 51, 0, 150 }, 1859619);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 40, 0, 150 }, 1859623);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 40, 0, 150 }, 1859627);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 40, 0, 150, 1 }, 1859631);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 0, 1 }, 1859636);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 100, 0, 2 }, 1859639);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 2, 168 }, 1859644);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 50 }, 1859647);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 0, 60 }, 1859808);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 150, 0, 60 }, 1859811);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 150, 1, 244 }, 1859815);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 150, 1, 244 }, 1859819);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 150 }, 1859823);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 252, 205, 252, 205, 249, 154, 192 }, 1859868);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 192 }, 1859876);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 192 }, 1859878);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 192 }, 1859880);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 192 }, 1859882);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 192 }, 1859884);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 192 }, 1859886);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 192 }, 1859888);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 192 }, 1859890);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 192 }, 1859892);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 192 }, 1859894);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 192 }, 1859896);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 192 }, 1859898);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16, 74, 13, 2, 13, 2, 13, 2, 13, 2, 13, 2, 13, 2, 13, 2, 13, 2, 13, 2, 13, 2, 12, 98, 11, 184, 11, 14, 10, 110, 9, 196, 9, 26, 8, 122, 7, 208, 7, 38, 6, 134, 5, 50, 3, 62, 0, 170 }, 1879434);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 89 }, 1879587);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 101, 23, 74, 23, 89, 23, 129, 23, 158, 23, 58, 22, 201, 21, 241, 21, 115, 20, 101, 19, 33, 18, 22, 17, 21, 15, 242, 3, 252 }, 1879589);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 0 }, 1879619);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 4, 26 }, 1887568);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 217, 4, 26 }, 1887571);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 125 }, 1887575);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 162 }, 1887577);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 162 }, 1887579);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 162 }, 1887581);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 155 }, 1887583);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 141 }, 1887585);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 113 }, 1887587);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 106 }, 1887589);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 106 }, 1887591);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 96 }, 1887593);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 86 }, 1887595);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 76 }, 1887597);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 76, 4, 41 }, 1887599);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 217, 4, 26 }, 1887603);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 152 }, 1887607);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 152 }, 1887609);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 152 }, 1887611);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 152 }, 1887613);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 152 }, 1887615);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 141 }, 1887617);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 113 }, 1887619);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 106 }, 1887621);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 106 }, 1887623);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 86 }, 1887625);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 86 }, 1887627);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 143 }, 1887629);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 142 }, 1887631);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 134 }, 1887633);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 217, 4, 26 }, 1887635);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 146 }, 1887639);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 146 }, 1887641);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 146 }, 1887643);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 146 }, 1887645);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 146 }, 1887647);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 146 }, 1887649);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 136 }, 1887651);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 106 }, 1887653);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 106 }, 1887655);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 96 }, 1887657);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 96 }, 1887659);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 143 }, 1887661);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 142 }, 1887663);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 148 }, 1887665);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 217, 4, 26 }, 1887667);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 146 }, 1887671);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 146 }, 1887673);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 146 }, 1887675);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 146 }, 1887677);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 146 }, 1887679);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 146 }, 1887681);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 136 }, 1887683);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 106 }, 1887685);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 96 }, 1887687);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 86, 4, 71 }, 1887689);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 161 }, 1887693);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 175 }, 1887695);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 171 }, 1887697);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 217, 4, 26 }, 1887699);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 146 }, 1887703);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 146 }, 1887705);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 146 }, 1887707);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 146 }, 1887709);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 146 }, 1887711);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 146 }, 1887713);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 136 }, 1887715);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 106 }, 1887717);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 86, 4, 76 }, 1887719);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 145 }, 1887723);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 161 }, 1887725);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 174 }, 1887727);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 168 }, 1887729);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 217 }, 1887731);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 109 }, 1887733);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 196 }, 1887735);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 196 }, 1887737);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 196 }, 1887739);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 196 }, 1887741);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 196 }, 1887743);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 196 }, 1887745);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 136 }, 1887747);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 106 }, 1887749);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 106 }, 1887751);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 125 }, 1887753);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 145 }, 1887755);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 125 }, 1887757);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 140 }, 1887759);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 127 }, 1887761);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 182, 3, 212, 3, 212, 3, 212, 3, 212, 3, 212, 3, 212, 3, 212, 3, 212, 3, 212, 3, 212, 3, 212 }, 1887869);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 3, 232, 3, 232, 3, 232, 3, 232, 3, 232, 3, 232, 3, 212, 3, 212, 3, 212, 3, 212, 3, 212 }, 1887902);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 140 }, 1887931);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16, 3, 232 }, 1887947);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 212 }, 1887951);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 212 }, 1887953);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 212 }, 1887955);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 176 }, 1887963);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 206 }, 1887965);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 126 }, 1887975);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 106 }, 1887977);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 86 }, 1887979);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 66 }, 1887981);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 36 }, 1887983);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 36 }, 1887985);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 36 }, 1887987);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 175 }, 1888003);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 151 }, 1888005);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 123 }, 1888007);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 116 }, 1888009);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 96 }, 1888011);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 86 }, 1888013);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 66 }, 1888015);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 56 }, 1888017);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 56 }, 1888019);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 185 }, 1888035);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 161 }, 1888037);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 123 }, 1888039);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 116 }, 1888041);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 106 }, 1888043);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 96 }, 1888045);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 66 }, 1888047);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 56 }, 1888049);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 56 }, 1888051);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 185 }, 1888067);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 161 }, 1888069);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 123 }, 1888071);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 116 }, 1888073);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 106 }, 1888075);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 96 }, 1888077);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 66 }, 1888079);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 56 }, 1888081);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 56 }, 1888083);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 175 }, 1888099);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 151 }, 1888101);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 123 }, 1888103);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 106 }, 1888105);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 106 }, 1888107);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 86 }, 1888109);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 56 }, 1888111);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 56 }, 1888113);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 56 }, 1888115);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 166 }, 1888131);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 141 }, 1888133);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 113 }, 1888135);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 106 }, 1888137);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 106 }, 1888139);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 86 }, 1888141);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 56 }, 1888143);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 56 }, 1888145);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 56, 4, 26 }, 1888147);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 217, 4, 26 }, 1888151);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 156 }, 1888155);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 162 }, 1888157);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 186 }, 1888159);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 176 }, 1888161);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 155 }, 1888163);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 141 }, 1888165);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 113, 4, 106, 4, 106 }, 1888167);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 96 }, 1888173);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 86, 4, 76, 4, 76, 4, 41 }, 1888175);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 217, 4, 26 }, 1888183);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 152 }, 1888187);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 152 }, 1888189);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 152 }, 1888191);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 152 }, 1888193);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 152 }, 1888195);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 141 }, 1888197);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 113, 4, 106, 4, 106, 4, 86, 4, 86, 4, 143, 4, 142, 4, 134 }, 1888199);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 217, 4, 26 }, 1888215);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 146 }, 1888219);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 146 }, 1888221);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 146 }, 1888223);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 146 }, 1888225);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 146 }, 1888227);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 146 }, 1888229);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 136, 4, 106, 4, 106, 4, 96, 4, 96, 4, 143, 4, 142, 4, 148 }, 1888231);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 217, 4, 26 }, 1888247);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 146 }, 1888251);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 146 }, 1888253);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 146 }, 1888255);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 146 }, 1888257);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 146 }, 1888259);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 146 }, 1888261);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 136, 4, 106, 4, 96, 4, 86, 4, 71, 4, 161, 4, 175, 4, 171 }, 1888263);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 217, 4, 26 }, 1888279);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 146 }, 1888283);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 146 }, 1888285);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 146 }, 1888287);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 146 }, 1888289);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 146 }, 1888291);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 146 }, 1888293);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 136, 4, 106, 4, 86, 4, 76, 4, 145, 4, 161, 4, 174, 4, 168 }, 1888295);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 217 }, 1888311);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 109 }, 1888313);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 196 }, 1888315);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 196 }, 1888317);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 196 }, 1888319);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 196 }, 1888321);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 196 }, 1888323);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 196 }, 1888325);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 136, 4, 106, 4, 106, 4, 125, 4, 145, 4, 125, 4, 140, 4, 127 }, 1888327);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 88 }, 1889029);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 88 }, 1889031);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 88 }, 1889033);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 88 }, 1889035);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 88 }, 1889037);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 88 }, 1889039);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 88 }, 1889041);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 88 }, 1889043);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 88 }, 1889045);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 88 }, 1889047);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 88 }, 1889049);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 88 }, 1889051);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 162 }, 1889063);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 162 }, 1889065);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 162 }, 1889067);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 162 }, 1889069);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 162 }, 1889071);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 162 }, 1889073);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 162 }, 1889075);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 162 }, 1889077);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 162 }, 1889079);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 162 }, 1889081);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 162 }, 1889083);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 146 }, 1889091);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 142 }, 1889107);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 142 }, 1889109);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 142 }, 1889111);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 142 }, 1889113);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 142 }, 1889115);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 30 }, 1889123);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 246 }, 1889125);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 3, 252 }, 1889134);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 212, 3, 182, 3, 182, 3, 182, 3, 182, 3, 182 }, 1889137);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 196 }, 1889163);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 86 }, 1889165);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 36 }, 1889167);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 232 }, 1889169);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 232, 3, 232, 3, 232, 3, 232, 3, 232 }, 1889171);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 196 }, 1889195);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 176 }, 1889197);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 156 }, 1889199);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 86 }, 1889201);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 36 }, 1889203);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 242 }, 1889205);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 242, 3, 242, 3, 242 }, 1889207);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 196 }, 1889227);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 176 }, 1889229);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 156 }, 1889231);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 126 }, 1889233);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 36 }, 1889235);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 242 }, 1889237);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 242, 3, 242, 3, 242 }, 1889239);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 196 }, 1889259);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 176 }, 1889261);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 156 }, 1889263);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 146 }, 1889265);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 36, 3, 242, 3, 242, 3, 242, 3, 242 }, 1889267);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 196 }, 1889291);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 176 }, 1889293);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 156 }, 1889295);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 146, 4, 36 }, 1889297);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 26 }, 1889301);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 26 }, 1889303);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 26 }, 1889305);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 26, 4, 26 }, 1889307);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 96, 5, 40, 5, 30 }, 1889311);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 246 }, 1889317);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 236 }, 1889319);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 226 }, 1889321);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 196 }, 1889323);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 176 }, 1889325);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 156, 4, 146, 4, 66 }, 1889327);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 36 }, 1889333);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 36, 4, 36, 4, 36, 4, 36 }, 1889335);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 186 }, 1889343);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 186 }, 1889345);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 186 }, 1889347);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 186 }, 1889349);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 186 }, 1889351);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 186 }, 1889353);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 186 }, 1889355);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 186 }, 1889357);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 186, 4, 166, 4, 76, 4, 36, 4, 36, 4, 36, 4, 36, 4, 36 }, 1889359);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 176 }, 1889375);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 176 }, 1889377);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 176 }, 1889379);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 176 }, 1889381);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 176 }, 1889383);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 176 }, 1889385);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 176 }, 1889387);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 176 }, 1889389);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 176, 4, 176, 4, 76, 4, 46, 4, 46, 4, 46, 4, 46, 4, 46 }, 1889391);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 156 }, 1889407);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 156 }, 1889409);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 156 }, 1889411);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 156 }, 1889413);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 156 }, 1889415);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 156 }, 1889417);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 156 }, 1889419);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 176 }, 1889421);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 176, 4, 176, 4, 76, 4, 66, 4, 66, 4, 66, 4, 66, 4, 66 }, 1889423);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 156 }, 1889439);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 156 }, 1889441);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 156 }, 1889443);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 156 }, 1889445);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 156 }, 1889447);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 156 }, 1889449);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 156 }, 1889451);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 156 }, 1889453);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 156 }, 1889455);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 206, 4, 76, 4, 76, 4, 76, 4, 76, 4, 76, 4, 76 }, 1889457);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 196 }, 1889471);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 196 }, 1889473);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 196 }, 1889475);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 196 }, 1889477);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 196 }, 1889479);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 196 }, 1889481);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 196 }, 1889483);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 196 }, 1889485);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 196 }, 1889487);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 206, 4, 126, 4, 126, 4, 126, 4, 126, 4, 126, 4, 126 }, 1889489);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 37, 133, 40, 196 }, 1891866);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 34, 136, 37, 121 }, 1891898);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 32, 111, 34, 241 }, 1891930);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 27, 178, 32, 230 }, 1891962);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 27, 83, 30, 167 }, 1891994);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 27, 188, 30, 90 }, 1892026);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 29, 31, 30, 120 }, 1892058);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 30, 30, 30, 230 }, 1892090);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 29, 76, 31, 106 }, 1892122);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 30, 80, 31, 166 }, 1892154);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 32, 228, 33, 62 }, 1892186);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 35, 40, 35, 123 }, 1892218);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 36, 254, 37, 178 }, 1892250);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 38, 122, 40, 80 }, 1892282);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 40, 30, 42, 158 }, 1892314);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 37, 243, 42, 44 }, 1892412);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 33, 192, 37, 191 }, 1892444);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 31, 72, 34, 186 }, 1892476);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 29, 36, 31, 254 }, 1892508);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 27, 134, 30, 47 }, 1892540);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 27, 8, 30, 57 }, 1892572);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 27, 118, 30, 153 }, 1892604);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 27, 188, 31, 144 }, 1892636);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 29, 51, 33, 94 }, 1892668);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 30, 33, 34, 28 }, 1892700);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 31, 14, 34, 216 }, 1892732);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 31, 219, 35, 135 }, 1892764);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 32, 168, 36, 54 }, 1892796);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 34, 147, 38, 87 }, 1892828);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 36, 126, 40, 119 }, 1892860);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 33, 186, 37, 133 }, 1892958);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 30, 167, 34, 136 }, 1892990);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 28, 27, 32, 111 }, 1893022);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 24, 31, 27, 178 }, 1893054);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 23, 147, 27, 83 }, 1893086);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 23, 172, 27, 188 }, 1893118);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 23 }, 1893150);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 29, 31 }, 1893152);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 25, 40, 30, 30 }, 1893182);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 25, 170, 29, 76 }, 1893214);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 26, 63, 30, 80 }, 1893246);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 26, 174, 32, 228 }, 1893278);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 32, 88, 35, 40 }, 1893310);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 33, 252, 36, 254 }, 1893342);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 32, 245, 37, 21 }, 1893504);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 29, 11, 32, 242 }, 1893536);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 27, 141, 30, 246 }, 1893568);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 26, 18, 28, 230 }, 1893600);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 23, 240, 26, 129 }, 1893632);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 23, 135, 26, 173 }, 1893664);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 23, 88, 27, 27 }, 1893696);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 23, 65, 26, 250 }, 1893728);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 24, 63, 28, 73 }, 1893760);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 24, 195, 28, 135 }, 1893792);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 25, 151, 29, 37 }, 1893824);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 26, 116, 29, 230 }, 1893856);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 27, 80, 30, 166 }, 1893888);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 22, 168, 22, 168, 21, 124, 19, 236, 18, 192, 17, 148, 17, 48, 16, 204, 16, 104, 16, 4 }, 1898996);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 22, 168, 21, 224, 21, 24, 19, 36, 17, 148, 17, 48, 16, 204 }, 1899022);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 21, 24, 19, 136, 19, 36, 18, 92 }, 1899048);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 22, 168, 22, 68, 21, 124, 20, 180 }, 1899068);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 24, 156, 24, 156, 24, 56, 23, 12 }, 1899088);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 26, 144, 26, 244, 26, 44, 25, 100 }, 1899108);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 25, 0, 25, 0 }, 1919194);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 24, 156, 24, 156 }, 1919224);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 25, 100, 25, 200 }, 1919254);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 24, 156, 25, 100, 25, 200 }, 1919282);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 25, 0, 25, 100, 25, 100 }, 1919312);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 25, 0, 25, 100, 25, 200 }, 1919342);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 25, 0, 25, 100, 25, 200 }, 1919372);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 25, 0, 25, 100, 25, 200 }, 1919402);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 25, 100, 25, 200, 25, 200 }, 1919432);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 25, 200, 26, 44, 26, 44 }, 1919462);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 25, 200, 25, 200, 26, 44 }, 1919492);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 26, 244, 27, 188, 27, 188, 23, 112, 23, 112, 23, 112, 23, 112 }, 1919522);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 112, 23, 112, 23, 112, 23, 112, 23, 112, 23, 112, 23, 112, 23, 112, 23, 112, 23, 112, 23, 112, 23, 112 }, 1919537);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 24, 66, 24, 76 }, 1919772);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 24, 46, 24, 26 }, 1919802);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 24, 166, 25, 20 }, 1919832);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 24, 26, 24, 196, 25, 60 }, 1919860);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 24, 66, 24, 156, 24, 246 }, 1919890);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 24, 66, 24, 166, 25, 0 }, 1919920);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 24, 86, 24, 176, 25, 10 }, 1919950);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 24, 116, 24, 206, 25, 30 }, 1919980);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 24, 186, 25, 0, 25, 70 }, 1920010);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 25, 40, 25, 100, 25, 150 }, 1920040);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 25, 180, 25, 244, 26, 20, 23, 112, 23, 112, 23, 112, 23, 112, 23, 112 }, 1920070);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 112 }, 1920087);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 112, 23, 112, 23, 112, 23, 112, 23, 112, 23, 112, 23, 112, 23, 112, 23, 112, 23, 112, 23, 112, 23, 112, 23, 112, 23, 112, 23, 112 }, 1920089);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 112 }, 1920119);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 112, 23, 112, 23, 112, 23, 112, 23, 112, 23, 112, 23, 112, 23, 112, 23, 112, 23, 112, 23, 112 }, 1920121);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 33, 52, 33, 52, 33, 52, 33, 52, 33, 52, 33, 52, 33, 52, 33, 52, 33, 52, 33, 52, 33, 52, 33, 52, 33, 52, 33, 52, 33, 52, 33, 52, 33, 52, 33, 52, 33, 52, 33, 52, 33, 52, 33, 52, 33, 52, 33, 52, 33, 52, 33, 52, 33, 52, 33, 52, 33, 52, 33, 52, 33, 52, 33, 52, 33, 52, 33, 52, 33, 52, 33, 52, 33, 52, 33, 52, 33, 52, 33, 52, 33, 52, 33, 52, 33, 52, 33, 52, 33, 52, 33, 52, 33, 52, 33, 52, 33, 52, 33, 52, 33, 52, 33, 52, 33, 52, 33, 52, 33, 52, 33, 52, 33, 52, 33, 52, 33, 52, 33, 52, 33, 52, 33, 52, 33, 52, 33, 52 }, 1921014);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 24, 87, 23, 93 }, 1921150);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 1, 251 }, 1992370);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 77 }, 1992373);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 161 }, 1992375);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 4 }, 1992377);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 87 }, 1992379);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 185 }, 1992381);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 71 }, 1992383);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 52 }, 1992385);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 36 }, 1992387);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 126 }, 1992389);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 194 }, 1992411);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 31 }, 1992413);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 91 }, 1992415);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 179 }, 1992417);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 10 }, 1992419);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 84, 3, 240 }, 1992421);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 188 }, 1992425);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 145 }, 1992427);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 177 }, 1992429);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 166 }, 1992451);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 236 }, 1992453);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 57 }, 1992455);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 119 }, 1992457);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 198 }, 1992459);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 5 }, 1992461);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 164 }, 1992463);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 101 }, 1992465);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 46 }, 1992467);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 61 }, 1992469);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 152 }, 1992491);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 196 }, 1992493);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 8 }, 1992495);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 73 }, 1992497);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 137 }, 1992499);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 212 }, 1992501);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 75 }, 1992503);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 36, 4, 210, 5, 214 }, 1992505);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 133 }, 1992531);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 178 }, 1992533);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 225 }, 1992535);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 37 }, 1992537);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 101 }, 1992539);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 153 }, 1992541);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 26 }, 1992543);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 200 }, 1992545);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 133, 5, 138 }, 1992547);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 117 }, 1992571);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 167 }, 1992573);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 208 }, 1992575);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 1 }, 1992577);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 66 }, 1992579);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 119, 2, 234 }, 1992581);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 139 }, 1992585);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 64 }, 1992587);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 62 }, 1992589);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 102 }, 1992611);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 152 }, 1992613);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 202, 1, 237 }, 1992615);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 38 }, 1992619);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 89 }, 1992621);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 189 }, 1992623);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 86, 3, 253, 4, 225 }, 1992625);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 90 }, 1992651);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 137 }, 1992653);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 184 }, 1992655);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 228 }, 1992657);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 11 }, 1992659);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 61 }, 1992661);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 158 }, 1992663);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 55, 3, 192 }, 1992665);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 126 }, 1992669);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 78 }, 1992691);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 125 }, 1992693);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 167 }, 1992695);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 212, 1, 248 }, 1992697);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 33 }, 1992701);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 123 }, 1992703);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 15 }, 1992705);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 154 }, 1992707);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 109 }, 1992709);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 57 }, 1992731);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 102 }, 1992733);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 142 }, 1992735);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 178 }, 1992737);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 216, 1, 250 }, 1992739);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 67, 2, 205 }, 1992743);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 80, 3, 228 }, 1992747);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 55 }, 1992771);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 93 }, 1992773);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 132 }, 1992775);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 171 }, 1992777);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 210, 1, 248 }, 1992779);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 28 }, 1992783);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 149 }, 1992785);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 19, 3, 191 }, 1992787);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 1, 251 }, 1993086);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 77 }, 1993089);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 161 }, 1993091);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 4 }, 1993093);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 87 }, 1993095);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 185 }, 1993097);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 71 }, 1993099);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 52 }, 1993101);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 36 }, 1993103);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 126 }, 1993105);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 194 }, 1993127);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 31 }, 1993129);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 91 }, 1993131);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 179 }, 1993133);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 10 }, 1993135);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 84, 3, 240 }, 1993137);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 188 }, 1993141);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 145 }, 1993143);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 177 }, 1993145);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 166 }, 1993167);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 236 }, 1993169);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 57 }, 1993171);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 119 }, 1993173);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 198 }, 1993175);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 5 }, 1993177);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 164 }, 1993179);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 101 }, 1993181);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 46 }, 1993183);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 61 }, 1993185);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 152 }, 1993207);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 196 }, 1993209);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 8 }, 1993211);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 73 }, 1993213);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 137 }, 1993215);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 212 }, 1993217);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 75 }, 1993219);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 36, 4, 210, 5, 214 }, 1993221);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 133 }, 1993247);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 178 }, 1993249);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 225 }, 1993251);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 37 }, 1993253);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 101 }, 1993255);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 153 }, 1993257);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 26 }, 1993259);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 200 }, 1993261);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 133, 5, 138 }, 1993263);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 117 }, 1993287);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 167 }, 1993289);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 208 }, 1993291);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 1 }, 1993293);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 66 }, 1993295);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 119, 2, 234 }, 1993297);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 139 }, 1993301);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 64 }, 1993303);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 62 }, 1993305);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 102 }, 1993327);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 152 }, 1993329);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 202, 1, 237 }, 1993331);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 38 }, 1993335);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 89 }, 1993337);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 189 }, 1993339);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 86, 3, 253, 4, 225 }, 1993341);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 90 }, 1993367);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 137 }, 1993369);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 184 }, 1993371);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 228 }, 1993373);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 11 }, 1993375);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 61 }, 1993377);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 158 }, 1993379);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 55, 3, 192 }, 1993381);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 126 }, 1993385);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 78 }, 1993407);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 125 }, 1993409);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 167 }, 1993411);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 212, 1, 248 }, 1993413);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 33 }, 1993417);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 123 }, 1993419);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 15 }, 1993421);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 154 }, 1993423);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 109 }, 1993425);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 57 }, 1993447);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 102 }, 1993449);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 142 }, 1993451);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 178 }, 1993453);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 216, 1, 250 }, 1993455);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 67, 2, 205 }, 1993459);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 80, 3, 228 }, 1993463);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 55 }, 1993487);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 93 }, 1993489);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 132 }, 1993491);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 171 }, 1993493);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 210, 1, 248 }, 1993495);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 28 }, 1993499);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 149 }, 1993501);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 19, 3, 191 }, 1993503);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 1, 251 }, 1993802);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 77 }, 1993805);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 161 }, 1993807);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 4 }, 1993809);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 87 }, 1993811);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 185 }, 1993813);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 71 }, 1993815);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 52 }, 1993817);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 36 }, 1993819);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 126 }, 1993821);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 194 }, 1993843);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 31 }, 1993845);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 91 }, 1993847);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 179 }, 1993849);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 10 }, 1993851);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 84, 3, 240 }, 1993853);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 188 }, 1993857);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 145 }, 1993859);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 177 }, 1993861);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 166 }, 1993883);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 236 }, 1993885);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 57 }, 1993887);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 119 }, 1993889);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 198 }, 1993891);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 5 }, 1993893);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 164 }, 1993895);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 101 }, 1993897);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 46 }, 1993899);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 61 }, 1993901);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 152 }, 1993923);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 196 }, 1993925);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 8 }, 1993927);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 73 }, 1993929);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 137 }, 1993931);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 212 }, 1993933);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 75 }, 1993935);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 36, 4, 210, 5, 214 }, 1993937);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 133 }, 1993963);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 178 }, 1993965);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 225 }, 1993967);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 37 }, 1993969);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 101 }, 1993971);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 153 }, 1993973);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 26 }, 1993975);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 200 }, 1993977);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 133, 5, 138 }, 1993979);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 117 }, 1994003);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 167 }, 1994005);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 208 }, 1994007);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 1 }, 1994009);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 66 }, 1994011);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 119, 2, 234 }, 1994013);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 139 }, 1994017);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 64 }, 1994019);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 62 }, 1994021);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 102 }, 1994043);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 152 }, 1994045);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 202, 1, 237 }, 1994047);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 38 }, 1994051);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 89 }, 1994053);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 189 }, 1994055);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 86, 3, 253, 4, 225 }, 1994057);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 90 }, 1994083);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 137 }, 1994085);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 184 }, 1994087);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 228 }, 1994089);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 11 }, 1994091);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 61 }, 1994093);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 158 }, 1994095);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 55, 3, 192 }, 1994097);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 126 }, 1994101);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 78 }, 1994123);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 125 }, 1994125);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 167 }, 1994127);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 212, 1, 248 }, 1994129);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 33 }, 1994133);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 123 }, 1994135);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 15 }, 1994137);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 154 }, 1994139);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 109 }, 1994141);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 57 }, 1994163);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 102 }, 1994165);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 142 }, 1994167);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 178 }, 1994169);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 216, 1, 250 }, 1994171);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 67, 2, 205 }, 1994175);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 80, 3, 228 }, 1994179);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 55 }, 1994203);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 93 }, 1994205);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 132 }, 1994207);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 171 }, 1994209);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 210, 1, 248 }, 1994211);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 28 }, 1994215);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 149 }, 1994217);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 19, 3, 191 }, 1994219);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 1, 251 }, 1994518);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 77 }, 1994521);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 161 }, 1994523);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 4 }, 1994525);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 87 }, 1994527);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 185 }, 1994529);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 71 }, 1994531);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 52 }, 1994533);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 36 }, 1994535);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 126 }, 1994537);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 194 }, 1994559);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 31 }, 1994561);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 91 }, 1994563);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 179 }, 1994565);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 10 }, 1994567);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 84, 3, 240 }, 1994569);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 188 }, 1994573);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 145 }, 1994575);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 177 }, 1994577);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 166 }, 1994599);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 236 }, 1994601);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 57 }, 1994603);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 119 }, 1994605);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 198 }, 1994607);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 5 }, 1994609);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 164 }, 1994611);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 101 }, 1994613);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 46 }, 1994615);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 61 }, 1994617);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 152 }, 1994639);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 196 }, 1994641);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 8 }, 1994643);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 73 }, 1994645);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 137 }, 1994647);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 212 }, 1994649);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 75 }, 1994651);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 36, 4, 210, 5, 214 }, 1994653);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 133 }, 1994679);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 178 }, 1994681);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 225 }, 1994683);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 37 }, 1994685);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 101 }, 1994687);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 153 }, 1994689);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 26 }, 1994691);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 200 }, 1994693);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 133, 5, 138 }, 1994695);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 117 }, 1994719);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 167 }, 1994721);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 208 }, 1994723);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 1 }, 1994725);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 66 }, 1994727);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 119, 2, 234 }, 1994729);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 139 }, 1994733);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 64 }, 1994735);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 62 }, 1994737);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 102 }, 1994759);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 152 }, 1994761);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 202, 1, 237 }, 1994763);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 38 }, 1994767);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 89 }, 1994769);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 189 }, 1994771);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 86, 3, 253, 4, 225 }, 1994773);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 90 }, 1994799);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 137 }, 1994801);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 184 }, 1994803);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 228 }, 1994805);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 11 }, 1994807);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 61 }, 1994809);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 158 }, 1994811);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 55, 3, 192 }, 1994813);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 126 }, 1994817);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 78 }, 1994839);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 125 }, 1994841);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 167 }, 1994843);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 212, 1, 248 }, 1994845);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 33 }, 1994849);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 123 }, 1994851);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 15 }, 1994853);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 154 }, 1994855);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 109 }, 1994857);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 57 }, 1994879);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 102 }, 1994881);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 142 }, 1994883);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 178 }, 1994885);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 216, 1, 250 }, 1994887);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 67, 2, 205 }, 1994891);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 80, 3, 228 }, 1994895);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 55 }, 1994919);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 93 }, 1994921);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 132 }, 1994923);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 171 }, 1994925);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 210, 1, 248 }, 1994927);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 28 }, 1994931);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 149 }, 1994933);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 19, 3, 191 }, 1994935);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 1, 251 }, 1995234);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 77 }, 1995237);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 161 }, 1995239);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 4 }, 1995241);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 87 }, 1995243);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 185 }, 1995245);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 71 }, 1995247);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 52 }, 1995249);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 36 }, 1995251);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 126 }, 1995253);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 194 }, 1995275);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 31 }, 1995277);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 91 }, 1995279);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 179 }, 1995281);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 10 }, 1995283);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 84, 3, 240 }, 1995285);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 188 }, 1995289);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 145 }, 1995291);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 177 }, 1995293);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 166 }, 1995315);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 236 }, 1995317);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 57 }, 1995319);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 119 }, 1995321);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 198 }, 1995323);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 5 }, 1995325);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 164 }, 1995327);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 101 }, 1995329);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 46 }, 1995331);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 61 }, 1995333);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 152 }, 1995355);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 196 }, 1995357);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 8 }, 1995359);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 73 }, 1995361);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 137 }, 1995363);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 212 }, 1995365);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 75 }, 1995367);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 36, 4, 210, 5, 214 }, 1995369);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 133 }, 1995395);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 178 }, 1995397);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 225 }, 1995399);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 37 }, 1995401);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 101 }, 1995403);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 153 }, 1995405);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 26 }, 1995407);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 200 }, 1995409);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 133, 5, 138 }, 1995411);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 117 }, 1995435);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 167 }, 1995437);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 208 }, 1995439);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 1 }, 1995441);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 66 }, 1995443);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 119, 2, 234 }, 1995445);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 139 }, 1995449);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 64 }, 1995451);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 62 }, 1995453);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 102 }, 1995475);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 152 }, 1995477);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 202, 1, 237 }, 1995479);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 38 }, 1995483);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 89 }, 1995485);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 189 }, 1995487);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 86, 3, 253, 4, 225 }, 1995489);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 90 }, 1995515);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 137 }, 1995517);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 184 }, 1995519);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 228 }, 1995521);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 11 }, 1995523);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 61 }, 1995525);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 158 }, 1995527);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 55, 3, 192 }, 1995529);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 126 }, 1995533);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 78 }, 1995555);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 125 }, 1995557);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 167 }, 1995559);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 212, 1, 248 }, 1995561);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 33 }, 1995565);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 123 }, 1995567);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 15 }, 1995569);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 154 }, 1995571);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 109 }, 1995573);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 57 }, 1995595);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 102 }, 1995597);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 142 }, 1995599);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 178 }, 1995601);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 216, 1, 250 }, 1995603);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 67, 2, 205 }, 1995607);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 80, 3, 228 }, 1995611);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 55 }, 1995635);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 93 }, 1995637);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 132 }, 1995639);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 171 }, 1995641);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 210, 1, 248 }, 1995643);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 28 }, 1995647);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 149 }, 1995649);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 19, 3, 191 }, 1995651);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 1, 251 }, 1995950);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 77 }, 1995953);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 161 }, 1995955);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 4 }, 1995957);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 87 }, 1995959);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 185 }, 1995961);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 71 }, 1995963);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 52 }, 1995965);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 36 }, 1995967);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 126 }, 1995969);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 194 }, 1995991);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 31 }, 1995993);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 91 }, 1995995);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 179 }, 1995997);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 10 }, 1995999);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 84, 3, 240 }, 1996001);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 188 }, 1996005);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 145 }, 1996007);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 177 }, 1996009);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 166 }, 1996031);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 236 }, 1996033);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 57 }, 1996035);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 119 }, 1996037);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 198 }, 1996039);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 5 }, 1996041);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 164 }, 1996043);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 101 }, 1996045);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 46 }, 1996047);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 61 }, 1996049);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 152 }, 1996071);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 196 }, 1996073);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 8 }, 1996075);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 73 }, 1996077);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 137 }, 1996079);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 212 }, 1996081);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 75 }, 1996083);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 36, 4, 210, 5, 214 }, 1996085);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 133 }, 1996111);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 178 }, 1996113);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 225 }, 1996115);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 37 }, 1996117);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 101 }, 1996119);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 153 }, 1996121);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 26 }, 1996123);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 200 }, 1996125);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 133, 5, 138 }, 1996127);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 117 }, 1996151);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 167 }, 1996153);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 208 }, 1996155);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 1 }, 1996157);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 66 }, 1996159);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 119, 2, 234 }, 1996161);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 139 }, 1996165);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 64 }, 1996167);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 62 }, 1996169);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 102 }, 1996191);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 152 }, 1996193);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 202, 1, 237 }, 1996195);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 38 }, 1996199);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 89 }, 1996201);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 189 }, 1996203);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 86, 3, 253, 4, 225 }, 1996205);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 90 }, 1996231);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 137 }, 1996233);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 184 }, 1996235);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 228 }, 1996237);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 11 }, 1996239);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 61 }, 1996241);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 158 }, 1996243);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 55, 3, 192 }, 1996245);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 126 }, 1996249);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 78 }, 1996271);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 125 }, 1996273);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 167 }, 1996275);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 212, 1, 248 }, 1996277);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 33 }, 1996281);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 123 }, 1996283);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 15 }, 1996285);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 154 }, 1996287);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 109 }, 1996289);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 57 }, 1996311);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 102 }, 1996313);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 142 }, 1996315);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 178 }, 1996317);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 216, 1, 250 }, 1996319);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 67, 2, 205 }, 1996323);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 80, 3, 228 }, 1996327);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 55 }, 1996351);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 93 }, 1996353);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 132 }, 1996355);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 171 }, 1996357);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 210, 1, 248 }, 1996359);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 28 }, 1996363);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 149 }, 1996365);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 19, 3, 191 }, 1996367);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 78, 6, 234, 7, 162 }, 2020559);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 27, 8, 165, 8, 243 }, 2020565);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 80, 9, 158, 9, 221, 9, 221, 6, 216 }, 2020571);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 139 }, 2020581);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 111, 8, 237 }, 2020583);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 54 }, 2020587);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 125, 9, 185, 9, 251 }, 2020589);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 60 }, 2020595);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 60 }, 2020597);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 44, 7, 252, 8, 230 }, 2020599);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 93 }, 2020605);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 140, 9, 197, 9, 243 }, 2020607);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 49 }, 2020613);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 100 }, 2020615);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 100 }, 2020617);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 88 }, 2020619);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 30 }, 2020621);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 27, 9, 149, 9, 182, 9, 224 }, 2020623);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 6 }, 2020631);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 73 }, 2020633);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 130 }, 2020635);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 130 }, 2020637);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 60 }, 2020639);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 7 }, 2020641);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 7 }, 2020643);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 139, 9, 186, 9, 224 }, 2020645);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 10 }, 2020651);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 73 }, 2020653);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 140 }, 2020655);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 140, 6, 243, 7, 193, 8, 190 }, 2020657);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 74, 9, 153, 9, 200, 9, 242 }, 2020665);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 53 }, 2020673);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 120 }, 2020675);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 120, 6, 148 }, 2020677);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 100 }, 2020681);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 96, 8, 229 }, 2020683);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 75, 9, 157, 9, 223 }, 2020687);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 24 }, 2020693);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 100 }, 2020695);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 100 }, 2020697);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 52, 6, 255, 7, 247 }, 2020699);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 132, 8, 246 }, 2020705);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 95, 9, 176, 9, 241 }, 2020709);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 50 }, 2020715);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 50, 5, 216, 6, 172 }, 2020717);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 143 }, 2020723);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 29, 8, 158 }, 2020725);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 20 }, 2020729);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 114, 9, 177, 9, 241, 9, 241 }, 2020731);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 122 }, 2020739);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 86 }, 2020741);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 49, 7, 190 }, 2020743);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 84, 8, 206 }, 2020747);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 57 }, 2020751);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 119, 9, 181, 9, 181 }, 2020753);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 35, 5, 245, 6, 214 }, 2020759);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 98, 7, 255 }, 2020765);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 139 }, 2020769);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 4 }, 2020771);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 70 }, 2020773);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 131 }, 2020775);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 131, 4, 216, 5, 160 }, 2020777);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 124 }, 2020783);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 8, 7, 184 }, 2020785);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 78, 8, 208 }, 2020789);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 26 }, 2020793);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 86 }, 2020795);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 86 }, 2020797);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 76 }, 2020799);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 25, 5, 230 }, 2020801);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 99 }, 2020805);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 32, 7, 235 }, 2020807);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 112, 8, 199 }, 2020811);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 6 }, 2020815);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 6 }, 2020817);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 8, 202 }, 2021020);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 78, 6, 234, 7, 162 }, 2021159);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 27, 8, 165, 8, 243 }, 2021165);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 80, 9, 158, 9, 221, 9, 221, 6, 216 }, 2021171);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 139 }, 2021181);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 111, 8, 237 }, 2021183);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 54 }, 2021187);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 125, 9, 185, 9, 251 }, 2021189);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 60 }, 2021195);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 60 }, 2021197);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 44, 7, 252, 8, 230 }, 2021199);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 93 }, 2021205);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 140, 9, 197, 9, 243 }, 2021207);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 49 }, 2021213);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 100 }, 2021215);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 100 }, 2021217);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 88 }, 2021219);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 30 }, 2021221);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 27, 9, 149, 9, 182, 9, 224 }, 2021223);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 6 }, 2021231);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 73 }, 2021233);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 130 }, 2021235);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 130 }, 2021237);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 60 }, 2021239);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 7 }, 2021241);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 7 }, 2021243);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 139, 9, 186, 9, 224 }, 2021245);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 10 }, 2021251);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 73 }, 2021253);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 140 }, 2021255);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 140, 6, 243, 7, 193, 8, 190 }, 2021257);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 74, 9, 153, 9, 200, 9, 242 }, 2021265);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 53 }, 2021273);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 120 }, 2021275);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 120, 6, 148 }, 2021277);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 100 }, 2021281);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 96, 8, 229 }, 2021283);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 75, 9, 157, 9, 223 }, 2021287);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 24 }, 2021293);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 100 }, 2021295);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 100 }, 2021297);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 52, 6, 255, 7, 247 }, 2021299);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 132, 8, 246 }, 2021305);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 95, 9, 176, 9, 241 }, 2021309);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 50 }, 2021315);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 50, 5, 216, 6, 172 }, 2021317);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 143 }, 2021323);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 29, 8, 158 }, 2021325);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 20 }, 2021329);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 114, 9, 177, 9, 241, 9, 241 }, 2021331);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 122 }, 2021339);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 86 }, 2021341);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 49, 7, 190 }, 2021343);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 84, 8, 206 }, 2021347);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 57 }, 2021351);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 119, 9, 181, 9, 181 }, 2021353);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 35, 5, 245, 6, 214 }, 2021359);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 98, 7, 255 }, 2021365);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 139 }, 2021369);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 4 }, 2021371);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 70 }, 2021373);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 131 }, 2021375);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 131, 4, 216, 5, 160 }, 2021377);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 124 }, 2021383);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 8, 7, 184 }, 2021385);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 78, 8, 208 }, 2021389);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 26 }, 2021393);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 86 }, 2021395);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 86 }, 2021397);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 76 }, 2021399);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 25, 5, 230 }, 2021401);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 99 }, 2021405);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 32, 7, 235 }, 2021407);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 112, 8, 199 }, 2021411);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 6 }, 2021415);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 6 }, 2021417);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 11, 184, 12, 178, 13, 172, 14, 166, 15, 160, 16, 154, 17, 148, 18, 142 }, 2021426);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 9, 206, 9, 206, 9, 206, 9, 206, 9, 206, 9, 206, 9, 206, 9, 206, 9, 206, 9, 206, 9, 176, 9, 146, 9, 146, 9, 146, 9, 231, 9, 231, 9, 231, 9, 146, 9, 71, 9, 71, 9, 71 }, 2021458);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 0 }, 2021501);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 0 }, 2021503);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 0, 9, 126, 9, 46, 9, 46, 9, 46 }, 2021505);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 0 }, 2021515);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 0 }, 2021517);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 0, 9, 106, 9, 16, 9, 16, 9, 16, 9, 176, 9, 176, 9, 176, 9, 76, 9, 16, 9, 16, 9, 16, 9, 96, 9, 96, 9, 96, 9, 56, 9, 16, 9, 16, 9, 16 }, 2021519);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 21 }, 2021557);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 21 }, 2021559);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 21 }, 2021561);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16 }, 2021563);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16 }, 2021565);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16 }, 2021567);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16, 8, 227, 8, 227, 8, 227, 8, 227, 8, 227, 8, 227, 8, 227, 8, 152, 8, 152, 8, 152, 8, 152, 8, 152, 8, 152, 8, 152, 9, 196, 9, 196, 9, 196, 9, 196, 9, 196, 9, 196, 9, 196, 9, 196, 9, 196, 9, 196, 9, 196 }, 2021569);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 130 }, 2021659);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 130 }, 2021661);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 130 }, 2021663);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 130 }, 2021665);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 130 }, 2021667);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 130 }, 2021669);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 130 }, 2021671);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 140 }, 2021673);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 140 }, 2021675);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 140 }, 2021677);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 140 }, 2021679);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 140 }, 2021681);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 140 }, 2021683);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 140 }, 2021685);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 120 }, 2021687);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 120 }, 2021689);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 120 }, 2021691);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 120 }, 2021693);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 120 }, 2021695);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 120 }, 2021697);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 120 }, 2021699);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 100 }, 2021701);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 100 }, 2021703);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 100 }, 2021705);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 100 }, 2021707);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 100 }, 2021709);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 100 }, 2021711);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 100 }, 2021713);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 50 }, 2021715);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 50 }, 2021717);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 50 }, 2021719);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 50 }, 2021721);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 50 }, 2021723);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 50 }, 2021725);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 50, 9, 241, 9, 241, 9, 241, 9, 241, 9, 241, 9, 241, 9, 241, 9, 181, 9, 181, 9, 181, 9, 181, 9, 181, 9, 181, 9, 181 }, 2021727);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 131 }, 2021757);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 131 }, 2021759);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 131 }, 2021761);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 131 }, 2021763);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 131 }, 2021765);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 131 }, 2021767);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 131 }, 2021769);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 86 }, 2021771);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 86 }, 2021773);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 86 }, 2021775);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 86 }, 2021777);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 86 }, 2021779);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 86 }, 2021781);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 86 }, 2021783);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 6 }, 2021785);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 6 }, 2021787);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 6 }, 2021789);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 6 }, 2021791);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 6 }, 2021793);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 6 }, 2021795);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 6, 9, 196, 9, 196, 9, 196, 9, 196, 9, 196, 9, 196, 9, 196, 9, 196, 9, 196, 9, 196, 9, 196 }, 2021797);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 130 }, 2021879);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 130 }, 2021881);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 130 }, 2021883);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 130 }, 2021885);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 130 }, 2021887);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 130 }, 2021889);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 130 }, 2021891);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 140 }, 2021893);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 140 }, 2021895);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 140 }, 2021897);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 140 }, 2021899);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 140 }, 2021901);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 140 }, 2021903);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 140 }, 2021905);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 120 }, 2021907);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 120 }, 2021909);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 120 }, 2021911);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 120 }, 2021913);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 120 }, 2021915);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 120 }, 2021917);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 120 }, 2021919);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 100 }, 2021921);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 100 }, 2021923);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 100 }, 2021925);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 100 }, 2021927);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 100 }, 2021929);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 100 }, 2021931);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 100 }, 2021933);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 50 }, 2021935);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 50 }, 2021937);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 50 }, 2021939);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 50 }, 2021941);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 50 }, 2021943);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 50 }, 2021945);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 50, 9, 241, 9, 241, 9, 241, 9, 241, 9, 241, 9, 241, 9, 241, 9, 181, 9, 181, 9, 181, 9, 181, 9, 181, 9, 181, 9, 181 }, 2021947);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 131 }, 2021977);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 131 }, 2021979);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 131 }, 2021981);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 131 }, 2021983);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 131 }, 2021985);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 131 }, 2021987);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 131 }, 2021989);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 86 }, 2021991);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 86 }, 2021993);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 86 }, 2021995);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 86 }, 2021997);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 86 }, 2021999);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 86 }, 2022001);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 86 }, 2022003);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 6 }, 2022005);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 6 }, 2022007);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 6 }, 2022009);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 6 }, 2022011);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 6 }, 2022013);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 6 }, 2022015);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 6, 9, 196, 9, 196, 9, 196, 9, 196, 9, 196, 9, 196, 9, 196, 9, 196, 9, 196, 9, 196, 9, 196 }, 2022017);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 4, 52, 4, 109, 4, 219 }, 2022312);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 4, 168, 5, 30, 5, 163 }, 2022344);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 5, 114, 6, 7, 6, 193 }, 2022376);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 6, 84, 7, 27, 7, 128 }, 2022408);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 7, 68, 7, 157, 7, 245 }, 2022440);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 7, 189, 8, 29, 9, 1 }, 2022472);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 8, 57, 9, 21, 9, 131 }, 2022504);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 9, 26, 9, 136, 9, 246 }, 2022536);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 9, 146, 9, 176, 9, 176 }, 2022568);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 96, 9, 96, 9, 96 }, 2022601);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 21 }, 2022633);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 21, 9, 21 }, 2022635);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 8, 152, 8, 152, 8, 2 }, 2022664);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 97 }, 2022863);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 102 }, 2022865);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 136, 9, 206, 9, 216 }, 2022893);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 0 }, 2022925);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 50, 10, 50 }, 2022927);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 32 }, 2022957);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 85, 10, 90 }, 2022959);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 40 }, 2022989);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 105, 10, 130 }, 2022991);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 35 }, 2023021);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 120, 10, 120 }, 2023023);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 41 }, 2023053);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 110, 10, 100 }, 2023055);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 39 }, 2023085);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 70, 10, 70 }, 2023087);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 10 }, 2023117);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 10 }, 2023119);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 10 }, 2023121);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 9, 216, 9, 216, 9, 216 }, 2023148);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 146, 9, 146, 9, 146 }, 2023181);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 106 }, 2023213);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 106, 9, 106 }, 2023215);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 76 }, 2023245);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 76 }, 2023247);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 76 }, 2023249);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 14, 216, 11, 134, 5, 190 }, 2053358);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 18, 132, 15, 160, 9, 196, 6, 124, 0, 0 }, 2053388);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 22, 118, 18, 142, 14, 166, 10, 140, 7, 8, 0, 0, 0, 0 }, 2053418);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 26, 94, 23, 112, 19, 236, 17, 48, 14, 66, 10, 240, 5, 20, 0, 0, 0, 0 }, 2053448);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 30, 70 }, 2053478);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 88, 24, 6, 21, 24, 18, 242, 16, 54, 12, 28, 6, 64, 0, 0, 0, 0 }, 2053481);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 32, 208, 30, 120 }, 2053508);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 238, 25, 0, 23, 12, 21, 24, 18, 92, 12, 178, 6, 64, 0, 0, 0, 0 }, 2053513);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 34, 246, 32, 208, 30, 170, 28, 32, 26, 144, 25, 0, 23, 12, 18, 242, 11, 84, 5, 70, 0, 0, 0, 0 }, 2053538);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 36, 184, 35, 40, 32, 208, 30, 220, 29, 76, 27, 188, 26, 94, 22, 218, 17, 98, 10, 140, 5, 20, 0, 0, 0, 0, 0, 0, 0, 0 }, 2053568);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 36, 184, 34, 196, 32, 208, 31, 64, 29, 226, 28, 132, 25, 150, 21, 124, 15, 160, 9, 196, 3, 82, 0, 0, 0, 0, 0, 0 }, 2053600);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 35, 240, 34, 96, 32, 208, 31, 64, 30, 20, 27, 88, 24, 56, 19, 36, 12, 188, 6, 64, 0, 200, 0, 0, 0, 0 }, 2053632);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 36, 84, 34, 246, 33, 202, 32, 208, 29, 176, 27, 38, 23, 62, 16, 234, 10, 140, 2, 188, 0, 100, 0, 0 }, 2053664);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 36, 84, 35, 90, 34, 146, 31, 114, 29, 26, 25, 100, 19, 186, 14, 76, 5, 220, 1, 144, 0, 100 }, 2053696);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 34, 146, 31, 214, 28, 82, 24, 76, 20, 20, 12, 128, 7, 8, 1, 44 }, 2053732);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 36, 234, 34, 146, 31, 14, 27, 248, 23, 112, 17, 108, 12, 148, 5, 120 }, 2053762);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 33, 252, 30, 220, 26, 64, 21, 24 }, 2053796);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 42, 248, 46, 224, 50, 200 }, 2071128);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 42, 248, 46, 224, 50, 200 }, 2071160);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 42, 248, 46, 224, 50, 200 }, 2071192);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 42, 248, 46, 224, 50, 200 }, 2071224);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 42, 248, 46, 224, 50, 200 }, 2071256);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 42, 248, 46, 224, 50, 200 }, 2071288);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 42, 248, 46, 224, 50, 200 }, 2071320);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 42, 248, 46, 224, 50, 200 }, 2071352);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 12, 128, 15, 160, 18, 192 }, 2071442);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 80, 9, 227, 10, 171, 11, 115, 11, 215, 12, 159, 13, 103, 14, 47, 14, 247, 16, 135 }, 2071449);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 12, 128, 15, 160, 18, 192 }, 2071478);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 80, 9, 227, 10, 171, 11, 115, 11, 215, 12, 159, 13, 103, 14, 47, 14, 247 }, 2071485);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 38, 232, 40, 60, 41, 4 }, 2074732);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 27, 188, 29, 226, 32, 68, 35, 190, 38, 142, 40, 100, 42, 148, 44, 36 }, 2074754);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 29, 226, 32, 8, 34, 246, 38, 32, 40, 140, 42, 228, 45, 190, 46, 224 }, 2074786);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 33, 52, 35, 180, 38, 2, 41, 24, 43, 192, 46, 54, 47, 168, 50, 0 }, 2074818);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 34, 216, 37, 168, 40, 100, 42, 238, 44, 226, 47, 118, 49, 186, 50, 200, 53, 232 }, 2074848);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 40, 100, 42, 253, 45, 150, 48, 12, 49, 241, 51, 254, 54, 6, 55, 120, 58, 152 }, 2074880);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 43, 172, 45, 240, 48, 82, 50, 200, 53, 42, 55, 0, 56, 134, 58, 82, 59, 146, 62, 128 }, 2074910);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 46, 154, 49, 6, 51, 114, 53, 232, 55, 255, 57, 248, 60, 15, 62, 23, 64, 56, 66, 4 }, 2074942);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 49, 136, 52, 28, 54, 146, 57, 8, 58, 212, 60, 240, 63, 152, 65, 220, 69, 136, 69, 136 }, 2074974);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 51, 230, 55, 100, 57, 68, 59, 76, 61, 194, 63, 182, 67, 8, 70, 80, 70, 80, 70, 80 }, 2075006);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 51, 230, 55, 100, 57, 68, 59, 76, 61, 194, 63, 182, 67, 8, 70, 80, 70, 80, 70, 80 }, 2075038);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 41, 4, 41, 4, 41, 4 }, 2076270);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 39, 86, 43, 112, 43, 192, 43, 242, 43, 242, 43, 242, 43, 242, 43, 242 }, 2076292);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 41, 144, 45, 230, 46, 124, 46, 224, 46, 224, 46, 224, 46, 224, 46, 224 }, 2076324);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 42, 78, 48, 162, 49, 206, 49, 206, 49, 206, 49, 206, 49, 206, 49, 206 }, 2076356);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 37, 178, 42, 218, 47, 238, 49, 86, 50, 86, 52, 81, 53, 182, 53, 182, 53, 182 }, 2076386);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 36, 144, 42, 98, 48, 2, 50, 170, 52, 45, 57, 212, 58, 152, 58, 152, 58, 152 }, 2076418);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 32, 238, 36, 104, 42, 8, 48, 82, 51, 154, 54, 3, 60, 54, 62, 128, 62, 128, 62, 128 }, 2076448);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 33, 152, 36, 184, 42, 78, 48, 205, 52, 35, 55, 120, 62, 38, 66, 4, 66, 4, 66, 4 }, 2076480);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 34, 46, 37, 178, 43, 21, 49, 83, 52, 35, 57, 158, 65, 210, 69, 86, 69, 86, 69, 86 }, 2076512);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 35, 40, 39, 16, 44, 81, 50, 227, 53, 139, 63, 72, 70, 55, 70, 80, 70, 80, 70, 80 }, 2076544);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 36, 34, 40, 10, 45, 112, 52, 48, 55, 213, 70, 80, 70, 80, 70, 80, 70, 80, 70, 80 }, 2076576);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 46, 224, 46, 224, 46, 224, 46, 224, 70, 80, 70, 80, 70, 80, 70, 80, 70, 80, 70, 80, 70, 80, 70, 80, 70, 80, 70, 80, 70, 80, 70, 80, 70, 80, 70, 80, 70, 80, 70, 80, 23, 112, 23, 112, 23, 112, 23, 112 }, 2077026);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 26, 94, 22, 68, 21, 114 }, 2082578);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 25, 170, 21, 204, 20, 190, 18, 72 }, 2082600);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 12, 155 }, 2082610);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 24, 156, 20, 100, 19, 86, 17, 108, 14, 103, 11, 144, 8, 202, 7, 188 }, 2082622);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 23, 52, 18, 162, 17, 148, 16, 44, 13, 39, 10, 87, 7, 128, 6, 144 }, 2082644);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 21, 114, 16, 224, 15, 210, 14, 196, 11, 134, 8, 245, 6, 64, 5, 70 }, 2082666);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 19, 186, 15, 10, 14, 16, 13, 92, 9, 196, 7, 135, 4, 226, 3, 222 }, 2082688);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 199, 243, 252, 233, 123, 222, 142, 140, 66, 6, 21, 173, 184, 81, 210, 47, 57, 97, 255, 8, 60, 25, 81, 191, 21, 68, 12, 69, 201, 207, 114, 83, 148, 109, 118, 214, 140, 121, 204, 50, 194, 186, 139, 169, 46, 160, 132, 67, 222, 205, 171, 83, 28, 201, 217, 53, 226, 166, 97, 204, 162, 70, 128, 214, 30, 120, 182, 240, 118, 204, 108, 194, 140, 202, 254, 148, 198, 151, 56, 142, 74, 109, 134, 134, 234, 15, 146, 106, 146, 151, 29, 253, 3, 177, 58, 213, 97, 201, 56, 234, 187, 203, 167, 162, 231, 121, 155, 187, 84, 169, 15, 68, 71, 233, 0, 115, 72, 63, 8, 51, 21, 44, 93, 137, 219, 202, 140, 50, 117, 41, 211, 165, 206, 230, 252, 244 }, 2088824);
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
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 22, 108 },
         new byte[] { 23, 72 }, 1776216, 1776217, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 24, 216, 25, 100 },
             new byte[] { 26, 144, 27, 138 }, 1776222, 1776225, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 22, 108 },
             new byte[] { 23, 72 }, 1776248, 1776249, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 24, 216, 25, 100 },
             new byte[] { 26, 144, 27, 138 }, 1776254, 1776257, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 22, 108 },
             new byte[] { 23, 72 }, 1776280, 1776281, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 24, 216, 25, 100 },
             new byte[] { 26, 144, 27, 138 }, 1776286, 1776289, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 22, 108 },
             new byte[] { 23, 72 }, 1776312, 1776313, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 24, 216, 25, 100 },
             new byte[] { 26, 144, 27, 138 }, 1776318, 1776321, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 22, 108 },
             new byte[] { 23, 72 }, 1776344, 1776345, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 24, 216, 25, 100 },
             new byte[] { 26, 144, 27, 138 }, 1776350, 1776353, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 22, 108 },
             new byte[] { 23, 72 }, 1776376, 1776377, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 24, 216, 25, 100 },
             new byte[] { 26, 144, 27, 138 }, 1776382, 1776385, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 22, 58 },
             new byte[] { 23, 22 }, 1776408, 1776409, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 2, 23, 162, 24, 216, 25, 100 },
             new byte[] { 222, 24, 126, 26, 144, 27, 138 }, 1776411, 1776417, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 21, 124, 22, 68 },
             new byte[] { 22, 88, 23, 32 }, 1776440, 1776443, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 2, 24, 126, 25, 100 },
             new byte[] { 222, 26, 54, 27, 138 }, 1776445, 1776449, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 20, 230, 21, 124, 22, 118, 24, 16, 25, 100 },
             new byte[] { 21, 194, 22, 88, 23, 82, 25, 200, 29, 66 }, 1776472, 1776481, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 19, 36, 20, 120, 21, 54, 22, 88, 23, 142, 25, 100 },
             new byte[] { 20, 0, 21, 84, 22, 18, 23, 52, 25, 70, 29, 66 }, 1776502, 1776513, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 18, 102, 19, 246, 20, 210, 22, 38, 23, 62, 25, 100 },
             new byte[] { 19, 66, 20, 210, 21, 174, 23, 2, 24, 246, 29, 66 }, 1776534, 1776545, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 17, 48, 18, 172, 19, 216 },
             new byte[] { 18, 12, 19, 136, 20, 180 }, 1776566, 1776571, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 24, 22, 98, 24, 176 },
             new byte[] { 244, 24, 26, 28, 142 }, 1776573, 1776577, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 12, 198, 15, 160, 17, 108, 18, 202 },
             new byte[] { 13, 162, 16, 124, 18, 72, 19, 166 }, 1776596, 1776603, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 0, 21, 124, 23, 72 },
             new byte[] { 220, 23, 52, 27, 38 }, 1776605, 1776609, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 11, 234, 14, 176, 16, 104 },
             new byte[] { 12, 198, 15, 140, 17, 68 }, 1776628, 1776633, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 12, 19, 46, 20, 150, 22, 78 },
             new byte[] { 232, 20, 10, 22, 78, 26, 44 }, 1776635, 1776641, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 10, 210, 13, 92 },
             new byte[] { 11, 174, 14, 56 }, 1776660, 1776663, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 10, 16, 214, 17, 218, 19, 36, 20, 160 },
             new byte[] { 230, 17, 178, 18, 182, 20, 220, 24, 126 }, 1776665, 1776673, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 9, 166, 11, 184, 13, 162 },
             new byte[] { 10, 130, 12, 148, 14, 126 }, 1776692, 1776697, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 4, 16, 244, 18, 32, 19, 136 },
             new byte[] { 224, 17, 208, 19, 216, 23, 102 }, 1776699, 1776705, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 28, 122, 30, 240, 34, 106 },
             new byte[] { 30, 56, 32, 173, 36, 39 }, 1793122, 1793127, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 30, 140, 32, 78, 35, 140 },
             new byte[] { 32, 73, 34, 11, 37, 72 }, 1793154, 1793159, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 31, 124, 33, 132, 36, 124 },
             new byte[] { 33, 57, 35, 65, 38, 56 }, 1793186, 1793191, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 32, 108, 34, 66, 37, 118 },
             new byte[] { 34, 41, 35, 255, 39, 50 }, 1793218, 1793223, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 33, 62, 35, 230, 38, 62 },
             new byte[] { 34, 251, 37, 162, 39, 250 }, 1793250, 1793255, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 33, 232, 36, 164, 38, 132 },
             new byte[] { 35, 165, 38, 96, 40, 64 }, 1793282, 1793287, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 35, 70, 37, 228, 39, 206 },
             new byte[] { 37, 2, 39, 160, 41, 138 }, 1793314, 1793319, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 38, 197 },
             new byte[] { 40, 129 }, 1793346, 1793347, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 29, 46, 32, 228, 38, 172 },
             new byte[] { 30, 247, 34, 189, 40, 160 }, 1793702, 1793707, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 30, 140, 34, 106, 40, 60 },
             new byte[] { 32, 73, 36, 68, 42, 51 }, 1793734, 1793739, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 31, 54, 36, 4, 41, 104 },
             new byte[] { 32, 239, 37, 226, 43, 96 }, 1793766, 1793771, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 32, 58, 37, 28, 42, 148 },
             new byte[] { 33, 244, 38, 254, 44, 141 }, 1793798, 1793803, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 33, 82, 38, 82, 42, 248 },
             new byte[] { 35, 16, 40, 44, 44, 235 }, 1793830, 1793835, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 34, 66, 39, 136, 43, 92 },
             new byte[] { 36, 3, 41, 103, 45, 80 }, 1793862, 1793867, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 36, 74, 40, 90, 43, 92 },
             new byte[] { 38, 19, 42, 51, 45, 64 }, 1793894, 1793899, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 38, 197 },
             new byte[] { 40, 129 }, 1793926, 1793927, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 26, 224, 28, 162, 31, 114 },
             new byte[] { 28, 133, 30, 62, 33, 8 }, 1794282, 1794287, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 27, 58, 29, 46, 31, 214 },
             new byte[] { 28, 199, 30, 192, 33, 100 }, 1794314, 1794319, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 27, 88, 29, 146, 32, 108 },
             new byte[] { 28, 218, 31, 26, 33, 247 }, 1794346, 1794351, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 27, 228, 29, 236, 32, 228 },
             new byte[] { 29, 99, 31, 112, 34, 106 }, 1794378, 1794383, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 28, 162, 30, 120, 33, 132 },
             new byte[] { 30, 33, 31, 241, 35, 9 }, 1794410, 1794415, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 29, 46, 31, 144, 34, 76 },
             new byte[] { 30, 173, 33, 15, 35, 215 }, 1794442, 1794447, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 30, 220, 32, 228, 35, 160 },
             new byte[] { 32, 97, 34, 101, 37, 45 }, 1794474, 1794479, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 33, 152 },
             new byte[] { 35, 25 }, 1794506, 1794507, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 26, 165, 28, 142, 30, 120 },
             new byte[] { 28, 70, 30, 41, 32, 2 }, 1794862, 1794867, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 27, 38, 29, 166, 31, 84 },
             new byte[] { 28, 178, 31, 62, 32, 220 }, 1794894, 1794899, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 28, 162, 30, 30, 32, 88 },
             new byte[] { 30, 55, 31, 174, 33, 226 }, 1794926, 1794931, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 29, 76, 31, 74, 33, 32 },
             new byte[] { 30, 222, 32, 224, 34, 169 }, 1794958, 1794963, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 30, 30, 31, 224, 34, 66 },
             new byte[] { 31, 177, 33, 106, 35, 208 }, 1794990, 1794995, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 30, 240, 32, 198, 34, 206 },
             new byte[] { 32, 134, 34, 83, 36, 95 }, 1795022, 1795027, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 32, 38, 34, 36, 35, 240 },
             new byte[] { 33, 187, 35, 180, 37, 129 }, 1795054, 1795059, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 34, 106 },
             new byte[] { 35, 244 }, 1795086, 1795087, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 26, 144, 29, 236, 34, 116 },
             new byte[] { 28, 48, 31, 154, 36, 49 }, 1795442, 1795447, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 29, 66, 32, 58, 36, 194 },
             new byte[] { 30, 236, 33, 246, 38, 142 }, 1795474, 1795479, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 30, 70, 34, 16, 38, 52 },
             new byte[] { 31, 242, 35, 212, 40, 5 }, 1795506, 1795511, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 30, 140, 35, 160, 38, 172 },
             new byte[] { 32, 47, 37, 110, 40, 119 }, 1795538, 1795543, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 31, 4, 36, 124, 38, 172 },
             new byte[] { 32, 163, 38, 64, 40, 109 }, 1795570, 1795575, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 30, 240, 36, 54, 38, 132 },
             new byte[] { 32, 134, 37, 237, 40, 64 }, 1795602, 1795607, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 32, 38, 35, 240, 38, 102 },
             new byte[] { 33, 187, 37, 149, 40, 18 }, 1795634, 1795639, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 34, 106 },
             new byte[] { 35, 244 }, 1795666, 1795667, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 27, 109, 29, 186, 33, 6 },
             new byte[] { 29, 26, 31, 102, 34, 177 }, 1796022, 1796027, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 27, 64, 29, 241, 33, 110 },
             new byte[] { 28, 205, 31, 141, 35, 16 }, 1796054, 1796059, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 27, 151, 30, 42, 33, 214 },
             new byte[] { 29, 29, 31, 186, 35, 114 }, 1796086, 1796091, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 28, 52, 31, 24, 34, 62 },
             new byte[] { 29, 183, 32, 171, 35, 212 }, 1796118, 1796123, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 28, 46, 31, 58, 34, 176 },
             new byte[] { 29, 167, 32, 188, 36, 67 }, 1796150, 1796155, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 30, 160, 33, 72, 36, 114 },
             new byte[] { 32, 50, 34, 219, 38, 22 }, 1796182, 1796187, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 32, 238, 36, 184, 39, 46 },
             new byte[] { 34, 141, 38, 102, 40, 227 }, 1796214, 1796219, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 35, 50 },
             new byte[] { 36, 197 }, 1796246, 1796247, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 41, 54, 43, 158, 46, 146 },
             new byte[] { 43, 187, 46, 18, 48, 236 }, 1796602, 1796607, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 43, 132, 47, 52, 49, 197 },
             new byte[] { 45, 254, 49, 190, 52, 51 }, 1796634, 1796639, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 44, 46, 49, 13, 51, 239 },
             new byte[] { 46, 159, 51, 152, 54, 104 }, 1796666, 1796671, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 44, 206, 50, 228, 53, 172 },
             new byte[] { 47, 53, 53, 121, 56, 41 }, 1796698, 1796703, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 45, 150, 51, 161, 54, 135 },
             new byte[] { 47, 248, 54, 32, 57, 0 }, 1796730, 1796735, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 49, 240, 52, 244, 55, 123 },
             new byte[] { 52, 127, 55, 118, 57, 251 }, 1796762, 1796767, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 49, 240, 53, 28, 56, 97 },
             new byte[] { 52, 101, 55, 139, 58, 214 }, 1796794, 1796799, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 50, 47 },
             new byte[] { 52, 110 }, 1796826, 1796827, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 1 },
             new byte[] { 0 }, 1807302, 1807302, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 6, 64, 6, 64, 6, 64, 6, 64, 6, 64, 6, 64, 6, 64, 6, 64, 6, 64, 6, 64, 6, 64, 6, 64, 6, 64, 6, 64, 6, 64, 6, 64, 6, 64, 6, 64, 6, 64, 6, 64, 6, 64, 6, 64, 6, 64, 6, 64, 6, 164, 6, 164, 6, 164, 6, 164, 6, 164, 6, 164, 6, 164, 6, 164, 6, 164, 6, 164, 6, 164, 6, 164, 6, 164, 6, 164, 6, 164, 6, 164, 6, 164, 6, 164, 6, 164, 6, 164, 6, 164, 6, 164, 6, 164, 6, 164, 6, 164, 6, 164, 6, 164, 6, 164, 6, 164, 6, 164, 6, 164, 6, 164, 6, 164, 6, 164, 6, 164, 6, 164, 6, 164, 6, 164, 6, 164, 6, 164, 6, 164, 6, 164, 6, 164, 6, 164, 6, 164, 6, 164, 6, 164, 6, 164, 6, 164, 6, 164, 6, 164, 6, 164, 6, 164, 6, 164, 6, 164, 6, 164, 6, 164, 6, 164, 6, 164, 6, 164, 6, 164, 6, 164, 6, 164, 6, 164, 6, 164, 6, 164, 6, 164, 6, 164, 6, 164, 6, 164, 6, 164, 6, 164, 6, 164, 6, 164, 6, 164, 6, 164, 6, 164, 6, 164, 6, 164, 6, 164 },
             new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, 1807612, 1807819, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 7, 8, 7, 8, 7, 8, 6, 164, 5, 220, 4, 176, 5, 20, 4, 226, 7, 208, 7, 208, 7, 208, 8, 52, 7, 8, 7, 8, 8, 152, 5, 220, 9, 96, 9, 96, 9, 96, 10, 140, 9, 196, 13, 72, 13, 172, 13, 72, 9, 96, 9, 96, 9, 96, 11, 84, 12, 28, 12, 228, 13, 172, 13, 172, 7, 208, 7, 208, 7, 208, 10, 140, 11, 184, 12, 28, 11, 184, 14, 16 },
             new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, 1807952, 1808031, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 5, 220, 8, 252, 9, 196, 3, 232, 14, 16 },
             new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, 1808038, 1808047, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 10, 240, 10, 240, 11, 184, 6, 214, 5, 220, 6, 214, 5, 220, 3, 232, 6, 164, 6, 164, 11, 184, 6, 214, 5, 220, 6, 214, 5, 220, 3, 232, 6, 164, 6, 164, 10, 190, 8, 202, 5, 220, 6, 214, 5, 220, 3, 232, 6, 164, 6, 164, 10, 190, 10, 190, 11, 184, 14, 166, 17, 148, 15, 160, 6, 164, 6, 164, 10, 190, 10, 190, 11, 184, 14, 166, 17, 148, 15, 160, 6, 164, 6, 164, 10, 190, 10, 190, 11, 184, 12, 178, 17, 148, 15, 160, 6, 164, 6, 164, 6, 164, 10, 190, 11, 184, 10, 190, 10, 190, 17, 148, 5, 220, 5, 220, 5, 220, 9, 196, 9, 196, 9, 196, 9, 196, 17, 148, 5, 220, 5, 220, 5, 220, 7, 208, 7, 208, 7, 208, 7, 208, 15, 160, 3, 232, 3, 232, 3, 232 },
             new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, 1808280, 1808429, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 40, 0, 100 },
             new byte[] { 0, 255, 255 }, 1808767, 1808769, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 0, 100, 255, 255 },
             new byte[] { 255, 255, 0, 0 }, 1808772, 1808775, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 37, 28 },
             new byte[] { 39, 66 }, 1822646, 1822647, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 37, 28 },
             new byte[] { 39, 66 }, 1822670, 1822671, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 37, 28 },
             new byte[] { 39, 66 }, 1822694, 1822695, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 23, 112, 25, 50 },
             new byte[] { 24, 76, 26, 14 }, 1822712, 1822715, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 37, 28 },
             new byte[] { 39, 66 }, 1822718, 1822719, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 22, 108, 23, 202, 26, 224, 37, 28 },
             new byte[] { 23, 72, 25, 130, 27, 188, 39, 66 }, 1822736, 1822743, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 21, 124, 23, 2, 25, 170, 37, 28 },
             new byte[] { 22, 88, 24, 186, 26, 134, 39, 66 }, 1822760, 1822767, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 24, 22, 88 },
             new byte[] { 244, 24, 16 }, 1822785, 1822787, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 0, 37, 28 },
             new byte[] { 220, 39, 66 }, 1822789, 1822791, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 20, 180, 21, 224, 24, 116, 37, 28 },
             new byte[] { 21, 144, 23, 152, 25, 80, 39, 66 }, 1822808, 1822815, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 11, 34 },
             new byte[] { 10, 0 }, 1825500, 1825501, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 134, 12, 30 },
             new byte[] { 151, 11, 219 }, 1825505, 1825507, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 13, 222 },
             new byte[] { 10, 40 }, 1825512, 1825513, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 160, 16, 199, 16, 199 },
             new byte[] { 158, 17, 15, 17, 163 }, 1825517, 1825521, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 8, 16, 4, 17, 198 },
             new byte[] { 228, 11, 114, 16, 234 }, 1825523, 1825527, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 142 },
             new byte[] { 5 }, 1825529, 1825529, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 161, 20, 155, 21, 14, 16, 254, 19, 36, 19, 236 },
             new byte[] { 253, 21, 24, 23, 52, 11, 114, 16, 234, 18, 122 }, 1825531, 1825541, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 206, 21, 200, 23, 42, 17, 48 },
             new byte[] { 230, 24, 156, 28, 82, 14, 246 }, 1825543, 1825549, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 186 },
             new byte[] { 66 }, 1825551, 1825551, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 130 },
             new byte[] { 43 }, 1825553, 1825553, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 48, 21, 234, 23, 56, 17, 58 },
             new byte[] { 241, 25, 0, 28, 96, 14, 246 }, 1825555, 1825561, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 186 },
             new byte[] { 66 }, 1825563, 1825563, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 130 },
             new byte[] { 43 }, 1825565, 1825565, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 21, 21, 201, 23, 99, 16, 244, 19, 96, 20, 30, 20, 183, 21, 107, 23, 25, 15, 0 },
             new byte[] { 241, 25, 0, 28, 139, 13, 202, 18, 222, 19, 233, 21, 207, 25, 220, 28, 65, 12, 158 }, 1825567, 1825585, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 92 },
             new byte[] { 22 }, 1825587, 1825587, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 86, 19, 239, 20, 173, 21, 214, 13, 22, 16, 204, 17, 198, 18, 242, 19, 236, 21, 114, 10, 140, 14, 16, 15, 10, 16, 31, 17, 25, 19, 56, 8, 252, 11, 184, 12, 178, 13, 149, 14, 143, 17, 18 },
             new byte[] { 97, 21, 136, 25, 213, 26, 254, 12, 158, 17, 178, 18, 222, 20, 230, 25, 20, 26, 154, 11, 14, 15, 90, 16, 93, 18, 60, 22, 65, 24, 96, 9, 26, 13, 2, 13, 244, 15, 195, 19, 183, 22, 58 }, 1825589, 1825631, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16, 51, 16, 199 },
             new byte[] { 17, 15, 17, 163 }, 1825702, 1825705, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 8, 10, 40, 15, 160, 16, 187, 17, 215, 18, 242, 21, 14, 10, 40, 15, 160, 17, 48, 18, 192, 20, 80, 23, 42, 13, 172, 17, 248, 18, 225, 19, 203, 20, 180, 23, 56, 13, 172, 17, 248, 18, 225, 19, 203, 20, 180, 23, 99, 12, 128, 17, 148, 18, 159, 19, 169, 20, 180, 23, 25, 11, 84, 16, 204, 18, 23, 19, 98, 20, 173, 21, 214, 11, 84, 16, 104, 17, 148, 18, 192, 19, 236, 21, 114, 9, 196, 14, 16, 15, 19, 16, 22, 17, 25, 19, 56, 7, 208, 11, 184, 12, 170, 13, 157, 14, 143, 17, 18 },
             new byte[] { 228, 11, 114, 16, 234, 18, 5, 19, 253, 21, 24, 23, 52, 11, 114, 16, 234, 18, 122, 20, 230, 24, 156, 28, 82, 14, 246, 19, 66, 20, 43, 21, 241, 25, 0, 28, 96, 14, 246, 19, 66, 20, 43, 21, 241, 25, 0, 28, 139, 13, 202, 18, 222, 19, 233, 21, 207, 25, 220, 28, 65, 12, 158, 18, 22, 19, 97, 21, 136, 25, 213, 26, 254, 12, 158, 17, 178, 18, 222, 20, 230, 25, 20, 26, 154, 11, 14, 15, 90, 16, 93, 18, 60, 22, 65, 24, 96, 9, 26, 13, 2, 13, 244, 15, 195, 19, 183, 22, 58 }, 1825707, 1825815, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 132 },
             new byte[] { 0 }, 1835071, 1835071, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 18, 17, 19, 73 },
             new byte[] { 0, 0, 0, 0 }, 1835218, 1835221, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 151 },
             new byte[] { 0 }, 1835229, 1835229, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 246 },
             new byte[] { 0 }, 1835233, 1835233, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 245 },
             new byte[] { 0 }, 1835237, 1835237, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 21, 17 },
             new byte[] { 0, 0 }, 1835242, 1835243, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 25, 73, 18, 17, 242 },
             new byte[] { 0, 0, 0, 0, 0 }, 1835248, 1835252, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 18, 17, 19 },
             new byte[] { 0, 0, 0 }, 1835254, 1835256, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 56, 56, 56, 56, 18, 17, 19, 73, 55, 54 },
             new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, 1835258, 1835267, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 49 },
             new byte[] { 0 }, 1835269, 1835269, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 115 },
             new byte[] { 0 }, 1835273, 1835273, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 114 },
             new byte[] { 0 }, 1835277, 1835277, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 21 },
             new byte[] { 0 }, 1836687, 1836687, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 10, 10, 10, 10 },
             new byte[] { 0, 0, 0, 0 }, 1836834, 1836837, "Found egr map...Delete map");
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
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16, 16, 16, 16, 17, 17 },
             new byte[] { 0, 0, 0, 0, 0, 0 }, 1836878, 1836883, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 17 },
             new byte[] { 0 }, 1836885, 1836885, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 10 },
             new byte[] { 0 }, 1836889, 1836889, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 21 },
             new byte[] { 0 }, 1836893, 1836893, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 0, 0 },
             new byte[] { 255, 255 }, 1859344, 1859345, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 10, 0, 20 },
             new byte[] { 0, 255, 255 }, 1859347, 1859349, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 30, 0, 40 },
             new byte[] { 0, 255, 255 }, 1859351, 1859353, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 50, 0, 60 },
             new byte[] { 0, 255, 255 }, 1859355, 1859357, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 70 },
             new byte[] { 0 }, 1859359, 1859359, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 0, 100 },
             new byte[] { 255, 255 }, 1859378, 1859379, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 50, 0, 40 },
             new byte[] { 0, 255, 255 }, 1859381, 1859383, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 50, 0, 40 },
             new byte[] { 0, 255, 255 }, 1859385, 1859387, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 50, 0, 40 },
             new byte[] { 0, 255, 255 }, 1859389, 1859391, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 50 },
             new byte[] { 0 }, 1859393, 1859393, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 0, 50 },
             new byte[] { 255, 255 }, 1859410, 1859411, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 50, 0, 50 },
             new byte[] { 0, 255, 255 }, 1859413, 1859415, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 200, 0, 50 },
             new byte[] { 0, 255, 255 }, 1859417, 1859419, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 20, 0, 50 },
             new byte[] { 0, 255, 255 }, 1859421, 1859423, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 20, 0, 50 },
             new byte[] { 0, 255, 255 }, 1859425, 1859427, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 20, 0, 50 },
             new byte[] { 0, 255, 255 }, 1859429, 1859431, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 20, 0, 50 },
             new byte[] { 0, 255, 255 }, 1859433, 1859435, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 50, 0, 50 },
             new byte[] { 0, 255, 255 }, 1859437, 1859439, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 200 },
             new byte[] { 0 }, 1859441, 1859441, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 0, 0 },
             new byte[] { 255, 255 }, 1859446, 1859447, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 10 },
             new byte[] { 0 }, 1859449, 1859449, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 110, 3, 151 },
             new byte[] { 0, 127, 255 }, 1859481, 1859483, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 0, 82 },
             new byte[] { 255, 255 }, 1859498, 1859499, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 0, 40 },
             new byte[] { 255, 255 }, 1859506, 1859507, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 40, 0, 40 },
             new byte[] { 0, 255, 255 }, 1859509, 1859511, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 40 },
             new byte[] { 0 }, 1859513, 1859513, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 51, 0, 150 },
             new byte[] { 0, 255, 255 }, 1859619, 1859621, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 40, 0, 150 },
             new byte[] { 0, 255, 255 }, 1859623, 1859625, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 40, 0, 150 },
             new byte[] { 0, 255, 255 }, 1859627, 1859629, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 40, 0, 150, 1 },
             new byte[] { 0, 255, 255, 0 }, 1859631, 1859634, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 0, 1 },
             new byte[] { 255, 255 }, 1859636, 1859637, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 100, 0, 2 },
             new byte[] { 0, 255, 255 }, 1859639, 1859641, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 2, 168 },
             new byte[] { 255, 255 }, 1859644, 1859645, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 50 },
             new byte[] { 0 }, 1859647, 1859647, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 0, 60 },
             new byte[] { 255, 255 }, 1859808, 1859809, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 150, 0, 60 },
             new byte[] { 0, 255, 255 }, 1859811, 1859813, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 150, 1, 244 },
             new byte[] { 0, 255, 255 }, 1859815, 1859817, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 150, 1, 244 },
             new byte[] { 0, 255, 255 }, 1859819, 1859821, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 150 },
             new byte[] { 0 }, 1859823, 1859823, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 252, 205, 252, 205, 249, 154, 192 },
             new byte[] { 0, 0, 0, 0, 0, 0, 0 }, 1859868, 1859874, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 192 },
             new byte[] { 0 }, 1859876, 1859876, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 192 },
             new byte[] { 0 }, 1859878, 1859878, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 192 },
             new byte[] { 0 }, 1859880, 1859880, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 192 },
             new byte[] { 0 }, 1859882, 1859882, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 192 },
             new byte[] { 0 }, 1859884, 1859884, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 192 },
             new byte[] { 0 }, 1859886, 1859886, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 192 },
             new byte[] { 0 }, 1859888, 1859888, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 192 },
             new byte[] { 0 }, 1859890, 1859890, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 192 },
             new byte[] { 0 }, 1859892, 1859892, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 192 },
             new byte[] { 0 }, 1859894, 1859894, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 192 },
             new byte[] { 0 }, 1859896, 1859896, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 192 },
             new byte[] { 0 }, 1859898, 1859898, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16, 74, 13, 2, 13, 2, 13, 2, 13, 2, 13, 2, 13, 2, 13, 2, 13, 2, 13, 2, 13, 2, 12, 98, 11, 184, 11, 14, 10, 110, 9, 196, 9, 26, 8, 122, 7, 208, 7, 38, 6, 134, 5, 50, 3, 62, 0, 170 },
             new byte[] { 31, 64, 31, 64, 31, 64, 31, 64, 31, 64, 31, 64, 31, 64, 31, 64, 31, 64, 31, 64, 31, 64, 31, 64, 31, 64, 31, 64, 31, 64, 31, 64, 31, 64, 31, 64, 31, 64, 31, 64, 31, 64, 31, 64, 31, 64, 31, 64 }, 1879434, 1879481, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 89 },
             new byte[] { 199 }, 1879587, 1879587, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 101, 23, 74, 23, 89, 23, 129, 23, 158, 23, 58, 22, 201, 21, 241, 21, 115, 20, 101, 19, 33, 18, 22, 17, 21, 15, 242, 3, 252 },
             new byte[] { 211, 28, 114, 28, 129, 28, 169, 28, 198, 29, 172, 29, 59, 28, 99, 27, 229, 26, 215, 25, 147, 24, 136, 23, 135, 22, 100, 9, 36 }, 1879589, 1879617, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 0 },
             new byte[] { 110 }, 1879619, 1879619, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 4, 26 },
             new byte[] { 3, 216 }, 1887568, 1887569, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 217, 4, 26 },
             new byte[] { 157, 3, 216 }, 1887571, 1887573, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 125 },
             new byte[] { 53 }, 1887575, 1887575, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 162 },
             new byte[] { 90 }, 1887577, 1887577, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 162 },
             new byte[] { 90 }, 1887579, 1887579, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 162 },
             new byte[] { 90 }, 1887581, 1887581, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 155 },
             new byte[] { 83 }, 1887583, 1887583, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 141 },
             new byte[] { 69 }, 1887585, 1887585, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 113 },
             new byte[] { 41 }, 1887587, 1887587, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 106 },
             new byte[] { 28 }, 1887589, 1887589, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 106 },
             new byte[] { 28 }, 1887591, 1887591, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 96 },
             new byte[] { 30 }, 1887593, 1887593, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 86 },
             new byte[] { 20 }, 1887595, 1887595, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 76 },
             new byte[] { 4 }, 1887597, 1887597, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 76, 4, 41 },
             new byte[] { 4, 3, 225 }, 1887599, 1887601, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 217, 4, 26 },
             new byte[] { 157, 3, 216 }, 1887603, 1887605, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 152 },
             new byte[] { 80 }, 1887607, 1887607, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 152 },
             new byte[] { 80 }, 1887609, 1887609, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 152 },
             new byte[] { 80 }, 1887611, 1887611, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 152 },
             new byte[] { 80 }, 1887613, 1887613, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 152 },
             new byte[] { 80 }, 1887615, 1887615, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 141 },
             new byte[] { 69 }, 1887617, 1887617, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 113 },
             new byte[] { 41 }, 1887619, 1887619, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 106 },
             new byte[] { 28 }, 1887621, 1887621, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 106 },
             new byte[] { 28 }, 1887623, 1887623, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 86 },
             new byte[] { 14 }, 1887625, 1887625, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 86 },
             new byte[] { 8 }, 1887627, 1887627, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 143 },
             new byte[] { 65 }, 1887629, 1887629, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 142 },
             new byte[] { 64 }, 1887631, 1887631, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 134 },
             new byte[] { 56 }, 1887633, 1887633, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 217, 4, 26 },
             new byte[] { 157, 3, 216 }, 1887635, 1887637, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 146 },
             new byte[] { 74 }, 1887639, 1887639, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 146 },
             new byte[] { 74 }, 1887641, 1887641, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 146 },
             new byte[] { 74 }, 1887643, 1887643, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 146 },
             new byte[] { 74 }, 1887645, 1887645, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 146 },
             new byte[] { 74 }, 1887647, 1887647, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 146 },
             new byte[] { 74 }, 1887649, 1887649, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 136 },
             new byte[] { 64 }, 1887651, 1887651, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 106 },
             new byte[] { 28 }, 1887653, 1887653, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 106 },
             new byte[] { 28 }, 1887655, 1887655, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 96 },
             new byte[] { 24 }, 1887657, 1887657, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 96 },
             new byte[] { 18 }, 1887659, 1887659, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 143 },
             new byte[] { 65 }, 1887661, 1887661, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 142 },
             new byte[] { 64 }, 1887663, 1887663, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 148 },
             new byte[] { 70 }, 1887665, 1887665, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 217, 4, 26 },
             new byte[] { 157, 3, 216 }, 1887667, 1887669, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 146 },
             new byte[] { 74 }, 1887671, 1887671, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 146 },
             new byte[] { 74 }, 1887673, 1887673, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 146 },
             new byte[] { 74 }, 1887675, 1887675, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 146 },
             new byte[] { 74 }, 1887677, 1887677, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 146 },
             new byte[] { 74 }, 1887679, 1887679, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 146 },
             new byte[] { 74 }, 1887681, 1887681, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 136 },
             new byte[] { 64 }, 1887683, 1887683, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 106 },
             new byte[] { 28 }, 1887685, 1887685, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 96 },
             new byte[] { 18 }, 1887687, 1887687, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 86, 4, 71 },
             new byte[] { 8, 3, 249 }, 1887689, 1887691, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 161 },
             new byte[] { 83 }, 1887693, 1887693, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 175 },
             new byte[] { 91 }, 1887695, 1887695, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 171 },
             new byte[] { 87 }, 1887697, 1887697, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 217, 4, 26 },
             new byte[] { 157, 3, 216 }, 1887699, 1887701, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 146 },
             new byte[] { 74 }, 1887703, 1887703, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 146 },
             new byte[] { 74 }, 1887705, 1887705, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 146 },
             new byte[] { 74 }, 1887707, 1887707, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 146 },
             new byte[] { 74 }, 1887709, 1887709, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 146 },
             new byte[] { 74 }, 1887711, 1887711, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 146 },
             new byte[] { 74 }, 1887713, 1887713, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 136 },
             new byte[] { 64 }, 1887715, 1887715, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 106 },
             new byte[] { 28 }, 1887717, 1887717, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 86, 4, 76 },
             new byte[] { 8, 3, 254 }, 1887719, 1887721, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 145 },
             new byte[] { 67 }, 1887723, 1887723, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 161 },
             new byte[] { 83 }, 1887725, 1887725, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 174 },
             new byte[] { 90 }, 1887727, 1887727, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 168 },
             new byte[] { 84 }, 1887729, 1887729, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 217 },
             new byte[] { 157 }, 1887731, 1887731, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 109 },
             new byte[] { 37 }, 1887733, 1887733, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 196 },
             new byte[] { 118 }, 1887735, 1887735, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 196 },
             new byte[] { 118 }, 1887737, 1887737, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 196 },
             new byte[] { 118 }, 1887739, 1887739, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 196 },
             new byte[] { 118 }, 1887741, 1887741, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 196 },
             new byte[] { 118 }, 1887743, 1887743, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 196 },
             new byte[] { 118 }, 1887745, 1887745, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 136 },
             new byte[] { 64 }, 1887747, 1887747, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 106 },
             new byte[] { 28 }, 1887749, 1887749, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 106 },
             new byte[] { 28 }, 1887751, 1887751, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 125 },
             new byte[] { 47 }, 1887753, 1887753, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 145 },
             new byte[] { 67 }, 1887755, 1887755, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 125 },
             new byte[] { 47 }, 1887757, 1887757, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 140 },
             new byte[] { 62 }, 1887759, 1887759, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 127 },
             new byte[] { 49 }, 1887761, 1887761, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 182, 3, 212, 3, 212, 3, 212, 3, 212, 3, 212, 3, 212, 3, 212, 3, 212, 3, 212, 3, 212, 3, 212 },
             new byte[] { 233, 4, 8, 4, 31, 4, 31, 4, 31, 4, 31, 4, 31, 4, 31, 4, 31, 4, 31, 4, 31, 4, 31 }, 1887869, 1887891, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 3, 232, 3, 232, 3, 232, 3, 232, 3, 232, 3, 232, 3, 212, 3, 212, 3, 212, 3, 212, 3, 212 },
             new byte[] { 4, 30, 4, 52, 4, 52, 4, 52, 4, 52, 4, 52, 4, 31, 4, 31, 4, 31, 4, 31, 4, 31 }, 1887902, 1887923, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 140 },
             new byte[] { 156 }, 1887931, 1887931, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16, 3, 232 },
             new byte[] { 66, 4, 7 }, 1887947, 1887949, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 212 },
             new byte[] { 242 }, 1887951, 1887951, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 212 },
             new byte[] { 242 }, 1887953, 1887953, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 212 },
             new byte[] { 242 }, 1887955, 1887955, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 176 },
             new byte[] { 187 }, 1887963, 1887963, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 206 },
             new byte[] { 215 }, 1887965, 1887965, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 126 },
             new byte[] { 147 }, 1887975, 1887975, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 106 },
             new byte[] { 127 }, 1887977, 1887977, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 86 },
             new byte[] { 174 }, 1887979, 1887979, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 66 },
             new byte[] { 153 }, 1887981, 1887981, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 36 },
             new byte[] { 120 }, 1887983, 1887983, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 36 },
             new byte[] { 120 }, 1887985, 1887985, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 36 },
             new byte[] { 120 }, 1887987, 1887987, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 175 },
             new byte[] { 185 }, 1888003, 1888003, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 151 },
             new byte[] { 161 }, 1888005, 1888005, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 123 },
             new byte[] { 133 }, 1888007, 1888007, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 116 },
             new byte[] { 126 }, 1888009, 1888009, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 96 },
             new byte[] { 119 }, 1888011, 1888011, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 86 },
             new byte[] { 159 }, 1888013, 1888013, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 66 },
             new byte[] { 163 }, 1888015, 1888015, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 56 },
             new byte[] { 113 }, 1888017, 1888017, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 56 },
             new byte[] { 130 }, 1888019, 1888019, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 185 },
             new byte[] { 195 }, 1888035, 1888035, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 161 },
             new byte[] { 181 }, 1888037, 1888037, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 123 },
             new byte[] { 143 }, 1888039, 1888039, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 116 },
             new byte[] { 136 }, 1888041, 1888041, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 106 },
             new byte[] { 129 }, 1888043, 1888043, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 96 },
             new byte[] { 38 }, 1888045, 1888045, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 66 },
             new byte[] { 46 }, 1888047, 1888047, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 56 },
             new byte[] { 82 }, 1888049, 1888049, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 56 },
             new byte[] { 102 }, 1888051, 1888051, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 185 },
             new byte[] { 195 }, 1888067, 1888067, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 161 },
             new byte[] { 181 }, 1888069, 1888069, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 123 },
             new byte[] { 153 }, 1888071, 1888071, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 116 },
             new byte[] { 136 }, 1888073, 1888073, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 106 },
             new byte[] { 139 }, 1888075, 1888075, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 96 },
             new byte[] { 48 }, 1888077, 1888077, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 66 },
             new byte[] { 46 }, 1888079, 1888079, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 56 },
             new byte[] { 82 }, 1888081, 1888081, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 56 },
             new byte[] { 102 }, 1888083, 1888083, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 175 },
             new byte[] { 185 }, 1888099, 1888099, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 151 },
             new byte[] { 171 }, 1888101, 1888101, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 123 },
             new byte[] { 143 }, 1888103, 1888103, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 106 },
             new byte[] { 126 }, 1888105, 1888105, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 106 },
             new byte[] { 150 }, 1888107, 1888107, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 86 },
             new byte[] { 148 }, 1888109, 1888109, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 56 },
             new byte[] { 111 }, 1888111, 1888111, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 56 },
             new byte[] { 86 }, 1888113, 1888113, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 56 },
             new byte[] { 102 }, 1888115, 1888115, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 166 },
             new byte[] { 176 }, 1888131, 1888131, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 141 },
             new byte[] { 151 }, 1888133, 1888133, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 113 },
             new byte[] { 122 }, 1888135, 1888135, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 106 },
             new byte[] { 14 }, 1888137, 1888137, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 106 },
             new byte[] { 43 }, 1888139, 1888139, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 86 },
             new byte[] { 137 }, 1888141, 1888141, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 56 },
             new byte[] { 107 }, 1888143, 1888143, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 56 },
             new byte[] { 86 }, 1888145, 1888145, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 56, 4, 26 },
             new byte[] { 86, 3, 216 }, 1888147, 1888149, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 217, 4, 26 },
             new byte[] { 157, 3, 216 }, 1888151, 1888153, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 156 },
             new byte[] { 82 }, 1888155, 1888155, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 162 },
             new byte[] { 89 }, 1888157, 1888157, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 186 },
             new byte[] { 112 }, 1888159, 1888159, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 176 },
             new byte[] { 103 }, 1888161, 1888161, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 155 },
             new byte[] { 82 }, 1888163, 1888163, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 141 },
             new byte[] { 69 }, 1888165, 1888165, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 113, 4, 106, 4, 106 },
             new byte[] { 41, 3, 190, 3, 216 }, 1888167, 1888171, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 96 },
             new byte[] { 71 }, 1888173, 1888173, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 86, 4, 76, 4, 76, 4, 41 },
             new byte[] { 79, 3, 206, 3, 206, 3, 132 }, 1888175, 1888181, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 217, 4, 26 },
             new byte[] { 157, 3, 216 }, 1888183, 1888185, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 152 },
             new byte[] { 80 }, 1888187, 1888187, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 152 },
             new byte[] { 80 }, 1888189, 1888189, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 152 },
             new byte[] { 80 }, 1888191, 1888191, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 152 },
             new byte[] { 80 }, 1888193, 1888193, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 152 },
             new byte[] { 80 }, 1888195, 1888195, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 141 },
             new byte[] { 69 }, 1888197, 1888197, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 113, 4, 106, 4, 106, 4, 86, 4, 86, 4, 143, 4, 142, 4, 134 },
             new byte[] { 41, 3, 190, 3, 216, 3, 197, 3, 166, 3, 227, 3, 226, 3, 218 }, 1888199, 1888213, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 217, 4, 26 },
             new byte[] { 157, 3, 216 }, 1888215, 1888217, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 146 },
             new byte[] { 73 }, 1888219, 1888219, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 146 },
             new byte[] { 73 }, 1888221, 1888221, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 146 },
             new byte[] { 73 }, 1888223, 1888223, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 146 },
             new byte[] { 73 }, 1888225, 1888225, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 146 },
             new byte[] { 73 }, 1888227, 1888227, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 146 },
             new byte[] { 73 }, 1888229, 1888229, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 136, 4, 106, 4, 106, 4, 96, 4, 96, 4, 143, 4, 142, 4, 148 },
             new byte[] { 64, 3, 190, 3, 216, 3, 215, 3, 187, 3, 227, 3, 226, 3, 232 }, 1888231, 1888245, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 217, 4, 26 },
             new byte[] { 157, 3, 216 }, 1888247, 1888249, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 146 },
             new byte[] { 73 }, 1888251, 1888251, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 146 },
             new byte[] { 73 }, 1888253, 1888253, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 146 },
             new byte[] { 73 }, 1888255, 1888255, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 146 },
             new byte[] { 73 }, 1888257, 1888257, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 146 },
             new byte[] { 73 }, 1888259, 1888259, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 146 },
             new byte[] { 73 }, 1888261, 1888261, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 136, 4, 106, 4, 96, 4, 86, 4, 71, 4, 161, 4, 175, 4, 171 },
             new byte[] { 64, 3, 190, 3, 198, 3, 178, 3, 135, 3, 244, 3, 253, 3, 249 }, 1888263, 1888277, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 217, 4, 26 },
             new byte[] { 157, 3, 216 }, 1888279, 1888281, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 146 },
             new byte[] { 73 }, 1888283, 1888283, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 146 },
             new byte[] { 73 }, 1888285, 1888285, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 146 },
             new byte[] { 73 }, 1888287, 1888287, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 146 },
             new byte[] { 73 }, 1888289, 1888289, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 146 },
             new byte[] { 73 }, 1888291, 1888291, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 146 },
             new byte[] { 73 }, 1888293, 1888293, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 136, 4, 106, 4, 86, 4, 76, 4, 145, 4, 161, 4, 174, 4, 168 },
             new byte[] { 64, 3, 190, 3, 181, 3, 161, 3, 229, 3, 244, 3, 252, 3, 246 }, 1888295, 1888309, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 217 },
             new byte[] { 157 }, 1888311, 1888311, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 109 },
             new byte[] { 36 }, 1888313, 1888313, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 196 },
             new byte[] { 117 }, 1888315, 1888315, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 196 },
             new byte[] { 117 }, 1888317, 1888317, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 196 },
             new byte[] { 117 }, 1888319, 1888319, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 196 },
             new byte[] { 117 }, 1888321, 1888321, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 196 },
             new byte[] { 117 }, 1888323, 1888323, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 196 },
             new byte[] { 117 }, 1888325, 1888325, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 136, 4, 106, 4, 106, 4, 125, 4, 145, 4, 125, 4, 140, 4, 127 },
             new byte[] { 64, 3, 190, 3, 216, 3, 209, 3, 229, 3, 209, 3, 224, 3, 211 }, 1888327, 1888341, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 88 },
             new byte[] { 120 }, 1889029, 1889029, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 88 },
             new byte[] { 120 }, 1889031, 1889031, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 88 },
             new byte[] { 134 }, 1889033, 1889033, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 88 },
             new byte[] { 134 }, 1889035, 1889035, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 88 },
             new byte[] { 134 }, 1889037, 1889037, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 88 },
             new byte[] { 134 }, 1889039, 1889039, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 88 },
             new byte[] { 134 }, 1889041, 1889041, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 88 },
             new byte[] { 134 }, 1889043, 1889043, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 88 },
             new byte[] { 134 }, 1889045, 1889045, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 88 },
             new byte[] { 134 }, 1889047, 1889047, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 88 },
             new byte[] { 134 }, 1889049, 1889049, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 88 },
             new byte[] { 134 }, 1889051, 1889051, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 162 },
             new byte[] { 212 }, 1889063, 1889063, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 162 },
             new byte[] { 233 }, 1889065, 1889065, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 162 },
             new byte[] { 233 }, 1889067, 1889067, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 162 },
             new byte[] { 233 }, 1889069, 1889069, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 162 },
             new byte[] { 233 }, 1889071, 1889071, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 162 },
             new byte[] { 233 }, 1889073, 1889073, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 162 },
             new byte[] { 233 }, 1889075, 1889075, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 162 },
             new byte[] { 233 }, 1889077, 1889077, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 162 },
             new byte[] { 233 }, 1889079, 1889079, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 162 },
             new byte[] { 233 }, 1889081, 1889081, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 162 },
             new byte[] { 233 }, 1889083, 1889083, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 146 },
             new byte[] { 162 }, 1889091, 1889091, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 142 },
             new byte[] { 185 }, 1889107, 1889107, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 142 },
             new byte[] { 170 }, 1889109, 1889109, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 142 },
             new byte[] { 170 }, 1889111, 1889111, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 142 },
             new byte[] { 170 }, 1889113, 1889113, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 142 },
             new byte[] { 170 }, 1889115, 1889115, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 30 },
             new byte[] { 42 }, 1889123, 1889123, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 246 },
             new byte[] { 255 }, 1889125, 1889125, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 3, 252 },
             new byte[] { 4, 14 }, 1889134, 1889135, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 212, 3, 182, 3, 182, 3, 182, 3, 182, 3, 182 },
             new byte[] { 230, 4, 2, 4, 2, 4, 2, 4, 2, 4, 2 }, 1889137, 1889147, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 196 },
             new byte[] { 206 }, 1889163, 1889163, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 86 },
             new byte[] { 95 }, 1889165, 1889165, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 36 },
             new byte[] { 45 }, 1889167, 1889167, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 232 },
             new byte[] { 240 }, 1889169, 1889169, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 232, 3, 232, 3, 232, 3, 232, 3, 232 },
             new byte[] { 252, 4, 42, 4, 65, 4, 29, 4, 45 }, 1889171, 1889179, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 196 },
             new byte[] { 206 }, 1889195, 1889195, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 176 },
             new byte[] { 196 }, 1889197, 1889197, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 156 },
             new byte[] { 176 }, 1889199, 1889199, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 86 },
             new byte[] { 105 }, 1889201, 1889201, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 36 },
             new byte[] { 58 }, 1889203, 1889203, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 242 },
             new byte[] { 190 }, 1889205, 1889205, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 242, 3, 242, 3, 242 },
             new byte[] { 223, 4, 10, 4, 29 }, 1889207, 1889211, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 196 },
             new byte[] { 206 }, 1889227, 1889227, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 176 },
             new byte[] { 196 }, 1889229, 1889229, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 156 },
             new byte[] { 187 }, 1889231, 1889231, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 126 },
             new byte[] { 146 }, 1889233, 1889233, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 36 },
             new byte[] { 67 }, 1889235, 1889235, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 242 },
             new byte[] { 198 }, 1889237, 1889237, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 242, 3, 242, 3, 242 },
             new byte[] { 223, 4, 10, 4, 29 }, 1889239, 1889243, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 196 },
             new byte[] { 206 }, 1889259, 1889259, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 176 },
             new byte[] { 196 }, 1889261, 1889261, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 156 },
             new byte[] { 176 }, 1889263, 1889263, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 146 },
             new byte[] { 166 }, 1889265, 1889265, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 36, 3, 242, 3, 242, 3, 242, 3, 242 },
             new byte[] { 77, 4, 43, 4, 38, 4, 14, 4, 29 }, 1889267, 1889275, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 196 },
             new byte[] { 206 }, 1889291, 1889291, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 176 },
             new byte[] { 186 }, 1889293, 1889293, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 156 },
             new byte[] { 166 }, 1889295, 1889295, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 146, 4, 36 },
             new byte[] { 51, 3, 233 }, 1889297, 1889299, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 26 },
             new byte[] { 75 }, 1889301, 1889301, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 26 },
             new byte[] { 75 }, 1889303, 1889303, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 26 },
             new byte[] { 56 }, 1889305, 1889305, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 26, 4, 26 },
             new byte[] { 56, 3, 216 }, 1889307, 1889309, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 96, 5, 40, 5, 30 },
             new byte[] { 27, 4, 213, 4, 203 }, 1889311, 1889315, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 246 },
             new byte[] { 168 }, 1889317, 1889317, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 236 },
             new byte[] { 159 }, 1889319, 1889319, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 226 },
             new byte[] { 150 }, 1889321, 1889321, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 196 },
             new byte[] { 121 }, 1889323, 1889323, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 176 },
             new byte[] { 101 }, 1889325, 1889325, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 156, 4, 146, 4, 66 },
             new byte[] { 81, 3, 224, 3, 182 }, 1889327, 1889331, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 36 },
             new byte[] { 12 }, 1889333, 1889333, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 36, 4, 36, 4, 36, 4, 36 },
             new byte[] { 29, 3, 171, 3, 171, 3, 127 }, 1889335, 1889341, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 186 },
             new byte[] { 112 }, 1889343, 1889343, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 186 },
             new byte[] { 109 }, 1889345, 1889345, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 186 },
             new byte[] { 111 }, 1889347, 1889347, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 186 },
             new byte[] { 111 }, 1889349, 1889349, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 186 },
             new byte[] { 111 }, 1889351, 1889351, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 186 },
             new byte[] { 111 }, 1889353, 1889353, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 186 },
             new byte[] { 111 }, 1889355, 1889355, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 186 },
             new byte[] { 111 }, 1889357, 1889357, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 186, 4, 166, 4, 76, 4, 36, 4, 36, 4, 36, 4, 36, 4, 36 },
             new byte[] { 109, 3, 241, 3, 190, 3, 154, 3, 124, 3, 135, 3, 135, 3, 134 }, 1889359, 1889373, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 176 },
             new byte[] { 102 }, 1889375, 1889375, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 176 },
             new byte[] { 100 }, 1889377, 1889377, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 176 },
             new byte[] { 102 }, 1889379, 1889379, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 176 },
             new byte[] { 102 }, 1889381, 1889381, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 176 },
             new byte[] { 102 }, 1889383, 1889383, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 176 },
             new byte[] { 102 }, 1889385, 1889385, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 176 },
             new byte[] { 102 }, 1889387, 1889387, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 176 },
             new byte[] { 102 }, 1889389, 1889389, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 176, 4, 176, 4, 76, 4, 46, 4, 46, 4, 46, 4, 46, 4, 46 },
             new byte[] { 101, 3, 250, 3, 190, 3, 171, 3, 144, 3, 144, 3, 144, 3, 145 }, 1889391, 1889405, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 156 },
             new byte[] { 84 }, 1889407, 1889407, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 156 },
             new byte[] { 81 }, 1889409, 1889409, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 156 },
             new byte[] { 83 }, 1889411, 1889411, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 156 },
             new byte[] { 83 }, 1889413, 1889413, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 156 },
             new byte[] { 83 }, 1889415, 1889415, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 156 },
             new byte[] { 83 }, 1889417, 1889417, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 156 },
             new byte[] { 83 }, 1889419, 1889419, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 176 },
             new byte[] { 102 }, 1889421, 1889421, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 176, 4, 176, 4, 76, 4, 66, 4, 66, 4, 66, 4, 66, 4, 66 },
             new byte[] { 101, 3, 250, 3, 181, 3, 161, 3, 131, 3, 163, 3, 160, 3, 159 }, 1889423, 1889437, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 156 },
             new byte[] { 84 }, 1889439, 1889439, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 156 },
             new byte[] { 81 }, 1889441, 1889441, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 156 },
             new byte[] { 83 }, 1889443, 1889443, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 156 },
             new byte[] { 83 }, 1889445, 1889445, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 156 },
             new byte[] { 83 }, 1889447, 1889447, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 156 },
             new byte[] { 83 }, 1889449, 1889449, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 156 },
             new byte[] { 83 }, 1889451, 1889451, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 156 },
             new byte[] { 83 }, 1889453, 1889453, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 156 },
             new byte[] { 82 }, 1889455, 1889455, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 206, 4, 76, 4, 76, 4, 76, 4, 76, 4, 76, 4, 76 },
             new byte[] { 19, 3, 172, 3, 161, 3, 170, 3, 172, 3, 168, 3, 168 }, 1889457, 1889469, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 196 },
             new byte[] { 121 }, 1889471, 1889471, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 196 },
             new byte[] { 118 }, 1889473, 1889473, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 196 },
             new byte[] { 117 }, 1889475, 1889475, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 196 },
             new byte[] { 117 }, 1889477, 1889477, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 196 },
             new byte[] { 117 }, 1889479, 1889479, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 196 },
             new byte[] { 117 }, 1889481, 1889481, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 196 },
             new byte[] { 117 }, 1889483, 1889483, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 196 },
             new byte[] { 117 }, 1889485, 1889485, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 196 },
             new byte[] { 120 }, 1889487, 1889487, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 206, 4, 126, 4, 126, 4, 126, 4, 126, 4, 126, 4, 126 },
             new byte[] { 19, 3, 234, 3, 210, 3, 212, 3, 210, 3, 212, 3, 210 }, 1889489, 1889501, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 37, 133, 40, 196 },
             new byte[] { 38, 203, 42, 2 }, 1891866, 1891869, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 34, 136, 37, 121 },
             new byte[] { 35, 217, 41, 79 }, 1891898, 1891901, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 32, 111, 34, 241 },
             new byte[] { 35, 255, 40, 254 }, 1891930, 1891933, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 27, 178, 32, 230 },
             new byte[] { 30, 246, 42, 45 }, 1891962, 1891965, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 27, 83, 30, 167 },
             new byte[] { 30, 188, 39, 208 }, 1891994, 1891997, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 27, 188, 30, 90 },
             new byte[] { 31, 66, 39, 105 }, 1892026, 1892029, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 29, 31, 30, 120 },
             new byte[] { 32, 196, 39, 116 }, 1892058, 1892061, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 30, 30, 30, 230 },
             new byte[] { 33, 217, 39, 187 }, 1892090, 1892093, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 29, 76, 31, 106 },
             new byte[] { 32, 190, 39, 232 }, 1892122, 1892125, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 30, 80, 31, 166 },
             new byte[] { 33, 197, 40, 5 }, 1892154, 1892157, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 32, 228, 33, 62 },
             new byte[] { 36, 136, 38, 251 }, 1892186, 1892189, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 35, 40, 35, 123 },
             new byte[] { 38, 243, 41, 124 }, 1892218, 1892221, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 36, 254, 37, 178 },
             new byte[] { 40, 226, 43, 245 }, 1892250, 1892253, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 38, 122, 40, 80 },
             new byte[] { 39, 233, 44, 96 }, 1892282, 1892285, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 40, 30, 42, 158 },
             new byte[] { 41, 136, 43, 249 }, 1892314, 1892317, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 37, 243, 42, 44 },
             new byte[] { 39, 61, 43, 118 }, 1892412, 1892415, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 33, 192, 37, 191 },
             new byte[] { 35, 10, 41, 157 }, 1892444, 1892447, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 31, 72, 34, 186 },
             new byte[] { 34, 184, 40, 190 }, 1892476, 1892479, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 29, 36, 31, 254 },
             new byte[] { 32, 148, 41, 4 }, 1892508, 1892511, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 27, 134, 30, 47 },
             new byte[] { 30, 246, 39, 53 }, 1892540, 1892543, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 27, 8, 30, 57 },
             new byte[] { 30, 120, 39, 63 }, 1892572, 1892575, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 27, 118, 30, 153 },
             new byte[] { 30, 230, 39, 159 }, 1892604, 1892607, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 27, 188, 31, 144 },
             new byte[] { 31, 44, 40, 150 }, 1892636, 1892639, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 29, 51, 33, 94 },
             new byte[] { 32, 163, 42, 100 }, 1892668, 1892671, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 30, 33, 34, 28 },
             new byte[] { 33, 145, 43, 34 }, 1892700, 1892703, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 31, 14, 34, 216 },
             new byte[] { 34, 126, 40, 220 }, 1892732, 1892735, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 31, 219, 35, 135 },
             new byte[] { 35, 75, 41, 139 }, 1892764, 1892767, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 32, 168, 36, 54 },
             new byte[] { 36, 24, 42, 58 }, 1892796, 1892799, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 34, 147, 38, 87 },
             new byte[] { 35, 221, 42, 53 }, 1892828, 1892831, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 36, 126, 40, 119 },
             new byte[] { 37, 200, 41, 193 }, 1892860, 1892863, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 33, 186, 37, 133 },
             new byte[] { 34, 223, 38, 170 }, 1892958, 1892961, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 30, 167, 34, 136 },
             new byte[] { 31, 210, 38, 17 }, 1892990, 1892993, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 28, 27, 32, 111 },
             new byte[] { 31, 49, 38, 13 }, 1893022, 1893025, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 24, 31, 27, 178 },
             new byte[] { 26, 247, 35, 129 }, 1893054, 1893057, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 23, 147, 27, 83 },
             new byte[] { 26, 132, 35, 126 }, 1893086, 1893089, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 23, 172, 27, 188 },
             new byte[] { 26, 174, 36, 3 }, 1893118, 1893121, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 23 },
             new byte[] { 26 }, 1893150, 1893150, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 29, 31 },
             new byte[] { 37, 181 }, 1893152, 1893153, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 25, 40, 30, 30 },
             new byte[] { 28, 70, 38, 186 }, 1893182, 1893185, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 25, 170, 29, 76 },
             new byte[] { 28, 175, 37, 56 }, 1893214, 1893217, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 26, 63, 30, 80 },
             new byte[] { 29, 61, 38, 84 }, 1893246, 1893249, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 26, 174, 32, 228 },
             new byte[] { 29, 162, 38, 145 }, 1893278, 1893281, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 32, 88, 35, 40 },
             new byte[] { 35, 213, 41, 27 }, 1893310, 1893313, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 33, 252, 36, 254 },
             new byte[] { 37, 143, 43, 35 }, 1893342, 1893345, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 32, 245, 37, 21 },
             new byte[] { 34, 19, 38, 55 }, 1893504, 1893507, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 29, 11, 32, 242 },
             new byte[] { 30, 38, 36, 82 }, 1893536, 1893539, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 27, 141, 30, 246 },
             new byte[] { 30, 148, 36, 83 }, 1893568, 1893571, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 26, 18, 28, 230 },
             new byte[] { 29, 37, 37, 12 }, 1893600, 1893603, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 23, 240, 26, 129 },
             new byte[] { 26, 237, 34, 109 }, 1893632, 1893635, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 23, 135, 26, 173 },
             new byte[] { 26, 132, 34, 163 }, 1893664, 1893667, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 23, 88, 27, 27 },
             new byte[] { 26, 68, 35, 25 }, 1893696, 1893699, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 23, 65, 26, 250 },
             new byte[] { 26, 34, 34, 176 }, 1893728, 1893731, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 24, 63, 28, 73 },
             new byte[] { 27, 25, 35, 239 }, 1893760, 1893763, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 24, 195, 28, 135 },
             new byte[] { 27, 150, 36, 18 }, 1893792, 1893795, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 25, 151, 29, 37 },
             new byte[] { 28, 108, 34, 45 }, 1893824, 1893827, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 26, 116, 29, 230 },
             new byte[] { 29, 78, 34, 246 }, 1893856, 1893859, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 27, 80, 30, 166 },
             new byte[] { 30, 48, 35, 189 }, 1893888, 1893891, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 22, 168, 22, 168, 21, 124, 19, 236, 18, 192, 17, 148, 17, 48, 16, 204, 16, 104, 16, 4 },
             new byte[] { 23, 242, 23, 242, 22, 198, 21, 54, 20, 10, 18, 222, 18, 122, 18, 22, 17, 178, 17, 78 }, 1898996, 1899015, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 22, 168, 21, 224, 21, 24, 19, 36, 17, 148, 17, 48, 16, 204 },
             new byte[] { 23, 242, 23, 42, 22, 98, 20, 110, 18, 222, 18, 122, 18, 22 }, 1899022, 1899035, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 21, 24, 19, 136, 19, 36, 18, 92 },
             new byte[] { 22, 98, 21, 174, 21, 74, 20, 130 }, 1899048, 1899055, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 22, 168, 22, 68, 21, 124, 20, 180 },
             new byte[] { 23, 242, 24, 106, 23, 162, 22, 218 }, 1899068, 1899075, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 24, 156, 24, 156, 24, 56, 23, 12 },
             new byte[] { 25, 230, 26, 194, 26, 94, 25, 50 }, 1899088, 1899095, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 26, 144, 26, 244, 26, 44, 25, 100 },
             new byte[] { 27, 218, 28, 62, 27, 118, 26, 174 }, 1899108, 1899115, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 25, 0, 25, 0 },
             new byte[] { 28, 2, 28, 2 }, 1919194, 1919197, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 24, 156, 24, 156 },
             new byte[] { 27, 158, 27, 158 }, 1919224, 1919227, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 25, 100, 25, 200 },
             new byte[] { 28, 102, 28, 202 }, 1919254, 1919257, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 24, 156, 25, 100, 25, 200 },
             new byte[] { 27, 158, 28, 102, 28, 202 }, 1919282, 1919287, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 25, 0, 25, 100, 25, 100 },
             new byte[] { 28, 2, 28, 102, 28, 102 }, 1919312, 1919317, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 25, 0, 25, 100, 25, 200 },
             new byte[] { 28, 2, 28, 212, 29, 56 }, 1919342, 1919347, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 25, 0, 25, 100, 25, 200 },
             new byte[] { 28, 2, 28, 212, 29, 56 }, 1919372, 1919377, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 25, 0, 25, 100, 25, 200 },
             new byte[] { 28, 2, 28, 212, 29, 56 }, 1919402, 1919407, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 25, 100, 25, 200, 25, 200 },
             new byte[] { 28, 102, 29, 56, 29, 56 }, 1919432, 1919437, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 25, 200, 26, 44, 26, 44 },
             new byte[] { 28, 202, 29, 156, 29, 156 }, 1919462, 1919467, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 25, 200, 25, 200, 26, 44 },
             new byte[] { 28, 202, 29, 56, 29, 156 }, 1919492, 1919497, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 26, 244, 27, 188, 27, 188, 23, 112, 23, 112, 23, 112, 23, 112 },
             new byte[] { 29, 246, 28, 42, 28, 42, 26, 44, 21, 24, 21, 224, 22, 68 }, 1919522, 1919535, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 112, 23, 112, 23, 112, 23, 112, 23, 112, 23, 112, 23, 112, 23, 112, 23, 112, 23, 112, 23, 112, 23, 112 },
             new byte[] { 12, 25, 200, 25, 0, 25, 200, 26, 44, 26, 144, 26, 44, 26, 44, 26, 144, 26, 244, 27, 188, 27, 188 }, 1919537, 1919559, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 24, 66, 24, 76 },
             new byte[] { 27, 68, 27, 78 }, 1919772, 1919775, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 24, 46, 24, 26 },
             new byte[] { 27, 48, 27, 28 }, 1919802, 1919805, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 24, 166, 25, 20 },
             new byte[] { 27, 168, 28, 22 }, 1919832, 1919835, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 24, 26, 24, 196, 25, 60 },
             new byte[] { 27, 28, 27, 198, 28, 62 }, 1919860, 1919865, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 24, 66, 24, 156, 24, 246 },
             new byte[] { 27, 68, 27, 158, 27, 248 }, 1919890, 1919895, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 24, 66, 24, 166, 25, 0 },
             new byte[] { 27, 68, 28, 22, 28, 112 }, 1919920, 1919925, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 24, 86, 24, 176, 25, 10 },
             new byte[] { 27, 88, 28, 32, 28, 122 }, 1919950, 1919955, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 24, 116, 24, 206, 25, 30 },
             new byte[] { 27, 118, 28, 62, 28, 142 }, 1919980, 1919985, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 24, 186, 25, 0, 25, 70 },
             new byte[] { 27, 188, 28, 112, 28, 182 }, 1920010, 1920015, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 25, 40, 25, 100, 25, 150 },
             new byte[] { 28, 42, 28, 212, 29, 6 }, 1920040, 1920045, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 25, 180, 25, 244, 26, 20, 23, 112, 23, 112, 23, 112, 23, 112, 23, 112 },
             new byte[] { 28, 182, 29, 100, 29, 132, 25, 150, 19, 234, 20, 150, 21, 3, 21, 208 }, 1920070, 1920085, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 112 },
             new byte[] { 67 }, 1920087, 1920087, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 112, 23, 112, 23, 112, 23, 112, 23, 112, 23, 112, 23, 112, 23, 112, 23, 112, 23, 112, 23, 112, 23, 112, 23, 112, 23, 112, 23, 112 },
             new byte[] { 116, 24, 23, 24, 151, 24, 187, 24, 176, 24, 234, 25, 85, 25, 180, 25, 244, 26, 20, 26, 20, 19, 234, 20, 150, 21, 3, 21, 208 }, 1920089, 1920117, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 112 },
             new byte[] { 67 }, 1920119, 1920119, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 112, 23, 112, 23, 112, 23, 112, 23, 112, 23, 112, 23, 112, 23, 112, 23, 112, 23, 112, 23, 112 },
             new byte[] { 116, 24, 23, 24, 151, 24, 187, 24, 176, 24, 234, 25, 85, 25, 180, 25, 244, 26, 20, 26, 20 }, 1920121, 1920141, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 33, 52, 33, 52, 33, 52, 33, 52, 33, 52, 33, 52, 33, 52, 33, 52, 33, 52, 33, 52, 33, 52, 33, 52, 33, 52, 33, 52, 33, 52, 33, 52, 33, 52, 33, 52, 33, 52, 33, 52, 33, 52, 33, 52, 33, 52, 33, 52, 33, 52, 33, 52, 33, 52, 33, 52, 33, 52, 33, 52, 33, 52, 33, 52, 33, 52, 33, 52, 33, 52, 33, 52, 33, 52, 33, 52, 33, 52, 33, 52, 33, 52, 33, 52, 33, 52, 33, 52, 33, 52, 33, 52, 33, 52, 33, 52, 33, 52, 33, 52, 33, 52, 33, 52, 33, 52, 33, 52, 33, 52, 33, 52, 33, 52, 33, 52, 33, 52, 33, 52, 33, 52, 33, 52, 33, 52, 33, 52 },
             new byte[] { 35, 40, 35, 40, 35, 40, 35, 40, 35, 40, 35, 40, 35, 40, 35, 40, 35, 40, 35, 40, 35, 40, 35, 40, 35, 40, 35, 40, 35, 40, 35, 40, 35, 40, 35, 40, 35, 40, 35, 40, 35, 40, 35, 40, 35, 40, 35, 40, 35, 40, 35, 40, 35, 40, 35, 40, 35, 40, 35, 40, 35, 40, 35, 40, 35, 40, 35, 40, 35, 40, 35, 40, 35, 40, 35, 40, 35, 40, 35, 40, 35, 40, 35, 40, 35, 40, 35, 40, 35, 40, 35, 40, 35, 40, 35, 40, 35, 40, 35, 40, 35, 40, 35, 40, 35, 40, 35, 40, 35, 40, 35, 40, 35, 40, 35, 40, 35, 40, 35, 40, 35, 40, 35, 40, 35, 40, 35, 40 }, 1921014, 1921141, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 24, 87, 23, 93 },
             new byte[] { 25, 181, 24, 237 }, 1921150, 1921153, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 1, 251 },
             new byte[] { 2, 10 }, 1992370, 1992371, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 77 },
             new byte[] { 92 }, 1992373, 1992373, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 161 },
             new byte[] { 179 }, 1992375, 1992375, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 4 },
             new byte[] { 25 }, 1992377, 1992377, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 87 },
             new byte[] { 111 }, 1992379, 1992379, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 185 },
             new byte[] { 212 }, 1992381, 1992381, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 71 },
             new byte[] { 101 }, 1992383, 1992383, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 52 },
             new byte[] { 91 }, 1992385, 1992385, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 36 },
             new byte[] { 81 }, 1992387, 1992387, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 126 },
             new byte[] { 183 }, 1992389, 1992389, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 194 },
             new byte[] { 206 }, 1992411, 1992411, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 31 },
             new byte[] { 46 }, 1992413, 1992413, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 91 },
             new byte[] { 109 }, 1992415, 1992415, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 179 },
             new byte[] { 197 }, 1992417, 1992417, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 10 },
             new byte[] { 31 }, 1992419, 1992419, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 84, 3, 240 },
             new byte[] { 108, 4, 14 }, 1992421, 1992423, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 188 },
             new byte[] { 224 }, 1992425, 1992425, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 145 },
             new byte[] { 187 }, 1992427, 1992427, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 177 },
             new byte[] { 228 }, 1992429, 1992429, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 166 },
             new byte[] { 178 }, 1992451, 1992451, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 236 },
             new byte[] { 248 }, 1992453, 1992453, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 57 },
             new byte[] { 72 }, 1992455, 1992455, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 119 },
             new byte[] { 137 }, 1992457, 1992457, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 198 },
             new byte[] { 219 }, 1992459, 1992459, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 5 },
             new byte[] { 26 }, 1992461, 1992461, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 164 },
             new byte[] { 191 }, 1992463, 1992463, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 101 },
             new byte[] { 167 }, 1992465, 1992465, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 46 },
             new byte[] { 124 }, 1992467, 1992467, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 61 },
             new byte[] { 151 }, 1992469, 1992469, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 152 },
             new byte[] { 164 }, 1992491, 1992491, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 196 },
             new byte[] { 208 }, 1992493, 1992493, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 8 },
             new byte[] { 23 }, 1992495, 1992495, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 73 },
             new byte[] { 88 }, 1992497, 1992497, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 137 },
             new byte[] { 173 }, 1992499, 1992499, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 212 },
             new byte[] { 254 }, 1992501, 1992501, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 75 },
             new byte[] { 123 }, 1992503, 1992503, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 36, 4, 210, 5, 214 },
             new byte[] { 96, 5, 26, 6, 42 }, 1992505, 1992509, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 133 },
             new byte[] { 142 }, 1992531, 1992531, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 178 },
             new byte[] { 190 }, 1992533, 1992533, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 225 },
             new byte[] { 237 }, 1992535, 1992535, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 37 },
             new byte[] { 52 }, 1992537, 1992537, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 101 },
             new byte[] { 137 }, 1992539, 1992539, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 153 },
             new byte[] { 189 }, 1992541, 1992541, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 26 },
             new byte[] { 68 }, 1992543, 1992543, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 200 },
             new byte[] { 254 }, 1992545, 1992545, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 133, 5, 138 },
             new byte[] { 232, 6, 8 }, 1992547, 1992549, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 117 },
             new byte[] { 126 }, 1992571, 1992571, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 167 },
             new byte[] { 179 }, 1992573, 1992573, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 208 },
             new byte[] { 232 }, 1992575, 1992575, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 1 },
             new byte[] { 31 }, 1992577, 1992577, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 66 },
             new byte[] { 96 }, 1992579, 1992579, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 119, 2, 234 },
             new byte[] { 155, 3, 20 }, 1992581, 1992583, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 139 },
             new byte[] { 193 }, 1992585, 1992585, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 64 },
             new byte[] { 154 }, 1992587, 1992587, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 62 },
             new byte[] { 179 }, 1992589, 1992589, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 102 },
             new byte[] { 111 }, 1992611, 1992611, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 152 },
             new byte[] { 164 }, 1992613, 1992613, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 202, 1, 237 },
             new byte[] { 226, 2, 5 }, 1992615, 1992617, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 38 },
             new byte[] { 68 }, 1992619, 1992619, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 89 },
             new byte[] { 125 }, 1992621, 1992621, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 189 },
             new byte[] { 252 }, 1992623, 1992623, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 86, 3, 253, 4, 225 },
             new byte[] { 158, 4, 87, 5, 77 }, 1992625, 1992629, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 90 },
             new byte[] { 99 }, 1992651, 1992651, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 137 },
             new byte[] { 146 }, 1992653, 1992653, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 184 },
             new byte[] { 208 }, 1992655, 1992655, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 228 },
             new byte[] { 252 }, 1992657, 1992657, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 11 },
             new byte[] { 41 }, 1992659, 1992659, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 61 },
             new byte[] { 91 }, 1992661, 1992661, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 158 },
             new byte[] { 212 }, 1992663, 1992663, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 55, 3, 192 },
             new byte[] { 127, 4, 25 }, 1992665, 1992667, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 126 },
             new byte[] { 235 }, 1992669, 1992669, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 78 },
             new byte[] { 96 }, 1992691, 1992691, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 125 },
             new byte[] { 143 }, 1992693, 1992693, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 167 },
             new byte[] { 191 }, 1992695, 1992695, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 212, 1, 248 },
             new byte[] { 236, 2, 22 }, 1992697, 1992699, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 33 },
             new byte[] { 78 }, 1992701, 1992701, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 123 },
             new byte[] { 177 }, 1992703, 1992703, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 15 },
             new byte[] { 78 }, 1992705, 1992705, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 154 },
             new byte[] { 243 }, 1992707, 1992707, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 109 },
             new byte[] { 218 }, 1992709, 1992709, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 57 },
             new byte[] { 75 }, 1992731, 1992731, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 102 },
             new byte[] { 120 }, 1992733, 1992733, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 142 },
             new byte[] { 160 }, 1992735, 1992735, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 178 },
             new byte[] { 202 }, 1992737, 1992737, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 216, 1, 250 },
             new byte[] { 240, 2, 39 }, 1992739, 1992741, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 67, 2, 205 },
             new byte[] { 112, 3, 12 }, 1992743, 1992745, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 80, 3, 228 },
             new byte[] { 159, 4, 61 }, 1992747, 1992749, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 55 },
             new byte[] { 73 }, 1992771, 1992771, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 93 },
             new byte[] { 111 }, 1992773, 1992773, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 132 },
             new byte[] { 150 }, 1992775, 1992775, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 171 },
             new byte[] { 195 }, 1992777, 1992777, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 210, 1, 248 },
             new byte[] { 234, 2, 37 }, 1992779, 1992781, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 28 },
             new byte[] { 73 }, 1992783, 1992783, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 149 },
             new byte[] { 203 }, 1992785, 1992785, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 19, 3, 191 },
             new byte[] { 88, 4, 24 }, 1992787, 1992789, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 1, 251 },
             new byte[] { 2, 10 }, 1993086, 1993087, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 77 },
             new byte[] { 92 }, 1993089, 1993089, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 161 },
             new byte[] { 179 }, 1993091, 1993091, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 4 },
             new byte[] { 25 }, 1993093, 1993093, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 87 },
             new byte[] { 111 }, 1993095, 1993095, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 185 },
             new byte[] { 212 }, 1993097, 1993097, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 71 },
             new byte[] { 101 }, 1993099, 1993099, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 52 },
             new byte[] { 91 }, 1993101, 1993101, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 36 },
             new byte[] { 81 }, 1993103, 1993103, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 126 },
             new byte[] { 183 }, 1993105, 1993105, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 194 },
             new byte[] { 206 }, 1993127, 1993127, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 31 },
             new byte[] { 46 }, 1993129, 1993129, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 91 },
             new byte[] { 109 }, 1993131, 1993131, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 179 },
             new byte[] { 197 }, 1993133, 1993133, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 10 },
             new byte[] { 31 }, 1993135, 1993135, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 84, 3, 240 },
             new byte[] { 108, 4, 14 }, 1993137, 1993139, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 188 },
             new byte[] { 224 }, 1993141, 1993141, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 145 },
             new byte[] { 187 }, 1993143, 1993143, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 177 },
             new byte[] { 228 }, 1993145, 1993145, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 166 },
             new byte[] { 178 }, 1993167, 1993167, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 236 },
             new byte[] { 248 }, 1993169, 1993169, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 57 },
             new byte[] { 72 }, 1993171, 1993171, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 119 },
             new byte[] { 137 }, 1993173, 1993173, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 198 },
             new byte[] { 219 }, 1993175, 1993175, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 5 },
             new byte[] { 26 }, 1993177, 1993177, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 164 },
             new byte[] { 191 }, 1993179, 1993179, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 101 },
             new byte[] { 167 }, 1993181, 1993181, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 46 },
             new byte[] { 124 }, 1993183, 1993183, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 61 },
             new byte[] { 151 }, 1993185, 1993185, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 152 },
             new byte[] { 164 }, 1993207, 1993207, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 196 },
             new byte[] { 208 }, 1993209, 1993209, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 8 },
             new byte[] { 23 }, 1993211, 1993211, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 73 },
             new byte[] { 88 }, 1993213, 1993213, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 137 },
             new byte[] { 173 }, 1993215, 1993215, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 212 },
             new byte[] { 254 }, 1993217, 1993217, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 75 },
             new byte[] { 123 }, 1993219, 1993219, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 36, 4, 210, 5, 214 },
             new byte[] { 96, 5, 26, 6, 42 }, 1993221, 1993225, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 133 },
             new byte[] { 142 }, 1993247, 1993247, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 178 },
             new byte[] { 190 }, 1993249, 1993249, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 225 },
             new byte[] { 237 }, 1993251, 1993251, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 37 },
             new byte[] { 52 }, 1993253, 1993253, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 101 },
             new byte[] { 137 }, 1993255, 1993255, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 153 },
             new byte[] { 189 }, 1993257, 1993257, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 26 },
             new byte[] { 68 }, 1993259, 1993259, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 200 },
             new byte[] { 254 }, 1993261, 1993261, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 133, 5, 138 },
             new byte[] { 232, 6, 8 }, 1993263, 1993265, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 117 },
             new byte[] { 126 }, 1993287, 1993287, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 167 },
             new byte[] { 179 }, 1993289, 1993289, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 208 },
             new byte[] { 232 }, 1993291, 1993291, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 1 },
             new byte[] { 31 }, 1993293, 1993293, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 66 },
             new byte[] { 96 }, 1993295, 1993295, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 119, 2, 234 },
             new byte[] { 155, 3, 20 }, 1993297, 1993299, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 139 },
             new byte[] { 193 }, 1993301, 1993301, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 64 },
             new byte[] { 154 }, 1993303, 1993303, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 62 },
             new byte[] { 179 }, 1993305, 1993305, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 102 },
             new byte[] { 111 }, 1993327, 1993327, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 152 },
             new byte[] { 164 }, 1993329, 1993329, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 202, 1, 237 },
             new byte[] { 226, 2, 5 }, 1993331, 1993333, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 38 },
             new byte[] { 68 }, 1993335, 1993335, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 89 },
             new byte[] { 125 }, 1993337, 1993337, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 189 },
             new byte[] { 252 }, 1993339, 1993339, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 86, 3, 253, 4, 225 },
             new byte[] { 158, 4, 87, 5, 77 }, 1993341, 1993345, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 90 },
             new byte[] { 99 }, 1993367, 1993367, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 137 },
             new byte[] { 146 }, 1993369, 1993369, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 184 },
             new byte[] { 208 }, 1993371, 1993371, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 228 },
             new byte[] { 252 }, 1993373, 1993373, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 11 },
             new byte[] { 41 }, 1993375, 1993375, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 61 },
             new byte[] { 91 }, 1993377, 1993377, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 158 },
             new byte[] { 212 }, 1993379, 1993379, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 55, 3, 192 },
             new byte[] { 127, 4, 25 }, 1993381, 1993383, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 126 },
             new byte[] { 235 }, 1993385, 1993385, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 78 },
             new byte[] { 96 }, 1993407, 1993407, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 125 },
             new byte[] { 143 }, 1993409, 1993409, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 167 },
             new byte[] { 191 }, 1993411, 1993411, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 212, 1, 248 },
             new byte[] { 236, 2, 22 }, 1993413, 1993415, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 33 },
             new byte[] { 78 }, 1993417, 1993417, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 123 },
             new byte[] { 177 }, 1993419, 1993419, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 15 },
             new byte[] { 78 }, 1993421, 1993421, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 154 },
             new byte[] { 243 }, 1993423, 1993423, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 109 },
             new byte[] { 218 }, 1993425, 1993425, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 57 },
             new byte[] { 75 }, 1993447, 1993447, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 102 },
             new byte[] { 120 }, 1993449, 1993449, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 142 },
             new byte[] { 160 }, 1993451, 1993451, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 178 },
             new byte[] { 202 }, 1993453, 1993453, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 216, 1, 250 },
             new byte[] { 240, 2, 39 }, 1993455, 1993457, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 67, 2, 205 },
             new byte[] { 112, 3, 12 }, 1993459, 1993461, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 80, 3, 228 },
             new byte[] { 159, 4, 61 }, 1993463, 1993465, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 55 },
             new byte[] { 73 }, 1993487, 1993487, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 93 },
             new byte[] { 111 }, 1993489, 1993489, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 132 },
             new byte[] { 150 }, 1993491, 1993491, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 171 },
             new byte[] { 195 }, 1993493, 1993493, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 210, 1, 248 },
             new byte[] { 234, 2, 37 }, 1993495, 1993497, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 28 },
             new byte[] { 73 }, 1993499, 1993499, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 149 },
             new byte[] { 203 }, 1993501, 1993501, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 19, 3, 191 },
             new byte[] { 88, 4, 24 }, 1993503, 1993505, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 1, 251 },
             new byte[] { 2, 10 }, 1993802, 1993803, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 77 },
             new byte[] { 92 }, 1993805, 1993805, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 161 },
             new byte[] { 179 }, 1993807, 1993807, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 4 },
             new byte[] { 25 }, 1993809, 1993809, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 87 },
             new byte[] { 111 }, 1993811, 1993811, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 185 },
             new byte[] { 212 }, 1993813, 1993813, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 71 },
             new byte[] { 101 }, 1993815, 1993815, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 52 },
             new byte[] { 91 }, 1993817, 1993817, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 36 },
             new byte[] { 81 }, 1993819, 1993819, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 126 },
             new byte[] { 183 }, 1993821, 1993821, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 194 },
             new byte[] { 206 }, 1993843, 1993843, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 31 },
             new byte[] { 46 }, 1993845, 1993845, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 91 },
             new byte[] { 109 }, 1993847, 1993847, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 179 },
             new byte[] { 197 }, 1993849, 1993849, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 10 },
             new byte[] { 31 }, 1993851, 1993851, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 84, 3, 240 },
             new byte[] { 108, 4, 14 }, 1993853, 1993855, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 188 },
             new byte[] { 224 }, 1993857, 1993857, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 145 },
             new byte[] { 187 }, 1993859, 1993859, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 177 },
             new byte[] { 228 }, 1993861, 1993861, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 166 },
             new byte[] { 178 }, 1993883, 1993883, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 236 },
             new byte[] { 248 }, 1993885, 1993885, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 57 },
             new byte[] { 72 }, 1993887, 1993887, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 119 },
             new byte[] { 137 }, 1993889, 1993889, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 198 },
             new byte[] { 219 }, 1993891, 1993891, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 5 },
             new byte[] { 26 }, 1993893, 1993893, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 164 },
             new byte[] { 191 }, 1993895, 1993895, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 101 },
             new byte[] { 167 }, 1993897, 1993897, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 46 },
             new byte[] { 124 }, 1993899, 1993899, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 61 },
             new byte[] { 151 }, 1993901, 1993901, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 152 },
             new byte[] { 164 }, 1993923, 1993923, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 196 },
             new byte[] { 208 }, 1993925, 1993925, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 8 },
             new byte[] { 23 }, 1993927, 1993927, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 73 },
             new byte[] { 88 }, 1993929, 1993929, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 137 },
             new byte[] { 173 }, 1993931, 1993931, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 212 },
             new byte[] { 254 }, 1993933, 1993933, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 75 },
             new byte[] { 123 }, 1993935, 1993935, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 36, 4, 210, 5, 214 },
             new byte[] { 96, 5, 26, 6, 42 }, 1993937, 1993941, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 133 },
             new byte[] { 142 }, 1993963, 1993963, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 178 },
             new byte[] { 190 }, 1993965, 1993965, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 225 },
             new byte[] { 237 }, 1993967, 1993967, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 37 },
             new byte[] { 52 }, 1993969, 1993969, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 101 },
             new byte[] { 137 }, 1993971, 1993971, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 153 },
             new byte[] { 189 }, 1993973, 1993973, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 26 },
             new byte[] { 68 }, 1993975, 1993975, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 200 },
             new byte[] { 254 }, 1993977, 1993977, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 133, 5, 138 },
             new byte[] { 232, 6, 8 }, 1993979, 1993981, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 117 },
             new byte[] { 126 }, 1994003, 1994003, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 167 },
             new byte[] { 179 }, 1994005, 1994005, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 208 },
             new byte[] { 232 }, 1994007, 1994007, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 1 },
             new byte[] { 31 }, 1994009, 1994009, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 66 },
             new byte[] { 96 }, 1994011, 1994011, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 119, 2, 234 },
             new byte[] { 155, 3, 20 }, 1994013, 1994015, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 139 },
             new byte[] { 193 }, 1994017, 1994017, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 64 },
             new byte[] { 154 }, 1994019, 1994019, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 62 },
             new byte[] { 179 }, 1994021, 1994021, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 102 },
             new byte[] { 111 }, 1994043, 1994043, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 152 },
             new byte[] { 164 }, 1994045, 1994045, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 202, 1, 237 },
             new byte[] { 226, 2, 5 }, 1994047, 1994049, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 38 },
             new byte[] { 68 }, 1994051, 1994051, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 89 },
             new byte[] { 125 }, 1994053, 1994053, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 189 },
             new byte[] { 252 }, 1994055, 1994055, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 86, 3, 253, 4, 225 },
             new byte[] { 158, 4, 87, 5, 77 }, 1994057, 1994061, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 90 },
             new byte[] { 99 }, 1994083, 1994083, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 137 },
             new byte[] { 146 }, 1994085, 1994085, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 184 },
             new byte[] { 208 }, 1994087, 1994087, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 228 },
             new byte[] { 252 }, 1994089, 1994089, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 11 },
             new byte[] { 41 }, 1994091, 1994091, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 61 },
             new byte[] { 91 }, 1994093, 1994093, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 158 },
             new byte[] { 212 }, 1994095, 1994095, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 55, 3, 192 },
             new byte[] { 127, 4, 25 }, 1994097, 1994099, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 126 },
             new byte[] { 235 }, 1994101, 1994101, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 78 },
             new byte[] { 96 }, 1994123, 1994123, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 125 },
             new byte[] { 143 }, 1994125, 1994125, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 167 },
             new byte[] { 191 }, 1994127, 1994127, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 212, 1, 248 },
             new byte[] { 236, 2, 22 }, 1994129, 1994131, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 33 },
             new byte[] { 78 }, 1994133, 1994133, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 123 },
             new byte[] { 177 }, 1994135, 1994135, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 15 },
             new byte[] { 78 }, 1994137, 1994137, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 154 },
             new byte[] { 243 }, 1994139, 1994139, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 109 },
             new byte[] { 218 }, 1994141, 1994141, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 57 },
             new byte[] { 75 }, 1994163, 1994163, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 102 },
             new byte[] { 120 }, 1994165, 1994165, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 142 },
             new byte[] { 160 }, 1994167, 1994167, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 178 },
             new byte[] { 202 }, 1994169, 1994169, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 216, 1, 250 },
             new byte[] { 240, 2, 39 }, 1994171, 1994173, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 67, 2, 205 },
             new byte[] { 112, 3, 12 }, 1994175, 1994177, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 80, 3, 228 },
             new byte[] { 159, 4, 61 }, 1994179, 1994181, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 55 },
             new byte[] { 73 }, 1994203, 1994203, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 93 },
             new byte[] { 111 }, 1994205, 1994205, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 132 },
             new byte[] { 150 }, 1994207, 1994207, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 171 },
             new byte[] { 195 }, 1994209, 1994209, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 210, 1, 248 },
             new byte[] { 234, 2, 37 }, 1994211, 1994213, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 28 },
             new byte[] { 73 }, 1994215, 1994215, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 149 },
             new byte[] { 203 }, 1994217, 1994217, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 19, 3, 191 },
             new byte[] { 88, 4, 24 }, 1994219, 1994221, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 1, 251 },
             new byte[] { 2, 10 }, 1994518, 1994519, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 77 },
             new byte[] { 92 }, 1994521, 1994521, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 161 },
             new byte[] { 179 }, 1994523, 1994523, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 4 },
             new byte[] { 25 }, 1994525, 1994525, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 87 },
             new byte[] { 111 }, 1994527, 1994527, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 185 },
             new byte[] { 212 }, 1994529, 1994529, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 71 },
             new byte[] { 101 }, 1994531, 1994531, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 52 },
             new byte[] { 91 }, 1994533, 1994533, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 36 },
             new byte[] { 81 }, 1994535, 1994535, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 126 },
             new byte[] { 183 }, 1994537, 1994537, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 194 },
             new byte[] { 206 }, 1994559, 1994559, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 31 },
             new byte[] { 46 }, 1994561, 1994561, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 91 },
             new byte[] { 109 }, 1994563, 1994563, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 179 },
             new byte[] { 197 }, 1994565, 1994565, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 10 },
             new byte[] { 31 }, 1994567, 1994567, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 84, 3, 240 },
             new byte[] { 108, 4, 14 }, 1994569, 1994571, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 188 },
             new byte[] { 224 }, 1994573, 1994573, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 145 },
             new byte[] { 187 }, 1994575, 1994575, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 177 },
             new byte[] { 228 }, 1994577, 1994577, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 166 },
             new byte[] { 178 }, 1994599, 1994599, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 236 },
             new byte[] { 248 }, 1994601, 1994601, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 57 },
             new byte[] { 72 }, 1994603, 1994603, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 119 },
             new byte[] { 137 }, 1994605, 1994605, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 198 },
             new byte[] { 219 }, 1994607, 1994607, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 5 },
             new byte[] { 26 }, 1994609, 1994609, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 164 },
             new byte[] { 191 }, 1994611, 1994611, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 101 },
             new byte[] { 167 }, 1994613, 1994613, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 46 },
             new byte[] { 124 }, 1994615, 1994615, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 61 },
             new byte[] { 151 }, 1994617, 1994617, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 152 },
             new byte[] { 164 }, 1994639, 1994639, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 196 },
             new byte[] { 208 }, 1994641, 1994641, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 8 },
             new byte[] { 23 }, 1994643, 1994643, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 73 },
             new byte[] { 88 }, 1994645, 1994645, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 137 },
             new byte[] { 173 }, 1994647, 1994647, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 212 },
             new byte[] { 254 }, 1994649, 1994649, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 75 },
             new byte[] { 123 }, 1994651, 1994651, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 36, 4, 210, 5, 214 },
             new byte[] { 96, 5, 26, 6, 42 }, 1994653, 1994657, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 133 },
             new byte[] { 142 }, 1994679, 1994679, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 178 },
             new byte[] { 190 }, 1994681, 1994681, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 225 },
             new byte[] { 237 }, 1994683, 1994683, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 37 },
             new byte[] { 52 }, 1994685, 1994685, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 101 },
             new byte[] { 137 }, 1994687, 1994687, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 153 },
             new byte[] { 189 }, 1994689, 1994689, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 26 },
             new byte[] { 68 }, 1994691, 1994691, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 200 },
             new byte[] { 254 }, 1994693, 1994693, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 133, 5, 138 },
             new byte[] { 232, 6, 8 }, 1994695, 1994697, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 117 },
             new byte[] { 126 }, 1994719, 1994719, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 167 },
             new byte[] { 179 }, 1994721, 1994721, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 208 },
             new byte[] { 232 }, 1994723, 1994723, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 1 },
             new byte[] { 31 }, 1994725, 1994725, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 66 },
             new byte[] { 96 }, 1994727, 1994727, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 119, 2, 234 },
             new byte[] { 155, 3, 20 }, 1994729, 1994731, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 139 },
             new byte[] { 193 }, 1994733, 1994733, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 64 },
             new byte[] { 154 }, 1994735, 1994735, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 62 },
             new byte[] { 179 }, 1994737, 1994737, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 102 },
             new byte[] { 111 }, 1994759, 1994759, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 152 },
             new byte[] { 164 }, 1994761, 1994761, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 202, 1, 237 },
             new byte[] { 226, 2, 5 }, 1994763, 1994765, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 38 },
             new byte[] { 68 }, 1994767, 1994767, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 89 },
             new byte[] { 125 }, 1994769, 1994769, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 189 },
             new byte[] { 252 }, 1994771, 1994771, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 86, 3, 253, 4, 225 },
             new byte[] { 158, 4, 87, 5, 77 }, 1994773, 1994777, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 90 },
             new byte[] { 99 }, 1994799, 1994799, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 137 },
             new byte[] { 146 }, 1994801, 1994801, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 184 },
             new byte[] { 208 }, 1994803, 1994803, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 228 },
             new byte[] { 252 }, 1994805, 1994805, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 11 },
             new byte[] { 41 }, 1994807, 1994807, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 61 },
             new byte[] { 91 }, 1994809, 1994809, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 158 },
             new byte[] { 212 }, 1994811, 1994811, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 55, 3, 192 },
             new byte[] { 127, 4, 25 }, 1994813, 1994815, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 126 },
             new byte[] { 235 }, 1994817, 1994817, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 78 },
             new byte[] { 96 }, 1994839, 1994839, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 125 },
             new byte[] { 143 }, 1994841, 1994841, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 167 },
             new byte[] { 191 }, 1994843, 1994843, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 212, 1, 248 },
             new byte[] { 236, 2, 22 }, 1994845, 1994847, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 33 },
             new byte[] { 78 }, 1994849, 1994849, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 123 },
             new byte[] { 177 }, 1994851, 1994851, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 15 },
             new byte[] { 78 }, 1994853, 1994853, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 154 },
             new byte[] { 243 }, 1994855, 1994855, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 109 },
             new byte[] { 218 }, 1994857, 1994857, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 57 },
             new byte[] { 75 }, 1994879, 1994879, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 102 },
             new byte[] { 120 }, 1994881, 1994881, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 142 },
             new byte[] { 160 }, 1994883, 1994883, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 178 },
             new byte[] { 202 }, 1994885, 1994885, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 216, 1, 250 },
             new byte[] { 240, 2, 39 }, 1994887, 1994889, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 67, 2, 205 },
             new byte[] { 112, 3, 12 }, 1994891, 1994893, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 80, 3, 228 },
             new byte[] { 159, 4, 61 }, 1994895, 1994897, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 55 },
             new byte[] { 73 }, 1994919, 1994919, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 93 },
             new byte[] { 111 }, 1994921, 1994921, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 132 },
             new byte[] { 150 }, 1994923, 1994923, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 171 },
             new byte[] { 195 }, 1994925, 1994925, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 210, 1, 248 },
             new byte[] { 234, 2, 37 }, 1994927, 1994929, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 28 },
             new byte[] { 73 }, 1994931, 1994931, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 149 },
             new byte[] { 203 }, 1994933, 1994933, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 19, 3, 191 },
             new byte[] { 88, 4, 24 }, 1994935, 1994937, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 1, 251 },
             new byte[] { 2, 10 }, 1995234, 1995235, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 77 },
             new byte[] { 92 }, 1995237, 1995237, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 161 },
             new byte[] { 179 }, 1995239, 1995239, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 4 },
             new byte[] { 25 }, 1995241, 1995241, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 87 },
             new byte[] { 111 }, 1995243, 1995243, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 185 },
             new byte[] { 212 }, 1995245, 1995245, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 71 },
             new byte[] { 101 }, 1995247, 1995247, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 52 },
             new byte[] { 91 }, 1995249, 1995249, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 36 },
             new byte[] { 81 }, 1995251, 1995251, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 126 },
             new byte[] { 183 }, 1995253, 1995253, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 194 },
             new byte[] { 206 }, 1995275, 1995275, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 31 },
             new byte[] { 46 }, 1995277, 1995277, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 91 },
             new byte[] { 109 }, 1995279, 1995279, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 179 },
             new byte[] { 197 }, 1995281, 1995281, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 10 },
             new byte[] { 31 }, 1995283, 1995283, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 84, 3, 240 },
             new byte[] { 108, 4, 14 }, 1995285, 1995287, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 188 },
             new byte[] { 224 }, 1995289, 1995289, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 145 },
             new byte[] { 187 }, 1995291, 1995291, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 177 },
             new byte[] { 228 }, 1995293, 1995293, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 166 },
             new byte[] { 178 }, 1995315, 1995315, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 236 },
             new byte[] { 248 }, 1995317, 1995317, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 57 },
             new byte[] { 72 }, 1995319, 1995319, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 119 },
             new byte[] { 137 }, 1995321, 1995321, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 198 },
             new byte[] { 219 }, 1995323, 1995323, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 5 },
             new byte[] { 26 }, 1995325, 1995325, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 164 },
             new byte[] { 191 }, 1995327, 1995327, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 101 },
             new byte[] { 167 }, 1995329, 1995329, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 46 },
             new byte[] { 124 }, 1995331, 1995331, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 61 },
             new byte[] { 151 }, 1995333, 1995333, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 152 },
             new byte[] { 164 }, 1995355, 1995355, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 196 },
             new byte[] { 208 }, 1995357, 1995357, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 8 },
             new byte[] { 23 }, 1995359, 1995359, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 73 },
             new byte[] { 88 }, 1995361, 1995361, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 137 },
             new byte[] { 173 }, 1995363, 1995363, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 212 },
             new byte[] { 254 }, 1995365, 1995365, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 75 },
             new byte[] { 123 }, 1995367, 1995367, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 36, 4, 210, 5, 214 },
             new byte[] { 96, 5, 26, 6, 42 }, 1995369, 1995373, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 133 },
             new byte[] { 142 }, 1995395, 1995395, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 178 },
             new byte[] { 190 }, 1995397, 1995397, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 225 },
             new byte[] { 237 }, 1995399, 1995399, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 37 },
             new byte[] { 52 }, 1995401, 1995401, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 101 },
             new byte[] { 137 }, 1995403, 1995403, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 153 },
             new byte[] { 189 }, 1995405, 1995405, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 26 },
             new byte[] { 68 }, 1995407, 1995407, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 200 },
             new byte[] { 254 }, 1995409, 1995409, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 133, 5, 138 },
             new byte[] { 232, 6, 8 }, 1995411, 1995413, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 117 },
             new byte[] { 126 }, 1995435, 1995435, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 167 },
             new byte[] { 179 }, 1995437, 1995437, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 208 },
             new byte[] { 232 }, 1995439, 1995439, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 1 },
             new byte[] { 31 }, 1995441, 1995441, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 66 },
             new byte[] { 96 }, 1995443, 1995443, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 119, 2, 234 },
             new byte[] { 155, 3, 20 }, 1995445, 1995447, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 139 },
             new byte[] { 193 }, 1995449, 1995449, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 64 },
             new byte[] { 154 }, 1995451, 1995451, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 62 },
             new byte[] { 179 }, 1995453, 1995453, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 102 },
             new byte[] { 111 }, 1995475, 1995475, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 152 },
             new byte[] { 164 }, 1995477, 1995477, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 202, 1, 237 },
             new byte[] { 226, 2, 5 }, 1995479, 1995481, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 38 },
             new byte[] { 68 }, 1995483, 1995483, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 89 },
             new byte[] { 125 }, 1995485, 1995485, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 189 },
             new byte[] { 252 }, 1995487, 1995487, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 86, 3, 253, 4, 225 },
             new byte[] { 158, 4, 87, 5, 77 }, 1995489, 1995493, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 90 },
             new byte[] { 99 }, 1995515, 1995515, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 137 },
             new byte[] { 146 }, 1995517, 1995517, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 184 },
             new byte[] { 208 }, 1995519, 1995519, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 228 },
             new byte[] { 252 }, 1995521, 1995521, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 11 },
             new byte[] { 41 }, 1995523, 1995523, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 61 },
             new byte[] { 91 }, 1995525, 1995525, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 158 },
             new byte[] { 212 }, 1995527, 1995527, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 55, 3, 192 },
             new byte[] { 127, 4, 25 }, 1995529, 1995531, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 126 },
             new byte[] { 235 }, 1995533, 1995533, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 78 },
             new byte[] { 96 }, 1995555, 1995555, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 125 },
             new byte[] { 143 }, 1995557, 1995557, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 167 },
             new byte[] { 191 }, 1995559, 1995559, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 212, 1, 248 },
             new byte[] { 236, 2, 22 }, 1995561, 1995563, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 33 },
             new byte[] { 78 }, 1995565, 1995565, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 123 },
             new byte[] { 177 }, 1995567, 1995567, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 15 },
             new byte[] { 78 }, 1995569, 1995569, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 154 },
             new byte[] { 243 }, 1995571, 1995571, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 109 },
             new byte[] { 218 }, 1995573, 1995573, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 57 },
             new byte[] { 75 }, 1995595, 1995595, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 102 },
             new byte[] { 120 }, 1995597, 1995597, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 142 },
             new byte[] { 160 }, 1995599, 1995599, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 178 },
             new byte[] { 202 }, 1995601, 1995601, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 216, 1, 250 },
             new byte[] { 240, 2, 39 }, 1995603, 1995605, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 67, 2, 205 },
             new byte[] { 112, 3, 12 }, 1995607, 1995609, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 80, 3, 228 },
             new byte[] { 159, 4, 61 }, 1995611, 1995613, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 55 },
             new byte[] { 73 }, 1995635, 1995635, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 93 },
             new byte[] { 111 }, 1995637, 1995637, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 132 },
             new byte[] { 150 }, 1995639, 1995639, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 171 },
             new byte[] { 195 }, 1995641, 1995641, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 210, 1, 248 },
             new byte[] { 234, 2, 37 }, 1995643, 1995645, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 28 },
             new byte[] { 73 }, 1995647, 1995647, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 149 },
             new byte[] { 203 }, 1995649, 1995649, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 19, 3, 191 },
             new byte[] { 88, 4, 24 }, 1995651, 1995653, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 1, 251 },
             new byte[] { 2, 10 }, 1995950, 1995951, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 77 },
             new byte[] { 92 }, 1995953, 1995953, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 161 },
             new byte[] { 179 }, 1995955, 1995955, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 4 },
             new byte[] { 25 }, 1995957, 1995957, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 87 },
             new byte[] { 111 }, 1995959, 1995959, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 185 },
             new byte[] { 212 }, 1995961, 1995961, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 71 },
             new byte[] { 101 }, 1995963, 1995963, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 52 },
             new byte[] { 91 }, 1995965, 1995965, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 36 },
             new byte[] { 81 }, 1995967, 1995967, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 126 },
             new byte[] { 183 }, 1995969, 1995969, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 194 },
             new byte[] { 206 }, 1995991, 1995991, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 31 },
             new byte[] { 46 }, 1995993, 1995993, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 91 },
             new byte[] { 109 }, 1995995, 1995995, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 179 },
             new byte[] { 197 }, 1995997, 1995997, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 10 },
             new byte[] { 31 }, 1995999, 1995999, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 84, 3, 240 },
             new byte[] { 108, 4, 14 }, 1996001, 1996003, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 188 },
             new byte[] { 224 }, 1996005, 1996005, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 145 },
             new byte[] { 187 }, 1996007, 1996007, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 177 },
             new byte[] { 228 }, 1996009, 1996009, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 166 },
             new byte[] { 178 }, 1996031, 1996031, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 236 },
             new byte[] { 248 }, 1996033, 1996033, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 57 },
             new byte[] { 72 }, 1996035, 1996035, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 119 },
             new byte[] { 137 }, 1996037, 1996037, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 198 },
             new byte[] { 219 }, 1996039, 1996039, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 5 },
             new byte[] { 26 }, 1996041, 1996041, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 164 },
             new byte[] { 191 }, 1996043, 1996043, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 101 },
             new byte[] { 167 }, 1996045, 1996045, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 46 },
             new byte[] { 124 }, 1996047, 1996047, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 61 },
             new byte[] { 151 }, 1996049, 1996049, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 152 },
             new byte[] { 164 }, 1996071, 1996071, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 196 },
             new byte[] { 208 }, 1996073, 1996073, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 8 },
             new byte[] { 23 }, 1996075, 1996075, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 73 },
             new byte[] { 88 }, 1996077, 1996077, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 137 },
             new byte[] { 173 }, 1996079, 1996079, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 212 },
             new byte[] { 254 }, 1996081, 1996081, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 75 },
             new byte[] { 123 }, 1996083, 1996083, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 36, 4, 210, 5, 214 },
             new byte[] { 96, 5, 26, 6, 42 }, 1996085, 1996089, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 133 },
             new byte[] { 142 }, 1996111, 1996111, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 178 },
             new byte[] { 190 }, 1996113, 1996113, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 225 },
             new byte[] { 237 }, 1996115, 1996115, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 37 },
             new byte[] { 52 }, 1996117, 1996117, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 101 },
             new byte[] { 137 }, 1996119, 1996119, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 153 },
             new byte[] { 189 }, 1996121, 1996121, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 26 },
             new byte[] { 68 }, 1996123, 1996123, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 200 },
             new byte[] { 254 }, 1996125, 1996125, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 133, 5, 138 },
             new byte[] { 232, 6, 8 }, 1996127, 1996129, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 117 },
             new byte[] { 126 }, 1996151, 1996151, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 167 },
             new byte[] { 179 }, 1996153, 1996153, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 208 },
             new byte[] { 232 }, 1996155, 1996155, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 1 },
             new byte[] { 31 }, 1996157, 1996157, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 66 },
             new byte[] { 96 }, 1996159, 1996159, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 119, 2, 234 },
             new byte[] { 155, 3, 20 }, 1996161, 1996163, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 139 },
             new byte[] { 193 }, 1996165, 1996165, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 64 },
             new byte[] { 154 }, 1996167, 1996167, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 62 },
             new byte[] { 179 }, 1996169, 1996169, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 102 },
             new byte[] { 111 }, 1996191, 1996191, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 152 },
             new byte[] { 164 }, 1996193, 1996193, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 202, 1, 237 },
             new byte[] { 226, 2, 5 }, 1996195, 1996197, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 38 },
             new byte[] { 68 }, 1996199, 1996199, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 89 },
             new byte[] { 125 }, 1996201, 1996201, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 189 },
             new byte[] { 252 }, 1996203, 1996203, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 86, 3, 253, 4, 225 },
             new byte[] { 158, 4, 87, 5, 77 }, 1996205, 1996209, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 90 },
             new byte[] { 99 }, 1996231, 1996231, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 137 },
             new byte[] { 146 }, 1996233, 1996233, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 184 },
             new byte[] { 208 }, 1996235, 1996235, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 228 },
             new byte[] { 252 }, 1996237, 1996237, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 11 },
             new byte[] { 41 }, 1996239, 1996239, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 61 },
             new byte[] { 91 }, 1996241, 1996241, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 158 },
             new byte[] { 212 }, 1996243, 1996243, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 55, 3, 192 },
             new byte[] { 127, 4, 25 }, 1996245, 1996247, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 126 },
             new byte[] { 235 }, 1996249, 1996249, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 78 },
             new byte[] { 96 }, 1996271, 1996271, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 125 },
             new byte[] { 143 }, 1996273, 1996273, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 167 },
             new byte[] { 191 }, 1996275, 1996275, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 212, 1, 248 },
             new byte[] { 236, 2, 22 }, 1996277, 1996279, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 33 },
             new byte[] { 78 }, 1996281, 1996281, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 123 },
             new byte[] { 177 }, 1996283, 1996283, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 15 },
             new byte[] { 78 }, 1996285, 1996285, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 154 },
             new byte[] { 243 }, 1996287, 1996287, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 109 },
             new byte[] { 218 }, 1996289, 1996289, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 57 },
             new byte[] { 75 }, 1996311, 1996311, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 102 },
             new byte[] { 120 }, 1996313, 1996313, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 142 },
             new byte[] { 160 }, 1996315, 1996315, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 178 },
             new byte[] { 202 }, 1996317, 1996317, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 216, 1, 250 },
             new byte[] { 240, 2, 39 }, 1996319, 1996321, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 67, 2, 205 },
             new byte[] { 112, 3, 12 }, 1996323, 1996325, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 80, 3, 228 },
             new byte[] { 159, 4, 61 }, 1996327, 1996329, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 55 },
             new byte[] { 73 }, 1996351, 1996351, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 93 },
             new byte[] { 111 }, 1996353, 1996353, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 132 },
             new byte[] { 150 }, 1996355, 1996355, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 171 },
             new byte[] { 195 }, 1996357, 1996357, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 210, 1, 248 },
             new byte[] { 234, 2, 37 }, 1996359, 1996361, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 28 },
             new byte[] { 73 }, 1996363, 1996363, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 149 },
             new byte[] { 203 }, 1996365, 1996365, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 19, 3, 191 },
             new byte[] { 88, 4, 24 }, 1996367, 1996369, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 78, 6, 234, 7, 162 },
             new byte[] { 188, 7, 88, 8, 16 }, 2020559, 2020563, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 27, 8, 165, 8, 243 },
             new byte[] { 137, 9, 19, 9, 97 }, 2020565, 2020569, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 80, 9, 158, 9, 221, 9, 221, 6, 216 },
             new byte[] { 190, 10, 12, 10, 75, 10, 75, 7, 70 }, 2020571, 2020579, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 139 },
             new byte[] { 249 }, 2020581, 2020581, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 111, 8, 237 },
             new byte[] { 221, 9, 91 }, 2020583, 2020585, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 54 },
             new byte[] { 164 }, 2020587, 2020587, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 125, 9, 185, 9, 251 },
             new byte[] { 235, 10, 39, 10, 105 }, 2020589, 2020593, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 60 },
             new byte[] { 170 }, 2020595, 2020595, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 60 },
             new byte[] { 170 }, 2020597, 2020597, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 44, 7, 252, 8, 230 },
             new byte[] { 154, 8, 106, 9, 84 }, 2020599, 2020603, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 93 },
             new byte[] { 203 }, 2020605, 2020605, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 140, 9, 197, 9, 243 },
             new byte[] { 250, 10, 51, 10, 97 }, 2020607, 2020611, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 49 },
             new byte[] { 159 }, 2020613, 2020613, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 100 },
             new byte[] { 210 }, 2020615, 2020615, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 100 },
             new byte[] { 210 }, 2020617, 2020617, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 88 },
             new byte[] { 198 }, 2020619, 2020619, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 30 },
             new byte[] { 140 }, 2020621, 2020621, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 27, 9, 149, 9, 182, 9, 224 },
             new byte[] { 137, 10, 3, 10, 36, 10, 78 }, 2020623, 2020629, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 6 },
             new byte[] { 116 }, 2020631, 2020631, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 73 },
             new byte[] { 183 }, 2020633, 2020633, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 130 },
             new byte[] { 240 }, 2020635, 2020635, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 130 },
             new byte[] { 240 }, 2020637, 2020637, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 60 },
             new byte[] { 170 }, 2020639, 2020639, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 7 },
             new byte[] { 117 }, 2020641, 2020641, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 7 },
             new byte[] { 117 }, 2020643, 2020643, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 139, 9, 186, 9, 224 },
             new byte[] { 249, 10, 40, 10, 78 }, 2020645, 2020649, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 10 },
             new byte[] { 120 }, 2020651, 2020651, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 73 },
             new byte[] { 183 }, 2020653, 2020653, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 140 },
             new byte[] { 250 }, 2020655, 2020655, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 140, 6, 243, 7, 193, 8, 190 },
             new byte[] { 250, 7, 97, 8, 47, 9, 44 }, 2020657, 2020663, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 74, 9, 153, 9, 200, 9, 242 },
             new byte[] { 184, 10, 7, 10, 54, 10, 96 }, 2020665, 2020671, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 53 },
             new byte[] { 163 }, 2020673, 2020673, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 120 },
             new byte[] { 230 }, 2020675, 2020675, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 120, 6, 148 },
             new byte[] { 230, 7, 2 }, 2020677, 2020679, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 100 },
             new byte[] { 210 }, 2020681, 2020681, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 96, 8, 229 },
             new byte[] { 206, 9, 83 }, 2020683, 2020685, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 75, 9, 157, 9, 223 },
             new byte[] { 185, 10, 11, 10, 77 }, 2020687, 2020691, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 24 },
             new byte[] { 134 }, 2020693, 2020693, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 100 },
             new byte[] { 210 }, 2020695, 2020695, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 100 },
             new byte[] { 210 }, 2020697, 2020697, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 52, 6, 255, 7, 247 },
             new byte[] { 162, 7, 109, 8, 101 }, 2020699, 2020703, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 132, 8, 246 },
             new byte[] { 242, 9, 100 }, 2020705, 2020707, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 95, 9, 176, 9, 241 },
             new byte[] { 205, 10, 30, 10, 95 }, 2020709, 2020713, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 50 },
             new byte[] { 160 }, 2020715, 2020715, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 50, 5, 216, 6, 172 },
             new byte[] { 160, 6, 70, 7, 26 }, 2020717, 2020721, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 143 },
             new byte[] { 253 }, 2020723, 2020723, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 29, 8, 158 },
             new byte[] { 139, 9, 12 }, 2020725, 2020727, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 20 },
             new byte[] { 130 }, 2020729, 2020729, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 114, 9, 177, 9, 241, 9, 241 },
             new byte[] { 224, 10, 31, 10, 95, 10, 95 }, 2020731, 2020737, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 122 },
             new byte[] { 232 }, 2020739, 2020739, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 86 },
             new byte[] { 196 }, 2020741, 2020741, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 49, 7, 190 },
             new byte[] { 159, 8, 44 }, 2020743, 2020745, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 84, 8, 206 },
             new byte[] { 194, 9, 60 }, 2020747, 2020749, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 57 },
             new byte[] { 167 }, 2020751, 2020751, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 119, 9, 181, 9, 181 },
             new byte[] { 229, 10, 35, 10, 35 }, 2020753, 2020757, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 35, 5, 245, 6, 214 },
             new byte[] { 145, 6, 99, 7, 68 }, 2020759, 2020763, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 98, 7, 255 },
             new byte[] { 208, 8, 109 }, 2020765, 2020767, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 139 },
             new byte[] { 249 }, 2020769, 2020769, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 4 },
             new byte[] { 114 }, 2020771, 2020771, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 70 },
             new byte[] { 180 }, 2020773, 2020773, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 131 },
             new byte[] { 241 }, 2020775, 2020775, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 131, 4, 216, 5, 160 },
             new byte[] { 241, 5, 70, 6, 14 }, 2020777, 2020781, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 124 },
             new byte[] { 234 }, 2020783, 2020783, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 8, 7, 184 },
             new byte[] { 118, 8, 38 }, 2020785, 2020787, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 78, 8, 208 },
             new byte[] { 188, 9, 62 }, 2020789, 2020791, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 26 },
             new byte[] { 136 }, 2020793, 2020793, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 86 },
             new byte[] { 196 }, 2020795, 2020795, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 86 },
             new byte[] { 196 }, 2020797, 2020797, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 76 },
             new byte[] { 186 }, 2020799, 2020799, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 25, 5, 230 },
             new byte[] { 135, 6, 84 }, 2020801, 2020803, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 99 },
             new byte[] { 209 }, 2020805, 2020805, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 32, 7, 235 },
             new byte[] { 142, 8, 89 }, 2020807, 2020809, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 112, 8, 199 },
             new byte[] { 222, 9, 53 }, 2020811, 2020813, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 6 },
             new byte[] { 116 }, 2020815, 2020815, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 6 },
             new byte[] { 116 }, 2020817, 2020817, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 8, 202 },
             new byte[] { 9, 146 }, 2021020, 2021021, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 78, 6, 234, 7, 162 },
             new byte[] { 188, 7, 88, 8, 16 }, 2021159, 2021163, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 27, 8, 165, 8, 243 },
             new byte[] { 137, 9, 19, 9, 97 }, 2021165, 2021169, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 80, 9, 158, 9, 221, 9, 221, 6, 216 },
             new byte[] { 190, 10, 12, 10, 75, 10, 75, 7, 70 }, 2021171, 2021179, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 139 },
             new byte[] { 249 }, 2021181, 2021181, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 111, 8, 237 },
             new byte[] { 221, 9, 91 }, 2021183, 2021185, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 54 },
             new byte[] { 164 }, 2021187, 2021187, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 125, 9, 185, 9, 251 },
             new byte[] { 235, 10, 39, 10, 105 }, 2021189, 2021193, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 60 },
             new byte[] { 170 }, 2021195, 2021195, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 60 },
             new byte[] { 170 }, 2021197, 2021197, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 44, 7, 252, 8, 230 },
             new byte[] { 154, 8, 106, 9, 84 }, 2021199, 2021203, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 93 },
             new byte[] { 203 }, 2021205, 2021205, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 140, 9, 197, 9, 243 },
             new byte[] { 250, 10, 51, 10, 97 }, 2021207, 2021211, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 49 },
             new byte[] { 159 }, 2021213, 2021213, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 100 },
             new byte[] { 210 }, 2021215, 2021215, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 100 },
             new byte[] { 210 }, 2021217, 2021217, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 88 },
             new byte[] { 198 }, 2021219, 2021219, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 30 },
             new byte[] { 140 }, 2021221, 2021221, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 27, 9, 149, 9, 182, 9, 224 },
             new byte[] { 137, 10, 3, 10, 36, 10, 78 }, 2021223, 2021229, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 6 },
             new byte[] { 116 }, 2021231, 2021231, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 73 },
             new byte[] { 183 }, 2021233, 2021233, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 130 },
             new byte[] { 240 }, 2021235, 2021235, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 130 },
             new byte[] { 240 }, 2021237, 2021237, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 60 },
             new byte[] { 170 }, 2021239, 2021239, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 7 },
             new byte[] { 117 }, 2021241, 2021241, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 7 },
             new byte[] { 117 }, 2021243, 2021243, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 139, 9, 186, 9, 224 },
             new byte[] { 249, 10, 40, 10, 78 }, 2021245, 2021249, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 10 },
             new byte[] { 120 }, 2021251, 2021251, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 73 },
             new byte[] { 183 }, 2021253, 2021253, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 140 },
             new byte[] { 250 }, 2021255, 2021255, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 140, 6, 243, 7, 193, 8, 190 },
             new byte[] { 250, 7, 97, 8, 47, 9, 44 }, 2021257, 2021263, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 74, 9, 153, 9, 200, 9, 242 },
             new byte[] { 184, 10, 7, 10, 54, 10, 96 }, 2021265, 2021271, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 53 },
             new byte[] { 163 }, 2021273, 2021273, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 120 },
             new byte[] { 230 }, 2021275, 2021275, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 120, 6, 148 },
             new byte[] { 230, 7, 2 }, 2021277, 2021279, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 100 },
             new byte[] { 210 }, 2021281, 2021281, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 96, 8, 229 },
             new byte[] { 206, 9, 83 }, 2021283, 2021285, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 75, 9, 157, 9, 223 },
             new byte[] { 185, 10, 11, 10, 77 }, 2021287, 2021291, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 24 },
             new byte[] { 134 }, 2021293, 2021293, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 100 },
             new byte[] { 210 }, 2021295, 2021295, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 100 },
             new byte[] { 210 }, 2021297, 2021297, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 52, 6, 255, 7, 247 },
             new byte[] { 162, 7, 109, 8, 101 }, 2021299, 2021303, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 132, 8, 246 },
             new byte[] { 242, 9, 100 }, 2021305, 2021307, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 95, 9, 176, 9, 241 },
             new byte[] { 205, 10, 30, 10, 95 }, 2021309, 2021313, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 50 },
             new byte[] { 160 }, 2021315, 2021315, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 50, 5, 216, 6, 172 },
             new byte[] { 160, 6, 70, 7, 26 }, 2021317, 2021321, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 143 },
             new byte[] { 253 }, 2021323, 2021323, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 29, 8, 158 },
             new byte[] { 139, 9, 12 }, 2021325, 2021327, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 20 },
             new byte[] { 130 }, 2021329, 2021329, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 114, 9, 177, 9, 241, 9, 241 },
             new byte[] { 224, 10, 31, 10, 95, 10, 95 }, 2021331, 2021337, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 122 },
             new byte[] { 232 }, 2021339, 2021339, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 86 },
             new byte[] { 196 }, 2021341, 2021341, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 49, 7, 190 },
             new byte[] { 159, 8, 44 }, 2021343, 2021345, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 84, 8, 206 },
             new byte[] { 194, 9, 60 }, 2021347, 2021349, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 57 },
             new byte[] { 167 }, 2021351, 2021351, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 119, 9, 181, 9, 181 },
             new byte[] { 229, 10, 35, 10, 35 }, 2021353, 2021357, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 35, 5, 245, 6, 214 },
             new byte[] { 145, 6, 99, 7, 68 }, 2021359, 2021363, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 98, 7, 255 },
             new byte[] { 208, 8, 109 }, 2021365, 2021367, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 139 },
             new byte[] { 249 }, 2021369, 2021369, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 4 },
             new byte[] { 114 }, 2021371, 2021371, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 70 },
             new byte[] { 180 }, 2021373, 2021373, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 131 },
             new byte[] { 241 }, 2021375, 2021375, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 131, 4, 216, 5, 160 },
             new byte[] { 241, 5, 70, 6, 14 }, 2021377, 2021381, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 124 },
             new byte[] { 234 }, 2021383, 2021383, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 8, 7, 184 },
             new byte[] { 118, 8, 38 }, 2021385, 2021387, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 78, 8, 208 },
             new byte[] { 188, 9, 62 }, 2021389, 2021391, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 26 },
             new byte[] { 136 }, 2021393, 2021393, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 86 },
             new byte[] { 196 }, 2021395, 2021395, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 86 },
             new byte[] { 196 }, 2021397, 2021397, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 76 },
             new byte[] { 186 }, 2021399, 2021399, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 25, 5, 230 },
             new byte[] { 135, 6, 84 }, 2021401, 2021403, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 99 },
             new byte[] { 209 }, 2021405, 2021405, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 32, 7, 235 },
             new byte[] { 142, 8, 89 }, 2021407, 2021409, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 112, 8, 199 },
             new byte[] { 222, 9, 53 }, 2021411, 2021413, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 6 },
             new byte[] { 116 }, 2021415, 2021415, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 6 },
             new byte[] { 116 }, 2021417, 2021417, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 11, 184, 12, 178, 13, 172, 14, 166, 15, 160, 16, 154, 17, 148, 18, 142 },
             new byte[] { 10, 190, 11, 184, 12, 178, 13, 172, 14, 166, 15, 160, 16, 154, 17, 148 }, 2021426, 2021441, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 9, 206, 9, 206, 9, 206, 9, 206, 9, 206, 9, 206, 9, 206, 9, 206, 9, 206, 9, 206, 9, 176, 9, 146, 9, 146, 9, 146, 9, 231, 9, 231, 9, 231, 9, 146, 9, 71, 9, 71, 9, 71 },
             new byte[] { 10, 240, 10, 240, 10, 240, 10, 240, 10, 240, 10, 240, 10, 240, 10, 250, 10, 250, 10, 250, 10, 250, 10, 250, 10, 250, 10, 250, 10, 230, 10, 230, 10, 230, 10, 230, 10, 230, 10, 230, 10, 230 }, 2021458, 2021499, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 0 },
             new byte[] { 210 }, 2021501, 2021501, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 0 },
             new byte[] { 210 }, 2021503, 2021503, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 0, 9, 126, 9, 46, 9, 46, 9, 46 },
             new byte[] { 210, 10, 210, 10, 210, 10, 210, 10, 210 }, 2021505, 2021513, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 0 },
             new byte[] { 160 }, 2021515, 2021515, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 0 },
             new byte[] { 160 }, 2021517, 2021517, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 0, 9, 106, 9, 16, 9, 16, 9, 16, 9, 176, 9, 176, 9, 176, 9, 76, 9, 16, 9, 16, 9, 16, 9, 96, 9, 96, 9, 96, 9, 56, 9, 16, 9, 16, 9, 16 },
             new byte[] { 160, 10, 160, 10, 160, 10, 160, 10, 160, 10, 95, 10, 95, 10, 95, 10, 95, 10, 95, 10, 95, 10, 95, 10, 35, 10, 35, 10, 35, 10, 35, 10, 35, 10, 35, 10, 35 }, 2021519, 2021555, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 21 },
             new byte[] { 241 }, 2021557, 2021557, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 21 },
             new byte[] { 241 }, 2021559, 2021559, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 21 },
             new byte[] { 241 }, 2021561, 2021561, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16 },
             new byte[] { 241 }, 2021563, 2021563, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16 },
             new byte[] { 241 }, 2021565, 2021565, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16 },
             new byte[] { 241 }, 2021567, 2021567, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16, 8, 227, 8, 227, 8, 227, 8, 227, 8, 227, 8, 227, 8, 227, 8, 152, 8, 152, 8, 152, 8, 152, 8, 152, 8, 152, 8, 152, 9, 196, 9, 196, 9, 196, 9, 196, 9, 196, 9, 196, 9, 196, 9, 196, 9, 196, 9, 196, 9, 196 },
             new byte[] { 241, 9, 196, 9, 196, 9, 196, 9, 196, 9, 196, 9, 196, 9, 196, 9, 116, 9, 116, 9, 116, 9, 116, 9, 116, 9, 116, 9, 116, 10, 240, 10, 240, 10, 240, 10, 240, 10, 240, 10, 240, 10, 240, 10, 240, 10, 240, 10, 240, 10, 240 }, 2021569, 2021619, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 130 },
             new byte[] { 240 }, 2021659, 2021659, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 130 },
             new byte[] { 240 }, 2021661, 2021661, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 130 },
             new byte[] { 240 }, 2021663, 2021663, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 130 },
             new byte[] { 240 }, 2021665, 2021665, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 130 },
             new byte[] { 240 }, 2021667, 2021667, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 130 },
             new byte[] { 240 }, 2021669, 2021669, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 130 },
             new byte[] { 240 }, 2021671, 2021671, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 140 },
             new byte[] { 250 }, 2021673, 2021673, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 140 },
             new byte[] { 250 }, 2021675, 2021675, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 140 },
             new byte[] { 250 }, 2021677, 2021677, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 140 },
             new byte[] { 250 }, 2021679, 2021679, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 140 },
             new byte[] { 250 }, 2021681, 2021681, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 140 },
             new byte[] { 250 }, 2021683, 2021683, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 140 },
             new byte[] { 250 }, 2021685, 2021685, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 120 },
             new byte[] { 230 }, 2021687, 2021687, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 120 },
             new byte[] { 230 }, 2021689, 2021689, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 120 },
             new byte[] { 230 }, 2021691, 2021691, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 120 },
             new byte[] { 230 }, 2021693, 2021693, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 120 },
             new byte[] { 230 }, 2021695, 2021695, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 120 },
             new byte[] { 230 }, 2021697, 2021697, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 120 },
             new byte[] { 230 }, 2021699, 2021699, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 100 },
             new byte[] { 210 }, 2021701, 2021701, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 100 },
             new byte[] { 210 }, 2021703, 2021703, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 100 },
             new byte[] { 210 }, 2021705, 2021705, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 100 },
             new byte[] { 210 }, 2021707, 2021707, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 100 },
             new byte[] { 210 }, 2021709, 2021709, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 100 },
             new byte[] { 210 }, 2021711, 2021711, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 100 },
             new byte[] { 210 }, 2021713, 2021713, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 50 },
             new byte[] { 160 }, 2021715, 2021715, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 50 },
             new byte[] { 160 }, 2021717, 2021717, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 50 },
             new byte[] { 160 }, 2021719, 2021719, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 50 },
             new byte[] { 160 }, 2021721, 2021721, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 50 },
             new byte[] { 160 }, 2021723, 2021723, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 50 },
             new byte[] { 160 }, 2021725, 2021725, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 50, 9, 241, 9, 241, 9, 241, 9, 241, 9, 241, 9, 241, 9, 241, 9, 181, 9, 181, 9, 181, 9, 181, 9, 181, 9, 181, 9, 181 },
             new byte[] { 160, 10, 95, 10, 95, 10, 95, 10, 95, 10, 95, 10, 95, 10, 95, 10, 35, 10, 35, 10, 35, 10, 35, 10, 35, 10, 35, 10, 35 }, 2021727, 2021755, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 131 },
             new byte[] { 241 }, 2021757, 2021757, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 131 },
             new byte[] { 241 }, 2021759, 2021759, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 131 },
             new byte[] { 241 }, 2021761, 2021761, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 131 },
             new byte[] { 241 }, 2021763, 2021763, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 131 },
             new byte[] { 241 }, 2021765, 2021765, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 131 },
             new byte[] { 241 }, 2021767, 2021767, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 131 },
             new byte[] { 241 }, 2021769, 2021769, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 86 },
             new byte[] { 196 }, 2021771, 2021771, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 86 },
             new byte[] { 196 }, 2021773, 2021773, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 86 },
             new byte[] { 196 }, 2021775, 2021775, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 86 },
             new byte[] { 196 }, 2021777, 2021777, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 86 },
             new byte[] { 196 }, 2021779, 2021779, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 86 },
             new byte[] { 196 }, 2021781, 2021781, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 86 },
             new byte[] { 196 }, 2021783, 2021783, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 6 },
             new byte[] { 116 }, 2021785, 2021785, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 6 },
             new byte[] { 116 }, 2021787, 2021787, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 6 },
             new byte[] { 116 }, 2021789, 2021789, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 6 },
             new byte[] { 116 }, 2021791, 2021791, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 6 },
             new byte[] { 116 }, 2021793, 2021793, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 6 },
             new byte[] { 116 }, 2021795, 2021795, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 6, 9, 196, 9, 196, 9, 196, 9, 196, 9, 196, 9, 196, 9, 196, 9, 196, 9, 196, 9, 196, 9, 196 },
             new byte[] { 116, 10, 240, 10, 240, 10, 240, 10, 240, 10, 240, 10, 240, 10, 240, 10, 240, 10, 240, 10, 240, 10, 240 }, 2021797, 2021819, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 130 },
             new byte[] { 240 }, 2021879, 2021879, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 130 },
             new byte[] { 240 }, 2021881, 2021881, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 130 },
             new byte[] { 240 }, 2021883, 2021883, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 130 },
             new byte[] { 240 }, 2021885, 2021885, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 130 },
             new byte[] { 240 }, 2021887, 2021887, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 130 },
             new byte[] { 240 }, 2021889, 2021889, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 130 },
             new byte[] { 240 }, 2021891, 2021891, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 140 },
             new byte[] { 250 }, 2021893, 2021893, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 140 },
             new byte[] { 250 }, 2021895, 2021895, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 140 },
             new byte[] { 250 }, 2021897, 2021897, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 140 },
             new byte[] { 250 }, 2021899, 2021899, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 140 },
             new byte[] { 250 }, 2021901, 2021901, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 140 },
             new byte[] { 250 }, 2021903, 2021903, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 140 },
             new byte[] { 250 }, 2021905, 2021905, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 120 },
             new byte[] { 230 }, 2021907, 2021907, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 120 },
             new byte[] { 230 }, 2021909, 2021909, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 120 },
             new byte[] { 230 }, 2021911, 2021911, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 120 },
             new byte[] { 230 }, 2021913, 2021913, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 120 },
             new byte[] { 230 }, 2021915, 2021915, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 120 },
             new byte[] { 230 }, 2021917, 2021917, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 120 },
             new byte[] { 230 }, 2021919, 2021919, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 100 },
             new byte[] { 210 }, 2021921, 2021921, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 100 },
             new byte[] { 210 }, 2021923, 2021923, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 100 },
             new byte[] { 210 }, 2021925, 2021925, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 100 },
             new byte[] { 210 }, 2021927, 2021927, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 100 },
             new byte[] { 210 }, 2021929, 2021929, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 100 },
             new byte[] { 210 }, 2021931, 2021931, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 100 },
             new byte[] { 210 }, 2021933, 2021933, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 50 },
             new byte[] { 160 }, 2021935, 2021935, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 50 },
             new byte[] { 160 }, 2021937, 2021937, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 50 },
             new byte[] { 160 }, 2021939, 2021939, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 50 },
             new byte[] { 160 }, 2021941, 2021941, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 50 },
             new byte[] { 160 }, 2021943, 2021943, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 50 },
             new byte[] { 160 }, 2021945, 2021945, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 50, 9, 241, 9, 241, 9, 241, 9, 241, 9, 241, 9, 241, 9, 241, 9, 181, 9, 181, 9, 181, 9, 181, 9, 181, 9, 181, 9, 181 },
             new byte[] { 160, 10, 95, 10, 95, 10, 95, 10, 95, 10, 95, 10, 95, 10, 95, 10, 35, 10, 35, 10, 35, 10, 35, 10, 35, 10, 35, 10, 35 }, 2021947, 2021975, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 131 },
             new byte[] { 241 }, 2021977, 2021977, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 131 },
             new byte[] { 241 }, 2021979, 2021979, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 131 },
             new byte[] { 241 }, 2021981, 2021981, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 131 },
             new byte[] { 241 }, 2021983, 2021983, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 131 },
             new byte[] { 241 }, 2021985, 2021985, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 131 },
             new byte[] { 241 }, 2021987, 2021987, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 131 },
             new byte[] { 241 }, 2021989, 2021989, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 86 },
             new byte[] { 196 }, 2021991, 2021991, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 86 },
             new byte[] { 196 }, 2021993, 2021993, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 86 },
             new byte[] { 196 }, 2021995, 2021995, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 86 },
             new byte[] { 196 }, 2021997, 2021997, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 86 },
             new byte[] { 196 }, 2021999, 2021999, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 86 },
             new byte[] { 196 }, 2022001, 2022001, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 86 },
             new byte[] { 196 }, 2022003, 2022003, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 6 },
             new byte[] { 116 }, 2022005, 2022005, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 6 },
             new byte[] { 116 }, 2022007, 2022007, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 6 },
             new byte[] { 116 }, 2022009, 2022009, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 6 },
             new byte[] { 116 }, 2022011, 2022011, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 6 },
             new byte[] { 116 }, 2022013, 2022013, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 6 },
             new byte[] { 116 }, 2022015, 2022015, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 6, 9, 196, 9, 196, 9, 196, 9, 196, 9, 196, 9, 196, 9, 196, 9, 196, 9, 196, 9, 196, 9, 196 },
             new byte[] { 116, 10, 240, 10, 240, 10, 240, 10, 240, 10, 240, 10, 240, 10, 240, 10, 240, 10, 240, 10, 240, 10, 240 }, 2022017, 2022039, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 4, 52, 4, 109, 4, 219 },
             new byte[] { 9, 136, 10, 59, 10, 70 }, 2022312, 2022317, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 4, 168, 5, 30, 5, 163 },
             new byte[] { 10, 51, 10, 160, 11, 14 }, 2022344, 2022349, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 5, 114, 6, 7, 6, 193 },
             new byte[] { 10, 82, 10, 194, 11, 54 }, 2022376, 2022381, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 6, 84, 7, 27, 7, 128 },
             new byte[] { 10, 90, 10, 214, 11, 94 }, 2022408, 2022413, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 7, 68, 7, 157, 7, 245 },
             new byte[] { 10, 85, 10, 230, 11, 84 }, 2022440, 2022445, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 7, 189, 8, 29, 9, 1 },
             new byte[] { 10, 91, 10, 220, 11, 64 }, 2022472, 2022477, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 8, 57, 9, 21, 9, 131 },
             new byte[] { 10, 90, 10, 180, 11, 34 }, 2022504, 2022509, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 9, 26, 9, 136, 9, 246 },
             new byte[] { 10, 59, 10, 119, 10, 229 }, 2022536, 2022541, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 9, 146, 9, 176, 9, 176 },
             new byte[] { 10, 10, 10, 70, 10, 180 }, 2022568, 2022573, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 96, 9, 96, 9, 96 },
             new byte[] { 194, 10, 0, 10, 110 }, 2022601, 2022605, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 21 },
             new byte[] { 154 }, 2022633, 2022633, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 21, 9, 21 },
             new byte[] { 216, 10, 70 }, 2022635, 2022637, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 8, 152, 8, 152, 8, 2 },
             new byte[] { 9, 122, 9, 186, 9, 186 }, 2022664, 2022669, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 97 },
             new byte[] { 212 }, 2022863, 2022863, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 102 },
             new byte[] { 212 }, 2022865, 2022865, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 136, 9, 206, 9, 216 },
             new byte[] { 206, 10, 65, 10, 65 }, 2022893, 2022897, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 0 },
             new byte[] { 102 }, 2022925, 2022925, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 50, 10, 50 },
             new byte[] { 160, 11, 14 }, 2022927, 2022929, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 32 },
             new byte[] { 137 }, 2022957, 2022957, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 85, 10, 90 },
             new byte[] { 200, 11, 54 }, 2022959, 2022961, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 40 },
             new byte[] { 157 }, 2022989, 2022989, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 105, 10, 130 },
             new byte[] { 235, 11, 89 }, 2022991, 2022993, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 35 },
             new byte[] { 172 }, 2023021, 2023021, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 120, 10, 120 },
             new byte[] { 230, 11, 84 }, 2023023, 2023025, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 41 },
             new byte[] { 147 }, 2023053, 2023053, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 110, 10, 100 },
             new byte[] { 210, 11, 64 }, 2023055, 2023057, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 39 },
             new byte[] { 117 }, 2023085, 2023085, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 70, 10, 70 },
             new byte[] { 175, 11, 29 }, 2023087, 2023089, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 10 },
             new byte[] { 65 }, 2023117, 2023117, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 10 },
             new byte[] { 125 }, 2023119, 2023119, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 10 },
             new byte[] { 235 }, 2023121, 2023121, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 9, 216, 9, 216, 9, 216 },
             new byte[] { 10, 5, 10, 65, 10, 175 }, 2023148, 2023153, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 146, 9, 146, 9, 146 },
             new byte[] { 194, 10, 0, 10, 110 }, 2023181, 2023185, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 106 },
             new byte[] { 154 }, 2023213, 2023213, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 106, 9, 106 },
             new byte[] { 216, 10, 70 }, 2023215, 2023217, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 76 },
             new byte[] { 117 }, 2023245, 2023245, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 76 },
             new byte[] { 181 }, 2023247, 2023247, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 76 },
             new byte[] { 181 }, 2023249, 2023249, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 14, 216, 11, 134, 5, 190 },
             new byte[] { 15, 60, 10, 240, 7, 8 }, 2053358, 2053363, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 18, 132, 15, 160, 9, 196, 6, 124, 0, 0 },
             new byte[] { 23, 112, 17, 148, 14, 26, 8, 172, 7, 8 }, 2053388, 2053397, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 22, 118, 18, 142, 14, 166, 10, 140, 7, 8, 0, 0, 0, 0 },
             new byte[] { 25, 0, 23, 212, 21, 54, 17, 88, 13, 242, 10, 60, 7, 8 }, 2053418, 2053431, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 26, 94, 23, 112, 19, 236, 17, 48, 14, 66, 10, 240, 5, 20, 0, 0, 0, 0 },
             new byte[] { 27, 148, 27, 148, 27, 148, 27, 148, 24, 156, 23, 212, 18, 82, 9, 56, 7, 8 }, 2053448, 2053465, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 30, 70 },
             new byte[] { 27, 148 }, 2053478, 2053479, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 88, 24, 6, 21, 24, 18, 242, 16, 54, 12, 28, 6, 64, 0, 0, 0, 0 },
             new byte[] { 148, 27, 148, 27, 148, 27, 148, 27, 148, 23, 212, 18, 202, 10, 30, 7, 8 }, 2053481, 2053497, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 32, 208, 30, 120 },
             new byte[] { 27, 148, 27, 148 }, 2053508, 2053511, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 238, 25, 0, 23, 12, 21, 24, 18, 92, 12, 178, 6, 64, 0, 0, 0, 0 },
             new byte[] { 148, 27, 148, 27, 148, 27, 148, 27, 148, 26, 204, 19, 96, 8, 172, 7, 8 }, 2053513, 2053529, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 34, 246, 32, 208, 30, 170, 28, 32, 26, 144, 25, 0, 23, 12, 18, 242, 11, 84, 5, 70, 0, 0, 0, 0 },
             new byte[] { 27, 148, 27, 148, 27, 148, 27, 148, 27, 148, 27, 148, 27, 148, 27, 148, 25, 160, 13, 242, 7, 208, 7, 8 }, 2053538, 2053561, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 36, 184, 35, 40, 32, 208, 30, 220, 29, 76, 27, 188, 26, 94, 22, 218, 17, 98, 10, 140, 5, 20, 0, 0, 0, 0, 0, 0, 0, 0 },
             new byte[] { 37, 28, 37, 28, 37, 28, 37, 28, 37, 28, 37, 28, 37, 28, 37, 28, 37, 28, 37, 28, 37, 28, 37, 28, 37, 28, 37, 28, 37, 28 }, 2053568, 2053597, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 36, 184, 34, 196, 32, 208, 31, 64, 29, 226, 28, 132, 25, 150, 21, 124, 15, 160, 9, 196, 3, 82, 0, 0, 0, 0, 0, 0 },
             new byte[] { 37, 28, 37, 28, 37, 28, 37, 28, 37, 28, 37, 28, 37, 28, 37, 28, 37, 28, 37, 28, 37, 28, 37, 28, 37, 28, 37, 28 }, 2053600, 2053627, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 35, 240, 34, 96, 32, 208, 31, 64, 30, 20, 27, 88, 24, 56, 19, 36, 12, 188, 6, 64, 0, 200, 0, 0, 0, 0 },
             new byte[] { 37, 28, 37, 28, 37, 28, 37, 28, 37, 28, 37, 28, 37, 28, 37, 28, 37, 28, 37, 28, 37, 28, 37, 28, 37, 28 }, 2053632, 2053657, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 36, 84, 34, 246, 33, 202, 32, 208, 29, 176, 27, 38, 23, 62, 16, 234, 10, 140, 2, 188, 0, 100, 0, 0 },
             new byte[] { 37, 28, 37, 28, 37, 28, 37, 28, 37, 28, 37, 28, 37, 28, 37, 28, 37, 28, 37, 28, 37, 28, 37, 28 }, 2053664, 2053687, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 36, 84, 35, 90, 34, 146, 31, 114, 29, 26, 25, 100, 19, 186, 14, 76, 5, 220, 1, 144, 0, 100 },
             new byte[] { 37, 28, 37, 28, 37, 28, 37, 28, 37, 28, 37, 28, 37, 28, 37, 28, 37, 28, 37, 28, 37, 28 }, 2053696, 2053717, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 34, 146, 31, 214, 28, 82, 24, 76, 20, 20, 12, 128, 7, 8, 1, 44 },
             new byte[] { 37, 28, 37, 28, 37, 28, 37, 28, 37, 28, 37, 28, 37, 28, 37, 28 }, 2053732, 2053747, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 36, 234, 34, 146, 31, 14, 27, 248, 23, 112, 17, 108, 12, 148, 5, 120 },
             new byte[] { 37, 28, 37, 28, 37, 28, 37, 28, 37, 28, 37, 28, 37, 28, 37, 28 }, 2053762, 2053777, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 33, 252, 30, 220, 26, 64, 21, 24 },
             new byte[] { 37, 28, 37, 28, 37, 28, 37, 28 }, 2053796, 2053803, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 42, 248, 46, 224, 50, 200 },
             new byte[] { 50, 200, 54, 176, 58, 152 }, 2071128, 2071133, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 42, 248, 46, 224, 50, 200 },
             new byte[] { 50, 200, 54, 176, 58, 152 }, 2071160, 2071165, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 42, 248, 46, 224, 50, 200 },
             new byte[] { 50, 200, 54, 176, 58, 152 }, 2071192, 2071197, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 42, 248, 46, 224, 50, 200 },
             new byte[] { 50, 200, 54, 176, 58, 152 }, 2071224, 2071229, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 42, 248, 46, 224, 50, 200 },
             new byte[] { 50, 200, 54, 176, 58, 152 }, 2071256, 2071261, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 42, 248, 46, 224, 50, 200 },
             new byte[] { 50, 200, 54, 176, 58, 152 }, 2071288, 2071293, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 42, 248, 46, 224, 50, 200 },
             new byte[] { 50, 200, 54, 176, 58, 152 }, 2071320, 2071325, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 42, 248, 46, 224, 50, 200 },
             new byte[] { 50, 200, 54, 176, 58, 152 }, 2071352, 2071357, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 12, 128, 15, 160, 18, 192 },
             new byte[] { 20, 83, 20, 84, 20, 85 }, 2071442, 2071447, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 80, 9, 227, 10, 171, 11, 115, 11, 215, 12, 159, 13, 103, 14, 47, 14, 247, 16, 135 },
             new byte[] { 86, 35, 40, 35, 40, 35, 40, 35, 40, 35, 40, 35, 40, 35, 40, 35, 40, 35, 40 }, 2071449, 2071467, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 12, 128, 15, 160, 18, 192 },
             new byte[] { 20, 83, 20, 84, 20, 85 }, 2071478, 2071483, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 80, 9, 227, 10, 171, 11, 115, 11, 215, 12, 159, 13, 103, 14, 47, 14, 247 },
             new byte[] { 86, 35, 40, 35, 40, 35, 40, 35, 40, 35, 40, 35, 40, 35, 40, 35, 40 }, 2071485, 2071501, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 38, 232, 40, 60, 41, 4 },
             new byte[] { 41, 14, 42, 98, 43, 42 }, 2074732, 2074737, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 27, 188, 29, 226, 32, 68, 35, 190, 38, 142, 40, 100, 42, 148, 44, 36 },
             new byte[] { 29, 226, 32, 8, 34, 106, 37, 228, 40, 180, 42, 138, 44, 186, 46, 74 }, 2074754, 2074769, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 29, 226, 32, 8, 34, 246, 38, 32, 40, 140, 42, 228, 45, 190, 46, 224 },
             new byte[] { 32, 8, 34, 46, 37, 28, 40, 70, 42, 178, 45, 10, 47, 228, 49, 6 }, 2074786, 2074801, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 33, 52, 35, 180, 38, 2, 41, 24, 43, 192, 46, 54, 47, 168, 50, 0 },
             new byte[] { 35, 90, 37, 218, 40, 40, 43, 62, 45, 230, 48, 92, 49, 206, 52, 38 }, 2074818, 2074833, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 34, 216, 37, 168, 40, 100, 42, 238, 44, 226, 47, 118, 49, 186, 50, 200, 53, 232 },
             new byte[] { 36, 254, 39, 206, 42, 138, 45, 20, 47, 8, 49, 156, 51, 224, 52, 238, 56, 14 }, 2074848, 2074865, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 40, 100, 42, 253, 45, 150, 48, 12, 49, 241, 51, 254, 54, 6, 55, 120, 58, 152 },
             new byte[] { 42, 138, 45, 35, 47, 188, 50, 50, 52, 23, 54, 36, 56, 44, 57, 158, 60, 190 }, 2074880, 2074897, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 43, 172, 45, 240, 48, 82, 50, 200, 53, 42, 55, 0, 56, 134, 58, 82, 59, 146, 62, 128 },
             new byte[] { 45, 210, 48, 22, 50, 120, 52, 238, 55, 80, 57, 38, 58, 172, 60, 120, 61, 184, 64, 166 }, 2074910, 2074929, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 46, 154, 49, 6, 51, 114, 53, 232, 55, 255, 57, 248, 60, 15, 62, 23, 64, 56, 66, 4 },
             new byte[] { 48, 192, 51, 44, 53, 152, 56, 14, 58, 37, 60, 30, 62, 53, 64, 61, 66, 94, 68, 42 }, 2074942, 2074961, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 49, 136, 52, 28, 54, 146, 57, 8, 58, 212, 60, 240, 63, 152, 65, 220, 69, 136, 69, 136 },
             new byte[] { 51, 174, 54, 66, 56, 184, 59, 46, 60, 250, 63, 22, 65, 190, 68, 2, 71, 174, 71, 174 }, 2074974, 2074993, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 51, 230, 55, 100, 57, 68, 59, 76, 61, 194, 63, 182, 67, 8, 70, 80, 70, 80, 70, 80 },
             new byte[] { 54, 12, 57, 138, 59, 106, 61, 114, 63, 232, 65, 220, 69, 46, 72, 118, 72, 118, 72, 118 }, 2075006, 2075025, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 51, 230, 55, 100, 57, 68, 59, 76, 61, 194, 63, 182, 67, 8, 70, 80, 70, 80, 70, 80 },
             new byte[] { 54, 12, 57, 138, 59, 106, 61, 114, 63, 232, 65, 220, 69, 46, 72, 118, 72, 118, 72, 118 }, 2075038, 2075057, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 41, 4, 41, 4, 41, 4 },
             new byte[] { 43, 42, 43, 42, 43, 42 }, 2076270, 2076275, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 39, 86, 43, 112, 43, 192, 43, 242, 43, 242, 43, 242, 43, 242, 43, 242 },
             new byte[] { 41, 124, 45, 150, 45, 230, 46, 24, 46, 24, 46, 24, 46, 24, 46, 24 }, 2076292, 2076307, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 41, 144, 45, 230, 46, 124, 46, 224, 46, 224, 46, 224, 46, 224, 46, 224 },
             new byte[] { 43, 182, 48, 12, 48, 162, 49, 6, 49, 6, 49, 6, 49, 6, 49, 6 }, 2076324, 2076339, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 42, 78, 48, 162, 49, 206, 49, 206, 49, 206, 49, 206, 49, 206, 49, 206 },
             new byte[] { 44, 116, 50, 200, 51, 244, 51, 244, 51, 244, 51, 244, 51, 244, 51, 244 }, 2076356, 2076371, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 37, 178, 42, 218, 47, 238, 49, 86, 50, 86, 52, 81, 53, 182, 53, 182, 53, 182 },
             new byte[] { 39, 216, 45, 0, 50, 20, 51, 124, 52, 124, 54, 119, 55, 220, 55, 220, 55, 220 }, 2076386, 2076403, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 36, 144, 42, 98, 48, 2, 50, 170, 52, 45, 57, 212, 58, 152, 58, 152, 58, 152 },
             new byte[] { 38, 182, 44, 136, 50, 40, 52, 208, 54, 83, 59, 250, 60, 190, 60, 190, 60, 190 }, 2076418, 2076435, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 32, 238, 36, 104, 42, 8, 48, 82, 51, 154, 54, 3, 60, 54, 62, 128, 62, 128, 62, 128 },
             new byte[] { 35, 20, 38, 142, 44, 46, 50, 120, 53, 192, 56, 41, 62, 92, 64, 166, 64, 166, 64, 166 }, 2076448, 2076467, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 33, 152, 36, 184, 42, 78, 48, 205, 52, 35, 55, 120, 62, 38, 66, 4, 66, 4, 66, 4 },
             new byte[] { 35, 190, 38, 222, 44, 116, 50, 243, 54, 73, 57, 158, 64, 76, 68, 42, 68, 42, 68, 42 }, 2076480, 2076499, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 34, 46, 37, 178, 43, 21, 49, 83, 52, 35, 57, 158, 65, 210, 69, 86, 69, 86, 69, 86 },
             new byte[] { 36, 84, 39, 216, 45, 59, 51, 121, 54, 73, 59, 196, 67, 248, 71, 124, 71, 124, 71, 124 }, 2076512, 2076531, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 35, 40, 39, 16, 44, 81, 50, 227, 53, 139, 63, 72, 70, 55, 70, 80, 70, 80, 70, 80 },
             new byte[] { 37, 78, 41, 54, 46, 119, 53, 9, 55, 177, 65, 110, 72, 93, 72, 118, 72, 118, 72, 118 }, 2076544, 2076563, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 36, 34, 40, 10, 45, 112, 52, 48, 55, 213, 70, 80, 70, 80, 70, 80, 70, 80, 70, 80 },
             new byte[] { 38, 72, 42, 48, 47, 150, 54, 86, 57, 251, 72, 118, 72, 118, 72, 118, 72, 118, 72, 118 }, 2076576, 2076595, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 46, 224, 46, 224, 46, 224, 46, 224, 70, 80, 70, 80, 70, 80, 70, 80, 70, 80, 70, 80, 70, 80, 70, 80, 70, 80, 70, 80, 70, 80, 70, 80, 70, 80, 70, 80, 70, 80, 70, 80, 23, 112, 23, 112, 23, 112, 23, 112 },
             new byte[] { 49, 6, 49, 6, 49, 6, 49, 6, 72, 118, 72, 118, 72, 118, 72, 118, 72, 118, 72, 118, 72, 118, 72, 118, 72, 118, 72, 118, 72, 118, 72, 118, 72, 118, 72, 118, 72, 118, 72, 118, 25, 150, 25, 150, 25, 150, 25, 150 }, 2077026, 2077073, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 26, 94, 22, 68, 21, 114 },
             new byte[] { 28, 132, 24, 106, 23, 152 }, 2082578, 2082583, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 25, 170, 21, 204, 20, 190, 18, 72 },
             new byte[] { 27, 208, 23, 242, 22, 228, 20, 110 }, 2082600, 2082607, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 12, 155 },
             new byte[] { 13, 72 }, 2082610, 2082611, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 24, 156, 20, 100, 19, 86, 17, 108, 14, 103, 11, 144, 8, 202, 7, 188 },
             new byte[] { 26, 194, 22, 138, 21, 124, 19, 146, 16, 141, 13, 182, 9, 196, 8, 202 }, 2082622, 2082637, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 23, 52, 18, 162, 17, 148, 16, 44, 13, 39, 10, 87, 7, 128, 6, 144 },
             new byte[] { 25, 90, 20, 200, 19, 186, 18, 82, 15, 77, 12, 125, 9, 166, 8, 202 }, 2082644, 2082659, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 21, 114, 16, 224, 15, 210, 14, 196, 11, 134, 8, 245, 6, 64, 5, 70 },
             new byte[] { 23, 152, 19, 6, 17, 248, 16, 234, 13, 172, 11, 27, 8, 102, 7, 108 }, 2082666, 2082681, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 19, 186, 15, 10, 14, 16, 13, 92, 9, 196, 7, 135, 4, 226, 3, 222 },
             new byte[] { 21, 224, 17, 48, 16, 54, 15, 130, 11, 234, 9, 173, 7, 8, 6, 4 }, 2082688, 2082703, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 199, 243, 252, 233, 123, 222, 142, 140, 66, 6, 21, 173, 184, 81, 210, 47, 57, 97, 255, 8, 60, 25, 81, 191, 21, 68, 12, 69, 201, 207, 114, 83, 148, 109, 118, 214, 140, 121, 204, 50, 194, 186, 139, 169, 46, 160, 132, 67, 222, 205, 171, 83, 28, 201, 217, 53, 226, 166, 97, 204, 162, 70, 128, 214, 30, 120, 182, 240, 118, 204, 108, 194, 140, 202, 254, 148, 198, 151, 56, 142, 74, 109, 134, 134, 234, 15, 146, 106, 146, 151, 29, 253, 3, 177, 58, 213, 97, 201, 56, 234, 187, 203, 167, 162, 231, 121, 155, 187, 84, 169, 15, 68, 71, 233, 0, 115, 72, 63, 8, 51, 21, 44, 93, 137, 219, 202, 140, 50, 117, 41, 211, 165, 206, 230, 252, 244 },
             new byte[] { 67, 55, 86, 99, 163, 166, 174, 3, 139, 225, 235, 103, 30, 104, 230, 27, 4, 35, 221, 79, 201, 38, 241, 16, 69, 71, 220, 245, 189, 139, 250, 16, 189, 10, 83, 101, 19, 22, 19, 67, 93, 32, 29, 145, 244, 87, 161, 183, 22, 116, 254, 233, 22, 235, 131, 30, 81, 248, 99, 218, 215, 106, 68, 70, 83, 228, 73, 189, 21, 34, 250, 253, 154, 212, 166, 102, 109, 232, 215, 31, 52, 84, 93, 140, 47, 87, 217, 214, 149, 34, 223, 128, 213, 51, 30, 149, 163, 40, 147, 131, 82, 199, 160, 194, 126, 239, 108, 225, 233, 11, 181, 133, 91, 255, 43, 56, 21, 31, 170, 168, 16, 91, 152, 117, 190, 10, 51, 222, 164, 178, 18, 129, 23, 139, 162, 235 }, 2088824, 2088959, "Found egr map...Delete map");
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