using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Party
{
  /// <summary>
  /// Provides solution for input/RCTE_party.pdf Problem.
  /// </summary>
  class Program
  {
    static void Main(string[] args)
    {
      Input input = new Input();
      string path = "../../input/input-party-388b.txt";
      input.ReadInputFile(path);

      path = "../../output/input-party-388b.txt";
      using (StreamWriter sw = new StreamWriter(path))
      {
        for (int i = 0; i < input.Tests.Count; i++)
        {
          sw.Write("Case #"+(i+1)+": ");
          sw.WriteLine(input.Tests[i].Where(t=>t>0).Sum(t=>t));
        }
            
      }
    }
  }
}
