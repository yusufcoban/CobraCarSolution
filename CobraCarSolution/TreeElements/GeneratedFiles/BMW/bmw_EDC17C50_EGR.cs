using System.Collections.Generic;
using System.Threading.Tasks;

using ToolBoxNameSpace;

namespace CobraCarSolution.TreeElements.VAG
{
    class BMW_EDC17C50 : MenuItem, ITreeItem
    {
        public BMW_EDC17C50()
        {
            Title = "EDC17C50";
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
            FileSizeArray = new int[] { 0 };
        }

        public override async Task<bool> checkFileForEgr()
        {
            bool validationEgrInFile = true;
            //Algo for checking dpf solution
            if (ToolBox.array.Length > 0)
            {
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 230 }, 3151555);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 230 }, 3151563);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 230 }, 3151571);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 230 }, 3151579);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 230 }, 3151587);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 230 }, 3151595);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 230 }, 3151603);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 230 }, 3151611);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 230 }, 3151619);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 218 }, 3151627);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 203 }, 3151635);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 187 }, 3151643);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 171 }, 3151651);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 155 }, 3151659);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 230 }, 3151691);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 230 }, 3151699);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 230 }, 3151707);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 230 }, 3151715);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 230 }, 3151723);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 230 }, 3151731);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 230 }, 3151739);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 230 }, 3151747);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 230 }, 3151755);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 218 }, 3151763);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 203 }, 3151771);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 187 }, 3151779);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 171 }, 3151787);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 155 }, 3151795);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 200, 11, 200, 11, 200, 11, 40, 10, 128, 12, 128, 12, 128, 12, 40, 10, 128, 12, 128, 12, 128, 12, 40, 10, 128, 12, 128, 12, 128, 12, 40, 10, 128, 12, 128, 12, 128, 12, 40, 10, 108, 12, 108, 12, 108, 12, 40, 10, 254, 11, 234, 11, 254, 11, 191, 9, 139, 11, 71, 11, 139, 11, 85, 9, 14, 11, 150, 10, 14, 11, 212, 8, 170, 10, 236, 9, 170, 10, 102, 8, 40, 10, 86, 9, 40, 10, 238, 7, 212, 8, 32, 8, 212, 8, 250, 5, 128, 7, 128, 7, 128, 7, 36 }, 3151954);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 220, 5, 220, 5, 220, 5, 8 }, 3152058);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 252, 3, 252, 3, 252, 3 }, 3152066);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 234, 1, 234, 1, 234, 1 }, 3152074);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16, 14 }, 3468270);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16, 14 }, 3468286);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16, 14 }, 3468302);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16, 14 }, 3468318);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16, 14 }, 3468334);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16, 14 }, 3468350);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16, 14 }, 3468366);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16, 14 }, 3468382);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 6, 14 }, 3468398);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 240, 12, 83, 13 }, 3468412);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16, 12, 102, 12 }, 3468428);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 63, 11, 113, 11 }, 3468444);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 119, 10, 119, 10 }, 3468460);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 125, 9, 125, 9 }, 3468476);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16, 14 }, 3468542);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16, 14 }, 3468558);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16, 14 }, 3468574);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16, 14 }, 3468590);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16, 14 }, 3468606);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16, 14 }, 3468622);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 73 }, 3468636);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16, 14 }, 3468638);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 212, 12, 16, 14 }, 3468652);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 99, 12, 6, 14 }, 3468668);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 141, 11, 83, 13 }, 3468684);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 197, 10, 102, 12 }, 3468700);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 10, 10, 113, 11 }, 3468716);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 93, 9, 119, 10 }, 3468732);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 187, 8, 125, 9 }, 3468748);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 90, 10, 246, 9, 196, 9, 96, 9, 152, 8, 52, 8, 108, 7, 170, 5 }, 3589574);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 190, 10, 128, 12, 228, 12, 220, 5, 244, 1 }, 3589610);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 190, 10, 208, 7, 96, 9, 240, 10, 234, 11 }, 3589644);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 190, 10, 128, 12, 116, 14, 16, 14, 22, 13 }, 3589678);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 52, 8, 158, 7, 108, 7, 108, 7, 164, 6, 120, 5, 188, 2 }, 3589752);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 210, 15, 210, 15, 206, 14, 16, 14, 102, 13, 208, 12, 190, 10, 2, 8, 210, 15, 210, 15, 206, 14, 16, 14, 102, 13, 208, 12, 190, 10, 2, 8, 210, 15, 210, 15, 206, 14, 16, 14, 102, 13, 208, 12, 190, 10, 2, 8, 210, 15, 210, 15, 206, 14, 16, 14, 102, 13, 208, 12, 190, 10, 2, 8, 210, 15, 210, 15, 206, 14, 16, 14, 102, 13, 208, 12, 190, 10, 2, 8, 210, 15, 210, 15, 206, 14, 16, 14, 1, 13, 208, 12, 190, 10, 2, 8, 168, 15, 188, 15, 206, 14, 16, 14, 168, 12, 171, 12, 140, 10, 2, 8, 100, 15, 153, 15, 181, 14, 16, 14, 88, 12, 98, 12, 231, 9, 248, 7, 18, 15, 83, 15, 119, 14, 245, 13, 18, 12, 31, 12, 146, 9, 233, 7, 197, 13, 252, 13, 89, 13, 60, 13, 87, 11, 87, 11, 49, 9, 198, 7, 140, 13, 187, 13, 27, 13, 241, 12, 52, 11, 57, 11, 41, 9, 188, 7, 173, 12, 246, 12, 53, 12, 199, 11, 225, 10, 215, 10, 230, 8, 133, 7, 53, 12, 143, 12, 159, 11, 14, 11, 133, 10, 118, 10, 162, 8, 66, 7 }, 3589916);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 72, 8, 72, 8, 35, 7, 187, 5, 229, 4, 106, 4, 29, 4, 225, 3, 139, 3, 160, 10, 160, 10, 125, 7, 4, 6, 73, 5, 0, 5, 169, 4, 86, 4, 239, 3, 72, 13, 72, 13, 45, 8, 227, 5, 143, 4, 13, 4, 209, 3, 152, 3, 72, 3, 106, 14, 106, 14, 170, 10, 9, 8, 167, 6, 247, 5, 127, 5, 33, 5, 163, 4, 216, 14, 216, 14, 64, 11, 159, 8, 61, 7, 131, 6, 243, 5, 120, 5, 7, 5, 216, 14, 216, 14, 47, 11, 155, 8, 95, 7, 157, 6, 17, 6, 147, 5, 27, 5, 46, 14, 46, 14, 234, 10, 245, 7, 118, 6, 214, 5, 97, 5, 240, 4, 93, 4, 212, 13, 212, 13, 134, 10, 154, 7, 55, 6, 196, 5, 111, 5, 35, 5, 181, 4, 22, 13, 22, 13, 33, 10, 105, 7, 232, 5, 109, 5, 4, 5, 170, 4, 57, 4, 98, 12, 98, 12, 13, 10, 245, 7, 71, 6, 147, 5, 47, 5, 216, 4, 116, 4, 64, 11, 64, 11, 109, 8, 37, 6, 146, 4, 3, 4, 202, 3, 149, 3, 105, 3, 122, 8, 122, 8, 107, 6, 7, 5, 136, 4, 26, 4, 215, 3, 132, 3, 65, 3 }, 3590224);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 184, 11, 184, 11, 184, 11, 184, 11, 184, 11, 184, 11, 184, 11, 184, 11, 115, 10, 232, 3 }, 3591480);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 26, 14, 26, 14, 26, 14, 26, 14, 46, 14, 46, 14, 46, 14, 46, 14, 46, 14, 46, 14, 46, 14, 46, 14, 46, 14, 46, 14, 46, 14, 46, 14, 115, 13, 115, 13, 115, 13, 115, 13, 26, 13, 26, 13, 26, 13, 26, 13, 191, 12, 191, 12, 191, 12, 191, 12, 90, 12, 90, 12, 90, 12, 90, 12, 20, 12, 20, 12, 20, 12, 20, 12, 159, 11, 159, 11, 159, 11, 159, 11, 33, 11, 33, 11, 33, 11, 33, 11, 140, 10, 140, 10, 140, 10, 140, 10, 66, 9, 66, 9, 66, 9, 66, 9, 188, 7, 188, 7, 188, 7, 188, 7, 230, 5, 230, 5, 230, 5, 230, 5, 232, 3, 232, 3, 232, 3, 232, 3, 188, 2, 188, 2, 188, 2, 188, 2 }, 3591624);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16, 14, 72, 13, 72, 13, 72, 13, 178, 10, 196, 9 }, 3591894);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 66, 9, 52, 8, 230, 5, 232, 3, 188, 2 }, 3591960);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 247, 39 }, 3594400);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 163 }, 3710830);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16 }, 3710832);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 128 }, 3710834);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 241, 7, 87 }, 3710836);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 183, 8, 16 }, 3710840);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 114 }, 3710844);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224, 9, 70 }, 3710846);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 170, 10, 20 }, 3710850);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 124, 11, 227, 11, 78 }, 3710854);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 181, 12, 32 }, 3710860);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 145, 13, 242, 13, 71 }, 3710864);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 176, 14, 145, 15, 104, 16 }, 3710870);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 58 }, 3710910);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 169 }, 3710912);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 15 }, 3710914);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 113 }, 3710916);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 212, 7, 55 }, 3710918);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 157, 8, 242, 8, 71 }, 3710922);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 163, 9, 0 }, 3710928);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 98 }, 3710932);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 195, 10, 42 }, 3710934);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 139, 11, 227, 11, 73 }, 3710938);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 183, 12, 20 }, 3710944);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 112, 13, 212, 13, 159, 14, 108, 15 }, 3710948);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 228, 5, 63 }, 3710990);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 166 }, 3710994);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 4 }, 3710996);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 97 }, 3710998);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 184, 7, 29 }, 3711000);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 134 }, 3711004);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 231, 8, 56 }, 3711006);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 136, 9, 221, 9, 50 }, 3711010);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 138, 10, 233, 10, 67 }, 3711016);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 154, 11, 244, 11, 85 }, 3711022);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 188, 12, 34 }, 3711028);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 237, 13, 166, 14 }, 3711032);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 176 }, 3711070);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 250, 5, 77 }, 3711072);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 164 }, 3711076);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 249, 6, 83 }, 3711078);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 173, 7, 10 }, 3711082);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 107 }, 3711086);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 200, 8, 28 }, 3711088);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 108 }, 3711092);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 189, 9, 18 }, 3711094);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 103 }, 3711098);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 185, 10, 7 }, 3711100);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 86 }, 3711104);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 166, 11, 0 }, 3711106);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 93 }, 3711110);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 37 }, 3711112);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 232, 13 }, 3711114);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 108 }, 3711150);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 189, 5, 8 }, 3711152);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 86 }, 3711156);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 162 }, 3711158);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 242, 6, 73 }, 3711160);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 163, 7, 250, 7, 83 }, 3711164);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 166, 8, 247, 8, 68 }, 3711170);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 146, 9, 224, 9, 48 }, 3711176);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 125, 10, 195, 10, 12 }, 3711182);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 91 }, 3711188);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 179, 11, 101, 12, 72 }, 3711190);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 67 }, 3711230);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 139 }, 3711232);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 202, 5, 15 }, 3711234);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 85 }, 3711238);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 163 }, 3711240);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 244, 6, 72 }, 3711242);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 153 }, 3711246);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 232, 7, 62 }, 3711248);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 143 }, 3711252);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 215, 8, 29 }, 3711254);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 104 }, 3711258);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 177, 9, 249, 9, 60 }, 3711260);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 133, 10, 210, 10, 37 }, 3711266);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 204, 11, 178, 12 }, 3711272);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 251, 4, 68 }, 3711310);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 139 }, 3711314);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 215, 5, 22 }, 3711316);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 91 }, 3711320);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 166 }, 3711322);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 243, 6, 70 }, 3711324);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 147 }, 3711328);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 222, 7, 44 }, 3711330);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 122 }, 3711334);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 188, 8, 255, 8, 76 }, 3711336);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 144, 9, 216, 9, 25 }, 3711342);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 100 }, 3711348);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 180, 10, 89 }, 3711350);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 33 }, 3711354);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 177 }, 3711390);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 249, 4, 68 }, 3711392);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 149 }, 3711396);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 225, 5, 36 }, 3711398);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 115 }, 3711402);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 184, 6, 250, 6, 71 }, 3711404);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 140 }, 3711410);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 208, 7, 19 }, 3711412);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 79 }, 3711416);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 145 }, 3711418);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 210, 8, 21 }, 3711420);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 88 }, 3711424);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 156, 9, 229, 9, 55 }, 3711426);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 218, 10, 132, 11 }, 3711432);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 168, 97, 156, 99, 168, 97, 8, 82, 216, 89, 192, 93 }, 3714808);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 92, 204, 91, 88, 77, 252, 83, 4, 91, 100, 100, 124, 96, 96, 84, 16, 89, 240, 85 }, 3714821);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 155 }, 3778028);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 197 }, 3778030);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 250, 3, 35 }, 3778032);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 88 }, 3778036);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 148 }, 3778038);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 207, 4, 11 }, 3778040);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 70 }, 3778044);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 70 }, 3778046);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 70 }, 3778048);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 70 }, 3778050);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 70 }, 3778052);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 70 }, 3778054);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 0 }, 3778060);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 39 }, 3778062);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 80 }, 3778064);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 159 }, 3778066);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 244, 4, 56 }, 3778068);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 124 }, 3778072);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 192, 5, 4 }, 3778074);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 47 }, 3778078);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 91 }, 3778080);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 91 }, 3778082);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 91 }, 3778084);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 91 }, 3778086);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 94 }, 3778092);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 119 }, 3778094);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 156 }, 3778096);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16 }, 3778098);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 110 }, 3778100);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224, 5, 82 }, 3778102);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 195, 6, 53 }, 3778106);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 61 }, 3778110);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 61 }, 3778112);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 61 }, 3778114);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 61 }, 3778116);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 61 }, 3778118);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 126 }, 3778124);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 183 }, 3778126);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 15 }, 3778128);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 185, 5, 24 }, 3778130);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 200, 6, 77 }, 3778134);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 176, 7, 228, 7, 228, 7, 228, 7, 228, 7, 228, 7, 228, 7 }, 3778138);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 131 }, 3778156);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 3 }, 3778158);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 140 }, 3778160);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 41 }, 3778162);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 197, 6, 91 }, 3778164);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 223, 7, 228, 7, 228, 7, 228, 7, 228, 7, 228, 7, 228, 7, 228, 7 }, 3778168);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 176 }, 3778188);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 39 }, 3778190);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 215, 5, 132 }, 3778192);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 35 }, 3778196);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 160, 7, 228, 7, 228, 7, 228, 7, 228, 7, 228, 7, 228, 7, 228, 7, 228, 7 }, 3778198);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 226, 4, 88 }, 3778220);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 35 }, 3778224);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 227, 6, 108 }, 3778226);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 208, 7, 228, 7, 228, 7, 228, 7, 228, 7, 228, 7, 228, 7, 228, 7, 228, 7 }, 3778230);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 246, 4, 115 }, 3778252);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 46 }, 3778256);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224, 6, 93 }, 3778258);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 188, 7, 228, 7, 228, 7, 228, 7, 228, 7, 228, 7, 228, 7, 228, 7, 228, 7 }, 3778262);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 0 }, 3778284);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 132 }, 3778286);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 56 }, 3778288);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 213, 6, 66 }, 3778290);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 168, 7, 208, 7, 208, 7, 208, 7, 208, 7, 208, 7, 208, 7, 208, 7, 208, 7 }, 3778294);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 0 }, 3778316);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 170 }, 3778318);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 94 }, 3778320);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224, 6, 88 }, 3778322);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 148, 7, 158, 7, 158, 7, 158, 7, 158, 7, 158, 7, 158, 7, 158, 7, 158, 7 }, 3778326);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 211, 4, 170 }, 3778348);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 104 }, 3778352);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 18 }, 3778354);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 158, 7, 158, 7, 158, 7, 158, 7, 158, 7, 158, 7, 158, 7, 158, 7, 158, 7, 158, 7 }, 3778356);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 166 }, 3778380);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 140 }, 3778382);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 124 }, 3778384);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 204, 6, 254, 6, 254, 6, 254, 6, 254, 6, 254, 6, 254, 6, 254, 6, 254, 6, 254, 6, 254, 6 }, 3778386);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 149 }, 3778412);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 123 }, 3778414);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 108 }, 3778416);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 161, 6, 224, 6, 224, 6, 224, 6, 224, 6, 224, 6, 224, 6, 224, 6, 224, 6, 224, 6, 224, 6 }, 3778418);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 153 }, 3778608);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 211, 4, 7 }, 3778610);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 85 }, 3778614);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 191, 5, 38 }, 3778616);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 124 }, 3778620);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 219, 6, 48 }, 3778622);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 118 }, 3778626);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 158, 7, 198, 7, 208, 7, 208, 7 }, 3778628);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 191 }, 3778640);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 4 }, 3778642);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 119 }, 3778644);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 232, 5, 91 }, 3778646);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 213, 6, 58 }, 3778650);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 188, 7, 60 }, 3778654);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 112, 8, 152, 8, 192, 8, 192, 8, 192, 8 }, 3778658);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 236, 4, 99 }, 3778672);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 230, 5, 119 }, 3778676);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 244, 6, 106 }, 3778680);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 253, 7, 132, 8, 197, 8, 228, 8, 232, 8, 232, 8, 232, 8, 232, 8 }, 3778684);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 17 }, 3778704);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 168 }, 3778706);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 73 }, 3778708);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 254, 6, 151, 7, 7 }, 3778710);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 124, 8, 243, 8, 16 }, 3778716);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16 }, 3778722);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16 }, 3778724);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16 }, 3778726);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16 }, 3778728);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16 }, 3778730);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 50 }, 3778736);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 231, 5, 150 }, 3778738);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 67 }, 3778742);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 231, 7, 102 }, 3778744);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 183, 8, 16 }, 3778748);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16 }, 3778752);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16 }, 3778754);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16 }, 3778756);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16 }, 3778758);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16 }, 3778760);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16 }, 3778762);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 178 }, 3778768);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 71 }, 3778770);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 198, 6, 68 }, 3778772);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 231, 7, 142, 8, 194, 8, 16 }, 3778776);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16 }, 3778784);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16 }, 3778786);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16 }, 3778788);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16 }, 3778790);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16 }, 3778792);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16 }, 3778794);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 3 }, 3778800);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 145 }, 3778802);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 236, 6, 52 }, 3778804);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 226, 7, 142, 8, 211, 8, 16 }, 3778808);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16 }, 3778816);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16 }, 3778818);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16 }, 3778820);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16 }, 3778822);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16 }, 3778824);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16 }, 3778826);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 34 }, 3778832);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 162 }, 3778834);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 232, 6, 51 }, 3778836);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 226, 7, 142, 8, 245, 8, 16 }, 3778840);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16 }, 3778848);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16 }, 3778850);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16 }, 3778852);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16 }, 3778854);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16 }, 3778856);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16 }, 3778858);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 4 }, 3778864);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 140 }, 3778866);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 205, 6, 8 }, 3778868);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 226, 7, 142, 8, 14 }, 3778872);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16 }, 3778878);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16 }, 3778880);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16 }, 3778882);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16 }, 3778884);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16 }, 3778886);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16 }, 3778888);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16 }, 3778890);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 227, 5, 96 }, 3778896);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 185, 6, 8 }, 3778900);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 226, 7, 142, 8, 15 }, 3778904);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16 }, 3778910);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16 }, 3778912);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16 }, 3778914);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16 }, 3778916);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16 }, 3778918);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16 }, 3778920);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16 }, 3778922);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 190, 5, 28 }, 3778928);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 164, 6, 8 }, 3778932);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 208, 7, 142, 8, 6 }, 3778936);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 6 }, 3778942);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 6 }, 3778944);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 6 }, 3778946);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 6 }, 3778948);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 6 }, 3778950);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 6 }, 3778952);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 6 }, 3778954);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 190, 5, 210, 5, 164, 6, 8 }, 3778960);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 208, 7, 142, 8, 172, 8, 172, 8, 172, 8, 172, 8, 172, 8, 172, 8, 172, 8, 172, 8 }, 3778968);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 190, 5, 210, 5, 164, 6, 8 }, 3778992);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 208, 7, 208, 7, 208, 7, 208, 7, 208, 7, 208, 7, 208, 7, 208, 7, 208, 7, 208, 7 }, 3779000);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 111 }, 3779296);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 201, 4, 190, 5, 39 }, 3779298);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 104 }, 3779304);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 124 }, 3779306);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 139 }, 3779308);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 204, 6, 234, 6, 158, 7, 228, 7, 228, 7 }, 3779310);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 146 }, 3779322);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 40 }, 3779324);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 220, 5, 134 }, 3779326);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 249, 6, 56 }, 3779330);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 98 }, 3779334);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 118 }, 3779336);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 138, 7, 2 }, 3779338);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 222, 8, 222, 8 }, 3779342);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 226, 4, 105 }, 3779348);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 245, 5, 144 }, 3779352);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 38 }, 3779356);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 103 }, 3779358);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 148, 7, 162, 7, 238, 7, 67 }, 3779360);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 6 }, 3779368);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 6 }, 3779370);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 5 }, 3779374);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 120 }, 3779376);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 14 }, 3779378);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 179, 6, 121 }, 3779380);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 157, 7, 218, 7, 253, 7, 27 }, 3779384);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 162, 8, 46 }, 3779392);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 46 }, 3779396);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 34 }, 3779400);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 145 }, 3779402);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 37 }, 3779404);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 244, 6, 148, 7, 240, 7, 4 }, 3779406);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 27 }, 3779414);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 102, 8, 202, 8, 51 }, 3779416);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 51 }, 3779422);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 42 }, 3779426);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 155 }, 3779428);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 44 }, 3779430);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 254, 6, 168, 7, 42 }, 3779432);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 52 }, 3779438);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 112, 8, 137, 8, 26 }, 3779440);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 56 }, 3779446);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 56 }, 3779448);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 57 }, 3779452);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 4 }, 3779454);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 126 }, 3779456);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 88 }, 3779458);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 220, 7, 82 }, 3779460);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 122, 8, 152, 8, 167, 8, 36 }, 3779464);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 61 }, 3779472);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 61 }, 3779474);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 96 }, 3779478);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 34 }, 3779480);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 179, 6, 153, 7, 52 }, 3779482);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 97 }, 3779488);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 127, 8, 162, 8, 182, 8, 66 }, 3779490);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 66 }, 3779498);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 66, 9 }, 3779500);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 184, 5, 101 }, 3779504);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 8 }, 3779508);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 223, 7, 92 }, 3779510);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 112 }, 3779514);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 132, 8, 172, 8, 232, 8, 96, 9, 96, 9, 96, 9 }, 3779516);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 208, 5, 114 }, 3779530);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 64 }, 3779534);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 12 }, 3779536);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 102 }, 3779538);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 117 }, 3779540);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 134, 8, 177, 8, 46 }, 3779542);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 66 }, 3779548);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 66 }, 3779550);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 66, 9 }, 3779552);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 204, 5, 170, 6, 66 }, 3779556);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 52 }, 3779562);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 117 }, 3779564);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 130, 8, 152, 8, 202, 8, 61 }, 3779566);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 61 }, 3779574);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 61 }, 3779576);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 61 }, 3779578);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 204, 5, 170, 6, 66 }, 3779582);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 52 }, 3779588);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 117 }, 3779590);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 130, 8, 152, 8, 202, 8, 252, 8, 252, 8, 252, 8, 252, 8 }, 3779592);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 126 }, 3779876);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 252, 4, 117 }, 3779878);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 248, 5, 119 }, 3779882);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 134 }, 3779886);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 139 }, 3779888);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 219, 6, 43 }, 3779890);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 188, 7, 228, 7, 228, 7 }, 3779894);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 161 }, 3779902);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 20 }, 3779904);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224, 5, 86 }, 3779906);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 235, 6, 66 }, 3779910);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 106 }, 3779914);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 140, 7, 173, 7, 182, 8, 222, 8, 222, 8 }, 3779916);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 196, 4, 70 }, 3779928);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 244, 5, 134 }, 3779932);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 51 }, 3779936);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 103 }, 3779938);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 149, 7, 188, 7, 7 }, 3779940);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 6 }, 3779946);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 6 }, 3779948);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 6 }, 3779950);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 0 }, 3779954);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 110 }, 3779956);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 15 }, 3779958);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 178, 6, 121 }, 3779960);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 157, 7, 223, 7, 2 }, 3779964);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 82 }, 3779970);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 36 }, 3779972);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 46 }, 3779974);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 46 }, 3779976);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 10 }, 3779980);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 120 }, 3779982);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 37 }, 3779984);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 209, 6, 153, 7, 220, 7, 4 }, 3779986);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 88 }, 3779994);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 172, 8, 46 }, 3779996);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 51 }, 3780000);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 51 }, 3780002);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 20 }, 3780006);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 154 }, 3780008);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 76 }, 3780010);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 252, 6, 166, 7, 42 }, 3780012);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 67 }, 3780018);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 142, 8, 222, 8, 53 }, 3780020);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 56 }, 3780026);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 56 }, 3780028);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 50 }, 3780032);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 190, 5, 126 }, 3780034);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 65 }, 3780038);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 220, 7, 96 }, 3780040);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 152, 8, 197, 8, 26 }, 3780044);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 61 }, 3780050);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 61 }, 3780052);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 61 }, 3780054);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 70 }, 3780058);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 205, 5, 217, 6, 162, 7, 66 }, 3780060);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 127, 8, 200, 8, 252, 8, 36 }, 3780068);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 66 }, 3780076);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 66 }, 3780078);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 66, 9 }, 3780080);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 120 }, 3780084);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 250, 5, 8 }, 3780086);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 223, 7, 118 }, 3780090);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 142, 8, 147, 8, 222, 8, 41 }, 3780094);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 86, 9, 86, 9, 86, 9 }, 3780102);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 120 }, 3780110);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 44 }, 3780112);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 58 }, 3780114);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 17 }, 3780116);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 137, 8, 145, 8, 155, 8, 230, 8, 66 }, 3780118);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 66 }, 3780128);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 66 }, 3780130);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 66, 9 }, 3780132);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 120 }, 3780136);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 114 }, 3780138);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 108 }, 3780140);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 52 }, 3780142);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 141, 8, 152, 8, 178, 8, 251, 8, 61 }, 3780144);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 61 }, 3780154);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 61 }, 3780156);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 61 }, 3780158);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 195, 5, 83 }, 3780162);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 250, 7, 160, 8, 232, 8, 19 }, 3780166);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 11 }, 3780174);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 202, 8, 202, 8, 202, 8, 202, 8, 202, 8 }, 3780176);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 30 }, 3782804);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 63 }, 3782806);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 88 }, 3782808);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 106 }, 3782810);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 129 }, 3782812);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 168 }, 3782814);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 210, 4, 22 }, 3782816);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 84 }, 3782820);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 164, 5, 33 }, 3782822);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 177, 6, 234, 6, 26 }, 3782826);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 48 }, 3782836);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 89 }, 3782838);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 99 }, 3782840);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 135 }, 3782842);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 169 }, 3782844);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 217, 4, 19 }, 3782846);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 76 }, 3782850);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 171, 5, 31 }, 3782852);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 178, 6, 95 }, 3782856);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 193, 7, 24 }, 3782860);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 69 }, 3782868);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 112 }, 3782870);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 136 }, 3782872);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 184 }, 3782874);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 223, 4, 20 }, 3782876);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 89 }, 3782880);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 165, 5, 4 }, 3782882);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 139, 6, 104 }, 3782886);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 9 }, 3782890);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 94, 8, 180, 8 }, 3782892);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 98 }, 3782900);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 145 }, 3782902);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 164 }, 3782904);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 229, 4, 24 }, 3782906);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 86 }, 3782910);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 166, 5, 253, 5, 95 }, 3782912);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 218, 6, 0 }, 3782918);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 122, 8, 212, 8, 252, 8 }, 3782922);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 122 }, 3782932);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 170 }, 3782934);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 192, 4, 15 }, 3782936);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 73 }, 3782940);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 151 }, 3782942);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 236, 5, 69 }, 3782944);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 163, 6, 59 }, 3782948);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 117, 8, 203, 8, 4 }, 3782952);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 12 }, 3782958);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 146 }, 3782964);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 196, 4, 245, 4, 73 }, 3782966);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 139 }, 3782972);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 215, 5, 52 }, 3782974);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 152, 6, 254, 6, 164, 7, 180, 8, 5 }, 3782978);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 25 }, 3782988);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 25 }, 3782990);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 166 }, 3782996);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 221, 4, 45 }, 3782998);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 138 }, 3783002);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 216, 5, 43 }, 3783004);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 146 }, 3783008);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 244, 6, 91 }, 3783010);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 13 }, 3783014);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 203, 8, 25 }, 3783016);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 25 }, 3783020);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 25 }, 3783022);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 205, 4, 8 }, 3783028);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 90 }, 3783032);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 193, 5, 25 }, 3783034);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 122 }, 3783038);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 232, 6, 71 }, 3783040);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 173, 7, 87 }, 3783044);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 206, 8, 16 }, 3783048);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16 }, 3783052);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16 }, 3783054);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 246, 4, 44 }, 3783060);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 123 }, 3783064);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 229, 5, 70 }, 3783066);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 180, 6, 42 }, 3783070);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 142, 7, 222, 7, 92 }, 3783074);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 212, 8, 16 }, 3783080);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16 }, 3783084);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16 }, 3783086);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 61 }, 3783092);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 110 }, 3783094);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 180, 5, 10 }, 3783096);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 97 }, 3783100);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 194, 6, 45 }, 3783102);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 145, 7, 228, 7, 92 }, 3783106);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 212, 8, 16 }, 3783112);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16 }, 3783116);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16 }, 3783118);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 131 }, 3783124);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 175 }, 3783126);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 236, 5, 46 }, 3783128);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 123 }, 3783132);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 207, 6, 48 }, 3783134);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 147, 7, 234, 7, 92 }, 3783138);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 212, 8, 16 }, 3783144);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16 }, 3783148);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16 }, 3783150);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 160 }, 3783156);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 188, 5, 237, 5, 46 }, 3783158);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 125 }, 3783164);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 209, 6, 43 }, 3783166);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 135, 7, 222, 7, 87 }, 3783170);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 212, 8, 16 }, 3783176);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16 }, 3783180);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16 }, 3783182);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 188, 5, 200, 5, 238, 5, 45 }, 3783188);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 127 }, 3783196);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 210, 6, 38 }, 3783198);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 122 }, 3783202);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 210, 7, 82 }, 3783204);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 212, 8, 16 }, 3783208);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16 }, 3783212);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16 }, 3783214);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 157 }, 3783364);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 61 }, 3783366);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 101 }, 3783368);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 191, 4, 251, 4, 25 }, 3783370);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 80 }, 3783376);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 125 }, 3783378);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 195, 5, 245, 5, 250, 5, 250, 5, 250, 5 }, 3783380);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 252, 3, 136 }, 3783392);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 20 }, 3783396);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 110 }, 3783398);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 150 }, 3783400);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 190, 5, 255, 5, 79 }, 3783402);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 159, 6, 8 }, 3783408);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 108 }, 3783412);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 108 }, 3783414);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 108, 7 }, 3783416);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 86 }, 3783420);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 246, 4, 120 }, 3783422);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 220, 5, 64 }, 3783426);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 99 }, 3783430);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 139 }, 3783432);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 149, 6, 33 }, 3783434);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 138, 7, 188, 7, 188, 7, 188, 7 }, 3783438);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 146 }, 3783448);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 20 }, 3783450);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 165 }, 3783452);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 44 }, 3783454);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 114 }, 3783456);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 194, 6, 23 }, 3783458);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 43 }, 3783462);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 143, 7, 218, 7, 17 }, 3783464);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 32 }, 3783470);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 32 }, 3783472);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 226, 4, 80 }, 3783476);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 245, 5, 74 }, 3783480);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 194, 6, 58 }, 3783484);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 128 }, 3783488);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 158, 7, 17 }, 3783490);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 62 }, 3783494);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 102, 8, 102, 8, 102, 8 }, 3783496);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 0 }, 3783504);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 140 }, 3783506);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 240, 5, 144 }, 3783508);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 28 }, 3783512);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 148, 7, 198, 7, 218, 7, 42 }, 3783514);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 52 }, 3783522);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 72 }, 3783524);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 72 }, 3783526);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 72 }, 3783528);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 50 }, 3783532);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 175 }, 3783534);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 14 }, 3783536);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 204, 6, 108 }, 3783538);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 198, 7, 253, 7, 12 }, 3783542);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 32 }, 3783548);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 32 }, 3783550);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 32 }, 3783552);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 32 }, 3783554);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 32 }, 3783556);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 120 }, 3783560);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 205, 5, 54 }, 3783562);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 8 }, 3783566);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 168, 7, 2 }, 3783568);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 2 }, 3783572);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 7 }, 3783574);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 7 }, 3783576);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 7 }, 3783578);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 7 }, 3783580);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 7 }, 3783582);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 7 }, 3783584);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 145 }, 3783588);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 230, 5, 134 }, 3783590);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 48 }, 3783594);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 253, 7, 52 }, 3783596);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 52 }, 3783600);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 12 }, 3783602);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 2 }, 3783604);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 2 }, 3783606);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 238, 7, 238, 7, 238, 7 }, 3783608);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 160 }, 3783616);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 24 }, 3783618);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 184, 6, 108 }, 3783620);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 178, 7, 238, 7, 238, 7, 238, 7, 238, 7, 238, 7, 188, 7, 188, 7, 188, 7 }, 3783624);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 170 }, 3783644);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 64 }, 3783646);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 214, 6, 98 }, 3783648);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 118 }, 3783652);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 123 }, 3783654);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 123 }, 3783656);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 123 }, 3783658);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 123, 7, 178, 7, 188, 7, 188, 7, 188, 7 }, 3783660);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 190, 5, 84 }, 3783672);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 234, 6, 118 }, 3783676);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 138 }, 3783680);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 143, 7, 143, 7, 143, 7, 28 }, 3783682);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 28 }, 3783690);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 28 }, 3783692);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 28 }, 3783694);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 28 }, 3783696);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 207, 3, 36 }, 3783944);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 176 }, 3783948);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 70 }, 3783950);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 130 }, 3783952);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 190, 5, 240, 5, 19 }, 3783954);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 19 }, 3783960);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 19 }, 3783962);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 24 }, 3783964);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 250, 5, 250, 5 }, 3783966);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 212, 3, 81 }, 3783972);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 206, 4, 70 }, 3783976);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 195, 5, 64 }, 3783980);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 189, 6, 8 }, 3783984);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 43 }, 3783988);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 53 }, 3783990);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 108 }, 3783992);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 108 }, 3783994);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 108, 7 }, 3783996);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 6 }, 3784000);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 136 }, 3784002);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 30 }, 3784004);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 110 }, 3784006);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 14 }, 3784008);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 149 }, 3784010);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 78 }, 3784012);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 108 }, 3784014);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 133, 7, 158, 7, 188, 7, 188, 7, 188, 7 }, 3784016);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 56 }, 3784028);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 176 }, 3784030);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 55 }, 3784032);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 180, 5, 84 }, 3784034);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 244, 6, 143, 7, 173, 7, 238, 7, 248, 7, 17 }, 3784038);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 32 }, 3784050);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 32 }, 3784052);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 86 }, 3784056);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 221, 4, 150 }, 3784058);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 240, 5, 194, 6, 108 }, 3784062);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 233, 7, 72 }, 3784068);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 152, 8, 152, 8, 152, 8, 152, 8, 152, 8 }, 3784072);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 86 }, 3784084);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 236, 4, 150 }, 3784086);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 250, 5, 204, 6, 123 }, 3784090);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 12 }, 3784096);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 117, 8, 152, 8, 152, 8, 152, 8, 152, 8, 152, 8 }, 3784098);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 86 }, 3784112);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 0 }, 3784114);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 150 }, 3784116);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 4 }, 3784118);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224, 6, 123 }, 3784120);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 12 }, 3784124);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 32 }, 3784126);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 82 }, 3784128);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 82 }, 3784130);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 82 }, 3784132);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 82 }, 3784134);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 82 }, 3784136);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 86 }, 3784140);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 0 }, 3784142);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 160 }, 3784144);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 24 }, 3784146);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 229, 6, 123 }, 3784148);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 2 }, 3784152);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 32 }, 3784154);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 62 }, 3784156);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 62 }, 3784158);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 62 }, 3784160);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 62 }, 3784162);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 62 }, 3784164);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 86 }, 3784168);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 0 }, 3784170);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 160 }, 3784172);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 24 }, 3784174);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 239, 6, 123 }, 3784176);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 238, 7, 22 }, 3784180);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 42 }, 3784184);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 42 }, 3784186);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 42 }, 3784188);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 42 }, 3784190);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 42 }, 3784192);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 86 }, 3784196);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 70 }, 3784198);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 180, 5, 59 }, 3784200);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 28 }, 3784204);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 128 }, 3784206);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 223, 7, 223, 7, 223, 7, 223, 7, 188, 7, 188, 7, 188, 7 }, 3784208);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 126 }, 3784224);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 70 }, 3784226);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 200, 5, 74 }, 3784228);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 38 }, 3784232);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 138, 7, 173, 7, 173, 7, 173, 7, 173, 7, 188, 7, 188, 7, 188, 7 }, 3784234);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 220, 5, 169, 6, 169, 6, 28 }, 3784252);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 108 }, 3784260);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 108 }, 3784262);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 108 }, 3784264);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 108 }, 3784266);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 28 }, 3784268);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 28 }, 3784270);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 28 }, 3784272);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 28 }, 3784274);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 28 }, 3784276);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 40 }, 3786384);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 69 }, 3786386);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 101 }, 3786388);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 136 }, 3786390);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 169 }, 3786392);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 206, 4, 243, 4, 26 }, 3786394);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 66 }, 3786400);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 133 }, 3786402);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 182, 5, 1 }, 3786404);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 4 }, 3786408);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 4 }, 3786410);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 101 }, 3786416);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 143 }, 3786418);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 183 }, 3786420);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 237, 4, 35 }, 3786422);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 81 }, 3786426);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 127 }, 3786428);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 172, 5, 217, 5, 30 }, 3786430);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 101 }, 3786436);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 193, 6, 194, 6, 194, 6 }, 3786438);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 165 }, 3786448);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 210, 4, 6 }, 3786450);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 58 }, 3786454);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 109 }, 3786456);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 168, 5, 227, 5, 28 }, 3786458);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 85 }, 3786464);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 162, 6, 25 }, 3786466);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 128, 7, 138, 7, 138, 7 }, 3786470);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 205, 4, 6 }, 3786480);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 65 }, 3786484);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 125 }, 3786486);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 185, 5, 1 }, 3786488);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 74 }, 3786492);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 141 }, 3786494);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 207, 6, 40 }, 3786496);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 194, 7, 0 }, 3786500);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 12 }, 3786504);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 12 }, 3786506);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 231, 4, 46 }, 3786512);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 117 }, 3786516);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 190, 5, 3 }, 3786518);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 92 }, 3786522);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 173, 6, 248, 6, 71 }, 3786524);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 154, 7, 42 }, 3786530);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 125, 8, 132, 8, 132, 8 }, 3786534);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 236, 4, 55 }, 3786544);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 148 }, 3786548);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 232, 5, 52 }, 3786550);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 139 }, 3786554);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 219, 6, 43 }, 3786556);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 128, 7, 222, 7, 99, 8, 171, 8, 182, 8, 182, 8 }, 3786560);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 5 }, 3786576);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 100 }, 3786578);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 195, 5, 22 }, 3786580);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 103 }, 3786584);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 188, 6, 12 }, 3786586);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 103 }, 3786590);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 188, 7, 28 }, 3786592);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 129, 8, 181, 8, 192, 8, 192, 8 }, 3786596);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 11 }, 3786608);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 143 }, 3786610);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 0 }, 3786612);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 78 }, 3786614);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 159, 6, 244, 6, 51 }, 3786616);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 142, 7, 238, 7, 81 }, 3786622);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 144, 8, 179, 8, 192, 8, 192, 8 }, 3786628);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 11 }, 3786640);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 168 }, 3786642);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16 }, 3786644);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 78 }, 3786646);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 159, 6, 244, 6, 51 }, 3786648);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 142, 7, 238, 7, 81 }, 3786654);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 144, 8, 179, 8, 192, 8, 192, 8 }, 3786660);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 11 }, 3786672);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 168 }, 3786674);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16 }, 3786676);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 78 }, 3786678);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 159, 6, 244, 6, 51 }, 3786680);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 142, 7, 238, 7, 81 }, 3786686);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 144, 8, 179, 8, 192, 8, 192, 8 }, 3786692);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 11 }, 3786704);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 168 }, 3786706);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16 }, 3786708);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 78 }, 3786710);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 159, 6, 244, 6, 51 }, 3786712);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 142, 7, 238, 7, 81 }, 3786718);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 144, 8, 179, 8, 192, 8, 192, 8 }, 3786724);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 11 }, 3786736);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 168 }, 3786738);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16 }, 3786740);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 78 }, 3786742);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 159, 6, 244, 6, 51 }, 3786744);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 142, 7, 238, 7, 81 }, 3786750);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 144, 8, 179, 8, 192, 8, 192, 8 }, 3786756);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 11 }, 3786768);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 168 }, 3786770);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16 }, 3786772);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 78 }, 3786774);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 159, 6, 244, 6, 51 }, 3786776);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 142, 7, 238, 7, 81 }, 3786782);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 144, 8, 179, 8, 192, 8, 192, 8 }, 3786788);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 241, 3, 255, 3, 48 }, 3786964);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 66 }, 3786970);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 81 }, 3786972);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 122 }, 3786974);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 167 }, 3786976);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 223, 4, 44 }, 3786978);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 129 }, 3786982);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 3 }, 3786984);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 147, 6, 204, 6, 252, 6 }, 3786986);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 8 }, 3786996);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 49 }, 3786998);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 59 }, 3787000);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 100 }, 3787002);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 139 }, 3787004);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 192, 4, 39 }, 3787006);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 81 }, 3787010);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 150 }, 3787012);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 202, 5, 98 }, 3787014);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 15 }, 3787018);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 113, 7, 200, 7 }, 3787020);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 29 }, 3787028);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 72 }, 3787030);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 96 }, 3787032);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 149 }, 3787034);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 193, 4, 251, 4, 69 }, 3787036);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 180, 5, 240, 5, 34 }, 3787042);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 214, 6, 75 }, 3787048);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 4 }, 3787052);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 90, 8 }, 3787054);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 58 }, 3787060);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 105 }, 3787062);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 154 }, 3787064);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224, 4, 250, 4, 61 }, 3787066);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 146 }, 3787072);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 238, 5, 65 }, 3787074);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 123 }, 3787078);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 86 }, 3787080);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 228, 7, 162, 8, 202, 8 }, 3787082);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 87 }, 3787092);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 135 }, 3787094);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 212, 4, 40 }, 3787096);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 53 }, 3787100);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 136 }, 3787102);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 226, 5, 64 }, 3787104);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 143, 6, 235, 6, 158, 7, 52 }, 3787108);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 152, 8, 218, 8 }, 3787116);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 116 }, 3787124);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 166 }, 3787126);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 6 }, 3787128);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 97 }, 3787130);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 124 }, 3787132);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 205, 5, 47 }, 3787134);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 152, 6, 234, 6, 99 }, 3787138);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 2 }, 3787144);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 102, 8, 202, 8, 226, 8 }, 3787146);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 146 }, 3787156);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 201, 4, 20 }, 3787158);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 118 }, 3787162);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 201, 5, 33 }, 3787164);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 141 }, 3787168);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 244, 6, 71 }, 3787170);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 219, 7, 173, 8, 251, 8, 251, 8, 251, 8 }, 3787174);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 185 }, 3787188);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 244, 4, 65 }, 3787190);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 173, 5, 10 }, 3787194);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 112 }, 3787198);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 227, 6, 71 }, 3787200);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 173, 7, 87 }, 3787204);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 206, 8, 16 }, 3787208);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16 }, 3787212);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16 }, 3787214);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 246, 4, 44 }, 3787220);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 123 }, 3787224);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 229, 5, 70 }, 3787226);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 180, 6, 42 }, 3787230);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 142, 7, 222, 7, 92 }, 3787234);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 212, 8, 16 }, 3787240);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16 }, 3787244);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16 }, 3787246);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 61 }, 3787252);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 110 }, 3787254);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 180, 5, 10 }, 3787256);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 97 }, 3787260);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 194, 6, 45 }, 3787262);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 145, 7, 228, 7, 92 }, 3787266);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 212, 8, 16 }, 3787272);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16 }, 3787276);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16 }, 3787278);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 131 }, 3787284);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 175 }, 3787286);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 236, 5, 46 }, 3787288);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 123 }, 3787292);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 207, 6, 48 }, 3787294);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 147, 7, 234, 7, 92 }, 3787298);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 212, 8, 16 }, 3787304);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16 }, 3787308);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16 }, 3787310);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 160 }, 3787316);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 188, 5, 237, 5, 46 }, 3787318);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 125 }, 3787324);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 209, 6, 43 }, 3787326);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 135, 7, 222, 7, 87 }, 3787330);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 212, 8, 16 }, 3787336);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16 }, 3787340);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16 }, 3787342);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 188, 5, 200, 5, 238, 5, 45 }, 3787348);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 127 }, 3787356);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 210, 6, 38 }, 3787358);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 122 }, 3787362);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 210, 7, 82 }, 3787364);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 212, 8, 16 }, 3787368);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16 }, 3787372);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16 }, 3787374);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 6 }, 3787452);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 106 }, 3787454);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 156 }, 3787456);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 181, 4, 206, 4, 206, 4, 206, 4, 206, 4, 206, 4, 206, 4, 0 }, 3787458);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 0 }, 3787474);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 0 }, 3787476);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 0 }, 3787478);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 56 }, 3787480);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 126 }, 3787482);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 181, 4, 241, 4, 20 }, 3787484);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 60 }, 3787490);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 60 }, 3787492);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 60 }, 3787494);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 60 }, 3787496);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 60 }, 3787498);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 110 }, 3787500);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 110 }, 3787502);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 110 }, 3787504);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 110 }, 3787506);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 86 }, 3787508);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 146 }, 3787510);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 206, 4, 20 }, 3787512);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 90 }, 3787516);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 160, 5, 195, 5, 230, 5, 9 }, 3787518);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 29 }, 3787526);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 104 }, 3787528);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 114 }, 3787530);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 149, 6, 149, 6, 200, 5, 250, 5, 69 }, 3787532);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 129, 6, 194, 6, 13 }, 3787542);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 48 }, 3787548);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 88 }, 3787550);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 118, 7, 158, 7, 238, 7, 22 }, 3787552);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 32 }, 3787560);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 32 }, 3787562);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 58 }, 3787564);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 108, 7, 188, 7, 238, 7, 52 }, 3787566);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 122, 8, 162, 8, 202, 8, 232, 8, 232, 8, 26 }, 3787574);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 26 }, 3787586);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 26 }, 3787588);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 26 }, 3787590);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 138, 7, 188, 7, 248, 7, 32 }, 3787592);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 52 }, 3787600);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 162, 8, 232, 8, 46 }, 3787602);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 46 }, 3787608);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 71, 9, 96, 9, 96, 9, 96, 9, 96, 9, 228, 7, 2 }, 3787610);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 17 }, 3787624);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 32 }, 3787626);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 82 }, 3787628);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 177, 8, 242, 8, 46 }, 3787630);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 46 }, 3787636);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 71, 9, 96, 9, 96, 9, 96, 9, 96, 9, 228, 7, 2 }, 3787638);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 17 }, 3787652);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 32 }, 3787654);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 82 }, 3787656);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 192, 8, 16 }, 3787658);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 46 }, 3787662);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 46 }, 3787664);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 71, 9, 96, 9, 96, 9, 96, 9, 96, 9, 228, 7, 2 }, 3787666);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 32 }, 3787680);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 52 }, 3787682);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 97, 8, 192, 8, 16 }, 3787684);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 46 }, 3787690);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 46 }, 3787692);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 71, 9, 96, 9, 96, 9, 96, 9, 96, 9, 198, 7, 12 }, 3787694);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 52 }, 3787708);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 62 }, 3787710);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 112, 8, 192, 8, 16 }, 3787712);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 46 }, 3787718);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 46 }, 3787720);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 71, 9, 96, 9, 96, 9, 96, 9, 96, 9, 168, 7, 7 }, 3787722);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 32 }, 3787736);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 57 }, 3787738);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 112, 8, 192, 8, 16 }, 3787740);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 46 }, 3787746);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 46 }, 3787748);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 71, 9, 96, 9, 96, 9, 96, 9, 96, 9, 138, 7, 238, 7, 15 }, 3787750);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 49 }, 3787766);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 112, 8, 192, 8, 16 }, 3787768);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 46 }, 3787774);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 46 }, 3787776);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 71, 9, 96, 9, 96, 9, 96, 9, 96, 9, 73 }, 3787778);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 153, 7, 213, 7, 7 }, 3787790);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 52 }, 3787796);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 127, 8, 222, 8, 46 }, 3787798);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 46 }, 3787804);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 71, 9, 96, 9, 96, 9, 96, 9, 96, 9, 244, 6, 58 }, 3787806);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 118, 7, 178, 7, 233, 7, 52 }, 3787820);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 137, 8, 232, 8, 26 }, 3787828);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 71, 9, 96, 9, 106, 9, 106, 9, 106, 9, 164, 6, 234, 6, 38 }, 3787834);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 98 }, 3787850);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 153, 7, 218, 7, 27 }, 3787852);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 142, 8, 237, 8, 61 }, 3787858);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 91, 9, 96, 9, 96, 9, 96, 9, 187, 5, 250, 5, 66 }, 3787864);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 118 }, 3787878);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 158, 6, 225, 6, 46 }, 3787880);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 160, 7, 39 }, 3787886);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 143, 8, 42 }, 3787890);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 96, 9, 96, 9, 96, 9 }, 3787894);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 61 }, 3792474);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 211, 4, 140 }, 3792476);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 240, 5, 104 }, 3792480);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224, 6, 50 }, 3792484);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 168, 7, 168, 7, 168, 7 }, 3792488);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 126 }, 3792498);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 15 }, 3792500);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 44 }, 3792502);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 139 }, 3792504);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 244, 6, 103 }, 3792506);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 158, 7, 168, 7, 168, 7, 168, 7 }, 3792510);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 136 }, 3792522);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 55 }, 3792524);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 84 }, 3792526);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 10 }, 3792528);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 73 }, 3792530);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 253, 7, 102 }, 3792532);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 102, 8, 102, 8, 102, 8 }, 3792536);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 162 }, 3792546);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 127 }, 3792548);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 114 }, 3792550);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 108 }, 3792552);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 218, 7, 12 }, 3792554);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 63 }, 3792558);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 102, 8, 102, 8, 102, 8 }, 3792560);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 236, 4, 190, 5, 184, 6, 193, 7, 37 }, 3792570);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 52 }, 3792580);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 62 }, 3792582);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 112, 8, 112, 8, 112, 8 }, 3792584);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 246, 4, 220, 5, 244, 6, 208, 7, 42 }, 3792594);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 52 }, 3792604);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 72 }, 3792606);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 92 }, 3792608);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 92, 8, 92, 8 }, 3792610);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 251, 4, 220, 5, 234, 6, 190, 7, 208, 7, 12 }, 3792618);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 22 }, 3792630);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 52 }, 3792632);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 52 }, 3792634);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 52 }, 3792636);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 0 }, 3792642);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 220, 5, 224, 6, 138 }, 3792644);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 183, 7, 208, 7, 248, 7, 248, 7, 248, 7, 248, 7 }, 3792650);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 61 }, 3792814);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 211, 4, 140 }, 3792816);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 240, 5, 104 }, 3792820);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224, 6, 50 }, 3792824);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 168, 7, 168, 7, 168, 7 }, 3792828);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 126 }, 3792838);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 15 }, 3792840);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 44 }, 3792842);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 139 }, 3792844);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 244, 6, 103 }, 3792846);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 158, 7, 168, 7, 168, 7, 168, 7 }, 3792850);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 136 }, 3792862);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 55 }, 3792864);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 84 }, 3792866);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 10 }, 3792868);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 73 }, 3792870);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 253, 7, 102 }, 3792872);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 102, 8, 102, 8, 102, 8 }, 3792876);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 162 }, 3792886);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 127 }, 3792888);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 114 }, 3792890);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 108 }, 3792892);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 218, 7, 12 }, 3792894);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 63 }, 3792898);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 102, 8, 102, 8, 102, 8 }, 3792900);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 236, 4, 190, 5, 184, 6, 193, 7, 37 }, 3792910);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 52 }, 3792920);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 62 }, 3792922);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 112, 8, 112, 8, 112, 8 }, 3792924);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 246, 4, 220, 5, 244, 6, 208, 7, 42 }, 3792934);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 52 }, 3792944);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 72 }, 3792946);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 92 }, 3792948);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 92, 8, 92, 8 }, 3792950);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 251, 4, 220, 5, 234, 6, 190, 7, 208, 7, 12 }, 3792958);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 22 }, 3792970);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 52 }, 3792972);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 52 }, 3792974);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 52 }, 3792976);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 0 }, 3792982);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 220, 5, 224, 6, 138 }, 3792984);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 183, 7, 208, 7, 248, 7, 248, 7, 248, 7, 248, 7 }, 3792990);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 61 }, 3794844);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 140 }, 3794846);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 104 }, 3794848);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 168, 7, 168, 7, 168, 7, 168, 7 }, 3794850);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 136 }, 3794860);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 84 }, 3794862);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 73 }, 3794864);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 102 }, 3794866);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 102 }, 3794868);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 102, 8, 102, 8 }, 3794870);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 246, 4, 244, 6, 42 }, 3794876);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 92 }, 3794882);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 92 }, 3794884);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 92 }, 3794886);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 92, 8 }, 3794888);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 0 }, 3794892);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224, 6, 183, 7, 248, 7, 248, 7, 248, 7, 248, 7 }, 3794894);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 0 }, 3794908);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224, 6, 183, 7, 248, 7, 248, 7, 248, 7, 248, 7 }, 3794910);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 0 }, 3794924);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224, 6, 183, 7, 248, 7, 248, 7, 248, 7, 248, 7 }, 3794926);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 96, 34, 16 }, 3900294);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 104, 41, 204, 41, 98, 42, 248, 42, 248, 42, 248, 42 }, 3900298);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 18 }, 3900326);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 160, 40, 236, 44, 130, 45, 24, 46, 74, 46, 124, 46, 224, 46 }, 3900328);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 116, 39, 172, 43, 164, 46, 158, 47, 226, 49, 240, 50, 44, 51, 44, 51 }, 3900358);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 220, 40, 80, 45, 12, 48, 252, 48, 84, 51, 72, 53, 60, 55, 60, 55 }, 3900390);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 254, 41, 14 }, 3900422);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 252, 48, 110, 50, 188, 52, 10, 55, 164, 56, 164, 56 }, 3900426);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 94, 46, 70, 50, 162, 53, 134, 56, 6, 59, 200, 60, 98, 62, 128, 62 }, 3900454);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 78, 52, 234, 56, 110, 60, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62 }, 3900486);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 162, 58, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62 }, 3900518);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16, 59, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62 }, 3900550);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 200, 50, 200, 50, 200, 50, 200, 50, 200, 50, 200, 50, 200, 50, 200, 50 }, 3900582);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 64 }, 3900614);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 64 }, 3900616);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 64 }, 3900618);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 64 }, 3900620);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 64 }, 3900622);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 64 }, 3900624);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 64 }, 3900626);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 64 }, 3900628);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 172 }, 3900646);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 172 }, 3900648);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 172 }, 3900650);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 172 }, 3900652);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 172 }, 3900654);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 172 }, 3900656);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 172 }, 3900658);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 172 }, 3900660);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 96, 34, 32 }, 3909802);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 104, 41, 204, 41, 98, 42, 248, 42, 248, 42, 248, 42 }, 3909806);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 17 }, 3909834);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 159, 40, 236, 44, 130, 45, 24, 46, 74, 46, 124, 46, 224, 46 }, 3909836);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 116, 39, 172, 43, 164, 46, 158, 47, 226, 49, 243, 50, 44, 51, 44, 51 }, 3909866);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 220, 40, 80, 45, 12, 48, 252, 48, 84, 51, 72, 53, 60, 55, 60, 55 }, 3909898);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 254, 41, 14 }, 3909930);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 252, 48, 110, 50, 188, 52, 10, 55, 164, 56, 164, 56 }, 3909934);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 94, 46, 70, 50, 162, 53, 134, 56, 6, 59, 200, 60, 98, 62, 128, 62 }, 3909962);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 78, 52, 234, 56, 110, 60, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62 }, 3909994);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 162, 58, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62 }, 3910026);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16, 59, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62 }, 3910058);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 248, 57, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62 }, 3910090);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 64 }, 3910122);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 64 }, 3910124);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 64 }, 3910126);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 64 }, 3910128);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 64 }, 3910130);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 64 }, 3910132);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 64 }, 3910134);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 64 }, 3910136);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 61 }, 3910342);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 228, 37, 254, 41, 254, 41, 248, 42, 248, 42, 248, 42, 248, 42 }, 3910344);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 163, 37, 236, 39, 48, 42, 6 }, 3910374);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 130, 45, 224, 46, 224, 46, 224, 46 }, 3910382);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 104, 41, 138, 42, 231, 44, 94, 46, 56, 49, 194, 51, 194, 51, 194, 51 }, 3910406);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 36, 44, 176, 44, 63, 47, 202, 48, 72, 53, 60, 55, 60, 55, 60, 55 }, 3910438);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 170, 45, 8 }, 3910470);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 50, 144, 51, 10, 55, 164, 56, 164, 56, 164, 56 }, 3910475);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 221, 51, 162, 53, 134, 56, 6, 59, 200, 60, 98, 62, 128, 62, 128, 62 }, 3910502);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 234, 56, 110, 60, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62 }, 3910534);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62 }, 3910566);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 61 }, 3910922);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 254, 36, 60, 40, 254, 41, 248, 42, 248, 42, 248, 42, 248, 42 }, 3910924);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 128, 37, 236, 39, 48, 42, 6 }, 3910954);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 130, 45, 224, 46, 224, 46, 224, 46 }, 3910962);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 4 }, 3910986);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 138, 42, 231, 44, 94, 46, 56, 49, 194, 51, 194, 51, 194, 51 }, 3910988);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 92, 43, 176, 44, 63, 47, 202, 48, 72, 53, 60, 55, 60, 55, 60, 55 }, 3911018);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 236, 44, 18, 47 }, 3911050);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 50, 144, 51, 10, 55, 164, 56, 164, 56, 164, 56 }, 3911055);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 221, 51, 162, 53, 134, 56, 6, 59, 200, 60, 98, 62, 128, 62, 128, 62 }, 3911082);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 234, 56, 110, 60, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62 }, 3911114);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62 }, 3911146);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 128, 62, 128, 62, 128, 62, 128, 62 }, 3917452);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62 }, 3917464);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 184, 61, 184, 61, 184, 61, 184, 61, 184, 61, 184, 61, 184 }, 3920892);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 184 }, 3920930);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 184 }, 3920932);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 184 }, 3920934);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 184 }, 3920936);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 184 }, 3920938);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 128, 62, 128, 62, 184, 61, 184 }, 3923926);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 184, 11, 184, 11, 184, 11, 184, 11, 184, 11, 184, 11, 184, 11 }, 3924610);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15 }, 3924626);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 20, 15, 72, 13, 28, 12, 34, 11, 246, 9, 252, 8 }, 3924644);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 154, 16, 166, 14, 228, 12, 184, 11, 90, 10, 46, 9, 208, 7 }, 3924658);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 104, 16, 66, 14, 128, 12, 240, 10, 96, 9, 208, 7, 14, 6 }, 3924674);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 54, 16, 172, 13, 84, 11, 146, 9, 208, 7, 14, 6, 76, 4 }, 3924690);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 160, 15, 178, 12, 196, 9, 2, 8, 14, 6, 126, 4, 238, 2 }, 3924706);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 172, 13, 34, 11, 52, 8, 64, 6, 226, 4, 132, 3, 38, 2 }, 3924722);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 240, 10, 252, 8, 164, 6, 176, 4, 132, 3, 88, 2, 250, 0 }, 3924738);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 96, 9, 208, 7, 170, 5, 132, 3, 88, 2, 44, 1, 0, 0 }, 3924754);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 160, 15, 160, 15, 160, 15, 160, 15, 160, 15 }, 3924814);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 28 }, 3924830);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 160, 15, 252, 8, 64, 6, 232, 3 }, 3924832);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 170, 15, 228, 12, 8, 7, 176, 4, 244, 1 }, 3924846);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 90, 15, 28, 12, 20, 5, 188, 2, 150, 0 }, 3924862);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 38 }, 3924876);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 246, 14, 34, 11, 188, 2, 200, 0, 50, 0 }, 3924878);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 234, 16, 10, 15, 36, 14, 246, 9, 219, 1, 125, 0, 25, 0 }, 3924890);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 114, 16, 116, 14, 72, 13, 202, 8, 250, 0, 50, 0, 0, 0 }, 3924906);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 130, 15, 12, 13, 204, 11, 10, 5, 90, 0, 10, 0, 0, 0 }, 3924922);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 106, 14, 168, 12, 86, 9, 148, 2, 20, 0, 0, 0, 0, 0, 136, 14, 56, 14, 184, 11, 58, 7, 64, 1, 0, 0, 0, 0, 0, 0 }, 3924938);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62 }, 3925004);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 184, 11, 184, 11, 184, 11, 40, 10, 128, 12, 128, 12, 128, 12, 40, 10, 128, 12, 128, 12, 128, 12, 40, 10, 128, 12, 128, 12, 128, 12, 40, 10, 128, 12, 128, 12, 128, 12, 40, 10, 108, 12, 108, 12, 108, 12, 40, 10, 254, 11, 234, 11, 254, 11, 191, 9, 134, 11, 64, 11, 134, 11, 81, 9, 14, 11, 150, 10, 14, 11, 212, 8, 170, 10, 236, 9, 170, 10, 102, 8, 40, 10, 86, 9, 40, 10, 238, 7, 212, 8, 32, 8, 212, 8, 250, 5, 128, 7, 128, 7, 128, 7, 36 }, 3926040);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 220, 5, 220, 5, 220, 5, 8 }, 3926144);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 252, 3, 252, 3, 252, 3 }, 3926152);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 234, 1, 234, 1, 234, 1 }, 3926160);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 232, 3, 18, 7, 18, 7, 88, 12 }, 3979762);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 28, 12, 28, 12, 28, 12, 28, 12 }, 3979780);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 28, 12, 28, 12, 28, 12, 28, 12 }, 3979814);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 172, 13, 172, 13, 172, 13, 172, 13, 172, 13, 172, 13, 172, 13, 172, 13 }, 3979856);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 82, 8, 0, 0 }, 3979886);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 82, 8, 0, 0 }, 3979920);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 82, 8, 0, 0 }, 3979954);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 82, 8, 0, 0 }, 3979988);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 82, 8, 0, 0 }, 3980022);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 172, 13, 172, 13, 172, 13, 172, 13, 172, 13, 172, 13, 172, 13, 172, 13 }, 3980060);
            }
            return validationEgrInFile;
        }
        public override async Task<bool> checkFileForDpf()
        {
            bool validationEgrInFile = true;
            //Algo for checking dpf solution
            if (ToolBox.array.Length > 0)
            {
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 230 }, 3151555);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 230 }, 3151563);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 230 }, 3151571);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 230 }, 3151579);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 230 }, 3151587);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 230 }, 3151595);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 230 }, 3151603);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 230 }, 3151611);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 230 }, 3151619);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 218 }, 3151627);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 203 }, 3151635);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 187 }, 3151643);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 171 }, 3151651);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 155 }, 3151659);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 230 }, 3151691);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 230 }, 3151699);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 230 }, 3151707);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 230 }, 3151715);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 230 }, 3151723);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 230 }, 3151731);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 230 }, 3151739);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 230 }, 3151747);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 230 }, 3151755);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 218 }, 3151763);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 203 }, 3151771);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 187 }, 3151779);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 171 }, 3151787);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 155 }, 3151795);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 200, 11, 200, 11, 200, 11, 40, 10, 128, 12, 128, 12, 128, 12, 40, 10, 128, 12, 128, 12, 128, 12, 40, 10, 128, 12, 128, 12, 128, 12, 40, 10, 128, 12, 128, 12, 128, 12, 40, 10, 108, 12, 108, 12, 108, 12, 40, 10, 254, 11, 234, 11, 254, 11, 191, 9, 139, 11, 71, 11, 139, 11, 85, 9, 14, 11, 150, 10, 14, 11, 212, 8, 170, 10, 236, 9, 170, 10, 102, 8, 40, 10, 86, 9, 40, 10, 238, 7, 212, 8, 32, 8, 212, 8, 250, 5, 128, 7, 128, 7, 128, 7, 36 }, 3151954);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 220, 5, 220, 5, 220, 5, 8 }, 3152058);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 252, 3, 252, 3, 252, 3 }, 3152066);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 234, 1, 234, 1, 234, 1 }, 3152074);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16, 14 }, 3468270);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16, 14 }, 3468286);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16, 14 }, 3468302);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16, 14 }, 3468318);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16, 14 }, 3468334);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16, 14 }, 3468350);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16, 14 }, 3468366);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16, 14 }, 3468382);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 6, 14 }, 3468398);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 240, 12, 83, 13 }, 3468412);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16, 12, 102, 12 }, 3468428);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 63, 11, 113, 11 }, 3468444);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 119, 10, 119, 10 }, 3468460);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 125, 9, 125, 9 }, 3468476);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16, 14 }, 3468542);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16, 14 }, 3468558);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16, 14 }, 3468574);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16, 14 }, 3468590);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16, 14 }, 3468606);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16, 14 }, 3468622);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 73 }, 3468636);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16, 14 }, 3468638);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 212, 12, 16, 14 }, 3468652);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 99, 12, 6, 14 }, 3468668);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 141, 11, 83, 13 }, 3468684);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 197, 10, 102, 12 }, 3468700);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 10, 10, 113, 11 }, 3468716);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 93, 9, 119, 10 }, 3468732);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 187, 8, 125, 9 }, 3468748);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 90, 10, 246, 9, 196, 9, 96, 9, 152, 8, 52, 8, 108, 7, 170, 5 }, 3589574);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 190, 10, 128, 12, 228, 12, 220, 5, 244, 1 }, 3589610);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 190, 10, 208, 7, 96, 9, 240, 10, 234, 11 }, 3589644);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 190, 10, 128, 12, 116, 14, 16, 14, 22, 13 }, 3589678);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 52, 8, 158, 7, 108, 7, 108, 7, 164, 6, 120, 5, 188, 2 }, 3589752);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 210, 15, 210, 15, 206, 14, 16, 14, 102, 13, 208, 12, 190, 10, 2, 8, 210, 15, 210, 15, 206, 14, 16, 14, 102, 13, 208, 12, 190, 10, 2, 8, 210, 15, 210, 15, 206, 14, 16, 14, 102, 13, 208, 12, 190, 10, 2, 8, 210, 15, 210, 15, 206, 14, 16, 14, 102, 13, 208, 12, 190, 10, 2, 8, 210, 15, 210, 15, 206, 14, 16, 14, 102, 13, 208, 12, 190, 10, 2, 8, 210, 15, 210, 15, 206, 14, 16, 14, 1, 13, 208, 12, 190, 10, 2, 8, 168, 15, 188, 15, 206, 14, 16, 14, 168, 12, 171, 12, 140, 10, 2, 8, 100, 15, 153, 15, 181, 14, 16, 14, 88, 12, 98, 12, 231, 9, 248, 7, 18, 15, 83, 15, 119, 14, 245, 13, 18, 12, 31, 12, 146, 9, 233, 7, 197, 13, 252, 13, 89, 13, 60, 13, 87, 11, 87, 11, 49, 9, 198, 7, 140, 13, 187, 13, 27, 13, 241, 12, 52, 11, 57, 11, 41, 9, 188, 7, 173, 12, 246, 12, 53, 12, 199, 11, 225, 10, 215, 10, 230, 8, 133, 7, 53, 12, 143, 12, 159, 11, 14, 11, 133, 10, 118, 10, 162, 8, 66, 7 }, 3589916);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 72, 8, 72, 8, 35, 7, 187, 5, 229, 4, 106, 4, 29, 4, 225, 3, 139, 3, 160, 10, 160, 10, 125, 7, 4, 6, 73, 5, 0, 5, 169, 4, 86, 4, 239, 3, 72, 13, 72, 13, 45, 8, 227, 5, 143, 4, 13, 4, 209, 3, 152, 3, 72, 3, 106, 14, 106, 14, 170, 10, 9, 8, 167, 6, 247, 5, 127, 5, 33, 5, 163, 4, 216, 14, 216, 14, 64, 11, 159, 8, 61, 7, 131, 6, 243, 5, 120, 5, 7, 5, 216, 14, 216, 14, 47, 11, 155, 8, 95, 7, 157, 6, 17, 6, 147, 5, 27, 5, 46, 14, 46, 14, 234, 10, 245, 7, 118, 6, 214, 5, 97, 5, 240, 4, 93, 4, 212, 13, 212, 13, 134, 10, 154, 7, 55, 6, 196, 5, 111, 5, 35, 5, 181, 4, 22, 13, 22, 13, 33, 10, 105, 7, 232, 5, 109, 5, 4, 5, 170, 4, 57, 4, 98, 12, 98, 12, 13, 10, 245, 7, 71, 6, 147, 5, 47, 5, 216, 4, 116, 4, 64, 11, 64, 11, 109, 8, 37, 6, 146, 4, 3, 4, 202, 3, 149, 3, 105, 3, 122, 8, 122, 8, 107, 6, 7, 5, 136, 4, 26, 4, 215, 3, 132, 3, 65, 3 }, 3590224);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 184, 11, 184, 11, 184, 11, 184, 11, 184, 11, 184, 11, 184, 11, 184, 11, 115, 10, 232, 3 }, 3591480);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 26, 14, 26, 14, 26, 14, 26, 14, 46, 14, 46, 14, 46, 14, 46, 14, 46, 14, 46, 14, 46, 14, 46, 14, 46, 14, 46, 14, 46, 14, 46, 14, 115, 13, 115, 13, 115, 13, 115, 13, 26, 13, 26, 13, 26, 13, 26, 13, 191, 12, 191, 12, 191, 12, 191, 12, 90, 12, 90, 12, 90, 12, 90, 12, 20, 12, 20, 12, 20, 12, 20, 12, 159, 11, 159, 11, 159, 11, 159, 11, 33, 11, 33, 11, 33, 11, 33, 11, 140, 10, 140, 10, 140, 10, 140, 10, 66, 9, 66, 9, 66, 9, 66, 9, 188, 7, 188, 7, 188, 7, 188, 7, 230, 5, 230, 5, 230, 5, 230, 5, 232, 3, 232, 3, 232, 3, 232, 3, 188, 2, 188, 2, 188, 2, 188, 2 }, 3591624);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16, 14, 72, 13, 72, 13, 72, 13, 178, 10, 196, 9 }, 3591894);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 66, 9, 52, 8, 230, 5, 232, 3, 188, 2 }, 3591960);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 247, 39 }, 3594400);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 163 }, 3710830);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16 }, 3710832);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 128 }, 3710834);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 241, 7, 87 }, 3710836);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 183, 8, 16 }, 3710840);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 114 }, 3710844);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224, 9, 70 }, 3710846);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 170, 10, 20 }, 3710850);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 124, 11, 227, 11, 78 }, 3710854);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 181, 12, 32 }, 3710860);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 145, 13, 242, 13, 71 }, 3710864);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 176, 14, 145, 15, 104, 16 }, 3710870);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 58 }, 3710910);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 169 }, 3710912);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 15 }, 3710914);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 113 }, 3710916);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 212, 7, 55 }, 3710918);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 157, 8, 242, 8, 71 }, 3710922);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 163, 9, 0 }, 3710928);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 98 }, 3710932);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 195, 10, 42 }, 3710934);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 139, 11, 227, 11, 73 }, 3710938);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 183, 12, 20 }, 3710944);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 112, 13, 212, 13, 159, 14, 108, 15 }, 3710948);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 228, 5, 63 }, 3710990);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 166 }, 3710994);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 4 }, 3710996);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 97 }, 3710998);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 184, 7, 29 }, 3711000);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 134 }, 3711004);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 231, 8, 56 }, 3711006);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 136, 9, 221, 9, 50 }, 3711010);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 138, 10, 233, 10, 67 }, 3711016);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 154, 11, 244, 11, 85 }, 3711022);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 188, 12, 34 }, 3711028);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 237, 13, 166, 14 }, 3711032);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 176 }, 3711070);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 250, 5, 77 }, 3711072);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 164 }, 3711076);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 249, 6, 83 }, 3711078);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 173, 7, 10 }, 3711082);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 107 }, 3711086);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 200, 8, 28 }, 3711088);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 108 }, 3711092);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 189, 9, 18 }, 3711094);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 103 }, 3711098);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 185, 10, 7 }, 3711100);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 86 }, 3711104);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 166, 11, 0 }, 3711106);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 93 }, 3711110);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 37 }, 3711112);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 232, 13 }, 3711114);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 108 }, 3711150);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 189, 5, 8 }, 3711152);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 86 }, 3711156);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 162 }, 3711158);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 242, 6, 73 }, 3711160);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 163, 7, 250, 7, 83 }, 3711164);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 166, 8, 247, 8, 68 }, 3711170);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 146, 9, 224, 9, 48 }, 3711176);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 125, 10, 195, 10, 12 }, 3711182);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 91 }, 3711188);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 179, 11, 101, 12, 72 }, 3711190);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 67 }, 3711230);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 139 }, 3711232);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 202, 5, 15 }, 3711234);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 85 }, 3711238);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 163 }, 3711240);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 244, 6, 72 }, 3711242);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 153 }, 3711246);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 232, 7, 62 }, 3711248);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 143 }, 3711252);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 215, 8, 29 }, 3711254);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 104 }, 3711258);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 177, 9, 249, 9, 60 }, 3711260);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 133, 10, 210, 10, 37 }, 3711266);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 204, 11, 178, 12 }, 3711272);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 251, 4, 68 }, 3711310);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 139 }, 3711314);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 215, 5, 22 }, 3711316);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 91 }, 3711320);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 166 }, 3711322);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 243, 6, 70 }, 3711324);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 147 }, 3711328);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 222, 7, 44 }, 3711330);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 122 }, 3711334);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 188, 8, 255, 8, 76 }, 3711336);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 144, 9, 216, 9, 25 }, 3711342);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 100 }, 3711348);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 180, 10, 89 }, 3711350);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 33 }, 3711354);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 177 }, 3711390);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 249, 4, 68 }, 3711392);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 149 }, 3711396);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 225, 5, 36 }, 3711398);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 115 }, 3711402);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 184, 6, 250, 6, 71 }, 3711404);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 140 }, 3711410);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 208, 7, 19 }, 3711412);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 79 }, 3711416);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 145 }, 3711418);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 210, 8, 21 }, 3711420);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 88 }, 3711424);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 156, 9, 229, 9, 55 }, 3711426);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 218, 10, 132, 11 }, 3711432);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 168, 97, 156, 99, 168, 97, 8, 82, 216, 89, 192, 93 }, 3714808);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 92, 204, 91, 88, 77, 252, 83, 4, 91, 100, 100, 124, 96, 96, 84, 16, 89, 240, 85 }, 3714821);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 155 }, 3778028);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 197 }, 3778030);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 250, 3, 35 }, 3778032);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 88 }, 3778036);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 148 }, 3778038);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 207, 4, 11 }, 3778040);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 70 }, 3778044);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 70 }, 3778046);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 70 }, 3778048);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 70 }, 3778050);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 70 }, 3778052);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 70 }, 3778054);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 0 }, 3778060);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 39 }, 3778062);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 80 }, 3778064);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 159 }, 3778066);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 244, 4, 56 }, 3778068);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 124 }, 3778072);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 192, 5, 4 }, 3778074);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 47 }, 3778078);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 91 }, 3778080);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 91 }, 3778082);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 91 }, 3778084);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 91 }, 3778086);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 94 }, 3778092);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 119 }, 3778094);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 156 }, 3778096);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16 }, 3778098);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 110 }, 3778100);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224, 5, 82 }, 3778102);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 195, 6, 53 }, 3778106);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 61 }, 3778110);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 61 }, 3778112);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 61 }, 3778114);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 61 }, 3778116);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 61 }, 3778118);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 126 }, 3778124);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 183 }, 3778126);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 15 }, 3778128);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 185, 5, 24 }, 3778130);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 200, 6, 77 }, 3778134);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 176, 7, 228, 7, 228, 7, 228, 7, 228, 7, 228, 7, 228, 7 }, 3778138);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 131 }, 3778156);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 3 }, 3778158);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 140 }, 3778160);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 41 }, 3778162);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 197, 6, 91 }, 3778164);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 223, 7, 228, 7, 228, 7, 228, 7, 228, 7, 228, 7, 228, 7, 228, 7 }, 3778168);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 176 }, 3778188);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 39 }, 3778190);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 215, 5, 132 }, 3778192);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 35 }, 3778196);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 160, 7, 228, 7, 228, 7, 228, 7, 228, 7, 228, 7, 228, 7, 228, 7, 228, 7 }, 3778198);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 226, 4, 88 }, 3778220);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 35 }, 3778224);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 227, 6, 108 }, 3778226);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 208, 7, 228, 7, 228, 7, 228, 7, 228, 7, 228, 7, 228, 7, 228, 7, 228, 7 }, 3778230);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 246, 4, 115 }, 3778252);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 46 }, 3778256);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224, 6, 93 }, 3778258);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 188, 7, 228, 7, 228, 7, 228, 7, 228, 7, 228, 7, 228, 7, 228, 7, 228, 7 }, 3778262);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 0 }, 3778284);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 132 }, 3778286);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 56 }, 3778288);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 213, 6, 66 }, 3778290);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 168, 7, 208, 7, 208, 7, 208, 7, 208, 7, 208, 7, 208, 7, 208, 7, 208, 7 }, 3778294);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 0 }, 3778316);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 170 }, 3778318);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 94 }, 3778320);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224, 6, 88 }, 3778322);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 148, 7, 158, 7, 158, 7, 158, 7, 158, 7, 158, 7, 158, 7, 158, 7, 158, 7 }, 3778326);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 211, 4, 170 }, 3778348);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 104 }, 3778352);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 18 }, 3778354);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 158, 7, 158, 7, 158, 7, 158, 7, 158, 7, 158, 7, 158, 7, 158, 7, 158, 7, 158, 7 }, 3778356);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 166 }, 3778380);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 140 }, 3778382);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 124 }, 3778384);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 204, 6, 254, 6, 254, 6, 254, 6, 254, 6, 254, 6, 254, 6, 254, 6, 254, 6, 254, 6, 254, 6 }, 3778386);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 149 }, 3778412);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 123 }, 3778414);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 108 }, 3778416);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 161, 6, 224, 6, 224, 6, 224, 6, 224, 6, 224, 6, 224, 6, 224, 6, 224, 6, 224, 6, 224, 6 }, 3778418);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 153 }, 3778608);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 211, 4, 7 }, 3778610);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 85 }, 3778614);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 191, 5, 38 }, 3778616);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 124 }, 3778620);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 219, 6, 48 }, 3778622);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 118 }, 3778626);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 158, 7, 198, 7, 208, 7, 208, 7 }, 3778628);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 191 }, 3778640);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 4 }, 3778642);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 119 }, 3778644);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 232, 5, 91 }, 3778646);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 213, 6, 58 }, 3778650);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 188, 7, 60 }, 3778654);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 112, 8, 152, 8, 192, 8, 192, 8, 192, 8 }, 3778658);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 236, 4, 99 }, 3778672);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 230, 5, 119 }, 3778676);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 244, 6, 106 }, 3778680);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 253, 7, 132, 8, 197, 8, 228, 8, 232, 8, 232, 8, 232, 8, 232, 8 }, 3778684);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 17 }, 3778704);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 168 }, 3778706);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 73 }, 3778708);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 254, 6, 151, 7, 7 }, 3778710);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 124, 8, 243, 8, 16 }, 3778716);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16 }, 3778722);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16 }, 3778724);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16 }, 3778726);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16 }, 3778728);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16 }, 3778730);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 50 }, 3778736);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 231, 5, 150 }, 3778738);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 67 }, 3778742);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 231, 7, 102 }, 3778744);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 183, 8, 16 }, 3778748);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16 }, 3778752);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16 }, 3778754);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16 }, 3778756);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16 }, 3778758);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16 }, 3778760);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16 }, 3778762);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 178 }, 3778768);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 71 }, 3778770);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 198, 6, 68 }, 3778772);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 231, 7, 142, 8, 194, 8, 16 }, 3778776);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16 }, 3778784);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16 }, 3778786);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16 }, 3778788);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16 }, 3778790);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16 }, 3778792);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16 }, 3778794);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 3 }, 3778800);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 145 }, 3778802);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 236, 6, 52 }, 3778804);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 226, 7, 142, 8, 211, 8, 16 }, 3778808);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16 }, 3778816);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16 }, 3778818);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16 }, 3778820);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16 }, 3778822);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16 }, 3778824);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16 }, 3778826);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 34 }, 3778832);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 162 }, 3778834);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 232, 6, 51 }, 3778836);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 226, 7, 142, 8, 245, 8, 16 }, 3778840);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16 }, 3778848);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16 }, 3778850);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16 }, 3778852);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16 }, 3778854);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16 }, 3778856);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16 }, 3778858);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 4 }, 3778864);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 140 }, 3778866);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 205, 6, 8 }, 3778868);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 226, 7, 142, 8, 14 }, 3778872);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16 }, 3778878);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16 }, 3778880);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16 }, 3778882);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16 }, 3778884);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16 }, 3778886);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16 }, 3778888);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16 }, 3778890);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 227, 5, 96 }, 3778896);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 185, 6, 8 }, 3778900);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 226, 7, 142, 8, 15 }, 3778904);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16 }, 3778910);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16 }, 3778912);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16 }, 3778914);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16 }, 3778916);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16 }, 3778918);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16 }, 3778920);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16 }, 3778922);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 190, 5, 28 }, 3778928);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 164, 6, 8 }, 3778932);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 208, 7, 142, 8, 6 }, 3778936);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 6 }, 3778942);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 6 }, 3778944);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 6 }, 3778946);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 6 }, 3778948);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 6 }, 3778950);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 6 }, 3778952);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 6 }, 3778954);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 190, 5, 210, 5, 164, 6, 8 }, 3778960);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 208, 7, 142, 8, 172, 8, 172, 8, 172, 8, 172, 8, 172, 8, 172, 8, 172, 8, 172, 8 }, 3778968);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 190, 5, 210, 5, 164, 6, 8 }, 3778992);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 208, 7, 208, 7, 208, 7, 208, 7, 208, 7, 208, 7, 208, 7, 208, 7, 208, 7, 208, 7 }, 3779000);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 111 }, 3779296);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 201, 4, 190, 5, 39 }, 3779298);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 104 }, 3779304);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 124 }, 3779306);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 139 }, 3779308);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 204, 6, 234, 6, 158, 7, 228, 7, 228, 7 }, 3779310);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 146 }, 3779322);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 40 }, 3779324);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 220, 5, 134 }, 3779326);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 249, 6, 56 }, 3779330);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 98 }, 3779334);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 118 }, 3779336);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 138, 7, 2 }, 3779338);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 222, 8, 222, 8 }, 3779342);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 226, 4, 105 }, 3779348);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 245, 5, 144 }, 3779352);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 38 }, 3779356);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 103 }, 3779358);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 148, 7, 162, 7, 238, 7, 67 }, 3779360);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 6 }, 3779368);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 6 }, 3779370);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 5 }, 3779374);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 120 }, 3779376);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 14 }, 3779378);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 179, 6, 121 }, 3779380);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 157, 7, 218, 7, 253, 7, 27 }, 3779384);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 162, 8, 46 }, 3779392);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 46 }, 3779396);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 34 }, 3779400);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 145 }, 3779402);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 37 }, 3779404);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 244, 6, 148, 7, 240, 7, 4 }, 3779406);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 27 }, 3779414);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 102, 8, 202, 8, 51 }, 3779416);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 51 }, 3779422);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 42 }, 3779426);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 155 }, 3779428);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 44 }, 3779430);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 254, 6, 168, 7, 42 }, 3779432);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 52 }, 3779438);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 112, 8, 137, 8, 26 }, 3779440);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 56 }, 3779446);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 56 }, 3779448);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 57 }, 3779452);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 4 }, 3779454);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 126 }, 3779456);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 88 }, 3779458);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 220, 7, 82 }, 3779460);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 122, 8, 152, 8, 167, 8, 36 }, 3779464);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 61 }, 3779472);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 61 }, 3779474);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 96 }, 3779478);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 34 }, 3779480);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 179, 6, 153, 7, 52 }, 3779482);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 97 }, 3779488);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 127, 8, 162, 8, 182, 8, 66 }, 3779490);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 66 }, 3779498);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 66, 9 }, 3779500);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 184, 5, 101 }, 3779504);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 8 }, 3779508);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 223, 7, 92 }, 3779510);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 112 }, 3779514);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 132, 8, 172, 8, 232, 8, 96, 9, 96, 9, 96, 9 }, 3779516);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 208, 5, 114 }, 3779530);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 64 }, 3779534);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 12 }, 3779536);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 102 }, 3779538);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 117 }, 3779540);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 134, 8, 177, 8, 46 }, 3779542);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 66 }, 3779548);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 66 }, 3779550);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 66, 9 }, 3779552);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 204, 5, 170, 6, 66 }, 3779556);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 52 }, 3779562);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 117 }, 3779564);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 130, 8, 152, 8, 202, 8, 61 }, 3779566);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 61 }, 3779574);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 61 }, 3779576);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 61 }, 3779578);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 204, 5, 170, 6, 66 }, 3779582);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 52 }, 3779588);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 117 }, 3779590);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 130, 8, 152, 8, 202, 8, 252, 8, 252, 8, 252, 8, 252, 8 }, 3779592);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 126 }, 3779876);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 252, 4, 117 }, 3779878);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 248, 5, 119 }, 3779882);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 134 }, 3779886);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 139 }, 3779888);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 219, 6, 43 }, 3779890);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 188, 7, 228, 7, 228, 7 }, 3779894);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 161 }, 3779902);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 20 }, 3779904);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224, 5, 86 }, 3779906);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 235, 6, 66 }, 3779910);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 106 }, 3779914);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 140, 7, 173, 7, 182, 8, 222, 8, 222, 8 }, 3779916);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 196, 4, 70 }, 3779928);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 244, 5, 134 }, 3779932);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 51 }, 3779936);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 103 }, 3779938);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 149, 7, 188, 7, 7 }, 3779940);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 6 }, 3779946);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 6 }, 3779948);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 6 }, 3779950);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 0 }, 3779954);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 110 }, 3779956);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 15 }, 3779958);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 178, 6, 121 }, 3779960);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 157, 7, 223, 7, 2 }, 3779964);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 82 }, 3779970);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 36 }, 3779972);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 46 }, 3779974);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 46 }, 3779976);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 10 }, 3779980);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 120 }, 3779982);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 37 }, 3779984);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 209, 6, 153, 7, 220, 7, 4 }, 3779986);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 88 }, 3779994);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 172, 8, 46 }, 3779996);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 51 }, 3780000);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 51 }, 3780002);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 20 }, 3780006);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 154 }, 3780008);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 76 }, 3780010);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 252, 6, 166, 7, 42 }, 3780012);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 67 }, 3780018);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 142, 8, 222, 8, 53 }, 3780020);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 56 }, 3780026);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 56 }, 3780028);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 50 }, 3780032);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 190, 5, 126 }, 3780034);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 65 }, 3780038);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 220, 7, 96 }, 3780040);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 152, 8, 197, 8, 26 }, 3780044);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 61 }, 3780050);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 61 }, 3780052);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 61 }, 3780054);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 70 }, 3780058);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 205, 5, 217, 6, 162, 7, 66 }, 3780060);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 127, 8, 200, 8, 252, 8, 36 }, 3780068);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 66 }, 3780076);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 66 }, 3780078);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 66, 9 }, 3780080);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 120 }, 3780084);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 250, 5, 8 }, 3780086);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 223, 7, 118 }, 3780090);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 142, 8, 147, 8, 222, 8, 41 }, 3780094);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 86, 9, 86, 9, 86, 9 }, 3780102);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 120 }, 3780110);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 44 }, 3780112);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 58 }, 3780114);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 17 }, 3780116);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 137, 8, 145, 8, 155, 8, 230, 8, 66 }, 3780118);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 66 }, 3780128);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 66 }, 3780130);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 66, 9 }, 3780132);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 120 }, 3780136);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 114 }, 3780138);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 108 }, 3780140);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 52 }, 3780142);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 141, 8, 152, 8, 178, 8, 251, 8, 61 }, 3780144);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 61 }, 3780154);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 61 }, 3780156);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 61 }, 3780158);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 195, 5, 83 }, 3780162);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 250, 7, 160, 8, 232, 8, 19 }, 3780166);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 11 }, 3780174);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 202, 8, 202, 8, 202, 8, 202, 8, 202, 8 }, 3780176);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 30 }, 3782804);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 63 }, 3782806);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 88 }, 3782808);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 106 }, 3782810);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 129 }, 3782812);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 168 }, 3782814);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 210, 4, 22 }, 3782816);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 84 }, 3782820);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 164, 5, 33 }, 3782822);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 177, 6, 234, 6, 26 }, 3782826);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 48 }, 3782836);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 89 }, 3782838);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 99 }, 3782840);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 135 }, 3782842);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 169 }, 3782844);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 217, 4, 19 }, 3782846);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 76 }, 3782850);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 171, 5, 31 }, 3782852);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 178, 6, 95 }, 3782856);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 193, 7, 24 }, 3782860);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 69 }, 3782868);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 112 }, 3782870);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 136 }, 3782872);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 184 }, 3782874);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 223, 4, 20 }, 3782876);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 89 }, 3782880);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 165, 5, 4 }, 3782882);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 139, 6, 104 }, 3782886);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 9 }, 3782890);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 94, 8, 180, 8 }, 3782892);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 98 }, 3782900);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 145 }, 3782902);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 164 }, 3782904);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 229, 4, 24 }, 3782906);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 86 }, 3782910);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 166, 5, 253, 5, 95 }, 3782912);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 218, 6, 0 }, 3782918);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 122, 8, 212, 8, 252, 8 }, 3782922);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 122 }, 3782932);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 170 }, 3782934);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 192, 4, 15 }, 3782936);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 73 }, 3782940);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 151 }, 3782942);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 236, 5, 69 }, 3782944);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 163, 6, 59 }, 3782948);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 117, 8, 203, 8, 4 }, 3782952);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 12 }, 3782958);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 146 }, 3782964);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 196, 4, 245, 4, 73 }, 3782966);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 139 }, 3782972);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 215, 5, 52 }, 3782974);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 152, 6, 254, 6, 164, 7, 180, 8, 5 }, 3782978);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 25 }, 3782988);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 25 }, 3782990);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 166 }, 3782996);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 221, 4, 45 }, 3782998);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 138 }, 3783002);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 216, 5, 43 }, 3783004);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 146 }, 3783008);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 244, 6, 91 }, 3783010);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 13 }, 3783014);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 203, 8, 25 }, 3783016);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 25 }, 3783020);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 25 }, 3783022);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 205, 4, 8 }, 3783028);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 90 }, 3783032);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 193, 5, 25 }, 3783034);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 122 }, 3783038);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 232, 6, 71 }, 3783040);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 173, 7, 87 }, 3783044);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 206, 8, 16 }, 3783048);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16 }, 3783052);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16 }, 3783054);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 246, 4, 44 }, 3783060);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 123 }, 3783064);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 229, 5, 70 }, 3783066);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 180, 6, 42 }, 3783070);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 142, 7, 222, 7, 92 }, 3783074);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 212, 8, 16 }, 3783080);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16 }, 3783084);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16 }, 3783086);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 61 }, 3783092);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 110 }, 3783094);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 180, 5, 10 }, 3783096);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 97 }, 3783100);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 194, 6, 45 }, 3783102);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 145, 7, 228, 7, 92 }, 3783106);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 212, 8, 16 }, 3783112);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16 }, 3783116);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16 }, 3783118);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 131 }, 3783124);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 175 }, 3783126);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 236, 5, 46 }, 3783128);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 123 }, 3783132);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 207, 6, 48 }, 3783134);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 147, 7, 234, 7, 92 }, 3783138);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 212, 8, 16 }, 3783144);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16 }, 3783148);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16 }, 3783150);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 160 }, 3783156);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 188, 5, 237, 5, 46 }, 3783158);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 125 }, 3783164);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 209, 6, 43 }, 3783166);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 135, 7, 222, 7, 87 }, 3783170);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 212, 8, 16 }, 3783176);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16 }, 3783180);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16 }, 3783182);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 188, 5, 200, 5, 238, 5, 45 }, 3783188);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 127 }, 3783196);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 210, 6, 38 }, 3783198);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 122 }, 3783202);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 210, 7, 82 }, 3783204);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 212, 8, 16 }, 3783208);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16 }, 3783212);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16 }, 3783214);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 157 }, 3783364);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 61 }, 3783366);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 101 }, 3783368);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 191, 4, 251, 4, 25 }, 3783370);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 80 }, 3783376);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 125 }, 3783378);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 195, 5, 245, 5, 250, 5, 250, 5, 250, 5 }, 3783380);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 252, 3, 136 }, 3783392);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 20 }, 3783396);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 110 }, 3783398);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 150 }, 3783400);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 190, 5, 255, 5, 79 }, 3783402);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 159, 6, 8 }, 3783408);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 108 }, 3783412);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 108 }, 3783414);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 108, 7 }, 3783416);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 86 }, 3783420);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 246, 4, 120 }, 3783422);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 220, 5, 64 }, 3783426);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 99 }, 3783430);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 139 }, 3783432);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 149, 6, 33 }, 3783434);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 138, 7, 188, 7, 188, 7, 188, 7 }, 3783438);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 146 }, 3783448);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 20 }, 3783450);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 165 }, 3783452);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 44 }, 3783454);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 114 }, 3783456);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 194, 6, 23 }, 3783458);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 43 }, 3783462);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 143, 7, 218, 7, 17 }, 3783464);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 32 }, 3783470);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 32 }, 3783472);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 226, 4, 80 }, 3783476);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 245, 5, 74 }, 3783480);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 194, 6, 58 }, 3783484);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 128 }, 3783488);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 158, 7, 17 }, 3783490);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 62 }, 3783494);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 102, 8, 102, 8, 102, 8 }, 3783496);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 0 }, 3783504);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 140 }, 3783506);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 240, 5, 144 }, 3783508);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 28 }, 3783512);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 148, 7, 198, 7, 218, 7, 42 }, 3783514);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 52 }, 3783522);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 72 }, 3783524);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 72 }, 3783526);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 72 }, 3783528);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 50 }, 3783532);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 175 }, 3783534);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 14 }, 3783536);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 204, 6, 108 }, 3783538);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 198, 7, 253, 7, 12 }, 3783542);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 32 }, 3783548);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 32 }, 3783550);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 32 }, 3783552);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 32 }, 3783554);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 32 }, 3783556);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 120 }, 3783560);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 205, 5, 54 }, 3783562);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 8 }, 3783566);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 168, 7, 2 }, 3783568);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 2 }, 3783572);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 7 }, 3783574);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 7 }, 3783576);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 7 }, 3783578);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 7 }, 3783580);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 7 }, 3783582);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 7 }, 3783584);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 145 }, 3783588);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 230, 5, 134 }, 3783590);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 48 }, 3783594);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 253, 7, 52 }, 3783596);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 52 }, 3783600);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 12 }, 3783602);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 2 }, 3783604);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 2 }, 3783606);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 238, 7, 238, 7, 238, 7 }, 3783608);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 160 }, 3783616);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 24 }, 3783618);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 184, 6, 108 }, 3783620);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 178, 7, 238, 7, 238, 7, 238, 7, 238, 7, 238, 7, 188, 7, 188, 7, 188, 7 }, 3783624);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 170 }, 3783644);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 64 }, 3783646);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 214, 6, 98 }, 3783648);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 118 }, 3783652);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 123 }, 3783654);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 123 }, 3783656);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 123 }, 3783658);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 123, 7, 178, 7, 188, 7, 188, 7, 188, 7 }, 3783660);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 190, 5, 84 }, 3783672);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 234, 6, 118 }, 3783676);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 138 }, 3783680);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 143, 7, 143, 7, 143, 7, 28 }, 3783682);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 28 }, 3783690);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 28 }, 3783692);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 28 }, 3783694);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 28 }, 3783696);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 207, 3, 36 }, 3783944);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 176 }, 3783948);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 70 }, 3783950);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 130 }, 3783952);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 190, 5, 240, 5, 19 }, 3783954);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 19 }, 3783960);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 19 }, 3783962);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 24 }, 3783964);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 250, 5, 250, 5 }, 3783966);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 212, 3, 81 }, 3783972);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 206, 4, 70 }, 3783976);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 195, 5, 64 }, 3783980);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 189, 6, 8 }, 3783984);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 43 }, 3783988);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 53 }, 3783990);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 108 }, 3783992);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 108 }, 3783994);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 108, 7 }, 3783996);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 6 }, 3784000);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 136 }, 3784002);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 30 }, 3784004);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 110 }, 3784006);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 14 }, 3784008);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 149 }, 3784010);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 78 }, 3784012);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 108 }, 3784014);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 133, 7, 158, 7, 188, 7, 188, 7, 188, 7 }, 3784016);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 56 }, 3784028);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 176 }, 3784030);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 55 }, 3784032);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 180, 5, 84 }, 3784034);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 244, 6, 143, 7, 173, 7, 238, 7, 248, 7, 17 }, 3784038);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 32 }, 3784050);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 32 }, 3784052);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 86 }, 3784056);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 221, 4, 150 }, 3784058);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 240, 5, 194, 6, 108 }, 3784062);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 233, 7, 72 }, 3784068);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 152, 8, 152, 8, 152, 8, 152, 8, 152, 8 }, 3784072);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 86 }, 3784084);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 236, 4, 150 }, 3784086);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 250, 5, 204, 6, 123 }, 3784090);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 12 }, 3784096);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 117, 8, 152, 8, 152, 8, 152, 8, 152, 8, 152, 8 }, 3784098);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 86 }, 3784112);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 0 }, 3784114);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 150 }, 3784116);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 4 }, 3784118);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224, 6, 123 }, 3784120);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 12 }, 3784124);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 32 }, 3784126);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 82 }, 3784128);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 82 }, 3784130);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 82 }, 3784132);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 82 }, 3784134);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 82 }, 3784136);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 86 }, 3784140);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 0 }, 3784142);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 160 }, 3784144);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 24 }, 3784146);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 229, 6, 123 }, 3784148);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 2 }, 3784152);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 32 }, 3784154);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 62 }, 3784156);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 62 }, 3784158);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 62 }, 3784160);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 62 }, 3784162);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 62 }, 3784164);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 86 }, 3784168);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 0 }, 3784170);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 160 }, 3784172);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 24 }, 3784174);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 239, 6, 123 }, 3784176);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 238, 7, 22 }, 3784180);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 42 }, 3784184);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 42 }, 3784186);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 42 }, 3784188);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 42 }, 3784190);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 42 }, 3784192);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 86 }, 3784196);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 70 }, 3784198);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 180, 5, 59 }, 3784200);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 28 }, 3784204);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 128 }, 3784206);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 223, 7, 223, 7, 223, 7, 223, 7, 188, 7, 188, 7, 188, 7 }, 3784208);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 126 }, 3784224);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 70 }, 3784226);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 200, 5, 74 }, 3784228);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 38 }, 3784232);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 138, 7, 173, 7, 173, 7, 173, 7, 173, 7, 188, 7, 188, 7, 188, 7 }, 3784234);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 220, 5, 169, 6, 169, 6, 28 }, 3784252);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 108 }, 3784260);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 108 }, 3784262);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 108 }, 3784264);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 108 }, 3784266);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 28 }, 3784268);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 28 }, 3784270);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 28 }, 3784272);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 28 }, 3784274);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 28 }, 3784276);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 40 }, 3786384);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 69 }, 3786386);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 101 }, 3786388);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 136 }, 3786390);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 169 }, 3786392);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 206, 4, 243, 4, 26 }, 3786394);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 66 }, 3786400);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 133 }, 3786402);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 182, 5, 1 }, 3786404);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 4 }, 3786408);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 4 }, 3786410);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 101 }, 3786416);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 143 }, 3786418);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 183 }, 3786420);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 237, 4, 35 }, 3786422);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 81 }, 3786426);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 127 }, 3786428);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 172, 5, 217, 5, 30 }, 3786430);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 101 }, 3786436);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 193, 6, 194, 6, 194, 6 }, 3786438);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 165 }, 3786448);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 210, 4, 6 }, 3786450);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 58 }, 3786454);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 109 }, 3786456);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 168, 5, 227, 5, 28 }, 3786458);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 85 }, 3786464);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 162, 6, 25 }, 3786466);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 128, 7, 138, 7, 138, 7 }, 3786470);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 205, 4, 6 }, 3786480);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 65 }, 3786484);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 125 }, 3786486);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 185, 5, 1 }, 3786488);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 74 }, 3786492);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 141 }, 3786494);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 207, 6, 40 }, 3786496);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 194, 7, 0 }, 3786500);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 12 }, 3786504);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 12 }, 3786506);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 231, 4, 46 }, 3786512);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 117 }, 3786516);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 190, 5, 3 }, 3786518);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 92 }, 3786522);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 173, 6, 248, 6, 71 }, 3786524);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 154, 7, 42 }, 3786530);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 125, 8, 132, 8, 132, 8 }, 3786534);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 236, 4, 55 }, 3786544);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 148 }, 3786548);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 232, 5, 52 }, 3786550);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 139 }, 3786554);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 219, 6, 43 }, 3786556);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 128, 7, 222, 7, 99, 8, 171, 8, 182, 8, 182, 8 }, 3786560);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 5 }, 3786576);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 100 }, 3786578);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 195, 5, 22 }, 3786580);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 103 }, 3786584);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 188, 6, 12 }, 3786586);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 103 }, 3786590);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 188, 7, 28 }, 3786592);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 129, 8, 181, 8, 192, 8, 192, 8 }, 3786596);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 11 }, 3786608);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 143 }, 3786610);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 0 }, 3786612);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 78 }, 3786614);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 159, 6, 244, 6, 51 }, 3786616);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 142, 7, 238, 7, 81 }, 3786622);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 144, 8, 179, 8, 192, 8, 192, 8 }, 3786628);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 11 }, 3786640);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 168 }, 3786642);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16 }, 3786644);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 78 }, 3786646);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 159, 6, 244, 6, 51 }, 3786648);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 142, 7, 238, 7, 81 }, 3786654);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 144, 8, 179, 8, 192, 8, 192, 8 }, 3786660);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 11 }, 3786672);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 168 }, 3786674);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16 }, 3786676);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 78 }, 3786678);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 159, 6, 244, 6, 51 }, 3786680);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 142, 7, 238, 7, 81 }, 3786686);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 144, 8, 179, 8, 192, 8, 192, 8 }, 3786692);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 11 }, 3786704);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 168 }, 3786706);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16 }, 3786708);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 78 }, 3786710);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 159, 6, 244, 6, 51 }, 3786712);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 142, 7, 238, 7, 81 }, 3786718);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 144, 8, 179, 8, 192, 8, 192, 8 }, 3786724);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 11 }, 3786736);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 168 }, 3786738);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16 }, 3786740);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 78 }, 3786742);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 159, 6, 244, 6, 51 }, 3786744);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 142, 7, 238, 7, 81 }, 3786750);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 144, 8, 179, 8, 192, 8, 192, 8 }, 3786756);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 11 }, 3786768);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 168 }, 3786770);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16 }, 3786772);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 78 }, 3786774);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 159, 6, 244, 6, 51 }, 3786776);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 142, 7, 238, 7, 81 }, 3786782);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 144, 8, 179, 8, 192, 8, 192, 8 }, 3786788);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 241, 3, 255, 3, 48 }, 3786964);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 66 }, 3786970);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 81 }, 3786972);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 122 }, 3786974);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 167 }, 3786976);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 223, 4, 44 }, 3786978);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 129 }, 3786982);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 3 }, 3786984);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 147, 6, 204, 6, 252, 6 }, 3786986);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 8 }, 3786996);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 49 }, 3786998);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 59 }, 3787000);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 100 }, 3787002);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 139 }, 3787004);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 192, 4, 39 }, 3787006);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 81 }, 3787010);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 150 }, 3787012);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 202, 5, 98 }, 3787014);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 15 }, 3787018);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 113, 7, 200, 7 }, 3787020);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 29 }, 3787028);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 72 }, 3787030);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 96 }, 3787032);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 149 }, 3787034);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 193, 4, 251, 4, 69 }, 3787036);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 180, 5, 240, 5, 34 }, 3787042);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 214, 6, 75 }, 3787048);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 4 }, 3787052);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 90, 8 }, 3787054);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 58 }, 3787060);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 105 }, 3787062);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 154 }, 3787064);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224, 4, 250, 4, 61 }, 3787066);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 146 }, 3787072);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 238, 5, 65 }, 3787074);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 123 }, 3787078);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 86 }, 3787080);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 228, 7, 162, 8, 202, 8 }, 3787082);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 87 }, 3787092);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 135 }, 3787094);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 212, 4, 40 }, 3787096);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 53 }, 3787100);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 136 }, 3787102);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 226, 5, 64 }, 3787104);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 143, 6, 235, 6, 158, 7, 52 }, 3787108);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 152, 8, 218, 8 }, 3787116);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 116 }, 3787124);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 166 }, 3787126);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 6 }, 3787128);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 97 }, 3787130);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 124 }, 3787132);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 205, 5, 47 }, 3787134);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 152, 6, 234, 6, 99 }, 3787138);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 2 }, 3787144);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 102, 8, 202, 8, 226, 8 }, 3787146);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 146 }, 3787156);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 201, 4, 20 }, 3787158);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 118 }, 3787162);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 201, 5, 33 }, 3787164);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 141 }, 3787168);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 244, 6, 71 }, 3787170);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 219, 7, 173, 8, 251, 8, 251, 8, 251, 8 }, 3787174);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 185 }, 3787188);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 244, 4, 65 }, 3787190);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 173, 5, 10 }, 3787194);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 112 }, 3787198);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 227, 6, 71 }, 3787200);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 173, 7, 87 }, 3787204);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 206, 8, 16 }, 3787208);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16 }, 3787212);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16 }, 3787214);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 246, 4, 44 }, 3787220);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 123 }, 3787224);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 229, 5, 70 }, 3787226);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 180, 6, 42 }, 3787230);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 142, 7, 222, 7, 92 }, 3787234);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 212, 8, 16 }, 3787240);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16 }, 3787244);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16 }, 3787246);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 61 }, 3787252);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 110 }, 3787254);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 180, 5, 10 }, 3787256);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 97 }, 3787260);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 194, 6, 45 }, 3787262);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 145, 7, 228, 7, 92 }, 3787266);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 212, 8, 16 }, 3787272);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16 }, 3787276);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16 }, 3787278);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 131 }, 3787284);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 175 }, 3787286);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 236, 5, 46 }, 3787288);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 123 }, 3787292);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 207, 6, 48 }, 3787294);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 147, 7, 234, 7, 92 }, 3787298);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 212, 8, 16 }, 3787304);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16 }, 3787308);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16 }, 3787310);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 160 }, 3787316);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 188, 5, 237, 5, 46 }, 3787318);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 125 }, 3787324);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 209, 6, 43 }, 3787326);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 135, 7, 222, 7, 87 }, 3787330);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 212, 8, 16 }, 3787336);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16 }, 3787340);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16 }, 3787342);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 188, 5, 200, 5, 238, 5, 45 }, 3787348);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 127 }, 3787356);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 210, 6, 38 }, 3787358);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 122 }, 3787362);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 210, 7, 82 }, 3787364);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 212, 8, 16 }, 3787368);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16 }, 3787372);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16 }, 3787374);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 6 }, 3787452);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 106 }, 3787454);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 156 }, 3787456);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 181, 4, 206, 4, 206, 4, 206, 4, 206, 4, 206, 4, 206, 4, 0 }, 3787458);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 0 }, 3787474);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 0 }, 3787476);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 0 }, 3787478);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 56 }, 3787480);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 126 }, 3787482);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 181, 4, 241, 4, 20 }, 3787484);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 60 }, 3787490);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 60 }, 3787492);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 60 }, 3787494);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 60 }, 3787496);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 60 }, 3787498);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 110 }, 3787500);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 110 }, 3787502);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 110 }, 3787504);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 110 }, 3787506);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 86 }, 3787508);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 146 }, 3787510);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 206, 4, 20 }, 3787512);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 90 }, 3787516);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 160, 5, 195, 5, 230, 5, 9 }, 3787518);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 29 }, 3787526);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 104 }, 3787528);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 114 }, 3787530);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 149, 6, 149, 6, 200, 5, 250, 5, 69 }, 3787532);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 129, 6, 194, 6, 13 }, 3787542);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 48 }, 3787548);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 88 }, 3787550);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 118, 7, 158, 7, 238, 7, 22 }, 3787552);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 32 }, 3787560);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 32 }, 3787562);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 58 }, 3787564);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 108, 7, 188, 7, 238, 7, 52 }, 3787566);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 122, 8, 162, 8, 202, 8, 232, 8, 232, 8, 26 }, 3787574);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 26 }, 3787586);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 26 }, 3787588);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 26 }, 3787590);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 138, 7, 188, 7, 248, 7, 32 }, 3787592);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 52 }, 3787600);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 162, 8, 232, 8, 46 }, 3787602);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 46 }, 3787608);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 71, 9, 96, 9, 96, 9, 96, 9, 96, 9, 228, 7, 2 }, 3787610);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 17 }, 3787624);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 32 }, 3787626);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 82 }, 3787628);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 177, 8, 242, 8, 46 }, 3787630);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 46 }, 3787636);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 71, 9, 96, 9, 96, 9, 96, 9, 96, 9, 228, 7, 2 }, 3787638);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 17 }, 3787652);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 32 }, 3787654);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 82 }, 3787656);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 192, 8, 16 }, 3787658);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 46 }, 3787662);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 46 }, 3787664);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 71, 9, 96, 9, 96, 9, 96, 9, 96, 9, 228, 7, 2 }, 3787666);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 32 }, 3787680);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 52 }, 3787682);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 97, 8, 192, 8, 16 }, 3787684);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 46 }, 3787690);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 46 }, 3787692);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 71, 9, 96, 9, 96, 9, 96, 9, 96, 9, 198, 7, 12 }, 3787694);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 52 }, 3787708);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 62 }, 3787710);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 112, 8, 192, 8, 16 }, 3787712);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 46 }, 3787718);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 46 }, 3787720);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 71, 9, 96, 9, 96, 9, 96, 9, 96, 9, 168, 7, 7 }, 3787722);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 32 }, 3787736);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 57 }, 3787738);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 112, 8, 192, 8, 16 }, 3787740);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 46 }, 3787746);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 46 }, 3787748);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 71, 9, 96, 9, 96, 9, 96, 9, 96, 9, 138, 7, 238, 7, 15 }, 3787750);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 49 }, 3787766);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 112, 8, 192, 8, 16 }, 3787768);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 46 }, 3787774);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 46 }, 3787776);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 71, 9, 96, 9, 96, 9, 96, 9, 96, 9, 73 }, 3787778);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 153, 7, 213, 7, 7 }, 3787790);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 52 }, 3787796);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 127, 8, 222, 8, 46 }, 3787798);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 46 }, 3787804);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 71, 9, 96, 9, 96, 9, 96, 9, 96, 9, 244, 6, 58 }, 3787806);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 118, 7, 178, 7, 233, 7, 52 }, 3787820);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 137, 8, 232, 8, 26 }, 3787828);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 71, 9, 96, 9, 106, 9, 106, 9, 106, 9, 164, 6, 234, 6, 38 }, 3787834);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 98 }, 3787850);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 153, 7, 218, 7, 27 }, 3787852);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 142, 8, 237, 8, 61 }, 3787858);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 91, 9, 96, 9, 96, 9, 96, 9, 187, 5, 250, 5, 66 }, 3787864);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 118 }, 3787878);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 158, 6, 225, 6, 46 }, 3787880);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 160, 7, 39 }, 3787886);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 143, 8, 42 }, 3787890);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 96, 9, 96, 9, 96, 9 }, 3787894);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 61 }, 3792474);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 211, 4, 140 }, 3792476);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 240, 5, 104 }, 3792480);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224, 6, 50 }, 3792484);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 168, 7, 168, 7, 168, 7 }, 3792488);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 126 }, 3792498);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 15 }, 3792500);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 44 }, 3792502);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 139 }, 3792504);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 244, 6, 103 }, 3792506);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 158, 7, 168, 7, 168, 7, 168, 7 }, 3792510);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 136 }, 3792522);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 55 }, 3792524);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 84 }, 3792526);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 10 }, 3792528);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 73 }, 3792530);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 253, 7, 102 }, 3792532);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 102, 8, 102, 8, 102, 8 }, 3792536);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 162 }, 3792546);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 127 }, 3792548);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 114 }, 3792550);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 108 }, 3792552);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 218, 7, 12 }, 3792554);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 63 }, 3792558);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 102, 8, 102, 8, 102, 8 }, 3792560);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 236, 4, 190, 5, 184, 6, 193, 7, 37 }, 3792570);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 52 }, 3792580);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 62 }, 3792582);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 112, 8, 112, 8, 112, 8 }, 3792584);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 246, 4, 220, 5, 244, 6, 208, 7, 42 }, 3792594);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 52 }, 3792604);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 72 }, 3792606);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 92 }, 3792608);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 92, 8, 92, 8 }, 3792610);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 251, 4, 220, 5, 234, 6, 190, 7, 208, 7, 12 }, 3792618);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 22 }, 3792630);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 52 }, 3792632);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 52 }, 3792634);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 52 }, 3792636);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 0 }, 3792642);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 220, 5, 224, 6, 138 }, 3792644);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 183, 7, 208, 7, 248, 7, 248, 7, 248, 7, 248, 7 }, 3792650);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 61 }, 3792814);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 211, 4, 140 }, 3792816);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 240, 5, 104 }, 3792820);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224, 6, 50 }, 3792824);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 168, 7, 168, 7, 168, 7 }, 3792828);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 126 }, 3792838);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 15 }, 3792840);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 44 }, 3792842);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 139 }, 3792844);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 244, 6, 103 }, 3792846);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 158, 7, 168, 7, 168, 7, 168, 7 }, 3792850);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 136 }, 3792862);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 55 }, 3792864);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 84 }, 3792866);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 10 }, 3792868);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 73 }, 3792870);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 253, 7, 102 }, 3792872);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 102, 8, 102, 8, 102, 8 }, 3792876);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 162 }, 3792886);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 127 }, 3792888);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 114 }, 3792890);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 108 }, 3792892);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 218, 7, 12 }, 3792894);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 63 }, 3792898);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 102, 8, 102, 8, 102, 8 }, 3792900);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 236, 4, 190, 5, 184, 6, 193, 7, 37 }, 3792910);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 52 }, 3792920);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 62 }, 3792922);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 112, 8, 112, 8, 112, 8 }, 3792924);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 246, 4, 220, 5, 244, 6, 208, 7, 42 }, 3792934);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 52 }, 3792944);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 72 }, 3792946);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 92 }, 3792948);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 92, 8, 92, 8 }, 3792950);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 251, 4, 220, 5, 234, 6, 190, 7, 208, 7, 12 }, 3792958);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 22 }, 3792970);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 52 }, 3792972);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 52 }, 3792974);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 52 }, 3792976);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 0 }, 3792982);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 220, 5, 224, 6, 138 }, 3792984);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 183, 7, 208, 7, 248, 7, 248, 7, 248, 7, 248, 7 }, 3792990);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 61 }, 3794844);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 140 }, 3794846);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 104 }, 3794848);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 168, 7, 168, 7, 168, 7, 168, 7 }, 3794850);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 136 }, 3794860);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 84 }, 3794862);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 73 }, 3794864);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 102 }, 3794866);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 102 }, 3794868);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 102, 8, 102, 8 }, 3794870);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 246, 4, 244, 6, 42 }, 3794876);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 92 }, 3794882);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 92 }, 3794884);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 92 }, 3794886);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 92, 8 }, 3794888);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 0 }, 3794892);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224, 6, 183, 7, 248, 7, 248, 7, 248, 7, 248, 7 }, 3794894);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 0 }, 3794908);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224, 6, 183, 7, 248, 7, 248, 7, 248, 7, 248, 7 }, 3794910);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 0 }, 3794924);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224, 6, 183, 7, 248, 7, 248, 7, 248, 7, 248, 7 }, 3794926);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 96, 34, 16 }, 3900294);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 104, 41, 204, 41, 98, 42, 248, 42, 248, 42, 248, 42 }, 3900298);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 18 }, 3900326);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 160, 40, 236, 44, 130, 45, 24, 46, 74, 46, 124, 46, 224, 46 }, 3900328);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 116, 39, 172, 43, 164, 46, 158, 47, 226, 49, 240, 50, 44, 51, 44, 51 }, 3900358);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 220, 40, 80, 45, 12, 48, 252, 48, 84, 51, 72, 53, 60, 55, 60, 55 }, 3900390);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 254, 41, 14 }, 3900422);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 252, 48, 110, 50, 188, 52, 10, 55, 164, 56, 164, 56 }, 3900426);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 94, 46, 70, 50, 162, 53, 134, 56, 6, 59, 200, 60, 98, 62, 128, 62 }, 3900454);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 78, 52, 234, 56, 110, 60, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62 }, 3900486);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 162, 58, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62 }, 3900518);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16, 59, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62 }, 3900550);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 200, 50, 200, 50, 200, 50, 200, 50, 200, 50, 200, 50, 200, 50, 200, 50 }, 3900582);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 64 }, 3900614);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 64 }, 3900616);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 64 }, 3900618);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 64 }, 3900620);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 64 }, 3900622);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 64 }, 3900624);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 64 }, 3900626);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 64 }, 3900628);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 172 }, 3900646);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 172 }, 3900648);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 172 }, 3900650);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 172 }, 3900652);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 172 }, 3900654);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 172 }, 3900656);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 172 }, 3900658);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 172 }, 3900660);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 96, 34, 32 }, 3909802);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 104, 41, 204, 41, 98, 42, 248, 42, 248, 42, 248, 42 }, 3909806);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 17 }, 3909834);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 159, 40, 236, 44, 130, 45, 24, 46, 74, 46, 124, 46, 224, 46 }, 3909836);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 116, 39, 172, 43, 164, 46, 158, 47, 226, 49, 243, 50, 44, 51, 44, 51 }, 3909866);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 220, 40, 80, 45, 12, 48, 252, 48, 84, 51, 72, 53, 60, 55, 60, 55 }, 3909898);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 254, 41, 14 }, 3909930);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 252, 48, 110, 50, 188, 52, 10, 55, 164, 56, 164, 56 }, 3909934);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 94, 46, 70, 50, 162, 53, 134, 56, 6, 59, 200, 60, 98, 62, 128, 62 }, 3909962);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 78, 52, 234, 56, 110, 60, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62 }, 3909994);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 162, 58, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62 }, 3910026);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16, 59, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62 }, 3910058);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 248, 57, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62 }, 3910090);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 64 }, 3910122);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 64 }, 3910124);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 64 }, 3910126);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 64 }, 3910128);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 64 }, 3910130);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 64 }, 3910132);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 64 }, 3910134);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 64 }, 3910136);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 61 }, 3910342);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 228, 37, 254, 41, 254, 41, 248, 42, 248, 42, 248, 42, 248, 42 }, 3910344);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 163, 37, 236, 39, 48, 42, 6 }, 3910374);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 130, 45, 224, 46, 224, 46, 224, 46 }, 3910382);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 104, 41, 138, 42, 231, 44, 94, 46, 56, 49, 194, 51, 194, 51, 194, 51 }, 3910406);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 36, 44, 176, 44, 63, 47, 202, 48, 72, 53, 60, 55, 60, 55, 60, 55 }, 3910438);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 170, 45, 8 }, 3910470);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 50, 144, 51, 10, 55, 164, 56, 164, 56, 164, 56 }, 3910475);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 221, 51, 162, 53, 134, 56, 6, 59, 200, 60, 98, 62, 128, 62, 128, 62 }, 3910502);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 234, 56, 110, 60, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62 }, 3910534);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62 }, 3910566);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 61 }, 3910922);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 254, 36, 60, 40, 254, 41, 248, 42, 248, 42, 248, 42, 248, 42 }, 3910924);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 128, 37, 236, 39, 48, 42, 6 }, 3910954);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 130, 45, 224, 46, 224, 46, 224, 46 }, 3910962);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 4 }, 3910986);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 138, 42, 231, 44, 94, 46, 56, 49, 194, 51, 194, 51, 194, 51 }, 3910988);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 92, 43, 176, 44, 63, 47, 202, 48, 72, 53, 60, 55, 60, 55, 60, 55 }, 3911018);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 236, 44, 18, 47 }, 3911050);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 50, 144, 51, 10, 55, 164, 56, 164, 56, 164, 56 }, 3911055);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 221, 51, 162, 53, 134, 56, 6, 59, 200, 60, 98, 62, 128, 62, 128, 62 }, 3911082);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 234, 56, 110, 60, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62 }, 3911114);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62 }, 3911146);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 128, 62, 128, 62, 128, 62, 128, 62 }, 3917452);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62 }, 3917464);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 184, 61, 184, 61, 184, 61, 184, 61, 184, 61, 184, 61, 184 }, 3920892);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 184 }, 3920930);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 184 }, 3920932);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 184 }, 3920934);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 184 }, 3920936);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 184 }, 3920938);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 128, 62, 128, 62, 184, 61, 184 }, 3923926);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 184, 11, 184, 11, 184, 11, 184, 11, 184, 11, 184, 11, 184, 11 }, 3924610);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15 }, 3924626);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 20, 15, 72, 13, 28, 12, 34, 11, 246, 9, 252, 8 }, 3924644);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 154, 16, 166, 14, 228, 12, 184, 11, 90, 10, 46, 9, 208, 7 }, 3924658);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 104, 16, 66, 14, 128, 12, 240, 10, 96, 9, 208, 7, 14, 6 }, 3924674);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 54, 16, 172, 13, 84, 11, 146, 9, 208, 7, 14, 6, 76, 4 }, 3924690);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 160, 15, 178, 12, 196, 9, 2, 8, 14, 6, 126, 4, 238, 2 }, 3924706);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 172, 13, 34, 11, 52, 8, 64, 6, 226, 4, 132, 3, 38, 2 }, 3924722);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 240, 10, 252, 8, 164, 6, 176, 4, 132, 3, 88, 2, 250, 0 }, 3924738);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 96, 9, 208, 7, 170, 5, 132, 3, 88, 2, 44, 1, 0, 0 }, 3924754);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 160, 15, 160, 15, 160, 15, 160, 15, 160, 15 }, 3924814);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 28 }, 3924830);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 160, 15, 252, 8, 64, 6, 232, 3 }, 3924832);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 170, 15, 228, 12, 8, 7, 176, 4, 244, 1 }, 3924846);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 90, 15, 28, 12, 20, 5, 188, 2, 150, 0 }, 3924862);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 38 }, 3924876);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 246, 14, 34, 11, 188, 2, 200, 0, 50, 0 }, 3924878);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 234, 16, 10, 15, 36, 14, 246, 9, 219, 1, 125, 0, 25, 0 }, 3924890);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 114, 16, 116, 14, 72, 13, 202, 8, 250, 0, 50, 0, 0, 0 }, 3924906);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 130, 15, 12, 13, 204, 11, 10, 5, 90, 0, 10, 0, 0, 0 }, 3924922);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 106, 14, 168, 12, 86, 9, 148, 2, 20, 0, 0, 0, 0, 0, 136, 14, 56, 14, 184, 11, 58, 7, 64, 1, 0, 0, 0, 0, 0, 0 }, 3924938);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62 }, 3925004);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 184, 11, 184, 11, 184, 11, 40, 10, 128, 12, 128, 12, 128, 12, 40, 10, 128, 12, 128, 12, 128, 12, 40, 10, 128, 12, 128, 12, 128, 12, 40, 10, 128, 12, 128, 12, 128, 12, 40, 10, 108, 12, 108, 12, 108, 12, 40, 10, 254, 11, 234, 11, 254, 11, 191, 9, 134, 11, 64, 11, 134, 11, 81, 9, 14, 11, 150, 10, 14, 11, 212, 8, 170, 10, 236, 9, 170, 10, 102, 8, 40, 10, 86, 9, 40, 10, 238, 7, 212, 8, 32, 8, 212, 8, 250, 5, 128, 7, 128, 7, 128, 7, 36 }, 3926040);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 220, 5, 220, 5, 220, 5, 8 }, 3926144);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 252, 3, 252, 3, 252, 3 }, 3926152);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 234, 1, 234, 1, 234, 1 }, 3926160);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 232, 3, 18, 7, 18, 7, 88, 12 }, 3979762);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 28, 12, 28, 12, 28, 12, 28, 12 }, 3979780);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 28, 12, 28, 12, 28, 12, 28, 12 }, 3979814);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 172, 13, 172, 13, 172, 13, 172, 13, 172, 13, 172, 13, 172, 13, 172, 13 }, 3979856);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 82, 8, 0, 0 }, 3979886);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 82, 8, 0, 0 }, 3979920);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 82, 8, 0, 0 }, 3979954);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 82, 8, 0, 0 }, 3979988);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 82, 8, 0, 0 }, 3980022);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 172, 13, 172, 13, 172, 13, 172, 13, 172, 13, 172, 13, 172, 13, 172, 13 }, 3980060);
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
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 230 },
         new byte[] { 255 }, 3151555, 3151555, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 230 },
             new byte[] { 255 }, 3151563, 3151563, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 230 },
             new byte[] { 255 }, 3151571, 3151571, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 230 },
             new byte[] { 255 }, 3151579, 3151579, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 230 },
             new byte[] { 255 }, 3151587, 3151587, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 230 },
             new byte[] { 255 }, 3151595, 3151595, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 230 },
             new byte[] { 255 }, 3151603, 3151603, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 230 },
             new byte[] { 255 }, 3151611, 3151611, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 230 },
             new byte[] { 255 }, 3151619, 3151619, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 218 },
             new byte[] { 255 }, 3151627, 3151627, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 203 },
             new byte[] { 255 }, 3151635, 3151635, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 187 },
             new byte[] { 255 }, 3151643, 3151643, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 171 },
             new byte[] { 255 }, 3151651, 3151651, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 155 },
             new byte[] { 255 }, 3151659, 3151659, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 230 },
             new byte[] { 255 }, 3151691, 3151691, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 230 },
             new byte[] { 255 }, 3151699, 3151699, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 230 },
             new byte[] { 255 }, 3151707, 3151707, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 230 },
             new byte[] { 255 }, 3151715, 3151715, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 230 },
             new byte[] { 255 }, 3151723, 3151723, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 230 },
             new byte[] { 255 }, 3151731, 3151731, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 230 },
             new byte[] { 255 }, 3151739, 3151739, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 230 },
             new byte[] { 255 }, 3151747, 3151747, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 230 },
             new byte[] { 255 }, 3151755, 3151755, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 218 },
             new byte[] { 255 }, 3151763, 3151763, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 203 },
             new byte[] { 255 }, 3151771, 3151771, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 187 },
             new byte[] { 255 }, 3151779, 3151779, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 171 },
             new byte[] { 255 }, 3151787, 3151787, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 155 },
             new byte[] { 255 }, 3151795, 3151795, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 200, 11, 200, 11, 200, 11, 40, 10, 128, 12, 128, 12, 128, 12, 40, 10, 128, 12, 128, 12, 128, 12, 40, 10, 128, 12, 128, 12, 128, 12, 40, 10, 128, 12, 128, 12, 128, 12, 40, 10, 108, 12, 108, 12, 108, 12, 40, 10, 254, 11, 234, 11, 254, 11, 191, 9, 139, 11, 71, 11, 139, 11, 85, 9, 14, 11, 150, 10, 14, 11, 212, 8, 170, 10, 236, 9, 170, 10, 102, 8, 40, 10, 86, 9, 40, 10, 238, 7, 212, 8, 32, 8, 212, 8, 250, 5, 128, 7, 128, 7, 128, 7, 36 },
             new byte[] { 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 174, 11, 189, 10, 174, 11, 31, 9, 39, 10, 88, 9, 39, 10, 224, 6, 160, 8, 160, 8, 160, 8, 195 }, 3151954, 3152056, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 220, 5, 220, 5, 220, 5, 8 },
             new byte[] { 189, 6, 189, 6, 189, 6, 86 }, 3152058, 3152064, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 252, 3, 252, 3, 252, 3 },
             new byte[] { 149, 4, 149, 4, 149, 4 }, 3152066, 3152071, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 234, 1, 234, 1, 234, 1 },
             new byte[] { 52, 2, 52, 2, 52, 2 }, 3152074, 3152079, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16, 14 },
             new byte[] { 48, 17 }, 3468270, 3468271, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16, 14 },
             new byte[] { 48, 17 }, 3468286, 3468287, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16, 14 },
             new byte[] { 48, 17 }, 3468302, 3468303, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16, 14 },
             new byte[] { 48, 17 }, 3468318, 3468319, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16, 14 },
             new byte[] { 48, 17 }, 3468334, 3468335, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16, 14 },
             new byte[] { 48, 17 }, 3468350, 3468351, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16, 14 },
             new byte[] { 48, 17 }, 3468366, 3468367, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16, 14 },
             new byte[] { 48, 17 }, 3468382, 3468383, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 6, 14 },
             new byte[] { 48, 17 }, 3468398, 3468399, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 240, 12, 83, 13 },
             new byte[] { 172, 13, 48, 17 }, 3468412, 3468415, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16, 12, 102, 12 },
             new byte[] { 172, 13, 48, 17 }, 3468428, 3468431, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 63, 11, 113, 11 },
             new byte[] { 172, 13, 48, 17 }, 3468444, 3468447, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 119, 10, 119, 10 },
             new byte[] { 172, 13, 48, 17 }, 3468460, 3468463, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 125, 9, 125, 9 },
             new byte[] { 172, 13, 48, 17 }, 3468476, 3468479, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16, 14 },
             new byte[] { 48, 17 }, 3468542, 3468543, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16, 14 },
             new byte[] { 48, 17 }, 3468558, 3468559, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16, 14 },
             new byte[] { 48, 17 }, 3468574, 3468575, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16, 14 },
             new byte[] { 48, 17 }, 3468590, 3468591, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16, 14 },
             new byte[] { 48, 17 }, 3468606, 3468607, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16, 14 },
             new byte[] { 48, 17 }, 3468622, 3468623, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 73 },
             new byte[] { 172 }, 3468636, 3468636, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16, 14 },
             new byte[] { 48, 17 }, 3468638, 3468639, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 212, 12, 16, 14 },
             new byte[] { 172, 13, 48, 17 }, 3468652, 3468655, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 99, 12, 6, 14 },
             new byte[] { 172, 13, 48, 17 }, 3468668, 3468671, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 141, 11, 83, 13 },
             new byte[] { 172, 13, 48, 17 }, 3468684, 3468687, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 197, 10, 102, 12 },
             new byte[] { 172, 13, 48, 17 }, 3468700, 3468703, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 10, 10, 113, 11 },
             new byte[] { 172, 13, 48, 17 }, 3468716, 3468719, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 93, 9, 119, 10 },
             new byte[] { 172, 13, 48, 17 }, 3468732, 3468735, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 187, 8, 125, 9 },
             new byte[] { 172, 13, 48, 17 }, 3468748, 3468751, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 90, 10, 246, 9, 196, 9, 96, 9, 152, 8, 52, 8, 108, 7, 170, 5 },
             new byte[] { 241, 12, 116, 12, 53, 12, 184, 11, 190, 10, 65, 10, 71, 9, 21, 7 }, 3589574, 3589589, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 190, 10, 128, 12, 228, 12, 220, 5, 244, 1 },
             new byte[] { 110, 13, 160, 15, 29, 16, 83, 7, 113, 2 }, 3589610, 3589619, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 190, 10, 208, 7, 96, 9, 240, 10, 234, 11 },
             new byte[] { 110, 13, 196, 9, 184, 11, 172, 13, 229, 14 }, 3589644, 3589653, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 190, 10, 128, 12, 116, 14, 16, 14, 22, 13 },
             new byte[] { 110, 13, 160, 15, 17, 18, 148, 17, 92, 16 }, 3589678, 3589687, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 52, 8, 158, 7, 108, 7, 108, 7, 164, 6, 120, 5, 188, 2 },
             new byte[] { 65, 10, 134, 9, 71, 9, 71, 9, 77, 8, 214, 6, 107, 3 }, 3589752, 3589765, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 210, 15, 210, 15, 206, 14, 16, 14, 102, 13, 208, 12, 190, 10, 2, 8, 210, 15, 210, 15, 206, 14, 16, 14, 102, 13, 208, 12, 190, 10, 2, 8, 210, 15, 210, 15, 206, 14, 16, 14, 102, 13, 208, 12, 190, 10, 2, 8, 210, 15, 210, 15, 206, 14, 16, 14, 102, 13, 208, 12, 190, 10, 2, 8, 210, 15, 210, 15, 206, 14, 16, 14, 102, 13, 208, 12, 190, 10, 2, 8, 210, 15, 210, 15, 206, 14, 16, 14, 1, 13, 208, 12, 190, 10, 2, 8, 168, 15, 188, 15, 206, 14, 16, 14, 168, 12, 171, 12, 140, 10, 2, 8, 100, 15, 153, 15, 181, 14, 16, 14, 88, 12, 98, 12, 231, 9, 248, 7, 18, 15, 83, 15, 119, 14, 245, 13, 18, 12, 31, 12, 146, 9, 233, 7, 197, 13, 252, 13, 89, 13, 60, 13, 87, 11, 87, 11, 49, 9, 198, 7, 140, 13, 187, 13, 27, 13, 241, 12, 52, 11, 57, 11, 41, 9, 188, 7, 173, 12, 246, 12, 53, 12, 199, 11, 225, 10, 215, 10, 230, 8, 133, 7, 53, 12, 143, 12, 159, 11, 14, 11, 133, 10, 118, 10, 162, 8, 66, 7 },
             new byte[] { 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17 }, 3589916, 3590123, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 72, 8, 72, 8, 35, 7, 187, 5, 229, 4, 106, 4, 29, 4, 225, 3, 139, 3, 160, 10, 160, 10, 125, 7, 4, 6, 73, 5, 0, 5, 169, 4, 86, 4, 239, 3, 72, 13, 72, 13, 45, 8, 227, 5, 143, 4, 13, 4, 209, 3, 152, 3, 72, 3, 106, 14, 106, 14, 170, 10, 9, 8, 167, 6, 247, 5, 127, 5, 33, 5, 163, 4, 216, 14, 216, 14, 64, 11, 159, 8, 61, 7, 131, 6, 243, 5, 120, 5, 7, 5, 216, 14, 216, 14, 47, 11, 155, 8, 95, 7, 157, 6, 17, 6, 147, 5, 27, 5, 46, 14, 46, 14, 234, 10, 245, 7, 118, 6, 214, 5, 97, 5, 240, 4, 93, 4, 212, 13, 212, 13, 134, 10, 154, 7, 55, 6, 196, 5, 111, 5, 35, 5, 181, 4, 22, 13, 22, 13, 33, 10, 105, 7, 232, 5, 109, 5, 4, 5, 170, 4, 57, 4, 98, 12, 98, 12, 13, 10, 245, 7, 71, 6, 147, 5, 47, 5, 216, 4, 116, 4, 64, 11, 64, 11, 109, 8, 37, 6, 146, 4, 3, 4, 202, 3, 149, 3, 105, 3, 122, 8, 122, 8, 107, 6, 7, 5, 136, 4, 26, 4, 215, 3, 132, 3, 65, 3 },
             new byte[] { 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17 }, 3590224, 3590439, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 184, 11, 184, 11, 184, 11, 184, 11, 184, 11, 184, 11, 184, 11, 184, 11, 115, 10, 232, 3 },
             new byte[] { 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15 }, 3591480, 3591499, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 26, 14, 26, 14, 26, 14, 26, 14, 46, 14, 46, 14, 46, 14, 46, 14, 46, 14, 46, 14, 46, 14, 46, 14, 46, 14, 46, 14, 46, 14, 46, 14, 115, 13, 115, 13, 115, 13, 115, 13, 26, 13, 26, 13, 26, 13, 26, 13, 191, 12, 191, 12, 191, 12, 191, 12, 90, 12, 90, 12, 90, 12, 90, 12, 20, 12, 20, 12, 20, 12, 20, 12, 159, 11, 159, 11, 159, 11, 159, 11, 33, 11, 33, 11, 33, 11, 33, 11, 140, 10, 140, 10, 140, 10, 140, 10, 66, 9, 66, 9, 66, 9, 66, 9, 188, 7, 188, 7, 188, 7, 188, 7, 230, 5, 230, 5, 230, 5, 230, 5, 232, 3, 232, 3, 232, 3, 232, 3, 188, 2, 188, 2, 188, 2, 188, 2 },
             new byte[] { 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 93, 13, 93, 13, 93, 13, 93, 13, 204, 12, 204, 12, 204, 12, 204, 12, 33, 12, 33, 12, 33, 12, 33, 12, 166, 10, 166, 10, 166, 10, 166, 10, 229, 8, 229, 8, 229, 8, 229, 8, 201, 6, 201, 6, 201, 6, 201, 6, 126, 4, 126, 4, 126, 4, 126, 4, 37, 3, 37, 3, 37, 3, 37, 3 }, 3591624, 3591759, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16, 14, 72, 13, 72, 13, 72, 13, 178, 10, 196, 9 },
             new byte[] { 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15 }, 3591894, 3591905, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 66, 9, 52, 8, 230, 5, 232, 3, 188, 2 },
             new byte[] { 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 166, 10, 111, 9, 201, 6, 126, 4, 37, 3 }, 3591960, 3591991, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 247, 39 },
             new byte[] { 223, 43 }, 3594400, 3594401, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 163 },
             new byte[] { 248 }, 3710830, 3710830, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16 },
             new byte[] { 106 }, 3710832, 3710832, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 128 },
             new byte[] { 224 }, 3710834, 3710834, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 241, 7, 87 },
             new byte[] { 87, 8, 194 }, 3710836, 3710838, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 183, 8, 16 },
             new byte[] { 39, 9, 132 }, 3710840, 3710842, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 114 },
             new byte[] { 235 }, 3710844, 3710844, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224, 9, 70 },
             new byte[] { 94, 10, 202 }, 3710846, 3710848, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 170, 10, 20 },
             new byte[] { 51, 11, 162 }, 3710850, 3710852, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 124, 11, 227, 11, 78 },
             new byte[] { 15, 12, 123, 12, 236 }, 3710854, 3710858, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 181, 12, 32 },
             new byte[] { 88, 13, 200 }, 3710860, 3710862, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 145, 13, 242, 13, 71 },
             new byte[] { 63, 14, 165, 14, 254 }, 3710864, 3710868, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 176, 14, 145, 15, 104, 16 },
             new byte[] { 108, 15, 88, 16, 58, 17 }, 3710870, 3710875, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 58 },
             new byte[] { 138 }, 3710910, 3710910, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 169 },
             new byte[] { 254 }, 3710912, 3710912, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 15 },
             new byte[] { 105 }, 3710914, 3710914, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 113 },
             new byte[] { 208 }, 3710916, 3710916, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 212, 7, 55 },
             new byte[] { 56, 8, 160 }, 3710918, 3710920, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 157, 8, 242, 8, 71 },
             new byte[] { 11, 9, 101, 9, 190 }, 3710922, 3710926, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 163, 9, 0 },
             new byte[] { 30, 10, 128 }, 3710928, 3710930, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 98 },
             new byte[] { 231 }, 3710932, 3710932, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 195, 10, 42 },
             new byte[] { 77, 11, 185 }, 3710934, 3710936, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 139, 11, 227, 11, 73 },
             new byte[] { 31, 12, 123, 12, 230 }, 3710938, 3710942, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 183, 12, 20 },
             new byte[] { 90, 13, 187 }, 3710944, 3710946, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 112, 13, 212, 13, 159, 14, 108, 15 },
             new byte[] { 28, 14, 133, 14, 90, 15, 49, 16 }, 3710948, 3710955, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 228, 5, 63 },
             new byte[] { 47, 6, 143 }, 3710990, 3710992, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 166 },
             new byte[] { 251 }, 3710994, 3710994, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 4 },
             new byte[] { 94 }, 3710996, 3710996, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 97 },
             new byte[] { 191 }, 3710998, 3710998, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 184, 7, 29 },
             new byte[] { 27, 8, 133 }, 3711000, 3711002, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 134 },
             new byte[] { 243 }, 3711004, 3711004, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 231, 8, 56 },
             new byte[] { 89, 9, 174 }, 3711006, 3711008, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 136, 9, 221, 9, 50 },
             new byte[] { 2, 10, 91, 10, 181 }, 3711010, 3711014, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 138, 10, 233, 10, 67 },
             new byte[] { 17, 11, 117, 11, 211 }, 3711016, 3711020, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 154, 11, 244, 11, 85 },
             new byte[] { 47, 12, 141, 12, 243 }, 3711022, 3711026, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 188, 12, 34 },
             new byte[] { 95, 13, 202 }, 3711028, 3711030, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 237, 13, 166, 14 },
             new byte[] { 159, 14, 98, 15 }, 3711032, 3711035, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 176 },
             new byte[] { 249 }, 3711070, 3711070, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 250, 5, 77 },
             new byte[] { 71, 6, 158 }, 3711072, 3711074, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 164 },
             new byte[] { 249 }, 3711076, 3711076, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 249, 6, 83 },
             new byte[] { 82, 7, 177 }, 3711078, 3711080, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 173, 7, 10 },
             new byte[] { 15, 8, 113 }, 3711082, 3711084, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 107 },
             new byte[] { 215 }, 3711086, 3711086, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 200, 8, 28 },
             new byte[] { 56, 9, 145 }, 3711088, 3711090, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 108 },
             new byte[] { 229 }, 3711092, 3711092, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 189, 9, 18 },
             new byte[] { 58, 10, 147 }, 3711094, 3711096, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 103 },
             new byte[] { 236 }, 3711098, 3711098, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 185, 10, 7 },
             new byte[] { 66, 11, 148 }, 3711100, 3711102, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 86 },
             new byte[] { 231 }, 3711104, 3711104, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 166, 11, 0 },
             new byte[] { 59, 12, 154 }, 3711106, 3711108, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 93 },
             new byte[] { 251 }, 3711110, 3711110, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 37 },
             new byte[] { 205 }, 3711112, 3711112, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 232, 13 },
             new byte[] { 154, 14 }, 3711114, 3711115, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 108 },
             new byte[] { 177 }, 3711150, 3711150, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 189, 5, 8 },
             new byte[] { 6, 6, 85 }, 3711152, 3711154, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 86 },
             new byte[] { 167 }, 3711156, 3711156, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 162 },
             new byte[] { 247 }, 3711158, 3711158, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 242, 6, 73 },
             new byte[] { 75, 7, 166 }, 3711160, 3711162, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 163, 7, 250, 7, 83 },
             new byte[] { 5, 8, 96, 8, 190 }, 3711164, 3711168, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 166, 8, 247, 8, 68 },
             new byte[] { 21, 9, 106, 9, 187 }, 3711170, 3711174, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 146, 9, 224, 9, 48 },
             new byte[] { 13, 10, 94, 10, 178 }, 3711176, 3711180, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 125, 10, 195, 10, 12 },
             new byte[] { 3, 11, 77, 11, 153 }, 3711182, 3711186, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 91 },
             new byte[] { 236 }, 3711188, 3711188, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 179, 11, 101, 12, 72 },
             new byte[] { 73, 12, 4, 13, 242 }, 3711190, 3711194, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 67 },
             new byte[] { 134 }, 3711230, 3711230, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 139 },
             new byte[] { 210 }, 3711232, 3711232, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 202, 5, 15 },
             new byte[] { 20, 6, 93 }, 3711234, 3711236, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 85 },
             new byte[] { 166 }, 3711238, 3711238, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 163 },
             new byte[] { 248 }, 3711240, 3711240, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 244, 6, 72 },
             new byte[] { 77, 7, 165 }, 3711242, 3711244, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 153 },
             new byte[] { 250 }, 3711246, 3711246, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 232, 7, 62 },
             new byte[] { 77, 8, 168 }, 3711248, 3711250, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 143 },
             new byte[] { 253 }, 3711252, 3711252, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 215, 8, 29 },
             new byte[] { 72, 9, 146 }, 3711254, 3711256, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 104 },
             new byte[] { 224 }, 3711258, 3711258, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 177, 9, 249, 9, 60 },
             new byte[] { 45, 10, 121, 10, 191 }, 3711260, 3711264, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 133, 10, 210, 10, 37 },
             new byte[] { 12, 11, 93, 11, 180 }, 3711266, 3711270, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 204, 11, 178, 12 },
             new byte[] { 99, 12, 85, 13 }, 3711272, 3711275, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 251, 4, 68 },
             new byte[] { 59, 5, 135 }, 3711310, 3711312, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 139 },
             new byte[] { 210 }, 3711314, 3711314, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 215, 5, 22 },
             new byte[] { 34, 6, 100 }, 3711316, 3711318, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 91 },
             new byte[] { 172 }, 3711320, 3711320, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 166 },
             new byte[] { 251 }, 3711322, 3711322, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 243, 6, 70 },
             new byte[] { 76, 7, 163 }, 3711324, 3711326, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 147 },
             new byte[] { 244 }, 3711328, 3711328, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 222, 7, 44 },
             new byte[] { 67, 8, 149 }, 3711330, 3711332, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 122 },
             new byte[] { 231 }, 3711334, 3711334, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 188, 8, 255, 8, 76 },
             new byte[] { 44, 9, 114, 9, 195 }, 3711336, 3711340, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 144, 9, 216, 9, 25 },
             new byte[] { 10, 10, 86, 10, 154 }, 3711342, 3711346, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 100 },
             new byte[] { 233 }, 3711348, 3711348, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 180, 10, 89 },
             new byte[] { 61, 11, 234 }, 3711350, 3711352, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 33 },
             new byte[] { 188 }, 3711354, 3711354, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 177 },
             new byte[] { 237 }, 3711390, 3711390, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 249, 4, 68 },
             new byte[] { 57, 5, 135 }, 3711392, 3711394, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 149 },
             new byte[] { 220 }, 3711396, 3711396, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 225, 5, 36 },
             new byte[] { 44, 6, 115 }, 3711398, 3711400, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 115 },
             new byte[] { 198 }, 3711402, 3711402, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 184, 6, 250, 6, 71 },
             new byte[] { 14, 7, 83, 7, 164 }, 3711404, 3711408, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 140 },
             new byte[] { 237 }, 3711410, 3711410, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 208, 7, 19 },
             new byte[] { 52, 8, 122 }, 3711412, 3711414, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 79 },
             new byte[] { 185 }, 3711416, 3711416, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 145 },
             new byte[] { 255 }, 3711418, 3711418, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 210, 8, 21 },
             new byte[] { 67, 9, 137 }, 3711420, 3711422, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 88 },
             new byte[] { 208 }, 3711424, 3711424, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 156, 9, 229, 9, 55 },
             new byte[] { 23, 10, 100, 10, 186 }, 3711426, 3711430, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 218, 10, 132, 11 },
             new byte[] { 101, 11, 23, 12 }, 3711432, 3711435, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 168, 97, 156, 99, 168, 97, 8, 82, 216, 89, 192, 93 },
             new byte[] { 48, 117, 48, 117, 48, 117, 48, 117, 48, 117, 48, 117 }, 3714808, 3714819, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 92, 204, 91, 88, 77, 252, 83, 4, 91, 100, 100, 124, 96, 96, 84, 16, 89, 240, 85 },
             new byte[] { 117, 48, 117, 48, 117, 48, 117, 48, 117, 48, 117, 48, 117, 48, 117, 48, 117, 48, 117 }, 3714821, 3714839, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 155 },
             new byte[] { 201 }, 3778028, 3778028, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 197 },
             new byte[] { 247 }, 3778030, 3778030, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 250, 3, 35 },
             new byte[] { 50, 4, 95 }, 3778032, 3778034, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 88 },
             new byte[] { 154 }, 3778036, 3778036, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 148 },
             new byte[] { 220 }, 3778038, 3778038, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 207, 4, 11 },
             new byte[] { 30, 5, 96 }, 3778040, 3778042, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 70 },
             new byte[] { 162 }, 3778044, 3778044, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 70 },
             new byte[] { 166 }, 3778046, 3778046, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 70 },
             new byte[] { 169 }, 3778048, 3778048, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 70 },
             new byte[] { 172 }, 3778050, 3778050, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 70 },
             new byte[] { 175 }, 3778052, 3778052, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 70 },
             new byte[] { 178 }, 3778054, 3778054, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 0 },
             new byte[] { 51 }, 3778060, 3778060, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 39 },
             new byte[] { 95 }, 3778062, 3778062, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 80 },
             new byte[] { 140 }, 3778064, 3778064, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 159 },
             new byte[] { 226 }, 3778066, 3778066, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 244, 4, 56 },
             new byte[] { 63, 5, 138 }, 3778068, 3778070, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 124 },
             new byte[] { 214 }, 3778072, 3778072, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 192, 5, 4 },
             new byte[] { 33, 6, 109 }, 3778074, 3778076, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 47 },
             new byte[] { 159 }, 3778078, 3778078, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 91 },
             new byte[] { 210 }, 3778080, 3778080, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 91 },
             new byte[] { 214 }, 3778082, 3778082, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 91 },
             new byte[] { 217 }, 3778084, 3778084, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 91 },
             new byte[] { 221 }, 3778086, 3778086, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 94 },
             new byte[] { 150 }, 3778092, 3778092, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 119 },
             new byte[] { 179 }, 3778094, 3778094, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 156 },
             new byte[] { 220 }, 3778096, 3778096, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16 },
             new byte[] { 90 }, 3778098, 3778098, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 110 },
             new byte[] { 192 }, 3778100, 3778100, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224, 5, 82 },
             new byte[] { 61, 6, 185 }, 3778102, 3778104, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 195, 6, 53 },
             new byte[] { 54, 7, 179 }, 3778106, 3778108, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 61 },
             new byte[] { 192 }, 3778110, 3778110, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 61 },
             new byte[] { 196 }, 3778112, 3778112, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 61 },
             new byte[] { 201 }, 3778114, 3778114, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 61 },
             new byte[] { 205 }, 3778116, 3778116, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 61 },
             new byte[] { 209 }, 3778118, 3778118, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 126 },
             new byte[] { 184 }, 3778124, 3778124, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 183 },
             new byte[] { 246 }, 3778126, 3778126, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 15 },
             new byte[] { 86 }, 3778128, 3778128, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 185, 5, 24 },
             new byte[] { 12, 6, 116 }, 3778130, 3778132, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 200, 6, 77 },
             new byte[] { 51, 7, 196 }, 3778134, 3778136, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 176, 7, 228, 7, 228, 7, 228, 7, 228, 7, 228, 7, 228, 7 },
             new byte[] { 50, 8, 110, 8, 115, 8, 120, 8, 124, 8, 129, 8, 134, 8 }, 3778138, 3778151, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 131 },
             new byte[] { 189 }, 3778156, 3778156, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 3 },
             new byte[] { 70 }, 3778158, 3778158, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 140 },
             new byte[] { 218 }, 3778160, 3778160, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 41 },
             new byte[] { 131 }, 3778162, 3778162, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 197, 6, 91 },
             new byte[] { 44, 7, 207 }, 3778164, 3778166, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 223, 7, 228, 7, 228, 7, 228, 7, 228, 7, 228, 7, 228, 7, 228, 7 },
             new byte[] { 96, 8, 106, 8, 110, 8, 115, 8, 120, 8, 124, 8, 129, 8, 134, 8 }, 3778168, 3778183, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 176 },
             new byte[] { 236 }, 3778188, 3778188, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 39 },
             new byte[] { 108 }, 3778190, 3778190, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 215, 5, 132 },
             new byte[] { 41, 6, 227 }, 3778192, 3778194, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 35 },
             new byte[] { 143 }, 3778196, 3778196, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 160, 7, 228, 7, 228, 7, 228, 7, 228, 7, 228, 7, 228, 7, 228, 7, 228, 7 },
             new byte[] { 24, 8, 101, 8, 106, 8, 110, 8, 115, 8, 120, 8, 124, 8, 129, 8, 134, 8 }, 3778198, 3778215, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 226, 4, 88 },
             new byte[] { 33, 5, 160 }, 3778220, 3778222, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 35 },
             new byte[] { 121 }, 3778224, 3778224, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 227, 6, 108 },
             new byte[] { 71, 7, 221 }, 3778226, 3778228, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 208, 7, 228, 7, 228, 7, 228, 7, 228, 7, 228, 7, 228, 7, 228, 7, 228, 7 },
             new byte[] { 75, 8, 101, 8, 106, 8, 110, 8, 115, 8, 120, 8, 124, 8, 129, 8, 134, 8 }, 3778230, 3778247, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 246, 4, 115 },
             new byte[] { 54, 5, 188 }, 3778252, 3778254, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 46 },
             new byte[] { 132 }, 3778256, 3778256, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224, 6, 93 },
             new byte[] { 68, 7, 205 }, 3778258, 3778260, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 188, 7, 228, 7, 228, 7, 228, 7, 228, 7, 228, 7, 228, 7, 228, 7, 228, 7 },
             new byte[] { 54, 8, 101, 8, 106, 8, 110, 8, 115, 8, 120, 8, 124, 8, 129, 8, 134, 8 }, 3778262, 3778279, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 0 },
             new byte[] { 64 }, 3778284, 3778284, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 132 },
             new byte[] { 206 }, 3778286, 3778286, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 56 },
             new byte[] { 143 }, 3778288, 3778288, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 213, 6, 66 },
             new byte[] { 57, 7, 176 }, 3778290, 3778292, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 168, 7, 208, 7, 208, 7, 208, 7, 208, 7, 208, 7, 208, 7, 208, 7, 208, 7 },
             new byte[] { 33, 8, 80, 8, 84, 8, 89, 8, 94, 8, 98, 8, 103, 8, 107, 8, 112, 8 }, 3778294, 3778311, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 0 },
             new byte[] { 64 }, 3778316, 3778316, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 170 },
             new byte[] { 246 }, 3778318, 3778318, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 94 },
             new byte[] { 183 }, 3778320, 3778320, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224, 6, 88 },
             new byte[] { 68, 7, 199 }, 3778322, 3778324, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 148, 7, 158, 7, 158, 7, 158, 7, 158, 7, 158, 7, 158, 7, 158, 7, 158, 7 },
             new byte[] { 11, 8, 27, 8, 31, 8, 36, 8, 40, 8, 45, 8, 49, 8, 54, 8, 58, 8 }, 3778326, 3778343, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 211, 4, 170 },
             new byte[] { 17, 5, 246 }, 3778348, 3778350, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 104 },
             new byte[] { 194 }, 3778352, 3778352, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 18 },
             new byte[] { 121 }, 3778354, 3778354, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 158, 7, 158, 7, 158, 7, 158, 7, 158, 7, 158, 7, 158, 7, 158, 7, 158, 7, 158, 7 },
             new byte[] { 18, 8, 22, 8, 27, 8, 31, 8, 36, 8, 40, 8, 45, 8, 49, 8, 54, 8, 58, 8 }, 3778356, 3778375, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 166 },
             new byte[] { 226 }, 3778380, 3778380, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 140 },
             new byte[] { 214 }, 3778382, 3778382, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 124 },
             new byte[] { 215 }, 3778384, 3778384, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 204, 6, 254, 6, 254, 6, 254, 6, 254, 6, 254, 6, 254, 6, 254, 6, 254, 6, 254, 6, 254, 6 },
             new byte[] { 47, 7, 104, 7, 108, 7, 112, 7, 116, 7, 121, 7, 125, 7, 129, 7, 133, 7, 137, 7, 141, 7 }, 3778386, 3778407, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 149 },
             new byte[] { 208 }, 3778412, 3778412, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 123 },
             new byte[] { 196 }, 3778414, 3778414, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 108 },
             new byte[] { 198 }, 3778416, 3778416, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 161, 6, 224, 6, 224, 6, 224, 6, 224, 6, 224, 6, 224, 6, 224, 6, 224, 6, 224, 6, 224, 6 },
             new byte[] { 2, 7, 72, 7, 76, 7, 80, 7, 84, 7, 88, 7, 93, 7, 97, 7, 101, 7, 105, 7, 109, 7 }, 3778418, 3778439, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 153 },
             new byte[] { 212 }, 3778608, 3778608, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 211, 4, 7 },
             new byte[] { 20, 5, 77 }, 3778610, 3778612, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 85 },
             new byte[] { 163 }, 3778614, 3778614, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 191, 5, 38 },
             new byte[] { 22, 6, 135 }, 3778616, 3778618, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 124 },
             new byte[] { 230 }, 3778620, 3778620, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 219, 6, 48 },
             new byte[] { 79, 7, 174 }, 3778622, 3778624, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 118 },
             new byte[] { 253 }, 3778626, 3778626, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 158, 7, 198, 7, 208, 7, 208, 7 },
             new byte[] { 45, 8, 92, 8, 107, 8, 112, 8 }, 3778628, 3778635, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 191 },
             new byte[] { 252 }, 3778640, 3778640, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 4 },
             new byte[] { 71 }, 3778642, 3778642, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 119 },
             new byte[] { 195 }, 3778644, 3778644, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 232, 5, 91 },
             new byte[] { 62, 6, 187 }, 3778646, 3778648, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 213, 6, 58 },
             new byte[] { 65, 7, 176 }, 3778650, 3778652, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 188, 7, 60 },
             new byte[] { 63, 8, 204 }, 3778654, 3778656, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 112, 8, 152, 8, 192, 8, 192, 8, 192, 8 },
             new byte[] { 9, 9, 57, 9, 105, 9, 110, 9, 115, 9 }, 3778658, 3778667, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 236, 4, 99 },
             new byte[] { 43, 5, 171 }, 3778672, 3778674, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 230, 5, 119 },
             new byte[] { 56, 6, 213 }, 3778676, 3778678, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 244, 6, 106 },
             new byte[] { 93, 7, 223 }, 3778680, 3778682, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 253, 7, 132, 8, 197, 8, 228, 8, 232, 8, 232, 8, 232, 8, 232, 8 },
             new byte[] { 128, 8, 20, 9, 95, 9, 133, 9, 143, 9, 148, 9, 153, 9, 158, 9 }, 3778684, 3778699, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 17 },
             new byte[] { 82 }, 3778704, 3778704, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 168 },
             new byte[] { 244 }, 3778706, 3778706, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 73 },
             new byte[] { 161 }, 3778708, 3778708, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 254, 6, 151, 7, 7 },
             new byte[] { 100, 7, 10, 8, 133 }, 3778710, 3778714, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 124, 8, 243, 8, 16 },
             new byte[] { 7, 9, 139, 9, 175 }, 3778716, 3778720, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16 },
             new byte[] { 180 }, 3778722, 3778722, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16 },
             new byte[] { 186 }, 3778724, 3778724, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16 },
             new byte[] { 191 }, 3778726, 3778726, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16 },
             new byte[] { 196 }, 3778728, 3778728, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16 },
             new byte[] { 202 }, 3778730, 3778730, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 50 },
             new byte[] { 117 }, 3778736, 3778736, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 231, 5, 150 },
             new byte[] { 54, 6, 242 }, 3778738, 3778740, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 67 },
             new byte[] { 173 }, 3778742, 3778742, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 231, 7, 102 },
             new byte[] { 95, 8, 234 }, 3778744, 3778746, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 183, 8, 16 },
             new byte[] { 69, 9, 169 }, 3778748, 3778750, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16 },
             new byte[] { 175 }, 3778752, 3778752, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16 },
             new byte[] { 180 }, 3778754, 3778754, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16 },
             new byte[] { 186 }, 3778756, 3778756, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16 },
             new byte[] { 191 }, 3778758, 3778758, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16 },
             new byte[] { 196 }, 3778760, 3778760, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16 },
             new byte[] { 202 }, 3778762, 3778762, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 178 },
             new byte[] { 251 }, 3778768, 3778768, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 71 },
             new byte[] { 155 }, 3778770, 3778770, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 198, 6, 68 },
             new byte[] { 37, 7, 174 }, 3778772, 3778774, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 231, 7, 142, 8, 194, 8, 16 },
             new byte[] { 95, 8, 21, 9, 81, 9, 169 }, 3778776, 3778782, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16 },
             new byte[] { 175 }, 3778784, 3778784, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16 },
             new byte[] { 180 }, 3778786, 3778786, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16 },
             new byte[] { 186 }, 3778788, 3778788, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16 },
             new byte[] { 191 }, 3778790, 3778790, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16 },
             new byte[] { 196 }, 3778792, 3778792, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16 },
             new byte[] { 202 }, 3778794, 3778794, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 3 },
             new byte[] { 80 }, 3778800, 3778800, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 145 },
             new byte[] { 233 }, 3778802, 3778802, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 236, 6, 52 },
             new byte[] { 77, 7, 157 }, 3778804, 3778806, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 226, 7, 142, 8, 211, 8, 16 },
             new byte[] { 90, 8, 21, 9, 99, 9, 169 }, 3778808, 3778814, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16 },
             new byte[] { 175 }, 3778816, 3778816, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16 },
             new byte[] { 180 }, 3778818, 3778818, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16 },
             new byte[] { 186 }, 3778820, 3778820, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16 },
             new byte[] { 191 }, 3778822, 3778822, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16 },
             new byte[] { 196 }, 3778824, 3778824, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16 },
             new byte[] { 202 }, 3778826, 3778826, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 34 },
             new byte[] { 113 }, 3778832, 3778832, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 162 },
             new byte[] { 251 }, 3778834, 3778834, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 232, 6, 51 },
             new byte[] { 73, 7, 156 }, 3778836, 3778838, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 226, 7, 142, 8, 245, 8, 16 },
             new byte[] { 90, 8, 21, 9, 135, 9, 169 }, 3778840, 3778846, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16 },
             new byte[] { 175 }, 3778848, 3778848, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16 },
             new byte[] { 180 }, 3778850, 3778850, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16 },
             new byte[] { 186 }, 3778852, 3778852, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16 },
             new byte[] { 191 }, 3778854, 3778854, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16 },
             new byte[] { 196 }, 3778856, 3778856, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16 },
             new byte[] { 202 }, 3778858, 3778858, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 4 },
             new byte[] { 81 }, 3778864, 3778864, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 140 },
             new byte[] { 228 }, 3778866, 3778866, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 205, 6, 8 },
             new byte[] { 44, 7, 110 }, 3778868, 3778870, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 226, 7, 142, 8, 14 },
             new byte[] { 90, 8, 21, 9, 162 }, 3778872, 3778876, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16 },
             new byte[] { 169 }, 3778878, 3778878, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16 },
             new byte[] { 175 }, 3778880, 3778880, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16 },
             new byte[] { 180 }, 3778882, 3778882, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16 },
             new byte[] { 186 }, 3778884, 3778884, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16 },
             new byte[] { 191 }, 3778886, 3778886, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16 },
             new byte[] { 196 }, 3778888, 3778888, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16 },
             new byte[] { 202 }, 3778890, 3778890, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 227, 5, 96 },
             new byte[] { 46, 6, 181 }, 3778896, 3778898, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 185, 6, 8 },
             new byte[] { 23, 7, 110 }, 3778900, 3778902, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 226, 7, 142, 8, 15 },
             new byte[] { 90, 8, 21, 9, 163 }, 3778904, 3778908, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16 },
             new byte[] { 169 }, 3778910, 3778910, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16 },
             new byte[] { 175 }, 3778912, 3778912, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16 },
             new byte[] { 180 }, 3778914, 3778914, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16 },
             new byte[] { 186 }, 3778916, 3778916, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16 },
             new byte[] { 191 }, 3778918, 3778918, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16 },
             new byte[] { 196 }, 3778920, 3778920, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16 },
             new byte[] { 202 }, 3778922, 3778922, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 190, 5, 28 },
             new byte[] { 8, 6, 110 }, 3778928, 3778930, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 164, 6, 8 },
             new byte[] { 1, 7, 110 }, 3778932, 3778934, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 208, 7, 142, 8, 6 },
             new byte[] { 70, 8, 21, 9, 153 }, 3778936, 3778940, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 6 },
             new byte[] { 159 }, 3778942, 3778942, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 6 },
             new byte[] { 164 }, 3778944, 3778944, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 6 },
             new byte[] { 169 }, 3778946, 3778946, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 6 },
             new byte[] { 175 }, 3778948, 3778948, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 6 },
             new byte[] { 180 }, 3778950, 3778950, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 6 },
             new byte[] { 185 }, 3778952, 3778952, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 6 },
             new byte[] { 191 }, 3778954, 3778954, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 190, 5, 210, 5, 164, 6, 8 },
             new byte[] { 8, 6, 32, 6, 1, 7, 110 }, 3778960, 3778966, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 208, 7, 142, 8, 172, 8, 172, 8, 172, 8, 172, 8, 172, 8, 172, 8, 172, 8, 172, 8 },
             new byte[] { 70, 8, 21, 9, 58, 9, 63, 9, 68, 9, 73, 9, 78, 9, 83, 9, 88, 9, 94, 9 }, 3778968, 3778987, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 190, 5, 210, 5, 164, 6, 8 },
             new byte[] { 8, 6, 32, 6, 1, 7, 110 }, 3778992, 3778998, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 208, 7, 208, 7, 208, 7, 208, 7, 208, 7, 208, 7, 208, 7, 208, 7, 208, 7, 208, 7 },
             new byte[] { 70, 8, 75, 8, 80, 8, 84, 8, 89, 8, 94, 8, 98, 8, 103, 8, 107, 8, 112, 8 }, 3779000, 3779019, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 111 },
             new byte[] { 168 }, 3779296, 3779296, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 201, 4, 190, 5, 39 },
             new byte[] { 10, 5, 16, 6, 131 }, 3779298, 3779302, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 104 },
             new byte[] { 204 }, 3779304, 3779304, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 124 },
             new byte[] { 230 }, 3779306, 3779306, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 139 },
             new byte[] { 250 }, 3779308, 3779308, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 204, 6, 234, 6, 158, 7, 228, 7, 228, 7 },
             new byte[] { 68, 7, 105, 7, 47, 8, 128, 8, 134, 8 }, 3779310, 3779319, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 146 },
             new byte[] { 205 }, 3779322, 3779322, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 40 },
             new byte[] { 110 }, 3779324, 3779324, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 220, 5, 134 },
             new byte[] { 47, 6, 231 }, 3779326, 3779328, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 249, 6, 56 },
             new byte[] { 102, 7, 174 }, 3779330, 3779332, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 98 },
             new byte[] { 223 }, 3779334, 3779334, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 118 },
             new byte[] { 250 }, 3779336, 3779336, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 138, 7, 2 },
             new byte[] { 21, 8, 155 }, 3779338, 3779340, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 222, 8, 222, 8 },
             new byte[] { 141, 9, 148, 9 }, 3779342, 3779345, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 226, 4, 105 },
             new byte[] { 33, 5, 178 }, 3779348, 3779350, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 245, 5, 144 },
             new byte[] { 74, 6, 242 }, 3779352, 3779354, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 38 },
             new byte[] { 149 }, 3779356, 3779356, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 103 },
             new byte[] { 224 }, 3779358, 3779358, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 148, 7, 162, 7, 238, 7, 67 },
             new byte[] { 21, 8, 41, 8, 128, 8, 225 }, 3779360, 3779366, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 6 },
             new byte[] { 185 }, 3779368, 3779368, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 6 },
             new byte[] { 191 }, 3779370, 3779370, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 5 },
             new byte[] { 69 }, 3779374, 3779374, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 120 },
             new byte[] { 194 }, 3779376, 3779376, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 14 },
             new byte[] { 100 }, 3779378, 3779378, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 179, 6, 121 },
             new byte[] { 23, 7, 238 }, 3779380, 3779382, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 157, 7, 218, 7, 253, 7, 27 },
             new byte[] { 25, 8, 95, 8, 138, 8, 176 }, 3779384, 3779390, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 162, 8, 46 },
             new byte[] { 71, 9, 228 }, 3779392, 3779394, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 46 },
             new byte[] { 234 }, 3779396, 3779396, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 34 },
             new byte[] { 100 }, 3779400, 3779400, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 145 },
             new byte[] { 220 }, 3779402, 3779402, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 37 },
             new byte[] { 124 }, 3779404, 3779404, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 244, 6, 148, 7, 240, 7, 4 },
             new byte[] { 92, 7, 10, 8, 113, 8, 140 }, 3779406, 3779412, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 27 },
             new byte[] { 170 }, 3779414, 3779414, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 102, 8, 202, 8, 51 },
             new byte[] { 0, 9, 114, 9, 233 }, 3779416, 3779420, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 51 },
             new byte[] { 239 }, 3779422, 3779422, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 42 },
             new byte[] { 108 }, 3779426, 3779426, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 155 },
             new byte[] { 231 }, 3779428, 3779428, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 44 },
             new byte[] { 132 }, 3779430, 3779430, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 254, 6, 168, 7, 42 },
             new byte[] { 102, 7, 31, 8, 175 }, 3779432, 3779436, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 52 },
             new byte[] { 191 }, 3779438, 3779438, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 112, 8, 137, 8, 26 },
             new byte[] { 5, 9, 38, 9, 200 }, 3779440, 3779444, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 56 },
             new byte[] { 238 }, 3779446, 3779446, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 56 },
             new byte[] { 245 }, 3779448, 3779448, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 57 },
             new byte[] { 124 }, 3779452, 3779452, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 4 },
             new byte[] { 85 }, 3779454, 3779454, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 126 },
             new byte[] { 218 }, 3779456, 3779456, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 88 },
             new byte[] { 197 }, 3779458, 3779458, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 220, 7, 82 },
             new byte[] { 87, 8, 218 }, 3779460, 3779462, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 122, 8, 152, 8, 167, 8, 36 },
             new byte[] { 10, 9, 48, 9, 70, 9, 210 }, 3779464, 3779470, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 61 },
             new byte[] { 244 }, 3779472, 3779472, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 61 },
             new byte[] { 250 }, 3779474, 3779474, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 96 },
             new byte[] { 165 }, 3779478, 3779478, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 34 },
             new byte[] { 117 }, 3779480, 3779480, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 179, 6, 153, 7, 52 },
             new byte[] { 18, 7, 10, 8, 180 }, 3779482, 3779486, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 97 },
             new byte[] { 234 }, 3779488, 3779488, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 127, 8, 162, 8, 182, 8, 66 },
             new byte[] { 15, 9, 59, 9, 86, 9, 243 }, 3779490, 3779496, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 66 },
             new byte[] { 249 }, 3779498, 3779498, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 66, 9 },
             new byte[] { 0, 10 }, 3779500, 3779501, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 184, 5, 101 },
             new byte[] { 1, 6, 187 }, 3779504, 3779506, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 8 },
             new byte[] { 108 }, 3779508, 3779508, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 223, 7, 92 },
             new byte[] { 84, 8, 222 }, 3779510, 3779512, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 112 },
             new byte[] { 249 }, 3779514, 3779514, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 132, 8, 172, 8, 232, 8, 96, 9, 96, 9, 96, 9 },
             new byte[] { 21, 9, 69, 9, 140, 9, 19, 10, 25, 10, 32, 10 }, 3779516, 3779527, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 208, 5, 114 },
             new byte[] { 26, 6, 201 }, 3779530, 3779532, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 64 },
             new byte[] { 167 }, 3779534, 3779534, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 12 },
             new byte[] { 132 }, 3779536, 3779536, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 102 },
             new byte[] { 233 }, 3779538, 3779538, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 117 },
             new byte[] { 255 }, 3779540, 3779540, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 134, 8, 177, 8, 46 },
             new byte[] { 23, 9, 75, 9, 215 }, 3779542, 3779546, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 66 },
             new byte[] { 243 }, 3779548, 3779548, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 66 },
             new byte[] { 249 }, 3779550, 3779550, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 66, 9 },
             new byte[] { 0, 10 }, 3779552, 3779553, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 204, 5, 170, 6, 66 },
             new byte[] { 22, 6, 4, 7, 169 }, 3779556, 3779560, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 52 },
             new byte[] { 174 }, 3779562, 3779562, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 117 },
             new byte[] { 249 }, 3779564, 3779564, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 130, 8, 152, 8, 202, 8, 61 },
             new byte[] { 13, 9, 42, 9, 101, 9, 231 }, 3779566, 3779572, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 61 },
             new byte[] { 237 }, 3779574, 3779574, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 61 },
             new byte[] { 244 }, 3779576, 3779576, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 61 },
             new byte[] { 250 }, 3779578, 3779578, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 204, 5, 170, 6, 66 },
             new byte[] { 22, 6, 4, 7, 169 }, 3779582, 3779586, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 52 },
             new byte[] { 174 }, 3779588, 3779588, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 117 },
             new byte[] { 249 }, 3779590, 3779590, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 130, 8, 152, 8, 202, 8, 252, 8, 252, 8, 252, 8, 252, 8 },
             new byte[] { 13, 9, 42, 9, 101, 9, 161, 9, 167, 9, 174, 9, 180, 9 }, 3779592, 3779605, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 126 },
             new byte[] { 184 }, 3779876, 3779876, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 252, 4, 117 },
             new byte[] { 63, 5, 194 }, 3779878, 3779880, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 248, 5, 119 },
             new byte[] { 81, 6, 220 }, 3779882, 3779884, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 134 },
             new byte[] { 240 }, 3779886, 3779886, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 139 },
             new byte[] { 250 }, 3779888, 3779888, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 219, 6, 43 },
             new byte[] { 84, 7, 175 }, 3779890, 3779892, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 188, 7, 228, 7, 228, 7 },
             new byte[] { 80, 8, 128, 8, 134, 8 }, 3779894, 3779899, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 161 },
             new byte[] { 220 }, 3779902, 3779902, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 20 },
             new byte[] { 89 }, 3779904, 3779904, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224, 5, 86 },
             new byte[] { 51, 6, 180 }, 3779906, 3779908, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 235, 6, 66 },
             new byte[] { 87, 7, 184 }, 3779910, 3779912, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 106 },
             new byte[] { 232 }, 3779914, 3779914, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 140, 7, 173, 7, 182, 8, 222, 8, 222, 8 },
             new byte[] { 17, 8, 58, 8, 92, 9, 141, 9, 148, 9 }, 3779916, 3779925, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 196, 4, 70 },
             new byte[] { 1, 5, 141 }, 3779928, 3779930, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 244, 5, 134 },
             new byte[] { 73, 6, 231 }, 3779932, 3779934, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 51 },
             new byte[] { 163 }, 3779936, 3779936, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 103 },
             new byte[] { 224 }, 3779938, 3779938, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 149, 7, 188, 7, 7 },
             new byte[] { 22, 8, 69, 8, 155 }, 3779940, 3779944, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 6 },
             new byte[] { 178 }, 3779946, 3779946, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 6 },
             new byte[] { 185 }, 3779948, 3779948, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 6 },
             new byte[] { 191 }, 3779950, 3779950, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 0 },
             new byte[] { 64 }, 3779954, 3779954, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 110 },
             new byte[] { 183 }, 3779956, 3779956, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 15 },
             new byte[] { 101 }, 3779958, 3779958, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 178, 6, 121 },
             new byte[] { 22, 7, 238 }, 3779960, 3779962, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 157, 7, 223, 7, 2 },
             new byte[] { 25, 8, 101, 8, 144 }, 3779964, 3779968, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 82 },
             new byte[] { 235 }, 3779970, 3779970, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 36 },
             new byte[] { 210 }, 3779972, 3779972, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 46 },
             new byte[] { 228 }, 3779974, 3779974, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 46 },
             new byte[] { 234 }, 3779976, 3779976, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 10 },
             new byte[] { 75 }, 3779980, 3779980, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 120 },
             new byte[] { 194 }, 3779982, 3779982, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 37 },
             new byte[] { 124 }, 3779984, 3779984, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 209, 6, 153, 7, 220, 7, 4 },
             new byte[] { 55, 7, 15, 8, 92, 8, 140 }, 3779986, 3779992, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 88 },
             new byte[] { 236 }, 3779994, 3779994, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 172, 8, 46 },
             new byte[] { 75, 9, 221 }, 3779996, 3779998, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 51 },
             new byte[] { 233 }, 3780000, 3780000, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 51 },
             new byte[] { 239 }, 3780002, 3780002, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 20 },
             new byte[] { 85 }, 3780006, 3780006, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 154 },
             new byte[] { 230 }, 3780008, 3780008, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 76 },
             new byte[] { 165 }, 3780010, 3780010, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 252, 6, 166, 7, 42 },
             new byte[] { 100, 7, 29, 8, 175 }, 3780012, 3780016, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 67 },
             new byte[] { 207 }, 3780018, 3780018, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 142, 8, 222, 8, 53 },
             new byte[] { 37, 9, 129, 9, 229 }, 3780020, 3780024, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 56 },
             new byte[] { 238 }, 3780026, 3780026, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 56 },
             new byte[] { 245 }, 3780028, 3780028, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 50 },
             new byte[] { 117 }, 3780032, 3780032, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 190, 5, 126 },
             new byte[] { 12, 6, 218 }, 3780034, 3780036, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 65 },
             new byte[] { 173 }, 3780038, 3780038, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 220, 7, 96 },
             new byte[] { 87, 8, 232 }, 3780040, 3780042, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 152, 8, 197, 8, 26 },
             new byte[] { 42, 9, 96, 9, 193 }, 3780044, 3780048, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 61 },
             new byte[] { 237 }, 3780050, 3780050, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 61 },
             new byte[] { 244 }, 3780052, 3780052, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 61 },
             new byte[] { 250 }, 3780054, 3780054, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 70 },
             new byte[] { 138 }, 3780058, 3780058, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 205, 5, 217, 6, 162, 7, 66 },
             new byte[] { 27, 6, 58, 7, 20, 8, 195 }, 3780060, 3780066, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 127, 8, 200, 8, 252, 8, 36 },
             new byte[] { 9, 9, 93, 9, 155, 9, 204 }, 3780068, 3780074, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 66 },
             new byte[] { 243 }, 3780076, 3780076, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 66 },
             new byte[] { 249 }, 3780078, 3780078, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 66, 9 },
             new byte[] { 0, 10 }, 3780080, 3780081, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 120 },
             new byte[] { 190 }, 3780084, 3780084, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 250, 5, 8 },
             new byte[] { 75, 6, 108 }, 3780086, 3780088, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 223, 7, 118 },
             new byte[] { 84, 8, 250 }, 3780090, 3780092, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 142, 8, 147, 8, 222, 8, 41 },
             new byte[] { 25, 9, 37, 9, 123, 9, 209 }, 3780094, 3780100, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 86, 9, 86, 9, 86, 9 },
             new byte[] { 8, 10, 15, 10, 21, 10 }, 3780102, 3780107, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 120 },
             new byte[] { 190 }, 3780110, 3780110, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 44 },
             new byte[] { 127 }, 3780112, 3780112, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 58 },
             new byte[] { 161 }, 3780114, 3780114, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 17 },
             new byte[] { 137 }, 3780116, 3780116, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 137, 8, 145, 8, 155, 8, 230, 8, 66 },
             new byte[] { 14, 9, 29, 9, 45, 9, 131, 9, 236 }, 3780118, 3780126, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 66 },
             new byte[] { 243 }, 3780128, 3780128, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 66 },
             new byte[] { 249 }, 3780130, 3780130, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 66, 9 },
             new byte[] { 0, 10 }, 3780132, 3780133, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 120 },
             new byte[] { 190 }, 3780136, 3780136, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 114 },
             new byte[] { 201 }, 3780138, 3780138, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 108 },
             new byte[] { 213 }, 3780140, 3780140, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 52 },
             new byte[] { 174 }, 3780142, 3780142, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 141, 8, 152, 8, 178, 8, 251, 8, 61 },
             new byte[] { 18, 9, 36, 9, 70, 9, 154, 9, 231 }, 3780144, 3780152, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 61 },
             new byte[] { 237 }, 3780154, 3780154, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 61 },
             new byte[] { 244 }, 3780156, 3780156, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 61 },
             new byte[] { 250 }, 3780158, 3780158, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 195, 5, 83 },
             new byte[] { 13, 6, 182 }, 3780162, 3780164, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 250, 7, 160, 8, 232, 8, 19 },
             new byte[] { 107, 8, 32, 9, 115, 9, 167 }, 3780166, 3780172, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 11 },
             new byte[] { 165 }, 3780174, 3780174, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 202, 8, 202, 8, 202, 8, 202, 8, 202, 8 },
             new byte[] { 101, 9, 108, 9, 114, 9, 120, 9, 126, 9 }, 3780176, 3780185, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 30 },
             new byte[] { 83 }, 3782804, 3782804, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 63 },
             new byte[] { 120 }, 3782806, 3782806, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 88 },
             new byte[] { 149 }, 3782808, 3782808, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 106 },
             new byte[] { 170 }, 3782810, 3782810, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 129 },
             new byte[] { 197 }, 3782812, 3782812, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 168 },
             new byte[] { 241 }, 3782814, 3782814, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 210, 4, 22 },
             new byte[] { 33, 5, 108 }, 3782816, 3782818, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 84 },
             new byte[] { 177 }, 3782820, 3782820, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 164, 5, 33 },
             new byte[] { 10, 6, 148 }, 3782822, 3782824, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 177, 6, 234, 6, 26 },
             new byte[] { 50, 7, 116, 7, 171 }, 3782826, 3782830, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 48 },
             new byte[] { 102 }, 3782836, 3782836, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 89 },
             new byte[] { 147 }, 3782838, 3782838, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 99 },
             new byte[] { 160 }, 3782840, 3782840, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 135 },
             new byte[] { 201 }, 3782842, 3782842, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 169 },
             new byte[] { 240 }, 3782844, 3782844, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 217, 4, 19 },
             new byte[] { 37, 5, 102 }, 3782846, 3782848, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 76 },
             new byte[] { 166 }, 3782850, 3782850, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 171, 5, 31 },
             new byte[] { 14, 6, 142 }, 3782852, 3782854, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 178, 6, 95 },
             new byte[] { 47, 7, 237 }, 3782856, 3782858, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 193, 7, 24 },
             new byte[] { 91, 8, 190 }, 3782860, 3782862, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 69 },
             new byte[] { 124 }, 3782868, 3782868, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 112 },
             new byte[] { 171 }, 3782870, 3782870, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 136 },
             new byte[] { 199 }, 3782872, 3782872, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 184 },
             new byte[] { 253 }, 3782874, 3782874, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 223, 4, 20 },
             new byte[] { 41, 5, 100 }, 3782876, 3782878, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 89 },
             new byte[] { 176 }, 3782880, 3782880, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 165, 5, 4 },
             new byte[] { 5, 6, 109 }, 3782882, 3782884, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 139, 6, 104 },
             new byte[] { 2, 7, 243 }, 3782886, 3782888, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 9 },
             new byte[] { 164 }, 3782890, 3782890, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 94, 8, 180, 8 },
             new byte[] { 4, 9, 102, 9 }, 3782892, 3782895, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 98 },
             new byte[] { 154 }, 3782900, 3782900, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 145 },
             new byte[] { 206 }, 3782902, 3782902, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 164 },
             new byte[] { 229 }, 3782904, 3782904, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 229, 4, 24 },
             new byte[] { 44, 5, 101 }, 3782906, 3782908, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 86 },
             new byte[] { 170 }, 3782910, 3782910, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 166, 5, 253, 5, 95 },
             new byte[] { 2, 6, 98, 6, 207 }, 3782912, 3782916, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 218, 6, 0 },
             new byte[] { 86, 7, 150 }, 3782918, 3782920, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 122, 8, 212, 8, 252, 8 },
             new byte[] { 30, 9, 132, 9, 180, 9 }, 3782922, 3782927, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 122 },
             new byte[] { 179 }, 3782932, 3782932, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 170 },
             new byte[] { 232 }, 3782934, 3782934, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 192, 4, 15 },
             new byte[] { 2, 5, 89 }, 3782936, 3782938, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 73 },
             new byte[] { 153 }, 3782940, 3782940, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 151 },
             new byte[] { 239 }, 3782942, 3782942, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 236, 5, 69 },
             new byte[] { 77, 6, 175 }, 3782944, 3782946, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 163, 6, 59 },
             new byte[] { 23, 7, 190 }, 3782948, 3782950, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 117, 8, 203, 8, 4 },
             new byte[] { 19, 9, 117, 9, 183 }, 3782952, 3782956, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 12 },
             new byte[] { 197 }, 3782958, 3782958, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 146 },
             new byte[] { 205 }, 3782964, 3782964, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 196, 4, 245, 4, 73 },
             new byte[] { 4, 5, 58, 5, 150 }, 3782966, 3782970, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 139 },
             new byte[] { 223 }, 3782972, 3782972, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 215, 5, 52 },
             new byte[] { 51, 6, 153 }, 3782974, 3782976, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 152, 6, 254, 6, 164, 7, 180, 8, 5 },
             new byte[] { 8, 7, 121, 7, 46, 8, 87, 9, 179 }, 3782978, 3782986, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 25 },
             new byte[] { 206 }, 3782988, 3782988, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 25 },
             new byte[] { 211 }, 3782990, 3782990, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 166 },
             new byte[] { 226 }, 3782996, 3782996, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 221, 4, 45 },
             new byte[] { 30, 5, 117 }, 3782998, 3783000, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 138 },
             new byte[] { 219 }, 3783002, 3783002, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 216, 5, 43 },
             new byte[] { 49, 6, 140 }, 3783004, 3783006, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 146 },
             new byte[] { 253 }, 3783008, 3783008, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 244, 6, 91 },
             new byte[] { 106, 7, 220 }, 3783010, 3783012, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 13 },
             new byte[] { 159 }, 3783014, 3783014, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 203, 8, 25 },
             new byte[] { 111, 9, 201 }, 3783016, 3783018, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 25 },
             new byte[] { 206 }, 3783020, 3783020, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 25 },
             new byte[] { 211 }, 3783022, 3783022, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 205, 4, 8 },
             new byte[] { 10, 5, 75 }, 3783028, 3783030, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 90 },
             new byte[] { 165 }, 3783032, 3783032, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 193, 5, 25 },
             new byte[] { 21, 6, 117 }, 3783034, 3783036, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 122 },
             new byte[] { 224 }, 3783038, 3783038, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 232, 6, 71 },
             new byte[] { 89, 7, 194 }, 3783040, 3783042, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 173, 7, 87 },
             new byte[] { 52, 8, 238 }, 3783044, 3783046, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 206, 8, 16 },
             new byte[] { 115, 9, 191 }, 3783048, 3783050, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16 },
             new byte[] { 196 }, 3783052, 3783052, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16 },
             new byte[] { 202 }, 3783054, 3783054, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 246, 4, 44 },
             new byte[] { 54, 5, 113 }, 3783060, 3783062, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 123 },
             new byte[] { 200 }, 3783064, 3783064, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 229, 5, 70 },
             new byte[] { 59, 6, 165 }, 3783066, 3783068, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 180, 6, 42 },
             new byte[] { 30, 7, 159 }, 3783070, 3783072, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 142, 7, 222, 7, 92 },
             new byte[] { 14, 8, 104, 8, 243 }, 3783074, 3783078, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 212, 8, 16 },
             new byte[] { 121, 9, 191 }, 3783080, 3783082, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16 },
             new byte[] { 196 }, 3783084, 3783084, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16 },
             new byte[] { 202 }, 3783086, 3783086, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 61 },
             new byte[] { 128 }, 3783092, 3783092, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 110 },
             new byte[] { 183 }, 3783094, 3783094, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 180, 5, 10 },
             new byte[] { 4, 6, 98 }, 3783096, 3783098, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 97 },
             new byte[] { 194 }, 3783100, 3783100, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 194, 6, 45 },
             new byte[] { 44, 7, 162 }, 3783102, 3783104, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 145, 7, 228, 7, 92 },
             new byte[] { 17, 8, 110, 8, 243 }, 3783106, 3783110, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 212, 8, 16 },
             new byte[] { 121, 9, 191 }, 3783112, 3783114, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16 },
             new byte[] { 196 }, 3783116, 3783116, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16 },
             new byte[] { 202 }, 3783118, 3783118, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 131 },
             new byte[] { 202 }, 3783124, 3783124, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 175 },
             new byte[] { 251 }, 3783126, 3783126, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 236, 5, 46 },
             new byte[] { 63, 6, 136 }, 3783128, 3783130, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 123 },
             new byte[] { 221 }, 3783132, 3783132, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 207, 6, 48 },
             new byte[] { 58, 7, 165 }, 3783134, 3783136, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 147, 7, 234, 7, 92 },
             new byte[] { 19, 8, 117, 8, 243 }, 3783138, 3783142, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 212, 8, 16 },
             new byte[] { 121, 9, 191 }, 3783144, 3783146, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16 },
             new byte[] { 196 }, 3783148, 3783148, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16 },
             new byte[] { 202 }, 3783150, 3783150, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 160 },
             new byte[] { 232 }, 3783156, 3783156, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 188, 5, 237, 5, 46 },
             new byte[] { 9, 6, 64, 6, 136 }, 3783158, 3783162, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 125 },
             new byte[] { 223 }, 3783164, 3783164, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 209, 6, 43 },
             new byte[] { 60, 7, 160 }, 3783166, 3783168, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 135, 7, 222, 7, 87 },
             new byte[] { 6, 8, 104, 8, 238 }, 3783170, 3783174, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 212, 8, 16 },
             new byte[] { 121, 9, 191 }, 3783176, 3783178, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16 },
             new byte[] { 196 }, 3783180, 3783180, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16 },
             new byte[] { 202 }, 3783182, 3783182, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 188, 5, 200, 5, 238, 5, 45 },
             new byte[] { 5, 6, 21, 6, 65, 6, 135 }, 3783188, 3783194, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 127 },
             new byte[] { 226 }, 3783196, 3783196, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 210, 6, 38 },
             new byte[] { 61, 7, 155 }, 3783198, 3783200, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 122 },
             new byte[] { 249 }, 3783202, 3783202, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 210, 7, 82 },
             new byte[] { 91, 8, 233 }, 3783204, 3783206, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 212, 8, 16 },
             new byte[] { 121, 9, 191 }, 3783208, 3783210, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16 },
             new byte[] { 196 }, 3783212, 3783212, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16 },
             new byte[] { 202 }, 3783214, 3783214, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 157 },
             new byte[] { 203 }, 3783364, 3783364, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 61 },
             new byte[] { 118 }, 3783366, 3783366, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 101 },
             new byte[] { 163 }, 3783368, 3783368, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 191, 4, 251, 4, 25 },
             new byte[] { 5, 5, 72, 5, 107 }, 3783370, 3783374, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 80 },
             new byte[] { 168 }, 3783376, 3783376, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 125 },
             new byte[] { 220 }, 3783378, 3783378, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 195, 5, 245, 5, 250, 5, 250, 5, 250, 5 },
             new byte[] { 42, 6, 100, 6, 109, 6, 113, 6, 116, 6 }, 3783380, 3783389, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 252, 3, 136 },
             new byte[] { 47, 4, 197 }, 3783392, 3783394, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 20 },
             new byte[] { 92 }, 3783396, 3783396, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 110 },
             new byte[] { 190 }, 3783398, 3783398, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 150 },
             new byte[] { 236 }, 3783400, 3783400, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 190, 5, 255, 5, 79 },
             new byte[] { 26, 6, 99, 6, 188 }, 3783402, 3783406, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 159, 6, 8 },
             new byte[] { 22, 7, 139 }, 3783408, 3783410, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 108 },
             new byte[] { 251 }, 3783412, 3783412, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 108 },
             new byte[] { 255 }, 3783414, 3783414, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 108, 7 },
             new byte[] { 4, 8 }, 3783416, 3783417, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 86 },
             new byte[] { 142 }, 3783420, 3783420, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 246, 4, 120 },
             new byte[] { 57, 5, 197 }, 3783422, 3783424, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 220, 5, 64 },
             new byte[] { 50, 6, 160 }, 3783426, 3783428, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 99 },
             new byte[] { 201 }, 3783430, 3783430, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 139 },
             new byte[] { 248 }, 3783432, 3783432, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 149, 6, 33 },
             new byte[] { 7, 7, 161 }, 3783434, 3783436, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 138, 7, 188, 7, 188, 7, 188, 7 },
             new byte[] { 22, 8, 81, 8, 85, 8, 90, 8 }, 3783438, 3783445, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 146 },
             new byte[] { 205 }, 3783448, 3783448, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 20 },
             new byte[] { 88 }, 3783450, 3783450, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 165 },
             new byte[] { 244 }, 3783452, 3783452, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 44 },
             new byte[] { 135 }, 3783454, 3783454, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 114 },
             new byte[] { 213 }, 3783456, 3783456, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 194, 6, 23 },
             new byte[] { 46, 7, 141 }, 3783458, 3783460, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 43 },
             new byte[] { 167 }, 3783462, 3783462, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 143, 7, 218, 7, 17 },
             new byte[] { 22, 8, 108, 8, 172 }, 3783464, 3783468, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 32 },
             new byte[] { 193 }, 3783470, 3783470, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 32 },
             new byte[] { 198 }, 3783472, 3783472, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 226, 4, 80 },
             new byte[] { 33, 5, 151 }, 3783476, 3783478, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 245, 5, 74 },
             new byte[] { 73, 6, 167 }, 3783480, 3783482, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 194, 6, 58 },
             new byte[] { 42, 7, 174 }, 3783484, 3783486, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 128 },
             new byte[] { 253 }, 3783488, 3783488, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 158, 7, 17 },
             new byte[] { 34, 8, 162 }, 3783490, 3783492, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 62 },
             new byte[] { 215 }, 3783494, 3783494, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 102, 8, 102, 8, 102, 8 },
             new byte[] { 7, 9, 13, 9, 18, 9 }, 3783496, 3783501, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 0 },
             new byte[] { 64 }, 3783504, 3783504, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 140 },
             new byte[] { 215 }, 3783506, 3783506, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 240, 5, 144 },
             new byte[] { 68, 6, 241 }, 3783508, 3783510, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 28 },
             new byte[] { 137 }, 3783512, 3783512, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 148, 7, 198, 7, 218, 7, 42 },
             new byte[] { 13, 8, 71, 8, 98, 8, 188 }, 3783514, 3783520, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 52 },
             new byte[] { 204 }, 3783522, 3783522, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 72 },
             new byte[] { 231 }, 3783524, 3783524, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 72 },
             new byte[] { 236 }, 3783526, 3783526, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 72 },
             new byte[] { 242 }, 3783528, 3783528, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 50 },
             new byte[] { 117 }, 3783532, 3783532, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 175 },
             new byte[] { 251 }, 3783534, 3783534, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 14 },
             new byte[] { 99 }, 3783536, 3783536, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 204, 6, 108 },
             new byte[] { 48, 7, 222 }, 3783538, 3783540, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 198, 7, 253, 7, 12 },
             new byte[] { 66, 8, 130, 8, 151 }, 3783542, 3783546, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 32 },
             new byte[] { 178 }, 3783548, 3783548, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 32 },
             new byte[] { 183 }, 3783550, 3783550, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 32 },
             new byte[] { 188 }, 3783552, 3783552, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 32 },
             new byte[] { 193 }, 3783554, 3783554, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 32 },
             new byte[] { 198 }, 3783556, 3783556, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 120 },
             new byte[] { 190 }, 3783560, 3783560, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 205, 5, 54 },
             new byte[] { 27, 6, 141 }, 3783562, 3783564, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 8 },
             new byte[] { 112 }, 3783566, 3783566, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 168, 7, 2 },
             new byte[] { 30, 8, 130 }, 3783568, 3783570, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 2 },
             new byte[] { 135 }, 3783572, 3783572, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 7 },
             new byte[] { 146 }, 3783574, 3783574, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 7 },
             new byte[] { 151 }, 3783576, 3783576, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 7 },
             new byte[] { 156 }, 3783578, 3783578, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 7 },
             new byte[] { 161 }, 3783580, 3783580, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 7 },
             new byte[] { 166 }, 3783582, 3783582, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 7 },
             new byte[] { 171 }, 3783584, 3783584, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 145 },
             new byte[] { 216 }, 3783588, 3783588, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 230, 5, 134 },
             new byte[] { 53, 6, 226 }, 3783590, 3783592, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 48 },
             new byte[] { 154 }, 3783594, 3783594, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 253, 7, 52 },
             new byte[] { 120, 8, 183 }, 3783596, 3783598, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 52 },
             new byte[] { 189 }, 3783600, 3783600, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 12 },
             new byte[] { 151 }, 3783602, 3783602, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 2 },
             new byte[] { 146 }, 3783604, 3783604, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 2 },
             new byte[] { 151 }, 3783606, 3783606, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 238, 7, 238, 7, 238, 7 },
             new byte[] { 134, 8, 139, 8, 144, 8 }, 3783608, 3783613, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 160 },
             new byte[] { 232 }, 3783616, 3783616, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 24 },
             new byte[] { 106 }, 3783618, 3783618, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 184, 6, 108 },
             new byte[] { 23, 7, 217 }, 3783620, 3783622, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 178, 7, 238, 7, 238, 7, 238, 7, 238, 7, 238, 7, 188, 7, 188, 7, 188, 7 },
             new byte[] { 40, 8, 109, 8, 114, 8, 119, 8, 124, 8, 129, 8, 81, 8, 85, 8, 90, 8 }, 3783624, 3783641, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 170 },
             new byte[] { 243 }, 3783644, 3783644, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 64 },
             new byte[] { 148 }, 3783646, 3783646, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 214, 6, 98 },
             new byte[] { 54, 7, 207 }, 3783648, 3783650, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 118 },
             new byte[] { 233 }, 3783652, 3783652, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 123 },
             new byte[] { 243 }, 3783654, 3783654, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 123 },
             new byte[] { 247 }, 3783656, 3783656, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 123 },
             new byte[] { 252 }, 3783658, 3783658, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 123, 7, 178, 7, 188, 7, 188, 7, 188, 7 },
             new byte[] { 1, 8, 65, 8, 81, 8, 85, 8, 90, 8 }, 3783660, 3783669, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 190, 5, 84 },
             new byte[] { 8, 6, 169 }, 3783672, 3783674, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 234, 6, 118 },
             new byte[] { 75, 7, 228 }, 3783676, 3783678, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 138 },
             new byte[] { 254 }, 3783680, 3783680, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 143, 7, 143, 7, 143, 7, 28 },
             new byte[] { 8, 8, 13, 8, 18, 8, 155 }, 3783682, 3783688, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 28 },
             new byte[] { 160 }, 3783690, 3783690, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 28 },
             new byte[] { 165 }, 3783692, 3783692, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 28 },
             new byte[] { 169 }, 3783694, 3783694, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 28 },
             new byte[] { 174 }, 3783696, 3783696, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 207, 3, 36 },
             new byte[] { 0, 4, 92 }, 3783944, 3783946, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 176 },
             new byte[] { 242 }, 3783948, 3783948, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 70 },
             new byte[] { 148 }, 3783950, 3783950, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 130 },
             new byte[] { 215 }, 3783952, 3783952, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 190, 5, 240, 5, 19 },
             new byte[] { 26, 6, 83, 6, 124 }, 3783954, 3783958, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 19 },
             new byte[] { 128 }, 3783960, 3783960, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 19 },
             new byte[] { 132 }, 3783962, 3783962, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 24 },
             new byte[] { 141 }, 3783964, 3783964, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 250, 5, 250, 5 },
             new byte[] { 113, 6, 116, 6 }, 3783966, 3783969, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 212, 3, 81 },
             new byte[] { 5, 4, 139 }, 3783972, 3783974, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 206, 4, 70 },
             new byte[] { 18, 5, 148 }, 3783976, 3783978, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 195, 5, 64 },
             new byte[] { 28, 6, 164 }, 3783980, 3783982, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 189, 6, 8 },
             new byte[] { 45, 7, 130 }, 3783984, 3783986, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 43 },
             new byte[] { 171 }, 3783988, 3783988, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 53 },
             new byte[] { 187 }, 3783990, 3783990, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 108 },
             new byte[] { 251 }, 3783992, 3783992, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 108 },
             new byte[] { 255 }, 3783994, 3783994, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 108, 7 },
             new byte[] { 4, 8 }, 3783996, 3783997, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 6 },
             new byte[] { 58 }, 3784000, 3784000, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 136 },
             new byte[] { 197 }, 3784002, 3784002, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 30 },
             new byte[] { 102 }, 3784004, 3784004, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 110 },
             new byte[] { 190 }, 3784006, 3784006, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 14 },
             new byte[] { 107 }, 3784008, 3784008, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 149 },
             new byte[] { 254 }, 3784010, 3784010, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 78 },
             new byte[] { 200 }, 3784012, 3784012, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 108 },
             new byte[] { 236 }, 3784014, 3784014, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 133, 7, 158, 7, 188, 7, 188, 7, 188, 7 },
             new byte[] { 12, 8, 43, 8, 81, 8, 85, 8, 90, 8 }, 3784016, 3784025, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 56 },
             new byte[] { 110 }, 3784028, 3784028, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 176 },
             new byte[] { 239 }, 3784030, 3784030, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 55 },
             new byte[] { 128 }, 3784032, 3784032, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 180, 5, 84 },
             new byte[] { 8, 6, 181 }, 3784034, 3784036, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 244, 6, 143, 7, 173, 7, 238, 7, 248, 7, 17 },
             new byte[] { 99, 7, 13, 8, 50, 8, 124, 8, 140, 8, 172 }, 3784038, 3784048, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 32 },
             new byte[] { 193 }, 3784050, 3784050, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 32 },
             new byte[] { 198 }, 3784052, 3784052, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 86 },
             new byte[] { 142 }, 3784056, 3784056, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 221, 4, 150 },
             new byte[] { 30, 5, 229 }, 3784058, 3784060, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 240, 5, 194, 6, 108 },
             new byte[] { 71, 6, 42, 7, 227 }, 3784062, 3784066, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 233, 7, 72 },
             new byte[] { 109, 8, 215 }, 3784068, 3784070, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 152, 8, 152, 8, 152, 8, 152, 8, 152, 8 },
             new byte[] { 50, 9, 56, 9, 61, 9, 67, 9, 72, 9 }, 3784072, 3784081, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 86 },
             new byte[] { 142 }, 3784084, 3784084, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 236, 4, 150 },
             new byte[] { 46, 5, 229 }, 3784086, 3784088, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 250, 5, 204, 6, 123 },
             new byte[] { 82, 6, 52, 7, 243 }, 3784090, 3784094, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 12 },
             new byte[] { 146 }, 3784096, 3784096, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 117, 8, 152, 8, 152, 8, 152, 8, 152, 8, 152, 8 },
             new byte[] { 7, 9, 50, 9, 56, 9, 61, 9, 67, 9, 72, 9 }, 3784098, 3784109, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 86 },
             new byte[] { 142 }, 3784112, 3784112, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 0 },
             new byte[] { 67 }, 3784114, 3784114, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 150 },
             new byte[] { 229 }, 3784116, 3784116, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 4 },
             new byte[] { 93 }, 3784118, 3784118, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224, 6, 123 },
             new byte[] { 74, 7, 243 }, 3784120, 3784122, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 12 },
             new byte[] { 146 }, 3784124, 3784124, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 32 },
             new byte[] { 172 }, 3784126, 3784126, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 82 },
             new byte[] { 231 }, 3784128, 3784128, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 82 },
             new byte[] { 236 }, 3784130, 3784130, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 82 },
             new byte[] { 242 }, 3784132, 3784132, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 82 },
             new byte[] { 247 }, 3784134, 3784134, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 82 },
             new byte[] { 252 }, 3784136, 3784136, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 86 },
             new byte[] { 142 }, 3784140, 3784140, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 0 },
             new byte[] { 67 }, 3784142, 3784142, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 160 },
             new byte[] { 239 }, 3784144, 3784144, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 24 },
             new byte[] { 114 }, 3784146, 3784146, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 229, 6, 123 },
             new byte[] { 79, 7, 243 }, 3784148, 3784150, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 2 },
             new byte[] { 135 }, 3784152, 3784152, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 32 },
             new byte[] { 172 }, 3784154, 3784154, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 62 },
             new byte[] { 210 }, 3784156, 3784156, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 62 },
             new byte[] { 215 }, 3784158, 3784158, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 62 },
             new byte[] { 220 }, 3784160, 3784160, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 62 },
             new byte[] { 226 }, 3784162, 3784162, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 62 },
             new byte[] { 231 }, 3784164, 3784164, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 86 },
             new byte[] { 142 }, 3784168, 3784168, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 0 },
             new byte[] { 67 }, 3784170, 3784170, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 160 },
             new byte[] { 239 }, 3784172, 3784172, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 24 },
             new byte[] { 114 }, 3784174, 3784174, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 239, 6, 123 },
             new byte[] { 90, 7, 243 }, 3784176, 3784178, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 238, 7, 22 },
             new byte[] { 114, 8, 162 }, 3784180, 3784182, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 42 },
             new byte[] { 188 }, 3784184, 3784184, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 42 },
             new byte[] { 194 }, 3784186, 3784186, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 42 },
             new byte[] { 199 }, 3784188, 3784188, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 42 },
             new byte[] { 204 }, 3784190, 3784190, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 42 },
             new byte[] { 209 }, 3784192, 3784192, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 86 },
             new byte[] { 142 }, 3784196, 3784196, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 70 },
             new byte[] { 141 }, 3784198, 3784198, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 180, 5, 59 },
             new byte[] { 4, 6, 151 }, 3784200, 3784202, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 28 },
             new byte[] { 137 }, 3784204, 3784204, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 128 },
             new byte[] { 248 }, 3784206, 3784206, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 223, 7, 223, 7, 223, 7, 223, 7, 188, 7, 188, 7, 188, 7 },
             new byte[] { 98, 8, 103, 8, 108, 8, 113, 8, 81, 8, 85, 8, 90, 8 }, 3784208, 3784221, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 126 },
             new byte[] { 184 }, 3784224, 3784224, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 70 },
             new byte[] { 141 }, 3784226, 3784226, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 200, 5, 74 },
             new byte[] { 25, 6, 167 }, 3784228, 3784230, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 38 },
             new byte[] { 148 }, 3784232, 3784232, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 138, 7, 173, 7, 173, 7, 173, 7, 173, 7, 188, 7, 188, 7, 188, 7 },
             new byte[] { 3, 8, 45, 8, 50, 8, 55, 8, 59, 8, 81, 8, 85, 8, 90, 8 }, 3784234, 3784249, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 220, 5, 169, 6, 169, 6, 28 },
             new byte[] { 39, 6, 3, 7, 7, 7, 133 }, 3784252, 3784258, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 108 },
             new byte[] { 222 }, 3784260, 3784260, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 108 },
             new byte[] { 227 }, 3784262, 3784262, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 108 },
             new byte[] { 232 }, 3784264, 3784264, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 108 },
             new byte[] { 236 }, 3784266, 3784266, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 28 },
             new byte[] { 155 }, 3784268, 3784268, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 28 },
             new byte[] { 160 }, 3784270, 3784270, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 28 },
             new byte[] { 165 }, 3784272, 3784272, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 28 },
             new byte[] { 169 }, 3784274, 3784274, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 28 },
             new byte[] { 174 }, 3784276, 3784276, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 40 },
             new byte[] { 93 }, 3786384, 3786384, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 69 },
             new byte[] { 126 }, 3786386, 3786386, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 101 },
             new byte[] { 162 }, 3786388, 3786388, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 136 },
             new byte[] { 202 }, 3786390, 3786390, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 169 },
             new byte[] { 240 }, 3786392, 3786392, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 206, 4, 243, 4, 26 },
             new byte[] { 26, 5, 68, 5, 112 }, 3786394, 3786398, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 66 },
             new byte[] { 158 }, 3786400, 3786400, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 133 },
             new byte[] { 233 }, 3786402, 3786402, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 182, 5, 1 },
             new byte[] { 33, 6, 117 }, 3786404, 3786406, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 4 },
             new byte[] { 124 }, 3786408, 3786408, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 4 },
             new byte[] { 127 }, 3786410, 3786410, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 101 },
             new byte[] { 157 }, 3786416, 3786416, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 143 },
             new byte[] { 204 }, 3786418, 3786418, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 183 },
             new byte[] { 249 }, 3786420, 3786420, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 237, 4, 35 },
             new byte[] { 53, 5, 113 }, 3786422, 3786424, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 81 },
             new byte[] { 165 }, 3786426, 3786426, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 127 },
             new byte[] { 217 }, 3786428, 3786428, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 172, 5, 217, 5, 30 },
             new byte[] { 12, 6, 63, 6, 141 }, 3786430, 3786434, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 101 },
             new byte[] { 221 }, 3786436, 3786436, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 193, 6, 194, 6, 194, 6 },
             new byte[] { 67, 7, 72, 7, 76, 7 }, 3786438, 3786443, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 165 },
             new byte[] { 224 }, 3786448, 3786448, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 210, 4, 6 },
             new byte[] { 19, 5, 76 }, 3786450, 3786452, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 58 },
             new byte[] { 134 }, 3786454, 3786454, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 109 },
             new byte[] { 191 }, 3786456, 3786456, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 168, 5, 227, 5, 28 },
             new byte[] { 1, 6, 67, 6, 131 }, 3786458, 3786462, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 85 },
             new byte[] { 196 }, 3786464, 3786464, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 162, 6, 25 },
             new byte[] { 26, 7, 158 }, 3786466, 3786468, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 128, 7, 138, 7, 138, 7 },
             new byte[] { 17, 8, 32, 8, 36, 8 }, 3786470, 3786475, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 205, 4, 6 },
             new byte[] { 10, 5, 73 }, 3786480, 3786482, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 65 },
             new byte[] { 138 }, 3786484, 3786484, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 125 },
             new byte[] { 205 }, 3786486, 3786486, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 185, 5, 1 },
             new byte[] { 16, 6, 96 }, 3786488, 3786490, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 74 },
             new byte[] { 177 }, 3786492, 3786492, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 141 },
             new byte[] { 252 }, 3786494, 3786494, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 207, 6, 40 },
             new byte[] { 70, 7, 170 }, 3786496, 3786498, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 194, 7, 0 },
             new byte[] { 83, 8, 154 }, 3786500, 3786502, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 12 },
             new byte[] { 172 }, 3786504, 3786504, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 12 },
             new byte[] { 177 }, 3786506, 3786506, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 231, 4, 46 },
             new byte[] { 38, 5, 115 }, 3786512, 3786514, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 117 },
             new byte[] { 193 }, 3786516, 3786516, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 190, 5, 3 },
             new byte[] { 18, 6, 94 }, 3786518, 3786520, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 92 },
             new byte[] { 192 }, 3786522, 3786522, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 173, 6, 248, 6, 71 },
             new byte[] { 26, 7, 110, 7, 199 }, 3786524, 3786528, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 154, 7, 42 },
             new byte[] { 36, 8, 195 }, 3786530, 3786532, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 125, 8, 132, 8, 132, 8 },
             new byte[] { 33, 9, 45, 9, 50, 9 }, 3786534, 3786539, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 236, 4, 55 },
             new byte[] { 43, 5, 125 }, 3786544, 3786546, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 148 },
             new byte[] { 226 }, 3786548, 3786548, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 232, 5, 52 },
             new byte[] { 62, 6, 146 }, 3786550, 3786552, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 139 },
             new byte[] { 242 }, 3786554, 3786554, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 219, 6, 43 },
             new byte[] { 75, 7, 164 }, 3786556, 3786558, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 128, 7, 222, 7, 99, 8, 171, 8, 182, 8, 182, 8 },
             new byte[] { 3, 8, 109, 8, 0, 9, 82, 9, 99, 9, 104, 9 }, 3786560, 3786571, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 5 },
             new byte[] { 69 }, 3786576, 3786576, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 100 },
             new byte[] { 172 }, 3786578, 3786578, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 195, 5, 22 },
             new byte[] { 20, 6, 111 }, 3786580, 3786582, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 103 },
             new byte[] { 200 }, 3786584, 3786584, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 188, 6, 12 },
             new byte[] { 38, 7, 127 }, 3786586, 3786588, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 103 },
             new byte[] { 228 }, 3786590, 3786590, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 188, 7, 28 },
             new byte[] { 68, 8, 175 }, 3786592, 3786594, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 129, 8, 181, 8, 192, 8, 192, 8 },
             new byte[] { 32, 9, 93, 9, 110, 9, 115, 9 }, 3786596, 3786603, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 11 },
             new byte[] { 76 }, 3786608, 3786608, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 143 },
             new byte[] { 217 }, 3786610, 3786610, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 0 },
             new byte[] { 84 }, 3786612, 3786612, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 78 },
             new byte[] { 170 }, 3786614, 3786614, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 159, 6, 244, 6, 51 },
             new byte[] { 3, 7, 98, 7, 169 }, 3786616, 3786620, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 142, 7, 238, 7, 81 },
             new byte[] { 14, 8, 121, 8, 232 }, 3786622, 3786626, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 144, 8, 179, 8, 192, 8, 192, 8 },
             new byte[] { 48, 9, 91, 9, 110, 9, 115, 9 }, 3786628, 3786635, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 11 },
             new byte[] { 76 }, 3786640, 3786640, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 168 },
             new byte[] { 244 }, 3786642, 3786642, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16 },
             new byte[] { 101 }, 3786644, 3786644, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 78 },
             new byte[] { 170 }, 3786646, 3786646, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 159, 6, 244, 6, 51 },
             new byte[] { 3, 7, 98, 7, 169 }, 3786648, 3786652, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 142, 7, 238, 7, 81 },
             new byte[] { 14, 8, 121, 8, 232 }, 3786654, 3786658, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 144, 8, 179, 8, 192, 8, 192, 8 },
             new byte[] { 48, 9, 91, 9, 110, 9, 115, 9 }, 3786660, 3786667, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 11 },
             new byte[] { 76 }, 3786672, 3786672, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 168 },
             new byte[] { 244 }, 3786674, 3786674, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16 },
             new byte[] { 101 }, 3786676, 3786676, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 78 },
             new byte[] { 170 }, 3786678, 3786678, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 159, 6, 244, 6, 51 },
             new byte[] { 3, 7, 98, 7, 169 }, 3786680, 3786684, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 142, 7, 238, 7, 81 },
             new byte[] { 14, 8, 121, 8, 232 }, 3786686, 3786690, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 144, 8, 179, 8, 192, 8, 192, 8 },
             new byte[] { 48, 9, 91, 9, 110, 9, 115, 9 }, 3786692, 3786699, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 11 },
             new byte[] { 76 }, 3786704, 3786704, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 168 },
             new byte[] { 244 }, 3786706, 3786706, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16 },
             new byte[] { 101 }, 3786708, 3786708, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 78 },
             new byte[] { 170 }, 3786710, 3786710, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 159, 6, 244, 6, 51 },
             new byte[] { 3, 7, 98, 7, 169 }, 3786712, 3786716, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 142, 7, 238, 7, 81 },
             new byte[] { 14, 8, 121, 8, 232 }, 3786718, 3786722, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 144, 8, 179, 8, 192, 8, 192, 8 },
             new byte[] { 48, 9, 91, 9, 110, 9, 115, 9 }, 3786724, 3786731, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 11 },
             new byte[] { 76 }, 3786736, 3786736, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 168 },
             new byte[] { 244 }, 3786738, 3786738, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16 },
             new byte[] { 101 }, 3786740, 3786740, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 78 },
             new byte[] { 170 }, 3786742, 3786742, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 159, 6, 244, 6, 51 },
             new byte[] { 3, 7, 98, 7, 169 }, 3786744, 3786748, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 142, 7, 238, 7, 81 },
             new byte[] { 14, 8, 121, 8, 232 }, 3786750, 3786754, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 144, 8, 179, 8, 192, 8, 192, 8 },
             new byte[] { 48, 9, 91, 9, 110, 9, 115, 9 }, 3786756, 3786763, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 11 },
             new byte[] { 76 }, 3786768, 3786768, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 168 },
             new byte[] { 244 }, 3786770, 3786770, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16 },
             new byte[] { 101 }, 3786772, 3786772, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 78 },
             new byte[] { 170 }, 3786774, 3786774, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 159, 6, 244, 6, 51 },
             new byte[] { 3, 7, 98, 7, 169 }, 3786776, 3786780, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 142, 7, 238, 7, 81 },
             new byte[] { 14, 8, 121, 8, 232 }, 3786782, 3786786, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 144, 8, 179, 8, 192, 8, 192, 8 },
             new byte[] { 48, 9, 91, 9, 110, 9, 115, 9 }, 3786788, 3786795, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 241, 3, 255, 3, 48 },
             new byte[] { 35, 4, 53, 4, 107 }, 3786964, 3786968, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 66 },
             new byte[] { 128 }, 3786970, 3786970, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 81 },
             new byte[] { 146 }, 3786972, 3786972, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 122 },
             new byte[] { 193 }, 3786974, 3786974, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 167 },
             new byte[] { 243 }, 3786976, 3786976, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 223, 4, 44 },
             new byte[] { 49, 5, 135 }, 3786978, 3786980, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 129 },
             new byte[] { 229 }, 3786982, 3786982, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 3 },
             new byte[] { 115 }, 3786984, 3786984, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 147, 6, 204, 6, 252, 6 },
             new byte[] { 18, 7, 83, 7, 139, 7 }, 3786986, 3786991, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 8 },
             new byte[] { 60 }, 3786996, 3786996, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 49 },
             new byte[] { 105 }, 3786998, 3786998, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 59 },
             new byte[] { 118 }, 3787000, 3787000, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 100 },
             new byte[] { 164 }, 3787002, 3787002, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 139 },
             new byte[] { 208 }, 3787004, 3787004, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 192, 4, 39 },
             new byte[] { 11, 5, 123 }, 3787006, 3787008, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 81 },
             new byte[] { 171 }, 3787010, 3787010, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 150 },
             new byte[] { 248 }, 3787012, 3787012, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 202, 5, 98 },
             new byte[] { 51, 6, 217 }, 3787014, 3787016, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 15 },
             new byte[] { 151 }, 3787018, 3787018, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 113, 7, 200, 7 },
             new byte[] { 5, 8, 103, 8 }, 3787020, 3787023, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 29 },
             new byte[] { 82 }, 3787028, 3787028, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 72 },
             new byte[] { 129 }, 3787030, 3787030, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 96 },
             new byte[] { 157 }, 3787032, 3787032, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 149 },
             new byte[] { 216 }, 3787034, 3787034, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 193, 4, 251, 4, 69 },
             new byte[] { 9, 5, 73, 5, 155 }, 3787036, 3787040, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 180, 5, 240, 5, 34 },
             new byte[] { 21, 6, 88, 6, 145 }, 3787042, 3787046, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 214, 6, 75 },
             new byte[] { 86, 7, 216 }, 3787048, 3787050, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 4 },
             new byte[] { 163 }, 3787052, 3787052, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 90, 8 },
             new byte[] { 5, 9 }, 3787054, 3787055, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 58 },
             new byte[] { 112 }, 3787060, 3787060, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 105 },
             new byte[] { 164 }, 3787062, 3787062, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 154 },
             new byte[] { 218 }, 3787064, 3787064, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224, 4, 250, 4, 61 },
             new byte[] { 39, 5, 69, 5, 144 }, 3787066, 3787070, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 146 },
             new byte[] { 237 }, 3787072, 3787072, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 238, 5, 65 },
             new byte[] { 82, 6, 175 }, 3787074, 3787076, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 123 },
             new byte[] { 240 }, 3787078, 3787078, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 86 },
             new byte[] { 223 }, 3787080, 3787080, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 228, 7, 162, 8, 202, 8 },
             new byte[] { 124, 8, 78, 9, 126, 9 }, 3787082, 3787087, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 87 },
             new byte[] { 143 }, 3787092, 3787092, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 135 },
             new byte[] { 196 }, 3787094, 3787094, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 212, 4, 40 },
             new byte[] { 24, 5, 115 }, 3787096, 3787098, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 53 },
             new byte[] { 132 }, 3787100, 3787100, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 136 },
             new byte[] { 223 }, 3787102, 3787102, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 226, 5, 64 },
             new byte[] { 66, 6, 170 }, 3787104, 3787106, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 143, 6, 235, 6, 158, 7, 52 },
             new byte[] { 2, 7, 104, 7, 45, 8, 210 }, 3787108, 3787114, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 152, 8, 218, 8 },
             new byte[] { 67, 9, 143, 9 }, 3787116, 3787119, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 116 },
             new byte[] { 173 }, 3787124, 3787124, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 166 },
             new byte[] { 228 }, 3787126, 3787126, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 6 },
             new byte[] { 76 }, 3787128, 3787128, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 97 },
             new byte[] { 175 }, 3787130, 3787130, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 124 },
             new byte[] { 207 }, 3787132, 3787132, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 205, 5, 47 },
             new byte[] { 40, 6, 148 }, 3787134, 3787136, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 152, 6, 234, 6, 99 },
             new byte[] { 8, 7, 99, 7, 233 }, 3787138, 3787142, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 2 },
             new byte[] { 152 }, 3787144, 3787144, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 102, 8, 202, 8, 226, 8 },
             new byte[] { 8, 9, 121, 9, 152, 9 }, 3787146, 3787151, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 146 },
             new byte[] { 205 }, 3787156, 3787156, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 201, 4, 20 },
             new byte[] { 9, 5, 91 }, 3787158, 3787160, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 118 },
             new byte[] { 198 }, 3787162, 3787162, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 201, 5, 33 },
             new byte[] { 33, 6, 130 }, 3787164, 3787166, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 141 },
             new byte[] { 248 }, 3787168, 3787168, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 244, 6, 71 },
             new byte[] { 106, 7, 199 }, 3787170, 3787172, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 219, 7, 173, 8, 251, 8, 251, 8, 251, 8 },
             new byte[] { 105, 8, 79, 9, 168, 9, 174, 9, 179, 9 }, 3787174, 3787183, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 185 },
             new byte[] { 245 }, 3787188, 3787188, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 244, 4, 65 },
             new byte[] { 54, 5, 138 }, 3787190, 3787192, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 173, 5, 10 },
             new byte[] { 0, 6, 102 }, 3787194, 3787196, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 112 },
             new byte[] { 213 }, 3787198, 3787198, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 227, 6, 71 },
             new byte[] { 84, 7, 194 }, 3787200, 3787202, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 173, 7, 87 },
             new byte[] { 52, 8, 238 }, 3787204, 3787206, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 206, 8, 16 },
             new byte[] { 115, 9, 191 }, 3787208, 3787210, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16 },
             new byte[] { 196 }, 3787212, 3787212, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16 },
             new byte[] { 202 }, 3787214, 3787214, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 246, 4, 44 },
             new byte[] { 54, 5, 113 }, 3787220, 3787222, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 123 },
             new byte[] { 200 }, 3787224, 3787224, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 229, 5, 70 },
             new byte[] { 59, 6, 165 }, 3787226, 3787228, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 180, 6, 42 },
             new byte[] { 30, 7, 159 }, 3787230, 3787232, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 142, 7, 222, 7, 92 },
             new byte[] { 14, 8, 104, 8, 243 }, 3787234, 3787238, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 212, 8, 16 },
             new byte[] { 121, 9, 191 }, 3787240, 3787242, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16 },
             new byte[] { 196 }, 3787244, 3787244, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16 },
             new byte[] { 202 }, 3787246, 3787246, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 61 },
             new byte[] { 128 }, 3787252, 3787252, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 110 },
             new byte[] { 183 }, 3787254, 3787254, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 180, 5, 10 },
             new byte[] { 4, 6, 98 }, 3787256, 3787258, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 97 },
             new byte[] { 194 }, 3787260, 3787260, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 194, 6, 45 },
             new byte[] { 44, 7, 162 }, 3787262, 3787264, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 145, 7, 228, 7, 92 },
             new byte[] { 17, 8, 110, 8, 243 }, 3787266, 3787270, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 212, 8, 16 },
             new byte[] { 121, 9, 191 }, 3787272, 3787274, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16 },
             new byte[] { 196 }, 3787276, 3787276, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16 },
             new byte[] { 202 }, 3787278, 3787278, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 131 },
             new byte[] { 202 }, 3787284, 3787284, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 175 },
             new byte[] { 251 }, 3787286, 3787286, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 236, 5, 46 },
             new byte[] { 63, 6, 136 }, 3787288, 3787290, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 123 },
             new byte[] { 221 }, 3787292, 3787292, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 207, 6, 48 },
             new byte[] { 58, 7, 165 }, 3787294, 3787296, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 147, 7, 234, 7, 92 },
             new byte[] { 19, 8, 117, 8, 243 }, 3787298, 3787302, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 212, 8, 16 },
             new byte[] { 121, 9, 191 }, 3787304, 3787306, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16 },
             new byte[] { 196 }, 3787308, 3787308, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16 },
             new byte[] { 202 }, 3787310, 3787310, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 160 },
             new byte[] { 232 }, 3787316, 3787316, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 188, 5, 237, 5, 46 },
             new byte[] { 9, 6, 64, 6, 136 }, 3787318, 3787322, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 125 },
             new byte[] { 223 }, 3787324, 3787324, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 209, 6, 43 },
             new byte[] { 60, 7, 160 }, 3787326, 3787328, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 135, 7, 222, 7, 87 },
             new byte[] { 6, 8, 104, 8, 238 }, 3787330, 3787334, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 212, 8, 16 },
             new byte[] { 121, 9, 191 }, 3787336, 3787338, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16 },
             new byte[] { 196 }, 3787340, 3787340, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16 },
             new byte[] { 202 }, 3787342, 3787342, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 188, 5, 200, 5, 238, 5, 45 },
             new byte[] { 5, 6, 21, 6, 65, 6, 135 }, 3787348, 3787354, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 127 },
             new byte[] { 226 }, 3787356, 3787356, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 210, 6, 38 },
             new byte[] { 61, 7, 155 }, 3787358, 3787360, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 122 },
             new byte[] { 249 }, 3787362, 3787362, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 210, 7, 82 },
             new byte[] { 91, 8, 233 }, 3787364, 3787366, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 212, 8, 16 },
             new byte[] { 121, 9, 191 }, 3787368, 3787370, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16 },
             new byte[] { 196 }, 3787372, 3787372, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16 },
             new byte[] { 202 }, 3787374, 3787374, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 6 },
             new byte[] { 88 }, 3787452, 3787452, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 106 },
             new byte[] { 196 }, 3787454, 3787454, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 156 },
             new byte[] { 250 }, 3787456, 3787456, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 181, 4, 206, 4, 206, 4, 206, 4, 206, 4, 206, 4, 206, 4, 0 },
             new byte[] { 21, 5, 48, 5, 48, 5, 48, 5, 48, 5, 48, 5, 48, 5, 102 }, 3787458, 3787472, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 0 },
             new byte[] { 102 }, 3787474, 3787474, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 0 },
             new byte[] { 102 }, 3787476, 3787476, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 0 },
             new byte[] { 102 }, 3787478, 3787478, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 56 },
             new byte[] { 142 }, 3787480, 3787480, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 126 },
             new byte[] { 218 }, 3787482, 3787482, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 181, 4, 241, 4, 20 },
             new byte[] { 21, 5, 86, 5, 124 }, 3787484, 3787488, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 60 },
             new byte[] { 167 }, 3787490, 3787490, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 60 },
             new byte[] { 167 }, 3787492, 3787492, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 60 },
             new byte[] { 167 }, 3787494, 3787494, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 60 },
             new byte[] { 167 }, 3787496, 3787496, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 60 },
             new byte[] { 167 }, 3787498, 3787498, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 110 },
             new byte[] { 221 }, 3787500, 3787500, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 110 },
             new byte[] { 221 }, 3787502, 3787502, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 110 },
             new byte[] { 221 }, 3787504, 3787504, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 110 },
             new byte[] { 221 }, 3787506, 3787506, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 86 },
             new byte[] { 175 }, 3787508, 3787508, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 146 },
             new byte[] { 240 }, 3787510, 3787510, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 206, 4, 20 },
             new byte[] { 48, 5, 124 }, 3787512, 3787514, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 90 },
             new byte[] { 200 }, 3787516, 3787516, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 160, 5, 195, 5, 230, 5, 9 },
             new byte[] { 19, 6, 57, 6, 95, 6, 133 }, 3787518, 3787524, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 29 },
             new byte[] { 154 }, 3787526, 3787526, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 104 },
             new byte[] { 235 }, 3787528, 3787528, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 114 },
             new byte[] { 246 }, 3787530, 3787530, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 149, 6, 149, 6, 200, 5, 250, 5, 69 },
             new byte[] { 28, 7, 28, 7, 62, 6, 116, 6, 197 }, 3787532, 3787540, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 129, 6, 194, 6, 13 },
             new byte[] { 6, 7, 76, 7, 157 }, 3787542, 3787546, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 48 },
             new byte[] { 195 }, 3787548, 3787548, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 88 },
             new byte[] { 238 }, 3787550, 3787550, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 118, 7, 158, 7, 238, 7, 22 },
             new byte[] { 15, 8, 58, 8, 144, 8, 188 }, 3787552, 3787558, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 32 },
             new byte[] { 198 }, 3787560, 3787560, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 32 },
             new byte[] { 198 }, 3787562, 3787562, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 58 },
             new byte[] { 206 }, 3787564, 3787564, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 108, 7, 188, 7, 238, 7, 52 },
             new byte[] { 4, 8, 90, 8, 144, 8, 220 }, 3787566, 3787572, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 122, 8, 162, 8, 202, 8, 232, 8, 232, 8, 26 },
             new byte[] { 40, 9, 83, 9, 126, 9, 158, 9, 158, 9, 212 }, 3787574, 3787584, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 26 },
             new byte[] { 212 }, 3787586, 3787586, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 26 },
             new byte[] { 212 }, 3787588, 3787588, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 26 },
             new byte[] { 212 }, 3787590, 3787590, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 138, 7, 188, 7, 248, 7, 32 },
             new byte[] { 36, 8, 90, 8, 155, 8, 198 }, 3787592, 3787598, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 52 },
             new byte[] { 220 }, 3787600, 3787600, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 162, 8, 232, 8, 46 },
             new byte[] { 83, 9, 158, 9, 234 }, 3787602, 3787606, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 46 },
             new byte[] { 234 }, 3787608, 3787608, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 71, 9, 96, 9, 96, 9, 96, 9, 96, 9, 228, 7, 2 },
             new byte[] { 5, 10, 32, 10, 32, 10, 32, 10, 32, 10, 134, 8, 166 }, 3787610, 3787622, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 17 },
             new byte[] { 182 }, 3787624, 3787624, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 32 },
             new byte[] { 198 }, 3787626, 3787626, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 82 },
             new byte[] { 252 }, 3787628, 3787628, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 177, 8, 242, 8, 46 },
             new byte[] { 99, 9, 169, 9, 234 }, 3787630, 3787634, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 46 },
             new byte[] { 234 }, 3787636, 3787636, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 71, 9, 96, 9, 96, 9, 96, 9, 96, 9, 228, 7, 2 },
             new byte[] { 5, 10, 32, 10, 32, 10, 32, 10, 32, 10, 134, 8, 166 }, 3787638, 3787650, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 17 },
             new byte[] { 182 }, 3787652, 3787652, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 32 },
             new byte[] { 198 }, 3787654, 3787654, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 82 },
             new byte[] { 252 }, 3787656, 3787656, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 192, 8, 16 },
             new byte[] { 115, 9, 202 }, 3787658, 3787660, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 46 },
             new byte[] { 234 }, 3787662, 3787662, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 46 },
             new byte[] { 234 }, 3787664, 3787664, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 71, 9, 96, 9, 96, 9, 96, 9, 96, 9, 228, 7, 2 },
             new byte[] { 5, 10, 32, 10, 32, 10, 32, 10, 32, 10, 134, 8, 166 }, 3787666, 3787678, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 32 },
             new byte[] { 198 }, 3787680, 3787680, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 52 },
             new byte[] { 220 }, 3787682, 3787682, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 97, 8, 192, 8, 16 },
             new byte[] { 13, 9, 115, 9, 202 }, 3787684, 3787688, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 46 },
             new byte[] { 234 }, 3787690, 3787690, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 46 },
             new byte[] { 234 }, 3787692, 3787692, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 71, 9, 96, 9, 96, 9, 96, 9, 96, 9, 198, 7, 12 },
             new byte[] { 5, 10, 32, 10, 32, 10, 32, 10, 32, 10, 101, 8, 177 }, 3787694, 3787706, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 52 },
             new byte[] { 220 }, 3787708, 3787708, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 62 },
             new byte[] { 231 }, 3787710, 3787710, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 112, 8, 192, 8, 16 },
             new byte[] { 29, 9, 115, 9, 202 }, 3787712, 3787716, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 46 },
             new byte[] { 234 }, 3787718, 3787718, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 46 },
             new byte[] { 234 }, 3787720, 3787720, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 71, 9, 96, 9, 96, 9, 96, 9, 96, 9, 168, 7, 7 },
             new byte[] { 5, 10, 32, 10, 32, 10, 32, 10, 32, 10, 69, 8, 171 }, 3787722, 3787734, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 32 },
             new byte[] { 198 }, 3787736, 3787736, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 57 },
             new byte[] { 225 }, 3787738, 3787738, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 112, 8, 192, 8, 16 },
             new byte[] { 29, 9, 115, 9, 202 }, 3787740, 3787744, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 46 },
             new byte[] { 234 }, 3787746, 3787746, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 46 },
             new byte[] { 234 }, 3787748, 3787748, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 71, 9, 96, 9, 96, 9, 96, 9, 96, 9, 138, 7, 238, 7, 15 },
             new byte[] { 5, 10, 32, 10, 32, 10, 32, 10, 32, 10, 36, 8, 144, 8, 180 }, 3787750, 3787764, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 49 },
             new byte[] { 217 }, 3787766, 3787766, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 112, 8, 192, 8, 16 },
             new byte[] { 29, 9, 115, 9, 202 }, 3787768, 3787772, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 46 },
             new byte[] { 234 }, 3787774, 3787774, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 46 },
             new byte[] { 234 }, 3787776, 3787776, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 71, 9, 96, 9, 96, 9, 96, 9, 96, 9, 73 },
             new byte[] { 5, 10, 32, 10, 32, 10, 32, 10, 32, 10, 222 }, 3787778, 3787788, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 153, 7, 213, 7, 7 },
             new byte[] { 53, 8, 117, 8, 171 }, 3787790, 3787794, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 52 },
             new byte[] { 220 }, 3787796, 3787796, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 127, 8, 222, 8, 46 },
             new byte[] { 45, 9, 148, 9, 234 }, 3787798, 3787802, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 46 },
             new byte[] { 234 }, 3787804, 3787804, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 71, 9, 96, 9, 96, 9, 96, 9, 96, 9, 244, 6, 58 },
             new byte[] { 5, 10, 32, 10, 32, 10, 32, 10, 32, 10, 130, 7, 206 }, 3787806, 3787818, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 118, 7, 178, 7, 233, 7, 52 },
             new byte[] { 15, 8, 80, 8, 139, 8, 220 }, 3787820, 3787826, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 137, 8, 232, 8, 26 },
             new byte[] { 56, 9, 158, 9, 212 }, 3787828, 3787832, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 71, 9, 96, 9, 106, 9, 106, 9, 106, 9, 164, 6, 234, 6, 38 },
             new byte[] { 5, 10, 32, 10, 43, 10, 43, 10, 43, 10, 44, 7, 120, 7, 184 }, 3787834, 3787848, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 98 },
             new byte[] { 249 }, 3787850, 3787850, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 153, 7, 218, 7, 27 },
             new byte[] { 53, 8, 123, 8, 193 }, 3787852, 3787856, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 142, 8, 237, 8, 61 },
             new byte[] { 61, 9, 164, 9, 250 }, 3787858, 3787862, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 91, 9, 96, 9, 96, 9, 96, 9, 187, 5, 250, 5, 66 },
             new byte[] { 27, 10, 32, 10, 32, 10, 32, 10, 48, 6, 116, 6, 194 }, 3787864, 3787876, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 118 },
             new byte[] { 250 }, 3787878, 3787878, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 158, 6, 225, 6, 46 },
             new byte[] { 38, 7, 110, 7, 193 }, 3787880, 3787884, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 160, 7, 39 },
             new byte[] { 60, 8, 206 }, 3787886, 3787888, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 143, 8, 42 },
             new byte[] { 62, 9, 230 }, 3787890, 3787892, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 96, 9, 96, 9, 96, 9 },
             new byte[] { 32, 10, 32, 10, 32, 10 }, 3787894, 3787899, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 61 },
             new byte[] { 115 }, 3792474, 3792474, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 211, 4, 140 },
             new byte[] { 21, 5, 220 }, 3792476, 3792478, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 240, 5, 104 },
             new byte[] { 75, 6, 208 }, 3792480, 3792482, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224, 6, 50 },
             new byte[] { 85, 7, 179 }, 3792484, 3792486, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 168, 7, 168, 7, 168, 7 },
             new byte[] { 56, 8, 62, 8, 69, 8 }, 3792488, 3792493, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 126 },
             new byte[] { 184 }, 3792498, 3792498, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 15 },
             new byte[] { 84 }, 3792500, 3792500, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 44 },
             new byte[] { 134 }, 3792502, 3792502, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 139 },
             new byte[] { 240 }, 3792504, 3792504, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 244, 6, 103 },
             new byte[] { 101, 7, 229 }, 3792506, 3792508, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 158, 7, 168, 7, 168, 7, 168, 7 },
             new byte[] { 39, 8, 56, 8, 62, 8, 69, 8 }, 3792510, 3792517, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 136 },
             new byte[] { 194 }, 3792522, 3792522, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 55 },
             new byte[] { 126 }, 3792524, 3792524, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 84 },
             new byte[] { 176 }, 3792526, 3792526, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 10 },
             new byte[] { 118 }, 3792528, 3792528, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 73 },
             new byte[] { 191 }, 3792530, 3792530, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 253, 7, 102 },
             new byte[] { 133, 8, 253 }, 3792532, 3792534, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 102, 8, 102, 8, 102, 8 },
             new byte[] { 4, 9, 11, 9, 18, 9 }, 3792536, 3792541, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 162 },
             new byte[] { 221 }, 3792546, 3792546, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 127 },
             new byte[] { 202 }, 3792548, 3792548, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 114 },
             new byte[] { 208 }, 3792550, 3792550, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 108 },
             new byte[] { 222 }, 3792552, 3792552, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 218, 7, 12 },
             new byte[] { 89, 8, 149 }, 3792554, 3792556, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 63 },
             new byte[] { 211 }, 3792558, 3792558, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 102, 8, 102, 8, 102, 8 },
             new byte[] { 4, 9, 11, 9, 18, 9 }, 3792560, 3792565, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 236, 4, 190, 5, 184, 6, 193, 7, 37 },
             new byte[] { 43, 5, 12, 6, 25, 7, 56, 8, 169 }, 3792570, 3792578, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 52 },
             new byte[] { 192 }, 3792580, 3792580, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 62 },
             new byte[] { 210 }, 3792582, 3792582, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 112, 8, 112, 8, 112, 8 },
             new byte[] { 14, 9, 22, 9, 29, 9 }, 3792584, 3792589, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 246, 4, 220, 5, 244, 6, 208, 7, 42 },
             new byte[] { 54, 5, 44, 6, 89, 7, 72, 8, 174 }, 3792594, 3792602, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 52 },
             new byte[] { 192 }, 3792604, 3792604, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 72 },
             new byte[] { 220 }, 3792606, 3792606, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 92 },
             new byte[] { 249 }, 3792608, 3792608, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 92, 8, 92, 8 },
             new byte[] { 0, 9, 7, 9 }, 3792610, 3792613, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 251, 4, 220, 5, 234, 6, 190, 7, 208, 7, 12 },
             new byte[] { 59, 5, 44, 6, 78, 7, 53, 8, 79, 8, 149 }, 3792618, 3792628, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 22 },
             new byte[] { 167 }, 3792630, 3792630, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 52 },
             new byte[] { 206 }, 3792632, 3792632, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 52 },
             new byte[] { 213 }, 3792634, 3792634, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 52 },
             new byte[] { 220 }, 3792636, 3792636, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 0 },
             new byte[] { 64 }, 3792642, 3792642, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 220, 5, 224, 6, 138 },
             new byte[] { 44, 6, 68, 7, 254 }, 3792644, 3792648, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 183, 7, 208, 7, 248, 7, 248, 7, 248, 7, 248, 7 },
             new byte[] { 52, 8, 85, 8, 135, 8, 142, 8, 148, 8, 155, 8 }, 3792650, 3792661, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 61 },
             new byte[] { 115 }, 3792814, 3792814, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 211, 4, 140 },
             new byte[] { 21, 5, 220 }, 3792816, 3792818, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 240, 5, 104 },
             new byte[] { 75, 6, 208 }, 3792820, 3792822, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224, 6, 50 },
             new byte[] { 85, 7, 179 }, 3792824, 3792826, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 168, 7, 168, 7, 168, 7 },
             new byte[] { 56, 8, 62, 8, 69, 8 }, 3792828, 3792833, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 126 },
             new byte[] { 184 }, 3792838, 3792838, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 15 },
             new byte[] { 84 }, 3792840, 3792840, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 44 },
             new byte[] { 134 }, 3792842, 3792842, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 139 },
             new byte[] { 240 }, 3792844, 3792844, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 244, 6, 103 },
             new byte[] { 101, 7, 229 }, 3792846, 3792848, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 158, 7, 168, 7, 168, 7, 168, 7 },
             new byte[] { 39, 8, 56, 8, 62, 8, 69, 8 }, 3792850, 3792857, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 136 },
             new byte[] { 194 }, 3792862, 3792862, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 55 },
             new byte[] { 126 }, 3792864, 3792864, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 84 },
             new byte[] { 176 }, 3792866, 3792866, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 10 },
             new byte[] { 118 }, 3792868, 3792868, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 73 },
             new byte[] { 191 }, 3792870, 3792870, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 253, 7, 102 },
             new byte[] { 133, 8, 253 }, 3792872, 3792874, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 102, 8, 102, 8, 102, 8 },
             new byte[] { 4, 9, 11, 9, 18, 9 }, 3792876, 3792881, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 162 },
             new byte[] { 221 }, 3792886, 3792886, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 127 },
             new byte[] { 202 }, 3792888, 3792888, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 114 },
             new byte[] { 208 }, 3792890, 3792890, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 108 },
             new byte[] { 222 }, 3792892, 3792892, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 218, 7, 12 },
             new byte[] { 89, 8, 149 }, 3792894, 3792896, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 63 },
             new byte[] { 211 }, 3792898, 3792898, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 102, 8, 102, 8, 102, 8 },
             new byte[] { 4, 9, 11, 9, 18, 9 }, 3792900, 3792905, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 236, 4, 190, 5, 184, 6, 193, 7, 37 },
             new byte[] { 43, 5, 12, 6, 25, 7, 56, 8, 169 }, 3792910, 3792918, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 52 },
             new byte[] { 192 }, 3792920, 3792920, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 62 },
             new byte[] { 210 }, 3792922, 3792922, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 112, 8, 112, 8, 112, 8 },
             new byte[] { 14, 9, 22, 9, 29, 9 }, 3792924, 3792929, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 246, 4, 220, 5, 244, 6, 208, 7, 42 },
             new byte[] { 54, 5, 44, 6, 89, 7, 72, 8, 174 }, 3792934, 3792942, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 52 },
             new byte[] { 192 }, 3792944, 3792944, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 72 },
             new byte[] { 220 }, 3792946, 3792946, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 92 },
             new byte[] { 249 }, 3792948, 3792948, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 92, 8, 92, 8 },
             new byte[] { 0, 9, 7, 9 }, 3792950, 3792953, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 251, 4, 220, 5, 234, 6, 190, 7, 208, 7, 12 },
             new byte[] { 59, 5, 44, 6, 78, 7, 53, 8, 79, 8, 149 }, 3792958, 3792968, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 22 },
             new byte[] { 167 }, 3792970, 3792970, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 52 },
             new byte[] { 206 }, 3792972, 3792972, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 52 },
             new byte[] { 213 }, 3792974, 3792974, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 52 },
             new byte[] { 220 }, 3792976, 3792976, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 0 },
             new byte[] { 64 }, 3792982, 3792982, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 220, 5, 224, 6, 138 },
             new byte[] { 44, 6, 68, 7, 254 }, 3792984, 3792988, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 183, 7, 208, 7, 248, 7, 248, 7, 248, 7, 248, 7 },
             new byte[] { 52, 8, 85, 8, 135, 8, 142, 8, 148, 8, 155, 8 }, 3792990, 3793001, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 61 },
             new byte[] { 115 }, 3794844, 3794844, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 140 },
             new byte[] { 218 }, 3794846, 3794846, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 104 },
             new byte[] { 202 }, 3794848, 3794848, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 168, 7, 168, 7, 168, 7, 168, 7 },
             new byte[] { 39, 8, 49, 8, 59, 8, 69, 8 }, 3794850, 3794857, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 136 },
             new byte[] { 194 }, 3794860, 3794860, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 84 },
             new byte[] { 173 }, 3794862, 3794862, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 73 },
             new byte[] { 185 }, 3794864, 3794864, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 102 },
             new byte[] { 242 }, 3794866, 3794866, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 102 },
             new byte[] { 253 }, 3794868, 3794868, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 102, 8, 102, 8 },
             new byte[] { 7, 9, 18, 9 }, 3794870, 3794873, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 246, 4, 244, 6, 42 },
             new byte[] { 54, 5, 86, 7, 167 }, 3794876, 3794880, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 92 },
             new byte[] { 231 }, 3794882, 3794882, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 92 },
             new byte[] { 242 }, 3794884, 3794884, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 92 },
             new byte[] { 253 }, 3794886, 3794886, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 92, 8 },
             new byte[] { 7, 9 }, 3794888, 3794889, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 0 },
             new byte[] { 64 }, 3794892, 3794892, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224, 6, 183, 7, 248, 7, 248, 7, 248, 7, 248, 7 },
             new byte[] { 65, 7, 46, 8, 125, 8, 135, 8, 145, 8, 155, 8 }, 3794894, 3794905, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 0 },
             new byte[] { 64 }, 3794908, 3794908, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224, 6, 183, 7, 248, 7, 248, 7, 248, 7, 248, 7 },
             new byte[] { 65, 7, 46, 8, 125, 8, 135, 8, 145, 8, 155, 8 }, 3794910, 3794921, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 0 },
             new byte[] { 64 }, 3794924, 3794924, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224, 6, 183, 7, 248, 7, 248, 7, 248, 7, 248, 7 },
             new byte[] { 65, 7, 46, 8, 125, 8, 135, 8, 145, 8, 155, 8 }, 3794926, 3794937, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 96, 34, 16 },
             new byte[] { 16, 35, 216 }, 3900294, 3900296, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 104, 41, 204, 41, 98, 42, 248, 42, 248, 42, 248, 42 },
             new byte[] { 60, 42, 162, 42, 59, 43, 212, 43, 212, 43, 212, 43 }, 3900298, 3900309, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 18 },
             new byte[] { 208 }, 3900326, 3900326, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 160, 40, 236, 44, 130, 45, 24, 46, 74, 46, 124, 46, 224, 46 },
             new byte[] { 112, 41, 210, 45, 107, 46, 4, 47, 55, 47, 106, 47, 208, 47 }, 3900328, 3900341, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 116, 39, 172, 43, 164, 46, 158, 47, 226, 49, 240, 50, 44, 51, 44, 51 },
             new byte[] { 62, 40, 140, 44, 147, 47, 146, 48, 225, 50, 245, 51, 50, 52, 50, 52 }, 3900358, 3900373, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 220, 40, 80, 45, 12, 48, 252, 48, 84, 51, 72, 53, 60, 55, 60, 55 },
             new byte[] { 173, 41, 56, 46, 2, 49, 247, 49, 91, 52, 89, 54, 87, 56, 87, 56 }, 3900390, 3900405, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 254, 41, 14 },
             new byte[] { 213, 42, 250 }, 3900422, 3900424, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 252, 48, 110, 50, 188, 52, 10, 55, 164, 56, 164, 56 },
             new byte[] { 247, 49, 112, 51, 202, 53, 36, 56, 198, 57, 198, 57 }, 3900426, 3900437, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 94, 46, 70, 50, 162, 53, 134, 56, 6, 59, 200, 60, 98, 62, 128, 62 },
             new byte[] { 75, 47, 71, 51, 181, 54, 167, 57, 52, 60, 255, 61, 161, 63, 192, 63 }, 3900454, 3900469, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 78, 52, 234, 56, 110, 60, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62 },
             new byte[] { 90, 53, 13, 58, 163, 61, 192, 63, 192, 63, 192, 63, 192, 63, 192, 63 }, 3900486, 3900501, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 162, 58, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62 },
             new byte[] { 206, 59, 192, 63, 192, 63, 192, 63, 192, 63, 192, 63, 192, 63, 192, 63 }, 3900518, 3900533, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16, 59, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62 },
             new byte[] { 62, 60, 192, 63, 192, 63, 192, 63, 192, 63, 192, 63, 192, 63, 192, 63 }, 3900550, 3900565, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 200, 50, 200, 50, 200, 50, 200, 50, 200, 50, 200, 50, 200, 50, 200, 50 },
             new byte[] { 204, 51, 204, 51, 204, 51, 204, 51, 204, 51, 204, 51, 204, 51, 204, 51 }, 3900582, 3900597, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 64 },
             new byte[] { 224 }, 3900614, 3900614, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 64 },
             new byte[] { 224 }, 3900616, 3900616, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 64 },
             new byte[] { 224 }, 3900618, 3900618, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 64 },
             new byte[] { 224 }, 3900620, 3900620, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 64 },
             new byte[] { 224 }, 3900622, 3900622, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 64 },
             new byte[] { 224 }, 3900624, 3900624, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 64 },
             new byte[] { 224 }, 3900626, 3900626, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 64 },
             new byte[] { 224 }, 3900628, 3900628, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 172 },
             new byte[] { 242 }, 3900646, 3900646, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 172 },
             new byte[] { 242 }, 3900648, 3900648, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 172 },
             new byte[] { 242 }, 3900650, 3900650, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 172 },
             new byte[] { 242 }, 3900652, 3900652, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 172 },
             new byte[] { 242 }, 3900654, 3900654, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 172 },
             new byte[] { 242 }, 3900656, 3900656, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 172 },
             new byte[] { 242 }, 3900658, 3900658, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 172 },
             new byte[] { 242 }, 3900660, 3900660, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 96, 34, 32 },
             new byte[] { 16, 35, 217 }, 3909802, 3909804, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 104, 41, 204, 41, 98, 42, 248, 42, 248, 42, 248, 42 },
             new byte[] { 60, 42, 162, 42, 59, 43, 212, 43, 212, 43, 212, 43 }, 3909806, 3909817, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 17 },
             new byte[] { 207 }, 3909834, 3909834, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 159, 40, 236, 44, 130, 45, 24, 46, 74, 46, 124, 46, 224, 46 },
             new byte[] { 111, 41, 210, 45, 107, 46, 4, 47, 55, 47, 106, 47, 208, 47 }, 3909836, 3909849, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 116, 39, 172, 43, 164, 46, 158, 47, 226, 49, 243, 50, 44, 51, 44, 51 },
             new byte[] { 62, 40, 140, 44, 147, 47, 146, 48, 225, 50, 248, 51, 50, 52, 50, 52 }, 3909866, 3909881, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 220, 40, 80, 45, 12, 48, 252, 48, 84, 51, 72, 53, 60, 55, 60, 55 },
             new byte[] { 173, 41, 56, 46, 2, 49, 247, 49, 91, 52, 89, 54, 87, 56, 87, 56 }, 3909898, 3909913, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 254, 41, 14 },
             new byte[] { 213, 42, 250 }, 3909930, 3909932, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 252, 48, 110, 50, 188, 52, 10, 55, 164, 56, 164, 56 },
             new byte[] { 247, 49, 112, 51, 202, 53, 36, 56, 198, 57, 198, 57 }, 3909934, 3909945, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 94, 46, 70, 50, 162, 53, 134, 56, 6, 59, 200, 60, 98, 62, 128, 62 },
             new byte[] { 75, 47, 71, 51, 181, 54, 167, 57, 52, 60, 255, 61, 161, 63, 192, 63 }, 3909962, 3909977, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 78, 52, 234, 56, 110, 60, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62 },
             new byte[] { 90, 53, 13, 58, 163, 61, 192, 63, 192, 63, 192, 63, 192, 63, 192, 63 }, 3909994, 3910009, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 162, 58, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62 },
             new byte[] { 206, 59, 192, 63, 192, 63, 192, 63, 192, 63, 192, 63, 192, 63, 192, 63 }, 3910026, 3910041, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16, 59, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62 },
             new byte[] { 62, 60, 192, 63, 192, 63, 192, 63, 192, 63, 192, 63, 192, 63, 192, 63 }, 3910058, 3910073, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 248, 57, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62 },
             new byte[] { 33, 59, 192, 63, 192, 63, 192, 63, 192, 63, 192, 63, 192, 63, 192, 63 }, 3910090, 3910105, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 64 },
             new byte[] { 224 }, 3910122, 3910122, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 64 },
             new byte[] { 224 }, 3910124, 3910124, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 64 },
             new byte[] { 224 }, 3910126, 3910126, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 64 },
             new byte[] { 224 }, 3910128, 3910128, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 64 },
             new byte[] { 224 }, 3910130, 3910130, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 64 },
             new byte[] { 224 }, 3910132, 3910132, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 64 },
             new byte[] { 224 }, 3910134, 3910134, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 64 },
             new byte[] { 224 }, 3910136, 3910136, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 61 },
             new byte[] { 236 }, 3910342, 3910342, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 228, 37, 254, 41, 254, 41, 248, 42, 248, 42, 248, 42, 248, 42 },
             new byte[] { 166, 38, 213, 42, 213, 42, 212, 43, 212, 43, 212, 43, 212, 43 }, 3910344, 3910357, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 163, 37, 236, 39, 48, 42, 6 },
             new byte[] { 100, 38, 184, 40, 8, 43, 231 }, 3910374, 3910380, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 130, 45, 224, 46, 224, 46, 224, 46 },
             new byte[] { 107, 46, 208, 47, 208, 47, 208, 47 }, 3910382, 3910389, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 104, 41, 138, 42, 231, 44, 94, 46, 56, 49, 194, 51, 194, 51, 194, 51 },
             new byte[] { 60, 42, 100, 43, 205, 45, 75, 47, 52, 50, 203, 52, 203, 52, 203, 52 }, 3910406, 3910421, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 36, 44, 176, 44, 63, 47, 202, 48, 72, 53, 60, 55, 60, 55, 60, 55 },
             new byte[] { 6, 45, 149, 45, 49, 48, 196, 49, 89, 54, 87, 56, 87, 56, 87, 56 }, 3910438, 3910453, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 170, 45, 8 },
             new byte[] { 148, 46, 249 }, 3910470, 3910472, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 50, 144, 51, 10, 55, 164, 56, 164, 56, 164, 56 },
             new byte[] { 51, 152, 52, 36, 56, 198, 57, 198, 57, 198, 57 }, 3910475, 3910485, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 221, 51, 162, 53, 134, 56, 6, 59, 200, 60, 98, 62, 128, 62, 128, 62 },
             new byte[] { 231, 52, 181, 54, 167, 57, 52, 60, 255, 61, 161, 63, 192, 63, 192, 63 }, 3910502, 3910517, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 234, 56, 110, 60, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62 },
             new byte[] { 13, 58, 163, 61, 192, 63, 192, 63, 192, 63, 192, 63, 192, 63, 192, 63 }, 3910534, 3910549, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62 },
             new byte[] { 192, 63, 192, 63, 192, 63, 192, 63, 192, 63, 192, 63, 192, 63, 192, 63 }, 3910566, 3910581, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 61 },
             new byte[] { 236 }, 3910922, 3910922, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 254, 36, 60, 40, 254, 41, 248, 42, 248, 42, 248, 42, 248, 42 },
             new byte[] { 187, 37, 10, 41, 213, 42, 212, 43, 212, 43, 212, 43, 212, 43 }, 3910924, 3910937, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 128, 37, 236, 39, 48, 42, 6 },
             new byte[] { 64, 38, 184, 40, 8, 43, 231 }, 3910954, 3910960, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 130, 45, 224, 46, 224, 46, 224, 46 },
             new byte[] { 107, 46, 208, 47, 208, 47, 208, 47 }, 3910962, 3910969, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 4 },
             new byte[] { 214 }, 3910986, 3910986, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 138, 42, 231, 44, 94, 46, 56, 49, 194, 51, 194, 51, 194, 51 },
             new byte[] { 100, 43, 205, 45, 75, 47, 52, 50, 203, 52, 203, 52, 203, 52 }, 3910988, 3911001, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 92, 43, 176, 44, 63, 47, 202, 48, 72, 53, 60, 55, 60, 55, 60, 55 },
             new byte[] { 58, 44, 149, 45, 49, 48, 196, 49, 89, 54, 87, 56, 87, 56, 87, 56 }, 3911018, 3911033, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 236, 44, 18, 47 },
             new byte[] { 210, 45, 3, 48 }, 3911050, 3911053, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 50, 144, 51, 10, 55, 164, 56, 164, 56, 164, 56 },
             new byte[] { 51, 152, 52, 36, 56, 198, 57, 198, 57, 198, 57 }, 3911055, 3911065, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 221, 51, 162, 53, 134, 56, 6, 59, 200, 60, 98, 62, 128, 62, 128, 62 },
             new byte[] { 231, 52, 181, 54, 167, 57, 52, 60, 255, 61, 161, 63, 192, 63, 192, 63 }, 3911082, 3911097, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 234, 56, 110, 60, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62 },
             new byte[] { 13, 58, 163, 61, 192, 63, 192, 63, 192, 63, 192, 63, 192, 63, 192, 63 }, 3911114, 3911129, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62 },
             new byte[] { 192, 63, 192, 63, 192, 63, 192, 63, 192, 63, 192, 63, 192, 63, 192, 63 }, 3911146, 3911161, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 128, 62, 128, 62, 128, 62, 128, 62 },
             new byte[] { 192, 63, 192, 63, 192, 63, 192, 63 }, 3917452, 3917459, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62 },
             new byte[] { 116, 64, 116, 64, 116, 64, 116, 64, 116, 64, 116, 64, 116, 64, 116, 64, 116, 64, 116, 64, 116, 64, 116, 64, 116, 64, 116, 64, 116, 64, 116, 64, 116, 64, 116, 64, 116, 64, 116, 64, 116, 64, 116, 64, 116, 64, 116, 64, 116, 64, 116, 64, 116, 64, 116, 64, 116, 64, 116, 64, 116, 64, 116, 64, 116, 64, 116, 64, 116, 64, 116, 64, 116, 64, 116, 64, 116, 64, 116, 64, 116, 64, 116, 64, 116, 64, 116, 64, 116, 64, 116, 64, 116, 64, 116, 64, 116, 64, 116, 64, 116, 64, 116, 64, 116, 64, 116, 64, 116, 64, 116, 64, 116, 64, 116, 64, 116, 64, 116, 64, 116, 64, 116, 64, 116, 64, 116, 64, 116, 64, 116, 64, 116, 64, 116, 64, 116, 64, 116, 64 }, 3917464, 3917603, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 184, 61, 184, 61, 184, 61, 184, 61, 184, 61, 184, 61, 184 },
             new byte[] { 192, 63, 192, 63, 192, 63, 192, 63, 192, 63, 192, 63, 192, 63, 192, 63, 192, 63, 192, 63, 192, 63, 192, 63, 244, 62, 244, 62, 244, 62, 244, 62, 244, 62, 244, 62, 244 }, 3920892, 3920928, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 184 },
             new byte[] { 244 }, 3920930, 3920930, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 184 },
             new byte[] { 244 }, 3920932, 3920932, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 184 },
             new byte[] { 244 }, 3920934, 3920934, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 184 },
             new byte[] { 244 }, 3920936, 3920936, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 184 },
             new byte[] { 244 }, 3920938, 3920938, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 128, 62, 128, 62, 184, 61, 184 },
             new byte[] { 192, 63, 192, 63, 244, 62, 244 }, 3923926, 3923932, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 184, 11, 184, 11, 184, 11, 184, 11, 184, 11, 184, 11, 184, 11 },
             new byte[] { 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17 }, 3924610, 3924623, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15 },
             new byte[] { 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17 }, 3924626, 3924639, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 20, 15, 72, 13, 28, 12, 34, 11, 246, 9, 252, 8 },
             new byte[] { 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17 }, 3924644, 3924655, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 154, 16, 166, 14, 228, 12, 184, 11, 90, 10, 46, 9, 208, 7 },
             new byte[] { 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17 }, 3924658, 3924671, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 104, 16, 66, 14, 128, 12, 240, 10, 96, 9, 208, 7, 14, 6 },
             new byte[] { 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17 }, 3924674, 3924687, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 54, 16, 172, 13, 84, 11, 146, 9, 208, 7, 14, 6, 76, 4 },
             new byte[] { 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17 }, 3924690, 3924703, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 160, 15, 178, 12, 196, 9, 2, 8, 14, 6, 126, 4, 238, 2 },
             new byte[] { 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17 }, 3924706, 3924719, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 172, 13, 34, 11, 52, 8, 64, 6, 226, 4, 132, 3, 38, 2 },
             new byte[] { 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17 }, 3924722, 3924735, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 240, 10, 252, 8, 164, 6, 176, 4, 132, 3, 88, 2, 250, 0 },
             new byte[] { 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17 }, 3924738, 3924751, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 96, 9, 208, 7, 170, 5, 132, 3, 88, 2, 44, 1, 0, 0 },
             new byte[] { 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17 }, 3924754, 3924767, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 160, 15, 160, 15, 160, 15, 160, 15, 160, 15 },
             new byte[] { 48, 17, 48, 17, 48, 17, 48, 17, 48, 17 }, 3924814, 3924823, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 28 },
             new byte[] { 48 }, 3924830, 3924830, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 160, 15, 252, 8, 64, 6, 232, 3 },
             new byte[] { 48, 17, 48, 17, 48, 17, 48, 17 }, 3924832, 3924839, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 170, 15, 228, 12, 8, 7, 176, 4, 244, 1 },
             new byte[] { 48, 17, 48, 17, 48, 17, 48, 17, 48, 17 }, 3924846, 3924855, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 90, 15, 28, 12, 20, 5, 188, 2, 150, 0 },
             new byte[] { 48, 17, 48, 17, 48, 17, 48, 17, 48, 17 }, 3924862, 3924871, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 38 },
             new byte[] { 48 }, 3924876, 3924876, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 246, 14, 34, 11, 188, 2, 200, 0, 50, 0 },
             new byte[] { 48, 17, 48, 17, 48, 17, 48, 17, 48, 17 }, 3924878, 3924887, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 234, 16, 10, 15, 36, 14, 246, 9, 219, 1, 125, 0, 25, 0 },
             new byte[] { 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17 }, 3924890, 3924903, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 114, 16, 116, 14, 72, 13, 202, 8, 250, 0, 50, 0, 0, 0 },
             new byte[] { 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17 }, 3924906, 3924919, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 130, 15, 12, 13, 204, 11, 10, 5, 90, 0, 10, 0, 0, 0 },
             new byte[] { 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17 }, 3924922, 3924935, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 106, 14, 168, 12, 86, 9, 148, 2, 20, 0, 0, 0, 0, 0, 136, 14, 56, 14, 184, 11, 58, 7, 64, 1, 0, 0, 0, 0, 0, 0 },
             new byte[] { 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17 }, 3924938, 3924967, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62 },
             new byte[] { 192, 63, 192, 63, 192, 63, 192, 63, 192, 63, 192, 63, 192, 63, 192, 63, 192, 63, 192, 63, 192, 63, 192, 63, 192, 63, 192, 63, 192, 63, 192, 63 }, 3925004, 3925035, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 184, 11, 184, 11, 184, 11, 40, 10, 128, 12, 128, 12, 128, 12, 40, 10, 128, 12, 128, 12, 128, 12, 40, 10, 128, 12, 128, 12, 128, 12, 40, 10, 128, 12, 128, 12, 128, 12, 40, 10, 108, 12, 108, 12, 108, 12, 40, 10, 254, 11, 234, 11, 254, 11, 191, 9, 134, 11, 64, 11, 134, 11, 81, 9, 14, 11, 150, 10, 14, 11, 212, 8, 170, 10, 236, 9, 170, 10, 102, 8, 40, 10, 86, 9, 40, 10, 238, 7, 212, 8, 32, 8, 212, 8, 250, 5, 128, 7, 128, 7, 128, 7, 36 },
             new byte[] { 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 174, 11, 189, 10, 174, 11, 31, 9, 39, 10, 88, 9, 39, 10, 224, 6, 160, 8, 160, 8, 160, 8, 195 }, 3926040, 3926142, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 220, 5, 220, 5, 220, 5, 8 },
             new byte[] { 189, 6, 189, 6, 189, 6, 86 }, 3926144, 3926150, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 252, 3, 252, 3, 252, 3 },
             new byte[] { 149, 4, 149, 4, 149, 4 }, 3926152, 3926157, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 234, 1, 234, 1, 234, 1 },
             new byte[] { 52, 2, 52, 2, 52, 2 }, 3926160, 3926165, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 232, 3, 18, 7, 18, 7, 88, 12 },
             new byte[] { 160, 15, 160, 15, 160, 15, 160, 15 }, 3979762, 3979769, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 28, 12, 28, 12, 28, 12, 28, 12 },
             new byte[] { 172, 13, 172, 13, 172, 13, 172, 13 }, 3979780, 3979787, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 28, 12, 28, 12, 28, 12, 28, 12 },
             new byte[] { 172, 13, 172, 13, 172, 13, 172, 13 }, 3979814, 3979821, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 172, 13, 172, 13, 172, 13, 172, 13, 172, 13, 172, 13, 172, 13, 172, 13 },
             new byte[] { 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15 }, 3979856, 3979871, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 82, 8, 0, 0 },
             new byte[] { 160, 15, 160, 15 }, 3979886, 3979889, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 82, 8, 0, 0 },
             new byte[] { 160, 15, 160, 15 }, 3979920, 3979923, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 82, 8, 0, 0 },
             new byte[] { 160, 15, 160, 15 }, 3979954, 3979957, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 82, 8, 0, 0 },
             new byte[] { 160, 15, 160, 15 }, 3979988, 3979991, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 82, 8, 0, 0 },
             new byte[] { 160, 15, 160, 15 }, 3980022, 3980025, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 172, 13, 172, 13, 172, 13, 172, 13, 172, 13, 172, 13, 172, 13, 172, 13 },
             new byte[] { 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15 }, 3980060, 3980075, "Found egr map...Delete map");
            base.egrOffSolution();
        }
        public override void dpfOffSolution()
        {
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 230 },
         new byte[] { 255 }, 3151555, 3151555, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 230 },
             new byte[] { 255 }, 3151563, 3151563, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 230 },
             new byte[] { 255 }, 3151571, 3151571, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 230 },
             new byte[] { 255 }, 3151579, 3151579, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 230 },
             new byte[] { 255 }, 3151587, 3151587, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 230 },
             new byte[] { 255 }, 3151595, 3151595, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 230 },
             new byte[] { 255 }, 3151603, 3151603, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 230 },
             new byte[] { 255 }, 3151611, 3151611, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 230 },
             new byte[] { 255 }, 3151619, 3151619, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 218 },
             new byte[] { 255 }, 3151627, 3151627, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 203 },
             new byte[] { 255 }, 3151635, 3151635, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 187 },
             new byte[] { 255 }, 3151643, 3151643, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 171 },
             new byte[] { 255 }, 3151651, 3151651, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 155 },
             new byte[] { 255 }, 3151659, 3151659, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 230 },
             new byte[] { 255 }, 3151691, 3151691, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 230 },
             new byte[] { 255 }, 3151699, 3151699, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 230 },
             new byte[] { 255 }, 3151707, 3151707, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 230 },
             new byte[] { 255 }, 3151715, 3151715, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 230 },
             new byte[] { 255 }, 3151723, 3151723, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 230 },
             new byte[] { 255 }, 3151731, 3151731, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 230 },
             new byte[] { 255 }, 3151739, 3151739, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 230 },
             new byte[] { 255 }, 3151747, 3151747, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 230 },
             new byte[] { 255 }, 3151755, 3151755, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 218 },
             new byte[] { 255 }, 3151763, 3151763, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 203 },
             new byte[] { 255 }, 3151771, 3151771, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 187 },
             new byte[] { 255 }, 3151779, 3151779, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 171 },
             new byte[] { 255 }, 3151787, 3151787, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 155 },
             new byte[] { 255 }, 3151795, 3151795, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 200, 11, 200, 11, 200, 11, 40, 10, 128, 12, 128, 12, 128, 12, 40, 10, 128, 12, 128, 12, 128, 12, 40, 10, 128, 12, 128, 12, 128, 12, 40, 10, 128, 12, 128, 12, 128, 12, 40, 10, 108, 12, 108, 12, 108, 12, 40, 10, 254, 11, 234, 11, 254, 11, 191, 9, 139, 11, 71, 11, 139, 11, 85, 9, 14, 11, 150, 10, 14, 11, 212, 8, 170, 10, 236, 9, 170, 10, 102, 8, 40, 10, 86, 9, 40, 10, 238, 7, 212, 8, 32, 8, 212, 8, 250, 5, 128, 7, 128, 7, 128, 7, 36 },
             new byte[] { 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 174, 11, 189, 10, 174, 11, 31, 9, 39, 10, 88, 9, 39, 10, 224, 6, 160, 8, 160, 8, 160, 8, 195 }, 3151954, 3152056, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 220, 5, 220, 5, 220, 5, 8 },
             new byte[] { 189, 6, 189, 6, 189, 6, 86 }, 3152058, 3152064, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 252, 3, 252, 3, 252, 3 },
             new byte[] { 149, 4, 149, 4, 149, 4 }, 3152066, 3152071, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 234, 1, 234, 1, 234, 1 },
             new byte[] { 52, 2, 52, 2, 52, 2 }, 3152074, 3152079, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16, 14 },
             new byte[] { 48, 17 }, 3468270, 3468271, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16, 14 },
             new byte[] { 48, 17 }, 3468286, 3468287, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16, 14 },
             new byte[] { 48, 17 }, 3468302, 3468303, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16, 14 },
             new byte[] { 48, 17 }, 3468318, 3468319, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16, 14 },
             new byte[] { 48, 17 }, 3468334, 3468335, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16, 14 },
             new byte[] { 48, 17 }, 3468350, 3468351, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16, 14 },
             new byte[] { 48, 17 }, 3468366, 3468367, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16, 14 },
             new byte[] { 48, 17 }, 3468382, 3468383, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 6, 14 },
             new byte[] { 48, 17 }, 3468398, 3468399, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 240, 12, 83, 13 },
             new byte[] { 172, 13, 48, 17 }, 3468412, 3468415, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16, 12, 102, 12 },
             new byte[] { 172, 13, 48, 17 }, 3468428, 3468431, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 63, 11, 113, 11 },
             new byte[] { 172, 13, 48, 17 }, 3468444, 3468447, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 119, 10, 119, 10 },
             new byte[] { 172, 13, 48, 17 }, 3468460, 3468463, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 125, 9, 125, 9 },
             new byte[] { 172, 13, 48, 17 }, 3468476, 3468479, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16, 14 },
             new byte[] { 48, 17 }, 3468542, 3468543, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16, 14 },
             new byte[] { 48, 17 }, 3468558, 3468559, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16, 14 },
             new byte[] { 48, 17 }, 3468574, 3468575, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16, 14 },
             new byte[] { 48, 17 }, 3468590, 3468591, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16, 14 },
             new byte[] { 48, 17 }, 3468606, 3468607, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16, 14 },
             new byte[] { 48, 17 }, 3468622, 3468623, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 73 },
             new byte[] { 172 }, 3468636, 3468636, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16, 14 },
             new byte[] { 48, 17 }, 3468638, 3468639, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 212, 12, 16, 14 },
             new byte[] { 172, 13, 48, 17 }, 3468652, 3468655, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 99, 12, 6, 14 },
             new byte[] { 172, 13, 48, 17 }, 3468668, 3468671, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 141, 11, 83, 13 },
             new byte[] { 172, 13, 48, 17 }, 3468684, 3468687, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 197, 10, 102, 12 },
             new byte[] { 172, 13, 48, 17 }, 3468700, 3468703, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 10, 10, 113, 11 },
             new byte[] { 172, 13, 48, 17 }, 3468716, 3468719, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 93, 9, 119, 10 },
             new byte[] { 172, 13, 48, 17 }, 3468732, 3468735, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 187, 8, 125, 9 },
             new byte[] { 172, 13, 48, 17 }, 3468748, 3468751, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 90, 10, 246, 9, 196, 9, 96, 9, 152, 8, 52, 8, 108, 7, 170, 5 },
             new byte[] { 241, 12, 116, 12, 53, 12, 184, 11, 190, 10, 65, 10, 71, 9, 21, 7 }, 3589574, 3589589, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 190, 10, 128, 12, 228, 12, 220, 5, 244, 1 },
             new byte[] { 110, 13, 160, 15, 29, 16, 83, 7, 113, 2 }, 3589610, 3589619, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 190, 10, 208, 7, 96, 9, 240, 10, 234, 11 },
             new byte[] { 110, 13, 196, 9, 184, 11, 172, 13, 229, 14 }, 3589644, 3589653, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 190, 10, 128, 12, 116, 14, 16, 14, 22, 13 },
             new byte[] { 110, 13, 160, 15, 17, 18, 148, 17, 92, 16 }, 3589678, 3589687, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 52, 8, 158, 7, 108, 7, 108, 7, 164, 6, 120, 5, 188, 2 },
             new byte[] { 65, 10, 134, 9, 71, 9, 71, 9, 77, 8, 214, 6, 107, 3 }, 3589752, 3589765, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 210, 15, 210, 15, 206, 14, 16, 14, 102, 13, 208, 12, 190, 10, 2, 8, 210, 15, 210, 15, 206, 14, 16, 14, 102, 13, 208, 12, 190, 10, 2, 8, 210, 15, 210, 15, 206, 14, 16, 14, 102, 13, 208, 12, 190, 10, 2, 8, 210, 15, 210, 15, 206, 14, 16, 14, 102, 13, 208, 12, 190, 10, 2, 8, 210, 15, 210, 15, 206, 14, 16, 14, 102, 13, 208, 12, 190, 10, 2, 8, 210, 15, 210, 15, 206, 14, 16, 14, 1, 13, 208, 12, 190, 10, 2, 8, 168, 15, 188, 15, 206, 14, 16, 14, 168, 12, 171, 12, 140, 10, 2, 8, 100, 15, 153, 15, 181, 14, 16, 14, 88, 12, 98, 12, 231, 9, 248, 7, 18, 15, 83, 15, 119, 14, 245, 13, 18, 12, 31, 12, 146, 9, 233, 7, 197, 13, 252, 13, 89, 13, 60, 13, 87, 11, 87, 11, 49, 9, 198, 7, 140, 13, 187, 13, 27, 13, 241, 12, 52, 11, 57, 11, 41, 9, 188, 7, 173, 12, 246, 12, 53, 12, 199, 11, 225, 10, 215, 10, 230, 8, 133, 7, 53, 12, 143, 12, 159, 11, 14, 11, 133, 10, 118, 10, 162, 8, 66, 7 },
             new byte[] { 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17 }, 3589916, 3590123, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 72, 8, 72, 8, 35, 7, 187, 5, 229, 4, 106, 4, 29, 4, 225, 3, 139, 3, 160, 10, 160, 10, 125, 7, 4, 6, 73, 5, 0, 5, 169, 4, 86, 4, 239, 3, 72, 13, 72, 13, 45, 8, 227, 5, 143, 4, 13, 4, 209, 3, 152, 3, 72, 3, 106, 14, 106, 14, 170, 10, 9, 8, 167, 6, 247, 5, 127, 5, 33, 5, 163, 4, 216, 14, 216, 14, 64, 11, 159, 8, 61, 7, 131, 6, 243, 5, 120, 5, 7, 5, 216, 14, 216, 14, 47, 11, 155, 8, 95, 7, 157, 6, 17, 6, 147, 5, 27, 5, 46, 14, 46, 14, 234, 10, 245, 7, 118, 6, 214, 5, 97, 5, 240, 4, 93, 4, 212, 13, 212, 13, 134, 10, 154, 7, 55, 6, 196, 5, 111, 5, 35, 5, 181, 4, 22, 13, 22, 13, 33, 10, 105, 7, 232, 5, 109, 5, 4, 5, 170, 4, 57, 4, 98, 12, 98, 12, 13, 10, 245, 7, 71, 6, 147, 5, 47, 5, 216, 4, 116, 4, 64, 11, 64, 11, 109, 8, 37, 6, 146, 4, 3, 4, 202, 3, 149, 3, 105, 3, 122, 8, 122, 8, 107, 6, 7, 5, 136, 4, 26, 4, 215, 3, 132, 3, 65, 3 },
             new byte[] { 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17 }, 3590224, 3590439, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 184, 11, 184, 11, 184, 11, 184, 11, 184, 11, 184, 11, 184, 11, 184, 11, 115, 10, 232, 3 },
             new byte[] { 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15 }, 3591480, 3591499, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 26, 14, 26, 14, 26, 14, 26, 14, 46, 14, 46, 14, 46, 14, 46, 14, 46, 14, 46, 14, 46, 14, 46, 14, 46, 14, 46, 14, 46, 14, 46, 14, 115, 13, 115, 13, 115, 13, 115, 13, 26, 13, 26, 13, 26, 13, 26, 13, 191, 12, 191, 12, 191, 12, 191, 12, 90, 12, 90, 12, 90, 12, 90, 12, 20, 12, 20, 12, 20, 12, 20, 12, 159, 11, 159, 11, 159, 11, 159, 11, 33, 11, 33, 11, 33, 11, 33, 11, 140, 10, 140, 10, 140, 10, 140, 10, 66, 9, 66, 9, 66, 9, 66, 9, 188, 7, 188, 7, 188, 7, 188, 7, 230, 5, 230, 5, 230, 5, 230, 5, 232, 3, 232, 3, 232, 3, 232, 3, 188, 2, 188, 2, 188, 2, 188, 2 },
             new byte[] { 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 93, 13, 93, 13, 93, 13, 93, 13, 204, 12, 204, 12, 204, 12, 204, 12, 33, 12, 33, 12, 33, 12, 33, 12, 166, 10, 166, 10, 166, 10, 166, 10, 229, 8, 229, 8, 229, 8, 229, 8, 201, 6, 201, 6, 201, 6, 201, 6, 126, 4, 126, 4, 126, 4, 126, 4, 37, 3, 37, 3, 37, 3, 37, 3 }, 3591624, 3591759, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16, 14, 72, 13, 72, 13, 72, 13, 178, 10, 196, 9 },
             new byte[] { 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15 }, 3591894, 3591905, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 66, 9, 52, 8, 230, 5, 232, 3, 188, 2 },
             new byte[] { 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 166, 10, 111, 9, 201, 6, 126, 4, 37, 3 }, 3591960, 3591991, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 247, 39 },
             new byte[] { 223, 43 }, 3594400, 3594401, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 163 },
             new byte[] { 248 }, 3710830, 3710830, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16 },
             new byte[] { 106 }, 3710832, 3710832, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 128 },
             new byte[] { 224 }, 3710834, 3710834, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 241, 7, 87 },
             new byte[] { 87, 8, 194 }, 3710836, 3710838, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 183, 8, 16 },
             new byte[] { 39, 9, 132 }, 3710840, 3710842, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 114 },
             new byte[] { 235 }, 3710844, 3710844, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224, 9, 70 },
             new byte[] { 94, 10, 202 }, 3710846, 3710848, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 170, 10, 20 },
             new byte[] { 51, 11, 162 }, 3710850, 3710852, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 124, 11, 227, 11, 78 },
             new byte[] { 15, 12, 123, 12, 236 }, 3710854, 3710858, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 181, 12, 32 },
             new byte[] { 88, 13, 200 }, 3710860, 3710862, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 145, 13, 242, 13, 71 },
             new byte[] { 63, 14, 165, 14, 254 }, 3710864, 3710868, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 176, 14, 145, 15, 104, 16 },
             new byte[] { 108, 15, 88, 16, 58, 17 }, 3710870, 3710875, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 58 },
             new byte[] { 138 }, 3710910, 3710910, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 169 },
             new byte[] { 254 }, 3710912, 3710912, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 15 },
             new byte[] { 105 }, 3710914, 3710914, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 113 },
             new byte[] { 208 }, 3710916, 3710916, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 212, 7, 55 },
             new byte[] { 56, 8, 160 }, 3710918, 3710920, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 157, 8, 242, 8, 71 },
             new byte[] { 11, 9, 101, 9, 190 }, 3710922, 3710926, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 163, 9, 0 },
             new byte[] { 30, 10, 128 }, 3710928, 3710930, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 98 },
             new byte[] { 231 }, 3710932, 3710932, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 195, 10, 42 },
             new byte[] { 77, 11, 185 }, 3710934, 3710936, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 139, 11, 227, 11, 73 },
             new byte[] { 31, 12, 123, 12, 230 }, 3710938, 3710942, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 183, 12, 20 },
             new byte[] { 90, 13, 187 }, 3710944, 3710946, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 112, 13, 212, 13, 159, 14, 108, 15 },
             new byte[] { 28, 14, 133, 14, 90, 15, 49, 16 }, 3710948, 3710955, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 228, 5, 63 },
             new byte[] { 47, 6, 143 }, 3710990, 3710992, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 166 },
             new byte[] { 251 }, 3710994, 3710994, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 4 },
             new byte[] { 94 }, 3710996, 3710996, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 97 },
             new byte[] { 191 }, 3710998, 3710998, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 184, 7, 29 },
             new byte[] { 27, 8, 133 }, 3711000, 3711002, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 134 },
             new byte[] { 243 }, 3711004, 3711004, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 231, 8, 56 },
             new byte[] { 89, 9, 174 }, 3711006, 3711008, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 136, 9, 221, 9, 50 },
             new byte[] { 2, 10, 91, 10, 181 }, 3711010, 3711014, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 138, 10, 233, 10, 67 },
             new byte[] { 17, 11, 117, 11, 211 }, 3711016, 3711020, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 154, 11, 244, 11, 85 },
             new byte[] { 47, 12, 141, 12, 243 }, 3711022, 3711026, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 188, 12, 34 },
             new byte[] { 95, 13, 202 }, 3711028, 3711030, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 237, 13, 166, 14 },
             new byte[] { 159, 14, 98, 15 }, 3711032, 3711035, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 176 },
             new byte[] { 249 }, 3711070, 3711070, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 250, 5, 77 },
             new byte[] { 71, 6, 158 }, 3711072, 3711074, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 164 },
             new byte[] { 249 }, 3711076, 3711076, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 249, 6, 83 },
             new byte[] { 82, 7, 177 }, 3711078, 3711080, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 173, 7, 10 },
             new byte[] { 15, 8, 113 }, 3711082, 3711084, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 107 },
             new byte[] { 215 }, 3711086, 3711086, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 200, 8, 28 },
             new byte[] { 56, 9, 145 }, 3711088, 3711090, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 108 },
             new byte[] { 229 }, 3711092, 3711092, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 189, 9, 18 },
             new byte[] { 58, 10, 147 }, 3711094, 3711096, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 103 },
             new byte[] { 236 }, 3711098, 3711098, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 185, 10, 7 },
             new byte[] { 66, 11, 148 }, 3711100, 3711102, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 86 },
             new byte[] { 231 }, 3711104, 3711104, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 166, 11, 0 },
             new byte[] { 59, 12, 154 }, 3711106, 3711108, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 93 },
             new byte[] { 251 }, 3711110, 3711110, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 37 },
             new byte[] { 205 }, 3711112, 3711112, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 232, 13 },
             new byte[] { 154, 14 }, 3711114, 3711115, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 108 },
             new byte[] { 177 }, 3711150, 3711150, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 189, 5, 8 },
             new byte[] { 6, 6, 85 }, 3711152, 3711154, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 86 },
             new byte[] { 167 }, 3711156, 3711156, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 162 },
             new byte[] { 247 }, 3711158, 3711158, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 242, 6, 73 },
             new byte[] { 75, 7, 166 }, 3711160, 3711162, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 163, 7, 250, 7, 83 },
             new byte[] { 5, 8, 96, 8, 190 }, 3711164, 3711168, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 166, 8, 247, 8, 68 },
             new byte[] { 21, 9, 106, 9, 187 }, 3711170, 3711174, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 146, 9, 224, 9, 48 },
             new byte[] { 13, 10, 94, 10, 178 }, 3711176, 3711180, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 125, 10, 195, 10, 12 },
             new byte[] { 3, 11, 77, 11, 153 }, 3711182, 3711186, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 91 },
             new byte[] { 236 }, 3711188, 3711188, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 179, 11, 101, 12, 72 },
             new byte[] { 73, 12, 4, 13, 242 }, 3711190, 3711194, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 67 },
             new byte[] { 134 }, 3711230, 3711230, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 139 },
             new byte[] { 210 }, 3711232, 3711232, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 202, 5, 15 },
             new byte[] { 20, 6, 93 }, 3711234, 3711236, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 85 },
             new byte[] { 166 }, 3711238, 3711238, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 163 },
             new byte[] { 248 }, 3711240, 3711240, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 244, 6, 72 },
             new byte[] { 77, 7, 165 }, 3711242, 3711244, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 153 },
             new byte[] { 250 }, 3711246, 3711246, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 232, 7, 62 },
             new byte[] { 77, 8, 168 }, 3711248, 3711250, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 143 },
             new byte[] { 253 }, 3711252, 3711252, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 215, 8, 29 },
             new byte[] { 72, 9, 146 }, 3711254, 3711256, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 104 },
             new byte[] { 224 }, 3711258, 3711258, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 177, 9, 249, 9, 60 },
             new byte[] { 45, 10, 121, 10, 191 }, 3711260, 3711264, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 133, 10, 210, 10, 37 },
             new byte[] { 12, 11, 93, 11, 180 }, 3711266, 3711270, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 204, 11, 178, 12 },
             new byte[] { 99, 12, 85, 13 }, 3711272, 3711275, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 251, 4, 68 },
             new byte[] { 59, 5, 135 }, 3711310, 3711312, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 139 },
             new byte[] { 210 }, 3711314, 3711314, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 215, 5, 22 },
             new byte[] { 34, 6, 100 }, 3711316, 3711318, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 91 },
             new byte[] { 172 }, 3711320, 3711320, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 166 },
             new byte[] { 251 }, 3711322, 3711322, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 243, 6, 70 },
             new byte[] { 76, 7, 163 }, 3711324, 3711326, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 147 },
             new byte[] { 244 }, 3711328, 3711328, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 222, 7, 44 },
             new byte[] { 67, 8, 149 }, 3711330, 3711332, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 122 },
             new byte[] { 231 }, 3711334, 3711334, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 188, 8, 255, 8, 76 },
             new byte[] { 44, 9, 114, 9, 195 }, 3711336, 3711340, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 144, 9, 216, 9, 25 },
             new byte[] { 10, 10, 86, 10, 154 }, 3711342, 3711346, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 100 },
             new byte[] { 233 }, 3711348, 3711348, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 180, 10, 89 },
             new byte[] { 61, 11, 234 }, 3711350, 3711352, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 33 },
             new byte[] { 188 }, 3711354, 3711354, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 177 },
             new byte[] { 237 }, 3711390, 3711390, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 249, 4, 68 },
             new byte[] { 57, 5, 135 }, 3711392, 3711394, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 149 },
             new byte[] { 220 }, 3711396, 3711396, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 225, 5, 36 },
             new byte[] { 44, 6, 115 }, 3711398, 3711400, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 115 },
             new byte[] { 198 }, 3711402, 3711402, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 184, 6, 250, 6, 71 },
             new byte[] { 14, 7, 83, 7, 164 }, 3711404, 3711408, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 140 },
             new byte[] { 237 }, 3711410, 3711410, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 208, 7, 19 },
             new byte[] { 52, 8, 122 }, 3711412, 3711414, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 79 },
             new byte[] { 185 }, 3711416, 3711416, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 145 },
             new byte[] { 255 }, 3711418, 3711418, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 210, 8, 21 },
             new byte[] { 67, 9, 137 }, 3711420, 3711422, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 88 },
             new byte[] { 208 }, 3711424, 3711424, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 156, 9, 229, 9, 55 },
             new byte[] { 23, 10, 100, 10, 186 }, 3711426, 3711430, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 218, 10, 132, 11 },
             new byte[] { 101, 11, 23, 12 }, 3711432, 3711435, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 168, 97, 156, 99, 168, 97, 8, 82, 216, 89, 192, 93 },
             new byte[] { 48, 117, 48, 117, 48, 117, 48, 117, 48, 117, 48, 117 }, 3714808, 3714819, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 92, 204, 91, 88, 77, 252, 83, 4, 91, 100, 100, 124, 96, 96, 84, 16, 89, 240, 85 },
             new byte[] { 117, 48, 117, 48, 117, 48, 117, 48, 117, 48, 117, 48, 117, 48, 117, 48, 117, 48, 117 }, 3714821, 3714839, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 155 },
             new byte[] { 201 }, 3778028, 3778028, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 197 },
             new byte[] { 247 }, 3778030, 3778030, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 250, 3, 35 },
             new byte[] { 50, 4, 95 }, 3778032, 3778034, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 88 },
             new byte[] { 154 }, 3778036, 3778036, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 148 },
             new byte[] { 220 }, 3778038, 3778038, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 207, 4, 11 },
             new byte[] { 30, 5, 96 }, 3778040, 3778042, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 70 },
             new byte[] { 162 }, 3778044, 3778044, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 70 },
             new byte[] { 166 }, 3778046, 3778046, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 70 },
             new byte[] { 169 }, 3778048, 3778048, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 70 },
             new byte[] { 172 }, 3778050, 3778050, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 70 },
             new byte[] { 175 }, 3778052, 3778052, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 70 },
             new byte[] { 178 }, 3778054, 3778054, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 0 },
             new byte[] { 51 }, 3778060, 3778060, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 39 },
             new byte[] { 95 }, 3778062, 3778062, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 80 },
             new byte[] { 140 }, 3778064, 3778064, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 159 },
             new byte[] { 226 }, 3778066, 3778066, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 244, 4, 56 },
             new byte[] { 63, 5, 138 }, 3778068, 3778070, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 124 },
             new byte[] { 214 }, 3778072, 3778072, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 192, 5, 4 },
             new byte[] { 33, 6, 109 }, 3778074, 3778076, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 47 },
             new byte[] { 159 }, 3778078, 3778078, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 91 },
             new byte[] { 210 }, 3778080, 3778080, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 91 },
             new byte[] { 214 }, 3778082, 3778082, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 91 },
             new byte[] { 217 }, 3778084, 3778084, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 91 },
             new byte[] { 221 }, 3778086, 3778086, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 94 },
             new byte[] { 150 }, 3778092, 3778092, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 119 },
             new byte[] { 179 }, 3778094, 3778094, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 156 },
             new byte[] { 220 }, 3778096, 3778096, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16 },
             new byte[] { 90 }, 3778098, 3778098, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 110 },
             new byte[] { 192 }, 3778100, 3778100, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224, 5, 82 },
             new byte[] { 61, 6, 185 }, 3778102, 3778104, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 195, 6, 53 },
             new byte[] { 54, 7, 179 }, 3778106, 3778108, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 61 },
             new byte[] { 192 }, 3778110, 3778110, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 61 },
             new byte[] { 196 }, 3778112, 3778112, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 61 },
             new byte[] { 201 }, 3778114, 3778114, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 61 },
             new byte[] { 205 }, 3778116, 3778116, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 61 },
             new byte[] { 209 }, 3778118, 3778118, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 126 },
             new byte[] { 184 }, 3778124, 3778124, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 183 },
             new byte[] { 246 }, 3778126, 3778126, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 15 },
             new byte[] { 86 }, 3778128, 3778128, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 185, 5, 24 },
             new byte[] { 12, 6, 116 }, 3778130, 3778132, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 200, 6, 77 },
             new byte[] { 51, 7, 196 }, 3778134, 3778136, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 176, 7, 228, 7, 228, 7, 228, 7, 228, 7, 228, 7, 228, 7 },
             new byte[] { 50, 8, 110, 8, 115, 8, 120, 8, 124, 8, 129, 8, 134, 8 }, 3778138, 3778151, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 131 },
             new byte[] { 189 }, 3778156, 3778156, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 3 },
             new byte[] { 70 }, 3778158, 3778158, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 140 },
             new byte[] { 218 }, 3778160, 3778160, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 41 },
             new byte[] { 131 }, 3778162, 3778162, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 197, 6, 91 },
             new byte[] { 44, 7, 207 }, 3778164, 3778166, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 223, 7, 228, 7, 228, 7, 228, 7, 228, 7, 228, 7, 228, 7, 228, 7 },
             new byte[] { 96, 8, 106, 8, 110, 8, 115, 8, 120, 8, 124, 8, 129, 8, 134, 8 }, 3778168, 3778183, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 176 },
             new byte[] { 236 }, 3778188, 3778188, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 39 },
             new byte[] { 108 }, 3778190, 3778190, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 215, 5, 132 },
             new byte[] { 41, 6, 227 }, 3778192, 3778194, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 35 },
             new byte[] { 143 }, 3778196, 3778196, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 160, 7, 228, 7, 228, 7, 228, 7, 228, 7, 228, 7, 228, 7, 228, 7, 228, 7 },
             new byte[] { 24, 8, 101, 8, 106, 8, 110, 8, 115, 8, 120, 8, 124, 8, 129, 8, 134, 8 }, 3778198, 3778215, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 226, 4, 88 },
             new byte[] { 33, 5, 160 }, 3778220, 3778222, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 35 },
             new byte[] { 121 }, 3778224, 3778224, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 227, 6, 108 },
             new byte[] { 71, 7, 221 }, 3778226, 3778228, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 208, 7, 228, 7, 228, 7, 228, 7, 228, 7, 228, 7, 228, 7, 228, 7, 228, 7 },
             new byte[] { 75, 8, 101, 8, 106, 8, 110, 8, 115, 8, 120, 8, 124, 8, 129, 8, 134, 8 }, 3778230, 3778247, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 246, 4, 115 },
             new byte[] { 54, 5, 188 }, 3778252, 3778254, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 46 },
             new byte[] { 132 }, 3778256, 3778256, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224, 6, 93 },
             new byte[] { 68, 7, 205 }, 3778258, 3778260, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 188, 7, 228, 7, 228, 7, 228, 7, 228, 7, 228, 7, 228, 7, 228, 7, 228, 7 },
             new byte[] { 54, 8, 101, 8, 106, 8, 110, 8, 115, 8, 120, 8, 124, 8, 129, 8, 134, 8 }, 3778262, 3778279, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 0 },
             new byte[] { 64 }, 3778284, 3778284, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 132 },
             new byte[] { 206 }, 3778286, 3778286, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 56 },
             new byte[] { 143 }, 3778288, 3778288, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 213, 6, 66 },
             new byte[] { 57, 7, 176 }, 3778290, 3778292, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 168, 7, 208, 7, 208, 7, 208, 7, 208, 7, 208, 7, 208, 7, 208, 7, 208, 7 },
             new byte[] { 33, 8, 80, 8, 84, 8, 89, 8, 94, 8, 98, 8, 103, 8, 107, 8, 112, 8 }, 3778294, 3778311, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 0 },
             new byte[] { 64 }, 3778316, 3778316, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 170 },
             new byte[] { 246 }, 3778318, 3778318, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 94 },
             new byte[] { 183 }, 3778320, 3778320, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224, 6, 88 },
             new byte[] { 68, 7, 199 }, 3778322, 3778324, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 148, 7, 158, 7, 158, 7, 158, 7, 158, 7, 158, 7, 158, 7, 158, 7, 158, 7 },
             new byte[] { 11, 8, 27, 8, 31, 8, 36, 8, 40, 8, 45, 8, 49, 8, 54, 8, 58, 8 }, 3778326, 3778343, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 211, 4, 170 },
             new byte[] { 17, 5, 246 }, 3778348, 3778350, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 104 },
             new byte[] { 194 }, 3778352, 3778352, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 18 },
             new byte[] { 121 }, 3778354, 3778354, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 158, 7, 158, 7, 158, 7, 158, 7, 158, 7, 158, 7, 158, 7, 158, 7, 158, 7, 158, 7 },
             new byte[] { 18, 8, 22, 8, 27, 8, 31, 8, 36, 8, 40, 8, 45, 8, 49, 8, 54, 8, 58, 8 }, 3778356, 3778375, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 166 },
             new byte[] { 226 }, 3778380, 3778380, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 140 },
             new byte[] { 214 }, 3778382, 3778382, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 124 },
             new byte[] { 215 }, 3778384, 3778384, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 204, 6, 254, 6, 254, 6, 254, 6, 254, 6, 254, 6, 254, 6, 254, 6, 254, 6, 254, 6, 254, 6 },
             new byte[] { 47, 7, 104, 7, 108, 7, 112, 7, 116, 7, 121, 7, 125, 7, 129, 7, 133, 7, 137, 7, 141, 7 }, 3778386, 3778407, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 149 },
             new byte[] { 208 }, 3778412, 3778412, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 123 },
             new byte[] { 196 }, 3778414, 3778414, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 108 },
             new byte[] { 198 }, 3778416, 3778416, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 161, 6, 224, 6, 224, 6, 224, 6, 224, 6, 224, 6, 224, 6, 224, 6, 224, 6, 224, 6, 224, 6 },
             new byte[] { 2, 7, 72, 7, 76, 7, 80, 7, 84, 7, 88, 7, 93, 7, 97, 7, 101, 7, 105, 7, 109, 7 }, 3778418, 3778439, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 153 },
             new byte[] { 212 }, 3778608, 3778608, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 211, 4, 7 },
             new byte[] { 20, 5, 77 }, 3778610, 3778612, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 85 },
             new byte[] { 163 }, 3778614, 3778614, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 191, 5, 38 },
             new byte[] { 22, 6, 135 }, 3778616, 3778618, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 124 },
             new byte[] { 230 }, 3778620, 3778620, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 219, 6, 48 },
             new byte[] { 79, 7, 174 }, 3778622, 3778624, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 118 },
             new byte[] { 253 }, 3778626, 3778626, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 158, 7, 198, 7, 208, 7, 208, 7 },
             new byte[] { 45, 8, 92, 8, 107, 8, 112, 8 }, 3778628, 3778635, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 191 },
             new byte[] { 252 }, 3778640, 3778640, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 4 },
             new byte[] { 71 }, 3778642, 3778642, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 119 },
             new byte[] { 195 }, 3778644, 3778644, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 232, 5, 91 },
             new byte[] { 62, 6, 187 }, 3778646, 3778648, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 213, 6, 58 },
             new byte[] { 65, 7, 176 }, 3778650, 3778652, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 188, 7, 60 },
             new byte[] { 63, 8, 204 }, 3778654, 3778656, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 112, 8, 152, 8, 192, 8, 192, 8, 192, 8 },
             new byte[] { 9, 9, 57, 9, 105, 9, 110, 9, 115, 9 }, 3778658, 3778667, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 236, 4, 99 },
             new byte[] { 43, 5, 171 }, 3778672, 3778674, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 230, 5, 119 },
             new byte[] { 56, 6, 213 }, 3778676, 3778678, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 244, 6, 106 },
             new byte[] { 93, 7, 223 }, 3778680, 3778682, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 253, 7, 132, 8, 197, 8, 228, 8, 232, 8, 232, 8, 232, 8, 232, 8 },
             new byte[] { 128, 8, 20, 9, 95, 9, 133, 9, 143, 9, 148, 9, 153, 9, 158, 9 }, 3778684, 3778699, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 17 },
             new byte[] { 82 }, 3778704, 3778704, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 168 },
             new byte[] { 244 }, 3778706, 3778706, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 73 },
             new byte[] { 161 }, 3778708, 3778708, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 254, 6, 151, 7, 7 },
             new byte[] { 100, 7, 10, 8, 133 }, 3778710, 3778714, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 124, 8, 243, 8, 16 },
             new byte[] { 7, 9, 139, 9, 175 }, 3778716, 3778720, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16 },
             new byte[] { 180 }, 3778722, 3778722, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16 },
             new byte[] { 186 }, 3778724, 3778724, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16 },
             new byte[] { 191 }, 3778726, 3778726, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16 },
             new byte[] { 196 }, 3778728, 3778728, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16 },
             new byte[] { 202 }, 3778730, 3778730, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 50 },
             new byte[] { 117 }, 3778736, 3778736, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 231, 5, 150 },
             new byte[] { 54, 6, 242 }, 3778738, 3778740, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 67 },
             new byte[] { 173 }, 3778742, 3778742, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 231, 7, 102 },
             new byte[] { 95, 8, 234 }, 3778744, 3778746, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 183, 8, 16 },
             new byte[] { 69, 9, 169 }, 3778748, 3778750, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16 },
             new byte[] { 175 }, 3778752, 3778752, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16 },
             new byte[] { 180 }, 3778754, 3778754, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16 },
             new byte[] { 186 }, 3778756, 3778756, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16 },
             new byte[] { 191 }, 3778758, 3778758, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16 },
             new byte[] { 196 }, 3778760, 3778760, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16 },
             new byte[] { 202 }, 3778762, 3778762, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 178 },
             new byte[] { 251 }, 3778768, 3778768, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 71 },
             new byte[] { 155 }, 3778770, 3778770, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 198, 6, 68 },
             new byte[] { 37, 7, 174 }, 3778772, 3778774, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 231, 7, 142, 8, 194, 8, 16 },
             new byte[] { 95, 8, 21, 9, 81, 9, 169 }, 3778776, 3778782, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16 },
             new byte[] { 175 }, 3778784, 3778784, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16 },
             new byte[] { 180 }, 3778786, 3778786, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16 },
             new byte[] { 186 }, 3778788, 3778788, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16 },
             new byte[] { 191 }, 3778790, 3778790, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16 },
             new byte[] { 196 }, 3778792, 3778792, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16 },
             new byte[] { 202 }, 3778794, 3778794, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 3 },
             new byte[] { 80 }, 3778800, 3778800, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 145 },
             new byte[] { 233 }, 3778802, 3778802, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 236, 6, 52 },
             new byte[] { 77, 7, 157 }, 3778804, 3778806, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 226, 7, 142, 8, 211, 8, 16 },
             new byte[] { 90, 8, 21, 9, 99, 9, 169 }, 3778808, 3778814, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16 },
             new byte[] { 175 }, 3778816, 3778816, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16 },
             new byte[] { 180 }, 3778818, 3778818, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16 },
             new byte[] { 186 }, 3778820, 3778820, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16 },
             new byte[] { 191 }, 3778822, 3778822, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16 },
             new byte[] { 196 }, 3778824, 3778824, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16 },
             new byte[] { 202 }, 3778826, 3778826, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 34 },
             new byte[] { 113 }, 3778832, 3778832, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 162 },
             new byte[] { 251 }, 3778834, 3778834, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 232, 6, 51 },
             new byte[] { 73, 7, 156 }, 3778836, 3778838, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 226, 7, 142, 8, 245, 8, 16 },
             new byte[] { 90, 8, 21, 9, 135, 9, 169 }, 3778840, 3778846, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16 },
             new byte[] { 175 }, 3778848, 3778848, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16 },
             new byte[] { 180 }, 3778850, 3778850, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16 },
             new byte[] { 186 }, 3778852, 3778852, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16 },
             new byte[] { 191 }, 3778854, 3778854, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16 },
             new byte[] { 196 }, 3778856, 3778856, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16 },
             new byte[] { 202 }, 3778858, 3778858, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 4 },
             new byte[] { 81 }, 3778864, 3778864, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 140 },
             new byte[] { 228 }, 3778866, 3778866, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 205, 6, 8 },
             new byte[] { 44, 7, 110 }, 3778868, 3778870, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 226, 7, 142, 8, 14 },
             new byte[] { 90, 8, 21, 9, 162 }, 3778872, 3778876, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16 },
             new byte[] { 169 }, 3778878, 3778878, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16 },
             new byte[] { 175 }, 3778880, 3778880, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16 },
             new byte[] { 180 }, 3778882, 3778882, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16 },
             new byte[] { 186 }, 3778884, 3778884, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16 },
             new byte[] { 191 }, 3778886, 3778886, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16 },
             new byte[] { 196 }, 3778888, 3778888, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16 },
             new byte[] { 202 }, 3778890, 3778890, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 227, 5, 96 },
             new byte[] { 46, 6, 181 }, 3778896, 3778898, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 185, 6, 8 },
             new byte[] { 23, 7, 110 }, 3778900, 3778902, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 226, 7, 142, 8, 15 },
             new byte[] { 90, 8, 21, 9, 163 }, 3778904, 3778908, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16 },
             new byte[] { 169 }, 3778910, 3778910, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16 },
             new byte[] { 175 }, 3778912, 3778912, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16 },
             new byte[] { 180 }, 3778914, 3778914, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16 },
             new byte[] { 186 }, 3778916, 3778916, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16 },
             new byte[] { 191 }, 3778918, 3778918, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16 },
             new byte[] { 196 }, 3778920, 3778920, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16 },
             new byte[] { 202 }, 3778922, 3778922, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 190, 5, 28 },
             new byte[] { 8, 6, 110 }, 3778928, 3778930, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 164, 6, 8 },
             new byte[] { 1, 7, 110 }, 3778932, 3778934, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 208, 7, 142, 8, 6 },
             new byte[] { 70, 8, 21, 9, 153 }, 3778936, 3778940, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 6 },
             new byte[] { 159 }, 3778942, 3778942, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 6 },
             new byte[] { 164 }, 3778944, 3778944, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 6 },
             new byte[] { 169 }, 3778946, 3778946, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 6 },
             new byte[] { 175 }, 3778948, 3778948, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 6 },
             new byte[] { 180 }, 3778950, 3778950, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 6 },
             new byte[] { 185 }, 3778952, 3778952, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 6 },
             new byte[] { 191 }, 3778954, 3778954, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 190, 5, 210, 5, 164, 6, 8 },
             new byte[] { 8, 6, 32, 6, 1, 7, 110 }, 3778960, 3778966, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 208, 7, 142, 8, 172, 8, 172, 8, 172, 8, 172, 8, 172, 8, 172, 8, 172, 8, 172, 8 },
             new byte[] { 70, 8, 21, 9, 58, 9, 63, 9, 68, 9, 73, 9, 78, 9, 83, 9, 88, 9, 94, 9 }, 3778968, 3778987, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 190, 5, 210, 5, 164, 6, 8 },
             new byte[] { 8, 6, 32, 6, 1, 7, 110 }, 3778992, 3778998, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 208, 7, 208, 7, 208, 7, 208, 7, 208, 7, 208, 7, 208, 7, 208, 7, 208, 7, 208, 7 },
             new byte[] { 70, 8, 75, 8, 80, 8, 84, 8, 89, 8, 94, 8, 98, 8, 103, 8, 107, 8, 112, 8 }, 3779000, 3779019, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 111 },
             new byte[] { 168 }, 3779296, 3779296, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 201, 4, 190, 5, 39 },
             new byte[] { 10, 5, 16, 6, 131 }, 3779298, 3779302, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 104 },
             new byte[] { 204 }, 3779304, 3779304, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 124 },
             new byte[] { 230 }, 3779306, 3779306, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 139 },
             new byte[] { 250 }, 3779308, 3779308, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 204, 6, 234, 6, 158, 7, 228, 7, 228, 7 },
             new byte[] { 68, 7, 105, 7, 47, 8, 128, 8, 134, 8 }, 3779310, 3779319, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 146 },
             new byte[] { 205 }, 3779322, 3779322, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 40 },
             new byte[] { 110 }, 3779324, 3779324, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 220, 5, 134 },
             new byte[] { 47, 6, 231 }, 3779326, 3779328, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 249, 6, 56 },
             new byte[] { 102, 7, 174 }, 3779330, 3779332, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 98 },
             new byte[] { 223 }, 3779334, 3779334, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 118 },
             new byte[] { 250 }, 3779336, 3779336, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 138, 7, 2 },
             new byte[] { 21, 8, 155 }, 3779338, 3779340, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 222, 8, 222, 8 },
             new byte[] { 141, 9, 148, 9 }, 3779342, 3779345, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 226, 4, 105 },
             new byte[] { 33, 5, 178 }, 3779348, 3779350, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 245, 5, 144 },
             new byte[] { 74, 6, 242 }, 3779352, 3779354, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 38 },
             new byte[] { 149 }, 3779356, 3779356, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 103 },
             new byte[] { 224 }, 3779358, 3779358, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 148, 7, 162, 7, 238, 7, 67 },
             new byte[] { 21, 8, 41, 8, 128, 8, 225 }, 3779360, 3779366, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 6 },
             new byte[] { 185 }, 3779368, 3779368, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 6 },
             new byte[] { 191 }, 3779370, 3779370, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 5 },
             new byte[] { 69 }, 3779374, 3779374, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 120 },
             new byte[] { 194 }, 3779376, 3779376, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 14 },
             new byte[] { 100 }, 3779378, 3779378, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 179, 6, 121 },
             new byte[] { 23, 7, 238 }, 3779380, 3779382, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 157, 7, 218, 7, 253, 7, 27 },
             new byte[] { 25, 8, 95, 8, 138, 8, 176 }, 3779384, 3779390, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 162, 8, 46 },
             new byte[] { 71, 9, 228 }, 3779392, 3779394, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 46 },
             new byte[] { 234 }, 3779396, 3779396, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 34 },
             new byte[] { 100 }, 3779400, 3779400, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 145 },
             new byte[] { 220 }, 3779402, 3779402, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 37 },
             new byte[] { 124 }, 3779404, 3779404, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 244, 6, 148, 7, 240, 7, 4 },
             new byte[] { 92, 7, 10, 8, 113, 8, 140 }, 3779406, 3779412, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 27 },
             new byte[] { 170 }, 3779414, 3779414, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 102, 8, 202, 8, 51 },
             new byte[] { 0, 9, 114, 9, 233 }, 3779416, 3779420, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 51 },
             new byte[] { 239 }, 3779422, 3779422, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 42 },
             new byte[] { 108 }, 3779426, 3779426, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 155 },
             new byte[] { 231 }, 3779428, 3779428, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 44 },
             new byte[] { 132 }, 3779430, 3779430, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 254, 6, 168, 7, 42 },
             new byte[] { 102, 7, 31, 8, 175 }, 3779432, 3779436, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 52 },
             new byte[] { 191 }, 3779438, 3779438, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 112, 8, 137, 8, 26 },
             new byte[] { 5, 9, 38, 9, 200 }, 3779440, 3779444, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 56 },
             new byte[] { 238 }, 3779446, 3779446, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 56 },
             new byte[] { 245 }, 3779448, 3779448, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 57 },
             new byte[] { 124 }, 3779452, 3779452, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 4 },
             new byte[] { 85 }, 3779454, 3779454, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 126 },
             new byte[] { 218 }, 3779456, 3779456, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 88 },
             new byte[] { 197 }, 3779458, 3779458, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 220, 7, 82 },
             new byte[] { 87, 8, 218 }, 3779460, 3779462, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 122, 8, 152, 8, 167, 8, 36 },
             new byte[] { 10, 9, 48, 9, 70, 9, 210 }, 3779464, 3779470, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 61 },
             new byte[] { 244 }, 3779472, 3779472, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 61 },
             new byte[] { 250 }, 3779474, 3779474, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 96 },
             new byte[] { 165 }, 3779478, 3779478, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 34 },
             new byte[] { 117 }, 3779480, 3779480, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 179, 6, 153, 7, 52 },
             new byte[] { 18, 7, 10, 8, 180 }, 3779482, 3779486, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 97 },
             new byte[] { 234 }, 3779488, 3779488, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 127, 8, 162, 8, 182, 8, 66 },
             new byte[] { 15, 9, 59, 9, 86, 9, 243 }, 3779490, 3779496, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 66 },
             new byte[] { 249 }, 3779498, 3779498, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 66, 9 },
             new byte[] { 0, 10 }, 3779500, 3779501, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 184, 5, 101 },
             new byte[] { 1, 6, 187 }, 3779504, 3779506, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 8 },
             new byte[] { 108 }, 3779508, 3779508, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 223, 7, 92 },
             new byte[] { 84, 8, 222 }, 3779510, 3779512, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 112 },
             new byte[] { 249 }, 3779514, 3779514, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 132, 8, 172, 8, 232, 8, 96, 9, 96, 9, 96, 9 },
             new byte[] { 21, 9, 69, 9, 140, 9, 19, 10, 25, 10, 32, 10 }, 3779516, 3779527, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 208, 5, 114 },
             new byte[] { 26, 6, 201 }, 3779530, 3779532, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 64 },
             new byte[] { 167 }, 3779534, 3779534, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 12 },
             new byte[] { 132 }, 3779536, 3779536, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 102 },
             new byte[] { 233 }, 3779538, 3779538, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 117 },
             new byte[] { 255 }, 3779540, 3779540, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 134, 8, 177, 8, 46 },
             new byte[] { 23, 9, 75, 9, 215 }, 3779542, 3779546, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 66 },
             new byte[] { 243 }, 3779548, 3779548, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 66 },
             new byte[] { 249 }, 3779550, 3779550, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 66, 9 },
             new byte[] { 0, 10 }, 3779552, 3779553, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 204, 5, 170, 6, 66 },
             new byte[] { 22, 6, 4, 7, 169 }, 3779556, 3779560, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 52 },
             new byte[] { 174 }, 3779562, 3779562, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 117 },
             new byte[] { 249 }, 3779564, 3779564, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 130, 8, 152, 8, 202, 8, 61 },
             new byte[] { 13, 9, 42, 9, 101, 9, 231 }, 3779566, 3779572, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 61 },
             new byte[] { 237 }, 3779574, 3779574, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 61 },
             new byte[] { 244 }, 3779576, 3779576, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 61 },
             new byte[] { 250 }, 3779578, 3779578, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 204, 5, 170, 6, 66 },
             new byte[] { 22, 6, 4, 7, 169 }, 3779582, 3779586, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 52 },
             new byte[] { 174 }, 3779588, 3779588, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 117 },
             new byte[] { 249 }, 3779590, 3779590, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 130, 8, 152, 8, 202, 8, 252, 8, 252, 8, 252, 8, 252, 8 },
             new byte[] { 13, 9, 42, 9, 101, 9, 161, 9, 167, 9, 174, 9, 180, 9 }, 3779592, 3779605, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 126 },
             new byte[] { 184 }, 3779876, 3779876, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 252, 4, 117 },
             new byte[] { 63, 5, 194 }, 3779878, 3779880, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 248, 5, 119 },
             new byte[] { 81, 6, 220 }, 3779882, 3779884, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 134 },
             new byte[] { 240 }, 3779886, 3779886, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 139 },
             new byte[] { 250 }, 3779888, 3779888, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 219, 6, 43 },
             new byte[] { 84, 7, 175 }, 3779890, 3779892, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 188, 7, 228, 7, 228, 7 },
             new byte[] { 80, 8, 128, 8, 134, 8 }, 3779894, 3779899, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 161 },
             new byte[] { 220 }, 3779902, 3779902, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 20 },
             new byte[] { 89 }, 3779904, 3779904, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224, 5, 86 },
             new byte[] { 51, 6, 180 }, 3779906, 3779908, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 235, 6, 66 },
             new byte[] { 87, 7, 184 }, 3779910, 3779912, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 106 },
             new byte[] { 232 }, 3779914, 3779914, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 140, 7, 173, 7, 182, 8, 222, 8, 222, 8 },
             new byte[] { 17, 8, 58, 8, 92, 9, 141, 9, 148, 9 }, 3779916, 3779925, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 196, 4, 70 },
             new byte[] { 1, 5, 141 }, 3779928, 3779930, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 244, 5, 134 },
             new byte[] { 73, 6, 231 }, 3779932, 3779934, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 51 },
             new byte[] { 163 }, 3779936, 3779936, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 103 },
             new byte[] { 224 }, 3779938, 3779938, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 149, 7, 188, 7, 7 },
             new byte[] { 22, 8, 69, 8, 155 }, 3779940, 3779944, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 6 },
             new byte[] { 178 }, 3779946, 3779946, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 6 },
             new byte[] { 185 }, 3779948, 3779948, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 6 },
             new byte[] { 191 }, 3779950, 3779950, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 0 },
             new byte[] { 64 }, 3779954, 3779954, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 110 },
             new byte[] { 183 }, 3779956, 3779956, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 15 },
             new byte[] { 101 }, 3779958, 3779958, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 178, 6, 121 },
             new byte[] { 22, 7, 238 }, 3779960, 3779962, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 157, 7, 223, 7, 2 },
             new byte[] { 25, 8, 101, 8, 144 }, 3779964, 3779968, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 82 },
             new byte[] { 235 }, 3779970, 3779970, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 36 },
             new byte[] { 210 }, 3779972, 3779972, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 46 },
             new byte[] { 228 }, 3779974, 3779974, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 46 },
             new byte[] { 234 }, 3779976, 3779976, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 10 },
             new byte[] { 75 }, 3779980, 3779980, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 120 },
             new byte[] { 194 }, 3779982, 3779982, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 37 },
             new byte[] { 124 }, 3779984, 3779984, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 209, 6, 153, 7, 220, 7, 4 },
             new byte[] { 55, 7, 15, 8, 92, 8, 140 }, 3779986, 3779992, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 88 },
             new byte[] { 236 }, 3779994, 3779994, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 172, 8, 46 },
             new byte[] { 75, 9, 221 }, 3779996, 3779998, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 51 },
             new byte[] { 233 }, 3780000, 3780000, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 51 },
             new byte[] { 239 }, 3780002, 3780002, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 20 },
             new byte[] { 85 }, 3780006, 3780006, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 154 },
             new byte[] { 230 }, 3780008, 3780008, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 76 },
             new byte[] { 165 }, 3780010, 3780010, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 252, 6, 166, 7, 42 },
             new byte[] { 100, 7, 29, 8, 175 }, 3780012, 3780016, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 67 },
             new byte[] { 207 }, 3780018, 3780018, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 142, 8, 222, 8, 53 },
             new byte[] { 37, 9, 129, 9, 229 }, 3780020, 3780024, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 56 },
             new byte[] { 238 }, 3780026, 3780026, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 56 },
             new byte[] { 245 }, 3780028, 3780028, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 50 },
             new byte[] { 117 }, 3780032, 3780032, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 190, 5, 126 },
             new byte[] { 12, 6, 218 }, 3780034, 3780036, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 65 },
             new byte[] { 173 }, 3780038, 3780038, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 220, 7, 96 },
             new byte[] { 87, 8, 232 }, 3780040, 3780042, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 152, 8, 197, 8, 26 },
             new byte[] { 42, 9, 96, 9, 193 }, 3780044, 3780048, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 61 },
             new byte[] { 237 }, 3780050, 3780050, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 61 },
             new byte[] { 244 }, 3780052, 3780052, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 61 },
             new byte[] { 250 }, 3780054, 3780054, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 70 },
             new byte[] { 138 }, 3780058, 3780058, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 205, 5, 217, 6, 162, 7, 66 },
             new byte[] { 27, 6, 58, 7, 20, 8, 195 }, 3780060, 3780066, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 127, 8, 200, 8, 252, 8, 36 },
             new byte[] { 9, 9, 93, 9, 155, 9, 204 }, 3780068, 3780074, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 66 },
             new byte[] { 243 }, 3780076, 3780076, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 66 },
             new byte[] { 249 }, 3780078, 3780078, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 66, 9 },
             new byte[] { 0, 10 }, 3780080, 3780081, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 120 },
             new byte[] { 190 }, 3780084, 3780084, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 250, 5, 8 },
             new byte[] { 75, 6, 108 }, 3780086, 3780088, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 223, 7, 118 },
             new byte[] { 84, 8, 250 }, 3780090, 3780092, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 142, 8, 147, 8, 222, 8, 41 },
             new byte[] { 25, 9, 37, 9, 123, 9, 209 }, 3780094, 3780100, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 86, 9, 86, 9, 86, 9 },
             new byte[] { 8, 10, 15, 10, 21, 10 }, 3780102, 3780107, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 120 },
             new byte[] { 190 }, 3780110, 3780110, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 44 },
             new byte[] { 127 }, 3780112, 3780112, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 58 },
             new byte[] { 161 }, 3780114, 3780114, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 17 },
             new byte[] { 137 }, 3780116, 3780116, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 137, 8, 145, 8, 155, 8, 230, 8, 66 },
             new byte[] { 14, 9, 29, 9, 45, 9, 131, 9, 236 }, 3780118, 3780126, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 66 },
             new byte[] { 243 }, 3780128, 3780128, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 66 },
             new byte[] { 249 }, 3780130, 3780130, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 66, 9 },
             new byte[] { 0, 10 }, 3780132, 3780133, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 120 },
             new byte[] { 190 }, 3780136, 3780136, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 114 },
             new byte[] { 201 }, 3780138, 3780138, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 108 },
             new byte[] { 213 }, 3780140, 3780140, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 52 },
             new byte[] { 174 }, 3780142, 3780142, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 141, 8, 152, 8, 178, 8, 251, 8, 61 },
             new byte[] { 18, 9, 36, 9, 70, 9, 154, 9, 231 }, 3780144, 3780152, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 61 },
             new byte[] { 237 }, 3780154, 3780154, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 61 },
             new byte[] { 244 }, 3780156, 3780156, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 61 },
             new byte[] { 250 }, 3780158, 3780158, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 195, 5, 83 },
             new byte[] { 13, 6, 182 }, 3780162, 3780164, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 250, 7, 160, 8, 232, 8, 19 },
             new byte[] { 107, 8, 32, 9, 115, 9, 167 }, 3780166, 3780172, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 11 },
             new byte[] { 165 }, 3780174, 3780174, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 202, 8, 202, 8, 202, 8, 202, 8, 202, 8 },
             new byte[] { 101, 9, 108, 9, 114, 9, 120, 9, 126, 9 }, 3780176, 3780185, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 30 },
             new byte[] { 83 }, 3782804, 3782804, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 63 },
             new byte[] { 120 }, 3782806, 3782806, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 88 },
             new byte[] { 149 }, 3782808, 3782808, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 106 },
             new byte[] { 170 }, 3782810, 3782810, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 129 },
             new byte[] { 197 }, 3782812, 3782812, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 168 },
             new byte[] { 241 }, 3782814, 3782814, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 210, 4, 22 },
             new byte[] { 33, 5, 108 }, 3782816, 3782818, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 84 },
             new byte[] { 177 }, 3782820, 3782820, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 164, 5, 33 },
             new byte[] { 10, 6, 148 }, 3782822, 3782824, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 177, 6, 234, 6, 26 },
             new byte[] { 50, 7, 116, 7, 171 }, 3782826, 3782830, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 48 },
             new byte[] { 102 }, 3782836, 3782836, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 89 },
             new byte[] { 147 }, 3782838, 3782838, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 99 },
             new byte[] { 160 }, 3782840, 3782840, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 135 },
             new byte[] { 201 }, 3782842, 3782842, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 169 },
             new byte[] { 240 }, 3782844, 3782844, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 217, 4, 19 },
             new byte[] { 37, 5, 102 }, 3782846, 3782848, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 76 },
             new byte[] { 166 }, 3782850, 3782850, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 171, 5, 31 },
             new byte[] { 14, 6, 142 }, 3782852, 3782854, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 178, 6, 95 },
             new byte[] { 47, 7, 237 }, 3782856, 3782858, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 193, 7, 24 },
             new byte[] { 91, 8, 190 }, 3782860, 3782862, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 69 },
             new byte[] { 124 }, 3782868, 3782868, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 112 },
             new byte[] { 171 }, 3782870, 3782870, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 136 },
             new byte[] { 199 }, 3782872, 3782872, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 184 },
             new byte[] { 253 }, 3782874, 3782874, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 223, 4, 20 },
             new byte[] { 41, 5, 100 }, 3782876, 3782878, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 89 },
             new byte[] { 176 }, 3782880, 3782880, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 165, 5, 4 },
             new byte[] { 5, 6, 109 }, 3782882, 3782884, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 139, 6, 104 },
             new byte[] { 2, 7, 243 }, 3782886, 3782888, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 9 },
             new byte[] { 164 }, 3782890, 3782890, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 94, 8, 180, 8 },
             new byte[] { 4, 9, 102, 9 }, 3782892, 3782895, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 98 },
             new byte[] { 154 }, 3782900, 3782900, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 145 },
             new byte[] { 206 }, 3782902, 3782902, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 164 },
             new byte[] { 229 }, 3782904, 3782904, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 229, 4, 24 },
             new byte[] { 44, 5, 101 }, 3782906, 3782908, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 86 },
             new byte[] { 170 }, 3782910, 3782910, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 166, 5, 253, 5, 95 },
             new byte[] { 2, 6, 98, 6, 207 }, 3782912, 3782916, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 218, 6, 0 },
             new byte[] { 86, 7, 150 }, 3782918, 3782920, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 122, 8, 212, 8, 252, 8 },
             new byte[] { 30, 9, 132, 9, 180, 9 }, 3782922, 3782927, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 122 },
             new byte[] { 179 }, 3782932, 3782932, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 170 },
             new byte[] { 232 }, 3782934, 3782934, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 192, 4, 15 },
             new byte[] { 2, 5, 89 }, 3782936, 3782938, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 73 },
             new byte[] { 153 }, 3782940, 3782940, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 151 },
             new byte[] { 239 }, 3782942, 3782942, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 236, 5, 69 },
             new byte[] { 77, 6, 175 }, 3782944, 3782946, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 163, 6, 59 },
             new byte[] { 23, 7, 190 }, 3782948, 3782950, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 117, 8, 203, 8, 4 },
             new byte[] { 19, 9, 117, 9, 183 }, 3782952, 3782956, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 12 },
             new byte[] { 197 }, 3782958, 3782958, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 146 },
             new byte[] { 205 }, 3782964, 3782964, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 196, 4, 245, 4, 73 },
             new byte[] { 4, 5, 58, 5, 150 }, 3782966, 3782970, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 139 },
             new byte[] { 223 }, 3782972, 3782972, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 215, 5, 52 },
             new byte[] { 51, 6, 153 }, 3782974, 3782976, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 152, 6, 254, 6, 164, 7, 180, 8, 5 },
             new byte[] { 8, 7, 121, 7, 46, 8, 87, 9, 179 }, 3782978, 3782986, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 25 },
             new byte[] { 206 }, 3782988, 3782988, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 25 },
             new byte[] { 211 }, 3782990, 3782990, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 166 },
             new byte[] { 226 }, 3782996, 3782996, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 221, 4, 45 },
             new byte[] { 30, 5, 117 }, 3782998, 3783000, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 138 },
             new byte[] { 219 }, 3783002, 3783002, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 216, 5, 43 },
             new byte[] { 49, 6, 140 }, 3783004, 3783006, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 146 },
             new byte[] { 253 }, 3783008, 3783008, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 244, 6, 91 },
             new byte[] { 106, 7, 220 }, 3783010, 3783012, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 13 },
             new byte[] { 159 }, 3783014, 3783014, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 203, 8, 25 },
             new byte[] { 111, 9, 201 }, 3783016, 3783018, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 25 },
             new byte[] { 206 }, 3783020, 3783020, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 25 },
             new byte[] { 211 }, 3783022, 3783022, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 205, 4, 8 },
             new byte[] { 10, 5, 75 }, 3783028, 3783030, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 90 },
             new byte[] { 165 }, 3783032, 3783032, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 193, 5, 25 },
             new byte[] { 21, 6, 117 }, 3783034, 3783036, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 122 },
             new byte[] { 224 }, 3783038, 3783038, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 232, 6, 71 },
             new byte[] { 89, 7, 194 }, 3783040, 3783042, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 173, 7, 87 },
             new byte[] { 52, 8, 238 }, 3783044, 3783046, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 206, 8, 16 },
             new byte[] { 115, 9, 191 }, 3783048, 3783050, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16 },
             new byte[] { 196 }, 3783052, 3783052, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16 },
             new byte[] { 202 }, 3783054, 3783054, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 246, 4, 44 },
             new byte[] { 54, 5, 113 }, 3783060, 3783062, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 123 },
             new byte[] { 200 }, 3783064, 3783064, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 229, 5, 70 },
             new byte[] { 59, 6, 165 }, 3783066, 3783068, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 180, 6, 42 },
             new byte[] { 30, 7, 159 }, 3783070, 3783072, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 142, 7, 222, 7, 92 },
             new byte[] { 14, 8, 104, 8, 243 }, 3783074, 3783078, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 212, 8, 16 },
             new byte[] { 121, 9, 191 }, 3783080, 3783082, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16 },
             new byte[] { 196 }, 3783084, 3783084, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16 },
             new byte[] { 202 }, 3783086, 3783086, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 61 },
             new byte[] { 128 }, 3783092, 3783092, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 110 },
             new byte[] { 183 }, 3783094, 3783094, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 180, 5, 10 },
             new byte[] { 4, 6, 98 }, 3783096, 3783098, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 97 },
             new byte[] { 194 }, 3783100, 3783100, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 194, 6, 45 },
             new byte[] { 44, 7, 162 }, 3783102, 3783104, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 145, 7, 228, 7, 92 },
             new byte[] { 17, 8, 110, 8, 243 }, 3783106, 3783110, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 212, 8, 16 },
             new byte[] { 121, 9, 191 }, 3783112, 3783114, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16 },
             new byte[] { 196 }, 3783116, 3783116, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16 },
             new byte[] { 202 }, 3783118, 3783118, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 131 },
             new byte[] { 202 }, 3783124, 3783124, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 175 },
             new byte[] { 251 }, 3783126, 3783126, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 236, 5, 46 },
             new byte[] { 63, 6, 136 }, 3783128, 3783130, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 123 },
             new byte[] { 221 }, 3783132, 3783132, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 207, 6, 48 },
             new byte[] { 58, 7, 165 }, 3783134, 3783136, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 147, 7, 234, 7, 92 },
             new byte[] { 19, 8, 117, 8, 243 }, 3783138, 3783142, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 212, 8, 16 },
             new byte[] { 121, 9, 191 }, 3783144, 3783146, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16 },
             new byte[] { 196 }, 3783148, 3783148, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16 },
             new byte[] { 202 }, 3783150, 3783150, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 160 },
             new byte[] { 232 }, 3783156, 3783156, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 188, 5, 237, 5, 46 },
             new byte[] { 9, 6, 64, 6, 136 }, 3783158, 3783162, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 125 },
             new byte[] { 223 }, 3783164, 3783164, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 209, 6, 43 },
             new byte[] { 60, 7, 160 }, 3783166, 3783168, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 135, 7, 222, 7, 87 },
             new byte[] { 6, 8, 104, 8, 238 }, 3783170, 3783174, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 212, 8, 16 },
             new byte[] { 121, 9, 191 }, 3783176, 3783178, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16 },
             new byte[] { 196 }, 3783180, 3783180, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16 },
             new byte[] { 202 }, 3783182, 3783182, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 188, 5, 200, 5, 238, 5, 45 },
             new byte[] { 5, 6, 21, 6, 65, 6, 135 }, 3783188, 3783194, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 127 },
             new byte[] { 226 }, 3783196, 3783196, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 210, 6, 38 },
             new byte[] { 61, 7, 155 }, 3783198, 3783200, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 122 },
             new byte[] { 249 }, 3783202, 3783202, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 210, 7, 82 },
             new byte[] { 91, 8, 233 }, 3783204, 3783206, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 212, 8, 16 },
             new byte[] { 121, 9, 191 }, 3783208, 3783210, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16 },
             new byte[] { 196 }, 3783212, 3783212, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16 },
             new byte[] { 202 }, 3783214, 3783214, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 157 },
             new byte[] { 203 }, 3783364, 3783364, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 61 },
             new byte[] { 118 }, 3783366, 3783366, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 101 },
             new byte[] { 163 }, 3783368, 3783368, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 191, 4, 251, 4, 25 },
             new byte[] { 5, 5, 72, 5, 107 }, 3783370, 3783374, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 80 },
             new byte[] { 168 }, 3783376, 3783376, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 125 },
             new byte[] { 220 }, 3783378, 3783378, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 195, 5, 245, 5, 250, 5, 250, 5, 250, 5 },
             new byte[] { 42, 6, 100, 6, 109, 6, 113, 6, 116, 6 }, 3783380, 3783389, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 252, 3, 136 },
             new byte[] { 47, 4, 197 }, 3783392, 3783394, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 20 },
             new byte[] { 92 }, 3783396, 3783396, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 110 },
             new byte[] { 190 }, 3783398, 3783398, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 150 },
             new byte[] { 236 }, 3783400, 3783400, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 190, 5, 255, 5, 79 },
             new byte[] { 26, 6, 99, 6, 188 }, 3783402, 3783406, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 159, 6, 8 },
             new byte[] { 22, 7, 139 }, 3783408, 3783410, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 108 },
             new byte[] { 251 }, 3783412, 3783412, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 108 },
             new byte[] { 255 }, 3783414, 3783414, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 108, 7 },
             new byte[] { 4, 8 }, 3783416, 3783417, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 86 },
             new byte[] { 142 }, 3783420, 3783420, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 246, 4, 120 },
             new byte[] { 57, 5, 197 }, 3783422, 3783424, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 220, 5, 64 },
             new byte[] { 50, 6, 160 }, 3783426, 3783428, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 99 },
             new byte[] { 201 }, 3783430, 3783430, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 139 },
             new byte[] { 248 }, 3783432, 3783432, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 149, 6, 33 },
             new byte[] { 7, 7, 161 }, 3783434, 3783436, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 138, 7, 188, 7, 188, 7, 188, 7 },
             new byte[] { 22, 8, 81, 8, 85, 8, 90, 8 }, 3783438, 3783445, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 146 },
             new byte[] { 205 }, 3783448, 3783448, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 20 },
             new byte[] { 88 }, 3783450, 3783450, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 165 },
             new byte[] { 244 }, 3783452, 3783452, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 44 },
             new byte[] { 135 }, 3783454, 3783454, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 114 },
             new byte[] { 213 }, 3783456, 3783456, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 194, 6, 23 },
             new byte[] { 46, 7, 141 }, 3783458, 3783460, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 43 },
             new byte[] { 167 }, 3783462, 3783462, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 143, 7, 218, 7, 17 },
             new byte[] { 22, 8, 108, 8, 172 }, 3783464, 3783468, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 32 },
             new byte[] { 193 }, 3783470, 3783470, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 32 },
             new byte[] { 198 }, 3783472, 3783472, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 226, 4, 80 },
             new byte[] { 33, 5, 151 }, 3783476, 3783478, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 245, 5, 74 },
             new byte[] { 73, 6, 167 }, 3783480, 3783482, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 194, 6, 58 },
             new byte[] { 42, 7, 174 }, 3783484, 3783486, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 128 },
             new byte[] { 253 }, 3783488, 3783488, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 158, 7, 17 },
             new byte[] { 34, 8, 162 }, 3783490, 3783492, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 62 },
             new byte[] { 215 }, 3783494, 3783494, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 102, 8, 102, 8, 102, 8 },
             new byte[] { 7, 9, 13, 9, 18, 9 }, 3783496, 3783501, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 0 },
             new byte[] { 64 }, 3783504, 3783504, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 140 },
             new byte[] { 215 }, 3783506, 3783506, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 240, 5, 144 },
             new byte[] { 68, 6, 241 }, 3783508, 3783510, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 28 },
             new byte[] { 137 }, 3783512, 3783512, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 148, 7, 198, 7, 218, 7, 42 },
             new byte[] { 13, 8, 71, 8, 98, 8, 188 }, 3783514, 3783520, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 52 },
             new byte[] { 204 }, 3783522, 3783522, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 72 },
             new byte[] { 231 }, 3783524, 3783524, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 72 },
             new byte[] { 236 }, 3783526, 3783526, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 72 },
             new byte[] { 242 }, 3783528, 3783528, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 50 },
             new byte[] { 117 }, 3783532, 3783532, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 175 },
             new byte[] { 251 }, 3783534, 3783534, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 14 },
             new byte[] { 99 }, 3783536, 3783536, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 204, 6, 108 },
             new byte[] { 48, 7, 222 }, 3783538, 3783540, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 198, 7, 253, 7, 12 },
             new byte[] { 66, 8, 130, 8, 151 }, 3783542, 3783546, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 32 },
             new byte[] { 178 }, 3783548, 3783548, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 32 },
             new byte[] { 183 }, 3783550, 3783550, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 32 },
             new byte[] { 188 }, 3783552, 3783552, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 32 },
             new byte[] { 193 }, 3783554, 3783554, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 32 },
             new byte[] { 198 }, 3783556, 3783556, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 120 },
             new byte[] { 190 }, 3783560, 3783560, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 205, 5, 54 },
             new byte[] { 27, 6, 141 }, 3783562, 3783564, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 8 },
             new byte[] { 112 }, 3783566, 3783566, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 168, 7, 2 },
             new byte[] { 30, 8, 130 }, 3783568, 3783570, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 2 },
             new byte[] { 135 }, 3783572, 3783572, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 7 },
             new byte[] { 146 }, 3783574, 3783574, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 7 },
             new byte[] { 151 }, 3783576, 3783576, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 7 },
             new byte[] { 156 }, 3783578, 3783578, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 7 },
             new byte[] { 161 }, 3783580, 3783580, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 7 },
             new byte[] { 166 }, 3783582, 3783582, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 7 },
             new byte[] { 171 }, 3783584, 3783584, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 145 },
             new byte[] { 216 }, 3783588, 3783588, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 230, 5, 134 },
             new byte[] { 53, 6, 226 }, 3783590, 3783592, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 48 },
             new byte[] { 154 }, 3783594, 3783594, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 253, 7, 52 },
             new byte[] { 120, 8, 183 }, 3783596, 3783598, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 52 },
             new byte[] { 189 }, 3783600, 3783600, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 12 },
             new byte[] { 151 }, 3783602, 3783602, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 2 },
             new byte[] { 146 }, 3783604, 3783604, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 2 },
             new byte[] { 151 }, 3783606, 3783606, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 238, 7, 238, 7, 238, 7 },
             new byte[] { 134, 8, 139, 8, 144, 8 }, 3783608, 3783613, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 160 },
             new byte[] { 232 }, 3783616, 3783616, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 24 },
             new byte[] { 106 }, 3783618, 3783618, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 184, 6, 108 },
             new byte[] { 23, 7, 217 }, 3783620, 3783622, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 178, 7, 238, 7, 238, 7, 238, 7, 238, 7, 238, 7, 188, 7, 188, 7, 188, 7 },
             new byte[] { 40, 8, 109, 8, 114, 8, 119, 8, 124, 8, 129, 8, 81, 8, 85, 8, 90, 8 }, 3783624, 3783641, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 170 },
             new byte[] { 243 }, 3783644, 3783644, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 64 },
             new byte[] { 148 }, 3783646, 3783646, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 214, 6, 98 },
             new byte[] { 54, 7, 207 }, 3783648, 3783650, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 118 },
             new byte[] { 233 }, 3783652, 3783652, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 123 },
             new byte[] { 243 }, 3783654, 3783654, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 123 },
             new byte[] { 247 }, 3783656, 3783656, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 123 },
             new byte[] { 252 }, 3783658, 3783658, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 123, 7, 178, 7, 188, 7, 188, 7, 188, 7 },
             new byte[] { 1, 8, 65, 8, 81, 8, 85, 8, 90, 8 }, 3783660, 3783669, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 190, 5, 84 },
             new byte[] { 8, 6, 169 }, 3783672, 3783674, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 234, 6, 118 },
             new byte[] { 75, 7, 228 }, 3783676, 3783678, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 138 },
             new byte[] { 254 }, 3783680, 3783680, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 143, 7, 143, 7, 143, 7, 28 },
             new byte[] { 8, 8, 13, 8, 18, 8, 155 }, 3783682, 3783688, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 28 },
             new byte[] { 160 }, 3783690, 3783690, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 28 },
             new byte[] { 165 }, 3783692, 3783692, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 28 },
             new byte[] { 169 }, 3783694, 3783694, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 28 },
             new byte[] { 174 }, 3783696, 3783696, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 207, 3, 36 },
             new byte[] { 0, 4, 92 }, 3783944, 3783946, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 176 },
             new byte[] { 242 }, 3783948, 3783948, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 70 },
             new byte[] { 148 }, 3783950, 3783950, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 130 },
             new byte[] { 215 }, 3783952, 3783952, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 190, 5, 240, 5, 19 },
             new byte[] { 26, 6, 83, 6, 124 }, 3783954, 3783958, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 19 },
             new byte[] { 128 }, 3783960, 3783960, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 19 },
             new byte[] { 132 }, 3783962, 3783962, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 24 },
             new byte[] { 141 }, 3783964, 3783964, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 250, 5, 250, 5 },
             new byte[] { 113, 6, 116, 6 }, 3783966, 3783969, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 212, 3, 81 },
             new byte[] { 5, 4, 139 }, 3783972, 3783974, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 206, 4, 70 },
             new byte[] { 18, 5, 148 }, 3783976, 3783978, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 195, 5, 64 },
             new byte[] { 28, 6, 164 }, 3783980, 3783982, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 189, 6, 8 },
             new byte[] { 45, 7, 130 }, 3783984, 3783986, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 43 },
             new byte[] { 171 }, 3783988, 3783988, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 53 },
             new byte[] { 187 }, 3783990, 3783990, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 108 },
             new byte[] { 251 }, 3783992, 3783992, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 108 },
             new byte[] { 255 }, 3783994, 3783994, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 108, 7 },
             new byte[] { 4, 8 }, 3783996, 3783997, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 6 },
             new byte[] { 58 }, 3784000, 3784000, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 136 },
             new byte[] { 197 }, 3784002, 3784002, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 30 },
             new byte[] { 102 }, 3784004, 3784004, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 110 },
             new byte[] { 190 }, 3784006, 3784006, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 14 },
             new byte[] { 107 }, 3784008, 3784008, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 149 },
             new byte[] { 254 }, 3784010, 3784010, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 78 },
             new byte[] { 200 }, 3784012, 3784012, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 108 },
             new byte[] { 236 }, 3784014, 3784014, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 133, 7, 158, 7, 188, 7, 188, 7, 188, 7 },
             new byte[] { 12, 8, 43, 8, 81, 8, 85, 8, 90, 8 }, 3784016, 3784025, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 56 },
             new byte[] { 110 }, 3784028, 3784028, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 176 },
             new byte[] { 239 }, 3784030, 3784030, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 55 },
             new byte[] { 128 }, 3784032, 3784032, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 180, 5, 84 },
             new byte[] { 8, 6, 181 }, 3784034, 3784036, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 244, 6, 143, 7, 173, 7, 238, 7, 248, 7, 17 },
             new byte[] { 99, 7, 13, 8, 50, 8, 124, 8, 140, 8, 172 }, 3784038, 3784048, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 32 },
             new byte[] { 193 }, 3784050, 3784050, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 32 },
             new byte[] { 198 }, 3784052, 3784052, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 86 },
             new byte[] { 142 }, 3784056, 3784056, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 221, 4, 150 },
             new byte[] { 30, 5, 229 }, 3784058, 3784060, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 240, 5, 194, 6, 108 },
             new byte[] { 71, 6, 42, 7, 227 }, 3784062, 3784066, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 233, 7, 72 },
             new byte[] { 109, 8, 215 }, 3784068, 3784070, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 152, 8, 152, 8, 152, 8, 152, 8, 152, 8 },
             new byte[] { 50, 9, 56, 9, 61, 9, 67, 9, 72, 9 }, 3784072, 3784081, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 86 },
             new byte[] { 142 }, 3784084, 3784084, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 236, 4, 150 },
             new byte[] { 46, 5, 229 }, 3784086, 3784088, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 250, 5, 204, 6, 123 },
             new byte[] { 82, 6, 52, 7, 243 }, 3784090, 3784094, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 12 },
             new byte[] { 146 }, 3784096, 3784096, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 117, 8, 152, 8, 152, 8, 152, 8, 152, 8, 152, 8 },
             new byte[] { 7, 9, 50, 9, 56, 9, 61, 9, 67, 9, 72, 9 }, 3784098, 3784109, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 86 },
             new byte[] { 142 }, 3784112, 3784112, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 0 },
             new byte[] { 67 }, 3784114, 3784114, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 150 },
             new byte[] { 229 }, 3784116, 3784116, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 4 },
             new byte[] { 93 }, 3784118, 3784118, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224, 6, 123 },
             new byte[] { 74, 7, 243 }, 3784120, 3784122, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 12 },
             new byte[] { 146 }, 3784124, 3784124, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 32 },
             new byte[] { 172 }, 3784126, 3784126, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 82 },
             new byte[] { 231 }, 3784128, 3784128, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 82 },
             new byte[] { 236 }, 3784130, 3784130, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 82 },
             new byte[] { 242 }, 3784132, 3784132, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 82 },
             new byte[] { 247 }, 3784134, 3784134, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 82 },
             new byte[] { 252 }, 3784136, 3784136, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 86 },
             new byte[] { 142 }, 3784140, 3784140, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 0 },
             new byte[] { 67 }, 3784142, 3784142, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 160 },
             new byte[] { 239 }, 3784144, 3784144, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 24 },
             new byte[] { 114 }, 3784146, 3784146, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 229, 6, 123 },
             new byte[] { 79, 7, 243 }, 3784148, 3784150, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 2 },
             new byte[] { 135 }, 3784152, 3784152, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 32 },
             new byte[] { 172 }, 3784154, 3784154, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 62 },
             new byte[] { 210 }, 3784156, 3784156, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 62 },
             new byte[] { 215 }, 3784158, 3784158, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 62 },
             new byte[] { 220 }, 3784160, 3784160, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 62 },
             new byte[] { 226 }, 3784162, 3784162, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 62 },
             new byte[] { 231 }, 3784164, 3784164, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 86 },
             new byte[] { 142 }, 3784168, 3784168, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 0 },
             new byte[] { 67 }, 3784170, 3784170, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 160 },
             new byte[] { 239 }, 3784172, 3784172, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 24 },
             new byte[] { 114 }, 3784174, 3784174, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 239, 6, 123 },
             new byte[] { 90, 7, 243 }, 3784176, 3784178, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 238, 7, 22 },
             new byte[] { 114, 8, 162 }, 3784180, 3784182, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 42 },
             new byte[] { 188 }, 3784184, 3784184, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 42 },
             new byte[] { 194 }, 3784186, 3784186, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 42 },
             new byte[] { 199 }, 3784188, 3784188, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 42 },
             new byte[] { 204 }, 3784190, 3784190, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 42 },
             new byte[] { 209 }, 3784192, 3784192, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 86 },
             new byte[] { 142 }, 3784196, 3784196, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 70 },
             new byte[] { 141 }, 3784198, 3784198, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 180, 5, 59 },
             new byte[] { 4, 6, 151 }, 3784200, 3784202, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 28 },
             new byte[] { 137 }, 3784204, 3784204, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 128 },
             new byte[] { 248 }, 3784206, 3784206, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 223, 7, 223, 7, 223, 7, 223, 7, 188, 7, 188, 7, 188, 7 },
             new byte[] { 98, 8, 103, 8, 108, 8, 113, 8, 81, 8, 85, 8, 90, 8 }, 3784208, 3784221, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 126 },
             new byte[] { 184 }, 3784224, 3784224, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 70 },
             new byte[] { 141 }, 3784226, 3784226, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 200, 5, 74 },
             new byte[] { 25, 6, 167 }, 3784228, 3784230, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 38 },
             new byte[] { 148 }, 3784232, 3784232, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 138, 7, 173, 7, 173, 7, 173, 7, 173, 7, 188, 7, 188, 7, 188, 7 },
             new byte[] { 3, 8, 45, 8, 50, 8, 55, 8, 59, 8, 81, 8, 85, 8, 90, 8 }, 3784234, 3784249, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 220, 5, 169, 6, 169, 6, 28 },
             new byte[] { 39, 6, 3, 7, 7, 7, 133 }, 3784252, 3784258, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 108 },
             new byte[] { 222 }, 3784260, 3784260, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 108 },
             new byte[] { 227 }, 3784262, 3784262, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 108 },
             new byte[] { 232 }, 3784264, 3784264, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 108 },
             new byte[] { 236 }, 3784266, 3784266, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 28 },
             new byte[] { 155 }, 3784268, 3784268, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 28 },
             new byte[] { 160 }, 3784270, 3784270, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 28 },
             new byte[] { 165 }, 3784272, 3784272, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 28 },
             new byte[] { 169 }, 3784274, 3784274, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 28 },
             new byte[] { 174 }, 3784276, 3784276, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 40 },
             new byte[] { 93 }, 3786384, 3786384, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 69 },
             new byte[] { 126 }, 3786386, 3786386, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 101 },
             new byte[] { 162 }, 3786388, 3786388, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 136 },
             new byte[] { 202 }, 3786390, 3786390, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 169 },
             new byte[] { 240 }, 3786392, 3786392, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 206, 4, 243, 4, 26 },
             new byte[] { 26, 5, 68, 5, 112 }, 3786394, 3786398, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 66 },
             new byte[] { 158 }, 3786400, 3786400, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 133 },
             new byte[] { 233 }, 3786402, 3786402, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 182, 5, 1 },
             new byte[] { 33, 6, 117 }, 3786404, 3786406, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 4 },
             new byte[] { 124 }, 3786408, 3786408, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 4 },
             new byte[] { 127 }, 3786410, 3786410, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 101 },
             new byte[] { 157 }, 3786416, 3786416, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 143 },
             new byte[] { 204 }, 3786418, 3786418, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 183 },
             new byte[] { 249 }, 3786420, 3786420, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 237, 4, 35 },
             new byte[] { 53, 5, 113 }, 3786422, 3786424, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 81 },
             new byte[] { 165 }, 3786426, 3786426, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 127 },
             new byte[] { 217 }, 3786428, 3786428, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 172, 5, 217, 5, 30 },
             new byte[] { 12, 6, 63, 6, 141 }, 3786430, 3786434, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 101 },
             new byte[] { 221 }, 3786436, 3786436, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 193, 6, 194, 6, 194, 6 },
             new byte[] { 67, 7, 72, 7, 76, 7 }, 3786438, 3786443, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 165 },
             new byte[] { 224 }, 3786448, 3786448, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 210, 4, 6 },
             new byte[] { 19, 5, 76 }, 3786450, 3786452, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 58 },
             new byte[] { 134 }, 3786454, 3786454, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 109 },
             new byte[] { 191 }, 3786456, 3786456, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 168, 5, 227, 5, 28 },
             new byte[] { 1, 6, 67, 6, 131 }, 3786458, 3786462, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 85 },
             new byte[] { 196 }, 3786464, 3786464, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 162, 6, 25 },
             new byte[] { 26, 7, 158 }, 3786466, 3786468, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 128, 7, 138, 7, 138, 7 },
             new byte[] { 17, 8, 32, 8, 36, 8 }, 3786470, 3786475, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 205, 4, 6 },
             new byte[] { 10, 5, 73 }, 3786480, 3786482, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 65 },
             new byte[] { 138 }, 3786484, 3786484, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 125 },
             new byte[] { 205 }, 3786486, 3786486, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 185, 5, 1 },
             new byte[] { 16, 6, 96 }, 3786488, 3786490, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 74 },
             new byte[] { 177 }, 3786492, 3786492, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 141 },
             new byte[] { 252 }, 3786494, 3786494, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 207, 6, 40 },
             new byte[] { 70, 7, 170 }, 3786496, 3786498, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 194, 7, 0 },
             new byte[] { 83, 8, 154 }, 3786500, 3786502, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 12 },
             new byte[] { 172 }, 3786504, 3786504, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 12 },
             new byte[] { 177 }, 3786506, 3786506, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 231, 4, 46 },
             new byte[] { 38, 5, 115 }, 3786512, 3786514, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 117 },
             new byte[] { 193 }, 3786516, 3786516, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 190, 5, 3 },
             new byte[] { 18, 6, 94 }, 3786518, 3786520, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 92 },
             new byte[] { 192 }, 3786522, 3786522, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 173, 6, 248, 6, 71 },
             new byte[] { 26, 7, 110, 7, 199 }, 3786524, 3786528, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 154, 7, 42 },
             new byte[] { 36, 8, 195 }, 3786530, 3786532, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 125, 8, 132, 8, 132, 8 },
             new byte[] { 33, 9, 45, 9, 50, 9 }, 3786534, 3786539, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 236, 4, 55 },
             new byte[] { 43, 5, 125 }, 3786544, 3786546, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 148 },
             new byte[] { 226 }, 3786548, 3786548, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 232, 5, 52 },
             new byte[] { 62, 6, 146 }, 3786550, 3786552, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 139 },
             new byte[] { 242 }, 3786554, 3786554, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 219, 6, 43 },
             new byte[] { 75, 7, 164 }, 3786556, 3786558, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 128, 7, 222, 7, 99, 8, 171, 8, 182, 8, 182, 8 },
             new byte[] { 3, 8, 109, 8, 0, 9, 82, 9, 99, 9, 104, 9 }, 3786560, 3786571, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 5 },
             new byte[] { 69 }, 3786576, 3786576, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 100 },
             new byte[] { 172 }, 3786578, 3786578, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 195, 5, 22 },
             new byte[] { 20, 6, 111 }, 3786580, 3786582, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 103 },
             new byte[] { 200 }, 3786584, 3786584, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 188, 6, 12 },
             new byte[] { 38, 7, 127 }, 3786586, 3786588, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 103 },
             new byte[] { 228 }, 3786590, 3786590, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 188, 7, 28 },
             new byte[] { 68, 8, 175 }, 3786592, 3786594, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 129, 8, 181, 8, 192, 8, 192, 8 },
             new byte[] { 32, 9, 93, 9, 110, 9, 115, 9 }, 3786596, 3786603, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 11 },
             new byte[] { 76 }, 3786608, 3786608, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 143 },
             new byte[] { 217 }, 3786610, 3786610, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 0 },
             new byte[] { 84 }, 3786612, 3786612, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 78 },
             new byte[] { 170 }, 3786614, 3786614, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 159, 6, 244, 6, 51 },
             new byte[] { 3, 7, 98, 7, 169 }, 3786616, 3786620, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 142, 7, 238, 7, 81 },
             new byte[] { 14, 8, 121, 8, 232 }, 3786622, 3786626, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 144, 8, 179, 8, 192, 8, 192, 8 },
             new byte[] { 48, 9, 91, 9, 110, 9, 115, 9 }, 3786628, 3786635, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 11 },
             new byte[] { 76 }, 3786640, 3786640, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 168 },
             new byte[] { 244 }, 3786642, 3786642, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16 },
             new byte[] { 101 }, 3786644, 3786644, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 78 },
             new byte[] { 170 }, 3786646, 3786646, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 159, 6, 244, 6, 51 },
             new byte[] { 3, 7, 98, 7, 169 }, 3786648, 3786652, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 142, 7, 238, 7, 81 },
             new byte[] { 14, 8, 121, 8, 232 }, 3786654, 3786658, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 144, 8, 179, 8, 192, 8, 192, 8 },
             new byte[] { 48, 9, 91, 9, 110, 9, 115, 9 }, 3786660, 3786667, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 11 },
             new byte[] { 76 }, 3786672, 3786672, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 168 },
             new byte[] { 244 }, 3786674, 3786674, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16 },
             new byte[] { 101 }, 3786676, 3786676, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 78 },
             new byte[] { 170 }, 3786678, 3786678, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 159, 6, 244, 6, 51 },
             new byte[] { 3, 7, 98, 7, 169 }, 3786680, 3786684, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 142, 7, 238, 7, 81 },
             new byte[] { 14, 8, 121, 8, 232 }, 3786686, 3786690, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 144, 8, 179, 8, 192, 8, 192, 8 },
             new byte[] { 48, 9, 91, 9, 110, 9, 115, 9 }, 3786692, 3786699, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 11 },
             new byte[] { 76 }, 3786704, 3786704, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 168 },
             new byte[] { 244 }, 3786706, 3786706, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16 },
             new byte[] { 101 }, 3786708, 3786708, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 78 },
             new byte[] { 170 }, 3786710, 3786710, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 159, 6, 244, 6, 51 },
             new byte[] { 3, 7, 98, 7, 169 }, 3786712, 3786716, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 142, 7, 238, 7, 81 },
             new byte[] { 14, 8, 121, 8, 232 }, 3786718, 3786722, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 144, 8, 179, 8, 192, 8, 192, 8 },
             new byte[] { 48, 9, 91, 9, 110, 9, 115, 9 }, 3786724, 3786731, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 11 },
             new byte[] { 76 }, 3786736, 3786736, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 168 },
             new byte[] { 244 }, 3786738, 3786738, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16 },
             new byte[] { 101 }, 3786740, 3786740, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 78 },
             new byte[] { 170 }, 3786742, 3786742, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 159, 6, 244, 6, 51 },
             new byte[] { 3, 7, 98, 7, 169 }, 3786744, 3786748, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 142, 7, 238, 7, 81 },
             new byte[] { 14, 8, 121, 8, 232 }, 3786750, 3786754, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 144, 8, 179, 8, 192, 8, 192, 8 },
             new byte[] { 48, 9, 91, 9, 110, 9, 115, 9 }, 3786756, 3786763, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 11 },
             new byte[] { 76 }, 3786768, 3786768, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 168 },
             new byte[] { 244 }, 3786770, 3786770, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16 },
             new byte[] { 101 }, 3786772, 3786772, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 78 },
             new byte[] { 170 }, 3786774, 3786774, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 159, 6, 244, 6, 51 },
             new byte[] { 3, 7, 98, 7, 169 }, 3786776, 3786780, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 142, 7, 238, 7, 81 },
             new byte[] { 14, 8, 121, 8, 232 }, 3786782, 3786786, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 144, 8, 179, 8, 192, 8, 192, 8 },
             new byte[] { 48, 9, 91, 9, 110, 9, 115, 9 }, 3786788, 3786795, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 241, 3, 255, 3, 48 },
             new byte[] { 35, 4, 53, 4, 107 }, 3786964, 3786968, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 66 },
             new byte[] { 128 }, 3786970, 3786970, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 81 },
             new byte[] { 146 }, 3786972, 3786972, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 122 },
             new byte[] { 193 }, 3786974, 3786974, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 167 },
             new byte[] { 243 }, 3786976, 3786976, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 223, 4, 44 },
             new byte[] { 49, 5, 135 }, 3786978, 3786980, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 129 },
             new byte[] { 229 }, 3786982, 3786982, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 3 },
             new byte[] { 115 }, 3786984, 3786984, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 147, 6, 204, 6, 252, 6 },
             new byte[] { 18, 7, 83, 7, 139, 7 }, 3786986, 3786991, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 8 },
             new byte[] { 60 }, 3786996, 3786996, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 49 },
             new byte[] { 105 }, 3786998, 3786998, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 59 },
             new byte[] { 118 }, 3787000, 3787000, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 100 },
             new byte[] { 164 }, 3787002, 3787002, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 139 },
             new byte[] { 208 }, 3787004, 3787004, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 192, 4, 39 },
             new byte[] { 11, 5, 123 }, 3787006, 3787008, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 81 },
             new byte[] { 171 }, 3787010, 3787010, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 150 },
             new byte[] { 248 }, 3787012, 3787012, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 202, 5, 98 },
             new byte[] { 51, 6, 217 }, 3787014, 3787016, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 15 },
             new byte[] { 151 }, 3787018, 3787018, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 113, 7, 200, 7 },
             new byte[] { 5, 8, 103, 8 }, 3787020, 3787023, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 29 },
             new byte[] { 82 }, 3787028, 3787028, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 72 },
             new byte[] { 129 }, 3787030, 3787030, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 96 },
             new byte[] { 157 }, 3787032, 3787032, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 149 },
             new byte[] { 216 }, 3787034, 3787034, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 193, 4, 251, 4, 69 },
             new byte[] { 9, 5, 73, 5, 155 }, 3787036, 3787040, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 180, 5, 240, 5, 34 },
             new byte[] { 21, 6, 88, 6, 145 }, 3787042, 3787046, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 214, 6, 75 },
             new byte[] { 86, 7, 216 }, 3787048, 3787050, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 4 },
             new byte[] { 163 }, 3787052, 3787052, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 90, 8 },
             new byte[] { 5, 9 }, 3787054, 3787055, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 58 },
             new byte[] { 112 }, 3787060, 3787060, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 105 },
             new byte[] { 164 }, 3787062, 3787062, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 154 },
             new byte[] { 218 }, 3787064, 3787064, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224, 4, 250, 4, 61 },
             new byte[] { 39, 5, 69, 5, 144 }, 3787066, 3787070, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 146 },
             new byte[] { 237 }, 3787072, 3787072, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 238, 5, 65 },
             new byte[] { 82, 6, 175 }, 3787074, 3787076, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 123 },
             new byte[] { 240 }, 3787078, 3787078, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 86 },
             new byte[] { 223 }, 3787080, 3787080, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 228, 7, 162, 8, 202, 8 },
             new byte[] { 124, 8, 78, 9, 126, 9 }, 3787082, 3787087, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 87 },
             new byte[] { 143 }, 3787092, 3787092, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 135 },
             new byte[] { 196 }, 3787094, 3787094, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 212, 4, 40 },
             new byte[] { 24, 5, 115 }, 3787096, 3787098, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 53 },
             new byte[] { 132 }, 3787100, 3787100, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 136 },
             new byte[] { 223 }, 3787102, 3787102, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 226, 5, 64 },
             new byte[] { 66, 6, 170 }, 3787104, 3787106, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 143, 6, 235, 6, 158, 7, 52 },
             new byte[] { 2, 7, 104, 7, 45, 8, 210 }, 3787108, 3787114, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 152, 8, 218, 8 },
             new byte[] { 67, 9, 143, 9 }, 3787116, 3787119, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 116 },
             new byte[] { 173 }, 3787124, 3787124, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 166 },
             new byte[] { 228 }, 3787126, 3787126, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 6 },
             new byte[] { 76 }, 3787128, 3787128, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 97 },
             new byte[] { 175 }, 3787130, 3787130, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 124 },
             new byte[] { 207 }, 3787132, 3787132, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 205, 5, 47 },
             new byte[] { 40, 6, 148 }, 3787134, 3787136, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 152, 6, 234, 6, 99 },
             new byte[] { 8, 7, 99, 7, 233 }, 3787138, 3787142, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 2 },
             new byte[] { 152 }, 3787144, 3787144, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 102, 8, 202, 8, 226, 8 },
             new byte[] { 8, 9, 121, 9, 152, 9 }, 3787146, 3787151, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 146 },
             new byte[] { 205 }, 3787156, 3787156, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 201, 4, 20 },
             new byte[] { 9, 5, 91 }, 3787158, 3787160, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 118 },
             new byte[] { 198 }, 3787162, 3787162, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 201, 5, 33 },
             new byte[] { 33, 6, 130 }, 3787164, 3787166, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 141 },
             new byte[] { 248 }, 3787168, 3787168, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 244, 6, 71 },
             new byte[] { 106, 7, 199 }, 3787170, 3787172, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 219, 7, 173, 8, 251, 8, 251, 8, 251, 8 },
             new byte[] { 105, 8, 79, 9, 168, 9, 174, 9, 179, 9 }, 3787174, 3787183, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 185 },
             new byte[] { 245 }, 3787188, 3787188, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 244, 4, 65 },
             new byte[] { 54, 5, 138 }, 3787190, 3787192, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 173, 5, 10 },
             new byte[] { 0, 6, 102 }, 3787194, 3787196, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 112 },
             new byte[] { 213 }, 3787198, 3787198, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 227, 6, 71 },
             new byte[] { 84, 7, 194 }, 3787200, 3787202, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 173, 7, 87 },
             new byte[] { 52, 8, 238 }, 3787204, 3787206, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 206, 8, 16 },
             new byte[] { 115, 9, 191 }, 3787208, 3787210, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16 },
             new byte[] { 196 }, 3787212, 3787212, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16 },
             new byte[] { 202 }, 3787214, 3787214, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 246, 4, 44 },
             new byte[] { 54, 5, 113 }, 3787220, 3787222, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 123 },
             new byte[] { 200 }, 3787224, 3787224, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 229, 5, 70 },
             new byte[] { 59, 6, 165 }, 3787226, 3787228, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 180, 6, 42 },
             new byte[] { 30, 7, 159 }, 3787230, 3787232, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 142, 7, 222, 7, 92 },
             new byte[] { 14, 8, 104, 8, 243 }, 3787234, 3787238, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 212, 8, 16 },
             new byte[] { 121, 9, 191 }, 3787240, 3787242, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16 },
             new byte[] { 196 }, 3787244, 3787244, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16 },
             new byte[] { 202 }, 3787246, 3787246, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 61 },
             new byte[] { 128 }, 3787252, 3787252, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 110 },
             new byte[] { 183 }, 3787254, 3787254, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 180, 5, 10 },
             new byte[] { 4, 6, 98 }, 3787256, 3787258, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 97 },
             new byte[] { 194 }, 3787260, 3787260, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 194, 6, 45 },
             new byte[] { 44, 7, 162 }, 3787262, 3787264, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 145, 7, 228, 7, 92 },
             new byte[] { 17, 8, 110, 8, 243 }, 3787266, 3787270, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 212, 8, 16 },
             new byte[] { 121, 9, 191 }, 3787272, 3787274, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16 },
             new byte[] { 196 }, 3787276, 3787276, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16 },
             new byte[] { 202 }, 3787278, 3787278, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 131 },
             new byte[] { 202 }, 3787284, 3787284, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 175 },
             new byte[] { 251 }, 3787286, 3787286, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 236, 5, 46 },
             new byte[] { 63, 6, 136 }, 3787288, 3787290, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 123 },
             new byte[] { 221 }, 3787292, 3787292, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 207, 6, 48 },
             new byte[] { 58, 7, 165 }, 3787294, 3787296, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 147, 7, 234, 7, 92 },
             new byte[] { 19, 8, 117, 8, 243 }, 3787298, 3787302, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 212, 8, 16 },
             new byte[] { 121, 9, 191 }, 3787304, 3787306, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16 },
             new byte[] { 196 }, 3787308, 3787308, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16 },
             new byte[] { 202 }, 3787310, 3787310, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 160 },
             new byte[] { 232 }, 3787316, 3787316, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 188, 5, 237, 5, 46 },
             new byte[] { 9, 6, 64, 6, 136 }, 3787318, 3787322, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 125 },
             new byte[] { 223 }, 3787324, 3787324, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 209, 6, 43 },
             new byte[] { 60, 7, 160 }, 3787326, 3787328, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 135, 7, 222, 7, 87 },
             new byte[] { 6, 8, 104, 8, 238 }, 3787330, 3787334, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 212, 8, 16 },
             new byte[] { 121, 9, 191 }, 3787336, 3787338, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16 },
             new byte[] { 196 }, 3787340, 3787340, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16 },
             new byte[] { 202 }, 3787342, 3787342, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 188, 5, 200, 5, 238, 5, 45 },
             new byte[] { 5, 6, 21, 6, 65, 6, 135 }, 3787348, 3787354, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 127 },
             new byte[] { 226 }, 3787356, 3787356, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 210, 6, 38 },
             new byte[] { 61, 7, 155 }, 3787358, 3787360, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 122 },
             new byte[] { 249 }, 3787362, 3787362, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 210, 7, 82 },
             new byte[] { 91, 8, 233 }, 3787364, 3787366, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 212, 8, 16 },
             new byte[] { 121, 9, 191 }, 3787368, 3787370, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16 },
             new byte[] { 196 }, 3787372, 3787372, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16 },
             new byte[] { 202 }, 3787374, 3787374, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 6 },
             new byte[] { 88 }, 3787452, 3787452, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 106 },
             new byte[] { 196 }, 3787454, 3787454, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 156 },
             new byte[] { 250 }, 3787456, 3787456, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 181, 4, 206, 4, 206, 4, 206, 4, 206, 4, 206, 4, 206, 4, 0 },
             new byte[] { 21, 5, 48, 5, 48, 5, 48, 5, 48, 5, 48, 5, 48, 5, 102 }, 3787458, 3787472, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 0 },
             new byte[] { 102 }, 3787474, 3787474, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 0 },
             new byte[] { 102 }, 3787476, 3787476, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 0 },
             new byte[] { 102 }, 3787478, 3787478, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 56 },
             new byte[] { 142 }, 3787480, 3787480, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 126 },
             new byte[] { 218 }, 3787482, 3787482, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 181, 4, 241, 4, 20 },
             new byte[] { 21, 5, 86, 5, 124 }, 3787484, 3787488, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 60 },
             new byte[] { 167 }, 3787490, 3787490, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 60 },
             new byte[] { 167 }, 3787492, 3787492, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 60 },
             new byte[] { 167 }, 3787494, 3787494, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 60 },
             new byte[] { 167 }, 3787496, 3787496, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 60 },
             new byte[] { 167 }, 3787498, 3787498, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 110 },
             new byte[] { 221 }, 3787500, 3787500, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 110 },
             new byte[] { 221 }, 3787502, 3787502, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 110 },
             new byte[] { 221 }, 3787504, 3787504, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 110 },
             new byte[] { 221 }, 3787506, 3787506, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 86 },
             new byte[] { 175 }, 3787508, 3787508, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 146 },
             new byte[] { 240 }, 3787510, 3787510, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 206, 4, 20 },
             new byte[] { 48, 5, 124 }, 3787512, 3787514, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 90 },
             new byte[] { 200 }, 3787516, 3787516, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 160, 5, 195, 5, 230, 5, 9 },
             new byte[] { 19, 6, 57, 6, 95, 6, 133 }, 3787518, 3787524, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 29 },
             new byte[] { 154 }, 3787526, 3787526, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 104 },
             new byte[] { 235 }, 3787528, 3787528, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 114 },
             new byte[] { 246 }, 3787530, 3787530, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 149, 6, 149, 6, 200, 5, 250, 5, 69 },
             new byte[] { 28, 7, 28, 7, 62, 6, 116, 6, 197 }, 3787532, 3787540, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 129, 6, 194, 6, 13 },
             new byte[] { 6, 7, 76, 7, 157 }, 3787542, 3787546, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 48 },
             new byte[] { 195 }, 3787548, 3787548, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 88 },
             new byte[] { 238 }, 3787550, 3787550, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 118, 7, 158, 7, 238, 7, 22 },
             new byte[] { 15, 8, 58, 8, 144, 8, 188 }, 3787552, 3787558, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 32 },
             new byte[] { 198 }, 3787560, 3787560, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 32 },
             new byte[] { 198 }, 3787562, 3787562, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 58 },
             new byte[] { 206 }, 3787564, 3787564, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 108, 7, 188, 7, 238, 7, 52 },
             new byte[] { 4, 8, 90, 8, 144, 8, 220 }, 3787566, 3787572, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 122, 8, 162, 8, 202, 8, 232, 8, 232, 8, 26 },
             new byte[] { 40, 9, 83, 9, 126, 9, 158, 9, 158, 9, 212 }, 3787574, 3787584, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 26 },
             new byte[] { 212 }, 3787586, 3787586, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 26 },
             new byte[] { 212 }, 3787588, 3787588, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 26 },
             new byte[] { 212 }, 3787590, 3787590, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 138, 7, 188, 7, 248, 7, 32 },
             new byte[] { 36, 8, 90, 8, 155, 8, 198 }, 3787592, 3787598, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 52 },
             new byte[] { 220 }, 3787600, 3787600, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 162, 8, 232, 8, 46 },
             new byte[] { 83, 9, 158, 9, 234 }, 3787602, 3787606, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 46 },
             new byte[] { 234 }, 3787608, 3787608, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 71, 9, 96, 9, 96, 9, 96, 9, 96, 9, 228, 7, 2 },
             new byte[] { 5, 10, 32, 10, 32, 10, 32, 10, 32, 10, 134, 8, 166 }, 3787610, 3787622, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 17 },
             new byte[] { 182 }, 3787624, 3787624, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 32 },
             new byte[] { 198 }, 3787626, 3787626, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 82 },
             new byte[] { 252 }, 3787628, 3787628, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 177, 8, 242, 8, 46 },
             new byte[] { 99, 9, 169, 9, 234 }, 3787630, 3787634, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 46 },
             new byte[] { 234 }, 3787636, 3787636, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 71, 9, 96, 9, 96, 9, 96, 9, 96, 9, 228, 7, 2 },
             new byte[] { 5, 10, 32, 10, 32, 10, 32, 10, 32, 10, 134, 8, 166 }, 3787638, 3787650, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 17 },
             new byte[] { 182 }, 3787652, 3787652, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 32 },
             new byte[] { 198 }, 3787654, 3787654, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 82 },
             new byte[] { 252 }, 3787656, 3787656, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 192, 8, 16 },
             new byte[] { 115, 9, 202 }, 3787658, 3787660, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 46 },
             new byte[] { 234 }, 3787662, 3787662, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 46 },
             new byte[] { 234 }, 3787664, 3787664, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 71, 9, 96, 9, 96, 9, 96, 9, 96, 9, 228, 7, 2 },
             new byte[] { 5, 10, 32, 10, 32, 10, 32, 10, 32, 10, 134, 8, 166 }, 3787666, 3787678, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 32 },
             new byte[] { 198 }, 3787680, 3787680, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 52 },
             new byte[] { 220 }, 3787682, 3787682, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 97, 8, 192, 8, 16 },
             new byte[] { 13, 9, 115, 9, 202 }, 3787684, 3787688, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 46 },
             new byte[] { 234 }, 3787690, 3787690, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 46 },
             new byte[] { 234 }, 3787692, 3787692, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 71, 9, 96, 9, 96, 9, 96, 9, 96, 9, 198, 7, 12 },
             new byte[] { 5, 10, 32, 10, 32, 10, 32, 10, 32, 10, 101, 8, 177 }, 3787694, 3787706, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 52 },
             new byte[] { 220 }, 3787708, 3787708, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 62 },
             new byte[] { 231 }, 3787710, 3787710, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 112, 8, 192, 8, 16 },
             new byte[] { 29, 9, 115, 9, 202 }, 3787712, 3787716, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 46 },
             new byte[] { 234 }, 3787718, 3787718, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 46 },
             new byte[] { 234 }, 3787720, 3787720, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 71, 9, 96, 9, 96, 9, 96, 9, 96, 9, 168, 7, 7 },
             new byte[] { 5, 10, 32, 10, 32, 10, 32, 10, 32, 10, 69, 8, 171 }, 3787722, 3787734, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 32 },
             new byte[] { 198 }, 3787736, 3787736, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 57 },
             new byte[] { 225 }, 3787738, 3787738, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 112, 8, 192, 8, 16 },
             new byte[] { 29, 9, 115, 9, 202 }, 3787740, 3787744, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 46 },
             new byte[] { 234 }, 3787746, 3787746, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 46 },
             new byte[] { 234 }, 3787748, 3787748, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 71, 9, 96, 9, 96, 9, 96, 9, 96, 9, 138, 7, 238, 7, 15 },
             new byte[] { 5, 10, 32, 10, 32, 10, 32, 10, 32, 10, 36, 8, 144, 8, 180 }, 3787750, 3787764, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 49 },
             new byte[] { 217 }, 3787766, 3787766, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 112, 8, 192, 8, 16 },
             new byte[] { 29, 9, 115, 9, 202 }, 3787768, 3787772, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 46 },
             new byte[] { 234 }, 3787774, 3787774, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 46 },
             new byte[] { 234 }, 3787776, 3787776, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 71, 9, 96, 9, 96, 9, 96, 9, 96, 9, 73 },
             new byte[] { 5, 10, 32, 10, 32, 10, 32, 10, 32, 10, 222 }, 3787778, 3787788, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 153, 7, 213, 7, 7 },
             new byte[] { 53, 8, 117, 8, 171 }, 3787790, 3787794, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 52 },
             new byte[] { 220 }, 3787796, 3787796, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 127, 8, 222, 8, 46 },
             new byte[] { 45, 9, 148, 9, 234 }, 3787798, 3787802, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 46 },
             new byte[] { 234 }, 3787804, 3787804, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 71, 9, 96, 9, 96, 9, 96, 9, 96, 9, 244, 6, 58 },
             new byte[] { 5, 10, 32, 10, 32, 10, 32, 10, 32, 10, 130, 7, 206 }, 3787806, 3787818, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 118, 7, 178, 7, 233, 7, 52 },
             new byte[] { 15, 8, 80, 8, 139, 8, 220 }, 3787820, 3787826, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 137, 8, 232, 8, 26 },
             new byte[] { 56, 9, 158, 9, 212 }, 3787828, 3787832, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 71, 9, 96, 9, 106, 9, 106, 9, 106, 9, 164, 6, 234, 6, 38 },
             new byte[] { 5, 10, 32, 10, 43, 10, 43, 10, 43, 10, 44, 7, 120, 7, 184 }, 3787834, 3787848, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 98 },
             new byte[] { 249 }, 3787850, 3787850, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 153, 7, 218, 7, 27 },
             new byte[] { 53, 8, 123, 8, 193 }, 3787852, 3787856, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 142, 8, 237, 8, 61 },
             new byte[] { 61, 9, 164, 9, 250 }, 3787858, 3787862, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 91, 9, 96, 9, 96, 9, 96, 9, 187, 5, 250, 5, 66 },
             new byte[] { 27, 10, 32, 10, 32, 10, 32, 10, 48, 6, 116, 6, 194 }, 3787864, 3787876, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 118 },
             new byte[] { 250 }, 3787878, 3787878, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 158, 6, 225, 6, 46 },
             new byte[] { 38, 7, 110, 7, 193 }, 3787880, 3787884, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 160, 7, 39 },
             new byte[] { 60, 8, 206 }, 3787886, 3787888, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 143, 8, 42 },
             new byte[] { 62, 9, 230 }, 3787890, 3787892, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 96, 9, 96, 9, 96, 9 },
             new byte[] { 32, 10, 32, 10, 32, 10 }, 3787894, 3787899, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 61 },
             new byte[] { 115 }, 3792474, 3792474, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 211, 4, 140 },
             new byte[] { 21, 5, 220 }, 3792476, 3792478, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 240, 5, 104 },
             new byte[] { 75, 6, 208 }, 3792480, 3792482, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224, 6, 50 },
             new byte[] { 85, 7, 179 }, 3792484, 3792486, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 168, 7, 168, 7, 168, 7 },
             new byte[] { 56, 8, 62, 8, 69, 8 }, 3792488, 3792493, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 126 },
             new byte[] { 184 }, 3792498, 3792498, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 15 },
             new byte[] { 84 }, 3792500, 3792500, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 44 },
             new byte[] { 134 }, 3792502, 3792502, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 139 },
             new byte[] { 240 }, 3792504, 3792504, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 244, 6, 103 },
             new byte[] { 101, 7, 229 }, 3792506, 3792508, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 158, 7, 168, 7, 168, 7, 168, 7 },
             new byte[] { 39, 8, 56, 8, 62, 8, 69, 8 }, 3792510, 3792517, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 136 },
             new byte[] { 194 }, 3792522, 3792522, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 55 },
             new byte[] { 126 }, 3792524, 3792524, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 84 },
             new byte[] { 176 }, 3792526, 3792526, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 10 },
             new byte[] { 118 }, 3792528, 3792528, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 73 },
             new byte[] { 191 }, 3792530, 3792530, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 253, 7, 102 },
             new byte[] { 133, 8, 253 }, 3792532, 3792534, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 102, 8, 102, 8, 102, 8 },
             new byte[] { 4, 9, 11, 9, 18, 9 }, 3792536, 3792541, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 162 },
             new byte[] { 221 }, 3792546, 3792546, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 127 },
             new byte[] { 202 }, 3792548, 3792548, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 114 },
             new byte[] { 208 }, 3792550, 3792550, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 108 },
             new byte[] { 222 }, 3792552, 3792552, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 218, 7, 12 },
             new byte[] { 89, 8, 149 }, 3792554, 3792556, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 63 },
             new byte[] { 211 }, 3792558, 3792558, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 102, 8, 102, 8, 102, 8 },
             new byte[] { 4, 9, 11, 9, 18, 9 }, 3792560, 3792565, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 236, 4, 190, 5, 184, 6, 193, 7, 37 },
             new byte[] { 43, 5, 12, 6, 25, 7, 56, 8, 169 }, 3792570, 3792578, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 52 },
             new byte[] { 192 }, 3792580, 3792580, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 62 },
             new byte[] { 210 }, 3792582, 3792582, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 112, 8, 112, 8, 112, 8 },
             new byte[] { 14, 9, 22, 9, 29, 9 }, 3792584, 3792589, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 246, 4, 220, 5, 244, 6, 208, 7, 42 },
             new byte[] { 54, 5, 44, 6, 89, 7, 72, 8, 174 }, 3792594, 3792602, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 52 },
             new byte[] { 192 }, 3792604, 3792604, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 72 },
             new byte[] { 220 }, 3792606, 3792606, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 92 },
             new byte[] { 249 }, 3792608, 3792608, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 92, 8, 92, 8 },
             new byte[] { 0, 9, 7, 9 }, 3792610, 3792613, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 251, 4, 220, 5, 234, 6, 190, 7, 208, 7, 12 },
             new byte[] { 59, 5, 44, 6, 78, 7, 53, 8, 79, 8, 149 }, 3792618, 3792628, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 22 },
             new byte[] { 167 }, 3792630, 3792630, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 52 },
             new byte[] { 206 }, 3792632, 3792632, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 52 },
             new byte[] { 213 }, 3792634, 3792634, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 52 },
             new byte[] { 220 }, 3792636, 3792636, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 0 },
             new byte[] { 64 }, 3792642, 3792642, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 220, 5, 224, 6, 138 },
             new byte[] { 44, 6, 68, 7, 254 }, 3792644, 3792648, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 183, 7, 208, 7, 248, 7, 248, 7, 248, 7, 248, 7 },
             new byte[] { 52, 8, 85, 8, 135, 8, 142, 8, 148, 8, 155, 8 }, 3792650, 3792661, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 61 },
             new byte[] { 115 }, 3792814, 3792814, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 211, 4, 140 },
             new byte[] { 21, 5, 220 }, 3792816, 3792818, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 240, 5, 104 },
             new byte[] { 75, 6, 208 }, 3792820, 3792822, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224, 6, 50 },
             new byte[] { 85, 7, 179 }, 3792824, 3792826, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 168, 7, 168, 7, 168, 7 },
             new byte[] { 56, 8, 62, 8, 69, 8 }, 3792828, 3792833, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 126 },
             new byte[] { 184 }, 3792838, 3792838, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 15 },
             new byte[] { 84 }, 3792840, 3792840, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 44 },
             new byte[] { 134 }, 3792842, 3792842, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 139 },
             new byte[] { 240 }, 3792844, 3792844, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 244, 6, 103 },
             new byte[] { 101, 7, 229 }, 3792846, 3792848, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 158, 7, 168, 7, 168, 7, 168, 7 },
             new byte[] { 39, 8, 56, 8, 62, 8, 69, 8 }, 3792850, 3792857, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 136 },
             new byte[] { 194 }, 3792862, 3792862, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 55 },
             new byte[] { 126 }, 3792864, 3792864, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 84 },
             new byte[] { 176 }, 3792866, 3792866, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 10 },
             new byte[] { 118 }, 3792868, 3792868, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 73 },
             new byte[] { 191 }, 3792870, 3792870, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 253, 7, 102 },
             new byte[] { 133, 8, 253 }, 3792872, 3792874, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 102, 8, 102, 8, 102, 8 },
             new byte[] { 4, 9, 11, 9, 18, 9 }, 3792876, 3792881, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 162 },
             new byte[] { 221 }, 3792886, 3792886, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 127 },
             new byte[] { 202 }, 3792888, 3792888, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 114 },
             new byte[] { 208 }, 3792890, 3792890, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 108 },
             new byte[] { 222 }, 3792892, 3792892, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 218, 7, 12 },
             new byte[] { 89, 8, 149 }, 3792894, 3792896, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 63 },
             new byte[] { 211 }, 3792898, 3792898, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 102, 8, 102, 8, 102, 8 },
             new byte[] { 4, 9, 11, 9, 18, 9 }, 3792900, 3792905, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 236, 4, 190, 5, 184, 6, 193, 7, 37 },
             new byte[] { 43, 5, 12, 6, 25, 7, 56, 8, 169 }, 3792910, 3792918, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 52 },
             new byte[] { 192 }, 3792920, 3792920, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 62 },
             new byte[] { 210 }, 3792922, 3792922, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 112, 8, 112, 8, 112, 8 },
             new byte[] { 14, 9, 22, 9, 29, 9 }, 3792924, 3792929, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 246, 4, 220, 5, 244, 6, 208, 7, 42 },
             new byte[] { 54, 5, 44, 6, 89, 7, 72, 8, 174 }, 3792934, 3792942, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 52 },
             new byte[] { 192 }, 3792944, 3792944, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 72 },
             new byte[] { 220 }, 3792946, 3792946, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 92 },
             new byte[] { 249 }, 3792948, 3792948, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 92, 8, 92, 8 },
             new byte[] { 0, 9, 7, 9 }, 3792950, 3792953, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 251, 4, 220, 5, 234, 6, 190, 7, 208, 7, 12 },
             new byte[] { 59, 5, 44, 6, 78, 7, 53, 8, 79, 8, 149 }, 3792958, 3792968, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 22 },
             new byte[] { 167 }, 3792970, 3792970, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 52 },
             new byte[] { 206 }, 3792972, 3792972, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 52 },
             new byte[] { 213 }, 3792974, 3792974, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 52 },
             new byte[] { 220 }, 3792976, 3792976, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 0 },
             new byte[] { 64 }, 3792982, 3792982, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 220, 5, 224, 6, 138 },
             new byte[] { 44, 6, 68, 7, 254 }, 3792984, 3792988, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 183, 7, 208, 7, 248, 7, 248, 7, 248, 7, 248, 7 },
             new byte[] { 52, 8, 85, 8, 135, 8, 142, 8, 148, 8, 155, 8 }, 3792990, 3793001, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 61 },
             new byte[] { 115 }, 3794844, 3794844, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 140 },
             new byte[] { 218 }, 3794846, 3794846, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 104 },
             new byte[] { 202 }, 3794848, 3794848, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 168, 7, 168, 7, 168, 7, 168, 7 },
             new byte[] { 39, 8, 49, 8, 59, 8, 69, 8 }, 3794850, 3794857, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 136 },
             new byte[] { 194 }, 3794860, 3794860, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 84 },
             new byte[] { 173 }, 3794862, 3794862, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 73 },
             new byte[] { 185 }, 3794864, 3794864, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 102 },
             new byte[] { 242 }, 3794866, 3794866, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 102 },
             new byte[] { 253 }, 3794868, 3794868, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 102, 8, 102, 8 },
             new byte[] { 7, 9, 18, 9 }, 3794870, 3794873, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 246, 4, 244, 6, 42 },
             new byte[] { 54, 5, 86, 7, 167 }, 3794876, 3794880, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 92 },
             new byte[] { 231 }, 3794882, 3794882, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 92 },
             new byte[] { 242 }, 3794884, 3794884, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 92 },
             new byte[] { 253 }, 3794886, 3794886, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 92, 8 },
             new byte[] { 7, 9 }, 3794888, 3794889, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 0 },
             new byte[] { 64 }, 3794892, 3794892, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224, 6, 183, 7, 248, 7, 248, 7, 248, 7, 248, 7 },
             new byte[] { 65, 7, 46, 8, 125, 8, 135, 8, 145, 8, 155, 8 }, 3794894, 3794905, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 0 },
             new byte[] { 64 }, 3794908, 3794908, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224, 6, 183, 7, 248, 7, 248, 7, 248, 7, 248, 7 },
             new byte[] { 65, 7, 46, 8, 125, 8, 135, 8, 145, 8, 155, 8 }, 3794910, 3794921, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 0 },
             new byte[] { 64 }, 3794924, 3794924, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224, 6, 183, 7, 248, 7, 248, 7, 248, 7, 248, 7 },
             new byte[] { 65, 7, 46, 8, 125, 8, 135, 8, 145, 8, 155, 8 }, 3794926, 3794937, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 96, 34, 16 },
             new byte[] { 16, 35, 216 }, 3900294, 3900296, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 104, 41, 204, 41, 98, 42, 248, 42, 248, 42, 248, 42 },
             new byte[] { 60, 42, 162, 42, 59, 43, 212, 43, 212, 43, 212, 43 }, 3900298, 3900309, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 18 },
             new byte[] { 208 }, 3900326, 3900326, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 160, 40, 236, 44, 130, 45, 24, 46, 74, 46, 124, 46, 224, 46 },
             new byte[] { 112, 41, 210, 45, 107, 46, 4, 47, 55, 47, 106, 47, 208, 47 }, 3900328, 3900341, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 116, 39, 172, 43, 164, 46, 158, 47, 226, 49, 240, 50, 44, 51, 44, 51 },
             new byte[] { 62, 40, 140, 44, 147, 47, 146, 48, 225, 50, 245, 51, 50, 52, 50, 52 }, 3900358, 3900373, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 220, 40, 80, 45, 12, 48, 252, 48, 84, 51, 72, 53, 60, 55, 60, 55 },
             new byte[] { 173, 41, 56, 46, 2, 49, 247, 49, 91, 52, 89, 54, 87, 56, 87, 56 }, 3900390, 3900405, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 254, 41, 14 },
             new byte[] { 213, 42, 250 }, 3900422, 3900424, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 252, 48, 110, 50, 188, 52, 10, 55, 164, 56, 164, 56 },
             new byte[] { 247, 49, 112, 51, 202, 53, 36, 56, 198, 57, 198, 57 }, 3900426, 3900437, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 94, 46, 70, 50, 162, 53, 134, 56, 6, 59, 200, 60, 98, 62, 128, 62 },
             new byte[] { 75, 47, 71, 51, 181, 54, 167, 57, 52, 60, 255, 61, 161, 63, 192, 63 }, 3900454, 3900469, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 78, 52, 234, 56, 110, 60, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62 },
             new byte[] { 90, 53, 13, 58, 163, 61, 192, 63, 192, 63, 192, 63, 192, 63, 192, 63 }, 3900486, 3900501, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 162, 58, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62 },
             new byte[] { 206, 59, 192, 63, 192, 63, 192, 63, 192, 63, 192, 63, 192, 63, 192, 63 }, 3900518, 3900533, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16, 59, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62 },
             new byte[] { 62, 60, 192, 63, 192, 63, 192, 63, 192, 63, 192, 63, 192, 63, 192, 63 }, 3900550, 3900565, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 200, 50, 200, 50, 200, 50, 200, 50, 200, 50, 200, 50, 200, 50, 200, 50 },
             new byte[] { 204, 51, 204, 51, 204, 51, 204, 51, 204, 51, 204, 51, 204, 51, 204, 51 }, 3900582, 3900597, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 64 },
             new byte[] { 224 }, 3900614, 3900614, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 64 },
             new byte[] { 224 }, 3900616, 3900616, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 64 },
             new byte[] { 224 }, 3900618, 3900618, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 64 },
             new byte[] { 224 }, 3900620, 3900620, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 64 },
             new byte[] { 224 }, 3900622, 3900622, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 64 },
             new byte[] { 224 }, 3900624, 3900624, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 64 },
             new byte[] { 224 }, 3900626, 3900626, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 64 },
             new byte[] { 224 }, 3900628, 3900628, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 172 },
             new byte[] { 242 }, 3900646, 3900646, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 172 },
             new byte[] { 242 }, 3900648, 3900648, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 172 },
             new byte[] { 242 }, 3900650, 3900650, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 172 },
             new byte[] { 242 }, 3900652, 3900652, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 172 },
             new byte[] { 242 }, 3900654, 3900654, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 172 },
             new byte[] { 242 }, 3900656, 3900656, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 172 },
             new byte[] { 242 }, 3900658, 3900658, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 172 },
             new byte[] { 242 }, 3900660, 3900660, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 96, 34, 32 },
             new byte[] { 16, 35, 217 }, 3909802, 3909804, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 104, 41, 204, 41, 98, 42, 248, 42, 248, 42, 248, 42 },
             new byte[] { 60, 42, 162, 42, 59, 43, 212, 43, 212, 43, 212, 43 }, 3909806, 3909817, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 17 },
             new byte[] { 207 }, 3909834, 3909834, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 159, 40, 236, 44, 130, 45, 24, 46, 74, 46, 124, 46, 224, 46 },
             new byte[] { 111, 41, 210, 45, 107, 46, 4, 47, 55, 47, 106, 47, 208, 47 }, 3909836, 3909849, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 116, 39, 172, 43, 164, 46, 158, 47, 226, 49, 243, 50, 44, 51, 44, 51 },
             new byte[] { 62, 40, 140, 44, 147, 47, 146, 48, 225, 50, 248, 51, 50, 52, 50, 52 }, 3909866, 3909881, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 220, 40, 80, 45, 12, 48, 252, 48, 84, 51, 72, 53, 60, 55, 60, 55 },
             new byte[] { 173, 41, 56, 46, 2, 49, 247, 49, 91, 52, 89, 54, 87, 56, 87, 56 }, 3909898, 3909913, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 254, 41, 14 },
             new byte[] { 213, 42, 250 }, 3909930, 3909932, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 252, 48, 110, 50, 188, 52, 10, 55, 164, 56, 164, 56 },
             new byte[] { 247, 49, 112, 51, 202, 53, 36, 56, 198, 57, 198, 57 }, 3909934, 3909945, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 94, 46, 70, 50, 162, 53, 134, 56, 6, 59, 200, 60, 98, 62, 128, 62 },
             new byte[] { 75, 47, 71, 51, 181, 54, 167, 57, 52, 60, 255, 61, 161, 63, 192, 63 }, 3909962, 3909977, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 78, 52, 234, 56, 110, 60, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62 },
             new byte[] { 90, 53, 13, 58, 163, 61, 192, 63, 192, 63, 192, 63, 192, 63, 192, 63 }, 3909994, 3910009, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 162, 58, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62 },
             new byte[] { 206, 59, 192, 63, 192, 63, 192, 63, 192, 63, 192, 63, 192, 63, 192, 63 }, 3910026, 3910041, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16, 59, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62 },
             new byte[] { 62, 60, 192, 63, 192, 63, 192, 63, 192, 63, 192, 63, 192, 63, 192, 63 }, 3910058, 3910073, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 248, 57, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62 },
             new byte[] { 33, 59, 192, 63, 192, 63, 192, 63, 192, 63, 192, 63, 192, 63, 192, 63 }, 3910090, 3910105, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 64 },
             new byte[] { 224 }, 3910122, 3910122, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 64 },
             new byte[] { 224 }, 3910124, 3910124, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 64 },
             new byte[] { 224 }, 3910126, 3910126, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 64 },
             new byte[] { 224 }, 3910128, 3910128, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 64 },
             new byte[] { 224 }, 3910130, 3910130, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 64 },
             new byte[] { 224 }, 3910132, 3910132, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 64 },
             new byte[] { 224 }, 3910134, 3910134, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 64 },
             new byte[] { 224 }, 3910136, 3910136, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 61 },
             new byte[] { 236 }, 3910342, 3910342, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 228, 37, 254, 41, 254, 41, 248, 42, 248, 42, 248, 42, 248, 42 },
             new byte[] { 166, 38, 213, 42, 213, 42, 212, 43, 212, 43, 212, 43, 212, 43 }, 3910344, 3910357, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 163, 37, 236, 39, 48, 42, 6 },
             new byte[] { 100, 38, 184, 40, 8, 43, 231 }, 3910374, 3910380, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 130, 45, 224, 46, 224, 46, 224, 46 },
             new byte[] { 107, 46, 208, 47, 208, 47, 208, 47 }, 3910382, 3910389, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 104, 41, 138, 42, 231, 44, 94, 46, 56, 49, 194, 51, 194, 51, 194, 51 },
             new byte[] { 60, 42, 100, 43, 205, 45, 75, 47, 52, 50, 203, 52, 203, 52, 203, 52 }, 3910406, 3910421, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 36, 44, 176, 44, 63, 47, 202, 48, 72, 53, 60, 55, 60, 55, 60, 55 },
             new byte[] { 6, 45, 149, 45, 49, 48, 196, 49, 89, 54, 87, 56, 87, 56, 87, 56 }, 3910438, 3910453, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 170, 45, 8 },
             new byte[] { 148, 46, 249 }, 3910470, 3910472, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 50, 144, 51, 10, 55, 164, 56, 164, 56, 164, 56 },
             new byte[] { 51, 152, 52, 36, 56, 198, 57, 198, 57, 198, 57 }, 3910475, 3910485, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 221, 51, 162, 53, 134, 56, 6, 59, 200, 60, 98, 62, 128, 62, 128, 62 },
             new byte[] { 231, 52, 181, 54, 167, 57, 52, 60, 255, 61, 161, 63, 192, 63, 192, 63 }, 3910502, 3910517, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 234, 56, 110, 60, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62 },
             new byte[] { 13, 58, 163, 61, 192, 63, 192, 63, 192, 63, 192, 63, 192, 63, 192, 63 }, 3910534, 3910549, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62 },
             new byte[] { 192, 63, 192, 63, 192, 63, 192, 63, 192, 63, 192, 63, 192, 63, 192, 63 }, 3910566, 3910581, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 61 },
             new byte[] { 236 }, 3910922, 3910922, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 254, 36, 60, 40, 254, 41, 248, 42, 248, 42, 248, 42, 248, 42 },
             new byte[] { 187, 37, 10, 41, 213, 42, 212, 43, 212, 43, 212, 43, 212, 43 }, 3910924, 3910937, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 128, 37, 236, 39, 48, 42, 6 },
             new byte[] { 64, 38, 184, 40, 8, 43, 231 }, 3910954, 3910960, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 130, 45, 224, 46, 224, 46, 224, 46 },
             new byte[] { 107, 46, 208, 47, 208, 47, 208, 47 }, 3910962, 3910969, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 4 },
             new byte[] { 214 }, 3910986, 3910986, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 138, 42, 231, 44, 94, 46, 56, 49, 194, 51, 194, 51, 194, 51 },
             new byte[] { 100, 43, 205, 45, 75, 47, 52, 50, 203, 52, 203, 52, 203, 52 }, 3910988, 3911001, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 92, 43, 176, 44, 63, 47, 202, 48, 72, 53, 60, 55, 60, 55, 60, 55 },
             new byte[] { 58, 44, 149, 45, 49, 48, 196, 49, 89, 54, 87, 56, 87, 56, 87, 56 }, 3911018, 3911033, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 236, 44, 18, 47 },
             new byte[] { 210, 45, 3, 48 }, 3911050, 3911053, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 50, 144, 51, 10, 55, 164, 56, 164, 56, 164, 56 },
             new byte[] { 51, 152, 52, 36, 56, 198, 57, 198, 57, 198, 57 }, 3911055, 3911065, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 221, 51, 162, 53, 134, 56, 6, 59, 200, 60, 98, 62, 128, 62, 128, 62 },
             new byte[] { 231, 52, 181, 54, 167, 57, 52, 60, 255, 61, 161, 63, 192, 63, 192, 63 }, 3911082, 3911097, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 234, 56, 110, 60, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62 },
             new byte[] { 13, 58, 163, 61, 192, 63, 192, 63, 192, 63, 192, 63, 192, 63, 192, 63 }, 3911114, 3911129, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62 },
             new byte[] { 192, 63, 192, 63, 192, 63, 192, 63, 192, 63, 192, 63, 192, 63, 192, 63 }, 3911146, 3911161, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 128, 62, 128, 62, 128, 62, 128, 62 },
             new byte[] { 192, 63, 192, 63, 192, 63, 192, 63 }, 3917452, 3917459, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62 },
             new byte[] { 116, 64, 116, 64, 116, 64, 116, 64, 116, 64, 116, 64, 116, 64, 116, 64, 116, 64, 116, 64, 116, 64, 116, 64, 116, 64, 116, 64, 116, 64, 116, 64, 116, 64, 116, 64, 116, 64, 116, 64, 116, 64, 116, 64, 116, 64, 116, 64, 116, 64, 116, 64, 116, 64, 116, 64, 116, 64, 116, 64, 116, 64, 116, 64, 116, 64, 116, 64, 116, 64, 116, 64, 116, 64, 116, 64, 116, 64, 116, 64, 116, 64, 116, 64, 116, 64, 116, 64, 116, 64, 116, 64, 116, 64, 116, 64, 116, 64, 116, 64, 116, 64, 116, 64, 116, 64, 116, 64, 116, 64, 116, 64, 116, 64, 116, 64, 116, 64, 116, 64, 116, 64, 116, 64, 116, 64, 116, 64, 116, 64, 116, 64, 116, 64, 116, 64, 116, 64, 116, 64 }, 3917464, 3917603, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 184, 61, 184, 61, 184, 61, 184, 61, 184, 61, 184, 61, 184 },
             new byte[] { 192, 63, 192, 63, 192, 63, 192, 63, 192, 63, 192, 63, 192, 63, 192, 63, 192, 63, 192, 63, 192, 63, 192, 63, 244, 62, 244, 62, 244, 62, 244, 62, 244, 62, 244, 62, 244 }, 3920892, 3920928, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 184 },
             new byte[] { 244 }, 3920930, 3920930, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 184 },
             new byte[] { 244 }, 3920932, 3920932, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 184 },
             new byte[] { 244 }, 3920934, 3920934, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 184 },
             new byte[] { 244 }, 3920936, 3920936, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 184 },
             new byte[] { 244 }, 3920938, 3920938, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 128, 62, 128, 62, 184, 61, 184 },
             new byte[] { 192, 63, 192, 63, 244, 62, 244 }, 3923926, 3923932, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 184, 11, 184, 11, 184, 11, 184, 11, 184, 11, 184, 11, 184, 11 },
             new byte[] { 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17 }, 3924610, 3924623, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15 },
             new byte[] { 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17 }, 3924626, 3924639, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 20, 15, 72, 13, 28, 12, 34, 11, 246, 9, 252, 8 },
             new byte[] { 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17 }, 3924644, 3924655, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 154, 16, 166, 14, 228, 12, 184, 11, 90, 10, 46, 9, 208, 7 },
             new byte[] { 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17 }, 3924658, 3924671, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 104, 16, 66, 14, 128, 12, 240, 10, 96, 9, 208, 7, 14, 6 },
             new byte[] { 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17 }, 3924674, 3924687, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 54, 16, 172, 13, 84, 11, 146, 9, 208, 7, 14, 6, 76, 4 },
             new byte[] { 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17 }, 3924690, 3924703, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 160, 15, 178, 12, 196, 9, 2, 8, 14, 6, 126, 4, 238, 2 },
             new byte[] { 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17 }, 3924706, 3924719, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 172, 13, 34, 11, 52, 8, 64, 6, 226, 4, 132, 3, 38, 2 },
             new byte[] { 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17 }, 3924722, 3924735, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 240, 10, 252, 8, 164, 6, 176, 4, 132, 3, 88, 2, 250, 0 },
             new byte[] { 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17 }, 3924738, 3924751, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 96, 9, 208, 7, 170, 5, 132, 3, 88, 2, 44, 1, 0, 0 },
             new byte[] { 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17 }, 3924754, 3924767, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 160, 15, 160, 15, 160, 15, 160, 15, 160, 15 },
             new byte[] { 48, 17, 48, 17, 48, 17, 48, 17, 48, 17 }, 3924814, 3924823, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 28 },
             new byte[] { 48 }, 3924830, 3924830, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 160, 15, 252, 8, 64, 6, 232, 3 },
             new byte[] { 48, 17, 48, 17, 48, 17, 48, 17 }, 3924832, 3924839, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 170, 15, 228, 12, 8, 7, 176, 4, 244, 1 },
             new byte[] { 48, 17, 48, 17, 48, 17, 48, 17, 48, 17 }, 3924846, 3924855, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 90, 15, 28, 12, 20, 5, 188, 2, 150, 0 },
             new byte[] { 48, 17, 48, 17, 48, 17, 48, 17, 48, 17 }, 3924862, 3924871, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 38 },
             new byte[] { 48 }, 3924876, 3924876, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 246, 14, 34, 11, 188, 2, 200, 0, 50, 0 },
             new byte[] { 48, 17, 48, 17, 48, 17, 48, 17, 48, 17 }, 3924878, 3924887, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 234, 16, 10, 15, 36, 14, 246, 9, 219, 1, 125, 0, 25, 0 },
             new byte[] { 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17 }, 3924890, 3924903, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 114, 16, 116, 14, 72, 13, 202, 8, 250, 0, 50, 0, 0, 0 },
             new byte[] { 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17 }, 3924906, 3924919, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 130, 15, 12, 13, 204, 11, 10, 5, 90, 0, 10, 0, 0, 0 },
             new byte[] { 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17 }, 3924922, 3924935, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 106, 14, 168, 12, 86, 9, 148, 2, 20, 0, 0, 0, 0, 0, 136, 14, 56, 14, 184, 11, 58, 7, 64, 1, 0, 0, 0, 0, 0, 0 },
             new byte[] { 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17, 48, 17 }, 3924938, 3924967, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62, 128, 62 },
             new byte[] { 192, 63, 192, 63, 192, 63, 192, 63, 192, 63, 192, 63, 192, 63, 192, 63, 192, 63, 192, 63, 192, 63, 192, 63, 192, 63, 192, 63, 192, 63, 192, 63 }, 3925004, 3925035, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 184, 11, 184, 11, 184, 11, 40, 10, 128, 12, 128, 12, 128, 12, 40, 10, 128, 12, 128, 12, 128, 12, 40, 10, 128, 12, 128, 12, 128, 12, 40, 10, 128, 12, 128, 12, 128, 12, 40, 10, 108, 12, 108, 12, 108, 12, 40, 10, 254, 11, 234, 11, 254, 11, 191, 9, 134, 11, 64, 11, 134, 11, 81, 9, 14, 11, 150, 10, 14, 11, 212, 8, 170, 10, 236, 9, 170, 10, 102, 8, 40, 10, 86, 9, 40, 10, 238, 7, 212, 8, 32, 8, 212, 8, 250, 5, 128, 7, 128, 7, 128, 7, 36 },
             new byte[] { 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 174, 11, 189, 10, 174, 11, 31, 9, 39, 10, 88, 9, 39, 10, 224, 6, 160, 8, 160, 8, 160, 8, 195 }, 3926040, 3926142, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 220, 5, 220, 5, 220, 5, 8 },
             new byte[] { 189, 6, 189, 6, 189, 6, 86 }, 3926144, 3926150, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 252, 3, 252, 3, 252, 3 },
             new byte[] { 149, 4, 149, 4, 149, 4 }, 3926152, 3926157, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 234, 1, 234, 1, 234, 1 },
             new byte[] { 52, 2, 52, 2, 52, 2 }, 3926160, 3926165, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 232, 3, 18, 7, 18, 7, 88, 12 },
             new byte[] { 160, 15, 160, 15, 160, 15, 160, 15 }, 3979762, 3979769, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 28, 12, 28, 12, 28, 12, 28, 12 },
             new byte[] { 172, 13, 172, 13, 172, 13, 172, 13 }, 3979780, 3979787, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 28, 12, 28, 12, 28, 12, 28, 12 },
             new byte[] { 172, 13, 172, 13, 172, 13, 172, 13 }, 3979814, 3979821, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 172, 13, 172, 13, 172, 13, 172, 13, 172, 13, 172, 13, 172, 13, 172, 13 },
             new byte[] { 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15 }, 3979856, 3979871, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 82, 8, 0, 0 },
             new byte[] { 160, 15, 160, 15 }, 3979886, 3979889, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 82, 8, 0, 0 },
             new byte[] { 160, 15, 160, 15 }, 3979920, 3979923, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 82, 8, 0, 0 },
             new byte[] { 160, 15, 160, 15 }, 3979954, 3979957, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 82, 8, 0, 0 },
             new byte[] { 160, 15, 160, 15 }, 3979988, 3979991, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 82, 8, 0, 0 },
             new byte[] { 160, 15, 160, 15 }, 3980022, 3980025, "Found dpf map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 172, 13, 172, 13, 172, 13, 172, 13, 172, 13, 172, 13, 172, 13, 172, 13 },
             new byte[] { 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15, 160, 15 }, 3980060, 3980075, "Found dpf map...Delete map");
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