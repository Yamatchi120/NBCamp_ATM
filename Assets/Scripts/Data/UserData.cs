[System.Serializable]
public class UserData
{
    //private static string savePath = Application.persistentDataPath + "/userdata.json";

    private string userID;
    public string UserID { get; private set; }
    private string userPW;
    public string UserPW { get; private set; }
    private string userName;
    public string UserName { get; private set; }
    private int cash;
    public int Cash { get; private set; }
    private int balance;
    public int Balance { get; private set; }

    public UserData(string userID, string userPW, string userName, int cash, int balance)
    {
        UserID = userID;
        UserPW = userPW;
        UserName = userName;
        Cash = cash;
        Balance = balance;
    }

    // 계산로직 많아지거나, 복잡해지면 구조 분리
    public void DepositCash(int amount)
    {
        Cash -= amount;
        Balance += amount;
        GameManager.Instance.DataStorage.Save(this);
    }
    public void WithdrawBalance(int amount)
    {
        Balance -= amount;
        Cash += amount;
        GameManager.Instance.DataStorage.Save(GameManager.Instance.UserData);
    }
}
