using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class PopupBank : MonoBehaviour
{
    [SerializeField] private GameObject atm;
    [SerializeField] private GameObject depositBtn;
    [SerializeField] private GameObject withdrawBtn;

    private UserData userData;
    private void Start()
    {
        userData = GameManager.Instance.userData;
    }
    public void OnDepositBtn()
    {
        atm.gameObject.SetActive(false);
        depositBtn.gameObject.SetActive(true);
    }
    public void OnWithdrawBtn()
    {
        atm.gameObject.SetActive(false);
        withdrawBtn.gameObject.SetActive(true);
    }
    public void OnDepositBackBtn()
    {
        depositBtn.gameObject.SetActive(false);
        atm.gameObject.SetActive(true);
    }
    public void OnWithdrawBackBtn()
    {
        withdrawBtn.gameObject.SetActive(false);
        atm.gameObject.SetActive(true);
    }
    public void OnClickDeposit(int amount)
    {
        Debug.Log("OnClickDeposit");
        Debug.Log($"amount = {amount}");

        Debug.Log($"Cash = {userData.Cash}");
        Debug.Log($"Balance = {userData.Balance}");

        userData.DepositCash(amount);
    }
    public void OnClickWithdraw(int amount)
    {
        userData.WithdrawBalance(amount);
    }
}
