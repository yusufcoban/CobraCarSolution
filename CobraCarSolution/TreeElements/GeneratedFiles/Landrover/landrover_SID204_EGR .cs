using ToolBoxNameSpace;

namespace CobraCarSolution.TreeElements.VAG
{
    class landrover_SID204  :MenuItem, ITreeItem  {
    public landrover_SID204()  {
      Title = "SID204 ";
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
		validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {131,140,87,199 },  262404    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {13,192,21,64,21,64,21,224,21,224,22,128,28,192,31,224,34,96,39,96,41,64,42,128,36,224 },  408554    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {13,192,21,64,21,64,21,224,21,224,25,160,28,192,33,192,41,64,42,128,43,32,45 },  408586    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {34,96 },  408610    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {10,160,14,148,14,232,15,24,15,168,17,76,22,236,30,72,33,32,35,160,39,96,41,64,32,128 },  408618    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {10,160,20 },  408650    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20 },  408654    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {20,160,20 },  408656    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {23,32,27,128,32,128,36,64,38,192,41,224,43,192,30 },  408660    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3,39,8,9,10,11 },  413108    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3,39,8,9,10,11 },  413134    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3,39,8,9,10,11 },  413368    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3,39,8,9,10,11 },  413394    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3,39,8,9,10,11 },  413420    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3,39,8,9,10,11 },  413446    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3,39,8,9,10,11 },  413472    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3,39,8,9,10,11 },  413498    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3,39,8,9,10,11 },  414148    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3,39,8,9,10,11 },  414616    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3,39,8,9,10,11 },  414642    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3,39,8,9,10,11 },  414668    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3,39,8,9,10,11 },  414694    );
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
	ToolBox.ReplaceInFileWithStartStop(new byte[]  {131,140,87,199 },
 new byte[]  { 120,183,10,160 },262404,262407, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {13,192,21,64,21,64,21,224,21,224,22,128,28,192,31,224,34,96,39,96,41,64,42,128,36,224 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },408554,408579, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {13,192,21,64,21,64,21,224,21,224,25,160,28,192,33,192,41,64,42,128,43,32,45 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },408586,408608, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {34,96 },
 new byte[]  { 0,0 },408610,408611, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {10,160,14,148,14,232,15,24,15,168,17,76,22,236,30,72,33,32,35,160,39,96,41,64,32,128 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },408618,408643, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {10,160,20 },
 new byte[]  { 0,0,0 },408650,408652, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20 },
 new byte[]  { 0 },408654,408654, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {20,160,20 },
 new byte[]  { 0,0,0 },408656,408658, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {23,32,27,128,32,128,36,64,38,192,41,224,43,192,30 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },408660,408674, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3,39,8,9,10,11 },
 new byte[]  { 0,0,0,0,0,0 },413108,413113, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3,39,8,9,10,11 },
 new byte[]  { 0,0,0,0,0,0 },413134,413139, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3,39,8,9,10,11 },
 new byte[]  { 0,0,0,0,0,0 },413368,413373, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3,39,8,9,10,11 },
 new byte[]  { 0,0,0,0,0,0 },413394,413399, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3,39,8,9,10,11 },
 new byte[]  { 0,0,0,0,0,0 },413420,413425, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3,39,8,9,10,11 },
 new byte[]  { 0,0,0,0,0,0 },413446,413451, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3,39,8,9,10,11 },
 new byte[]  { 0,0,0,0,0,0 },413472,413477, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3,39,8,9,10,11 },
 new byte[]  { 0,0,0,0,0,0 },413498,413503, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3,39,8,9,10,11 },
 new byte[]  { 0,0,0,0,0,0 },414148,414153, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3,39,8,9,10,11 },
 new byte[]  { 0,0,0,0,0,0 },414616,414621, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3,39,8,9,10,11 },
 new byte[]  { 0,0,0,0,0,0 },414642,414647, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3,39,8,9,10,11 },
 new byte[]  { 0,0,0,0,0,0 },414668,414673, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3,39,8,9,10,11 },
 new byte[]  { 0,0,0,0,0,0 },414694,414699, "Found egr map...Delete map");
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