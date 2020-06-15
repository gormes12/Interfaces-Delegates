using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Delegates
{
    internal class GetValidInputs
    {
        public static int GetValidInputNumber(int i_MinRange, int i_MaxRange, int i_BackExitIndex, bool i_IsMainMenu)
        {
            string inputStr;
            int inputNum;
            bool parseSuccessed;

            inputStr = Console.ReadLine();
            parseSuccessed = int.TryParse(inputStr, out inputNum);
            while (!parseSuccessed || !isInNumberRangeOrBackExitIndex(i_MinRange, i_MaxRange, i_BackExitIndex, inputNum, i_IsMainMenu))
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

        private static bool isInNumberRangeOrBackExitIndex(float i_MinRange, float i_MaxRange, int i_BackExitIndex, float i_Input, bool i_IsMainMenu)
        {
            bool isValid = (i_Input >= i_MinRange && i_Input <= i_MaxRange) || i_Input == i_BackExitIndex;

            if (!isValid)
            {
                Console.WriteLine(
                    "You must enter a number between {0} and {1}, or {2} for {3}. Please try again!",
                    i_MinRange,
                    i_MaxRange,
                    i_BackExitIndex,
                    i_IsMainMenu ? "Exit" : "Back");
            }

            return isValid;
        }
    }
}
