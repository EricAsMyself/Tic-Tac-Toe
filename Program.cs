// See https://aka.ms/new-console-template for more information
string user_number = "5";
int int_user_number = 0;
string position1 = "1";
string position2 = "2";
string position3 = "3";
string position4 = "4";
string position5 = "5";
string position6 = "6";
string position7 = "7";
string position8 = "8";
string position9 = "9";
var cities = new Dictionary<string, string>(){
	{"UK", "London, Manchester, Birmingham"},
	{"USA", "Chicago, New York, Washington"},
	{"India", "Mumbai, New Delhi, Pune"}
};



Console.WriteLine("Hello, World!");
Console.WriteLine("Welcome to tik tak toe");

Console.WriteLine("1|2|3");
Console.WriteLine("4|5|6");
Console.WriteLine("7|8|9");

user_number = Console.ReadLine();
int_user_number = Convert.ToInt32(user_number);
Console.WriteLine(user_number);

while (int_user_number != 5)
{
    Console.WriteLine( position1 + "|"+ position2 + "|" + position3);
    Console.WriteLine( position4 + "|"+ position5 + "|" + position6);
    Console.WriteLine( position7 + "|"+ position8 + "|" + position9);
    user_number = Console.ReadLine();
    int_user_number = Convert.ToInt32(user_number);

}