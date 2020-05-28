var req = WScript.CreateObject("Microsoft.XMLHTTP");
//var req = WScript.CreateObject("MSXML2.XMLHTTP"); // also works
var isAsync = true;
req.open("GET", "http://www.example.com", isAsync);

if(isAsync == true){
	req.onreadystatechange = function(p){
		WScript.Echo(req.readyState);
		if(req.readyState == 4)
			WScript.Echo(req.responseText); // didn't look into parsing json yet
	};
	req.send();
}
else{
	req.send();
	WScript.Echo(req.responseText);
}

