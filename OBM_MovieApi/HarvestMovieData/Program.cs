// See https://aka.ms/new-console-template for more information
using HarvestMovieData;
using HarvestMovieData.Models;
using System.Text.Json;

Console.WriteLine("Hello, World!");

var _toolBox= new ToolBox();




//private static List<MovieCastCrew> GetData()
//{
    var json = "";// DataFeed.GetJsonData();
    try
    {

        var rootFolder = @"C:\Users\Chris\source\github_repos\OBM_MovieApi";

        //Default file. MAKE SURE TO CHANGE THIS LOCATION AND FILE PATH TO YOUR FILE
        var textFile = @"C:\Users\Chris\source\github_repos\OBM_MovieApi\archive\credits.csv";

        var movieId = 0;
        var lastElementIndec = 0;

        List<int> knownActorList = new List<int>();


        if (File.Exists(textFile))
        {
        // Read entire text file content in one string
        //string text = File.ReadAllText(textFile);
        //json= File.ReadAllText(textFile);
        //Console.WriteLine(text);

        // Read a text file line by line.
        string[] lines = File.ReadAllLines(textFile);

        var j= 0;
        var s = "";

        foreach (string line in lines)
        {
            //Console.WriteLine(line);
            j++;
            int[] ignorelines=new int[] {109,110,134,138,147,157,168,212,223,232,241,290,300,321,346,355,356};

            if(!ignorelines.Contains(j) && j<354)
            {
                var splitLine = line.Replace("'\"\"", "'").Replace("\"\"'", "'").Replace("\"\"", "~~z~~").Split("\",");
                //foreach(var c in splitLine)
                //{
                //    Console.WriteLine($"{c}");
                //}

                lastElementIndec = splitLine.GetLength(0);
                movieId= int.Parse(splitLine[lastElementIndec-1]);

                for (int i = 0; i < 1; i++)
                {

                    var cleanString = _toolBox.CleanDoubleQuotedStrings(splitLine[i]);

                    //var workingstring = splitLine[i].Replace("\"[", "[").Replace("None","null").Replace("'","\"");
                    var workingstring = cleanString.Replace("\"[", "[").Replace("None", "null").Replace("'", "\"");

                    var castlist = JsonSerializer.Deserialize<List<Cast>>(workingstring);

                    foreach (var castmember in castlist)
                    {
                        if (!knownActorList.Contains(castmember.id))
                        {
                            //new actor better add him

                        }

                    }


                    Console.WriteLine("a");
                }
                Console.WriteLine("Line: " + j.ToString());
                if (j == 108)
                {
                    Console.WriteLine("109");
                }
                if (j == lines.Length - 1)
                {
                    s = splitLine[0];
                }
            }
            

        }

        Console.WriteLine(s);

    }

    }
    catch (Exception e)
    {
        Console.WriteLine("Exception: " + e.Message);
    }
    finally
    {
        Console.WriteLine("Executing finally block.");
    }

    //var customer = JsonSerializer.Deserialize<List<MovieCastCrew>>(json);

Console.WriteLine("stop");
  //  return customer;
//}

