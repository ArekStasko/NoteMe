namespace NoteMe.Data.Models.Note;

public interface INote
{
    int Id { get; set; }
    string Title { get; set; }
    string Description { get; set; }
}