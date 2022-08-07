namespace NoteBookApp.WinForms
{
    partial class NoteBookForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LogoutButton = new System.Windows.Forms.Button();
            this.createNoteLabel = new System.Windows.Forms.Label();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.noteTitleLabel = new System.Windows.Forms.Label();
            this.noteContentLabel = new System.Windows.Forms.Label();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.noteTitleBox = new System.Windows.Forms.TextBox();
            this.noteContentBox = new System.Windows.Forms.TextBox();
            this.createNoteButton = new System.Windows.Forms.Button();
            this.uploadPhotoButton = new System.Windows.Forms.Button();
            this.uploadPictureBox = new System.Windows.Forms.PictureBox();
            this.createCategoryLabel = new System.Windows.Forms.Label();
            this.categoryTitleLabel = new System.Windows.Forms.Label();
            this.categoryTitleBox = new System.Windows.Forms.TextBox();
            this.categorySpecificationLabel = new System.Windows.Forms.Label();
            this.categorySpecificationBox = new System.Windows.Forms.TextBox();
            this.CategoryCreateButton = new System.Windows.Forms.Button();
            this.LogedByLabel = new System.Windows.Forms.Label();
            this.findCategoryLabel = new System.Windows.Forms.Label();
            this.findNoteLabel = new System.Windows.Forms.Label();
            this.findCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.findTextBox = new System.Windows.Forms.TextBox();
            this.findPictureBox = new System.Windows.Forms.PictureBox();
            this.LogoLabel = new System.Windows.Forms.Label();
            this.userNoteBox = new System.Windows.Forms.TextBox();
            this.userNotesLabel = new System.Windows.Forms.Label();
            this.findNoteComboBox = new System.Windows.Forms.ComboBox();
            this.removeButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.findNoteButton = new System.Windows.Forms.Button();
            this.findCategoryButton = new System.Windows.Forms.Button();
            this.userIdLabel = new System.Windows.Forms.Label();
            this.userInfoTextBox = new System.Windows.Forms.TextBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.pathLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.uploadPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.findPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // LogoutButton
            // 
            this.LogoutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.LogoutButton.Location = new System.Drawing.Point(20, 12);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(83, 30);
            this.LogoutButton.TabIndex = 0;
            this.LogoutButton.Text = "Log Out";
            this.LogoutButton.UseVisualStyleBackColor = false;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // createNoteLabel
            // 
            this.createNoteLabel.AutoSize = true;
            this.createNoteLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.createNoteLabel.ForeColor = System.Drawing.Color.Yellow;
            this.createNoteLabel.Location = new System.Drawing.Point(42, 45);
            this.createNoteLabel.Name = "createNoteLabel";
            this.createNoteLabel.Size = new System.Drawing.Size(101, 21);
            this.createNoteLabel.TabIndex = 1;
            this.createNoteLabel.Text = "Create Note";
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.categoryLabel.Location = new System.Drawing.Point(58, 77);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(71, 19);
            this.categoryLabel.TabIndex = 2;
            this.categoryLabel.Text = "Category";
            // 
            // noteTitleLabel
            // 
            this.noteTitleLabel.AutoSize = true;
            this.noteTitleLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.noteTitleLabel.Location = new System.Drawing.Point(57, 134);
            this.noteTitleLabel.Name = "noteTitleLabel";
            this.noteTitleLabel.Size = new System.Drawing.Size(72, 19);
            this.noteTitleLabel.TabIndex = 3;
            this.noteTitleLabel.Text = "Note title";
            // 
            // noteContentLabel
            // 
            this.noteContentLabel.AutoSize = true;
            this.noteContentLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.noteContentLabel.Location = new System.Drawing.Point(57, 200);
            this.noteContentLabel.Name = "noteContentLabel";
            this.noteContentLabel.Size = new System.Drawing.Size(96, 19);
            this.noteContentLabel.TabIndex = 4;
            this.noteContentLabel.Text = "Note content";
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(20, 99);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(173, 23);
            this.categoryComboBox.TabIndex = 5;
            // 
            // noteTitleBox
            // 
            this.noteTitleBox.Location = new System.Drawing.Point(20, 165);
            this.noteTitleBox.Name = "noteTitleBox";
            this.noteTitleBox.Size = new System.Drawing.Size(173, 23);
            this.noteTitleBox.TabIndex = 6;
            // 
            // noteContentBox
            // 
            this.noteContentBox.Location = new System.Drawing.Point(20, 232);
            this.noteContentBox.Multiline = true;
            this.noteContentBox.Name = "noteContentBox";
            this.noteContentBox.Size = new System.Drawing.Size(173, 93);
            this.noteContentBox.TabIndex = 7;
            // 
            // createNoteButton
            // 
            this.createNoteButton.BackColor = System.Drawing.Color.Yellow;
            this.createNoteButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.createNoteButton.Location = new System.Drawing.Point(20, 415);
            this.createNoteButton.Name = "createNoteButton";
            this.createNoteButton.Size = new System.Drawing.Size(75, 23);
            this.createNoteButton.TabIndex = 8;
            this.createNoteButton.Text = "Create";
            this.createNoteButton.UseVisualStyleBackColor = false;
            this.createNoteButton.Click += new System.EventHandler(this.createNoteButton_Click);
            // 
            // uploadPhotoButton
            // 
            this.uploadPhotoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.uploadPhotoButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.uploadPhotoButton.Location = new System.Drawing.Point(20, 351);
            this.uploadPhotoButton.Name = "uploadPhotoButton";
            this.uploadPhotoButton.Size = new System.Drawing.Size(75, 38);
            this.uploadPhotoButton.TabIndex = 9;
            this.uploadPhotoButton.Text = "Upload photo";
            this.uploadPhotoButton.UseVisualStyleBackColor = false;
            this.uploadPhotoButton.Click += new System.EventHandler(this.uploadPhotoButton_Click);
            // 
            // uploadPictureBox
            // 
            this.uploadPictureBox.Location = new System.Drawing.Point(109, 345);
            this.uploadPictureBox.Name = "uploadPictureBox";
            this.uploadPictureBox.Size = new System.Drawing.Size(174, 99);
            this.uploadPictureBox.TabIndex = 10;
            this.uploadPictureBox.TabStop = false;
            // 
            // createCategoryLabel
            // 
            this.createCategoryLabel.AutoSize = true;
            this.createCategoryLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.createCategoryLabel.ForeColor = System.Drawing.Color.Yellow;
            this.createCategoryLabel.Location = new System.Drawing.Point(726, 45);
            this.createCategoryLabel.Name = "createCategoryLabel";
            this.createCategoryLabel.Size = new System.Drawing.Size(130, 21);
            this.createCategoryLabel.TabIndex = 11;
            this.createCategoryLabel.Text = "Create category";
            // 
            // categoryTitleLabel
            // 
            this.categoryTitleLabel.AutoSize = true;
            this.categoryTitleLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.categoryTitleLabel.Location = new System.Drawing.Point(740, 77);
            this.categoryTitleLabel.Name = "categoryTitleLabel";
            this.categoryTitleLabel.Size = new System.Drawing.Size(101, 19);
            this.categoryTitleLabel.TabIndex = 12;
            this.categoryTitleLabel.Text = "Category title";
            // 
            // categoryTitleBox
            // 
            this.categoryTitleBox.Location = new System.Drawing.Point(696, 111);
            this.categoryTitleBox.Name = "categoryTitleBox";
            this.categoryTitleBox.Size = new System.Drawing.Size(190, 23);
            this.categoryTitleBox.TabIndex = 13;
            // 
            // categorySpecificationLabel
            // 
            this.categorySpecificationLabel.AutoSize = true;
            this.categorySpecificationLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.categorySpecificationLabel.Location = new System.Drawing.Point(712, 147);
            this.categorySpecificationLabel.Name = "categorySpecificationLabel";
            this.categorySpecificationLabel.Size = new System.Drawing.Size(159, 19);
            this.categorySpecificationLabel.TabIndex = 14;
            this.categorySpecificationLabel.Text = "Category specification";
            // 
            // categorySpecificationBox
            // 
            this.categorySpecificationBox.Location = new System.Drawing.Point(696, 183);
            this.categorySpecificationBox.Multiline = true;
            this.categorySpecificationBox.Name = "categorySpecificationBox";
            this.categorySpecificationBox.Size = new System.Drawing.Size(190, 93);
            this.categorySpecificationBox.TabIndex = 15;
            // 
            // CategoryCreateButton
            // 
            this.CategoryCreateButton.BackColor = System.Drawing.Color.Yellow;
            this.CategoryCreateButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CategoryCreateButton.Location = new System.Drawing.Point(751, 302);
            this.CategoryCreateButton.Name = "CategoryCreateButton";
            this.CategoryCreateButton.Size = new System.Drawing.Size(75, 23);
            this.CategoryCreateButton.TabIndex = 16;
            this.CategoryCreateButton.Text = "Create";
            this.CategoryCreateButton.UseVisualStyleBackColor = false;
            this.CategoryCreateButton.Click += new System.EventHandler(this.CategoryCreateButton_Click);
            // 
            // LogedByLabel
            // 
            this.LogedByLabel.AutoSize = true;
            this.LogedByLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LogedByLabel.ForeColor = System.Drawing.Color.Purple;
            this.LogedByLabel.Location = new System.Drawing.Point(109, 18);
            this.LogedByLabel.Name = "LogedByLabel";
            this.LogedByLabel.Size = new System.Drawing.Size(63, 15);
            this.LogedByLabel.TabIndex = 17;
            this.LogedByLabel.Text = "Loged by: ";
            // 
            // findCategoryLabel
            // 
            this.findCategoryLabel.AutoSize = true;
            this.findCategoryLabel.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.findCategoryLabel.Location = new System.Drawing.Point(20, 466);
            this.findCategoryLabel.Name = "findCategoryLabel";
            this.findCategoryLabel.Size = new System.Drawing.Size(77, 13);
            this.findCategoryLabel.TabIndex = 18;
            this.findCategoryLabel.Text = "Find category";
            // 
            // findNoteLabel
            // 
            this.findNoteLabel.AutoSize = true;
            this.findNoteLabel.Location = new System.Drawing.Point(20, 520);
            this.findNoteLabel.Name = "findNoteLabel";
            this.findNoteLabel.Size = new System.Drawing.Size(57, 15);
            this.findNoteLabel.TabIndex = 19;
            this.findNoteLabel.Text = "Find note";
            // 
            // findCategoryComboBox
            // 
            this.findCategoryComboBox.FormattingEnabled = true;
            this.findCategoryComboBox.Location = new System.Drawing.Point(103, 463);
            this.findCategoryComboBox.Name = "findCategoryComboBox";
            this.findCategoryComboBox.Size = new System.Drawing.Size(204, 23);
            this.findCategoryComboBox.TabIndex = 23;
            // 
            // findTextBox
            // 
            this.findTextBox.Location = new System.Drawing.Point(416, 360);
            this.findTextBox.Multiline = true;
            this.findTextBox.Name = "findTextBox";
            this.findTextBox.Size = new System.Drawing.Size(220, 132);
            this.findTextBox.TabIndex = 24;
            // 
            // findPictureBox
            // 
            this.findPictureBox.Location = new System.Drawing.Point(696, 360);
            this.findPictureBox.Name = "findPictureBox";
            this.findPictureBox.Size = new System.Drawing.Size(190, 132);
            this.findPictureBox.TabIndex = 25;
            this.findPictureBox.TabStop = false;
            // 
            // LogoLabel
            // 
            this.LogoLabel.AutoSize = true;
            this.LogoLabel.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.LogoLabel.ForeColor = System.Drawing.Color.Yellow;
            this.LogoLabel.Location = new System.Drawing.Point(696, 3);
            this.LogoLabel.Name = "LogoLabel";
            this.LogoLabel.Size = new System.Drawing.Size(198, 32);
            this.LogoLabel.TabIndex = 28;
            this.LogoLabel.Text = "@NoteBookApp";
            // 
            // userNoteBox
            // 
            this.userNoteBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.userNoteBox.Location = new System.Drawing.Point(235, 99);
            this.userNoteBox.Multiline = true;
            this.userNoteBox.Name = "userNoteBox";
            this.userNoteBox.Size = new System.Drawing.Size(413, 226);
            this.userNoteBox.TabIndex = 29;
            // 
            // userNotesLabel
            // 
            this.userNotesLabel.AutoSize = true;
            this.userNotesLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.userNotesLabel.Location = new System.Drawing.Point(404, 67);
            this.userNotesLabel.Name = "userNotesLabel";
            this.userNotesLabel.Size = new System.Drawing.Size(70, 19);
            this.userNotesLabel.TabIndex = 30;
            this.userNotesLabel.Text = "My notes";
            // 
            // findNoteComboBox
            // 
            this.findNoteComboBox.FormattingEnabled = true;
            this.findNoteComboBox.Location = new System.Drawing.Point(103, 516);
            this.findNoteComboBox.Name = "findNoteComboBox";
            this.findNoteComboBox.Size = new System.Drawing.Size(204, 23);
            this.findNoteComboBox.TabIndex = 31;
            // 
            // removeButton
            // 
            this.removeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.removeButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.removeButton.Location = new System.Drawing.Point(561, 515);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(75, 23);
            this.removeButton.TabIndex = 32;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = false;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.updateButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.updateButton.Location = new System.Drawing.Point(443, 516);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 23);
            this.updateButton.TabIndex = 33;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // findNoteButton
            // 
            this.findNoteButton.BackColor = System.Drawing.Color.Yellow;
            this.findNoteButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.findNoteButton.Location = new System.Drawing.Point(323, 516);
            this.findNoteButton.Name = "findNoteButton";
            this.findNoteButton.Size = new System.Drawing.Size(75, 23);
            this.findNoteButton.TabIndex = 34;
            this.findNoteButton.Text = "Find";
            this.findNoteButton.UseVisualStyleBackColor = false;
            this.findNoteButton.Click += new System.EventHandler(this.findNoteButton_Click);
            // 
            // findCategoryButton
            // 
            this.findCategoryButton.BackColor = System.Drawing.Color.Yellow;
            this.findCategoryButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.findCategoryButton.Location = new System.Drawing.Point(323, 463);
            this.findCategoryButton.Name = "findCategoryButton";
            this.findCategoryButton.Size = new System.Drawing.Size(75, 23);
            this.findCategoryButton.TabIndex = 35;
            this.findCategoryButton.Text = "Find";
            this.findCategoryButton.UseVisualStyleBackColor = false;
            this.findCategoryButton.Click += new System.EventHandler(this.findCategoryButton_Click);
            // 
            // userIdLabel
            // 
            this.userIdLabel.AutoSize = true;
            this.userIdLabel.Location = new System.Drawing.Point(169, 20);
            this.userIdLabel.Name = "userIdLabel";
            this.userIdLabel.Size = new System.Drawing.Size(0, 15);
            this.userIdLabel.TabIndex = 36;
            // 
            // userInfoTextBox
            // 
            this.userInfoTextBox.BackColor = System.Drawing.Color.Olive;
            this.userInfoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userInfoTextBox.ForeColor = System.Drawing.Color.Purple;
            this.userInfoTextBox.Location = new System.Drawing.Point(443, 17);
            this.userInfoTextBox.Name = "userInfoTextBox";
            this.userInfoTextBox.Size = new System.Drawing.Size(190, 16);
            this.userInfoTextBox.TabIndex = 37;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(335, 374);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(0, 15);
            this.idLabel.TabIndex = 38;
            // 
            // pathLabel
            // 
            this.pathLabel.AutoSize = true;
            this.pathLabel.ForeColor = System.Drawing.Color.Olive;
            this.pathLabel.Location = new System.Drawing.Point(676, 545);
            this.pathLabel.Name = "pathLabel";
            this.pathLabel.Size = new System.Drawing.Size(0, 15);
            this.pathLabel.TabIndex = 39;
            // 
            // NoteBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Olive;
            this.ClientSize = new System.Drawing.Size(898, 569);
            this.Controls.Add(this.pathLabel);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.userInfoTextBox);
            this.Controls.Add(this.userIdLabel);
            this.Controls.Add(this.findCategoryButton);
            this.Controls.Add(this.findNoteButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.findNoteComboBox);
            this.Controls.Add(this.userNotesLabel);
            this.Controls.Add(this.userNoteBox);
            this.Controls.Add(this.LogoLabel);
            this.Controls.Add(this.findPictureBox);
            this.Controls.Add(this.findTextBox);
            this.Controls.Add(this.findCategoryComboBox);
            this.Controls.Add(this.findNoteLabel);
            this.Controls.Add(this.findCategoryLabel);
            this.Controls.Add(this.LogedByLabel);
            this.Controls.Add(this.CategoryCreateButton);
            this.Controls.Add(this.categorySpecificationBox);
            this.Controls.Add(this.categorySpecificationLabel);
            this.Controls.Add(this.categoryTitleBox);
            this.Controls.Add(this.categoryTitleLabel);
            this.Controls.Add(this.createCategoryLabel);
            this.Controls.Add(this.uploadPictureBox);
            this.Controls.Add(this.uploadPhotoButton);
            this.Controls.Add(this.createNoteButton);
            this.Controls.Add(this.noteContentBox);
            this.Controls.Add(this.noteTitleBox);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.noteContentLabel);
            this.Controls.Add(this.noteTitleLabel);
            this.Controls.Add(this.categoryLabel);
            this.Controls.Add(this.createNoteLabel);
            this.Controls.Add(this.LogoutButton);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Name = "NoteBookForm";
            this.Text = "NoteBookForm";
            this.Load += new System.EventHandler(this.NoteBookForm_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.uploadPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.findPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button LogoutButton;
        private Label createNoteLabel;
        private Label categoryLabel;
        private Label noteTitleLabel;
        private Label noteContentLabel;
        private ComboBox categoryComboBox;
        private TextBox noteTitleBox;
        private TextBox noteContentBox;
        private Button createNoteButton;
        private Button uploadPhotoButton;
        private PictureBox uploadPictureBox;
        private Label createCategoryLabel;
        private Label categoryTitleLabel;
        private TextBox categoryTitleBox;
        private Label categorySpecificationLabel;
        private TextBox categorySpecificationBox;
        private Button CategoryCreateButton;
        private Label LogedByLabel;
        private Label findCategoryLabel;
        private Label findNoteLabel;
        private ComboBox findCategoryComboBox;
        private TextBox findTextBox;
        private PictureBox findPictureBox;
        private Label LogoLabel;
        private TextBox userNoteBox;
        private Label userNotesLabel;
        private ComboBox findNoteComboBox;
        private Button removeButton;
        private Button updateButton;
        private Button findNoteButton;
        private Button findCategoryButton;
        private Label userIdLabel;
        private TextBox userInfoTextBox;
        private Label idLabel;
        private Label pathLabel;
    }
}