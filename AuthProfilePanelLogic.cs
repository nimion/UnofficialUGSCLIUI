namespace UnofficialUGSCLIUI
{
    public class AuthProfilePanelLogic
    {
        private frmUGSCLIUI _mainFormView = null;

        public AuthProfilePanelLogic(frmUGSCLIUI mainFormView)
        {
            _mainFormView = mainFormView;
            _mainFormView.OnUseAuthProfileClicked += HandleOnUseAuthClicked;
            _mainFormView.OnEditAuthProfileClicked += HandleOnEditAuthProfileClicked;
            _mainFormView.OnDeleteAuthProfileClicked += HandleOnDeleteAuthProfileClicked;
            _mainFormView.OnCreateAuthProfileClicked += HandleOnCreateAuthProfileClicked;
        }

        private void HandleOnUseAuthClicked(int selectedEntryIndex)
        {

        }

        private void HandleOnEditAuthProfileClicked(int selectedEntryIndex)
        {

        }

        private void HandleOnDeleteAuthProfileClicked(int selectedEntryIndex)
        {

        }
        private void HandleOnCreateAuthProfileClicked(string name, string key, string secret)
        {
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Friendly Name cannot be empty.", "Name Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (string.IsNullOrEmpty(key) || UserInputValidators.IsValidId(key) == false)
            {
                MessageBox.Show("Account Key is an invalid format.", "Account Key Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (string.IsNullOrEmpty(secret) || secret.Length != 32)
            {
                MessageBox.Show("Account Secret is an invalid format.", "Account Key Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}