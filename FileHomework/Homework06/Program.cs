using System.Globalization;

string appPath = @"..\..\..\";
string folderPath = appPath + @"Files\";
string filePath = folderPath + @"names.txt";

if (!Directory.Exists(folderPath))
{
    Directory.CreateDirectory(folderPath);
    Console.WriteLine("New directory was created");
}

using (StreamWriter sw = new StreamWriter(filePath, true))
{
    Console.WriteLine("Please enter names or press x to exit");

    while (true)
    {
        string namesEntered = Console.ReadLine();
        if (namesEntered == "x")
        {
            break;
        }
        sw.WriteLine(namesEntered);
    }
}


Dictionary<char, List<string>> everyLetterName = new Dictionary<char, List<string>>();

using (StreamReader sr = new StreamReader(filePath))
{
    string nameInput;
    while ((nameInput = sr.ReadLine()) != null)
    {
        if (!string.IsNullOrWhiteSpace(nameInput))
        {
            string firstLetterStr = nameInput.Substring(0, 1).ToUpper();
            char firstLetter = firstLetterStr[0];

            if (firstLetter >= 'A' && firstLetter <= 'Z')
            {
                everyLetterName[firstLetter] = new List<string>();
            }
            everyLetterName[firstLetter].Add(nameInput);
        }
    }
  
}

foreach (var name in everyLetterName)
{
    string outputFile = Path.Combine(folderPath, $"namesStartingWith_{name.Key}.txt");
    List<string> existingNames = new List<string>();

    if (File.Exists(outputFile))
    {
        var existingLines = File.ReadAllLines(outputFile);
        foreach (string line in existingLines)
        { 
            existingNames.Add(line);
        }
    }

    using (StreamWriter sw = new StreamWriter(outputFile))
    {
        foreach (string nameOutput in existingNames)
        {
            sw.WriteLine(nameOutput);
        }

        foreach (string nameOutput in name.Value)
        {
            if (!existingNames.Contains(nameOutput))
            {
                sw.WriteLine(nameOutput);
            }
        }
    }
}
