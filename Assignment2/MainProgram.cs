using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InputProgram;



namespace Assignment2
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            Input inputObj = new Input();

            TempCon tempcObj = new TempCon(); //call an object of class TemperatureConverter
            tempcObj.Start();
           //all options are within tempcon so it's the only thing necessary here

        }//main
    }//mainprogram


}//namespace
