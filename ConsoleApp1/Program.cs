// See https://aka.ms/new-console-template for more information

using System.Collections;

ArrayList list = new ArrayList();
list.Add(Day.Monday);

try
{
    var array = list.ToArray(typeof(Day));
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
    return;
}

Console.WriteLine("OK");


public enum Day
{
    Monday,
    Tuesday
}
