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
            if (ConfigurationManager.AppSettings["BracketMode"] == "32")
            {
                OutputBracketResultsIn32Mode(sw, songs);
                sr.Close();
            }
            else if (ConfigurationManager.AppSettings["BracketMode"] == "64")
            {
                OutputBracketResultsIn64Mode(sw, songs);
                sr.Close();
            }
            else
            {
                throw new Exception("Mode not supported. Check App.config file -- mode should match either 32 or 64.");
            }
        }
        catch(Exception e)
        {
            Console.WriteLine("ERROR: Something went wrong.");
            Console.WriteLine(e.Message);
        }
    }

    private static void OutputBracketResultsIn64Mode(StreamWriter sw, ArrayList songs)
    {
        sw.WriteLine(":cowboy: " + songs[0] + " vs. :guitar: " + songs[63]);
        sw.WriteLine(":cowboy: " + songs[31] + " vs. :guitar: " + songs[32]);
        sw.WriteLine(":cowboy: " + songs[15] + " vs. :guitar: " + songs[48]);
        sw.WriteLine(":cowboy: " + songs[16] + " vs. :guitar: " + songs[47]);
        sw.WriteLine(":cowboy: " + songs[7] + " vs. :guitar: " + songs[56]);
        sw.WriteLine(":cowboy: " + songs[24] + " vs. :guitar: " + songs[39]);
        sw.WriteLine(":cowboy: " + songs[8] + " vs. :guitar: " + songs[55]);
        sw.WriteLine(":cowboy: " + songs[23] + " vs. :guitar: " + songs[40]);
        sw.WriteLine(":cowboy: " + songs[3] + " vs. :guitar: " + songs[60]);
        sw.WriteLine(":cowboy: " + songs[28] + " vs. :guitar: " + songs[35]);
        sw.WriteLine(":cowboy: " + songs[12] + " vs. :guitar: " + songs[51]);
        sw.WriteLine(":cowboy: " + songs[19] + " vs. :guitar: " + songs[44]);
        sw.WriteLine(":cowboy: " + songs[4] + " vs. :guitar: " + songs[59]);
        sw.WriteLine(":cowboy: " + songs[27] + " vs. :guitar: " + songs[36]);
        sw.WriteLine(":cowboy: " + songs[11] + " vs. :guitar: " + songs[52]);
        sw.WriteLine(":cowboy: " + songs[20] + " vs. :guitar: " + songs[43]);
        sw.WriteLine(":cowboy: " + songs[1] + " vs. :guitar: " + songs[62]);
        sw.WriteLine(":cowboy: " + songs[30] + " vs. :guitar: " + songs[33]);
        sw.WriteLine(":cowboy: " + songs[14] + " vs. :guitar: " + songs[49]);
        sw.WriteLine(":cowboy: " + songs[17] + " vs. :guitar: " + songs[46]);
        sw.WriteLine(":cowboy: " + songs[6] + " vs. :guitar: " + songs[57]);
        sw.WriteLine(":cowboy: " + songs[25] + " vs. :guitar: " + songs[38]);
        sw.WriteLine(":cowboy: " + songs[9] + " vs. :guitar: " + songs[54]);
        sw.WriteLine(":cowboy: " + songs[22] + " vs. :guitar: " + songs[41]);
        sw.WriteLine(":cowboy: " + songs[2] + " vs. :guitar: " + songs[61]);
        sw.WriteLine(":cowboy: " + songs[29] + " vs. :guitar: " + songs[34]);
        sw.WriteLine(":cowboy: " + songs[13] + " vs. :guitar: " + songs[50]);
        sw.WriteLine(":cowboy: " + songs[18] + " vs. :guitar: " + songs[45]);
        sw.WriteLine(":cowboy: " + songs[5] + " vs. :guitar: " + songs[58]);
        sw.WriteLine(":cowboy: " + songs[26] + " vs. :guitar: " + songs[37]);
        sw.WriteLine(":cowboy: " + songs[10] + " vs. :guitar: " + songs[53]);
        sw.WriteLine(":cowboy: " + songs[21] + " vs. :guitar: " + songs[42]);
        sw.Close();
    }

    private static void OutputBracketResultsIn32Mode(StreamWriter sw, ArrayList songs)
    {

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
        sw.Close();
    }
}