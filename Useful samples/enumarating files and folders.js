var shell = WScript.CreateObject("WScript.Shell");
var fso = WScript.CreateObject("Scripting.FileSystemObject");


{ // subdirectories
	var folder = fso.GetFolder(shell.CurrentDirectory);	
	for(var e = new Enumerator(folder.SubFolders); e.atEnd()===false; e.moveNext()){
		WScript.Echo(e.item());
	}
}

{ // files
	var folder = fso.GetFolder(shell.CurrentDirectory);	
	for(var e = new Enumerator(folder.Files); e.atEnd()===false; e.moveNext()){
		WScript.Echo(e.item());
	}
}

{ // by parsing DIR
	var command = "dir /b";
	var WshShell = WScript.CreateObject("WScript.Shell");
	var res = WshShell.Exec("cmd /c " + command).StdOut.ReadAll();
	var arr = res.split("\n");
	for(var i = 0; i<arr.length;i++)
		WScript.Echo(arr[i]);
}