// using eval
function ParseJson(strJson){
	eval('var json = '+strJson+';');
	return json;
}

// using the DOM
function ParseJson(strJson){
    var html = WScript.CreateObject("htmlfile");
    var window = html.parentWindow;
    window.execScript("window.json = " + strJson, "JScript");
    return window.json;
}