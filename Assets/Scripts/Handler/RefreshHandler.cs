using UnityEngine;
using UnityEngine.UI;

public class RefreshHandler : MonoBehaviour
{
    [SerializeField] private Text userNameTxt;
    [SerializeField] private Text balanceTxt;
    [SerializeField] private Text cashTxt;

    public void OnRefresh()
    {
        userNameTxt.text = GameManager.Instance.userData.UserName;
        cashTxt.text = GameManager.Instance.userData.Cash.ToString("N0");
        balanceTxt.text = GameManager.Instance.userData.Balance.ToString("N0");
    }
}
