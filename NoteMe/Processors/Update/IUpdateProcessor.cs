using NoteMe.Data.Models.Note;

namespace NoteMe.Processors.Update;

public interface IUpdateProcessor
{
    void Update(Note note);
}