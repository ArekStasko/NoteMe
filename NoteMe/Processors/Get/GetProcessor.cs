using NoteMe.Data.Models.Note;
using NoteMe.Data.Repositories.NotesRepository;

namespace NoteMe.Processors.Get;

public class GetProcessor : IGetSingleProcessor, IGetAllProcessor
{
    private INotesRepository _repo;

    public GetProcessor(INotesRepository repo)
    {
        _repo = repo;
    }

    public Note Get(int Id)
    {
        var note = _repo.GetNote(Id);
        return note;
    }

    public List<Note> Get()
    {
        var notes = _repo.GetNotes();
        return notes;
    }
}