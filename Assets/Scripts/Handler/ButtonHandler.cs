using UnityEngine;
public class ButtonHandler : MonoBehaviour
{
    [SerializeField] public GameObject popupLogin;
    [SerializeField] public GameObject popupSignUp;
    [SerializeField] public GameObject popupError;

    public void OnApply()
    {
        popupError.gameObject.SetActive(false);
    }
    public void OnCloseSignUp()
    {
        popupSignUp.SetActive(false);
        popupLogin.SetActive(true);
    }
    public void OnLogin()
    {
        // id pw != null
        // json save
    }
    public void OnOpenSignUp()
    {
        popupLogin.SetActive(false);
        popupSignUp.SetActive(true);
    }
}
