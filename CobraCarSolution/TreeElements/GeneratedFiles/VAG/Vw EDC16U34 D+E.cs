using System.Collections.Generic;
using System.Threading.Tasks;
using ToolBoxNameSpace;

namespace CobraCarSolution.TreeElements.VAG
{
    class VAG_EDC16U34 : MenuItem, ITreeItem  {
    public VAG_EDC16U34()  {
      Title = "EDC16U34";
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
		
      }
      return validationEgrInFile;
    }
    public override async Task < bool > checkFileForDpf()  {
      bool validationEgrInFile = true;
      //Algo for checking dpf solution
      if (ToolBox.array.Length > 0)  {
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20,130,21,124,22,118,23,112,24,106,39,16,39,16,39,16,39,16,39,16,39,16,39,16,39,16,39,16,39,16,39,16,39,16,9,196,7,208 },  1897684    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20,130,21,124,22,118,23,112,24,106,39,16,39,16,39,16,39,16,39,16,39,16,39,16,39,16,39,16,39,16,39,16,39,16,39,16,39,16,39,16,39,16,9,196,7,208 },  1897888    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1 },  1948466    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1 },  1962703    );
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
	
      base.egrOffSolution();
    }
    public override void dpfOffSolution()  {
	ToolBox.ReplaceInFileWithStartStop(new byte[]  {20,130,21,124,22,118,23,112,24,106,39,16,39,16,39,16,39,16,39,16,39,16,39,16,39,16,39,16,39,16,39,16,39,16,9,196,7,208 },
 new byte[]  { 32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32 },1897684,1897721, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20,130,21,124,22,118,23,112,24,106,39,16,39,16,39,16,39,16,39,16,39,16,39,16,39,16,39,16,39,16,39,16,39,16,39,16,39,16,39,16,39,16,9,196,7,208 },
 new byte[]  { 32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32 },1897888,1897933, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1 },
 new byte[]  { 0 },1948466,1948466, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1 },
 new byte[]  { 0 },1962703,1962703, "Found dpf map...Delete map");
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