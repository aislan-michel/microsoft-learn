const string path = @"../../use-case/stores";

var listOfDirectories = Directory.EnumerateDirectories(path);

Console.WriteLine("\nlist of directories:");
foreach (var dir in listOfDirectories)
{
    Console.WriteLine(dir);
}

var files = Directory.EnumerateFiles(path);

Console.WriteLine("\nfiles");
foreach (var file in files)
{
    Console.WriteLine(file);
}

var allFilesInAllFolders = Directory.EnumerateFiles(path, "*.txt", SearchOption.AllDirectories);

Console.WriteLine("\nFind all *.txt files in the stores folder and its subfolders");
foreach (var file in allFilesInAllFolders)
{
    Console.WriteLine(file);
}

var salesFiles = FindFiles(path);

Console.WriteLine("\nsales.* files");
foreach (var file in salesFiles)
{
    Console.WriteLine(file);
}

IEnumerable<string> FindFiles(string folderName)
{
    var foundFiles = Directory.EnumerateFiles(folderName, "*", SearchOption.AllDirectories);

    return foundFiles.Where(file => file.EndsWith("sales.json"));
}

var currentDirectory = Directory.GetCurrentDirectory();

Console.WriteLine($"\ncurrent directory: {currentDirectory}");

var docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

Console.WriteLine($"\nmy documents: {docPath}");

Console.WriteLine($@"
special char:
{path}{Path.DirectorySeparatorChar}201
stores\201 on Windows
stores/201 on macOS
");

Console.WriteLine($"path combine: {Path.Combine(path, "201")}"); 

Console.WriteLine($"\nget extension sales.json: {Path.GetExtension("sales.json")}");

var separator = Path.DirectorySeparatorChar;

var fileName = $"{path}{separator}201{separator}sales{separator}sales.json";

var info = new FileInfo(fileName);

Console.WriteLine($"Full Name: {info.FullName}{Environment.NewLine}Directory: {info.Directory}{Environment.NewLine}Extension: {info.Extension}{Environment.NewLine}Create Date: {info.CreationTime}"); 