using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private Text userNameTxt;
    [SerializeField] private Text balanceTxt;
    [SerializeField] private Text cashTxt;

    private void OnEnable() // 구독 추가
    {
        //GameManager.OnUserDataChange += 
    }

    private void OnDisable() // 구독 해지
    {
        //GameManager.OnUserDataChange -= 
    }
}
