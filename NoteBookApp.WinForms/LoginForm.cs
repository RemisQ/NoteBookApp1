using NoteBookApp.Business.Services;
using NoteBookApp.Repository.ContextDb;
using System.Windows.Forms;

namespace NoteBookApp.WinForms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        public static NoteBookDbContext _context = new();
        UserServices findData = new(_context);
        CreateAccountForm signup = new();
        NoteBookForm notebook = new();
        public static string SetValueForUserId = "";
        public static string SetValueForUserName = "";
        public static string SetValueForUserLastName = "";
        private void signUpButton_Click(object sender, EventArgs e)
        {
            signup.ShowDialog();
        }

        private void guestButton_Click(object sender, EventArgs e)
        {
            GuestForm guestForm = new();
            guestForm.Show();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = usernameBox.Text;
            string password = passwordBox.Text;
            var user = findData.FindUserByUserNameAndPassword(username, password);
            if (user == null)
            {
                MessageBox.Show("Username or password is incorrect.");
                usernameBox.Clear();
                passwordBox.Clear();
            }
            else
            {
                SetValueForUserId = user.Id.ToString();
                SetValueForUserName = user.FirstName;
                SetValueForUserLastName = user.LastName;
                notebook.Show();
                this.Visible = false;
            }
        }
    }
}