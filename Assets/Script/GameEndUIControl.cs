using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameEndUIControl : MonoBehaviour
{
    public Button mainmenubutton;

    private void Start() {
        mainmenubutton.onClick.AddListener(MainMenu);
    }

    private void MainMenu(){
        SceneManager.LoadScene("MainMenu");
    }
}
