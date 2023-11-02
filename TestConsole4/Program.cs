// See https://aka.ms/new-console-template for more information

using Microsoft.EntityFrameworkCore;
using TestConsole4;
using TestConsole4.Core;
using TestConsole4.Services;

using (var db = new TestContext())
{
    db.Database.EnsureCreated();
}


var nr = new NoteRepository();
var sn = new SuperNote(nr);

sn.CreateNote("устал","я очень устал"+ DateTime.Now);

Console.WriteLine(sn.FindNoteByTitle("устал").Text);
