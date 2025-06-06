using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameManager observedTarget;
    [SerializeField] private Text userNameTxt;
    [SerializeField] private Text balanceTxt;
    [SerializeField] private Text cashTxt;

    GameManager gm;

    public void Init()
    {
        userNameTxt.text = GameManager.Instance.UserData.UserName;
        cashTxt.text = GameManager.Instance.UserData.Cash.ToString("N0");
        balanceTxt.text = GameManager.Instance.UserData.Balance.ToString("N0");
    }

    private void OnEnable() // Observer+
    {
        gm = GameManager.Instance;
        gm.ClickSystem += Init;
    }
    private void OnDisable() // Observer-
    {
        gm.ClickSystem -= Init;
    }
    private void Start()
    {
        Init();
    }
}
