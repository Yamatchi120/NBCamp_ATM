using UnityEngine;
using UnityEngine.UI;

public abstract class BaseHandler : MonoBehaviour
{
    [SerializeField] protected GameObject atm;
    [SerializeField] protected GameObject depositBtn;
    [SerializeField] protected GameObject withdrawBtn;
    [SerializeField] protected GameObject popupError;
                     
    [SerializeField] protected InputField depositInputField;
    [SerializeField] protected InputField withdrawInputField;
                     
    [SerializeField] protected Text errorTitleTxt;

    protected UserData userData;
    protected int inputAmount;
    protected string inputText;
    protected void Start()
    {
        userData = GameManager.Instance.userData;
    }
    public virtual void OnOpen() { }
    public virtual void OnBack() { }
    public virtual void OnClickPreset(int amount) { }
    public virtual void OnClickCustom() { }
}
