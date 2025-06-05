using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    public UserData userData { get; private set; }


    [SerializeField] private string userName = "¼ÛÄ¡¿õ";
    [SerializeField] private int cash = 100000;
    [SerializeField] private int balance = 50000;

    private void Awake()
    {
        if (Instance == null) Instance = this;
        else Destroy(Instance);

        userData = new UserData(userName, cash, balance);
    }
}
