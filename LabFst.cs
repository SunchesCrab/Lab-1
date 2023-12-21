using System;
using System.Collections.Generic;
using System.Linq.Expressions;
namespace labFst{
class PerformStr{
    static void Main()
    {
        Console.Write("Enter math expression:\n>");
        string inpt = Console.ReadLine();
        var nums = new List<double>();
        var opers = new List<char>();
        string curNum = "";
        foreach (char c in inpt){
            if (Char.IsDigit(c)){
                curNum += c;
            }
            else if (c != ' '){
                if(double.TryParse(curNum)){
                nums.Add(double.Parse(curNum));
                curNum = "";
                opers.Add(c);
                }
            }
        }
        Console.Write("Values: ");
        foreach (double i in nums){
            Console.Write(i + " ");
        }
        Console.WriteLine("");
        Console.WriteLine("Operations:");
        foreach (char c in opers){
            Console.Write(c + " ");
        }
        double result = nums[0];
        for (int i = 1; i < nums.Count; i++){
            switch (opers[i - 1]){
                case '+':
                    result += nums[i];
                    break;
                case '-':
                    result -= nums[i];
                    break;
                case '*':
                    result *= nums[i];
                    break;
                case '/':
                    result /= nums[i];
                    break;
            }
        }
        Console.WriteLine("Result: " + result);
    }
}
}