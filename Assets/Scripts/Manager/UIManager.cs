using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private Text userNameTxt;
    [SerializeField] private Text balanceTxt;
    [SerializeField] private Text cashTxt;

    private void OnEnable() // ���� �߰�
    {
        //GameManager.OnUserDataChange += 
    }

    private void OnDisable() // ���� ����
    {
        //GameManager.OnUserDataChange -= 
    }
}
