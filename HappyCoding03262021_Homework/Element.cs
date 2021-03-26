using System;
using System.Collections.Generic;
using System.Text;

namespace HappyCoding03262021_Homework
{
    public abstract class Element
    {
        private string elementName;
        private string winsAgainst;
        private string losesAgainst;

        public Element(string name, string winsAgainst, string losesAgainst)
        {
            this.elementName = name.ToLower();
            this.winsAgainst = winsAgainst.ToLower();
            this.losesAgainst = losesAgainst.ToLower();
        }

        public string ValidateResult(string element)
        {
            string result = string.Empty;
            if (element == elementName)
            {
                result = "Unentschieden!";
            }
            else if (element == winsAgainst)
            {
                result = $"Deine Eingabe {element} verliert gegen die Eingabe des Computers {this.elementName}";
            }
            else if (element == losesAgainst)
            {
                result = $"Deine Eingabe {element} gewinnt gegen die Eingabe des Computers {this.elementName}";
            }

            return result;
        }
    }
}
