class TextStream{ // http://www.devguru.com/content/technologies/vbscript/objects-textstream.html
	bool AtEndOfLine { get; }
	bool AtEndOfStream { get; }
	int Column { get; set; }
	int Line { get; set; }
	string Read();
	string ReadAll();
	string ReadLine();
	void Skip();
	void SkipLine();
	void Write(string text);
	void WriteLine(string text);
	void WriteBlankLines(int count);
	void Close();
}
