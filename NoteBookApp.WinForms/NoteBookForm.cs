using NoteBookApp.Business.Services;
using NoteBookApp.Repository.ContextDb;
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

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
        }
        private void NoteBookForm_Load(object sender, System.EventArgs e)
        {
            userIdLabel.Text = LoginForm.SetValueForUserId;
            userInfoTextBox.AppendText($"{LoginForm.SetValueForUserName} {LoginForm.SetValueForUserLastName}");
            Guid userId = Guid.Parse(userIdLabel.Text);
            //AddNoteNameByUserToList(userId);
            //AddCategorieByUserToList(userId);
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
        /* private void removeButton_Click(object sender, EventArgs e)
        {
            if (findTextBox.Text == "")
            {
                MessageBox.Show("Please select category or note");
            }
            else
            {
                Guid categoryId = Guid.Parse(idLabel.Text);
                var category = categoryServices.FindCategoryById(categoryId);
                var note = noteServices.FindNoteById(idFromLabel);
                if (note != null)
                {
                    noteNameList.Items.Remove(note.Name);
                    noteServices.RemoveNote(note);
                    searchTextBox.Clear();
                    MessageBox.Show("Note deleted succsesfully.");
                }
                else
                {
                    findCategoryComboBox.Items.Remove(category.title);
                    categorieNameList.Items.Remove(categorie.Name);
                    categorieServices.RemoveCategorie(categorie);
                    searchTextBox.Clear();
                    MessageBox.Show("Categorie deleted succsesfully.");
                }
                this.Close();
                NoteBookForm noteBookForm = new NoteBookForm();
                noteBookForm.ShowDialog();
            }
        } */
    }
}
