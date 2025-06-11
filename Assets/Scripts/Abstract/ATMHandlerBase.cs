using UnityEngine;
using UnityEngine.UI;

public abstract class ATMHandlerBase : MonoBehaviour
{
    [SerializeField] protected GameObject atm;
    [SerializeField] protected GameObject depositBtn;
    [SerializeField] protected GameObject withdrawBtn;
    [SerializeField] public GameObject popupError;

    [SerializeField] protected InputField depositInputField;
    [SerializeField] protected InputField withdrawInputField;
                     
    [SerializeField] protected Text errorTitleTxt;

    protected ErrorHandler errorHandler;
    protected UserData userData;
    protected int inputAmount;
    protected string inputText;
    protected string error01 = "�ܾ��� �����մϴ�.";
    protected string error02 = "���ڸ� �Է����ּ���.";
    protected void Awake()
    {
        userData = GameManager.Instance.UserData;
    }
    public virtual void OnOpen() { }
    public virtual void OnBack() { }
    public virtual void OnClickPreset(int amount) { }
    public virtual void OnClickCustom() { }
    public virtual void ShowError(string error)
    {
        errorTitleTxt.text = error;
    }
}
