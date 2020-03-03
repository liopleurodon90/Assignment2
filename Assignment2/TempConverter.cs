using System.Text;
using System.Threading.Tasks;
using System;
using InputProgram;

namespace Assignment2
{
   

    public class TempCon

    {
        public void Start()
        {
            int choice = -1; //because we don't know and it's not one of the options
            do
            {
                DisplayMenu();
                choice = Input.ReadIntegerConsole("Your choice:  "); //this one actually does something
                switch (choice) //in each case use choice
                {
                    case 1:
                        CalculateFarenheitToCelcius();
                        break;
                    case 2:
                        CalculateCelciusToFarenheit();
                        break;
                    case 0: //exits loop, return to menu
                        break;
                    default:
                        Console.WriteLine("Error: invalid option. Please select 1, 2, or 0.");
                        break;
                }//switch
            }//do
            while (choice != 0); //while. remains active as long as choice is not zero

        }//start

        public void DisplayMenu()
        {
            Console.WriteLine("************************************************************");
            Console.WriteLine("MAIN MENU");
            Console.WriteLine("************************************************************");
            Console.WriteLine("Convert Farenheit to Celcius: 1");
            Console.WriteLine("Convert Celcius to Farenheit: 2");
            Console.WriteLine("Exit the converter: 0");
            Console.WriteLine("************************************************************");
            



            //string choiceSt = Console.ReadLine();
            //int choice = Convert.ToInt16(choiceSt);
            //int choice = int.Parse(choiceSt);    //parse from string to int
            //Console.WriteLine("Your selection: " + choiceSt + " "); //inform user 

          
        }//displaymenu

        

        public void CalculateCelciusToFarenheit()
        {
            double convertedValue = 0;
            string textOut = string.Empty;
           

            Console.WriteLine("Converting Celcius to Farenheit");

            for (int i = 0; i<= 100; i += 5)  //i between 0 and 100, increase in increments of 5
            
            {
                convertedValue = CelciusToFarenheit(i);

                textOut = string.Format("{0, 16:f2}C = {1, 6:f2} F", i, convertedValue); 

                Console.WriteLine(textOut);

                }//for
            Console.WriteLine(textOut);
            Console.WriteLine("************************************************************");
        } //c to f

        public void CalculateFarenheitToCelcius()
        {
            double convertedValueF = 0;
            string textOut = string.Empty;


            Console.WriteLine("Converting Farenheit to Celcius");

            for (int j = 0; j <= 212; j += 5)  //j between 0 and 212, increase in increments of 5

            {
                convertedValueF = FarenheitToCelcius(j);

                textOut = string.Format("{1,6:f2} F = {0,16:f2}C", convertedValueF, j); //

                Console.WriteLine(textOut);

            }//for
            Console.WriteLine(textOut);
           
            Console.WriteLine("************************************************************");
        } //f to c

    public double CelciusToFarenheit(double celcius)
        {
            double farenheit =(9.0/5.0)*celcius+32.0;
            return farenheit;
        }//double c to f

    public double FarenheitToCelcius(double farenheit)
        {
           double celcius = (5.0/9.0) * (farenheit - 32.0);
           return celcius;
        }//double f to c

        

    }//class tempconverter

}//namespace