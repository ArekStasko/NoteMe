using NoteMe.Data.Repositories.NotesRepository;
using NoteMe.Processors.Add;
using NoteMe.Processors.Delete;
using NoteMe.Processors.Get;
using NoteMe.Processors.Update;

namespace NoteMe.Processors.ProcessorsFactory;

public class ProcessorsFactory : IProcessorsFactory
{
    private INotesRepository _repo;

    public ProcessorsFactory(INotesRepository repo)
    {
        _repo = repo;
    }
    
    public IAddProcessor GetAddProcessorInstance() => new AddProcessor(_repo);
    public IDeleteProcessor GetDeleteProcessorInstance() => new DeleteProcessor(_repo);
    public IUpdateProcessor GetUpdateProcessorInstance() => new UpdateProcessor(_repo);
    public IGetSingleProcessor GetGetSingleProcessorInstance() => new GetProcessor(_repo);
    public IGetAllProcessor GetGetAllProcessorInstance() => new GetProcessor(_repo);
}