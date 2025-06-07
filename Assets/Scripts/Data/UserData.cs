using Newtonsoft.Json;
using System.IO;
using Unity.VisualScripting;
using UnityEngine;

[System.Serializable]
public class UserData
{
    private static string savePath = Application.persistentDataPath + "/userdata.json";
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
        Save();
    }
    public void WithdrawBalance(int amount)
    {
        Balance -= amount;
        Cash += amount;
        Save();
    }

    void Save()
    {
        string json = JsonConvert.SerializeObject(this, Formatting.Indented);
        File.WriteAllText(savePath, json);
        UnityEngine.Debug.Log($"저장: {savePath}");
        Debug.Log(json);
    }

    public static UserData Load()
    {
        if (!File.Exists(savePath))
        {
            UnityEngine.Debug.LogWarning("저장 파일 없음");
            return null;
        }

        string json = File.ReadAllText(savePath);
        UserData data = JsonConvert.DeserializeObject<UserData>(json);
        UnityEngine.Debug.Log($"로드: {savePath}");

        GameManager.Instance.OnClickBtn();
        return data;
    }
}
