using NoteBookApp.Business.Services;
using NoteBookApp.Repository.ContextDb;
using NoteBookApp.Repository.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteBookApp.WinForms
{
    public partial class NoteBookForm : Form
    {
        public static NoteBookDbContext _context = new();
        CategoryServices categoryServices = new(_context);
        UserServices userServices = new(_context);
        NoteServices noteServices = new NoteServices(_context);
        public static string SetNoteOrCategorieId = "";
        public static string SetUserId = "";
        public NoteBookForm()
        {
            InitializeComponent();
        }
        private void NoteBookForm_Load_1(object sender, EventArgs e)
        {
            userIdLabel.Text = LoginForm.SetValueForUserId;
            userInfoTextBox.AppendText($"{LoginForm.SetValueForUserName} {LoginForm.SetValueForUserLastName}");
            Guid userId = Guid.Parse(userIdLabel.Text);
            AddUserCategoryTitlesToList(userId);
            AddUserNoteTitlesToList(userId);
            var notes = noteServices.FindUserNotes(userId);
            var categories = categoryServices.FindUserCategories(userId);
            for (int i = 0; i < notes.Count; i++)
            {
                for (int j = 0; j < categories.Count; j++)
                {
                    if (notes[i].CategoryId == categories[j].Id)
                    {
                        if (notes[i].Photo == null)
                        {
                            userNoteBox.AppendText($"Categorie: {categories[j].Title}\r\nNote name: {notes[i].Title}\r\nRecord: {notes[i].Content}\r\n\r\n");
                        }
                        userNoteBox.AppendText($"Categorie: {categories[j].Title}\r\nNote name: {notes[i].Title}\r\nRecord: {notes[i].Content}\r\n\r\n");
                    }
                }
            }
        }
        private void AddUserCategoryTitlesToList(Guid userId)
        {
            List<Category> categories = categoryServices.FindUserCategories(userId);
            for (int i = 0; i < categories.Count; i++)
            {
                findCategoryComboBox.Items.Add(categories[i].Title);
                categoryComboBox.Items.Add(categories[i].Title);
            }
        }
        private void AddUserNoteTitlesToList(Guid userId)
        {
            findNoteComboBox.Items.Clear();
            List<Note> notes = noteServices.FindUserNotes(userId);
            for (int i = 0; i < notes.Count; i++)
            {
                findNoteComboBox.Items.Add(notes[i].Title);
            }
        }
        private void LogoutButton_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
        }

        private void findCategoryButton_Click(object sender, EventArgs e)
        {
            findTextBox.Clear();
            findPictureBox.Image = null;
            string categoryTitle = findCategoryComboBox.Text;
            if (categoryTitle == "")
            {
                MessageBox.Show("Please select category.");
            }
            else
            {
                var notes = noteServices.FindNotesByCategoryTitle(categoryTitle);
                if (notes.Count == 0)
                {
                    findTextBox.AppendText($"Category {findCategoryComboBox.Text} is empty");
                    var category = categoryServices.FindCategoryByTitle(findCategoryComboBox.Text);
                    idLabel.Text = category.Id.ToString();
                }
                else
                {
                    findTextBox.AppendText($"Notes by category {findCategoryComboBox.Text}:\r\n");
                    for (int i = 0; i < notes.Count; i++)
                    {
                        findTextBox.AppendText($"Note title: {notes[i].Title}\r\nContent: {notes[i].Content};\r\n*******\r\n");
                        idLabel.Text = notes[i].CategoryId.ToString();
                    }
                }
            }
        }

        private void findNoteButton_Click(object sender, EventArgs e)
        {
            findTextBox.Clear();
            findPictureBox.Image = null;
            string noteTitle = findNoteComboBox.Text;
            if (noteTitle == "")
            {
                MessageBox.Show("Please select note title.");
            }
            else
            {
                var note = noteServices.FindNoteByTitle(noteTitle);
                findTextBox.AppendText($"Note title: {note.Title}\r\n Note content: {note.Content}\r\n*******");
                //idLabel.Text = note.Id.ToString();
                if (note.Photo == "")
                {
                    findPictureBox.Visible = false;
                }
                else
                {
                    findPictureBox.Image = new Bitmap(note.Photo);
                }
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (findTextBox.Text == "")
            {
                MessageBox.Show("Please select category or note");
            }
            else
            {
                SetNoteOrCategorieId = idLabel.Text;
                Guid id = Guid.Parse(idLabel.Text);
                SetUserId = userIdLabel.Text;
                var note = noteServices.FindNoteById(id);
                if (note != null)
                {
                    UpdateForm updateForm = new UpdateForm();
                    updateForm.ShowDialog();
                }
                else
                {
                    UpdateForm updateForm = new UpdateForm();
                    updateForm.ShowDialog();
                }
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (findTextBox.Text == "")
            {
                MessageBox.Show("Please select category or note");
            }
            else
            {
                Guid id = Guid.Parse(idLabel.Text);
                var category = categoryServices.FindCategoryById(id);
                var note = noteServices.FindNoteById(id);
                if (note != null)
                {
                    findNoteComboBox.Items.Remove(note.Title);
                    noteServices.DeleteNote(note);
                    findTextBox.Clear();
                    MessageBox.Show("Note deleted");
                }
                else
                {
                    findCategoryComboBox.Items.Remove(category.Title);
                    categoryComboBox.Items.Remove(category.Title);
                    categoryServices.DeleteCategory(category);
                    findTextBox.Clear();
                    MessageBox.Show("Category deleted");
                }
                this.Close();
                NoteBookForm noteBookForm = new NoteBookForm();
                noteBookForm.ShowDialog();
            }
        }
    }
}
