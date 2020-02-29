using System;

public class TemperatureConverter
{
	public void Start()
	{
		int choice = 0
			do
			{
			DisplayMenu();
			choice = Input.ReadIntegerConsole("Your choice:  ");
			switch (choice)
				case 1:
					CalculateFarenheitToCelcius( );
					break;
				case 2:
					CalculateCelciusToFarenheit( );
					break;
				case 0: //exits loop, return to menu
					break;
				default:
					Console.WriteLine ("Error: invalid option. Please select 1, 2, or 0.")
					break;
			}//do
			while (choice != 0); //while

	}//start

	public void DisplayMenu()
    {
			Console.WriteLine("************************************************************");
			Console.WriteLine("MENU");
			Console.WriteLine("************************************************************");
			Console.WriteLine("Convert Farenheit to Celcius: 1);
			Console.WriteLine("Convert Celcius to Farenheit: 2);
			Console.WriteLine("Exit the converter and return to main menu: 0");
			Console.WriteLine("************************************************************");
			Console.WriteLine("Your selection: ");
		}//displaymenu

}//class tempconverter
