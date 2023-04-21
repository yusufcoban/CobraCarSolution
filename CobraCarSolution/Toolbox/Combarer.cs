using System;
using System.Collections.Generic;
using System.Linq;
namespace ToolBoxNameSpace
{
    public class FileCombreResult
    {
        public List<CombareCreator> allDifferencesForEcu = new List<CombareCreator>();
        public string ecuName = "";

        public FileCombreResult(byte[] org, List<DiffCollection> diffCollection, string ecuName)
        {
            ecuName = this.ecuName;
            for (int i = 0; i < diffCollection.Count(); i++)
            {
                CombareCreator CombareCreator = new CombareCreator(diffCollection[i].solutionName, org, diffCollection[i].compare);
                allDifferencesForEcu.Add(CombareCreator);
            }

            //Here we have all differences

            //CREATE FILE
        }
    }

    public class DiffCollection
    {
        public byte[] compare = new byte[0];
        public string solutionName = "";
    }

    public class CombareCreator
    {
        public CombareResult results =new CombareResult();

        public CombareCreator(string solutionName, byte[] src, byte[] dest)
        {
            List<DifferenceClass> foundDifferences = new List<DifferenceClass>();
            //First Check size
            if (src.Count() == dest.Count())
            {
                for (int i = 0; i < src.Count(); i++)
                {
                    if (src[i] != dest[i])
                    {
                        DifferenceClass difference = new DifferenceClass(i, dest[i], src[i]);
                        foundDifferences.Add(difference);
                    }
                }
                Combarer Combarer = new Combarer(solutionName, foundDifferences);
                results.allCompareResult.Add(Combarer);
            }
            else
            {
                //ERROR FILE SIZE
            }
        }
    }

    public class CombareResult
    {
        public List<Combarer> allCompareResult = new List<Combarer>();

    }

    public class Combarer
    {
        public byte[] src = new byte[0];
        public byte[] dest = new byte[0];
        public List<DifferenceClassCollection> collectionDifference = new List<DifferenceClassCollection>();
        public string solutionName;
        public List<DifferenceClass> allDifferences;

        public Combarer(string solutionName, List<DifferenceClass> allDifferences)
        {
            this.solutionName = solutionName;
            allDifferences = allDifferences.OrderBy(o => o.adress).ToList(); // order by adress
            for (int i = 0; i < allDifferences.Count() - 1; i++)
            {
                int startAdress = allDifferences[i].adress;
                int newCounter = 0;

                if (i + 1 + newCounter >= allDifferences.Count())
                {
                    Console.WriteLine("");
                }
                while ((i + 1 + newCounter) < allDifferences.Count()
                    && allDifferences[i + 1 + newCounter].adress == (allDifferences[i + newCounter].adress + 1))
                {
                    newCounter++;
                }
                byte[] differences = new byte[newCounter + 1];
                byte[] orginal = new byte[newCounter + 1];

                for (int n = 0; n < newCounter + 1; n++)
                {
                    differences[n] = allDifferences[i + n].dif;
                    orginal[n] = allDifferences[i + n].org;
                }
                int endAdress = allDifferences[i + newCounter].adress;
                i = i + newCounter;
                DifferenceClassCollection collectionDataCreated = new DifferenceClassCollection(startAdress, endAdress, differences, orginal);
                collectionDifference.Add(collectionDataCreated);
            }
        }
    }

    public class DifferenceClass
    {
        public int adress;
        public byte org;
        public byte dif;

        public DifferenceClass(int adress, byte dif, byte org)
        {
            this.adress = adress;
            this.org = org;
            this.dif = dif;
        }
    }

    public class DifferenceClassCollection
    {
        public int startAdress;
        public int endAdress;
        public byte[] difference = new byte[0];
        public byte[] orginal = new byte[0];

        public DifferenceClassCollection(int startAdress, int endAdress, byte[] difference, byte[] orginal)
        {
            this.startAdress = startAdress;
            this.endAdress = endAdress;
            this.difference = difference;
            this.orginal = orginal;
        }

    }
}
