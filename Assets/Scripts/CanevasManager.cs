using System.Collections;
using System.Collections.Generic;
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
        try
        {
            bestScore = PlayerPrefs.GetInt("Score");
            bestScorer = PlayerPrefs.GetString("Best");
        }
        catch
        {
            bestScore = 0;
            bestScorer = "_____";
        }

        text.GetComponent<Text>().text = bestScorer + " : " + bestScore;
    }
}
