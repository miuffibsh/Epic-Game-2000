using System;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;

namespace ConsoleApp3
{
    class Scenario
    {
        private string name;
        public Scenario()
        {
            this.name = "";
        }
        public Scenario(string name)
        {
            this.name = name;
        }

        public string TakeDialog(int number)
        {
            Encoding enc = Encoding.GetEncoding("Windows-1250");
            StreamReader streamreader = new StreamReader("Scenario.txt", enc);

            string script = streamreader.ReadToEnd();

            string[] scenario = script.Split('|');
            return scenario[number];
        }
    }
}
