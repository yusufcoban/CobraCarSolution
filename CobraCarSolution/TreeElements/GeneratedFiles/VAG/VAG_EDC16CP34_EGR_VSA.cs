using ToolBoxNameSpace;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace CobraCarSolution.TreeElements.VAG
{
    class VAG_EDC16CP34 :MenuItem, ITreeItem  {
    public VAG_EDC16CP34()  {
      Title = "VAG_EDC16CP34";
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
      hasSpecialISolution =true;
      hasSpecialIISolution =false;
      hasSpecialIIISolution =false;
      specialISolutionDescription="VSA OFF";
      specialIISolutionDescription="";
      specialIIISolutionDescription="";
      desciption="";
      FileSizeArray = new int[]  {  0 };
    }

    public override async Task < bool > checkFileForEgr()  {
      bool validationEgrInFile = true;
      //Algo for checking dpf solution
      if (ToolBox.array.Length > 0)  {
		validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {15,160,15,160,15,160,15,160,15,160,15,160,15,160,15,160,15,160,15,160,15,160,15,160,15,160,15,160,15,160,15,160,15,160,15,160,15,160,15,160,15,160,15,160,15,160,15,160,15,160 },  1860380    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {11,184,11,184,11,184,11,184,11,184,11,184,11,184,11,184,11,184,11,184,11,184,11,184,11,184,11,184,11,184,11,184,11,184,11,184,11,184,11,184,11,184,11,184,11,184,11,184,11,184 },  1860482    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {13 },  1883589    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {67,3,3 },  1883652    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {75,75,75,203,203,203,75,203,75,203,75,203,11,11 },  1883922    );
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
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {15,160,15,160,15,160,15,160,15,160,15,160,15,160,15,160,15,160,15,160,15,160,15,160,15,160,15,160,15,160,15,160,15,160,15,160,15,160,15,160,15,160,15,160,15,160,15,160,15,160 },  1860380    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {11,184,11,184,11,184,11,184,11,184,11,184,11,184,11,184,11,184,11,184,11,184,11,184,11,184,11,184,11,184,11,184,11,184,11,184,11,184,11,184,11,184,11,184,11,184,11,184,11,184 },  1860482    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {13 },  1883589    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {67,3,3 },  1883652    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {75,75,75,203,203,203,75,203,75,203,75,203,11,11 },  1883922    );
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
	ToolBox.ReplaceInFileWithStartStop(new byte[]  {15,160,15,160,15,160,15,160,15,160,15,160,15,160,15,160,15,160,15,160,15,160,15,160,15,160,15,160,15,160,15,160,15,160,15,160,15,160,15,160,15,160,15,160,15,160,15,160,15,160 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },1860380,1860429, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {11,184,11,184,11,184,11,184,11,184,11,184,11,184,11,184,11,184,11,184,11,184,11,184,11,184,11,184,11,184,11,184,11,184,11,184,11,184,11,184,11,184,11,184,11,184,11,184,11,184 },
 new byte[]  { 0,250,0,250,0,250,0,250,0,250,0,250,0,250,0,250,0,250,0,250,0,250,0,250,0,250,0,250,0,250,0,250,0,250,0,250,0,250,0,250,0,250,0,250,0,250,0,250,0,250 },1860482,1860531, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {13 },
 new byte[]  { 0 },1883589,1883589, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {67,3,3 },
 new byte[]  { 0,0,0 },1883652,1883654, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {75,75,75,203,203,203,75,203,75,203,75,203,11,11 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0 },1883922,1883935, "Found egr map...Delete map");
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
	ToolBox.ReplaceInFileWithStartStop(new byte[]  {15,160,15,160,15,160,15,160,15,160,15,160,15,160,15,160,15,160,15,160,15,160,15,160,15,160,15,160,15,160,15,160,15,160,15,160,15,160,15,160,15,160,15,160,15,160,15,160,15,160 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },1860380,1860429, "Found immo map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {11,184,11,184,11,184,11,184,11,184,11,184,11,184,11,184,11,184,11,184,11,184,11,184,11,184,11,184,11,184,11,184,11,184,11,184,11,184,11,184,11,184,11,184,11,184,11,184,11,184 },
 new byte[]  { 0,250,0,250,0,250,0,250,0,250,0,250,0,250,0,250,0,250,0,250,0,250,0,250,0,250,0,250,0,250,0,250,0,250,0,250,0,250,0,250,0,250,0,250,0,250,0,250,0,250 },1860482,1860531, "Found immo map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {13 },
 new byte[]  { 0 },1883589,1883589, "Found immo map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {67,3,3 },
 new byte[]  { 0,0,0 },1883652,1883654, "Found immo map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {75,75,75,203,203,203,75,203,75,203,75,203,11,11 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0 },1883922,1883935, "Found immo map...Delete map");

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