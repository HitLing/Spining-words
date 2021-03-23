using System.Collections.Generic;
using System.Linq;
using System;
/*
 *  H  e  y  0  f  e  l  l  o  w  0   w   a   r   r   i   o   r   s
 * [0][1][2][3][4][5][6][7][8][9][10][11][12][13][14][15][16][17][18][19][20][21][22][23][24][25][26][27][28][29][30][31][32][33][34][35][36][37][38][39][40]
local i = 8;
counter = 5
for (int j = local i - counter; j< local i; j++)
 */



public class Kata
{
    public static string SpinWords(string sentence)
    {
        char[] charString = sentence.ToCharArray();
        int counter = 0;
        char SafeLetter;
        for (int i = 0; i <sentence.Length; i++) {
            if (charString[i] != Convert.ToChar(" ")) {
             counter = counter + 1;
            }
            if (((counter > 4) && (charString[i] == Convert.ToChar(" "))) || ((counter > 4) && (i == sentence.Length - 1))) {
                int localI = i;
                int copyoflocalI;
                if (i != sentence.Length - 1)
                {
                    copyoflocalI = localI - 1;
                    for (int j = localI - counter; j <= localI - (counter / 2) - 1; j++)
                    {
                        SafeLetter = charString[copyoflocalI];
                        Console.WriteLine(SafeLetter);
                        charString[copyoflocalI] = charString[j];
                        Console.WriteLine(charString[copyoflocalI]);
                        charString[j] = SafeLetter;
                        Console.WriteLine(charString[j]);
                        copyoflocalI = copyoflocalI - 1;
                    }
                }
                else {
                    copyoflocalI = localI;
                    for (int j = localI - counter+1; j <= localI - (counter / 2); j++)
                    {
                        SafeLetter = charString[copyoflocalI];
                        Console.WriteLine(SafeLetter);
                        charString[copyoflocalI] = charString[j];
                        Console.WriteLine(charString[copyoflocalI]);
                        charString[j] = SafeLetter;
                        Console.WriteLine(charString[j]);
                        copyoflocalI = copyoflocalI - 1;
                    }
                }

            }
            if (charString[i] == Convert.ToChar(" ")) {
                counter = 0;
            }
        }
        sentence = new string(charString);
        return sentence;
    }
}






/*public class Kata
{

    public static string SpinWords(string sentence)
    {
        char[] charString = sentence.ToCharArray();
        int counter = 0;
        char SafeLetter;
        for (int i = 0; i < sentence.Length - 1; i++) {
            if (charString[i] != Convert.ToChar(" ")) {
                counter = counter + 1;
            }
            if (((counter > 4) && (charString[i] == Convert.ToChar(" "))) || ((counter > 4) && (i == sentence.Length - 1)))
            {
                int localI = i;
                for (int j = localI - counter; j < localI; j++) {
                    SafeLetter = charString[localI - j];
                    charString[localI - j] = charString[j];
                    charString[j] = SafeLetter;
                }
            }
            if (charString[i] == Convert.ToChar(" ")) {
                counter = 0;
            }
        } 
    
        sentence = new string(charString);
        return sentence;
    }
}*/


namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
          
            string result = Kata.SpinWords("Hey fellow warriors");
            Console.WriteLine($"{result}");

        }
    }
}
