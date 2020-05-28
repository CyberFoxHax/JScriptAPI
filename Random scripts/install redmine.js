var shell = WScript.CreateObject("WScript.Shell");
var fso = WScript.CreateObject("Scripting.FileSystemObject")

function RunCommands(){
	for(var i=0;i<arguments.length; i++){
		var status = shell.Run(arguments[i], 1, true);
		if (status == 0)
			continue;
		
		var exec = shell.Exec('cmd /c "' + arguments[i] + '"');
		while(exec.status === 0){
			WScript.Sleep(100);
		}
	}
}

var configFile = "config\\database.yml";
if(fso.FileExists(configFile) == false){
	var stream = fso.CreateTextFile(configFile, 2, 0);
	stream.Write(
		"production:"+
		"\n\tadapter: sqlite3" +
		"\n\tdatabase: db/redmine.sqlite3"
	)
	stream.close();
}



RunCommands(
	"gem install bundler",
	"bundle install --without development test",
	"bundle exec rake generate_secret_token"
);
	
shell.Environment("PROCESS")("RAILS_ENV") = "production";	
	
RunCommands(
	"bundle exec rake db:migrate",
	"RAILS_ENV=production bundle exec rake redmine:load_default_data"
);

shell.Environment("PROCESS")("RAILS_ENV") = "production";	
shell.Environment("PROCESS")("REDMINE_LANG") = "en";

RunCommands(
	"bundle exec rake redmine:load_default_data"
);