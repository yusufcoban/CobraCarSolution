using SmartFormat;
using SmartFormat.Core.Settings;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolBoxNameSpace;

namespace CobraCarSolution.TreeElements.GenerateTemplate
{
    public class GeneralTemplate
    {
        public string TitleECU = "";
        public bool hasEgrSolution = false;
        public bool hasDpfSolution = false;
        public bool hasDtcSolution = false;
        public bool hasTVASolution = false;
        public bool hasFileCheckSize = false;
        public bool hasLamdaSolution = false;
        public bool hasFLAPSSolution = false;
        public bool hasStartStopSolution = false;
        public bool hasADBlueSolution = false;
        public bool hasReadinessSolution = false;
        public bool hasImmoSolution = false;
        public bool hasSpecialISolution = false;
        public bool hasSpecialIISolution = false;
        public bool hasSpecialIIISolution = false;
        public string specialISolutionDescription = "";
        public string specialIISolutionDescription = "";
        public string specialIIISolutionDescription = "";
        public string desciption = "";
        public int fileSize = 0;

        public string FileForEgrCODE = "";
        public string FileForDpfCODE = "";
        public string FileForTvaCODE = "";
        public string FileForLamdaCODE = "";
        public string FileForFlapsCODE = "";
        public string FileForStartStopCODE = "";
        public string FileForAdBlueCODE = "";
        public string FileForReadinessCODE = "";
        public string FileForImmoCODE = "";
        public string FileForSpecialICODE = "";
        public string FileForSpecialIICODE = "";
        public string FileForSpecialIIICODE = "";



        public string checkFileForEgrCODE = "";
        public string checkFileForDpfCODE = "";
        public string checkFileForTvaCODE = "";
        public string checkFileForLamdaCODE = "";
        public string checkFileForFlapsCODE = "";
        public string checkFileForStartStopCODE = "";
        public string checkFileForAdBlueCODE = "";
        public string checkFileForReadinessCODE = "";
        public string checkFileForImmoCODE = "";
        public string checkFileForSpecialICODE = "";
        public string checkFileForSpecialIICODE = "";
        public string checkFileForSpecialIIICODE = "";



        public void GenerateCs()
        {

        }
    }

    public static class GenerateCSFile
    {
        public static string template = "using ToolBoxNameSpace;\r\nusing System;\r\nusing System.Collections.Generic;\r\nusing System.Linq;\r\nusing System.Reflection;\r\nusing System.Text;\r\nusing System.Threading.Tasks;\r\nusing System.Windows.Controls;\r\nusing System.Windows;\r\nusing System.IO;\r\n\r\nnamespace CobraCarSolution.TreeElements.VAG doubleBrackedOpen\r\n  class {TitleECU} :MenuItem, ITreeItem doubleBrackedOpen\r\n    public {TitleECU}() doubleBrackedOpen\r\n      Title = StricheOben{TitleECU}StricheOben;\r\n      IsSolutionItem =  true;\r\n      hasDtcSolution =  {hasDtcSolution};\r\n      hasEgrSolution = {hasEgrSolution};\r\n      hasTVASolution = {hasTVASolution};\r\n      hasFileCheckSize ={hasFileCheckSize};\r\n      hasDpfSolution ={hasDpfSolution};\r\n      hasLamdaSolution ={hasLamdaSolution};\r\n      hasFLAPSSolution ={hasFLAPSSolution};\r\n      hasStartStopSolution ={hasStartStopSolution};\r\n      hasADBlueSolution ={hasADBlueSolution};\r\n      hasReadinessSolution ={hasReadinessSolution};\r\n      hasImmoSolution ={hasImmoSolution};\r\n      hasSpecialISolution ={hasSpecialISolution};\r\n      hasSpecialIISolution ={hasSpecialIISolution};\r\n      hasSpecialIIISolution ={hasSpecialIIISolution};\r\n      specialISolutionDescription=StricheOben{specialISolutionDescription}StricheOben;\r\n      specialIISolutionDescription=StricheOben{specialIISolutionDescription}StricheOben;\r\n      specialIIISolutionDescription=StricheOben{specialIIISolutionDescription}StricheOben;\r\n      desciption=StricheOben{desciption}StricheOben;\r\n      FileSizeArray = new int[] doubleBrackedOpen  {fileSize} doubleBrackedClosed;\r\n    doubleBrackedClosed\r\n\r\n    public override async Task < bool > checkFileForEgr() doubleBrackedOpen\r\n      bool validationEgrInFile = true;\r\n      //Algo for checking dpf solution\r\n      if (ToolBox.array.Length > 0) doubleBrackedOpen\r\n\t\t{checkFileForEgrCODE}\r\n      doubleBrackedClosed\r\n      return validationEgrInFile;\r\n    doubleBrackedClosed\r\n    public override async Task < bool > checkFileForDpf() doubleBrackedOpen\r\n      bool validationEgrInFile = true;\r\n      //Algo for checking dpf solution\r\n      if (ToolBox.array.Length > 0) doubleBrackedOpen\r\n{checkFileForDpfCODE}\r\n      doubleBrackedClosed\r\n      return validationEgrInFile;\r\n\r\n    doubleBrackedClosed\r\n    public override async Task < bool > checkFileForTva() doubleBrackedOpen\r\n      bool validationEgrInFile = true;\r\n      //Algo for checking dpf solution\r\n      if (ToolBox.array.Length > 0) doubleBrackedOpen\r\n{checkFileForTvaCODE}\r\n      doubleBrackedClosed\r\n      return validationEgrInFile;\r\n    doubleBrackedClosed\r\n\r\n    public override async Task < bool > checkFileForLamda() doubleBrackedOpen\r\n      bool validationEgrInFile = true;\r\n      //Algo for checking dpf solution\r\n      if (ToolBox.array.Length > 0) doubleBrackedOpen\r\n{checkFileForLamdaCODE}\r\n      doubleBrackedClosed\r\n      return validationEgrInFile;\r\n    doubleBrackedClosed\r\n\r\n    public override async Task < bool > checkFileForFlaps() doubleBrackedOpen\r\n      bool validationEgrInFile = true;\r\n      //Algo for checking dpf solution\r\n      if (ToolBox.array.Length > 0) doubleBrackedOpen\r\n{checkFileForFlapsCODE}\r\n      doubleBrackedClosed\r\n      return validationEgrInFile;\r\n    doubleBrackedClosed\r\n\r\n    public override async Task < bool > checkFileForStartStop() doubleBrackedOpen\r\n      bool validationEgrInFile = true;\r\n      //Algo for checking dpf solution\r\n      if (ToolBox.array.Length > 0) doubleBrackedOpen\r\n{checkFileForStartStopCODE}\r\n      doubleBrackedClosed\r\n      return validationEgrInFile;\r\n    doubleBrackedClosed\r\n\r\n    public override async Task < bool > checkFileForAdBlue() doubleBrackedOpen\r\n      bool validationEgrInFile = true;\r\n      //Algo for checking dpf solution\r\n      if (ToolBox.array.Length > 0) doubleBrackedOpen\r\n{checkFileForAdBlueCODE}\r\n      doubleBrackedClosed\r\n      return validationEgrInFile;\r\n    doubleBrackedClosed\r\n\r\n    public override async Task < bool > checkFileForReadiness() doubleBrackedOpen\r\n      bool validationEgrInFile = true;\r\n      //Algo for checking dpf solution\r\n      if (ToolBox.array.Length > 0) doubleBrackedOpen\r\n{checkFileForReadinessCODE}\r\n      doubleBrackedClosed\r\n      return validationEgrInFile;\r\n    doubleBrackedClosed\r\n\r\n    public override async Task < bool > checkFileForImmo() doubleBrackedOpen\r\n      bool validationEgrInFile = true;\r\n      //Algo for checking dpf solution\r\n      if (ToolBox.array.Length > 0) doubleBrackedOpen\r\n{checkFileForImmoCODE}\r\n      doubleBrackedClosed\r\n      return validationEgrInFile;\r\n    doubleBrackedClosed\r\n\r\n    public override async Task < bool > checkFileForSpecialI() doubleBrackedOpen\r\n      bool validationEgrInFile = true;\r\n      //Algo for checking dpf solution\r\n      if (ToolBox.array.Length > 0) doubleBrackedOpen\r\n{checkFileForSpecialICODE}\r\n      doubleBrackedClosed\r\n      return validationEgrInFile;\r\n    doubleBrackedClosed\r\n\r\n    public override async Task < bool > checkFileForSpecialII() doubleBrackedOpen\r\n      bool validationEgrInFile = true;\r\n      //Algo for checking dpf solution\r\n      if (ToolBox.array.Length > 0) doubleBrackedOpen\r\n{checkFileForSpecialIICODE}\r\n      doubleBrackedClosed\r\n      return validationEgrInFile;\r\n    doubleBrackedClosed\r\n\r\n    public override async Task < bool > checkFileForSpecialIII() doubleBrackedOpen\r\n      bool validationEgrInFile = true;\r\n      //Algo for checking dpf solution\r\n      if (ToolBox.array.Length > 0) doubleBrackedOpen\r\n{checkFileForSpecialIIICODE}\r\n      doubleBrackedClosed\r\n      return validationEgrInFile;\r\n    doubleBrackedClosed\r\n\r\n    public override void egrOffSolution() doubleBrackedOpen\r\n\t{FileForEgrCODE}\r\n      base.egrOffSolution();\r\n    doubleBrackedClosed\r\n    public override void dpfOffSolution() doubleBrackedOpen\r\n\t{FileForDpfCODE}\r\n      base.dpfOffSolution();\r\n    doubleBrackedClosed\r\n    public override void lamdaOfffSolution() doubleBrackedOpen\r\n\t{FileForLamdaCODE}\r\n      base.lamdaOfffSolution();\r\n\r\n    doubleBrackedClosed\r\n\r\n    public override void flapsOfffSolution() doubleBrackedOpen\r\n\t{FileForFlapsCODE}\r\n\r\n      base.flapsOfffSolution();\r\n    doubleBrackedClosed\r\n    public override void startStopSolution() doubleBrackedOpen\r\n\t{FileForStartStopCODE}\r\n\r\n      base.startStopSolution();\r\n    doubleBrackedClosed\r\n\r\n    public override void adBlueSolution() doubleBrackedOpen\r\n\t{FileForAdBlueCODE}\r\n\r\n      base.adBlueSolution();\r\n    doubleBrackedClosed\r\n\r\n    public override void readnissSolution() doubleBrackedOpen\r\n\t{FileForReadinessCODE}\r\n\r\n      base.readnissSolution();\r\n    doubleBrackedClosed\r\n    public override void immoSolution() doubleBrackedOpen\r\n\t{FileForImmoCODE}\r\n      base.immoSolution();\r\n\r\n    doubleBrackedClosed\r\n\r\n    public override void tvaoffSolution() doubleBrackedOpen\r\n\t{FileForTvaCODE}\r\n\r\n      base.tvaoffSolution();\r\n    doubleBrackedClosed\r\n\r\n    public override void specialISolution() doubleBrackedOpen\r\n\t{FileForSpecialICODE}\r\n\r\n      base.specialISolution();\r\n    doubleBrackedClosed\r\n    public override void specialIISolution() doubleBrackedOpen\r\n\t{FileForSpecialIICODE}\r\n      base.specialIISolution();\r\n\r\n    doubleBrackedClosed\r\n\r\n    public override void specialIIISolution() doubleBrackedOpen\r\n\t{FileForSpecialIIICODE}\r\n      base.specialIIISolution();\r\n\r\n    doubleBrackedClosed\r\n\r\n    public List < string > getListOfDtcCodes() doubleBrackedOpen\r\n      return null;\r\n    doubleBrackedClosed\r\n\r\n    public override void RemoveDtcFromFile(string dtcCode) doubleBrackedOpen\r\n\r\n      base.RemoveDtcFromFile(dtcCode);\r\n    doubleBrackedClosed\r\n\r\n  doubleBrackedClosed\r\ndoubleBrackedClosed";
        public static void GenerateFile(GeneralTemplate fileInput, string filePath)
        {
            string generatedFile = Smart.Format(template, fileInput);
            generatedFile = generatedFile.Replace("doubleBrackedClosed", "}");
            generatedFile = generatedFile.Replace("doubleBrackedOpen", " {");
            generatedFile = generatedFile.Replace("StricheOben", "\"");
            generatedFile = generatedFile.Replace("False", "false");
            generatedFile = generatedFile.Replace("True", "true");

            Microsoft.Win32.SaveFileDialog saveDialog = new Microsoft.Win32.SaveFileDialog();

            saveDialog.FileName = fileInput.TitleECU + ".cs";
            saveDialog.Filter = "cs (*.cs)|*.cs";
            if (saveDialog.ShowDialog() == true)
            {
                File.WriteAllText(saveDialog.FileName, generatedFile); // Requires System.IO
            }
        }
    }


}
