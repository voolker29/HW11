using Json_Xml;
using System.Text.Json;
using System.Xml.Serialization;

Console.WriteLine("Напишите путь к директории ,в который лежит файл: Super hero squad.json");
var path = Console.ReadLine();
var fileName = "Super hero squad.json";
try
{
    var directory = new DirectoryInfo(path);
    var squaJsonFile = directory.GetFiles().Where(x => x.Name == fileName);
    if (squaJsonFile.Count() == 0)
    {
        Console.WriteLine($"В директории нет файла json c названием {fileName}");
        return;
    }

    var savedFile = directory.GetFiles().Where(x => x.Name == "Squad.xml");
    if (savedFile.Count() != 0)
    {
        Console.WriteLine($"В директории уже есть файл с название Squad.xml , прошу его удалить.");
        return;
    }

    using (var file = new StreamReader(path + @$"\{fileName}"))
    {
        var text = file.ReadToEnd();
        var squad = JsonSerializer.Deserialize<Squad>(text);

        using (var xmlFile = new FileStream(path + @"\Squad.xml", FileMode.CreateNew))
        {
            new XmlSerializer(typeof(Squad)).Serialize(xmlFile, squad);
            Console.WriteLine("Файл Squad.xml записан");
        }
    }
}
catch (DirectoryNotFoundException)
{
    Console.WriteLine("Директория не найдена");
}

