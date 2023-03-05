using NoteMe.Data.Models.Note;

namespace NoteMe.Processors.Get;

public interface IGetSingleProcessor
{
    Note Get(int Id);
}