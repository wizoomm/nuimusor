using TestConsole4.Model;

namespace TestConsole4.Services;

public interface ISuperNote
{
    public void CreateNote(string title, string text);
    
    public Note FindNoteByTitle(string title);

    public IEnumerable<Note> GetAllForToday();
}