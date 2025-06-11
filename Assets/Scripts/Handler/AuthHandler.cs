using UnityEngine;
using UnityEngine.UI;
public class AuthHandler : MonoBehaviour
{
    [SerializeField] public GameObject popupLogin;
    [SerializeField] public GameObject popupSignUp;
    [SerializeField] public GameObject popupError;
    [SerializeField] private InputField userNameInputField;
    [SerializeField] private InputField userIDInputField;
    [SerializeField] private InputField userPWInputField;

    GameManager gm = GameManager.Instance;

    public void OnApply()
    {
        popupError.gameObject.SetActive(false);
    }
    public void OnLogin()
    {
        // id pw != null
        // input id pw == json id pw - true - login
        // false - errorcode
    }
    public void OnOpenSignUp()
    {
        popupLogin.SetActive(false);
        popupSignUp.SetActive(true);
    }
    public void OnCloseSignUp()
    {
        popupSignUp.SetActive(false);
        popupLogin.SetActive(true);
    }
    public void OnSignUp()
    {
        gm.userName = userNameInputField.text.Trim();
        gm.userID = userIDInputField.text.Trim();
        gm.userPW = userPWInputField.text.Trim();

        //UserData = new UserData(gm.userName, gm.userID, gm.userPW, gm.cash, gm.balance);

        gm.DataStorage.Save(gm.UserData);
    }
}
