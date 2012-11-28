<Query Kind="Expression" />


new [] { "./file.js", "./sub/two.js", "./README.txt" }		// find .
	.Where(line => line.EndsWith(".js"))                    // grep .js
	.Aggregate(0, (memo,item) => memo += 1)					// wc -l