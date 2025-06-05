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
            popupError.gameObject.SetActive(true);
            return;
        }

        userData.DepositCash(amount);
    }
    public override void OnClickCustom()
    {
        inputText = depositInputField.text.Trim();

        if (!int.TryParse(inputText, out inputAmount))
        {
            // Eng Error
            errorTitleTxt.text = "숫자만 입력해주세요.";
            popupError.gameObject.SetActive(true);
        }
        if (userData.Cash < inputAmount)
        {
            // Money Error
            popupError.gameObject.SetActive(true);
            return;
        }

        userData.DepositCash(inputAmount);
    }
}
