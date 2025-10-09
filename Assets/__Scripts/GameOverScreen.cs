using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class GameOverScreen : MonoBehaviour
{
    public string gameSceneName = "_Scene_0";
    public string menuSceneName = "_Main_Menu";
    public TextMeshProUGUI shotsTakenText;
    public Button startGameButton;
    public Button mainMenuButton;

    [Header("Hover Colors")]
    public Color normalColor = Color.white;
    public Color hoverColor = Color.red;
    public Color pressedColor = Color.gray;

    
    // Start is called before the first frame update
    void Start()
    {
        startGameButton.onClick.AddListener(StartGame);
        mainMenuButton.onClick.AddListener(MainMenu);

        SetupButtonColors(startGameButton);
        SetupButtonColors(mainMenuButton);

        int shots = MissionDemolition.LAST_SHOTS_TAKEN;
        shotsTakenText.text = "Shots Taken: " + shots;
    }


    public void StartGame()
    {
        SceneManager.LoadScene(gameSceneName);
    }


    public void MainMenu()
    {
        SceneManager.LoadScene(menuSceneName);
    }


    private void SetupButtonColors(Button button)
    {
        TextMeshProUGUI buttonText = button.GetComponentInChildren<TextMeshProUGUI>();

        if (buttonText != null)
        {
            button.targetGraphic = buttonText;
            ColorBlock cb = button.colors;
            cb.normalColor = normalColor;
            cb.highlightedColor = hoverColor;
            cb.pressedColor = pressedColor;
            button.colors = cb;

            button.transition = Selectable.Transition.ColorTint;
        }
    }


    /*
        // Update is called once per frame
        void Update()
        {
        
        }
    */
}
