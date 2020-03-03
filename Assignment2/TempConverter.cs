using System.Text;
using System.Threading.Tasks;
using System;
using InputProgram;

namespace Assignment2
{
   

     class TempCon

    {
        public void Start()
        {
            int choice = -1; //because we don't know and it's not one of the options
            do
            {
                DisplayMenu();
                choice = Input.ReadIntegerConsole("Your choice:  "); //reads the user input and directs the choice
                switch (choice) //in each case use choice
                {
                    case 1:
                        CalculateFarenheitToCelcius();
                        break;
                    case 2:
                        CalculateCelciusToFarenheit();
                        break;
                    case 0: //exits loop
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
            


           
          
        }//displaymenu

        

        public void CalculateCelciusToFarenheit()
        {
            double convertedValue = 0; //declare
            string textOut = string.Empty; //and set default values
           

            Console.WriteLine("Converting Celcius to Farenheit"); //easy check

            for (int i = 0; i<= 100; i += 5)  //i between 0 and 100, increase in increments of 5
            
            {
                convertedValue = CelciusToFarenheit(i);

                textOut = string.Format("{0, 6:f2} C = {1, 16:f2} F", i, convertedValue); //C on the left, F on the right, extra spacing on right

                Console.WriteLine(textOut); //print

                }//for
            
            Console.WriteLine( ); //spacing
        } //c to f

        public void CalculateFarenheitToCelcius()
        {
            double convertedValueF = 0;
            string textOut = string.Empty;


            Console.WriteLine("Converting Farenheit to Celcius");

            for (int j = 0; j <= 212; j += 5)  //j between 0 and 212, increase in increments of 5

            {
                convertedValueF = FarenheitToCelcius(j); //renamed it j and valueF even though no technical conflict for ease of reading

                textOut = string.Format("{1,6:f2} F = {0,16:f2} C", convertedValueF, j); 

                Console.WriteLine(textOut);

            }//for
            
           
            Console.WriteLine( ); //spacing
        } //f to c

    private double CelciusToFarenheit(double celcius) //these are class variables so must be private
        {
            double farenheit =(9.0/5.0)*celcius+32.0; //how to calculate, gives value farenheit for use
            return farenheit;
        }//double c to f

    private double FarenheitToCelcius(double farenheit) //these are class variables so must be private
        {
           double celcius = (5.0/9.0) * (farenheit - 32.0);  //must use brackets here because - is lower priority
           return celcius; //gives value celcius for use
        }//double f to c

        

    }//class tempconverter

}//namespace