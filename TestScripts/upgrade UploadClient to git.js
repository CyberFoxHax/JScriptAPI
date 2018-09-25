var shell = WScript.CreateObject("WScript.Shell");
var fso = WScript.CreateObject("Scripting.FileSystemObject");
var backupPath = "..\\Backup\\";
var backupAssets = "..\\Backup\\Assets";
var startDir = shell.CurrentDirectory;
(function(){
	if(fso.FolderExists("Assets") == false){
		WScript.Echo("Error: Wrong folder");
		return;
	}
	
	if(fso.FileExists("Git-2.19.0-64-bit.exe") == false){
		WScript.Echo("Error: Git installer not found");
		return;
	}
	
	shell.Run('Git-2.19.0-64-bit.exe /VERYSILENT /NORESTART /NOCANCEL /SP- /CLOSEAPPLICATIONS /RESTARTAPPLICATIONS /COMPONENTS="icons,ext\reg\shellhere,assoc,assoc_sh"', 1, true);
	
	var backupFolder;
	if(fso.FolderExists(backupAssets))
		backupFolder = fso.GetFolder(backupAssets)
	else{
		fso.CreateFolder(backupPath);
		backupFolder = fso.CreateFolder(backupAssets);
	}

	if(fso.FolderExists("Library"))
		fso.MoveFolder("Library", fso.BuildPath(backupPath, "Library"));
	
	var assetsFolder = fso.GetFolder("Assets");
	for(var e = new Enumerator(assetsFolder.SubFolders); e.atEnd()===false; e.moveNext()){
		var item = e.item();
		if(item.Name == "UploadClient")
			continue;
		
		fso.MoveFolder(item.Path, fso.BuildPath(backupAssets, item.Name));
	}

	for(var e = new Enumerator(assetsFolder.Files); e.atEnd()===false; e.moveNext()){
		var item = e.item();
		if(item.Name == "UploadClient.meta")
			continue;
		
		fso.MoveFile(item.Path, fso.BuildPath(backupAssets, item.Name));
	}
	
	var oldFolderName = fso.GetFolder(startDir).Name;
	shell.CurrentDirectory = fso.GetFolder(startDir).ParentFolder.Path;
	shell.SendKeys("{BS}");
	WScript.Sleep(1000);
	fso.DeleteFolder(startDir, true);
	WScript.Sleep(1000);
	if(fso.FolderExists(startDir))
	WScript.Echo("Error deleting folder, please delete manually then click OK");
	fso.CreateFolder(startDir);
	shell.Run(
		"git clone -b client_release --single-branch http://uploadclient_user:t26BR738ubjPYPGwSqtKVXAX@idmei_server:8080/scm/git/Unity3D_UploadClient " + oldFolderName,
		1,
		true
	);
	shell.CurrentDirectory = startDir;

	WScript.Sleep(1000);

	shell.Run('cmd /c xcopy /e /i "'+backupAssets+'" "'+fso.BuildPath(startDir, "Unity3D_UploadClient\\Assets")+'"', 1, true);
	shell.Run('cmd /c xcopy /e /i "'+backupPath+'Library" "'+fso.BuildPath(startDir, "Unity3D_UploadClient\\Library")+'"', 1, true);

	var startupDir = shell.ExpandEnvironmentStrings("%APPDATA%") + "\\Microsoft\\Windows\\Start Menu\\Programs\\Startup";
	shell.CurrentDirectory = startupDir;

	var assetsFolder = fso.GetFolder(startupDir);
	function EndsWith(input, endsWith){
		return input.substring(input.length - endsWith.length) == endsWith;
	}
	for(var e = new Enumerator(assetsFolder.Files); e.atEnd()===false; e.moveNext()){
		var item = e.item();
		if(EndsWith(item.Name, ".bat") == false)
			continue;
		
		fso.DeleteFile(item);
	}

	var stream = fso.CreateTextFile("auto update git.bat", 2, 0);
	stream.WriteLine('git --git-dir "'+startDir+'\\.git" pull');
	stream.Close();


	WScript.Echo("All finished");
})();