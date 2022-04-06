using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartMenuController : MonoBehaviour
{
    [SerializeField] private Button startButton;

    [SerializeField] private GameObject inputField; 
    public static string username = " ";
    
    // Start is called before the first frame update
    void Start()
    {
      startButton.onClick.AddListener(ClaimName);
    }

    private void ClaimName()
    {
        username = inputField.GetComponent<InputField>().text;
        PlayerPrefs.SetString("name",username);
        PlayerPrefs.Save();
        SceneManager.LoadScene(1);
    }
}
