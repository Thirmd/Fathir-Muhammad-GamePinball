using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuUIControl : MonoBehaviour
{
    public Button playbutton;
    public Button exitbutton;
    public Button creditbutton;

    private void Start() {
        playbutton.onClick.AddListener(PlayGame);
        exitbutton.onClick.AddListener(ExitGame);
        creditbutton.onClick.AddListener(Credit);
    }
    
    public void PlayGame(){
        SceneManager.LoadScene("FathirMuhammad_Pinball");
    }

    public void ExitGame(){
        Application.Quit();
    }

    public void Credit(){
        SceneManager.LoadScene("Credits");
    }

}
