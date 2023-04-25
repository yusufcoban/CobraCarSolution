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
  class VAG_PPD1_3 :MenuItem, ITreeItem  {
    public VAG_PPD1_3()  {
      Title = "PPD1.3";
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
      bool validationEgrInFile = true;
      //Algo for checking dpf solution
      if (ToolBox.array.Length > 0)  {
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3,3,3 },  293158    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3,3,3 },  293166    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3,3,3 },  293174    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,2,3,6 },  293182    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,2,3,6 },  293190    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,2,3,6 },  293198    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3 },  293208    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,2,4,6 },  293214    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {128,0 },  305946    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {146,192,146,192,138,128,128,0,128,0,128,0,128,0,128,0,128,0,128,0,128,0,128,0,128,0,128,0 },  305950    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {0,0,0,0,0,0,0,0,0 },  306010    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },  306020    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {200,1,44,1,44,1,44 },  306631    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3,3,1,1,1 },  306650    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,1 },  306657    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,1 },  306664    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1 },  306668    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,1 },  306677    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1 },  306682    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,1 },  306684    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,1,1,1 },  306688    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {2,2,2,2 },  306693    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,1,1,1,1 },  306705    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1 },  306711    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1 },  306720    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1 },  306724    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1 },  306730    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1 },  306740    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1 },  306745    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1 },  306747    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,1,1,1,1,1,1 },  306750    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {2,2,2,2 },  306767    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,1 },  306777    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,1,1,1 },  306785    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,1,1,1,1 },  306791    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,1,1,1 },  306798    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,1,1,1 },  306808    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,1,1,1 },  306818    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,1,1,1 },  306828    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,1,1,1 },  306838    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1 },  306852    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1 },  306854    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,1,1,1 },  306862    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,1 },  306867    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1 },  306871    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,1,2,2,2,1,1,1,1,1,2,2,2,2,2,2,1,1 },  306873    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,1,1,2,2,2,2 },  306892    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1 },  306907    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1 },  306921    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {5 },  306923    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,1,1 },  306928    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,1,1 },  306944    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1 },  306949    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1 },  306953    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1 },  306960    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1 },  306966    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,1 },  306975    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1 },  306979    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {2,2,2,2 },  306985    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,1,1 },  306995    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1 },  307000    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1 },  307009    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,1,1,1 },  307011    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,1,5 },  307016    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20,10,5,50,50 },  307020    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {32,2 },  315770    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {32,2,39,89,39,89,39,89,39,89,8,87,133,202,126,197 },  315780    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {4,113 },  315826    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {36,83,40,9,40,9,40,9,40,9,8,133,142,203,90,214 },  315836    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {4,113 },  315854    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {4,113,40,16,40,16,40,16,40,16,8,133,142,203,90,214 },  315864    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {4,113 },  315882    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {4,113,40,17,40,17,40,17,40,17,8,133,203,142,90,214 },  315892    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {32,2 },  315966    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {32,2,39,97,39,97,39,97,39,97,8,133,142,203,90,214 },  315976    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {4,113 },  315994    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {4,113,40,19,40,19,40,19,40,19,8,133,203,90,142,214 },  316004    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {32,2 },  318234    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {32,2 },  318244    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {8,87,202,133,126,197 },  318254    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,53,1,53,1,53 },  318262    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {17,2,1,21,17,22 },  318272    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {122,112,158,24,140,147 },  318282    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {5,70,5,69 },  320950    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {5,70,5,69 },  320960    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {8,6,10,85,83,197 },  320970    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {32,51,32,50 },  320978    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {25,88,25,87 },  320988    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {8,6,10,135,83,147 },  320998    );
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
	ToolBox.ReplaceInFileWithStartStop(new byte[]  {3,3,3 },
 new byte[]  { 0,0,0 },293158,293160, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3,3,3 },
 new byte[]  { 0,0,0 },293166,293168, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3,3,3 },
 new byte[]  { 0,0,0 },293174,293176, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,2,3,6 },
 new byte[]  { 0,0,0,0 },293182,293185, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,2,3,6 },
 new byte[]  { 0,0,0,0 },293190,293193, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,2,3,6 },
 new byte[]  { 0,0,0,0 },293198,293201, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3 },
 new byte[]  { 0 },293208,293208, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,2,4,6 },
 new byte[]  { 0,0,0,0 },293214,293217, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {128,0 },
 new byte[]  { 146,192 },305946,305947, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {146,192,146,192,138,128,128,0,128,0,128,0,128,0,128,0,128,0,128,0,128,0,128,0,128,0,128,0 },
 new byte[]  { 149,64,149,64,158,0,170,102,180,5,181,196,181,88,180,179,179,250,178,156,177,103,176,9,174,228,174,70 },305950,305977, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {0,0,0,0,0,0,0,0,0 },
 new byte[]  { 146,192,146,192,149,64,149,64,158 },306010,306018, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },
 new byte[]  { 170,102,180,5,181,196,181,88,180,179,179,250,178,156,177,103,176,9,174,228,174,70 },306020,306041, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {200,1,44,1,44,1,44 },
 new byte[]  { 0,0,0,0,0,0,0 },306631,306637, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3,3,1,1,1 },
 new byte[]  { 0,0,0,0,0 },306650,306654, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,1 },
 new byte[]  { 0,0 },306657,306658, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,1 },
 new byte[]  { 0,0 },306664,306665, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1 },
 new byte[]  { 0 },306668,306668, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,1 },
 new byte[]  { 0,0 },306677,306678, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1 },
 new byte[]  { 0 },306682,306682, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,1 },
 new byte[]  { 0,0 },306684,306685, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,1,1,1 },
 new byte[]  { 0,0,0,0 },306688,306691, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {2,2,2,2 },
 new byte[]  { 0,0,0,0 },306693,306696, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,1,1,1,1 },
 new byte[]  { 0,0,0,0,0 },306705,306709, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1 },
 new byte[]  { 0 },306711,306711, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1 },
 new byte[]  { 0 },306720,306720, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1 },
 new byte[]  { 0 },306724,306724, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1 },
 new byte[]  { 0 },306730,306730, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1 },
 new byte[]  { 0 },306740,306740, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1 },
 new byte[]  { 0 },306745,306745, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1 },
 new byte[]  { 0 },306747,306747, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,1,1,1,1,1,1 },
 new byte[]  { 0,0,0,0,0,0,0 },306750,306756, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {2,2,2,2 },
 new byte[]  { 0,0,0,0 },306767,306770, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,1 },
 new byte[]  { 0,0 },306777,306778, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,1,1,1 },
 new byte[]  { 0,0,0,0 },306785,306788, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,1,1,1,1 },
 new byte[]  { 0,0,0,0,0 },306791,306795, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,1,1,1 },
 new byte[]  { 0,0,0,0 },306798,306801, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,1,1,1 },
 new byte[]  { 0,0,0,0 },306808,306811, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,1,1,1 },
 new byte[]  { 0,0,0,0 },306818,306821, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,1,1,1 },
 new byte[]  { 0,0,0,0 },306828,306831, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,1,1,1 },
 new byte[]  { 0,0,0,0 },306838,306841, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1 },
 new byte[]  { 0 },306852,306852, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1 },
 new byte[]  { 0 },306854,306854, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,1,1,1 },
 new byte[]  { 0,0,0,0 },306862,306865, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,1 },
 new byte[]  { 0,0 },306867,306868, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1 },
 new byte[]  { 0 },306871,306871, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,1,2,2,2,1,1,1,1,1,2,2,2,2,2,2,1,1 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },306873,306890, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,1,1,2,2,2,2 },
 new byte[]  { 0,0,0,0,0,0,0 },306892,306898, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1 },
 new byte[]  { 0 },306907,306907, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1 },
 new byte[]  { 0 },306921,306921, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {5 },
 new byte[]  { 0 },306923,306923, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,1,1 },
 new byte[]  { 0,0,0 },306928,306930, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,1,1 },
 new byte[]  { 0,0,0 },306944,306946, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1 },
 new byte[]  { 0 },306949,306949, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1 },
 new byte[]  { 0 },306953,306953, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1 },
 new byte[]  { 0 },306960,306960, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1 },
 new byte[]  { 0 },306966,306966, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,1 },
 new byte[]  { 0,0 },306975,306976, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1 },
 new byte[]  { 0 },306979,306979, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {2,2,2,2 },
 new byte[]  { 0,0,0,0 },306985,306988, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,1,1 },
 new byte[]  { 0,0,0 },306995,306997, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1 },
 new byte[]  { 0 },307000,307000, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1 },
 new byte[]  { 0 },307009,307009, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,1,1,1 },
 new byte[]  { 0,0,0,0 },307011,307014, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,1,5 },
 new byte[]  { 0,0,0 },307016,307018, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20,10,5,50,50 },
 new byte[]  { 0,0,0,0,0 },307020,307024, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {32,2 },
 new byte[]  { 0,0 },315770,315771, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {32,2,39,89,39,89,39,89,39,89,8,87,133,202,126,197 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },315780,315795, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {4,113 },
 new byte[]  { 0,0 },315826,315827, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {36,83,40,9,40,9,40,9,40,9,8,133,142,203,90,214 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },315836,315851, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {4,113 },
 new byte[]  { 0,0 },315854,315855, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {4,113,40,16,40,16,40,16,40,16,8,133,142,203,90,214 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },315864,315879, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {4,113 },
 new byte[]  { 0,0 },315882,315883, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {4,113,40,17,40,17,40,17,40,17,8,133,203,142,90,214 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },315892,315907, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {32,2 },
 new byte[]  { 0,0 },315966,315967, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {32,2,39,97,39,97,39,97,39,97,8,133,142,203,90,214 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },315976,315991, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {4,113 },
 new byte[]  { 0,0 },315994,315995, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {4,113,40,19,40,19,40,19,40,19,8,133,203,90,142,214 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },316004,316019, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {32,2 },
 new byte[]  { 0,0 },318234,318235, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {32,2 },
 new byte[]  { 0,0 },318244,318245, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {8,87,202,133,126,197 },
 new byte[]  { 0,0,0,0,0,0 },318254,318259, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,53,1,53,1,53 },
 new byte[]  { 0,0,0,0,0,0 },318262,318267, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {17,2,1,21,17,22 },
 new byte[]  { 0,0,0,0,0,0 },318272,318277, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {122,112,158,24,140,147 },
 new byte[]  { 0,0,0,0,0,0 },318282,318287, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {5,70,5,69 },
 new byte[]  { 0,0,0,0 },320950,320953, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {5,70,5,69 },
 new byte[]  { 0,0,0,0 },320960,320963, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {8,6,10,85,83,197 },
 new byte[]  { 0,0,0,0,0,0 },320970,320975, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {32,51,32,50 },
 new byte[]  { 0,0,0,0 },320978,320981, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {25,88,25,87 },
 new byte[]  { 0,0,0,0 },320988,320991, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {8,6,10,135,83,147 },
 new byte[]  { 0,0,0,0,0,0 },320998,321003, "Found dpf map...Delete map");
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