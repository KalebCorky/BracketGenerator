using System.Collections;
using System.Configuration;

public class BracketGenerator
{
    public static void Main(string[] args)
    {
        try
        {
            ArrayList songs = new ArrayList();
            StreamReader sr = new StreamReader(ConfigurationManager.AppSettings["InputFile"]);
            while (!sr.EndOfStream)
            {
                songs.Add(sr.ReadLine());
            }
            StreamWriter sw = new StreamWriter(ConfigurationManager.AppSettings["OutputFile"]);
            sw.WriteLine(":cowboy: " + songs[0] + " vs. :guitar: " + songs[31]);
            sw.WriteLine(":cowboy: " + songs[15] + " vs. :guitar: " + songs[16]);
            sw.WriteLine(":cowboy: " + songs[7] + " vs. :guitar: " + songs[24]);
            sw.WriteLine(":cowboy: " + songs[8] + " vs. :guitar: " + songs[23]);
            sw.WriteLine(":cowboy: " + songs[3] + " vs. :guitar: " + songs[28]);
            sw.WriteLine(":cowboy: " + songs[12] + " vs. :guitar: " + songs[19]);
            sw.WriteLine(":cowboy: " + songs[4] + " vs. :guitar: " + songs[27]);
            sw.WriteLine(":cowboy: " + songs[11] + " vs. :guitar: " + songs[20]);
            sw.WriteLine(":cowboy: " + songs[1] + " vs. :guitar: " + songs[30]);
            sw.WriteLine(":cowboy: " + songs[14] + " vs. :guitar: " + songs[17]);
            sw.WriteLine(":cowboy: " + songs[6] + " vs. :guitar: " + songs[25]);
            sw.WriteLine(":cowboy: " + songs[9] + " vs. :guitar: " + songs[22]);
            sw.WriteLine(":cowboy: " + songs[2] + " vs. :guitar: " + songs[29]);
            sw.WriteLine(":cowboy: " + songs[13] + " vs. :guitar: " + songs[18]);
            sw.WriteLine(":cowboy: " + songs[5] + " vs. :guitar: " + songs[26]);
            sw.WriteLine(":cowboy: " + songs[10] + " vs. :guitar: " + songs[21]);
            sr.Close();
            sw.Close();
        }
        catch(Exception e)
        {
            Console.WriteLine("ERROR: Something went wrong.");
            Console.WriteLine(e.Message);
        }
    }
}