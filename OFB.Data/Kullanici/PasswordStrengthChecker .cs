using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace OFB.Data.Kullanici
{

    public class PasswordStrengthChecker
    {
        private int GetLengthScore(string password)
        {
            return Math.Min(10, password.Length) * 6;
        }

        private int GetLowerScore(string password)
        {
            int rawScore = password.Length - Regex.Replace(password, "[a-z]", "").Length;
            return Math.Min(2, rawScore) * 5;
        }

        private int GetUpperScore(string password)
        {
            int rawScore = password.Length - Regex.Replace(password, "[A-Z]", "").Length;
            return Math.Min(2, rawScore) * 5;
        }

        private int GetDigitScore(string password)
        {
            int rawScore = password.Length - Regex.Replace(password, "[0-9]", "").Length;
            return Math.Min(2, rawScore) * 5;
        }

        private int GetSymbolScore(string password)
        {
            int rawScore = Regex.Replace(password, "[a-zA-Z0-9]", "").Length;
            return Math.Min(2, rawScore) * 5;
        }
        public int GeneratePasswordScore(string password)
        {
            if (password == null)
            {
                return 0;
            }

            int lengthScore = GetLengthScore(password);
            int lowerScore = GetLowerScore(password);
            int upperScore = GetUpperScore(password);
            int digitScore = GetDigitScore(password);
            int symbolScore = GetSymbolScore(password);

            return lengthScore + lowerScore + upperScore + digitScore + symbolScore;

            //    Unacceptable  <50
            //    Weak <60
            //    Normal < 80
            //    Strong < 90
            //    Secure >=90

        }


    }
}