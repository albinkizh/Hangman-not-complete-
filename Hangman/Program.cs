
var Words = new List<string> {"Baum", "Fortnite"};
int index = Random.Shared.Next(Words.Count);

string un = "_";
string bconv;
do
{

    Console.WriteLine("Guess a the Words");
    string guess = Console.ReadLine();

    Console.Clear();

    foreach (char b in Words[index])
    {

        bconv = Convert.ToString(b);


        if (guess != bconv)
        {
            Console.Write(un);
        }

        else
        {
            Console.Write(guess);
        }

        
    }



    Console.WriteLine("\n");
 
} while (true);





