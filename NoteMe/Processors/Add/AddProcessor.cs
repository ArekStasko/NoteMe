using NoteMe.Data.Models.Note;
using NoteMe.Data.Repositories.NotesRepository;

namespace NoteMe.Processors.Add;

public class AddProcessor : IAddProcessor
{
    private INotesRepository _repo;

    public AddProcessor(INotesRepository repo)
    {
        _repo = repo;
    }

    public void Add(Note note)
    {
        _repo.AddNote(note);
    }
}