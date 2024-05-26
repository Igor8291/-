Console.WriteLine("Введите строки через запятую:");
string userInput = Console.ReadLine();
string[] userArray = userInput.Split(',');
Console.WriteLine(string.Join(", ", FilterShortStrings(userArray)));

static string[] FilterShortStrings(string[] inputArray)
{
  // Считаем количество строк длиной <= 3
  int count = 0;
  foreach (string str in inputArray)
  {
    if (str.Length <= 3)
    {
      count++;
    }
  }

  string[] resultArray = new string[count];
  int index = 0;
  foreach (string str in inputArray)
  {
    if (str.Length <= 3)
    {
      resultArray[index] = str;
      index++;
    }
  }

  return resultArray;
}
