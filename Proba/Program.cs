////=============== 1 
//Console.WriteLine(text);
//text = text.Trim();
//Console.WriteLine(text);
//// ============== 2
//Console.WriteLine(text.Length);
//Console.WriteLine(text[5]);
//Console.WriteLine(text[0] + " - " + text[text.Length-1]);

////=============== 3
//Console.WriteLine(text.ToUpper());
//Console.WriteLine(text.ToLower());

//Console.WriteLine(text);

//=============== 4



//=============== 5


//=============== 6
string text = "Уча C# и програмирам на C#.";

Console.WriteLine(text.IndexOf("C#"));
Console.WriteLine(text.LastIndexOf("C#"));

Console.WriteLine(text.IndexOf("я"));

//=================7

//Извлечете първите три символа, пет символа от индекс 9 и текста от последното срещане на "C#" до края.

//Очаквани резултати: Уча, прогр, C#.

Console.WriteLine(text.Substring(0,3));
Console.WriteLine(text.Substring(9,5));
Console.WriteLine(text.Substring(text.LastIndexOf("C")));

string input = "Днес е дъждовно";

string first = input.Substring(0, input.IndexOf(" ")-1);
Console.WriteLine(first);

//string second = input.Substring();