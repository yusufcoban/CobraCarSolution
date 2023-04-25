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
  class VAG_EDC17CP14 : MenuItem, ITreeItem  {
    public VAG_EDC17CP14()  {
      Title = "VAG_EDC17CP14";
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
		validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {164,6,164,6,164,6,38,2,38,2,38,2,38,2,38,2,38,2,38,2,38,2,38,2,38,2,38,2,38,2,38,2,38,2,38,2,38,2,38,2,38,2,38,2,38,2 },  326094    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {100 },  326178    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {8,7,8,7,8,7,8,7,240,10,84,11,104,11,78,12,72,13,16,14,16,14,16,14,196,9,196,9,100 },  326180    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {100 },  326210    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {100 },  326212    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {38,2,38,2,38,2,38,2,38,2,38,2,38,2,38,2,38,2,38,2,38,2,38,2,38,2,38,2 },  326214    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {120,5,120,5,120,5,144,1,144,1,144,1,144,1,144,1,144,1,144,1,144,1,144,1,144,1,144,1,144,1,144,1,144,1,144,1,144,1,144,1,144,1,144,1,144,1 },  326298    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {164,6,164,6,164,6,164,6,140,10,240,10,240,10,114,11,228,12,172,13,172,13,172,13,172,13,96,9,96,9 },  326386    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {144,1,144,1,144,1,144,1,144,1,144,1,144,1,144,1,144,1,144,1,144,1,144,1 },  326422    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {120,5,120,5,120,5,144,1,144,1,144,1,144,1,144,1,144,1,144,1,144,1,144,1,144,1,144,1,144,1,144,1,144,1,144,1,144,1,144,1,144,1,144,1,144,1 },  372072    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {164,6,164,6,164,6,38,2,38,2,38,2,38,2,38,2,38,2,38,2,38,2,38,2,38,2,38,2,38,2,38,2,38,2,38,2,38,2,38,2,38,2,38,2,38,2 },  372174    );
      }
      return validationEgrInFile;
    }
    public override async Task < bool > checkFileForDpf()  {
      bool validationEgrInFile = true;
      //Algo for checking dpf solution
      if (ToolBox.array.Length > 0)  {
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,1,1,1,1,3,3,3,3,1,1,1,1,4,4,4,4 },  346759    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,1,4,4,1,1,1,1,1,1,1,1,1,1,1,1,2,2,3,3,11,1,1,1,1,1,1,1 },  346777    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,1,1,1,1,1,1,1,1,1,1,1,1 },  346807    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3,3,1,1 },  346835    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,1,1,3,3,3,1,1,1,1,1,3,3,3,3,3 },  346840    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3,3,1,1,1,1,1,4,4,1,3,1,1,1,1,4,2,2,2,2,3,1,3,3,4,3,3,3,3,4,1,1,1,1,1,1,1,1,1,1,1,2,3,3 },  346857    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {4,4,4,4,4,4,4,4,4,4,4,1,4,4,4,4,4,3,3,3,3,3,1,3 },  346903    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3,3,3,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1 },  346928    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,1,3,1,3,1,1,1,2,3,2,3,3,3,3,3,3,3,3,3,3,3,3,3,3,1,3,3,3,1,3,3,1,3,1,1,1,1,4,1,1,1,1,2,1,1,11,11,11,11,1,1,1,1 },  346947    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3,1,1 },  347002    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,3,1,1 },  347006    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,4,3,3,5,5,3,2,2,2,2,3,1,1,1,1,1,1,1,1,3,3,3,1,1,1,1,1 },  347022    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,3,1,1,1,1,1,1,1,4,4,1,1,1,1,1,1,1 },  347052    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,1,1 },  347071    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {51,1,7,6,7,6 },  349400    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {149,33,149,33 },  349408    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {150,33 },  349414    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {33 },  349425    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {33,1 },  349434    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {6 },  349459    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {6 },  349469    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {6 },  349477    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {6 },  349479    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {6 },  349493    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {6 },  349495    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {128,32,132,32,43,36,82,2,82,2,129,1 },  349500    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {7,6 },  349520    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3 },  349535    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {113,4,113,4,2,32 },  349538    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {22,1 },  349560    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {4,4,4,4 },  349576    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {38,7,38,7 },  349602    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {7,6,7,6,7,6 },  349610    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {18,33 },  349662    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3 },  469552    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3 },  469554    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3 },  469566    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3 },  469568    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3 },  469580    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3 },  469582    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3 },  469594    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3 },  469596    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3 },  469608    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3 },  469610    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1 },  469620    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {2 },  469622    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3 },  469624    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {6 },  469626    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3 },  469638    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1 },  469648    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {2 },  469650    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {4 },  469652    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {6 },  469654    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1 },  469662    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {2 },  469664    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {4 },  469666    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {6 },  469668    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1 },  469676    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {2 },  469678    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {4 },  469680    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {6 },  469682    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1 },  469690    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {2 },  469692    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {4 },  469694    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {6 },  469696    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1 },  469704    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {2 },  469706    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {4 },  469708    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {6 },  469710    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3 },  469762    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3 },  469764    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3 },  469776    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3 },  469778    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3 },  469790    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3 },  469792    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3 },  469804    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3 },  469806    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3 },  469818    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3 },  469820    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1 },  469830    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {2 },  469832    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3 },  469834    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {6 },  469836    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3 },  469848    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1 },  469858    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {2 },  469860    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {4 },  469862    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {6 },  469864    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1 },  469872    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {2 },  469874    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {4 },  469876    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {6 },  469878    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1 },  469886    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {2 },  469888    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {4 },  469890    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {6 },  469892    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1 },  469900    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {2 },  469902    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {4 },  469904    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {6 },  469906    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1 },  469914    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {2 },  469916    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {4 },  469918    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {6 },  469920    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3 },  469972    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3 },  469974    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3 },  469986    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3 },  469988    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3 },  470000    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3 },  470002    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3 },  470014    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3 },  470016    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3 },  470028    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3 },  470030    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1 },  470040    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {2 },  470042    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3 },  470044    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {6 },  470046    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3 },  470058    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1 },  470068    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {2 },  470070    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {4 },  470072    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {6 },  470074    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1 },  470082    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {2 },  470084    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {4 },  470086    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {6 },  470088    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1 },  470096    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {2 },  470098    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {4 },  470100    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {6 },  470102    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1 },  470110    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {2 },  470112    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {4 },  470114    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {6 },  470116    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1 },  470124    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {2 },  470126    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {4 },  470128    );
      }
      return validationEgrInFile;

    }
    public override async Task < bool > checkFileForTva()  {
      bool validationEgrInFile = false;  if (ToolBox.array.Length > 0)  {} return validationEgrInFile;
    }

    public override async Task < bool > checkFileForLamda()  {
      bool validationEgrInFile = false;  if (ToolBox.array.Length > 0)  {} return validationEgrInFile;
    }

    public override async Task < bool > checkFileForFlaps()  {
      bool validationEgrInFile = false;  if (ToolBox.array.Length > 0)  {} return validationEgrInFile;
    }

    public override async Task < bool > checkFileForStartStop()  {
      bool validationEgrInFile = false;  if (ToolBox.array.Length > 0)  {} return validationEgrInFile;
    }

    public override async Task < bool > checkFileForAdBlue()  {
      bool validationEgrInFile = false;  if (ToolBox.array.Length > 0)  {} return validationEgrInFile;
    }

    public override async Task < bool > checkFileForReadiness()  {
      bool validationEgrInFile = false;  if (ToolBox.array.Length > 0)  {} return validationEgrInFile;
    }

    public override async Task < bool > checkFileForImmo()  {
      bool validationEgrInFile = false;  if (ToolBox.array.Length > 0)  {} return validationEgrInFile;
    }

    public override async Task < bool > checkFileForSpecialI()  {
      bool validationEgrInFile = false;  if (ToolBox.array.Length > 0)  {} return validationEgrInFile;
    }

    public override async Task < bool > checkFileForSpecialII()  {
      bool validationEgrInFile = false;  if (ToolBox.array.Length > 0)  {} return validationEgrInFile;
    }

    public override async Task < bool > checkFileForSpecialIII()  {
      bool validationEgrInFile = false;  if (ToolBox.array.Length > 0)  {} return validationEgrInFile;
    }

    public override void egrOffSolution()  {
	ToolBox.ReplaceInFileWithStartStop(new byte[]  {164,6,164,6,164,6,38,2,38,2,38,2,38,2,38,2,38,2,38,2,38,2,38,2,38,2,38,2,38,2,38,2,38,2,38,2,38,2,38,2,38,2,38,2,38,2 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },326094,326139, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {100 },
 new byte[]  { 0 },326178,326178, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {8,7,8,7,8,7,8,7,240,10,84,11,104,11,78,12,72,13,16,14,16,14,16,14,196,9,196,9,100 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },326180,326208, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {100 },
 new byte[]  { 0 },326210,326210, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {100 },
 new byte[]  { 0 },326212,326212, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {38,2,38,2,38,2,38,2,38,2,38,2,38,2,38,2,38,2,38,2,38,2,38,2,38,2,38,2 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },326214,326241, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {120,5,120,5,120,5,144,1,144,1,144,1,144,1,144,1,144,1,144,1,144,1,144,1,144,1,144,1,144,1,144,1,144,1,144,1,144,1,144,1,144,1,144,1,144,1 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },326298,326343, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {164,6,164,6,164,6,164,6,140,10,240,10,240,10,114,11,228,12,172,13,172,13,172,13,172,13,96,9,96,9 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },326386,326415, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {144,1,144,1,144,1,144,1,144,1,144,1,144,1,144,1,144,1,144,1,144,1,144,1 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },326422,326445, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {120,5,120,5,120,5,144,1,144,1,144,1,144,1,144,1,144,1,144,1,144,1,144,1,144,1,144,1,144,1,144,1,144,1,144,1,144,1,144,1,144,1,144,1,144,1 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },372072,372117, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {164,6,164,6,164,6,38,2,38,2,38,2,38,2,38,2,38,2,38,2,38,2,38,2,38,2,38,2,38,2,38,2,38,2,38,2,38,2,38,2,38,2,38,2,38,2 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },372174,372219, "Found egr map...Delete map");
      base.egrOffSolution();
    }
    public override void dpfOffSolution()  {
	ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,1,1,1,1,3,3,3,3,1,1,1,1,4,4,4,4 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },346759,346775, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,1,4,4,1,1,1,1,1,1,1,1,1,1,1,1,2,2,3,3,11,1,1,1,1,1,1,1 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },346777,346804, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,1,1,1,1,1,1,1,1,1,1,1,1 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },346807,346833, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3,3,1,1 },
 new byte[]  { 0,0,0,0 },346835,346838, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,1,1,3,3,3,1,1,1,1,1,3,3,3,3,3 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },346840,346855, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3,3,1,1,1,1,1,4,4,1,3,1,1,1,1,4,2,2,2,2,3,1,3,3,4,3,3,3,3,4,1,1,1,1,1,1,1,1,1,1,1,2,3,3 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },346857,346900, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {4,4,4,4,4,4,4,4,4,4,4,1,4,4,4,4,4,3,3,3,3,3,1,3 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },346903,346926, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3,3,3,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },346928,346945, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,1,3,1,3,1,1,1,2,3,2,3,3,3,3,3,3,3,3,3,3,3,3,3,3,1,3,3,3,1,3,3,1,3,1,1,1,1,4,1,1,1,1,2,1,1,11,11,11,11,1,1,1,1 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },346947,347000, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3,1,1 },
 new byte[]  { 0,0,0 },347002,347004, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,3,1,1 },
 new byte[]  { 0,0,0,0 },347006,347009, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,4,3,3,5,5,3,2,2,2,2,3,1,1,1,1,1,1,1,1,3,3,3,1,1,1,1,1 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },347022,347049, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,3,1,1,1,1,1,1,1,4,4,1,1,1,1,1,1,1 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },347052,347069, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,1,1 },
 new byte[]  { 0,0,0 },347071,347073, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {51,1,7,6,7,6 },
 new byte[]  { 0,0,0,0,0,0 },349400,349405, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {149,33,149,33 },
 new byte[]  { 0,0,0,0 },349408,349411, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {150,33 },
 new byte[]  { 0,0 },349414,349415, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {33 },
 new byte[]  { 0 },349425,349425, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {33,1 },
 new byte[]  { 0,0 },349434,349435, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {6 },
 new byte[]  { 0 },349459,349459, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {6 },
 new byte[]  { 0 },349469,349469, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {6 },
 new byte[]  { 0 },349477,349477, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {6 },
 new byte[]  { 0 },349479,349479, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {6 },
 new byte[]  { 0 },349493,349493, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {6 },
 new byte[]  { 0 },349495,349495, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {128,32,132,32,43,36,82,2,82,2,129,1 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0 },349500,349511, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {7,6 },
 new byte[]  { 0,0 },349520,349521, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3 },
 new byte[]  { 0 },349535,349535, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {113,4,113,4,2,32 },
 new byte[]  { 0,0,0,0,0,0 },349538,349543, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {22,1 },
 new byte[]  { 0,0 },349560,349561, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {4,4,4,4 },
 new byte[]  { 0,0,0,0 },349576,349579, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {38,7,38,7 },
 new byte[]  { 0,0,0,0 },349602,349605, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {7,6,7,6,7,6 },
 new byte[]  { 0,0,0,0,0,0 },349610,349615, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {18,33 },
 new byte[]  { 0,0 },349662,349663, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3 },
 new byte[]  { 0 },469552,469552, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3 },
 new byte[]  { 0 },469554,469554, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3 },
 new byte[]  { 0 },469566,469566, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3 },
 new byte[]  { 0 },469568,469568, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3 },
 new byte[]  { 0 },469580,469580, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3 },
 new byte[]  { 0 },469582,469582, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3 },
 new byte[]  { 0 },469594,469594, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3 },
 new byte[]  { 0 },469596,469596, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3 },
 new byte[]  { 0 },469608,469608, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3 },
 new byte[]  { 0 },469610,469610, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1 },
 new byte[]  { 0 },469620,469620, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {2 },
 new byte[]  { 0 },469622,469622, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3 },
 new byte[]  { 0 },469624,469624, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {6 },
 new byte[]  { 0 },469626,469626, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3 },
 new byte[]  { 0 },469638,469638, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1 },
 new byte[]  { 0 },469648,469648, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {2 },
 new byte[]  { 0 },469650,469650, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {4 },
 new byte[]  { 0 },469652,469652, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {6 },
 new byte[]  { 0 },469654,469654, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1 },
 new byte[]  { 0 },469662,469662, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {2 },
 new byte[]  { 0 },469664,469664, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {4 },
 new byte[]  { 0 },469666,469666, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {6 },
 new byte[]  { 0 },469668,469668, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1 },
 new byte[]  { 0 },469676,469676, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {2 },
 new byte[]  { 0 },469678,469678, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {4 },
 new byte[]  { 0 },469680,469680, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {6 },
 new byte[]  { 0 },469682,469682, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1 },
 new byte[]  { 0 },469690,469690, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {2 },
 new byte[]  { 0 },469692,469692, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {4 },
 new byte[]  { 0 },469694,469694, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {6 },
 new byte[]  { 0 },469696,469696, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1 },
 new byte[]  { 0 },469704,469704, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {2 },
 new byte[]  { 0 },469706,469706, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {4 },
 new byte[]  { 0 },469708,469708, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {6 },
 new byte[]  { 0 },469710,469710, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3 },
 new byte[]  { 0 },469762,469762, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3 },
 new byte[]  { 0 },469764,469764, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3 },
 new byte[]  { 0 },469776,469776, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3 },
 new byte[]  { 0 },469778,469778, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3 },
 new byte[]  { 0 },469790,469790, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3 },
 new byte[]  { 0 },469792,469792, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3 },
 new byte[]  { 0 },469804,469804, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3 },
 new byte[]  { 0 },469806,469806, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3 },
 new byte[]  { 0 },469818,469818, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3 },
 new byte[]  { 0 },469820,469820, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1 },
 new byte[]  { 0 },469830,469830, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {2 },
 new byte[]  { 0 },469832,469832, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3 },
 new byte[]  { 0 },469834,469834, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {6 },
 new byte[]  { 0 },469836,469836, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3 },
 new byte[]  { 0 },469848,469848, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1 },
 new byte[]  { 0 },469858,469858, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {2 },
 new byte[]  { 0 },469860,469860, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {4 },
 new byte[]  { 0 },469862,469862, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {6 },
 new byte[]  { 0 },469864,469864, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1 },
 new byte[]  { 0 },469872,469872, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {2 },
 new byte[]  { 0 },469874,469874, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {4 },
 new byte[]  { 0 },469876,469876, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {6 },
 new byte[]  { 0 },469878,469878, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1 },
 new byte[]  { 0 },469886,469886, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {2 },
 new byte[]  { 0 },469888,469888, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {4 },
 new byte[]  { 0 },469890,469890, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {6 },
 new byte[]  { 0 },469892,469892, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1 },
 new byte[]  { 0 },469900,469900, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {2 },
 new byte[]  { 0 },469902,469902, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {4 },
 new byte[]  { 0 },469904,469904, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {6 },
 new byte[]  { 0 },469906,469906, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1 },
 new byte[]  { 0 },469914,469914, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {2 },
 new byte[]  { 0 },469916,469916, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {4 },
 new byte[]  { 0 },469918,469918, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {6 },
 new byte[]  { 0 },469920,469920, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3 },
 new byte[]  { 0 },469972,469972, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3 },
 new byte[]  { 0 },469974,469974, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3 },
 new byte[]  { 0 },469986,469986, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3 },
 new byte[]  { 0 },469988,469988, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3 },
 new byte[]  { 0 },470000,470000, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3 },
 new byte[]  { 0 },470002,470002, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3 },
 new byte[]  { 0 },470014,470014, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3 },
 new byte[]  { 0 },470016,470016, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3 },
 new byte[]  { 0 },470028,470028, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3 },
 new byte[]  { 0 },470030,470030, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1 },
 new byte[]  { 0 },470040,470040, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {2 },
 new byte[]  { 0 },470042,470042, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3 },
 new byte[]  { 0 },470044,470044, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {6 },
 new byte[]  { 0 },470046,470046, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3 },
 new byte[]  { 0 },470058,470058, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1 },
 new byte[]  { 0 },470068,470068, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {2 },
 new byte[]  { 0 },470070,470070, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {4 },
 new byte[]  { 0 },470072,470072, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {6 },
 new byte[]  { 0 },470074,470074, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1 },
 new byte[]  { 0 },470082,470082, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {2 },
 new byte[]  { 0 },470084,470084, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {4 },
 new byte[]  { 0 },470086,470086, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {6 },
 new byte[]  { 0 },470088,470088, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1 },
 new byte[]  { 0 },470096,470096, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {2 },
 new byte[]  { 0 },470098,470098, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {4 },
 new byte[]  { 0 },470100,470100, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {6 },
 new byte[]  { 0 },470102,470102, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1 },
 new byte[]  { 0 },470110,470110, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {2 },
 new byte[]  { 0 },470112,470112, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {4 },
 new byte[]  { 0 },470114,470114, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {6 },
 new byte[]  { 0 },470116,470116, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1 },
 new byte[]  { 0 },470124,470124, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {2 },
 new byte[]  { 0 },470126,470126, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {4 },
 new byte[]  { 0 },470128,470128, "Found dpf map...Delete map");
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