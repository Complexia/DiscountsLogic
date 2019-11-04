using System;
using System.IO;

namespace myApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadText read = new ReadText("ProgrammingExercise.txt");
            Modify modify = new Modify();
            WriteText write = new WriteText();
            string[] products = read.readFile();
            string[] modifiedProducts = modify.modify(products,20,15,10);
            write.writeText(modifiedProducts, "Results.txt");

            
            
        }
    }
}
