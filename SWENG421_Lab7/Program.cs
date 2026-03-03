using SWENG421_Lab7;

var swengLine = new LineOfText();
swengLine.Add(new Character('S'));
swengLine.Add(new Character('W'));
swengLine.Add(new Character('E'));
swengLine.Add(new Character('N'));
swengLine.Add(new Character('G'));

var line421 = new LineOfText();
line421.Add(new Character('4'));
line421.Add(new Character('2'));
line421.Add(new Character('1'));

var innerColumn = new Column();
innerColumn.Add(line421);

var frame = new Frame();
frame.Add(innerColumn);

var column = new Column();
column.Add(swengLine);

var page = new Page();
page.Add(column);
page.Add(frame);

var novel = new Novel();
novel.Add(page);

Console.WriteLine("Scenario 2 - Writer views the novel:");
var writer = new Writer();
writer.Invoke(novel, "view");