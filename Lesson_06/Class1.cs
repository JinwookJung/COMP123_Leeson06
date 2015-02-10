using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_06
{
    class Class1
    {
        //PRIVATE INSTANCE VARIABLES ++++++++++++++++++++++++++++++++++++++++++
        //just hold the data
        private int integerNumber;
        private string stringVariable;
        private double doubleNumber = 50.0d;

        //PUBLIC PROPERTIES +++++++++++++++++++++++++++++++++++++++++++++
        //access to the data
        public int IntegerNumber
        {
            get 
            {
                return this.integerNumber; //RETURNS VALUE OF INSTANCE
            }
            set 
            {
                Console.WriteLine("");
                this.integerNumber = value * 2; //SET OUR INTANCE VARIABLE
            }
        }

        public string StringVariable
        {
            get 
            {
                return this.stringVariable; //READ ONLY PROPERTY
            }
        }

        public double DoubleNumber{ get; set; }

        public Class1(string theString)
        {
            this.stringVariable = theString;
        }

        public void show()
        {
            
            Console.Write("++++++++++++++++++++++");
            Console.Write("\n");
            Console.WriteLine("IntegerNumber: {0}", this.integerNumber);
            Console.WriteLine("stringVariable: {0}", this.stringVariable);
            Console.WriteLine("DoubleNumber: {0}", this.doubleNumber);
            Console.Write("++++++++++++++++++++++");

        }
    }
}
