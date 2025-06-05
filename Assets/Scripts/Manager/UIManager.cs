using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private Text userNameTxt;
    [SerializeField] private Text balanceTxt;
    [SerializeField] private Text cashTxt;

    UserData data;
    private void Start()
    {
        data = GameManager.Instance.userData;
    }
    private void Update()
    {
        Init();
    }
    void Init()
    {

        userNameTxt.text = data.UserName;
        cashTxt.text = data.Cash.ToString("N0");
        balanceTxt.text = data.Balance.ToString("N0");
    }
}
