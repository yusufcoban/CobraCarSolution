using ToolBoxNameSpace;

namespace CobraCarSolution.TreeElements.VAG
{
    class EDC17C66 :MenuItem, ITreeItem  {
    public EDC17C66()  {
      Title = "EDC17C66";
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
		validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1 },  2252288    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,1,1,5 },  2252294    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,5 },  2252299    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {5 },  2252505    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,1,1,5,5 },  2252509    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {5,5 },  2252526    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1 },  2252532    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {5,5 },  2252534    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {5,5 },  2252538    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {5,1,1 },  2252731    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1 },  2253097    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,1 },  2253107    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {5 },  2253110    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {5 },  2253117    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,1 },  2253146    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,1 },  2253153    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,1,1,1 },  2253156    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {1,1 },  2253280    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {85 },  2255014    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {218 },  2255016    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {234 },  2255018    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {246 },  2255020    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {247 },  2255022    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {248 },  2255024    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {252 },  2255026    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {253 },  2255028    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {254 },  2255030    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {2,1,3,1,7,1,101,1,104,1,118,1,59,2,64,2,138,2,134,2,144,2,145,2,149,2,161,2,163,2,10,3,11,3,12,3,14,3,15,3,16,3,19 },  2255032    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {18,3,66,3 },  2255076    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {85 },  2255096    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {218 },  2255098    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {234 },  2255100    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {246 },  2255102    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {247 },  2255104    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {248 },  2255106    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {252 },  2255108    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {253 },  2255110    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {254 },  2255112    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {2,1,3,1,7,1,101,1,104,1,118,1,59,2,64,2,2 },  2255114    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {115,2,118,2,120,2,138,2,134,2,144,2,145,2,149,2,150,2,161,2,163,2,10,3,11,3,12,3,14,3,15,3,16,3,19 },  2255132    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {18,3,66,3 },  2255168    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {84 },  2255188    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {85 },  2255190    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {218 },  2255192    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {234 },  2255194    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {246 },  2255196    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {247 },  2255198    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {248 },  2255200    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {252 },  2255202    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {253 },  2255204    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {254 },  2255206    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {2,1,3,1,7,1,101,1,104,1,118,1,59,2,84,2,85,2,61,2,64,2,138,2,134,2,139,2,140,2,141,2,142,2,144,2,145,2,149,2,150,2,161,2,163,2,10,3,11,3,12,3,14,3,15,3,16,3,19 },  2255208    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {18,3,66,3,101,3 },  2255268    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {84 },  2255300    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {29 },  2255302    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {30 },  2255304    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {35 },  2255306    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {37 },  2255308    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {85 },  2255310    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64 },  2255312    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {81 },  2255314    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {114 },  2255316    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {115 },  2255318    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {116 },  2255320    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {118 },  2255322    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {158 },  2255324    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {218 },  2255326    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {234 },  2255328    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {246 },  2255330    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {247 },  2255332    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {248 },  2255334    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {252 },  2255336    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {253 },  2255338    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {254 },  2255340    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {2,1,3,1,7,1,78,1,79,1,101,1,104,1,118,1,161,1,163,1,165,1,166,1,235,1,246,1,254,1,10,2,12,2,59,2,84,2,85,2,92,2,10 },  2255342    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {95,2,97,2,61,2,64,2,66,2,69,2,9 },  2255386    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {72,2,2 },  2255400    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {118,2,120,2,138,2,134,2,139,2,140,2,141,2,142,2,144,2,145,2,149,2,150,2,161,2,163,2,10,3,11,3,12,3,14,3,15,3,16,3,19 },  2255404    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {18,3,66,3,100,3,101,3 },  2255446    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {84 },  2255640    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {85 },  2255642    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {218 },  2255644    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {234 },  2255646    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {246 },  2255648    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {247 },  2255650    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {248 },  2255652    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {252 },  2255654    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {253 },  2255656    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {254 },  2255658    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {2,1,3,1,7,1,101,1,104,1,118,1,59,2,84,2,85,2,61,2,64,2,2 },  2255660    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {115,2,118,2,120,2,138,2,134,2,139,2,140,2,141,2,144,2,145,2,149,2,150,2,161,2,163,2,10,3,11,3,12,3,14,3,15,3,16,3,19 },  2255684    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {18,3,66,3,94,3,101,3 },  2255726    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {84 },  2255754    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {29 },  2255756    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {30 },  2255758    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {35 },  2255760    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {37 },  2255762    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {85 },  2255764    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {64 },  2255766    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {81 },  2255768    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {114 },  2255770    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {115 },  2255772    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {116 },  2255774    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {118 },  2255776    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {158 },  2255778    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {218 },  2255780    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {234 },  2255782    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {246 },  2255784    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {247 },  2255786    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {248 },  2255788    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {252 },  2255790    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {253 },  2255792    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {254 },  2255794    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {2,1,3,1,7,1,78,1,79,1,101,1,104,1,118,1,161,1,163,1,165,1,166,1,235,1,246,1,254,1,10,2,12,2,59,2,84,2,85,2,92,2,10 },  2255796    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {95,2,97,2,61,2,64,2,66,2,69,2,9 },  2255840    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {72,2,2 },  2255854    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {115,2,118,2,120,2,138,2,134,2,139,2,140,2,141,2,142,2,144,2,145,2,149,2,150,2,161,2,163,2,10,3,11,3,12,3,14,3,15,3,16,3,19 },  2255858    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {18,3,66,3,94,3,101,3 },  2255902    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {84 },  2266952    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {29 },  2266954    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {30 },  2266956    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {35 },  2266958    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {85 },  2266960    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {46 },  2266962    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {81 },  2266964    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {158 },  2266966    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {234 },  2266968    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {248 },  2266970    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {253 },  2266972    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {254 },  2266974    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {7,1,76,1,78,1,79,1,101,1,104,1,163,1,59,2,84,2,92,2,10 },  2266976    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {95,2,97,2,64,2,69,2,9 },  2266998    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {72,2,150,2,161,2,10,3,11,3,12,3,16,3,19 },  2267008    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {18,3,99,3,100,3 },  2267024    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {84 },  2267398    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {218 },  2267400    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {234 },  2267402    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {248 },  2267404    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {253 },  2267406    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {254 },  2267408    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {7,1,84,2,64,2,145,2,150,2,161,2,10,3,11,3,12,3,16,3,19 },  2267410    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {18,3 },  2267432    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {84 },  2267492    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {29 },  2267494    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {30 },  2267496    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {35 },  2267498    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {85 },  2267500    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {81 },  2267502    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {114 },  2267504    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {115 },  2267506    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {116 },  2267508    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {234 },  2267510    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {248 },  2267512    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {253 },  2267514    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {254 },  2267516    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {7,1,78,1,79,1,85,1,87,1,88,1,90,1,96,1,97,1,101,1,104,1,161,1,163,1,165,1,166,1,246,1,12,2,59,2,84,2,92,2,10 },  2267518    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {95,2,97,2,64,2,66,2,69,2,9 },  2267560    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {72,2,2 },  2267572    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {118,2,120,2,150,2,161,2,10,3,11,3,12,3,16,3,19 },  2267576    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {18,3 },  2267594    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {234 },  2267634    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {248 },  2267636    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {253 },  2267638    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {254 },  2267640    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {7,1,64,2,10,3 },  2267642    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {84 },  2268752    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {29 },  2268754    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {30 },  2268756    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {35 },  2268758    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {85 },  2268760    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {81 },  2268762    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {114 },  2268764    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {115 },  2268766    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {116 },  2268768    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {234 },  2268770    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {248 },  2268772    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {253 },  2268774    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {254 },  2268776    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {7,1,78,1,79,1,85,1,87,1,88,1,90,1,96,1,97,1,101,1,104,1,161,1,163,1,165,1,166,1,246,1,12,2,59,2,84,2,92,2,10 },  2268778    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {95,2,97,2,64,2,66,2,69,2,9 },  2268820    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {72,2,2 },  2268832    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {118,2,120,2,150,2,161,2,10,3,11,3,12,3,16,3,19 },  2268836    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {18,3 },  2268854    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {234 },  2268894    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {248 },  2268896    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {253 },  2268898    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {254 },  2268900    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {7,1,64,2,10,3 },  2268902    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {84 },  2269292    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {29 },  2269294    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {30 },  2269296    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {35 },  2269298    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {85 },  2269300    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {81 },  2269302    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {218 },  2269304    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {234 },  2269306    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {248 },  2269308    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {253 },  2269310    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {254 },  2269312    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {7,1,101,1,104,1,163,1,205,1,235,1,246,1,254,1,10,2,12,2,59,2,84,2,64,2,138,2,134,2,144,2,146,2,149,2,150,2,153,2,157,2,161,2,162,2,163,2,10,3,11,3,12,3,16,3,19 },  2269314    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {18,3,66,3,94,3 },  2269372    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {84 },  2269528    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {29 },  2269530    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {30 },  2269532    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {35 },  2269534    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {85 },  2269536    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {81 },  2269538    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {114 },  2269540    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {115 },  2269542    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {116 },  2269544    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {218 },  2269546    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {234 },  2269548    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {248 },  2269550    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {253 },  2269552    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {254 },  2269554    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {7,1,78,1,79,1,85,1,86,1,87,1,88,1,90,1,95,1,97,1,101,1,104,1,118,1,161,1,163,1,165,1,166,1,246,1,12,2,59,2,84,2,92,2,10 },  2269556    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {95,2,97,2,64,2,66,2,69,2,9 },  2269602    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {72,2,2 },  2269614    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {112,2,118,2,120,2,138,2,134,2,144,2,145,2,146,2,149,2,150,2,153,2,157,2,161,2,162,2,163,2,10,3,11,3,12,3,16,3,19 },  2269618    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {18,3,66,3 },  2269658    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {84 },  2269688    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {29 },  2269690    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {30 },  2269692    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {35 },  2269694    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {85 },  2269696    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {81 },  2269698    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {114 },  2269700    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {115 },  2269702    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {116 },  2269704    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {218 },  2269706    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {234 },  2269708    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {248 },  2269710    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {253 },  2269712    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {254 },  2269714    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {7,1,78,1,79,1,85,1,86,1,87,1,88,1,90,1,95,1,97,1,101,1,104,1,118,1,161,1,163,1,165,1,166,1,246,1,12,2,59,2,84,2,92,2,10 },  2269716    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {95,2,97,2,64,2,66,2,69,2,9 },  2269762    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {72,2,2 },  2269774    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {112,2,118,2,120,2,138,2,134,2,144,2,145,2,146,2,149,2,150,2,153,2,157,2,161,2,162,2,163,2,10,3,11,3,12,3,16,3,19 },  2269778    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {18,3,66,3 },  2269818    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {84 },  2270084    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {43 },  2270086    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {29 },  2270088    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {30 },  2270090    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {35 },  2270092    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {85 },  2270094    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {81 },  2270096    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {114 },  2270098    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {115 },  2270100    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {116 },  2270102    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {218 },  2270104    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {234 },  2270106    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {248 },  2270108    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {253 },  2270110    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {254 },  2270112    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {7,1,78,1,79,1,85,1,86,1,87,1,88,1,90,1,95,1,97,1,101,1,104,1,161,1,163,1,165,1,166,1,246,1,12,2,59,2,84,2,92,2,10 },  2270114    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {95,2,97,2,64,2,66,2,69,2,9 },  2270158    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {72,2,2 },  2270170    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {118,2,120,2,138,2,134,2,144,2,149,2,150,2,153,2,157,2,161,2,162,2,163,2,10,3,11,3,12,3,16,3,19 },  2270174    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {18,3,66,3 },  2270208    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {84 },  2270244    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {43 },  2270246    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {29 },  2270248    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {30 },  2270250    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {35 },  2270252    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {85 },  2270254    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {81 },  2270256    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {114 },  2270258    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {115 },  2270260    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {116 },  2270262    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {218 },  2270264    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {234 },  2270266    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {248 },  2270268    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {253 },  2270270    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {254 },  2270272    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {7,1,78,1,79,1,85,1,86,1,87,1,88,1,90,1,95,1,97,1,101,1,104,1,161,1,163,1,165,1,166,1,246,1,12,2,59,2,84,2,92,2,10 },  2270274    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {95,2,97,2,64,2,66,2,69,2,9 },  2270318    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {72,2,2 },  2270330    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {118,2,120,2,138,2,134,2,144,2,149,2,150,2,153,2,157,2,161,2,162,2,163,2,10,3,11,3,12,3,16,3,19 },  2270334    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {18,3,66,3 },  2270368    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {29 },  2283076    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {30 },  2283078    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {35 },  2283080    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {85 },  2283082    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {81 },  2283084    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {114 },  2283086    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {115 },  2283088    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {116 },  2283090    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {78,1,79,1,101,1,104,1,118,1,161,1,163,1,59,2,2 },  2283092    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {112,2,118,2,120,2,138,2,134,2,144,2,149,2,150,2,161,2,163,2,66,3 },  2283110    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {84 },  2283236    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {29 },  2283238    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {30 },  2283240    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {35 },  2283242    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {85 },  2283244    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {81 },  2283246    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {146 },  2283248    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {234 },  2283250    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {248 },  2283252    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {253 },  2283254    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {254 },  2283256    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {7,1,101,1,104,1,161,1,163,1,205,1,246,1,12,2,59,2,84,2,64,2,150,2,161,2,10,3,11,3,12,3,16,3,19 },  2283258    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {18,3,94,3,101,3 },  2283294    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {84 },  2283336    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {234 },  2283338    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {248 },  2283340    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {253 },  2283342    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {254 },  2283344    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {7,1,161,1,84,2,64,2,150,2,161,2,10,3,11,3,12,3,16,3,19 },  2283346    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {18,3 },  2283368    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {85 },  2303810    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {114 },  2303812    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {115 },  2303814    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {116 },  2303816    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {158 },  2303818    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {78,1,101,1,104,1,59,2,150,2,161,2,196,2,99,3,100,3 },  2303820    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {84 },  2304752    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {43 },  2304754    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {29 },  2304756    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {30 },  2304758    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {35 },  2304760    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {37 },  2304762    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {85 },  2304764    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {81 },  2304766    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {114 },  2304768    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {115 },  2304770    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {116 },  2304772    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {218 },  2304774    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {234 },  2304776    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {248 },  2304778    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {253 },  2304780    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {254 },  2304782    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {7,1,78,1,79,1,85,1,87,1,88,1,90,1,93,1,96,1,101,1,104,1,118,1,161,1,163,1,165,1,166,1,246,1,12,2,59,2,84,2,92,2,10 },  2304784    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {95,2,97,2,64,2,66,2,69,2,9 },  2304828    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {72,2,2 },  2304840    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {112,2,118,2,120,2,138,2,134,2,144,2,149,2,150,2,161,2,163,2,10,3,11,3,12,3,16,3,19 },  2304844    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {18,3,66,3 },  2304874    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {84 },  2305358    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {29 },  2305360    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {30 },  2305362    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {35 },  2305364    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {85 },  2305366    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {81 },  2305368    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {234 },  2305370    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {248 },  2305372    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {253 },  2305374    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {254 },  2305376    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {7,1,78,1,79,1,85,1,87,1,88,1,90,1,95,1,96,1,101,1,104,1,161,1,163,1,59,2,84,2,64,2,150,2,161,2,10,3,11,3,12,3,16,3,19 },  2305378    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {18,3 },  2305424    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {234 },  2307030    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {248 },  2307032    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {253 },  2307034    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {254 },  2307036    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {7,1,64,2,10,3 },  2307038    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {234 },  2307068    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {248 },  2307070    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {253 },  2307072    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {254 },  2307074    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {7,1,64,2,10,3 },  2307076    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {234 },  2307144    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {248 },  2307146    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {253 },  2307148    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {254 },  2307150    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {7,1,64,2,10,3 },  2307152    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {234 },  2307182    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {248 },  2307184    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {253 },  2307186    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {254 },  2307188    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {7,1,64,2,10,3 },  2307190    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {234 },  2307220    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {248 },  2307222    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {253 },  2307224    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {254 },  2307226    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {7,1,64,2,10,3 },  2307228    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {234 },  2307258    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {248 },  2307260    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {253 },  2307262    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {254 },  2307264    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {7,1,64,2,10,3 },  2307266    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3,3 },  2331456    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3,3,3,3,3,3,1,1 },  2331468    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {3,3,1,1 },  2331478    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {0,128,0,128,0,0 },  2331638    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {0,128,0,128,0,128,15,0,0,128,0,128,15,0,0,128,0,128 },  2331650    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {0,128 },  2331890    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {0,0,0,0,0,0,0,0,0,0 },  2331898    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {0,128,0,128 },  2331932    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {0,0 },  2331944    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {0,128,0,128 },  2331948    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {0,128,0,128 },  2331956    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {235,0,0,128,235,0 },  2332072    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {0,128,0,128,0,128,65,0,0,128,0,128,0,128 },  2332080    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {105,0,0,128,0,128,0,128 },  2332114    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {0,128,0,128,105,0,105,0,0,128,0,128,105,0,105,0,0,0,235,0 },  2332126    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {0,128,105,0,105,0 },  2332342    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {73,0,0,128,0,128,0,128,235,0 },  2332524    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {0,128 },  2333074    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {0,128,0,128 },  2333094    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {0,128 },  2333100    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {0,128 },  2333114    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {0,128,0,128 },  2333172    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {0,0,0,0 },  2333186    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {0,0,0,0,0,128,0,128 },  2333192    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {0,128,0,128,0,128 },  2333256    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {105,0,105,0,105,0,105,0,0,128,0,128 },  2333276    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {105,0,0,0,0,128 },  2333296    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {0,128,0,128,0,128,0,128 },  2333354    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {0,128,0,128,0,128,0,128,0,128,0,128,0,128,0,128,0,128 },  2333368    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {0,128,0,128 },  2333440    );
validationEgrInFile= validationEgrInFile&&ToolBox.ExistsInFileMultiple(new byte[]  {0,128,0,128,0,128,0,128 },  2333622    );
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
	ToolBox.ReplaceInFileWithStartStop(new byte[]  {1 },
 new byte[]  { 0 },2252288,2252288, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,1,1,5 },
 new byte[]  { 0,0,0,0 },2252294,2252297, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,5 },
 new byte[]  { 0,0 },2252299,2252300, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {5 },
 new byte[]  { 0 },2252505,2252505, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,1,1,5,5 },
 new byte[]  { 0,0,0,0,0 },2252509,2252513, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {5,5 },
 new byte[]  { 0,0 },2252526,2252527, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1 },
 new byte[]  { 0 },2252532,2252532, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {5,5 },
 new byte[]  { 0,0 },2252534,2252535, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {5,5 },
 new byte[]  { 0,0 },2252538,2252539, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {5,1,1 },
 new byte[]  { 0,0,0 },2252731,2252733, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1 },
 new byte[]  { 0 },2253097,2253097, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,1 },
 new byte[]  { 0,0 },2253107,2253108, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {5 },
 new byte[]  { 0 },2253110,2253110, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {5 },
 new byte[]  { 0 },2253117,2253117, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,1 },
 new byte[]  { 0,0 },2253146,2253147, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,1 },
 new byte[]  { 0,0 },2253153,2253154, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,1,1,1 },
 new byte[]  { 0,0,0,0 },2253156,2253159, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {1,1 },
 new byte[]  { 0,0 },2253280,2253281, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {85 },
 new byte[]  { 0 },2255014,2255014, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {218 },
 new byte[]  { 0 },2255016,2255016, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {234 },
 new byte[]  { 0 },2255018,2255018, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {246 },
 new byte[]  { 0 },2255020,2255020, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {247 },
 new byte[]  { 0 },2255022,2255022, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {248 },
 new byte[]  { 0 },2255024,2255024, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {252 },
 new byte[]  { 0 },2255026,2255026, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {253 },
 new byte[]  { 0 },2255028,2255028, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {254 },
 new byte[]  { 0 },2255030,2255030, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {2,1,3,1,7,1,101,1,104,1,118,1,59,2,64,2,138,2,134,2,144,2,145,2,149,2,161,2,163,2,10,3,11,3,12,3,14,3,15,3,16,3,19 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },2255032,2255074, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {18,3,66,3 },
 new byte[]  { 0,0,0,0 },2255076,2255079, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {85 },
 new byte[]  { 0 },2255096,2255096, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {218 },
 new byte[]  { 0 },2255098,2255098, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {234 },
 new byte[]  { 0 },2255100,2255100, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {246 },
 new byte[]  { 0 },2255102,2255102, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {247 },
 new byte[]  { 0 },2255104,2255104, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {248 },
 new byte[]  { 0 },2255106,2255106, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {252 },
 new byte[]  { 0 },2255108,2255108, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {253 },
 new byte[]  { 0 },2255110,2255110, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {254 },
 new byte[]  { 0 },2255112,2255112, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {2,1,3,1,7,1,101,1,104,1,118,1,59,2,64,2,2 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },2255114,2255130, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {115,2,118,2,120,2,138,2,134,2,144,2,145,2,149,2,150,2,161,2,163,2,10,3,11,3,12,3,14,3,15,3,16,3,19 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },2255132,2255166, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {18,3,66,3 },
 new byte[]  { 0,0,0,0 },2255168,2255171, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {84 },
 new byte[]  { 0 },2255188,2255188, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {85 },
 new byte[]  { 0 },2255190,2255190, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {218 },
 new byte[]  { 0 },2255192,2255192, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {234 },
 new byte[]  { 0 },2255194,2255194, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {246 },
 new byte[]  { 0 },2255196,2255196, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {247 },
 new byte[]  { 0 },2255198,2255198, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {248 },
 new byte[]  { 0 },2255200,2255200, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {252 },
 new byte[]  { 0 },2255202,2255202, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {253 },
 new byte[]  { 0 },2255204,2255204, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {254 },
 new byte[]  { 0 },2255206,2255206, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {2,1,3,1,7,1,101,1,104,1,118,1,59,2,84,2,85,2,61,2,64,2,138,2,134,2,139,2,140,2,141,2,142,2,144,2,145,2,149,2,150,2,161,2,163,2,10,3,11,3,12,3,14,3,15,3,16,3,19 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },2255208,2255266, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {18,3,66,3,101,3 },
 new byte[]  { 0,0,0,0,0,0 },2255268,2255273, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {84 },
 new byte[]  { 0 },2255300,2255300, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {29 },
 new byte[]  { 0 },2255302,2255302, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {30 },
 new byte[]  { 0 },2255304,2255304, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {35 },
 new byte[]  { 0 },2255306,2255306, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {37 },
 new byte[]  { 0 },2255308,2255308, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {85 },
 new byte[]  { 0 },2255310,2255310, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64 },
 new byte[]  { 0 },2255312,2255312, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {81 },
 new byte[]  { 0 },2255314,2255314, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {114 },
 new byte[]  { 0 },2255316,2255316, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {115 },
 new byte[]  { 0 },2255318,2255318, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {116 },
 new byte[]  { 0 },2255320,2255320, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {118 },
 new byte[]  { 0 },2255322,2255322, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {158 },
 new byte[]  { 0 },2255324,2255324, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {218 },
 new byte[]  { 0 },2255326,2255326, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {234 },
 new byte[]  { 0 },2255328,2255328, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {246 },
 new byte[]  { 0 },2255330,2255330, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {247 },
 new byte[]  { 0 },2255332,2255332, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {248 },
 new byte[]  { 0 },2255334,2255334, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {252 },
 new byte[]  { 0 },2255336,2255336, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {253 },
 new byte[]  { 0 },2255338,2255338, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {254 },
 new byte[]  { 0 },2255340,2255340, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {2,1,3,1,7,1,78,1,79,1,101,1,104,1,118,1,161,1,163,1,165,1,166,1,235,1,246,1,254,1,10,2,12,2,59,2,84,2,85,2,92,2,10 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },2255342,2255384, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {95,2,97,2,61,2,64,2,66,2,69,2,9 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0 },2255386,2255398, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {72,2,2 },
 new byte[]  { 0,0,0 },2255400,2255402, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {118,2,120,2,138,2,134,2,139,2,140,2,141,2,142,2,144,2,145,2,149,2,150,2,161,2,163,2,10,3,11,3,12,3,14,3,15,3,16,3,19 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },2255404,2255444, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {18,3,66,3,100,3,101,3 },
 new byte[]  { 0,0,0,0,0,0,0,0 },2255446,2255453, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {84 },
 new byte[]  { 0 },2255640,2255640, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {85 },
 new byte[]  { 0 },2255642,2255642, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {218 },
 new byte[]  { 0 },2255644,2255644, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {234 },
 new byte[]  { 0 },2255646,2255646, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {246 },
 new byte[]  { 0 },2255648,2255648, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {247 },
 new byte[]  { 0 },2255650,2255650, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {248 },
 new byte[]  { 0 },2255652,2255652, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {252 },
 new byte[]  { 0 },2255654,2255654, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {253 },
 new byte[]  { 0 },2255656,2255656, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {254 },
 new byte[]  { 0 },2255658,2255658, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {2,1,3,1,7,1,101,1,104,1,118,1,59,2,84,2,85,2,61,2,64,2,2 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },2255660,2255682, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {115,2,118,2,120,2,138,2,134,2,139,2,140,2,141,2,144,2,145,2,149,2,150,2,161,2,163,2,10,3,11,3,12,3,14,3,15,3,16,3,19 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },2255684,2255724, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {18,3,66,3,94,3,101,3 },
 new byte[]  { 0,0,0,0,0,0,0,0 },2255726,2255733, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {84 },
 new byte[]  { 0 },2255754,2255754, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {29 },
 new byte[]  { 0 },2255756,2255756, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {30 },
 new byte[]  { 0 },2255758,2255758, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {35 },
 new byte[]  { 0 },2255760,2255760, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {37 },
 new byte[]  { 0 },2255762,2255762, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {85 },
 new byte[]  { 0 },2255764,2255764, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {64 },
 new byte[]  { 0 },2255766,2255766, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {81 },
 new byte[]  { 0 },2255768,2255768, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {114 },
 new byte[]  { 0 },2255770,2255770, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {115 },
 new byte[]  { 0 },2255772,2255772, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {116 },
 new byte[]  { 0 },2255774,2255774, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {118 },
 new byte[]  { 0 },2255776,2255776, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {158 },
 new byte[]  { 0 },2255778,2255778, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {218 },
 new byte[]  { 0 },2255780,2255780, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {234 },
 new byte[]  { 0 },2255782,2255782, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {246 },
 new byte[]  { 0 },2255784,2255784, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {247 },
 new byte[]  { 0 },2255786,2255786, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {248 },
 new byte[]  { 0 },2255788,2255788, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {252 },
 new byte[]  { 0 },2255790,2255790, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {253 },
 new byte[]  { 0 },2255792,2255792, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {254 },
 new byte[]  { 0 },2255794,2255794, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {2,1,3,1,7,1,78,1,79,1,101,1,104,1,118,1,161,1,163,1,165,1,166,1,235,1,246,1,254,1,10,2,12,2,59,2,84,2,85,2,92,2,10 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },2255796,2255838, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {95,2,97,2,61,2,64,2,66,2,69,2,9 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0 },2255840,2255852, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {72,2,2 },
 new byte[]  { 0,0,0 },2255854,2255856, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {115,2,118,2,120,2,138,2,134,2,139,2,140,2,141,2,142,2,144,2,145,2,149,2,150,2,161,2,163,2,10,3,11,3,12,3,14,3,15,3,16,3,19 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },2255858,2255900, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {18,3,66,3,94,3,101,3 },
 new byte[]  { 0,0,0,0,0,0,0,0 },2255902,2255909, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {84 },
 new byte[]  { 0 },2266952,2266952, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {29 },
 new byte[]  { 0 },2266954,2266954, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {30 },
 new byte[]  { 0 },2266956,2266956, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {35 },
 new byte[]  { 0 },2266958,2266958, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {85 },
 new byte[]  { 0 },2266960,2266960, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {46 },
 new byte[]  { 0 },2266962,2266962, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {81 },
 new byte[]  { 0 },2266964,2266964, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {158 },
 new byte[]  { 0 },2266966,2266966, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {234 },
 new byte[]  { 0 },2266968,2266968, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {248 },
 new byte[]  { 0 },2266970,2266970, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {253 },
 new byte[]  { 0 },2266972,2266972, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {254 },
 new byte[]  { 0 },2266974,2266974, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {7,1,76,1,78,1,79,1,101,1,104,1,163,1,59,2,84,2,92,2,10 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },2266976,2266996, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {95,2,97,2,64,2,69,2,9 },
 new byte[]  { 0,0,0,0,0,0,0,0,0 },2266998,2267006, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {72,2,150,2,161,2,10,3,11,3,12,3,16,3,19 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },2267008,2267022, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {18,3,99,3,100,3 },
 new byte[]  { 0,0,0,0,0,0 },2267024,2267029, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {84 },
 new byte[]  { 0 },2267398,2267398, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {218 },
 new byte[]  { 0 },2267400,2267400, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {234 },
 new byte[]  { 0 },2267402,2267402, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {248 },
 new byte[]  { 0 },2267404,2267404, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {253 },
 new byte[]  { 0 },2267406,2267406, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {254 },
 new byte[]  { 0 },2267408,2267408, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {7,1,84,2,64,2,145,2,150,2,161,2,10,3,11,3,12,3,16,3,19 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },2267410,2267430, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {18,3 },
 new byte[]  { 0,0 },2267432,2267433, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {84 },
 new byte[]  { 0 },2267492,2267492, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {29 },
 new byte[]  { 0 },2267494,2267494, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {30 },
 new byte[]  { 0 },2267496,2267496, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {35 },
 new byte[]  { 0 },2267498,2267498, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {85 },
 new byte[]  { 0 },2267500,2267500, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {81 },
 new byte[]  { 0 },2267502,2267502, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {114 },
 new byte[]  { 0 },2267504,2267504, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {115 },
 new byte[]  { 0 },2267506,2267506, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {116 },
 new byte[]  { 0 },2267508,2267508, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {234 },
 new byte[]  { 0 },2267510,2267510, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {248 },
 new byte[]  { 0 },2267512,2267512, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {253 },
 new byte[]  { 0 },2267514,2267514, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {254 },
 new byte[]  { 0 },2267516,2267516, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {7,1,78,1,79,1,85,1,87,1,88,1,90,1,96,1,97,1,101,1,104,1,161,1,163,1,165,1,166,1,246,1,12,2,59,2,84,2,92,2,10 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },2267518,2267558, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {95,2,97,2,64,2,66,2,69,2,9 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0 },2267560,2267570, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {72,2,2 },
 new byte[]  { 0,0,0 },2267572,2267574, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {118,2,120,2,150,2,161,2,10,3,11,3,12,3,16,3,19 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },2267576,2267592, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {18,3 },
 new byte[]  { 0,0 },2267594,2267595, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {234 },
 new byte[]  { 0 },2267634,2267634, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {248 },
 new byte[]  { 0 },2267636,2267636, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {253 },
 new byte[]  { 0 },2267638,2267638, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {254 },
 new byte[]  { 0 },2267640,2267640, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {7,1,64,2,10,3 },
 new byte[]  { 0,0,0,0,0,0 },2267642,2267647, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {84 },
 new byte[]  { 0 },2268752,2268752, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {29 },
 new byte[]  { 0 },2268754,2268754, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {30 },
 new byte[]  { 0 },2268756,2268756, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {35 },
 new byte[]  { 0 },2268758,2268758, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {85 },
 new byte[]  { 0 },2268760,2268760, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {81 },
 new byte[]  { 0 },2268762,2268762, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {114 },
 new byte[]  { 0 },2268764,2268764, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {115 },
 new byte[]  { 0 },2268766,2268766, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {116 },
 new byte[]  { 0 },2268768,2268768, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {234 },
 new byte[]  { 0 },2268770,2268770, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {248 },
 new byte[]  { 0 },2268772,2268772, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {253 },
 new byte[]  { 0 },2268774,2268774, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {254 },
 new byte[]  { 0 },2268776,2268776, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {7,1,78,1,79,1,85,1,87,1,88,1,90,1,96,1,97,1,101,1,104,1,161,1,163,1,165,1,166,1,246,1,12,2,59,2,84,2,92,2,10 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },2268778,2268818, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {95,2,97,2,64,2,66,2,69,2,9 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0 },2268820,2268830, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {72,2,2 },
 new byte[]  { 0,0,0 },2268832,2268834, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {118,2,120,2,150,2,161,2,10,3,11,3,12,3,16,3,19 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },2268836,2268852, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {18,3 },
 new byte[]  { 0,0 },2268854,2268855, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {234 },
 new byte[]  { 0 },2268894,2268894, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {248 },
 new byte[]  { 0 },2268896,2268896, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {253 },
 new byte[]  { 0 },2268898,2268898, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {254 },
 new byte[]  { 0 },2268900,2268900, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {7,1,64,2,10,3 },
 new byte[]  { 0,0,0,0,0,0 },2268902,2268907, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {84 },
 new byte[]  { 0 },2269292,2269292, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {29 },
 new byte[]  { 0 },2269294,2269294, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {30 },
 new byte[]  { 0 },2269296,2269296, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {35 },
 new byte[]  { 0 },2269298,2269298, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {85 },
 new byte[]  { 0 },2269300,2269300, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {81 },
 new byte[]  { 0 },2269302,2269302, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {218 },
 new byte[]  { 0 },2269304,2269304, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {234 },
 new byte[]  { 0 },2269306,2269306, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {248 },
 new byte[]  { 0 },2269308,2269308, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {253 },
 new byte[]  { 0 },2269310,2269310, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {254 },
 new byte[]  { 0 },2269312,2269312, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {7,1,101,1,104,1,163,1,205,1,235,1,246,1,254,1,10,2,12,2,59,2,84,2,64,2,138,2,134,2,144,2,146,2,149,2,150,2,153,2,157,2,161,2,162,2,163,2,10,3,11,3,12,3,16,3,19 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },2269314,2269370, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {18,3,66,3,94,3 },
 new byte[]  { 0,0,0,0,0,0 },2269372,2269377, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {84 },
 new byte[]  { 0 },2269528,2269528, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {29 },
 new byte[]  { 0 },2269530,2269530, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {30 },
 new byte[]  { 0 },2269532,2269532, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {35 },
 new byte[]  { 0 },2269534,2269534, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {85 },
 new byte[]  { 0 },2269536,2269536, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {81 },
 new byte[]  { 0 },2269538,2269538, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {114 },
 new byte[]  { 0 },2269540,2269540, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {115 },
 new byte[]  { 0 },2269542,2269542, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {116 },
 new byte[]  { 0 },2269544,2269544, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {218 },
 new byte[]  { 0 },2269546,2269546, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {234 },
 new byte[]  { 0 },2269548,2269548, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {248 },
 new byte[]  { 0 },2269550,2269550, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {253 },
 new byte[]  { 0 },2269552,2269552, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {254 },
 new byte[]  { 0 },2269554,2269554, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {7,1,78,1,79,1,85,1,86,1,87,1,88,1,90,1,95,1,97,1,101,1,104,1,118,1,161,1,163,1,165,1,166,1,246,1,12,2,59,2,84,2,92,2,10 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },2269556,2269600, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {95,2,97,2,64,2,66,2,69,2,9 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0 },2269602,2269612, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {72,2,2 },
 new byte[]  { 0,0,0 },2269614,2269616, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {112,2,118,2,120,2,138,2,134,2,144,2,145,2,146,2,149,2,150,2,153,2,157,2,161,2,162,2,163,2,10,3,11,3,12,3,16,3,19 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },2269618,2269656, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {18,3,66,3 },
 new byte[]  { 0,0,0,0 },2269658,2269661, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {84 },
 new byte[]  { 0 },2269688,2269688, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {29 },
 new byte[]  { 0 },2269690,2269690, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {30 },
 new byte[]  { 0 },2269692,2269692, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {35 },
 new byte[]  { 0 },2269694,2269694, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {85 },
 new byte[]  { 0 },2269696,2269696, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {81 },
 new byte[]  { 0 },2269698,2269698, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {114 },
 new byte[]  { 0 },2269700,2269700, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {115 },
 new byte[]  { 0 },2269702,2269702, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {116 },
 new byte[]  { 0 },2269704,2269704, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {218 },
 new byte[]  { 0 },2269706,2269706, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {234 },
 new byte[]  { 0 },2269708,2269708, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {248 },
 new byte[]  { 0 },2269710,2269710, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {253 },
 new byte[]  { 0 },2269712,2269712, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {254 },
 new byte[]  { 0 },2269714,2269714, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {7,1,78,1,79,1,85,1,86,1,87,1,88,1,90,1,95,1,97,1,101,1,104,1,118,1,161,1,163,1,165,1,166,1,246,1,12,2,59,2,84,2,92,2,10 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },2269716,2269760, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {95,2,97,2,64,2,66,2,69,2,9 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0 },2269762,2269772, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {72,2,2 },
 new byte[]  { 0,0,0 },2269774,2269776, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {112,2,118,2,120,2,138,2,134,2,144,2,145,2,146,2,149,2,150,2,153,2,157,2,161,2,162,2,163,2,10,3,11,3,12,3,16,3,19 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },2269778,2269816, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {18,3,66,3 },
 new byte[]  { 0,0,0,0 },2269818,2269821, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {84 },
 new byte[]  { 0 },2270084,2270084, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {43 },
 new byte[]  { 0 },2270086,2270086, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {29 },
 new byte[]  { 0 },2270088,2270088, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {30 },
 new byte[]  { 0 },2270090,2270090, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {35 },
 new byte[]  { 0 },2270092,2270092, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {85 },
 new byte[]  { 0 },2270094,2270094, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {81 },
 new byte[]  { 0 },2270096,2270096, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {114 },
 new byte[]  { 0 },2270098,2270098, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {115 },
 new byte[]  { 0 },2270100,2270100, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {116 },
 new byte[]  { 0 },2270102,2270102, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {218 },
 new byte[]  { 0 },2270104,2270104, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {234 },
 new byte[]  { 0 },2270106,2270106, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {248 },
 new byte[]  { 0 },2270108,2270108, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {253 },
 new byte[]  { 0 },2270110,2270110, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {254 },
 new byte[]  { 0 },2270112,2270112, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {7,1,78,1,79,1,85,1,86,1,87,1,88,1,90,1,95,1,97,1,101,1,104,1,161,1,163,1,165,1,166,1,246,1,12,2,59,2,84,2,92,2,10 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },2270114,2270156, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {95,2,97,2,64,2,66,2,69,2,9 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0 },2270158,2270168, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {72,2,2 },
 new byte[]  { 0,0,0 },2270170,2270172, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {118,2,120,2,138,2,134,2,144,2,149,2,150,2,153,2,157,2,161,2,162,2,163,2,10,3,11,3,12,3,16,3,19 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },2270174,2270206, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {18,3,66,3 },
 new byte[]  { 0,0,0,0 },2270208,2270211, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {84 },
 new byte[]  { 0 },2270244,2270244, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {43 },
 new byte[]  { 0 },2270246,2270246, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {29 },
 new byte[]  { 0 },2270248,2270248, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {30 },
 new byte[]  { 0 },2270250,2270250, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {35 },
 new byte[]  { 0 },2270252,2270252, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {85 },
 new byte[]  { 0 },2270254,2270254, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {81 },
 new byte[]  { 0 },2270256,2270256, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {114 },
 new byte[]  { 0 },2270258,2270258, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {115 },
 new byte[]  { 0 },2270260,2270260, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {116 },
 new byte[]  { 0 },2270262,2270262, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {218 },
 new byte[]  { 0 },2270264,2270264, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {234 },
 new byte[]  { 0 },2270266,2270266, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {248 },
 new byte[]  { 0 },2270268,2270268, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {253 },
 new byte[]  { 0 },2270270,2270270, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {254 },
 new byte[]  { 0 },2270272,2270272, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {7,1,78,1,79,1,85,1,86,1,87,1,88,1,90,1,95,1,97,1,101,1,104,1,161,1,163,1,165,1,166,1,246,1,12,2,59,2,84,2,92,2,10 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },2270274,2270316, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {95,2,97,2,64,2,66,2,69,2,9 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0 },2270318,2270328, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {72,2,2 },
 new byte[]  { 0,0,0 },2270330,2270332, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {118,2,120,2,138,2,134,2,144,2,149,2,150,2,153,2,157,2,161,2,162,2,163,2,10,3,11,3,12,3,16,3,19 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },2270334,2270366, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {18,3,66,3 },
 new byte[]  { 0,0,0,0 },2270368,2270371, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {29 },
 new byte[]  { 0 },2283076,2283076, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {30 },
 new byte[]  { 0 },2283078,2283078, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {35 },
 new byte[]  { 0 },2283080,2283080, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {85 },
 new byte[]  { 0 },2283082,2283082, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {81 },
 new byte[]  { 0 },2283084,2283084, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {114 },
 new byte[]  { 0 },2283086,2283086, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {115 },
 new byte[]  { 0 },2283088,2283088, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {116 },
 new byte[]  { 0 },2283090,2283090, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {78,1,79,1,101,1,104,1,118,1,161,1,163,1,59,2,2 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },2283092,2283108, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {112,2,118,2,120,2,138,2,134,2,144,2,149,2,150,2,161,2,163,2,66,3 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },2283110,2283131, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {84 },
 new byte[]  { 0 },2283236,2283236, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {29 },
 new byte[]  { 0 },2283238,2283238, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {30 },
 new byte[]  { 0 },2283240,2283240, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {35 },
 new byte[]  { 0 },2283242,2283242, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {85 },
 new byte[]  { 0 },2283244,2283244, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {81 },
 new byte[]  { 0 },2283246,2283246, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {146 },
 new byte[]  { 0 },2283248,2283248, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {234 },
 new byte[]  { 0 },2283250,2283250, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {248 },
 new byte[]  { 0 },2283252,2283252, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {253 },
 new byte[]  { 0 },2283254,2283254, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {254 },
 new byte[]  { 0 },2283256,2283256, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {7,1,101,1,104,1,161,1,163,1,205,1,246,1,12,2,59,2,84,2,64,2,150,2,161,2,10,3,11,3,12,3,16,3,19 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },2283258,2283292, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {18,3,94,3,101,3 },
 new byte[]  { 0,0,0,0,0,0 },2283294,2283299, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {84 },
 new byte[]  { 0 },2283336,2283336, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {234 },
 new byte[]  { 0 },2283338,2283338, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {248 },
 new byte[]  { 0 },2283340,2283340, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {253 },
 new byte[]  { 0 },2283342,2283342, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {254 },
 new byte[]  { 0 },2283344,2283344, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {7,1,161,1,84,2,64,2,150,2,161,2,10,3,11,3,12,3,16,3,19 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },2283346,2283366, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {18,3 },
 new byte[]  { 0,0 },2283368,2283369, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {85 },
 new byte[]  { 0 },2303810,2303810, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {114 },
 new byte[]  { 0 },2303812,2303812, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {115 },
 new byte[]  { 0 },2303814,2303814, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {116 },
 new byte[]  { 0 },2303816,2303816, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {158 },
 new byte[]  { 0 },2303818,2303818, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {78,1,101,1,104,1,59,2,150,2,161,2,196,2,99,3,100,3 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },2303820,2303837, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {84 },
 new byte[]  { 0 },2304752,2304752, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {43 },
 new byte[]  { 0 },2304754,2304754, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {29 },
 new byte[]  { 0 },2304756,2304756, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {30 },
 new byte[]  { 0 },2304758,2304758, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {35 },
 new byte[]  { 0 },2304760,2304760, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {37 },
 new byte[]  { 0 },2304762,2304762, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {85 },
 new byte[]  { 0 },2304764,2304764, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {81 },
 new byte[]  { 0 },2304766,2304766, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {114 },
 new byte[]  { 0 },2304768,2304768, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {115 },
 new byte[]  { 0 },2304770,2304770, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {116 },
 new byte[]  { 0 },2304772,2304772, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {218 },
 new byte[]  { 0 },2304774,2304774, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {234 },
 new byte[]  { 0 },2304776,2304776, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {248 },
 new byte[]  { 0 },2304778,2304778, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {253 },
 new byte[]  { 0 },2304780,2304780, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {254 },
 new byte[]  { 0 },2304782,2304782, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {7,1,78,1,79,1,85,1,87,1,88,1,90,1,93,1,96,1,101,1,104,1,118,1,161,1,163,1,165,1,166,1,246,1,12,2,59,2,84,2,92,2,10 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },2304784,2304826, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {95,2,97,2,64,2,66,2,69,2,9 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0 },2304828,2304838, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {72,2,2 },
 new byte[]  { 0,0,0 },2304840,2304842, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {112,2,118,2,120,2,138,2,134,2,144,2,149,2,150,2,161,2,163,2,10,3,11,3,12,3,16,3,19 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },2304844,2304872, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {18,3,66,3 },
 new byte[]  { 0,0,0,0 },2304874,2304877, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {84 },
 new byte[]  { 0 },2305358,2305358, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {29 },
 new byte[]  { 0 },2305360,2305360, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {30 },
 new byte[]  { 0 },2305362,2305362, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {35 },
 new byte[]  { 0 },2305364,2305364, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {85 },
 new byte[]  { 0 },2305366,2305366, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {81 },
 new byte[]  { 0 },2305368,2305368, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {234 },
 new byte[]  { 0 },2305370,2305370, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {248 },
 new byte[]  { 0 },2305372,2305372, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {253 },
 new byte[]  { 0 },2305374,2305374, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {254 },
 new byte[]  { 0 },2305376,2305376, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {7,1,78,1,79,1,85,1,87,1,88,1,90,1,95,1,96,1,101,1,104,1,161,1,163,1,59,2,84,2,64,2,150,2,161,2,10,3,11,3,12,3,16,3,19 },
 new byte[]  { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },2305378,2305422, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {18,3 },
 new byte[]  { 0,0 },2305424,2305425, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {234 },
 new byte[]  { 0 },2307030,2307030, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {248 },
 new byte[]  { 0 },2307032,2307032, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {253 },
 new byte[]  { 0 },2307034,2307034, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {254 },
 new byte[]  { 0 },2307036,2307036, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {7,1,64,2,10,3 },
 new byte[]  { 0,0,0,0,0,0 },2307038,2307043, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {234 },
 new byte[]  { 0 },2307068,2307068, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {248 },
 new byte[]  { 0 },2307070,2307070, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {253 },
 new byte[]  { 0 },2307072,2307072, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {254 },
 new byte[]  { 0 },2307074,2307074, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {7,1,64,2,10,3 },
 new byte[]  { 0,0,0,0,0,0 },2307076,2307081, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {234 },
 new byte[]  { 0 },2307144,2307144, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {248 },
 new byte[]  { 0 },2307146,2307146, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {253 },
 new byte[]  { 0 },2307148,2307148, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {254 },
 new byte[]  { 0 },2307150,2307150, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {7,1,64,2,10,3 },
 new byte[]  { 0,0,0,0,0,0 },2307152,2307157, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {234 },
 new byte[]  { 0 },2307182,2307182, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {248 },
 new byte[]  { 0 },2307184,2307184, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {253 },
 new byte[]  { 0 },2307186,2307186, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {254 },
 new byte[]  { 0 },2307188,2307188, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {7,1,64,2,10,3 },
 new byte[]  { 0,0,0,0,0,0 },2307190,2307195, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {234 },
 new byte[]  { 0 },2307220,2307220, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {248 },
 new byte[]  { 0 },2307222,2307222, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {253 },
 new byte[]  { 0 },2307224,2307224, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {254 },
 new byte[]  { 0 },2307226,2307226, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {7,1,64,2,10,3 },
 new byte[]  { 0,0,0,0,0,0 },2307228,2307233, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {234 },
 new byte[]  { 0 },2307258,2307258, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {248 },
 new byte[]  { 0 },2307260,2307260, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {253 },
 new byte[]  { 0 },2307262,2307262, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {254 },
 new byte[]  { 0 },2307264,2307264, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {7,1,64,2,10,3 },
 new byte[]  { 0,0,0,0,0,0 },2307266,2307271, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3,3 },
 new byte[]  { 255,255 },2331456,2331457, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3,3,3,3,3,3,1,1 },
 new byte[]  { 255,255,255,255,255,255,255,255 },2331468,2331475, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {3,3,1,1 },
 new byte[]  { 255,255,255,255 },2331478,2331481, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {0,128,0,128,0,0 },
 new byte[]  { 255,255,255,255,255,255 },2331638,2331643, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {0,128,0,128,0,128,15,0,0,128,0,128,15,0,0,128,0,128 },
 new byte[]  { 255,255,255,255,255,255,255,255,255,255,255,255,255,255,255,255,255,255 },2331650,2331667, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {0,128 },
 new byte[]  { 255,255 },2331890,2331891, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {0,0,0,0,0,0,0,0,0,0 },
 new byte[]  { 255,255,255,255,255,255,255,255,255,255 },2331898,2331907, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {0,128,0,128 },
 new byte[]  { 255,255,255,255 },2331932,2331935, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {0,0 },
 new byte[]  { 255,255 },2331944,2331945, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {0,128,0,128 },
 new byte[]  { 255,255,255,255 },2331948,2331951, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {0,128,0,128 },
 new byte[]  { 255,255,255,255 },2331956,2331959, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {235,0,0,128,235,0 },
 new byte[]  { 255,255,255,255,255,255 },2332072,2332077, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {0,128,0,128,0,128,65,0,0,128,0,128,0,128 },
 new byte[]  { 255,255,255,255,255,255,255,255,255,255,255,255,255,255 },2332080,2332093, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {105,0,0,128,0,128,0,128 },
 new byte[]  { 255,255,255,255,255,255,255,255 },2332114,2332121, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {0,128,0,128,105,0,105,0,0,128,0,128,105,0,105,0,0,0,235,0 },
 new byte[]  { 255,255,255,255,255,255,255,255,255,255,255,255,255,255,255,255,255,255,255,255 },2332126,2332145, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {0,128,105,0,105,0 },
 new byte[]  { 255,255,255,255,255,255 },2332342,2332347, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {73,0,0,128,0,128,0,128,235,0 },
 new byte[]  { 255,255,255,255,255,255,255,255,255,255 },2332524,2332533, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {0,128 },
 new byte[]  { 255,255 },2333074,2333075, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {0,128,0,128 },
 new byte[]  { 255,255,255,255 },2333094,2333097, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {0,128 },
 new byte[]  { 255,255 },2333100,2333101, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {0,128 },
 new byte[]  { 255,255 },2333114,2333115, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {0,128,0,128 },
 new byte[]  { 255,255,255,255 },2333172,2333175, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {0,0,0,0 },
 new byte[]  { 255,255,255,255 },2333186,2333189, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {0,0,0,0,0,128,0,128 },
 new byte[]  { 255,255,255,255,255,255,255,255 },2333192,2333199, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {0,128,0,128,0,128 },
 new byte[]  { 255,255,255,255,255,255 },2333256,2333261, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {105,0,105,0,105,0,105,0,0,128,0,128 },
 new byte[]  { 255,255,255,255,255,255,255,255,255,255,255,255 },2333276,2333287, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {105,0,0,0,0,128 },
 new byte[]  { 255,255,255,255,255,255 },2333296,2333301, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {0,128,0,128,0,128,0,128 },
 new byte[]  { 255,255,255,255,255,255,255,255 },2333354,2333361, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {0,128,0,128,0,128,0,128,0,128,0,128,0,128,0,128,0,128 },
 new byte[]  { 255,255,255,255,255,255,255,255,255,255,255,255,255,255,255,255,255,255 },2333368,2333385, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {0,128,0,128 },
 new byte[]  { 255,255,255,255 },2333440,2333443, "Found egr map...Delete map");
ToolBox.ReplaceInFileWithStartStop(new byte[]  {0,128,0,128,0,128,0,128 },
 new byte[]  { 255,255,255,255,255,255,255,255 },2333622,2333629, "Found egr map...Delete map");
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