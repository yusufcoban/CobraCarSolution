using ToolBoxNameSpace;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace CobraCarSolution.TreeElements.VAG
{
    class nissan_SID301 : MenuItem, ITreeItem
    {
        public nissan_SID301()
        {
            Title = "SID301";
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
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 124, 250, 104, 194 }, 263172);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 159 }, 288208);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 145 }, 288210);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 132 }, 288212);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 118 }, 288214);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 106 }, 288216);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 103 }, 288218);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 101 }, 288220);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 100 }, 288222);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 208 }, 288244);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 190 }, 288246);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 175 }, 288248);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 160 }, 288250);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 146 }, 288252);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 141 }, 288254);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 137 }, 288256);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 135 }, 288258);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 4 }, 288280);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 241, 1, 226 }, 288282);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 210 }, 288286);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 195 }, 288288);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 189 }, 288290);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 182 }, 288292);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 179 }, 288294);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 57 }, 288316);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 34 }, 288318);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16 }, 288320);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 253, 1, 236, 1, 229 }, 288322);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 222 }, 288328);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 220 }, 288330);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 141 }, 288352);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 106 }, 288354);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 77 }, 288356);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 51 }, 288358);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 31 }, 288360);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 20 }, 288362);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 6 }, 288364);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 1 }, 288366);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 253, 2, 208 }, 288388);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 172 }, 288392);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 139 }, 288394);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 110 }, 288396);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 93 }, 288398);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 74 }, 288400);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 65 }, 288402);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 146 }, 288424);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 85 }, 288426);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 34 }, 288428);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 245, 2, 208 }, 288430);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 182 }, 288434);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 157 }, 288436);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 145 }, 288438);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 62 }, 288460);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 246, 3, 182 }, 288462);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 124 }, 288466);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 75 }, 288468);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 39 }, 288470);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 3 }, 288472);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 243, 2 }, 288474);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 206 }, 288496);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 133 }, 288498);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 69 }, 288500);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 8 }, 288502);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 209, 3, 164 }, 288504);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 117 }, 288508);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 95 }, 288510);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 96 }, 288532);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 1 }, 288534);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 190 }, 288536);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 128 }, 288538);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 72 }, 288540);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 26 }, 288542);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 233, 3, 209, 3 }, 288544);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 115 }, 288568);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 11 }, 288570);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 190, 5, 121 }, 288572);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 56 }, 288576);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 2 }, 288578);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 206, 4, 180, 4 }, 288580);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 147 }, 288604);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 20 }, 288606);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 183, 6, 100 }, 288608);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 26 }, 288612);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 222, 5, 166, 5, 135 }, 288614);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 206, 8, 55 }, 288640);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 199, 7, 100 }, 288644);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 10 }, 288648);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 191, 6, 123 }, 288650);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 87 }, 288654);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 61 }, 288676);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 145, 10, 10 }, 288678);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 142, 9, 28 }, 288682);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 185, 8, 87 }, 288686);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 29 }, 288690);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 152, 14, 183, 13, 8 }, 288712);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 109, 12, 229, 11, 110, 11, 245, 10, 149, 10 }, 288718);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 159 }, 289072);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 145 }, 289074);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 132 }, 289076);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 118 }, 289078);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 106 }, 289080);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 103 }, 289082);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 101 }, 289084);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 100 }, 289086);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 208 }, 289108);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 190 }, 289110);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 175 }, 289112);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 160 }, 289114);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 146 }, 289116);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 141 }, 289118);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 137 }, 289120);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 135 }, 289122);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 4 }, 289144);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 241, 1, 226 }, 289146);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 210 }, 289150);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 195 }, 289152);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 189 }, 289154);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 182 }, 289156);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 179 }, 289158);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 57 }, 289180);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 34 }, 289182);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16 }, 289184);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 253, 1, 236, 1, 229 }, 289186);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 222 }, 289192);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 220 }, 289194);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 141 }, 289216);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 106 }, 289218);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 77 }, 289220);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 51 }, 289222);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 31 }, 289224);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 20 }, 289226);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 6 }, 289228);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 1 }, 289230);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 253, 2, 208 }, 289252);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 172 }, 289256);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 139 }, 289258);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 110 }, 289260);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 93 }, 289262);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 74 }, 289264);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 65 }, 289266);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 146 }, 289288);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 85 }, 289290);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 34 }, 289292);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 245, 2, 208 }, 289294);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 182 }, 289298);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 157 }, 289300);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 145 }, 289302);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 62 }, 289324);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 246, 3, 182 }, 289326);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 124 }, 289330);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 75 }, 289332);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 39 }, 289334);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 3 }, 289336);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 243, 2 }, 289338);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 206 }, 289360);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 133 }, 289362);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 69 }, 289364);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 8 }, 289366);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 209, 3, 164 }, 289368);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 117 }, 289372);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 95 }, 289374);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 96 }, 289396);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 1 }, 289398);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 190 }, 289400);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 128 }, 289402);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 72 }, 289404);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 26 }, 289406);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 233, 3, 209, 3 }, 289408);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 115 }, 289432);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 11 }, 289434);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 190, 5, 121 }, 289436);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 56 }, 289440);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 2 }, 289442);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 206, 4, 180, 4 }, 289444);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 147 }, 289468);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 20 }, 289470);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 183, 6, 100 }, 289472);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 26 }, 289476);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 222, 5, 166, 5, 135 }, 289478);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 206, 8, 55 }, 289504);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 199, 7, 100 }, 289508);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 10 }, 289512);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 191, 6, 123 }, 289514);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 87 }, 289518);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 61 }, 289540);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 145, 10, 10 }, 289542);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 142, 9, 28 }, 289546);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 185, 8, 87 }, 289550);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 29 }, 289554);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 152, 14, 183, 13, 8 }, 289576);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 109, 12, 229, 11, 110, 11, 245, 10, 149, 10 }, 289582);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 159 }, 289936);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 145 }, 289938);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 132 }, 289940);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 118 }, 289942);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 106 }, 289944);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 103 }, 289946);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 101 }, 289948);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 100 }, 289950);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 208 }, 289972);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 190 }, 289974);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 175 }, 289976);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 160 }, 289978);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 146 }, 289980);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 141 }, 289982);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 137 }, 289984);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 135 }, 289986);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 4 }, 290008);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 241, 1, 226 }, 290010);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 210 }, 290014);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 195 }, 290016);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 189 }, 290018);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 182 }, 290020);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 179 }, 290022);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 57 }, 290044);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 34 }, 290046);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16 }, 290048);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 253, 1, 236, 1, 229 }, 290050);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 222 }, 290056);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 220 }, 290058);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 141 }, 290080);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 106 }, 290082);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 77 }, 290084);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 51 }, 290086);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 31 }, 290088);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 20 }, 290090);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 6 }, 290092);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 1 }, 290094);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 253, 2, 208 }, 290116);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 172 }, 290120);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 139 }, 290122);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 110 }, 290124);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 93 }, 290126);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 74 }, 290128);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 65 }, 290130);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 146 }, 290152);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 85 }, 290154);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 34 }, 290156);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 245, 2, 208 }, 290158);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 182 }, 290162);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 157 }, 290164);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 145 }, 290166);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 62 }, 290188);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 246, 3, 182 }, 290190);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 124 }, 290194);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 75 }, 290196);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 39 }, 290198);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 3 }, 290200);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 243, 2 }, 290202);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 206 }, 290224);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 133 }, 290226);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 69 }, 290228);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 8 }, 290230);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 209, 3, 164 }, 290232);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 117 }, 290236);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 95 }, 290238);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 96 }, 290260);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 1 }, 290262);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 190 }, 290264);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 128 }, 290266);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 72 }, 290268);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 26 }, 290270);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 233, 3, 209, 3 }, 290272);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 115 }, 290296);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 11 }, 290298);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 190, 5, 121 }, 290300);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 56 }, 290304);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 2 }, 290306);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 206, 4, 180, 4 }, 290308);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 147 }, 290332);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 20 }, 290334);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 183, 6, 100 }, 290336);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 26 }, 290340);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 222, 5, 166, 5, 135 }, 290342);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 206, 8, 55 }, 290368);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 199, 7, 100 }, 290372);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 10 }, 290376);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 191, 6, 123 }, 290378);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 87 }, 290382);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 61 }, 290404);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 145, 10, 10 }, 290406);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 142, 9, 28 }, 290410);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 185, 8, 87 }, 290414);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 29 }, 290418);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 152, 14, 183, 13, 8 }, 290440);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 109, 12, 229, 11, 110, 11, 245, 10, 149, 10 }, 290446);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 159 }, 290800);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 145 }, 290802);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 132 }, 290804);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 118 }, 290806);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 106 }, 290808);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 103 }, 290810);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 101 }, 290812);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 100 }, 290814);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 208 }, 290836);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 190 }, 290838);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 175 }, 290840);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 160 }, 290842);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 146 }, 290844);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 141 }, 290846);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 137 }, 290848);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 135 }, 290850);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 4 }, 290872);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 241, 1, 226 }, 290874);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 210 }, 290878);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 195 }, 290880);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 189 }, 290882);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 182 }, 290884);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 179 }, 290886);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 57 }, 290908);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 34 }, 290910);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16 }, 290912);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 253, 1, 236, 1, 229 }, 290914);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 222 }, 290920);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 220 }, 290922);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 141 }, 290944);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 106 }, 290946);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 77 }, 290948);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 51 }, 290950);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 31 }, 290952);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 20 }, 290954);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 6 }, 290956);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 1 }, 290958);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 253, 2, 208 }, 290980);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 172 }, 290984);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 139 }, 290986);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 110 }, 290988);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 93 }, 290990);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 74 }, 290992);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 65 }, 290994);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 146 }, 291016);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 85 }, 291018);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 34 }, 291020);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 245, 2, 208 }, 291022);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 182 }, 291026);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 157 }, 291028);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 145 }, 291030);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 62 }, 291052);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 246, 3, 182 }, 291054);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 124 }, 291058);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 75 }, 291060);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 39 }, 291062);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 3 }, 291064);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 243, 2 }, 291066);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 206 }, 291088);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 133 }, 291090);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 69 }, 291092);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 8 }, 291094);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 209, 3, 164 }, 291096);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 117 }, 291100);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 95 }, 291102);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 96 }, 291124);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 1 }, 291126);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 190 }, 291128);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 128 }, 291130);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 72 }, 291132);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 26 }, 291134);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 233, 3, 209, 3 }, 291136);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 115 }, 291160);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 11 }, 291162);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 190, 5, 121 }, 291164);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 56 }, 291168);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 2 }, 291170);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 206, 4, 180, 4 }, 291172);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 147 }, 291196);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 20 }, 291198);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 183, 6, 100 }, 291200);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 26 }, 291204);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 222, 5, 166, 5, 135 }, 291206);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 206, 8, 55 }, 291232);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 199, 7, 100 }, 291236);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 10 }, 291240);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 191, 6, 123 }, 291242);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 87 }, 291246);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 61 }, 291268);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 145, 10, 10 }, 291270);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 142, 9, 28 }, 291274);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 185, 8, 87 }, 291278);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 29 }, 291282);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 152, 14, 183, 13, 8 }, 291304);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 109, 12, 229, 11, 110, 11, 245, 10, 149, 10 }, 291310);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 126 }, 303832);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 126 }, 303834);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 141 }, 303836);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 141 }, 303838);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 141 }, 303840);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 141 }, 303842);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 176 }, 303844);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 176 }, 303846);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 176 }, 303848);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 176 }, 303850);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 58 }, 303852);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 58 }, 303854);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 73 }, 303856);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 73 }, 303858);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 73 }, 303860);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 73 }, 303862);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 108 }, 303864);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 108 }, 303866);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 108 }, 303868);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 108 }, 303870);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 77 }, 303872);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 132, 8, 202, 8, 202, 8, 202, 8, 202, 8, 202, 8, 202, 8, 202, 8, 202, 8, 102 }, 303874);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 192, 8, 254, 8, 46 }, 303894);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 46 }, 303900);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 46 }, 303902);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 46 }, 303904);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 46 }, 303906);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 46 }, 303908);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 46 }, 303910);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 92 }, 303912);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 185, 8, 252, 8, 69 }, 303914);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 101 }, 303920);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 126, 9, 126, 9, 126, 9, 126, 9, 166, 9, 92 }, 303922);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 165, 8, 227, 8, 56 }, 303934);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 106 }, 303940);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 146, 9, 196, 9, 196, 9, 196, 9, 246, 9, 65 }, 303942);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 142, 8, 212, 8, 36 }, 303954);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 78 }, 303960);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 119, 9, 191, 9, 246, 9, 246, 9, 246, 9, 42 }, 303962);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 117 }, 303974);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 192, 8, 6 }, 303976);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 52 }, 303980);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 86 }, 303982);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 156, 9, 229, 9, 27 }, 303984);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 40 }, 303990);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 2 }, 303992);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 62 }, 303994);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 139, 8, 211, 8, 255, 8, 28 }, 303996);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 96 }, 304004);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 181, 9, 10 }, 304006);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 40 }, 304010);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 208, 7, 22 }, 304012);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 97 }, 304016);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 159, 8, 197, 8, 229, 8, 36 }, 304018);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 121, 9, 223, 9, 40 }, 304026);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 173, 7, 246, 7, 47 }, 304032);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 105 }, 304038);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 147, 8, 172, 8, 242, 8, 66 }, 304040);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 166, 9, 90 }, 304048);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 120 }, 304052);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 193, 7, 12 }, 304054);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 69 }, 304058);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 96 }, 304060);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 130, 8, 202, 8, 21 }, 304062);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 106 }, 304068);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 90 }, 304070);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 68 }, 304072);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 158, 7, 228, 7, 15 }, 304074);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 55 }, 304080);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 97 }, 304082);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 167, 8, 232, 8, 66 }, 304084);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 226, 9, 38 }, 304090);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 120 }, 304094);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 188, 7, 222, 7, 15 }, 304096);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 55 }, 304102);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 112 }, 304104);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 190, 8, 13 }, 304106);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 196, 9, 8 }, 304110);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 83 }, 304114);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 133 }, 304116);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 173, 7, 215, 7, 251, 7, 59 }, 304118);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 125 }, 304126);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 190, 8, 59 }, 304128);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 217, 6, 23 }, 304132);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 78 }, 304136);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 125 }, 304138);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 163, 7, 193, 7, 251, 7, 45 }, 304140);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 92 }, 304148);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 164, 8 }, 304150);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 246, 9, 246, 9 }, 304976);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 246, 9, 246, 9 }, 304996);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 10, 10, 0, 10, 222, 8, 162, 8, 51, 9 }, 305010);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 51 }, 305826);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 76 }, 305828);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 156 }, 305830);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 14 }, 305832);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 113 }, 305834);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 244, 5, 132 }, 305836);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 22 }, 305840);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 208, 7, 119 }, 305842);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 202, 8, 227, 8, 227, 8 }, 305846);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 66 }, 305858);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 96 }, 305860);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 197, 4, 65 }, 305862);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 186, 5, 82 }, 305866);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 241, 6, 216, 7, 144 }, 305870);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 9 }, 305876);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 66 }, 305878);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 66 }, 305880);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 66 }, 305882);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 101 }, 305890);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 146 }, 305892);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 246, 4, 115 }, 305894);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 250, 5, 168 }, 305898);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 93 }, 305902);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 54 }, 305904);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224, 8, 94 }, 305906);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 146, 9, 146, 9, 146, 9 }, 305910);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 146 }, 305922);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 166 }, 305924);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 28 }, 305926);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 170 }, 305928);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 77 }, 305930);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 12 }, 305932);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 208, 7, 124 }, 305934);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 44 }, 305938);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 162, 9, 179, 9, 196, 9, 196, 9 }, 305940);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 176 }, 305954);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 225, 4, 55 }, 305956);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 215, 5, 130 }, 305960);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 86 }, 305964);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16 }, 305966);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 192, 8, 106 }, 305968);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 216, 9, 10 }, 305972);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 10 }, 305976);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 10 }, 305978);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 176 }, 305986);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 26 }, 305988);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 185, 5, 121 }, 305990);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 214, 6, 118 }, 305994);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 79 }, 305998);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 26 }, 306000);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 221, 9, 55 }, 306002);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 60 }, 306006);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 60 }, 306008);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 60 }, 306010);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 176 }, 306018);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 49 }, 306020);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 203, 5, 139 }, 306022);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 49 }, 306026);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 146 }, 306028);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 97 }, 306030);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 108 }, 306032);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 15 }, 306034);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 50 }, 306036);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 50 }, 306038);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 50 }, 306040);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 50 }, 306042);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 234, 4, 103 }, 306050);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 31 }, 306054);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 189, 6, 95 }, 306056);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 141 }, 306060);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 111 }, 306062);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 106 }, 306064);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 40 }, 306066);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 40 }, 306068);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 40 }, 306070);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 40 }, 306072);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 40 }, 306074);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 53 }, 306082);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 168 }, 306084);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 77 }, 306086);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 196, 6, 119 }, 306088);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 34 }, 306092);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 46 }, 306094);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 126 }, 306096);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 40 }, 306098);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 40 }, 306100);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 40 }, 306102);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 40 }, 306104);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 40 }, 306106);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 103 }, 306114);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 218, 5, 77 }, 306116);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 196, 6, 119 }, 306120);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 34 }, 306124);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 66 }, 306126);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 156, 9, 196, 9, 40 }, 306128);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 40 }, 306134);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 40 }, 306136);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 40 }, 306138);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 104 }, 306146);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 216, 5, 82 }, 306148);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 202, 6, 121 }, 306152);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 33 }, 306156);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 96 }, 306158);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 96 }, 306160);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 96 }, 306162);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 96 }, 306164);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 96 }, 306166);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 96 }, 306168);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 96 }, 306170);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 25 }, 306888);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 75 }, 306890);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 75 }, 306892);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 75 }, 306894);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 75 }, 306896);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 75 }, 306898);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 5 }, 306900);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 191, 9, 94 }, 306902);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 199, 8, 25 }, 306906);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 75 }, 306910);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 75 }, 306912);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 75 }, 306914);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 75 }, 306916);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 75 }, 306918);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 5 }, 306920);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 191, 9, 94 }, 306922);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 199, 8, 25 }, 306926);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 75 }, 306930);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 75 }, 306932);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 75 }, 306934);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 75 }, 306936);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 75 }, 306938);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 5 }, 306940);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 191, 9, 94 }, 306942);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 199, 8, 25 }, 306946);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 75 }, 306950);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 75 }, 306952);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 75 }, 306954);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 75 }, 306956);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 75 }, 306958);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 5 }, 306960);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 191, 9, 94 }, 306962);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 199, 8, 25 }, 306966);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 75 }, 306970);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 75 }, 306972);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 75 }, 306974);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 75 }, 306976);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 75 }, 306978);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 5 }, 306980);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 191, 9, 94 }, 306982);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 199, 8, 5 }, 306986);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 40 }, 306990);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 40 }, 306992);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 15 }, 306994);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 5 }, 306996);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 10 }, 306998);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 196, 9, 106 }, 307000);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 46 }, 307004);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 152, 8, 244, 9, 37 }, 307006);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 38 }, 307012);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 196, 9, 193, 8, 164, 8, 56 }, 307014);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 252, 8, 142, 8, 52 }, 307022);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 244, 9, 37 }, 307028);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 38 }, 307032);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 196, 9, 193, 8, 164, 8, 56 }, 307034);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 252, 8, 142, 8, 52 }, 307042);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 244, 9, 37 }, 307048);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 38 }, 307052);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 196, 9, 193, 8, 164, 8, 56 }, 307054);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 252, 8, 142, 8, 52 }, 307062);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 244, 9, 37 }, 307068);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 38 }, 307072);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 196, 9, 193, 8, 164, 8, 56 }, 307074);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 252, 8, 142, 8, 52 }, 307082);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 56 }, 307894);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 84 }, 307896);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 149 }, 307898);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 214, 4, 90 }, 307900);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 180 }, 307904);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 84 }, 307906);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 244, 6, 108 }, 307908);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 42 }, 307912);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 252, 8, 101 }, 307914);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 101 }, 307918);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 84 }, 307926);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 135 }, 307928);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 199, 4, 48 }, 307930);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 229, 5, 54 }, 307934);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 234, 6, 188, 7, 2 }, 307938);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 122 }, 307944);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 76 }, 307946);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 231, 9, 231, 9 }, 307948);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 162 }, 307958);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 251, 4, 78 }, 307960);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 232, 5, 119 }, 307964);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 155 }, 307968);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 31 }, 307970);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 158, 7, 20 }, 307972);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 195, 8, 122 }, 307976);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 40 }, 307980);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 40 }, 307982);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 251, 4, 147 }, 307990);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 245, 5, 144 }, 307994);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 9 }, 307998);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 103 }, 308000);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 176, 7, 24 }, 308002);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 152, 8, 36 }, 308006);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 200, 9, 70 }, 308010);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 70 }, 308014);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 64 }, 308022);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 232, 5, 152 }, 308024);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 34 }, 308028);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 139 }, 308030);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 29 }, 308032);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 120 }, 308034);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 205, 8, 36 }, 308036);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 144, 9, 50 }, 308040);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 54 }, 308044);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 54 }, 308046);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 6 }, 308054);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 173 }, 308056);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 95 }, 308058);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 238, 6, 1 }, 308060);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 217, 8, 240, 8, 32 }, 308064);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 106 }, 308070);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 211, 9, 58 }, 308072);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 65 }, 308076);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 65 }, 308078);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 196, 4, 70 }, 308086);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 243, 5, 132 }, 308090);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 32 }, 308094);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 4 }, 308096);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 160, 8, 26 }, 308098);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 97 }, 308102);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 2 }, 308104);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 70 }, 308106);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 70 }, 308108);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 70 }, 308110);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 201, 4, 45 }, 308118);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 223, 5, 114 }, 308122);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 17 }, 308126);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 194, 7, 87 }, 308128);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 1 }, 308132);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 92 }, 308134);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 60 }, 308136);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 120 }, 308138);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 120 }, 308140);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 120 }, 308142);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 216, 4, 40 }, 308150);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 206, 5, 106 }, 308154);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 243, 6, 159, 7, 60 }, 308158);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 235, 8, 57 }, 308164);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 60 }, 308168);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 120 }, 308170);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 120 }, 308172);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 120 }, 308174);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 196, 4, 246, 4, 168 }, 308182);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 67 }, 308188);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 218, 6, 115 }, 308190);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 20 }, 308194);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 197, 8, 28 }, 308196);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 30 }, 308200);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 30 }, 308202);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 30 }, 308204);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 30 }, 308206);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 140 }, 308214);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 244, 4, 144 }, 308216);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 49 }, 308220);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 202, 6, 71 }, 308222);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 243, 7, 145 }, 308226);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 145 }, 308230);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 145 }, 308232);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 145 }, 308234);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 145 }, 308236);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 145 }, 308238);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 58, 8, 154, 8, 250, 8, 97, 9, 200, 9, 64, 9, 183, 8, 169, 8, 57, 9, 222, 8, 210, 8, 172, 9, 134, 10, 207, 10, 24, 11, 124, 10, 223, 9, 125, 10, 68, 10, 90, 10, 229, 8, 222, 9, 214, 10, 42, 11, 76, 11, 0, 11, 130, 10, 243, 10, 120, 10, 177, 10, 212, 8, 218, 9, 223, 10, 18, 11, 69, 11, 244, 10, 163, 10, 37, 11, 163, 10, 130, 10, 148, 8, 203, 9, 1, 11, 43, 11, 84, 11, 3, 11, 178, 10, 74, 11, 213, 10, 190, 10, 123, 8, 198, 9, 16, 11, 54, 11, 92, 11, 23, 11, 209, 10, 137, 11, 42, 11, 14, 11, 133, 8, 216, 9, 42, 11, 76, 11, 110, 11, 77, 11, 44, 11, 207, 11, 149, 11, 154, 11, 140, 8, 223, 9, 49, 11, 104, 11, 159, 11, 145, 11, 130, 11, 28, 12, 3, 12, 28, 12, 158, 8, 216, 9, 17, 11, 95, 11, 172, 11, 173, 11, 174, 11, 81, 12, 86, 12, 138, 12, 181, 8, 200, 9, 219, 10, 71, 11, 179, 11, 192, 11, 204, 11, 108, 12, 151, 12, 208, 12, 212, 8, 204, 9, 195, 10, 72, 11, 204, 11, 213, 11, 222, 11, 141, 12, 178, 12, 2, 13, 52, 9, 0, 10, 204, 10, 75, 11, 201, 11, 205, 11, 209, 11, 113, 12, 160, 12, 228, 12, 186, 9, 67, 10, 203, 10, 67, 11, 187, 11, 185, 11, 182, 11, 63, 12, 141, 12, 208, 12, 58, 10, 139, 10, 219, 10, 39, 11, 115, 11, 99, 11, 82, 11, 251, 11, 11, 12, 31, 12 }, 310008);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 0, 11, 160, 16, 128, 17, 32, 18, 192, 20, 224, 20, 64, 20, 96, 19, 16, 23, 160, 25, 224, 21 }, 311378);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 20, 96, 19, 160, 15, 160, 11, 192, 12, 32, 19, 192, 24, 160, 25, 64, 26, 224, 28, 0, 29, 96, 28, 128, 27, 128, 27, 224, 26, 32, 23, 160, 20 }, 311401);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 20, 64, 16, 64, 12 }, 311435);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 52, 8, 102, 8, 152, 8, 111, 8, 70, 8, 10, 8, 206, 7, 176, 7, 32, 8, 32, 8, 89, 9, 23, 10, 212, 10, 135, 10, 57, 10, 23, 10, 244, 9, 94, 9, 126, 9, 126, 9, 171, 9, 109, 10, 46, 11, 47, 11, 47, 11, 244, 10, 185, 10, 75, 10, 90, 10, 20, 10, 179, 9, 125, 10, 71, 11, 109, 11, 146, 11, 90, 11, 34, 11, 215, 10, 203, 10, 167, 10, 174, 9, 127, 10, 79, 11, 127, 11, 174, 11, 149, 11, 124, 11, 44, 11, 84, 11, 71, 11, 168, 9, 120, 10, 72, 11, 122, 11, 171, 11, 180, 11, 189, 11, 162, 11, 174, 11, 134, 11, 184, 9, 129, 10, 74, 11, 131, 11, 187, 11, 205, 11, 222, 11 }, 312308);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 12, 33, 12, 18, 12, 248, 9, 156, 10, 64, 11, 123, 11, 181, 11, 239, 11, 41, 12, 128, 12, 125, 12, 153, 12, 103, 10, 217, 10, 74, 11, 114, 11, 154, 11, 9, 12, 120, 12, 161, 12, 178, 12, 248, 12, 175, 10, 240, 10, 49, 11, 81, 11, 112, 11, 245, 11, 121, 12, 161, 12, 208, 12, 97, 13, 195, 10, 244, 10, 36, 11, 59, 11, 81, 11, 227, 11, 116, 12, 128, 12, 196, 12, 142, 13, 137, 10, 204, 10, 14, 11, 39, 11, 64, 11, 217, 11, 113, 12, 128, 12, 192, 12, 102, 13, 3, 10, 125, 10, 247, 10, 28, 11, 64, 11, 183, 11, 46, 12, 53, 12, 118, 12, 248, 12, 49, 8, 131, 8, 212, 8, 31, 9, 106, 9, 195, 9, 27, 10, 103, 10, 183, 10, 34, 11 }, 312443);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 0, 11, 64, 16, 32, 21, 224, 21, 0, 22, 32, 22, 128, 21, 192, 20, 208, 23, 160, 25, 64, 25 }, 313678);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 24, 0, 22, 192, 20, 160, 11, 192, 12, 32, 19, 192, 24, 224, 29, 0, 30, 32, 30, 64, 30, 160, 29, 224, 28, 64, 28, 128, 27, 128, 26, 224, 25, 224, 23, 0, 22, 64, 12 }, 313701);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 82 }, 387662);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 102 }, 387664);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 112 }, 387666);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 132 }, 387668);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 132 }, 387670);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 132 }, 387672);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 132 }, 387674);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 6 }, 387694);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 46 }, 387696);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 66 }, 387698);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 182 }, 387700);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 112 }, 387702);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 112 }, 387704);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 86 }, 387706);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16 }, 387726);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 76 }, 387728);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 106 }, 387730);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 116 }, 387732);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 136 }, 387734);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 136 }, 387736);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 176 }, 387738);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 26 }, 387758);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 126 }, 387760);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 206 }, 387762);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 20 }, 387764);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 20 }, 387766);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 20 }, 387768);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 20 }, 387770);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 36 }, 387790);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 146 }, 387792);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 246, 4, 40 }, 387794);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 90 }, 387798);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 90 }, 387800);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 90 }, 387802);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 66 }, 387822);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 166 }, 387824);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 20 }, 387826);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 110 }, 387828);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 110 }, 387830);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 54 }, 387832);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 54 }, 387834);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 106 }, 387854);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 196 }, 387856);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 60 }, 387858);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 220, 5, 250, 5, 250, 5, 250, 5 }, 387860);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 10 }, 387886);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 100 }, 387888);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 190 }, 387890);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 14 }, 387892);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 29 }, 387894);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 29 }, 387896);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 29 }, 387898);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 170 }, 387918);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 4 }, 387920);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 44 }, 387922);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 49 }, 387924);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 49 }, 387926);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 64 }, 387928);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 64 }, 387930);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 245, 5, 34 }, 387950);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 44 }, 387954);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 44 }, 387956);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 64 }, 387958);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 64 }, 387960);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 64 }, 387962);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 64 }, 387982);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 64 }, 387984);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 64 }, 387986);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 64 }, 387988);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 64 }, 387990);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 64 }, 387992);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 64 }, 387994);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 64 }, 388014);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 64 }, 388016);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 64 }, 388018);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 64 }, 388020);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 64 }, 388022);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 64 }, 388024);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 64 }, 388026);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 176 }, 388100);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 176 }, 388102);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 176 }, 388104);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 176 }, 388106);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 181 }, 388120);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 223, 4, 12 }, 388122);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 49 }, 388126);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 181 }, 388140);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 226, 4, 21 }, 388142);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 118 }, 388146);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 30 }, 388160);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 132 }, 388162);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 162 }, 388164);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 253, 5 }, 388166);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 200 }, 388180);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 64 }, 388182);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 64 }, 388184);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 69 }, 388186);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 64 }, 388200);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 64 }, 388202);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 64 }, 388204);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 71 }, 388206);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 64 }, 388220);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 64 }, 388222);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 64 }, 388224);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 64 }, 388226);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 60 }, 390186);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 110 }, 390188);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 114 }, 390190);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 123 }, 390192);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 82 }, 390194);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 82 }, 390196);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 82 }, 390198);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 87 }, 390218);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 183 }, 390220);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 211 }, 390222);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 232, 3, 56 }, 390224);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 56 }, 390228);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 56 }, 390230);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 35 }, 390250);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 57 }, 390252);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 182 }, 390254);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 212 }, 390256);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 206 }, 390258);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 70 }, 390260);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 70 }, 390262);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 55 }, 390282);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 127 }, 390284);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 179 }, 390286);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 243, 4, 52 }, 390288);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 70 }, 390292);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 70 }, 390294);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 129 }, 390314);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 212 }, 390316);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 241, 4, 60 }, 390318);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 146 }, 390322);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 170 }, 390324);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 170 }, 390326);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 232, 4, 8 }, 390346);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 43 }, 390350);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 139 }, 390352);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 239, 5, 245, 5, 245, 5 }, 390354);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 65 }, 390378);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 101 }, 390380);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 126 }, 390382);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 4 }, 390384);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 39 }, 390386);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 39 }, 390388);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 39 }, 390390);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 127 }, 390410);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224, 5, 248, 5, 32 }, 390412);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 54 }, 390418);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 54 }, 390420);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 54 }, 390422);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 189 }, 390442);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 254, 5, 27 }, 390444);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 57 }, 390448);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 64 }, 390450);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 64 }, 390452);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 64 }, 390454);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 250, 5, 43 }, 390474);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 57 }, 390478);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 63 }, 390480);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 64 }, 390482);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 64 }, 390484);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 64 }, 390486);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 32 }, 390506);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 59 }, 390508);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 62 }, 390510);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 64 }, 390512);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 64 }, 390514);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 64 }, 390516);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 64 }, 390518);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 44 }, 390538);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 64 }, 390540);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 64 }, 390542);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 64 }, 390544);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 64 }, 390546);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 64 }, 390548);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 64 }, 390550);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 54 }, 390954);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 81 }, 390956);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 90 }, 390958);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 150 }, 390960);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 207 }, 390962);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 245, 2, 1 }, 390964);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 126 }, 390986);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 188 }, 390988);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 210 }, 390990);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 1 }, 390992);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 68 }, 390994);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 113 }, 390996);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 117 }, 390998);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 210 }, 391018);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 3 }, 391020);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 45 }, 391022);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 121 }, 391024);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 164 }, 391026);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 218 }, 391028);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 223 }, 391030);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 19 }, 391050);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 69 }, 391052);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 98 }, 391054);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 182 }, 391056);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 242, 3, 76 }, 391058);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 76 }, 391062);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 87 }, 391082);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 166 }, 391084);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 191 }, 391086);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 76 }, 391088);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 160 }, 391090);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 236, 4, 236, 4 }, 391092);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 205 }, 391114);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 42 }, 391116);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 105 }, 391118);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 229, 4, 63 }, 391120);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 112 }, 391124);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 122 }, 391126);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 52 }, 391146);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 134 }, 391148);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 162 }, 391150);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 17 }, 391152);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 134 }, 391154);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 180 }, 391156);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 180 }, 391158);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 111 }, 391178);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 26 }, 391180);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 65 }, 391182);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 123 }, 391184);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 185 }, 391186);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 5 }, 391188);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 10 }, 391190);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 180 }, 391210);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 16 }, 391212);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 69 }, 391214);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 174 }, 391216);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 232, 5, 254, 5, 2 }, 391218);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 253, 4, 80 }, 391242);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 117 }, 391246);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 228, 5, 13 }, 391248);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 14 }, 391252);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 14 }, 391254);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 183 }, 391274);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 54 }, 391276);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 103 }, 391278);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 7 }, 391280);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 14 }, 391282);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 14 }, 391284);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 14 }, 391286);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 166 }, 391306);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 64 }, 391308);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 125 }, 391310);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 9 }, 391312);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 14 }, 391314);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 14 }, 391316);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 14 }, 391318);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 176 }, 391392);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 176 }, 391394);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 176 }, 391396);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 176 }, 391398);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 181 }, 391412);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 223, 4, 12 }, 391414);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 49 }, 391418);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 181 }, 391432);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 226, 4, 21 }, 391434);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 118 }, 391438);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 30 }, 391452);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 132 }, 391454);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 162 }, 391456);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 253, 5 }, 391458);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 200 }, 391472);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 64 }, 391474);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 64 }, 391476);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 69 }, 391478);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 64 }, 391492);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 64 }, 391494);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 64 }, 391496);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 71 }, 391498);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 64 }, 391512);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 64 }, 391514);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 64 }, 391516);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 64 }, 391518);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 171 }, 391592);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 199 }, 391594);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 243, 1, 176 }, 391596);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 194 }, 391612);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 194 }, 391614);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 21 }, 391616);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 252, 2 }, 391618);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 219 }, 391632);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 244, 1, 91 }, 391634);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 29 }, 391638);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 148 }, 391652);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 250, 2, 24 }, 391654);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 149 }, 391658);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 178 }, 391672);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 194 }, 391674);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 161 }, 391676);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 83 }, 391678);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 22 }, 391692);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 56 }, 391694);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 178 }, 391696);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 30 }, 391698);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 255, 3, 182 }, 391712);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 3 }, 391716);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 206 }, 391718);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 60 }, 392122);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 110 }, 392124);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 114 }, 392126);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 123 }, 392128);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 1 }, 392130);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 1 }, 392132);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 1 }, 392134);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 125 }, 392154);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 213 }, 392156);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 241, 3, 1 }, 392158);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 126 }, 392162);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 126 }, 392164);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 126 }, 392166);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 206 }, 392186);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 53 }, 392188);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 95 }, 392190);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 140 }, 392192);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 0 }, 392194);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 0 }, 392196);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 0 }, 392198);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 22 }, 392218);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 127 }, 392220);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 179 }, 392222);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 243, 4, 52 }, 392224);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 70 }, 392228);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 70 }, 392230);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 111 }, 392250);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 212 }, 392252);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 241, 4, 60 }, 392254);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 146 }, 392258);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 170 }, 392260);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 170 }, 392262);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 205 }, 392282);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 8 }, 392284);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 43 }, 392286);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 139 }, 392288);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 239, 5, 245, 5, 245, 5 }, 392290);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 39 }, 392314);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 101 }, 392316);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 126 }, 392318);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 4 }, 392320);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 39 }, 392322);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 39 }, 392324);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 39 }, 392326);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 115 }, 392346);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224, 5, 248, 5, 32 }, 392348);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 54 }, 392354);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 54 }, 392356);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 54 }, 392358);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 181 }, 392378);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 254, 5, 27 }, 392380);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 57 }, 392384);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 64 }, 392386);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 64 }, 392388);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 64 }, 392390);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 250, 5, 43 }, 392410);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 57 }, 392414);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 63 }, 392416);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 64 }, 392418);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 64 }, 392420);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 64 }, 392422);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 32 }, 392442);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 59 }, 392444);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 62 }, 392446);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 64 }, 392448);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 64 }, 392450);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 64 }, 392452);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 64 }, 392454);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 44 }, 392474);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 64 }, 392476);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 64 }, 392478);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 64 }, 392480);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 64 }, 392482);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 64 }, 392484);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 64 }, 392486);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 110 }, 402806);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 110 }, 402808);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 105 }, 402810);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 150 }, 402838);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 150 }, 402840);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 150 }, 402842);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 155 }, 402870);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 155 }, 402872);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 155 }, 402874);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 49 }, 402902);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 49 }, 402904);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 49 }, 402906);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 107 }, 402934);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 107 }, 402936);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 107 }, 402938);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 164 }, 402966);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 164 }, 402968);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 164 }, 402970);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 204 }, 402998);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 204 }, 403000);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 204 }, 403002);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 204 }, 403030);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 204 }, 403032);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 204 }, 403034);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 105 }, 403318);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 105 }, 403320);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 105 }, 403322);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 150 }, 403350);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 150 }, 403352);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 150 }, 403354);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 155 }, 403382);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 155 }, 403384);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 155 }, 403386);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 49 }, 403414);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 49 }, 403416);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 49 }, 403418);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 107 }, 403446);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 107 }, 403448);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 107 }, 403450);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 164 }, 403478);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 164 }, 403480);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 164 }, 403482);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 204 }, 403510);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 204 }, 403512);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 204 }, 403514);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 204 }, 403542);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 204 }, 403544);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 204 }, 403546);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 165 }, 407290);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 130 }, 407292);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 130 }, 407294);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 3 }, 407322);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 252, 70, 9 }, 407324);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 44 }, 407354);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 26 }, 407356);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 26 }, 407358);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 92 }, 407386);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 92 }, 407388);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 92 }, 407390);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 174 }, 407418);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 174 }, 407420);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 174 }, 407422);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 249, 71, 249, 71, 249, 71 }, 407450);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 99 }, 407482);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 99 }, 407484);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 99 }, 407486);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 203 }, 407514);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 199 }, 407516);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 199 }, 407518);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 52 }, 407546);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 51 }, 407548);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 51 }, 407550);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 165 }, 407802);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 130 }, 407804);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 130 }, 407806);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 3 }, 407834);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 252, 70, 9 }, 407836);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 44 }, 407866);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 26 }, 407868);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 26 }, 407870);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 92 }, 407898);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 92 }, 407900);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 92 }, 407902);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 174 }, 407930);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 174 }, 407932);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 174 }, 407934);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 249, 71, 249, 71, 249, 71 }, 407962);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 99 }, 407994);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 99 }, 407996);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 99 }, 407998);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 203 }, 408026);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 199 }, 408028);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 199 }, 408030);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 52 }, 408058);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 51 }, 408060);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 51 }, 408062);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 165 }, 408970);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 130 }, 408972);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 130 }, 408974);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 180 }, 409002);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 155 }, 409004);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 155 }, 409006);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 207 }, 409034);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 205 }, 409036);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 205 }, 409038);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 248, 70, 245 }, 409066);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 245 }, 409070);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 26 }, 409098);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 14 }, 409100);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 14 }, 409102);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 114 }, 409130);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 110 }, 409132);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 110 }, 409134);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 206 }, 409162);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 205 }, 409164);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 205 }, 409166);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 175 }, 409194);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 177 }, 409196);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 177 }, 409198);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 217 }, 409226);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 218 }, 409228);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 218 }, 409230);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 169 }, 409482);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 140 }, 409484);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 140 }, 409486);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 180 }, 409514);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 155 }, 409516);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 155 }, 409518);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 207 }, 409546);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 205 }, 409548);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 205 }, 409550);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 248, 70, 245 }, 409578);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 245 }, 409582);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 26 }, 409610);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 14 }, 409612);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 14 }, 409614);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 114 }, 409642);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 110 }, 409644);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 110 }, 409646);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 206 }, 409674);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 205 }, 409676);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 205 }, 409678);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 175 }, 409706);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 177 }, 409708);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 177 }, 409710);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 217 }, 409738);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 218 }, 409740);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 218 }, 409742);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 190 }, 410250);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 155 }, 410252);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 155 }, 410254);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 180 }, 410282);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 155 }, 410284);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 155 }, 410286);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 207 }, 410314);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 205 }, 410316);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 205 }, 410318);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 248, 70, 245 }, 410346);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 245 }, 410350);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 26 }, 410378);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 14 }, 410380);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 14 }, 410382);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 104 }, 410410);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 104 }, 410412);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 104 }, 410414);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 196 }, 410442);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 196 }, 410444);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 196 }, 410446);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 162 }, 410474);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 162 }, 410476);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 162 }, 410478);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 185 }, 410506);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 185 }, 410508);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 185 }, 410510);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 169 }, 410762);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 140 }, 410764);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 140 }, 410766);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 180 }, 410794);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 155 }, 410796);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 155 }, 410798);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 207 }, 410826);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 205 }, 410828);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 205 }, 410830);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 248, 70, 245 }, 410858);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 245 }, 410862);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 26 }, 410890);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 26 }, 410892);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 26 }, 410894);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 114 }, 410922);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 114 }, 410924);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 114 }, 410926);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 206 }, 410954);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 206 }, 410956);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 206 }, 410958);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 172 }, 410986);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 172 }, 410988);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 172 }, 410990);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 185 }, 411018);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 185 }, 411020);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 185 }, 411022);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 128, 32, 128, 32, 128, 32, 78, 28, 197, 24, 4, 22, 209, 19, 4, 18, 131, 16, 62, 15, 39, 14, 54, 13, 98, 12, 2, 11, 87, 7 }, 444944);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 128, 32, 128, 32, 128, 32, 216, 31, 221, 27, 197, 24, 75, 22, 68, 20, 148, 18, 38, 17, 236, 15, 220, 14, 239, 13, 98, 12, 66, 8 }, 444984);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 128, 32, 128, 32, 128, 32, 128, 32, 246, 30, 133, 27, 197, 24, 132, 22, 164, 20, 13, 19, 177, 17, 131, 16, 123, 15, 195, 13, 44, 9 }, 445024);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 128, 32, 128, 32, 128, 32, 128, 32, 128, 32, 70, 30, 63, 27, 197, 24, 180, 22, 245, 20, 118, 19, 42, 18, 7, 17, 35, 15, 23, 10 }, 445064);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 128, 32, 128, 32, 128, 32, 128, 32, 128, 32, 128, 32, 185, 29, 5, 27, 197, 24, 221, 22, 59, 21, 209, 19, 148, 18, 131, 16, 2, 11 }, 445104);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 128, 32, 128, 32, 128, 32, 128, 32, 128, 32, 128, 32, 51, 32, 69, 29, 213, 26, 197, 24, 0, 23, 119, 21, 32, 20, 228, 17, 237, 11 }, 445144);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 128, 32, 128, 32, 128, 32, 128, 32, 128, 32, 128, 32, 128, 32, 134, 31, 229, 28, 172, 26, 197, 24, 30, 23, 172, 21, 68, 19, 216, 12 }, 445184);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 128, 32, 128, 32, 128, 32, 128, 32, 128, 32, 128, 32, 128, 32, 128, 32, 246, 30, 148, 28, 138, 26, 197, 24, 56, 23, 164, 20, 195, 13 }, 445224);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 128, 32, 128, 32, 128, 32, 128, 32, 128, 32, 128, 32, 128, 32, 128, 32, 128, 32, 124, 30, 78, 28, 108, 26, 197, 24, 4, 22, 173, 14 }, 445264);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 160, 32, 215, 31, 90, 28, 213, 26, 80, 25, 151, 18, 217, 13, 108, 12, 160, 32, 35, 31, 90, 28, 213, 26, 80, 25, 151, 18, 26, 13, 201, 9, 39, 32, 227, 30, 90, 28, 109, 26, 129, 24, 201, 17, 60, 12, 79, 8, 123, 31, 111, 30, 90, 28, 210, 25, 70, 22, 164, 16, 171, 11, 142, 8, 74, 28, 245, 26, 77, 24, 112, 22, 244, 18, 58, 15, 202, 10, 56, 8, 178, 26, 57, 25, 70, 22, 190, 20, 75, 17, 132, 14, 89, 10, 13, 8, 118, 24, 249, 22, 254, 19, 139, 18, 98, 15, 133, 12, 19, 9, 123, 7, 29, 21, 154, 19, 146, 16, 62, 15, 133, 12, 134, 9, 43, 7, 160, 6 }, 469268);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 107, 106, 95, 94, 89, 89, 93, 100, 92, 52, 52, 52 }, 469436);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 111, 113, 112, 109, 106, 106, 99, 111, 107, 76, 62, 62 }, 469456);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 117, 116, 115, 115, 113, 108, 100, 116, 115, 93, 65, 65 }, 469476);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 114, 115, 115, 109, 105, 100, 112, 112, 101, 87, 87 }, 469497);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 119, 120, 116, 112, 108, 104, 114, 115, 115, 115, 115 }, 469517);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 112, 107, 118, 118, 118, 118, 111 }, 469541);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 0, 33 }, 469648);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 20, 224, 16, 64, 16, 160, 15, 0, 15, 96, 14, 32, 13, 160, 7, 64, 7, 192, 6, 64, 6, 0, 33, 96, 20, 64, 18, 224, 17, 224, 16, 64, 16, 128, 15, 32, 15, 224, 10, 128, 10, 96, 9, 32, 8, 0, 33, 96, 33, 160, 26, 128, 30, 128, 21, 64, 19, 224, 17, 160, 16, 32, 15, 224, 14, 64, 14, 192, 13, 0, 33, 96, 33, 128, 28, 96, 31, 128, 26, 192, 24, 0, 23, 160, 20, 32, 18, 224, 17, 128, 17, 0, 15, 0, 33, 96, 33, 96, 33, 96, 33, 160, 27, 128, 26, 64, 25, 64, 23, 32, 21, 32, 20, 96, 19, 96, 15, 0, 33, 96, 33, 96, 33, 96, 33, 96, 30, 128, 29, 128, 28, 192, 26, 224, 24 }, 469651);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 24, 192, 22, 96, 15, 0, 33, 96, 33, 96, 33, 96, 33 }, 469787);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 32 }, 469801);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 32, 224, 31, 64, 30, 128, 28, 128, 25, 224, 24, 96, 15, 0, 33, 96, 33, 96, 33, 96, 33 }, 469803);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 32 }, 469825);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 32, 224, 31, 128, 30, 0, 29, 0, 27, 32, 25, 96, 15, 0, 33, 96, 33, 96, 33, 96, 33 }, 469827);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 32 }, 469849);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 32, 224, 31, 64, 31, 0, 29, 0, 27, 32, 25, 96, 15, 0, 33, 96, 33, 96, 33, 96, 33 }, 469851);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 32 }, 469873);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 32, 224, 31, 64, 31, 0, 29, 0, 27, 32, 25, 96, 15 }, 469875);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224, 27, 0, 33, 32, 33, 64, 33, 96, 33, 192, 32 }, 470088);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 32, 96, 31, 160, 30, 160, 29, 0, 29, 0, 27, 32, 25, 128, 19, 96, 15, 224, 7 }, 470101);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 115, 115, 115, 109, 99, 95, 88, 92, 102 }, 470228);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 120, 113, 102, 97, 90, 97, 102 }, 470250);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 118, 107, 102, 96, 102, 107 }, 470271);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 120, 115, 108, 110, 115 }, 470292);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 117, 110, 102, 108, 115 }, 470312);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 113, 105, 111, 118 }, 470333);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 119, 110, 116, 122 }, 470353);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 113, 120 }, 470374);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 0, 33, 64, 33, 96, 33, 176, 32 }, 470440);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 32, 80, 31, 160, 30, 208, 29, 0, 29, 0, 27, 32, 25, 96, 15, 0, 33, 64, 33, 96, 33, 176, 32 }, 470449);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 32, 80, 31, 160, 30, 208, 29, 0, 29, 0, 27, 32, 25, 96, 15, 0, 33, 64, 33, 96, 33, 176, 32 }, 470473);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 32, 80, 31, 160, 30, 208, 29, 0, 29, 0, 27, 32, 25, 96, 15, 0, 33, 64, 33, 96, 33, 176, 32 }, 470497);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 32, 80, 31, 160, 30, 208, 29, 0, 29, 0, 27, 32, 25, 96, 15, 0, 33, 64, 33, 96, 33, 176, 32 }, 470521);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 32, 80, 31, 160, 30, 208, 29, 0, 29, 0, 27, 32, 25, 96, 15, 0, 33, 64, 33, 96, 33, 176, 32 }, 470545);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 32, 80, 31, 160, 30, 208, 29, 0, 29, 0, 27, 32, 25, 96, 15, 0, 33, 78, 29, 192, 27, 234, 26, 235, 24, 247, 21, 36, 18, 224, 14, 63, 13, 17, 12, 100, 11, 137, 9, 0, 33, 132, 30, 226, 28, 194, 27, 18, 26, 236, 22, 139, 25, 252, 22, 238, 20, 91, 19, 196, 18, 226, 10, 0, 33, 9, 32, 17, 30, 9, 31 }, 470569);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 32, 96, 31, 160, 30, 160, 29, 0, 29, 0, 27, 32, 25, 96, 15, 0, 33, 64, 33, 128, 31, 192, 31 }, 470641);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 32, 96, 31, 160, 30, 160, 29, 0, 29, 0, 27, 32, 25, 96, 15, 0, 33, 64, 33, 9, 32, 5, 32 }, 470665);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 32, 96, 31, 160, 30, 160, 29, 0, 29, 0, 27, 32, 25, 96, 15, 0, 33, 64, 33, 0, 33, 128, 32 }, 470689);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 32, 96, 31, 160, 30, 160, 29, 0, 29, 0, 27, 32, 25, 96, 15, 0, 33, 64, 33, 64, 33, 160, 32 }, 470713);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 32, 96, 31, 160, 30, 160, 29, 0, 29, 0, 27, 32, 25, 96, 15, 0, 33, 64, 33, 96, 33, 192, 32 }, 470737);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 32, 96, 31, 160, 30, 160, 29, 0, 29, 0, 27, 32, 25, 96, 15, 0, 33, 64, 33, 96, 33, 192, 32 }, 470761);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 32, 96, 31, 160, 30, 160, 29, 0, 29, 0, 27, 32, 25, 96, 15, 0, 33, 64, 33, 96, 33, 192, 32 }, 470785);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 32, 96, 31, 160, 30, 160, 29, 0, 29, 0, 27, 32, 25, 96, 15 }, 470809);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 224, 27, 0, 33, 32, 33, 192, 33, 192, 33, 192, 32 }, 471064);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 32, 96, 31, 160, 30, 0, 30, 96, 29, 128, 27, 160, 25, 128, 19, 96, 15, 224, 7 }, 471077);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 160, 76, 160, 81, 192, 81, 160, 81, 160, 81, 224, 80 }, 471116);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 80, 64, 79, 96, 78, 64, 77, 96, 76, 0, 74, 160, 71, 224, 65, 128, 61, 32, 59 }, 471129);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 160, 76, 160, 81, 192, 81, 160, 81, 160, 81, 224, 80 }, 471156);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 80, 64, 79, 96, 78, 64, 77, 96, 76, 0, 74, 160, 71, 224, 65, 128, 61, 32, 59 }, 471169);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 0, 33, 0, 33, 0, 33, 0, 33, 0, 33, 0, 33, 0, 33, 0, 33, 0, 33, 0, 33, 48, 34, 48, 34, 48, 34, 48, 34, 48, 34, 48, 34, 48, 34, 48, 34, 48, 34, 48, 34, 96, 33, 96, 33, 96, 33, 96, 33, 96, 33, 96, 33, 96, 33, 96, 33, 96, 33, 96, 33, 224, 33, 224, 33, 224, 33, 224, 33, 224, 33, 224, 33, 224, 33, 224, 33, 224, 33, 224, 33, 96, 34, 96, 34, 96, 34, 96, 34, 96, 34, 96, 34, 96, 34, 96, 34, 96, 34, 96, 34, 16, 34, 16, 34, 16, 34, 16, 34, 16, 34, 16, 34, 16, 34, 16, 34, 16, 34, 16, 34, 192, 33, 192, 33, 192, 33, 192, 33, 192, 33, 192, 33, 192, 33, 192, 33, 192, 33, 192, 33, 240, 30, 240, 30, 240, 30, 240, 30, 240, 30, 240, 30, 240, 30, 240, 30, 240, 30, 240, 30, 32, 28, 32, 28, 32, 28, 32, 28, 32, 28, 32, 28, 32, 28, 32, 28, 32, 28, 32, 28, 32, 28, 32, 28, 32, 28, 32, 28, 32, 28, 32, 28, 32, 28, 32, 28, 32, 28, 32, 28, 64, 26, 64, 26, 64, 26, 64, 26, 64, 26, 64, 26, 64, 26, 64, 26, 64, 26, 64, 26, 96, 15, 96, 15, 96, 15, 96, 15, 96, 15, 96, 15, 96, 15, 96, 15, 96, 15, 96, 15 }, 471404);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 0, 35, 0, 35, 0, 35, 0, 35, 0, 35 }, 488074);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 0, 35, 0, 35, 0, 35, 0, 35, 0, 35 }, 488110);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 0, 35, 0, 35, 0, 35, 0, 35, 0, 35 }, 488146);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 0, 35, 0, 35, 0, 35, 0, 35, 0, 35 }, 488182);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 0, 35, 0, 35, 0, 35, 0, 35, 0, 35 }, 488218);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 0, 35, 0, 35, 0, 35, 0, 35, 0, 35 }, 488254);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 0, 35, 0, 35, 0, 35, 0, 35, 0, 35 }, 488290);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 0, 35, 0, 35, 0, 35, 0, 35, 0, 35 }, 488326);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 0, 35, 0, 35, 0, 35, 0, 35, 0, 35 }, 488362);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 0, 35, 0, 35, 0, 35, 0, 35, 0, 35 }, 488398);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 0, 35, 0, 35, 0, 35, 0, 35, 0, 35 }, 488434);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 0, 35, 0, 35, 0, 35, 0, 35, 0, 35 }, 488470);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 0, 35, 0, 35, 0, 35, 0, 35, 0, 35 }, 488506);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 0, 35, 0, 35, 0, 35, 0, 35, 0, 35 }, 488542);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 0, 35, 0, 35, 0, 35, 0, 35, 0, 35 }, 488578);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 0, 35, 0, 35, 0, 35, 0, 35, 0, 35 }, 488614);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 0, 35, 0, 35, 0, 35, 0, 35, 0, 35 }, 488650);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 0, 35, 0, 35, 0, 35, 0, 35, 0, 35 }, 488686);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 29 }, 488726);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 29 }, 488728);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 29, 19 }, 488730);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 252, 18, 252, 18, 252, 18 }, 488762);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 222, 18, 222, 18, 222, 18 }, 488798);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 44 }, 488834);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 44 }, 488836);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 44, 19 }, 488838);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 106 }, 488870);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 106 }, 488872);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 106, 19 }, 488874);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 83 }, 488906);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 83 }, 488908);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 83, 19 }, 488910);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 145, 18, 145, 18, 145, 18 }, 488942);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 182, 18, 182, 18, 182, 18 }, 488978);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 122, 18, 122, 18, 122, 18 }, 489014);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 182, 18, 182, 18, 182, 18 }, 489050);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 148 }, 489086);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 148 }, 489088);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 148, 19 }, 489090);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 111, 20, 111, 20, 111 }, 489122);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 83, 18, 83, 18, 83, 18 }, 489158);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 19 }, 489194);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 19 }, 489196);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 19, 19 }, 489198);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 178, 18, 178, 18, 178, 18 }, 489230);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 178, 18, 178, 18, 178, 18 }, 489266);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 178, 18, 178, 18, 178, 18 }, 489302);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 178, 18, 178, 18, 178, 18 }, 489338);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 0, 35, 0, 35, 0, 35 }, 489998);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 0, 35, 0, 35, 0, 35 }, 490034);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 0, 35, 0, 35, 0, 35 }, 490070);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 0, 35, 0, 35, 0, 35 }, 490106);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 0, 35, 0, 35, 0, 35 }, 490142);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 0, 35, 0, 35, 0, 35 }, 490178);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 0, 35, 0, 35, 0, 35 }, 490214);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 0, 35, 0, 35, 0, 35 }, 490250);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 0, 35, 0, 35, 0, 35 }, 490286);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 0, 35, 0, 35, 0, 35 }, 490322);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 0, 35, 0, 35, 0, 35 }, 490358);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 0, 35, 0, 35, 0, 35 }, 490394);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 0, 35, 0, 35, 0, 35 }, 490430);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 0, 35, 0, 35, 0, 35 }, 490466);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 0, 35, 0, 35, 0, 35 }, 490502);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 0, 35, 0, 35, 0, 35 }, 490538);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 0, 35, 0, 35, 0, 35 }, 490574);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 0, 35, 0, 35, 0, 35 }, 490610);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 136 }, 490648);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 136, 19 }, 490650);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 136 }, 490684);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 136, 19 }, 490686);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 136 }, 490720);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 136, 19 }, 490722);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 176 }, 490756);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 176, 19 }, 490758);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 66 }, 490790);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 66 }, 490792);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 66, 19 }, 490794);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 96 }, 490826);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 96 }, 490828);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 96, 19 }, 490830);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 96 }, 490862);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 96 }, 490864);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 96, 19 }, 490866);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 236 }, 490898);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 236, 19 }, 490902);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 6 }, 490934);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 6 }, 490936);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 6, 19 }, 490938);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 26 }, 490970);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 26 }, 490972);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 26, 19 }, 490974);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 242, 18, 242, 18, 242, 18 }, 491006);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 242, 18, 242, 18, 242, 18 }, 491042);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 242, 18, 242, 18, 242, 18 }, 491078);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 242, 18, 242, 18, 242, 18 }, 491114);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 242, 18, 242, 18, 242, 18 }, 491150);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 242, 18, 242, 18, 242, 18 }, 491186);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 242, 18, 242, 18, 242, 18 }, 491222);
                validationEgrInFile = validationEgrInFile && ToolBox.ExistsInFileMultiple(new byte[] { 242, 18, 242, 18, 242, 18 }, 491258);
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
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 124, 250, 104, 194 },
         new byte[] { 104, 9, 55, 150 }, 263172, 263175, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 159 },
             new byte[] { 176 }, 288208, 288208, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 145 },
             new byte[] { 161 }, 288210, 288210, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 132 },
             new byte[] { 148 }, 288212, 288212, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 118 },
             new byte[] { 133 }, 288214, 288214, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 106 },
             new byte[] { 120 }, 288216, 288216, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 103 },
             new byte[] { 117 }, 288218, 288218, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 101 },
             new byte[] { 115 }, 288220, 288220, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 100 },
             new byte[] { 114 }, 288222, 288222, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 208 },
             new byte[] { 227 }, 288244, 288244, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 190 },
             new byte[] { 208 }, 288246, 288246, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 175 },
             new byte[] { 193 }, 288248, 288248, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 160 },
             new byte[] { 177 }, 288250, 288250, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 146 },
             new byte[] { 163 }, 288252, 288252, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 141 },
             new byte[] { 158 }, 288254, 288254, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 137 },
             new byte[] { 154 }, 288256, 288256, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 135 },
             new byte[] { 152 }, 288258, 288258, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 4 },
             new byte[] { 25 }, 288280, 288280, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 241, 1, 226 },
             new byte[] { 5, 2, 246 }, 288282, 288284, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 210 },
             new byte[] { 230 }, 288286, 288286, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 195 },
             new byte[] { 215 }, 288288, 288288, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 189 },
             new byte[] { 209 }, 288290, 288290, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 182 },
             new byte[] { 202 }, 288292, 288292, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 179 },
             new byte[] { 199 }, 288294, 288294, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 57 },
             new byte[] { 80 }, 288316, 288316, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 34 },
             new byte[] { 57 }, 288318, 288318, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16 },
             new byte[] { 38 }, 288320, 288320, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 253, 1, 236, 1, 229 },
             new byte[] { 19, 2, 2, 2, 251 }, 288322, 288326, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 222 },
             new byte[] { 245 }, 288328, 288328, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 220 },
             new byte[] { 243 }, 288330, 288330, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 141 },
             new byte[] { 167 }, 288352, 288352, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 106 },
             new byte[] { 132 }, 288354, 288354, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 77 },
             new byte[] { 102 }, 288356, 288356, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 51 },
             new byte[] { 76 }, 288358, 288358, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 31 },
             new byte[] { 56 }, 288360, 288360, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 20 },
             new byte[] { 46 }, 288362, 288362, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 6 },
             new byte[] { 32 }, 288364, 288364, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 1 },
             new byte[] { 27 }, 288366, 288366, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 253, 2, 208 },
             new byte[] { 28, 3, 238 }, 288388, 288390, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 172 },
             new byte[] { 202 }, 288392, 288392, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 139 },
             new byte[] { 169 }, 288394, 288394, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 110 },
             new byte[] { 140 }, 288396, 288396, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 93 },
             new byte[] { 123 }, 288398, 288398, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 74 },
             new byte[] { 105 }, 288400, 288400, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 65 },
             new byte[] { 96 }, 288402, 288402, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 146 },
             new byte[] { 183 }, 288424, 288424, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 85 },
             new byte[] { 121 }, 288426, 288426, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 34 },
             new byte[] { 70 }, 288428, 288428, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 245, 2, 208 },
             new byte[] { 25, 3, 244 }, 288430, 288432, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 182 },
             new byte[] { 218 }, 288434, 288434, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 157 },
             new byte[] { 194 }, 288436, 288436, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 145 },
             new byte[] { 183 }, 288438, 288438, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 62 },
             new byte[] { 105 }, 288460, 288460, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 246, 3, 182 },
             new byte[] { 33, 4, 225 }, 288462, 288464, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 124 },
             new byte[] { 167 }, 288466, 288466, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 75 },
             new byte[] { 118 }, 288468, 288468, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 39 },
             new byte[] { 83 }, 288470, 288470, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 3 },
             new byte[] { 47 }, 288472, 288472, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 243, 2 },
             new byte[] { 32, 3 }, 288474, 288475, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 206 },
             new byte[] { 255 }, 288496, 288496, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 133 },
             new byte[] { 183 }, 288498, 288498, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 69 },
             new byte[] { 120 }, 288500, 288500, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 8 },
             new byte[] { 59 }, 288502, 288502, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 209, 3, 164 },
             new byte[] { 5, 4, 216 }, 288504, 288506, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 117 },
             new byte[] { 170 }, 288508, 288508, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 95 },
             new byte[] { 149 }, 288510, 288510, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 96 },
             new byte[] { 151 }, 288532, 288532, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 1 },
             new byte[] { 57 }, 288534, 288534, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 190 },
             new byte[] { 247 }, 288536, 288536, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 128 },
             new byte[] { 187 }, 288538, 288538, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 72 },
             new byte[] { 132 }, 288540, 288540, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 26 },
             new byte[] { 87 }, 288542, 288542, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 233, 3, 209, 3 },
             new byte[] { 39, 4, 17, 4 }, 288544, 288547, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 115 },
             new byte[] { 181 }, 288568, 288568, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 11 },
             new byte[] { 79 }, 288570, 288570, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 190, 5, 121 },
             new byte[] { 5, 6, 194 }, 288572, 288574, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 56 },
             new byte[] { 131 }, 288576, 288576, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 2 },
             new byte[] { 79 }, 288578, 288578, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 206, 4, 180, 4 },
             new byte[] { 29, 5, 7, 5 }, 288580, 288583, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 147 },
             new byte[] { 225 }, 288604, 288604, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 20 },
             new byte[] { 101 }, 288606, 288606, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 183, 6, 100 },
             new byte[] { 11, 7, 187 }, 288608, 288610, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 26 },
             new byte[] { 117 }, 288612, 288612, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 222, 5, 166, 5, 135 },
             new byte[] { 60, 6, 7, 6, 236 }, 288614, 288618, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 206, 8, 55 },
             new byte[] { 40, 9, 149 }, 288640, 288642, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 199, 7, 100 },
             new byte[] { 42, 8, 203 }, 288644, 288646, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 10 },
             new byte[] { 117 }, 288648, 288648, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 191, 6, 123 },
             new byte[] { 46, 7, 238 }, 288650, 288652, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 87 },
             new byte[] { 208 }, 288654, 288654, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 61 },
             new byte[] { 176 }, 288676, 288676, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 145, 10, 10 },
             new byte[] { 12, 11, 140 }, 288678, 288680, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 142, 9, 28 },
             new byte[] { 23, 10, 171 }, 288682, 288684, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 185, 8, 87 },
             new byte[] { 78, 9, 240 }, 288686, 288688, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 29 },
             new byte[] { 189 }, 288690, 288690, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 152, 14, 183, 13, 8 },
             new byte[] { 45, 15, 88, 14, 180 }, 288712, 288716, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 109, 12, 229, 11, 110, 11, 245, 10, 149, 10 },
             new byte[] { 35, 13, 164, 12, 55, 12, 197, 11, 110, 11 }, 288718, 288727, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 159 },
             new byte[] { 176 }, 289072, 289072, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 145 },
             new byte[] { 161 }, 289074, 289074, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 132 },
             new byte[] { 148 }, 289076, 289076, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 118 },
             new byte[] { 133 }, 289078, 289078, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 106 },
             new byte[] { 120 }, 289080, 289080, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 103 },
             new byte[] { 117 }, 289082, 289082, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 101 },
             new byte[] { 115 }, 289084, 289084, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 100 },
             new byte[] { 114 }, 289086, 289086, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 208 },
             new byte[] { 227 }, 289108, 289108, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 190 },
             new byte[] { 208 }, 289110, 289110, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 175 },
             new byte[] { 193 }, 289112, 289112, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 160 },
             new byte[] { 177 }, 289114, 289114, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 146 },
             new byte[] { 163 }, 289116, 289116, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 141 },
             new byte[] { 158 }, 289118, 289118, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 137 },
             new byte[] { 154 }, 289120, 289120, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 135 },
             new byte[] { 152 }, 289122, 289122, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 4 },
             new byte[] { 25 }, 289144, 289144, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 241, 1, 226 },
             new byte[] { 5, 2, 246 }, 289146, 289148, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 210 },
             new byte[] { 230 }, 289150, 289150, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 195 },
             new byte[] { 215 }, 289152, 289152, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 189 },
             new byte[] { 209 }, 289154, 289154, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 182 },
             new byte[] { 202 }, 289156, 289156, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 179 },
             new byte[] { 199 }, 289158, 289158, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 57 },
             new byte[] { 80 }, 289180, 289180, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 34 },
             new byte[] { 57 }, 289182, 289182, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16 },
             new byte[] { 38 }, 289184, 289184, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 253, 1, 236, 1, 229 },
             new byte[] { 19, 2, 2, 2, 251 }, 289186, 289190, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 222 },
             new byte[] { 245 }, 289192, 289192, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 220 },
             new byte[] { 243 }, 289194, 289194, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 141 },
             new byte[] { 167 }, 289216, 289216, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 106 },
             new byte[] { 132 }, 289218, 289218, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 77 },
             new byte[] { 102 }, 289220, 289220, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 51 },
             new byte[] { 76 }, 289222, 289222, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 31 },
             new byte[] { 56 }, 289224, 289224, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 20 },
             new byte[] { 46 }, 289226, 289226, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 6 },
             new byte[] { 32 }, 289228, 289228, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 1 },
             new byte[] { 27 }, 289230, 289230, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 253, 2, 208 },
             new byte[] { 28, 3, 238 }, 289252, 289254, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 172 },
             new byte[] { 202 }, 289256, 289256, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 139 },
             new byte[] { 169 }, 289258, 289258, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 110 },
             new byte[] { 140 }, 289260, 289260, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 93 },
             new byte[] { 123 }, 289262, 289262, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 74 },
             new byte[] { 105 }, 289264, 289264, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 65 },
             new byte[] { 96 }, 289266, 289266, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 146 },
             new byte[] { 183 }, 289288, 289288, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 85 },
             new byte[] { 121 }, 289290, 289290, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 34 },
             new byte[] { 70 }, 289292, 289292, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 245, 2, 208 },
             new byte[] { 25, 3, 244 }, 289294, 289296, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 182 },
             new byte[] { 218 }, 289298, 289298, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 157 },
             new byte[] { 194 }, 289300, 289300, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 145 },
             new byte[] { 183 }, 289302, 289302, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 62 },
             new byte[] { 105 }, 289324, 289324, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 246, 3, 182 },
             new byte[] { 33, 4, 225 }, 289326, 289328, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 124 },
             new byte[] { 167 }, 289330, 289330, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 75 },
             new byte[] { 118 }, 289332, 289332, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 39 },
             new byte[] { 83 }, 289334, 289334, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 3 },
             new byte[] { 47 }, 289336, 289336, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 243, 2 },
             new byte[] { 32, 3 }, 289338, 289339, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 206 },
             new byte[] { 255 }, 289360, 289360, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 133 },
             new byte[] { 183 }, 289362, 289362, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 69 },
             new byte[] { 120 }, 289364, 289364, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 8 },
             new byte[] { 59 }, 289366, 289366, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 209, 3, 164 },
             new byte[] { 5, 4, 216 }, 289368, 289370, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 117 },
             new byte[] { 170 }, 289372, 289372, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 95 },
             new byte[] { 149 }, 289374, 289374, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 96 },
             new byte[] { 151 }, 289396, 289396, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 1 },
             new byte[] { 57 }, 289398, 289398, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 190 },
             new byte[] { 247 }, 289400, 289400, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 128 },
             new byte[] { 187 }, 289402, 289402, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 72 },
             new byte[] { 132 }, 289404, 289404, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 26 },
             new byte[] { 87 }, 289406, 289406, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 233, 3, 209, 3 },
             new byte[] { 39, 4, 17, 4 }, 289408, 289411, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 115 },
             new byte[] { 181 }, 289432, 289432, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 11 },
             new byte[] { 79 }, 289434, 289434, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 190, 5, 121 },
             new byte[] { 5, 6, 194 }, 289436, 289438, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 56 },
             new byte[] { 131 }, 289440, 289440, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 2 },
             new byte[] { 79 }, 289442, 289442, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 206, 4, 180, 4 },
             new byte[] { 29, 5, 7, 5 }, 289444, 289447, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 147 },
             new byte[] { 225 }, 289468, 289468, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 20 },
             new byte[] { 101 }, 289470, 289470, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 183, 6, 100 },
             new byte[] { 11, 7, 187 }, 289472, 289474, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 26 },
             new byte[] { 117 }, 289476, 289476, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 222, 5, 166, 5, 135 },
             new byte[] { 60, 6, 7, 6, 236 }, 289478, 289482, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 206, 8, 55 },
             new byte[] { 40, 9, 149 }, 289504, 289506, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 199, 7, 100 },
             new byte[] { 42, 8, 203 }, 289508, 289510, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 10 },
             new byte[] { 117 }, 289512, 289512, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 191, 6, 123 },
             new byte[] { 46, 7, 238 }, 289514, 289516, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 87 },
             new byte[] { 208 }, 289518, 289518, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 61 },
             new byte[] { 176 }, 289540, 289540, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 145, 10, 10 },
             new byte[] { 12, 11, 140 }, 289542, 289544, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 142, 9, 28 },
             new byte[] { 23, 10, 171 }, 289546, 289548, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 185, 8, 87 },
             new byte[] { 78, 9, 240 }, 289550, 289552, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 29 },
             new byte[] { 189 }, 289554, 289554, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 152, 14, 183, 13, 8 },
             new byte[] { 45, 15, 88, 14, 180 }, 289576, 289580, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 109, 12, 229, 11, 110, 11, 245, 10, 149, 10 },
             new byte[] { 35, 13, 164, 12, 55, 12, 197, 11, 110, 11 }, 289582, 289591, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 159 },
             new byte[] { 176 }, 289936, 289936, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 145 },
             new byte[] { 161 }, 289938, 289938, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 132 },
             new byte[] { 148 }, 289940, 289940, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 118 },
             new byte[] { 133 }, 289942, 289942, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 106 },
             new byte[] { 120 }, 289944, 289944, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 103 },
             new byte[] { 117 }, 289946, 289946, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 101 },
             new byte[] { 115 }, 289948, 289948, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 100 },
             new byte[] { 114 }, 289950, 289950, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 208 },
             new byte[] { 227 }, 289972, 289972, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 190 },
             new byte[] { 208 }, 289974, 289974, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 175 },
             new byte[] { 193 }, 289976, 289976, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 160 },
             new byte[] { 177 }, 289978, 289978, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 146 },
             new byte[] { 163 }, 289980, 289980, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 141 },
             new byte[] { 158 }, 289982, 289982, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 137 },
             new byte[] { 154 }, 289984, 289984, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 135 },
             new byte[] { 152 }, 289986, 289986, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 4 },
             new byte[] { 25 }, 290008, 290008, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 241, 1, 226 },
             new byte[] { 5, 2, 246 }, 290010, 290012, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 210 },
             new byte[] { 230 }, 290014, 290014, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 195 },
             new byte[] { 215 }, 290016, 290016, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 189 },
             new byte[] { 209 }, 290018, 290018, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 182 },
             new byte[] { 202 }, 290020, 290020, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 179 },
             new byte[] { 199 }, 290022, 290022, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 57 },
             new byte[] { 80 }, 290044, 290044, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 34 },
             new byte[] { 57 }, 290046, 290046, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16 },
             new byte[] { 38 }, 290048, 290048, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 253, 1, 236, 1, 229 },
             new byte[] { 19, 2, 2, 2, 251 }, 290050, 290054, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 222 },
             new byte[] { 245 }, 290056, 290056, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 220 },
             new byte[] { 243 }, 290058, 290058, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 141 },
             new byte[] { 167 }, 290080, 290080, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 106 },
             new byte[] { 132 }, 290082, 290082, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 77 },
             new byte[] { 102 }, 290084, 290084, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 51 },
             new byte[] { 76 }, 290086, 290086, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 31 },
             new byte[] { 56 }, 290088, 290088, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 20 },
             new byte[] { 46 }, 290090, 290090, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 6 },
             new byte[] { 32 }, 290092, 290092, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 1 },
             new byte[] { 27 }, 290094, 290094, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 253, 2, 208 },
             new byte[] { 28, 3, 238 }, 290116, 290118, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 172 },
             new byte[] { 202 }, 290120, 290120, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 139 },
             new byte[] { 169 }, 290122, 290122, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 110 },
             new byte[] { 140 }, 290124, 290124, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 93 },
             new byte[] { 123 }, 290126, 290126, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 74 },
             new byte[] { 105 }, 290128, 290128, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 65 },
             new byte[] { 96 }, 290130, 290130, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 146 },
             new byte[] { 183 }, 290152, 290152, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 85 },
             new byte[] { 121 }, 290154, 290154, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 34 },
             new byte[] { 70 }, 290156, 290156, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 245, 2, 208 },
             new byte[] { 25, 3, 244 }, 290158, 290160, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 182 },
             new byte[] { 218 }, 290162, 290162, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 157 },
             new byte[] { 194 }, 290164, 290164, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 145 },
             new byte[] { 183 }, 290166, 290166, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 62 },
             new byte[] { 105 }, 290188, 290188, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 246, 3, 182 },
             new byte[] { 33, 4, 225 }, 290190, 290192, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 124 },
             new byte[] { 167 }, 290194, 290194, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 75 },
             new byte[] { 118 }, 290196, 290196, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 39 },
             new byte[] { 83 }, 290198, 290198, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 3 },
             new byte[] { 47 }, 290200, 290200, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 243, 2 },
             new byte[] { 32, 3 }, 290202, 290203, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 206 },
             new byte[] { 255 }, 290224, 290224, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 133 },
             new byte[] { 183 }, 290226, 290226, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 69 },
             new byte[] { 120 }, 290228, 290228, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 8 },
             new byte[] { 59 }, 290230, 290230, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 209, 3, 164 },
             new byte[] { 5, 4, 216 }, 290232, 290234, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 117 },
             new byte[] { 170 }, 290236, 290236, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 95 },
             new byte[] { 149 }, 290238, 290238, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 96 },
             new byte[] { 151 }, 290260, 290260, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 1 },
             new byte[] { 57 }, 290262, 290262, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 190 },
             new byte[] { 247 }, 290264, 290264, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 128 },
             new byte[] { 187 }, 290266, 290266, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 72 },
             new byte[] { 132 }, 290268, 290268, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 26 },
             new byte[] { 87 }, 290270, 290270, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 233, 3, 209, 3 },
             new byte[] { 39, 4, 17, 4 }, 290272, 290275, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 115 },
             new byte[] { 181 }, 290296, 290296, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 11 },
             new byte[] { 79 }, 290298, 290298, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 190, 5, 121 },
             new byte[] { 5, 6, 194 }, 290300, 290302, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 56 },
             new byte[] { 131 }, 290304, 290304, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 2 },
             new byte[] { 79 }, 290306, 290306, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 206, 4, 180, 4 },
             new byte[] { 29, 5, 7, 5 }, 290308, 290311, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 147 },
             new byte[] { 225 }, 290332, 290332, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 20 },
             new byte[] { 101 }, 290334, 290334, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 183, 6, 100 },
             new byte[] { 11, 7, 187 }, 290336, 290338, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 26 },
             new byte[] { 117 }, 290340, 290340, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 222, 5, 166, 5, 135 },
             new byte[] { 60, 6, 7, 6, 236 }, 290342, 290346, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 206, 8, 55 },
             new byte[] { 40, 9, 149 }, 290368, 290370, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 199, 7, 100 },
             new byte[] { 42, 8, 203 }, 290372, 290374, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 10 },
             new byte[] { 117 }, 290376, 290376, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 191, 6, 123 },
             new byte[] { 46, 7, 238 }, 290378, 290380, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 87 },
             new byte[] { 208 }, 290382, 290382, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 61 },
             new byte[] { 176 }, 290404, 290404, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 145, 10, 10 },
             new byte[] { 12, 11, 140 }, 290406, 290408, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 142, 9, 28 },
             new byte[] { 23, 10, 171 }, 290410, 290412, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 185, 8, 87 },
             new byte[] { 78, 9, 240 }, 290414, 290416, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 29 },
             new byte[] { 189 }, 290418, 290418, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 152, 14, 183, 13, 8 },
             new byte[] { 45, 15, 88, 14, 180 }, 290440, 290444, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 109, 12, 229, 11, 110, 11, 245, 10, 149, 10 },
             new byte[] { 35, 13, 164, 12, 55, 12, 197, 11, 110, 11 }, 290446, 290455, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 159 },
             new byte[] { 176 }, 290800, 290800, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 145 },
             new byte[] { 161 }, 290802, 290802, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 132 },
             new byte[] { 148 }, 290804, 290804, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 118 },
             new byte[] { 133 }, 290806, 290806, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 106 },
             new byte[] { 120 }, 290808, 290808, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 103 },
             new byte[] { 117 }, 290810, 290810, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 101 },
             new byte[] { 115 }, 290812, 290812, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 100 },
             new byte[] { 114 }, 290814, 290814, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 208 },
             new byte[] { 227 }, 290836, 290836, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 190 },
             new byte[] { 208 }, 290838, 290838, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 175 },
             new byte[] { 193 }, 290840, 290840, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 160 },
             new byte[] { 177 }, 290842, 290842, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 146 },
             new byte[] { 163 }, 290844, 290844, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 141 },
             new byte[] { 158 }, 290846, 290846, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 137 },
             new byte[] { 154 }, 290848, 290848, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 135 },
             new byte[] { 152 }, 290850, 290850, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 4 },
             new byte[] { 25 }, 290872, 290872, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 241, 1, 226 },
             new byte[] { 5, 2, 246 }, 290874, 290876, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 210 },
             new byte[] { 230 }, 290878, 290878, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 195 },
             new byte[] { 215 }, 290880, 290880, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 189 },
             new byte[] { 209 }, 290882, 290882, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 182 },
             new byte[] { 202 }, 290884, 290884, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 179 },
             new byte[] { 199 }, 290886, 290886, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 57 },
             new byte[] { 80 }, 290908, 290908, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 34 },
             new byte[] { 57 }, 290910, 290910, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16 },
             new byte[] { 38 }, 290912, 290912, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 253, 1, 236, 1, 229 },
             new byte[] { 19, 2, 2, 2, 251 }, 290914, 290918, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 222 },
             new byte[] { 245 }, 290920, 290920, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 220 },
             new byte[] { 243 }, 290922, 290922, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 141 },
             new byte[] { 167 }, 290944, 290944, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 106 },
             new byte[] { 132 }, 290946, 290946, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 77 },
             new byte[] { 102 }, 290948, 290948, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 51 },
             new byte[] { 76 }, 290950, 290950, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 31 },
             new byte[] { 56 }, 290952, 290952, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 20 },
             new byte[] { 46 }, 290954, 290954, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 6 },
             new byte[] { 32 }, 290956, 290956, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 1 },
             new byte[] { 27 }, 290958, 290958, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 253, 2, 208 },
             new byte[] { 28, 3, 238 }, 290980, 290982, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 172 },
             new byte[] { 202 }, 290984, 290984, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 139 },
             new byte[] { 169 }, 290986, 290986, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 110 },
             new byte[] { 140 }, 290988, 290988, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 93 },
             new byte[] { 123 }, 290990, 290990, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 74 },
             new byte[] { 105 }, 290992, 290992, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 65 },
             new byte[] { 96 }, 290994, 290994, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 146 },
             new byte[] { 183 }, 291016, 291016, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 85 },
             new byte[] { 121 }, 291018, 291018, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 34 },
             new byte[] { 70 }, 291020, 291020, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 245, 2, 208 },
             new byte[] { 25, 3, 244 }, 291022, 291024, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 182 },
             new byte[] { 218 }, 291026, 291026, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 157 },
             new byte[] { 194 }, 291028, 291028, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 145 },
             new byte[] { 183 }, 291030, 291030, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 62 },
             new byte[] { 105 }, 291052, 291052, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 246, 3, 182 },
             new byte[] { 33, 4, 225 }, 291054, 291056, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 124 },
             new byte[] { 167 }, 291058, 291058, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 75 },
             new byte[] { 118 }, 291060, 291060, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 39 },
             new byte[] { 83 }, 291062, 291062, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 3 },
             new byte[] { 47 }, 291064, 291064, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 243, 2 },
             new byte[] { 32, 3 }, 291066, 291067, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 206 },
             new byte[] { 255 }, 291088, 291088, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 133 },
             new byte[] { 183 }, 291090, 291090, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 69 },
             new byte[] { 120 }, 291092, 291092, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 8 },
             new byte[] { 59 }, 291094, 291094, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 209, 3, 164 },
             new byte[] { 5, 4, 216 }, 291096, 291098, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 117 },
             new byte[] { 170 }, 291100, 291100, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 95 },
             new byte[] { 149 }, 291102, 291102, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 96 },
             new byte[] { 151 }, 291124, 291124, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 1 },
             new byte[] { 57 }, 291126, 291126, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 190 },
             new byte[] { 247 }, 291128, 291128, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 128 },
             new byte[] { 187 }, 291130, 291130, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 72 },
             new byte[] { 132 }, 291132, 291132, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 26 },
             new byte[] { 87 }, 291134, 291134, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 233, 3, 209, 3 },
             new byte[] { 39, 4, 17, 4 }, 291136, 291139, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 115 },
             new byte[] { 181 }, 291160, 291160, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 11 },
             new byte[] { 79 }, 291162, 291162, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 190, 5, 121 },
             new byte[] { 5, 6, 194 }, 291164, 291166, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 56 },
             new byte[] { 131 }, 291168, 291168, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 2 },
             new byte[] { 79 }, 291170, 291170, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 206, 4, 180, 4 },
             new byte[] { 29, 5, 7, 5 }, 291172, 291175, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 147 },
             new byte[] { 225 }, 291196, 291196, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 20 },
             new byte[] { 101 }, 291198, 291198, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 183, 6, 100 },
             new byte[] { 11, 7, 187 }, 291200, 291202, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 26 },
             new byte[] { 117 }, 291204, 291204, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 222, 5, 166, 5, 135 },
             new byte[] { 60, 6, 7, 6, 236 }, 291206, 291210, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 206, 8, 55 },
             new byte[] { 40, 9, 149 }, 291232, 291234, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 199, 7, 100 },
             new byte[] { 42, 8, 203 }, 291236, 291238, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 10 },
             new byte[] { 117 }, 291240, 291240, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 191, 6, 123 },
             new byte[] { 46, 7, 238 }, 291242, 291244, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 87 },
             new byte[] { 208 }, 291246, 291246, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 61 },
             new byte[] { 176 }, 291268, 291268, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 145, 10, 10 },
             new byte[] { 12, 11, 140 }, 291270, 291272, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 142, 9, 28 },
             new byte[] { 23, 10, 171 }, 291274, 291276, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 185, 8, 87 },
             new byte[] { 78, 9, 240 }, 291278, 291280, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 29 },
             new byte[] { 189 }, 291282, 291282, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 152, 14, 183, 13, 8 },
             new byte[] { 45, 15, 88, 14, 180 }, 291304, 291308, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 109, 12, 229, 11, 110, 11, 245, 10, 149, 10 },
             new byte[] { 35, 13, 164, 12, 55, 12, 197, 11, 110, 11 }, 291310, 291319, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 126 },
             new byte[] { 195 }, 303832, 303832, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 126 },
             new byte[] { 195 }, 303834, 303834, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 141 },
             new byte[] { 211 }, 303836, 303836, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 141 },
             new byte[] { 211 }, 303838, 303838, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 141 },
             new byte[] { 211 }, 303840, 303840, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 141 },
             new byte[] { 211 }, 303842, 303842, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 176 },
             new byte[] { 248 }, 303844, 303844, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 176 },
             new byte[] { 248 }, 303846, 303846, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 176 },
             new byte[] { 248 }, 303848, 303848, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 176 },
             new byte[] { 248 }, 303850, 303850, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 58 },
             new byte[] { 169 }, 303852, 303852, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 58 },
             new byte[] { 169 }, 303854, 303854, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 73 },
             new byte[] { 185 }, 303856, 303856, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 73 },
             new byte[] { 185 }, 303858, 303858, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 73 },
             new byte[] { 185 }, 303860, 303860, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 73 },
             new byte[] { 185 }, 303862, 303862, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 108 },
             new byte[] { 222 }, 303864, 303864, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 108 },
             new byte[] { 222 }, 303866, 303866, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 108 },
             new byte[] { 222 }, 303868, 303868, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 108 },
             new byte[] { 222 }, 303870, 303870, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 77 },
             new byte[] { 205 }, 303872, 303872, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 132, 8, 202, 8, 202, 8, 202, 8, 202, 8, 202, 8, 202, 8, 202, 8, 202, 8, 102 },
             new byte[] { 7, 9, 81, 9, 81, 9, 81, 9, 81, 9, 81, 9, 81, 9, 81, 9, 81, 9, 231 }, 303874, 303892, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 192, 8, 254, 8, 46 },
             new byte[] { 70, 9, 136, 9, 187 }, 303894, 303898, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 46 },
             new byte[] { 187 }, 303900, 303900, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 46 },
             new byte[] { 187 }, 303902, 303902, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 46 },
             new byte[] { 187 }, 303904, 303904, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 46 },
             new byte[] { 187 }, 303906, 303906, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 46 },
             new byte[] { 187 }, 303908, 303908, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 46 },
             new byte[] { 187 }, 303910, 303910, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 92 },
             new byte[] { 220 }, 303912, 303912, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 185, 8, 252, 8, 69 },
             new byte[] { 63, 9, 134, 9, 211 }, 303914, 303918, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 101 },
             new byte[] { 245 }, 303920, 303920, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 126, 9, 126, 9, 126, 9, 126, 9, 166, 9, 92 },
             new byte[] { 16, 10, 16, 10, 16, 10, 16, 10, 58, 10, 220 }, 303922, 303932, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 165, 8, 227, 8, 56 },
             new byte[] { 42, 9, 108, 9, 198 }, 303934, 303938, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 106 },
             new byte[] { 251 }, 303940, 303940, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 146, 9, 196, 9, 196, 9, 196, 9, 246, 9, 65 },
             new byte[] { 37, 10, 90, 10, 90, 10, 90, 10, 143, 10, 192 }, 303942, 303952, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 142, 8, 212, 8, 36 },
             new byte[] { 17, 9, 92, 9, 176 }, 303954, 303958, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 78 },
             new byte[] { 221 }, 303960, 303960, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 119, 9, 191, 9, 246, 9, 246, 9, 246, 9, 42 },
             new byte[] { 8, 10, 85, 10, 143, 10, 143, 10, 143, 10, 167 }, 303962, 303972, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 117 },
             new byte[] { 247 }, 303974, 303974, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 192, 8, 6 },
             new byte[] { 70, 9, 145 }, 303976, 303978, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 52 },
             new byte[] { 193 }, 303980, 303980, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 86 },
             new byte[] { 229 }, 303982, 303982, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 156, 9, 229, 9, 27 },
             new byte[] { 48, 10, 125, 10, 182 }, 303984, 303988, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 40 },
             new byte[] { 196 }, 303990, 303990, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 2 },
             new byte[] { 125 }, 303992, 303992, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 62 },
             new byte[] { 189 }, 303994, 303994, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 139, 8, 211, 8, 255, 8, 28 },
             new byte[] { 14, 9, 91, 9, 137, 9, 168 }, 303996, 304002, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 96 },
             new byte[] { 240 }, 304004, 304004, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 181, 9, 10 },
             new byte[] { 74, 10, 164 }, 304006, 304008, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 40 },
             new byte[] { 196 }, 304010, 304010, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 208, 7, 22 },
             new byte[] { 72, 8, 146 }, 304012, 304014, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 97 },
             new byte[] { 226 }, 304016, 304016, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 159, 8, 197, 8, 229, 8, 36 },
             new byte[] { 35, 9, 76, 9, 110, 9, 176 }, 304018, 304024, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 121, 9, 223, 9, 40 },
             new byte[] { 11, 10, 119, 10, 196 }, 304026, 304030, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 173, 7, 246, 7, 47 },
             new byte[] { 35, 8, 112, 8, 173 }, 304032, 304036, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 105 },
             new byte[] { 234 }, 304038, 304038, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 147, 8, 172, 8, 242, 8, 66 },
             new byte[] { 23, 9, 49, 9, 123, 9, 208 }, 304040, 304046, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 166, 9, 90 },
             new byte[] { 58, 10, 249 }, 304048, 304050, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 120 },
             new byte[] { 235 }, 304052, 304052, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 193, 7, 12 },
             new byte[] { 56, 8, 136 }, 304054, 304056, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 69 },
             new byte[] { 196 }, 304058, 304058, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 96 },
             new byte[] { 225 }, 304060, 304060, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 130, 8, 202, 8, 21 },
             new byte[] { 5, 9, 81, 9, 161 }, 304062, 304066, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 106 },
             new byte[] { 251 }, 304068, 304068, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 90 },
             new byte[] { 249 }, 304070, 304070, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 68 },
             new byte[] { 180 }, 304072, 304072, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 158, 7, 228, 7, 15 },
             new byte[] { 19, 8, 93, 8, 139 }, 304074, 304078, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 55 },
             new byte[] { 181 }, 304080, 304080, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 97 },
             new byte[] { 226 }, 304082, 304082, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 167, 8, 232, 8, 66 },
             new byte[] { 44, 9, 113, 9, 208 }, 304084, 304088, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 226, 9, 38 },
             new byte[] { 122, 10, 148 }, 304090, 304092, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 120 },
             new byte[] { 235 }, 304094, 304094, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 188, 7, 222, 7, 15 },
             new byte[] { 51, 8, 87, 8, 139 }, 304096, 304100, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 55 },
             new byte[] { 181 }, 304102, 304102, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 112 },
             new byte[] { 242 }, 304104, 304104, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 190, 8, 13 },
             new byte[] { 68, 9, 152 }, 304106, 304108, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 196, 9, 8 },
             new byte[] { 90, 10, 116 }, 304110, 304112, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 83 },
             new byte[] { 196 }, 304114, 304114, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 133 },
             new byte[] { 249 }, 304116, 304116, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 173, 7, 215, 7, 251, 7, 59 },
             new byte[] { 35, 8, 79, 8, 118, 8, 185 }, 304118, 304124, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 125 },
             new byte[] { 255 }, 304126, 304126, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 190, 8, 59 },
             new byte[] { 68, 9, 201 }, 304128, 304130, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 217, 6, 23 },
             new byte[] { 66, 7, 132 }, 304132, 304134, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 78 },
             new byte[] { 190 }, 304136, 304136, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 125 },
             new byte[] { 240 }, 304138, 304138, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 163, 7, 193, 7, 251, 7, 45 },
             new byte[] { 24, 8, 56, 8, 118, 8, 171 }, 304140, 304146, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 92 },
             new byte[] { 220 }, 304148, 304148, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 164, 8 },
             new byte[] { 41, 9 }, 304150, 304151, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 246, 9, 246, 9 },
             new byte[] { 184, 11, 184, 11 }, 304976, 304979, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 246, 9, 246, 9 },
             new byte[] { 184, 11, 184, 11 }, 304996, 304999, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 10, 10, 0, 10, 222, 8, 162, 8, 51, 9 },
             new byte[] { 184, 11, 184, 11, 184, 11, 184, 11, 184, 11 }, 305010, 305019, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 51 },
             new byte[] { 105 }, 305826, 305826, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 76 },
             new byte[] { 131 }, 305828, 305828, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 156 },
             new byte[] { 215 }, 305830, 305830, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 14 },
             new byte[] { 79 }, 305832, 305832, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 113 },
             new byte[] { 183 }, 305834, 305834, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 244, 5, 132 },
             new byte[] { 64, 6, 215 }, 305836, 305838, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 22 },
             new byte[] { 113 }, 305840, 305840, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 208, 7, 119 },
             new byte[] { 52, 8, 227 }, 305842, 305844, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 202, 8, 227, 8, 227, 8 },
             new byte[] { 59, 9, 85, 9, 85, 9 }, 305846, 305851, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 66 },
             new byte[] { 121 }, 305858, 305858, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 96 },
             new byte[] { 152 }, 305860, 305860, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 197, 4, 65 },
             new byte[] { 2, 5, 132 }, 305862, 305864, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 186, 5, 82 },
             new byte[] { 3, 6, 163 }, 305866, 305868, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 241, 6, 216, 7, 144 },
             new byte[] { 74, 7, 60, 8, 254 }, 305870, 305874, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 9 },
             new byte[] { 125 }, 305876, 305876, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 66 },
             new byte[] { 185 }, 305878, 305878, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 66 },
             new byte[] { 185 }, 305880, 305880, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 66 },
             new byte[] { 185 }, 305882, 305882, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 101 },
             new byte[] { 157 }, 305890, 305890, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 146 },
             new byte[] { 205 }, 305892, 305892, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 246, 4, 115 },
             new byte[] { 54, 5, 185 }, 305894, 305896, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 250, 5, 168 },
             new byte[] { 71, 6, 253 }, 305898, 305900, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 93 },
             new byte[] { 187 }, 305902, 305902, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 54 },
             new byte[] { 159 }, 305904, 305904, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224, 8, 94 },
             new byte[] { 82, 9, 214 }, 305906, 305908, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 146, 9, 146, 9, 146, 9 },
             new byte[] { 13, 10, 13, 10, 13, 10 }, 305910, 305915, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 146 },
             new byte[] { 205 }, 305922, 305922, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 166 },
             new byte[] { 226 }, 305924, 305924, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 28 },
             new byte[] { 93 }, 305926, 305926, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 170 },
             new byte[] { 243 }, 305928, 305928, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 77 },
             new byte[] { 158 }, 305930, 305930, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 12 },
             new byte[] { 102 }, 305932, 305932, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 208, 7, 124 },
             new byte[] { 52, 8, 233 }, 305934, 305936, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 44 },
             new byte[] { 161 }, 305938, 305938, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 162, 9, 179, 9, 196, 9, 196, 9 },
             new byte[] { 29, 10, 47, 10, 65, 10, 65, 10 }, 305940, 305947, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 176 },
             new byte[] { 236 }, 305954, 305954, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 225, 4, 55 },
             new byte[] { 31, 5, 122 }, 305956, 305958, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 215, 5, 130 },
             new byte[] { 34, 6, 213 }, 305960, 305962, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 86 },
             new byte[] { 180 }, 305964, 305964, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16 },
             new byte[] { 119 }, 305966, 305966, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 192, 8, 106 },
             new byte[] { 48, 9, 227 }, 305968, 305970, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 216, 9, 10 },
             new byte[] { 86, 10, 139 }, 305972, 305974, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 10 },
             new byte[] { 139 }, 305976, 305976, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 10 },
             new byte[] { 139 }, 305978, 305978, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 176 },
             new byte[] { 236 }, 305986, 305986, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 26 },
             new byte[] { 91 }, 305988, 305988, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 185, 5, 121 },
             new byte[] { 2, 6, 204 }, 305990, 305992, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 214, 6, 118 },
             new byte[] { 46, 7, 214 }, 305994, 305996, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 79 },
             new byte[] { 185 }, 305998, 305998, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 26 },
             new byte[] { 143 }, 306000, 306000, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 221, 9, 55 },
             new byte[] { 91, 10, 186 }, 306002, 306004, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 60 },
             new byte[] { 191 }, 306006, 306006, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 60 },
             new byte[] { 191 }, 306008, 306008, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 60 },
             new byte[] { 191 }, 306010, 306010, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 176 },
             new byte[] { 236 }, 306018, 306018, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 49 },
             new byte[] { 115 }, 306020, 306020, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 203, 5, 139 },
             new byte[] { 21, 6, 223 }, 306022, 306024, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 49 },
             new byte[] { 141 }, 306026, 306026, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 146 },
             new byte[] { 243 }, 306028, 306028, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 97 },
             new byte[] { 204 }, 306030, 306030, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 108 },
             new byte[] { 229 }, 306032, 306032, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 15 },
             new byte[] { 144 }, 306034, 306034, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 50 },
             new byte[] { 181 }, 306036, 306036, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 50 },
             new byte[] { 181 }, 306038, 306038, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 50 },
             new byte[] { 181 }, 306040, 306040, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 50 },
             new byte[] { 181 }, 306042, 306042, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 234, 4, 103 },
             new byte[] { 41, 5, 172 }, 306050, 306052, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 31 },
             new byte[] { 109 }, 306054, 306054, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 189, 6, 95 },
             new byte[] { 19, 7, 189 }, 306056, 306058, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 141 },
             new byte[] { 238 }, 306060, 306060, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 111 },
             new byte[] { 219 }, 306062, 306062, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 106 },
             new byte[] { 227 }, 306064, 306064, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 40 },
             new byte[] { 170 }, 306066, 306066, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 40 },
             new byte[] { 170 }, 306068, 306068, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 40 },
             new byte[] { 170 }, 306070, 306070, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 40 },
             new byte[] { 170 }, 306072, 306072, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 40 },
             new byte[] { 170 }, 306074, 306074, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 53 },
             new byte[] { 120 }, 306082, 306082, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 168 },
             new byte[] { 240 }, 306084, 306084, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 77 },
             new byte[] { 158 }, 306086, 306086, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 196, 6, 119 },
             new byte[] { 27, 7, 215 }, 306088, 306090, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 34 },
             new byte[] { 138 }, 306092, 306092, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 46 },
             new byte[] { 164 }, 306094, 306094, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 126 },
             new byte[] { 248 }, 306096, 306096, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 40 },
             new byte[] { 170 }, 306098, 306098, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 40 },
             new byte[] { 170 }, 306100, 306100, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 40 },
             new byte[] { 170 }, 306102, 306102, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 40 },
             new byte[] { 170 }, 306104, 306104, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 40 },
             new byte[] { 170 }, 306106, 306106, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 103 },
             new byte[] { 172 }, 306114, 306114, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 218, 5, 77 },
             new byte[] { 37, 6, 158 }, 306116, 306118, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 196, 6, 119 },
             new byte[] { 27, 7, 215 }, 306120, 306122, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 34 },
             new byte[] { 138 }, 306124, 306124, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 66 },
             new byte[] { 185 }, 306126, 306126, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 156, 9, 196, 9, 40 },
             new byte[] { 23, 10, 65, 10, 170 }, 306128, 306132, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 40 },
             new byte[] { 170 }, 306134, 306134, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 40 },
             new byte[] { 170 }, 306136, 306136, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 40 },
             new byte[] { 170 }, 306138, 306138, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 104 },
             new byte[] { 173 }, 306146, 306146, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 216, 5, 82 },
             new byte[] { 35, 6, 163 }, 306148, 306150, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 202, 6, 121 },
             new byte[] { 33, 7, 217 }, 306152, 306154, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 33 },
             new byte[] { 137 }, 306156, 306156, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 96 },
             new byte[] { 216 }, 306158, 306158, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 96 },
             new byte[] { 216 }, 306160, 306160, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 96 },
             new byte[] { 216 }, 306162, 306162, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 96 },
             new byte[] { 216 }, 306164, 306164, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 96 },
             new byte[] { 216 }, 306166, 306166, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 96 },
             new byte[] { 216 }, 306168, 306168, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 96 },
             new byte[] { 216 }, 306170, 306170, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 25 },
             new byte[] { 180 }, 306888, 306888, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 75 },
             new byte[] { 233 }, 306890, 306890, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 75 },
             new byte[] { 233 }, 306892, 306892, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 75 },
             new byte[] { 233 }, 306894, 306894, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 75 },
             new byte[] { 233 }, 306896, 306896, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 75 },
             new byte[] { 233 }, 306898, 306898, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 5 },
             new byte[] { 159 }, 306900, 306900, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 191, 9, 94 },
             new byte[] { 85, 10, 238 }, 306902, 306904, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 199, 8, 25 },
             new byte[] { 78, 9, 180 }, 306906, 306908, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 75 },
             new byte[] { 233 }, 306910, 306910, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 75 },
             new byte[] { 233 }, 306912, 306912, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 75 },
             new byte[] { 233 }, 306914, 306914, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 75 },
             new byte[] { 233 }, 306916, 306916, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 75 },
             new byte[] { 233 }, 306918, 306918, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 5 },
             new byte[] { 159 }, 306920, 306920, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 191, 9, 94 },
             new byte[] { 85, 10, 238 }, 306922, 306924, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 199, 8, 25 },
             new byte[] { 78, 9, 180 }, 306926, 306928, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 75 },
             new byte[] { 233 }, 306930, 306930, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 75 },
             new byte[] { 233 }, 306932, 306932, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 75 },
             new byte[] { 233 }, 306934, 306934, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 75 },
             new byte[] { 233 }, 306936, 306936, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 75 },
             new byte[] { 233 }, 306938, 306938, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 5 },
             new byte[] { 159 }, 306940, 306940, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 191, 9, 94 },
             new byte[] { 85, 10, 238 }, 306942, 306944, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 199, 8, 25 },
             new byte[] { 78, 9, 180 }, 306946, 306948, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 75 },
             new byte[] { 233 }, 306950, 306950, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 75 },
             new byte[] { 233 }, 306952, 306952, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 75 },
             new byte[] { 233 }, 306954, 306954, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 75 },
             new byte[] { 233 }, 306956, 306956, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 75 },
             new byte[] { 233 }, 306958, 306958, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 5 },
             new byte[] { 159 }, 306960, 306960, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 191, 9, 94 },
             new byte[] { 85, 10, 238 }, 306962, 306964, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 199, 8, 25 },
             new byte[] { 78, 9, 180 }, 306966, 306968, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 75 },
             new byte[] { 233 }, 306970, 306970, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 75 },
             new byte[] { 233 }, 306972, 306972, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 75 },
             new byte[] { 233 }, 306974, 306974, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 75 },
             new byte[] { 233 }, 306976, 306976, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 75 },
             new byte[] { 233 }, 306978, 306978, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 5 },
             new byte[] { 159 }, 306980, 306980, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 191, 9, 94 },
             new byte[] { 85, 10, 238 }, 306982, 306984, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 199, 8, 5 },
             new byte[] { 78, 9, 159 }, 306986, 306988, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 40 },
             new byte[] { 196 }, 306990, 306990, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 40 },
             new byte[] { 196 }, 306992, 306992, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 15 },
             new byte[] { 170 }, 306994, 306994, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 5 },
             new byte[] { 159 }, 306996, 306996, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 10 },
             new byte[] { 164 }, 306998, 306998, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 196, 9, 106 },
             new byte[] { 90, 10, 251 }, 307000, 307002, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 46 },
             new byte[] { 187 }, 307004, 307004, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 152, 8, 244, 9, 37 },
             new byte[] { 28, 9, 141, 10, 193 }, 307006, 307010, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 38 },
             new byte[] { 194 }, 307012, 307012, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 196, 9, 193, 8, 164, 8, 56 },
             new byte[] { 90, 10, 71, 9, 41, 9, 198 }, 307014, 307020, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 252, 8, 142, 8, 52 },
             new byte[] { 134, 9, 17, 9, 178 }, 307022, 307026, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 244, 9, 37 },
             new byte[] { 141, 10, 193 }, 307028, 307030, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 38 },
             new byte[] { 194 }, 307032, 307032, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 196, 9, 193, 8, 164, 8, 56 },
             new byte[] { 90, 10, 71, 9, 41, 9, 198 }, 307034, 307040, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 252, 8, 142, 8, 52 },
             new byte[] { 134, 9, 17, 9, 178 }, 307042, 307046, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 244, 9, 37 },
             new byte[] { 141, 10, 193 }, 307048, 307050, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 38 },
             new byte[] { 194 }, 307052, 307052, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 196, 9, 193, 8, 164, 8, 56 },
             new byte[] { 90, 10, 71, 9, 41, 9, 198 }, 307054, 307060, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 252, 8, 142, 8, 52 },
             new byte[] { 134, 9, 17, 9, 178 }, 307062, 307066, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 244, 9, 37 },
             new byte[] { 141, 10, 193 }, 307068, 307070, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 38 },
             new byte[] { 194 }, 307072, 307072, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 196, 9, 193, 8, 164, 8, 56 },
             new byte[] { 90, 10, 71, 9, 41, 9, 198 }, 307074, 307080, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 252, 8, 142, 8, 52 },
             new byte[] { 134, 9, 17, 9, 178 }, 307082, 307086, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 56 },
             new byte[] { 110 }, 307894, 307894, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 84 },
             new byte[] { 139 }, 307896, 307896, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 149 },
             new byte[] { 208 }, 307898, 307898, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 214, 4, 90 },
             new byte[] { 20, 5, 159 }, 307900, 307902, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 180 },
             new byte[] { 253 }, 307904, 307904, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 84 },
             new byte[] { 165 }, 307906, 307906, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 244, 6, 108 },
             new byte[] { 77, 7, 203 }, 307908, 307910, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 42 },
             new byte[] { 147 }, 307912, 307912, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 252, 8, 101 },
             new byte[] { 111, 9, 221 }, 307914, 307916, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 101 },
             new byte[] { 221 }, 307918, 307918, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 84 },
             new byte[] { 139 }, 307926, 307926, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 135 },
             new byte[] { 193 }, 307928, 307928, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 199, 4, 48 },
             new byte[] { 4, 5, 114 }, 307930, 307932, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 229, 5, 54 },
             new byte[] { 48, 6, 134 }, 307934, 307936, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 234, 6, 188, 7, 2 },
             new byte[] { 67, 7, 31, 8, 105 }, 307938, 307942, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 122 },
             new byte[] { 231 }, 307944, 307944, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 76 },
             new byte[] { 195 }, 307946, 307946, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 231, 9, 231, 9 },
             new byte[] { 102, 10, 102, 10 }, 307948, 307951, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 162 },
             new byte[] { 221 }, 307958, 307958, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 251, 4, 78 },
             new byte[] { 59, 5, 146 }, 307960, 307962, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 232, 5, 119 },
             new byte[] { 52, 6, 202 }, 307964, 307966, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 155 },
             new byte[] { 240 }, 307968, 307968, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 31 },
             new byte[] { 122 }, 307970, 307970, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 158, 7, 20 },
             new byte[] { 0, 8, 123 }, 307972, 307974, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 195, 8, 122 },
             new byte[] { 51, 9, 243 }, 307976, 307978, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 40 },
             new byte[] { 170 }, 307980, 307980, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 40 },
             new byte[] { 170 }, 307982, 307982, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 251, 4, 147 },
             new byte[] { 59, 5, 218 }, 307990, 307992, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 245, 5, 144 },
             new byte[] { 65, 6, 228 }, 307994, 307996, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 9 },
             new byte[] { 99 }, 307998, 307998, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 103 },
             new byte[] { 198 }, 308000, 308000, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 176, 7, 24 },
             new byte[] { 18, 8, 128 }, 308002, 308004, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 152, 8, 36 },
             new byte[] { 6, 9, 153 }, 308006, 308008, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 200, 9, 70 },
             new byte[] { 69, 10, 202 }, 308010, 308012, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 70 },
             new byte[] { 202 }, 308014, 308014, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 64 },
             new byte[] { 131 }, 308022, 308022, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 232, 5, 152 },
             new byte[] { 52, 6, 236 }, 308024, 308026, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 34 },
             new byte[] { 125 }, 308028, 308028, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 139 },
             new byte[] { 236 }, 308030, 308030, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 29 },
             new byte[] { 133 }, 308032, 308032, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 120 },
             new byte[] { 228 }, 308034, 308034, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 205, 8, 36 },
             new byte[] { 62, 9, 153 }, 308036, 308038, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 144, 9, 50 },
             new byte[] { 10, 10, 181 }, 308040, 308042, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 54 },
             new byte[] { 185 }, 308044, 308044, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 54 },
             new byte[] { 185 }, 308046, 308046, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 6 },
             new byte[] { 70 }, 308054, 308054, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 173 },
             new byte[] { 246 }, 308056, 308056, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 95 },
             new byte[] { 177 }, 308058, 308058, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 238, 6, 1 },
             new byte[] { 71, 7, 103 }, 308060, 308062, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 217, 8, 240, 8, 32 },
             new byte[] { 74, 9, 98, 9, 149 }, 308064, 308068, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 106 },
             new byte[] { 227 }, 308070, 308070, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 211, 9, 58 },
             new byte[] { 81, 10, 189 }, 308072, 308074, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 65 },
             new byte[] { 196 }, 308076, 308076, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 65 },
             new byte[] { 196 }, 308078, 308078, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 196, 4, 70 },
             new byte[] { 1, 5, 138 }, 308086, 308088, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 243, 5, 132 },
             new byte[] { 63, 6, 215 }, 308090, 308092, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 32 },
             new byte[] { 123 }, 308094, 308094, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 4 },
             new byte[] { 107 }, 308096, 308096, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 160, 8, 26 },
             new byte[] { 14, 9, 143 }, 308098, 308100, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 97 },
             new byte[] { 217 }, 308102, 308102, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 2 },
             new byte[] { 130 }, 308104, 308104, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 70 },
             new byte[] { 202 }, 308106, 308106, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 70 },
             new byte[] { 202 }, 308108, 308108, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 70 },
             new byte[] { 202 }, 308110, 308110, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 201, 4, 45 },
             new byte[] { 6, 5, 111 }, 308118, 308120, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 223, 5, 114 },
             new byte[] { 42, 6, 197 }, 308122, 308124, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 17 },
             new byte[] { 107 }, 308126, 308126, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 194, 7, 87 },
             new byte[] { 37, 8, 194 }, 308128, 308130, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 1 },
             new byte[] { 116 }, 308132, 308132, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 92 },
             new byte[] { 212 }, 308134, 308134, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 60 },
             new byte[] { 191 }, 308136, 308136, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 120 },
             new byte[] { 254 }, 308138, 308138, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 120 },
             new byte[] { 254 }, 308140, 308140, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 120 },
             new byte[] { 254 }, 308142, 308142, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 216, 4, 40 },
             new byte[] { 22, 5, 106 }, 308150, 308152, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 206, 5, 106 },
             new byte[] { 24, 6, 188 }, 308154, 308156, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 243, 6, 159, 7, 60 },
             new byte[] { 76, 7, 1, 8, 165 }, 308158, 308162, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 235, 8, 57 },
             new byte[] { 93, 9, 188 }, 308164, 308166, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 60 },
             new byte[] { 191 }, 308168, 308168, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 120 },
             new byte[] { 254 }, 308170, 308170, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 120 },
             new byte[] { 254 }, 308172, 308172, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 120 },
             new byte[] { 254 }, 308174, 308174, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 196, 4, 246, 4, 168 },
             new byte[] { 1, 5, 54, 5, 240 }, 308182, 308186, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 67 },
             new byte[] { 147 }, 308188, 308188, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 218, 6, 115 },
             new byte[] { 50, 7, 210 }, 308190, 308192, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 20 },
             new byte[] { 123 }, 308194, 308194, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 197, 8, 28 },
             new byte[] { 53, 9, 157 }, 308196, 308198, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 30 },
             new byte[] { 160 }, 308200, 308200, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 30 },
             new byte[] { 160 }, 308202, 308202, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 30 },
             new byte[] { 160 }, 308204, 308204, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 30 },
             new byte[] { 160 }, 308206, 308206, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 140 },
             new byte[] { 198 }, 308214, 308214, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 244, 4, 144 },
             new byte[] { 51, 5, 215 }, 308216, 308218, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 49 },
             new byte[] { 128 }, 308220, 308220, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 202, 6, 71 },
             new byte[] { 33, 7, 164 }, 308222, 308224, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 243, 7, 145 },
             new byte[] { 89, 8, 255 }, 308226, 308228, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 145 },
             new byte[] { 255 }, 308230, 308230, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 145 },
             new byte[] { 255 }, 308232, 308232, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 145 },
             new byte[] { 255 }, 308234, 308234, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 145 },
             new byte[] { 255 }, 308236, 308236, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 145 },
             new byte[] { 255 }, 308238, 308238, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 58, 8, 154, 8, 250, 8, 97, 9, 200, 9, 64, 9, 183, 8, 169, 8, 57, 9, 222, 8, 210, 8, 172, 9, 134, 10, 207, 10, 24, 11, 124, 10, 223, 9, 125, 10, 68, 10, 90, 10, 229, 8, 222, 9, 214, 10, 42, 11, 76, 11, 0, 11, 130, 10, 243, 10, 120, 10, 177, 10, 212, 8, 218, 9, 223, 10, 18, 11, 69, 11, 244, 10, 163, 10, 37, 11, 163, 10, 130, 10, 148, 8, 203, 9, 1, 11, 43, 11, 84, 11, 3, 11, 178, 10, 74, 11, 213, 10, 190, 10, 123, 8, 198, 9, 16, 11, 54, 11, 92, 11, 23, 11, 209, 10, 137, 11, 42, 11, 14, 11, 133, 8, 216, 9, 42, 11, 76, 11, 110, 11, 77, 11, 44, 11, 207, 11, 149, 11, 154, 11, 140, 8, 223, 9, 49, 11, 104, 11, 159, 11, 145, 11, 130, 11, 28, 12, 3, 12, 28, 12, 158, 8, 216, 9, 17, 11, 95, 11, 172, 11, 173, 11, 174, 11, 81, 12, 86, 12, 138, 12, 181, 8, 200, 9, 219, 10, 71, 11, 179, 11, 192, 11, 204, 11, 108, 12, 151, 12, 208, 12, 212, 8, 204, 9, 195, 10, 72, 11, 204, 11, 213, 11, 222, 11, 141, 12, 178, 12, 2, 13, 52, 9, 0, 10, 204, 10, 75, 11, 201, 11, 205, 11, 209, 11, 113, 12, 160, 12, 228, 12, 186, 9, 67, 10, 203, 10, 67, 11, 187, 11, 185, 11, 182, 11, 63, 12, 141, 12, 208, 12, 58, 10, 139, 10, 219, 10, 39, 11, 115, 11, 99, 11, 82, 11, 251, 11, 11, 12, 31, 12 },
             new byte[] { 73, 10, 193, 10, 56, 11, 185, 11, 58, 12, 144, 11, 229, 10, 211, 10, 135, 11, 22, 11, 7, 11, 23, 12, 40, 13, 131, 13, 222, 13, 27, 13, 87, 12, 28, 13, 213, 12, 241, 12, 30, 11, 86, 12, 140, 13, 244, 13, 31, 14, 192, 13, 35, 13, 176, 13, 22, 13, 93, 13, 9, 11, 81, 12, 151, 13, 215, 13, 22, 14, 177, 13, 76, 13, 238, 13, 76, 13, 35, 13, 185, 10, 62, 12, 193, 13, 246, 13, 41, 14, 196, 13, 94, 13, 29, 14, 138, 13, 110, 13, 154, 10, 56, 12, 212, 13, 4, 14, 51, 14, 221, 13, 133, 13, 107, 14, 244, 13, 210, 13, 166, 10, 78, 12, 244, 13, 31, 14, 74, 14, 32, 14, 247, 13, 195, 14, 122, 14, 129, 14, 175, 10, 87, 12, 253, 13, 66, 14, 135, 14, 117, 14, 98, 14, 35, 15, 4, 15, 35, 15, 198, 10, 78, 12, 213, 13, 55, 14, 151, 14, 152, 14, 154, 14, 101, 15, 107, 15, 173, 15, 226, 10, 58, 12, 146, 13, 25, 14, 160, 14, 176, 14, 191, 14, 135, 15, 189, 15, 4, 16, 9, 11, 63, 12, 116, 13, 26, 14, 191, 14, 202, 14, 213, 14, 176, 15, 223, 15, 67, 16, 129, 11, 128, 12, 127, 13, 30, 14, 187, 14, 192, 14, 197, 14, 141, 15, 200, 15, 29, 16, 41, 12, 212, 12, 126, 13, 20, 14, 170, 14, 167, 14, 163, 14, 79, 15, 176, 15, 4, 16, 200, 12, 46, 13, 146, 13, 241, 13, 80, 14, 60, 14, 38, 14, 250, 14, 14, 15, 39, 15 }, 310008, 310287, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 0, 11, 160, 16, 128, 17, 32, 18, 192, 20, 224, 20, 64, 20, 96, 19, 16, 23, 160, 25, 224, 21 },
             new byte[] { 192, 13, 200, 20, 224, 21, 168, 22, 240, 25, 24, 26, 80, 25, 56, 24, 212, 28, 8, 32, 88, 27 }, 311378, 311399, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 20, 96, 19, 160, 15, 160, 11, 192, 12, 32, 19, 192, 24, 160, 25, 64, 26, 224, 28, 0, 29, 96, 28, 128, 27, 128, 27, 224, 26, 32, 23, 160, 20 },
             new byte[] { 25, 56, 24, 136, 19, 136, 14, 240, 15, 232, 23, 240, 30, 8, 32, 208, 32, 24, 36, 64, 36, 120, 35, 96, 34, 96, 34, 152, 33, 232, 28, 200, 25 }, 311401, 311433, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 20, 64, 16, 64, 12 },
             new byte[] { 25, 80, 20, 80, 15 }, 311435, 311439, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 52, 8, 102, 8, 152, 8, 111, 8, 70, 8, 10, 8, 206, 7, 176, 7, 32, 8, 32, 8, 89, 9, 23, 10, 212, 10, 135, 10, 57, 10, 23, 10, 244, 9, 94, 9, 126, 9, 126, 9, 171, 9, 109, 10, 46, 11, 47, 11, 47, 11, 244, 10, 185, 10, 75, 10, 90, 10, 20, 10, 179, 9, 125, 10, 71, 11, 109, 11, 146, 11, 90, 11, 34, 11, 215, 10, 203, 10, 167, 10, 174, 9, 127, 10, 79, 11, 127, 11, 174, 11, 149, 11, 124, 11, 44, 11, 84, 11, 71, 11, 168, 9, 120, 10, 72, 11, 122, 11, 171, 11, 180, 11, 189, 11, 162, 11, 174, 11, 134, 11, 184, 9, 129, 10, 74, 11, 131, 11, 187, 11, 205, 11, 222, 11 },
             new byte[] { 65, 10, 128, 10, 190, 10, 139, 10, 88, 10, 13, 10, 193, 9, 156, 9, 40, 10, 40, 10, 175, 11, 157, 12, 137, 13, 41, 13, 199, 12, 157, 12, 113, 12, 181, 11, 222, 11, 222, 11, 22, 12, 8, 13, 250, 13, 251, 13, 251, 13, 177, 13, 103, 13, 222, 12, 241, 12, 153, 12, 32, 12, 28, 13, 25, 14, 72, 14, 119, 14, 49, 14, 235, 13, 141, 13, 126, 13, 81, 13, 26, 12, 31, 13, 35, 14, 95, 14, 154, 14, 122, 14, 91, 14, 247, 13, 41, 14, 25, 14, 18, 12, 22, 13, 26, 14, 88, 14, 150, 14, 161, 14, 172, 14, 139, 14, 154, 14, 104, 14, 38, 12, 33, 13, 29, 14, 100, 14, 170, 14, 192, 14, 213, 14 }, 312308, 312441, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 12, 33, 12, 18, 12, 248, 9, 156, 10, 64, 11, 123, 11, 181, 11, 239, 11, 41, 12, 128, 12, 125, 12, 153, 12, 103, 10, 217, 10, 74, 11, 114, 11, 154, 11, 9, 12, 120, 12, 161, 12, 178, 12, 248, 12, 175, 10, 240, 10, 49, 11, 81, 11, 112, 11, 245, 11, 121, 12, 161, 12, 208, 12, 97, 13, 195, 10, 244, 10, 36, 11, 59, 11, 81, 11, 227, 11, 116, 12, 128, 12, 196, 12, 142, 13, 137, 10, 204, 10, 14, 11, 39, 11, 64, 11, 217, 11, 113, 12, 128, 12, 192, 12, 102, 13, 3, 10, 125, 10, 247, 10, 28, 11, 64, 11, 183, 11, 46, 12, 53, 12, 118, 12, 248, 12, 49, 8, 131, 8, 212, 8, 31, 9, 106, 9, 195, 9, 27, 10, 103, 10, 183, 10, 34, 11 },
             new byte[] { 15, 41, 15, 23, 15, 118, 12, 67, 13, 16, 14, 90, 14, 162, 14, 235, 14, 51, 15, 160, 15, 156, 15, 191, 15, 1, 13, 143, 13, 29, 14, 79, 14, 129, 14, 11, 15, 150, 15, 201, 15, 223, 15, 54, 16, 91, 13, 172, 13, 253, 13, 37, 14, 76, 14, 242, 14, 151, 15, 201, 15, 4, 16, 185, 16, 116, 13, 177, 13, 237, 13, 10, 14, 37, 14, 220, 14, 145, 15, 160, 15, 245, 15, 242, 16, 43, 13, 127, 13, 210, 13, 241, 13, 16, 14, 207, 14, 141, 15, 160, 15, 240, 15, 192, 16, 132, 12, 28, 13, 181, 13, 227, 13, 16, 14, 165, 14, 57, 15, 66, 15, 148, 15, 54, 16, 61, 10, 164, 10, 9, 11, 103, 11, 197, 11, 52, 12, 162, 12, 1, 13, 101, 13, 235, 13 }, 312443, 312587, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 0, 11, 64, 16, 32, 21, 224, 21, 0, 22, 32, 22, 128, 21, 192, 20, 208, 23, 160, 25, 64, 25 },
             new byte[] { 192, 13, 80, 20, 104, 26, 88, 27, 128, 27, 168, 27, 224, 26, 240, 25, 196, 29, 8, 32, 144, 31 }, 313678, 313699, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 24, 0, 22, 192, 20, 160, 11, 192, 12, 32, 19, 192, 24, 224, 29, 0, 30, 32, 30, 64, 30, 160, 29, 224, 28, 64, 28, 128, 27, 128, 26, 224, 25, 224, 23, 0, 22, 64, 12 },
             new byte[] { 30, 128, 27, 240, 25, 136, 14, 240, 15, 232, 23, 240, 30, 88, 37, 128, 37, 168, 37, 208, 37, 8, 37, 24, 36, 80, 35, 96, 34, 32, 33, 88, 32, 216, 29, 128, 27, 80, 15 }, 313701, 313739, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 82 },
             new byte[] { 108 }, 387662, 387662, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 102 },
             new byte[] { 128 }, 387664, 387664, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 112 },
             new byte[] { 138 }, 387666, 387666, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 132 },
             new byte[] { 159 }, 387668, 387668, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 132 },
             new byte[] { 159 }, 387670, 387670, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 132 },
             new byte[] { 159 }, 387672, 387672, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 132 },
             new byte[] { 159 }, 387674, 387674, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 6 },
             new byte[] { 37 }, 387694, 387694, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 46 },
             new byte[] { 78 }, 387696, 387696, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 66 },
             new byte[] { 99 }, 387698, 387698, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 182 },
             new byte[] { 211 }, 387700, 387700, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 112 },
             new byte[] { 138 }, 387702, 387702, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 112 },
             new byte[] { 138 }, 387704, 387704, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 86 },
             new byte[] { 119 }, 387706, 387706, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16 },
             new byte[] { 47 }, 387726, 387726, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 76 },
             new byte[] { 109 }, 387728, 387728, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 106 },
             new byte[] { 140 }, 387730, 387730, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 116 },
             new byte[] { 150 }, 387732, 387732, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 136 },
             new byte[] { 171 }, 387734, 387734, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 136 },
             new byte[] { 171 }, 387736, 387736, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 176 },
             new byte[] { 212 }, 387738, 387738, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 26 },
             new byte[] { 58 }, 387758, 387758, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 126 },
             new byte[] { 161 }, 387760, 387760, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 206 },
             new byte[] { 243 }, 387762, 387762, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 20 },
             new byte[] { 59 }, 387764, 387764, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 20 },
             new byte[] { 59 }, 387766, 387766, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 20 },
             new byte[] { 59 }, 387768, 387768, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 20 },
             new byte[] { 59 }, 387770, 387770, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 36 },
             new byte[] { 68 }, 387790, 387790, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 146 },
             new byte[] { 181 }, 387792, 387792, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 246, 4, 40 },
             new byte[] { 28, 5, 80 }, 387794, 387796, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 90 },
             new byte[] { 131 }, 387798, 387798, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 90 },
             new byte[] { 131 }, 387800, 387800, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 90 },
             new byte[] { 131 }, 387802, 387802, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 66 },
             new byte[] { 99 }, 387822, 387822, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 166 },
             new byte[] { 202 }, 387824, 387824, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 20 },
             new byte[] { 59 }, 387826, 387826, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 110 },
             new byte[] { 152 }, 387828, 387828, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 110 },
             new byte[] { 152 }, 387830, 387830, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 54 },
             new byte[] { 102 }, 387832, 387832, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 54 },
             new byte[] { 102 }, 387834, 387834, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 106 },
             new byte[] { 140 }, 387854, 387854, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 196 },
             new byte[] { 233 }, 387856, 387856, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 60 },
             new byte[] { 100 }, 387858, 387858, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 220, 5, 250, 5, 250, 5, 250, 5 },
             new byte[] { 9, 6, 40, 6, 40, 6, 40, 6 }, 387860, 387867, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 10 },
             new byte[] { 49 }, 387886, 387886, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 100 },
             new byte[] { 141 }, 387888, 387888, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 190 },
             new byte[] { 234 }, 387890, 387890, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 14 },
             new byte[] { 61 }, 387892, 387892, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 29 },
             new byte[] { 76 }, 387894, 387894, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 29 },
             new byte[] { 76 }, 387896, 387896, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 29 },
             new byte[] { 76 }, 387898, 387898, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 170 },
             new byte[] { 214 }, 387918, 387918, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 4 },
             new byte[] { 50 }, 387920, 387920, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 44 },
             new byte[] { 91 }, 387922, 387922, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 49 },
             new byte[] { 97 }, 387924, 387924, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 49 },
             new byte[] { 97 }, 387926, 387926, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 64 },
             new byte[] { 112 }, 387928, 387928, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 64 },
             new byte[] { 112 }, 387930, 387930, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 245, 5, 34 },
             new byte[] { 35, 6, 81 }, 387950, 387952, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 44 },
             new byte[] { 91 }, 387954, 387954, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 44 },
             new byte[] { 91 }, 387956, 387956, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 64 },
             new byte[] { 112 }, 387958, 387958, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 64 },
             new byte[] { 112 }, 387960, 387960, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 64 },
             new byte[] { 112 }, 387962, 387962, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 64 },
             new byte[] { 112 }, 387982, 387982, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 64 },
             new byte[] { 112 }, 387984, 387984, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 64 },
             new byte[] { 112 }, 387986, 387986, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 64 },
             new byte[] { 112 }, 387988, 387988, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 64 },
             new byte[] { 112 }, 387990, 387990, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 64 },
             new byte[] { 112 }, 387992, 387992, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 64 },
             new byte[] { 112 }, 387994, 387994, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 64 },
             new byte[] { 112 }, 388014, 388014, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 64 },
             new byte[] { 112 }, 388016, 388016, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 64 },
             new byte[] { 112 }, 388018, 388018, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 64 },
             new byte[] { 112 }, 388020, 388020, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 64 },
             new byte[] { 112 }, 388022, 388022, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 64 },
             new byte[] { 112 }, 388024, 388024, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 64 },
             new byte[] { 112 }, 388026, 388026, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 176 },
             new byte[] { 212 }, 388100, 388100, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 176 },
             new byte[] { 212 }, 388102, 388102, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 176 },
             new byte[] { 212 }, 388104, 388104, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 176 },
             new byte[] { 212 }, 388106, 388106, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 181 },
             new byte[] { 217 }, 388120, 388120, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 223, 4, 12 },
             new byte[] { 4, 5, 51 }, 388122, 388124, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 49 },
             new byte[] { 89 }, 388126, 388126, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 181 },
             new byte[] { 217 }, 388140, 388140, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 226, 4, 21 },
             new byte[] { 8, 5, 60 }, 388142, 388144, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 118 },
             new byte[] { 160 }, 388146, 388146, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 30 },
             new byte[] { 69 }, 388160, 388160, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 132 },
             new byte[] { 174 }, 388162, 388162, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 162 },
             new byte[] { 205 }, 388164, 388164, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 253, 5 },
             new byte[] { 43, 6 }, 388166, 388167, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 200 },
             new byte[] { 244 }, 388180, 388180, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 64 },
             new byte[] { 112 }, 388182, 388182, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 64 },
             new byte[] { 112 }, 388184, 388184, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 69 },
             new byte[] { 117 }, 388186, 388186, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 64 },
             new byte[] { 112 }, 388200, 388200, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 64 },
             new byte[] { 112 }, 388202, 388202, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 64 },
             new byte[] { 112 }, 388204, 388204, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 71 },
             new byte[] { 119 }, 388206, 388206, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 64 },
             new byte[] { 112 }, 388220, 388220, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 64 },
             new byte[] { 112 }, 388222, 388222, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 64 },
             new byte[] { 112 }, 388224, 388224, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 64 },
             new byte[] { 112 }, 388226, 388226, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 60 },
             new byte[] { 85 }, 390186, 390186, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 110 },
             new byte[] { 136 }, 390188, 390188, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 114 },
             new byte[] { 140 }, 390190, 390190, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 123 },
             new byte[] { 150 }, 390192, 390192, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 82 },
             new byte[] { 108 }, 390194, 390194, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 82 },
             new byte[] { 108 }, 390196, 390196, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 82 },
             new byte[] { 108 }, 390198, 390198, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 87 },
             new byte[] { 113 }, 390218, 390218, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 183 },
             new byte[] { 212 }, 390220, 390220, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 211 },
             new byte[] { 240 }, 390222, 390222, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 232, 3, 56 },
             new byte[] { 6, 4, 88 }, 390224, 390226, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 56 },
             new byte[] { 88 }, 390228, 390228, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 56 },
             new byte[] { 88 }, 390230, 390230, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 35 },
             new byte[] { 59 }, 390250, 390250, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 57 },
             new byte[] { 82 }, 390252, 390252, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 182 },
             new byte[] { 211 }, 390254, 390254, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 212 },
             new byte[] { 241 }, 390256, 390256, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 206 },
             new byte[] { 243 }, 390258, 390258, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 70 },
             new byte[] { 111 }, 390260, 390260, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 70 },
             new byte[] { 111 }, 390262, 390262, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 55 },
             new byte[] { 87 }, 390282, 390282, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 127 },
             new byte[] { 162 }, 390284, 390284, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 179 },
             new byte[] { 215 }, 390286, 390286, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 243, 4, 52 },
             new byte[] { 25, 5, 92 }, 390288, 390290, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 70 },
             new byte[] { 111 }, 390292, 390292, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 70 },
             new byte[] { 111 }, 390294, 390294, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 129 },
             new byte[] { 164 }, 390314, 390314, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 212 },
             new byte[] { 249 }, 390316, 390316, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 241, 4, 60 },
             new byte[] { 23, 5, 100 }, 390318, 390320, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 146 },
             new byte[] { 189 }, 390322, 390322, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 170 },
             new byte[] { 214 }, 390324, 390324, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 170 },
             new byte[] { 214 }, 390326, 390326, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 232, 4, 8 },
             new byte[] { 14, 5, 47 }, 390346, 390348, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 43 },
             new byte[] { 83 }, 390350, 390350, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 139 },
             new byte[] { 182 }, 390352, 390352, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 239, 5, 245, 5, 245, 5 },
             new byte[] { 29, 6, 35, 6, 35, 6 }, 390354, 390359, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 65 },
             new byte[] { 105 }, 390378, 390378, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 101 },
             new byte[] { 142 }, 390380, 390380, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 126 },
             new byte[] { 168 }, 390382, 390382, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 4 },
             new byte[] { 50 }, 390384, 390384, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 39 },
             new byte[] { 86 }, 390386, 390386, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 39 },
             new byte[] { 86 }, 390388, 390388, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 39 },
             new byte[] { 86 }, 390390, 390390, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 127 },
             new byte[] { 169 }, 390410, 390410, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224, 5, 248, 5, 32 },
             new byte[] { 13, 6, 38, 6, 79 }, 390412, 390416, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 54 },
             new byte[] { 102 }, 390418, 390418, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 54 },
             new byte[] { 102 }, 390420, 390420, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 54 },
             new byte[] { 102 }, 390422, 390422, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 189 },
             new byte[] { 233 }, 390442, 390442, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 254, 5, 27 },
             new byte[] { 44, 6, 74 }, 390444, 390446, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 57 },
             new byte[] { 105 }, 390448, 390448, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 64 },
             new byte[] { 112 }, 390450, 390450, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 64 },
             new byte[] { 112 }, 390452, 390452, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 64 },
             new byte[] { 112 }, 390454, 390454, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 250, 5, 43 },
             new byte[] { 40, 6, 90 }, 390474, 390476, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 57 },
             new byte[] { 105 }, 390478, 390478, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 63 },
             new byte[] { 111 }, 390480, 390480, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 64 },
             new byte[] { 112 }, 390482, 390482, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 64 },
             new byte[] { 112 }, 390484, 390484, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 64 },
             new byte[] { 112 }, 390486, 390486, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 32 },
             new byte[] { 79 }, 390506, 390506, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 59 },
             new byte[] { 107 }, 390508, 390508, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 62 },
             new byte[] { 110 }, 390510, 390510, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 64 },
             new byte[] { 112 }, 390512, 390512, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 64 },
             new byte[] { 112 }, 390514, 390514, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 64 },
             new byte[] { 112 }, 390516, 390516, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 64 },
             new byte[] { 112 }, 390518, 390518, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 44 },
             new byte[] { 91 }, 390538, 390538, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 64 },
             new byte[] { 112 }, 390540, 390540, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 64 },
             new byte[] { 112 }, 390542, 390542, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 64 },
             new byte[] { 112 }, 390544, 390544, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 64 },
             new byte[] { 112 }, 390546, 390546, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 64 },
             new byte[] { 112 }, 390548, 390548, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 64 },
             new byte[] { 112 }, 390550, 390550, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 54 },
             new byte[] { 71 }, 390954, 390954, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 81 },
             new byte[] { 99 }, 390956, 390956, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 90 },
             new byte[] { 108 }, 390958, 390958, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 150 },
             new byte[] { 170 }, 390960, 390960, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 207 },
             new byte[] { 229 }, 390962, 390962, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 245, 2, 1 },
             new byte[] { 12, 3, 24 }, 390964, 390966, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 126 },
             new byte[] { 145 }, 390986, 390986, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 188 },
             new byte[] { 209 }, 390988, 390988, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 210 },
             new byte[] { 232 }, 390990, 390990, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 1 },
             new byte[] { 24 }, 390992, 390992, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 68 },
             new byte[] { 93 }, 390994, 390994, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 113 },
             new byte[] { 139 }, 390996, 390996, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 117 },
             new byte[] { 144 }, 390998, 390998, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 210 },
             new byte[] { 232 }, 391018, 391018, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 3 },
             new byte[] { 26 }, 391020, 391020, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 45 },
             new byte[] { 69 }, 391022, 391022, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 121 },
             new byte[] { 148 }, 391024, 391024, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 164 },
             new byte[] { 192 }, 391026, 391026, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 218 },
             new byte[] { 248 }, 391028, 391028, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 223 },
             new byte[] { 253 }, 391030, 391030, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 19 },
             new byte[] { 43 }, 391050, 391050, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 69 },
             new byte[] { 94 }, 391052, 391052, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 98 },
             new byte[] { 124 }, 391054, 391054, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 182 },
             new byte[] { 211 }, 391056, 391056, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 242, 3, 76 },
             new byte[] { 16, 4, 109 }, 391058, 391060, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 76 },
             new byte[] { 109 }, 391062, 391062, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 87 },
             new byte[] { 113 }, 391082, 391082, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 166 },
             new byte[] { 194 }, 391084, 391084, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 191 },
             new byte[] { 220 }, 391086, 391086, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 76 },
             new byte[] { 109 }, 391088, 391088, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 160 },
             new byte[] { 196 }, 391090, 391090, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 236, 4, 236, 4 },
             new byte[] { 18, 5, 18, 5 }, 391092, 391095, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 205 },
             new byte[] { 234 }, 391114, 391114, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 42 },
             new byte[] { 74 }, 391116, 391116, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 105 },
             new byte[] { 139 }, 391118, 391118, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 229, 4, 63 },
             new byte[] { 11, 5, 103 }, 391120, 391122, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 112 },
             new byte[] { 154 }, 391124, 391124, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 122 },
             new byte[] { 164 }, 391126, 391126, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 52 },
             new byte[] { 84 }, 391146, 391146, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 134 },
             new byte[] { 169 }, 391148, 391148, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 162 },
             new byte[] { 198 }, 391150, 391150, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 17 },
             new byte[] { 56 }, 391152, 391152, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 134 },
             new byte[] { 176 }, 391154, 391154, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 180 },
             new byte[] { 224 }, 391156, 391156, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 180 },
             new byte[] { 224 }, 391158, 391158, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 111 },
             new byte[] { 145 }, 391178, 391178, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 26 },
             new byte[] { 65 }, 391180, 391180, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 65 },
             new byte[] { 105 }, 391182, 391182, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 123 },
             new byte[] { 165 }, 391184, 391184, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 185 },
             new byte[] { 229 }, 391186, 391186, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 5 },
             new byte[] { 51 }, 391188, 391188, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 10 },
             new byte[] { 56 }, 391190, 391190, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 180 },
             new byte[] { 216 }, 391210, 391210, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 16 },
             new byte[] { 55 }, 391212, 391212, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 69 },
             new byte[] { 109 }, 391214, 391214, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 174 },
             new byte[] { 218 }, 391216, 391216, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 232, 5, 254, 5, 2 },
             new byte[] { 21, 6, 44, 6, 48 }, 391218, 391222, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 253, 4, 80 },
             new byte[] { 35, 5, 121 }, 391242, 391244, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 117 },
             new byte[] { 159 }, 391246, 391246, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 228, 5, 13 },
             new byte[] { 17, 6, 59 }, 391248, 391250, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 14 },
             new byte[] { 61 }, 391252, 391252, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 14 },
             new byte[] { 61 }, 391254, 391254, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 183 },
             new byte[] { 219 }, 391274, 391274, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 54 },
             new byte[] { 94 }, 391276, 391276, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 103 },
             new byte[] { 144 }, 391278, 391278, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 7 },
             new byte[] { 53 }, 391280, 391280, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 14 },
             new byte[] { 61 }, 391282, 391282, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 14 },
             new byte[] { 61 }, 391284, 391284, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 14 },
             new byte[] { 61 }, 391286, 391286, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 166 },
             new byte[] { 202 }, 391306, 391306, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 64 },
             new byte[] { 104 }, 391308, 391308, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 125 },
             new byte[] { 167 }, 391310, 391310, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 9 },
             new byte[] { 55 }, 391312, 391312, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 14 },
             new byte[] { 61 }, 391314, 391314, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 14 },
             new byte[] { 61 }, 391316, 391316, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 14 },
             new byte[] { 61 }, 391318, 391318, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 176 },
             new byte[] { 212 }, 391392, 391392, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 176 },
             new byte[] { 212 }, 391394, 391394, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 176 },
             new byte[] { 212 }, 391396, 391396, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 176 },
             new byte[] { 212 }, 391398, 391398, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 181 },
             new byte[] { 217 }, 391412, 391412, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 223, 4, 12 },
             new byte[] { 4, 5, 51 }, 391414, 391416, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 49 },
             new byte[] { 89 }, 391418, 391418, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 181 },
             new byte[] { 217 }, 391432, 391432, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 226, 4, 21 },
             new byte[] { 8, 5, 60 }, 391434, 391436, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 118 },
             new byte[] { 160 }, 391438, 391438, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 30 },
             new byte[] { 69 }, 391452, 391452, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 132 },
             new byte[] { 174 }, 391454, 391454, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 162 },
             new byte[] { 205 }, 391456, 391456, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 253, 5 },
             new byte[] { 43, 6 }, 391458, 391459, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 200 },
             new byte[] { 244 }, 391472, 391472, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 64 },
             new byte[] { 112 }, 391474, 391474, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 64 },
             new byte[] { 112 }, 391476, 391476, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 69 },
             new byte[] { 117 }, 391478, 391478, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 64 },
             new byte[] { 112 }, 391492, 391492, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 64 },
             new byte[] { 112 }, 391494, 391494, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 64 },
             new byte[] { 112 }, 391496, 391496, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 71 },
             new byte[] { 119 }, 391498, 391498, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 64 },
             new byte[] { 112 }, 391512, 391512, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 64 },
             new byte[] { 112 }, 391514, 391514, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 64 },
             new byte[] { 112 }, 391516, 391516, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 64 },
             new byte[] { 112 }, 391518, 391518, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 171 },
             new byte[] { 184 }, 391592, 391592, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 199 },
             new byte[] { 213 }, 391594, 391594, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 243, 1, 176 },
             new byte[] { 2, 2, 197 }, 391596, 391598, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 194 },
             new byte[] { 208 }, 391612, 391612, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 194 },
             new byte[] { 208 }, 391614, 391614, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 21 },
             new byte[] { 37 }, 391616, 391616, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 252, 2 },
             new byte[] { 19, 3 }, 391618, 391619, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 219 },
             new byte[] { 233 }, 391632, 391632, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 244, 1, 91 },
             new byte[] { 3, 2, 109 }, 391634, 391636, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 29 },
             new byte[] { 53 }, 391638, 391638, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 148 },
             new byte[] { 168 }, 391652, 391652, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 250, 2, 24 },
             new byte[] { 17, 3, 48 }, 391654, 391656, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 149 },
             new byte[] { 177 }, 391658, 391658, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 178 },
             new byte[] { 199 }, 391672, 391672, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 194 },
             new byte[] { 223 }, 391674, 391674, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 161 },
             new byte[] { 189 }, 391676, 391676, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 83 },
             new byte[] { 116 }, 391678, 391678, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 22 },
             new byte[] { 46 }, 391692, 391692, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 56 },
             new byte[] { 88 }, 391694, 391694, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 178 },
             new byte[] { 214 }, 391696, 391696, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 30 },
             new byte[] { 69 }, 391698, 391698, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 255, 3, 182 },
             new byte[] { 30, 4, 218 }, 391712, 391714, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 3 },
             new byte[] { 41 }, 391716, 391716, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 206 },
             new byte[] { 251 }, 391718, 391718, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 60 },
             new byte[] { 85 }, 392122, 392122, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 110 },
             new byte[] { 136 }, 392124, 392124, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 114 },
             new byte[] { 140 }, 392126, 392126, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 123 },
             new byte[] { 150 }, 392128, 392128, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 1 },
             new byte[] { 32 }, 392130, 392130, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 1 },
             new byte[] { 32 }, 392132, 392132, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 1 },
             new byte[] { 32 }, 392134, 392134, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 125 },
             new byte[] { 152 }, 392154, 392154, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 213 },
             new byte[] { 242 }, 392156, 392156, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 241, 3, 1 },
             new byte[] { 15, 4, 32 }, 392158, 392160, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 126 },
             new byte[] { 161 }, 392162, 392162, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 126 },
             new byte[] { 161 }, 392164, 392164, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 126 },
             new byte[] { 161 }, 392166, 392166, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 206 },
             new byte[] { 235 }, 392186, 392186, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 53 },
             new byte[] { 85 }, 392188, 392188, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 95 },
             new byte[] { 129 }, 392190, 392190, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 140 },
             new byte[] { 175 }, 392192, 392192, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 0 },
             new byte[] { 38 }, 392194, 392194, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 0 },
             new byte[] { 38 }, 392196, 392196, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 0 },
             new byte[] { 38 }, 392198, 392198, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 22 },
             new byte[] { 53 }, 392218, 392218, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 127 },
             new byte[] { 162 }, 392220, 392220, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 179 },
             new byte[] { 215 }, 392222, 392222, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 243, 4, 52 },
             new byte[] { 25, 5, 92 }, 392224, 392226, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 70 },
             new byte[] { 111 }, 392228, 392228, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 70 },
             new byte[] { 111 }, 392230, 392230, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 111 },
             new byte[] { 145 }, 392250, 392250, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 212 },
             new byte[] { 249 }, 392252, 392252, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 241, 4, 60 },
             new byte[] { 23, 5, 100 }, 392254, 392256, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 146 },
             new byte[] { 189 }, 392258, 392258, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 170 },
             new byte[] { 214 }, 392260, 392260, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 170 },
             new byte[] { 214 }, 392262, 392262, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 205 },
             new byte[] { 242 }, 392282, 392282, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 8 },
             new byte[] { 47 }, 392284, 392284, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 43 },
             new byte[] { 83 }, 392286, 392286, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 139 },
             new byte[] { 182 }, 392288, 392288, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 239, 5, 245, 5, 245, 5 },
             new byte[] { 29, 6, 35, 6, 35, 6 }, 392290, 392295, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 39 },
             new byte[] { 79 }, 392314, 392314, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 101 },
             new byte[] { 142 }, 392316, 392316, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 126 },
             new byte[] { 168 }, 392318, 392318, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 4 },
             new byte[] { 50 }, 392320, 392320, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 39 },
             new byte[] { 86 }, 392322, 392322, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 39 },
             new byte[] { 86 }, 392324, 392324, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 39 },
             new byte[] { 86 }, 392326, 392326, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 115 },
             new byte[] { 157 }, 392346, 392346, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224, 5, 248, 5, 32 },
             new byte[] { 13, 6, 38, 6, 79 }, 392348, 392352, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 54 },
             new byte[] { 102 }, 392354, 392354, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 54 },
             new byte[] { 102 }, 392356, 392356, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 54 },
             new byte[] { 102 }, 392358, 392358, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 181 },
             new byte[] { 225 }, 392378, 392378, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 254, 5, 27 },
             new byte[] { 44, 6, 74 }, 392380, 392382, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 57 },
             new byte[] { 105 }, 392384, 392384, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 64 },
             new byte[] { 112 }, 392386, 392386, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 64 },
             new byte[] { 112 }, 392388, 392388, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 64 },
             new byte[] { 112 }, 392390, 392390, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 250, 5, 43 },
             new byte[] { 40, 6, 90 }, 392410, 392412, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 57 },
             new byte[] { 105 }, 392414, 392414, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 63 },
             new byte[] { 111 }, 392416, 392416, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 64 },
             new byte[] { 112 }, 392418, 392418, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 64 },
             new byte[] { 112 }, 392420, 392420, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 64 },
             new byte[] { 112 }, 392422, 392422, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 32 },
             new byte[] { 79 }, 392442, 392442, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 59 },
             new byte[] { 107 }, 392444, 392444, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 62 },
             new byte[] { 110 }, 392446, 392446, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 64 },
             new byte[] { 112 }, 392448, 392448, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 64 },
             new byte[] { 112 }, 392450, 392450, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 64 },
             new byte[] { 112 }, 392452, 392452, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 64 },
             new byte[] { 112 }, 392454, 392454, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 44 },
             new byte[] { 91 }, 392474, 392474, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 64 },
             new byte[] { 112 }, 392476, 392476, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 64 },
             new byte[] { 112 }, 392478, 392478, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 64 },
             new byte[] { 112 }, 392480, 392480, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 64 },
             new byte[] { 112 }, 392482, 392482, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 64 },
             new byte[] { 112 }, 392484, 392484, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 64 },
             new byte[] { 112 }, 392486, 392486, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 110 },
             new byte[] { 112 }, 402806, 402806, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 110 },
             new byte[] { 112 }, 402808, 402808, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 105 },
             new byte[] { 106 }, 402810, 402810, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 150 },
             new byte[] { 154 }, 402838, 402838, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 150 },
             new byte[] { 154 }, 402840, 402840, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 150 },
             new byte[] { 154 }, 402842, 402842, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 155 },
             new byte[] { 159 }, 402870, 402870, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 155 },
             new byte[] { 159 }, 402872, 402872, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 155 },
             new byte[] { 159 }, 402874, 402874, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 49 },
             new byte[] { 60 }, 402902, 402902, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 49 },
             new byte[] { 60 }, 402904, 402904, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 49 },
             new byte[] { 60 }, 402906, 402906, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 107 },
             new byte[] { 121 }, 402934, 402934, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 107 },
             new byte[] { 121 }, 402936, 402936, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 107 },
             new byte[] { 121 }, 402938, 402938, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 164 },
             new byte[] { 181 }, 402966, 402966, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 164 },
             new byte[] { 181 }, 402968, 402968, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 164 },
             new byte[] { 181 }, 402970, 402970, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 204 },
             new byte[] { 223 }, 402998, 402998, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 204 },
             new byte[] { 223 }, 403000, 403000, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 204 },
             new byte[] { 223 }, 403002, 403002, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 204 },
             new byte[] { 223 }, 403030, 403030, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 204 },
             new byte[] { 223 }, 403032, 403032, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 204 },
             new byte[] { 223 }, 403034, 403034, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 105 },
             new byte[] { 106 }, 403318, 403318, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 105 },
             new byte[] { 106 }, 403320, 403320, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 105 },
             new byte[] { 106 }, 403322, 403322, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 150 },
             new byte[] { 154 }, 403350, 403350, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 150 },
             new byte[] { 154 }, 403352, 403352, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 150 },
             new byte[] { 154 }, 403354, 403354, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 155 },
             new byte[] { 159 }, 403382, 403382, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 155 },
             new byte[] { 159 }, 403384, 403384, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 155 },
             new byte[] { 159 }, 403386, 403386, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 49 },
             new byte[] { 60 }, 403414, 403414, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 49 },
             new byte[] { 60 }, 403416, 403416, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 49 },
             new byte[] { 60 }, 403418, 403418, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 107 },
             new byte[] { 121 }, 403446, 403446, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 107 },
             new byte[] { 121 }, 403448, 403448, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 107 },
             new byte[] { 121 }, 403450, 403450, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 164 },
             new byte[] { 181 }, 403478, 403478, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 164 },
             new byte[] { 181 }, 403480, 403480, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 164 },
             new byte[] { 181 }, 403482, 403482, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 204 },
             new byte[] { 223 }, 403510, 403510, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 204 },
             new byte[] { 223 }, 403512, 403512, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 204 },
             new byte[] { 223 }, 403514, 403514, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 204 },
             new byte[] { 223 }, 403542, 403542, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 204 },
             new byte[] { 223 }, 403544, 403544, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 204 },
             new byte[] { 223 }, 403546, 403546, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 165 },
             new byte[] { 169 }, 407290, 407290, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 130 },
             new byte[] { 133 }, 407292, 407292, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 130 },
             new byte[] { 133 }, 407294, 407294, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 3 },
             new byte[] { 12 }, 407322, 407322, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 252, 70, 9 },
             new byte[] { 5, 71, 18 }, 407324, 407326, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 44 },
             new byte[] { 55 }, 407354, 407354, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 26 },
             new byte[] { 36 }, 407356, 407356, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 26 },
             new byte[] { 36 }, 407358, 407358, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 92 },
             new byte[] { 105 }, 407386, 407386, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 92 },
             new byte[] { 105 }, 407388, 407388, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 92 },
             new byte[] { 105 }, 407390, 407390, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 174 },
             new byte[] { 192 }, 407418, 407418, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 174 },
             new byte[] { 192 }, 407420, 407420, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 174 },
             new byte[] { 192 }, 407422, 407422, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 249, 71, 249, 71, 249, 71 },
             new byte[] { 14, 72, 14, 72, 14, 72 }, 407450, 407455, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 99 },
             new byte[] { 126 }, 407482, 407482, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 99 },
             new byte[] { 126 }, 407484, 407484, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 99 },
             new byte[] { 126 }, 407486, 407486, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 203 },
             new byte[] { 235 }, 407514, 407514, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 199 },
             new byte[] { 231 }, 407516, 407516, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 199 },
             new byte[] { 231 }, 407518, 407518, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 52 },
             new byte[] { 89 }, 407546, 407546, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 51 },
             new byte[] { 88 }, 407548, 407548, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 51 },
             new byte[] { 88 }, 407550, 407550, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 165 },
             new byte[] { 169 }, 407802, 407802, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 130 },
             new byte[] { 133 }, 407804, 407804, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 130 },
             new byte[] { 133 }, 407806, 407806, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 3 },
             new byte[] { 12 }, 407834, 407834, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 252, 70, 9 },
             new byte[] { 5, 71, 18 }, 407836, 407838, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 44 },
             new byte[] { 55 }, 407866, 407866, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 26 },
             new byte[] { 36 }, 407868, 407868, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 26 },
             new byte[] { 36 }, 407870, 407870, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 92 },
             new byte[] { 105 }, 407898, 407898, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 92 },
             new byte[] { 105 }, 407900, 407900, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 92 },
             new byte[] { 105 }, 407902, 407902, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 174 },
             new byte[] { 192 }, 407930, 407930, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 174 },
             new byte[] { 192 }, 407932, 407932, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 174 },
             new byte[] { 192 }, 407934, 407934, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 249, 71, 249, 71, 249, 71 },
             new byte[] { 14, 72, 14, 72, 14, 72 }, 407962, 407967, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 99 },
             new byte[] { 126 }, 407994, 407994, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 99 },
             new byte[] { 126 }, 407996, 407996, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 99 },
             new byte[] { 126 }, 407998, 407998, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 203 },
             new byte[] { 235 }, 408026, 408026, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 199 },
             new byte[] { 231 }, 408028, 408028, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 199 },
             new byte[] { 231 }, 408030, 408030, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 52 },
             new byte[] { 89 }, 408058, 408058, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 51 },
             new byte[] { 88 }, 408060, 408060, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 51 },
             new byte[] { 88 }, 408062, 408062, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 165 },
             new byte[] { 169 }, 408970, 408970, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 130 },
             new byte[] { 133 }, 408972, 408972, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 130 },
             new byte[] { 133 }, 408974, 408974, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 180 },
             new byte[] { 185 }, 409002, 409002, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 155 },
             new byte[] { 159 }, 409004, 409004, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 155 },
             new byte[] { 159 }, 409006, 409006, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 207 },
             new byte[] { 213 }, 409034, 409034, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 205 },
             new byte[] { 211 }, 409036, 409036, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 205 },
             new byte[] { 211 }, 409038, 409038, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 248, 70, 245 },
             new byte[] { 0, 71, 253 }, 409066, 409068, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 245 },
             new byte[] { 253 }, 409070, 409070, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 26 },
             new byte[] { 36 }, 409098, 409098, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 14 },
             new byte[] { 24 }, 409100, 409100, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 14 },
             new byte[] { 24 }, 409102, 409102, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 114 },
             new byte[] { 129 }, 409130, 409130, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 110 },
             new byte[] { 124 }, 409132, 409132, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 110 },
             new byte[] { 124 }, 409134, 409134, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 206 },
             new byte[] { 225 }, 409162, 409162, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 205 },
             new byte[] { 224 }, 409164, 409164, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 205 },
             new byte[] { 224 }, 409166, 409166, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 175 },
             new byte[] { 205 }, 409194, 409194, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 177 },
             new byte[] { 207 }, 409196, 409196, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 177 },
             new byte[] { 207 }, 409198, 409198, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 217 },
             new byte[] { 249 }, 409226, 409226, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 218 },
             new byte[] { 251 }, 409228, 409228, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 218 },
             new byte[] { 251 }, 409230, 409230, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 169 },
             new byte[] { 173 }, 409482, 409482, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 140 },
             new byte[] { 143 }, 409484, 409484, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 140 },
             new byte[] { 143 }, 409486, 409486, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 180 },
             new byte[] { 185 }, 409514, 409514, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 155 },
             new byte[] { 159 }, 409516, 409516, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 155 },
             new byte[] { 159 }, 409518, 409518, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 207 },
             new byte[] { 213 }, 409546, 409546, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 205 },
             new byte[] { 211 }, 409548, 409548, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 205 },
             new byte[] { 211 }, 409550, 409550, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 248, 70, 245 },
             new byte[] { 0, 71, 253 }, 409578, 409580, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 245 },
             new byte[] { 253 }, 409582, 409582, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 26 },
             new byte[] { 36 }, 409610, 409610, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 14 },
             new byte[] { 24 }, 409612, 409612, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 14 },
             new byte[] { 24 }, 409614, 409614, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 114 },
             new byte[] { 129 }, 409642, 409642, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 110 },
             new byte[] { 124 }, 409644, 409644, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 110 },
             new byte[] { 124 }, 409646, 409646, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 206 },
             new byte[] { 225 }, 409674, 409674, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 205 },
             new byte[] { 224 }, 409676, 409676, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 205 },
             new byte[] { 224 }, 409678, 409678, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 175 },
             new byte[] { 205 }, 409706, 409706, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 177 },
             new byte[] { 207 }, 409708, 409708, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 177 },
             new byte[] { 207 }, 409710, 409710, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 217 },
             new byte[] { 249 }, 409738, 409738, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 218 },
             new byte[] { 251 }, 409740, 409740, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 218 },
             new byte[] { 251 }, 409742, 409742, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 190 },
             new byte[] { 195 }, 410250, 410250, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 155 },
             new byte[] { 159 }, 410252, 410252, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 155 },
             new byte[] { 159 }, 410254, 410254, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 180 },
             new byte[] { 185 }, 410282, 410282, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 155 },
             new byte[] { 159 }, 410284, 410284, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 155 },
             new byte[] { 159 }, 410286, 410286, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 207 },
             new byte[] { 213 }, 410314, 410314, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 205 },
             new byte[] { 211 }, 410316, 410316, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 205 },
             new byte[] { 211 }, 410318, 410318, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 248, 70, 245 },
             new byte[] { 0, 71, 253 }, 410346, 410348, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 245 },
             new byte[] { 253 }, 410350, 410350, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 26 },
             new byte[] { 36 }, 410378, 410378, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 14 },
             new byte[] { 24 }, 410380, 410380, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 14 },
             new byte[] { 24 }, 410382, 410382, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 104 },
             new byte[] { 118 }, 410410, 410410, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 104 },
             new byte[] { 118 }, 410412, 410412, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 104 },
             new byte[] { 118 }, 410414, 410414, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 196 },
             new byte[] { 215 }, 410442, 410442, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 196 },
             new byte[] { 215 }, 410444, 410444, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 196 },
             new byte[] { 215 }, 410446, 410446, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 162 },
             new byte[] { 192 }, 410474, 410474, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 162 },
             new byte[] { 192 }, 410476, 410476, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 162 },
             new byte[] { 192 }, 410478, 410478, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 185 },
             new byte[] { 216 }, 410506, 410506, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 185 },
             new byte[] { 216 }, 410508, 410508, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 185 },
             new byte[] { 216 }, 410510, 410510, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 169 },
             new byte[] { 173 }, 410762, 410762, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 140 },
             new byte[] { 143 }, 410764, 410764, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 140 },
             new byte[] { 143 }, 410766, 410766, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 180 },
             new byte[] { 185 }, 410794, 410794, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 155 },
             new byte[] { 159 }, 410796, 410796, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 155 },
             new byte[] { 159 }, 410798, 410798, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 207 },
             new byte[] { 213 }, 410826, 410826, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 205 },
             new byte[] { 211 }, 410828, 410828, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 205 },
             new byte[] { 211 }, 410830, 410830, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 248, 70, 245 },
             new byte[] { 0, 71, 253 }, 410858, 410860, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 245 },
             new byte[] { 253 }, 410862, 410862, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 26 },
             new byte[] { 36 }, 410890, 410890, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 26 },
             new byte[] { 36 }, 410892, 410892, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 26 },
             new byte[] { 36 }, 410894, 410894, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 114 },
             new byte[] { 129 }, 410922, 410922, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 114 },
             new byte[] { 129 }, 410924, 410924, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 114 },
             new byte[] { 129 }, 410926, 410926, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 206 },
             new byte[] { 225 }, 410954, 410954, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 206 },
             new byte[] { 225 }, 410956, 410956, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 206 },
             new byte[] { 225 }, 410958, 410958, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 172 },
             new byte[] { 202 }, 410986, 410986, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 172 },
             new byte[] { 202 }, 410988, 410988, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 172 },
             new byte[] { 202 }, 410990, 410990, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 185 },
             new byte[] { 216 }, 411018, 411018, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 185 },
             new byte[] { 216 }, 411020, 411020, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 185 },
             new byte[] { 216 }, 411022, 411022, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 128, 32, 128, 32, 128, 32, 78, 28, 197, 24, 4, 22, 209, 19, 4, 18, 131, 16, 62, 15, 39, 14, 54, 13, 98, 12, 2, 11, 87, 7 },
             new byte[] { 160, 40, 160, 40, 160, 40, 98, 35, 246, 30, 133, 27, 197, 24, 133, 22, 164, 20, 14, 19, 177, 17, 132, 16, 123, 15, 195, 13, 45, 9 }, 444944, 444973, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 128, 32, 128, 32, 128, 32, 216, 31, 221, 27, 197, 24, 75, 22, 68, 20, 148, 18, 38, 17, 236, 15, 220, 14, 239, 13, 98, 12, 66, 8 },
             new byte[] { 160, 40, 160, 40, 160, 40, 206, 39, 212, 34, 246, 30, 222, 27, 85, 25, 57, 23, 112, 21, 231, 19, 147, 18, 107, 17, 123, 15, 83, 10 }, 444984, 445013, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 128, 32, 128, 32, 128, 32, 128, 32, 246, 30, 133, 27, 197, 24, 132, 22, 164, 20, 13, 19, 177, 17, 131, 16, 123, 15, 195, 13, 44, 9 },
             new byte[] { 160, 40, 160, 40, 160, 40, 160, 40, 180, 38, 102, 34, 246, 30, 37, 28, 205, 25, 208, 23, 29, 22, 164, 20, 90, 19, 52, 17, 119, 11 }, 445024, 445053, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 128, 32, 128, 32, 128, 32, 128, 32, 128, 32, 70, 30, 63, 27, 197, 24, 180, 22, 245, 20, 118, 19, 42, 18, 7, 17, 35, 15, 23, 10 },
             new byte[] { 160, 40, 160, 40, 160, 40, 160, 40, 160, 40, 216, 37, 15, 34, 246, 30, 97, 28, 50, 26, 84, 24, 181, 22, 73, 21, 236, 18, 157, 12 }, 445064, 445093, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 128, 32, 128, 32, 128, 32, 128, 32, 128, 32, 128, 32, 185, 29, 5, 27, 197, 24, 221, 22, 59, 21, 209, 19, 148, 18, 131, 16, 2, 11 },
             new byte[] { 160, 40, 160, 40, 160, 40, 160, 40, 160, 40, 160, 40, 39, 37, 198, 33, 246, 30, 148, 28, 138, 26, 197, 24, 57, 23, 164, 20, 195, 13 }, 445104, 445133, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 128, 32, 128, 32, 128, 32, 128, 32, 128, 32, 128, 32, 51, 32, 69, 29, 213, 26, 197, 24, 0, 23, 119, 21, 32, 20, 228, 17, 237, 11 },
             new byte[] { 160, 40, 160, 40, 160, 40, 160, 40, 160, 40, 160, 40, 64, 40, 150, 36, 138, 33, 246, 30, 192, 28, 213, 26, 40, 25, 93, 22, 232, 14 }, 445144, 445173, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 128, 32, 128, 32, 128, 32, 128, 32, 128, 32, 128, 32, 128, 32, 134, 31, 229, 28, 172, 26, 197, 24, 30, 23, 172, 21, 68, 19, 216, 12 },
             new byte[] { 160, 40, 160, 40, 160, 40, 160, 40, 160, 40, 160, 40, 160, 40, 104, 39, 30, 36, 87, 33, 246, 30, 230, 28, 23, 27, 21, 24, 14, 16 }, 445184, 445213, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 128, 32, 128, 32, 128, 32, 128, 32, 128, 32, 128, 32, 128, 32, 128, 32, 246, 30, 148, 28, 138, 26, 197, 24, 56, 23, 164, 20, 195, 13 },
             new byte[] { 160, 40, 160, 40, 160, 40, 160, 40, 160, 40, 160, 40, 160, 40, 160, 40, 180, 38, 185, 35, 45, 33, 246, 30, 6, 29, 205, 25, 52, 17 }, 445224, 445253, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 128, 32, 128, 32, 128, 32, 128, 32, 128, 32, 128, 32, 128, 32, 128, 32, 128, 32, 124, 30, 78, 28, 108, 26, 197, 24, 4, 22, 173, 14 },
             new byte[] { 160, 40, 160, 40, 160, 40, 160, 40, 160, 40, 160, 40, 160, 40, 160, 40, 160, 40, 27, 38, 98, 35, 7, 33, 246, 30, 133, 27, 88, 18 }, 445264, 445293, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 160, 32, 215, 31, 90, 28, 213, 26, 80, 25, 151, 18, 217, 13, 108, 12, 160, 32, 35, 31, 90, 28, 213, 26, 80, 25, 151, 18, 26, 13, 201, 9, 39, 32, 227, 30, 90, 28, 109, 26, 129, 24, 201, 17, 60, 12, 79, 8, 123, 31, 111, 30, 90, 28, 210, 25, 70, 22, 164, 16, 171, 11, 142, 8, 74, 28, 245, 26, 77, 24, 112, 22, 244, 18, 58, 15, 202, 10, 56, 8, 178, 26, 57, 25, 70, 22, 190, 20, 75, 17, 132, 14, 89, 10, 13, 8, 118, 24, 249, 22, 254, 19, 139, 18, 98, 15, 133, 12, 19, 9, 123, 7, 29, 21, 154, 19, 146, 16, 62, 15, 133, 12, 134, 9, 43, 7, 160, 6 },
             new byte[] { 128, 37, 128, 37, 128, 37, 128, 37, 128, 37, 128, 37, 128, 37, 128, 37, 128, 37, 128, 37, 128, 37, 128, 37, 128, 37, 128, 37, 128, 37, 128, 37, 128, 37, 128, 37, 128, 37, 128, 37, 128, 37, 128, 37, 128, 37, 128, 37, 128, 37, 128, 37, 128, 37, 128, 37, 128, 37, 128, 37, 128, 37, 128, 37, 128, 37, 128, 37, 128, 37, 128, 37, 128, 37, 128, 37, 128, 37, 128, 37, 128, 37, 128, 37, 128, 37, 128, 37, 128, 37, 128, 37, 128, 37, 128, 37, 128, 37, 128, 37, 128, 37, 128, 37, 128, 37, 128, 37, 128, 37, 128, 37, 128, 37, 128, 37, 128, 37, 128, 37, 128, 37, 128, 37, 128, 37, 128, 37 }, 469268, 469395, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 107, 106, 95, 94, 89, 89, 93, 100, 92, 52, 52, 52 },
             new byte[] { 128, 128, 128, 128, 128, 128, 128, 128, 128, 128, 128, 128 }, 469436, 469447, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 111, 113, 112, 109, 106, 106, 99, 111, 107, 76, 62, 62 },
             new byte[] { 128, 128, 128, 128, 128, 128, 128, 128, 128, 128, 128, 128 }, 469456, 469467, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 117, 116, 115, 115, 113, 108, 100, 116, 115, 93, 65, 65 },
             new byte[] { 128, 128, 128, 128, 128, 128, 128, 128, 128, 128, 128, 128 }, 469476, 469487, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 114, 115, 115, 109, 105, 100, 112, 112, 101, 87, 87 },
             new byte[] { 128, 128, 128, 128, 128, 128, 128, 128, 128, 128, 128 }, 469497, 469507, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 119, 120, 116, 112, 108, 104, 114, 115, 115, 115, 115 },
             new byte[] { 128, 128, 128, 128, 128, 128, 128, 128, 128, 128, 128 }, 469517, 469527, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 112, 107, 118, 118, 118, 118, 111 },
             new byte[] { 128, 128, 128, 128, 128, 128, 128 }, 469541, 469547, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 0, 33 },
             new byte[] { 64, 41 }, 469648, 469649, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 20, 224, 16, 64, 16, 160, 15, 0, 15, 96, 14, 32, 13, 160, 7, 64, 7, 192, 6, 64, 6, 0, 33, 96, 20, 64, 18, 224, 17, 224, 16, 64, 16, 128, 15, 32, 15, 224, 10, 128, 10, 96, 9, 32, 8, 0, 33, 96, 33, 160, 26, 128, 30, 128, 21, 64, 19, 224, 17, 160, 16, 32, 15, 224, 14, 64, 14, 192, 13, 0, 33, 96, 33, 128, 28, 96, 31, 128, 26, 192, 24, 0, 23, 160, 20, 32, 18, 224, 17, 128, 17, 0, 15, 0, 33, 96, 33, 96, 33, 96, 33, 160, 27, 128, 26, 64, 25, 64, 23, 32, 21, 32, 20, 96, 19, 96, 15, 0, 33, 96, 33, 96, 33, 96, 33, 96, 30, 128, 29, 128, 28, 192, 26, 224, 24 },
             new byte[] { 25, 24, 21, 80, 20, 136, 19, 192, 18, 248, 17, 104, 16, 136, 9, 16, 9, 112, 8, 208, 7, 64, 41, 120, 25, 208, 22, 88, 22, 24, 21, 80, 20, 96, 19, 232, 18, 152, 13, 32, 13, 184, 11, 40, 10, 64, 41, 184, 41, 72, 33, 32, 38, 224, 26, 16, 24, 88, 22, 200, 20, 232, 18, 152, 18, 208, 17, 48, 17, 64, 41, 184, 41, 160, 35, 56, 39, 32, 33, 240, 30, 192, 28, 200, 25, 168, 22, 88, 22, 224, 21, 192, 18, 64, 41, 184, 41, 184, 41, 184, 41, 136, 34, 32, 33, 144, 31, 16, 29, 104, 26, 40, 25, 56, 24, 56, 19, 64, 41, 184, 41, 184, 41, 184, 41, 248, 37, 224, 36, 160, 35, 112, 33, 24, 31 }, 469651, 469785, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 24, 192, 22, 96, 15, 0, 33, 96, 33, 96, 33, 96, 33 },
             new byte[] { 30, 112, 28, 56, 19, 64, 41, 184, 41, 184, 41, 184, 41 }, 469787, 469799, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 32 },
             new byte[] { 40 }, 469801, 469801, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 32, 224, 31, 64, 30, 128, 28, 128, 25, 224, 24, 96, 15, 0, 33, 96, 33, 96, 33, 96, 33 },
             new byte[] { 40, 216, 39, 208, 37, 160, 35, 224, 31, 24, 31, 56, 19, 64, 41, 184, 41, 184, 41, 184, 41 }, 469803, 469823, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 32 },
             new byte[] { 40 }, 469825, 469825, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 32, 224, 31, 128, 30, 0, 29, 0, 27, 32, 25, 96, 15, 0, 33, 96, 33, 96, 33, 96, 33 },
             new byte[] { 40, 216, 39, 32, 38, 64, 36, 192, 33, 104, 31, 56, 19, 64, 41, 184, 41, 184, 41, 184, 41 }, 469827, 469847, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 32 },
             new byte[] { 40 }, 469849, 469849, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 32, 224, 31, 64, 31, 0, 29, 0, 27, 32, 25, 96, 15, 0, 33, 96, 33, 96, 33, 96, 33 },
             new byte[] { 40, 216, 39, 16, 39, 64, 36, 192, 33, 104, 31, 56, 19, 64, 41, 184, 41, 184, 41, 184, 41 }, 469851, 469871, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 32 },
             new byte[] { 40 }, 469873, 469873, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 32, 224, 31, 64, 31, 0, 29, 0, 27, 32, 25, 96, 15 },
             new byte[] { 40, 216, 39, 16, 39, 64, 36, 192, 33, 104, 31, 56, 19 }, 469875, 469887, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224, 27, 0, 33, 32, 33, 64, 33, 96, 33, 192, 32 },
             new byte[] { 216, 34, 64, 41, 104, 41, 144, 41, 184, 41, 240, 40 }, 470088, 470099, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 32, 96, 31, 160, 30, 160, 29, 0, 29, 0, 27, 32, 25, 128, 19, 96, 15, 224, 7 },
             new byte[] { 40, 56, 39, 72, 38, 8, 37, 64, 36, 192, 33, 104, 31, 96, 24, 56, 19, 216, 9 }, 470101, 470119, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 115, 115, 115, 109, 99, 95, 88, 92, 102 },
             new byte[] { 128, 128, 128, 128, 128, 128, 128, 128, 128 }, 470228, 470236, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 120, 113, 102, 97, 90, 97, 102 },
             new byte[] { 128, 128, 128, 128, 128, 128, 128 }, 470250, 470256, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 118, 107, 102, 96, 102, 107 },
             new byte[] { 128, 128, 128, 128, 128, 128 }, 470271, 470276, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 120, 115, 108, 110, 115 },
             new byte[] { 128, 128, 128, 128, 128 }, 470292, 470296, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 117, 110, 102, 108, 115 },
             new byte[] { 128, 128, 128, 128, 128 }, 470312, 470316, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 113, 105, 111, 118 },
             new byte[] { 128, 128, 128, 128 }, 470333, 470336, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 119, 110, 116, 122 },
             new byte[] { 128, 128, 128, 128 }, 470353, 470356, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 113, 120 },
             new byte[] { 128, 128 }, 470374, 470375, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 0, 33, 64, 33, 96, 33, 176, 32 },
             new byte[] { 64, 41, 144, 41, 184, 41, 220, 40 }, 470440, 470447, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 32, 80, 31, 160, 30, 208, 29, 0, 29, 0, 27, 32, 25, 96, 15, 0, 33, 64, 33, 96, 33, 176, 32 },
             new byte[] { 40, 36, 39, 72, 38, 68, 37, 64, 36, 192, 33, 104, 31, 56, 19, 64, 41, 144, 41, 184, 41, 220, 40 }, 470449, 470471, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 32, 80, 31, 160, 30, 208, 29, 0, 29, 0, 27, 32, 25, 96, 15, 0, 33, 64, 33, 96, 33, 176, 32 },
             new byte[] { 40, 36, 39, 72, 38, 68, 37, 64, 36, 192, 33, 104, 31, 56, 19, 64, 41, 144, 41, 184, 41, 220, 40 }, 470473, 470495, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 32, 80, 31, 160, 30, 208, 29, 0, 29, 0, 27, 32, 25, 96, 15, 0, 33, 64, 33, 96, 33, 176, 32 },
             new byte[] { 40, 36, 39, 72, 38, 68, 37, 64, 36, 192, 33, 104, 31, 56, 19, 64, 41, 144, 41, 184, 41, 220, 40 }, 470497, 470519, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 32, 80, 31, 160, 30, 208, 29, 0, 29, 0, 27, 32, 25, 96, 15, 0, 33, 64, 33, 96, 33, 176, 32 },
             new byte[] { 40, 36, 39, 72, 38, 68, 37, 64, 36, 192, 33, 104, 31, 56, 19, 64, 41, 144, 41, 184, 41, 220, 40 }, 470521, 470543, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 32, 80, 31, 160, 30, 208, 29, 0, 29, 0, 27, 32, 25, 96, 15, 0, 33, 64, 33, 96, 33, 176, 32 },
             new byte[] { 40, 36, 39, 72, 38, 68, 37, 64, 36, 192, 33, 104, 31, 56, 19, 64, 41, 144, 41, 184, 41, 220, 40 }, 470545, 470567, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 32, 80, 31, 160, 30, 208, 29, 0, 29, 0, 27, 32, 25, 96, 15, 0, 33, 78, 29, 192, 27, 234, 26, 235, 24, 247, 21, 36, 18, 224, 14, 63, 13, 17, 12, 100, 11, 137, 9, 0, 33, 132, 30, 226, 28, 194, 27, 18, 26, 236, 22, 139, 25, 252, 22, 238, 20, 91, 19, 196, 18, 226, 10, 0, 33, 9, 32, 17, 30, 9, 31 },
             new byte[] { 40, 36, 39, 72, 38, 68, 37, 64, 36, 192, 33, 104, 31, 56, 19, 64, 41, 162, 36, 176, 34, 165, 33, 38, 31, 117, 27, 173, 22, 152, 18, 143, 16, 21, 15, 61, 14, 235, 11, 64, 41, 37, 38, 27, 36, 179, 34, 151, 32, 167, 28, 238, 31, 187, 28, 42, 26, 50, 24, 117, 23, 155, 13, 64, 41, 11, 40, 149, 37, 203, 38 }, 470569, 470639, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 32, 96, 31, 160, 30, 160, 29, 0, 29, 0, 27, 32, 25, 96, 15, 0, 33, 64, 33, 128, 31, 192, 31 },
             new byte[] { 40, 56, 39, 72, 38, 8, 37, 64, 36, 192, 33, 104, 31, 56, 19, 64, 41, 144, 41, 96, 39, 176, 39 }, 470641, 470663, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 32, 96, 31, 160, 30, 160, 29, 0, 29, 0, 27, 32, 25, 96, 15, 0, 33, 64, 33, 9, 32, 5, 32 },
             new byte[] { 40, 56, 39, 72, 38, 8, 37, 64, 36, 192, 33, 104, 31, 56, 19, 64, 41, 144, 41, 11, 40, 6, 40 }, 470665, 470687, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 32, 96, 31, 160, 30, 160, 29, 0, 29, 0, 27, 32, 25, 96, 15, 0, 33, 64, 33, 0, 33, 128, 32 },
             new byte[] { 40, 56, 39, 72, 38, 8, 37, 64, 36, 192, 33, 104, 31, 56, 19, 64, 41, 144, 41, 64, 41, 160, 40 }, 470689, 470711, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 32, 96, 31, 160, 30, 160, 29, 0, 29, 0, 27, 32, 25, 96, 15, 0, 33, 64, 33, 64, 33, 160, 32 },
             new byte[] { 40, 56, 39, 72, 38, 8, 37, 64, 36, 192, 33, 104, 31, 56, 19, 64, 41, 144, 41, 144, 41, 200, 40 }, 470713, 470735, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 32, 96, 31, 160, 30, 160, 29, 0, 29, 0, 27, 32, 25, 96, 15, 0, 33, 64, 33, 96, 33, 192, 32 },
             new byte[] { 40, 56, 39, 72, 38, 8, 37, 64, 36, 192, 33, 104, 31, 56, 19, 64, 41, 144, 41, 184, 41, 240, 40 }, 470737, 470759, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 32, 96, 31, 160, 30, 160, 29, 0, 29, 0, 27, 32, 25, 96, 15, 0, 33, 64, 33, 96, 33, 192, 32 },
             new byte[] { 40, 56, 39, 72, 38, 8, 37, 64, 36, 192, 33, 104, 31, 56, 19, 64, 41, 144, 41, 184, 41, 240, 40 }, 470761, 470783, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 32, 96, 31, 160, 30, 160, 29, 0, 29, 0, 27, 32, 25, 96, 15, 0, 33, 64, 33, 96, 33, 192, 32 },
             new byte[] { 40, 56, 39, 72, 38, 8, 37, 64, 36, 192, 33, 104, 31, 56, 19, 64, 41, 144, 41, 184, 41, 240, 40 }, 470785, 470807, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 32, 96, 31, 160, 30, 160, 29, 0, 29, 0, 27, 32, 25, 96, 15 },
             new byte[] { 40, 56, 39, 72, 38, 8, 37, 64, 36, 192, 33, 104, 31, 56, 19 }, 470809, 470823, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 224, 27, 0, 33, 32, 33, 192, 33, 192, 33, 192, 32 },
             new byte[] { 216, 34, 64, 41, 104, 41, 48, 42, 48, 42, 240, 40 }, 471064, 471075, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 32, 96, 31, 160, 30, 0, 30, 96, 29, 128, 27, 160, 25, 128, 19, 96, 15, 224, 7 },
             new byte[] { 40, 56, 39, 72, 38, 128, 37, 184, 36, 96, 34, 8, 32, 96, 24, 56, 19, 216, 9 }, 471077, 471095, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 160, 76, 160, 81, 192, 81, 160, 81, 160, 81, 224, 80 },
             new byte[] { 70, 107, 70, 114, 115, 114, 70, 114, 70, 114, 58, 113 }, 471116, 471127, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 80, 64, 79, 96, 78, 64, 77, 96, 76, 0, 74, 160, 71, 224, 65, 128, 61, 32, 59 },
             new byte[] { 112, 243, 110, 186, 109, 38, 108, 237, 106, 154, 103, 70, 100, 58, 92, 26, 86, 198, 82 }, 471129, 471147, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 160, 76, 160, 81, 192, 81, 160, 81, 160, 81, 224, 80 },
             new byte[] { 70, 107, 70, 114, 115, 114, 70, 114, 70, 114, 58, 113 }, 471156, 471167, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 80, 64, 79, 96, 78, 64, 77, 96, 76, 0, 74, 160, 71, 224, 65, 128, 61, 32, 59 },
             new byte[] { 112, 243, 110, 186, 109, 38, 108, 237, 106, 154, 103, 70, 100, 58, 92, 26, 86, 198, 82 }, 471169, 471187, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 0, 33, 0, 33, 0, 33, 0, 33, 0, 33, 0, 33, 0, 33, 0, 33, 0, 33, 0, 33, 48, 34, 48, 34, 48, 34, 48, 34, 48, 34, 48, 34, 48, 34, 48, 34, 48, 34, 48, 34, 96, 33, 96, 33, 96, 33, 96, 33, 96, 33, 96, 33, 96, 33, 96, 33, 96, 33, 96, 33, 224, 33, 224, 33, 224, 33, 224, 33, 224, 33, 224, 33, 224, 33, 224, 33, 224, 33, 224, 33, 96, 34, 96, 34, 96, 34, 96, 34, 96, 34, 96, 34, 96, 34, 96, 34, 96, 34, 96, 34, 16, 34, 16, 34, 16, 34, 16, 34, 16, 34, 16, 34, 16, 34, 16, 34, 16, 34, 16, 34, 192, 33, 192, 33, 192, 33, 192, 33, 192, 33, 192, 33, 192, 33, 192, 33, 192, 33, 192, 33, 240, 30, 240, 30, 240, 30, 240, 30, 240, 30, 240, 30, 240, 30, 240, 30, 240, 30, 240, 30, 32, 28, 32, 28, 32, 28, 32, 28, 32, 28, 32, 28, 32, 28, 32, 28, 32, 28, 32, 28, 32, 28, 32, 28, 32, 28, 32, 28, 32, 28, 32, 28, 32, 28, 32, 28, 32, 28, 32, 28, 64, 26, 64, 26, 64, 26, 64, 26, 64, 26, 64, 26, 64, 26, 64, 26, 64, 26, 64, 26, 96, 15, 96, 15, 96, 15, 96, 15, 96, 15, 96, 15, 96, 15, 96, 15, 96, 15, 96, 15 },
             new byte[] { 64, 41, 64, 41, 64, 41, 64, 41, 64, 41, 64, 41, 64, 41, 64, 41, 64, 41, 64, 41, 188, 42, 188, 42, 188, 42, 188, 42, 188, 42, 188, 42, 188, 42, 188, 42, 188, 42, 188, 42, 184, 41, 184, 41, 184, 41, 184, 41, 184, 41, 184, 41, 184, 41, 184, 41, 184, 41, 184, 41, 88, 42, 88, 42, 88, 42, 88, 42, 88, 42, 88, 42, 88, 42, 88, 42, 88, 42, 88, 42, 248, 42, 248, 42, 248, 42, 248, 42, 248, 42, 248, 42, 248, 42, 248, 42, 248, 42, 248, 42, 148, 42, 148, 42, 148, 42, 148, 42, 148, 42, 148, 42, 148, 42, 148, 42, 148, 42, 148, 42, 48, 42, 48, 42, 48, 42, 48, 42, 48, 42, 48, 42, 48, 42, 48, 42, 48, 42, 48, 42, 172, 38, 172, 38, 172, 38, 172, 38, 172, 38, 172, 38, 172, 38, 172, 38, 172, 38, 172, 38, 40, 35, 40, 35, 40, 35, 40, 35, 40, 35, 40, 35, 40, 35, 40, 35, 40, 35, 40, 35, 40, 35, 40, 35, 40, 35, 40, 35, 40, 35, 40, 35, 40, 35, 40, 35, 40, 35, 40, 35, 208, 32, 208, 32, 208, 32, 208, 32, 208, 32, 208, 32, 208, 32, 208, 32, 208, 32, 208, 32, 56, 19, 56, 19, 56, 19, 56, 19, 56, 19, 56, 19, 56, 19, 56, 19, 56, 19, 56, 19 }, 471404, 471643, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 0, 35, 0, 35, 0, 35, 0, 35, 0, 35 },
             new byte[] { 128, 37, 128, 37, 128, 37, 128, 37, 128, 37 }, 488074, 488083, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 0, 35, 0, 35, 0, 35, 0, 35, 0, 35 },
             new byte[] { 128, 37, 128, 37, 128, 37, 128, 37, 128, 37 }, 488110, 488119, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 0, 35, 0, 35, 0, 35, 0, 35, 0, 35 },
             new byte[] { 128, 37, 128, 37, 128, 37, 128, 37, 128, 37 }, 488146, 488155, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 0, 35, 0, 35, 0, 35, 0, 35, 0, 35 },
             new byte[] { 128, 37, 128, 37, 128, 37, 128, 37, 128, 37 }, 488182, 488191, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 0, 35, 0, 35, 0, 35, 0, 35, 0, 35 },
             new byte[] { 128, 37, 128, 37, 128, 37, 128, 37, 128, 37 }, 488218, 488227, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 0, 35, 0, 35, 0, 35, 0, 35, 0, 35 },
             new byte[] { 128, 37, 128, 37, 128, 37, 128, 37, 128, 37 }, 488254, 488263, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 0, 35, 0, 35, 0, 35, 0, 35, 0, 35 },
             new byte[] { 128, 37, 128, 37, 128, 37, 128, 37, 128, 37 }, 488290, 488299, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 0, 35, 0, 35, 0, 35, 0, 35, 0, 35 },
             new byte[] { 128, 37, 128, 37, 128, 37, 128, 37, 128, 37 }, 488326, 488335, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 0, 35, 0, 35, 0, 35, 0, 35, 0, 35 },
             new byte[] { 128, 37, 128, 37, 128, 37, 128, 37, 128, 37 }, 488362, 488371, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 0, 35, 0, 35, 0, 35, 0, 35, 0, 35 },
             new byte[] { 128, 37, 128, 37, 128, 37, 128, 37, 128, 37 }, 488398, 488407, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 0, 35, 0, 35, 0, 35, 0, 35, 0, 35 },
             new byte[] { 128, 37, 128, 37, 128, 37, 128, 37, 128, 37 }, 488434, 488443, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 0, 35, 0, 35, 0, 35, 0, 35, 0, 35 },
             new byte[] { 128, 37, 128, 37, 128, 37, 128, 37, 128, 37 }, 488470, 488479, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 0, 35, 0, 35, 0, 35, 0, 35, 0, 35 },
             new byte[] { 128, 37, 128, 37, 128, 37, 128, 37, 128, 37 }, 488506, 488515, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 0, 35, 0, 35, 0, 35, 0, 35, 0, 35 },
             new byte[] { 128, 37, 128, 37, 128, 37, 128, 37, 128, 37 }, 488542, 488551, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 0, 35, 0, 35, 0, 35, 0, 35, 0, 35 },
             new byte[] { 128, 37, 128, 37, 128, 37, 128, 37, 128, 37 }, 488578, 488587, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 0, 35, 0, 35, 0, 35, 0, 35, 0, 35 },
             new byte[] { 128, 37, 128, 37, 128, 37, 128, 37, 128, 37 }, 488614, 488623, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 0, 35, 0, 35, 0, 35, 0, 35, 0, 35 },
             new byte[] { 128, 37, 128, 37, 128, 37, 128, 37, 128, 37 }, 488650, 488659, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 0, 35, 0, 35, 0, 35, 0, 35, 0, 35 },
             new byte[] { 128, 37, 128, 37, 128, 37, 128, 37, 128, 37 }, 488686, 488695, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 29 },
             new byte[] { 136 }, 488726, 488726, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 29 },
             new byte[] { 236 }, 488728, 488728, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 29, 19 },
             new byte[] { 80, 20 }, 488730, 488731, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 252, 18, 252, 18, 252, 18 },
             new byte[] { 136, 19, 236, 19, 80, 20 }, 488762, 488767, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 222, 18, 222, 18, 222, 18 },
             new byte[] { 136, 19, 236, 19, 80, 20 }, 488798, 488803, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 44 },
             new byte[] { 136 }, 488834, 488834, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 44 },
             new byte[] { 236 }, 488836, 488836, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 44, 19 },
             new byte[] { 80, 20 }, 488838, 488839, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 106 },
             new byte[] { 136 }, 488870, 488870, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 106 },
             new byte[] { 236 }, 488872, 488872, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 106, 19 },
             new byte[] { 80, 20 }, 488874, 488875, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 83 },
             new byte[] { 136 }, 488906, 488906, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 83 },
             new byte[] { 236 }, 488908, 488908, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 83, 19 },
             new byte[] { 80, 20 }, 488910, 488911, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 145, 18, 145, 18, 145, 18 },
             new byte[] { 136, 19, 236, 19, 80, 20 }, 488942, 488947, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 182, 18, 182, 18, 182, 18 },
             new byte[] { 136, 19, 236, 19, 80, 20 }, 488978, 488983, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 122, 18, 122, 18, 122, 18 },
             new byte[] { 136, 19, 236, 19, 80, 20 }, 489014, 489019, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 182, 18, 182, 18, 182, 18 },
             new byte[] { 136, 19, 236, 19, 80, 20 }, 489050, 489055, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 148 },
             new byte[] { 136 }, 489086, 489086, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 148 },
             new byte[] { 236 }, 489088, 489088, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 148, 19 },
             new byte[] { 80, 20 }, 489090, 489091, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 111, 20, 111, 20, 111 },
             new byte[] { 136, 19, 236, 19, 80 }, 489122, 489126, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 83, 18, 83, 18, 83, 18 },
             new byte[] { 136, 19, 236, 19, 80, 20 }, 489158, 489163, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 19 },
             new byte[] { 136 }, 489194, 489194, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 19 },
             new byte[] { 236 }, 489196, 489196, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 19, 19 },
             new byte[] { 80, 20 }, 489198, 489199, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 178, 18, 178, 18, 178, 18 },
             new byte[] { 136, 19, 236, 19, 80, 20 }, 489230, 489235, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 178, 18, 178, 18, 178, 18 },
             new byte[] { 136, 19, 236, 19, 80, 20 }, 489266, 489271, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 178, 18, 178, 18, 178, 18 },
             new byte[] { 136, 19, 236, 19, 80, 20 }, 489302, 489307, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 178, 18, 178, 18, 178, 18 },
             new byte[] { 136, 19, 236, 19, 80, 20 }, 489338, 489343, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 0, 35, 0, 35, 0, 35 },
             new byte[] { 128, 37, 128, 37, 128, 37 }, 489998, 490003, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 0, 35, 0, 35, 0, 35 },
             new byte[] { 128, 37, 128, 37, 128, 37 }, 490034, 490039, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 0, 35, 0, 35, 0, 35 },
             new byte[] { 128, 37, 128, 37, 128, 37 }, 490070, 490075, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 0, 35, 0, 35, 0, 35 },
             new byte[] { 128, 37, 128, 37, 128, 37 }, 490106, 490111, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 0, 35, 0, 35, 0, 35 },
             new byte[] { 128, 37, 128, 37, 128, 37 }, 490142, 490147, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 0, 35, 0, 35, 0, 35 },
             new byte[] { 128, 37, 128, 37, 128, 37 }, 490178, 490183, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 0, 35, 0, 35, 0, 35 },
             new byte[] { 128, 37, 128, 37, 128, 37 }, 490214, 490219, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 0, 35, 0, 35, 0, 35 },
             new byte[] { 128, 37, 128, 37, 128, 37 }, 490250, 490255, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 0, 35, 0, 35, 0, 35 },
             new byte[] { 128, 37, 128, 37, 128, 37 }, 490286, 490291, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 0, 35, 0, 35, 0, 35 },
             new byte[] { 128, 37, 128, 37, 128, 37 }, 490322, 490327, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 0, 35, 0, 35, 0, 35 },
             new byte[] { 128, 37, 128, 37, 128, 37 }, 490358, 490363, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 0, 35, 0, 35, 0, 35 },
             new byte[] { 128, 37, 128, 37, 128, 37 }, 490394, 490399, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 0, 35, 0, 35, 0, 35 },
             new byte[] { 128, 37, 128, 37, 128, 37 }, 490430, 490435, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 0, 35, 0, 35, 0, 35 },
             new byte[] { 128, 37, 128, 37, 128, 37 }, 490466, 490471, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 0, 35, 0, 35, 0, 35 },
             new byte[] { 128, 37, 128, 37, 128, 37 }, 490502, 490507, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 0, 35, 0, 35, 0, 35 },
             new byte[] { 128, 37, 128, 37, 128, 37 }, 490538, 490543, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 0, 35, 0, 35, 0, 35 },
             new byte[] { 128, 37, 128, 37, 128, 37 }, 490574, 490579, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 0, 35, 0, 35, 0, 35 },
             new byte[] { 128, 37, 128, 37, 128, 37 }, 490610, 490615, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 136 },
             new byte[] { 236 }, 490648, 490648, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 136, 19 },
             new byte[] { 80, 20 }, 490650, 490651, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 136 },
             new byte[] { 236 }, 490684, 490684, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 136, 19 },
             new byte[] { 80, 20 }, 490686, 490687, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 136 },
             new byte[] { 236 }, 490720, 490720, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 136, 19 },
             new byte[] { 80, 20 }, 490722, 490723, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 176 },
             new byte[] { 236 }, 490756, 490756, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 176, 19 },
             new byte[] { 80, 20 }, 490758, 490759, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 66 },
             new byte[] { 136 }, 490790, 490790, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 66 },
             new byte[] { 236 }, 490792, 490792, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 66, 19 },
             new byte[] { 80, 20 }, 490794, 490795, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 96 },
             new byte[] { 136 }, 490826, 490826, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 96 },
             new byte[] { 236 }, 490828, 490828, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 96, 19 },
             new byte[] { 80, 20 }, 490830, 490831, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 96 },
             new byte[] { 136 }, 490862, 490862, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 96 },
             new byte[] { 236 }, 490864, 490864, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 96, 19 },
             new byte[] { 80, 20 }, 490866, 490867, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 236 },
             new byte[] { 136 }, 490898, 490898, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 236, 19 },
             new byte[] { 80, 20 }, 490902, 490903, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 6 },
             new byte[] { 136 }, 490934, 490934, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 6 },
             new byte[] { 236 }, 490936, 490936, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 6, 19 },
             new byte[] { 80, 20 }, 490938, 490939, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 26 },
             new byte[] { 136 }, 490970, 490970, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 26 },
             new byte[] { 236 }, 490972, 490972, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 26, 19 },
             new byte[] { 80, 20 }, 490974, 490975, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 242, 18, 242, 18, 242, 18 },
             new byte[] { 136, 19, 236, 19, 80, 20 }, 491006, 491011, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 242, 18, 242, 18, 242, 18 },
             new byte[] { 136, 19, 236, 19, 80, 20 }, 491042, 491047, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 242, 18, 242, 18, 242, 18 },
             new byte[] { 136, 19, 236, 19, 80, 20 }, 491078, 491083, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 242, 18, 242, 18, 242, 18 },
             new byte[] { 136, 19, 236, 19, 80, 20 }, 491114, 491119, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 242, 18, 242, 18, 242, 18 },
             new byte[] { 136, 19, 236, 19, 80, 20 }, 491150, 491155, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 242, 18, 242, 18, 242, 18 },
             new byte[] { 136, 19, 236, 19, 80, 20 }, 491186, 491191, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 242, 18, 242, 18, 242, 18 },
             new byte[] { 136, 19, 236, 19, 80, 20 }, 491222, 491227, "Found egr map...Delete map");
            ToolBox.ReplaceInFileWithStartStop(new byte[] { 242, 18, 242, 18, 242, 18 },
             new byte[] { 136, 19, 236, 19, 80, 20 }, 491258, 491263, "Found egr map...Delete map");
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