using System;

namespace Assignment2
{ 
    public class TempCon
{
    public void Start()
    {
        int choice = 0;
        do
        {
            DisplayMenu();
            choice = Input.ReadIntegerConsole("Your choice:  ");
            switch (choice)
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
        while (choice != 0); //while

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
        Console.ReadLine();
        string choiceSt = Console.ReadLine();
        choice = int.Parse(choiceSt);    //parse from string to int
        Console.WriteLine("Your selection: "+ choice +" ");
        choice = Console.ReadLine();
            //send people to the appropriate page
    }//displaymenu

    public void CalculateFarenheitToCelcius()
        {
            Console.WriteLine("Convert Farenheit to Celcius");
        }//f to c

    public void CalculateCelciusToFarenheit()
        {
            Console.WriteLine("Convert Celcius to Farenheit");
        } //c to f

        //method farenheit to celcius
        //method celcius to farenheit
        //display for each
        //maybe these are classes
        //maybe the display goes in main

    }//class tempconverter
}//namespace