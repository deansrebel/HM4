using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ExitGame : MonoBehaviour
{
    #region Variables

    [SerializeField] private Button _startButton;

    #endregion

    #region Unity lifecycle

    private void Start()
    {
        _startButton.onClick.AddListener(EnterGame);
    }

    #endregion

    #region Private methods

    private void EnterGame()
    {
        SceneManager.LoadScene("GameScene");
    }

    #endregion
}