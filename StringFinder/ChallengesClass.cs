using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFinder
{
    public static class ChallengesClass
    {
        public static bool CanFind(string[] userInputs, string[] words)
        {
            if (userInputs != null && words != null)
            {
                bool isSuccess = false;
                for (int i = 0; i < words.Length; i++)
                {
                    foreach (var input in userInputs)
                    {
                        bool isExist = words[i].Contains(input);

                        if (isExist)
                        {
                            isSuccess = true;
                        }
                        else
                        {
                            isSuccess = false;
                        }
                    }
                }

                return isSuccess;
            }
            else
            {
                return false;
            }
        }
    }
}
