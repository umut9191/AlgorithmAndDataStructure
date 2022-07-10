using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmAndDataStructure
{
    public class In
    {
        public static IEnumerable<int> ReadInts(string filePath)
        {
            using (TextReader reader = File.OpenText(filePath))
            {
                string lastLine;
                while ((lastLine = reader.ReadLine()) != null)
                {
                    //yield used for lazy evaluation
                    //that means its not going to read whole file right away in case it is not necessary
                    yield return int.Parse(lastLine);
                }
            }
        }
    }
}
