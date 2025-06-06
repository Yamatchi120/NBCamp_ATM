using System.Diagnostics;
using UnityEngine;

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
        base.OnClickCustom();

        userData.DepositCash(inputAmount);
        GameManager.Instance.OnClickBtn();
    }
}
