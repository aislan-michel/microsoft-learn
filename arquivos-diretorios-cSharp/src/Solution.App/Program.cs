const string path = @"../../use-case/stores";

var listOfDirectories = Directory.EnumerateDirectories(path);

Console.WriteLine("list of directories:");
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

    return foundFiles.Where(file => file.EndsWith("sales.json")).ToList();
}