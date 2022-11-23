using System;
using System.Collections.Generic;

namespace OldPhonePad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var inputData = InputData();
            foreach (string input in inputData)
            {
                Console.WriteLine(OldPhonePad(input));
            }
        }
        public static List<string> InputData()
        {
            var result = new List<string>();
            result.Add("33#");
            result.Add("227*#");
            result.Add("4433555 555666#");
            result.Add("8 88777444666*664#");
            result.Add("6884426 623#");
            result.Add("6884426 623029999442777#");
            result.Add("6884426 62302999944277707772333444778833#");
            result.Add("6884426 62302999944277707772333444778833*33#");
            return result;
        }
        public static string OldPhonePad(string input)
        {
            //Get pad data
            var dataDictionary = PadData.GetPadData();
            string output = string.Empty;
            string subString = string.Empty;
            for (int i = 0; i < input.Length; i++)
            {
                //for # sign
                if(input[i] == '#' && !string.IsNullOrEmpty(subString))
                {
                    output = output + dataDictionary[subString];
                    return output;
                }
                //for backspace
                if(input[i] == '*' && !string.IsNullOrEmpty(subString))
                {
                    subString = string.Empty;
                    continue;
                }
                //for space
                if(input[i] == ' ' && !string.IsNullOrEmpty(subString))
                {
                    output = output + dataDictionary[subString];
                    subString = string.Empty;
                    continue;
                }
                if (!string.IsNullOrEmpty(subString))
                {
                    if (subString[subString.Length - 1] == input[i])
                        subString = subString + input[i];
                    else
                    {
                        output = output + dataDictionary[subString];
                        subString = input[i].ToString();
                    }
                }
                else
                {
                    subString = subString + input[i];
                }
            }
            return output;
        }
    }
}
