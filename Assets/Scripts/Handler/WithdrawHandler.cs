using System.Diagnostics;

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
            ShowError(error01);
            popupError.gameObject.SetActive(true);
            return;
        }

        userData.WithdrawBalance(amount);
        GameManager.Instance.OnClickBtn();
    }
    public override void OnClickCustom()
    {
        base.OnClickCustom();

        userData.WithdrawBalance(inputAmount);
        GameManager.Instance.OnClickBtn();
    }
}
