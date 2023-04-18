using ToolBoxNameSpace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CobraCarSolution.TreeElements.VAG
{
    class VAG_EDC17CP14 : MenuItem, ITreeItem
    {
        public VAG_EDC17CP14()
        {
            Title = "EDC17CP14";
            IsSolutionItem = true;
            hasEgrSolution = true;
            hasDpfSolution = true;
            hasDtcSolution = true;
        }

        public override void initFunction()
        {
            ToolBox.AddLineToConsoleBox("VAG_EDC17CP14 selected...");
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

        public void dpfOffSolution()
        {
            throw new NotImplementedException();
        }
    }
}
