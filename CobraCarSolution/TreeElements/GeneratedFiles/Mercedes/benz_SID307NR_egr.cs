using ToolBoxNameSpace;

namespace CobraCarSolution.TreeElements.VAG
{
    class benz_SID307NR :MenuItem, ITreeItem  {
    public benz_SID307NR()  {
      Title = "benz_SID307NR";
      IsSolutionItem =  true;
      hasDtcSolution =  false;
      hasEgrSolution = true;
      hasTVASolution = false;
      hasFileCheckSize =false;
      hasDpfSolution =false;
      hasLamdaSolution =false;
      hasFLAPSSolution =false;
      hasStartStopSolution =false;
      hasADBlueSolution =false;
      hasReadinessSolution =false;
      hasImmoSolution =false;
      hasSpecialISolution =false;
      hasSpecialIISolution =false;
      hasSpecialIIISolution =false;
      specialISolutionDescription="";
      specialIISolutionDescription="";
      specialIIISolutionDescription="";
      desciption="";
      FileSizeArray = new int[]  { 0 };
    }

    public override async Task < bool > checkFileForEgr()  {
      bool validationEgrInFile = true;
      //Algo for checking dpf solution
      if (ToolBox.array.Length > 0)  {
		validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {13 },  149996    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {12 },  150012    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {13 },  150668    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {65,0,143,2 },  156168    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {52,3 },  159430    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {255,255,205,12 },  159442    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {93,73,60,79,2,83,83,83,112,83,140,83,156,82,237,80,110,79,204,77,141,76,73,75,217,73,51,71,141,69,66,68 },  173904    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {128,22,128,28,0,30,0,30,128,29,0,29,96,28,32,27,64,26,32,25,64,24,96,23,96,22,32,21 },  192282    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  192311    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {110,4,173,4,236,4,30 },  202310    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {80,5,125,5,170,5,220,5,94,6 },  202318    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {125,6,235,6,89,7,149,7,208,7,252,7,40 },  202330    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {72,8,72,8 },  202344    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {38 },  202350    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {98,7,158,7,218,7,22 },  202352    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {87,8,152,8,222,8,226,9 },  202360    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {158,7,243,7,72,8,132,8,192,8,2 },  202370    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {68,9,146,9,75,10 },  202382    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {220,7,35 },  202390    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {107,8,178,8,250,8,75,9,156,9,196,9,90,10 },  202394    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {220,7,49 },  202410    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {133,8,201,8,14 },  202414    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {105,9,196,9,40 },  202420    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {90,10 },  202426    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {40 },  202430    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {114,8,188,8,1 },  202432    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {69,9,143,9,216,9,40 },  202438    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {90,10 },  202446    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {51 },  202450    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {121,8,191,8,9 },  202452    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {84,9,158,9,232,9,40 },  202458    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {70,10 },  202466    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {12 },  202470    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {84,8,155,8,227,8,44 },  202472    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {114,9,185,9,251,9,30 },  202480    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {221,7,40 },  202490    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {114,8,174,8,233,8,55 },  202494    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {133,9,201,9,0 },  202502    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {183,7,253,7,67,8,121,8,174,8,249,8,69,9,141,9,236,9 },  202510    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {114,7,180,7,246,7,52 },  202530    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {114,8,185,8,0 },  202538    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {66,9,216,9 },  202544    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {48 },  202550    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {120,7,191,7,249,7,51 },  202552    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {117,8,184,8,252,8,100,9 },  202560    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {254,6,63,7,128,7,194,7,4 },  202570    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {66,8,128,8,197,8,252,8 },  202580    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {45 },  202590    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {97,6,150,6,203,6,255,6,52 },  202592    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {105,7,148,7,148,7 },  202602    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {15 },  203330    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {75,10,90,10,70,10,246,9,226,9,216,9 },  203332    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {15 },  203350    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {75,10,90,10,70,10,246,9,226,9,216,9 },  203352    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {15 },  203370    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {75,10,90,10,70,10,246,9,226,9,216,9 },  203372    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {15 },  203390    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {75,10,90,10,70,10,246,9,226,9,216,9 },  203392    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {15 },  203410    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {75,10,90,10,70,10,246,9,226,9,216,9 },  203412    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {116,9,196,9,236,9,217,9,166,9,146,9,116,9 },  203430    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {252,8,81,9,136,9,136,9,106,9,86,9,56,9 },  203450    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {112,8,202,8,252,8,11 },  203470    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {11 },  203478    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {6 },  203480    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {252,8 },  203482    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {2 },  203490    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {72,8,152,8,162,8,162,8,162,8,152,8 },  203492    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {95,4,159,4,159,4,159,4,159,4,159,4,159,4,159,4,159,4,159,4 },  204212    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {119,4,211,4,48 },  204244    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {182,5,84,6,84,6,84,6,84,6,84,6,84,6 },  204250    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {170,4,11 },  204276    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {124,5,29 },  204280    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {135,6,142,7,62,8,62,8,62,8,62,8 },  204284    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {231,4,83,5,207,5,126,6,249,6,28 },  204308    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {212,8,216,9,216,9,216,9 },  204320    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {33 },  204340    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {160,5,40 },  204342    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {217,6,91,7,147,8,86,9,65,10,65,10,65,10 },  204346    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {95,5,228,5,123,6,54 },  204372    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {184,7,244,8,136,9,80,10,80,10,80,10 },  204380    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {201,5,44 },  204404    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {194,6,147,7,18 },  204408    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {45 },  204414    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {166,9,80,10,80,10,80,10 },  204416    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {44 },  204436    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {158,6,30 },  204438    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {239,7,109,8,104,9,196,9,80,10,80,10,80,10 },  204442    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {93,6,233,6,111,7,69,8,188,8,141,9,196,9,90,10,90,10,90,10 },  204468    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {109,6,4 },  204500    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {142,7,98,8,219,8,154,9,20 },  204504    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  204514    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  204516    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  204518    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {137,6,32 },  204532    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {173,7,132,8,249,8,164,9,246,9,246,9,246,9,246,9 },  204536    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {175,6,46 },  204564    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {210,7,183,8,38 },  204568    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {226,9,226,9,226,9,226,9,226,9 },  204574    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {157,6,39 },  204596    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {215,7,191,8,126,9,206,9,206,9,206,9,206,9,206,9 },  204600    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {92,6,182,6,96,7,59,8,242,8,242,8,242,8,242,8,242,8,242,8 },  204628    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {25 },  204660    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {80,6,205,6,58,7,118,7,47 },  204662    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {47 },  204672    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {47 },  204674    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {47 },  204676    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {47 },  204678    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {15 },  206282    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {75,10,90,10,70,10,246,9,226,9,216,9 },  206284    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {15 },  206302    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {75,10,90,10,70,10,246,9,226,9,216,9 },  206304    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {15 },  206322    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {75,10,90,10,70,10,246,9,226,9,216,9 },  206324    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {15 },  206342    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {75,10,90,10,70,10,246,9,226,9,216,9 },  206344    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {15 },  206362    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {75,10,90,10,70,10,246,9,226,9,216,9 },  206364    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {116,9,196,9,236,9,217,9,166,9,146,9,116,9 },  206382    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {252,8,81,9,136,9,136,9,106,9,86,9,56,9 },  206402    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {112,8,202,8,252,8,11 },  206422    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {11 },  206430    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {6 },  206432    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {252,8 },  206434    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {27 },  206844    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {16 },  206846    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {128,4,20 },  206848    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {140,5,140,5,140,5,140,5,140,5,140,5 },  206852    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {86,4,126,4,0 },  206876    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {230,5,84,6,84,6,84,6,84,6,84,6,84,6 },  206882    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {51 },  206908    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {141,4,24 },  206910    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {211,5,132,6,254,6,243,7,62,8,62,8,62,8 },  206914    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {76 },  206940    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {176,4,120,5,64,6,53,7,223,7,69,8,222,8,216,9,216,9 },  206942    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  206972    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {170,5,64,6,58,7,158,7,102,8,152,8,26 },  206974    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {65,10,65,10 },  206988    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {184,5,13 },  207004    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {214,6,208,7,52,8,102,8,152,8,46 },  207008    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {80,10,80,10 },  207020    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {14 },  207036    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64,6,239,6,208,7,52 },  207038    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {112,8,182,8,96,9,80,10,80,10 },  207046    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {250,5,105,6,8 },  207068    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {208,7,112,8,162,8,252,8,196,9,80,10,80,10 },  207074    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {231,5,144,6,90,7,38 },  207100    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {152,8,227,8,96,9,60,10,60,10,60,10 },  207108    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {240,5,189,6,149,7,72,8,177,8,252,8,146,9,20 },  207132    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  207148    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  207150    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {245,5,213,6,163,7,87,8,207,8,21 },  207164    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {246,9,246,9,246,9,246,9 },  207176    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {4 },  207196    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {222,6,170,7,74,8,207,8,46 },  207198    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {226,9,226,9,226,9,226,9 },  207208    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {245,5,182,6,148,7,61 },  207228    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {208,8,136,9,206,9,206,9,206,9,206,9 },  207236    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {212,5,117,6,97,7,72,8,172,8,242,8,242,8,242,8,242,8,242,8 },  207260    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {97,5,200,5,80,6,205,6,58 },  207292    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {118,7,47 },  207302    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {47 },  207306    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {47 },  207308    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {47 },  207310    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {60,7,114,7,169,7,224,7,22 },  210170    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {153,8,28 },  210180    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {38 },  210184    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {221,9 },  210186    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {161,10,194,10,227,10,3 },  210190    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {36 },  210198    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {81,11,125,11,217,10,163,10 },  210200    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {28 },  210210    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {91,9,178,9,245,9,56,10,129,10,208,10,32 },  210212    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {96,11 },  210226    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {248,8,67,9,142,9,217,9,36 },  210230    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {120,10,210,10,15 },  210240    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {72,11 },  210246    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {82,9,157,9,233,9,53 },  210250    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {128,10,174,10,9 },  210258    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {114,11,95,11 },  210264    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {129,9,220,9,55 },  210270    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {146,10,237,10,41 },  210276    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {101,11,29 },  210282    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {212,11 },  210286    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {72,10,156,10,240,10,68,11,151,11,212,11,17 },  210290    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {125,12,60,12 },  210304    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {219,10,45 },  210310    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {126,11,207,11,33 },  210314    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {126,12,219,12,6 },  210320    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {181,12 },  210326    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {16 },  210330    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {106,11,197,11,31 },  210332    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {121,12,220,12,63,13,97,13,63,13 },  210338    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {27 },  210350    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {118,11,209,11,44 },  210352    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {135,12,236,12,81,13,149,13,134,13 },  210358    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {24 },  210370    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {124,11,204,11,47 },  210372    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {128,12,242,12,77,13,172,13,234,13 },  210378    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {24 },  210390    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {124,11,204,11,48 },  210392    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {128,12,228,12,72,13,127,13,236,13 },  210398    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {24 },  210410    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {124,11,204,11,48 },  210412    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {128,12,228,12,72,13,127,13,211,13 },  210418    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {24 },  210430    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {124,11,204,11,48 },  210432    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {128,12,228,12,72,13,127,13,153,13 },  210438    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {24 },  210450    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {124,11,204,11,48 },  210452    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {128,12,178,12,248,12,92,13,151,13 },  210458    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {136,11,39,12,48,13,97,14,52,17,128,17,128,17,104,14,147,15,215,17,102,20,51,21,0,22,0,22,152,18,70,19,176,20,78,22,97,23,14,25,64,26,131,19,151,20,205,22,170,23,246,24,159,25,90,26,203,19,4,21,14,23,232,23,229,24,94,25,116,26,77,19,40,20,149,21,148,22,148,23,92,24 },  211570    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {26,182,18,135,19,227,20,152,21,110,22,93,23,199,24,58,19,96,19,99,21,228,21,188,22,9,24,225,24,59,18,11,19,171,20,40,21,248,21,21,23,187,23,122,17,162,17,78,18,222,18,85,19,27,22,58,23,110,16,251,16,134,17,27,18,208,18,64,21,110,22,199,15,45,16,118,16,101,17,41,18,182,20,28,22,152,14,28,15,249,15,14,17,235,17,57,20,22,21,86,15,27,16,91,17,253,17,42,19,32,21,161,21 },  211653    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {23,8,102,8,181,8,226,8,14,9,219,8,167,8,221,8,23,9 },  212650    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {209,10,201,10,193,10,255,10,60,11,49,11,38,11,204,10,147,10 },  212670    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {223,9,9,10,72,10,135,10,206,10,14,11,84,11,156,11,255,11 },  212690    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {125,9,188,9,2 },  212710    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {82,10,137,10,219,10,36,11,111,11,159,11 },  212716    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {150,9,222,9,38,10,139,10,192,10,23,11,104,11,174,11,131,11 },  212730    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {222,9,60,10,153,10,219,10,29,11,128,11,226,11,79,12,230,11 },  212750    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {137,10,224,10,55,11,126,11,196,11,17,12,93,12,174,12,72,12 },  212770    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {227,10,55,11,138,11,221,11,48,12,141,12,234,12,38 },  212790    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {224,12 },  212806    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {43,11,125,11,207,11,42,12,132,12,215,12,42 },  212810    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {110 },  212824    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {81 },  212826    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64,11,156,11,248,11,65,12,138,12,237,12,81 },  212830    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {167 },  212844    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {152 },  212846    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64,11,154,11,254,11,63,12,138,12,244,12,86 },  212850    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {178 },  212864    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {210 },  212866    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64,11,154,11,254,11,48,12,128,12,231,12,72 },  212870    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {151 },  212884    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {222 },  212886    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64,11,154,11,254,11,48,12,128,12,248,12,92 },  212890    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {162 },  212904    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {202 },  212906    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64,11,154,11,254,11,48,12,128,12,248,12,92 },  212910    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {162 },  212924    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {187 },  212926    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64,11,154,11,254,11,48,12,128,12,208,12,248,12,22 },  212930    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {228,12 },  212946    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {136,11,39,12,48,13,97,14,52,17,128,17,128,17,104,14,147,15,215,17,102,20,51,21,0,22,0,22,152,18,70,19,176,20,78,22,97,23,14,25,64,26,131,19,151,20,205,22,170,23,246,24,159,25,90,26,203,19,4,21,14,23,232,23,229,24,94,25,116,26,77,19,40,20,149,21,148,22,148,23,92,24 },  214050    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {26,182,18,135,19,227,20,152,21,110,22,93,23,199,24,58,19,96,19,99,21,228,21,188,22,9,24,225,24,59,18,11,19,171,20,40,21,248,21,21,23,187,23,122,17,162,17,78,18,222,18,85,19,27,22,58,23,110,16,251,16,134,17,27,18,208,18,64,21,110,22,199,15,45,16,118,16,101,17,41,18,182,20,28,22,152,14,28,15,249,15,14,17,235,17,57,20,22,21,86,15,27,16,91,17,253,17,42,19,32,21,161,21 },  214133    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {223,10,230,9,21 },  269914    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {87 },  269920    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {87 },  269922    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {231,6,133 },  269924    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {59 },  269928    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {204,5,136 },  269930    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {22 },  269934    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {241,13,195,12,191,11,226,10,152,9,15 },  269950    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {149,8,48 },  269962    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {160,7,73 },  269966    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {184,6 },  269970    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {32,20,121,18,19 },  269986    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {225,15,30 },  269992    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {95,13,186,12,55 },  269996    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {99 },  270002    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {210,10,241,9 },  270004    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {223,10,230,9,21 },  270778    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {87 },  270784    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {87 },  270786    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {231,6,133 },  270788    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {59 },  270792    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {204,5,136 },  270794    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {22 },  270798    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {241,13,195,12,191,11,226,10,152,9,15 },  270814    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {149,8,48 },  270826    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {160,7,73 },  270830    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {184,6 },  270834    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {32,20,121,18,19 },  270850    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {225,15,30 },  270856    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {95,13,186,12,55 },  270860    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {99 },  270866    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {210,10,241,9 },  270868    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {106 },  309146    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {196 },  309148    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {60 },  309150    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {198 },  309152    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {238,5,238,5,238,5 },  309154    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {10 },  309178    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {100 },  309180    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {190 },  309182    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {220,5,14 },  309184    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {14 },  309188    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {14 },  309190    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {170 },  309210    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {4 },  309212    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {37 },  309214    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {37 },  309216    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {37 },  309218    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {37 },  309220    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {37 },  309222    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {245,5,47 },  309242    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {61 },  309246    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64 },  309248    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64 },  309250    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64 },  309252    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64 },  309254    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64 },  309274    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {92 },  309276    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {110 },  309278    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {114 },  309280    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {114 },  309282    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {114 },  309284    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {114 },  309286    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {55 },  309306    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64 },  309308    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64 },  309310    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64 },  309312    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64 },  309314    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64 },  309316    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64 },  309318    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {220,5,220,5,220,5,220,5,220,5,220,5,220,5 },  309338    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {16 },  309658    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {36 },  309660    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {56 },  309662    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {76 },  309664    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {86 },  309666    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {106 },  309668    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {106 },  309670    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {36 },  309690    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {76 },  309692    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {126 },  309694    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {176 },  309696    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {226,4,10 },  309698    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {10 },  309702    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {66 },  309722    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {166 },  309724    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {246,4,110 },  309726    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {120 },  309730    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {145 },  309732    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {145 },  309734    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {106 },  309754    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {176 },  309756    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {60 },  309758    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {225,5,238,5,238,5,238,5 },  309760    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {10 },  309786    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {100 },  309788    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {190 },  309790    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {220,5,10 },  309792    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {10 },  309796    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {10 },  309798    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {170 },  309818    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {4 },  309820    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {14 },  309822    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {37 },  309824    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {37 },  309826    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {37 },  309828    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {37 },  309830    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {245,5,58 },  309850    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {63 },  309854    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64 },  309856    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64 },  309858    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64 },  309860    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64 },  309862    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {193 },  310034    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {56 },  310036    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {199 },  310038    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {70 },  310040    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {70 },  310042    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {70 },  310044    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {70 },  310046    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3 },  310058    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {149 },  310060    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {119 },  310062    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {240,5,240,5,240,5,240,5 },  310064    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {172 },  310082    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {101 },  310084    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64 },  310086    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64 },  310088    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64 },  310090    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64 },  310092    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64 },  310094    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {58 },  310106    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {24 },  310108    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {114 },  310110    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {114 },  310112    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {114 },  310114    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {114 },  310116    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {114 },  310118    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {58 },  310130    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64 },  310132    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64 },  310134    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64 },  310136    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64 },  310138    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64 },  310140    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64 },  310142    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {68 },  310154    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {243,4,220,5,220,5,220,5,220,5,220,5 },  310156    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {23 },  312006    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {141 },  312008    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {184 },  312010    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {238,4,42 },  312012    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {70 },  312016    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {70 },  312018    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {61 },  312038    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {197 },  312040    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {250,4,8 },  312042    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {91 },  312046    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {155 },  312048    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {155 },  312050    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {99 },  312070    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {253,4,60 },  312072    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {84 },  312076    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {240,5,240,5,240,5 },  312078    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {214 },  312102    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {87 },  312104    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {157 },  312106    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {177 },  312108    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {24 },  312110    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {24 },  312112    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {24 },  312114    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {73 },  312134    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {178 },  312136    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {254,5,64 },  312138    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64 },  312142    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64 },  312144    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64 },  312146    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {161 },  312166    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {235,5,40 },  312168    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64 },  312172    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64 },  312174    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64 },  312176    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64 },  312178    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {249,5,36 },  312198    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {83 },  312202    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {114 },  312204    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {114 },  312206    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {114 },  312208    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {114 },  312210    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {8 },  312518    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {202 },  312520    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {164 },  312522    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {227,3,60 },  312524    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  312528    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  312530    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {232,3,242,3,19 },  312550    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {102 },  312556    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {169 },  312558    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {145 },  312560    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {145 },  312562    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {99 },  312582    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {183 },  312584    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {214 },  312586    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {57 },  312588    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {240,5,240,5,240,5 },  312590    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {168 },  312614    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {24 },  312616    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {91 },  312618    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {176 },  312620    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {24 },  312622    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {24 },  312624    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {24 },  312626    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {208 },  312646    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {92 },  312648    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {159 },  312650    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64 },  312652    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64 },  312654    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64 },  312656    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64 },  312658    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {0 },  312678    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {110 },  312680    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {220,5,64 },  312682    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64 },  312686    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64 },  312688    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64 },  312690    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {173 },  312710    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {24 },  312712    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64 },  312714    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64 },  312716    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64 },  312718    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64 },  312720    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64 },  312722    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {82 },  313542    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {163 },  313544    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {244,3,125 },  313546    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {219,4,20 },  313550    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {27 },  313554    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {214 },  313574    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {55 },  313576    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {89 },  313578    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {0 },  313580    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {79 },  313582    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {127 },  313584    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {137 },  313586    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {135 },  313606    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {0 },  313608    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {48 },  313610    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {164 },  313612    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {206 },  313614    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {220,5,220,5 },  313616    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {218 },  313638    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {74 },  313640    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {141 },  313642    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {226,5,24 },  313644    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {24 },  313648    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {24 },  313650    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {32 },  313670    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {142 },  313672    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {209 },  313674    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {17 },  313676    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64 },  313678    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64 },  313680    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64 },  313682    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {101 },  313702    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {211,5,20 },  313704    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64 },  313708    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64 },  313710    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64 },  313712    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64 },  313714    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {5 },  313734    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {14 },  313736    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {14 },  313738    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64 },  313740    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64 },  313742    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64 },  313744    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64 },  313746    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {82 },  314054    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {163 },  314056    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {244,3,125 },  314058    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {219,4,20 },  314062    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {27 },  314066    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {214 },  314086    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {55 },  314088    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {89 },  314090    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {0 },  314092    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {79 },  314094    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {127 },  314096    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {137 },  314098    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {135 },  314118    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {0 },  314120    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {48 },  314122    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {164 },  314124    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {206 },  314126    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {220,5,220,5 },  314128    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {218 },  314150    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {74 },  314152    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {141 },  314154    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {226,5,24 },  314156    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {24 },  314160    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {24 },  314162    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {32 },  314182    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {142 },  314184    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {209 },  314186    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {17 },  314188    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64 },  314190    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64 },  314192    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64 },  314194    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {101 },  314214    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {211,5,20 },  314216    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64 },  314220    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64 },  314222    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64 },  314224    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64 },  314226    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {5 },  314246    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {14 },  314248    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {14 },  314250    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64 },  314252    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64 },  314254    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64 },  314256    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64 },  314258    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {193 },  314430    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {56 },  314432    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {199 },  314434    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {70 },  314436    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {70 },  314438    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {70 },  314440    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {70 },  314442    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3 },  314454    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {149 },  314456    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {119 },  314458    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {240,5,240,5,240,5,240,5 },  314460    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {172 },  314478    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {101 },  314480    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64 },  314482    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64 },  314484    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64 },  314486    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64 },  314488    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64 },  314490    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {58 },  314502    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {24 },  314504    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {114 },  314506    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {114 },  314508    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {114 },  314510    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {114 },  314512    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {114 },  314514    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {58 },  314526    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64 },  314528    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64 },  314530    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64 },  314532    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64 },  314534    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64 },  314536    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64 },  314538    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {68 },  314550    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {243,4,220,5,220,5,220,5,220,5,220,5 },  314552    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {82 },  315054    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {212 },  315056    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {48 },  315058    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {143 },  315060    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {232,4,20 },  315062    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  315066    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {216 },  315086    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {55 },  315088    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {168 },  315090    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {21 },  315092    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {95 },  315094    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {145 },  315096    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {145 },  315098    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {137 },  315118    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {6 },  315120    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {74 },  315122    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {176 },  315124    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {240,5,240,5,240,5 },  315126    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {218 },  315150    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {74 },  315152    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {141 },  315154    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {226,5,24 },  315156    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {24 },  315160    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {24 },  315162    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {32 },  315182    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {142 },  315184    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {209 },  315186    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64 },  315188    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64 },  315190    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64 },  315192    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64 },  315194    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {101 },  315214    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {211,5,20 },  315216    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64 },  315220    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64 },  315222    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64 },  315224    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64 },  315226    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {5 },  315246    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {14 },  315248    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64 },  315250    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64 },  315252    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64 },  315254    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64 },  315256    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64 },  315258    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {82 },  315566    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {212 },  315568    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {48 },  315570    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {143 },  315572    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {232,4,20 },  315574    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  315578    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {216 },  315598    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {55 },  315600    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {168 },  315602    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {21 },  315604    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {95 },  315606    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {145 },  315608    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {145 },  315610    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {137 },  315630    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {6 },  315632    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {74 },  315634    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {176 },  315636    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {240,5,240,5,240,5 },  315638    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {218 },  315662    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {74 },  315664    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {141 },  315666    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {226,5,24 },  315668    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {24 },  315672    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {24 },  315674    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {32 },  315694    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {142 },  315696    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {209 },  315698    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64 },  315700    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64 },  315702    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64 },  315704    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64 },  315706    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {101 },  315726    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {211,5,20 },  315728    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64 },  315732    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64 },  315734    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64 },  315736    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64 },  315738    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {5 },  315758    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {14 },  315760    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64 },  315762    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64 },  315764    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64 },  315766    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64 },  315768    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64 },  315770    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {51 },  316590    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {76 },  316592    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {76 },  316594    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {166 },  316596    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {0 },  316598    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  316600    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  316602    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {166 },  316622    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {205 },  316624    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {65 },  316626    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {117 },  316628    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {131 },  316630    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {145 },  316632    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {145 },  316634    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {225,4,35 },  316654    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {126 },  316658    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {203 },  316660    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {240,5,240,5,240,5 },  316662    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {35 },  316686    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {190 },  316688    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {245,5,227,5,24 },  316690    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {24 },  316696    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {24 },  316698    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {134 },  316718    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {5 },  316720    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {30 },  316722    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64 },  316724    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64 },  316726    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64 },  316728    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64 },  316730    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {249,5,46 },  316750    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {40 },  316754    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64 },  316756    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64 },  316758    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64 },  316760    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64 },  316762    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {249,5,36 },  316782    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {83 },  316786    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {114 },  316788    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {114 },  316790    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {114 },  316792    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {114 },  316794    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {216 },  317102    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {226,4,20 },  317104    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {60 },  317108    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  317110    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  317112    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  317114    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {166 },  317134    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {205 },  317136    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {65 },  317138    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {117 },  317140    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {131 },  317142    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {145 },  317144    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {145 },  317146    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {225,4,35 },  317166    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {126 },  317170    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {203 },  317172    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {240,5,240,5,240,5 },  317174    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {35 },  317198    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {190 },  317200    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {245,5,227,5,24 },  317202    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {24 },  317208    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {24 },  317210    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {134 },  317230    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {5 },  317232    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {30 },  317234    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64 },  317236    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64 },  317238    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64 },  317240    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64 },  317242    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {249,5,46 },  317262    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {40 },  317266    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64 },  317268    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64 },  317270    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64 },  317272    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64 },  317274    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {249,5,36 },  317294    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {83 },  317298    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {114 },  317300    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {114 },  317302    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {114 },  317304    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {114 },  317306    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {114 },  318576    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {114 },  318578    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {114 },  318580    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {114 },  318582    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {114 },  318584    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {114 },  318586    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {114 },  318588    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {114 },  318590    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {43 },  377658    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {199,4,30 },  377660    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {141,7,205,7 },  377664    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {149,4,161,5,51 },  377674    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {107,8,54 },  377680    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {92,5,179,6,51 },  377690    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {216,8,77,10 },  377696    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {112,5,71,7,152,8,103,9,48 },  377706    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {124,5,139,7,205,8,198,9,234,9 },  377722    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {114,5,118,7,213,8,186,9,186,9 },  377738    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {66,5,66,7,134,8,242,8,242,8 },  377754    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {72,5,233,5,60,6,114,6,164,6 },  377846    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {47,6,95,7,79,8,11 },  377862    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {132,9 },  377870    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {181,6,244,7,252,8,182,9,130,10 },  377878    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {128,7,82,8,116,9,18 },  377894    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {136,10 },  377902    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {87,7,166,8,130,9,16 },  377910    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {93,10 },  377918    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {96,7,133,8,164,9,7 },  377926    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {140,10 },  377934    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {96,7,133,8,164,9,7 },  377942    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {140,10 },  377950    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {56,137,16,142,178,146,94,149,6,152,169,154,32,156,31,157,10,158,150,158,74,159,127,159,185,158,198,157,212,156,68,155 },  390262    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {32,224,35,0,36,64,36,128,36,96,35,192,33,128,32,0,31,0,30,0,29,160,27,64,25,32,24,32,23,224,21 },  419445    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {32,224,35,0,36,64,36,128,36,96,35,192,33,128,32,0,31,0,30,0,29,160,27,64,25,32,24,32,23,224,21 },  420333    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {192,78,128,82,128,82,128,82,128,82,64,81,128,79,32,78,160,76,96,75,32,74,128,72,128,70,128,68,64,66,96,64 },  420480    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {128,72,192,78,128,82,128,82,128,82,128,82,64,81,128,79,32,78,160,76,96,75,32,74,128,72,128,70,128,68,64,66,96,64 },  420518    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {192,42 },  420906    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {45 },  420917    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {128,43 },  420926    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {166,40 },  420936    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {166,37 },  420946    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {26,35 },  420956    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {166,31 },  420966    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {24,21,184,26,32,28,32,28,48,27,104,25,136,23,240,21,200,19,88,17,64,16,32,18,32,18,32,18,192,18,192,18,32,18,240,16,176,15,160,14,48,13 },  427144    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {128,37,128,37 },  427912    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {128,37,128,37 },  427948    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {128,37,128,37 },  427984    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {128,37,128,37 },  428020    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {128,37,128,37 },  428056    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {128,37,128,37 },  428092    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {128,37,128,37 },  428128    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {128,37,128,37 },  428164    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {128,37,128,37 },  428200    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {128,37,128,37 },  428236    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {128,37,128,37 },  428272    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {128,37,128,37 },  428308    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {128,37,128,37 },  428344    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {128,37,128,37 },  428380    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {128,37,128,37 },  428416    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {128,37,128,37 },  428452    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {128,37,128,37 },  428488    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {128,37,128,37 },  428524    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {174,21 },  428562    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {110,20 },  428598    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {180,20 },  428634    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {170,20 },  428670    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {179,21 },  428706    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {84,21 },  428742    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {120,20 },  428778    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {140,20 },  428814    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  428851    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {170,20 },  428886    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {140,20 },  428922    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {220,20 },  428958    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {180,20 },  428994    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {180,20 },  429030    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {130,20 },  429066    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {150,20 },  429102    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {94,21 },  429138    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {250,20 },  429174    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {32,38,96,39 },  429904    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {192,38 },  429940    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {40 },  429943    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64,40,32,41 },  429976    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {90,39,131,41 },  430012    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {92,39,136,41 },  430048    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {173,38,4,41 },  430084    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {209,38,161,40 },  430120    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {134,38,60,40 },  430156    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {92,38,35,40 },  430192    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {67,38,83,40 },  430228    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {52,38,91,40 },  430264    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {50,38,83,40 },  430300    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {179,37,212,39 },  430336    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {209,37,235,39 },  430372    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64,38,32,40 },  430408    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {192,38,64,40 },  430444    );
      }
      return validationEgrInFile;
    }
    public override async Task < bool > checkFileForDpf()  {
      bool validationEgrInFile = true;
      //Algo for checking dpf solution
      if (ToolBox.array.Length > 0)  {

      }
      return validationEgrInFile;

    }
    public override async Task < bool > checkFileForTva()  {
      bool validationEgrInFile = true;
      //Algo for checking dpf solution
      if (ToolBox.array.Length > 0)  {

      }
      return validationEgrInFile;
    }

    public override async Task < bool > checkFileForLamda()  {
      bool validationEgrInFile = true;
      //Algo for checking dpf solution
      if (ToolBox.array.Length > 0)  {

      }
      return validationEgrInFile;
    }

    public override async Task < bool > checkFileForFlaps()  {
      bool validationEgrInFile = true;
      //Algo for checking dpf solution
      if (ToolBox.array.Length > 0)  {

      }
      return validationEgrInFile;
    }

    public override async Task < bool > checkFileForStartStop()  {
      bool validationEgrInFile = true;
      //Algo for checking dpf solution
      if (ToolBox.array.Length > 0)  {

      }
      return validationEgrInFile;
    }

    public override async Task < bool > checkFileForAdBlue()  {
      bool validationEgrInFile = true;
      //Algo for checking dpf solution
      if (ToolBox.array.Length > 0)  {

      }
      return validationEgrInFile;
    }

    public override async Task < bool > checkFileForReadiness()  {
      bool validationEgrInFile = true;
      //Algo for checking dpf solution
      if (ToolBox.array.Length > 0)  {

      }
      return validationEgrInFile;
    }

    public override async Task < bool > checkFileForImmo()  {
      bool validationEgrInFile = true;
      //Algo for checking dpf solution
      if (ToolBox.array.Length > 0)  {

      }
      return validationEgrInFile;
    }

    public override async Task < bool > checkFileForSpecialI()  {
      bool validationEgrInFile = true;
      //Algo for checking dpf solution
      if (ToolBox.array.Length > 0)  {

      }
      return validationEgrInFile;
    }

    public override async Task < bool > checkFileForSpecialII()  {
      bool validationEgrInFile = true;
      //Algo for checking dpf solution
      if (ToolBox.array.Length > 0)  {

      }
      return validationEgrInFile;
    }

    public override async Task < bool > checkFileForSpecialIII()  {
      bool validationEgrInFile = true;
      //Algo for checking dpf solution
      if (ToolBox.array.Length > 0)  {

      }
      return validationEgrInFile;
    }

    public override void egrOffSolution()  {
	ToolBox.ReplaceInFileWithStartStop(new byte[]  {13 },
 new byte[]  { 0 },149996,149996, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {12 },
 new byte[]  { 0 },150012,150012, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {13 },
 new byte[]  { 0 },150668,150668, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {65,0,143,2 },
 new byte[]  { 255,255,0,0 },156168,156171, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {52,3 },
 new byte[]  { 255,255 },159430,159431, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {255,255,205,12 },
 new byte[]  { 0,0,0,0 },159442,159445, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {93,73,60,79,2,83,83,83,112,83,140,83,156,82,237,80,110,79,204,77,141,76,73,75,217,73,51,71,141,69,66,68 },
 new byte[]  { 52,79,164,86,123,91,253,91,62,92,126,92,106,91,97,89,146,87,148,85,19,84,137,82,195,80,107,77,90,75,188,73 },173904,173935, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {128,22,128,28,0,30,0,30,128,29,0,29,96,28,32,27,64,26,32,25,64,24,96,23,96,22,32,21 },
 new byte[]  { 32,28,186,35,183,37,210,37,76,37,197,36,20,36,150,34,144,33,55,32,46,31,35,30,237,28,99,27 },192282,192309, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 26 },192311,192311, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {110,4,173,4,236,4,30 },
 new byte[]  { 54,5,117,5,180,5,230 },202310,202316, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {80,5,125,5,170,5,220,5,94,6 },
 new byte[]  { 24,6,69,6,114,6,164,6,38,7 },202318,202327, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {125,6,235,6,89,7,149,7,208,7,252,7,40 },
 new byte[]  { 69,7,179,7,33,8,93,8,152,8,196,8,240 },202330,202342, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {72,8,72,8 },
 new byte[]  { 16,9,16,9 },202344,202347, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {38 },
 new byte[]  { 238 },202350,202350, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {98,7,158,7,218,7,22 },
 new byte[]  { 42,8,102,8,162,8,222 },202352,202358, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {87,8,152,8,222,8,226,9 },
 new byte[]  { 31,9,96,9,166,9,170,10 },202360,202367, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {158,7,243,7,72,8,132,8,192,8,2 },
 new byte[]  { 102,8,187,8,16,9,76,9,136,9,202 },202370,202380, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {68,9,146,9,75,10 },
 new byte[]  { 12,10,90,10,19,11 },202382,202387, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {220,7,35 },
 new byte[]  { 164,8,235 },202390,202392, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {107,8,178,8,250,8,75,9,156,9,196,9,90,10 },
 new byte[]  { 51,9,122,9,194,9,19,10,100,10,140,10,34,11 },202394,202407, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {220,7,49 },
 new byte[]  { 164,8,249 },202410,202412, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {133,8,201,8,14 },
 new byte[]  { 77,9,145,9,214 },202414,202418, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {105,9,196,9,40 },
 new byte[]  { 49,10,140,10,240 },202420,202424, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {90,10 },
 new byte[]  { 34,11 },202426,202427, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {40 },
 new byte[]  { 240 },202430,202430, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {114,8,188,8,1 },
 new byte[]  { 58,9,132,9,201 },202432,202436, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {69,9,143,9,216,9,40 },
 new byte[]  { 13,10,87,10,160,10,240 },202438,202444, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {90,10 },
 new byte[]  { 34,11 },202446,202447, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {51 },
 new byte[]  { 251 },202450,202450, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {121,8,191,8,9 },
 new byte[]  { 65,9,135,9,209 },202452,202456, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {84,9,158,9,232,9,40 },
 new byte[]  { 28,10,102,10,176,10,240 },202458,202464, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {70,10 },
 new byte[]  { 14,11 },202466,202467, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {12 },
 new byte[]  { 212 },202470,202470, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {84,8,155,8,227,8,44 },
 new byte[]  { 28,9,99,9,171,9,244 },202472,202478, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {114,9,185,9,251,9,30 },
 new byte[]  { 58,10,129,10,195,10,230 },202480,202486, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {221,7,40 },
 new byte[]  { 165,8,240 },202490,202492, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {114,8,174,8,233,8,55 },
 new byte[]  { 58,9,118,9,177,9,255 },202494,202500, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {133,9,201,9,0 },
 new byte[]  { 77,10,145,10,200 },202502,202506, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {183,7,253,7,67,8,121,8,174,8,249,8,69,9,141,9,236,9 },
 new byte[]  { 127,8,197,8,11,9,65,9,118,9,193,9,13,10,85,10,180,10 },202510,202527, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {114,7,180,7,246,7,52 },
 new byte[]  { 58,8,124,8,190,8,252 },202530,202536, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {114,8,185,8,0 },
 new byte[]  { 58,9,129,9,200 },202538,202542, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {66,9,216,9 },
 new byte[]  { 10,10,160,10 },202544,202547, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {48 },
 new byte[]  { 248 },202550,202550, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {120,7,191,7,249,7,51 },
 new byte[]  { 64,8,135,8,193,8,251 },202552,202558, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {117,8,184,8,252,8,100,9 },
 new byte[]  { 61,9,128,9,196,9,44,10 },202560,202567, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {254,6,63,7,128,7,194,7,4 },
 new byte[]  { 198,7,7,8,72,8,138,8,204 },202570,202578, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {66,8,128,8,197,8,252,8 },
 new byte[]  { 10,9,72,9,141,9,196,9 },202580,202587, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {45 },
 new byte[]  { 245 },202590,202590, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {97,6,150,6,203,6,255,6,52 },
 new byte[]  { 41,7,94,7,147,7,199,7,252 },202592,202600, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {105,7,148,7,148,7 },
 new byte[]  { 49,8,92,8,92,8 },202602,202607, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {15 },
 new byte[]  { 215 },203330,203330, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {75,10,90,10,70,10,246,9,226,9,216,9 },
 new byte[]  { 19,11,34,11,14,11,190,10,170,10,160,10 },203332,203343, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {15 },
 new byte[]  { 215 },203350,203350, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {75,10,90,10,70,10,246,9,226,9,216,9 },
 new byte[]  { 19,11,34,11,14,11,190,10,170,10,160,10 },203352,203363, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {15 },
 new byte[]  { 215 },203370,203370, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {75,10,90,10,70,10,246,9,226,9,216,9 },
 new byte[]  { 19,11,34,11,14,11,190,10,170,10,160,10 },203372,203383, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {15 },
 new byte[]  { 215 },203390,203390, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {75,10,90,10,70,10,246,9,226,9,216,9 },
 new byte[]  { 19,11,34,11,14,11,190,10,170,10,160,10 },203392,203403, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {15 },
 new byte[]  { 215 },203410,203410, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {75,10,90,10,70,10,246,9,226,9,216,9 },
 new byte[]  { 19,11,34,11,14,11,190,10,170,10,160,10 },203412,203423, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {116,9,196,9,236,9,217,9,166,9,146,9,116,9 },
 new byte[]  { 60,10,140,10,180,10,161,10,110,10,90,10,60,10 },203430,203443, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {252,8,81,9,136,9,136,9,106,9,86,9,56,9 },
 new byte[]  { 196,9,25,10,80,10,80,10,50,10,30,10,0,10 },203450,203463, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {112,8,202,8,252,8,11 },
 new byte[]  { 56,9,146,9,196,9,211 },203470,203476, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {11 },
 new byte[]  { 211 },203478,203478, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {6 },
 new byte[]  { 206 },203480,203480, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {252,8 },
 new byte[]  { 196,9 },203482,203483, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {2 },
 new byte[]  { 202 },203490,203490, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {72,8,152,8,162,8,162,8,162,8,152,8 },
 new byte[]  { 16,9,96,9,106,9,106,9,106,9,96,9 },203492,203503, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {95,4,159,4,159,4,159,4,159,4,159,4,159,4,159,4,159,4,159,4 },
 new byte[]  { 39,5,103,5,103,5,103,5,103,5,103,5,103,5,103,5,103,5,103,5 },204212,204231, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {119,4,211,4,48 },
 new byte[]  { 63,5,155,5,248 },204244,204248, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {182,5,84,6,84,6,84,6,84,6,84,6,84,6 },
 new byte[]  { 126,6,28,7,28,7,28,7,28,7,28,7,28,7 },204250,204263, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {170,4,11 },
 new byte[]  { 114,5,211 },204276,204278, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {124,5,29 },
 new byte[]  { 68,6,229 },204280,204282, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {135,6,142,7,62,8,62,8,62,8,62,8 },
 new byte[]  { 79,7,86,8,6,9,6,9,6,9,6,9 },204284,204295, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {231,4,83,5,207,5,126,6,249,6,28 },
 new byte[]  { 175,5,27,6,151,6,70,7,193,7,228 },204308,204318, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {212,8,216,9,216,9,216,9 },
 new byte[]  { 156,9,160,10,160,10,160,10 },204320,204327, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {33 },
 new byte[]  { 233 },204340,204340, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {160,5,40 },
 new byte[]  { 104,6,240 },204342,204344, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {217,6,91,7,147,8,86,9,65,10,65,10,65,10 },
 new byte[]  { 161,7,35,8,91,9,30,10,9,11,9,11,9,11 },204346,204359, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {95,5,228,5,123,6,54 },
 new byte[]  { 39,6,172,6,67,7,254 },204372,204378, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {184,7,244,8,136,9,80,10,80,10,80,10 },
 new byte[]  { 128,8,188,9,80,10,24,11,24,11,24,11 },204380,204391, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {201,5,44 },
 new byte[]  { 145,6,244 },204404,204406, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {194,6,147,7,18 },
 new byte[]  { 138,7,91,8,218 },204408,204412, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {45 },
 new byte[]  { 245 },204414,204414, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {166,9,80,10,80,10,80,10 },
 new byte[]  { 110,10,24,11,24,11,24,11 },204416,204423, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {44 },
 new byte[]  { 244 },204436,204436, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {158,6,30 },
 new byte[]  { 102,7,230 },204438,204440, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {239,7,109,8,104,9,196,9,80,10,80,10,80,10 },
 new byte[]  { 183,8,53,9,48,10,140,10,24,11,24,11,24,11 },204442,204455, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {93,6,233,6,111,7,69,8,188,8,141,9,196,9,90,10,90,10,90,10 },
 new byte[]  { 37,7,177,7,55,8,13,9,132,9,85,10,140,10,34,11,34,11,34,11 },204468,204487, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {109,6,4 },
 new byte[]  { 53,7,204 },204500,204502, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {142,7,98,8,219,8,154,9,20 },
 new byte[]  { 86,8,42,9,163,9,98,10,220 },204504,204512, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 220 },204514,204514, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 220 },204516,204516, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 220 },204518,204518, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {137,6,32 },
 new byte[]  { 81,7,232 },204532,204534, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {173,7,132,8,249,8,164,9,246,9,246,9,246,9,246,9 },
 new byte[]  { 117,8,76,9,193,9,108,10,190,10,190,10,190,10,190,10 },204536,204551, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {175,6,46 },
 new byte[]  { 119,7,246 },204564,204566, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {210,7,183,8,38 },
 new byte[]  { 154,8,127,9,238 },204568,204572, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {226,9,226,9,226,9,226,9,226,9 },
 new byte[]  { 170,10,170,10,170,10,170,10,170,10 },204574,204583, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {157,6,39 },
 new byte[]  { 101,7,239 },204596,204598, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {215,7,191,8,126,9,206,9,206,9,206,9,206,9,206,9 },
 new byte[]  { 159,8,135,9,70,10,150,10,150,10,150,10,150,10,150,10 },204600,204615, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {92,6,182,6,96,7,59,8,242,8,242,8,242,8,242,8,242,8,242,8 },
 new byte[]  { 36,7,126,7,40,8,3,9,186,9,186,9,186,9,186,9,186,9,186,9 },204628,204647, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {25 },
 new byte[]  { 225 },204660,204660, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {80,6,205,6,58,7,118,7,47 },
 new byte[]  { 24,7,149,7,2,8,62,8,247 },204662,204670, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {47 },
 new byte[]  { 247 },204672,204672, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {47 },
 new byte[]  { 247 },204674,204674, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {47 },
 new byte[]  { 247 },204676,204676, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {47 },
 new byte[]  { 247 },204678,204678, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {15 },
 new byte[]  { 215 },206282,206282, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {75,10,90,10,70,10,246,9,226,9,216,9 },
 new byte[]  { 19,11,34,11,14,11,190,10,170,10,160,10 },206284,206295, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {15 },
 new byte[]  { 215 },206302,206302, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {75,10,90,10,70,10,246,9,226,9,216,9 },
 new byte[]  { 19,11,34,11,14,11,190,10,170,10,160,10 },206304,206315, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {15 },
 new byte[]  { 215 },206322,206322, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {75,10,90,10,70,10,246,9,226,9,216,9 },
 new byte[]  { 19,11,34,11,14,11,190,10,170,10,160,10 },206324,206335, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {15 },
 new byte[]  { 215 },206342,206342, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {75,10,90,10,70,10,246,9,226,9,216,9 },
 new byte[]  { 19,11,34,11,14,11,190,10,170,10,160,10 },206344,206355, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {15 },
 new byte[]  { 215 },206362,206362, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {75,10,90,10,70,10,246,9,226,9,216,9 },
 new byte[]  { 19,11,34,11,14,11,190,10,170,10,160,10 },206364,206375, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {116,9,196,9,236,9,217,9,166,9,146,9,116,9 },
 new byte[]  { 60,10,140,10,180,10,161,10,110,10,90,10,60,10 },206382,206395, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {252,8,81,9,136,9,136,9,106,9,86,9,56,9 },
 new byte[]  { 196,9,25,10,80,10,80,10,50,10,30,10,0,10 },206402,206415, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {112,8,202,8,252,8,11 },
 new byte[]  { 56,9,146,9,196,9,211 },206422,206428, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {11 },
 new byte[]  { 211 },206430,206430, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {6 },
 new byte[]  { 206 },206432,206432, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {252,8 },
 new byte[]  { 196,9 },206434,206435, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {27 },
 new byte[]  { 215 },206844,206844, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {16 },
 new byte[]  { 192 },206846,206846, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {128,4,20 },
 new byte[]  { 67,5,240 },206848,206850, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {140,5,140,5,140,5,140,5,140,5,140,5 },
 new byte[]  { 124,6,124,6,124,6,124,6,124,6,124,6 },206852,206863, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {86,4,126,4,0 },
 new byte[]  { 24,5,56,5,193 },206876,206880, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {230,5,84,6,84,6,84,6,84,6,84,6,84,6 },
 new byte[]  { 181,6,28,7,28,7,28,7,28,7,28,7,28,7 },206882,206895, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {51 },
 new byte[]  { 231 },206908,206908, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {141,4,24 },
 new byte[]  { 65,5,210 },206910,206912, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {211,5,132,6,254,6,243,7,62,8,62,8,62,8 },
 new byte[]  { 146,6,76,7,183,7,180,8,6,9,6,9,6,9 },206914,206927, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {76 },
 new byte[]  { 251 },206940,206940, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {176,4,120,5,64,6,53,7,223,7,69,8,222,8,216,9,216,9 },
 new byte[]  { 96,5,52,6,1,7,4,8,161,8,0,9,146,9,160,10,160,10 },206942,206959, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 218 },206972,206972, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {170,5,64,6,58,7,158,7,102,8,152,8,26 },
 new byte[]  { 115,6,11,7,13,8,109,8,42,9,80,9,204 },206974,206986, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {65,10,65,10 },
 new byte[]  { 9,11,9,11 },206988,206991, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {184,5,13 },
 new byte[]  { 141,6,218 },207004,207006, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {214,6,208,7,52,8,102,8,152,8,46 },
 new byte[]  { 169,7,169,8,9,9,34,9,76,9,224 },207008,207018, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {80,10,80,10 },
 new byte[]  { 24,11,24,11 },207020,207023, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {14 },
 new byte[]  { 223 },207036,207036, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64,6,239,6,208,7,52 },
 new byte[]  { 11,7,188,7,158,8,255 },207038,207044, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {112,8,182,8,96,9,80,10,80,10 },
 new byte[]  { 40,9,107,9,22,10,24,11,24,11 },207046,207055, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {250,5,105,6,8 },
 new byte[]  { 188,6,43,7,206 },207068,207072, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {208,7,112,8,162,8,252,8,196,9,80,10,80,10 },
 new byte[]  { 149,8,56,9,90,9,180,9,129,10,24,11,24,11 },207074,207087, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {231,5,144,6,90,7,38 },
 new byte[]  { 161,6,78,7,32,8,235 },207100,207106, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {152,8,227,8,96,9,60,10,60,10,60,10 },
 new byte[]  { 93,9,157,9,32,10,2,11,2,11,2,11 },207108,207119, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {240,5,189,6,149,7,72,8,177,8,252,8,146,9,20 },
 new byte[]  { 169,6,125,7,94,8,14,9,117,9,183,9,80,10,220 },207132,207146, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 220 },207148,207148, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 220 },207150,207150, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {245,5,213,6,163,7,87,8,207,8,21 },
 new byte[]  { 171,6,149,7,106,8,27,9,147,9,209 },207164,207174, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {246,9,246,9,246,9,246,9 },
 new byte[]  { 190,10,190,10,190,10,190,10 },207176,207183, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {4 },
 new byte[]  { 184 },207196,207196, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {222,6,170,7,74,8,207,8,46 },
 new byte[]  { 157,7,110,8,8,9,144,9,232 },207198,207206, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {226,9,226,9,226,9,226,9 },
 new byte[]  { 170,10,170,10,170,10,170,10 },207208,207215, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {245,5,182,6,148,7,61 },
 new byte[]  { 169,6,114,7,85,8,249 },207228,207234, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {208,8,136,9,206,9,206,9,206,9,206,9 },
 new byte[]  { 138,9,74,10,150,10,150,10,150,10,150,10 },207236,207247, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {212,5,117,6,97,7,72,8,172,8,242,8,242,8,242,8,242,8,242,8 },
 new byte[]  { 139,6,53,7,41,8,17,9,110,9,186,9,186,9,186,9,186,9,186,9 },207260,207279, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {97,5,200,5,80,6,205,6,58 },
 new byte[]  { 17,6,127,6,10,7,137,7,252 },207292,207300, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {118,7,47 },
 new byte[]  { 44,8,247 },207302,207304, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {47 },
 new byte[]  { 247 },207306,207306, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {47 },
 new byte[]  { 247 },207308,207308, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {47 },
 new byte[]  { 247 },207310,207310, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {60,7,114,7,169,7,224,7,22 },
 new byte[]  { 4,8,58,8,113,8,168,8,222 },210170,210178, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {153,8,28 },
 new byte[]  { 97,9,228 },210180,210182, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {38 },
 new byte[]  { 238 },210184,210184, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {221,9 },
 new byte[]  { 165,10 },210186,210187, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {161,10,194,10,227,10,3 },
 new byte[]  { 105,11,138,11,171,11,203 },210190,210196, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {36 },
 new byte[]  { 236 },210198,210198, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {81,11,125,11,217,10,163,10 },
 new byte[]  { 25,12,69,12,161,11,107,11 },210200,210207, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {28 },
 new byte[]  { 228 },210210,210210, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {91,9,178,9,245,9,56,10,129,10,208,10,32 },
 new byte[]  { 35,10,122,10,189,10,0,11,73,11,152,11,232 },210212,210224, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {96,11 },
 new byte[]  { 40,12 },210226,210227, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {248,8,67,9,142,9,217,9,36 },
 new byte[]  { 192,9,11,10,86,10,161,10,236 },210230,210238, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {120,10,210,10,15 },
 new byte[]  { 64,11,154,11,215 },210240,210244, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {72,11 },
 new byte[]  { 16,12 },210246,210247, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {82,9,157,9,233,9,53 },
 new byte[]  { 26,10,101,10,177,10,253 },210250,210256, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {128,10,174,10,9 },
 new byte[]  { 72,11,118,11,209 },210258,210262, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {114,11,95,11 },
 new byte[]  { 58,12,39,12 },210264,210267, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {129,9,220,9,55 },
 new byte[]  { 73,10,164,10,255 },210270,210274, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {146,10,237,10,41 },
 new byte[]  { 90,11,181,11,241 },210276,210280, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {101,11,29 },
 new byte[]  { 45,12,229 },210282,210284, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {212,11 },
 new byte[]  { 156,12 },210286,210287, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {72,10,156,10,240,10,68,11,151,11,212,11,17 },
 new byte[]  { 16,11,100,11,184,11,12,12,95,12,156,12,217 },210290,210302, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {125,12,60,12 },
 new byte[]  { 69,13,4,13 },210304,210307, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {219,10,45 },
 new byte[]  { 163,11,245 },210310,210312, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {126,11,207,11,33 },
 new byte[]  { 70,12,151,12,233 },210314,210318, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {126,12,219,12,6 },
 new byte[]  { 70,13,163,13,206 },210320,210324, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {181,12 },
 new byte[]  { 125,13 },210326,210327, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {16 },
 new byte[]  { 216 },210330,210330, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {106,11,197,11,31 },
 new byte[]  { 50,12,141,12,231 },210332,210336, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {121,12,220,12,63,13,97,13,63,13 },
 new byte[]  { 65,13,164,13,7,14,41,14,7,14 },210338,210347, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {27 },
 new byte[]  { 227 },210350,210350, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {118,11,209,11,44 },
 new byte[]  { 62,12,153,12,244 },210352,210356, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {135,12,236,12,81,13,149,13,134,13 },
 new byte[]  { 79,13,180,13,25,14,93,14,78,14 },210358,210367, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {24 },
 new byte[]  { 224 },210370,210370, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {124,11,204,11,47 },
 new byte[]  { 68,12,148,12,247 },210372,210376, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {128,12,242,12,77,13,172,13,234,13 },
 new byte[]  { 72,13,186,13,21,14,116,14,178,14 },210378,210387, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {24 },
 new byte[]  { 224 },210390,210390, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {124,11,204,11,48 },
 new byte[]  { 68,12,148,12,248 },210392,210396, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {128,12,228,12,72,13,127,13,236,13 },
 new byte[]  { 72,13,172,13,16,14,71,14,180,14 },210398,210407, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {24 },
 new byte[]  { 224 },210410,210410, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {124,11,204,11,48 },
 new byte[]  { 68,12,148,12,248 },210412,210416, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {128,12,228,12,72,13,127,13,211,13 },
 new byte[]  { 72,13,172,13,16,14,71,14,155,14 },210418,210427, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {24 },
 new byte[]  { 224 },210430,210430, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {124,11,204,11,48 },
 new byte[]  { 68,12,148,12,248 },210432,210436, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {128,12,228,12,72,13,127,13,153,13 },
 new byte[]  { 72,13,172,13,16,14,71,14,97,14 },210438,210447, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {24 },
 new byte[]  { 224 },210450,210450, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {124,11,204,11,48 },
 new byte[]  { 68,12,148,12,248 },210452,210456, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {128,12,178,12,248,12,92,13,151,13 },
 new byte[]  { 72,13,122,13,192,13,36,14,95,14 },210458,210467, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {136,11,39,12,48,13,97,14,52,17,128,17,128,17,104,14,147,15,215,17,102,20,51,21,0,22,0,22,152,18,70,19,176,20,78,22,97,23,14,25,64,26,131,19,151,20,205,22,170,23,246,24,159,25,90,26,203,19,4,21,14,23,232,23,229,24,94,25,116,26,77,19,40,20,149,21,148,22,148,23,92,24 },
 new byte[]  { 106,14,49,15,124,16,249,17,129,21,224,21,224,21,16,18,135,19,94,22,148,25,149,26,150,27,150,27,99,23,61,24,5,26,13,28,103,29,131,31,4,33,157,24,250,25,196,28,218,29,125,31,82,32,62,33,12,25,152,26,44,29,64,30,128,31,25,32,121,33,127,24,149,25,101,27,168,28,237,29,235,30 },211570,211651, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {26,182,18,135,19,227,20,152,21,110,22,93,23,199,24,58,19,96,19,99,21,228,21,188,22,9,24,225,24,59,18,11,19,171,20,40,21,248,21,21,23,187,23,122,17,162,17,78,18,222,18,85,19,27,22,58,23,110,16,251,16,134,17,27,18,208,18,64,21,110,22,199,15,45,16,118,16,101,17,41,18,182,20,28,22,152,14,28,15,249,15,14,17,235,17,57,20,22,21,86,15,27,16,91,17,253,17,42,19,32,21,161,21 },
 new byte[]  { 33,210,23,220,24,151,26,126,27,142,28,190,29,139,31,141,24,190,24,79,27,244,27,8,29,177,30,197,31,89,23,100,24,121,26,25,27,35,28,144,29,101,30,115,22,167,22,132,23,61,24,214,24,102,28,214,29,43,21,225,21,148,22,84,23,61,24,97,27,230,28,100,20,231,20,70,21,123,22,120,23,196,26,146,28,234,18,150,19,180,20,27,22,57,23,54,26,85,27,240,19,240,20,144,22,99,23,234,24,118,27,30,28 },211653,211765, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {23,8,102,8,181,8,226,8,14,9,219,8,167,8,221,8,23,9 },
 new byte[]  { 132,9,205,9,23,10,61,10,99,10,30,10,217,9,12,10,53,10 },212650,212667, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {209,10,201,10,193,10,255,10,60,11,49,11,38,11,204,10,147,10 },
 new byte[]  { 30,12,1,12,230,11,33,12,92,12,73,12,55,12,209,11,146,11 },212670,212687, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {223,9,9,10,72,10,135,10,206,10,14,11,84,11,156,11,255,11 },
 new byte[]  { 243,10,25,11,86,11,147,11,217,11,23,12,92,12,162,12,242,12 },212690,212707, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {125,9,188,9,2 },
 new byte[]  { 118,10,177,10,244 },212710,212714, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {82,10,137,10,219,10,36,11,111,11,159,11 },
 new byte[]  { 68,11,122,11,204,11,20,12,94,12,129,12 },212716,212727, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {150,9,222,9,38,10,139,10,192,10,23,11,104,11,174,11,131,11 },
 new byte[]  { 138,10,209,10,23,11,125,11,176,11,6,12,85,12,157,12,97,12 },212730,212747, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {222,9,60,10,153,10,219,10,29,11,128,11,226,11,79,12,230,11 },
 new byte[]  { 217,10,54,11,146,11,210,11,18,12,116,12,213,12,65,13,204,12 },212750,212767, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {137,10,224,10,55,11,126,11,196,11,17,12,93,12,174,12,72,12 },
 new byte[]  { 139,11,226,11,56,12,125,12,194,12,13,13,88,13,168,13,53,13 },212770,212787, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {227,10,55,11,138,11,221,11,48,12,141,12,234,12,38 },
 new byte[]  { 237,11,64,12,146,12,228,12,53,13,146,13,172,13,172 },212790,212804, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {224,12 },
 new byte[]  { 172,13 },212806,212807, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {43,11,125,11,207,11,42,12,132,12,215,12,42 },
 new byte[]  { 65,12,145,12,225,12,60,13,149,13,172,13,172 },212810,212822, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {110 },
 new byte[]  { 172 },212824,212824, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {81 },
 new byte[]  { 172 },212826,212826, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64,11,156,11,248,11,65,12,138,12,237,12,81 },
 new byte[]  { 94,12,185,12,19,13,91,13,163,13,172,13,172 },212830,212842, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {167 },
 new byte[]  { 172 },212844,212844, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {152 },
 new byte[]  { 172 },212846,212846, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64,11,154,11,254,11,63,12,138,12,244,12,86 },
 new byte[]  { 100,12,188,12,32,13,96,13,171,13,172,13,172 },212850,212862, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {178 },
 new byte[]  { 172 },212864,212864, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {210 },
 new byte[]  { 172 },212866,212866, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64,11,154,11,254,11,48,12,128,12,231,12,72 },
 new byte[]  { 110,12,199,12,43,13,89,13,168,13,172,13,172 },212870,212882, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {151 },
 new byte[]  { 172 },212884,212884, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {222 },
 new byte[]  { 172 },212886,212886, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64,11,154,11,254,11,48,12,128,12,248,12,92 },
 new byte[]  { 121,12,209,12,52,13,98,13,172,13,172,13,172 },212890,212902, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {162 },
 new byte[]  { 172 },212904,212904, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {202 },
 new byte[]  { 172 },212906,212906, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64,11,154,11,254,11,48,12,128,12,248,12,92 },
 new byte[]  { 130,12,218,12,62,13,106,13,172,13,172,13,172 },212910,212922, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {162 },
 new byte[]  { 172 },212924,212924, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {187 },
 new byte[]  { 172 },212926,212926, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64,11,154,11,254,11,48,12,128,12,208,12,248,12,22 },
 new byte[]  { 172,12,6,13,106,13,151,13,172,13,172,13,172,13,172 },212930,212944, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {228,12 },
 new byte[]  { 172,13 },212946,212947, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {136,11,39,12,48,13,97,14,52,17,128,17,128,17,104,14,147,15,215,17,102,20,51,21,0,22,0,22,152,18,70,19,176,20,78,22,97,23,14,25,64,26,131,19,151,20,205,22,170,23,246,24,159,25,90,26,203,19,4,21,14,23,232,23,229,24,94,25,116,26,77,19,40,20,149,21,148,22,148,23,92,24 },
 new byte[]  { 106,14,49,15,124,16,249,17,129,21,224,21,224,21,16,18,135,19,94,22,148,25,149,26,150,27,150,27,99,23,61,24,5,26,13,28,103,29,131,31,4,33,157,24,250,25,196,28,218,29,125,31,82,32,62,33,12,25,152,26,44,29,64,30,128,31,25,32,121,33,127,24,149,25,101,27,168,28,237,29,235,30 },214050,214131, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {26,182,18,135,19,227,20,152,21,110,22,93,23,199,24,58,19,96,19,99,21,228,21,188,22,9,24,225,24,59,18,11,19,171,20,40,21,248,21,21,23,187,23,122,17,162,17,78,18,222,18,85,19,27,22,58,23,110,16,251,16,134,17,27,18,208,18,64,21,110,22,199,15,45,16,118,16,101,17,41,18,182,20,28,22,152,14,28,15,249,15,14,17,235,17,57,20,22,21,86,15,27,16,91,17,253,17,42,19,32,21,161,21 },
 new byte[]  { 33,210,23,220,24,151,26,126,27,142,28,190,29,139,31,141,24,190,24,79,27,244,27,8,29,177,30,197,31,89,23,100,24,121,26,25,27,35,28,144,29,101,30,115,22,167,22,132,23,61,24,214,24,102,28,214,29,43,21,225,21,148,22,84,23,61,24,97,27,230,28,100,20,231,20,70,21,123,22,120,23,196,26,146,28,234,18,150,19,180,20,27,22,57,23,54,26,85,27,240,19,240,20,144,22,99,23,234,24,118,27,30,28 },214133,214245, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {223,10,230,9,21 },
 new byte[]  { 106,11,101,10,137 },269914,269918, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {87 },
 new byte[]  { 194 },269920,269920, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {87 },
 new byte[]  { 181 },269922,269922, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {231,6,133 },
 new byte[]  { 63,7,216 },269924,269926, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {59 },
 new byte[]  { 139 },269928,269928, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {204,5,136 },
 new byte[]  { 22,6,207 },269930,269932, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {22 },
 new byte[]  { 87 },269934,269934, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {241,13,195,12,191,11,226,10,152,9,15 },
 new byte[]  { 163,14,102,13,85,12,109,11,19,10,131 },269950,269960, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {149,8,48 },
 new byte[]  { 3,9,153 },269962,269964, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {160,7,73 },
 new byte[]  { 2,8,166 },269966,269968, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {184,6 },
 new byte[]  { 14,7 },269970,269971, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {32,20,121,18,19 },
 new byte[]  { 34,21,101,19,238 },269986,269990, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {225,15,30 },
 new byte[]  { 172,16,211 },269992,269994, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {95,13,186,12,55 },
 new byte[]  { 10,14,93,13,211 },269996,270000, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {99 },
 new byte[]  { 245 },270002,270002, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {210,10,241,9 },
 new byte[]  { 93,11,112,10 },270004,270007, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {223,10,230,9,21 },
 new byte[]  { 106,11,101,10,137 },270778,270782, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {87 },
 new byte[]  { 194 },270784,270784, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {87 },
 new byte[]  { 181 },270786,270786, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {231,6,133 },
 new byte[]  { 63,7,216 },270788,270790, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {59 },
 new byte[]  { 139 },270792,270792, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {204,5,136 },
 new byte[]  { 22,6,207 },270794,270796, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {22 },
 new byte[]  { 87 },270798,270798, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {241,13,195,12,191,11,226,10,152,9,15 },
 new byte[]  { 163,14,102,13,85,12,109,11,19,10,131 },270814,270824, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {149,8,48 },
 new byte[]  { 3,9,153 },270826,270828, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {160,7,73 },
 new byte[]  { 2,8,166 },270830,270832, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {184,6 },
 new byte[]  { 14,7 },270834,270835, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {32,20,121,18,19 },
 new byte[]  { 34,21,101,19,238 },270850,270854, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {225,15,30 },
 new byte[]  { 172,16,211 },270856,270858, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {95,13,186,12,55 },
 new byte[]  { 10,14,93,13,211 },270860,270864, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {99 },
 new byte[]  { 245 },270866,270866, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {210,10,241,9 },
 new byte[]  { 93,11,112,10 },270868,270871, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {106 },
 new byte[]  { 140 },309146,309146, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {196 },
 new byte[]  { 233 },309148,309148, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {60 },
 new byte[]  { 100 },309150,309150, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {198 },
 new byte[]  { 242 },309152,309152, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {238,5,238,5,238,5 },
 new byte[]  { 28,6,28,6,28,6 },309154,309159, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {10 },
 new byte[]  { 49 },309178,309178, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {100 },
 new byte[]  { 141 },309180,309180, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {190 },
 new byte[]  { 234 },309182,309182, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {220,5,14 },
 new byte[]  { 9,6,61 },309184,309186, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {14 },
 new byte[]  { 61 },309188,309188, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {14 },
 new byte[]  { 61 },309190,309190, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {170 },
 new byte[]  { 214 },309210,309210, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {4 },
 new byte[]  { 50 },309212,309212, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {37 },
 new byte[]  { 84 },309214,309214, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {37 },
 new byte[]  { 84 },309216,309216, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {37 },
 new byte[]  { 84 },309218,309218, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {37 },
 new byte[]  { 84 },309220,309220, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {37 },
 new byte[]  { 84 },309222,309222, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {245,5,47 },
 new byte[]  { 35,6,94 },309242,309244, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {61 },
 new byte[]  { 109 },309246,309246, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64 },
 new byte[]  { 112 },309248,309248, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64 },
 new byte[]  { 112 },309250,309250, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64 },
 new byte[]  { 112 },309252,309252, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64 },
 new byte[]  { 112 },309254,309254, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64 },
 new byte[]  { 112 },309274,309274, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {92 },
 new byte[]  { 141 },309276,309276, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {110 },
 new byte[]  { 159 },309278,309278, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {114 },
 new byte[]  { 164 },309280,309280, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {114 },
 new byte[]  { 164 },309282,309282, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {114 },
 new byte[]  { 164 },309284,309284, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {114 },
 new byte[]  { 164 },309286,309286, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {55 },
 new byte[]  { 103 },309306,309306, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64 },
 new byte[]  { 112 },309308,309308, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64 },
 new byte[]  { 112 },309310,309310, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64 },
 new byte[]  { 112 },309312,309312, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64 },
 new byte[]  { 112 },309314,309314, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64 },
 new byte[]  { 112 },309316,309316, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64 },
 new byte[]  { 112 },309318,309318, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {220,5,220,5,220,5,220,5,220,5,220,5,220,5 },
 new byte[]  { 9,6,9,6,9,6,9,6,9,6,9,6,9,6 },309338,309351, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {16 },
 new byte[]  { 47 },309658,309658, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {36 },
 new byte[]  { 68 },309660,309660, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {56 },
 new byte[]  { 88 },309662,309662, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {76 },
 new byte[]  { 109 },309664,309664, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {86 },
 new byte[]  { 119 },309666,309666, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {106 },
 new byte[]  { 140 },309668,309668, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {106 },
 new byte[]  { 140 },309670,309670, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {36 },
 new byte[]  { 68 },309690,309690, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {76 },
 new byte[]  { 109 },309692,309692, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {126 },
 new byte[]  { 161 },309694,309694, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {176 },
 new byte[]  { 212 },309696,309696, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {226,4,10 },
 new byte[]  { 8,5,49 },309698,309700, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {10 },
 new byte[]  { 49 },309702,309702, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {66 },
 new byte[]  { 99 },309722,309722, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {166 },
 new byte[]  { 202 },309724,309724, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {246,4,110 },
 new byte[]  { 28,5,152 },309726,309728, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {120 },
 new byte[]  { 162 },309730,309730, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {145 },
 new byte[]  { 188 },309732,309732, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {145 },
 new byte[]  { 188 },309734,309734, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {106 },
 new byte[]  { 140 },309754,309754, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {176 },
 new byte[]  { 212 },309756,309756, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {60 },
 new byte[]  { 100 },309758,309758, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {225,5,238,5,238,5,238,5 },
 new byte[]  { 14,6,28,6,28,6,28,6 },309760,309767, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {10 },
 new byte[]  { 49 },309786,309786, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {100 },
 new byte[]  { 141 },309788,309788, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {190 },
 new byte[]  { 234 },309790,309790, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {220,5,10 },
 new byte[]  { 9,6,56 },309792,309794, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {10 },
 new byte[]  { 56 },309796,309796, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {10 },
 new byte[]  { 56 },309798,309798, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {170 },
 new byte[]  { 214 },309818,309818, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {4 },
 new byte[]  { 50 },309820,309820, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {14 },
 new byte[]  { 61 },309822,309822, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {37 },
 new byte[]  { 84 },309824,309824, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {37 },
 new byte[]  { 84 },309826,309826, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {37 },
 new byte[]  { 84 },309828,309828, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {37 },
 new byte[]  { 84 },309830,309830, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {245,5,58 },
 new byte[]  { 35,6,106 },309850,309852, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {63 },
 new byte[]  { 111 },309854,309854, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64 },
 new byte[]  { 112 },309856,309856, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64 },
 new byte[]  { 112 },309858,309858, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64 },
 new byte[]  { 112 },309860,309860, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64 },
 new byte[]  { 112 },309862,309862, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {193 },
 new byte[]  { 222 },310034,310034, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {56 },
 new byte[]  { 88 },310036,310036, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {199 },
 new byte[]  { 236 },310038,310038, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {70 },
 new byte[]  { 111 },310040,310040, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {70 },
 new byte[]  { 111 },310042,310042, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {70 },
 new byte[]  { 111 },310044,310044, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {70 },
 new byte[]  { 111 },310046,310046, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3 },
 new byte[]  { 34 },310058,310058, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {149 },
 new byte[]  { 184 },310060,310060, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {119 },
 new byte[]  { 161 },310062,310062, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {240,5,240,5,240,5,240,5 },
 new byte[]  { 30,6,30,6,30,6,30,6 },310064,310071, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {172 },
 new byte[]  { 208 },310082,310082, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {101 },
 new byte[]  { 142 },310084,310084, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64 },
 new byte[]  { 112 },310086,310086, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64 },
 new byte[]  { 112 },310088,310088, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64 },
 new byte[]  { 112 },310090,310090, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64 },
 new byte[]  { 112 },310092,310092, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64 },
 new byte[]  { 112 },310094,310094, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {58 },
 new byte[]  { 98 },310106,310106, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {24 },
 new byte[]  { 71 },310108,310108, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {114 },
 new byte[]  { 164 },310110,310110, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {114 },
 new byte[]  { 164 },310112,310112, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {114 },
 new byte[]  { 164 },310114,310114, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {114 },
 new byte[]  { 164 },310116,310116, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {114 },
 new byte[]  { 164 },310118,310118, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {58 },
 new byte[]  { 98 },310130,310130, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64 },
 new byte[]  { 112 },310132,310132, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64 },
 new byte[]  { 112 },310134,310134, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64 },
 new byte[]  { 112 },310136,310136, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64 },
 new byte[]  { 112 },310138,310138, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64 },
 new byte[]  { 112 },310140,310140, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64 },
 new byte[]  { 112 },310142,310142, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {68 },
 new byte[]  { 101 },310154,310154, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {243,4,220,5,220,5,220,5,220,5,220,5 },
 new byte[]  { 25,5,9,6,9,6,9,6,9,6,9,6 },310156,310167, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {23 },
 new byte[]  { 54 },312006,312006, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {141 },
 new byte[]  { 176 },312008,312008, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {184 },
 new byte[]  { 220 },312010,312010, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {238,4,42 },
 new byte[]  { 20,5,82 },312012,312014, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {70 },
 new byte[]  { 111 },312016,312016, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {70 },
 new byte[]  { 111 },312018,312018, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {61 },
 new byte[]  { 94 },312038,312038, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {197 },
 new byte[]  { 234 },312040,312040, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {250,4,8 },
 new byte[]  { 32,5,47 },312042,312044, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {91 },
 new byte[]  { 132 },312046,312046, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {155 },
 new byte[]  { 198 },312048,312048, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {155 },
 new byte[]  { 198 },312050,312050, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {99 },
 new byte[]  { 133 },312070,312070, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {253,4,60 },
 new byte[]  { 35,5,100 },312072,312074, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {84 },
 new byte[]  { 125 },312076,312076, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {240,5,240,5,240,5 },
 new byte[]  { 30,6,30,6,30,6 },312078,312083, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {214 },
 new byte[]  { 251 },312102,312102, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {87 },
 new byte[]  { 128 },312104,312104, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {157 },
 new byte[]  { 200 },312106,312106, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {177 },
 new byte[]  { 221 },312108,312108, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {24 },
 new byte[]  { 71 },312110,312110, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {24 },
 new byte[]  { 71 },312112,312112, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {24 },
 new byte[]  { 71 },312114,312114, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {73 },
 new byte[]  { 114 },312134,312134, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {178 },
 new byte[]  { 222 },312136,312136, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {254,5,64 },
 new byte[]  { 44,6,112 },312138,312140, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64 },
 new byte[]  { 112 },312142,312142, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64 },
 new byte[]  { 112 },312144,312144, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64 },
 new byte[]  { 112 },312146,312146, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {161 },
 new byte[]  { 204 },312166,312166, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {235,5,40 },
 new byte[]  { 24,6,87 },312168,312170, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64 },
 new byte[]  { 112 },312172,312172, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64 },
 new byte[]  { 112 },312174,312174, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64 },
 new byte[]  { 112 },312176,312176, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64 },
 new byte[]  { 112 },312178,312178, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {249,5,36 },
 new byte[]  { 39,6,83 },312198,312200, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {83 },
 new byte[]  { 132 },312202,312202, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {114 },
 new byte[]  { 164 },312204,312204, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {114 },
 new byte[]  { 164 },312206,312206, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {114 },
 new byte[]  { 164 },312208,312208, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {114 },
 new byte[]  { 164 },312210,312210, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {8 },
 new byte[]  { 39 },312518,312518, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {202 },
 new byte[]  { 231 },312520,312520, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {164 },
 new byte[]  { 192 },312522,312522, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {227,3,60 },
 new byte[]  { 1,4,93 },312524,312526, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 59 },312528,312528, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 59 },312530,312530, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {232,3,242,3,19 },
 new byte[]  { 6,4,16,4,50 },312550,312554, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {102 },
 new byte[]  { 136 },312556,312556, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {169 },
 new byte[]  { 205 },312558,312558, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {145 },
 new byte[]  { 188 },312560,312560, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {145 },
 new byte[]  { 188 },312562,312562, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {99 },
 new byte[]  { 133 },312582,312582, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {183 },
 new byte[]  { 219 },312584,312584, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {214 },
 new byte[]  { 251 },312586,312586, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {57 },
 new byte[]  { 97 },312588,312588, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {240,5,240,5,240,5 },
 new byte[]  { 30,6,30,6,30,6 },312590,312595, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {168 },
 new byte[]  { 204 },312614,312614, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {24 },
 new byte[]  { 63 },312616,312616, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {91 },
 new byte[]  { 132 },312618,312618, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {176 },
 new byte[]  { 220 },312620,312620, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {24 },
 new byte[]  { 71 },312622,312622, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {24 },
 new byte[]  { 71 },312624,312624, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {24 },
 new byte[]  { 71 },312626,312626, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {208 },
 new byte[]  { 245 },312646,312646, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {92 },
 new byte[]  { 133 },312648,312648, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {159 },
 new byte[]  { 202 },312650,312650, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64 },
 new byte[]  { 112 },312652,312652, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64 },
 new byte[]  { 112 },312654,312654, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64 },
 new byte[]  { 112 },312656,312656, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64 },
 new byte[]  { 112 },312658,312658, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {0 },
 new byte[]  { 38 },312678,312678, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {110 },
 new byte[]  { 152 },312680,312680, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {220,5,64 },
 new byte[]  { 9,6,112 },312682,312684, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64 },
 new byte[]  { 112 },312686,312686, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64 },
 new byte[]  { 112 },312688,312688, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64 },
 new byte[]  { 112 },312690,312690, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {173 },
 new byte[]  { 217 },312710,312710, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {24 },
 new byte[]  { 71 },312712,312712, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64 },
 new byte[]  { 112 },312714,312714, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64 },
 new byte[]  { 112 },312716,312716, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64 },
 new byte[]  { 112 },312718,312718, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64 },
 new byte[]  { 112 },312720,312720, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64 },
 new byte[]  { 112 },312722,312722, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {82 },
 new byte[]  { 108 },313542,313542, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {163 },
 new byte[]  { 191 },313544,313544, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {244,3,125 },
 new byte[]  { 18,4,159 },313546,313548, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {219,4,20 },
 new byte[]  { 0,5,59 },313550,313552, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {27 },
 new byte[]  { 66 },313554,313554, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {214 },
 new byte[]  { 243 },313574,313574, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {55 },
 new byte[]  { 87 },313576,313576, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {89 },
 new byte[]  { 122 },313578,313578, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {0 },
 new byte[]  { 38 },313580,313580, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {79 },
 new byte[]  { 120 },313582,313582, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {127 },
 new byte[]  { 169 },313584,313584, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {137 },
 new byte[]  { 180 },313586,313586, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {135 },
 new byte[]  { 170 },313606,313606, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {0 },
 new byte[]  { 38 },313608,313608, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {48 },
 new byte[]  { 88 },313610,313610, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {164 },
 new byte[]  { 207 },313612,313612, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {206 },
 new byte[]  { 251 },313614,313614, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {220,5,220,5 },
 new byte[]  { 9,6,9,6 },313616,313619, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {218 },
 new byte[]  { 255 },313638,313638, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {74 },
 new byte[]  { 115 },313640,313640, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {141 },
 new byte[]  { 184 },313642,313642, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {226,5,24 },
 new byte[]  { 15,6,71 },313644,313646, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {24 },
 new byte[]  { 71 },313648,313648, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {24 },
 new byte[]  { 71 },313650,313650, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {32 },
 new byte[]  { 71 },313670,313670, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {142 },
 new byte[]  { 185 },313672,313672, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {209 },
 new byte[]  { 254 },313674,313674, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {17 },
 new byte[]  { 64 },313676,313676, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64 },
 new byte[]  { 112 },313678,313678, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64 },
 new byte[]  { 112 },313680,313680, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64 },
 new byte[]  { 112 },313682,313682, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {101 },
 new byte[]  { 142 },313702,313702, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {211,5,20 },
 new byte[]  { 0,6,67 },313704,313706, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64 },
 new byte[]  { 112 },313708,313708, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64 },
 new byte[]  { 112 },313710,313710, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64 },
 new byte[]  { 112 },313712,313712, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64 },
 new byte[]  { 112 },313714,313714, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {5 },
 new byte[]  { 51 },313734,313734, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {14 },
 new byte[]  { 61 },313736,313736, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {14 },
 new byte[]  { 61 },313738,313738, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64 },
 new byte[]  { 112 },313740,313740, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64 },
 new byte[]  { 112 },313742,313742, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64 },
 new byte[]  { 112 },313744,313744, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64 },
 new byte[]  { 112 },313746,313746, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {82 },
 new byte[]  { 108 },314054,314054, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {163 },
 new byte[]  { 191 },314056,314056, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {244,3,125 },
 new byte[]  { 18,4,159 },314058,314060, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {219,4,20 },
 new byte[]  { 0,5,59 },314062,314064, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {27 },
 new byte[]  { 66 },314066,314066, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {214 },
 new byte[]  { 243 },314086,314086, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {55 },
 new byte[]  { 87 },314088,314088, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {89 },
 new byte[]  { 122 },314090,314090, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {0 },
 new byte[]  { 38 },314092,314092, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {79 },
 new byte[]  { 120 },314094,314094, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {127 },
 new byte[]  { 169 },314096,314096, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {137 },
 new byte[]  { 180 },314098,314098, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {135 },
 new byte[]  { 170 },314118,314118, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {0 },
 new byte[]  { 38 },314120,314120, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {48 },
 new byte[]  { 88 },314122,314122, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {164 },
 new byte[]  { 207 },314124,314124, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {206 },
 new byte[]  { 251 },314126,314126, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {220,5,220,5 },
 new byte[]  { 9,6,9,6 },314128,314131, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {218 },
 new byte[]  { 255 },314150,314150, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {74 },
 new byte[]  { 115 },314152,314152, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {141 },
 new byte[]  { 184 },314154,314154, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {226,5,24 },
 new byte[]  { 15,6,71 },314156,314158, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {24 },
 new byte[]  { 71 },314160,314160, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {24 },
 new byte[]  { 71 },314162,314162, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {32 },
 new byte[]  { 71 },314182,314182, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {142 },
 new byte[]  { 185 },314184,314184, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {209 },
 new byte[]  { 254 },314186,314186, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {17 },
 new byte[]  { 64 },314188,314188, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64 },
 new byte[]  { 112 },314190,314190, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64 },
 new byte[]  { 112 },314192,314192, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64 },
 new byte[]  { 112 },314194,314194, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {101 },
 new byte[]  { 142 },314214,314214, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {211,5,20 },
 new byte[]  { 0,6,67 },314216,314218, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64 },
 new byte[]  { 112 },314220,314220, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64 },
 new byte[]  { 112 },314222,314222, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64 },
 new byte[]  { 112 },314224,314224, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64 },
 new byte[]  { 112 },314226,314226, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {5 },
 new byte[]  { 51 },314246,314246, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {14 },
 new byte[]  { 61 },314248,314248, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {14 },
 new byte[]  { 61 },314250,314250, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64 },
 new byte[]  { 112 },314252,314252, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64 },
 new byte[]  { 112 },314254,314254, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64 },
 new byte[]  { 112 },314256,314256, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64 },
 new byte[]  { 112 },314258,314258, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {193 },
 new byte[]  { 222 },314430,314430, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {56 },
 new byte[]  { 88 },314432,314432, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {199 },
 new byte[]  { 236 },314434,314434, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {70 },
 new byte[]  { 111 },314436,314436, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {70 },
 new byte[]  { 111 },314438,314438, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {70 },
 new byte[]  { 111 },314440,314440, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {70 },
 new byte[]  { 111 },314442,314442, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3 },
 new byte[]  { 34 },314454,314454, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {149 },
 new byte[]  { 184 },314456,314456, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {119 },
 new byte[]  { 161 },314458,314458, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {240,5,240,5,240,5,240,5 },
 new byte[]  { 30,6,30,6,30,6,30,6 },314460,314467, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {172 },
 new byte[]  { 208 },314478,314478, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {101 },
 new byte[]  { 142 },314480,314480, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64 },
 new byte[]  { 112 },314482,314482, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64 },
 new byte[]  { 112 },314484,314484, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64 },
 new byte[]  { 112 },314486,314486, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64 },
 new byte[]  { 112 },314488,314488, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64 },
 new byte[]  { 112 },314490,314490, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {58 },
 new byte[]  { 98 },314502,314502, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {24 },
 new byte[]  { 71 },314504,314504, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {114 },
 new byte[]  { 164 },314506,314506, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {114 },
 new byte[]  { 164 },314508,314508, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {114 },
 new byte[]  { 164 },314510,314510, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {114 },
 new byte[]  { 164 },314512,314512, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {114 },
 new byte[]  { 164 },314514,314514, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {58 },
 new byte[]  { 98 },314526,314526, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64 },
 new byte[]  { 112 },314528,314528, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64 },
 new byte[]  { 112 },314530,314530, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64 },
 new byte[]  { 112 },314532,314532, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64 },
 new byte[]  { 112 },314534,314534, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64 },
 new byte[]  { 112 },314536,314536, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64 },
 new byte[]  { 112 },314538,314538, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {68 },
 new byte[]  { 101 },314550,314550, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {243,4,220,5,220,5,220,5,220,5,220,5 },
 new byte[]  { 25,5,9,6,9,6,9,6,9,6,9,6 },314552,314563, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {82 },
 new byte[]  { 108 },315054,315054, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {212 },
 new byte[]  { 241 },315056,315056, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {48 },
 new byte[]  { 80 },315058,315058, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {143 },
 new byte[]  { 178 },315060,315060, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {232,4,20 },
 new byte[]  { 14,5,59 },315062,315064, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 59 },315066,315066, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {216 },
 new byte[]  { 246 },315086,315086, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {55 },
 new byte[]  { 87 },315088,315088, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {168 },
 new byte[]  { 204 },315090,315090, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {21 },
 new byte[]  { 60 },315092,315092, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {95 },
 new byte[]  { 136 },315094,315094, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {145 },
 new byte[]  { 188 },315096,315096, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {145 },
 new byte[]  { 188 },315098,315098, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {137 },
 new byte[]  { 172 },315118,315118, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {6 },
 new byte[]  { 45 },315120,315120, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {74 },
 new byte[]  { 115 },315122,315122, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {176 },
 new byte[]  { 220 },315124,315124, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {240,5,240,5,240,5 },
 new byte[]  { 30,6,30,6,30,6 },315126,315131, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {218 },
 new byte[]  { 255 },315150,315150, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {74 },
 new byte[]  { 115 },315152,315152, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {141 },
 new byte[]  { 184 },315154,315154, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {226,5,24 },
 new byte[]  { 15,6,71 },315156,315158, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {24 },
 new byte[]  { 71 },315160,315160, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {24 },
 new byte[]  { 71 },315162,315162, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {32 },
 new byte[]  { 71 },315182,315182, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {142 },
 new byte[]  { 185 },315184,315184, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {209 },
 new byte[]  { 254 },315186,315186, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64 },
 new byte[]  { 112 },315188,315188, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64 },
 new byte[]  { 112 },315190,315190, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64 },
 new byte[]  { 112 },315192,315192, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64 },
 new byte[]  { 112 },315194,315194, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {101 },
 new byte[]  { 142 },315214,315214, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {211,5,20 },
 new byte[]  { 0,6,67 },315216,315218, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64 },
 new byte[]  { 112 },315220,315220, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64 },
 new byte[]  { 112 },315222,315222, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64 },
 new byte[]  { 112 },315224,315224, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64 },
 new byte[]  { 112 },315226,315226, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {5 },
 new byte[]  { 51 },315246,315246, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {14 },
 new byte[]  { 61 },315248,315248, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64 },
 new byte[]  { 112 },315250,315250, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64 },
 new byte[]  { 112 },315252,315252, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64 },
 new byte[]  { 112 },315254,315254, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64 },
 new byte[]  { 112 },315256,315256, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64 },
 new byte[]  { 112 },315258,315258, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {82 },
 new byte[]  { 108 },315566,315566, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {212 },
 new byte[]  { 241 },315568,315568, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {48 },
 new byte[]  { 80 },315570,315570, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {143 },
 new byte[]  { 178 },315572,315572, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {232,4,20 },
 new byte[]  { 14,5,59 },315574,315576, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 59 },315578,315578, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {216 },
 new byte[]  { 246 },315598,315598, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {55 },
 new byte[]  { 87 },315600,315600, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {168 },
 new byte[]  { 204 },315602,315602, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {21 },
 new byte[]  { 60 },315604,315604, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {95 },
 new byte[]  { 136 },315606,315606, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {145 },
 new byte[]  { 188 },315608,315608, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {145 },
 new byte[]  { 188 },315610,315610, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {137 },
 new byte[]  { 172 },315630,315630, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {6 },
 new byte[]  { 45 },315632,315632, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {74 },
 new byte[]  { 115 },315634,315634, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {176 },
 new byte[]  { 220 },315636,315636, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {240,5,240,5,240,5 },
 new byte[]  { 30,6,30,6,30,6 },315638,315643, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {218 },
 new byte[]  { 255 },315662,315662, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {74 },
 new byte[]  { 115 },315664,315664, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {141 },
 new byte[]  { 184 },315666,315666, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {226,5,24 },
 new byte[]  { 15,6,71 },315668,315670, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {24 },
 new byte[]  { 71 },315672,315672, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {24 },
 new byte[]  { 71 },315674,315674, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {32 },
 new byte[]  { 71 },315694,315694, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {142 },
 new byte[]  { 185 },315696,315696, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {209 },
 new byte[]  { 254 },315698,315698, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64 },
 new byte[]  { 112 },315700,315700, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64 },
 new byte[]  { 112 },315702,315702, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64 },
 new byte[]  { 112 },315704,315704, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64 },
 new byte[]  { 112 },315706,315706, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {101 },
 new byte[]  { 142 },315726,315726, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {211,5,20 },
 new byte[]  { 0,6,67 },315728,315730, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64 },
 new byte[]  { 112 },315732,315732, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64 },
 new byte[]  { 112 },315734,315734, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64 },
 new byte[]  { 112 },315736,315736, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64 },
 new byte[]  { 112 },315738,315738, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {5 },
 new byte[]  { 51 },315758,315758, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {14 },
 new byte[]  { 61 },315760,315760, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64 },
 new byte[]  { 112 },315762,315762, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64 },
 new byte[]  { 112 },315764,315764, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64 },
 new byte[]  { 112 },315766,315766, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64 },
 new byte[]  { 112 },315768,315768, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64 },
 new byte[]  { 112 },315770,315770, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {51 },
 new byte[]  { 83 },316590,316590, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {76 },
 new byte[]  { 109 },316592,316592, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {76 },
 new byte[]  { 109 },316594,316594, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {166 },
 new byte[]  { 202 },316596,316596, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {0 },
 new byte[]  { 38 },316598,316598, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 59 },316600,316600, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 59 },316602,316602, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {166 },
 new byte[]  { 202 },316622,316622, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {205 },
 new byte[]  { 242 },316624,316624, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {65 },
 new byte[]  { 105 },316626,316626, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {117 },
 new byte[]  { 159 },316628,316628, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {131 },
 new byte[]  { 173 },316630,316630, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {145 },
 new byte[]  { 188 },316632,316632, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {145 },
 new byte[]  { 188 },316634,316634, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {225,4,35 },
 new byte[]  { 6,5,74 },316654,316656, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {126 },
 new byte[]  { 168 },316658,316658, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {203 },
 new byte[]  { 247 },316660,316660, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {240,5,240,5,240,5 },
 new byte[]  { 30,6,30,6,30,6 },316662,316667, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {35 },
 new byte[]  { 74 },316686,316686, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {190 },
 new byte[]  { 234 },316688,316688, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {245,5,227,5,24 },
 new byte[]  { 35,6,16,6,71 },316690,316694, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {24 },
 new byte[]  { 71 },316696,316696, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {24 },
 new byte[]  { 71 },316698,316698, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {134 },
 new byte[]  { 176 },316718,316718, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {5 },
 new byte[]  { 51 },316720,316720, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {30 },
 new byte[]  { 77 },316722,316722, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64 },
 new byte[]  { 112 },316724,316724, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64 },
 new byte[]  { 112 },316726,316726, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64 },
 new byte[]  { 112 },316728,316728, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64 },
 new byte[]  { 112 },316730,316730, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {249,5,46 },
 new byte[]  { 39,6,93 },316750,316752, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {40 },
 new byte[]  { 87 },316754,316754, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64 },
 new byte[]  { 112 },316756,316756, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64 },
 new byte[]  { 112 },316758,316758, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64 },
 new byte[]  { 112 },316760,316760, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64 },
 new byte[]  { 112 },316762,316762, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {249,5,36 },
 new byte[]  { 39,6,83 },316782,316784, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {83 },
 new byte[]  { 132 },316786,316786, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {114 },
 new byte[]  { 164 },316788,316788, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {114 },
 new byte[]  { 164 },316790,316790, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {114 },
 new byte[]  { 164 },316792,316792, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {114 },
 new byte[]  { 164 },316794,316794, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {216 },
 new byte[]  { 253 },317102,317102, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {226,4,20 },
 new byte[]  { 8,5,59 },317104,317106, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {60 },
 new byte[]  { 100 },317108,317108, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 59 },317110,317110, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 59 },317112,317112, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 59 },317114,317114, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {166 },
 new byte[]  { 202 },317134,317134, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {205 },
 new byte[]  { 242 },317136,317136, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {65 },
 new byte[]  { 105 },317138,317138, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {117 },
 new byte[]  { 159 },317140,317140, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {131 },
 new byte[]  { 173 },317142,317142, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {145 },
 new byte[]  { 188 },317144,317144, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {145 },
 new byte[]  { 188 },317146,317146, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {225,4,35 },
 new byte[]  { 6,5,74 },317166,317168, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {126 },
 new byte[]  { 168 },317170,317170, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {203 },
 new byte[]  { 247 },317172,317172, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {240,5,240,5,240,5 },
 new byte[]  { 30,6,30,6,30,6 },317174,317179, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {35 },
 new byte[]  { 74 },317198,317198, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {190 },
 new byte[]  { 234 },317200,317200, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {245,5,227,5,24 },
 new byte[]  { 35,6,16,6,71 },317202,317206, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {24 },
 new byte[]  { 71 },317208,317208, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {24 },
 new byte[]  { 71 },317210,317210, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {134 },
 new byte[]  { 176 },317230,317230, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {5 },
 new byte[]  { 51 },317232,317232, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {30 },
 new byte[]  { 77 },317234,317234, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64 },
 new byte[]  { 112 },317236,317236, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64 },
 new byte[]  { 112 },317238,317238, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64 },
 new byte[]  { 112 },317240,317240, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64 },
 new byte[]  { 112 },317242,317242, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {249,5,46 },
 new byte[]  { 39,6,93 },317262,317264, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {40 },
 new byte[]  { 87 },317266,317266, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64 },
 new byte[]  { 112 },317268,317268, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64 },
 new byte[]  { 112 },317270,317270, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64 },
 new byte[]  { 112 },317272,317272, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64 },
 new byte[]  { 112 },317274,317274, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {249,5,36 },
 new byte[]  { 39,6,83 },317294,317296, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {83 },
 new byte[]  { 132 },317298,317298, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {114 },
 new byte[]  { 164 },317300,317300, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {114 },
 new byte[]  { 164 },317302,317302, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {114 },
 new byte[]  { 164 },317304,317304, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {114 },
 new byte[]  { 164 },317306,317306, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {114 },
 new byte[]  { 164 },318576,318576, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {114 },
 new byte[]  { 164 },318578,318578, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {114 },
 new byte[]  { 164 },318580,318580, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {114 },
 new byte[]  { 164 },318582,318582, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {114 },
 new byte[]  { 164 },318584,318584, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {114 },
 new byte[]  { 164 },318586,318586, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {114 },
 new byte[]  { 164 },318588,318588, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {114 },
 new byte[]  { 164 },318590,318590, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {43 },
 new byte[]  { 243 },377658,377658, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {199,4,30 },
 new byte[]  { 143,5,230 },377660,377662, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {141,7,205,7 },
 new byte[]  { 85,8,149,8 },377664,377667, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {149,4,161,5,51 },
 new byte[]  { 93,5,105,6,251 },377674,377678, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {107,8,54 },
 new byte[]  { 51,9,254 },377680,377682, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {92,5,179,6,51 },
 new byte[]  { 36,6,123,7,251 },377690,377694, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {216,8,77,10 },
 new byte[]  { 160,9,21,11 },377696,377699, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {112,5,71,7,152,8,103,9,48 },
 new byte[]  { 56,6,15,8,96,9,47,10,248 },377706,377714, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {124,5,139,7,205,8,198,9,234,9 },
 new byte[]  { 68,6,83,8,149,9,142,10,178,10 },377722,377731, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {114,5,118,7,213,8,186,9,186,9 },
 new byte[]  { 58,6,62,8,157,9,130,10,130,10 },377738,377747, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {66,5,66,7,134,8,242,8,242,8 },
 new byte[]  { 10,6,10,8,78,9,186,9,186,9 },377754,377763, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {72,5,233,5,60,6,114,6,164,6 },
 new byte[]  { 69,6,224,6,8,7,29,7,78,7 },377846,377855, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {47,6,95,7,79,8,11 },
 new byte[]  { 61,7,101,8,54,9,226 },377862,377868, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {132,9 },
 new byte[]  { 62,10 },377870,377871, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {181,6,244,7,252,8,182,9,130,10 },
 new byte[]  { 175,7,225,8,215,9,146,10,78,11 },377878,377887, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {128,7,82,8,116,9,18 },
 new byte[]  { 148,8,55,9,80,10,232 },377894,377900, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {136,10 },
 new byte[]  { 87,11 },377902,377903, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {87,7,166,8,130,9,16 },
 new byte[]  { 99,8,139,9,90,10,222 },377910,377916, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {93,10 },
 new byte[]  { 46,11 },377918,377919, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {96,7,133,8,164,9,7 },
 new byte[]  { 111,8,105,9,126,10,213 },377926,377932, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {140,10 },
 new byte[]  { 101,11 },377934,377935, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {96,7,133,8,164,9,7 },
 new byte[]  { 121,8,112,9,134,10,231 },377942,377948, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {140,10 },
 new byte[]  { 120,11 },377950,377951, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {56,137,16,142,178,146,94,149,6,152,169,154,32,156,31,157,10,158,150,158,74,159,127,159,185,158,198,157,212,156,68,155 },
 new byte[]  { 134,139,160,145,126,151,236,154,90,158,197,161,184,163,21,165,90,166,38,167,40,168,134,168,162,167,130,166,97,165,114,163 },390262,390293, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {32,224,35,0,36,64,36,128,36,96,35,192,33,128,32,0,31,0,30,0,29,160,27,64,25,32,24,32,23,224,21 },
 new byte[]  { 40,247,44,61,45,173,45,29,46,207,44,221,42,98,41,148,39,102,38,55,37,139,35,147,32,52,31,252,29,112,28 },419445,419475, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {32,224,35,0,36,64,36,128,36,96,35,192,33,128,32,0,31,0,30,0,29,160,27,64,25,32,24,32,23,224,21 },
 new byte[]  { 40,247,44,61,45,173,45,29,46,207,44,221,42,98,41,148,39,102,38,55,37,139,35,147,32,52,31,252,29,112,28 },420333,420363, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {192,78,128,82,128,82,128,82,128,82,64,81,128,79,32,78,160,76,96,75,32,74,128,72,128,70,128,68,64,66,96,64 },
 new byte[]  { 240,85,188,90,215,90,243,90,15,91,149,89,119,87,208,85,254,83,123,82,246,80,243,78,114,76,237,73,18,71,176,68 },420480,420511, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {128,72,192,78,128,82,128,82,128,82,128,82,64,81,128,79,32,78,160,76,96,75,32,74,128,72,128,70,128,68,64,66,96,64 },
 new byte[]  { 32,78,7,86,212,90,238,90,8,91,34,91,166,89,133,87,220,85,8,84,131,82,252,80,248,78,117,76,239,73,19,71,176,68 },420518,420551, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {192,42 },
 new byte[]  { 77,51 },420906,420907, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {45 },
 new byte[]  { 54 },420917,420917, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {128,43 },
 new byte[]  { 51,52 },420926,420927, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {166,40 },
 new byte[]  { 199,48 },420936,420937, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {166,37 },
 new byte[]  { 46,45 },420946,420947, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {26,35 },
 new byte[]  { 31,42 },420956,420957, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {166,31 },
 new byte[]  { 250,37 },420966,420967, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {24,21,184,26,32,28,32,28,48,27,104,25,136,23,240,21,200,19,88,17,64,16,32,18,32,18,32,18,192,18,192,18,32,18,240,16,176,15,160,14,48,13 },
 new byte[]  { 94,26,140,33,120,35,160,35,151,34,119,32,51,30,70,28,155,25,140,22,80,20,191,22,214,22,238,22,208,23,232,23,51,23,196,21,61,20,240,18,37,17 },427144,427185, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {128,37,128,37 },
 new byte[]  { 0,50,0,50 },427912,427915, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {128,37,128,37 },
 new byte[]  { 0,50,0,50 },427948,427951, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {128,37,128,37 },
 new byte[]  { 0,50,0,50 },427984,427987, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {128,37,128,37 },
 new byte[]  { 0,50,0,50 },428020,428023, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {128,37,128,37 },
 new byte[]  { 0,50,0,50 },428056,428059, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {128,37,128,37 },
 new byte[]  { 0,50,0,50 },428092,428095, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {128,37,128,37 },
 new byte[]  { 0,50,0,50 },428128,428131, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {128,37,128,37 },
 new byte[]  { 0,50,0,50 },428164,428167, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {128,37,128,37 },
 new byte[]  { 0,50,0,50 },428200,428203, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {128,37,128,37 },
 new byte[]  { 0,50,0,50 },428236,428239, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {128,37,128,37 },
 new byte[]  { 0,50,0,50 },428272,428275, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {128,37,128,37 },
 new byte[]  { 0,50,0,50 },428308,428311, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {128,37,128,37 },
 new byte[]  { 0,50,0,50 },428344,428347, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {128,37,128,37 },
 new byte[]  { 0,50,0,50 },428380,428383, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {128,37,128,37 },
 new byte[]  { 0,50,0,50 },428416,428419, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {128,37,128,37 },
 new byte[]  { 0,50,0,50 },428452,428455, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {128,37,128,37 },
 new byte[]  { 0,50,0,50 },428488,428491, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {128,37,128,37 },
 new byte[]  { 0,50,0,50 },428524,428527, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {174,21 },
 new byte[]  { 196,22 },428562,428563, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {110,20 },
 new byte[]  { 116,21 },428598,428599, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {180,20 },
 new byte[]  { 189,21 },428634,428635, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {170,20 },
 new byte[]  { 179,21 },428670,428671, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {179,21 },
 new byte[]  { 201,22 },428706,428707, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {84,21 },
 new byte[]  { 101,22 },428742,428743, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {120,20 },
 new byte[]  { 126,21 },428778,428779, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {140,20 },
 new byte[]  { 147,21 },428814,428815, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 21 },428851,428851, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {170,20 },
 new byte[]  { 179,21 },428886,428887, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {140,20 },
 new byte[]  { 147,21 },428922,428923, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {220,20 },
 new byte[]  { 231,21 },428958,428959, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {180,20 },
 new byte[]  { 189,21 },428994,428995, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {180,20 },
 new byte[]  { 189,21 },429030,429031, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {130,20 },
 new byte[]  { 137,21 },429066,429067, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {150,20 },
 new byte[]  { 158,21 },429102,429103, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {94,21 },
 new byte[]  { 112,22 },429138,429139, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {250,20 },
 new byte[]  { 7,22 },429174,429175, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {32,38,96,39 },
 new byte[]  { 0,50,0,50 },429904,429907, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {192,38 },
 new byte[]  { 0,50 },429940,429941, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {40 },
 new byte[]  { 50 },429943,429943, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64,40,32,41 },
 new byte[]  { 0,50,0,50 },429976,429979, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {90,39,131,41 },
 new byte[]  { 0,50,0,50 },430012,430015, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {92,39,136,41 },
 new byte[]  { 0,50,0,50 },430048,430051, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {173,38,4,41 },
 new byte[]  { 0,50,0,50 },430084,430087, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {209,38,161,40 },
 new byte[]  { 0,50,0,50 },430120,430123, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {134,38,60,40 },
 new byte[]  { 0,50,0,50 },430156,430159, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {92,38,35,40 },
 new byte[]  { 0,50,0,50 },430192,430195, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {67,38,83,40 },
 new byte[]  { 0,50,0,50 },430228,430231, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {52,38,91,40 },
 new byte[]  { 0,50,0,50 },430264,430267, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {50,38,83,40 },
 new byte[]  { 0,50,0,50 },430300,430303, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {179,37,212,39 },
 new byte[]  { 0,50,0,50 },430336,430339, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {209,37,235,39 },
 new byte[]  { 0,50,0,50 },430372,430375, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64,38,32,40 },
 new byte[]  { 0,50,0,50 },430408,430411, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {192,38,64,40 },
 new byte[]  { 0,50,0,50 },430444,430447, "Found egr map...Delete map");
      base.egrOffSolution();
    }
    public override void dpfOffSolution()  {
	
      base.dpfOffSolution();
    }
    public override void lamdaOfffSolution()  {
	
      base.lamdaOfffSolution();

    }

    public override void flapsOfffSolution()  {
	

      base.flapsOfffSolution();
    }
    public override void startStopSolution()  {
	

      base.startStopSolution();
    }

    public override void adBlueSolution()  {
	

      base.adBlueSolution();
    }

    public override void readnissSolution()  {
	

      base.readnissSolution();
    }
    public override void immoSolution()  {
	
      base.immoSolution();

    }

    public override void tvaoffSolution()  {
	

      base.tvaoffSolution();
    }

    public override void specialISolution()  {
	

      base.specialISolution();
    }
    public override void specialIISolution()  {
	
      base.specialIISolution();

    }

    public override void specialIIISolution()  {
	
      base.specialIIISolution();

    }

    public List < string > getListOfDtcCodes()  {
      return null;
    }

    public override void RemoveDtcFromFile(string dtcCode)  {

      base.RemoveDtcFromFile(dtcCode);
    }

  }
}