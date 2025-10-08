using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class MainMenuScreen : MonoBehaviour
{
    public string gameSceneName = "_Scene_0";
    public TextMeshProUGUI MissionDemolition;
    public Button startGameButton;
    public Button quitGameButton;

    [Header("Hover Colors")]
    public Color normalColor = Color.white;
    public Color hoverColor = Color.red;
    public Color pressedColor = Color.gray;


    // Start is called before the first frame update
    void Start()
    {
        startGameButton.onClick.AddListener(StartGame);
        quitGameButton.onClick.AddListener(QuitGame);

        SetupButtonColors(startGameButton);
        SetupButtonColors(quitGameButton);
    }


    public void StartGame()
    {
        SceneManager.LoadScene(gameSceneName);
    }


    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit Game!");
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
