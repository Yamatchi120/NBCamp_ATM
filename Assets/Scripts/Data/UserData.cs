[System.Serializable]
public class UserData
{
    private string userName;
    public string UserName { get; private set; }
    private int cash;
    public int Cash { get; private set; }
    private int balance;
    public int Balance { get; private set; }

    public UserData(string userName, int cash, int balance)
    {
        UserName = userName;
        Cash = cash;
        Balance = balance;
    }
}
