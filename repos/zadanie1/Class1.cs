using System;
using System.IO;

class Class1
{
    private string outPut;

    private static string line, y, x;

    public void outPutString()
    {
        Console.WriteLine(outPut);
    }

    public Class1(string path)
    {
        try
        {
            using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
            {
                while (!sr.EndOfStream)
                {
                    line = sr.ReadLine();
                    line = line.Replace(",", " ").Replace(".", ",");
                    y = line.Substring(line.IndexOf(" "));
                    x = line.Substring(0, line.IndexOf(" "));

                    outPut += "X: " + x + " Y:" + y + "\n";
                }

            }

        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

}

