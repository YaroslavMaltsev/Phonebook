namespace Phonebook.View.Views
{
    partial class GetContactByPhoneNumberWindow
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
            label1 = new Label();
            dataGridView1 = new DataGridView();
            Search = new Button();
            textBox1 = new TextBox();
            Surname = new DataGridViewTextBoxColumn();
            NameContact = new DataGridViewTextBoxColumn();
            LastName = new DataGridViewTextBoxColumn();
            DateOfBirth = new DataGridViewTextBoxColumn();
            Phone = new DataGridViewTextBoxColumn();
            City = new DataGridViewTextBoxColumn();
            Street = new DataGridViewTextBoxColumn();
            NumberHome = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 15);
            label1.Name = "label1";
            label1.Size = new Size(148, 15);
            label1.TabIndex = 1;
            label1.Text = "Введите номер телефона:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Surname, NameContact, LastName, DateOfBirth, Phone, City, Street, NumberHome });
            dataGridView1.Location = new Point(12, 122);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(491, 150);
            dataGridView1.TabIndex = 3;
            // 
            // Search
            // 
            Search.Location = new Point(188, 59);
            Search.Name = "Search";
            Search.Size = new Size(75, 23);
            Search.TabIndex = 5;
            Search.Text = "Поиск";
            Search.UseVisualStyleBackColor = true;
            Search.Click += Search_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(165, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(118, 23);
            textBox1.TabIndex = 6;
            // 
            // Surname
            // 
            Surname.HeaderText = "Фамилия";
            Surname.Name = "Surname";
            // 
            // NameContact
            // 
            NameContact.HeaderText = "Имя";
            NameContact.Name = "NameContact";
            // 
            // LastName
            // 
            LastName.HeaderText = "Отчество";
            LastName.Name = "LastName";
            // 
            // DateOfBirth
            // 
            DateOfBirth.HeaderText = "Дата_рождения";
            DateOfBirth.Name = "DateOfBirth";
            // 
            // Phone
            // 
            Phone.HeaderText = "Телефон";
            Phone.Name = "Phone";
            // 
            // City
            // 
            City.HeaderText = "Город";
            City.Name = "City";
            // 
            // Street
            // 
            Street.HeaderText = "Улица";
            Street.Name = "Street";
            // 
            // NumberHome
            // 
            NumberHome.HeaderText = "Номер_дома";
            NumberHome.Name = "NumberHome";
            // 
            // GetContactByPhoneNumberWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(516, 277);
            Controls.Add(textBox1);
            Controls.Add(Search);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "GetContactByPhoneNumberWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Поиск контакта по номеру телефона";
            Load += GetContactByPhoneNumberWindow_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private DataGridView dataGridView1;
        private Button Search;
        private TextBox textBox1;
        private DataGridViewTextBoxColumn Surname;
        private DataGridViewTextBoxColumn NameContact;
        private DataGridViewTextBoxColumn LastName;
        private DataGridViewTextBoxColumn DateOfBirth;
        private DataGridViewTextBoxColumn Phone;
        private DataGridViewTextBoxColumn City;
        private DataGridViewTextBoxColumn Street;
        private DataGridViewTextBoxColumn NumberHome;
    }
}