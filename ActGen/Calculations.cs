using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*may only need on SecureFastRandom:*/
using System.Security.Cryptography;
//Temp add for msgbox
using System.Windows.Forms;

namespace ActGen
{


    class Calculations
    {
        
        //Calculation background worker -> https://msdn.microsoft.com/en-us/library/windows/desktop/system.componentmodel.backgroundworker(v=vs.85).aspx
        private System.ComponentModel.BackgroundWorker backgroundWorker_calc;
        
        // Access console form Interface for updates via public string 'singleCode'
        private readonly IsingleCode consoleform;
        public Calculations(IsingleCode consoleform)
        {
            this.consoleform = consoleform;
        }

        // Code Worker Method //
        private static string MakeCode(int CharsPerCode, string sDefaultChars)
        {
            //      http://stackoverflow.com/a/1518495/503621       //
            char[] charSet = sDefaultChars.ToCharArray();
            int byteSize = 256; //Labelling convenience
            int biasZone = byteSize - (byteSize % charSet.Length);
            byte[] rBytes = new byte[CharsPerCode]; //Do as much before and after lock as possible
            char[] rName = new char[CharsPerCode];

            SecureFastRandom.DirectGetBytes(rBytes);

            for (var i = 0; i < CharsPerCode; i++)
            {
                rName[i] = charSet[rBytes[i] % charSet.Length];
            }
            return new string(rName);
        }


        //Ideally should be in another class - like some others. Quick fix for is to format codes here and put on form below.
        private static string AddDashes(int spacing, string input)
        {
            //  http://stackoverflow.com/a/11437187/503621 :
            string output = "";
            int start = 0;
            while (start < input.Length)
            {
                output += input.Substring(start, Math.Min(spacing, input.Length - start)) + "-";
                start += spacing;
            }
            // remove trailing dash
            return output.Trim('-');


        }


        private static IEnumerable<string> RandomStrings(
            string allowedChars,
            int charsPerCode,
            int count,
            Random rng)
        {
            char[] chars = new char[charsPerCode];
            int setLength = allowedChars.Length;
            int length = charsPerCode;


            while (count-- > 0)
            {
                for (int i = 0; i < charsPerCode; ++i)
                {
                    chars[i] = allowedChars[rng.Next(setLength)];
                }
                yield return new string(chars, 0, length);
            }
        }

        public static void CreateRandomCodes(int iAmountOfCodes, int iCharsPerCode, bool bDashes, int iDashSpacing, string sChars, bool bcodeType)
        {
            var secureCode = "";
            //var fasterCode = "";
            var holder = "";
            var watch = System.Diagnostics.Stopwatch.StartNew();  // Timer for random calcs
            FormToggle.Console.clearConsole = "";
            if (!FormToggle.Console.Visible)
                FormToggle.Console.Show();
            FormToggle.Console.Text = "ActGen Console - Calculating.. please wait";

            //debug = MessageBox.Show(" iAmountOfCodes = " + iAmountOfCodes +
            //              "\n iCharsPerCode = " + iCharsPerCode +
            //              "\n sChars = " + sChars);

            // Two methods:

            //System.Random method

            if (!bcodeType)              //then this method
            {
                Random rng = new Random();
                foreach (var fasterCode in RandomStrings(sChars, iCharsPerCode, iAmountOfCodes, rng))
                {
                    if (bDashes) //Add some dashes if needed:
                        holder += AddDashes(iDashSpacing, fasterCode) + Environment.NewLine;
                    else
                        holder += fasterCode + Environment.NewLine; 
                }
                
            }
            else  //// Do RNGCryptoServiceProvider method (default)
            {

                for (int i = 1; i <= iAmountOfCodes; i++)
                {
                    secureCode = MakeCode(iCharsPerCode, sChars);
                    if (bDashes) //Add some dashes if needed:
                        secureCode = AddDashes(iDashSpacing, secureCode);
                    holder += secureCode + Environment.NewLine;
                }
            }


            watch.Stop(); // Stop timer
            var elapsedMs = watch.ElapsedMilliseconds; 

            //FormToggle.Console.singleCode += code + Environment.NewLine;
            FormToggle.Console.textBoxConsole.Text = holder;
            FormToggle.Console.Text = "ActGen Console - Calculation Time: " + elapsedMs + " ms";
        } 



    }
}

