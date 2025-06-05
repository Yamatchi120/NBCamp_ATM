using UnityEngine;
public class ApplyHandler : MonoBehaviour
{
    public void OnApply()
    {
        GameManager.Instance.BaseHandler.popupError.gameObject.SetActive(false);
    }
}
