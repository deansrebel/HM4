using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartGame : MonoBehaviour
{
    #region Variables

    [SerializeField] private Button _startButton;
    [SerializeField] private Button _exitButton;

    #endregion

    #region Unity lifecycle

    private void Start()
    {
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