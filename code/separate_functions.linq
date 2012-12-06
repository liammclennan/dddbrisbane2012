<Query Kind="Program" />

void Main()
{
	Console.WriteLine(CountJsFiles());	
}

private int CountJsFiles() {
	return GetLines().Where(EndsWithJs).Aggregate(0, Step);
}

private IEnumerable<string> GetLines() {
		return new [] {"one.js", "two.js", "README.txt" };
}

private bool EndsWithJs(string line) {
	return line.EndsWith(".js");
}

private int Step(int memo, string item) {
	return memo + 1;
}