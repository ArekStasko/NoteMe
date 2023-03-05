using NoteMe.Data.Repositories.NotesRepository;

namespace NoteMe.Processors.Delete;

public class DeleteProcessor : IDeleteProcessor
{
    private INotesRepository _repo;

    public DeleteProcessor(INotesRepository repo)
    {
        _repo = repo;
    }

    public void Delete(int Id)
    {
        _repo.DeleteNote(Id);
    }
}