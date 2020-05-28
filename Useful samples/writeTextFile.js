var fso = WScript.CreateObject("Scripting.FileSystemObject");

var stream = fso.CreateTextFile("dep.txt", 2, 0);
stream.WriteLine("Hello World!");
stream.Close();
