public class DepositHandler : BaseHandler
{
    public override void OnOpen()
    {
        atm.gameObject.SetActive(false);
        depositBtn.gameObject.SetActive(true);
    }
    public override void OnBack()
    {
        depositBtn.gameObject.SetActive(false);
        atm.gameObject.SetActive(true);
    }
    public override void OnClickPreset(int amount)
    {
        if (userData.Cash < amount)
        {
            ShowError(error01);
            popupError.gameObject.SetActive(true);
            return;
        }

        userData.DepositCash(amount);
        GameManager.Instance.OnClickBtn();
    }
    public override void OnClickCustom()
    {
        inputText = depositInputField.text.Trim();

        bool num = int.TryParse(inputText, out inputAmount);
        if (!num || inputAmount <= 0)
        {
            // Eng Error
            ShowError(error02);
            popupError.gameObject.SetActive(true);
            return;
        }
        if (userData.Cash < inputAmount)
        {
            // Money Error
            ShowError(error01);
            popupError.gameObject.SetActive(true);
            return;
        }

        userData.DepositCash(inputAmount);
        GameManager.Instance.OnClickBtn();
    }
}
