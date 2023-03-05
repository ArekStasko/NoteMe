using NoteMe.Processors.Add;
using NoteMe.Processors.Delete;
using NoteMe.Processors.Get;
using NoteMe.Processors.Update;

namespace NoteMe.Processors.ProcessorsFactory;

public interface IProcessorsFactory
{
    IAddProcessor GetAddProcessorInstance();
    IDeleteProcessor GetDeleteProcessorInstance();
    IUpdateProcessor GetUpdateProcessorInstance();
    IGetSingleProcessor GetGetSingleProcessorInstance();
    IGetAllProcessor GetGetAllProcessorInstance();
}