namespace Lab1
    using System;
    using System.Collections.Generic;
    struct symbs{
        list<char> opers = new list<char>();
        list<double> nums = new list<int>(); 
    };
    class CalcPerf{
        private static symbs SortStr(string str){
            string inpt = Console.ReadLine();
            symbs res;
             for (int i = 0; i < input.Length; i++)
            if (char.IsDigit(str[i]))
                res.nums.Add(int.Parse(str[i]));
            else if (str[i] != ' ')
                res.opers.Add(str[i]);
            return res;
        }
        static void main(){
            symbs parts;
            parts = SortStr();
      /*    Console.Write("Choose option:\n1) Show parts of math operation\n2)Show result\n>");
            bool flag = true;
            while (flag)
                int tmp;
                switch(tmp){
                    case 1:*/
                        foreach ( int element in digits ) 
                            Console.Write(element); 
                        Console.WriteLine();
                        foreach ( char element in symbols) 
                            Console.Write(element);
                        Console.WriteLine();
	         /*           break;
                    case 2:

                }*/
        }
    }
