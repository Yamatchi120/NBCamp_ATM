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
        Debug.Log($"저장: {savePath}");
        Debug.Log(json);
    }

    public UserData Load(string userName)
    {
        string savePath = Application.persistentDataPath + $"/{userName}.json";
        if (!File.Exists(savePath))
        {
            Debug.LogWarning("저장 파일 없음");
            return null;
        }

        string json = File.ReadAllText(savePath);
        UserData data = JsonConvert.DeserializeObject<UserData>(json);
        Debug.Log($"로드: {savePath}");

        GameManager.Instance.OnClickBtn();
        return data;
    }
}
