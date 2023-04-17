using CobraCarSolution.Toolbox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CobraCarSolution.TreeElements.VAG
{
    class VAG_EDC16CP45 : MenuItem, ITreeItem
    {
        public VAG_EDC16CP45()
        {
            Title = "EDC16CP45";
            IsSolutionItem = true;
            hasEgrSolution = true;
            hasDpfSolution = true;
            hasDtcSolution = false;
        }

        public override void initFunction()
        {
            ToolBox.AddLineToConsoleBox("VAG_EDC16CP45 selected...");
        }

        public override void egrOffSolution()
        {

        }
        public void dpfOffSolution()
        {

        }
        public List<string> getListOfDtcCodes()
        {
            // get list of all dtcs, Dtc code, mask, current state
            return null;
        }
        public override void RemoveDtcFromFile(string dtcCode)
        {
            //Find dtccodes
            //show how often found in file
            //+
            //36from file and call base function
            base.RemoveDtcFromFile(dtcCode);
        }

    }
}
