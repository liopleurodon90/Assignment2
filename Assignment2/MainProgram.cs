using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Assignment2
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            Input inputObj = new Input();
            inputObj.Start();

            TempCon tempcObj = new TempCon(); //call an object of class TemperatureConverter
            tempcObj.Start();
           //how do choices work: if choice==1 run method?

        }//main
    }//mainprogram


}//namespace
