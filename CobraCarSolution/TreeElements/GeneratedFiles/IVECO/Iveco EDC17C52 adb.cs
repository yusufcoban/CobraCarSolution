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
  class IVECO_EDC17C52 : MenuItem, ITreeItem  {
    public IVECO_EDC17C52()  {
      Title = "IVECO_EDC17C52";
      IsSolutionItem =  true;
      hasDtcSolution =  false;
      hasEgrSolution = false;
      hasTVASolution = false;
      hasFileCheckSize =false;
      hasDpfSolution =false;
      hasLamdaSolution =false;
      hasFLAPSSolution =false;
      hasStartStopSolution =false;
      hasADBlueSolution =true;
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
      bool validationEgrInFile = false;  if (ToolBox.array.Length > 0)  {} return validationEgrInFile;

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
      bool validationEgrInFile = true;
      //Algo for checking dpf solution
      if (ToolBox.array.Length > 0)  {
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {4 },  2328338    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {4 },  2328340    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3,3,3,3,3 },  3523577    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3,3,3,3,3 },  3523584    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3,3,3,3,3 },  3523591    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3,3,3,3,3 },  3523598    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3,3,3,3,3 },  3523605    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3,3,3,3,3 },  3523626    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3,3,3,3,3 },  3523633    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3,3,3,3,3 },  3523640    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3,3,3,3,3 },  3523647    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3,3,3,3,3 },  3523706    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3,3,3,3,3 },  3523713    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3,3,3,3,3 },  3523720    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3,3,3,3,3 },  3523727    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3,3,3,3,3 },  3523734    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3,3,3,3,3 },  3523755    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3,3,3,3,3 },  3523762    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3,3,3,3,3 },  3523769    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3,3,3,3,3 },  3523776    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3,3,3 },  3523898    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3,3,3,3 },  3523904    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3,3,3 },  3523912    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3,3 },  3523920    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3 },  3523928    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3,3,3 },  3523947    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3,3 },  3523955    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3 },  3523963    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3 },  3523970    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3,3,3 },  3524028    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3,3,3,3 },  3524034    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3,3,3 },  3524042    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3,3 },  3524050    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3 },  3524058    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3,3,3 },  3524077    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3,3 },  3524085    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3 },  3524093    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3 },  3524100    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3,3,3 },  3524157    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3,3,3,3 },  3524163    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3,3,3 },  3524171    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3,3 },  3524179    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3 },  3524187    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3,3,3 },  3524206    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3,3 },  3524214    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3 },  3524222    );
      }
      return validationEgrInFile;
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
	
      base.dpfOffSolution();
    }
    public override void lamdaOfffSolution()  {
	
      base.lamdaOfffSolution();

    }

    public override void flapsOfffSolution()  {
	

      base.flapsOfffSolution();
    }
    public override void startStopSolution()  {
	ToolBox.ReplaceInFileWithStartStop(new byte[]  {4 },
 new byte[]  { 0 },2328338,2328338, "Found startstop map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {4 },
 new byte[]  { 0 },2328340,2328340, "Found startstop map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3,3,3,3,3 },
 new byte[]  { 0,0,0,0,0 },3523577,3523581, "Found startstop map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3,3,3,3,3 },
 new byte[]  { 0,0,0,0,0 },3523584,3523588, "Found startstop map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3,3,3,3,3 },
 new byte[]  { 0,0,0,0,0 },3523591,3523595, "Found startstop map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3,3,3,3,3 },
 new byte[]  { 0,0,0,0,0 },3523598,3523602, "Found startstop map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3,3,3,3,3 },
 new byte[]  { 0,0,0,0,0 },3523605,3523609, "Found startstop map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3,3,3,3,3 },
 new byte[]  { 0,0,0,0,0 },3523626,3523630, "Found startstop map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3,3,3,3,3 },
 new byte[]  { 0,0,0,0,0 },3523633,3523637, "Found startstop map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3,3,3,3,3 },
 new byte[]  { 0,0,0,0,0 },3523640,3523644, "Found startstop map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3,3,3,3,3 },
 new byte[]  { 0,0,0,0,0 },3523647,3523651, "Found startstop map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3,3,3,3,3 },
 new byte[]  { 0,0,0,0,0 },3523706,3523710, "Found startstop map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3,3,3,3,3 },
 new byte[]  { 0,0,0,0,0 },3523713,3523717, "Found startstop map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3,3,3,3,3 },
 new byte[]  { 0,0,0,0,0 },3523720,3523724, "Found startstop map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3,3,3,3,3 },
 new byte[]  { 0,0,0,0,0 },3523727,3523731, "Found startstop map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3,3,3,3,3 },
 new byte[]  { 0,0,0,0,0 },3523734,3523738, "Found startstop map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3,3,3,3,3 },
 new byte[]  { 0,0,0,0,0 },3523755,3523759, "Found startstop map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3,3,3,3,3 },
 new byte[]  { 0,0,0,0,0 },3523762,3523766, "Found startstop map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3,3,3,3,3 },
 new byte[]  { 0,0,0,0,0 },3523769,3523773, "Found startstop map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3,3,3,3,3 },
 new byte[]  { 0,0,0,0,0 },3523776,3523780, "Found startstop map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3,3,3 },
 new byte[]  { 0,0,0 },3523898,3523900, "Found startstop map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3,3,3,3 },
 new byte[]  { 0,0,0,0 },3523904,3523907, "Found startstop map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3,3,3 },
 new byte[]  { 0,0,0 },3523912,3523914, "Found startstop map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3,3 },
 new byte[]  { 0,0 },3523920,3523921, "Found startstop map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3 },
 new byte[]  { 0 },3523928,3523928, "Found startstop map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3,3,3 },
 new byte[]  { 0,0,0 },3523947,3523949, "Found startstop map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3,3 },
 new byte[]  { 0,0 },3523955,3523956, "Found startstop map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3 },
 new byte[]  { 0 },3523963,3523963, "Found startstop map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3 },
 new byte[]  { 0 },3523970,3523970, "Found startstop map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3,3,3 },
 new byte[]  { 0,0,0 },3524028,3524030, "Found startstop map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3,3,3,3 },
 new byte[]  { 0,0,0,0 },3524034,3524037, "Found startstop map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3,3,3 },
 new byte[]  { 0,0,0 },3524042,3524044, "Found startstop map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3,3 },
 new byte[]  { 0,0 },3524050,3524051, "Found startstop map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3 },
 new byte[]  { 0 },3524058,3524058, "Found startstop map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3,3,3 },
 new byte[]  { 0,0,0 },3524077,3524079, "Found startstop map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3,3 },
 new byte[]  { 0,0 },3524085,3524086, "Found startstop map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3 },
 new byte[]  { 0 },3524093,3524093, "Found startstop map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3 },
 new byte[]  { 0 },3524100,3524100, "Found startstop map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3,3,3 },
 new byte[]  { 0,0,0 },3524157,3524159, "Found startstop map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3,3,3,3 },
 new byte[]  { 0,0,0,0 },3524163,3524166, "Found startstop map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3,3,3 },
 new byte[]  { 0,0,0 },3524171,3524173, "Found startstop map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3,3 },
 new byte[]  { 0,0 },3524179,3524180, "Found startstop map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3 },
 new byte[]  { 0 },3524187,3524187, "Found startstop map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3,3,3 },
 new byte[]  { 0,0,0 },3524206,3524208, "Found startstop map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3,3 },
 new byte[]  { 0,0 },3524214,3524215, "Found startstop map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3 },
 new byte[]  { 0 },3524222,3524222, "Found startstop map...Delete map");

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