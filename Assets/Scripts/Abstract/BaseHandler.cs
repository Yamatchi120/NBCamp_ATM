using UnityEngine;
using UnityEngine.UI;

public abstract class BaseHandler : MonoBehaviour
{
    [SerializeField] protected GameObject atm;
    [SerializeField] protected GameObject depositBtn;
    [SerializeField] protected GameObject withdrawBtn;
    [SerializeField] public GameObject popupError;
                     
    [SerializeField] protected InputField depositInputField;
    [SerializeField] protected InputField withdrawInputField;
                     
    [SerializeField] protected Text errorTitleTxt;

    protected UserData userData;
    protected int inputAmount;
    protected string inputText;
    protected string error01 = "잔액이 부족합니다.";
    protected string error02 = "숫자만 입력해주세요.";
    protected void Awake()
    {
        userData = GameManager.Instance.UserData;
    }
    public virtual void OnOpen() { }
    public virtual void OnBack() { }
    public virtual void OnClickPreset(int amount) { }
    public virtual void OnClickCustom()
    {
        inputText = depositInputField.text.Trim();

        if (!int.TryParse(inputText, out inputAmount))
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
    }
    public virtual void ShowError(string error)
    {
        errorTitleTxt.text = error;
    }
}
