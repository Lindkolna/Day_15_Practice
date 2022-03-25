// See https://aka.ms/new-console-template for more information
/*var original = "Was it a car or a cat I saw?";
var reversed = new string(original.Reverse().ToArray());
var palindrom = original == reversed;
Console.WriteLine(original);*/

/*DateTime dateTime = DateTime.Now;
Console.WriteLine(dateTime.ToString());

Console.WriteLine("Please enter the day of your birthday");
string day = Console.ReadLine();
Console.WriteLine("Please enter the month of your birthday");
string month = Console.ReadLine();
Console.WriteLine("Please enter the year of your birthday");
string year = Console.ReadLine();

string forParsing = $"{day}-{month}-{year}";
Console.WriteLine(forParsing);
Console.WriteLine(DateTime.Parse(forParsing).ToString());*/

string original = "Aa kiu, I swd skieo 236587. GH kiu: sieo?? 25.33";
/*int numberOfLetters = original.ToCharArray().Count();
foreach (char c in original)
{
    numberOfLetters++;
}
Console.WriteLine(numberOfLetters);*/
int lettersCount = original.Count(c => char.IsLetter(c));
Console.WriteLine(lettersCount);
int digitsCount = original.Count (c => char.IsDigit (c));
Console.WriteLine (digitsCount);
int spaceCount = original.Count (c => char.IsWhiteSpace (c));
Console.WriteLine(spaceCount);
int specialChar = original.Count (c => char.IsPunctuation (c));
Console.WriteLine (specialChar);
char value = 'Z';
int ascii = value;
Console.WriteLine ($"The ASCII value of {value} is: {ascii} ");

/*int digitsCount = 0; //The second option//
foreach (char c in original)
{
    if (Char.IsDigit(c))
        digitsCount++;
}
Console.WriteLine(digitsCount);*/ //The second option//

string txt = "Lorem ipsum dolor sit amet (ipsum), consectetur adipiscing elit ipsum, sed do eiusmod tempor magna aliqua.";

Console.WriteLine(txt.IndexOf("ipsum"));

string text = "ABCD";
Console.WriteLine(text.Length);

String text2 = "Hello World";
Console.WriteLine(text2.ToLower());

