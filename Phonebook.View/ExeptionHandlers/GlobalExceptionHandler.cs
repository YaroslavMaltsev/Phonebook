namespace Phonebook.View.ExeptionHandlers
{
    public static class GlobalExceptionHandler
    {
        public static void HandleException(object sender, UnhandledExceptionEventArgs e)
        {
            try
            {
                Exception ex = (Exception)e.ExceptionObject;
                if (ex is ArgumentNullException argumentNullException)
                {
                    MessageError(argumentNullException.Message);
                }
                else
                {
                    MessageError(ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageError(ex.Message);
            }

        }
        public static void MessageError(string mesages)
        {
          MessageBox.Show("Произошла ошибка",mesages, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
