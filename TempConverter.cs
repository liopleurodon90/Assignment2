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
}//class tempconverter
