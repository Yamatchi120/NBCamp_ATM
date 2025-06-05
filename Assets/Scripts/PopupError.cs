using UnityEngine;

public class PopupError : MonoBehaviour
{
    private void Update()
    {
        BankServiceError();
    }
    void BankServiceError()
    {
        UserData userData = GameManager.Instance.userData;

        if(userData.Cash > userData.Balance ||
            userData.Balance > userData.Cash)
        {

        }
    }
}
