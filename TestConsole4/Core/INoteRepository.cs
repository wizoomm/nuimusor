using TestConsole4.Model;

namespace TestConsole4.Core;

public interface INoteRepository
{
    public IEnumerable<Note> GetAll();
    
    public void SetNote(Note note);
    
    public IEnumerable<Note> FindByTitle(string title);
}