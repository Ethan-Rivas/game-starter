using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveGameSystem
{
    public static void SaveVolume(AudioSource music, AudioSource effects)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/volume.sins";

        FileStream stream = new FileStream(path, FileMode.Create);
   
        GameVolumeData volumeData = new GameVolumeData(music, effects);

        formatter.Serialize(stream, volumeData);
        stream.Close();
    }

    public static GameVolumeData LoadVolume()
    {
        string path = Application.persistentDataPath + "/volume.sins";

        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();

            FileStream stream = new FileStream(path, FileMode.Open);

            GameVolumeData volumeData = formatter.Deserialize(stream) as GameVolumeData;
            stream.Close();

            return volumeData;
        } else {
            Debug.LogError("Data file not found in: " + path);
            return null;
        }
    }
}
