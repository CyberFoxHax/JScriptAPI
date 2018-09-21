namespace Scripting{
	[CreateObject("Scripting.FileSystemObject")]
	class FileSystemObject{ // http://www.java2s.com/Tutorial/JavaScript/0600__MS-JScript/FileSystemObject.htm
		string BuildPath(string pathA, string partB); // http://www.java2s.com/Tutorial/JavaScript/0600__MS-JScript/FileSystemObjectBuildPath.htm
		void CopyFile(string pathFrom, string pathTo, bool? replace); // http://www.java2s.com/Tutorial/JavaScript/0600__MS-JScript/FileSystemObjectCopyFile.htm
		void CopyFolder(string pathFrom, string pathTo, bool? replace); // http://www.java2s.com/Tutorial/JavaScript/0600__MS-JScript/FileSystemObjectCopyFolder.htm
		string CreateFolder(string path); // http://www.java2s.com/Tutorial/JavaScript/0600__MS-JScript/FileSystemObjectCreateFolder.htm
		
		// https://docs.microsoft.com/en-us/office/vba/language/reference/user-interface-help/createtextfile-method
		// http://www.java2s.com/Tutorial/JavaScript/0600__MS-JScript/FileSystemObjectCreateTextFile.htm
		TextStream CreateTextFile(string path, bool replace=false, bool unicode=false);
		
		// https://docs.microsoft.com/en-us/office/vba/language/reference/user-interface-help/opentextfile-method
		// http://www.java2s.com/Tutorial/JavaScript/0600__MS-JScript/FileSystemObjectOpentextFile.htm
		TextStream OpenTextFile(string path, IOMode? mode, bool? create, Encoding encoding);

		enum IOMode { // https://docs.microsoft.com/en-us/office/vba/language/reference/user-interface-help/opentextfile-method
			ForReading = 1,
			ForWriting = 2,
			ForAppending = 8
		}
		
		enum Encoding { // https://docs.microsoft.com/en-us/office/vba/language/reference/user-interface-help/opentextfile-method
			SystemDefault = -2, // const TristateUseDefault
			Unicode = -1, // const TristateTrue
			ASCII = 0, // const TristateFalse
		}
	
		
		void DeleteFile(string path, bool force=false); // http://www.java2s.com/Tutorial/JavaScript/0600__MS-JScript/FileSystemObjectDeleteFile.htm
	
	}
}