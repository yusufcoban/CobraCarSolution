using ToolBoxNameSpace;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace CobraCarSolution.TreeElements.VAG
{
    class nissan_Denso_SH7058 :MenuItem, ITreeItem  {
    public nissan_Denso_SH7058()  {
      Title = "Denso_SH7058";
      IsSolutionItem =  true;
      hasDtcSolution =  false;
      hasEgrSolution = true;
      hasTVASolution = false;
      hasFileCheckSize =false;
      hasDpfSolution =true;
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
      FileSizeArray = new int[]  {  0 };
    }

    public override async Task < bool > checkFileForEgr()  {
      bool validationEgrInFile = true;
      //Algo for checking dpf solution
      if (ToolBox.array.Length > 0)  {
		validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {192 },  590187    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1 },  590380    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1 },  590426    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1 },  590437    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1 },  590446    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1 },  590554    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1 },  590570    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {10 },  590602    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,1 },  590628    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1 },  590631    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1 },  590671    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64 },  602156    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64 },  602158    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64 },  602160    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64 },  602162    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64 },  602164    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64 },  602166    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64 },  602168    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64 },  602170    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64 },  602204    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64 },  602206    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64 },  602208    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64 },  602210    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64 },  602212    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64 },  602214    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64 },  602216    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64 },  602218    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {38 },  603205    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {38 },  603207    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {38 },  603209    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {38 },  603211    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {37 },  603213    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {35 },  603215    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {32 },  603217    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {30 },  603219    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {29 },  603221    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {25 },  603223    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {25 },  603225    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {25 },  603227    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {25 },  603229    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {25 },  603231    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {25 },  603233    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {25 },  603235    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {50 },  603301    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {50 },  603303    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {50 },  603305    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {50 },  603307    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {50 },  603309    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {50 },  603311    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {44 },  603313    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {38 },  603315    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {38 },  603317    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {38 },  603319    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {38 },  603321    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {38 },  603323    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {38 },  603325    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {38 },  603327    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {38 },  603329    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {38 },  603331    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {60 },  606449    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {60 },  606451    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {60 },  606453    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {60 },  606455    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {60 },  606457    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {60 },  606459    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {60 },  606461    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {60 },  606463    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {112,109,108,106,111,113,120,122,124,115,105,103 },  626523    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {125,118,116,111,121,125,140,144,149,130,111,105 },  626542    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {112,123,114,111,128,130,137,138,138,131,123,117,112,106 },  626561    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {121,142,109,117,109,110,135,134,134,131,128,131,135,130,126,115,105,104,103,108,113,106,112,109,108,121,117,117,116,114,117,120,119,118,112,106,104,102 },  626578    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {99,103,107,109,106,107 },  626617    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {102,104,107,111,109,107,104 },  626627    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {98,95,101,104,110,107,106 },  626635    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {101,102,103,103,107,110,109,108,104,101,98,95 },  626644    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {106,111,109,105,101 },  626657    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {102,104,104,103,106,109,109,108,105,101 },  626663    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {99 },  626674    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {107,108,110,105,103,102,103,104,103,102,104,107,107,106,103,99 },  626676    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {101 },  626693    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {108,104,110,105,105,105,104,104,102,101,103,105,105,105,101,97,99,102 },  626695    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {102,105,104,103,105,104,104,102,101,102,103,103,104,101,98,99 },  626715    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {104 },  626736    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {105,104,104,102,101,101,101,102,103,102 },  626738    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {102,101,104,104,103,102,101,101,102,103,104,102 },  626755    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {101,104,103,102,102,101,102,103,104,104,102 },  626775    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {99,101 },  626794    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {102,103,102,102,101 },  626800    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {100 },  648847    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {100 },  648849    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {100 },  648851    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {100 },  648853    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {100 },  648855    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {100 },  648857    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {100 },  648859    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {100 },  648861    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {100 },  648863    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {100 },  648865    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {100 },  648867    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {100 },  648869    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {100 },  648871    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {100 },  648873    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {100 },  648875    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {82,128,82,128,82,128,82,128,82,128,82,128,82,128,82,128,82,128,78,176,80,160,80,160,82,160,74,80,66,224,74,176,72,96,68,224,53,176,42,48,56,96,43,240,35,96,10,16,0 },  674672    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {9,179,9,102,9,51,9,92,9,13,8,128,8,51,7,218,7,154,7,85,9,179,9,102,9,51,9,92,9,13,8,128,8,51,7,218,7,154,7,85,9,179,9,102,9,51,9,92,9,13,8,128,8,51,7,64,6,195,6,72,9,154,9,102,9,51,8,192,8,36,7,20,6,102,5,187,5,28,4,118,8,64,7,241,7,154,6,166,5,172,4,61,3,110,2,133,1,200,0,223 },  686320    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {63,102,102,102,63,102,102,102,63,102,102,102,63,102,102,102,63,102,102,102,63,102,102,102,63,102,102,102,63,102,102,102 },  876820    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {63,102,102,102,63,102,102,102,63,102,102,102,63,102,102,102,63,102,102,102,63,102,102,102,63,102,102,102,63,102,102,102 },  876892    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {63,102,102,102,63,102,102,102,63,102,102,102,63,102,102,102,63,102,102,102,63,102,102,102,63,102,102,102,63,102,102,102 },  876964    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {63,102,102,102,63,102,102,102,63,102,102,102,63,102,102,102,63,102,102,102,63,102,102,102,63,102,102,102,63,102,102,102 },  877036    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {63,102,102,102,63,102,102,102,63,102,102,102,63,102,102,102,63,102,102,102,63,102,102,102,63,102,102,102,63,102,102,102 },  877108    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {63,64 },  877180    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {63,64 },  877184    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {63,76,204,205,63,83,51,51,63,102,102,102,63,102,102,102,63,51,51,51,63,64 },  877188    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {63,25,153,154,63,25,153,154,63,51,51,51,63,64 },  877252    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {63,102,102,102,63,102,102,102,63,102,102,102,63,25,153,154 },  877268    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {63 },  877324    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {63 },  877328    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {63,25,153,154,63,38,102,102,63,76,204,205,63,89,153,154,63,89,153,154,63,25,153,154 },  877332    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {62,204,204,205,62,204,204,205,63 },  877396    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {63,12,204,205,63,51,51,51,63,76,204,205,63,76,204,205,63,25,153,154 },  877408    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {62,76,204,205,62,76,204,205,62,128 },  877468    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {62,128 },  877480    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {62,179,51,51,62,204,204,205,62,204,204,205,62,153,153,154 },  877484    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {0,0 },  904760    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {66,112 },  904764    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {66,112 },  904768    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {66,97,235,133,66,97,235,133,66,106,215,10,66,132,148,123,66,170 },  904772    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {66,191,143,92,66,193,250,225,66,192,10,61,66,187,245,195,66,183,250,225,66,187,46,20,66,181,5,31,66,170 },  904792    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {66,163,250,225,66,157,10,61,66,152,10,61,66,146,163,215,66,92,122,225,65,112 },  904824    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {0,0 },  904848    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {0,0 },  904852    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {66,112 },  904856    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {66,112 },  904860    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {66,97,235,133,66,97,235,133,66,106,215,10,66,132,148,123,66,170 },  904864    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {66,191,143,92,66,193,250,225,66,192,10,61,66,187,245,195,66,183,250,225,66,187,46,20,66,181,5,31,66,170 },  904884    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {66,163,250,225,66,157,10,61,66,152,10,61,66,146,163,215,66,92,122,225,65,112 },  904916    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {0,0 },  904940    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {0,0 },  904944    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {66,112 },  904948    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {66,110,102,102,66,48 },  904952    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {66,32 },  904960    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {66,2 },  904964    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {66,14 },  904968    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {66,20 },  904972    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {66,32 },  904976    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {66,32 },  904980    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {66,32 },  904984    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {66,32 },  904988    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {66,32 },  904992    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {65,240 },  904996    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {65,200 },  905000    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {65,200 },  905004    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {65,200 },  905008    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {65,200 },  905012    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {65,200 },  905016    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {65,200 },  905020    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {65,200 },  905024    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {0,0 },  905028    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {0,0 },  905032    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {0,0 },  905036    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {66,112 },  905040    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {66,110,102,102,66,40 },  905044    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {66,20 },  905052    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {65,236 },  905056    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {66,0 },  905060    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {66,6 },  905064    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {66,16 },  905068    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {66,0 },  905072    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {65,224 },  905076    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {65,208 },  905080    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {65,200 },  905084    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {65,200 },  905088    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {65,160 },  905092    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {65,160 },  905096    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {65,160 },  905100    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {65,160 },  905104    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {65,160 },  905108    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {65,160 },  905112    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {65,160 },  905116    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {0,0 },  905120    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {0,0 },  905124    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {0,0 },  905128    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {66,112 },  905132    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {66,110,102,102,66,32 },  905136    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {66,12 },  905144    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {65,196 },  905148    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {65,216 },  905152    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {65,224 },  905156    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {65,240 },  905160    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {65,200 },  905164    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {65,160 },  905168    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {65,160 },  905172    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {0,0 },  905176    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {0,0 },  905180    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {0,0 },  905184    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {0,0 },  905188    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {0,0 },  905192    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {0,0 },  905196    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {0,0 },  905200    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {0,0 },  905204    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {0,0 },  905208    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {0,0 },  905212    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {0,0 },  905216    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64,12,66,236,64,12,66,236,63,202,54,198,64,69,155,8,64,54,136,193,64,71,29,233,64,91,224,64,64,92,189,248,64,113,227,49,64,131,132,53,64,105,154,255,64,59,131,221,64,95,171,50,64,171,1,119,64,182,78,199 },  914492    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64,124,20,68,64,124,20,68,64,35,147,157,64,60,86,124,64,129,117,137,64,164,191,211,63,135,174,20,64,154,57,141,64,165,152,129,64,165,152,129,64,179,36,245,64,166,91,169,64,202,149,148,64,233,5,82,64,225,222,10 },  914556    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64,227,13,96,64,227,13,96,64,131,121,163,64,134,151,131,64,114,121,237,64,87,196,212,64,208,81,236,64,132,114,145,64,103,121,11,64,103,121,11,64,217,157,115,64,226,92,187,64,214,42,109,65,16,129,59,65,14,35,19 },  914620    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {65,90,225,207,65,90,225,207,64,214,4,129,64,253,32,242,64,221,75,53,64,189,117,119,64,67,209,191,65,32,157,156,65,13,116,103,65,13,116,103,64,245,198,211,64,223,228,219,64,255,30,239,65,36,227,108,65,89,91,40 },  914684    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {65,254,206,60,65,254,206,60,65,134,99,209,65,119,45,217,65,63,89,14,65,7,132,67,64,191,81,4,65,147,48,150,65,133,131,227,65,127,154,192,64,250,203,184,64,223,212,215,64,252,89,124,65,49,227,224,65,167,106,59 },  914748    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {65,214,114,134,65,214,114,134,66,22,5,178,65,203,66,124,65,176,36,203,65,149,7,26,64,220,240,162,65,168,65,80,65,172,151,40,65,172,151,40,64,219,189,194,64,209,40,31,64,246,133,47,65,55,49,171,65,185,83,198 },  914812    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {65,165,1,145,65,165,1,145,66,65,71,234,65,230,218,150,65,255,42,122,66,1,102,151,65,14,44,183,65,35,242,129,65,53,111,160,65,53,111,160,64,186,164,227,64,207,53,74,65 },  914876    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {193,16,65,39,185,245,65,152,25,218 },  914926    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {66,16,252,172,66,16,252,172,65,245,137,6,64,239,168,128,65,169,245,16,66,12 },  914940    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {65,141,56,38,65,26,255,91,65,46,25,165,65,46,25,165,64,229,70,60,64,184,30,222,65,24,144,9,65,51,111,171,65,141,117,131 },  914964    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {66,196,88,202,66,196,88,202,65,212,250,12,65,82,120,130,65,192,158,33,66,9,235,202,65,199,150,38,65,108,87,191,65,78,165,53,65,78,165,53,64,239,192,185,64,178,6,189,65,29,250,66,65,33,112,126,65,100,124,226 },  915004    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {67,73 },  915068    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {67,73 },  915072    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {66,133,243,205,65,190,250,197,65,137,51,169,65,38,217,26,65,213,11,239,65,198,238,220,65,125,86,213,65,125,86,213,65,5,161,239,64,187,184,26,65,24,106,127,65,6,144,122,65,51,143,76 },  915076    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {67,73 },  915132    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {67,73 },  915136    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {66,241,30,131,65,222,108,88,65,155,93,169,65,31,161,139,65,138,134,196,65,194,57,254,65,134,4,89,65,134,4,89,65,22,4,13,64,201,217,162,64,229,218,38,64,237,52,62,65,41,19,80 },  915140    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {67,73 },  915196    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {67,73 },  915200    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {67,46,36,156,65,253,221,235,65,175,129,76,65,25,116,6,64,160,49,77,65,83,58,145,65,123,215,162,65,123,215,162,65,15,244,33,64,212,173,91,64,223,181,203,64,227,229,176,65,66,208,58 },  915204    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {67,73 },  915260    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {67,73 },  915264    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {67,46,36,156,66,14,167,191,65,197,180,246,65,33,96,216,64,166,159,92,65,4,123,43,65,79,157,241,65,79,157,241,65,40,10,27,64,209,154,163,65,11,137,65,65,14,31,70,65,95,249,3 },  915268    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {67,73 },  915324    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {67,73 },  915328    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {67,46,36,156,66,30,96,136,65,225,122,78,65,53,48,168,64,204,125,109,64,252,35,115,65,2,189,160,65,2,189,160,65,87,170,33,64,235,149,61,65,8,249,184,65,42,120,94,65,136,92,104 },  915332    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {67,73 },  915388    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {67,73 },  915392    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {67,46,36,156,66,61,210,26,66,11,249,112,65,180,65,139,65,44,60,240,64,223,26,176,65,27,200,1,65,27,200,1,65,145,197,217,65,65,221,42,65,72,109,79,65,193,177,185,66,20,102,218 },  915396    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64,131,215,10,64,131,215,10,64,162,61,113,64,168,163,215,64,175,10,61,64,138,102,102,64,75,133,31,64,19,105,208,63,182,157,3,63,12,204,205,62,165,139,242,62,237,58,7,63,120,81,236,64,167,51,51,65,23,174,20 },  919708    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64,131,215,10,64,131,215,10,64,162,61,113,64,168,163,215,64,175,10,61,64,138,102,102,64,75,133,31,64,19,105,208,63,182,157,3,63,12,204,205,62,165,139,242,62,237,58,7,63,120,81,236,64,167,51,51,65,23,174,20 },  919772    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64,131,204,84,64,131,204,84,64,162,37,130,64,168,151,224,64,175,10,61,64,138,102,102,64,75,133,31,64,19,105,208,63,182,157,3,63,12,204,205,62,166,124,227,62,237,235,181,63,119,243,7,64,167,45,69,65,23,174,20 },  919836    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {65,167,28,210,65,167,28,210,65,21,146,226,64,237,8,248,64,174,236,44,64,138,87,94,64,75,133,31,64,19,117,50,63,182,202,140,63,13,85,103,63,251,223,36,64,170,108,99,65,42,4,61,65,32,217,41,65,23,174,20 },  919900    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {66,10,107,15,66,10,107,15,65,124,120,89,65,131,38,100,65,136,16,154,65,33,129,52,64,75,132,203,64,137,212,12,64,173,229,178,64,209,247,89,64,230,140,146,65,29,238,169,65,104,244,203,65,64,81,112,65,23,174,20 },  919964    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {65,244,235,60,65,244,235,60,66,8,78,168,65,223,35,98,65,173,169,117,65,109,230,25,65 },  920028    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {121,74,65,32,142,27,65,64,162,237,65,96,183,191,65,134,106,3,65,130,118,104,65,73,2,25,65,48,95,110,65,23,188,195 },  920054    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64,7,104,250,64,7,104,250,66,13,118,254,65,228,24,70,65,173,66,142,65,128,211,229,65,40,202,121,65,55,37,177,65,69,128,232,65,83,220,32,65,188,106,142,65,202,39,87,65,147,36,106,65,143,228,98,65,140,164,90 },  920092    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {66,47,73,231,66,47,73,231,66,1,94,70,65,219,92,148,65,179,252,157,65,138,228,137,65,67,152,234,65,103,211,242,65,134,7,124,65,152,37 },  920156    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {65,243,76,133,66,6,199,65,65,230,234,248,65,197,98,42,65,163,217,93 },  920196    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {66,47,71,174,66,47,71,174,66,26,76,165,66 },  920220    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {219,230,65,206,214,80,65,157,91,61,65,87,192,85,65,164,18,158,65,220,69,18,66,10,59,195,66,23,101,170,66,32,135,39,66,37,160,57,66,23,247,79,66,10,78,100 },  920234    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {66,47,71,174,66,173,249,69,66,102,154,219,65,226,134,87,65,195,12,189,65,163,147,35,65,203,45,91,65,242,199,147,66,13,48,229,66,11,190,138,66,25,104,21,66,54,45,136,66,25,163,186,65,250,51,218 },  920288    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {66,47,71,174,67,21,239,175,66,173,182,205,65,190,56,237,65,202,255,224,65,215,198,210,65,236,53,244,66 },  920352    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {82,139,66,10,138,27,65,244,244,19,65,234,144,93,65,245,233,20,65,206,132,88,65,167,31,157 },  920382    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {66,47,71,174,67,21,240,164,66,170,67,53,65,162,148,141,65,204,74,114,65,246 },  920416    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {87,66 },  920439    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {45,249,66,5,91,199,66,10,137,149,65,247,250,150,65,206,242,185,65,153,251,144,65,81,3,141,64,220,31,243 },  920442    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {66,47,71,174,67,21,240,164,66,180,33,4,65,241,130,255,65,203,31,190,65,164,188,125,65,175,37,41,65,185,141,213,65,195,246,129,65,209,142,9,65,162,73,163,64,216,165,68,64,218,103,29,64,220,40,246 },  920480    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {66,47,71,174,67,21,240,164,66,180,33,72,65,241,133,31,65,169,109,221,65,66,173,55,65,99,183,178,65,130,97,22,65,146,230,84,65,93,247,148,65,32,36 },  920544    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64,216,163,215,64,218,102,102,64,220,40,246 },  920588    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {66,47,71,174,67,21,240,164,66,180,33,72,65,241,133,31,65,169,112,164,65,66,184,82,65,106,244,88,65,137,152,47,65,157,182,50,65,101,49,200,65,32,40,246,64,216,163,215,64,218,102,102,64,220,40,246 },  920608    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64,131,215,10,64,131,215,10,64,162,61,113,64,168,163,215,64,175,10,61,64,138,102,102,64,75,133,31,64,19,105,208,63,182,157,3,63,12,204,205,62,165,139,242,62,237,58,7,63,120,81,236,64,167,51,51,65,23,174,20 },  920860    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64,131,215,10,64,131,215,10,64,162,61,113,64,168,163,215,64,175,10,61,64,138,102,102,64,75,133,31,64,19,105,208,63,182,157,3,63,12,204,205,62,165,139,242,62,237,58,7,63,120,81,236,64,167,51,51,65,23,174,20 },  920924    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64,131,204,84,64,131,204,84,64,162,37,130,64,168,151,224,64,175,10,61,64,138,102,102,64,75,133,31,64,19,105,208,63,182,157,3,63,12,204,205,62,166,124,227,62,237,235,181,63,119,243,7,64,167,45,69,65,23,174,20 },  920988    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {65,167,28,210,65,167,28,210,65,21,146,226,64,237,8,248,64,174,236,44,64,138,87,94,64,75,133,31,64,19,117,50,63,182,202,140,63,13,85,103,63,251,223,36,64,170,108,99,65,42,4,61,65,32,217,41,65,23,174,20 },  921052    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {66,10,107,15,66,10,107,15,65,124,120,89,65,131,38,100,65,136,16,154,65,33,129,52,64,75,132,203,64,137,212,12,64,173,229,178,64,209,247,89,64,230,140,146,65,29,238,169,65,104,244,203,65,64,81,112,65,23,174,20 },  921116    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {65,244,235,60,65,244,235,60,66,8,78,168,65,223,35,98,65,173,169,117,65,109,230,25,65 },  921180    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {121,74,65,32,142,27,65,64,162,237,65,96,183,191,65,134,106,3,65,130,118,104,65,73,2,25,65,48,95,110,65,23,188,195 },  921206    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64,7,104,250,64,7,104,250,66,13,118,254,65,228,24,70,65,173,66,142,65,128,211,229,65,40,202,121,65,55,37,177,65,69,128,232,65,83,220,32,65,188,106,142,65,202,39,87,65,147,36,106,65,143,228,98,65,140,164,90 },  921244    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {66,47,73,231,66,47,73,231,66,1,94,70,65,219,92,148,65,179,252,157,65,138,228,137,65,67,152,234,65,103,211,242,65,134,7,124,65,152,37 },  921308    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {65,243,76,133,66,6,199,65,65,230,234,248,65,197,98,42,65,163,217,93 },  921348    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {66,47,71,174,66,47,71,174,66,26,76,165,66 },  921372    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {219,230,65,206,214,80,65,157,91,61,65,87,192,85,65,164,18,158,65,220,69,18,66,10,59,195,66,23,101,170,66,32,135,39,66,37,160,57,66,23,247,79,66,10,78,100 },  921386    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {66,47,71,174,66,173,249,69,66,102,154,219,65,226,134,87,65,195,12,189,65,163,147,35,65,203,45,91,65,242,199,147,66,13,48,229,66,11,190,138,66,25,104,21,66,54,45,136,66,25,163,186,65,250,51,218 },  921440    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {66,47,71,174,67,21,239,175,66,173,182,205,65,190,56,237,65,202,255,224,65,215,198,210,65,236,53,244,66 },  921504    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {82,139,66,10,138,27,65,244,244,19,65,234,144,93,65,245,233,20,65,206,132,88,65,167,31,157 },  921534    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {66,47,71,174,67,21,240,164,66,170,67,53,65,162,148,141,65,204,74,114,65,246 },  921568    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {87,66 },  921591    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {45,249,66,5,91,199,66,10,137,149,65,247,250,150,65,206,242,185,65,153,251,144,65,81,3,141,64,220,31,243 },  921594    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {66,47,71,174,67,21,240,164,66,180,33,4,65,241,130,255,65,203,31,190,65,164,188,125,65,175,37,41,65,185,141,213,65,195,246,129,65,209,142,9,65,162,73,163,64,216,165,68,64,218,103,29,64,220,40,246 },  921632    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {66,47,71,174,67,21,240,164,66,180,33,72,65,241,133,31,65,169,109,221,65,66,173,55,65,99,183,178,65,130,97,22,65,146,230,84,65,93,247,148,65,32,36 },  921696    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64,216,163,215,64,218,102,102,64,220,40,246 },  921740    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {66,47,71,174,67,21,240,164,66,180,33,72,65,241,133,31,65,169,112,164,65,66,184,82,65,106,244,88,65,137,152,47,65,157,182,50,65,101,49,200,65,32,40,246,64,216,163,215,64,218,102,102,64,220,40,246 },  921760    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64,12,66,236,64,12,66,236,63,202,54,198,64,69,155,8,64,191,34,180,65,13,187,242,64,155,215,10,65,34,209,5,64,215,116,125,64,215,116,125,64,105,154,255,64,59,131,221,64,95,171,50,64,171,1,119,64,182,78,199 },  922012    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64,124,20,68,64,124,20,68,64,35,147,157,64,60,86,124,64,129,117,137,64,164,191,211,63,135,174,20,64,229,10,78,64,165,152,129,64,165,152,129,64,195,57,187,64,166,91,169,64,202,149,148,64,233,5,82,64,225,222,10 },  922076    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64,227,13,96,64,227,13,96,64,131,121,163,64,134,151,131,64,114,121,237,64,87,196,212,64,208,81,236,64,132,114,145,64,103,121,11,64,103,121,11,65,6,107,95,65,7,101,125,65,13,231,59,65,16,129,59,65,14,35,19 },  922140    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {65,90,225,207,65,90,225,207,64,214,4,129,64,253,32,242,64,221,75,53,64,189,117,119,64,67,209,191,65,32,157,156,65,13,116,103,65,13,116,103,65,30,155,128,65,22,45,86,65,58,97,131,65,69,165,240,65,89,91,40 },  922204    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {65,254,206,60,65,254,206,60,65,134,99,209,65,119,45,217,65,63,89,14,65,7,132,67,64,191,81,4,65,147,48,150,65,133,131,227,65,133,131,227,65,188,130,233,65,7,163,207,65,63,19,174,65,110,218,151,65,167,106,59 },  922268    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {65,214,114,134,65,214,114,134,66,22,5,178,65,203,66,124,65,176,36,203,65,149,7,26,64,220,240,162,65,168,65,80,65,172,151,40,65,172,151,40,65,206,250,17,64,245,85,12,65,72,184,230,65,139,127,249,65,185,83,198 },  922332    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {65,165,1,145,65,165,1,145,66,65,71,234,65,251,135,197,65,255,42,122,66,1,102,151,65,14,44,183,65,35,242,129,65,53,111,160,65,53,111,160,65,225,113,58,64,213,184,165,65,64,26,178,65,122,65,118,65,152,25,218 },  922396    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {66,16,252,172,66,16,252,172,65,245,137,6,64,239,168,128,65,169,245,16,66,12 },  922460    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {65,141,56,38,65,26,255,91,65,46,25,165,65,46,25,165,65,227,233,37,64,206,51,69,65,63,183,127,65,80,162,22,65,141,117,131 },  922484    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {66,196,88,202,66,196,88,202,65,212,250,12,65,82,120,130,65,192,158,33,66,12 },  922524    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {65,199,150,38,65,108,87,191,65,78,165,53,65,78,165,53,66,22,132,82,64,207,32,199,65,52,51,157,65,52,194,123,65,100,124,226 },  922548    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {67,73 },  922588    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {67,73 },  922592    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {66,133,243,205,65,190,250,197,65,137,51,169,65,38,217,26,65,213,11,239,65,198,238,220,65,125,86,213,65,125,86,213,66,49,21,229,64,220,255,227,65,60,122,194,65,35,27,221,65,51,143,76 },  922596    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {67,73 },  922652    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {67,73 },  922656    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {66,241,30,131,65,222,108,88,65,155,93,169,65,48,157,243,65,138,134,196,65,194,57,254,65,134,4,89,65,134,4,89,66,52,247,248,64,211,214,240,65,21,83,190,65,3,37,230,65,41,19,80 },  922660    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {67,73 },  922716    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {67,73 },  922720    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {67,46,36,156,65,253,221,235,65,175,129,76,65,66,73,92,64,160,49,77,65,219,112,164,65,123,215,162,65,123,215,162,66,31,80,65,64,218,9,35,65,20,134,114,64,240,189,20,65,66,208,58 },  922724    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {67,73 },  922780    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {67,73 },  922784    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {67,46,36,156,66,14,167,191,65,197,180,246,65,92,52,222,64,166,159,92,65,62,102,102,65,79,157,241,65,79,157,241,65,226,42,207,64,209,154,163,65,11,137,65,65,14,31,70,65,95,249,3 },  922788    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {67,73 },  922844    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {67,73 },  922848    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {67,46,36,156,66,30,96,136,65,225,122,78,65,134,51,139,64,204,125,109,65,103,133,31,65,2,189,160,65,2,189,160,65,128,217,120,64,235,149,61,65,8,249,184,65,42,120,94,65,136,92,104 },  922852    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {67,73 },  922908    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {67,73 },  922912    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {67,46,36,156,66,61,210,26,66,11,249,112,65,180,65,139,65,44,60,240,64,223,26,176,65,27,200,1,65,27,200,1,65,145,197,217,65,65,221,42,65,72,109,79,65,193,177,185,66,20,102,218 },  922916    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {2,2,2,2,2,2,2 },  940649    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {2,2 },  940671    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {2,2,2 },  940676    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {2 },  940715    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {2,2 },  940728    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {2 },  940735    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {2,2,2,2,2,2,2,2,2,2 },  940739    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {2,2,2,2,2,2,2 },  940816    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {2,2 },  940838    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {2,2,2 },  940843    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {2 },  940882    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {2,2 },  940895    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {2 },  940902    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {2,2,2,2,2,2,2,2,2,2 },  940906    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1 },  940989    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1 },  941049    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3,3,3,3,3,3,3,3 },  941673    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3 },  941717    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3,3,3,3,3,3,3,3 },  941840    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3 },  941884    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,1,1,1,1,1 },  942152    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,1 },  942174    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,1 },  942179    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,1 },  942231    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,1,1,1,1,1,1,1 },  942244    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,1,1,1,1,1 },  942319    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,1 },  942341    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,1 },  942346    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,1 },  942398    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,1,1,1,1,1,1,1 },  942411    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3,72,3,72,3,72,3,72 },  942540    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {210 },  942549    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {210 },  942551    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {78 },  942553    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {2,13,2,13,255,255,255,255 },  942610    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3,72,3,72 },  942698    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {255,255 },  942712    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {210 },  942721    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {210,16,98,16,98,16,98,16,98,8,49,3,71,2,13,4,25 },  942723    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3,72,3,72,3,72,3,72 },  943208    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {210 },  943217    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {210 },  943219    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {78 },  943221    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {2,13,2,13,255,255,255,255 },  943278    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {255,255 },  943358    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3,72,3,72 },  943366    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {255,255 },  943380    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {210 },  943389    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {210,16,98,16,98,16,98,16,98,8,49,3,71,2,13,4,25 },  943391    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {4 },  943715    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3 },  943876    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3 },  943878    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3 },  943880    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3 },  943882    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1 },  943884    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1 },  943886    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1 },  943888    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,1,1,1,1,1,1,1 },  943946    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1 },  944048    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1 },  944050    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {10 },  944060    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {10 },  944062    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {10 },  944064    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {10 },  944066    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {10 },  944068    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {10 },  944070    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {10 },  944072    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {10 },  944074    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {4,2,4,1,4,4,4,4,4,6,4,5,4,9,4,3 },  944606    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {4,4 },  944694    );
      }
      return validationEgrInFile;
    }
    public override async Task < bool > checkFileForDpf()  {
      bool validationEgrInFile = true;
      //Algo for checking dpf solution
      if (ToolBox.array.Length > 0)  {
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {192 },  590187    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1 },  590380    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1 },  590426    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1 },  590437    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1 },  590446    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1 },  590554    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1 },  590570    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {10 },  590602    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,1 },  590628    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1 },  590631    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1 },  590671    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64 },  602156    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64 },  602158    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64 },  602160    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64 },  602162    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64 },  602164    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64 },  602166    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64 },  602168    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64 },  602170    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64 },  602204    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64 },  602206    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64 },  602208    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64 },  602210    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64 },  602212    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64 },  602214    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64 },  602216    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64 },  602218    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {38 },  603205    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {38 },  603207    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {38 },  603209    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {38 },  603211    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {37 },  603213    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {35 },  603215    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {32 },  603217    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {30 },  603219    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {29 },  603221    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {25 },  603223    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {25 },  603225    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {25 },  603227    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {25 },  603229    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {25 },  603231    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {25 },  603233    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {25 },  603235    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {50 },  603301    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {50 },  603303    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {50 },  603305    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {50 },  603307    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {50 },  603309    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {50 },  603311    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {44 },  603313    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {38 },  603315    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {38 },  603317    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {38 },  603319    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {38 },  603321    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {38 },  603323    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {38 },  603325    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {38 },  603327    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {38 },  603329    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {38 },  603331    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {60 },  606449    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {60 },  606451    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {60 },  606453    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {60 },  606455    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {60 },  606457    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {60 },  606459    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {60 },  606461    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {60 },  606463    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {112,109,108,106,111,113,120,122,124,115,105,103 },  626523    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {125,118,116,111,121,125,140,144,149,130,111,105 },  626542    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {112,123,114,111,128,130,137,138,138,131,123,117,112,106 },  626561    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {121,142,109,117,109,110,135,134,134,131,128,131,135,130,126,115,105,104,103,108,113,106,112,109,108,121,117,117,116,114,117,120,119,118,112,106,104,102 },  626578    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {99,103,107,109,106,107 },  626617    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {102,104,107,111,109,107,104 },  626627    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {98,95,101,104,110,107,106 },  626635    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {101,102,103,103,107,110,109,108,104,101,98,95 },  626644    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {106,111,109,105,101 },  626657    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {102,104,104,103,106,109,109,108,105,101 },  626663    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {99 },  626674    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {107,108,110,105,103,102,103,104,103,102,104,107,107,106,103,99 },  626676    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {101 },  626693    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {108,104,110,105,105,105,104,104,102,101,103,105,105,105,101,97,99,102 },  626695    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {102,105,104,103,105,104,104,102,101,102,103,103,104,101,98,99 },  626715    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {104 },  626736    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {105,104,104,102,101,101,101,102,103,102 },  626738    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {102,101,104,104,103,102,101,101,102,103,104,102 },  626755    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {101,104,103,102,102,101,102,103,104,104,102 },  626775    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {99,101 },  626794    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {102,103,102,102,101 },  626800    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {100 },  648847    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {100 },  648849    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {100 },  648851    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {100 },  648853    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {100 },  648855    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {100 },  648857    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {100 },  648859    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {100 },  648861    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {100 },  648863    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {100 },  648865    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {100 },  648867    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {100 },  648869    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {100 },  648871    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {100 },  648873    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {100 },  648875    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {82,128,82,128,82,128,82,128,82,128,82,128,82,128,82,128,82,128,78,176,80,160,80,160,82,160,74,80,66,224,74,176,72,96,68,224,53,176,42,48,56,96,43,240,35,96,10,16,0 },  674672    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {9,179,9,102,9,51,9,92,9,13,8,128,8,51,7,218,7,154,7,85,9,179,9,102,9,51,9,92,9,13,8,128,8,51,7,218,7,154,7,85,9,179,9,102,9,51,9,92,9,13,8,128,8,51,7,64,6,195,6,72,9,154,9,102,9,51,8,192,8,36,7,20,6,102,5,187,5,28,4,118,8,64,7,241,7,154,6,166,5,172,4,61,3,110,2,133,1,200,0,223 },  686320    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {63,102,102,102,63,102,102,102,63,102,102,102,63,102,102,102,63,102,102,102,63,102,102,102,63,102,102,102,63,102,102,102 },  876820    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {63,102,102,102,63,102,102,102,63,102,102,102,63,102,102,102,63,102,102,102,63,102,102,102,63,102,102,102,63,102,102,102 },  876892    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {63,102,102,102,63,102,102,102,63,102,102,102,63,102,102,102,63,102,102,102,63,102,102,102,63,102,102,102,63,102,102,102 },  876964    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {63,102,102,102,63,102,102,102,63,102,102,102,63,102,102,102,63,102,102,102,63,102,102,102,63,102,102,102,63,102,102,102 },  877036    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {63,102,102,102,63,102,102,102,63,102,102,102,63,102,102,102,63,102,102,102,63,102,102,102,63,102,102,102,63,102,102,102 },  877108    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {63,64 },  877180    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {63,64 },  877184    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {63,76,204,205,63,83,51,51,63,102,102,102,63,102,102,102,63,51,51,51,63,64 },  877188    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {63,25,153,154,63,25,153,154,63,51,51,51,63,64 },  877252    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {63,102,102,102,63,102,102,102,63,102,102,102,63,25,153,154 },  877268    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {63 },  877324    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {63 },  877328    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {63,25,153,154,63,38,102,102,63,76,204,205,63,89,153,154,63,89,153,154,63,25,153,154 },  877332    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {62,204,204,205,62,204,204,205,63 },  877396    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {63,12,204,205,63,51,51,51,63,76,204,205,63,76,204,205,63,25,153,154 },  877408    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {62,76,204,205,62,76,204,205,62,128 },  877468    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {62,128 },  877480    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {62,179,51,51,62,204,204,205,62,204,204,205,62,153,153,154 },  877484    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {0,0 },  904760    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {66,112 },  904764    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {66,112 },  904768    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {66,97,235,133,66,97,235,133,66,106,215,10,66,132,148,123,66,170 },  904772    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {66,191,143,92,66,193,250,225,66,192,10,61,66,187,245,195,66,183,250,225,66,187,46,20,66,181,5,31,66,170 },  904792    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {66,163,250,225,66,157,10,61,66,152,10,61,66,146,163,215,66,92,122,225,65,112 },  904824    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {0,0 },  904848    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {0,0 },  904852    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {66,112 },  904856    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {66,112 },  904860    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {66,97,235,133,66,97,235,133,66,106,215,10,66,132,148,123,66,170 },  904864    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {66,191,143,92,66,193,250,225,66,192,10,61,66,187,245,195,66,183,250,225,66,187,46,20,66,181,5,31,66,170 },  904884    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {66,163,250,225,66,157,10,61,66,152,10,61,66,146,163,215,66,92,122,225,65,112 },  904916    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {0,0 },  904940    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {0,0 },  904944    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {66,112 },  904948    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {66,110,102,102,66,48 },  904952    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {66,32 },  904960    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {66,2 },  904964    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {66,14 },  904968    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {66,20 },  904972    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {66,32 },  904976    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {66,32 },  904980    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {66,32 },  904984    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {66,32 },  904988    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {66,32 },  904992    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {65,240 },  904996    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {65,200 },  905000    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {65,200 },  905004    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {65,200 },  905008    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {65,200 },  905012    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {65,200 },  905016    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {65,200 },  905020    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {65,200 },  905024    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {0,0 },  905028    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {0,0 },  905032    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {0,0 },  905036    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {66,112 },  905040    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {66,110,102,102,66,40 },  905044    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {66,20 },  905052    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {65,236 },  905056    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {66,0 },  905060    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {66,6 },  905064    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {66,16 },  905068    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {66,0 },  905072    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {65,224 },  905076    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {65,208 },  905080    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {65,200 },  905084    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {65,200 },  905088    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {65,160 },  905092    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {65,160 },  905096    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {65,160 },  905100    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {65,160 },  905104    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {65,160 },  905108    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {65,160 },  905112    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {65,160 },  905116    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {0,0 },  905120    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {0,0 },  905124    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {0,0 },  905128    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {66,112 },  905132    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {66,110,102,102,66,32 },  905136    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {66,12 },  905144    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {65,196 },  905148    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {65,216 },  905152    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {65,224 },  905156    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {65,240 },  905160    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {65,200 },  905164    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {65,160 },  905168    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {65,160 },  905172    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {0,0 },  905176    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {0,0 },  905180    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {0,0 },  905184    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {0,0 },  905188    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {0,0 },  905192    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {0,0 },  905196    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {0,0 },  905200    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {0,0 },  905204    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {0,0 },  905208    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {0,0 },  905212    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {0,0 },  905216    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64,12,66,236,64,12,66,236,63,202,54,198,64,69,155,8,64,54,136,193,64,71,29,233,64,91,224,64,64,92,189,248,64,113,227,49,64,131,132,53,64,105,154,255,64,59,131,221,64,95,171,50,64,171,1,119,64,182,78,199 },  914492    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64,124,20,68,64,124,20,68,64,35,147,157,64,60,86,124,64,129,117,137,64,164,191,211,63,135,174,20,64,154,57,141,64,165,152,129,64,165,152,129,64,179,36,245,64,166,91,169,64,202,149,148,64,233,5,82,64,225,222,10 },  914556    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64,227,13,96,64,227,13,96,64,131,121,163,64,134,151,131,64,114,121,237,64,87,196,212,64,208,81,236,64,132,114,145,64,103,121,11,64,103,121,11,64,217,157,115,64,226,92,187,64,214,42,109,65,16,129,59,65,14,35,19 },  914620    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {65,90,225,207,65,90,225,207,64,214,4,129,64,253,32,242,64,221,75,53,64,189,117,119,64,67,209,191,65,32,157,156,65,13,116,103,65,13,116,103,64,245,198,211,64,223,228,219,64,255,30,239,65,36,227,108,65,89,91,40 },  914684    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {65,254,206,60,65,254,206,60,65,134,99,209,65,119,45,217,65,63,89,14,65,7,132,67,64,191,81,4,65,147,48,150,65,133,131,227,65,127,154,192,64,250,203,184,64,223,212,215,64,252,89,124,65,49,227,224,65,167,106,59 },  914748    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {65,214,114,134,65,214,114,134,66,22,5,178,65,203,66,124,65,176,36,203,65,149,7,26,64,220,240,162,65,168,65,80,65,172,151,40,65,172,151,40,64,219,189,194,64,209,40,31,64,246,133,47,65,55,49,171,65,185,83,198 },  914812    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {65,165,1,145,65,165,1,145,66,65,71,234,65,230,218,150,65,255,42,122,66,1,102,151,65,14,44,183,65,35,242,129,65,53,111,160,65,53,111,160,64,186,164,227,64,207,53,74,65 },  914876    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {193,16,65,39,185,245,65,152,25,218 },  914926    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {66,16,252,172,66,16,252,172,65,245,137,6,64,239,168,128,65,169,245,16,66,12 },  914940    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {65,141,56,38,65,26,255,91,65,46,25,165,65,46,25,165,64,229,70,60,64,184,30,222,65,24,144,9,65,51,111,171,65,141,117,131 },  914964    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {66,196,88,202,66,196,88,202,65,212,250,12,65,82,120,130,65,192,158,33,66,9,235,202,65,199,150,38,65,108,87,191,65,78,165,53,65,78,165,53,64,239,192,185,64,178,6,189,65,29,250,66,65,33,112,126,65,100,124,226 },  915004    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {67,73 },  915068    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {67,73 },  915072    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {66,133,243,205,65,190,250,197,65,137,51,169,65,38,217,26,65,213,11,239,65,198,238,220,65,125,86,213,65,125,86,213,65,5,161,239,64,187,184,26,65,24,106,127,65,6,144,122,65,51,143,76 },  915076    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {67,73 },  915132    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {67,73 },  915136    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {66,241,30,131,65,222,108,88,65,155,93,169,65,31,161,139,65,138,134,196,65,194,57,254,65,134,4,89,65,134,4,89,65,22,4,13,64,201,217,162,64,229,218,38,64,237,52,62,65,41,19,80 },  915140    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {67,73 },  915196    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {67,73 },  915200    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {67,46,36,156,65,253,221,235,65,175,129,76,65,25,116,6,64,160,49,77,65,83,58,145,65,123,215,162,65,123,215,162,65,15,244,33,64,212,173,91,64,223,181,203,64,227,229,176,65,66,208,58 },  915204    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {67,73 },  915260    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {67,73 },  915264    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {67,46,36,156,66,14,167,191,65,197,180,246,65,33,96,216,64,166,159,92,65,4,123,43,65,79,157,241,65,79,157,241,65,40,10,27,64,209,154,163,65,11,137,65,65,14,31,70,65,95,249,3 },  915268    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {67,73 },  915324    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {67,73 },  915328    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {67,46,36,156,66,30,96,136,65,225,122,78,65,53,48,168,64,204,125,109,64,252,35,115,65,2,189,160,65,2,189,160,65,87,170,33,64,235,149,61,65,8,249,184,65,42,120,94,65,136,92,104 },  915332    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {67,73 },  915388    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {67,73 },  915392    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {67,46,36,156,66,61,210,26,66,11,249,112,65,180,65,139,65,44,60,240,64,223,26,176,65,27,200,1,65,27,200,1,65,145,197,217,65,65,221,42,65,72,109,79,65,193,177,185,66,20,102,218 },  915396    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64,131,215,10,64,131,215,10,64,162,61,113,64,168,163,215,64,175,10,61,64,138,102,102,64,75,133,31,64,19,105,208,63,182,157,3,63,12,204,205,62,165,139,242,62,237,58,7,63,120,81,236,64,167,51,51,65,23,174,20 },  919708    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64,131,215,10,64,131,215,10,64,162,61,113,64,168,163,215,64,175,10,61,64,138,102,102,64,75,133,31,64,19,105,208,63,182,157,3,63,12,204,205,62,165,139,242,62,237,58,7,63,120,81,236,64,167,51,51,65,23,174,20 },  919772    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64,131,204,84,64,131,204,84,64,162,37,130,64,168,151,224,64,175,10,61,64,138,102,102,64,75,133,31,64,19,105,208,63,182,157,3,63,12,204,205,62,166,124,227,62,237,235,181,63,119,243,7,64,167,45,69,65,23,174,20 },  919836    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {65,167,28,210,65,167,28,210,65,21,146,226,64,237,8,248,64,174,236,44,64,138,87,94,64,75,133,31,64,19,117,50,63,182,202,140,63,13,85,103,63,251,223,36,64,170,108,99,65,42,4,61,65,32,217,41,65,23,174,20 },  919900    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {66,10,107,15,66,10,107,15,65,124,120,89,65,131,38,100,65,136,16,154,65,33,129,52,64,75,132,203,64,137,212,12,64,173,229,178,64,209,247,89,64,230,140,146,65,29,238,169,65,104,244,203,65,64,81,112,65,23,174,20 },  919964    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {65,244,235,60,65,244,235,60,66,8,78,168,65,223,35,98,65,173,169,117,65,109,230,25,65 },  920028    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {121,74,65,32,142,27,65,64,162,237,65,96,183,191,65,134,106,3,65,130,118,104,65,73,2,25,65,48,95,110,65,23,188,195 },  920054    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64,7,104,250,64,7,104,250,66,13,118,254,65,228,24,70,65,173,66,142,65,128,211,229,65,40,202,121,65,55,37,177,65,69,128,232,65,83,220,32,65,188,106,142,65,202,39,87,65,147,36,106,65,143,228,98,65,140,164,90 },  920092    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {66,47,73,231,66,47,73,231,66,1,94,70,65,219,92,148,65,179,252,157,65,138,228,137,65,67,152,234,65,103,211,242,65,134,7,124,65,152,37 },  920156    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {65,243,76,133,66,6,199,65,65,230,234,248,65,197,98,42,65,163,217,93 },  920196    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {66,47,71,174,66,47,71,174,66,26,76,165,66 },  920220    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {219,230,65,206,214,80,65,157,91,61,65,87,192,85,65,164,18,158,65,220,69,18,66,10,59,195,66,23,101,170,66,32,135,39,66,37,160,57,66,23,247,79,66,10,78,100 },  920234    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {66,47,71,174,66,173,249,69,66,102,154,219,65,226,134,87,65,195,12,189,65,163,147,35,65,203,45,91,65,242,199,147,66,13,48,229,66,11,190,138,66,25,104,21,66,54,45,136,66,25,163,186,65,250,51,218 },  920288    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {66,47,71,174,67,21,239,175,66,173,182,205,65,190,56,237,65,202,255,224,65,215,198,210,65,236,53,244,66 },  920352    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {82,139,66,10,138,27,65,244,244,19,65,234,144,93,65,245,233,20,65,206,132,88,65,167,31,157 },  920382    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {66,47,71,174,67,21,240,164,66,170,67,53,65,162,148,141,65,204,74,114,65,246 },  920416    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {87,66 },  920439    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {45,249,66,5,91,199,66,10,137,149,65,247,250,150,65,206,242,185,65,153,251,144,65,81,3,141,64,220,31,243 },  920442    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {66,47,71,174,67,21,240,164,66,180,33,4,65,241,130,255,65,203,31,190,65,164,188,125,65,175,37,41,65,185,141,213,65,195,246,129,65,209,142,9,65,162,73,163,64,216,165,68,64,218,103,29,64,220,40,246 },  920480    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {66,47,71,174,67,21,240,164,66,180,33,72,65,241,133,31,65,169,109,221,65,66,173,55,65,99,183,178,65,130,97,22,65,146,230,84,65,93,247,148,65,32,36 },  920544    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64,216,163,215,64,218,102,102,64,220,40,246 },  920588    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {66,47,71,174,67,21,240,164,66,180,33,72,65,241,133,31,65,169,112,164,65,66,184,82,65,106,244,88,65,137,152,47,65,157,182,50,65,101,49,200,65,32,40,246,64,216,163,215,64,218,102,102,64,220,40,246 },  920608    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64,131,215,10,64,131,215,10,64,162,61,113,64,168,163,215,64,175,10,61,64,138,102,102,64,75,133,31,64,19,105,208,63,182,157,3,63,12,204,205,62,165,139,242,62,237,58,7,63,120,81,236,64,167,51,51,65,23,174,20 },  920860    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64,131,215,10,64,131,215,10,64,162,61,113,64,168,163,215,64,175,10,61,64,138,102,102,64,75,133,31,64,19,105,208,63,182,157,3,63,12,204,205,62,165,139,242,62,237,58,7,63,120,81,236,64,167,51,51,65,23,174,20 },  920924    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64,131,204,84,64,131,204,84,64,162,37,130,64,168,151,224,64,175,10,61,64,138,102,102,64,75,133,31,64,19,105,208,63,182,157,3,63,12,204,205,62,166,124,227,62,237,235,181,63,119,243,7,64,167,45,69,65,23,174,20 },  920988    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {65,167,28,210,65,167,28,210,65,21,146,226,64,237,8,248,64,174,236,44,64,138,87,94,64,75,133,31,64,19,117,50,63,182,202,140,63,13,85,103,63,251,223,36,64,170,108,99,65,42,4,61,65,32,217,41,65,23,174,20 },  921052    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {66,10,107,15,66,10,107,15,65,124,120,89,65,131,38,100,65,136,16,154,65,33,129,52,64,75,132,203,64,137,212,12,64,173,229,178,64,209,247,89,64,230,140,146,65,29,238,169,65,104,244,203,65,64,81,112,65,23,174,20 },  921116    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {65,244,235,60,65,244,235,60,66,8,78,168,65,223,35,98,65,173,169,117,65,109,230,25,65 },  921180    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {121,74,65,32,142,27,65,64,162,237,65,96,183,191,65,134,106,3,65,130,118,104,65,73,2,25,65,48,95,110,65,23,188,195 },  921206    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64,7,104,250,64,7,104,250,66,13,118,254,65,228,24,70,65,173,66,142,65,128,211,229,65,40,202,121,65,55,37,177,65,69,128,232,65,83,220,32,65,188,106,142,65,202,39,87,65,147,36,106,65,143,228,98,65,140,164,90 },  921244    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {66,47,73,231,66,47,73,231,66,1,94,70,65,219,92,148,65,179,252,157,65,138,228,137,65,67,152,234,65,103,211,242,65,134,7,124,65,152,37 },  921308    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {65,243,76,133,66,6,199,65,65,230,234,248,65,197,98,42,65,163,217,93 },  921348    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {66,47,71,174,66,47,71,174,66,26,76,165,66 },  921372    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {219,230,65,206,214,80,65,157,91,61,65,87,192,85,65,164,18,158,65,220,69,18,66,10,59,195,66,23,101,170,66,32,135,39,66,37,160,57,66,23,247,79,66,10,78,100 },  921386    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {66,47,71,174,66,173,249,69,66,102,154,219,65,226,134,87,65,195,12,189,65,163,147,35,65,203,45,91,65,242,199,147,66,13,48,229,66,11,190,138,66,25,104,21,66,54,45,136,66,25,163,186,65,250,51,218 },  921440    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {66,47,71,174,67,21,239,175,66,173,182,205,65,190,56,237,65,202,255,224,65,215,198,210,65,236,53,244,66 },  921504    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {82,139,66,10,138,27,65,244,244,19,65,234,144,93,65,245,233,20,65,206,132,88,65,167,31,157 },  921534    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {66,47,71,174,67,21,240,164,66,170,67,53,65,162,148,141,65,204,74,114,65,246 },  921568    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {87,66 },  921591    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {45,249,66,5,91,199,66,10,137,149,65,247,250,150,65,206,242,185,65,153,251,144,65,81,3,141,64,220,31,243 },  921594    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {66,47,71,174,67,21,240,164,66,180,33,4,65,241,130,255,65,203,31,190,65,164,188,125,65,175,37,41,65,185,141,213,65,195,246,129,65,209,142,9,65,162,73,163,64,216,165,68,64,218,103,29,64,220,40,246 },  921632    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {66,47,71,174,67,21,240,164,66,180,33,72,65,241,133,31,65,169,109,221,65,66,173,55,65,99,183,178,65,130,97,22,65,146,230,84,65,93,247,148,65,32,36 },  921696    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64,216,163,215,64,218,102,102,64,220,40,246 },  921740    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {66,47,71,174,67,21,240,164,66,180,33,72,65,241,133,31,65,169,112,164,65,66,184,82,65,106,244,88,65,137,152,47,65,157,182,50,65,101,49,200,65,32,40,246,64,216,163,215,64,218,102,102,64,220,40,246 },  921760    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64,12,66,236,64,12,66,236,63,202,54,198,64,69,155,8,64,191,34,180,65,13,187,242,64,155,215,10,65,34,209,5,64,215,116,125,64,215,116,125,64,105,154,255,64,59,131,221,64,95,171,50,64,171,1,119,64,182,78,199 },  922012    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64,124,20,68,64,124,20,68,64,35,147,157,64,60,86,124,64,129,117,137,64,164,191,211,63,135,174,20,64,229,10,78,64,165,152,129,64,165,152,129,64,195,57,187,64,166,91,169,64,202,149,148,64,233,5,82,64,225,222,10 },  922076    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64,227,13,96,64,227,13,96,64,131,121,163,64,134,151,131,64,114,121,237,64,87,196,212,64,208,81,236,64,132,114,145,64,103,121,11,64,103,121,11,65,6,107,95,65,7,101,125,65,13,231,59,65,16,129,59,65,14,35,19 },  922140    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {65,90,225,207,65,90,225,207,64,214,4,129,64,253,32,242,64,221,75,53,64,189,117,119,64,67,209,191,65,32,157,156,65,13,116,103,65,13,116,103,65,30,155,128,65,22,45,86,65,58,97,131,65,69,165,240,65,89,91,40 },  922204    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {65,254,206,60,65,254,206,60,65,134,99,209,65,119,45,217,65,63,89,14,65,7,132,67,64,191,81,4,65,147,48,150,65,133,131,227,65,133,131,227,65,188,130,233,65,7,163,207,65,63,19,174,65,110,218,151,65,167,106,59 },  922268    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {65,214,114,134,65,214,114,134,66,22,5,178,65,203,66,124,65,176,36,203,65,149,7,26,64,220,240,162,65,168,65,80,65,172,151,40,65,172,151,40,65,206,250,17,64,245,85,12,65,72,184,230,65,139,127,249,65,185,83,198 },  922332    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {65,165,1,145,65,165,1,145,66,65,71,234,65,251,135,197,65,255,42,122,66,1,102,151,65,14,44,183,65,35,242,129,65,53,111,160,65,53,111,160,65,225,113,58,64,213,184,165,65,64,26,178,65,122,65,118,65,152,25,218 },  922396    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {66,16,252,172,66,16,252,172,65,245,137,6,64,239,168,128,65,169,245,16,66,12 },  922460    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {65,141,56,38,65,26,255,91,65,46,25,165,65,46,25,165,65,227,233,37,64,206,51,69,65,63,183,127,65,80,162,22,65,141,117,131 },  922484    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {66,196,88,202,66,196,88,202,65,212,250,12,65,82,120,130,65,192,158,33,66,12 },  922524    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {65,199,150,38,65,108,87,191,65,78,165,53,65,78,165,53,66,22,132,82,64,207,32,199,65,52,51,157,65,52,194,123,65,100,124,226 },  922548    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {67,73 },  922588    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {67,73 },  922592    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {66,133,243,205,65,190,250,197,65,137,51,169,65,38,217,26,65,213,11,239,65,198,238,220,65,125,86,213,65,125,86,213,66,49,21,229,64,220,255,227,65,60,122,194,65,35,27,221,65,51,143,76 },  922596    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {67,73 },  922652    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {67,73 },  922656    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {66,241,30,131,65,222,108,88,65,155,93,169,65,48,157,243,65,138,134,196,65,194,57,254,65,134,4,89,65,134,4,89,66,52,247,248,64,211,214,240,65,21,83,190,65,3,37,230,65,41,19,80 },  922660    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {67,73 },  922716    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {67,73 },  922720    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {67,46,36,156,65,253,221,235,65,175,129,76,65,66,73,92,64,160,49,77,65,219,112,164,65,123,215,162,65,123,215,162,66,31,80,65,64,218,9,35,65,20,134,114,64,240,189,20,65,66,208,58 },  922724    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {67,73 },  922780    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {67,73 },  922784    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {67,46,36,156,66,14,167,191,65,197,180,246,65,92,52,222,64,166,159,92,65,62,102,102,65,79,157,241,65,79,157,241,65,226,42,207,64,209,154,163,65,11,137,65,65,14,31,70,65,95,249,3 },  922788    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {67,73 },  922844    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {67,73 },  922848    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {67,46,36,156,66,30,96,136,65,225,122,78,65,134,51,139,64,204,125,109,65,103,133,31,65,2,189,160,65,2,189,160,65,128,217,120,64,235,149,61,65,8,249,184,65,42,120,94,65,136,92,104 },  922852    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {67,73 },  922908    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {67,73 },  922912    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {67,46,36,156,66,61,210,26,66,11,249,112,65,180,65,139,65,44,60,240,64,223,26,176,65,27,200,1,65,27,200,1,65,145,197,217,65,65,221,42,65,72,109,79,65,193,177,185,66,20,102,218 },  922916    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {2,2,2,2,2,2,2 },  940649    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {2,2 },  940671    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {2,2,2 },  940676    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {2 },  940715    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {2,2 },  940728    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {2 },  940735    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {2,2,2,2,2,2,2,2,2,2 },  940739    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {2,2,2,2,2,2,2 },  940816    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {2,2 },  940838    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {2,2,2 },  940843    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {2 },  940882    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {2,2 },  940895    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {2 },  940902    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {2,2,2,2,2,2,2,2,2,2 },  940906    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1 },  940989    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1 },  941049    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3,3,3,3,3,3,3,3 },  941673    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3 },  941717    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3,3,3,3,3,3,3,3 },  941840    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3 },  941884    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,1,1,1,1,1 },  942152    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,1 },  942174    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,1 },  942179    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,1 },  942231    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,1,1,1,1,1,1,1 },  942244    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,1,1,1,1,1 },  942319    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,1 },  942341    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,1 },  942346    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,1 },  942398    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,1,1,1,1,1,1,1 },  942411    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3,72,3,72,3,72,3,72 },  942540    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {210 },  942549    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {210 },  942551    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {78 },  942553    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {2,13,2,13,255,255,255,255 },  942610    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3,72,3,72 },  942698    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {255,255 },  942712    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {210 },  942721    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {210,16,98,16,98,16,98,16,98,8,49,3,71,2,13,4,25 },  942723    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3,72,3,72,3,72,3,72 },  943208    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {210 },  943217    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {210 },  943219    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {78 },  943221    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {2,13,2,13,255,255,255,255 },  943278    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {255,255 },  943358    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3,72,3,72 },  943366    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {255,255 },  943380    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {210 },  943389    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {210,16,98,16,98,16,98,16,98,8,49,3,71,2,13,4,25 },  943391    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {4 },  943715    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3 },  943876    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3 },  943878    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3 },  943880    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3 },  943882    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1 },  943884    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1 },  943886    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1 },  943888    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,1,1,1,1,1,1,1 },  943946    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1 },  944048    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1 },  944050    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {10 },  944060    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {10 },  944062    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {10 },  944064    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {10 },  944066    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {10 },  944068    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {10 },  944070    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {10 },  944072    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {10 },  944074    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {4,2,4,1,4,4,4,4,4,6,4,5,4,9,4,3 },  944606    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {4,4 },  944694    );
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
	ToolBox.ReplaceInFileWithStartStop(new byte[]  {192 },
 new byte[]  { 0 },590187,590187, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1 },
 new byte[]  { 0 },590380,590380, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1 },
 new byte[]  { 0 },590426,590426, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1 },
 new byte[]  { 0 },590437,590437, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1 },
 new byte[]  { 0 },590446,590446, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1 },
 new byte[]  { 0 },590554,590554, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1 },
 new byte[]  { 0 },590570,590570, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {10 },
 new byte[]  { 3 },590602,590602, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,1 },
 new byte[]  { 0,0 },590628,590629, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1 },
 new byte[]  { 0 },590631,590631, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1 },
 new byte[]  { 0 },590671,590671, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64 },
 new byte[]  { 0 },602156,602156, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64 },
 new byte[]  { 0 },602158,602158, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64 },
 new byte[]  { 0 },602160,602160, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64 },
 new byte[]  { 0 },602162,602162, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64 },
 new byte[]  { 0 },602164,602164, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64 },
 new byte[]  { 0 },602166,602166, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64 },
 new byte[]  { 0 },602168,602168, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64 },
 new byte[]  { 0 },602170,602170, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64 },
 new byte[]  { 0 },602204,602204, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64 },
 new byte[]  { 0 },602206,602206, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64 },
 new byte[]  { 0 },602208,602208, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64 },
 new byte[]  { 0 },602210,602210, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64 },
 new byte[]  { 0 },602212,602212, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64 },
 new byte[]  { 0 },602214,602214, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64 },
 new byte[]  { 0 },602216,602216, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64 },
 new byte[]  { 0 },602218,602218, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {38 },
 new byte[]  { 0 },603205,603205, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {38 },
 new byte[]  { 0 },603207,603207, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {38 },
 new byte[]  { 0 },603209,603209, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {38 },
 new byte[]  { 0 },603211,603211, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {37 },
 new byte[]  { 0 },603213,603213, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {35 },
 new byte[]  { 0 },603215,603215, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {32 },
 new byte[]  { 0 },603217,603217, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {30 },
 new byte[]  { 0 },603219,603219, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {29 },
 new byte[]  { 0 },603221,603221, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {25 },
 new byte[]  { 0 },603223,603223, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {25 },
 new byte[]  { 0 },603225,603225, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {25 },
 new byte[]  { 0 },603227,603227, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {25 },
 new byte[]  { 0 },603229,603229, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {25 },
 new byte[]  { 0 },603231,603231, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {25 },
 new byte[]  { 0 },603233,603233, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {25 },
 new byte[]  { 0 },603235,603235, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {50 },
 new byte[]  { 0 },603301,603301, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {50 },
 new byte[]  { 0 },603303,603303, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {50 },
 new byte[]  { 0 },603305,603305, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {50 },
 new byte[]  { 0 },603307,603307, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {50 },
 new byte[]  { 0 },603309,603309, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {50 },
 new byte[]  { 0 },603311,603311, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {44 },
 new byte[]  { 0 },603313,603313, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {38 },
 new byte[]  { 0 },603315,603315, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {38 },
 new byte[]  { 0 },603317,603317, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {38 },
 new byte[]  { 0 },603319,603319, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {38 },
 new byte[]  { 0 },603321,603321, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {38 },
 new byte[]  { 0 },603323,603323, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {38 },
 new byte[]  { 0 },603325,603325, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {38 },
 new byte[]  { 0 },603327,603327, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {38 },
 new byte[]  { 0 },603329,603329, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {38 },
 new byte[]  { 0 },603331,603331, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {60 },
 new byte[]  { 5 },606449,606449, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {60 },
 new byte[]  { 5 },606451,606451, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {60 },
 new byte[]  { 5 },606453,606453, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {60 },
 new byte[]  { 5 },606455,606455, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {60 },
 new byte[]  { 5 },606457,606457, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {60 },
 new byte[]  { 5 },606459,606459, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {60 },
 new byte[]  { 5 },606461,606461, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {60 },
 new byte[]  { 5 },606463,606463, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {112,109,108,106,111,113,120,122,124,115,105,103 },
 new byte[]  { 100,100,100,100,100,100,100,100,100,100,100,100 },626523,626534, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {125,118,116,111,121,125,140,144,149,130,111,105 },
 new byte[]  { 100,100,100,100,100,100,100,100,100,100,100,100 },626542,626553, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {112,123,114,111,128,130,137,138,138,131,123,117,112,106 },
 new byte[]  { 100,100,100,100,100,100,100,100,100,100,100,100,100,100 },626561,626574, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {121,142,109,117,109,110,135,134,134,131,128,131,135,130,126,115,105,104,103,108,113,106,112,109,108,121,117,117,116,114,117,120,119,118,112,106,104,102 },
 new byte[]  { 100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100 },626578,626615, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {99,103,107,109,106,107 },
 new byte[]  { 100,100,100,100,100,100 },626617,626622, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {102,104,107,111,109,107,104 },
 new byte[]  { 100,100,100,100,100,100,100 },626627,626633, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {98,95,101,104,110,107,106 },
 new byte[]  { 100,100,100,100,100,100,100 },626635,626641, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {101,102,103,103,107,110,109,108,104,101,98,95 },
 new byte[]  { 100,100,100,100,100,100,100,100,100,100,100,100 },626644,626655, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {106,111,109,105,101 },
 new byte[]  { 100,100,100,100,100 },626657,626661, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {102,104,104,103,106,109,109,108,105,101 },
 new byte[]  { 100,100,100,100,100,100,100,100,100,100 },626663,626672, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {99 },
 new byte[]  { 100 },626674,626674, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {107,108,110,105,103,102,103,104,103,102,104,107,107,106,103,99 },
 new byte[]  { 100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100 },626676,626691, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {101 },
 new byte[]  { 100 },626693,626693, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {108,104,110,105,105,105,104,104,102,101,103,105,105,105,101,97,99,102 },
 new byte[]  { 100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100 },626695,626712, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {102,105,104,103,105,104,104,102,101,102,103,103,104,101,98,99 },
 new byte[]  { 100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100 },626715,626730, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {104 },
 new byte[]  { 100 },626736,626736, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {105,104,104,102,101,101,101,102,103,102 },
 new byte[]  { 100,100,100,100,100,100,100,100,100,100 },626738,626747, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {102,101,104,104,103,102,101,101,102,103,104,102 },
 new byte[]  { 100,100,100,100,100,100,100,100,100,100,100,100 },626755,626766, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {101,104,103,102,102,101,102,103,104,104,102 },
 new byte[]  { 100,100,100,100,100,100,100,100,100,100,100 },626775,626785, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {99,101 },
 new byte[]  { 100,100 },626794,626795, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {102,103,102,102,101 },
 new byte[]  { 100,100,100,100,100 },626800,626804, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {100 },
 new byte[]  { 0 },648847,648847, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {100 },
 new byte[]  { 0 },648849,648849, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {100 },
 new byte[]  { 0 },648851,648851, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {100 },
 new byte[]  { 0 },648853,648853, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {100 },
 new byte[]  { 0 },648855,648855, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {100 },
 new byte[]  { 0 },648857,648857, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {100 },
 new byte[]  { 0 },648859,648859, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {100 },
 new byte[]  { 0 },648861,648861, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {100 },
 new byte[]  { 0 },648863,648863, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {100 },
 new byte[]  { 0 },648865,648865, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {100 },
 new byte[]  { 0 },648867,648867, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {100 },
 new byte[]  { 0 },648869,648869, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {100 },
 new byte[]  { 0 },648871,648871, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {100 },
 new byte[]  { 0 },648873,648873, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {100 },
 new byte[]  { 0 },648875,648875, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {82,128,82,128,82,128,82,128,82,128,82,128,82,128,82,128,82,128,78,176,80,160,80,160,82,160,74,80,66,224,74,176,72,96,68,224,53,176,42,48,56,96,43,240,35,96,10,16,0 },
 new byte[]  { 125,0,125,0,125,0,125,0,125,0,125,0,125,0,125,0,125,0,125,0,125,0,125,0,125,0,125,0,125,0,125,0,125,0,125,0,125,0,125,0,125,0,125,0,125,0,125,0,125 },674672,674720, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {9,179,9,102,9,51,9,92,9,13,8,128,8,51,7,218,7,154,7,85,9,179,9,102,9,51,9,92,9,13,8,128,8,51,7,218,7,154,7,85,9,179,9,102,9,51,9,92,9,13,8,128,8,51,7,64,6,195,6,72,9,154,9,102,9,51,8,192,8,36,7,20,6,102,5,187,5,28,4,118,8,64,7,241,7,154,6,166,5,172,4,61,3,110,2,133,1,200,0,223 },
 new byte[]  { 15,0,15,0,15,0,15,0,15,0,15,0,15,0,15,0,15,0,15,0,15,0,15,0,15,0,15,0,15,0,15,0,15,0,15,0,15,0,15,0,15,0,15,0,15,0,15,0,15,0,15,0,15,0,15,0,15,0,15,0,15,0,15,0,15,0,15,0,15,0,15,0,15,0,15,0,15,0,15,0,15,0,15,0,15,0,15,0,15,0,15,0,15,0,15,0,15,0,15,0 },686320,686419, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {63,102,102,102,63,102,102,102,63,102,102,102,63,102,102,102,63,102,102,102,63,102,102,102,63,102,102,102,63,102,102,102 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },876820,876851, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {63,102,102,102,63,102,102,102,63,102,102,102,63,102,102,102,63,102,102,102,63,102,102,102,63,102,102,102,63,102,102,102 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },876892,876923, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {63,102,102,102,63,102,102,102,63,102,102,102,63,102,102,102,63,102,102,102,63,102,102,102,63,102,102,102,63,102,102,102 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },876964,876995, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {63,102,102,102,63,102,102,102,63,102,102,102,63,102,102,102,63,102,102,102,63,102,102,102,63,102,102,102,63,102,102,102 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },877036,877067, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {63,102,102,102,63,102,102,102,63,102,102,102,63,102,102,102,63,102,102,102,63,102,102,102,63,102,102,102,63,102,102,102 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },877108,877139, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {63,64 },
 new byte[]  { 0,0 },877180,877181, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {63,64 },
 new byte[]  { 0,0 },877184,877185, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {63,76,204,205,63,83,51,51,63,102,102,102,63,102,102,102,63,51,51,51,63,64 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },877188,877209, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {63,25,153,154,63,25,153,154,63,51,51,51,63,64 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0 },877252,877265, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {63,102,102,102,63,102,102,102,63,102,102,102,63,25,153,154 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },877268,877283, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {63 },
 new byte[]  { 0 },877324,877324, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {63 },
 new byte[]  { 0 },877328,877328, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {63,25,153,154,63,38,102,102,63,76,204,205,63,89,153,154,63,89,153,154,63,25,153,154 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },877332,877355, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {62,204,204,205,62,204,204,205,63 },
 new byte[]  { 0,0,0,0,0,0,0,0,0 },877396,877404, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {63,12,204,205,63,51,51,51,63,76,204,205,63,76,204,205,63,25,153,154 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },877408,877427, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {62,76,204,205,62,76,204,205,62,128 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0 },877468,877477, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {62,128 },
 new byte[]  { 0,0 },877480,877481, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {62,179,51,51,62,204,204,205,62,204,204,205,62,153,153,154 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },877484,877499, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {0,0 },
 new byte[]  { 67,22 },904760,904761, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {66,112 },
 new byte[]  { 67,22 },904764,904765, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {66,112 },
 new byte[]  { 67,22 },904768,904769, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {66,97,235,133,66,97,235,133,66,106,215,10,66,132,148,123,66,170 },
 new byte[]  { 67,22,0,0,67,22,0,0,67,22,0,0,67,22,0,0,67,22 },904772,904789, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {66,191,143,92,66,193,250,225,66,192,10,61,66,187,245,195,66,183,250,225,66,187,46,20,66,181,5,31,66,170 },
 new byte[]  { 67,22,0,0,67,22,0,0,67,22,0,0,67,22,0,0,67,22,0,0,67,22,0,0,67,22,0,0,67,22 },904792,904821, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {66,163,250,225,66,157,10,61,66,152,10,61,66,146,163,215,66,92,122,225,65,112 },
 new byte[]  { 67,22,0,0,67,22,0,0,67,22,0,0,67,22,0,0,67,22,0,0,67,22 },904824,904845, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {0,0 },
 new byte[]  { 67,22 },904848,904849, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {0,0 },
 new byte[]  { 67,22 },904852,904853, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {66,112 },
 new byte[]  { 67,22 },904856,904857, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {66,112 },
 new byte[]  { 67,22 },904860,904861, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {66,97,235,133,66,97,235,133,66,106,215,10,66,132,148,123,66,170 },
 new byte[]  { 67,22,0,0,67,22,0,0,67,22,0,0,67,22,0,0,67,22 },904864,904881, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {66,191,143,92,66,193,250,225,66,192,10,61,66,187,245,195,66,183,250,225,66,187,46,20,66,181,5,31,66,170 },
 new byte[]  { 67,22,0,0,67,22,0,0,67,22,0,0,67,22,0,0,67,22,0,0,67,22,0,0,67,22,0,0,67,22 },904884,904913, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {66,163,250,225,66,157,10,61,66,152,10,61,66,146,163,215,66,92,122,225,65,112 },
 new byte[]  { 67,22,0,0,67,22,0,0,67,22,0,0,67,22,0,0,67,22,0,0,67,22 },904916,904937, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {0,0 },
 new byte[]  { 67,22 },904940,904941, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {0,0 },
 new byte[]  { 67,22 },904944,904945, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {66,112 },
 new byte[]  { 67,22 },904948,904949, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {66,110,102,102,66,48 },
 new byte[]  { 67,22,0,0,67,22 },904952,904957, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {66,32 },
 new byte[]  { 67,22 },904960,904961, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {66,2 },
 new byte[]  { 67,22 },904964,904965, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {66,14 },
 new byte[]  { 67,22 },904968,904969, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {66,20 },
 new byte[]  { 67,22 },904972,904973, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {66,32 },
 new byte[]  { 67,22 },904976,904977, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {66,32 },
 new byte[]  { 67,22 },904980,904981, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {66,32 },
 new byte[]  { 67,22 },904984,904985, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {66,32 },
 new byte[]  { 67,22 },904988,904989, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {66,32 },
 new byte[]  { 67,22 },904992,904993, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {65,240 },
 new byte[]  { 67,22 },904996,904997, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {65,200 },
 new byte[]  { 67,22 },905000,905001, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {65,200 },
 new byte[]  { 67,22 },905004,905005, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {65,200 },
 new byte[]  { 67,22 },905008,905009, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {65,200 },
 new byte[]  { 67,22 },905012,905013, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {65,200 },
 new byte[]  { 67,22 },905016,905017, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {65,200 },
 new byte[]  { 67,22 },905020,905021, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {65,200 },
 new byte[]  { 67,22 },905024,905025, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {0,0 },
 new byte[]  { 67,22 },905028,905029, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {0,0 },
 new byte[]  { 67,22 },905032,905033, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {0,0 },
 new byte[]  { 67,22 },905036,905037, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {66,112 },
 new byte[]  { 67,22 },905040,905041, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {66,110,102,102,66,40 },
 new byte[]  { 67,22,0,0,67,22 },905044,905049, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {66,20 },
 new byte[]  { 67,22 },905052,905053, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {65,236 },
 new byte[]  { 67,22 },905056,905057, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {66,0 },
 new byte[]  { 67,22 },905060,905061, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {66,6 },
 new byte[]  { 67,22 },905064,905065, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {66,16 },
 new byte[]  { 67,22 },905068,905069, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {66,0 },
 new byte[]  { 67,22 },905072,905073, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {65,224 },
 new byte[]  { 67,22 },905076,905077, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {65,208 },
 new byte[]  { 67,22 },905080,905081, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {65,200 },
 new byte[]  { 67,22 },905084,905085, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {65,200 },
 new byte[]  { 67,22 },905088,905089, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {65,160 },
 new byte[]  { 67,22 },905092,905093, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {65,160 },
 new byte[]  { 67,22 },905096,905097, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {65,160 },
 new byte[]  { 67,22 },905100,905101, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {65,160 },
 new byte[]  { 67,22 },905104,905105, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {65,160 },
 new byte[]  { 67,22 },905108,905109, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {65,160 },
 new byte[]  { 67,22 },905112,905113, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {65,160 },
 new byte[]  { 67,22 },905116,905117, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {0,0 },
 new byte[]  { 67,22 },905120,905121, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {0,0 },
 new byte[]  { 67,22 },905124,905125, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {0,0 },
 new byte[]  { 67,22 },905128,905129, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {66,112 },
 new byte[]  { 67,22 },905132,905133, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {66,110,102,102,66,32 },
 new byte[]  { 67,22,0,0,67,22 },905136,905141, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {66,12 },
 new byte[]  { 67,22 },905144,905145, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {65,196 },
 new byte[]  { 67,22 },905148,905149, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {65,216 },
 new byte[]  { 67,22 },905152,905153, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {65,224 },
 new byte[]  { 67,22 },905156,905157, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {65,240 },
 new byte[]  { 67,22 },905160,905161, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {65,200 },
 new byte[]  { 67,22 },905164,905165, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {65,160 },
 new byte[]  { 67,22 },905168,905169, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {65,160 },
 new byte[]  { 67,22 },905172,905173, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {0,0 },
 new byte[]  { 67,22 },905176,905177, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {0,0 },
 new byte[]  { 67,22 },905180,905181, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {0,0 },
 new byte[]  { 67,22 },905184,905185, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {0,0 },
 new byte[]  { 67,22 },905188,905189, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {0,0 },
 new byte[]  { 67,22 },905192,905193, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {0,0 },
 new byte[]  { 67,22 },905196,905197, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {0,0 },
 new byte[]  { 67,22 },905200,905201, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {0,0 },
 new byte[]  { 67,22 },905204,905205, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {0,0 },
 new byte[]  { 67,22 },905208,905209, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {0,0 },
 new byte[]  { 67,22 },905212,905213, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {0,0 },
 new byte[]  { 67,22 },905216,905217, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64,12,66,236,64,12,66,236,63,202,54,198,64,69,155,8,64,54,136,193,64,71,29,233,64,91,224,64,64,92,189,248,64,113,227,49,64,131,132,53,64,105,154,255,64,59,131,221,64,95,171,50,64,171,1,119,64,182,78,199 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },914492,914551, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64,124,20,68,64,124,20,68,64,35,147,157,64,60,86,124,64,129,117,137,64,164,191,211,63,135,174,20,64,154,57,141,64,165,152,129,64,165,152,129,64,179,36,245,64,166,91,169,64,202,149,148,64,233,5,82,64,225,222,10 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },914556,914615, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64,227,13,96,64,227,13,96,64,131,121,163,64,134,151,131,64,114,121,237,64,87,196,212,64,208,81,236,64,132,114,145,64,103,121,11,64,103,121,11,64,217,157,115,64,226,92,187,64,214,42,109,65,16,129,59,65,14,35,19 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },914620,914679, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {65,90,225,207,65,90,225,207,64,214,4,129,64,253,32,242,64,221,75,53,64,189,117,119,64,67,209,191,65,32,157,156,65,13,116,103,65,13,116,103,64,245,198,211,64,223,228,219,64,255,30,239,65,36,227,108,65,89,91,40 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },914684,914743, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {65,254,206,60,65,254,206,60,65,134,99,209,65,119,45,217,65,63,89,14,65,7,132,67,64,191,81,4,65,147,48,150,65,133,131,227,65,127,154,192,64,250,203,184,64,223,212,215,64,252,89,124,65,49,227,224,65,167,106,59 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },914748,914807, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {65,214,114,134,65,214,114,134,66,22,5,178,65,203,66,124,65,176,36,203,65,149,7,26,64,220,240,162,65,168,65,80,65,172,151,40,65,172,151,40,64,219,189,194,64,209,40,31,64,246,133,47,65,55,49,171,65,185,83,198 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },914812,914871, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {65,165,1,145,65,165,1,145,66,65,71,234,65,230,218,150,65,255,42,122,66,1,102,151,65,14,44,183,65,35,242,129,65,53,111,160,65,53,111,160,64,186,164,227,64,207,53,74,65 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },914876,914924, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {193,16,65,39,185,245,65,152,25,218 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0 },914926,914935, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {66,16,252,172,66,16,252,172,65,245,137,6,64,239,168,128,65,169,245,16,66,12 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },914940,914961, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {65,141,56,38,65,26,255,91,65,46,25,165,65,46,25,165,64,229,70,60,64,184,30,222,65,24,144,9,65,51,111,171,65,141,117,131 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },914964,914999, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {66,196,88,202,66,196,88,202,65,212,250,12,65,82,120,130,65,192,158,33,66,9,235,202,65,199,150,38,65,108,87,191,65,78,165,53,65,78,165,53,64,239,192,185,64,178,6,189,65,29,250,66,65,33,112,126,65,100,124,226 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },915004,915063, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {67,73 },
 new byte[]  { 0,0 },915068,915069, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {67,73 },
 new byte[]  { 0,0 },915072,915073, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {66,133,243,205,65,190,250,197,65,137,51,169,65,38,217,26,65,213,11,239,65,198,238,220,65,125,86,213,65,125,86,213,65,5,161,239,64,187,184,26,65,24,106,127,65,6,144,122,65,51,143,76 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },915076,915127, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {67,73 },
 new byte[]  { 0,0 },915132,915133, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {67,73 },
 new byte[]  { 0,0 },915136,915137, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {66,241,30,131,65,222,108,88,65,155,93,169,65,31,161,139,65,138,134,196,65,194,57,254,65,134,4,89,65,134,4,89,65,22,4,13,64,201,217,162,64,229,218,38,64,237,52,62,65,41,19,80 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },915140,915191, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {67,73 },
 new byte[]  { 0,0 },915196,915197, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {67,73 },
 new byte[]  { 0,0 },915200,915201, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {67,46,36,156,65,253,221,235,65,175,129,76,65,25,116,6,64,160,49,77,65,83,58,145,65,123,215,162,65,123,215,162,65,15,244,33,64,212,173,91,64,223,181,203,64,227,229,176,65,66,208,58 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },915204,915255, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {67,73 },
 new byte[]  { 0,0 },915260,915261, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {67,73 },
 new byte[]  { 0,0 },915264,915265, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {67,46,36,156,66,14,167,191,65,197,180,246,65,33,96,216,64,166,159,92,65,4,123,43,65,79,157,241,65,79,157,241,65,40,10,27,64,209,154,163,65,11,137,65,65,14,31,70,65,95,249,3 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },915268,915319, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {67,73 },
 new byte[]  { 0,0 },915324,915325, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {67,73 },
 new byte[]  { 0,0 },915328,915329, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {67,46,36,156,66,30,96,136,65,225,122,78,65,53,48,168,64,204,125,109,64,252,35,115,65,2,189,160,65,2,189,160,65,87,170,33,64,235,149,61,65,8,249,184,65,42,120,94,65,136,92,104 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },915332,915383, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {67,73 },
 new byte[]  { 0,0 },915388,915389, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {67,73 },
 new byte[]  { 0,0 },915392,915393, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {67,46,36,156,66,61,210,26,66,11,249,112,65,180,65,139,65,44,60,240,64,223,26,176,65,27,200,1,65,27,200,1,65,145,197,217,65,65,221,42,65,72,109,79,65,193,177,185,66,20,102,218 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },915396,915447, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64,131,215,10,64,131,215,10,64,162,61,113,64,168,163,215,64,175,10,61,64,138,102,102,64,75,133,31,64,19,105,208,63,182,157,3,63,12,204,205,62,165,139,242,62,237,58,7,63,120,81,236,64,167,51,51,65,23,174,20 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },919708,919767, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64,131,215,10,64,131,215,10,64,162,61,113,64,168,163,215,64,175,10,61,64,138,102,102,64,75,133,31,64,19,105,208,63,182,157,3,63,12,204,205,62,165,139,242,62,237,58,7,63,120,81,236,64,167,51,51,65,23,174,20 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },919772,919831, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64,131,204,84,64,131,204,84,64,162,37,130,64,168,151,224,64,175,10,61,64,138,102,102,64,75,133,31,64,19,105,208,63,182,157,3,63,12,204,205,62,166,124,227,62,237,235,181,63,119,243,7,64,167,45,69,65,23,174,20 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },919836,919895, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {65,167,28,210,65,167,28,210,65,21,146,226,64,237,8,248,64,174,236,44,64,138,87,94,64,75,133,31,64,19,117,50,63,182,202,140,63,13,85,103,63,251,223,36,64,170,108,99,65,42,4,61,65,32,217,41,65,23,174,20 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },919900,919959, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {66,10,107,15,66,10,107,15,65,124,120,89,65,131,38,100,65,136,16,154,65,33,129,52,64,75,132,203,64,137,212,12,64,173,229,178,64,209,247,89,64,230,140,146,65,29,238,169,65,104,244,203,65,64,81,112,65,23,174,20 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },919964,920023, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {65,244,235,60,65,244,235,60,66,8,78,168,65,223,35,98,65,173,169,117,65,109,230,25,65 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },920028,920052, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {121,74,65,32,142,27,65,64,162,237,65,96,183,191,65,134,106,3,65,130,118,104,65,73,2,25,65,48,95,110,65,23,188,195 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },920054,920087, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64,7,104,250,64,7,104,250,66,13,118,254,65,228,24,70,65,173,66,142,65,128,211,229,65,40,202,121,65,55,37,177,65,69,128,232,65,83,220,32,65,188,106,142,65,202,39,87,65,147,36,106,65,143,228,98,65,140,164,90 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },920092,920151, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {66,47,73,231,66,47,73,231,66,1,94,70,65,219,92,148,65,179,252,157,65,138,228,137,65,67,152,234,65,103,211,242,65,134,7,124,65,152,37 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },920156,920194, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {65,243,76,133,66,6,199,65,65,230,234,248,65,197,98,42,65,163,217,93 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },920196,920215, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {66,47,71,174,66,47,71,174,66,26,76,165,66 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0 },920220,920232, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {219,230,65,206,214,80,65,157,91,61,65,87,192,85,65,164,18,158,65,220,69,18,66,10,59,195,66,23,101,170,66,32,135,39,66,37,160,57,66,23,247,79,66,10,78,100 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },920234,920279, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {66,47,71,174,66,173,249,69,66,102,154,219,65,226,134,87,65,195,12,189,65,163,147,35,65,203,45,91,65,242,199,147,66,13,48,229,66,11,190,138,66,25,104,21,66,54,45,136,66,25,163,186,65,250,51,218 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },920288,920343, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {66,47,71,174,67,21,239,175,66,173,182,205,65,190,56,237,65,202,255,224,65,215,198,210,65,236,53,244,66 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },920352,920380, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {82,139,66,10,138,27,65,244,244,19,65,234,144,93,65,245,233,20,65,206,132,88,65,167,31,157 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },920382,920407, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {66,47,71,174,67,21,240,164,66,170,67,53,65,162,148,141,65,204,74,114,65,246 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },920416,920437, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {87,66 },
 new byte[]  { 0,0 },920439,920440, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {45,249,66,5,91,199,66,10,137,149,65,247,250,150,65,206,242,185,65,153,251,144,65,81,3,141,64,220,31,243 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },920442,920471, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {66,47,71,174,67,21,240,164,66,180,33,4,65,241,130,255,65,203,31,190,65,164,188,125,65,175,37,41,65,185,141,213,65,195,246,129,65,209,142,9,65,162,73,163,64,216,165,68,64,218,103,29,64,220,40,246 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },920480,920535, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {66,47,71,174,67,21,240,164,66,180,33,72,65,241,133,31,65,169,109,221,65,66,173,55,65,99,183,178,65,130,97,22,65,146,230,84,65,93,247,148,65,32,36 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },920544,920586, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64,216,163,215,64,218,102,102,64,220,40,246 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0 },920588,920599, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {66,47,71,174,67,21,240,164,66,180,33,72,65,241,133,31,65,169,112,164,65,66,184,82,65,106,244,88,65,137,152,47,65,157,182,50,65,101,49,200,65,32,40,246,64,216,163,215,64,218,102,102,64,220,40,246 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },920608,920663, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64,131,215,10,64,131,215,10,64,162,61,113,64,168,163,215,64,175,10,61,64,138,102,102,64,75,133,31,64,19,105,208,63,182,157,3,63,12,204,205,62,165,139,242,62,237,58,7,63,120,81,236,64,167,51,51,65,23,174,20 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },920860,920919, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64,131,215,10,64,131,215,10,64,162,61,113,64,168,163,215,64,175,10,61,64,138,102,102,64,75,133,31,64,19,105,208,63,182,157,3,63,12,204,205,62,165,139,242,62,237,58,7,63,120,81,236,64,167,51,51,65,23,174,20 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },920924,920983, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64,131,204,84,64,131,204,84,64,162,37,130,64,168,151,224,64,175,10,61,64,138,102,102,64,75,133,31,64,19,105,208,63,182,157,3,63,12,204,205,62,166,124,227,62,237,235,181,63,119,243,7,64,167,45,69,65,23,174,20 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },920988,921047, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {65,167,28,210,65,167,28,210,65,21,146,226,64,237,8,248,64,174,236,44,64,138,87,94,64,75,133,31,64,19,117,50,63,182,202,140,63,13,85,103,63,251,223,36,64,170,108,99,65,42,4,61,65,32,217,41,65,23,174,20 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },921052,921111, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {66,10,107,15,66,10,107,15,65,124,120,89,65,131,38,100,65,136,16,154,65,33,129,52,64,75,132,203,64,137,212,12,64,173,229,178,64,209,247,89,64,230,140,146,65,29,238,169,65,104,244,203,65,64,81,112,65,23,174,20 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },921116,921175, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {65,244,235,60,65,244,235,60,66,8,78,168,65,223,35,98,65,173,169,117,65,109,230,25,65 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },921180,921204, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {121,74,65,32,142,27,65,64,162,237,65,96,183,191,65,134,106,3,65,130,118,104,65,73,2,25,65,48,95,110,65,23,188,195 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },921206,921239, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64,7,104,250,64,7,104,250,66,13,118,254,65,228,24,70,65,173,66,142,65,128,211,229,65,40,202,121,65,55,37,177,65,69,128,232,65,83,220,32,65,188,106,142,65,202,39,87,65,147,36,106,65,143,228,98,65,140,164,90 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },921244,921303, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {66,47,73,231,66,47,73,231,66,1,94,70,65,219,92,148,65,179,252,157,65,138,228,137,65,67,152,234,65,103,211,242,65,134,7,124,65,152,37 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },921308,921346, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {65,243,76,133,66,6,199,65,65,230,234,248,65,197,98,42,65,163,217,93 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },921348,921367, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {66,47,71,174,66,47,71,174,66,26,76,165,66 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0 },921372,921384, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {219,230,65,206,214,80,65,157,91,61,65,87,192,85,65,164,18,158,65,220,69,18,66,10,59,195,66,23,101,170,66,32,135,39,66,37,160,57,66,23,247,79,66,10,78,100 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },921386,921431, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {66,47,71,174,66,173,249,69,66,102,154,219,65,226,134,87,65,195,12,189,65,163,147,35,65,203,45,91,65,242,199,147,66,13,48,229,66,11,190,138,66,25,104,21,66,54,45,136,66,25,163,186,65,250,51,218 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },921440,921495, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {66,47,71,174,67,21,239,175,66,173,182,205,65,190,56,237,65,202,255,224,65,215,198,210,65,236,53,244,66 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },921504,921532, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {82,139,66,10,138,27,65,244,244,19,65,234,144,93,65,245,233,20,65,206,132,88,65,167,31,157 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },921534,921559, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {66,47,71,174,67,21,240,164,66,170,67,53,65,162,148,141,65,204,74,114,65,246 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },921568,921589, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {87,66 },
 new byte[]  { 0,0 },921591,921592, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {45,249,66,5,91,199,66,10,137,149,65,247,250,150,65,206,242,185,65,153,251,144,65,81,3,141,64,220,31,243 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },921594,921623, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {66,47,71,174,67,21,240,164,66,180,33,4,65,241,130,255,65,203,31,190,65,164,188,125,65,175,37,41,65,185,141,213,65,195,246,129,65,209,142,9,65,162,73,163,64,216,165,68,64,218,103,29,64,220,40,246 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },921632,921687, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {66,47,71,174,67,21,240,164,66,180,33,72,65,241,133,31,65,169,109,221,65,66,173,55,65,99,183,178,65,130,97,22,65,146,230,84,65,93,247,148,65,32,36 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },921696,921738, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64,216,163,215,64,218,102,102,64,220,40,246 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0 },921740,921751, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {66,47,71,174,67,21,240,164,66,180,33,72,65,241,133,31,65,169,112,164,65,66,184,82,65,106,244,88,65,137,152,47,65,157,182,50,65,101,49,200,65,32,40,246,64,216,163,215,64,218,102,102,64,220,40,246 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },921760,921815, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64,12,66,236,64,12,66,236,63,202,54,198,64,69,155,8,64,191,34,180,65,13,187,242,64,155,215,10,65,34,209,5,64,215,116,125,64,215,116,125,64,105,154,255,64,59,131,221,64,95,171,50,64,171,1,119,64,182,78,199 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },922012,922071, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64,124,20,68,64,124,20,68,64,35,147,157,64,60,86,124,64,129,117,137,64,164,191,211,63,135,174,20,64,229,10,78,64,165,152,129,64,165,152,129,64,195,57,187,64,166,91,169,64,202,149,148,64,233,5,82,64,225,222,10 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },922076,922135, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64,227,13,96,64,227,13,96,64,131,121,163,64,134,151,131,64,114,121,237,64,87,196,212,64,208,81,236,64,132,114,145,64,103,121,11,64,103,121,11,65,6,107,95,65,7,101,125,65,13,231,59,65,16,129,59,65,14,35,19 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },922140,922199, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {65,90,225,207,65,90,225,207,64,214,4,129,64,253,32,242,64,221,75,53,64,189,117,119,64,67,209,191,65,32,157,156,65,13,116,103,65,13,116,103,65,30,155,128,65,22,45,86,65,58,97,131,65,69,165,240,65,89,91,40 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },922204,922263, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {65,254,206,60,65,254,206,60,65,134,99,209,65,119,45,217,65,63,89,14,65,7,132,67,64,191,81,4,65,147,48,150,65,133,131,227,65,133,131,227,65,188,130,233,65,7,163,207,65,63,19,174,65,110,218,151,65,167,106,59 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },922268,922327, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {65,214,114,134,65,214,114,134,66,22,5,178,65,203,66,124,65,176,36,203,65,149,7,26,64,220,240,162,65,168,65,80,65,172,151,40,65,172,151,40,65,206,250,17,64,245,85,12,65,72,184,230,65,139,127,249,65,185,83,198 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },922332,922391, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {65,165,1,145,65,165,1,145,66,65,71,234,65,251,135,197,65,255,42,122,66,1,102,151,65,14,44,183,65,35,242,129,65,53,111,160,65,53,111,160,65,225,113,58,64,213,184,165,65,64,26,178,65,122,65,118,65,152,25,218 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },922396,922455, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {66,16,252,172,66,16,252,172,65,245,137,6,64,239,168,128,65,169,245,16,66,12 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },922460,922481, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {65,141,56,38,65,26,255,91,65,46,25,165,65,46,25,165,65,227,233,37,64,206,51,69,65,63,183,127,65,80,162,22,65,141,117,131 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },922484,922519, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {66,196,88,202,66,196,88,202,65,212,250,12,65,82,120,130,65,192,158,33,66,12 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },922524,922545, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {65,199,150,38,65,108,87,191,65,78,165,53,65,78,165,53,66,22,132,82,64,207,32,199,65,52,51,157,65,52,194,123,65,100,124,226 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },922548,922583, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {67,73 },
 new byte[]  { 0,0 },922588,922589, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {67,73 },
 new byte[]  { 0,0 },922592,922593, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {66,133,243,205,65,190,250,197,65,137,51,169,65,38,217,26,65,213,11,239,65,198,238,220,65,125,86,213,65,125,86,213,66,49,21,229,64,220,255,227,65,60,122,194,65,35,27,221,65,51,143,76 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },922596,922647, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {67,73 },
 new byte[]  { 0,0 },922652,922653, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {67,73 },
 new byte[]  { 0,0 },922656,922657, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {66,241,30,131,65,222,108,88,65,155,93,169,65,48,157,243,65,138,134,196,65,194,57,254,65,134,4,89,65,134,4,89,66,52,247,248,64,211,214,240,65,21,83,190,65,3,37,230,65,41,19,80 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },922660,922711, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {67,73 },
 new byte[]  { 0,0 },922716,922717, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {67,73 },
 new byte[]  { 0,0 },922720,922721, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {67,46,36,156,65,253,221,235,65,175,129,76,65,66,73,92,64,160,49,77,65,219,112,164,65,123,215,162,65,123,215,162,66,31,80,65,64,218,9,35,65,20,134,114,64,240,189,20,65,66,208,58 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },922724,922775, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {67,73 },
 new byte[]  { 0,0 },922780,922781, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {67,73 },
 new byte[]  { 0,0 },922784,922785, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {67,46,36,156,66,14,167,191,65,197,180,246,65,92,52,222,64,166,159,92,65,62,102,102,65,79,157,241,65,79,157,241,65,226,42,207,64,209,154,163,65,11,137,65,65,14,31,70,65,95,249,3 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },922788,922839, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {67,73 },
 new byte[]  { 0,0 },922844,922845, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {67,73 },
 new byte[]  { 0,0 },922848,922849, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {67,46,36,156,66,30,96,136,65,225,122,78,65,134,51,139,64,204,125,109,65,103,133,31,65,2,189,160,65,2,189,160,65,128,217,120,64,235,149,61,65,8,249,184,65,42,120,94,65,136,92,104 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },922852,922903, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {67,73 },
 new byte[]  { 0,0 },922908,922909, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {67,73 },
 new byte[]  { 0,0 },922912,922913, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {67,46,36,156,66,61,210,26,66,11,249,112,65,180,65,139,65,44,60,240,64,223,26,176,65,27,200,1,65,27,200,1,65,145,197,217,65,65,221,42,65,72,109,79,65,193,177,185,66,20,102,218 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },922916,922967, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {2,2,2,2,2,2,2 },
 new byte[]  { 0,0,0,0,0,0,0 },940649,940655, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {2,2 },
 new byte[]  { 0,0 },940671,940672, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {2,2,2 },
 new byte[]  { 0,0,0 },940676,940678, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {2 },
 new byte[]  { 0 },940715,940715, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {2,2 },
 new byte[]  { 0,0 },940728,940729, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {2 },
 new byte[]  { 0 },940735,940735, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {2,2,2,2,2,2,2,2,2,2 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0 },940739,940748, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {2,2,2,2,2,2,2 },
 new byte[]  { 0,0,0,0,0,0,0 },940816,940822, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {2,2 },
 new byte[]  { 0,0 },940838,940839, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {2,2,2 },
 new byte[]  { 0,0,0 },940843,940845, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {2 },
 new byte[]  { 0 },940882,940882, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {2,2 },
 new byte[]  { 0,0 },940895,940896, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {2 },
 new byte[]  { 0 },940902,940902, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {2,2,2,2,2,2,2,2,2,2 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0 },940906,940915, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1 },
 new byte[]  { 0 },940989,940989, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1 },
 new byte[]  { 0 },941049,941049, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3,3,3,3,3,3,3,3 },
 new byte[]  { 1,1,1,1,1,1,1,1 },941673,941680, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3 },
 new byte[]  { 1 },941717,941717, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3,3,3,3,3,3,3,3 },
 new byte[]  { 1,1,1,1,1,1,1,1 },941840,941847, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3 },
 new byte[]  { 1 },941884,941884, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,1,1,1,1,1 },
 new byte[]  { 0,0,0,0,0,0 },942152,942157, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,1 },
 new byte[]  { 0,0 },942174,942175, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,1 },
 new byte[]  { 0,0 },942179,942180, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,1 },
 new byte[]  { 0,0 },942231,942232, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,1,1,1,1,1,1,1 },
 new byte[]  { 0,0,0,0,0,0,0,0 },942244,942251, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,1,1,1,1,1 },
 new byte[]  { 0,0,0,0,0,0 },942319,942324, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,1 },
 new byte[]  { 0,0 },942341,942342, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,1 },
 new byte[]  { 0,0 },942346,942347, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,1 },
 new byte[]  { 0,0 },942398,942399, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,1,1,1,1,1,1,1 },
 new byte[]  { 0,0,0,0,0,0,0,0 },942411,942418, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3,72,3,72,3,72,3,72 },
 new byte[]  { 0,0,0,0,0,0,0,0 },942540,942547, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {210 },
 new byte[]  { 0 },942549,942549, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {210 },
 new byte[]  { 0 },942551,942551, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {78 },
 new byte[]  { 0 },942553,942553, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {2,13,2,13,255,255,255,255 },
 new byte[]  { 0,0,0,0,0,0,0,0 },942610,942617, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3,72,3,72 },
 new byte[]  { 0,0,0,0 },942698,942701, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {255,255 },
 new byte[]  { 0,0 },942712,942713, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {210 },
 new byte[]  { 0 },942721,942721, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {210,16,98,16,98,16,98,16,98,8,49,3,71,2,13,4,25 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },942723,942739, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3,72,3,72,3,72,3,72 },
 new byte[]  { 0,0,0,0,0,0,0,0 },943208,943215, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {210 },
 new byte[]  { 0 },943217,943217, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {210 },
 new byte[]  { 0 },943219,943219, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {78 },
 new byte[]  { 0 },943221,943221, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {2,13,2,13,255,255,255,255 },
 new byte[]  { 0,0,0,0,0,0,0,0 },943278,943285, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {255,255 },
 new byte[]  { 0,0 },943358,943359, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3,72,3,72 },
 new byte[]  { 0,0,0,0 },943366,943369, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {255,255 },
 new byte[]  { 0,0 },943380,943381, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {210 },
 new byte[]  { 0 },943389,943389, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {210,16,98,16,98,16,98,16,98,8,49,3,71,2,13,4,25 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },943391,943407, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {4 },
 new byte[]  { 0 },943715,943715, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3 },
 new byte[]  { 0 },943876,943876, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3 },
 new byte[]  { 0 },943878,943878, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3 },
 new byte[]  { 0 },943880,943880, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3 },
 new byte[]  { 0 },943882,943882, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1 },
 new byte[]  { 0 },943884,943884, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1 },
 new byte[]  { 0 },943886,943886, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1 },
 new byte[]  { 0 },943888,943888, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,1,1,1,1,1,1,1 },
 new byte[]  { 0,0,0,0,0,0,0,0 },943946,943953, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1 },
 new byte[]  { 0 },944048,944048, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1 },
 new byte[]  { 0 },944050,944050, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {10 },
 new byte[]  { 0 },944060,944060, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {10 },
 new byte[]  { 0 },944062,944062, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {10 },
 new byte[]  { 0 },944064,944064, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {10 },
 new byte[]  { 0 },944066,944066, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {10 },
 new byte[]  { 0 },944068,944068, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {10 },
 new byte[]  { 0 },944070,944070, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {10 },
 new byte[]  { 0 },944072,944072, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {10 },
 new byte[]  { 0 },944074,944074, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {4,2,4,1,4,4,4,4,4,6,4,5,4,9,4,3 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },944606,944621, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {4,4 },
 new byte[]  { 0,0 },944694,944695, "Found egr map...Delete map");
      base.egrOffSolution();
    }
    public override void dpfOffSolution()  {
	ToolBox.ReplaceInFileWithStartStop(new byte[]  {192 },
 new byte[]  { 0 },590187,590187, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1 },
 new byte[]  { 0 },590380,590380, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1 },
 new byte[]  { 0 },590426,590426, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1 },
 new byte[]  { 0 },590437,590437, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1 },
 new byte[]  { 0 },590446,590446, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1 },
 new byte[]  { 0 },590554,590554, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1 },
 new byte[]  { 0 },590570,590570, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {10 },
 new byte[]  { 3 },590602,590602, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,1 },
 new byte[]  { 0,0 },590628,590629, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1 },
 new byte[]  { 0 },590631,590631, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1 },
 new byte[]  { 0 },590671,590671, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64 },
 new byte[]  { 0 },602156,602156, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64 },
 new byte[]  { 0 },602158,602158, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64 },
 new byte[]  { 0 },602160,602160, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64 },
 new byte[]  { 0 },602162,602162, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64 },
 new byte[]  { 0 },602164,602164, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64 },
 new byte[]  { 0 },602166,602166, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64 },
 new byte[]  { 0 },602168,602168, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64 },
 new byte[]  { 0 },602170,602170, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64 },
 new byte[]  { 0 },602204,602204, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64 },
 new byte[]  { 0 },602206,602206, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64 },
 new byte[]  { 0 },602208,602208, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64 },
 new byte[]  { 0 },602210,602210, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64 },
 new byte[]  { 0 },602212,602212, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64 },
 new byte[]  { 0 },602214,602214, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64 },
 new byte[]  { 0 },602216,602216, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64 },
 new byte[]  { 0 },602218,602218, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {38 },
 new byte[]  { 0 },603205,603205, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {38 },
 new byte[]  { 0 },603207,603207, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {38 },
 new byte[]  { 0 },603209,603209, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {38 },
 new byte[]  { 0 },603211,603211, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {37 },
 new byte[]  { 0 },603213,603213, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {35 },
 new byte[]  { 0 },603215,603215, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {32 },
 new byte[]  { 0 },603217,603217, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {30 },
 new byte[]  { 0 },603219,603219, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {29 },
 new byte[]  { 0 },603221,603221, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {25 },
 new byte[]  { 0 },603223,603223, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {25 },
 new byte[]  { 0 },603225,603225, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {25 },
 new byte[]  { 0 },603227,603227, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {25 },
 new byte[]  { 0 },603229,603229, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {25 },
 new byte[]  { 0 },603231,603231, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {25 },
 new byte[]  { 0 },603233,603233, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {25 },
 new byte[]  { 0 },603235,603235, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {50 },
 new byte[]  { 0 },603301,603301, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {50 },
 new byte[]  { 0 },603303,603303, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {50 },
 new byte[]  { 0 },603305,603305, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {50 },
 new byte[]  { 0 },603307,603307, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {50 },
 new byte[]  { 0 },603309,603309, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {50 },
 new byte[]  { 0 },603311,603311, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {44 },
 new byte[]  { 0 },603313,603313, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {38 },
 new byte[]  { 0 },603315,603315, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {38 },
 new byte[]  { 0 },603317,603317, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {38 },
 new byte[]  { 0 },603319,603319, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {38 },
 new byte[]  { 0 },603321,603321, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {38 },
 new byte[]  { 0 },603323,603323, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {38 },
 new byte[]  { 0 },603325,603325, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {38 },
 new byte[]  { 0 },603327,603327, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {38 },
 new byte[]  { 0 },603329,603329, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {38 },
 new byte[]  { 0 },603331,603331, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {60 },
 new byte[]  { 5 },606449,606449, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {60 },
 new byte[]  { 5 },606451,606451, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {60 },
 new byte[]  { 5 },606453,606453, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {60 },
 new byte[]  { 5 },606455,606455, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {60 },
 new byte[]  { 5 },606457,606457, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {60 },
 new byte[]  { 5 },606459,606459, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {60 },
 new byte[]  { 5 },606461,606461, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {60 },
 new byte[]  { 5 },606463,606463, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {112,109,108,106,111,113,120,122,124,115,105,103 },
 new byte[]  { 100,100,100,100,100,100,100,100,100,100,100,100 },626523,626534, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {125,118,116,111,121,125,140,144,149,130,111,105 },
 new byte[]  { 100,100,100,100,100,100,100,100,100,100,100,100 },626542,626553, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {112,123,114,111,128,130,137,138,138,131,123,117,112,106 },
 new byte[]  { 100,100,100,100,100,100,100,100,100,100,100,100,100,100 },626561,626574, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {121,142,109,117,109,110,135,134,134,131,128,131,135,130,126,115,105,104,103,108,113,106,112,109,108,121,117,117,116,114,117,120,119,118,112,106,104,102 },
 new byte[]  { 100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100 },626578,626615, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {99,103,107,109,106,107 },
 new byte[]  { 100,100,100,100,100,100 },626617,626622, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {102,104,107,111,109,107,104 },
 new byte[]  { 100,100,100,100,100,100,100 },626627,626633, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {98,95,101,104,110,107,106 },
 new byte[]  { 100,100,100,100,100,100,100 },626635,626641, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {101,102,103,103,107,110,109,108,104,101,98,95 },
 new byte[]  { 100,100,100,100,100,100,100,100,100,100,100,100 },626644,626655, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {106,111,109,105,101 },
 new byte[]  { 100,100,100,100,100 },626657,626661, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {102,104,104,103,106,109,109,108,105,101 },
 new byte[]  { 100,100,100,100,100,100,100,100,100,100 },626663,626672, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {99 },
 new byte[]  { 100 },626674,626674, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {107,108,110,105,103,102,103,104,103,102,104,107,107,106,103,99 },
 new byte[]  { 100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100 },626676,626691, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {101 },
 new byte[]  { 100 },626693,626693, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {108,104,110,105,105,105,104,104,102,101,103,105,105,105,101,97,99,102 },
 new byte[]  { 100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100 },626695,626712, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {102,105,104,103,105,104,104,102,101,102,103,103,104,101,98,99 },
 new byte[]  { 100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100 },626715,626730, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {104 },
 new byte[]  { 100 },626736,626736, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {105,104,104,102,101,101,101,102,103,102 },
 new byte[]  { 100,100,100,100,100,100,100,100,100,100 },626738,626747, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {102,101,104,104,103,102,101,101,102,103,104,102 },
 new byte[]  { 100,100,100,100,100,100,100,100,100,100,100,100 },626755,626766, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {101,104,103,102,102,101,102,103,104,104,102 },
 new byte[]  { 100,100,100,100,100,100,100,100,100,100,100 },626775,626785, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {99,101 },
 new byte[]  { 100,100 },626794,626795, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {102,103,102,102,101 },
 new byte[]  { 100,100,100,100,100 },626800,626804, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {100 },
 new byte[]  { 0 },648847,648847, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {100 },
 new byte[]  { 0 },648849,648849, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {100 },
 new byte[]  { 0 },648851,648851, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {100 },
 new byte[]  { 0 },648853,648853, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {100 },
 new byte[]  { 0 },648855,648855, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {100 },
 new byte[]  { 0 },648857,648857, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {100 },
 new byte[]  { 0 },648859,648859, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {100 },
 new byte[]  { 0 },648861,648861, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {100 },
 new byte[]  { 0 },648863,648863, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {100 },
 new byte[]  { 0 },648865,648865, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {100 },
 new byte[]  { 0 },648867,648867, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {100 },
 new byte[]  { 0 },648869,648869, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {100 },
 new byte[]  { 0 },648871,648871, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {100 },
 new byte[]  { 0 },648873,648873, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {100 },
 new byte[]  { 0 },648875,648875, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {82,128,82,128,82,128,82,128,82,128,82,128,82,128,82,128,82,128,78,176,80,160,80,160,82,160,74,80,66,224,74,176,72,96,68,224,53,176,42,48,56,96,43,240,35,96,10,16,0 },
 new byte[]  { 125,0,125,0,125,0,125,0,125,0,125,0,125,0,125,0,125,0,125,0,125,0,125,0,125,0,125,0,125,0,125,0,125,0,125,0,125,0,125,0,125,0,125,0,125,0,125,0,125 },674672,674720, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {9,179,9,102,9,51,9,92,9,13,8,128,8,51,7,218,7,154,7,85,9,179,9,102,9,51,9,92,9,13,8,128,8,51,7,218,7,154,7,85,9,179,9,102,9,51,9,92,9,13,8,128,8,51,7,64,6,195,6,72,9,154,9,102,9,51,8,192,8,36,7,20,6,102,5,187,5,28,4,118,8,64,7,241,7,154,6,166,5,172,4,61,3,110,2,133,1,200,0,223 },
 new byte[]  { 15,0,15,0,15,0,15,0,15,0,15,0,15,0,15,0,15,0,15,0,15,0,15,0,15,0,15,0,15,0,15,0,15,0,15,0,15,0,15,0,15,0,15,0,15,0,15,0,15,0,15,0,15,0,15,0,15,0,15,0,15,0,15,0,15,0,15,0,15,0,15,0,15,0,15,0,15,0,15,0,15,0,15,0,15,0,15,0,15,0,15,0,15,0,15,0,15,0,15,0 },686320,686419, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {63,102,102,102,63,102,102,102,63,102,102,102,63,102,102,102,63,102,102,102,63,102,102,102,63,102,102,102,63,102,102,102 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },876820,876851, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {63,102,102,102,63,102,102,102,63,102,102,102,63,102,102,102,63,102,102,102,63,102,102,102,63,102,102,102,63,102,102,102 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },876892,876923, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {63,102,102,102,63,102,102,102,63,102,102,102,63,102,102,102,63,102,102,102,63,102,102,102,63,102,102,102,63,102,102,102 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },876964,876995, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {63,102,102,102,63,102,102,102,63,102,102,102,63,102,102,102,63,102,102,102,63,102,102,102,63,102,102,102,63,102,102,102 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },877036,877067, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {63,102,102,102,63,102,102,102,63,102,102,102,63,102,102,102,63,102,102,102,63,102,102,102,63,102,102,102,63,102,102,102 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },877108,877139, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {63,64 },
 new byte[]  { 0,0 },877180,877181, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {63,64 },
 new byte[]  { 0,0 },877184,877185, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {63,76,204,205,63,83,51,51,63,102,102,102,63,102,102,102,63,51,51,51,63,64 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },877188,877209, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {63,25,153,154,63,25,153,154,63,51,51,51,63,64 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0 },877252,877265, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {63,102,102,102,63,102,102,102,63,102,102,102,63,25,153,154 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },877268,877283, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {63 },
 new byte[]  { 0 },877324,877324, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {63 },
 new byte[]  { 0 },877328,877328, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {63,25,153,154,63,38,102,102,63,76,204,205,63,89,153,154,63,89,153,154,63,25,153,154 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },877332,877355, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {62,204,204,205,62,204,204,205,63 },
 new byte[]  { 0,0,0,0,0,0,0,0,0 },877396,877404, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {63,12,204,205,63,51,51,51,63,76,204,205,63,76,204,205,63,25,153,154 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },877408,877427, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {62,76,204,205,62,76,204,205,62,128 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0 },877468,877477, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {62,128 },
 new byte[]  { 0,0 },877480,877481, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {62,179,51,51,62,204,204,205,62,204,204,205,62,153,153,154 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },877484,877499, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {0,0 },
 new byte[]  { 67,22 },904760,904761, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {66,112 },
 new byte[]  { 67,22 },904764,904765, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {66,112 },
 new byte[]  { 67,22 },904768,904769, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {66,97,235,133,66,97,235,133,66,106,215,10,66,132,148,123,66,170 },
 new byte[]  { 67,22,0,0,67,22,0,0,67,22,0,0,67,22,0,0,67,22 },904772,904789, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {66,191,143,92,66,193,250,225,66,192,10,61,66,187,245,195,66,183,250,225,66,187,46,20,66,181,5,31,66,170 },
 new byte[]  { 67,22,0,0,67,22,0,0,67,22,0,0,67,22,0,0,67,22,0,0,67,22,0,0,67,22,0,0,67,22 },904792,904821, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {66,163,250,225,66,157,10,61,66,152,10,61,66,146,163,215,66,92,122,225,65,112 },
 new byte[]  { 67,22,0,0,67,22,0,0,67,22,0,0,67,22,0,0,67,22,0,0,67,22 },904824,904845, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {0,0 },
 new byte[]  { 67,22 },904848,904849, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {0,0 },
 new byte[]  { 67,22 },904852,904853, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {66,112 },
 new byte[]  { 67,22 },904856,904857, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {66,112 },
 new byte[]  { 67,22 },904860,904861, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {66,97,235,133,66,97,235,133,66,106,215,10,66,132,148,123,66,170 },
 new byte[]  { 67,22,0,0,67,22,0,0,67,22,0,0,67,22,0,0,67,22 },904864,904881, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {66,191,143,92,66,193,250,225,66,192,10,61,66,187,245,195,66,183,250,225,66,187,46,20,66,181,5,31,66,170 },
 new byte[]  { 67,22,0,0,67,22,0,0,67,22,0,0,67,22,0,0,67,22,0,0,67,22,0,0,67,22,0,0,67,22 },904884,904913, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {66,163,250,225,66,157,10,61,66,152,10,61,66,146,163,215,66,92,122,225,65,112 },
 new byte[]  { 67,22,0,0,67,22,0,0,67,22,0,0,67,22,0,0,67,22,0,0,67,22 },904916,904937, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {0,0 },
 new byte[]  { 67,22 },904940,904941, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {0,0 },
 new byte[]  { 67,22 },904944,904945, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {66,112 },
 new byte[]  { 67,22 },904948,904949, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {66,110,102,102,66,48 },
 new byte[]  { 67,22,0,0,67,22 },904952,904957, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {66,32 },
 new byte[]  { 67,22 },904960,904961, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {66,2 },
 new byte[]  { 67,22 },904964,904965, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {66,14 },
 new byte[]  { 67,22 },904968,904969, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {66,20 },
 new byte[]  { 67,22 },904972,904973, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {66,32 },
 new byte[]  { 67,22 },904976,904977, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {66,32 },
 new byte[]  { 67,22 },904980,904981, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {66,32 },
 new byte[]  { 67,22 },904984,904985, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {66,32 },
 new byte[]  { 67,22 },904988,904989, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {66,32 },
 new byte[]  { 67,22 },904992,904993, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {65,240 },
 new byte[]  { 67,22 },904996,904997, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {65,200 },
 new byte[]  { 67,22 },905000,905001, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {65,200 },
 new byte[]  { 67,22 },905004,905005, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {65,200 },
 new byte[]  { 67,22 },905008,905009, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {65,200 },
 new byte[]  { 67,22 },905012,905013, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {65,200 },
 new byte[]  { 67,22 },905016,905017, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {65,200 },
 new byte[]  { 67,22 },905020,905021, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {65,200 },
 new byte[]  { 67,22 },905024,905025, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {0,0 },
 new byte[]  { 67,22 },905028,905029, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {0,0 },
 new byte[]  { 67,22 },905032,905033, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {0,0 },
 new byte[]  { 67,22 },905036,905037, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {66,112 },
 new byte[]  { 67,22 },905040,905041, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {66,110,102,102,66,40 },
 new byte[]  { 67,22,0,0,67,22 },905044,905049, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {66,20 },
 new byte[]  { 67,22 },905052,905053, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {65,236 },
 new byte[]  { 67,22 },905056,905057, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {66,0 },
 new byte[]  { 67,22 },905060,905061, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {66,6 },
 new byte[]  { 67,22 },905064,905065, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {66,16 },
 new byte[]  { 67,22 },905068,905069, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {66,0 },
 new byte[]  { 67,22 },905072,905073, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {65,224 },
 new byte[]  { 67,22 },905076,905077, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {65,208 },
 new byte[]  { 67,22 },905080,905081, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {65,200 },
 new byte[]  { 67,22 },905084,905085, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {65,200 },
 new byte[]  { 67,22 },905088,905089, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {65,160 },
 new byte[]  { 67,22 },905092,905093, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {65,160 },
 new byte[]  { 67,22 },905096,905097, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {65,160 },
 new byte[]  { 67,22 },905100,905101, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {65,160 },
 new byte[]  { 67,22 },905104,905105, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {65,160 },
 new byte[]  { 67,22 },905108,905109, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {65,160 },
 new byte[]  { 67,22 },905112,905113, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {65,160 },
 new byte[]  { 67,22 },905116,905117, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {0,0 },
 new byte[]  { 67,22 },905120,905121, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {0,0 },
 new byte[]  { 67,22 },905124,905125, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {0,0 },
 new byte[]  { 67,22 },905128,905129, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {66,112 },
 new byte[]  { 67,22 },905132,905133, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {66,110,102,102,66,32 },
 new byte[]  { 67,22,0,0,67,22 },905136,905141, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {66,12 },
 new byte[]  { 67,22 },905144,905145, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {65,196 },
 new byte[]  { 67,22 },905148,905149, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {65,216 },
 new byte[]  { 67,22 },905152,905153, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {65,224 },
 new byte[]  { 67,22 },905156,905157, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {65,240 },
 new byte[]  { 67,22 },905160,905161, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {65,200 },
 new byte[]  { 67,22 },905164,905165, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {65,160 },
 new byte[]  { 67,22 },905168,905169, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {65,160 },
 new byte[]  { 67,22 },905172,905173, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {0,0 },
 new byte[]  { 67,22 },905176,905177, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {0,0 },
 new byte[]  { 67,22 },905180,905181, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {0,0 },
 new byte[]  { 67,22 },905184,905185, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {0,0 },
 new byte[]  { 67,22 },905188,905189, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {0,0 },
 new byte[]  { 67,22 },905192,905193, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {0,0 },
 new byte[]  { 67,22 },905196,905197, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {0,0 },
 new byte[]  { 67,22 },905200,905201, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {0,0 },
 new byte[]  { 67,22 },905204,905205, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {0,0 },
 new byte[]  { 67,22 },905208,905209, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {0,0 },
 new byte[]  { 67,22 },905212,905213, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {0,0 },
 new byte[]  { 67,22 },905216,905217, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64,12,66,236,64,12,66,236,63,202,54,198,64,69,155,8,64,54,136,193,64,71,29,233,64,91,224,64,64,92,189,248,64,113,227,49,64,131,132,53,64,105,154,255,64,59,131,221,64,95,171,50,64,171,1,119,64,182,78,199 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },914492,914551, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64,124,20,68,64,124,20,68,64,35,147,157,64,60,86,124,64,129,117,137,64,164,191,211,63,135,174,20,64,154,57,141,64,165,152,129,64,165,152,129,64,179,36,245,64,166,91,169,64,202,149,148,64,233,5,82,64,225,222,10 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },914556,914615, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64,227,13,96,64,227,13,96,64,131,121,163,64,134,151,131,64,114,121,237,64,87,196,212,64,208,81,236,64,132,114,145,64,103,121,11,64,103,121,11,64,217,157,115,64,226,92,187,64,214,42,109,65,16,129,59,65,14,35,19 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },914620,914679, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {65,90,225,207,65,90,225,207,64,214,4,129,64,253,32,242,64,221,75,53,64,189,117,119,64,67,209,191,65,32,157,156,65,13,116,103,65,13,116,103,64,245,198,211,64,223,228,219,64,255,30,239,65,36,227,108,65,89,91,40 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },914684,914743, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {65,254,206,60,65,254,206,60,65,134,99,209,65,119,45,217,65,63,89,14,65,7,132,67,64,191,81,4,65,147,48,150,65,133,131,227,65,127,154,192,64,250,203,184,64,223,212,215,64,252,89,124,65,49,227,224,65,167,106,59 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },914748,914807, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {65,214,114,134,65,214,114,134,66,22,5,178,65,203,66,124,65,176,36,203,65,149,7,26,64,220,240,162,65,168,65,80,65,172,151,40,65,172,151,40,64,219,189,194,64,209,40,31,64,246,133,47,65,55,49,171,65,185,83,198 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },914812,914871, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {65,165,1,145,65,165,1,145,66,65,71,234,65,230,218,150,65,255,42,122,66,1,102,151,65,14,44,183,65,35,242,129,65,53,111,160,65,53,111,160,64,186,164,227,64,207,53,74,65 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },914876,914924, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {193,16,65,39,185,245,65,152,25,218 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0 },914926,914935, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {66,16,252,172,66,16,252,172,65,245,137,6,64,239,168,128,65,169,245,16,66,12 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },914940,914961, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {65,141,56,38,65,26,255,91,65,46,25,165,65,46,25,165,64,229,70,60,64,184,30,222,65,24,144,9,65,51,111,171,65,141,117,131 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },914964,914999, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {66,196,88,202,66,196,88,202,65,212,250,12,65,82,120,130,65,192,158,33,66,9,235,202,65,199,150,38,65,108,87,191,65,78,165,53,65,78,165,53,64,239,192,185,64,178,6,189,65,29,250,66,65,33,112,126,65,100,124,226 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },915004,915063, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {67,73 },
 new byte[]  { 0,0 },915068,915069, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {67,73 },
 new byte[]  { 0,0 },915072,915073, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {66,133,243,205,65,190,250,197,65,137,51,169,65,38,217,26,65,213,11,239,65,198,238,220,65,125,86,213,65,125,86,213,65,5,161,239,64,187,184,26,65,24,106,127,65,6,144,122,65,51,143,76 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },915076,915127, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {67,73 },
 new byte[]  { 0,0 },915132,915133, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {67,73 },
 new byte[]  { 0,0 },915136,915137, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {66,241,30,131,65,222,108,88,65,155,93,169,65,31,161,139,65,138,134,196,65,194,57,254,65,134,4,89,65,134,4,89,65,22,4,13,64,201,217,162,64,229,218,38,64,237,52,62,65,41,19,80 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },915140,915191, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {67,73 },
 new byte[]  { 0,0 },915196,915197, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {67,73 },
 new byte[]  { 0,0 },915200,915201, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {67,46,36,156,65,253,221,235,65,175,129,76,65,25,116,6,64,160,49,77,65,83,58,145,65,123,215,162,65,123,215,162,65,15,244,33,64,212,173,91,64,223,181,203,64,227,229,176,65,66,208,58 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },915204,915255, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {67,73 },
 new byte[]  { 0,0 },915260,915261, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {67,73 },
 new byte[]  { 0,0 },915264,915265, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {67,46,36,156,66,14,167,191,65,197,180,246,65,33,96,216,64,166,159,92,65,4,123,43,65,79,157,241,65,79,157,241,65,40,10,27,64,209,154,163,65,11,137,65,65,14,31,70,65,95,249,3 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },915268,915319, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {67,73 },
 new byte[]  { 0,0 },915324,915325, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {67,73 },
 new byte[]  { 0,0 },915328,915329, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {67,46,36,156,66,30,96,136,65,225,122,78,65,53,48,168,64,204,125,109,64,252,35,115,65,2,189,160,65,2,189,160,65,87,170,33,64,235,149,61,65,8,249,184,65,42,120,94,65,136,92,104 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },915332,915383, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {67,73 },
 new byte[]  { 0,0 },915388,915389, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {67,73 },
 new byte[]  { 0,0 },915392,915393, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {67,46,36,156,66,61,210,26,66,11,249,112,65,180,65,139,65,44,60,240,64,223,26,176,65,27,200,1,65,27,200,1,65,145,197,217,65,65,221,42,65,72,109,79,65,193,177,185,66,20,102,218 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },915396,915447, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64,131,215,10,64,131,215,10,64,162,61,113,64,168,163,215,64,175,10,61,64,138,102,102,64,75,133,31,64,19,105,208,63,182,157,3,63,12,204,205,62,165,139,242,62,237,58,7,63,120,81,236,64,167,51,51,65,23,174,20 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },919708,919767, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64,131,215,10,64,131,215,10,64,162,61,113,64,168,163,215,64,175,10,61,64,138,102,102,64,75,133,31,64,19,105,208,63,182,157,3,63,12,204,205,62,165,139,242,62,237,58,7,63,120,81,236,64,167,51,51,65,23,174,20 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },919772,919831, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64,131,204,84,64,131,204,84,64,162,37,130,64,168,151,224,64,175,10,61,64,138,102,102,64,75,133,31,64,19,105,208,63,182,157,3,63,12,204,205,62,166,124,227,62,237,235,181,63,119,243,7,64,167,45,69,65,23,174,20 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },919836,919895, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {65,167,28,210,65,167,28,210,65,21,146,226,64,237,8,248,64,174,236,44,64,138,87,94,64,75,133,31,64,19,117,50,63,182,202,140,63,13,85,103,63,251,223,36,64,170,108,99,65,42,4,61,65,32,217,41,65,23,174,20 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },919900,919959, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {66,10,107,15,66,10,107,15,65,124,120,89,65,131,38,100,65,136,16,154,65,33,129,52,64,75,132,203,64,137,212,12,64,173,229,178,64,209,247,89,64,230,140,146,65,29,238,169,65,104,244,203,65,64,81,112,65,23,174,20 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },919964,920023, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {65,244,235,60,65,244,235,60,66,8,78,168,65,223,35,98,65,173,169,117,65,109,230,25,65 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },920028,920052, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {121,74,65,32,142,27,65,64,162,237,65,96,183,191,65,134,106,3,65,130,118,104,65,73,2,25,65,48,95,110,65,23,188,195 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },920054,920087, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64,7,104,250,64,7,104,250,66,13,118,254,65,228,24,70,65,173,66,142,65,128,211,229,65,40,202,121,65,55,37,177,65,69,128,232,65,83,220,32,65,188,106,142,65,202,39,87,65,147,36,106,65,143,228,98,65,140,164,90 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },920092,920151, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {66,47,73,231,66,47,73,231,66,1,94,70,65,219,92,148,65,179,252,157,65,138,228,137,65,67,152,234,65,103,211,242,65,134,7,124,65,152,37 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },920156,920194, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {65,243,76,133,66,6,199,65,65,230,234,248,65,197,98,42,65,163,217,93 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },920196,920215, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {66,47,71,174,66,47,71,174,66,26,76,165,66 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0 },920220,920232, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {219,230,65,206,214,80,65,157,91,61,65,87,192,85,65,164,18,158,65,220,69,18,66,10,59,195,66,23,101,170,66,32,135,39,66,37,160,57,66,23,247,79,66,10,78,100 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },920234,920279, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {66,47,71,174,66,173,249,69,66,102,154,219,65,226,134,87,65,195,12,189,65,163,147,35,65,203,45,91,65,242,199,147,66,13,48,229,66,11,190,138,66,25,104,21,66,54,45,136,66,25,163,186,65,250,51,218 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },920288,920343, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {66,47,71,174,67,21,239,175,66,173,182,205,65,190,56,237,65,202,255,224,65,215,198,210,65,236,53,244,66 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },920352,920380, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {82,139,66,10,138,27,65,244,244,19,65,234,144,93,65,245,233,20,65,206,132,88,65,167,31,157 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },920382,920407, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {66,47,71,174,67,21,240,164,66,170,67,53,65,162,148,141,65,204,74,114,65,246 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },920416,920437, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {87,66 },
 new byte[]  { 0,0 },920439,920440, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {45,249,66,5,91,199,66,10,137,149,65,247,250,150,65,206,242,185,65,153,251,144,65,81,3,141,64,220,31,243 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },920442,920471, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {66,47,71,174,67,21,240,164,66,180,33,4,65,241,130,255,65,203,31,190,65,164,188,125,65,175,37,41,65,185,141,213,65,195,246,129,65,209,142,9,65,162,73,163,64,216,165,68,64,218,103,29,64,220,40,246 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },920480,920535, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {66,47,71,174,67,21,240,164,66,180,33,72,65,241,133,31,65,169,109,221,65,66,173,55,65,99,183,178,65,130,97,22,65,146,230,84,65,93,247,148,65,32,36 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },920544,920586, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64,216,163,215,64,218,102,102,64,220,40,246 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0 },920588,920599, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {66,47,71,174,67,21,240,164,66,180,33,72,65,241,133,31,65,169,112,164,65,66,184,82,65,106,244,88,65,137,152,47,65,157,182,50,65,101,49,200,65,32,40,246,64,216,163,215,64,218,102,102,64,220,40,246 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },920608,920663, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64,131,215,10,64,131,215,10,64,162,61,113,64,168,163,215,64,175,10,61,64,138,102,102,64,75,133,31,64,19,105,208,63,182,157,3,63,12,204,205,62,165,139,242,62,237,58,7,63,120,81,236,64,167,51,51,65,23,174,20 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },920860,920919, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64,131,215,10,64,131,215,10,64,162,61,113,64,168,163,215,64,175,10,61,64,138,102,102,64,75,133,31,64,19,105,208,63,182,157,3,63,12,204,205,62,165,139,242,62,237,58,7,63,120,81,236,64,167,51,51,65,23,174,20 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },920924,920983, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64,131,204,84,64,131,204,84,64,162,37,130,64,168,151,224,64,175,10,61,64,138,102,102,64,75,133,31,64,19,105,208,63,182,157,3,63,12,204,205,62,166,124,227,62,237,235,181,63,119,243,7,64,167,45,69,65,23,174,20 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },920988,921047, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {65,167,28,210,65,167,28,210,65,21,146,226,64,237,8,248,64,174,236,44,64,138,87,94,64,75,133,31,64,19,117,50,63,182,202,140,63,13,85,103,63,251,223,36,64,170,108,99,65,42,4,61,65,32,217,41,65,23,174,20 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },921052,921111, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {66,10,107,15,66,10,107,15,65,124,120,89,65,131,38,100,65,136,16,154,65,33,129,52,64,75,132,203,64,137,212,12,64,173,229,178,64,209,247,89,64,230,140,146,65,29,238,169,65,104,244,203,65,64,81,112,65,23,174,20 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },921116,921175, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {65,244,235,60,65,244,235,60,66,8,78,168,65,223,35,98,65,173,169,117,65,109,230,25,65 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },921180,921204, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {121,74,65,32,142,27,65,64,162,237,65,96,183,191,65,134,106,3,65,130,118,104,65,73,2,25,65,48,95,110,65,23,188,195 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },921206,921239, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64,7,104,250,64,7,104,250,66,13,118,254,65,228,24,70,65,173,66,142,65,128,211,229,65,40,202,121,65,55,37,177,65,69,128,232,65,83,220,32,65,188,106,142,65,202,39,87,65,147,36,106,65,143,228,98,65,140,164,90 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },921244,921303, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {66,47,73,231,66,47,73,231,66,1,94,70,65,219,92,148,65,179,252,157,65,138,228,137,65,67,152,234,65,103,211,242,65,134,7,124,65,152,37 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },921308,921346, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {65,243,76,133,66,6,199,65,65,230,234,248,65,197,98,42,65,163,217,93 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },921348,921367, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {66,47,71,174,66,47,71,174,66,26,76,165,66 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0 },921372,921384, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {219,230,65,206,214,80,65,157,91,61,65,87,192,85,65,164,18,158,65,220,69,18,66,10,59,195,66,23,101,170,66,32,135,39,66,37,160,57,66,23,247,79,66,10,78,100 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },921386,921431, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {66,47,71,174,66,173,249,69,66,102,154,219,65,226,134,87,65,195,12,189,65,163,147,35,65,203,45,91,65,242,199,147,66,13,48,229,66,11,190,138,66,25,104,21,66,54,45,136,66,25,163,186,65,250,51,218 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },921440,921495, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {66,47,71,174,67,21,239,175,66,173,182,205,65,190,56,237,65,202,255,224,65,215,198,210,65,236,53,244,66 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },921504,921532, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {82,139,66,10,138,27,65,244,244,19,65,234,144,93,65,245,233,20,65,206,132,88,65,167,31,157 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },921534,921559, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {66,47,71,174,67,21,240,164,66,170,67,53,65,162,148,141,65,204,74,114,65,246 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },921568,921589, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {87,66 },
 new byte[]  { 0,0 },921591,921592, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {45,249,66,5,91,199,66,10,137,149,65,247,250,150,65,206,242,185,65,153,251,144,65,81,3,141,64,220,31,243 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },921594,921623, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {66,47,71,174,67,21,240,164,66,180,33,4,65,241,130,255,65,203,31,190,65,164,188,125,65,175,37,41,65,185,141,213,65,195,246,129,65,209,142,9,65,162,73,163,64,216,165,68,64,218,103,29,64,220,40,246 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },921632,921687, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {66,47,71,174,67,21,240,164,66,180,33,72,65,241,133,31,65,169,109,221,65,66,173,55,65,99,183,178,65,130,97,22,65,146,230,84,65,93,247,148,65,32,36 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },921696,921738, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64,216,163,215,64,218,102,102,64,220,40,246 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0 },921740,921751, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {66,47,71,174,67,21,240,164,66,180,33,72,65,241,133,31,65,169,112,164,65,66,184,82,65,106,244,88,65,137,152,47,65,157,182,50,65,101,49,200,65,32,40,246,64,216,163,215,64,218,102,102,64,220,40,246 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },921760,921815, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64,12,66,236,64,12,66,236,63,202,54,198,64,69,155,8,64,191,34,180,65,13,187,242,64,155,215,10,65,34,209,5,64,215,116,125,64,215,116,125,64,105,154,255,64,59,131,221,64,95,171,50,64,171,1,119,64,182,78,199 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },922012,922071, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64,124,20,68,64,124,20,68,64,35,147,157,64,60,86,124,64,129,117,137,64,164,191,211,63,135,174,20,64,229,10,78,64,165,152,129,64,165,152,129,64,195,57,187,64,166,91,169,64,202,149,148,64,233,5,82,64,225,222,10 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },922076,922135, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64,227,13,96,64,227,13,96,64,131,121,163,64,134,151,131,64,114,121,237,64,87,196,212,64,208,81,236,64,132,114,145,64,103,121,11,64,103,121,11,65,6,107,95,65,7,101,125,65,13,231,59,65,16,129,59,65,14,35,19 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },922140,922199, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {65,90,225,207,65,90,225,207,64,214,4,129,64,253,32,242,64,221,75,53,64,189,117,119,64,67,209,191,65,32,157,156,65,13,116,103,65,13,116,103,65,30,155,128,65,22,45,86,65,58,97,131,65,69,165,240,65,89,91,40 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },922204,922263, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {65,254,206,60,65,254,206,60,65,134,99,209,65,119,45,217,65,63,89,14,65,7,132,67,64,191,81,4,65,147,48,150,65,133,131,227,65,133,131,227,65,188,130,233,65,7,163,207,65,63,19,174,65,110,218,151,65,167,106,59 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },922268,922327, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {65,214,114,134,65,214,114,134,66,22,5,178,65,203,66,124,65,176,36,203,65,149,7,26,64,220,240,162,65,168,65,80,65,172,151,40,65,172,151,40,65,206,250,17,64,245,85,12,65,72,184,230,65,139,127,249,65,185,83,198 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },922332,922391, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {65,165,1,145,65,165,1,145,66,65,71,234,65,251,135,197,65,255,42,122,66,1,102,151,65,14,44,183,65,35,242,129,65,53,111,160,65,53,111,160,65,225,113,58,64,213,184,165,65,64,26,178,65,122,65,118,65,152,25,218 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },922396,922455, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {66,16,252,172,66,16,252,172,65,245,137,6,64,239,168,128,65,169,245,16,66,12 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },922460,922481, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {65,141,56,38,65,26,255,91,65,46,25,165,65,46,25,165,65,227,233,37,64,206,51,69,65,63,183,127,65,80,162,22,65,141,117,131 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },922484,922519, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {66,196,88,202,66,196,88,202,65,212,250,12,65,82,120,130,65,192,158,33,66,12 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },922524,922545, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {65,199,150,38,65,108,87,191,65,78,165,53,65,78,165,53,66,22,132,82,64,207,32,199,65,52,51,157,65,52,194,123,65,100,124,226 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },922548,922583, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {67,73 },
 new byte[]  { 0,0 },922588,922589, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {67,73 },
 new byte[]  { 0,0 },922592,922593, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {66,133,243,205,65,190,250,197,65,137,51,169,65,38,217,26,65,213,11,239,65,198,238,220,65,125,86,213,65,125,86,213,66,49,21,229,64,220,255,227,65,60,122,194,65,35,27,221,65,51,143,76 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },922596,922647, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {67,73 },
 new byte[]  { 0,0 },922652,922653, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {67,73 },
 new byte[]  { 0,0 },922656,922657, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {66,241,30,131,65,222,108,88,65,155,93,169,65,48,157,243,65,138,134,196,65,194,57,254,65,134,4,89,65,134,4,89,66,52,247,248,64,211,214,240,65,21,83,190,65,3,37,230,65,41,19,80 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },922660,922711, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {67,73 },
 new byte[]  { 0,0 },922716,922717, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {67,73 },
 new byte[]  { 0,0 },922720,922721, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {67,46,36,156,65,253,221,235,65,175,129,76,65,66,73,92,64,160,49,77,65,219,112,164,65,123,215,162,65,123,215,162,66,31,80,65,64,218,9,35,65,20,134,114,64,240,189,20,65,66,208,58 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },922724,922775, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {67,73 },
 new byte[]  { 0,0 },922780,922781, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {67,73 },
 new byte[]  { 0,0 },922784,922785, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {67,46,36,156,66,14,167,191,65,197,180,246,65,92,52,222,64,166,159,92,65,62,102,102,65,79,157,241,65,79,157,241,65,226,42,207,64,209,154,163,65,11,137,65,65,14,31,70,65,95,249,3 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },922788,922839, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {67,73 },
 new byte[]  { 0,0 },922844,922845, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {67,73 },
 new byte[]  { 0,0 },922848,922849, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {67,46,36,156,66,30,96,136,65,225,122,78,65,134,51,139,64,204,125,109,65,103,133,31,65,2,189,160,65,2,189,160,65,128,217,120,64,235,149,61,65,8,249,184,65,42,120,94,65,136,92,104 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },922852,922903, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {67,73 },
 new byte[]  { 0,0 },922908,922909, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {67,73 },
 new byte[]  { 0,0 },922912,922913, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {67,46,36,156,66,61,210,26,66,11,249,112,65,180,65,139,65,44,60,240,64,223,26,176,65,27,200,1,65,27,200,1,65,145,197,217,65,65,221,42,65,72,109,79,65,193,177,185,66,20,102,218 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },922916,922967, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {2,2,2,2,2,2,2 },
 new byte[]  { 0,0,0,0,0,0,0 },940649,940655, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {2,2 },
 new byte[]  { 0,0 },940671,940672, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {2,2,2 },
 new byte[]  { 0,0,0 },940676,940678, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {2 },
 new byte[]  { 0 },940715,940715, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {2,2 },
 new byte[]  { 0,0 },940728,940729, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {2 },
 new byte[]  { 0 },940735,940735, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {2,2,2,2,2,2,2,2,2,2 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0 },940739,940748, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {2,2,2,2,2,2,2 },
 new byte[]  { 0,0,0,0,0,0,0 },940816,940822, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {2,2 },
 new byte[]  { 0,0 },940838,940839, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {2,2,2 },
 new byte[]  { 0,0,0 },940843,940845, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {2 },
 new byte[]  { 0 },940882,940882, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {2,2 },
 new byte[]  { 0,0 },940895,940896, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {2 },
 new byte[]  { 0 },940902,940902, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {2,2,2,2,2,2,2,2,2,2 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0 },940906,940915, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1 },
 new byte[]  { 0 },940989,940989, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1 },
 new byte[]  { 0 },941049,941049, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3,3,3,3,3,3,3,3 },
 new byte[]  { 1,1,1,1,1,1,1,1 },941673,941680, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3 },
 new byte[]  { 1 },941717,941717, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3,3,3,3,3,3,3,3 },
 new byte[]  { 1,1,1,1,1,1,1,1 },941840,941847, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3 },
 new byte[]  { 1 },941884,941884, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,1,1,1,1,1 },
 new byte[]  { 0,0,0,0,0,0 },942152,942157, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,1 },
 new byte[]  { 0,0 },942174,942175, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,1 },
 new byte[]  { 0,0 },942179,942180, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,1 },
 new byte[]  { 0,0 },942231,942232, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,1,1,1,1,1,1,1 },
 new byte[]  { 0,0,0,0,0,0,0,0 },942244,942251, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,1,1,1,1,1 },
 new byte[]  { 0,0,0,0,0,0 },942319,942324, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,1 },
 new byte[]  { 0,0 },942341,942342, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,1 },
 new byte[]  { 0,0 },942346,942347, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,1 },
 new byte[]  { 0,0 },942398,942399, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,1,1,1,1,1,1,1 },
 new byte[]  { 0,0,0,0,0,0,0,0 },942411,942418, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3,72,3,72,3,72,3,72 },
 new byte[]  { 0,0,0,0,0,0,0,0 },942540,942547, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {210 },
 new byte[]  { 0 },942549,942549, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {210 },
 new byte[]  { 0 },942551,942551, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {78 },
 new byte[]  { 0 },942553,942553, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {2,13,2,13,255,255,255,255 },
 new byte[]  { 0,0,0,0,0,0,0,0 },942610,942617, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3,72,3,72 },
 new byte[]  { 0,0,0,0 },942698,942701, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {255,255 },
 new byte[]  { 0,0 },942712,942713, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {210 },
 new byte[]  { 0 },942721,942721, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {210,16,98,16,98,16,98,16,98,8,49,3,71,2,13,4,25 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },942723,942739, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3,72,3,72,3,72,3,72 },
 new byte[]  { 0,0,0,0,0,0,0,0 },943208,943215, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {210 },
 new byte[]  { 0 },943217,943217, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {210 },
 new byte[]  { 0 },943219,943219, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {78 },
 new byte[]  { 0 },943221,943221, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {2,13,2,13,255,255,255,255 },
 new byte[]  { 0,0,0,0,0,0,0,0 },943278,943285, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {255,255 },
 new byte[]  { 0,0 },943358,943359, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3,72,3,72 },
 new byte[]  { 0,0,0,0 },943366,943369, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {255,255 },
 new byte[]  { 0,0 },943380,943381, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {210 },
 new byte[]  { 0 },943389,943389, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {210,16,98,16,98,16,98,16,98,8,49,3,71,2,13,4,25 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },943391,943407, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {4 },
 new byte[]  { 0 },943715,943715, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3 },
 new byte[]  { 0 },943876,943876, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3 },
 new byte[]  { 0 },943878,943878, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3 },
 new byte[]  { 0 },943880,943880, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3 },
 new byte[]  { 0 },943882,943882, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1 },
 new byte[]  { 0 },943884,943884, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1 },
 new byte[]  { 0 },943886,943886, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1 },
 new byte[]  { 0 },943888,943888, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,1,1,1,1,1,1,1 },
 new byte[]  { 0,0,0,0,0,0,0,0 },943946,943953, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1 },
 new byte[]  { 0 },944048,944048, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1 },
 new byte[]  { 0 },944050,944050, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {10 },
 new byte[]  { 0 },944060,944060, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {10 },
 new byte[]  { 0 },944062,944062, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {10 },
 new byte[]  { 0 },944064,944064, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {10 },
 new byte[]  { 0 },944066,944066, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {10 },
 new byte[]  { 0 },944068,944068, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {10 },
 new byte[]  { 0 },944070,944070, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {10 },
 new byte[]  { 0 },944072,944072, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {10 },
 new byte[]  { 0 },944074,944074, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {4,2,4,1,4,4,4,4,4,6,4,5,4,9,4,3 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },944606,944621, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {4,4 },
 new byte[]  { 0,0 },944694,944695, "Found dpf map...Delete map");
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