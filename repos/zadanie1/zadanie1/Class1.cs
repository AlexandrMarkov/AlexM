using System;
using System.IO;

class Class1
{
    private string outPut;

    private static string l, y, x;

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
                    l = sr.ReadLine();
                    l = l.Replace(",", " ").Replace(".", ",");
                    y = l.Substring(l.IndexOf(" "));
                    x = l.Substring(0, l.IndexOf(" "));

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

