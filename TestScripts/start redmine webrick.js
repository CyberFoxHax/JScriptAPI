var shell = WScript.CreateObject("WScript.Shell");

shell.Run('bundle exec rails server webrick -e production');
WScript.Sleep(6000);
shell.Exec('cmd /c "start "" http://localhost:3000/"');