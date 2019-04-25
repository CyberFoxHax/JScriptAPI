var shell = WScript.CreateObject("WScript.Shell");
var fso = WScript.CreateObject("Scripting.FileSystemObject");

if(WScript.FullName.indexOf("cscript.exe") == -1){
	shell.Run("cscript.exe \""+WScript.ScriptFullName +"\"");
	WScript.Quit();
}

var folder = fso.GetFolder(shell.CurrentDirectory);
var enumerator = new Enumerator(folder.Files);
while(enumerator.atEnd() == false){
	var file = enumerator.item();
	enumerator.moveNext();
	if(file.Name.indexOf(".js") > -1)
		continue;
	var fullName = file.Path;
	WScript.Echo(fullName);
	var oldName = fullName;
	var newName = fullName+ ".jpg";
	fso.MoveFile(oldName, newName);
	var magick = WScript.CreateObject("ImageMagickObject.MagickImage.1");
	magick.Convert(newName,"-resize","64x64",newName);
	//shell.Run("magick \""+fullName+".jpg\" -resize 64x64 \""+fullName+".jpg\"");
	//while(process.Status == 0)
	//	WScript.Sleep(1);
	fso.MoveFile(newName, oldName);
}