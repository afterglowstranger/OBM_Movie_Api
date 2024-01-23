using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarvestMovieData
{
    public class ToolBox
    {

        public string CleanDoubleQuotedStrings(string text)
        {
            var cleanString = "";
            var workingString=text.Split("~~z~~");

            var cleanNextToggle =false;
            if (workingString.Length > 1) {
                foreach (var line in workingString)
                {
                    if(!cleanNextToggle)
                    {
                        cleanString += line;
                        cleanNextToggle = !cleanNextToggle;
                    }
                    else
                    {
                        if (line.IndexOf("'") > -1)
                        {
                            cleanString += "'" + line.Replace("'", "-") + "'";
                        }
                        else
                        {
                            cleanString += "-" + line + "-";
                        }
                        
                        cleanNextToggle = !cleanNextToggle;
                    }
                    
                }


                return cleanString;
            }

            return text;

        }

        public void WriteNewActorToTextFile()
        {
            string docPath = "C:\\Users\\Chris\\source\\github_repos\\OBM_MovieApi";

            // Append text to an existing file named "WriteLines.txt".
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "WriteLines.txt"), true))
            {
                outputFile.WriteLine("Fourth Line");
            }
        }
    }
}
