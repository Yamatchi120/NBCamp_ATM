using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private Text userNameTxt;
    [SerializeField] private Text balanceTxt;
    [SerializeField] private Text cashTxt;

    UserData Data = GameManager.Instance.userData;
    private void Start()
    {
        Init();
    }
    private void Update()
    {

    }
    void Init()
    {
        userNameTxt.text = Data.UserName;
        cashTxt.text = Data.Cash.ToString();
        balanceTxt.text = Data.Balance.ToString();
    }
}
