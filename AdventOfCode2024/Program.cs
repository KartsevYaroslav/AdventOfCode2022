﻿using AdventOfCode2024;

var lines = File.ReadAllLines("input.txt");

ISolvable day = new Day7();
var res1 = day.SolvePart1(lines);
Console.WriteLine($"Part 1: {res1}");

var res2 = day.SolvePart2(lines);
Console.WriteLine($"Part 2: {res2}");