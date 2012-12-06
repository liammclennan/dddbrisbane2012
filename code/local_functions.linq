<Query Kind="Program" />

void Main()
{
	Console.WriteLine(CountJsFiles());	
}

private int CountJsFiles() {
	Func<string,bool> IsJsFile               = (line) => line.EndsWith(".js");
	Func<int, string, int> Step                = (memo, item) => memo + 1;
	Func<IEnumerable<string>> GetLines         = () => new [] {"one.js", "two.js", "README.txt" };
	
	return GetLines().Where(IsJsFile).Aggregate(0, Step);
	
	// localFunctions.js
	// localFunctions.hs
}