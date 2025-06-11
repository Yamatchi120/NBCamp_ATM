using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using UnityEngine.UI;

public class ErrorHandler : MonoBehaviour
{
    [SerializeField] private GameObject popupError;
    [SerializeField] private Text errorTitleTxt;

    UserData data = GameManager.Instance.UserData;

    string error01 = "�ܾ��� �����մϴ�.";
    string error02 = "���ڸ� �Է����ּ���.";


    public void ShowEngError(string input)
    {
        bool num = int.TryParse(input, out int amount);

        if (!num)
        {
            // Eng Error
            ShowError(error02);
            popupError.gameObject.SetActive(true);
            return;
        }
        if (data.Cash < amount)
        {
            // Money Error
            ShowError(error01);
            popupError.gameObject.SetActive(true);
            return;
        }
    }
    public void ShowMoneyError(int amount)
    {
        if (data.Cash < amount)
        {
            // Money Error
            ShowError(error01);
            popupError.gameObject.SetActive(true);
            return;
        }

    }
    public virtual void ShowError(string error)
    {
        errorTitleTxt.text = error;
    }
}
