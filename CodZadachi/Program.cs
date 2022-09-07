static string[] GetStringArr()
        {
            string[] stringArr = new string[4];
    int finWordArrayLength = 0;
    int finWordArrayIndex = 0;


    for (int i = 0; i < stringArr.Length; i++)
    {
        Console.WriteLine("Введите  слова через Enter: ");
        stringArr[i] = Console.ReadLine();

            if (stringArr[i].Length <= 3)
            {
                finWordArrayLength++;
            }
    }

    string[] finStringArr = new string[finWordArrayLength];

        foreach(string str in stringArr)
        {
            if (str.Length <= 3)
            {
                finStringArr[finWordArrayIndex++] = str;
            }
        }

    return finStringArr;            
}

string[] Array = GetStringArr();

    foreach(string str in Array)
    {
        Console.WriteLine($"Слово с количеством букв менее или равное трём: " + str);
    }
       