using System;
class Program{
static void Main(string[] args){
Console.BackgroundColor = ConsoleColor.Yellow;
Console.ForegroundColor = ConsoleColor.Black;
Console.CursorVisible = false;
Console.Clear();
while (Console.ReadKey(true).Key != ConsoleKey.Escape) {
string s = @"using System;
class Program{{
static void Main(string[] args){{
Console.BackgroundColor = ConsoleColor.Yellow;
Console.ForegroundColor = ConsoleColor.Black;
Console.CursorVisible = false;
Console.Clear();
while (Console.ReadKey(true).Key != ConsoleKey.Escape) {{
string s = @{0}{1}{0};
Console.WriteLine(s,'{0}',s);}}}}}}";
Console.WriteLine(s, '"', s);}}}