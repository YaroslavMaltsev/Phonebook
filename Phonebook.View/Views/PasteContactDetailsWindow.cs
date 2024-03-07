using Phonebook.ApplicationServices.ApplicationDTOs;
using Phonebook.ApplicationServices.Interfaces;

namespace Phonebook.View.Views
{
    public partial class PasteContactDetailsWindow : Form
    {
        private readonly IAddContactService _addContactService;

        public PasteContactDetailsWindow(IAddContactService addContactService)
        {
            InitializeComponent();
            _addContactService = addContactService;
        }
        private async void PasteContactDetailsWindow_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Save_KeyDown);
            this.KeyPress += new KeyPressEventHandler(MovingBetween);
        }
        private void MovingBetween(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Tab)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
                e.Handled = true;
            }
        }
        public async void Save_KeyDown(object sender, KeyEventArgs e) 
        {
            if (e.Control && e.KeyCode == Keys.S)
            {
                await CreateContact();
            }
        }
        private async void Save_Click(object sender, EventArgs e)
        {
            await CreateContact();
        }

        private async Task CreateContact()
        {
            

            var contactDTO = new ContactDTO
            {
                Surname = textBox1.Text,
                Name = textBox2.Text,
                LastName = textBox3.Text,
                PhoneNumber = textBox4.Text,
                DateOfBirth = dateTimePicker1.Value.Date,
                AdressContatDTO = new AdressContatDTO
                {
                    City = textBox5.Text,
                    Street = textBox6.Text,
                    HouseNumber = textBox7.Text,
                }

            };
            await _addContactService.AddContactAsync(contactDTO);
        }

       
    }
}
