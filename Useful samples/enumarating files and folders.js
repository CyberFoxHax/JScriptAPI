var shell = WScript.CreateObject("WScript.Shell");
var fso = WScript.CreateObject("Scripting.FileSystemObject");


function IterateCurrentDirectory(){
	 // CurrentDirectory being the executing directory
	 // passing a relative path will find from the executing directory
	var folder = fso.GetFolder(shell.CurrentDirectory);
	
	// folders
	for(var e = new Enumerator(folder.SubFolders); e.atEnd()===false; e.moveNext()){
		WScript.Echo(e.item());
	}
	
	// files
	for(var e = new Enumerator(folder.Files); e.atEnd()===false; e.moveNext()){
		WScript.Echo(e.item());
	}
}

function UsingDirCmd(){
	var command = "dir /b";
	var WshShell = WScript.CreateObject("WScript.Shell");
	var res = WshShell.Exec("cmd /c " + command).StdOut.ReadAll();
	var arr = res.split("\n");
	for(var i = 0; i<arr.length;i++)
		WScript.Echo(arr[i]);
}