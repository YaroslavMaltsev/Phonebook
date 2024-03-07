using Phonebook.ApplicationServices.Interfaces;

namespace Phonebook.View.Views
{
    public partial class GetContactByPhoneNumberWindow : Form
    {
        private readonly IGetContactByPhoneNumberService _getContactByPhoneNumberService;

        public GetContactByPhoneNumberWindow(IGetContactByPhoneNumberService getContactByPhoneNumberService)
        {
            InitializeComponent();

            _getContactByPhoneNumberService = getContactByPhoneNumberService;
        }

        private async void Search_Click(object sender, EventArgs e)
        {
            await DisplayContactInDataGridView();
        }

        private async Task DisplayContactInDataGridView()
        {
            try
            {
                var contact = await _getContactByPhoneNumberService.GetContactBPhoneNumber(textBox1.Text);
                var r = dataGridView1.Rows.Count;

                dataGridView1.Rows[0].Cells["Surname"].Value = contact.Surname;
                dataGridView1.Rows[0].Cells["NameContact"].Value = contact.Name;
                dataGridView1.Rows[0].Cells["LastName"].Value = contact.LastName;
                dataGridView1.Rows[0].Cells["DateOfBirth"].Value = contact.DateOfBirth.Date.ToString();
                dataGridView1.Rows[0].Cells["Phone"].Value = contact.PhoneNumber;
                dataGridView1.Rows[0].Cells["City"].Value = contact.AdressContatDTO.City;
                dataGridView1.Rows[0].Cells["Street"].Value = contact.AdressContatDTO.Street;
                dataGridView1.Rows[0].Cells["NumberHome"].Value = contact.AdressContatDTO.HouseNumber;

            }
            catch (Exception)
            {
                throw;
            }
        }

        private void GetContactByPhoneNumberWindow_Load(object sender, EventArgs e)
        {

        }
    }
}
