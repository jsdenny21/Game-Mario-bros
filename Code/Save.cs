using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
public static class SaveScript
{
    public static void SaveData(PlayerProgress player)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/data3.bin";
        FileStream stream = new FileStream(path, FileMode.Create);
        SavePRogress data = new SavePRogress(player);
        formatter.Serialize(stream, data);
        stream.Close();
    }
    public static SavePRogress LoadData()
    {
        string path = Application.persistentDataPath + "/data3.bin";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);
            formatter.Deserialize(stream);
            SavePRogress data = formatter.Deserialize(stream) as SavePRogress;
            stream.Close();
            return data;
        }
        else
        {
            Debug.Log("File not found");
            return null;
        }
    }
}