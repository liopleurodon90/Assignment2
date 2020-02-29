using System;

public class Menu()
{
	public void Start
	{
		 int choice = -1
		 while (choice !=0)
		 {
			WriteMenuText(); //show the menu options and pick up user's input
			choice = int.Parse(Console.ReadLine()); //create an instance of chosen class
			switch (choice); //apply statement to all cases
			{
			case 1:  //menu item 1
				{
				WholeNumbersForAdd sumObj = new WholeNumbersForAdd(); //declare a local reference variable and create an instance of it
				sumObj.Start(); //call its start method
				break;
				}//case 1
			}//switch
		 }//while loop 

	}//start
}//class menu

