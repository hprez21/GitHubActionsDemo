// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, GitHub learners!");

Console.WriteLine("Creating txt file");

//Create a new file in the current directory.
using (FileStream fs = File.Create("test.txt"))
{
    Byte[] info = new System.Text.UTF8Encoding(true).GetBytes("This is some text in the file.");
    // Add some information to the file.
    fs.Write(info, 0, info.Length);
}

Console.WriteLine("File created successfully");