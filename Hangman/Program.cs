
using System.Net;

string Word = "Fortnite";

string bconv;
string guess;
string hiddenwrd = "";






foreach (char a in Word)
{
    hiddenwrd += "_";
}


do
{
    Console.WriteLine(hiddenwrd);
    Console.WriteLine("\n\nHangman! \nGuess a word");
    guess = Console.ReadLine();
    
    foreach (char b in Word)
    {


        bconv = Convert.ToString(b);


        if (guess == bconv)
        {
            hiddenwrd += guess;
        }

    }


} while (true);






