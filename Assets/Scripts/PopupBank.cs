using Unity.Burst.Intrinsics;
using UnityEngine;
using UnityEngine.UI;

public class PopupBank : MonoBehaviour
{
    [SerializeField] private GameObject atm;
    [SerializeField] private GameObject depositBtn;
    [SerializeField] private GameObject withdrawBtn;

    public void OnDepositBtn()
    {
        atm.gameObject.SetActive(false);

        depositBtn.gameObject.SetActive(true);
    }
    public void OnWithdrawBtn()
    {
        atm.gameObject.SetActive(false);

        withdrawBtn.gameObject.SetActive(true);
    }
}
