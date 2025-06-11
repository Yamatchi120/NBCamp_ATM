using UnityEngine;
public class AuthHandler : MonoBehaviour
{
    [SerializeField] public GameObject popupLogin;
    [SerializeField] public GameObject popupSignUp;
    [SerializeField] public GameObject popupError;

    private GameManager gm;
    private UserData data;
    private void Awake()
    {
        gm = GameManager.Instance;
    }
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
        data = new UserData(gm.userID, userData.UserPW, userData.UserName, userData.Cash, userData.Balance);
        gm.DataStorage.Save(GameManager.Instance.UserData);
    }
}
