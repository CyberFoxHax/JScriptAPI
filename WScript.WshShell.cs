// Windows Script Host Object Model
// https://msdn.microsoft.com/en-us/library/a74hyyw0.aspx

namespace WScript{
	[CreateObject("WScript.Shell")]
	class WshShell{ // https://msdn.microsoft.com/en-us/library/aew9yb99.aspx
		string CurrentDirectory { get; set; } // https://msdn.microsoft.com/en-us/library/3cc5edzd.aspx
		WshEnvironment Environment { get; } // https://msdn.microsoft.com/en-us/library/fd7hxfdd.aspx
		WshEnvironment Environment(string type); // https://msdn.microsoft.com/en-us/library/fd7hxfdd.aspx
		WshSpecialFolders SpecialFolders { get; } // https://msdn.microsoft.com/en-us/library/0ea7b5xe.aspx
		WshSpecialFolders SpecialFolders(string name); // https://msdn.microsoft.com/en-us/library/0ea7b5xe.aspx
		
		WshScriptExec Exec(string executable); // https://msdn.microsoft.com/en-us/library/ateytk4a.aspx
		int Run(string command, WindowStyle? style, bool? waitOnReturn); // https://msdn.microsoft.com/en-us/library/d5fk67ky.aspx
		string ExpandEnvironmentStrings(string variableString); // http://www.robvanderwoude.com/vbstech_data_environment.php
		
		enum WindowStyle{ // https://msdn.microsoft.com/en-us/library/d5fk67ky.aspx
			Hidden = 0,
			Activated = 1,
			ActivatedMinimized = 2,
			ActivatedMaximized = 3,
		}
		
		class WshSpecialFolders { // https://msdn.microsoft.com/en-us/library/9x9e7edx.aspx
			string Item(string key); // https://msdn.microsoft.com/en-us/library/yzefkb42.aspx
			int length { get; } // https://msdn.microsoft.com/en-us/library/zz1z71z6.aspx
			int Count(); // https://msdn.microsoft.com/en-us/library/6x47fysb.aspx
		}
		
		class WshEnvironment { // https://msdn.microsoft.com/en-us/library/6s7w15a0.aspx
			string Item(string key); // https://msdn.microsoft.com/en-us/library/yzefkb42.aspx
			int length { get; } // https://msdn.microsoft.com/en-us/library/6kz722cz.aspx
			int Count(); // https://msdn.microsoft.com/en-us/library/6x47fysb.aspx
			void Remove(string name); // https://msdn.microsoft.com/en-us/library/218yba97.aspx
		}
		
		class WshScriptExec { // https://www.vbsedit.com/html/f3358e96-3d5a-46c2-b43b-3107e586736e.asp
			TextStream StdIn { get; }
			TextStream StdOut { get; }
			TextStream StdErr { get; }
			ExecStatus Status { get; }
			int ExitCode { get; }
			int ProcessID { get; }
			void Terminate();
		}
		
		enum ExecStatus {
			WshRunning=0,
			WshFinished=1,
		}
	}
}
