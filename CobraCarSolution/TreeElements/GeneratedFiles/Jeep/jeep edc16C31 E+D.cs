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
  class jeep_edc16C31 :MenuItem, ITreeItem  {
    public jeep_edc16C31()  {
      Title = "JEEP_edc16C31";
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
		validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {11,84,11,84,11,84,11,84,12,128,13,172,15,160,15,160,15,160,15,160,15,160,15,160,15,160,15,160 },  1870396    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {255,255,255,255,10,240,10,240,10,240,10,240,12,28,13,72,15,60,15,60,15,60,15,60,15,60,15,60,15,60,15,60,255,255,255,255,255,255,255,255,127 },  1870638    );
      }
      return validationEgrInFile;
    }
    public override async Task < bool > checkFileForDpf()  {
      bool validationEgrInFile = true;
      //Algo for checking dpf solution
      if (ToolBox.array.Length > 0)  {
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {10,25,13,13,11,13,25,27,1,2,2,11,11,11 },  1894873    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {11 },  1894889    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {11 },  1894894    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {12,1,1,1,1 },  1894897    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,1,1 },  1894904    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1 },  1894908    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,1,1 },  1894913    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1 },  1894920    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {2,2,2,25,3 },  1894923    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3 },  1894930    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {11,1 },  1894932    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1 },  1894937    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1 },  1894944    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {2,1 },  1894946    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {2 },  1894952    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {13,13,1,1 },  1894955    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,1 },  1894965    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,1 },  1894969    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,1,1,1,1,1,1,1,1,1 },  1894976    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,1,1,1,1,1,1,1 },  1895008    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,1,1,1,1,1 },  1895018    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,1 },  1895026    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,1 },  1895029    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,1 },  1895037    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,1 },  1895058    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1 },  1895061    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1 },  1895063    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,1,1,1 },  1895065    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {11,12,1 },  1895074    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1 },  1895078    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {11 },  1895081    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {28 },  1895083    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {10 },  1895086    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {9,9,9,9 },  1895091    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {11,11,11,11 },  1895101    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {11,13 },  1895106    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {13 },  1895109    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {13 },  1895112    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {13 },  1895115    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,2,1,1,2,2,2,2 },  1895118    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {27 },  1895129    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {11,11 },  1895133    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {11,13 },  1895136    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {13,13 },  1895140    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  1895145    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {13,13,13,13 },  1895148    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {13 },  1895155    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {13,13,13,13,13,13,2,26,25,25 },  1895157    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1 },  1895168    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1 },  1895171    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {2 },  1895173    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {11 },  1895176    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {11,1,13,13,2,2,11,11,11,1,13,13,13 },  1895179    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {2,255,2,255,2,255,2,255,2,255,2,255,2,255,2,255,1,192,1,192,1,192,1,192,1,192,1,192,1,192,1,192,1,213,1,213,1,213,1,213,1,213,1,213,1,213,1,213,2,21,2,21,2,21,2,21,2,21,2,21,2,21,2,21,2,106,2,106,2,106,2,106,2,106,2,106,2,106,2,106,2,149,2,149,2,149,2,149,2,149,2,149,2,149,2,149,2,213,2,213,2,213,2,213,2,213,2,213,2,213,2,213,2,213,2,213,2,213,2,213,2,213,2,213,2,213,2,213 },  1965388    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {2,255,2,255,2,255,2,255,2,255,2,255,2,255,2,255,1,192,1,192,1,192,1,192,1,192,1,192,1,192,1,192,1,213,1,213,1,213,1,213,1,213,1,213,1,213,1,213,2,21,2,21,2,21,2,21,2,21,2,21,2,21,2,21,2,106,2,106,2,106,2,106,2,106,2,106,2,106,2,106,2,149,2,149,2,149,2,149,2,149,2,149,2,149,2,149,2,213,2,213,2,213,2,213,2,213,2,213,2,213,2,213,2,213,2,213,2,213,2,213,2,213,2,213,2,213,2,213 },  1965552    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {2,255,2,255,2,255,2,255,2,255,2,255,2,255,2,255,1,192,1,192,1,192,1,192,1,192,1,192,1,192,1,192,1,213,1,213,1,213,1,213,1,213,1,213,1,213,1,213,2,21,2,21,2,21,2,21,2,21,2,21,2,21,2,21,2,106,2,106,2,106,2,106,2,106,2,106,2,106,2,106,2,149,2,149,2,149,2,149,2,149,2,149,2,149,2,149,2,213,2,213,2,213,2,213,2,213,2,213,2,213,2,213,2,213,2,213,2,213,2,213,2,213,2,213,2,213,2,213 },  1965716    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,174,1,174,3,132,6,64,5,220,8,2,7,108,5,120,3,2 },  1972988    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,124,1,124,2,188,5,151,9,66,8,102,7,149,6,144,4,122 },  1973018    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {4,76,4,76,7,8,8,52,8,202,8,152,7,108,9,246,7,249,2,138 },  1973048    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {7,8,7,8,6,211,6,198,7,132,7,221,7,135,8,158,8,37,4,176 },  1973078    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {7,8,7,8,6,8,6,111,6,220,6,214,5,220,7,68,5,150,4,226 },  1973108    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {5,70,5,70,5,61,5,231,5,36,5,20,5,57,5,104,5,100,6,94 },  1973138    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {4,176,4,176,4,66,4,136,5,56,5,35,3,213,4,133,4,109,5,146 },  1973168    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,144,1,144,1,244,5,2,4,231,4,204,4,161,4,107,3,152,4,216 },  1973198    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {100 },  1973229    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {100,1,144,4,24,3,126,3,232,3,201,3,186,3,22,2,138 },  1973231    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {200 },  1973259    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {200,1,144,2,188,2,212,3,182,2,22,2,38,2,28,2,118 },  1973261    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,244,1,244,1,244,3,132,3,132,4,226,4,76,2,22 },  1973288    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {150 },  1973305    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {150 },  1973319    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {150 },  1973321    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {200 },  1973323    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {200,4,176,5,120,2,188,2,88,2,88 },  1973325    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {200 },  1973349    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {200 },  1973351    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {250 },  1973353    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {250,1,44,1,204,2,148,2,128 },  1973355    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,174,1,174,3,132,6,64,5,220,8,2,7,108,5,120,3,2 },  1973568    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,124,1,124,2,188,5,151,9,66,8,102,7,149,6,144,4,122 },  1973598    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {4,76,4,76,7,8,8,52,8,202,8,152,7,108,9,246,7,249,2,138 },  1973628    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {7,8,7,8,6,211,6,198,7,132,7,221,7,135,8,158,8,37,4,176 },  1973658    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {7,8,7,8,6,8,6,111,6,220,6,214,5,220,7,68,5,150,4,226 },  1973688    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {5,70,5,70,5,61,5,231,5,36,5,20,5,57,5,104,5,100,6,94 },  1973718    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {4,176,4,176,4,66,4,136,5,56,5,35,3,213,4,133,4,109,5,146 },  1973748    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,144,1,144,1,244,5,2,4,231,4,204,4,161,4,107,3,152,4,216 },  1973778    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {100 },  1973809    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {100,1,144,4,24,3,126,3,232,3,201,3,186,3,22,2,138 },  1973811    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {200 },  1973839    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {200,1,144,2,188,2,212,3,182,2,22,2,38,2,28,2,118 },  1973841    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,244,1,244,1,244,3,132,3,132,4,226,4,76,2,22 },  1973868    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {150 },  1973885    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {150 },  1973899    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {150 },  1973901    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {200 },  1973903    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {200,4,176,5,120,2,188,2,88,2,88 },  1973905    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {200 },  1973929    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {200 },  1973931    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {250 },  1973933    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {250,1,44,1,204,2,148,2,128 },  1973935    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,174,1,174,3,132,6,64,5,220,8,2,7,108,5,120,3,2 },  1974148    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,124,1,124,2,188,5,151,9,66,8,102,7,149,6,144,4,122 },  1974178    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {4,76,4,76,7,8,8,52,8,202,8,152,7,108,9,246,7,249,2,138 },  1974208    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {7,8,7,8,6,211,6,198,7,132,7,221,7,135,8,158,8,37,4,176 },  1974238    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {7,8,7,8,6,8,6,111,6,220,6,214,5,220,7,68,5,150,4,226 },  1974268    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {5,70,5,70,5,61,5,231,5,36,5,20,5,57,5,104,5,100,6,94 },  1974298    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {4,176,4,176,4,66,4,136,5,56,5,35,3,213,4,133,4,109,5,146 },  1974328    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,144,1,144,1,244,5,2,4,231,4,204,4,161,4,107,3,152,4,216 },  1974358    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {100 },  1974389    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {100,1,144,4,24,3,126,3,232,3,201,3,186,3,22,2,138 },  1974391    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {200 },  1974419    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {200,1,144,2,188,2,212,3,182,2,22,2,38,2,28,2,118 },  1974421    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,244,1,244,1,244,3,132,3,132,4,226,4,76,2,22 },  1974448    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {150 },  1974465    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {150 },  1974479    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {150 },  1974481    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {200 },  1974483    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {200,4,176,5,120,2,188,2,88,2,88 },  1974485    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {200 },  1974509    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {200 },  1974511    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {250 },  1974513    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {250,1,44,1,204,2,148,2,128 },  1974515    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,174,1,174,3,132,6,64,5,220,8,2,7,108,5,120,3,2 },  1974728    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,124,1,124,2,188,5,151,9,66,8,102,7,149,6,144,4,122 },  1974758    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {4,76,4,76,7,8,8,52,8,202,8,152,7,108,9,246,7,249,2,138 },  1974788    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {7,8,7,8,6,211,6,198,7,132,7,221,7,135,8,158,8,37,4,176 },  1974818    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {7,8,7,8,6,8,6,111,6,220,6,214,5,220,7,68,5,150,4,226 },  1974848    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {5,70,5,70,5,61,5,231,5,36,5,20,5,57,5,104,5,100,6,94 },  1974878    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {4,176,4,176,4,66,4,136,5,56,5,35,3,213,4,133,4,109,5,146 },  1974908    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,144,1,144,1,244,5,2,4,231,4,204,4,161,4,107,3,152,4,216 },  1974938    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {100 },  1974969    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {100,1,144,4,24,3,126,3,232,3,201,3,186,3,22,2,138 },  1974971    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {200 },  1974999    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {200,1,144,2,188,2,212,3,182,2,22,2,38,2,28,2,118 },  1975001    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,244,1,244,1,244,3,132,3,132,4,226,4,76,2,22 },  1975028    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {150 },  1975045    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {150 },  1975059    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {150 },  1975061    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {200 },  1975063    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {200,4,176,5,120,2,188,2,88,2,88 },  1975065    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {200 },  1975089    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {200 },  1975091    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {250 },  1975093    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {250,1,44,1,204,2,148,2,128 },  1975095    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3 },  2017600    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3,3 },  2017607    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3,3 },  2017615    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {2,3,6 },  2017623    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,2,3,6 },  2017630    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,1,2,3,6 },  2017637    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3 },  2017648    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {4,6 },  2017656    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {6,1,2 },  2017660    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3,4 },  2017664    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1 },  2017667    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3 },  2018099    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1 },  2018103    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1 },  2018107    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {4 },  2018111    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1 },  2018115    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1 },  2018123    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3,1 },  2018127    );
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
	ToolBox.ReplaceInFileWithStartStop(new byte[]  {11,84,11,84,11,84,11,84,12,128,13,172,15,160,15,160,15,160,15,160,15,160,15,160,15,160,15,160 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },1870396,1870423, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {255,255,255,255,10,240,10,240,10,240,10,240,12,28,13,72,15,60,15,60,15,60,15,60,15,60,15,60,15,60,15,60,255,255,255,255,255,255,255,255,127 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },1870638,1870678, "Found egr map...Delete map");
      base.egrOffSolution();
    }
    public override void dpfOffSolution()  {
	ToolBox.ReplaceInFileWithStartStop(new byte[]  {10,25,13,13,11,13,25,27,1,2,2,11,11,11 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0 },1894873,1894886, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {11 },
 new byte[]  { 0 },1894889,1894889, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {11 },
 new byte[]  { 0 },1894894,1894894, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {12,1,1,1,1 },
 new byte[]  { 0,0,0,0,0 },1894897,1894901, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,1,1 },
 new byte[]  { 0,0,0 },1894904,1894906, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1 },
 new byte[]  { 0 },1894908,1894908, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,1,1 },
 new byte[]  { 0,0,0 },1894913,1894915, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1 },
 new byte[]  { 0 },1894920,1894920, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {2,2,2,25,3 },
 new byte[]  { 0,0,0,0,0 },1894923,1894927, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3 },
 new byte[]  { 0 },1894930,1894930, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {11,1 },
 new byte[]  { 0,0 },1894932,1894933, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1 },
 new byte[]  { 0 },1894937,1894937, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1 },
 new byte[]  { 0 },1894944,1894944, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {2,1 },
 new byte[]  { 0,0 },1894946,1894947, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {2 },
 new byte[]  { 0 },1894952,1894952, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {13,13,1,1 },
 new byte[]  { 0,0,0,0 },1894955,1894958, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,1 },
 new byte[]  { 0,0 },1894965,1894966, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,1 },
 new byte[]  { 0,0 },1894969,1894970, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,1,1,1,1,1,1,1,1,1 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0 },1894976,1894985, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,1,1,1,1,1,1,1 },
 new byte[]  { 0,0,0,0,0,0,0,0 },1895008,1895015, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,1,1,1,1,1 },
 new byte[]  { 0,0,0,0,0,0 },1895018,1895023, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,1 },
 new byte[]  { 0,0 },1895026,1895027, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,1 },
 new byte[]  { 0,0 },1895029,1895030, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,1 },
 new byte[]  { 0,0 },1895037,1895038, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,1 },
 new byte[]  { 0,0 },1895058,1895059, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1 },
 new byte[]  { 0 },1895061,1895061, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1 },
 new byte[]  { 0 },1895063,1895063, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,1,1,1 },
 new byte[]  { 0,0,0,0 },1895065,1895068, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {11,12,1 },
 new byte[]  { 0,0,0 },1895074,1895076, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1 },
 new byte[]  { 0 },1895078,1895078, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {11 },
 new byte[]  { 0 },1895081,1895081, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {28 },
 new byte[]  { 0 },1895083,1895083, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {10 },
 new byte[]  { 0 },1895086,1895086, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {9,9,9,9 },
 new byte[]  { 0,0,0,0 },1895091,1895094, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {11,11,11,11 },
 new byte[]  { 0,0,0,0 },1895101,1895104, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {11,13 },
 new byte[]  { 0,0 },1895106,1895107, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {13 },
 new byte[]  { 0 },1895109,1895109, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {13 },
 new byte[]  { 0 },1895112,1895112, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {13 },
 new byte[]  { 0 },1895115,1895115, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,2,1,1,2,2,2,2 },
 new byte[]  { 0,0,0,0,0,0,0,0 },1895118,1895125, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {27 },
 new byte[]  { 0 },1895129,1895129, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {11,11 },
 new byte[]  { 0,0 },1895133,1895134, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {11,13 },
 new byte[]  { 0,0 },1895136,1895137, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {13,13 },
 new byte[]  { 0,0 },1895140,1895141, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },1895145,1895145, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {13,13,13,13 },
 new byte[]  { 0,0,0,0 },1895148,1895151, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {13 },
 new byte[]  { 0 },1895155,1895155, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {13,13,13,13,13,13,2,26,25,25 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0 },1895157,1895166, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1 },
 new byte[]  { 0 },1895168,1895168, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1 },
 new byte[]  { 0 },1895171,1895171, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {2 },
 new byte[]  { 0 },1895173,1895173, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {11 },
 new byte[]  { 0 },1895176,1895176, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {11,1,13,13,2,2,11,11,11,1,13,13,13 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0 },1895179,1895191, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {2,255,2,255,2,255,2,255,2,255,2,255,2,255,2,255,1,192,1,192,1,192,1,192,1,192,1,192,1,192,1,192,1,213,1,213,1,213,1,213,1,213,1,213,1,213,1,213,2,21,2,21,2,21,2,21,2,21,2,21,2,21,2,21,2,106,2,106,2,106,2,106,2,106,2,106,2,106,2,106,2,149,2,149,2,149,2,149,2,149,2,149,2,149,2,149,2,213,2,213,2,213,2,213,2,213,2,213,2,213,2,213,2,213,2,213,2,213,2,213,2,213,2,213,2,213,2,213 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },1965388,1965515, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {2,255,2,255,2,255,2,255,2,255,2,255,2,255,2,255,1,192,1,192,1,192,1,192,1,192,1,192,1,192,1,192,1,213,1,213,1,213,1,213,1,213,1,213,1,213,1,213,2,21,2,21,2,21,2,21,2,21,2,21,2,21,2,21,2,106,2,106,2,106,2,106,2,106,2,106,2,106,2,106,2,149,2,149,2,149,2,149,2,149,2,149,2,149,2,149,2,213,2,213,2,213,2,213,2,213,2,213,2,213,2,213,2,213,2,213,2,213,2,213,2,213,2,213,2,213,2,213 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },1965552,1965679, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {2,255,2,255,2,255,2,255,2,255,2,255,2,255,2,255,1,192,1,192,1,192,1,192,1,192,1,192,1,192,1,192,1,213,1,213,1,213,1,213,1,213,1,213,1,213,1,213,2,21,2,21,2,21,2,21,2,21,2,21,2,21,2,21,2,106,2,106,2,106,2,106,2,106,2,106,2,106,2,106,2,149,2,149,2,149,2,149,2,149,2,149,2,149,2,149,2,213,2,213,2,213,2,213,2,213,2,213,2,213,2,213,2,213,2,213,2,213,2,213,2,213,2,213,2,213,2,213 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },1965716,1965843, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,174,1,174,3,132,6,64,5,220,8,2,7,108,5,120,3,2 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },1972988,1973005, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,124,1,124,2,188,5,151,9,66,8,102,7,149,6,144,4,122 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },1973018,1973035, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {4,76,4,76,7,8,8,52,8,202,8,152,7,108,9,246,7,249,2,138 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },1973048,1973067, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {7,8,7,8,6,211,6,198,7,132,7,221,7,135,8,158,8,37,4,176 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },1973078,1973097, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {7,8,7,8,6,8,6,111,6,220,6,214,5,220,7,68,5,150,4,226 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },1973108,1973127, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {5,70,5,70,5,61,5,231,5,36,5,20,5,57,5,104,5,100,6,94 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },1973138,1973157, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {4,176,4,176,4,66,4,136,5,56,5,35,3,213,4,133,4,109,5,146 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },1973168,1973187, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,144,1,144,1,244,5,2,4,231,4,204,4,161,4,107,3,152,4,216 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },1973198,1973217, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {100 },
 new byte[]  { 0 },1973229,1973229, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {100,1,144,4,24,3,126,3,232,3,201,3,186,3,22,2,138 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },1973231,1973247, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {200 },
 new byte[]  { 0 },1973259,1973259, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {200,1,144,2,188,2,212,3,182,2,22,2,38,2,28,2,118 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },1973261,1973277, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,244,1,244,1,244,3,132,3,132,4,226,4,76,2,22 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },1973288,1973303, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {150 },
 new byte[]  { 0 },1973305,1973305, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {150 },
 new byte[]  { 0 },1973319,1973319, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {150 },
 new byte[]  { 0 },1973321,1973321, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {200 },
 new byte[]  { 0 },1973323,1973323, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {200,4,176,5,120,2,188,2,88,2,88 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0 },1973325,1973335, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {200 },
 new byte[]  { 0 },1973349,1973349, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {200 },
 new byte[]  { 0 },1973351,1973351, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {250 },
 new byte[]  { 0 },1973353,1973353, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {250,1,44,1,204,2,148,2,128 },
 new byte[]  { 0,0,0,0,0,0,0,0,0 },1973355,1973363, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,174,1,174,3,132,6,64,5,220,8,2,7,108,5,120,3,2 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },1973568,1973585, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,124,1,124,2,188,5,151,9,66,8,102,7,149,6,144,4,122 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },1973598,1973615, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {4,76,4,76,7,8,8,52,8,202,8,152,7,108,9,246,7,249,2,138 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },1973628,1973647, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {7,8,7,8,6,211,6,198,7,132,7,221,7,135,8,158,8,37,4,176 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },1973658,1973677, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {7,8,7,8,6,8,6,111,6,220,6,214,5,220,7,68,5,150,4,226 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },1973688,1973707, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {5,70,5,70,5,61,5,231,5,36,5,20,5,57,5,104,5,100,6,94 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },1973718,1973737, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {4,176,4,176,4,66,4,136,5,56,5,35,3,213,4,133,4,109,5,146 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },1973748,1973767, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,144,1,144,1,244,5,2,4,231,4,204,4,161,4,107,3,152,4,216 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },1973778,1973797, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {100 },
 new byte[]  { 0 },1973809,1973809, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {100,1,144,4,24,3,126,3,232,3,201,3,186,3,22,2,138 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },1973811,1973827, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {200 },
 new byte[]  { 0 },1973839,1973839, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {200,1,144,2,188,2,212,3,182,2,22,2,38,2,28,2,118 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },1973841,1973857, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,244,1,244,1,244,3,132,3,132,4,226,4,76,2,22 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },1973868,1973883, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {150 },
 new byte[]  { 0 },1973885,1973885, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {150 },
 new byte[]  { 0 },1973899,1973899, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {150 },
 new byte[]  { 0 },1973901,1973901, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {200 },
 new byte[]  { 0 },1973903,1973903, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {200,4,176,5,120,2,188,2,88,2,88 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0 },1973905,1973915, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {200 },
 new byte[]  { 0 },1973929,1973929, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {200 },
 new byte[]  { 0 },1973931,1973931, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {250 },
 new byte[]  { 0 },1973933,1973933, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {250,1,44,1,204,2,148,2,128 },
 new byte[]  { 0,0,0,0,0,0,0,0,0 },1973935,1973943, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,174,1,174,3,132,6,64,5,220,8,2,7,108,5,120,3,2 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },1974148,1974165, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,124,1,124,2,188,5,151,9,66,8,102,7,149,6,144,4,122 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },1974178,1974195, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {4,76,4,76,7,8,8,52,8,202,8,152,7,108,9,246,7,249,2,138 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },1974208,1974227, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {7,8,7,8,6,211,6,198,7,132,7,221,7,135,8,158,8,37,4,176 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },1974238,1974257, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {7,8,7,8,6,8,6,111,6,220,6,214,5,220,7,68,5,150,4,226 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },1974268,1974287, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {5,70,5,70,5,61,5,231,5,36,5,20,5,57,5,104,5,100,6,94 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },1974298,1974317, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {4,176,4,176,4,66,4,136,5,56,5,35,3,213,4,133,4,109,5,146 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },1974328,1974347, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,144,1,144,1,244,5,2,4,231,4,204,4,161,4,107,3,152,4,216 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },1974358,1974377, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {100 },
 new byte[]  { 0 },1974389,1974389, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {100,1,144,4,24,3,126,3,232,3,201,3,186,3,22,2,138 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },1974391,1974407, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {200 },
 new byte[]  { 0 },1974419,1974419, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {200,1,144,2,188,2,212,3,182,2,22,2,38,2,28,2,118 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },1974421,1974437, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,244,1,244,1,244,3,132,3,132,4,226,4,76,2,22 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },1974448,1974463, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {150 },
 new byte[]  { 0 },1974465,1974465, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {150 },
 new byte[]  { 0 },1974479,1974479, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {150 },
 new byte[]  { 0 },1974481,1974481, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {200 },
 new byte[]  { 0 },1974483,1974483, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {200,4,176,5,120,2,188,2,88,2,88 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0 },1974485,1974495, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {200 },
 new byte[]  { 0 },1974509,1974509, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {200 },
 new byte[]  { 0 },1974511,1974511, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {250 },
 new byte[]  { 0 },1974513,1974513, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {250,1,44,1,204,2,148,2,128 },
 new byte[]  { 0,0,0,0,0,0,0,0,0 },1974515,1974523, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,174,1,174,3,132,6,64,5,220,8,2,7,108,5,120,3,2 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },1974728,1974745, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,124,1,124,2,188,5,151,9,66,8,102,7,149,6,144,4,122 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },1974758,1974775, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {4,76,4,76,7,8,8,52,8,202,8,152,7,108,9,246,7,249,2,138 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },1974788,1974807, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {7,8,7,8,6,211,6,198,7,132,7,221,7,135,8,158,8,37,4,176 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },1974818,1974837, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {7,8,7,8,6,8,6,111,6,220,6,214,5,220,7,68,5,150,4,226 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },1974848,1974867, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {5,70,5,70,5,61,5,231,5,36,5,20,5,57,5,104,5,100,6,94 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },1974878,1974897, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {4,176,4,176,4,66,4,136,5,56,5,35,3,213,4,133,4,109,5,146 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },1974908,1974927, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,144,1,144,1,244,5,2,4,231,4,204,4,161,4,107,3,152,4,216 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },1974938,1974957, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {100 },
 new byte[]  { 0 },1974969,1974969, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {100,1,144,4,24,3,126,3,232,3,201,3,186,3,22,2,138 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },1974971,1974987, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {200 },
 new byte[]  { 0 },1974999,1974999, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {200,1,144,2,188,2,212,3,182,2,22,2,38,2,28,2,118 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },1975001,1975017, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,244,1,244,1,244,3,132,3,132,4,226,4,76,2,22 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },1975028,1975043, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {150 },
 new byte[]  { 0 },1975045,1975045, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {150 },
 new byte[]  { 0 },1975059,1975059, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {150 },
 new byte[]  { 0 },1975061,1975061, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {200 },
 new byte[]  { 0 },1975063,1975063, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {200,4,176,5,120,2,188,2,88,2,88 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0 },1975065,1975075, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {200 },
 new byte[]  { 0 },1975089,1975089, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {200 },
 new byte[]  { 0 },1975091,1975091, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {250 },
 new byte[]  { 0 },1975093,1975093, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {250,1,44,1,204,2,148,2,128 },
 new byte[]  { 0,0,0,0,0,0,0,0,0 },1975095,1975103, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3 },
 new byte[]  { 0 },2017600,2017600, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3,3 },
 new byte[]  { 0,0 },2017607,2017608, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3,3 },
 new byte[]  { 0,0 },2017615,2017616, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {2,3,6 },
 new byte[]  { 0,0,0 },2017623,2017625, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,2,3,6 },
 new byte[]  { 0,0,0,0 },2017630,2017633, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,1,2,3,6 },
 new byte[]  { 0,0,0,0,0 },2017637,2017641, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3 },
 new byte[]  { 0 },2017648,2017648, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {4,6 },
 new byte[]  { 0,0 },2017656,2017657, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {6,1,2 },
 new byte[]  { 0,0,0 },2017660,2017662, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3,4 },
 new byte[]  { 0,0 },2017664,2017665, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1 },
 new byte[]  { 0 },2017667,2017667, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3 },
 new byte[]  { 0 },2018099,2018099, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1 },
 new byte[]  { 0 },2018103,2018103, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1 },
 new byte[]  { 0 },2018107,2018107, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {4 },
 new byte[]  { 0 },2018111,2018111, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1 },
 new byte[]  { 0 },2018115,2018115, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1 },
 new byte[]  { 0 },2018123,2018123, "Found dpf map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3,1 },
 new byte[]  { 0,0 },2018127,2018128, "Found dpf map...Delete map");
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