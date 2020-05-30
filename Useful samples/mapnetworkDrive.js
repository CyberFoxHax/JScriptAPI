var network = WScript.CreateObject("WScript.Network");

// if the network path can't be found the program crashes. Wrap in try catch to keep executing
function mapDrive(driveLetter, path){
	try {
		network.MapNetworkDrive(driveLetter, path);
		return null;
	}
	catch(e){
		return e;
	}
}

var hello1_error = mapDrive("X:", "\\\\smb\\Hello1");
if(hello1_error != null)
	WScript.Echo("Error mapping drive X: " + hello1_error.message);

var hello2_error = mapDrive("Y:", "\\\\smb\\Hello2");
if(hello2_error != null)
	WScript.Echo("Error mapping drive Y: " + hello2_error.message);



