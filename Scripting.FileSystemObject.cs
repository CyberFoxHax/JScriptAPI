
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
		
		FolderObject CreateFolder(string path); // http://www.java2s.com/Tutorial/JavaScript/0600__MS-JScript/FileSystemObjectCreateFolder.htm
		
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
		
		class DriveCollection : IEnumerable{ // http://www.java2s.com/Tutorial/JavaScript/0600__MS-JScript/Drives.htm
			int Count(); // http://www.java2s.com/Tutorial/JavaScript/0600__MS-JScript/DrivesCount.htm
			DriveObject item(); // http://www.java2s.com/Tutorial/JavaScript/0600__MS-JScript/DrivesItem.htm
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
	
	class FilesCollection : IEnumerable { // http://www.java2s.com/Tutorial/JavaScript/0600__MS-JScript/Files.htm
		int Count(); // http://www.java2s.com/Tutorial/JavaScript/0600__MS-JScript/FilesCount.htm
		FileObject Item(string filename); // http://www.java2s.com/Tutorial/JavaScript/0600__MS-JScript/FilesItem.htm
	}
	
	class FoldersCollection : IEnumerable { // http://www.java2s.com/Tutorial/JavaScript/0600__MS-JScript/Folders.htm
		void Add(string foldername); // http://www.java2s.com/Tutorial/JavaScript/0600__MS-JScript/FoldersAdd.htm
		int Count(); // http://www.java2s.com/Tutorial/JavaScript/0600__MS-JScript/FoldersCount.htm
		FolderObject Item(string foldername); // http://www.java2s.com/Tutorial/JavaScript/0600__MS-JScript/FoldersItem.htm
		FolderObject Item(); // http://www.java2s.com/Tutorial/JavaScript/0600__MS-JScript/FoldersItem.htm
	}

	class FolderObject { //http://www.java2s.com/Tutorial/JavaScript/0600__MS-JScript/Folder.htm
		void Copy(string destination, bool overwrite=false); // http://www.java2s.com/Tutorial/JavaScript/0600__MS-JScript/FolderCopy.htm
		void Delete(bool force=false); // http://www.java2s.com/Tutorial/JavaScript/0600__MS-JScript/FolderDelete.htm
		
		/// todo. does this have an overwrite paramter?
		void Move(string destination); // http://www.java2s.com/Tutorial/JavaScript/0600__MS-JScript/FolderMove.htm
		
		AttributeFlags Attributes { get; set; } // http://www.java2s.com/Tutorial/JavaScript/0600__MS-JScript/FolderAttributes.htm
		enum AttributeFlags{
			Normal = 0,		// Normal folder with no attributes set
			ReadOnly = 1,	// Read-only folder with read/write attribute
			Hidden = 2,		// Hidden folder with read/write attribute
			System = 4,		// System folder with read/write attribute
			Volume = 8,		// Disk drive volume label with read-only attribute
			Directory = 16,	// Folder or directory with read-only attribute
			Archive = 32,	// Folder has changed since last backup with read/write attribute
			Alias = 64,		// Link or shortcut to a folder with read-only attribute
			Compressed = 128// Compressed folder with read-only attribute
		}
		
		
		Date DateCreated { get; } // http://www.java2s.com/Tutorial/JavaScript/0600__MS-JScript/FolderDateCreated.htm
		Date DateLastAccessed { get; }  // http://www.java2s.com/Tutorial/JavaScript/0600__MS-JScript/FolderDateLastAccessed.htm
		Date DateLastModified { get; }  // http://www.java2s.com/Tutorial/JavaScript/0600__MS-JScript/FolderDateLastModified.htm
		string Drive { get; } // http://www.java2s.com/Tutorial/JavaScript/0600__MS-JScript/FolderDrive.htm
		FilesCollection Files { get; } // http://www.java2s.com/Tutorial/JavaScript/0600__MS-JScript/FolderFiles.htm
		bool IsRootFolder { get; } // http://www.java2s.com/Tutorial/JavaScript/0600__MS-JScript/FolderIsRootFolder.htm
		string Name { get; set; } // http://www.java2s.com/Tutorial/JavaScript/0600__MS-JScript/FolderName.htm
		FolderObject ParentFolder { get; } // http://www.java2s.com/Tutorial/JavaScript/0600__MS-JScript/FolderParentFolder.htm
		string Path { get; } // http://www.java2s.com/Tutorial/JavaScript/0600__MS-JScript/FolderPath.htm
		string ShortName { get; } // http://www.java2s.com/Tutorial/JavaScript/0600__MS-JScript/FolderShortName.htm
		string ShortPath { get; } // http://www.java2s.com/Tutorial/JavaScript/0600__MS-JScript/FolderShortPath.htm
		int Size { get; } // http://www.java2s.com/Tutorial/JavaScript/0600__MS-JScript/FolderSize.htm
		FoldersCollection SubFolders { get; } // http://www.java2s.com/Tutorial/JavaScript/0600__MS-JScript/FolderSubFolders.htm
		string Type { get; } // http://www.java2s.com/Tutorial/JavaScript/0600__MS-JScript/FolderType.htm
	}
	
	class FileObject {
		AttributeFlags Attributes { get; } // http://www.java2s.com/Tutorial/JavaScript/0600__MS-JScript/FolderAttributes.htm
		enum AttributeFlags{
			Normal = 0,		// read/write
			ReadOnly = 1,	// read/write
			Hidden = 2,		// read/write
			System = 4,		// read/write
			Volume = 8,		// read
			Directory = 16,	// read
			Archive = 32,	// read/write
			Alias = 64,		// read. Link or shortcut to a File. 
			Compressed = 128// read. Compressed File with read-only attribute. Readonly
		}
		void Copy(string destination, bool overwrite=false); // http://www.java2s.com/Tutorial/JavaScript/0600__MS-JScript/FileCopy.htm
		Date DateCreated { get; } // http://www.java2s.com/Tutorial/JavaScript/0600__MS-JScript/FileDateCreated.htm
		Date DateLastAccessed { get; } // http://www.java2s.com/Tutorial/JavaScript/0600__MS-JScript/FileDateLastAccessed.htm
		Date DateLastModified { get; } // http://www.java2s.com/Tutorial/JavaScript/0600__MS-JScript/FileDateLastModified.htm
		void Delete(); // http://www.java2s.com/Tutorial/JavaScript/0600__MS-JScript/FileDelete.htm
		// test if have overwrite paramter
		void Move(string destination); // http://www.java2s.com/Tutorial/JavaScript/0600__MS-JScript/FileMove.htm
		string Name { get; } // http://www.java2s.com/Tutorial/JavaScript/0600__MS-JScript/FileName.htm
		FolderObject ParentFolder { get; } // http://www.java2s.com/Tutorial/JavaScript/0600__MS-JScript/FileParentFolder.htm
		string Path { get; } // http://www.java2s.com/Tutorial/JavaScript/0600__MS-JScript/FilePath.htm
		string ShortName { get; } // http://www.java2s.com/Tutorial/JavaScript/0600__MS-JScript/FileShortName.htm
		string ShortPath { get; } // http://www.java2s.com/Tutorial/JavaScript/0600__MS-JScript/FileShortPath.htm
		int Size { get; } // http://www.java2s.com/Tutorial/JavaScript/0600__MS-JScript/FileSize.htm
		string Type { get; } // http://www.java2s.com/Tutorial/JavaScript/0600__MS-JScript/FileType.htm
	}
	
	class DriveObject { // http://www.java2s.com/Tutorial/JavaScript/0600__MS-JScript/0100__Drive.htm
		// todo wat @AvailableSpace
		float FreeSpace { get; } // http://www.java2s.com/Tutorial/JavaScript/0600__MS-JScript/DriveFreeSpace.htm
		// todo wat @FreeSpace
		float AvailableSpace { get; } // http://www.java2s.com/Tutorial/JavaScript/0600__MS-JScript/DriveAvaliableSpace.htm
		float TotalSize { get; } // http://www.java2s.com/Tutorial/JavaScript/0600__MS-JScript/DriveTotalSize.htm
		bool IsReady { get; } // http://www.java2s.com/Tutorial/JavaScript/0600__MS-JScript/DriveIsReady.htm
		string Path { get; } // http://www.java2s.com/Tutorial/JavaScript/0600__MS-JScript/DrivePath.htm
		FolderObject { get; } // http://www.java2s.com/Tutorial/JavaScript/0600__MS-JScript/DriveRootFolder.htm
		string DriveLetter { get; } // http://www.java2s.com/Tutorial/JavaScript/0600__MS-JScript/DriveDriveLetter.htm
		DriveType Type { get; } // http://www.java2s.com/Tutorial/JavaScript/0600__MS-JScript/DriveDriveType.htm
		enum DriveType{
			Unknown=0
			Removable=1
			Fixed=2
			Network=3
			CDROM=4
			RAMDisk=5
		}
		string FileSystem { get; } // http://www.java2s.com/Tutorial/JavaScript/0600__MS-JScript/DriveFileSystem.htm
		string SerialNumber { get; } // http://www.java2s.com/Tutorial/JavaScript/0600__MS-JScript/DriveSerialNumber.htm
		string ShareName { get; } // http://www.java2s.com/Tutorial/JavaScript/0600__MS-JScript/DriveShareName.htm
		string VolumeName { get; } // http://www.java2s.com/Tutorial/JavaScript/0600__MS-JScript/DriveVolumeName.htm
	}
}














