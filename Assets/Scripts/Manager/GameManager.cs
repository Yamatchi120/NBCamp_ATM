using System;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public static event Action OnUserDataChange;

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

    public void DataChange()
    {
        OnUserDataChange?.Invoke(); // ¹æ¼Û
    }
}
