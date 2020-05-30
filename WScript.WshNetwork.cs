
[CreateObject("WScript.Network")]
class WshNetwork { // https://ss64.com/vb/network.html
	public string UserName { get; }
	public string UserDomain { get; }
	public string ComputerName { get; }
	
	public void AddWindowsPrinterConnection(string path); // https://ss64.com/vb/addwindowsprinterconnection.html
	public void AddWindowsPrinterConnection(string name, string path); // https://ss64.com/vb/addwindowsprinterconnection.html
	[Deprecated("Use AddWindowsPrinterConnection()")]
	public void AddPrinterConnection(string localName, string remoteName, bool updateProfile=false, string? user, string? password); // https://ss64.com/vb/addprinterconnection.html
	
	// Note: i+0=DriveLetter, i+1=NetworkPath
    public Enumerator<string> EnumNetworkDrives(); // https://ss64.com/vb/enumnetworkdrives.html
	
	// Note: i+0=Port, i+1=PrinterName
    public Enumerator<string> EnumPrinterConnections(); // https://ss64.com/vb/enumprinterconnections.html
    public void MapNetworkDrive(string driveLetter, string path, bool persistent=false, string? user, string? password); // https://ss64.com/vb/mapnetworkdrive.html
    public void RemoveNetworkDrive(string driveLetter, bool force=false, bool updateProfile=false); // https://ss64.com/vb/removenetworkdrive.html
    public void RemovePrinterConnection(string driveLetter, bool force=false, bool updateProfile=false); // https://ss64.com/vb/removeprinterconnection.html
    public void SetDefaultPrinter(string path); // https://ss64.com/vb/setdefaultprinter.html
}