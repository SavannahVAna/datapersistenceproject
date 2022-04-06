using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartGame : MonoBehaviour
{
    [SerializeField] private Button arg;
    // Start is called before the first frame update
    void Start()
    {
        arg.onClick.AddListener(ChangeScene);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void ChangeScene()
    {
        SceneManager.LoadScene(1);
    }
}
