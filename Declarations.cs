using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//alex_moyo
namespace Standalone
{
    //main class will inherit the abstract class ever since calling the abstract class will result in an error 
    
    class Declarations : Expense //base class (parent)
    {
        //declaration for user input
        public double  Income { get; set; }
        public int  Tax { get; set; }

        //delarations for the expenditures 
        public double Groceries { get; set; }
        public double Water { get; set; }
        public double Travelling { get; set; }
        public double Cell_phone { get; set; }
        public double Other { get; set; }

        //stores expenses into array
      public double [] Store = new double [8];
        
        // option for condition on rental and buying a property
        public int Option { get; set; }
        public double Rent { get; set; }
        public int Choose  { get; set; }

      
        

    }
    //abstract class
    abstract class Expense //derived class (child)
    {


        //abstract peroperties

        // declaration for the rental amount 
        public double Rental { get; set; }

        //declaration for buying a propery
        public double Purchase_prop { get; set; }
        public double Total_dep { get; set; }
        public double Interest_rate { get; set; }
        public double Months_repay { get; set; }

        
        //Declaration to calculate tax
        public double Ta { get; set; }
        public double Cal { get; set; }

        //declaration to subtract from income 
        public  double Groce { get; set; }
        public double Light { get; set; }
        public  double Travel { get; set; }
        public  double Cell { get; set; }
        public  double Other_ex { get; set; }

       
        //declaration to calculate home loan
        public  double Price  { get; set; }
        public double Dep { get; set; }
        public  double Rate  { get; set; }
        public double Loan  { get; set; }
        public  double Repay  { get; set; }
        public double Months { get; set; }
        public double Tot { get; set; }




    }
}
