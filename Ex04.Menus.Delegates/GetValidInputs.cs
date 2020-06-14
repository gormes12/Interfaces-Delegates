using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Delegates
{
    class GetValidInputs
    {
        public static int GetValidInputNumber(int i_MinRange, int i_MaxRange)
        {
            string inputStr;
            int inputNum;
            bool parseSuccessed;

            inputStr = Console.ReadLine();
            parseSuccessed = int.TryParse(inputStr, out inputNum);
            while (!parseSuccessed || !isInNumberRange(i_MinRange, i_MaxRange, inputNum))
            {
                if (!parseSuccessed)
                {
                    Console.WriteLine("You must enter digits only! Try again!");
                }

                inputStr = Console.ReadLine();
                parseSuccessed = int.TryParse(inputStr, out inputNum);
            }

            return inputNum;
        }

        private static bool isInNumberRange(float i_MinRange, float i_MaxRange, float i_Input)
        {
            bool isValid = i_Input >= i_MinRange && i_Input <= i_MaxRange;

            if (!isValid)
            {
                Console.WriteLine("You must enter a number between {0} and {1}. Please try again!", i_MinRange, i_MaxRange);
            }

            return isValid;
        }
    }
}
