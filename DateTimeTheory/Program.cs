var dateTime = new DateTime(2015,1,1);

var now = DateTime.Now;
var today = DateTime.Today;
Console.WriteLine("Hora: " + now.Hour);
Console.WriteLine("Minute: " + now.Minute);

Console.WriteLine(now.ToLongDateString());
Console.WriteLine(now.ToShortDateString());
Console.WriteLine(now.ToLongTimeString());
Console.WriteLine(now.ToShortTimeString());
Console.WriteLine(now.ToString("yyy-MM-dddd"));


var timeSpan = new TimeSpan(1, 2, 3);
var span1 = new TimeSpan(1, 0, 0);
var span2 = TimeSpan.FromHours(1);

var start = DateTime.Now;
var end = DateTime.Now.AddMinutes(2);
var duration = end - start;
Console.WriteLine("Duration: " + duration);

//Properties each timespan have a number of properties that comes in pairs

Console.WriteLine("Minutes: " + timeSpan.Minutes);
Console.WriteLine("Total Minutes: " + timeSpan.TotalMinutes);

//Add the time span is inmutable but can be modified by add and sustract

Console.WriteLine("Add Example: " + timeSpan.Add(TimeSpan.FromMinutes(10)));
Console.WriteLine("Subtract Example: " + timeSpan.Subtract(TimeSpan.FromMinutes(10)));

//ToString
Console.WriteLine("To String: " + timeSpan.ToString());

//Parse

Console.WriteLine("Parse: " + TimeSpan.Parse("01:10:59"));