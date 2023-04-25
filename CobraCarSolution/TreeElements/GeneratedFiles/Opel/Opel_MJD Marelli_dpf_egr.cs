using System.Collections.Generic;
using System.Threading.Tasks;

using ToolBoxNameSpace;


namespace CobraCarSolution.TreeElements.VAG
{
    class Opel_MJD_Marelli :MenuItem, ITreeItem  {
    public Opel_MJD_Marelli()  {
      Title = "Opel_MJD_Marelli";
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
		validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {59,204,196,51 },  524458    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {79,9,176,246 },  524500    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {39 },  526975    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {39 },  526999    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {39 },  527011    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {2 },  527084    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {50 },  527087    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {50 },  527089    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {50 },  527091    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {25,3,159 },  527093    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,244,3,32,3,32,1,244 },  527098    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {39 },  527107    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,244,3,32,3,32,1,244,3,159 },  527410    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {10,1,124,1,44,1,14 },  527747    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {43 },  527755    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,44,1,124,1,44,1,14 },  527770    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {35 },  527779    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {39 },  528271    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {47 },  528283    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {9 },  528295    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {15 },  528319    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {43 },  528343    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {41 },  528367    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {43 },  528451    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1 },  541732    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1 },  541750    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1 },  541762    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1 },  541792    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,1 },  541840    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1 },  541856    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1 },  541868    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {55,172 },  542352    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {177 },  559371    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,1,1,1,1 },  559389    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,1,1,1 },  559398    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,1,1 },  559407    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,1 },  559416    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1 },  559425    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1 },  559441    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,1,1 },  559471    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {2,28,2,28,2,28,2,28,2,28,2,28,2,28,2,28,2,28,2,28,2,28,1,224,2,28,3,252,3,250,3,247,3,245,3,247,3,248,3,248,3,232,4,6,7,208,3,252,3,252,3,252 },  559476    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {17,145 },  568556    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {17,144,17,145 },  568560    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {4,3,4 },  568576    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {4 },  568630    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {37,63 },  568686    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {37,63 },  568690    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {25,2,25,1,25,1 },  568772    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {25,1 },  568780    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {25,1,25 },  568784    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {25 },  568788    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {25,2 },  568794    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {32,3 },  568802    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {4,3 },  568948    );
      }
      return validationEgrInFile;
    }
    public override async Task < bool > checkFileForDpf()  {
      bool validationEgrInFile = true;
      //Algo for checking dpf solution
      if (ToolBox.array.Length > 0)  {
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {59,204,196,51 },  524458    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {79,9,176,246 },  524500    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {39 },  526975    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {39 },  526999    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {39 },  527011    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {2 },  527084    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {50 },  527087    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {50 },  527089    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {50 },  527091    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {25,3,159 },  527093    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,244,3,32,3,32,1,244 },  527098    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {39 },  527107    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,244,3,32,3,32,1,244,3,159 },  527410    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {10,1,124,1,44,1,14 },  527747    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {43 },  527755    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,44,1,124,1,44,1,14 },  527770    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {35 },  527779    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {39 },  528271    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {47 },  528283    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {9 },  528295    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {15 },  528319    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {43 },  528343    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {41 },  528367    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {43 },  528451    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1 },  541732    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1 },  541750    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1 },  541762    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1 },  541792    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,1 },  541840    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1 },  541856    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1 },  541868    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {55,172 },  542352    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {177 },  559371    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,1,1,1,1 },  559389    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,1,1,1 },  559398    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,1,1 },  559407    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,1 },  559416    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1 },  559425    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1 },  559441    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,1,1 },  559471    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {2,28,2,28,2,28,2,28,2,28,2,28,2,28,2,28,2,28,2,28,2,28,1,224,2,28,3,252,3,250,3,247,3,245,3,247,3,248,3,248,3,232,4,6,7,208,3,252,3,252,3,252 },  559476    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {17,145 },  568556    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {17,144,17,145 },  568560    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {4,3,4 },  568576    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {4 },  568630    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {37,63 },  568686    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {37,63 },  568690    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {25,2,25,1,25,1 },  568772    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {25,1 },  568780    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {25,1,25 },  568784    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {25 },  568788    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {25,2 },  568794    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {32,3 },  568802    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {4,3 },  568948    );
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
	ToolBox.ReplaceInFileWithStartStop(new byte[]  {59,204,196,51 },
 new byte[]  { 32,188,223,67 },524458,524461, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {79,9,176,246 },
 new byte[]  { 205,97,50,158 },524500,524503, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {39 },
 new byte[]  { 14 },526975,526975, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {39 },
 new byte[]  { 14 },526999,526999, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {39 },
 new byte[]  { 14 },527011,527011, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {2 },
 new byte[]  { 1 },527084,527084, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {50 },
 new byte[]  { 0 },527087,527087, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {50 },
 new byte[]  { 1 },527089,527089, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {50 },
 new byte[]  { 1 },527091,527091, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {25,3,159 },
 new byte[]  { 0,0,14 },527093,527095, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,244,3,32,3,32,1,244 },
 new byte[]  { 0,0,0,1,0,1,0,0 },527098,527105, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {39 },
 new byte[]  { 14 },527107,527107, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,244,3,32,3,32,1,244,3,159 },
 new byte[]  { 0,0,0,1,0,1,0,0,0,14 },527410,527419, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {10,1,124,1,44,1,14 },
 new byte[]  { 0,0,1,0,1,0,0 },527747,527753, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {43 },
 new byte[]  { 14 },527755,527755, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,44,1,124,1,44,1,14 },
 new byte[]  { 0,0,0,1,0,1,0,0 },527770,527777, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {35 },
 new byte[]  { 4 },527779,527779, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {39 },
 new byte[]  { 14 },528271,528271, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {47 },
 new byte[]  { 14 },528283,528283, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {9 },
 new byte[]  { 14 },528295,528295, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {15 },
 new byte[]  { 14 },528319,528319, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {43 },
 new byte[]  { 14 },528343,528343, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {41 },
 new byte[]  { 14 },528367,528367, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {43 },
 new byte[]  { 14 },528451,528451, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1 },
 new byte[]  { 0 },541732,541732, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1 },
 new byte[]  { 0 },541750,541750, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1 },
 new byte[]  { 0 },541762,541762, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1 },
 new byte[]  { 0 },541792,541792, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,1 },
 new byte[]  { 0,0 },541840,541841, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1 },
 new byte[]  { 0 },541856,541856, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1 },
 new byte[]  { 0 },541868,541868, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {55,172 },
 new byte[]  { 185,146 },542352,542353, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {177 },
 new byte[]  { 0 },559371,559371, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,1,1,1,1 },
 new byte[]  { 0,0,0,0,0 },559389,559393, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,1,1,1 },
 new byte[]  { 0,0,0,0 },559398,559401, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,1,1 },
 new byte[]  { 0,0,0 },559407,559409, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,1 },
 new byte[]  { 0,0 },559416,559417, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1 },
 new byte[]  { 0 },559425,559425, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1 },
 new byte[]  { 0 },559441,559441, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,1,1 },
 new byte[]  { 0,0,0 },559471,559473, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {2,28,2,28,2,28,2,28,2,28,2,28,2,28,2,28,2,28,2,28,2,28,1,224,2,28,3,252,3,250,3,247,3,245,3,247,3,248,3,248,3,232,4,6,7,208,3,252,3,252,3,252 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },559476,559527, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {17,145 },
 new byte[]  { 0,0 },568556,568557, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {17,144,17,145 },
 new byte[]  { 0,0,0,0 },568560,568563, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {4,3,4 },
 new byte[]  { 0,0,0 },568576,568578, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {4 },
 new byte[]  { 0 },568630,568630, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {37,63 },
 new byte[]  { 0,0 },568686,568687, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {37,63 },
 new byte[]  { 0,0 },568690,568691, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {25,2,25,1,25,1 },
 new byte[]  { 0,0,0,0,0,0 },568772,568777, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {25,1 },
 new byte[]  { 0,0 },568780,568781, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {25,1,25 },
 new byte[]  { 0,0,0 },568784,568786, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {25 },
 new byte[]  { 0 },568788,568788, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {25,2 },
 new byte[]  { 0,0 },568794,568795, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {32,3 },
 new byte[]  { 0,0 },568802,568803, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {4,3 },
 new byte[]  { 0,0 },568948,568949, "Found egr map...Delete map");
      base.egrOffSolution();
    }
    public override void dpfOffSolution()  {
	ToolBox.ReplaceInFileWithStartStop(new byte[]  {59,204,196,51 },
 new byte[]  { 32,188,223,67 },524458,524461, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {79,9,176,246 },
 new byte[]  { 205,97,50,158 },524500,524503, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {39 },
 new byte[]  { 14 },526975,526975, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {39 },
 new byte[]  { 14 },526999,526999, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {39 },
 new byte[]  { 14 },527011,527011, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {2 },
 new byte[]  { 1 },527084,527084, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {50 },
 new byte[]  { 0 },527087,527087, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {50 },
 new byte[]  { 1 },527089,527089, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {50 },
 new byte[]  { 1 },527091,527091, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {25,3,159 },
 new byte[]  { 0,0,14 },527093,527095, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,244,3,32,3,32,1,244 },
 new byte[]  { 0,0,0,1,0,1,0,0 },527098,527105, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {39 },
 new byte[]  { 14 },527107,527107, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,244,3,32,3,32,1,244,3,159 },
 new byte[]  { 0,0,0,1,0,1,0,0,0,14 },527410,527419, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {10,1,124,1,44,1,14 },
 new byte[]  { 0,0,1,0,1,0,0 },527747,527753, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {43 },
 new byte[]  { 14 },527755,527755, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,44,1,124,1,44,1,14 },
 new byte[]  { 0,0,0,1,0,1,0,0 },527770,527777, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {35 },
 new byte[]  { 4 },527779,527779, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {39 },
 new byte[]  { 14 },528271,528271, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {47 },
 new byte[]  { 14 },528283,528283, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {9 },
 new byte[]  { 14 },528295,528295, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {15 },
 new byte[]  { 14 },528319,528319, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {43 },
 new byte[]  { 14 },528343,528343, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {41 },
 new byte[]  { 14 },528367,528367, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {43 },
 new byte[]  { 14 },528451,528451, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1 },
 new byte[]  { 0 },541732,541732, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1 },
 new byte[]  { 0 },541750,541750, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1 },
 new byte[]  { 0 },541762,541762, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1 },
 new byte[]  { 0 },541792,541792, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,1 },
 new byte[]  { 0,0 },541840,541841, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1 },
 new byte[]  { 0 },541856,541856, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1 },
 new byte[]  { 0 },541868,541868, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {55,172 },
 new byte[]  { 185,146 },542352,542353, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {177 },
 new byte[]  { 0 },559371,559371, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,1,1,1,1 },
 new byte[]  { 0,0,0,0,0 },559389,559393, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,1,1,1 },
 new byte[]  { 0,0,0,0 },559398,559401, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,1,1 },
 new byte[]  { 0,0,0 },559407,559409, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,1 },
 new byte[]  { 0,0 },559416,559417, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1 },
 new byte[]  { 0 },559425,559425, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1 },
 new byte[]  { 0 },559441,559441, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,1,1 },
 new byte[]  { 0,0,0 },559471,559473, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {2,28,2,28,2,28,2,28,2,28,2,28,2,28,2,28,2,28,2,28,2,28,1,224,2,28,3,252,3,250,3,247,3,245,3,247,3,248,3,248,3,232,4,6,7,208,3,252,3,252,3,252 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },559476,559527, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {17,145 },
 new byte[]  { 0,0 },568556,568557, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {17,144,17,145 },
 new byte[]  { 0,0,0,0 },568560,568563, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {4,3,4 },
 new byte[]  { 0,0,0 },568576,568578, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {4 },
 new byte[]  { 0 },568630,568630, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {37,63 },
 new byte[]  { 0,0 },568686,568687, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {37,63 },
 new byte[]  { 0,0 },568690,568691, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {25,2,25,1,25,1 },
 new byte[]  { 0,0,0,0,0,0 },568772,568777, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {25,1 },
 new byte[]  { 0,0 },568780,568781, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {25,1,25 },
 new byte[]  { 0,0,0 },568784,568786, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {25 },
 new byte[]  { 0 },568788,568788, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {25,2 },
 new byte[]  { 0,0 },568794,568795, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {32,3 },
 new byte[]  { 0,0 },568802,568803, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {4,3 },
 new byte[]  { 0,0 },568948,568949, "Found dpf map...Delete map");
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