// See https://aka.ms/new-console-template for more information

string filePath = "exemplo.txt";
string directoryPath = @"C:\Users\Krysthian\source\repos\CSharp\Treinamento 5by5\Aulas\Aula21-10-2025";


try
{
    if (!Directory.Exists(directoryPath))
    {
        Directory.CreateDirectory(directoryPath);
    }
}
catch(Exception e)
{
    Console.WriteLine(e.StackTrace);
    Console.WriteLine(e.Message);
}

var fullPath = Path.Combine(directoryPath, filePath);

/*
StreamReader reader = new StreamReader(fullPath);

using (reader)
{
    string content = reader.ReadToEnd();
    Console.WriteLine(content);
}
*/

StreamWriter writer = new StreamWriter(fullPath, append: true);

using (writer)
{
    writer.WriteLine("Eu escrevi o meu arquivo!");
}


StreamReader reader1 = new StreamReader(fullPath);

using (reader1)
{
    string content = reader1.ReadToEnd();
    Console.WriteLine(content);
}