using ToolBoxNameSpace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;
using System.IO;

namespace CobraCarSolution.TreeElements.VAG  {
  class Mercedes_Benz_EDC16C31 : MenuItem, ITreeItem  {
    public Mercedes_Benz_EDC16C31()  {
      Title = "Mercedes_Benz_EDC16C31";
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
		validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {100 },  545033    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {100,13,172,14,116,15,160,17,48,19,36,19,136,20,80,20,180,20,80,19,236,17,148,17,148 },  545035    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {100 },  545061    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {100,2,38,2,38,2,38,2,38,2,38,2,38,2,38,2,38,2,38,2,38,2,38,2,38,2,38,2,38,2,38,2,38,2,38,2,38 },  545063    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {12,228,13,172,14,216,16,104,18,92,18,192,19,136,19,236,19,136,19,36,16,204,16,204 },  545138    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,144,1,144,1,144,1,144,1,144,1,144,1,144,1,144,1,144,1,144,1,144,1,144,1,144,1,144,1,144,1,144,1,144,1,144,1 },  545166    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {100 },  812285    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {100,13,172,14,116,15,60,16,204,18,92,19,186,20,130,20,230,19,236,18,192,17,148,17,148 },  812287    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {100 },  812313    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {100,2,38,2,38,2,38,2,38,2,38,2,38,2,38,2,38,2,38,2,38,2,38,2,38,2,38,2,38,2,38,2,38,2,38,2,38 },  812315    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {12,228,13,172,14,116,16,4,17,148,18,192,19,186,20,30,19,86,17,248,16,204,16,204 },  812390    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,144,1,144,1,144,1,144,1,144,1,144,1,144,1,144,1,144,1,144,1,144,1,144,1,144,1,144,1,144,1,144,1,144,1,144,1 },  812418    );
      }
      return validationEgrInFile;
    }
    public override async Task < bool > checkFileForDpf()  {
      bool validationEgrInFile = true;
      //Algo for checking dpf solution
      if (ToolBox.array.Length > 0)  {
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {0,100,0,100,13,172,14,116,15,160,17,48,19,36,19,136,20,80,20,180,20,80,19,236,17,148,17,148 },  545032    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {0,0,0,0,12,228,13,172,14,216,16,104,18,92,18,192,19,136,19,236,19,136,19,36,16,204,16,204 },  545134    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,1 },  549499    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {5,5,4,4,4,4 },  549510    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,5 },  549517    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {8 },  549520    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {4 },  549522    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,1,1,1,1 },  549524    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1 },  549531    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,1,1 },  549533    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {4,1,1 },  549537    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,1 },  549543    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3,3,3,3,3,3 },  549548    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3,3,3,3,3,3,3,3,3 },  549555    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3 },  549566    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,1,1,1 },  549568    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3,14,5,1 },  549574    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1 },  549579    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,5 },  549581    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {4,4 },  549584    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {5,5,5,5,5,5,5,5,5,5,5,5,5,5 },  549589    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3 },  549607    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3 },  549609    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3 },  549611    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3 },  549613    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3 },  549615    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3 },  549617    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3 },  549619    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3 },  549621    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3 },  549623    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3 },  549630    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3 },  549632    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3 },  549634    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3 },  549637    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,1 },  549639    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,5,4,4,4 },  549643    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {5,4,4 },  549649    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3,4 },  549653    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,4,1,1,4,1,4,1 },  549666    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {4 },  549675    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,1,1,1,1,1 },  549677    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {4,5,5,5 },  549685    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {4,4,4,4 },  549692    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {4,27,3,4 },  549697    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {4,4,4,1,1,1 },  549702    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {4 },  549709    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {11 },  549711    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {11,11,11 },  549713    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {29 },  549718    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {29 },  549720    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {11 },  549722    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {11,11,11 },  549724    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {29 },  549729    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {29 },  549731    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {5,4,4 },  549734    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,1,1,1,1,1,4,4,4,4,1,1,5 },  549739    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {100 },  611583    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {101 },  611585    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {150 },  611587    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {200 },  611589    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {80 },  611591    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {80 },  611593    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {61 },  611595    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {61 },  611597    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {61 },  611599    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {80 },  611601    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {80 },  611603    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {80 },  611605    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {80 },  611607    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {80 },  611609    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {61 },  611611    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {61 },  611613    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {61 },  611615    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {80 },  611617    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {80 },  611619    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {80 },  611621    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {80 },  611623    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {80 },  611625    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {61 },  611627    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {61 },  611629    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {61 },  611631    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {80 },  611633    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {80 },  611635    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {80 },  611637    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {120 },  611639    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {120 },  611641    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {61 },  611643    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {61 },  611645    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {61 },  611647    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {120 },  611649    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {120 },  611651    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {160 },  611653    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {120 },  611655    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {120 },  611657    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {61 },  611659    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {61 },  611661    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {61 },  611663    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {120 },  611665    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {120 },  611667    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {160 },  611669    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {80 },  611671    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {80 },  611673    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {61 },  611675    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {61 },  611677    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {61 },  611679    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {80 },  611681    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {80 },  611683    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {80 },  611685    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {80 },  611687    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {80 },  611689    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {61 },  611691    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {61 },  611693    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {61 },  611695    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {80 },  611697    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {80 },  611699    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {80 },  611701    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {80 },  611703    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {80 },  611705    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {61 },  611707    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {61 },  611709    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {61 },  611711    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {80 },  611713    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {80 },  611715    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {80 },  611717    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {100 },  611747    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {101 },  611749    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {150 },  611751    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {200 },  611753    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {80 },  611755    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {80 },  611757    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {61 },  611759    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {61 },  611761    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {61 },  611763    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {80 },  611765    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {80 },  611767    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {80 },  611769    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {80 },  611771    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {80 },  611773    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {61 },  611775    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {61 },  611777    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {61 },  611779    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {80 },  611781    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {80 },  611783    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {80 },  611785    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {80 },  611787    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {80 },  611789    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {61 },  611791    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {61 },  611793    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {61 },  611795    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {80 },  611797    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {80 },  611799    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {80 },  611801    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {120 },  611803    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {120 },  611805    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {61 },  611807    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {61 },  611809    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {61 },  611811    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {120 },  611813    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {120 },  611815    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {160 },  611817    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {120 },  611819    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {120 },  611821    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {61 },  611823    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {61 },  611825    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {61 },  611827    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {120 },  611829    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {120 },  611831    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {160 },  611833    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {80 },  611835    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {80 },  611837    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {61 },  611839    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {61 },  611841    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {61 },  611843    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {80 },  611845    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {80 },  611847    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {80 },  611849    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {80 },  611851    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {80 },  611853    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {61 },  611855    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {61 },  611857    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {61 },  611859    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {80 },  611861    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {80 },  611863    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {80 },  611865    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {80 },  611867    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {80 },  611869    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {61 },  611871    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {61 },  611873    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {61 },  611875    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {80 },  611877    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {80 },  611879    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {80 },  611881    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {22 },  611919    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {22 },  611921    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  611923    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  611925    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  611927    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  611929    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  611931    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  611933    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {22 },  611935    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {22 },  611937    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  611939    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  611941    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  611943    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  611945    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  611947    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  611949    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {22 },  611951    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {22 },  611953    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  611955    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  611957    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  611959    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  611961    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  611963    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  611965    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {22 },  611967    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {22 },  611969    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  611971    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  611973    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  611975    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  611977    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  611979    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  611981    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {22 },  611983    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {22 },  611985    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  611987    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  611989    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  611991    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  611993    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  611995    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  611997    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {22 },  611999    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {22 },  612001    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  612003    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  612005    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  612007    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  612009    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  612011    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  612013    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {22 },  612015    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {22 },  612017    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  612019    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  612021    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  612023    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  612025    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  612027    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  612029    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {22 },  612031    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {22 },  612033    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  612035    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  612037    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  612039    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  612041    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  612043    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  612045    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {22 },  612083    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {22 },  612085    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  612087    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  612089    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  612091    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  612093    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  612095    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  612097    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {22 },  612099    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {22 },  612101    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  612103    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  612105    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  612107    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  612109    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  612111    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  612113    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {22 },  612115    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {22 },  612117    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  612119    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  612121    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  612123    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  612125    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  612127    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  612129    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {22 },  612131    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {22 },  612133    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  612135    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  612137    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  612139    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  612141    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  612143    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  612145    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {22 },  612147    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {22 },  612149    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  612151    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  612153    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  612155    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  612157    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  612159    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  612161    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {22 },  612163    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {22 },  612165    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  612167    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  612169    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  612171    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  612173    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  612175    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  612177    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {22 },  612179    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {22 },  612181    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  612183    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  612185    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  612187    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  612189    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  612191    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  612193    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {22 },  612195    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {22 },  612197    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  612199    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  612201    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  612203    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  612205    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  612207    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  612209    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {2 },  612501    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {2 },  612503    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {25 },  612507    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {0,100,0,100,13,172,14,116,15,60,16,204,18,92,19,186,20,130,20,230,19,236,18,192,17,148,17,148 },  812284    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {0,0,0,0,12,228,13,172,14,116,16,4,17,148,18,192,19,186,20,30,19,86,17,248,16,204,16,204 },  812386    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,1 },  829471    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {5,5,4,4,4,4 },  829482    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,5 },  829489    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {8 },  829492    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {4 },  829494    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,1,1,1,1 },  829496    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1 },  829503    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,1,1 },  829505    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,1 },  829510    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,1 },  829515    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3 },  829538    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,1,1,1 },  829540    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3,14,5,2 },  829546    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1 },  829551    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,5 },  829553    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {4,4 },  829556    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {5,5,5,5,5,5,5,5,5,5,5,5,5,5 },  829561    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3 },  829579    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3 },  829581    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3 },  829583    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3 },  829585    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3 },  829587    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3 },  829589    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3 },  829591    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3 },  829593    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3 },  829595    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3 },  829602    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3 },  829604    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3 },  829606    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3 },  829609    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,1 },  829611    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,5,4,4,4 },  829615    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {5,4,4 },  829621    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3,4 },  829625    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,4,1,1 },  829638    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,4,1 },  829643    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {4 },  829647    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,1,1,1,1,1 },  829649    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {4,5,5,5 },  829657    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {4,4,4,4 },  829664    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {4,27,3,4 },  829669    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {4,4,4,1,1,1 },  829674    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {4 },  829681    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {11 },  829683    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {11,11,11 },  829685    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {29 },  829690    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {29 },  829692    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {11 },  829694    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {11,11,11 },  829696    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {29 },  829701    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {29 },  829703    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {5,4,4 },  829706    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,1,1,1,1,1,4,4,4,4,1,1,5 },  829711    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {24,87,26,75,28,63,30,51,32,39,34,27,36,15,38,3,39,247,41,235,43,223,45,211,47,199,49,187,96,185 },  957988    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {24,87,26,75,28,63,30,51,32,39,34,27,36,15,38,3,39,247,41,235,43,223,45,211,47,199,49,187,96,185 },  958094    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {24,87,26,75,28,63,30,51,32,39,34,27,36,15,38,3,39,247,41,235,43,223,45,211,47,199,49,187,96,185 },  958228    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {24,87,26,75,28,63,30,51,32,39,34,27,36,15,38,3,39,247,41,235,43,223,45,211,47,199,49,187,96,185 },  958334    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {100 },  984155    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {101 },  984157    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {150 },  984159    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {200 },  984161    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {80 },  984163    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {80 },  984165    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {61 },  984167    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {61 },  984169    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {61 },  984171    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {80 },  984173    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {80 },  984175    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {80 },  984177    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {80 },  984179    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {80 },  984181    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {61 },  984183    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {61 },  984185    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {61 },  984187    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {80 },  984189    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {80 },  984191    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {80 },  984193    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {80 },  984195    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {80 },  984197    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {61 },  984199    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {61 },  984201    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {61 },  984203    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {80 },  984205    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {80 },  984207    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {80 },  984209    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {120 },  984211    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {120 },  984213    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {61 },  984215    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {61 },  984217    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {61 },  984219    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {120 },  984221    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {120 },  984223    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {160 },  984225    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {120 },  984227    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {120 },  984229    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {61 },  984231    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {61 },  984233    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {61 },  984235    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {120 },  984237    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {120 },  984239    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {160 },  984241    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {80 },  984243    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {80 },  984245    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {61 },  984247    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {61 },  984249    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {61 },  984251    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {80 },  984253    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {80 },  984255    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {80 },  984257    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {80 },  984259    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {80 },  984261    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {61 },  984263    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {61 },  984265    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {61 },  984267    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {80 },  984269    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {80 },  984271    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {80 },  984273    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {80 },  984275    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {80 },  984277    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {61 },  984279    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {61 },  984281    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {61 },  984283    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {80 },  984285    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {80 },  984287    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {80 },  984289    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {100 },  984319    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {101 },  984321    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {150 },  984323    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {200 },  984325    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {80 },  984327    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {80 },  984329    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {61 },  984331    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {61 },  984333    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {61 },  984335    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {80 },  984337    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {80 },  984339    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {80 },  984341    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {80 },  984343    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {80 },  984345    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {61 },  984347    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {61 },  984349    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {61 },  984351    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {80 },  984353    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {80 },  984355    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {80 },  984357    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {80 },  984359    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {80 },  984361    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {61 },  984363    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {61 },  984365    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {61 },  984367    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {80 },  984369    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {80 },  984371    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {80 },  984373    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {120 },  984375    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {120 },  984377    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {61 },  984379    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {61 },  984381    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {61 },  984383    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {120 },  984385    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {120 },  984387    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {160 },  984389    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {120 },  984391    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {120 },  984393    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {61 },  984395    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {61 },  984397    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {61 },  984399    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {120 },  984401    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {120 },  984403    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {160 },  984405    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {80 },  984407    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {80 },  984409    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {61 },  984411    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {61 },  984413    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {61 },  984415    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {80 },  984417    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {80 },  984419    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {80 },  984421    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {80 },  984423    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {80 },  984425    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {61 },  984427    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {61 },  984429    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {61 },  984431    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {80 },  984433    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {80 },  984435    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {80 },  984437    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {80 },  984439    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {80 },  984441    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {61 },  984443    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {61 },  984445    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {61 },  984447    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {80 },  984449    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {80 },  984451    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {80 },  984453    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {22 },  984491    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {22 },  984493    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  984495    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  984497    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  984499    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  984501    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  984503    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  984505    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {22 },  984507    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {22 },  984509    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  984511    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  984513    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  984515    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  984517    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  984519    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  984521    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {22 },  984523    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {22 },  984525    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  984527    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  984529    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  984531    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  984533    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  984535    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  984537    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {22 },  984539    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {22 },  984541    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  984543    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  984545    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  984547    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  984549    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  984551    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  984553    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {22 },  984555    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {22 },  984557    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  984559    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  984561    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  984563    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  984565    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  984567    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  984569    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {22 },  984571    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {22 },  984573    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  984575    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  984577    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  984579    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  984581    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  984583    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  984585    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {22 },  984587    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {22 },  984589    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  984591    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  984593    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  984595    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  984597    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  984599    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  984601    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {22 },  984603    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {22 },  984605    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  984607    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  984609    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  984611    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  984613    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  984615    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  984617    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {22 },  984655    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {22 },  984657    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  984659    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  984661    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  984663    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  984665    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  984667    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  984669    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {22 },  984671    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {22 },  984673    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  984675    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  984677    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  984679    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  984681    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  984683    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  984685    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {22 },  984687    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {22 },  984689    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  984691    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  984693    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  984695    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  984697    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  984699    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  984701    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {22 },  984703    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {22 },  984705    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  984707    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  984709    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  984711    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  984713    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  984715    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  984717    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {22 },  984719    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {22 },  984721    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  984723    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  984725    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  984727    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  984729    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  984731    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  984733    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {22 },  984735    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {22 },  984737    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  984739    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  984741    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  984743    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  984745    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  984747    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  984749    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {22 },  984751    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {22 },  984753    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  984755    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  984757    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  984759    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  984761    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  984763    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  984765    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {22 },  984767    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {22 },  984769    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  984771    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  984773    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  984775    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  984777    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  984779    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  984781    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {2 },  985305    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {2 },  985307    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {25 },  985311    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1 },  989301    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {32 },  989307    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64 },  989311    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {128 },  989315    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1 },  989318    );
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
	ToolBox.ReplaceInFileWithStartStop(new byte[]  {100 },
 new byte[]  { 0 },545033,545033, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {100,13,172,14,116,15,160,17,48,19,36,19,136,20,80,20,180,20,80,19,236,17,148,17,148 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },545035,545059, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {100 },
 new byte[]  { 0 },545061,545061, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {100,2,38,2,38,2,38,2,38,2,38,2,38,2,38,2,38,2,38,2,38,2,38,2,38,2,38,2,38,2,38,2,38,2,38,2,38 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },545063,545099, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {12,228,13,172,14,216,16,104,18,92,18,192,19,136,19,236,19,136,19,36,16,204,16,204 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },545138,545161, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,144,1,144,1,144,1,144,1,144,1,144,1,144,1,144,1,144,1,144,1,144,1,144,1,144,1,144,1,144,1,144,1,144,1,144,1 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },545166,545202, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {100 },
 new byte[]  { 0 },812285,812285, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {100,13,172,14,116,15,60,16,204,18,92,19,186,20,130,20,230,19,236,18,192,17,148,17,148 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },812287,812311, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {100 },
 new byte[]  { 0 },812313,812313, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {100,2,38,2,38,2,38,2,38,2,38,2,38,2,38,2,38,2,38,2,38,2,38,2,38,2,38,2,38,2,38,2,38,2,38,2,38 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },812315,812351, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {12,228,13,172,14,116,16,4,17,148,18,192,19,186,20,30,19,86,17,248,16,204,16,204 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },812390,812413, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,144,1,144,1,144,1,144,1,144,1,144,1,144,1,144,1,144,1,144,1,144,1,144,1,144,1,144,1,144,1,144,1,144,1,144,1 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },812418,812454, "Found egr map...Delete map");
      base.egrOffSolution();
    }
    public override void dpfOffSolution()  {
	ToolBox.ReplaceInFileWithStartStop(new byte[]  {0,100,0,100,13,172,14,116,15,160,17,48,19,36,19,136,20,80,20,180,20,80,19,236,17,148,17,148 },
 new byte[]  { 31,31,31,31,31,31,31,31,31,31,31,31,31,31,31,31,31,31,31,31,31,31,31,31,31,31,31,31 },545032,545059, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {0,0,0,0,12,228,13,172,14,216,16,104,18,92,18,192,19,136,19,236,19,136,19,36,16,204,16,204 },
 new byte[]  { 31,31,31,31,31,31,31,31,31,31,31,31,31,31,31,31,31,31,31,31,31,31,31,31,31,31,31,31 },545134,545161, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,1 },
 new byte[]  { 0,0 },549499,549500, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {5,5,4,4,4,4 },
 new byte[]  { 0,0,0,0,0,0 },549510,549515, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,5 },
 new byte[]  { 0,0 },549517,549518, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {8 },
 new byte[]  { 0 },549520,549520, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {4 },
 new byte[]  { 0 },549522,549522, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,1,1,1,1 },
 new byte[]  { 0,0,0,0,0 },549524,549528, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1 },
 new byte[]  { 0 },549531,549531, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,1,1 },
 new byte[]  { 0,0,0 },549533,549535, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {4,1,1 },
 new byte[]  { 0,0,0 },549537,549539, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,1 },
 new byte[]  { 0,0 },549543,549544, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3,3,3,3,3,3 },
 new byte[]  { 0,0,0,0,0,0 },549548,549553, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3,3,3,3,3,3,3,3,3 },
 new byte[]  { 0,0,0,0,0,0,0,0,0 },549555,549563, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3 },
 new byte[]  { 0 },549566,549566, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,1,1,1 },
 new byte[]  { 0,0,0,0 },549568,549571, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3,14,5,1 },
 new byte[]  { 0,0,0,0 },549574,549577, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1 },
 new byte[]  { 0 },549579,549579, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,5 },
 new byte[]  { 0,0 },549581,549582, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {4,4 },
 new byte[]  { 0,0 },549584,549585, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {5,5,5,5,5,5,5,5,5,5,5,5,5,5 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0 },549589,549602, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3 },
 new byte[]  { 0 },549607,549607, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3 },
 new byte[]  { 0 },549609,549609, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3 },
 new byte[]  { 0 },549611,549611, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3 },
 new byte[]  { 0 },549613,549613, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3 },
 new byte[]  { 0 },549615,549615, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3 },
 new byte[]  { 0 },549617,549617, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3 },
 new byte[]  { 0 },549619,549619, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3 },
 new byte[]  { 0 },549621,549621, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3 },
 new byte[]  { 0 },549623,549623, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3 },
 new byte[]  { 0 },549630,549630, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3 },
 new byte[]  { 0 },549632,549632, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3 },
 new byte[]  { 0 },549634,549634, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3 },
 new byte[]  { 0 },549637,549637, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,1 },
 new byte[]  { 0,0 },549639,549640, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,5,4,4,4 },
 new byte[]  { 0,0,0,0,0 },549643,549647, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {5,4,4 },
 new byte[]  { 0,0,0 },549649,549651, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3,4 },
 new byte[]  { 0,0 },549653,549654, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,4,1,1,4,1,4,1 },
 new byte[]  { 0,0,0,0,0,0,0,0 },549666,549673, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {4 },
 new byte[]  { 0 },549675,549675, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,1,1,1,1,1 },
 new byte[]  { 0,0,0,0,0,0 },549677,549682, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {4,5,5,5 },
 new byte[]  { 0,0,0,0 },549685,549688, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {4,4,4,4 },
 new byte[]  { 0,0,0,0 },549692,549695, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {4,27,3,4 },
 new byte[]  { 0,0,0,0 },549697,549700, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {4,4,4,1,1,1 },
 new byte[]  { 0,0,0,0,0,0 },549702,549707, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {4 },
 new byte[]  { 0 },549709,549709, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {11 },
 new byte[]  { 0 },549711,549711, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {11,11,11 },
 new byte[]  { 0,0,0 },549713,549715, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {29 },
 new byte[]  { 0 },549718,549718, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {29 },
 new byte[]  { 0 },549720,549720, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {11 },
 new byte[]  { 0 },549722,549722, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {11,11,11 },
 new byte[]  { 0,0,0 },549724,549726, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {29 },
 new byte[]  { 0 },549729,549729, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {29 },
 new byte[]  { 0 },549731,549731, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {5,4,4 },
 new byte[]  { 0,0,0 },549734,549736, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,1,1,1,1,1,4,4,4,4,1,1,5 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0 },549739,549751, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {100 },
 new byte[]  { 0 },611583,611583, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {101 },
 new byte[]  { 0 },611585,611585, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {150 },
 new byte[]  { 0 },611587,611587, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {200 },
 new byte[]  { 0 },611589,611589, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {80 },
 new byte[]  { 0 },611591,611591, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {80 },
 new byte[]  { 0 },611593,611593, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {61 },
 new byte[]  { 0 },611595,611595, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {61 },
 new byte[]  { 0 },611597,611597, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {61 },
 new byte[]  { 0 },611599,611599, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {80 },
 new byte[]  { 0 },611601,611601, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {80 },
 new byte[]  { 0 },611603,611603, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {80 },
 new byte[]  { 0 },611605,611605, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {80 },
 new byte[]  { 0 },611607,611607, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {80 },
 new byte[]  { 0 },611609,611609, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {61 },
 new byte[]  { 0 },611611,611611, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {61 },
 new byte[]  { 0 },611613,611613, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {61 },
 new byte[]  { 0 },611615,611615, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {80 },
 new byte[]  { 0 },611617,611617, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {80 },
 new byte[]  { 0 },611619,611619, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {80 },
 new byte[]  { 0 },611621,611621, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {80 },
 new byte[]  { 0 },611623,611623, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {80 },
 new byte[]  { 0 },611625,611625, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {61 },
 new byte[]  { 0 },611627,611627, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {61 },
 new byte[]  { 0 },611629,611629, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {61 },
 new byte[]  { 0 },611631,611631, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {80 },
 new byte[]  { 0 },611633,611633, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {80 },
 new byte[]  { 0 },611635,611635, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {80 },
 new byte[]  { 0 },611637,611637, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {120 },
 new byte[]  { 0 },611639,611639, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {120 },
 new byte[]  { 0 },611641,611641, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {61 },
 new byte[]  { 0 },611643,611643, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {61 },
 new byte[]  { 0 },611645,611645, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {61 },
 new byte[]  { 0 },611647,611647, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {120 },
 new byte[]  { 0 },611649,611649, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {120 },
 new byte[]  { 0 },611651,611651, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {160 },
 new byte[]  { 0 },611653,611653, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {120 },
 new byte[]  { 0 },611655,611655, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {120 },
 new byte[]  { 0 },611657,611657, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {61 },
 new byte[]  { 0 },611659,611659, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {61 },
 new byte[]  { 0 },611661,611661, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {61 },
 new byte[]  { 0 },611663,611663, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {120 },
 new byte[]  { 0 },611665,611665, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {120 },
 new byte[]  { 0 },611667,611667, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {160 },
 new byte[]  { 0 },611669,611669, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {80 },
 new byte[]  { 0 },611671,611671, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {80 },
 new byte[]  { 0 },611673,611673, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {61 },
 new byte[]  { 0 },611675,611675, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {61 },
 new byte[]  { 0 },611677,611677, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {61 },
 new byte[]  { 0 },611679,611679, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {80 },
 new byte[]  { 0 },611681,611681, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {80 },
 new byte[]  { 0 },611683,611683, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {80 },
 new byte[]  { 0 },611685,611685, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {80 },
 new byte[]  { 0 },611687,611687, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {80 },
 new byte[]  { 0 },611689,611689, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {61 },
 new byte[]  { 0 },611691,611691, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {61 },
 new byte[]  { 0 },611693,611693, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {61 },
 new byte[]  { 0 },611695,611695, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {80 },
 new byte[]  { 0 },611697,611697, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {80 },
 new byte[]  { 0 },611699,611699, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {80 },
 new byte[]  { 0 },611701,611701, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {80 },
 new byte[]  { 0 },611703,611703, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {80 },
 new byte[]  { 0 },611705,611705, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {61 },
 new byte[]  { 0 },611707,611707, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {61 },
 new byte[]  { 0 },611709,611709, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {61 },
 new byte[]  { 0 },611711,611711, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {80 },
 new byte[]  { 0 },611713,611713, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {80 },
 new byte[]  { 0 },611715,611715, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {80 },
 new byte[]  { 0 },611717,611717, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {100 },
 new byte[]  { 0 },611747,611747, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {101 },
 new byte[]  { 0 },611749,611749, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {150 },
 new byte[]  { 0 },611751,611751, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {200 },
 new byte[]  { 0 },611753,611753, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {80 },
 new byte[]  { 0 },611755,611755, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {80 },
 new byte[]  { 0 },611757,611757, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {61 },
 new byte[]  { 0 },611759,611759, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {61 },
 new byte[]  { 0 },611761,611761, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {61 },
 new byte[]  { 0 },611763,611763, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {80 },
 new byte[]  { 0 },611765,611765, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {80 },
 new byte[]  { 0 },611767,611767, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {80 },
 new byte[]  { 0 },611769,611769, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {80 },
 new byte[]  { 0 },611771,611771, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {80 },
 new byte[]  { 0 },611773,611773, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {61 },
 new byte[]  { 0 },611775,611775, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {61 },
 new byte[]  { 0 },611777,611777, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {61 },
 new byte[]  { 0 },611779,611779, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {80 },
 new byte[]  { 0 },611781,611781, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {80 },
 new byte[]  { 0 },611783,611783, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {80 },
 new byte[]  { 0 },611785,611785, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {80 },
 new byte[]  { 0 },611787,611787, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {80 },
 new byte[]  { 0 },611789,611789, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {61 },
 new byte[]  { 0 },611791,611791, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {61 },
 new byte[]  { 0 },611793,611793, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {61 },
 new byte[]  { 0 },611795,611795, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {80 },
 new byte[]  { 0 },611797,611797, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {80 },
 new byte[]  { 0 },611799,611799, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {80 },
 new byte[]  { 0 },611801,611801, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {120 },
 new byte[]  { 0 },611803,611803, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {120 },
 new byte[]  { 0 },611805,611805, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {61 },
 new byte[]  { 0 },611807,611807, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {61 },
 new byte[]  { 0 },611809,611809, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {61 },
 new byte[]  { 0 },611811,611811, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {120 },
 new byte[]  { 0 },611813,611813, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {120 },
 new byte[]  { 0 },611815,611815, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {160 },
 new byte[]  { 0 },611817,611817, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {120 },
 new byte[]  { 0 },611819,611819, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {120 },
 new byte[]  { 0 },611821,611821, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {61 },
 new byte[]  { 0 },611823,611823, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {61 },
 new byte[]  { 0 },611825,611825, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {61 },
 new byte[]  { 0 },611827,611827, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {120 },
 new byte[]  { 0 },611829,611829, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {120 },
 new byte[]  { 0 },611831,611831, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {160 },
 new byte[]  { 0 },611833,611833, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {80 },
 new byte[]  { 0 },611835,611835, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {80 },
 new byte[]  { 0 },611837,611837, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {61 },
 new byte[]  { 0 },611839,611839, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {61 },
 new byte[]  { 0 },611841,611841, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {61 },
 new byte[]  { 0 },611843,611843, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {80 },
 new byte[]  { 0 },611845,611845, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {80 },
 new byte[]  { 0 },611847,611847, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {80 },
 new byte[]  { 0 },611849,611849, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {80 },
 new byte[]  { 0 },611851,611851, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {80 },
 new byte[]  { 0 },611853,611853, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {61 },
 new byte[]  { 0 },611855,611855, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {61 },
 new byte[]  { 0 },611857,611857, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {61 },
 new byte[]  { 0 },611859,611859, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {80 },
 new byte[]  { 0 },611861,611861, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {80 },
 new byte[]  { 0 },611863,611863, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {80 },
 new byte[]  { 0 },611865,611865, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {80 },
 new byte[]  { 0 },611867,611867, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {80 },
 new byte[]  { 0 },611869,611869, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {61 },
 new byte[]  { 0 },611871,611871, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {61 },
 new byte[]  { 0 },611873,611873, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {61 },
 new byte[]  { 0 },611875,611875, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {80 },
 new byte[]  { 0 },611877,611877, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {80 },
 new byte[]  { 0 },611879,611879, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {80 },
 new byte[]  { 0 },611881,611881, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {22 },
 new byte[]  { 0 },611919,611919, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {22 },
 new byte[]  { 0 },611921,611921, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },611923,611923, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },611925,611925, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },611927,611927, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },611929,611929, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },611931,611931, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },611933,611933, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {22 },
 new byte[]  { 0 },611935,611935, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {22 },
 new byte[]  { 0 },611937,611937, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },611939,611939, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },611941,611941, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },611943,611943, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },611945,611945, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },611947,611947, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },611949,611949, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {22 },
 new byte[]  { 0 },611951,611951, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {22 },
 new byte[]  { 0 },611953,611953, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },611955,611955, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },611957,611957, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },611959,611959, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },611961,611961, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },611963,611963, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },611965,611965, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {22 },
 new byte[]  { 0 },611967,611967, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {22 },
 new byte[]  { 0 },611969,611969, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },611971,611971, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },611973,611973, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },611975,611975, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },611977,611977, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },611979,611979, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },611981,611981, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {22 },
 new byte[]  { 0 },611983,611983, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {22 },
 new byte[]  { 0 },611985,611985, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },611987,611987, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },611989,611989, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },611991,611991, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },611993,611993, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },611995,611995, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },611997,611997, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {22 },
 new byte[]  { 0 },611999,611999, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {22 },
 new byte[]  { 0 },612001,612001, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },612003,612003, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },612005,612005, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },612007,612007, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },612009,612009, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },612011,612011, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },612013,612013, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {22 },
 new byte[]  { 0 },612015,612015, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {22 },
 new byte[]  { 0 },612017,612017, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },612019,612019, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },612021,612021, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },612023,612023, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },612025,612025, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },612027,612027, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },612029,612029, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {22 },
 new byte[]  { 0 },612031,612031, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {22 },
 new byte[]  { 0 },612033,612033, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },612035,612035, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },612037,612037, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },612039,612039, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },612041,612041, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },612043,612043, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },612045,612045, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {22 },
 new byte[]  { 0 },612083,612083, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {22 },
 new byte[]  { 0 },612085,612085, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },612087,612087, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },612089,612089, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },612091,612091, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },612093,612093, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },612095,612095, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },612097,612097, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {22 },
 new byte[]  { 0 },612099,612099, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {22 },
 new byte[]  { 0 },612101,612101, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },612103,612103, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },612105,612105, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },612107,612107, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },612109,612109, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },612111,612111, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },612113,612113, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {22 },
 new byte[]  { 0 },612115,612115, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {22 },
 new byte[]  { 0 },612117,612117, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },612119,612119, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },612121,612121, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },612123,612123, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },612125,612125, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },612127,612127, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },612129,612129, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {22 },
 new byte[]  { 0 },612131,612131, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {22 },
 new byte[]  { 0 },612133,612133, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },612135,612135, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },612137,612137, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },612139,612139, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },612141,612141, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },612143,612143, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },612145,612145, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {22 },
 new byte[]  { 0 },612147,612147, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {22 },
 new byte[]  { 0 },612149,612149, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },612151,612151, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },612153,612153, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },612155,612155, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },612157,612157, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },612159,612159, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },612161,612161, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {22 },
 new byte[]  { 0 },612163,612163, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {22 },
 new byte[]  { 0 },612165,612165, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },612167,612167, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },612169,612169, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },612171,612171, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },612173,612173, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },612175,612175, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },612177,612177, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {22 },
 new byte[]  { 0 },612179,612179, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {22 },
 new byte[]  { 0 },612181,612181, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },612183,612183, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },612185,612185, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },612187,612187, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },612189,612189, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },612191,612191, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },612193,612193, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {22 },
 new byte[]  { 0 },612195,612195, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {22 },
 new byte[]  { 0 },612197,612197, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },612199,612199, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },612201,612201, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },612203,612203, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },612205,612205, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },612207,612207, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },612209,612209, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {2 },
 new byte[]  { 0 },612501,612501, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {2 },
 new byte[]  { 0 },612503,612503, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {25 },
 new byte[]  { 0 },612507,612507, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {0,100,0,100,13,172,14,116,15,60,16,204,18,92,19,186,20,130,20,230,19,236,18,192,17,148,17,148 },
 new byte[]  { 31,31,31,31,31,31,31,31,31,31,31,31,31,31,31,31,31,31,31,31,31,31,31,31,31,31,31,31 },812284,812311, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {0,0,0,0,12,228,13,172,14,116,16,4,17,148,18,192,19,186,20,30,19,86,17,248,16,204,16,204 },
 new byte[]  { 31,31,31,31,31,31,31,31,31,31,31,31,31,31,31,31,31,31,31,31,31,31,31,31,31,31,31,31 },812386,812413, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,1 },
 new byte[]  { 0,0 },829471,829472, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {5,5,4,4,4,4 },
 new byte[]  { 0,0,0,0,0,0 },829482,829487, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,5 },
 new byte[]  { 0,0 },829489,829490, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {8 },
 new byte[]  { 0 },829492,829492, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {4 },
 new byte[]  { 0 },829494,829494, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,1,1,1,1 },
 new byte[]  { 0,0,0,0,0 },829496,829500, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1 },
 new byte[]  { 0 },829503,829503, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,1,1 },
 new byte[]  { 0,0,0 },829505,829507, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,1 },
 new byte[]  { 0,0 },829510,829511, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,1 },
 new byte[]  { 0,0 },829515,829516, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3 },
 new byte[]  { 0 },829538,829538, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,1,1,1 },
 new byte[]  { 0,0,0,0 },829540,829543, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3,14,5,2 },
 new byte[]  { 0,0,0,0 },829546,829549, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1 },
 new byte[]  { 0 },829551,829551, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,5 },
 new byte[]  { 0,0 },829553,829554, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {4,4 },
 new byte[]  { 0,0 },829556,829557, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {5,5,5,5,5,5,5,5,5,5,5,5,5,5 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0 },829561,829574, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3 },
 new byte[]  { 0 },829579,829579, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3 },
 new byte[]  { 0 },829581,829581, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3 },
 new byte[]  { 0 },829583,829583, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3 },
 new byte[]  { 0 },829585,829585, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3 },
 new byte[]  { 0 },829587,829587, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3 },
 new byte[]  { 0 },829589,829589, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3 },
 new byte[]  { 0 },829591,829591, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3 },
 new byte[]  { 0 },829593,829593, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3 },
 new byte[]  { 0 },829595,829595, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3 },
 new byte[]  { 0 },829602,829602, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3 },
 new byte[]  { 0 },829604,829604, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3 },
 new byte[]  { 0 },829606,829606, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3 },
 new byte[]  { 0 },829609,829609, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,1 },
 new byte[]  { 0,0 },829611,829612, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,5,4,4,4 },
 new byte[]  { 0,0,0,0,0 },829615,829619, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {5,4,4 },
 new byte[]  { 0,0,0 },829621,829623, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3,4 },
 new byte[]  { 0,0 },829625,829626, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,4,1,1 },
 new byte[]  { 0,0,0,0 },829638,829641, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,4,1 },
 new byte[]  { 0,0,0 },829643,829645, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {4 },
 new byte[]  { 0 },829647,829647, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,1,1,1,1,1 },
 new byte[]  { 0,0,0,0,0,0 },829649,829654, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {4,5,5,5 },
 new byte[]  { 0,0,0,0 },829657,829660, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {4,4,4,4 },
 new byte[]  { 0,0,0,0 },829664,829667, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {4,27,3,4 },
 new byte[]  { 0,0,0,0 },829669,829672, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {4,4,4,1,1,1 },
 new byte[]  { 0,0,0,0,0,0 },829674,829679, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {4 },
 new byte[]  { 0 },829681,829681, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {11 },
 new byte[]  { 0 },829683,829683, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {11,11,11 },
 new byte[]  { 0,0,0 },829685,829687, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {29 },
 new byte[]  { 0 },829690,829690, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {29 },
 new byte[]  { 0 },829692,829692, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {11 },
 new byte[]  { 0 },829694,829694, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {11,11,11 },
 new byte[]  { 0,0,0 },829696,829698, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {29 },
 new byte[]  { 0 },829701,829701, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {29 },
 new byte[]  { 0 },829703,829703, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {5,4,4 },
 new byte[]  { 0,0,0 },829706,829708, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,1,1,1,1,1,4,4,4,4,1,1,5 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0 },829711,829723, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {24,87,26,75,28,63,30,51,32,39,34,27,36,15,38,3,39,247,41,235,43,223,45,211,47,199,49,187,96,185 },
 new byte[]  { 22,99,22,99,22,99,22,99,22,99,22,99,22,99,22,99,22,99,22,99,22,99,22,99,22,99,22,99,22,99 },957988,958017, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {24,87,26,75,28,63,30,51,32,39,34,27,36,15,38,3,39,247,41,235,43,223,45,211,47,199,49,187,96,185 },
 new byte[]  { 22,99,22,99,22,99,22,99,22,99,22,99,22,99,22,99,22,99,22,99,22,99,22,99,22,99,22,99,22,99 },958094,958123, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {24,87,26,75,28,63,30,51,32,39,34,27,36,15,38,3,39,247,41,235,43,223,45,211,47,199,49,187,96,185 },
 new byte[]  { 22,99,22,99,22,99,22,99,22,99,22,99,22,99,22,99,22,99,22,99,22,99,22,99,22,99,22,99,22,99 },958228,958257, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {24,87,26,75,28,63,30,51,32,39,34,27,36,15,38,3,39,247,41,235,43,223,45,211,47,199,49,187,96,185 },
 new byte[]  { 22,99,22,99,22,99,22,99,22,99,22,99,22,99,22,99,22,99,22,99,22,99,22,99,22,99,22,99,22,99 },958334,958363, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {100 },
 new byte[]  { 0 },984155,984155, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {101 },
 new byte[]  { 0 },984157,984157, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {150 },
 new byte[]  { 0 },984159,984159, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {200 },
 new byte[]  { 0 },984161,984161, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {80 },
 new byte[]  { 0 },984163,984163, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {80 },
 new byte[]  { 0 },984165,984165, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {61 },
 new byte[]  { 0 },984167,984167, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {61 },
 new byte[]  { 0 },984169,984169, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {61 },
 new byte[]  { 0 },984171,984171, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {80 },
 new byte[]  { 0 },984173,984173, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {80 },
 new byte[]  { 0 },984175,984175, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {80 },
 new byte[]  { 0 },984177,984177, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {80 },
 new byte[]  { 0 },984179,984179, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {80 },
 new byte[]  { 0 },984181,984181, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {61 },
 new byte[]  { 0 },984183,984183, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {61 },
 new byte[]  { 0 },984185,984185, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {61 },
 new byte[]  { 0 },984187,984187, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {80 },
 new byte[]  { 0 },984189,984189, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {80 },
 new byte[]  { 0 },984191,984191, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {80 },
 new byte[]  { 0 },984193,984193, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {80 },
 new byte[]  { 0 },984195,984195, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {80 },
 new byte[]  { 0 },984197,984197, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {61 },
 new byte[]  { 0 },984199,984199, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {61 },
 new byte[]  { 0 },984201,984201, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {61 },
 new byte[]  { 0 },984203,984203, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {80 },
 new byte[]  { 0 },984205,984205, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {80 },
 new byte[]  { 0 },984207,984207, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {80 },
 new byte[]  { 0 },984209,984209, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {120 },
 new byte[]  { 0 },984211,984211, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {120 },
 new byte[]  { 0 },984213,984213, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {61 },
 new byte[]  { 0 },984215,984215, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {61 },
 new byte[]  { 0 },984217,984217, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {61 },
 new byte[]  { 0 },984219,984219, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {120 },
 new byte[]  { 0 },984221,984221, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {120 },
 new byte[]  { 0 },984223,984223, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {160 },
 new byte[]  { 0 },984225,984225, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {120 },
 new byte[]  { 0 },984227,984227, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {120 },
 new byte[]  { 0 },984229,984229, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {61 },
 new byte[]  { 0 },984231,984231, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {61 },
 new byte[]  { 0 },984233,984233, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {61 },
 new byte[]  { 0 },984235,984235, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {120 },
 new byte[]  { 0 },984237,984237, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {120 },
 new byte[]  { 0 },984239,984239, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {160 },
 new byte[]  { 0 },984241,984241, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {80 },
 new byte[]  { 0 },984243,984243, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {80 },
 new byte[]  { 0 },984245,984245, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {61 },
 new byte[]  { 0 },984247,984247, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {61 },
 new byte[]  { 0 },984249,984249, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {61 },
 new byte[]  { 0 },984251,984251, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {80 },
 new byte[]  { 0 },984253,984253, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {80 },
 new byte[]  { 0 },984255,984255, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {80 },
 new byte[]  { 0 },984257,984257, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {80 },
 new byte[]  { 0 },984259,984259, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {80 },
 new byte[]  { 0 },984261,984261, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {61 },
 new byte[]  { 0 },984263,984263, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {61 },
 new byte[]  { 0 },984265,984265, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {61 },
 new byte[]  { 0 },984267,984267, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {80 },
 new byte[]  { 0 },984269,984269, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {80 },
 new byte[]  { 0 },984271,984271, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {80 },
 new byte[]  { 0 },984273,984273, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {80 },
 new byte[]  { 0 },984275,984275, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {80 },
 new byte[]  { 0 },984277,984277, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {61 },
 new byte[]  { 0 },984279,984279, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {61 },
 new byte[]  { 0 },984281,984281, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {61 },
 new byte[]  { 0 },984283,984283, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {80 },
 new byte[]  { 0 },984285,984285, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {80 },
 new byte[]  { 0 },984287,984287, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {80 },
 new byte[]  { 0 },984289,984289, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {100 },
 new byte[]  { 0 },984319,984319, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {101 },
 new byte[]  { 0 },984321,984321, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {150 },
 new byte[]  { 0 },984323,984323, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {200 },
 new byte[]  { 0 },984325,984325, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {80 },
 new byte[]  { 0 },984327,984327, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {80 },
 new byte[]  { 0 },984329,984329, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {61 },
 new byte[]  { 0 },984331,984331, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {61 },
 new byte[]  { 0 },984333,984333, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {61 },
 new byte[]  { 0 },984335,984335, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {80 },
 new byte[]  { 0 },984337,984337, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {80 },
 new byte[]  { 0 },984339,984339, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {80 },
 new byte[]  { 0 },984341,984341, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {80 },
 new byte[]  { 0 },984343,984343, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {80 },
 new byte[]  { 0 },984345,984345, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {61 },
 new byte[]  { 0 },984347,984347, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {61 },
 new byte[]  { 0 },984349,984349, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {61 },
 new byte[]  { 0 },984351,984351, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {80 },
 new byte[]  { 0 },984353,984353, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {80 },
 new byte[]  { 0 },984355,984355, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {80 },
 new byte[]  { 0 },984357,984357, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {80 },
 new byte[]  { 0 },984359,984359, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {80 },
 new byte[]  { 0 },984361,984361, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {61 },
 new byte[]  { 0 },984363,984363, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {61 },
 new byte[]  { 0 },984365,984365, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {61 },
 new byte[]  { 0 },984367,984367, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {80 },
 new byte[]  { 0 },984369,984369, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {80 },
 new byte[]  { 0 },984371,984371, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {80 },
 new byte[]  { 0 },984373,984373, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {120 },
 new byte[]  { 0 },984375,984375, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {120 },
 new byte[]  { 0 },984377,984377, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {61 },
 new byte[]  { 0 },984379,984379, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {61 },
 new byte[]  { 0 },984381,984381, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {61 },
 new byte[]  { 0 },984383,984383, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {120 },
 new byte[]  { 0 },984385,984385, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {120 },
 new byte[]  { 0 },984387,984387, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {160 },
 new byte[]  { 0 },984389,984389, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {120 },
 new byte[]  { 0 },984391,984391, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {120 },
 new byte[]  { 0 },984393,984393, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {61 },
 new byte[]  { 0 },984395,984395, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {61 },
 new byte[]  { 0 },984397,984397, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {61 },
 new byte[]  { 0 },984399,984399, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {120 },
 new byte[]  { 0 },984401,984401, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {120 },
 new byte[]  { 0 },984403,984403, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {160 },
 new byte[]  { 0 },984405,984405, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {80 },
 new byte[]  { 0 },984407,984407, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {80 },
 new byte[]  { 0 },984409,984409, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {61 },
 new byte[]  { 0 },984411,984411, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {61 },
 new byte[]  { 0 },984413,984413, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {61 },
 new byte[]  { 0 },984415,984415, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {80 },
 new byte[]  { 0 },984417,984417, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {80 },
 new byte[]  { 0 },984419,984419, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {80 },
 new byte[]  { 0 },984421,984421, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {80 },
 new byte[]  { 0 },984423,984423, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {80 },
 new byte[]  { 0 },984425,984425, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {61 },
 new byte[]  { 0 },984427,984427, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {61 },
 new byte[]  { 0 },984429,984429, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {61 },
 new byte[]  { 0 },984431,984431, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {80 },
 new byte[]  { 0 },984433,984433, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {80 },
 new byte[]  { 0 },984435,984435, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {80 },
 new byte[]  { 0 },984437,984437, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {80 },
 new byte[]  { 0 },984439,984439, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {80 },
 new byte[]  { 0 },984441,984441, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {61 },
 new byte[]  { 0 },984443,984443, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {61 },
 new byte[]  { 0 },984445,984445, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {61 },
 new byte[]  { 0 },984447,984447, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {80 },
 new byte[]  { 0 },984449,984449, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {80 },
 new byte[]  { 0 },984451,984451, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {80 },
 new byte[]  { 0 },984453,984453, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {22 },
 new byte[]  { 0 },984491,984491, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {22 },
 new byte[]  { 0 },984493,984493, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },984495,984495, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },984497,984497, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },984499,984499, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },984501,984501, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },984503,984503, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },984505,984505, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {22 },
 new byte[]  { 0 },984507,984507, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {22 },
 new byte[]  { 0 },984509,984509, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },984511,984511, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },984513,984513, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },984515,984515, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },984517,984517, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },984519,984519, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },984521,984521, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {22 },
 new byte[]  { 0 },984523,984523, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {22 },
 new byte[]  { 0 },984525,984525, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },984527,984527, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },984529,984529, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },984531,984531, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },984533,984533, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },984535,984535, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },984537,984537, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {22 },
 new byte[]  { 0 },984539,984539, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {22 },
 new byte[]  { 0 },984541,984541, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },984543,984543, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },984545,984545, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },984547,984547, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },984549,984549, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },984551,984551, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },984553,984553, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {22 },
 new byte[]  { 0 },984555,984555, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {22 },
 new byte[]  { 0 },984557,984557, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },984559,984559, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },984561,984561, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },984563,984563, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },984565,984565, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },984567,984567, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },984569,984569, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {22 },
 new byte[]  { 0 },984571,984571, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {22 },
 new byte[]  { 0 },984573,984573, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },984575,984575, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },984577,984577, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },984579,984579, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },984581,984581, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },984583,984583, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },984585,984585, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {22 },
 new byte[]  { 0 },984587,984587, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {22 },
 new byte[]  { 0 },984589,984589, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },984591,984591, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },984593,984593, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },984595,984595, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },984597,984597, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },984599,984599, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },984601,984601, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {22 },
 new byte[]  { 0 },984603,984603, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {22 },
 new byte[]  { 0 },984605,984605, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },984607,984607, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },984609,984609, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },984611,984611, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },984613,984613, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },984615,984615, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },984617,984617, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {22 },
 new byte[]  { 0 },984655,984655, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {22 },
 new byte[]  { 0 },984657,984657, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },984659,984659, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },984661,984661, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },984663,984663, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },984665,984665, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },984667,984667, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },984669,984669, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {22 },
 new byte[]  { 0 },984671,984671, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {22 },
 new byte[]  { 0 },984673,984673, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },984675,984675, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },984677,984677, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },984679,984679, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },984681,984681, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },984683,984683, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },984685,984685, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {22 },
 new byte[]  { 0 },984687,984687, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {22 },
 new byte[]  { 0 },984689,984689, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },984691,984691, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },984693,984693, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },984695,984695, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },984697,984697, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },984699,984699, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },984701,984701, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {22 },
 new byte[]  { 0 },984703,984703, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {22 },
 new byte[]  { 0 },984705,984705, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },984707,984707, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },984709,984709, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },984711,984711, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },984713,984713, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },984715,984715, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },984717,984717, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {22 },
 new byte[]  { 0 },984719,984719, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {22 },
 new byte[]  { 0 },984721,984721, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },984723,984723, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },984725,984725, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },984727,984727, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },984729,984729, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },984731,984731, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },984733,984733, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {22 },
 new byte[]  { 0 },984735,984735, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {22 },
 new byte[]  { 0 },984737,984737, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },984739,984739, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },984741,984741, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },984743,984743, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },984745,984745, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },984747,984747, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },984749,984749, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {22 },
 new byte[]  { 0 },984751,984751, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {22 },
 new byte[]  { 0 },984753,984753, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },984755,984755, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },984757,984757, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },984759,984759, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },984761,984761, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },984763,984763, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },984765,984765, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {22 },
 new byte[]  { 0 },984767,984767, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {22 },
 new byte[]  { 0 },984769,984769, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },984771,984771, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },984773,984773, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },984775,984775, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },984777,984777, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },984779,984779, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },984781,984781, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {2 },
 new byte[]  { 0 },985305,985305, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {2 },
 new byte[]  { 0 },985307,985307, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {25 },
 new byte[]  { 0 },985311,985311, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1 },
 new byte[]  { 0 },989301,989301, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {32 },
 new byte[]  { 0 },989307,989307, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64 },
 new byte[]  { 0 },989311,989311, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {128 },
 new byte[]  { 0 },989315,989315, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1 },
 new byte[]  { 0 },989318,989318, "Found dpf map...Delete map");
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