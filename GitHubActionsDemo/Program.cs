Console.WriteLine("Hello, GitHub learners!");
Console.WriteLine("Creating txt file");

// Get the directory where the executable is located
string executingPath = AppContext.BaseDirectory;
string filePath = Path.Combine(executingPath, "test.txt");

Console.WriteLine($"Creating file at: {filePath}");

// Create the file in the same directory as the executable
using (FileStream fs = File.Create(filePath))
{
    Byte[] info = new System.Text.UTF8Encoding(true).GetBytes("This is some text in the file.");
    // Add some information to the file.
    fs.Write(info, 0, info.Length); 
}
Console.WriteLine("File created successfully");
