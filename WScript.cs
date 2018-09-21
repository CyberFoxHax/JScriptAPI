// Windows Script Host Object Model
// https://msdn.microsoft.com/en-us/library/a74hyyw0.aspx

class WScript{ // https://msdn.microsoft.com/en-us/library/at5ydy31.aspx
	WshArguments Arguments { get; } // https://msdn.microsoft.com/en-us/library/z2b05k8s.aspx
	int BuildVersion { get; } // https://msdn.microsoft.com/en-us/library/kt8ycte6.aspx
	string Version { get; } // https://msdn.microsoft.com/en-us/library/kaw07b53.aspx
	string Name { get; } // https://msdn.microsoft.com/en-us/library/3ktf76t1.aspx
	string FullName { get; } // https://msdn.microsoft.com/en-us/library/z00t383b.aspx
	bool Interactive { get; set; } // https://msdn.microsoft.com/en-us/library/b48sxsw0.aspx
	string Path { get; } // https://msdn.microsoft.com/en-us/library/sw3e6ehs.aspx
	string ScriptFullName { get; } // https://msdn.microsoft.com/en-us/library/cc5ywscw.aspx
	string ScriptName { get; } // https://msdn.microsoft.com/en-us/library/3faf1xkh.aspx
	TextStream StdErr { get; } // https://msdn.microsoft.com/en-us/library/hyez2k48.aspx
	TextStream StdIn { get; } // https://msdn.microsoft.com/en-us/library/1y8934a7.aspx
	TextStream StdOut { get; } // https://msdn.microsoft.com/en-us/library/c61dx86d.aspx
	
	void ConnectObject(object objEventSource, string strPrefix); // https://msdn.microsoft.com/en-us/library/ccxe1xe6.aspx
	void DisconnectObject(object obj); // https://msdn.microsoft.com/en-us/library/2d26y0c1.aspx
	object CreateObject(string strProgID, string? strPrefix); // https://msdn.microsoft.com/en-us/library/xzysf6hc.aspx
	object GetObject(string pathname, string? progID, string? prefix); // https://msdn.microsoft.com/en-us/library/8ywk619w.aspx
	void Echo(params string[] arg); // https://msdn.microsoft.com/en-us/library/h8f603s7.aspx
	void Quit(int? code); // https://msdn.microsoft.com/en-us/library/fw0fx1aw.aspx
	void Sleep(int ms); // https://msdn.microsoft.com/en-us/library/6t81adfd.aspx
	
	class WshArguments { // https://msdn.microsoft.com/en-us/library/ss1ysb2a.aspx
		string Item(int natIndex); // https://msdn.microsoft.com/en-us/library/yzefkb42.aspx
		WshNamed Named { get; } // https://msdn.microsoft.com/en-us/library/zw780x4f.aspx
		WshUnnamed Unnamed { get; } // https://msdn.microsoft.com/en-us/library/b4ywdf43.aspx
		void ShowUsage(); // https://msdn.microsoft.com/en-us/library/dc1y0x0h.aspx
		
		class WshNamed { // https://msdn.microsoft.com/en-us/library/d6y04sbb.aspx
			string Item(string key); // https://msdn.microsoft.com/en-us/library/c2x76sxz.aspx
			int length { get; } // https://msdn.microsoft.com/en-us/library/zz1z71z6.aspx
			int Count(); // https://msdn.microsoft.com/en-us/library/6x47fysb.aspx
			bool Exists(string key); // https://msdn.microsoft.com/en-us/library/0axxztye.aspx
		}

		class WshUnnamed {  // https://msdn.microsoft.com/en-us/library/ah2hawwc.aspx
			string Item(int index); // https://msdn.microsoft.com/en-us/library/c2x76sxz.aspx
			int length { get; } // https://msdn.microsoft.com/en-us/library/zz1z71z6.aspx
			int Count(); // https://msdn.microsoft.com/en-us/library/6x47fysb.aspx
		}
	}
}