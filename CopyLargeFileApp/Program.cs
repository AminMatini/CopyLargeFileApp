Console.WriteLine("Welcome To Copy Large File App");

string myFile = @"f:\movie.mp4";

// First Solution

File.Copy(myFile , "f:\\movie_copy.mp4");

// Second Solution = Error For Large File 

var fileData = File.ReadAllBytes(myFile);

File.WriteAllBytes("f:\\movie_copy2.mp4",fileData);

// Third Solution 

var fromFile = new FileStream(myFile, FileMode.Open);
var toFile = new FileStream("f:\\movie_copy3.mp4", FileMode.Create);

var buffer = new byte[1024];
var counter = 0;

while(fromFile.Read(buffer , 0 , buffer.Length) > 0)
{
    Console.WriteLine(counter++);

    toFile.Write(buffer, 0, buffer.Length); 
}

Console.WriteLine("Done !");