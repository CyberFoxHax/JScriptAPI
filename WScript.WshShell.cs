// Windows Script Host Object Model
// https://msdn.microsoft.com/en-us/library/a74hyyw0.aspx

namespace WScript{
	[CreateObject("WScript.Shell")]
	class WshShell{ // https://msdn.microsoft.com/en-us/library/aew9yb99.aspx
		string CurrentDirectory { get; set; } // https://msdn.microsoft.com/en-us/library/3cc5edzd.aspx
		WshEnvironment Environment { get; } // https://msdn.microsoft.com/en-us/library/fd7hxfdd.aspx
		WshSpecialFolders SpecialFolders { get; } // https://msdn.microsoft.com/en-us/library/0ea7b5xe.aspx
		WshEnvironment Environment(string type); // https://msdn.microsoft.com/en-us/library/fd7hxfdd.aspx
		WshSpecialFolders SpecialFolders(string name); // https://msdn.microsoft.com/en-us/library/0ea7b5xe.aspx
		string ExpandEnvironmentStrings(string variableString); // http://www.robvanderwoude.com/vbstech_data_environment.php
		bool AppActivate(string title); // https://msdn.microsoft.com/en-us/library/wzcddbek.aspx
		bool AppActivate(int processID); // https://msdn.microsoft.com/en-us/library/wzcddbek.aspx
		IWshShortcut CreateShortcut(string pathname); // https://msdn.microsoft.com/en-us/library/xsy6k3ys.aspx
		bool LogEvent(LogEventTypes eventType, string message, string? target); // https://msdn.microsoft.com/en-us/library/b4ce6by3.aspx
		PopupReturnCode Popup(string text, int? timeoutSeconds, string? title, PopupConfig? config); // https://msdn.microsoft.com/en-us/library/x83z1d9f.aspx
		void SendKeys(string key); // https://msdn.microsoft.com/en-us/library/8c6yea83.aspx
		
		object RegRead(string key); // https://msdn.microsoft.com/en-us/library/x05fawxd.aspx
		void RegDelete(string key); // https://msdn.microsoft.com/en-us/library/293bt9hh.aspx
		void RegWrite(string key, object value, string regType); // https://msdn.microsoft.com/en-us/library/yfdfhz1b.aspx
		
		WshScriptExec Exec(string executable); // https://msdn.microsoft.com/en-us/library/ateytk4a.aspx
		int Run(string command, WindowStyle? style, bool? waitOnReturn); // https://msdn.microsoft.com/en-us/library/d5fk67ky.aspx
		
		enum PopupReturnCode {
			Timeout = -1,
			Button_Ok = 1,
			Button_Cancel = 2,
			Button_Abort = 3,
			Button_Retry = 4,
			Button_Ignore = 5,
			Button_Yes = 6,
			Button_No = 7,
			Button_TryAgain = 10,
			Button_Continue  = 11
		}
		
		enum PopupConfig { // https://docs.microsoft.com/en-us/windows/desktop/api/winuser/nf-winuser-messagebox
			Buttons_Ok = 0,
			Buttons_OkCancel = 1,
			Buttons_AbortRetryIngore = 2,
			Buttons_YesNoCancel = 3,
			Buttons_YesNo = 4,
			Buttons_RetryCancel = 5,
			Buttons_CancelTryAgainContinue = 6,
			Icon_Stop = 16, // 0x10
			Icon_QuestionMark = 32, // 0x20
			Icon_ExclamationMark = 48, // 0x30
			Icon_InformationMark = 64, // 0x40
			Other_SecondButtonIsDefault = 256, // 0x100
			Other_ThirdButtonIsDefault = 512, // 0x200
			Other_SystemTopMostModal = 4096, // 0x1000
			Other_TextJustifyRight = 524288, // 0x80000
			Other_CaptionRightToLeft = 1048576, // 0x100000
		}
		
		enum LogEventTypes{
			Success = 0,
			Error = 1,
			Warning = 2,
			Information = 4,
			AuditSuccess = 8,
			AuditFailure = 16
		}
		
		abstract class WshShortcutBase {
			string TargetPath { get; set; } // https://msdn.microsoft.com/en-us/library/594k4c67.aspx
			void Save(); // https://msdn.microsoft.com/en-us/library/k5x59zft.aspx
		}
		
		class WshShortcut : WshShortcutBase {
			WshArguments Arguments { get; } // https://msdn.microsoft.com/en-us/library/z2b05k8s.aspx
			string Description { get; set; } // https://msdn.microsoft.com/en-us/library/ybdhh477.aspx
			string FullName { get; } // https://msdn.microsoft.com/en-us/library/7c7x465d.aspx
			string Hotkey { get; set; } // https://msdn.microsoft.com/en-us/library/3zb1shc6.aspx
			string IconLocation { get; set; } // https://msdn.microsoft.com/en-us/library/3s9bx7at.aspx
			string RelativePath { get; set; } // https://msdn.microsoft.com/en-us/library/85hy4580.aspx
			string TargetPath { get; set; } // https://msdn.microsoft.com/en-us/library/594k4c67.aspx
			WindowStyle WindowStyle { get; set; } // https://msdn.microsoft.com/en-us/library/w88k7fw2.aspx
			string WorkingDirectory { get; set; } // https://msdn.microsoft.com/en-us/library/ae0a4aee.aspx
			void Save(); // https://msdn.microsoft.com/en-us/library/k5x59zft.aspx
		}
		
		class WshURLShortcut : WshShortcutBase {
			string FullName { get; } // https://msdn.microsoft.com/en-us/library/bxz935t5.aspx
		}
		
		enum WindowStyle{ // https://msdn.microsoft.com/en-us/library/d5fk67ky.aspx
			Hidden = 0,
			Activated = 1,
			ActivatedMinimized = 2,
			ActivatedMaximized = 3
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
			WshFinished=1
		}
	}
}
