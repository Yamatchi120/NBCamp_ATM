using System;using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public event Action ClickSystem; // Subject

    public static GameManager Instance { get; private set; }
    public ATMHandlerBase ATMHandlerBase { get; private set; }
    public UserData UserData { get; private set; }
    public DataStorage DataStorage { get; private set; }

    [SerializeField] private InputField userNameInputField;
    [SerializeField] private InputField userIDInputField;
    [SerializeField] private InputField userPWInputField;

    private string userName;
    private string userID;
    private string userPW;
    [SerializeField] private int cash = 100000;
    [SerializeField] private int balance = 50000;

    private void Awake()
    {
        if (Instance == null) Instance = this;
        else Destroy(Instance);

    }
    private void Start()
    {
        userName = userNameInputField.text.Trim();
        userID = userIDInputField.text.Trim();
        userPW = userPWInputField.text.Trim();

        //UserData loaded = DataStorage.Load(userID);
        //if (loaded != null)
        //    UserData = loaded;
        //else
        UserData = new UserData(userID, userPW, userName, cash, balance);
        
    }
    public void OnClickBtn() // Subject
    {
        ClickSystem?.Invoke();
    }
}
