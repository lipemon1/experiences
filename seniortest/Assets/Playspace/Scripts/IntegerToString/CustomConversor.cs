using System;

namespace IntegerToString
{
    public static class CustomConversor
    {
        public static String Itoa(int number, int wantedBase)
        {
            //cheking for zero
            if (number == 0)
                return "0";

            //needed values
            int index = 10;
            int range = 1 + index;
            char[] buff = new char[range];
            string alphabet = "0123456789abcdefghijklmnopqrstuvwxyz";

            for (int i = Math.Abs(number), q; i > 0; i = q)
            {
                q = Math.DivRem(i, wantedBase, out i);
                buff[index -= 1] = alphabet[i];
            }

            //checking for negatives
            if (number < 0)
            {
                buff[index -= 1] = '-';
            }

            return new String(buff, index, buff.Length - index);
        }
    }
}
