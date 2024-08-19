using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartGame : MonoBehaviour
{
    #region Variables

    [SerializeField] private Button _startButton;
    [SerializeField] private Button _exitButton;
    [SerializeField] private TextMeshProUGUI _startText;

    #endregion

    #region Unity lifecycle

    private void Start()
    {
        _startText.text =
            "Привет! Я Magic Numbers. Тебе нужно будет загадать число, а я попробую его угадать. Тебе потребуется только нажимать на кнопки :) \n Ну что, ты готов?";
        _startButton.onClick.AddListener(EnterGame);
        _exitButton.onClick.AddListener(ExitGame);
    }

    #endregion

    #region Private methods

    private void EnterGame()
    {
        SceneManager.LoadScene("GameScene");
    }

    private void ExitGame()
    {
        SceneManager.LoadScene("ExitGame");
    }

    #endregion
}