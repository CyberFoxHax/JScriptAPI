var shell = WScript.CreateObject("WScript.Shell");
if(WScript.FullName.indexOf("cscript.exe") == -1){
	shell.Run("cscript.exe \""+WScript.ScriptFullName +"\"");
	WScript.Quit();
}