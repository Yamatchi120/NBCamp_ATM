using UnityEngine;
public class ApplyHandler : MonoBehaviour
{
    [SerializeField] public GameObject popupError;
    public void OnApply()
    {
        popupError.gameObject.SetActive(false);
    }
}
