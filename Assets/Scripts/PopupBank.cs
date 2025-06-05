using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class PopupBank : MonoBehaviour
{
    [SerializeField] private GameObject atm;
    [SerializeField] private GameObject depositBtn;
    [SerializeField] private GameObject withdrawBtn;
    [SerializeField] private TMP_InputField inputField;

    private UserData userData;
    int inputAmount;
    string userCustom;
    private void Start()
    {
        userCustom = inputField.text;
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
        userData.DepositCash(amount);
    }
    public void OnClickWithdraw(int amount)
    {
        userData.WithdrawBalance(amount);
    }
    public void OnDepositCustomBtn()
    {
        InputAmount();
        userData.DepositCash(inputAmount);
    }
    public void OnWithdrawCustomBtn()
    {
        InputAmount();
        userData.WithdrawBalance(inputAmount);
    }
    private void InputAmount()
    {

        if(int.TryParse(userCustom, out inputAmount))
        {
            Debug.Log($"입력된 숫자 -> {inputAmount}");
        }
        else { Debug.LogWarning("숫자가 아닙니다."); }
    }
}
