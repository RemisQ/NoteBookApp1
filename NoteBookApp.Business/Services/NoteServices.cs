using NoteBookApp.Repository.ContextDb;
using NoteBookApp.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteBookApp.Business.Services
{
    public class NoteServices
    {
        private NoteBookDbContext _context;
        public NoteServices(NoteBookDbContext dbContext)
        {
            _context = dbContext;
        }
        public void CreateNote(string title, string content, string photo, Guid userId, Guid categoryId)
        {
            Note note = new(title, content, photo);
            note.CategoryId = categoryId;
            note.UserId = userId;
            _context.Add(note);
            _context.SaveChanges();
        }
        public void AddNoteToCategory(Category category, Note note)
        {
            category.Notes.Add(note);
        }
        public void AddNoteToUser(User user, Note note)
        {
            user.Notes.Add(note);
        }
        public void DeleteNote(Note note)
        {
            _context.Remove(note);
            _context.SaveChanges();
        }
        public void UpdateNote(Guid id, Note note)
        {
            _context.Notes.Update(note);
            _context.SaveChanges();
        }
        public Note FindNoteByTitle(string title)
        {
            var note = _context.Notes
                .FirstOrDefault(x => x.Title == title);
            return note;
        }
        public Note FindNoteById(Guid id)
        {
            return _context.Notes.Find(id);
        }
        public List<Note> FindNotesByCategoryTitle(string title)
        {
            var notes = _context.Notes.Where(x => x.Category.Title == title).ToList();
            return notes;
        }
        public List<Note> FindUserNotes(Guid userId)
        {
            return _context.Notes.Where(x => x.UserId == userId).ToList();
        }
        public Note FindUserNoteByTitle(Guid userId, string title)
        {
            var note = _context.Notes.
                FirstOrDefault(x => x.UserId == userId && x.Title == title);
            return note;
        }
    }
}
