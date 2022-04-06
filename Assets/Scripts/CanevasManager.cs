using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class CanevasManager : MonoBehaviour
{
    public static int bestScore;

    private string bestScorer;

    [SerializeField] private GameObject text;
    // Start is called before the first frame update
    void Start()
    {
        LoadColor();

        text.GetComponent<Text>().text = bestScorer + " : " + bestScore;
    }
    
    public void LoadColor()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            MainManager.ScoreBoard data = JsonUtility.FromJson<MainManager.ScoreBoard>(json);

            bestScore = data.score;
            bestScorer = data.name;
        }
    }
}
