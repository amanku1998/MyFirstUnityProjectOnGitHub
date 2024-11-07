using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainSceneManager : MonoBehaviour
{
    public Button button_1, button_2, button_3;

    public string firstSceneName, secondSceneName, thirdSceneName;
    // Start is called before the first frame update
    void Start()
    {
        button_1.onClick.AddListener(() => OnButtonClick(firstSceneName));
        button_2.onClick.AddListener(() => OnButtonClick(secondSceneName));
        button_3.onClick.AddListener(() => OnButtonClick(thirdSceneName));
    }
    //
    private void OnButtonClick(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

}
