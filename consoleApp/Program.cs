// string path = @"C:\temp";
// string path = "/Users/sadikturan/Desktop/temp/deneme";

string rootPath = Directory.GetCurrentDirectory();

// string[] dirs = Directory.GetDirectories(rootPath, "*", SearchOption.AllDirectories);

// foreach(var dir in dirs) {
//     Console.WriteLine(dir);
// }

string source_path = "/Users/sadikturan/Desktop/ConsoleApp/img";
string dest_path = "/Users/sadikturan/Desktop/ConsoleApp/images/";

string[] files = Directory.GetFiles(source_path, "*", SearchOption.AllDirectories);

foreach(var file in files) {
    Console.WriteLine(file);
    Console.WriteLine(Path.GetExtension(file));
    Console.WriteLine(Path.GetFileNameWithoutExtension(file));
    Console.WriteLine(Path.GetFileName(file));

    var info = new FileInfo(file);
    Console.WriteLine($"{Path.GetFileName(file)}: {info.Length}");

    if(!Directory.Exists(dest_path)) {
        Directory.CreateDirectory(dest_path);
    }

    string name = Path.GetRandomFileName() + Path.GetExtension(file);
    
    File.Copy(file, $"{dest_path}{name}");
}