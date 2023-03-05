using NoteMe.Data.Models.Note;

namespace NoteMe.Processors.Get;

public interface IGetAllProcessor
{
    List<Note> Get();
}