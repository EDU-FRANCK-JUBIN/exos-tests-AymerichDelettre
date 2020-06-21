using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerciceTest
{
    class ClasseChaine
    {
        public static string TraiterTexte(String inputText)
        {
            String initiales = "";
            if (string.IsNullOrEmpty(inputText) || inputText.Length < 3)
            {
                return string.Empty;
            }
            if (inputText.Contains(" "))
            {
                String[] content = inputText.Split(' ');
                if (content.Length != 2)
                {
                    return string.Empty;
                }
                initiales = content[0][0].ToString() + "." + content[1][0].ToString();
            }
            else
            {
                return string.Empty;
            }
            
            return initiales;
        }
    }
}
