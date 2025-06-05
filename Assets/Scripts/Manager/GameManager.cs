using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    [SerializeField] private string userName = "¼ÛÄ¡¿õ";
    [SerializeField] private int cash = 100000;
    [SerializeField] private int balance = 50000;

    public UserData userData;

    private void Awake()
    {
        if (Instance == null) Instance = this;
        else Destroy(Instance);

        userData = new UserData(userName, cash, balance);
    }
}
