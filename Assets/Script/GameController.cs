using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public Button backButton;

    public string mainScene;
    // Start is called before the first frame update
    void Start()
    {
        backButton.onClick.AddListener(OnButtonClick);
    }

    private void OnButtonClick()
    {
        Debug.Log("Load mainScene");
        SceneManager.LoadScene(mainScene);
    }
}
