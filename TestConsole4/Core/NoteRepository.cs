using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using TestConsole4.Model;

namespace TestConsole4.Core;

public class NoteRepository : INoteRepository
{
    public IEnumerable<Note> GetAll()
    {
        using var dbContext = new TestContext();
        return dbContext.Notes.ToList();
    }

    public void SetNote(Note note)
    {
        using var dbContext = new TestContext();
        dbContext.Notes.Add(note);
        dbContext.SaveChanges();
    }

    public IEnumerable<Note> FindByTitle(string title)
    {
        using var dbContext = new TestContext();
        return dbContext.Notes.Where(n => n.Title.Contains(title)).ToList();
    }
}