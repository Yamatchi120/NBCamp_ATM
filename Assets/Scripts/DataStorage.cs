using Newtonsoft.Json;
using System.IO;
using UnityEngine;

public class DataStorage : MonoBehaviour
{
    private static string savePath = Application.persistentDataPath + $"/{GameManager.Instance.UserData.UserName}.json";

    public void Save()
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
