public interface IDepositChange
{
    void OnDepositCash(int amount) { }
    void OnDepositBalance(int amount) { }
}
