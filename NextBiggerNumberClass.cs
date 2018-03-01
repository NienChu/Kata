using System;

namespace Kata
{
    public class NextBiggerNumberClass
    {
        public  long NextBiggerNumber(long n)
        {
            string number = n.ToString();//parse to string
            char[] charArray = number.ToCharArray();
            int lenhthOfNumber = charArray.Length;
            bool isChange = false;
            int changeIdex = -1;

            for (int i = lenhthOfNumber - 1; i >= 0; i--)
            {

                for (int j = lenhthOfNumber - 1; j >= i + 1; j--)
                {
                    if (charArray[i] < charArray[j])
                    {
                        char temp = charArray[i];
                        charArray[i] = charArray[j];
                        charArray[j] = temp;
                        isChange = true;
                        changeIdex = i;
                        break;
                    }
                }
                if (isChange)
                    break;

            }
            //sort
            charArray = sortCharArray(charArray, changeIdex + 1, lenhthOfNumber - 1);

            if (!isChange)
            {
                return -1;
            }

            string resultString = new string(charArray);
            long result = Convert.ToInt64(resultString);

            return result;
        }

        //from small to large
        public static char[] sortCharArray(char[] charArray, int startIndex, int endIndex)
        {
            for (int i = startIndex; i < endIndex; i++)
            {
                for (int j = i + 1; j < endIndex + 1; j++)
                {
                    if (charArray[i] > charArray[j])
                    {
                        char temp = charArray[i];
                        charArray[i] = charArray[j];
                        charArray[j] = temp;
                    }
                }
            }
            return charArray;
        }


    }
}
