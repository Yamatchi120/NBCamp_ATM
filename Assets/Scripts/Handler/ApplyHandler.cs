using UnityEngine;
public class ApplyHandler : MonoBehaviour
{
    // 추후 ApplyHandler.cs가 아닌 다른cs로 바뀔 확률 높음
    [SerializeField] public GameObject popupError;
    public void OnApply()
    {
        popupError.gameObject.SetActive(false);
    }
}
