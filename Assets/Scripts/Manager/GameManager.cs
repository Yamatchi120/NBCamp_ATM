using System;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public event Action ClickSystem; // Subject
    public static GameManager Instance { get; private set; }
    public BaseHandler BaseHandler { get; private set; }
    public UserData UserData { get; private set; }

    [SerializeField] private string userName = "¼ÛÄ¡¿õ";
    [SerializeField] private int cash = 100000;
    [SerializeField] private int balance = 50000;

    private void Awake()
    {
        if (Instance == null) Instance = this;
        else Destroy(Instance);

        UserData loaded = UserData.Load();
        if (loaded != null)
            UserData = loaded;
        else
            UserData = new UserData(userName, cash, balance);
    }

    public void OnClickBtn()
    {
        ClickSystem?.Invoke();
    }
}
