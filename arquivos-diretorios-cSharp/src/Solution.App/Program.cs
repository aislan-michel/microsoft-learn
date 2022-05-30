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