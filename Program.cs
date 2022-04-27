

int[] positions = {1, 2, 3, 4, 5, 6, 7, 8, 9};
string[] character = {"1", "2", "3", "4", "5", "6", "7", "8", "9"};
string input = "0";
string Xoro = "O";
int userschoice = 10;
string exit = "no";
int[] checkwinnums = {123,456,789,147,257,369,159,753};



 static void main()
{
    while (exit == "no"){
        Printboard();
        character[Getuserplacement()] = Togglexando();
        Checkwin();
        Togglexando();
    }
}

void Printboard()
// This is the main game, what You play
{

        Console.WriteLine("\n");
        foreach (int lines in positions)
        {
            Console.Write(character[lines - 1] + "|");
            if (lines % 3 == 0 && lines < 9){
                Console.WriteLine("\n-------");
            }
        }

}

string Togglexando()
// Togggling Xoro to show the proper persons turn.
{
    if (Xoro == "O")
    {
        Xoro = "X";
    }
    else
    {
        Xoro = "O";
    }
    return Xoro;
}

int Getuserplacement()
// Gets the users input and toggles the different X/O
{
    
    Console.WriteLine("\nPlease put in a in a number for place. It's " + Togglexando() + " turn.");
    input = Console.ReadLine();
    userschoice = (Convert.ToInt32(input)-1);

    while (character[userschoice] == "X" || character[userschoice] == "O")
    {
        Console.WriteLine("\nThat was an invalid number. Please put in a in a number for place. It's " + Xoro + " turn.");
        input = Console.ReadLine();
        userschoice = Convert.ToInt32(input)-1;
    }
    return userschoice;
    // Console.WriteLine(input);
}

 void Checkwin()
{
    foreach(int win in checkwinnums)
    {
        int win1 = (win /100);
        int win2 = ((win - (win1*100)) /10);
        int win3 = ((win - ((win1*100) + (win2*10))) / 1);

        if (character[win1-1] == character[win2-1] && character[win2-1] == character[win3-1]){
            Console.WriteLine("it worked");
            exit = "yes";
            }
    }   
}

main();