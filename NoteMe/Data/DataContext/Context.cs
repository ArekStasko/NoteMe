using NoteMe.Data.Models.Note;

namespace NoteMe.Data.DataContext;

public class Context : IContext
{
    public List<Note> Notes { get; set; } = new();
}