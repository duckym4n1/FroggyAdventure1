using System.IO;
using UnityEngine;

public static class SaveSystem
{
    private static string savePath = Path.Combine(Application.persistentDataPath, "savefile.json");

    public static void SaveProgress(PlayerData playerData)
    {
        string json = JsonUtility.ToJson(playerData);
        File.WriteAllText(savePath, json);
        Debug.Log($"✅ Progress saved to: {savePath}");
    }

    public static PlayerData LoadProgress()
    {
        if(File.Exists(savePath))
        {
            string json = File.ReadAllText(savePath);
            PlayerData playerData = JsonUtility.FromJson<PlayerData>(json);
            Debug.Log("✅ Progress loaded successfully.");
            return playerData;
        }
        else
        {
            Debug.LogWarning("⚠️ No save file found. Returning default PlayerData.");
            return new PlayerData { level = 1, exp =0 };
        }
    }
}
