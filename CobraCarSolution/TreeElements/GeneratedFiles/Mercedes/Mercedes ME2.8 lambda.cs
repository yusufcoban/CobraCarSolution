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
  class Mercedes_ME2_8 : MenuItem, ITreeItem  {
    public Mercedes_ME2_8()  {
      Title = "Mercedes_ME2.8";
      IsSolutionItem =  true;
      hasDtcSolution =  false;
      hasEgrSolution = false;
      hasTVASolution = false;
      hasFileCheckSize =false;
      hasDpfSolution =false;
      hasLamdaSolution =true;
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
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {8,248,249,250,251,252,253,254,255,255,105,204,150,222,170,238,227,142,238,211,254,252,201,188,150,60,195,105,3,170,133,215,252,223,204,236,255,232,164,179,172,85,95,104,100,80,80,80,32 },  94059    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {80,80,80,80,80,80,80 },  94109    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,1,1 },  94126    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {11,11,11,11,14,17,20,23,22,23,23,24,30,34,40,45,81,86,91,94,101,107,113 },  94132    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {8 },  94414    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {12,30,46,62,77,129,255,92,60,83,116,54,51,22,213,199,116,20,16,20,118,126,254,18,46,107,33,22,93,112,60,101,84,51,74,70,194,41,151,8,24,26,43,61,116,152,174,207,27,24,62,107,33,15,93,112,60,101,84,51,74,70,194,41 },  94416    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {60,150,195 },  94481    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {60,2,218 },  94485    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {204,27,12,2 },  94496    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {150,7 },  94502    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {2 },  94505    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3 },  94507    );
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
	
      base.egrOffSolution();
    }
    public override void dpfOffSolution()  {
	
      base.dpfOffSolution();
    }
    public override void lamdaOfffSolution()  {
	ToolBox.ReplaceInFileWithStartStop(new byte[]  {8,248,249,250,251,252,253,254,255,255,105,204,150,222,170,238,227,142,238,211,254,252,201,188,150,60,195,105,3,170,133,215,252,223,204,236,255,232,164,179,172,85,95,104,100,80,80,80,32 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },94059,94107, "Found lamda map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {80,80,80,80,80,80,80 },
 new byte[]  { 0,0,0,0,0,0,0 },94109,94115, "Found lamda map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,1,1 },
 new byte[]  { 0,0,0 },94126,94128, "Found lamda map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {11,11,11,11,14,17,20,23,22,23,23,24,30,34,40,45,81,86,91,94,101,107,113 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },94132,94154, "Found lamda map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {8 },
 new byte[]  { 0 },94414,94414, "Found lamda map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {12,30,46,62,77,129,255,92,60,83,116,54,51,22,213,199,116,20,16,20,118,126,254,18,46,107,33,22,93,112,60,101,84,51,74,70,194,41,151,8,24,26,43,61,116,152,174,207,27,24,62,107,33,15,93,112,60,101,84,51,74,70,194,41 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },94416,94479, "Found lamda map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {60,150,195 },
 new byte[]  { 0,0,0 },94481,94483, "Found lamda map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {60,2,218 },
 new byte[]  { 0,0,0 },94485,94487, "Found lamda map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {204,27,12,2 },
 new byte[]  { 0,0,0,0 },94496,94499, "Found lamda map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {150,7 },
 new byte[]  { 0,0 },94502,94503, "Found lamda map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {2 },
 new byte[]  { 0 },94505,94505, "Found lamda map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3 },
 new byte[]  { 0 },94507,94507, "Found lamda map...Delete map");
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