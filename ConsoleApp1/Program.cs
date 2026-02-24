using System;
using System.ComponentModel.Design;
using System.Reflection.Metadata.Ecma335;

class Program
{

	/* Go to Tools > Options.
     * In the search bar at the top left of the window, type IntelliCode.
     * Find C# user model predictions (or "Whole line completions") and set it to Disabled.
     * */

	static void Main()
	{
		bool running = true;

		while (running)
		{
			Console.Clear();

			// Please write down your name first. 
			Console.WriteLine("My name is Marin Disbrow My OU 4x4 is Disb0000, and my GitHub account name is @mdisbrow64. \n");

			Console.WriteLine("=== While Loop, Do-while Loop, For Loop ===");
			Console.WriteLine("1) Smart Checkout System");
			Console.WriteLine("2) Password Cracker");
			Console.WriteLine("3) Rocket Launch Pad");
			Console.WriteLine("0) Exit");
			Console.Write("\nSelect an option: ");

			string input = Console.ReadLine();

			if (input == "1")
			{
				grocery_checkout();
			}
			else if (input == "2")
			{
				password_cracker();
			}
			else if (input == "3")
			{
				launchpad();
			}
			else if (input == "0")
			{
				Console.WriteLine("Exiting program...");
				running = false;
			}
			else
			{
				Console.WriteLine("Invalid choice. Press any key to try again.");
				Console.ReadKey();
			}
		}
	}

	// --- Question 1 ---

	static void grocery_checkout()
	{
		Console.Clear();
		Console.WriteLine("--- Smart Checkout System ---");

		double total = 0.0; // Move total declaration here so it's in scope

		// use while loop to complete

		double price = -1.0; // initialize to enter the loop

		Console.WriteLine("Enter item prices (enter 0 to finish):");

		while (true)
		{
			Console.Write("Item price: $");
			string priceInput = Console.ReadLine();

			// Sentinel value
			if (!double.TryParse(priceInput, out price) || price < 0)
			{
				Console.WriteLine("Invalid input. Please enter a valid price.");
				continue;
			}
			if (price == 0)
			{
				break;
			}

			if (price >= 100)
			{
				Console.WriteLine("Manager approval required for high-value item. Manager, please enter your 4-digit override code:");
				string codeInput = Console.ReadLine();

				// Validate code input
				if (!int.TryParse(codeInput, out int enteredCode))
				{
					Console.WriteLine("Invalid code format. Item not added.");
					continue;
				}

				if (enteredCode == 1234)
				{
					Console.WriteLine("Approval accepted. Item added.");
					total += price;
				}
				else
				{
					Console.WriteLine("Invalid code. Item not added.");
				}

				continue; // move to next item
			}

			// Add normal item to total
			total += price;
		}

		Console.WriteLine($"\nTotal cost of valid items: ${total:F2}");
		Console.WriteLine("\nPress any key to return to menu...");
		Console.ReadKey();
	}






	// --- Question 2 ---

	static void password_cracker()
	{
		Console.Clear();
		Console.WriteLine("--- Password Cracker ---");

		string correctpassword = ("mis3013isgreat!");
		string userinput;
		int MaxAttempts = 3;
		int attempts = 0;
		bool passwordCracked = false;

		do
		{
			Console.WriteLine("Please enter the security password:");
			userinput = Console.ReadLine();
			attempts++;

			if (userinput == correctpassword)
			{
				passwordCracked = true;
				Console.WriteLine("Access granted.");
			}
			else
			{
				int attemptsLeft = MaxAttempts - attempts;

				if (attemptsLeft > 0)
				{
					Console.WriteLine($"Incorrect password. Attempts left: {attemptsLeft}");
				}
			}


		} while (!passwordCracked && attempts < MaxAttempts);
		if (!passwordCracked)
		{
			Console.WriteLine("Too many failed attempts. Access denied.");
		}







		Console.WriteLine("\nPress any key to return to menu...");
		Console.ReadKey();
	}

	// --- Question 3 ---

	static void launchpad()
	{
		Console.Clear();
		Console.WriteLine("---  Launchpad ---");

		// use for loop to complete
		for (int i = 10; i > 0; i--)
		{
			Console.WriteLine(i);

			if (i == 7)
			{
				Console.WriteLine("[SYSTEM]: Checking fuel levels... OK.");
			}
			else if (i == 4)
			{
				Console.WriteLine("[SYSTEM]: Oxygen pressure... stabilized.");
			}
			else if (i == 1)
			{
				Console.WriteLine("[SYSTEM]: Ignition sequence... START.");
			}

			Thread.Sleep(500); // Half-second pause for dramatic effect
		}

		// Blast off
		Console.WriteLine("0 - BLAST OFF!");

		Thread.Sleep(20);

		// Initial rocket drawing
		DrawRocket();

		// Rocket "launch" animation
		for (int i = 0; i < 20; i++)
		{
			Console.WriteLine(); // Push rocket upward
			DrawRocket();
			Thread.Sleep(20);
		}
		Console.WriteLine("Mission Sucsessful! The rocket has launched");
		Console.WriteLine("\nPress any key to return to menu...");
		Console.ReadKey();
	}

	static void DrawRocket()
	{
		Console.WriteLine("   |   ");
		Console.WriteLine("  / \\  ");
		Console.WriteLine(" / _ \\ ");
		Console.WriteLine(" | |  ");
		Console.WriteLine(" | (R) |");
		Console.WriteLine(" |_____|");
		Console.WriteLine("  V V V ");


	}
}

