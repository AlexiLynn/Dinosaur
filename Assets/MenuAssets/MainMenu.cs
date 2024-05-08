using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public string NewGameScene;
    public string CreditsScene;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartButton(){
        SceneManager.LoadScene(NewGameScene);
    }

    public void CreditsButton(){
        SceneManager.LoadScene(CreditsScene);
    }

}
