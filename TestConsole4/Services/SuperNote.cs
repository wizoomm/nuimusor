using TestConsole4.Core;
using TestConsole4.Model;

namespace TestConsole4.Services;

public class SuperNote : ISuperNote
{
    private INoteRepository _noteRepository;

    public SuperNote(INoteRepository noteRepository)
    {
        _noteRepository = noteRepository;
    }

    public void CreateNote(string title, string text)
    {
        var note = new Note()
        {
            Text = text,
            Title = title,
            CreatedAt = DateTime.Now
        };
        
        _noteRepository.SetNote(note);
    }

    public Note FindNoteByTitle(string title)
    {
        return _noteRepository.FindByTitle(title).First();
    }

    public IEnumerable<Note> GetAllForToday()
    {
        return _noteRepository.GetAll().Where(n => n.CreatedAt.Date == DateTime.Now.Date);
    }
}