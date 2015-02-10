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
        private int _integerNumber;
        private string _stringVariable;
        private double _doubleNumber = 0.0d;

        //PUBLIC PROPERTIES +++++++++++++++++++++++++++++++++++++++++++++
        //access to the data
        public int IntegerNumber
        {
            get 
            {
                return this._integerNumber; //RETURNS VALUE OF INSTANCE
            }
            set 
            {
                Console.WriteLine("");
                this._integerNumber = value * 2; //SET OUR INTANCE VARIABLE
            }
        }

        public string StringVariable
        {
            get 
            {
                return this._stringVariable; //READ ONLY PROPERTY
            }
        }

        public double DoubleNumber
        {
            get 
            {
                return this._doubleNumber;
            }
            set 
            {
                this._doubleNumber = value;
            }

        }

        public Class1(string theString)
        {
            this._stringVariable = theString;
        }

        public void show()
        {
            
            Console.Write("++++++++++++++++++++++");
            Console.Write("\n");
            Console.WriteLine("IntegerNumber: {0}", this._integerNumber);
            Console.WriteLine("StringVariable: {0}", this._stringVariable);
            Console.WriteLine("DoubleNumber: {0}", this._doubleNumber);
            Console.Write("++++++++++++++++++++++");
            Console.Write("\n");

        }
    }
}
