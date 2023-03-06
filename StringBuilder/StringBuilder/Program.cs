#region Homework
//using StringBuilder.Models;

//Car car = new Car("BMW", "X5", 0.18, 60, 2023);
//car.currentFuel = 60;
//car.color = "Black";

//car.Drive(2);

//Console.WriteLine(car.ShowInfo());
//string text = "   Hello    World   ";


//Replace(ref text);

//Console.WriteLine(text);

//void Replace(ref string word)
//{
//    string result = string.Empty;
//    foreach (char item in word)
//    {
//        if (item != ' ')
//            result += item;
//    }

//    word = result;
//}
#endregion

//int[] arr1 = { 1, 2, 3 };
//int[] arr2 = { 1, 2, 3 };

//arr2 = arr1;

//arr2[0] = 5;

//Console.WriteLine(arr1[0]);
//Console.WriteLine(arr2[0]);

//Console.WriteLine(arr1 == arr2);
//immutable type
//string word1 = "Hello";
//string word2 = "Hello";
////string word3 = "Hi";
//Console.WriteLine(word2);

//word2 = word1;
//word2 = "test";

//Console.WriteLine(word1);
//Console.WriteLine(word2);
//Console.WriteLine(word1 == word2);

string word = "Hello world";

//Console.WriteLine(word.Contains("world"));
//Console.WriteLine(word.ToUpper());

//string search = Console.ReadLine();

//Console.WriteLine(word.ToLower().Trim().Contains(search.ToLower().Trim()));

//Console.WriteLine(word.Trim());

//Console.WriteLine(word.Replace('o', 'a'));

//Console.WriteLine(word.Remove(2, 3));


Console.WriteLine(Reverse(word));



System.Text.StringBuilder stringBuilder = new();

//string Reverse(string word)
//{
//    string result = string.Empty;
//    for (int i = word.Length - 1; i >= 0; i--)
//    {
//        result += word[i];
//    }

//    return result;
//}
string Reverse(string word)
{
    System.Text.StringBuilder result = new();
    for (int i = word.Length - 1; i >= 0; i--)
    {
        result.Append(word[i]);
    }

    return result.ToString();
}