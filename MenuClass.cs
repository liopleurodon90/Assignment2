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

				}//case 1
			}//switch
		 }//while loop 

	}//start
}//class menu

