using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameManager observedTarget;
    //[SerializeField] private Text userNameTxt;
    //[SerializeField] private Text balanceTxt;
    //[SerializeField] private Text cashTxt;

    private void Update()
    {
        //Init();
    }
    //void Init()
    //{
    //    userNameTxt.text = GameManager.Instance.userData.UserName;
    //    cashTxt.text = GameManager.Instance.userData.Cash.ToString("N0");
    //    balanceTxt.text = GameManager.Instance.userData.Balance.ToString("N0");
    //}

    private void OnEnable() // 구독 등록
    {
        //observedTarget +=
    }
    private void OnDisable() // 구독 해지
    {
        //observedTarget -=
    }

}
