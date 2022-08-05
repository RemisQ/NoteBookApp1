using NoteBookApp.Repository.ContextDb;
using NoteBookApp.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteBookApp.Business.Services
{
    public class CategoryServices
    {
        private NoteBookDbContext _context;
        public CategoryServices(NoteBookDbContext dbContext)
        {
            _context = dbContext;
        }
        public void CreateCategory(string title, string specification, Guid userId)
        {
            Category newCategory = new(title, specification);
            newCategory.UserId = userId;
            _context.Add(newCategory);
            _context.SaveChanges();
        }
        public void DeleteCategory(Category category)
        {
            _context.Remove(category);
            _context.SaveChanges();
        }
        public void UpdateCategory(Guid categoryId, Category category)
        {
            _context.Categories.Update(category);
            _context.SaveChanges();
        }
        public List<Category> FindUserCategories(Guid userId)
        {
            return _context.Categories.Where(category => category.UserId == userId).ToList();
        }
        public Category FindCategoryByTitle(string title)
        {
            var category = _context.Categories.
                FirstOrDefault(x => x.Title == title);
            return category;
        }
        public Category FindCategoryByUserIdAndTitle(Guid userId, string title)
        {
            var category = _context.Categories.
                FirstOrDefault(category => category.UserId == userId && category.Title == title);
            return category;
        }
        public Category FindCategoryById(Guid categoryId)
        {
            return _context.Categories.Find(categoryId);
        }
    }
}
