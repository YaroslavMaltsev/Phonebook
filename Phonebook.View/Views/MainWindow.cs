namespace Phonebook.View.Views
{
    public partial class MainWindow : Form
    {
        private readonly GetContactByPhoneNumberWindow _getContactByPhoneNumberWindow;
        private readonly PasteContactDetailsWindow _pasteContactDetailsWindow;

        public MainWindow(GetContactByPhoneNumberWindow getContactByPhoneNumberWindow,
          PasteContactDetailsWindow pasteContactDetailsWindow)
        {
            InitializeComponent();
            _getContactByPhoneNumberWindow = getContactByPhoneNumberWindow;
            _pasteContactDetailsWindow = pasteContactDetailsWindow;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            _pasteContactDetailsWindow.Show();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            _getContactByPhoneNumberWindow.Show();
        }
    }
}
