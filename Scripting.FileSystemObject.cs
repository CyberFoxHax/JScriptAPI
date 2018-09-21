
namespace Scripting{
	[CreateObject("Scripting.FileSystemObject")]
	class FileSystemObject{ // http://www.java2s.com/Tutorial/JavaScript/0600__MS-JScript/FileSystemObject.htm
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
		
		string CreateFolder(string path); // http://www.java2s.com/Tutorial/JavaScript/0600__MS-JScript/FileSystemObjectCreateFolder.htm
		
		bool FileExists(string file); // http://www.java2s.com/Tutorial/JavaScript/0600__MS-JScript/FileSystemObjectFileExists.htm
		bool FolderExists(string path); // http://www.java2s.com/Tutorial/JavaScript/0600__MS-JScript/FileSystemObjectFolderExists.htm
		bool DriveExists(string drive); //http://www.java2s.com/Tutorial/JavaScript/0600__MS-JScript/FileSystemObjectDriveExists.htm
		
		void CopyFile(string pathFrom, string pathTo, bool? replace); // http://www.java2s.com/Tutorial/JavaScript/0600__MS-JScript/FileSystemObjectCopyFile.htm
		void CopyFolder(string pathFrom, string pathTo, bool? replace); // http://www.java2s.com/Tutorial/JavaScript/0600__MS-JScript/FileSystemObjectCopyFolder.htm
		
		void DeleteFile(string path, bool force=false); // http://www.java2s.com/Tutorial/JavaScript/0600__MS-JScript/FileSystemObjectDeleteFile.htm
		void DeleteFolder(string path, bool force=false); // http://www.java2s.com/Tutorial/JavaScript/0600__MS-JScript/FileSystemObjectDeleteFolder.htm
		
		void MoveFile(string fileFrom, string fileTo); // http://www.java2s.com/Tutorial/JavaScript/0600__MS-JScript/FileSystemObjectMoveFile.htm
		void MoveFolder(string fileFrom, string fileTo); // http://www.java2s.com/Tutorial/JavaScript/0600__MS-JScript/FileSystemObjectMoveFolder.htm

		DriveCollection Drives { get; }// http://www.java2s.com/Tutorial/JavaScript/0600__MS-JScript/FileSystemObjectDrives.htm
		
		class DriveCollection : IEnumerable{
			DriveObject item(); // ?
		}
		
		string GetAbsolutePathName(string filename); // http://www.java2s.com/Tutorial/JavaScript/0600__MS-JScript/FileSystemObjectGetAbsolutePathName.htm
		string GetDriveName(string drive); // http://www.java2s.com/Tutorial/JavaScript/0600__MS-JScript/FileSystemObjectGetDriveName.htm
		string GetExtensionName(string file); // http://www.java2s.com/Tutorial/JavaScript/0600__MS-JScript/FileSystemObjectGetExtensionName.htm
		string GetFileName(string file); // http://www.java2s.com/Tutorial/JavaScript/0600__MS-JScript/FileSystemObjectGetFileName.htm
		string GetParentFolderName(string folder); // http://www.java2s.com/Tutorial/JavaScript/0600__MS-JScript/FileSystemObjectGetParentFolderName.htm
		DriveObject GetDrive(); // http://www.java2s.com/Tutorial/JavaScript/0600__MS-JScript/FileSystemObjectGetDrive.htm
		FileObject GetFile(string file); // http://www.java2s.com/Tutorial/JavaScript/0600__MS-JScript/FileSystemObjectGetFile.htm
		FolderObject GetFolder(string path); // http://www.java2s.com/Tutorial/JavaScript/0600__MS-JScript/FileSystemObjectGetFolder.htm
		
		string GetSpecialFolder(SpecialFolderType type); // http://www.java2s.com/Tutorial/JavaScript/0600__MS-JScript/FileSystemObjectGetSpecialFolder.htm
		enum SpecialFolderType { // http://www.java2s.com/Tutorial/JavaScript/0600__MS-JScript/FileSystemObjectGetSpecialFolder.htm
			WindowsFolder = 0,
			SystemFolder = 1,
			TemporaryFolder = 2
		}
		
		string GetTempName(); // http://www.java2s.com/Tutorial/JavaScript/0600__MS-JScript/FileSystemObjectGetTempName.htm
		string GetBaseName(string path); // http://www.java2s.com/Tutorial/JavaScript/0600__MS-JScript/FileSystemObjectGetBaseName.htm
		string BuildPath(string pathPartA, string partPartB); // http://www.java2s.com/Tutorial/JavaScript/0600__MS-JScript/FileSystemObjectBuildPath.htm
	}

	class FileObject {
		Attributes { get; } // 
		void Copy(); //
		DateCreated { get; } //
		DateLastAccessed { get; } // 
		DateLastModified { get; } // 
		void Delete(); // 
		Drive { get; } // 
		void Move(); // 
		string Name { get; } // 
		TextStream OpenAsTextStream(); // 
		ParentFolder { get; } // 
		string Path { get; } // 
		string ShortName { get; } // 
		string ShortPath { get; } // 
		Size { get; } // 
		Type { get; } // 
	}
}














