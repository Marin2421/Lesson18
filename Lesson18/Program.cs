//Домашнее задание. Тема 18. Урок 1. Работа со строками.
//Метод Split.
//string[] forbiddenWords = { "слово1", "слово2", "слово3" };
//string sentence = "";
//while (true)
//{
//    Console.Write("Введите слово (для завершения введите 'конец'): ");
//    string word = Console.ReadLine();

//for (int i = 0; i < forbiddenWords.Length; i++)
//    {
//        if (word == forbiddenWords[i])
//        {
//            word = "(скрыто)";
//            break;
//        }
//    }
//    if (word == "конец")
//    {
//        break;
//    }
//    sentence += word + " ";
//}
//Console.WriteLine("Сформированное предложение: " + sentence);

//Домашнее задание. Тема 18. Урок 2. Работа со строками.
//Метод Split.
//1
//Console.Write("Введите строку чисел: ");
//string numbersStr = Console.ReadLine();

//string[] numbersList = numbersStr.Split(", ");

//int totalSum = 0;
//foreach (string numStr in numbersList)
//{
//    totalSum += int.Parse(numStr);
//}

//Console.WriteLine($"Сумма чисел: {totalSum}");

//2
//Console.Write("Введите предложение: ");
//string sentence = Console.ReadLine();

//string[] words = sentence.Split(" ");
//int wordCount = words.Length;

//Console.WriteLine($"Количество слов: {wordCount}");