<Query Kind="Program" />

void Main()
{
	Console.WriteLine(Numbers().Take(10));
}

private IEnumerable<int> Numbers() {
	int start = 0;
	
	while (true) {
		yield return start++;
	}

}