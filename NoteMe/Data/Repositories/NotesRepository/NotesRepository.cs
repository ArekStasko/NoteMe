using NoteMe.Data.DataContext;
using NoteMe.Data.Models.Note;

namespace NoteMe.Data.Repositories.NotesRepository;

public class NotesRepository : INotesRepository
{
    private IContext _context;
    
    public NotesRepository(IContext context)
    {
        _context = context;
    }
    
    public List<Note> GetNotes()
    {
        return _context.Notes;
    }

    public Note GetNote(int Id)
    {
        var note = _context.Notes.Single(n => n.Id == Id);
        return note;
    }

    public void DeleteNote(int Id)
    {
        var note = GetNote(Id);
        _context.Notes.Remove(note);
    }

    public void AddNote(Note note)
    {
        _context.Notes.Add(note);
    }

    public void UpdateNote(Note note)
    {
        DeleteNote(note.Id);
        AddNote(note);
    }
}