using Newtonsoft.Json;
using System.IO;
using UnityEngine;

public class DataStorage : MonoBehaviour
{
    public void Save(UserData data)
    {
        string savePath = Application.persistentDataPath + $"/{data.UserName}.json";
        string json = JsonConvert.SerializeObject(data, Formatting.Indented);
        File.WriteAllText(savePath, json);
        Debug.Log($"����: {savePath}");
        Debug.Log(json);
    }

    public UserData Load(string userName)
    {
        string savePath = Application.persistentDataPath + $"/{userName}.json";
        if (!File.Exists(savePath))
        {
            Debug.LogWarning("���� ���� ����");
            return null;
        }

        string json = File.ReadAllText(savePath);
        UserData data = JsonConvert.DeserializeObject<UserData>(json);
        Debug.Log($"�ε�: {savePath}");

        GameManager.Instance.OnClickBtn();
        return data;
    }
}
