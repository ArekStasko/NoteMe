using NoteMe.Data.Models.Note;

namespace NoteMe.Data.Repositories.NotesRepository;

public interface INotesRepository
{
   List<Note> GetNotes();
   Note GetNote(int Id);
   void DeleteNote(int Id);
   void AddNote(Note note);
   void UpdateNote(Note note);
}