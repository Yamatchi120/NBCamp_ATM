public class WithdrawHandler : BaseHandler
{
    public override void OnOpen()
    {
        atm.gameObject.SetActive(false);
        withdrawBtn.gameObject.SetActive(true);
    }
    public override void OnBack()
    {
        withdrawBtn.gameObject.SetActive(false);
        atm.gameObject.SetActive(true);
    }
    public override void OnClickPreset(int amount)
    {
        if (userData.Balance < amount)
        {
            popupError.gameObject.SetActive(true);
            return;
        }

        userData.WithdrawBalance(amount);
        GameManager.Instance.OnClickBtn();
    }
    public override void OnClickCustom()
    {
        inputText = withdrawInputField.text.Trim();

        if (!int.TryParse(inputText, out inputAmount))
        {
            // Eng Error
            errorTitleTxt.text = "숫자만 입력해주세요.";
            popupError.gameObject.SetActive(true);
        }
        if (userData.Balance < inputAmount)
        {
            // Money Error
            popupError.gameObject.SetActive(true);
            return;
        }

        userData.WithdrawBalance(inputAmount);
        GameManager.Instance.OnClickBtn();
    }
}
