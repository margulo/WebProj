﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Kazzel!");

//try enumerate
Enumerable.Range(0, 10).Select(x => x.ToString()).ToList().ForEach(x => Console.WriteLine(x));


