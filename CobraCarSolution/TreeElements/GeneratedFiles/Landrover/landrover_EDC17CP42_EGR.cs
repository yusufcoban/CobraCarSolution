using ToolBoxNameSpace;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace CobraCarSolution.TreeElements.VAG
{
    class landrover_EDC17CP42 :MenuItem, ITreeItem  {
    public landrover_EDC17CP42()  {
      Title = "landrover EDC17CP42";
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
		validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {12 },  3165931    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {12 },  3165933    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1 },  3165967    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {4 },  3165974    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1 },  3165976    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1 },  3165979    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {4 },  3165989    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {4 },  3165991    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,1 },  3166123    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {4 },  3166218    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {4 },  3166220    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {4 },  3166222    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {4 },  3166224    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {4 },  3166226    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {4 },  3166228    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {4 },  3166230    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {4 },  3166232    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {4 },  3166234    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {4 },  3166236    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,1,1,1,1,1,1,1 },  3166402    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,1 },  3166411    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {4 },  3166605    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {4 },  3166607    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {4 },  3166609    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,1,1 },  3166681    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {91 },  3168692    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {81,1,83,1,86,1,90,1,97,1,93,1,96,1 },  3168694    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {91 },  3168758    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {81,1,83,1,86,1,90,1,97,1,93,1,96,1 },  3168760    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {190 },  3169232    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {188 },  3169234    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {198 },  3169236    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {91 },  3169238    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {81,1,83,1,86,1,90,1,97,1,93,1,96,1 },  3169240    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {190 },  3169280    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {188 },  3169282    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {198 },  3169284    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {91 },  3169286    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {81,1,83,1,86,1,90,1,97,1,93,1,96,1 },  3169288    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {125,2 },  3170712    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {121,2,122,2 },  3170720    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {81,1,83,1,86,1,90,1,97,1,93,1,125,2 },  3170726    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {121,2,122,2 },  3170746    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {81,1,83,1,86,1,90,1,97,1,93,1 },  3170752    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {190 },  3172110    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {91 },  3172112    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {81,1,83,1,86,1,90,1,97,1,93,1,96,1 },  3172114    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {190 },  3172150    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {91 },  3172152    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {81,1,83,1,86,1,90,1,97,1,93,1,96,1 },  3172154    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {190 },  3172190    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {91 },  3172192    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {81,1,83,1,86,1,90,1,97,1,93,1,96,1 },  3172194    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {190 },  3172230    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {91 },  3172232    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {81,1,83,1,86,1,90,1,97,1,93,1,96,1 },  3172234    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {190 },  3172270    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {91 },  3172272    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {81,1,83,1,86,1,90,1,97,1,93,1,96,1 },  3172274    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {190 },  3172310    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {91 },  3172312    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {81,1,83,1,86,1,90,1,97,1,93,1,96,1 },  3172314    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {190 },  3172350    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {91 },  3172352    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {81,1,83,1,86,1,90,1,97,1,93,1,96,1 },  3172354    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {190 },  3172390    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {91 },  3172392    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {81,1,83,1,86,1,90,1,97,1,93,1,96,1 },  3172394    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {190 },  3172430    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {91 },  3172432    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {81,1,83,1,86,1,90,1,97,1,93,1,96,1 },  3172434    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {190 },  3172470    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {91 },  3172472    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {81,1,83,1,86,1,90,1,97,1,93,1,96,1 },  3172474    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {125,2 },  3175492    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {81,1,125,2 },  3175502    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {81,1,125,2 },  3175514    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {81,1,83,1,86,1,90,1,97,1,93,1,125,2 },  3175526    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {81,1,125,2 },  3175548    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {81,1,125,2 },  3175560    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {81,1,125,2 },  3175572    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {81,1,125,2 },  3175584    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {81,1 },  3175596    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {125,2 },  3175602    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {81,1,125,2 },  3175612    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {81,1 },  3175624    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {190 },  3178042    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {91 },  3178044    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {81,1,83,1,86,1,90,1,97,1,93,1,96,1 },  3178046    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {225 },  3178086    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {91 },  3178088    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {193,1,182,1,81,1,83,1,86,1,90,1,97,1,93,1 },  3178090    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {81,1,83,1,86,1,90,1,97,1,93,1,96,1 },  3178130    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {125,2 },  3178870    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {81,1,125,2 },  3178880    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {81,1 },  3178892    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {55,24 },  3201722    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {55,24 },  3201726    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {0,0 },  3201794    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {2,8 },  3201808    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {0,0 },  3201812    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {0,0 },  3201818    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {0,0 },  3201838    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {0,0 },  3201842    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {0,0,0,0 },  3202106    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {0,0 },  3202296    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {0,0 },  3202300    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {0,0 },  3202304    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {0,0 },  3202308    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {0,0 },  3202312    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {0,0 },  3202316    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {0,0 },  3202320    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {0,0 },  3202324    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {0,0 },  3202328    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {0,0 },  3202332    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },  3202664    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {0,0,0,0 },  3202682    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {48,24 },  3203070    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {48,24 },  3203074    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {48,24 },  3203078    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {48,24,48,24,48,24 },  3203222    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64,31,64,31,64,31,64,31,64,31,64,31,64,31,64,31,64,31,64,31,64,31,64,31 },  3660654    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {16,39,16,39,16,39,16,39,16,39,16,39,16,39,16,39,16,39,16,39,16,39,16,39 },  3660704    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {40,35,100,25,120,5,120,5,120,5,144,1,144,1,144,1,144,1,144,1,144,1,144,1 },  3660754    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64,6,64,6,64,6,64,6,64,6,64,6,64,6,64,6,64,6,64,6,64,6,64,6,32,3,38,2,38,2,38,2,38,2,38,2,38,2,38,2,38,2,38,2,38,2,38,2,38,2 },  3662492    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {121,3,64,6,64,6,214,6,108,7,102,8,96,9,40,10,34,11,34,11,78,12,78,12,78,12,234,11,134,11,111,7,212,3,193,1 },  3662596    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {14,6,14,6,14,6,14,6,14,6,14,6,14,6,14,6,14,6,14,6,14,6,14,6,32,3,244,1,244,1,244,1,244,1,244,1,244,1,244,1,244,1,244,1,244,1,244,1,244,1 },  3662696    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {177,2,120,5,195,5,99,6,251,6,208,7,152,8,166,9,190,10,155,10,134,11,134,11,134,11,34,11,190,10,167,6,12,3,249 },  3662800    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {56,255,56,255,56,255,56,255,56,255,56,255,244,1 },  3662836    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {14,6,14,6,14,6,14,6,14,6,14,6,14,6,14,6,14,6,14,6,14,6,14,6,14,6,14,6,14,6,14,6,14,6,14,6,14,6,14,6,14,6,14,6,14,6,14,6,14,6 },  3942952    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64,6,64,6,64,6,64,6,64,6,64,6,64,6,64,6,64,6,64,6,64,6,64,6,64,6,64,6,64,6,64,6,64,6,64,6,64,6,64,6,64,6,64,6,64,6,64,6,64,6 },  3943472    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {248,254,184,112,72,228,219,223,203,154,109,169,108,219,174,217,230,114,239,8,7,103,82,171,59,165,149,142,65,253,206,156,167,8,196,152,87,199,155,141,40,99,171,155,237,71,199,138,200,78,93,70,191,7,243,36,111,248,156,36,139,10,47,211,67,73,144,38,213,255,167,41,148,148,204,37,164,182,65,194,248,129,155,242,204,194,197,73,71,81,79,142,184,242,97,71,62,137,27,94,174,200,210,179,23,145,202,122,171,203,224,51,55,218,105,55,98,45,225,203,167,29,21,138,52,136,158,151,118,147,253,122,181,39,147,136 },  4190068    );
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
	ToolBox.ReplaceInFileWithStartStop(new byte[]  {12 },
 new byte[]  { 0 },3165931,3165931, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {12 },
 new byte[]  { 0 },3165933,3165933, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1 },
 new byte[]  { 0 },3165967,3165967, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {4 },
 new byte[]  { 0 },3165974,3165974, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1 },
 new byte[]  { 0 },3165976,3165976, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1 },
 new byte[]  { 0 },3165979,3165979, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {4 },
 new byte[]  { 0 },3165989,3165989, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {4 },
 new byte[]  { 0 },3165991,3165991, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,1 },
 new byte[]  { 0,0 },3166123,3166124, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {4 },
 new byte[]  { 0 },3166218,3166218, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {4 },
 new byte[]  { 0 },3166220,3166220, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {4 },
 new byte[]  { 0 },3166222,3166222, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {4 },
 new byte[]  { 0 },3166224,3166224, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {4 },
 new byte[]  { 0 },3166226,3166226, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {4 },
 new byte[]  { 0 },3166228,3166228, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {4 },
 new byte[]  { 0 },3166230,3166230, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {4 },
 new byte[]  { 0 },3166232,3166232, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {4 },
 new byte[]  { 0 },3166234,3166234, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {4 },
 new byte[]  { 0 },3166236,3166236, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,1,1,1,1,1,1,1 },
 new byte[]  { 0,0,0,0,0,0,0,0 },3166402,3166409, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,1 },
 new byte[]  { 0,0 },3166411,3166412, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {4 },
 new byte[]  { 0 },3166605,3166605, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {4 },
 new byte[]  { 0 },3166607,3166607, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {4 },
 new byte[]  { 0 },3166609,3166609, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,1,1 },
 new byte[]  { 0,0,0 },3166681,3166683, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {91 },
 new byte[]  { 0 },3168692,3168692, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {81,1,83,1,86,1,90,1,97,1,93,1,96,1 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0 },3168694,3168707, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {91 },
 new byte[]  { 0 },3168758,3168758, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {81,1,83,1,86,1,90,1,97,1,93,1,96,1 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0 },3168760,3168773, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {190 },
 new byte[]  { 0 },3169232,3169232, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {188 },
 new byte[]  { 0 },3169234,3169234, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {198 },
 new byte[]  { 0 },3169236,3169236, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {91 },
 new byte[]  { 0 },3169238,3169238, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {81,1,83,1,86,1,90,1,97,1,93,1,96,1 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0 },3169240,3169253, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {190 },
 new byte[]  { 0 },3169280,3169280, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {188 },
 new byte[]  { 0 },3169282,3169282, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {198 },
 new byte[]  { 0 },3169284,3169284, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {91 },
 new byte[]  { 0 },3169286,3169286, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {81,1,83,1,86,1,90,1,97,1,93,1,96,1 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0 },3169288,3169301, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {125,2 },
 new byte[]  { 0,0 },3170712,3170713, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {121,2,122,2 },
 new byte[]  { 0,0,0,0 },3170720,3170723, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {81,1,83,1,86,1,90,1,97,1,93,1,125,2 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0 },3170726,3170739, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {121,2,122,2 },
 new byte[]  { 0,0,0,0 },3170746,3170749, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {81,1,83,1,86,1,90,1,97,1,93,1 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0 },3170752,3170763, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {190 },
 new byte[]  { 0 },3172110,3172110, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {91 },
 new byte[]  { 0 },3172112,3172112, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {81,1,83,1,86,1,90,1,97,1,93,1,96,1 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0 },3172114,3172127, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {190 },
 new byte[]  { 0 },3172150,3172150, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {91 },
 new byte[]  { 0 },3172152,3172152, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {81,1,83,1,86,1,90,1,97,1,93,1,96,1 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0 },3172154,3172167, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {190 },
 new byte[]  { 0 },3172190,3172190, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {91 },
 new byte[]  { 0 },3172192,3172192, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {81,1,83,1,86,1,90,1,97,1,93,1,96,1 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0 },3172194,3172207, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {190 },
 new byte[]  { 0 },3172230,3172230, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {91 },
 new byte[]  { 0 },3172232,3172232, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {81,1,83,1,86,1,90,1,97,1,93,1,96,1 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0 },3172234,3172247, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {190 },
 new byte[]  { 0 },3172270,3172270, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {91 },
 new byte[]  { 0 },3172272,3172272, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {81,1,83,1,86,1,90,1,97,1,93,1,96,1 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0 },3172274,3172287, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {190 },
 new byte[]  { 0 },3172310,3172310, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {91 },
 new byte[]  { 0 },3172312,3172312, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {81,1,83,1,86,1,90,1,97,1,93,1,96,1 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0 },3172314,3172327, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {190 },
 new byte[]  { 0 },3172350,3172350, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {91 },
 new byte[]  { 0 },3172352,3172352, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {81,1,83,1,86,1,90,1,97,1,93,1,96,1 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0 },3172354,3172367, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {190 },
 new byte[]  { 0 },3172390,3172390, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {91 },
 new byte[]  { 0 },3172392,3172392, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {81,1,83,1,86,1,90,1,97,1,93,1,96,1 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0 },3172394,3172407, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {190 },
 new byte[]  { 0 },3172430,3172430, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {91 },
 new byte[]  { 0 },3172432,3172432, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {81,1,83,1,86,1,90,1,97,1,93,1,96,1 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0 },3172434,3172447, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {190 },
 new byte[]  { 0 },3172470,3172470, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {91 },
 new byte[]  { 0 },3172472,3172472, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {81,1,83,1,86,1,90,1,97,1,93,1,96,1 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0 },3172474,3172487, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {125,2 },
 new byte[]  { 0,0 },3175492,3175493, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {81,1,125,2 },
 new byte[]  { 0,0,0,0 },3175502,3175505, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {81,1,125,2 },
 new byte[]  { 0,0,0,0 },3175514,3175517, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {81,1,83,1,86,1,90,1,97,1,93,1,125,2 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0 },3175526,3175539, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {81,1,125,2 },
 new byte[]  { 0,0,0,0 },3175548,3175551, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {81,1,125,2 },
 new byte[]  { 0,0,0,0 },3175560,3175563, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {81,1,125,2 },
 new byte[]  { 0,0,0,0 },3175572,3175575, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {81,1,125,2 },
 new byte[]  { 0,0,0,0 },3175584,3175587, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {81,1 },
 new byte[]  { 0,0 },3175596,3175597, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {125,2 },
 new byte[]  { 0,0 },3175602,3175603, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {81,1,125,2 },
 new byte[]  { 0,0,0,0 },3175612,3175615, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {81,1 },
 new byte[]  { 0,0 },3175624,3175625, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {190 },
 new byte[]  { 0 },3178042,3178042, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {91 },
 new byte[]  { 0 },3178044,3178044, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {81,1,83,1,86,1,90,1,97,1,93,1,96,1 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0 },3178046,3178059, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {225 },
 new byte[]  { 0 },3178086,3178086, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {91 },
 new byte[]  { 0 },3178088,3178088, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {193,1,182,1,81,1,83,1,86,1,90,1,97,1,93,1 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },3178090,3178105, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {81,1,83,1,86,1,90,1,97,1,93,1,96,1 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0 },3178130,3178143, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {125,2 },
 new byte[]  { 0,0 },3178870,3178871, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {81,1,125,2 },
 new byte[]  { 0,0,0,0 },3178880,3178883, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {81,1 },
 new byte[]  { 0,0 },3178892,3178893, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {55,24 },
 new byte[]  { 255,255 },3201722,3201723, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {55,24 },
 new byte[]  { 255,255 },3201726,3201727, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {0,0 },
 new byte[]  { 255,255 },3201794,3201795, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {2,8 },
 new byte[]  { 255,255 },3201808,3201809, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {0,0 },
 new byte[]  { 255,255 },3201812,3201813, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {0,0 },
 new byte[]  { 255,255 },3201818,3201819, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {0,0 },
 new byte[]  { 255,255 },3201838,3201839, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {0,0 },
 new byte[]  { 255,255 },3201842,3201843, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {0,0,0,0 },
 new byte[]  { 255,255,255,255 },3202106,3202109, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {0,0 },
 new byte[]  { 255,255 },3202296,3202297, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {0,0 },
 new byte[]  { 255,255 },3202300,3202301, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {0,0 },
 new byte[]  { 255,255 },3202304,3202305, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {0,0 },
 new byte[]  { 255,255 },3202308,3202309, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {0,0 },
 new byte[]  { 255,255 },3202312,3202313, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {0,0 },
 new byte[]  { 255,255 },3202316,3202317, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {0,0 },
 new byte[]  { 255,255 },3202320,3202321, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {0,0 },
 new byte[]  { 255,255 },3202324,3202325, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {0,0 },
 new byte[]  { 255,255 },3202328,3202329, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {0,0 },
 new byte[]  { 255,255 },3202332,3202333, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },
 new byte[]  { 255,255,255,255,255,255,255,255,255,255,255,255,255,255,255,255 },3202664,3202679, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {0,0,0,0 },
 new byte[]  { 255,255,255,255 },3202682,3202685, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {48,24 },
 new byte[]  { 255,255 },3203070,3203071, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {48,24 },
 new byte[]  { 255,255 },3203074,3203075, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {48,24 },
 new byte[]  { 255,255 },3203078,3203079, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {48,24,48,24,48,24 },
 new byte[]  { 255,255,255,255,255,255 },3203222,3203227, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64,31,64,31,64,31,64,31,64,31,64,31,64,31,64,31,64,31,64,31,64,31,64,31 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },3660654,3660677, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {16,39,16,39,16,39,16,39,16,39,16,39,16,39,16,39,16,39,16,39,16,39,16,39 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },3660704,3660727, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {40,35,100,25,120,5,120,5,120,5,144,1,144,1,144,1,144,1,144,1,144,1,144,1 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },3660754,3660777, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64,6,64,6,64,6,64,6,64,6,64,6,64,6,64,6,64,6,64,6,64,6,64,6,32,3,38,2,38,2,38,2,38,2,38,2,38,2,38,2,38,2,38,2,38,2,38,2,38,2 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },3662492,3662541, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {121,3,64,6,64,6,214,6,108,7,102,8,96,9,40,10,34,11,34,11,78,12,78,12,78,12,234,11,134,11,111,7,212,3,193,1 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },3662596,3662631, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {14,6,14,6,14,6,14,6,14,6,14,6,14,6,14,6,14,6,14,6,14,6,14,6,32,3,244,1,244,1,244,1,244,1,244,1,244,1,244,1,244,1,244,1,244,1,244,1,244,1 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },3662696,3662745, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {177,2,120,5,195,5,99,6,251,6,208,7,152,8,166,9,190,10,155,10,134,11,134,11,134,11,34,11,190,10,167,6,12,3,249 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },3662800,3662834, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {56,255,56,255,56,255,56,255,56,255,56,255,244,1 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0 },3662836,3662849, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {14,6,14,6,14,6,14,6,14,6,14,6,14,6,14,6,14,6,14,6,14,6,14,6,14,6,14,6,14,6,14,6,14,6,14,6,14,6,14,6,14,6,14,6,14,6,14,6,14,6 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },3942952,3943001, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64,6,64,6,64,6,64,6,64,6,64,6,64,6,64,6,64,6,64,6,64,6,64,6,64,6,64,6,64,6,64,6,64,6,64,6,64,6,64,6,64,6,64,6,64,6,64,6,64,6 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },3943472,3943521, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {248,254,184,112,72,228,219,223,203,154,109,169,108,219,174,217,230,114,239,8,7,103,82,171,59,165,149,142,65,253,206,156,167,8,196,152,87,199,155,141,40,99,171,155,237,71,199,138,200,78,93,70,191,7,243,36,111,248,156,36,139,10,47,211,67,73,144,38,213,255,167,41,148,148,204,37,164,182,65,194,248,129,155,242,204,194,197,73,71,81,79,142,184,242,97,71,62,137,27,94,174,200,210,179,23,145,202,122,171,203,224,51,55,218,105,55,98,45,225,203,167,29,21,138,52,136,158,151,118,147,253,122,181,39,147,136 },
 new byte[]  { 89,28,130,180,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,66,138,47,152,215,40,174,34,8,51,138,11,52,236,46,52,141,6,239,62,64,120,146,247,243,127,120,35,97,194,2,91,181,227,119,101,238,223,218,112,44,44,189,162,12,198 },4190068,4190203, "Found egr map...Delete map");
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