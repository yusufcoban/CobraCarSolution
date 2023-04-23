/*using ToolBoxNameSpace;
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
  class EcuName :MenuItem, ITreeItem  {
    public EcuName()  {
      Title = "EcuName";
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
      FileSizeArray = new int[]  {  0 };
    }

    public override async Task < bool > checkFileForEgr()  {
      bool validationEgrInFile = true;
      //Algo for checking dpf solution
      if (ToolBox.array.Length > 0)  {
		validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {124,21,112,23,112,23,112,23,112,23,112,23,112,23,112,23,112,23,112,23,112,23,112,23,112,23,112,23,112,23,112,23,112,23,112,23,112,23,112,23,112,23,112,23,112,23,112,23,112,23 },  311724    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {124,21,112,23,112,23,112,23,112,23,112,23,112,23,112,23,112,23,112,23,112,23,112,23,112,23,112,23,112,23,112,23,112,23,112,23,112,23,112,23,112,23,112,23,112,23,112,23,112,23 },  311826    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {72,244,60,246,60,246,60,246,60,246,60,246,60,246,60,246,60,246,60,246,60,246,60,246,60,246,60,246,60,246,60,246,60,246,60,246,60,246,60,246,60,246,60,246,60,246,60,246,60,246 },  311928    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {72,244,60,246,60,246,60,246,60,246,60,246,60,246,60,246,60,246,60,246,60,246,60,246,60,246,60,246,60,246,60,246,60,246,60,246,60,246,60,246,60,246,60,246,60,246,60,246,60,246 },  312030    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {240,35,152,8,8,7,220,5,220,5,220,5,120,5,176,4,250 },  313796    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {250 },  313814    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {250 },  313816    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {250 },  313818    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {250 },  313820    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {250 },  313822    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {250 },  313824    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {250 },  313826    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {250 },  313828    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {250 },  313830    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {250 },  313832    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {250 },  313834    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {250 },  313836    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {250 },  313838    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {250 },  313840    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {250 },  313842    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {250 },  313844    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {124,21,112,23,112,23,112,23,112,23,112,23,112,23,112,23,112,23,112,23,112,23,112,23,112,23,112,23,112,23,112,23,112,23,112,23,112,23,112,23,112,23,112,23,112,23,112,23,112,23 },  633884    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {124,21,112,23,112,23,112,23,112,23,112,23,112,23,112,23,112,23,112,23,112,23,112,23,112,23,112,23,112,23,112,23,112,23,112,23,112,23,112,23,112,23,112,23,112,23,112,23,112,23 },  633986    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {72,244,60,246,60,246,60,246,60,246,60,246,60,246,60,246,60,246,60,246,60,246,60,246,60,246,60,246,60,246,60,246,60,246,60,246,60,246,60,246,60,246,60,246,60,246,60,246,60,246 },  634088    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {72,244,60,246,60,246,60,246,60,246,60,246,60,246,60,246,60,246,60,246,60,246,60,246,60,246,60,246,60,246,60,246,60,246,60,246,60,246,60,246,60,246,60,246,60,246,60,246,60,246 },  634190    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {240,35,152,8,8,7,220,5,220,5,220,5,120,5,176,4,250 },  656756    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {250 },  656774    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {250 },  656776    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {250 },  656778    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {250 },  656780    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {250 },  656782    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {250 },  656784    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {250 },  656786    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {250 },  656788    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {250 },  656790    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {250 },  656792    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {250 },  656794    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {250 },  656796    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {250 },  656798    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {250 },  656800    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {250 },  656802    );
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
	ToolBox.ReplaceInFileWithStartStop(new byte[]  {124,21,112,23,112,23,112,23,112,23,112,23,112,23,112,23,112,23,112,23,112,23,112,23,112,23,112,23,112,23,112,23,112,23,112,23,112,23,112,23,112,23,112,23,112,23,112,23,112,23 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },311724,311773, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {124,21,112,23,112,23,112,23,112,23,112,23,112,23,112,23,112,23,112,23,112,23,112,23,112,23,112,23,112,23,112,23,112,23,112,23,112,23,112,23,112,23,112,23,112,23,112,23,112,23 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },311826,311875, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {72,244,60,246,60,246,60,246,60,246,60,246,60,246,60,246,60,246,60,246,60,246,60,246,60,246,60,246,60,246,60,246,60,246,60,246,60,246,60,246,60,246,60,246,60,246,60,246,60,246 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },311928,311977, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {72,244,60,246,60,246,60,246,60,246,60,246,60,246,60,246,60,246,60,246,60,246,60,246,60,246,60,246,60,246,60,246,60,246,60,246,60,246,60,246,60,246,60,246,60,246,60,246,60,246 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },312030,312079, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {240,35,152,8,8,7,220,5,220,5,220,5,120,5,176,4,250 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },313796,313812, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {250 },
 new byte[]  { 0 },313814,313814, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {250 },
 new byte[]  { 0 },313816,313816, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {250 },
 new byte[]  { 0 },313818,313818, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {250 },
 new byte[]  { 0 },313820,313820, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {250 },
 new byte[]  { 0 },313822,313822, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {250 },
 new byte[]  { 0 },313824,313824, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {250 },
 new byte[]  { 0 },313826,313826, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {250 },
 new byte[]  { 0 },313828,313828, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {250 },
 new byte[]  { 0 },313830,313830, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {250 },
 new byte[]  { 0 },313832,313832, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {250 },
 new byte[]  { 0 },313834,313834, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {250 },
 new byte[]  { 0 },313836,313836, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {250 },
 new byte[]  { 0 },313838,313838, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {250 },
 new byte[]  { 0 },313840,313840, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {250 },
 new byte[]  { 0 },313842,313842, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {250 },
 new byte[]  { 0 },313844,313844, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {124,21,112,23,112,23,112,23,112,23,112,23,112,23,112,23,112,23,112,23,112,23,112,23,112,23,112,23,112,23,112,23,112,23,112,23,112,23,112,23,112,23,112,23,112,23,112,23,112,23 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },633884,633933, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {124,21,112,23,112,23,112,23,112,23,112,23,112,23,112,23,112,23,112,23,112,23,112,23,112,23,112,23,112,23,112,23,112,23,112,23,112,23,112,23,112,23,112,23,112,23,112,23,112,23 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },633986,634035, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {72,244,60,246,60,246,60,246,60,246,60,246,60,246,60,246,60,246,60,246,60,246,60,246,60,246,60,246,60,246,60,246,60,246,60,246,60,246,60,246,60,246,60,246,60,246,60,246,60,246 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },634088,634137, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {72,244,60,246,60,246,60,246,60,246,60,246,60,246,60,246,60,246,60,246,60,246,60,246,60,246,60,246,60,246,60,246,60,246,60,246,60,246,60,246,60,246,60,246,60,246,60,246,60,246 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },634190,634239, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {240,35,152,8,8,7,220,5,220,5,220,5,120,5,176,4,250 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },656756,656772, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {250 },
 new byte[]  { 0 },656774,656774, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {250 },
 new byte[]  { 0 },656776,656776, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {250 },
 new byte[]  { 0 },656778,656778, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {250 },
 new byte[]  { 0 },656780,656780, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {250 },
 new byte[]  { 0 },656782,656782, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {250 },
 new byte[]  { 0 },656784,656784, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {250 },
 new byte[]  { 0 },656786,656786, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {250 },
 new byte[]  { 0 },656788,656788, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {250 },
 new byte[]  { 0 },656790,656790, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {250 },
 new byte[]  { 0 },656792,656792, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {250 },
 new byte[]  { 0 },656794,656794, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {250 },
 new byte[]  { 0 },656796,656796, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {250 },
 new byte[]  { 0 },656798,656798, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {250 },
 new byte[]  { 0 },656800,656800, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {250 },
 new byte[]  { 0 },656802,656802, "Found egr map...Delete map");
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
}*/