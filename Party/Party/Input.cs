using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Party
{
  public class Input
  {
    public List<List<short>> Tests = new List<List<short>>();
    public void ReadInputFile(string path)
    {
      using (StreamReader sr = new StreamReader(path))
      {
        int counter = -1;
        while (!sr.EndOfStream)
        {
          counter = int.Parse(sr.ReadLine());
          if (counter > 0)
          {
            for (int i = 0; i < counter; i++)
            {
              int size = int.Parse(sr.ReadLine());
              List<short> elements = new List<short>(size);
              string[] parts = sr.ReadLine().Split(' ');
              for (int j = 0; j < size; j++)
              {
                elements.Add(short.Parse(parts[j]));
              }
              Tests.Add(elements);
            }
          }
        }

      }
    }
  }
}
