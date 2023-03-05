using NoteMe.Data.Models.Note;

namespace NoteMe.Data.DataContext;

public interface IContext
{
    List<Note> Notes { get; set; }
}