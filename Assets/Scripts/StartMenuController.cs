using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartMenuController : MonoBehaviour
{
    public static StartMenuController Instance;
    [SerializeField] private Button startButton;

    [SerializeField] private InputField inputField; 
    public static string user = " ";
    public int sc;
    
    private void Awake()
    {

        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
        LoadColor();
    }
    
    // Start is called before the first frame update
    void Start()
    {
        startButton.onClick.AddListener(SaveColo);
    }
    
    [System.Serializable]
    public class USernae
    {
        public string username;
    }
    
    public void SaveColo()
    {
        user = inputField.text;
        USernae data = new USernae();
        data.username = user;

        string json = JsonUtility.ToJson(data);
  
        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }
    
    public void LoadColor()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            USernae data = JsonUtility.FromJson<USernae>(json);
            
            user = data.username;
        }
    }
    
}
