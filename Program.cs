string path_file = "C:\\Users\\defau\\source\\repos\\FileSystem\\TEST.txt";
string path_directory = "C:\\Users\\defau\\source\\repos\\FileSystem\\Test";

//try
//{
//    CreateFile(path_file);
//}
//catch (Exception e)
//{
//    Console.WriteLine(e.Message);
//}

//try
//{
//    CreateDirectory(path_directory);
//}
//catch (Exception e)
//{
//    Console.WriteLine(e.Message);
//}
ShowAllFilesDirectory("C:\\Users\\defau\\source\\repos\\FileSystem");


static void CreateFile(string str)
{
    if (File.Exists(str))
    {
        throw new Exception("File exist");
    }
    File.Create(str);
}

static void CreateDirectory(string str)
{
    if (Directory.Exists(str))
    {
        throw new Exception("Direcory exist");
    }
    Directory.CreateDirectory(str);
}

static void ShowAllFilesDirectory(string path)
{
    var files = Directory.GetFiles(path);
    foreach (var elem in files)
    {
        Console.WriteLine(elem);
    }
    var directories = Directory.GetDirectories(path);
    foreach (var elem in directories)
    {
        ShowAllFilesDirectory(elem);
    }
}

/*

4)Создайте программу, которая выводит список всех файлов в указанном каталоге и его подкаталогах. */