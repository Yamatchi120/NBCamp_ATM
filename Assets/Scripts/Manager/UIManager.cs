using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private Text userNameTxt;
    [SerializeField] private Text balanceTxt;
    [SerializeField] private Text cashTxt;

    private void Start()
    {
        Init();
    }
    private void Update()
    {

    }
    void Init()
    {
        UserData Data = GameManager.Instance.userData;

        userNameTxt.text = Data.UserName;
        cashTxt.text = Data.Cash.ToString();
        balanceTxt.text = Data.Balance.ToString();
    }
}
