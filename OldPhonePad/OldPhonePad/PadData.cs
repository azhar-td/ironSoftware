using System;
using System.Collections.Generic;
using System.Text;

namespace OldPhonePad
{
    public static class PadData
    {
        public static Dictionary<string,char> GetPadData()
        {
            Dictionary<string, char> dataDictionary = new Dictionary<string, char>();
            dataDictionary.Add("1", '&');
            dataDictionary.Add("11", '\'');
            dataDictionary.Add("111", '(');
            dataDictionary.Add("2", 'A');
            dataDictionary.Add("22", 'B');
            dataDictionary.Add("222", 'C');
            dataDictionary.Add("3", 'D');
            dataDictionary.Add("33", 'E');
            dataDictionary.Add("333", 'F');
            dataDictionary.Add("4", 'G');
            dataDictionary.Add("44", 'H');
            dataDictionary.Add("444", 'I');
            dataDictionary.Add("5", 'J');
            dataDictionary.Add("55", 'K');
            dataDictionary.Add("555", 'L');
            dataDictionary.Add("6", 'M');
            dataDictionary.Add("66", 'N');
            dataDictionary.Add("666", 'O');
            dataDictionary.Add("7", 'P');
            dataDictionary.Add("77", 'Q');
            dataDictionary.Add("777", 'R');
            dataDictionary.Add("7777", 'S');
            dataDictionary.Add("8", 'T');
            dataDictionary.Add("88", 'U');
            dataDictionary.Add("888", 'V');
            dataDictionary.Add("9", 'W');
            dataDictionary.Add("99", 'X');
            dataDictionary.Add("999", 'Y');
            dataDictionary.Add("9999", 'Z');
            dataDictionary.Add("0", ' ');
            return dataDictionary;
        }
    }
}
