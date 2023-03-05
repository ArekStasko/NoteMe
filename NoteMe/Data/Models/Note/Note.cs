namespace NoteMe.Data.Models.Note;

public class Note : INote
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
}