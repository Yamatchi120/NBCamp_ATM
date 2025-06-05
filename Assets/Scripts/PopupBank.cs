using UnityEngine;
using UnityEngine.UI;

public class PopupBank : MonoBehaviour
{
    [SerializeField] private GameObject atm;
    [SerializeField] private GameObject depositBtn;
    [SerializeField] private GameObject withdrawBtn;
    [SerializeField] private GameObject popupError;
    [SerializeField] private InputField depositInputField;
    [SerializeField] private InputField withdrawInputField;
    [SerializeField] private Text errorTxt;

    private UserData userData;
    int inputAmount;
    string inputText;
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
        if(userData.Cash < amount)
        {
            popupError.gameObject.SetActive(true);
            return;
        }

        userData.DepositCash(amount);
    }
    public void OnClickWithdraw(int amount)
    {
        if (userData.Balance < amount)
        {
            popupError.gameObject.SetActive(true);
            return;
        }

        userData.WithdrawBalance(amount);
    }

    public void OnApplyBtn()
    {
        popupError.gameObject.SetActive(false);
    }
    public void OnDepositCustomBtn()
    {
        inputText = depositInputField.text.Trim();

        if (!int.TryParse(inputText, out inputAmount))
        {
            // Eng Error
            errorTxt.text = "숫자만 입력해주세요.";
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

    public void OnWithdrawCustomBtn()
    {
        inputText = withdrawInputField.text.Trim();

        if (!int.TryParse(inputText, out inputAmount))
        {
            // Eng Error
            errorTxt.text = "숫자만 입력해주세요.";
            popupError.gameObject.SetActive(true);
        }
        if (userData.Balance < inputAmount)
        {
            // Money Error
            popupError.gameObject.SetActive(true);
            return;
        }

        userData.WithdrawBalance(inputAmount);
    }
}
