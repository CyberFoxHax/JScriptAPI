function StartsWith(input, searchStr){
	return input.substring(0, searchStr.length) == searchStr;
}

function FindLastWhere(arr, condition){
	for(var i = arr.length-1; i>=0;i--){
		if(condition(arr[i]) == false)
			continue;
		return arr[i];
	}
}

(function(){
	var shell  = WScript.CreateObject("WScript.Shell");
	var fso = WScript.CreateObject("Scripting.FileSystemObject");

	var appData = shell.ExpandEnvironmentStrings("%appdata%");
	var logDir = appData + "\\..\\Local\\Unity\\Editor\\Editor.log";
	var packageCache = appData + "\\..\\Local\\Unity\\cache\\\packages\\\packages.unity.com\\";
	var unityFile = '"C:\\Program Files\\Unity\\Editor\\Unity.exe" -projectPath "E:\\Projects\\DaMei\\Unity3D\\FrameScaler"';

	//while(true){
	var destroyGarbageBat = fso.CreateTextFile("destroy garbage.bat", 2, 0);
	for(var i = 0; i<1; i++){
		//var exec = shell.Exec(unityFile);
        //
		//while (exec.Status == 0)
		//	WScript.Sleep(100);

		var stream = fso.OpenTextFile(logDir);
		var logStr = stream.ReadAll();
		stream.Close();
		
		var searchStr = "Updating Packages";
		var logEntry = FindLastWhere(
			logStr.split("\n"),
			function(p){return StartsWith(p, searchStr)}
		);
		if(logEntry == null)
			break;
		
		var file = logEntry.substring(searchStr.length, logEntry.indexOf(" - GUID:"));
		
		var stream;
		var errorsFile = "broken files.log";
		
		var stream = fso.FileExists(errorsFile) ?
			fso.OpenTextFile(errorsFile, 8, 0) :
			fso.CreateTextFile(errorsFile);
		
		stream.WriteLine(file);
		stream.Close();
		
		var rootFolderName = file.split("/")[1];
		var sanitizedPath = file.substring(rootFolderName.length+1).split("/").join("\\");
		
		var path = "";
		
		var folders = fso.GetFolder(packageCache).SubFolders;
		for(var e = new Enumerator(folders); e.atEnd()===false; e.moveNext()){
			var folder = e.item().name;
			if(StartsWith(folder, rootFolderName) == false)
				continue;
			
			path = packageCache + folder + sanitizedPath;
			
			break;
		}
		
		destroyGarbageBat.WriteLine('del "' + path + '"');
		destroyGarbageBat.WriteLine('copy "emptyfile" "' + path + '"');
		
		//var stream = fso.OpenTextFile(path, 2, 1);
		//stream.Write("");
		//stream.Close();
	}
	destroyGarbageBat.WriteLine();
	destroyGarbageBat.WriteLine('del "emptyfile"');
	destroyGarbageBat.WriteLine('pause');
	destroyGarbageBat.close();
	
	var stream = fso.CreateTextFile("emptyfile", 2, 0);
	stream.close();
	
})();