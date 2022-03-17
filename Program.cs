// See https://aka.ms/new-console-template for more information
bool party = false;
double partyNum = 0;
double buffet = 0;
string soda = "soda";
string coffee = "coffee";
double cTotal = 0;
double sTotal = 0;
double drinkTot = 0;
double bill = 0;

Console.WriteLine("Hi, welcome to our all-you-can-eat buffet! It's $9.99 per person, but we do charge extra " +
    "for coffee. We limit party sizes to six.");

begin:

Console.WriteLine("How many people will we be seating today?");
string userInput = Console.ReadLine();
party = double.TryParse(userInput, out partyNum);

buffet = partyNum * 9.99;


if (party == false)
{
    Console.WriteLine("Hah-hah, very funny... but seriously.");
    goto begin;
}
else if (partyNum > 6)
{
    Console.WriteLine("Oh, I'm sorry. As I said, we are only able to seat up to six people in a party. Please have a nice day.");

}
else
{
    Console.WriteLine("Okay, table for " + userInput + ". Right this way, please.");

    Console.WriteLine();
    Console.WriteLine("Let me get you started with some drinks. We have coffee or soda available. Soda is included with " +
        "the cost of your meal but, as I mentioned before, coffee is $2.00 extra. I'll get you all one at a time. So...");
    Console.WriteLine();

    for (int i = 0; i < partyNum; i++)
    {
        Console.WriteLine("Coffee or soda?");
        string userDrink = Console.ReadLine();

        if (userDrink == soda)
        {
            ++sTotal;
            Console.WriteLine("Great! Please help yourself to our soda fountain.");
        }
        else if (userDrink == coffee)
        {
            ++cTotal;
            Console.WriteLine("Okay, coffee it is.");
        }
        else
        {
            Console.WriteLine("Sorry, we only have coffee and soda.");
        }
    }
    drinkTot = cTotal * 2.00;
    bill = drinkTot + buffet;
    Console.WriteLine();
    Console.WriteLine("So I have " + cTotal + " coffees, and " + sTotal + " sodas. Your total today is " +
        "going to be $" + bill);
}
Console.ReadLine();
    

