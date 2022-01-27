# WasmToArrayIssue
ArrayList.ToArray(type) is not working for enum type in Blazor WebAssembly

Below code is code snippet:

ArrayList list = new ArrayList();
list.Add(Day.Monday);
var array = list.ToArray(typeof(Day));

public enum Day
{
    Monday,
    Tuesday
}

This is working fine in .net 6 desktop. But in Blazor WebAssembly, it throws exception
System.InvalidCastException: At least one element in the source array could not be cast down to the destination array type. 
