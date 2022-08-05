using Microsoft.EntityFrameworkCore;
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
    public partial class CreateAccountForm : Form
    {
        public static NoteBookDbContext _context = new NoteBookDbContext();
        UserServices userServices = new(_context);
        public CreateAccountForm()
        {
            InitializeComponent();
        }

        private void createAccountButton_Click(object sender, EventArgs e)
        {
            string name = nameBox.Text;
            string lastname = lastnameBox.Text;
            string username = usernameBox.Text;
            string password = passwordBox.Text;
            if (name == "" || lastname == "" || username == "" || password == "")
            {
                MessageBox.Show("You missed something. All fields is required!!!");
            }
            else
            {
                List<User> checkUsername = userServices.FindUserByUserName(username);
                if (checkUsername.Count == 0)
                {
                    userServices.CreateUser(name, lastname, username, password);
                    MessageBox.Show("Your account registered successfully!");
                    nameBox.Clear();
                    lastnameBox.Clear();
                    usernameBox.Clear();
                    passwordBox.Clear();
                }
                else
                {
                    usernameBox.Clear();
                    MessageBox.Show("This username is already taken!");
                }
            }
        }
    }
}
