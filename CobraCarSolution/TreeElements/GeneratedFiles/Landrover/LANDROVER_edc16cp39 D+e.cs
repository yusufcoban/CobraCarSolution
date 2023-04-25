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
  class LANDROVER_edc16cp39 : MenuItem, ITreeItem  {
    public LANDROVER_edc16cp39()  {
      Title = "LANDROVER_edc16cp39";
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
		validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {16 },  1585574    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {16 },  1585576    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {16 },  1585578    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {16 },  1585580    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {16 },  1585582    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {16 },  1585586    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {16 },  1585588    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {16 },  1585590    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {16 },  1585592    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {16 },  1585594    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {16 },  1585602    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {16 },  1585604    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {16 },  1585606    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {16 },  1585618    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {16 },  1585630    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {16 },  1585632    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {16 },  1585634    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {16 },  1585636    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {16 },  1585638    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {16 },  1585640    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {16 },  1585642    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {16 },  1585774    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {16 },  1585776    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {16 },  1585778    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {16 },  1585780    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {16 },  1585782    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {16 },  1585786    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {16 },  1585788    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {16 },  1585790    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {16 },  1585792    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {16 },  1585794    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {16 },  1585802    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {16 },  1585804    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {16 },  1585806    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {16 },  1585818    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {16 },  1585830    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {16 },  1585832    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {16 },  1585834    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {16 },  1585836    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {16 },  1585838    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {16 },  1585840    );
      }
      return validationEgrInFile;
    }
    public override async Task < bool > checkFileForDpf()  {
      bool validationEgrInFile = true;
      //Algo for checking dpf solution
      if (ToolBox.array.Length > 0)  {
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {0,0,0,0,5,120,5,120,5,120,5,120,5,120,5,120,5,120,5,120,5,120,5,120,1,244,1,244,1,244,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },  1629442    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {39,16,39,16,39,16,39,16,39,16,39,16,39,16,39,16,39,16,39,16,39,16,39,16,39,16,39,16,39,16,39,16,39,16,39,16,39,16,39,16,39,16,39,16,39,16,39,16,39,16 },  1629544    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1 },  1634642    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,33 },  1634649    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {33 },  1634657    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {33 },  1634659    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {2 },  1634665    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {33 },  1634668    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {33 },  1634685    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {33 },  1634689    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {33 },  1634691    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1 },  1634693    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {33 },  1634696    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {33 },  1634698    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {33 },  1634701    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {33,1 },  1634704    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {33 },  1634707    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {33 },  1634730    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1 },  1634733    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {85 },  1634753    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {33 },  1634758    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {33,33 },  1634761    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {33,1 },  1634764    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,33 },  1634770    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {34,33 },  1634774    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {22,21 },  1634780    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {34 },  1634798    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1 },  1634802    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {33 },  1634824    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1 },  1634826    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1 },  1634831    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {34,1 },  1634834    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,1,1 },  1634837    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {34,34,34,34,34 },  1634841    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {34,1 },  1634847    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {34,1 },  1634850    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {34,1 },  1634853    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {34,1 },  1634856    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {33 },  1634879    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {34,34,34 },  1634905    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {34,33 },  1634921    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {33,34 },  1634924    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {34,34,34 },  1634927    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {34,33,33 },  1634931    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {34,102,33,33,33,34 },  1634936    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {33,102 },  1634943    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {102 },  1634947    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {34,34,1,1,1 },  1634949    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {33,33,33,34,33,33,33,33,34,33,33 },  1634956    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {34,33,33,34 },  1634968    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1 },  1634976    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {33,33,33,33 },  1634980    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {33,1 },  1634988    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,1,1,2,2,2,2,12 },  1634995    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {4 },  1635005    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {4,6 },  1635012    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {6 },  1635020    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {6 },  1635022    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,1,1,1,1,12 },  1635026    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3 },  1635041    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {2 },  1635043    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {12 },  1635048    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {12 },  1635052    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {18 },  1635054    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {12 },  1635056    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {12 },  1635059    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {12 },  1635061    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {12 },  1635064    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {12 },  1635067    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {18 },  1635070    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {2,2 },  1635078    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {12,20,20,17 },  1635093    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1 },  1635108    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {2,2,1,1,1,12,2 },  1635111    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {2,20,4 },  1635119    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {4,6 },  1635124    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {4,4,2,2,2,2,4,7,2,2,2,12 },  1635127    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {2,2 },  1635141    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1 },  1635158    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {2,1 },  1635160    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,2 },  1635163    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {2,2,2 },  1635167    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {16,1 },  1635173    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,1 },  1635176    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,1,3 },  1635179    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,1 },  1635183    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {12,10,8 },  1635187    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {8 },  1635194    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3,8 },  1635197    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {8,8,8,2,2,9,2,9,9,2,10,8,10,10,8,10,10,8,10,10,8,10 },  1635200    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {10,14,14,14,14,14,14,14,14,14,14,14,14,14,14,14,19,1,1 },  1635226    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,1 },  1635246    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,1 },  1635249    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {2,1,1,1,1,1,1,1,1,1,1,1,1 },  1635252    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {14 },  1635266    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {9,9,9 },  1635268    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {12,2,2,2,1,12,12 },  1635272    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {14,2,2 },  1635281    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {18 },  1635287    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {9,9,9 },  1635290    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {2 },  1635294    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {18,12,12 },  1635300    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {2 },  1635304    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {2 },  1635309    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {9 },  1635312    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {8,8,8 },  1635314    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {8,8,8,9,8,8,8,8,9,8,8 },  1635319    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {9,12,12,14,1 },  1635331    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {2,2,2,2,16,2,12,12,18,12,2,2,2,2,12,4,2 },  1635337    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,20,2 },  1635355    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },  1667736    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,59,2,68,3,152,4,54,5,220,5,170,2,163 },  1817224    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,59,2,68,3,152,4,54,5,221,5,170,2,163 },  1817272    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,64,2,88,3,132,4,76,7,106,7,53,3,32,1,144 },  1817320    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,86,2,128,3,192,4,101,7,38,7,58,5,156,1,221 },  1817368    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,104,2,128,3,194,4,171,7,28,7,66,7,193,6,70,3,101,1,254 },  1817416    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,14,2,53,2,198,3,132,6,244,7,58,8,30,7,84,6,240,6,58,3,32,1,144 },  1817464    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,64,2,82,2,228,3,222,8,95,8,162,9,21,8,137,8,42,7,249,7,174,4,176,2,88,1,44 },  1817512    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,94,2,88,2,228,3,142,9,27,9,167,10,44,10,58,9,177,9,92,8,186,7,247,5,99,2,138 },  1817560    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,74,2,35,2,218,3,72,8,192,9,113,10,16,9,239,9,60,8,245,8,65,6,151,3,32 },  1817608    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,44,2,18,2,88,3,112,9,47,9,169,10,26,9,232,9,73,9,4,8,162,7,92,3,238 },  1817656    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {250,2,8,2,198,3,182,8,211,9,55,10,57,9,241,9,45,8,120,7,160,4,128,3,134 },  1817705    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,75,2,183,4,79,8,58,8,100,8,190,9,172,9,152,9,15,8,29,6,34,3,194 },  1817752    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,74,2,168,5,21,7,168,8,52,8,193,9,34,8,252,7,242,6,68,4,205,2,83 },  1817800    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,118,2,198,5,149,7,49,7,119,7,107,7,233,7,80,5,218,4,66,2,23 },  1817848    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {238 },  1817871    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,124,2,238,5,119,6,173,6,232,6,189,6,247,5,236,5,21,3,142 },  1817896    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {251 },  1817917    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,94,2,238,4,47,5,6,5,14,4,142,4,74,3,224,3,37,1,234 },  1817944    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,89,1,251,2,15,3,112,3,232,3,232,3,232,3,32,1,144 },  1818374    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,92,2,55,2,115,4,75,4,175,5,141,4,177,3,111,1,144 },  1818422    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,112,3,30,4,184,5,90,6,134,7,248,9,36,6,134,3,32 },  1818470    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,99,3,22,4,106,5,150,7,118,8,82,8,182,8,98,5,197,2,226 },  1818518    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,86,3,12,4,76,6,54,7,168,8,156,9,95,9,24,8,25,5,200,3,2,1,74 },  1818566    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,73,2,122,4,146,6,54,7,178,8,202,9,57,9,106,9,61,8,52,6,4,5,140,2,238 },  1818614    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,69,2,183,4,186,5,130,7,124,8,152,9,96,10,23,9,124,9,18,8,220,8,136,6,114,2,248,1,124 },  1818662    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,94,2,193,4,196,6,16,7,165,8,183,9,167,10,44,10,58,9,177,9,92,8,186,7,247,5,99,2,88 },  1818710    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,64,2,193,5,68,6,62,7,166,8,192,9,113,10,16,9,239,9,60,8,245,8,65,6,151,4,100 },  1818758    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,4,2,150,5,110,6,12,7,186,9,45,9,169,10,26,9,232,9,73,9,4,8,162,7,92,3,238 },  1818806    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {200,2,108,5,100,6,144,7,179,8,211,9,55,10,57,9,241,9,45,8,120,7,160,4,128,3,134 },  1818855    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {150,2,38,5,90,6,64,7,174,8,100,8,190,9,172,9,152,9,15,8,29,6,34,3,194 },  1818903    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {200,1,244,5,120,5,188,7,18,8,52,8,193,9,34,8,252,7,242,6,68,4,205,2,83 },  1818951    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {200,2,226,5,180,5,198,6,205,7,119,7,107,7,233,7,80,5,218,4,66,2,23 },  1818999    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {238 },  1819023    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,31,2,148,5,170,5,190,6,64,6,232,6,189,6,247,5,236,5,21,3,142 },  1819046    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {251 },  1819069    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,31,2,91,4,26,5,80,5,150,6,82,5,177,5,92,4,216,3,238,2,101 },  1819094    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {143,1,59,2,13,2,24,2,188,3,12,2,138,2,68,2,8,1,244,1,194 },  1819143    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {6 },  1881295    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {2 },  1881299    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {2 },  1881303    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {2 },  1881315    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {2 },  1881323    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {6 },  1881327    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1 },  1881331    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1 },  1881339    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {2 },  1881343    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {8 },  1881347    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {6 },  1881351    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1 },  1881377    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,1,1,1,1,1 },  1881380    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,1,1,1,1,1,1,1 },  1881389    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1 },  1881400    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1 },  1881405    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1 },  1881407    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {0,0,16,0,32,0,48,0,64,0,0,0,16,0,32,0,48,0,64,0,0,5,0,0,16,0,32,0,48,0,64,0,0,0,0,1,0,0,0,0,32,0,0,0,0,0,0,0,0,0 },  1902520    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {0,1,0,0,0,0,2,0,3,255,0,0,0,0,0,0,0,0,3,32,2,88,9,196,9,196,0,0,0,0,0,0,0,0,0,0,0,1,10,171,0,0,11,115,13,3,13,203,14,147 },  1906728    );
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
	ToolBox.ReplaceInFileWithStartStop(new byte[]  {16 },
 new byte[]  { 0 },1585574,1585574, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {16 },
 new byte[]  { 0 },1585576,1585576, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {16 },
 new byte[]  { 0 },1585578,1585578, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {16 },
 new byte[]  { 0 },1585580,1585580, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {16 },
 new byte[]  { 0 },1585582,1585582, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {16 },
 new byte[]  { 0 },1585586,1585586, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {16 },
 new byte[]  { 0 },1585588,1585588, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {16 },
 new byte[]  { 0 },1585590,1585590, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {16 },
 new byte[]  { 0 },1585592,1585592, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {16 },
 new byte[]  { 0 },1585594,1585594, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {16 },
 new byte[]  { 0 },1585602,1585602, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {16 },
 new byte[]  { 0 },1585604,1585604, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {16 },
 new byte[]  { 0 },1585606,1585606, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {16 },
 new byte[]  { 0 },1585618,1585618, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {16 },
 new byte[]  { 0 },1585630,1585630, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {16 },
 new byte[]  { 0 },1585632,1585632, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {16 },
 new byte[]  { 0 },1585634,1585634, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {16 },
 new byte[]  { 0 },1585636,1585636, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {16 },
 new byte[]  { 0 },1585638,1585638, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {16 },
 new byte[]  { 0 },1585640,1585640, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {16 },
 new byte[]  { 0 },1585642,1585642, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {16 },
 new byte[]  { 0 },1585774,1585774, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {16 },
 new byte[]  { 0 },1585776,1585776, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {16 },
 new byte[]  { 0 },1585778,1585778, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {16 },
 new byte[]  { 0 },1585780,1585780, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {16 },
 new byte[]  { 0 },1585782,1585782, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {16 },
 new byte[]  { 0 },1585786,1585786, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {16 },
 new byte[]  { 0 },1585788,1585788, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {16 },
 new byte[]  { 0 },1585790,1585790, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {16 },
 new byte[]  { 0 },1585792,1585792, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {16 },
 new byte[]  { 0 },1585794,1585794, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {16 },
 new byte[]  { 0 },1585802,1585802, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {16 },
 new byte[]  { 0 },1585804,1585804, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {16 },
 new byte[]  { 0 },1585806,1585806, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {16 },
 new byte[]  { 0 },1585818,1585818, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {16 },
 new byte[]  { 0 },1585830,1585830, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {16 },
 new byte[]  { 0 },1585832,1585832, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {16 },
 new byte[]  { 0 },1585834,1585834, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {16 },
 new byte[]  { 0 },1585836,1585836, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {16 },
 new byte[]  { 0 },1585838,1585838, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {16 },
 new byte[]  { 0 },1585840,1585840, "Found egr map...Delete map");
      base.egrOffSolution();
    }
    public override void dpfOffSolution()  {
	ToolBox.ReplaceInFileWithStartStop(new byte[]  {0,0,0,0,5,120,5,120,5,120,5,120,5,120,5,120,5,120,5,120,5,120,5,120,1,244,1,244,1,244,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },
 new byte[]  { 24,24,24,24,24,24,24,24,24,24,24,24,24,24,24,24,24,24,24,24,24,24,24,24,24,24,24,24,24,24,24,24,24,24,24,24,24,24,24,24,24,24,24,24,24,24,24,24,24 },1629442,1629490, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {39,16,39,16,39,16,39,16,39,16,39,16,39,16,39,16,39,16,39,16,39,16,39,16,39,16,39,16,39,16,39,16,39,16,39,16,39,16,39,16,39,16,39,16,39,16,39,16,39,16 },
 new byte[]  { 24,24,24,24,24,24,24,24,24,24,24,24,24,24,24,24,24,24,24,24,24,24,24,24,24,24,24,24,24,24,24,24,24,24,24,24,24,24,24,24,24,24,24,24,24,24,24,24,24,24 },1629544,1629593, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1 },
 new byte[]  { 0 },1634642,1634642, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,33 },
 new byte[]  { 0,0 },1634649,1634650, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {33 },
 new byte[]  { 0 },1634657,1634657, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {33 },
 new byte[]  { 0 },1634659,1634659, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {2 },
 new byte[]  { 0 },1634665,1634665, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {33 },
 new byte[]  { 0 },1634668,1634668, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {33 },
 new byte[]  { 0 },1634685,1634685, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {33 },
 new byte[]  { 0 },1634689,1634689, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {33 },
 new byte[]  { 0 },1634691,1634691, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1 },
 new byte[]  { 0 },1634693,1634693, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {33 },
 new byte[]  { 0 },1634696,1634696, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {33 },
 new byte[]  { 0 },1634698,1634698, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {33 },
 new byte[]  { 0 },1634701,1634701, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {33,1 },
 new byte[]  { 0,0 },1634704,1634705, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {33 },
 new byte[]  { 0 },1634707,1634707, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {33 },
 new byte[]  { 0 },1634730,1634730, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1 },
 new byte[]  { 0 },1634733,1634733, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {85 },
 new byte[]  { 0 },1634753,1634753, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {33 },
 new byte[]  { 0 },1634758,1634758, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {33,33 },
 new byte[]  { 0,0 },1634761,1634762, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {33,1 },
 new byte[]  { 0,0 },1634764,1634765, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,33 },
 new byte[]  { 0,0 },1634770,1634771, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {34,33 },
 new byte[]  { 0,0 },1634774,1634775, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {22,21 },
 new byte[]  { 0,0 },1634780,1634781, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {34 },
 new byte[]  { 0 },1634798,1634798, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1 },
 new byte[]  { 0 },1634802,1634802, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {33 },
 new byte[]  { 0 },1634824,1634824, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1 },
 new byte[]  { 0 },1634826,1634826, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1 },
 new byte[]  { 0 },1634831,1634831, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {34,1 },
 new byte[]  { 0,0 },1634834,1634835, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,1,1 },
 new byte[]  { 0,0,0 },1634837,1634839, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {34,34,34,34,34 },
 new byte[]  { 0,0,0,0,0 },1634841,1634845, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {34,1 },
 new byte[]  { 0,0 },1634847,1634848, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {34,1 },
 new byte[]  { 0,0 },1634850,1634851, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {34,1 },
 new byte[]  { 0,0 },1634853,1634854, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {34,1 },
 new byte[]  { 0,0 },1634856,1634857, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {33 },
 new byte[]  { 0 },1634879,1634879, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {34,34,34 },
 new byte[]  { 0,0,0 },1634905,1634907, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {34,33 },
 new byte[]  { 0,0 },1634921,1634922, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {33,34 },
 new byte[]  { 0,0 },1634924,1634925, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {34,34,34 },
 new byte[]  { 0,0,0 },1634927,1634929, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {34,33,33 },
 new byte[]  { 0,0,0 },1634931,1634933, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {34,102,33,33,33,34 },
 new byte[]  { 0,0,0,0,0,0 },1634936,1634941, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {33,102 },
 new byte[]  { 0,0 },1634943,1634944, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {102 },
 new byte[]  { 0 },1634947,1634947, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {34,34,1,1,1 },
 new byte[]  { 0,0,0,0,0 },1634949,1634953, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {33,33,33,34,33,33,33,33,34,33,33 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0 },1634956,1634966, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {34,33,33,34 },
 new byte[]  { 0,0,0,0 },1634968,1634971, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1 },
 new byte[]  { 0 },1634976,1634976, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {33,33,33,33 },
 new byte[]  { 0,0,0,0 },1634980,1634983, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {33,1 },
 new byte[]  { 0,0 },1634988,1634989, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,1,1,2,2,2,2,12 },
 new byte[]  { 0,0,0,0,0,0,0,0 },1634995,1635002, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {4 },
 new byte[]  { 0 },1635005,1635005, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {4,6 },
 new byte[]  { 0,0 },1635012,1635013, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {6 },
 new byte[]  { 0 },1635020,1635020, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {6 },
 new byte[]  { 0 },1635022,1635022, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,1,1,1,1,12 },
 new byte[]  { 0,0,0,0,0,0 },1635026,1635031, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3 },
 new byte[]  { 0 },1635041,1635041, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {2 },
 new byte[]  { 0 },1635043,1635043, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {12 },
 new byte[]  { 0 },1635048,1635048, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {12 },
 new byte[]  { 0 },1635052,1635052, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {18 },
 new byte[]  { 0 },1635054,1635054, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {12 },
 new byte[]  { 0 },1635056,1635056, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {12 },
 new byte[]  { 0 },1635059,1635059, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {12 },
 new byte[]  { 0 },1635061,1635061, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {12 },
 new byte[]  { 0 },1635064,1635064, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {12 },
 new byte[]  { 0 },1635067,1635067, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {18 },
 new byte[]  { 0 },1635070,1635070, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {2,2 },
 new byte[]  { 0,0 },1635078,1635079, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {12,20,20,17 },
 new byte[]  { 0,0,0,0 },1635093,1635096, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1 },
 new byte[]  { 0 },1635108,1635108, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {2,2,1,1,1,12,2 },
 new byte[]  { 0,0,0,0,0,0,0 },1635111,1635117, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {2,20,4 },
 new byte[]  { 0,0,0 },1635119,1635121, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {4,6 },
 new byte[]  { 0,0 },1635124,1635125, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {4,4,2,2,2,2,4,7,2,2,2,12 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0 },1635127,1635138, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {2,2 },
 new byte[]  { 0,0 },1635141,1635142, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1 },
 new byte[]  { 0 },1635158,1635158, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {2,1 },
 new byte[]  { 0,0 },1635160,1635161, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,2 },
 new byte[]  { 0,0 },1635163,1635164, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {2,2,2 },
 new byte[]  { 0,0,0 },1635167,1635169, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {16,1 },
 new byte[]  { 0,0 },1635173,1635174, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,1 },
 new byte[]  { 0,0 },1635176,1635177, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,1,3 },
 new byte[]  { 0,0,0 },1635179,1635181, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,1 },
 new byte[]  { 0,0 },1635183,1635184, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {12,10,8 },
 new byte[]  { 0,0,0 },1635187,1635189, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {8 },
 new byte[]  { 0 },1635194,1635194, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3,8 },
 new byte[]  { 0,0 },1635197,1635198, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {8,8,8,2,2,9,2,9,9,2,10,8,10,10,8,10,10,8,10,10,8,10 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },1635200,1635221, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {10,14,14,14,14,14,14,14,14,14,14,14,14,14,14,14,19,1,1 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },1635226,1635244, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,1 },
 new byte[]  { 0,0 },1635246,1635247, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,1 },
 new byte[]  { 0,0 },1635249,1635250, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {2,1,1,1,1,1,1,1,1,1,1,1,1 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0 },1635252,1635264, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {14 },
 new byte[]  { 0 },1635266,1635266, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {9,9,9 },
 new byte[]  { 0,0,0 },1635268,1635270, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {12,2,2,2,1,12,12 },
 new byte[]  { 0,0,0,0,0,0,0 },1635272,1635278, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {14,2,2 },
 new byte[]  { 0,0,0 },1635281,1635283, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {18 },
 new byte[]  { 0 },1635287,1635287, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {9,9,9 },
 new byte[]  { 0,0,0 },1635290,1635292, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {2 },
 new byte[]  { 0 },1635294,1635294, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {18,12,12 },
 new byte[]  { 0,0,0 },1635300,1635302, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {2 },
 new byte[]  { 0 },1635304,1635304, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {2 },
 new byte[]  { 0 },1635309,1635309, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {9 },
 new byte[]  { 0 },1635312,1635312, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {8,8,8 },
 new byte[]  { 0,0,0 },1635314,1635316, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {8,8,8,9,8,8,8,8,9,8,8 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0 },1635319,1635329, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {9,12,12,14,1 },
 new byte[]  { 0,0,0,0,0 },1635331,1635335, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {2,2,2,2,16,2,12,12,18,12,2,2,2,2,12,4,2 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },1635337,1635353, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,20,2 },
 new byte[]  { 0,0,0 },1635355,1635357, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },
 new byte[]  { 32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32 },1667736,1667783, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,59,2,68,3,152,4,54,5,220,5,170,2,163 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0 },1817224,1817237, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,59,2,68,3,152,4,54,5,221,5,170,2,163 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0 },1817272,1817285, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,64,2,88,3,132,4,76,7,106,7,53,3,32,1,144 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },1817320,1817335, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,86,2,128,3,192,4,101,7,38,7,58,5,156,1,221 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },1817368,1817383, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,104,2,128,3,194,4,171,7,28,7,66,7,193,6,70,3,101,1,254 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },1817416,1817435, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,14,2,53,2,198,3,132,6,244,7,58,8,30,7,84,6,240,6,58,3,32,1,144 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },1817464,1817487, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,64,2,82,2,228,3,222,8,95,8,162,9,21,8,137,8,42,7,249,7,174,4,176,2,88,1,44 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },1817512,1817539, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,94,2,88,2,228,3,142,9,27,9,167,10,44,10,58,9,177,9,92,8,186,7,247,5,99,2,138 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },1817560,1817587, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,74,2,35,2,218,3,72,8,192,9,113,10,16,9,239,9,60,8,245,8,65,6,151,3,32 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },1817608,1817633, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,44,2,18,2,88,3,112,9,47,9,169,10,26,9,232,9,73,9,4,8,162,7,92,3,238 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },1817656,1817681, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {250,2,8,2,198,3,182,8,211,9,55,10,57,9,241,9,45,8,120,7,160,4,128,3,134 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },1817705,1817729, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,75,2,183,4,79,8,58,8,100,8,190,9,172,9,152,9,15,8,29,6,34,3,194 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },1817752,1817775, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,74,2,168,5,21,7,168,8,52,8,193,9,34,8,252,7,242,6,68,4,205,2,83 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },1817800,1817823, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,118,2,198,5,149,7,49,7,119,7,107,7,233,7,80,5,218,4,66,2,23 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },1817848,1817869, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {238 },
 new byte[]  { 0 },1817871,1817871, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,124,2,238,5,119,6,173,6,232,6,189,6,247,5,236,5,21,3,142 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },1817896,1817915, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {251 },
 new byte[]  { 0 },1817917,1817917, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,94,2,238,4,47,5,6,5,14,4,142,4,74,3,224,3,37,1,234 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },1817944,1817963, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,89,1,251,2,15,3,112,3,232,3,232,3,232,3,32,1,144 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },1818374,1818391, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,92,2,55,2,115,4,75,4,175,5,141,4,177,3,111,1,144 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },1818422,1818439, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,112,3,30,4,184,5,90,6,134,7,248,9,36,6,134,3,32 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },1818470,1818487, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,99,3,22,4,106,5,150,7,118,8,82,8,182,8,98,5,197,2,226 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },1818518,1818537, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,86,3,12,4,76,6,54,7,168,8,156,9,95,9,24,8,25,5,200,3,2,1,74 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },1818566,1818589, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,73,2,122,4,146,6,54,7,178,8,202,9,57,9,106,9,61,8,52,6,4,5,140,2,238 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },1818614,1818639, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,69,2,183,4,186,5,130,7,124,8,152,9,96,10,23,9,124,9,18,8,220,8,136,6,114,2,248,1,124 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },1818662,1818691, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,94,2,193,4,196,6,16,7,165,8,183,9,167,10,44,10,58,9,177,9,92,8,186,7,247,5,99,2,88 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },1818710,1818739, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,64,2,193,5,68,6,62,7,166,8,192,9,113,10,16,9,239,9,60,8,245,8,65,6,151,4,100 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },1818758,1818785, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,4,2,150,5,110,6,12,7,186,9,45,9,169,10,26,9,232,9,73,9,4,8,162,7,92,3,238 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },1818806,1818833, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {200,2,108,5,100,6,144,7,179,8,211,9,55,10,57,9,241,9,45,8,120,7,160,4,128,3,134 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },1818855,1818881, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {150,2,38,5,90,6,64,7,174,8,100,8,190,9,172,9,152,9,15,8,29,6,34,3,194 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },1818903,1818927, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {200,1,244,5,120,5,188,7,18,8,52,8,193,9,34,8,252,7,242,6,68,4,205,2,83 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },1818951,1818975, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {200,2,226,5,180,5,198,6,205,7,119,7,107,7,233,7,80,5,218,4,66,2,23 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },1818999,1819021, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {238 },
 new byte[]  { 0 },1819023,1819023, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,31,2,148,5,170,5,190,6,64,6,232,6,189,6,247,5,236,5,21,3,142 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },1819046,1819067, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {251 },
 new byte[]  { 0 },1819069,1819069, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,31,2,91,4,26,5,80,5,150,6,82,5,177,5,92,4,216,3,238,2,101 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },1819094,1819115, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {143,1,59,2,13,2,24,2,188,3,12,2,138,2,68,2,8,1,244,1,194 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },1819143,1819163, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {6 },
 new byte[]  { 0 },1881295,1881295, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {2 },
 new byte[]  { 0 },1881299,1881299, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {2 },
 new byte[]  { 0 },1881303,1881303, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {2 },
 new byte[]  { 0 },1881315,1881315, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {2 },
 new byte[]  { 0 },1881323,1881323, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {6 },
 new byte[]  { 0 },1881327,1881327, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1 },
 new byte[]  { 0 },1881331,1881331, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1 },
 new byte[]  { 0 },1881339,1881339, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {2 },
 new byte[]  { 0 },1881343,1881343, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {8 },
 new byte[]  { 0 },1881347,1881347, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {6 },
 new byte[]  { 0 },1881351,1881351, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1 },
 new byte[]  { 0 },1881377,1881377, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,1,1,1,1,1 },
 new byte[]  { 0,0,0,0,0,0 },1881380,1881385, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,1,1,1,1,1,1,1 },
 new byte[]  { 0,0,0,0,0,0,0,0 },1881389,1881396, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1 },
 new byte[]  { 0 },1881400,1881400, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1 },
 new byte[]  { 0 },1881405,1881405, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1 },
 new byte[]  { 0 },1881407,1881407, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {0,0,16,0,32,0,48,0,64,0,0,0,16,0,32,0,48,0,64,0,0,5,0,0,16,0,32,0,48,0,64,0,0,0,0,1,0,0,0,0,32,0,0,0,0,0,0,0,0,0 },
 new byte[]  { 20,20,20,20,20,20,20,20,20,20,20,20,20,20,20,20,20,20,20,20,20,20,20,20,20,20,20,20,20,20,20,20,20,20,20,20,20,20,20,20,20,20,20,20,20,20,20,20,20,20 },1902520,1902569, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {0,1,0,0,0,0,2,0,3,255,0,0,0,0,0,0,0,0,3,32,2,88,9,196,9,196,0,0,0,0,0,0,0,0,0,0,0,1,10,171,0,0,11,115,13,3,13,203,14,147 },
 new byte[]  { 20,20,20,20,20,20,20,20,20,20,20,20,20,20,20,20,20,20,20,20,20,20,20,20,20,20,20,20,20,20,20,20,20,20,20,20,20,20,20,20,20,20,20,20,20,20,20,20,20,20 },1906728,1906777, "Found dpf map...Delete map");
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