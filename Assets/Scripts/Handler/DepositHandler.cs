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
        GameManager.Instance.OnClickBtn();
    }
    public override void OnClickCustom()
    {
        inputText = depositInputField.text.Trim();

        if (!int.TryParse(inputText, out inputAmount))
        {
            // Eng Error
            errorTitleTxt.text = "���ڸ� �Է����ּ���.";
            popupError.gameObject.SetActive(true);
        }
        if (userData.Cash < inputAmount)
        {
            // Money Error
            errorTitleTxt.text = "�ܾ��� �����մϴ�.";
            popupError.gameObject.SetActive(true);
            return;
        }

        userData.DepositCash(inputAmount);
        GameManager.Instance.OnClickBtn();
    }
}
