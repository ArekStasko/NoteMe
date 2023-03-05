using NoteMe.Data.Models.Note;
using NoteMe.Data.Repositories.NotesRepository;

namespace NoteMe.Processors.Update;

public class UpdateProcessor : IUpdateProcessor
{
    private INotesRepository _repo;

    public UpdateProcessor(INotesRepository repo)
    {
        _repo = repo;
    }

    public void Update(Note note)
    {
        _repo.UpdateNote(note);
    }
}