using IronPython.Hosting;
using Microsoft.Scripting;
using Microsoft.Scripting.Hosting;
using Nuuka.Scripting;

var engine = Python.CreateEngine(); // Extract Python language engine from their grasp
ScriptSource source = engine.CreateScriptSourceFromString("res = 1 + 2 + value + tag.ID + tag.First() + tag.Last()", SourceCodeKind.File);

ScriptScope scope = engine.CreateScope();
scope.SetVariable("value", 3);
scope.SetVariable("tag", new Tag()
{
    ID = 1,
    History = new List<HistoryItem>()
    {
        new HistoryItem(1),
        new HistoryItem(2),
        new HistoryItem(3)
    }
});
source.Execute(scope);

var res = scope.GetVariable<double>("res");

Console.WriteLine(res);
