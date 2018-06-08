using System;
using System.Diagnostics;

namespace cSharpProjectEulerSolutions
{
    class Program
    {
        static void Main(string[] args)
        {
            // to run your application use command: dotnet run 
            // without or with an argument which is project euler problem number
            if(args.Length==0){
                string s;
                do{
                     Console.WriteLine("\n***************************************************************************************");
                     Console.WriteLine("The following problems are taken from Project Euler at https://projecteuler.net/archives \n");
                     Console.Write("Enter the Problem number or Space to Exit:");
                     s=Console.ReadLine();
                     if(!String.IsNullOrWhiteSpace(s)){
                       appMenu(s.Trim());
                      }
                } while(s!=" "); //Space & Enter Kill the process.
                Process.GetCurrentProcess().Kill();
            }
            else
            {
                appMenu(args[0]);
            }
        }
        private static void appMenu(string pID)
        {
            ProjectEuler  projectEuler = new ProjectEuler(); 
            switch  (pID)
            {
                case  "1":
                    projectEuler.p1();
                    break;
                case  "2":
                    projectEuler.p2();
                    break;
                case  "3":
                    projectEuler.p3();
                    break;  
                case  "4":
                    projectEuler.p4();
                    break; 
                case  "5":
                    projectEuler.p5();
                    break;  
                case  "6":
                    projectEuler.p6();
                    break;      
                default:
                    Console.WriteLine("There is no solution for the problem # {0} yet. Please try it later. Thanks! \n",pID);
                    break;
            }
        }
    }
}
