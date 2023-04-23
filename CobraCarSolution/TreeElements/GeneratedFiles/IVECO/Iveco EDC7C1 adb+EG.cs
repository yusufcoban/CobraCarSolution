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
  class Iveco_EDC7C1 :MenuItem, ITreeItem  {
    public Iveco_EDC7C1()  {
      Title = "Iveco_EDC7C1";
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
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {5,1,5,3,5,3,5,1,5,3,5,2,5,1,5,3,5,1,5,1,5,1 },  1573236    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {6,6,6,6 },  1573264    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {6,6,1,72,1,47,1,217,1,18,2,18,1,235,1,33,7,144,1,19,1,135,1,136,2,135,2,136,7,240,1,46,1,45,2,45,1,43,1,44,1,145,1,146,2,146,3,146,2,31,1,52,1,38,1,75,1,76,1,23,3,158,2,138,1,62,1,63,1,39,1,36,2,36,1,49,2,50,1,50,2,117,2,118,2,119,2,120,2,121,2,122,1,125,1,117,1,118,1,119,1,120,1,121,1,122,1,123,3,50,1,190,1,79,1,22,1,60,1,24,1,138,1,74,2,74,2,171,1,171,1,137,2,137,3,137,2,255,2,253,1,253,1,148,1,149,1,150,1,151,1,42,1,66,1,67,1,65,1,68,1,77,4,158,1,218,1,61,2,61,1,53,1,69,1,70,1,71,1,73,1,28,1,185,1,175,2,175,3,175,4,175,5,175,1,172,1,163,2,161,1,161,1,162,1,173,1,168,1,180,2,180,1,165,1,186,1,193,1,187,1,194,2,194,2,172,3,201,1,27,1,164,1,188,1,189,1,191,1,166,2,166,1,132,1,195,1,201,1,196,3,196,2,196,4,196,1,197,3,197,2,197,4,197,1,198,2,198,1,199,3,199,2,199,4,199,1,200,3,200,2,200,4,200,2,201,4,167,2,27,1,181,1,182,1,183,2,167,3,167,1,170,1,184,1,209,1,210,1,211,2,211,3,211,1,233,1,234,1,91,2,174,1,174,1,51,1,129,1,226,1,126,1,113,1,114,1,115,1,116,1,124,2,124,1,97,1,103,1,98,1,104,1,99,1,105,1,100,1,106,1,101,1,107,1,102,1,108,1,109,1,110,6,1,6,2,6,6,1,143,6,4,6,5,6,7,6,8,6,9,6,10,6,11,6,12,6,3,6,13,6,15,6,14,2,21,3,21,1,34,1,37,2,37,1,41,1,20,1,89,2,89,3,89,1,90,1,40,2,40,1,212,1,159,2,157,1,177,1,178,1,179,5,158,1,95,2,95,3,95,4,95,5,95,3,56,1,56,2,56,1,58,2,58,1,227,1,228,1,251,1,252,1,246,1,152,1,153,1,156,1,154,2,153,4,157 },  1573274    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {5,1,5,3,5,3,5,1,5,3,5,2,5,1,5,3,5,1,5,1,5,1 },  1900916    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {6,6,6,6 },  1900944    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {6,6,1,72,1,47,1,217,1,18,2,18,1,235,1,33,7,144,1,19,1,135,1,136,2,135,2,136,7,240,1,46,1,45,2,45,1,43,1,44,1,145,1,146,2,146,3,146,2,31,1,52,1,38,1,75,1,76,1,23,3,158,2,138,1,62,1,63,1,39,1,36,2,36,1,49,2,50,1,50,2,117,2,118,2,119,2,120,2,121,2,122,1,125,1,117,1,118,1,119,1,120,1,121,1,122,1,123,3,50,1,190,1,79,1,22,1,60,1,24,1,138,1,74,2,74,2,171,1,171,1,137,2,137,3,137,2,255,2,253,1,253,1,148,1,149,1,150,1,151,1,42,1,66,1,67,1,65,1,68,1,77,4,158,1,218,1,61,2,61,1,53,1,69,1,70,1,71,1,73,1,28,1,185,1,175,2,175,3,175,4,175,5,175,1,172,1,163,2,161,1,161,1,162,1,173,1,168,1,180,2,180,1,165,1,186,1,193,1,187,1,194,2,194,2,172,3,201,1,27,1,164,1,188,1,189,1,191,1,166,2,166,1,132,1,195,1,201,1,196,3,196,2,196,4,196,1,197,3,197,2,197,4,197,1,198,2,198,1,199,3,199,2,199,4,199,1,200,3,200,2,200,4,200,2,201,4,167,2,27,1,181,1,182,1,183,2,167,3,167,1,170,1,184,1,209,1,210,1,211,2,211,3,211,1,233,1,234,1,91,2,174,1,174,1,51,1,129,1,226,1,126,1,113,1,114,1,115,1,116,1,124,2,124,1,97,1,103,1,98,1,104,1,99,1,105,1,100,1,106,1,101,1,107,1,102,1,108,1,109,1,110,6,1,6,2,6,6,1,143,6,4,6,5,6,7,6,8,6,9,6,10,6,11,6,12,6,3,6,13,6,15,6,14,2,21,3,21,1,34,1,37,2,37,1,41,1,20,1,89,2,89,3,89,1,90,1,40,2,40,1,212,1,159,2,157,1,177,1,178,1,179,5,158,1,95,2,95,3,95,4,95,5,95,3,56,1,56,2,56,1,58,2,58,1,227,1,228,1,251,1,252,1,246,1,152,1,153,1,156,1,154,2,153,4,157 },  1900954    );
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
	
      base.lamdaOfffSolution();

    }

    public override void flapsOfffSolution()  {
	

      base.flapsOfffSolution();
    }
    public override void startStopSolution()  {
	ToolBox.ReplaceInFileWithStartStop(new byte[]  {5,1,5,3,5,3,5,1,5,3,5,2,5,1,5,3,5,1,5,1,5,1 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },1573236,1573257, "Found startstop map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {6,6,6,6 },
 new byte[]  { 0,0,0,0 },1573264,1573267, "Found startstop map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {6,6,1,72,1,47,1,217,1,18,2,18,1,235,1,33,7,144,1,19,1,135,1,136,2,135,2,136,7,240,1,46,1,45,2,45,1,43,1,44,1,145,1,146,2,146,3,146,2,31,1,52,1,38,1,75,1,76,1,23,3,158,2,138,1,62,1,63,1,39,1,36,2,36,1,49,2,50,1,50,2,117,2,118,2,119,2,120,2,121,2,122,1,125,1,117,1,118,1,119,1,120,1,121,1,122,1,123,3,50,1,190,1,79,1,22,1,60,1,24,1,138,1,74,2,74,2,171,1,171,1,137,2,137,3,137,2,255,2,253,1,253,1,148,1,149,1,150,1,151,1,42,1,66,1,67,1,65,1,68,1,77,4,158,1,218,1,61,2,61,1,53,1,69,1,70,1,71,1,73,1,28,1,185,1,175,2,175,3,175,4,175,5,175,1,172,1,163,2,161,1,161,1,162,1,173,1,168,1,180,2,180,1,165,1,186,1,193,1,187,1,194,2,194,2,172,3,201,1,27,1,164,1,188,1,189,1,191,1,166,2,166,1,132,1,195,1,201,1,196,3,196,2,196,4,196,1,197,3,197,2,197,4,197,1,198,2,198,1,199,3,199,2,199,4,199,1,200,3,200,2,200,4,200,2,201,4,167,2,27,1,181,1,182,1,183,2,167,3,167,1,170,1,184,1,209,1,210,1,211,2,211,3,211,1,233,1,234,1,91,2,174,1,174,1,51,1,129,1,226,1,126,1,113,1,114,1,115,1,116,1,124,2,124,1,97,1,103,1,98,1,104,1,99,1,105,1,100,1,106,1,101,1,107,1,102,1,108,1,109,1,110,6,1,6,2,6,6,1,143,6,4,6,5,6,7,6,8,6,9,6,10,6,11,6,12,6,3,6,13,6,15,6,14,2,21,3,21,1,34,1,37,2,37,1,41,1,20,1,89,2,89,3,89,1,90,1,40,2,40,1,212,1,159,2,157,1,177,1,178,1,179,5,158,1,95,2,95,3,95,4,95,5,95,3,56,1,56,2,56,1,58,2,58,1,227,1,228,1,251,1,252,1,246,1,152,1,153,1,156,1,154,2,153,4,157 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },1573274,1573759, "Found startstop map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {5,1,5,3,5,3,5,1,5,3,5,2,5,1,5,3,5,1,5,1,5,1 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },1900916,1900937, "Found startstop map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {6,6,6,6 },
 new byte[]  { 0,0,0,0 },1900944,1900947, "Found startstop map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {6,6,1,72,1,47,1,217,1,18,2,18,1,235,1,33,7,144,1,19,1,135,1,136,2,135,2,136,7,240,1,46,1,45,2,45,1,43,1,44,1,145,1,146,2,146,3,146,2,31,1,52,1,38,1,75,1,76,1,23,3,158,2,138,1,62,1,63,1,39,1,36,2,36,1,49,2,50,1,50,2,117,2,118,2,119,2,120,2,121,2,122,1,125,1,117,1,118,1,119,1,120,1,121,1,122,1,123,3,50,1,190,1,79,1,22,1,60,1,24,1,138,1,74,2,74,2,171,1,171,1,137,2,137,3,137,2,255,2,253,1,253,1,148,1,149,1,150,1,151,1,42,1,66,1,67,1,65,1,68,1,77,4,158,1,218,1,61,2,61,1,53,1,69,1,70,1,71,1,73,1,28,1,185,1,175,2,175,3,175,4,175,5,175,1,172,1,163,2,161,1,161,1,162,1,173,1,168,1,180,2,180,1,165,1,186,1,193,1,187,1,194,2,194,2,172,3,201,1,27,1,164,1,188,1,189,1,191,1,166,2,166,1,132,1,195,1,201,1,196,3,196,2,196,4,196,1,197,3,197,2,197,4,197,1,198,2,198,1,199,3,199,2,199,4,199,1,200,3,200,2,200,4,200,2,201,4,167,2,27,1,181,1,182,1,183,2,167,3,167,1,170,1,184,1,209,1,210,1,211,2,211,3,211,1,233,1,234,1,91,2,174,1,174,1,51,1,129,1,226,1,126,1,113,1,114,1,115,1,116,1,124,2,124,1,97,1,103,1,98,1,104,1,99,1,105,1,100,1,106,1,101,1,107,1,102,1,108,1,109,1,110,6,1,6,2,6,6,1,143,6,4,6,5,6,7,6,8,6,9,6,10,6,11,6,12,6,3,6,13,6,15,6,14,2,21,3,21,1,34,1,37,2,37,1,41,1,20,1,89,2,89,3,89,1,90,1,40,2,40,1,212,1,159,2,157,1,177,1,178,1,179,5,158,1,95,2,95,3,95,4,95,5,95,3,56,1,56,2,56,1,58,2,58,1,227,1,228,1,251,1,252,1,246,1,152,1,153,1,156,1,154,2,153,4,157 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },1900954,1901439, "Found startstop map...Delete map");

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