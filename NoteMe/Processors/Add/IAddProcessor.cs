using NoteMe.Data.Models.Note;

namespace NoteMe.Processors.Add;

public interface IAddProcessor
{
    void Add(Note note);
}