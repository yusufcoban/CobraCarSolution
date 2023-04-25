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
  class Toyota_edc17cp07 : MenuItem, ITreeItem  {
    public Toyota_edc17cp07()  {
      Title = "Toyota_edc17cp07";
      IsSolutionItem =  true;
      hasDtcSolution =  false;
      hasEgrSolution = false;
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