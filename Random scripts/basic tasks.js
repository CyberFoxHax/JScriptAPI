function HelloWorld(){
	var path = 2;
	if(path == 0){
		var text;
		text="Hello world!";
		WScript.Echo(text);
	}
}

function CurrentDirectory(){
	var WshShell = WScript.CreateObject ("WScript.Shell");
	WScript.Echo (WshShell.CurrentDirectory);
}

function Dir(){
	var WshShell = WScript.CreateObject ("WScript.Shell");
	var res = WshShell.Exec("cmd /c dir").StdOut.ReadAll();
	WScript.Echo(res);
}

function ChangeDirectory(){
	var WshShell = WScript.CreateObject ("WScript.Shell");
	WshShell.CurrentDirectory == "C:\\";
}


function ExecuteProgram(){
	var WshShell = WScript.CreateObject ("WScript.Shell");
	var res = WshShell.Exec("regedit.exe").StdOut.ReadAll();
}

function ExceuteCommand(){
	var command = "dir /b";
	var WshShell = WScript.CreateObject ("WScript.Shell");
	var res = WshShell.Exec("cmd /c " + command).StdOut.ReadAll();
	WScript.Echo(res);
}

function IterateDirectories(){
	var command = "dir /b";
	var WshShell = WScript.CreateObject ("WScript.Shell");
	var res = WshShell.Exec("cmd /c " + command).StdOut.ReadAll();
	var arr = res.split("\n");
	for(var i = 0; i<arr.length;i++)
		WScript.Echo(arr[i]);
}

function IterateDirectories2(){
	var fso = WScript.CreateObject("Scripting.FileSystemObject");
	var folders = fso.Folders;
	for(var e = new Enumerator(folders); e.atEnd()===false; e.moveNext()){
		WScript.Echo(e);
	}
}

function CreateFile(){
	var stream = fso.CreateTextFile("dep.txt", 2, 0);
	stream.WriteLine("Hello World!");
	stream.Close();
}

// copy file

// read file

// write file

// script arguments

// user input

// dialogue boxes

// ui?

IterateDirectories2();