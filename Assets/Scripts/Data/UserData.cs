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

    // 계산로직 많아지거나, 복잡해지면 구조 분리
    public void DepositCash(int amount)
    {
        Cash -= amount;
        Balance += amount;
    }
    public void WithdrawBalance(int amount)
    {
        Balance -= amount;
        Cash += amount;
    }
}
