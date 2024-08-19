using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class WinGame : MonoBehaviour
{
    #region Variables

    [SerializeField] private Button _playAgainButton;
    [SerializeField] private Button _exitButton;
    [SerializeField] private TMP_Text _winText;

    #endregion

    #region Unity lifecycle

    private void Start()
    {
        _winText.text = $"Ура! Победа! \n Твое число отгадано и равно: {MagicNumbers._guess}! Число затраченных ходов: {MagicNumbers.GuessCount}.";
        _playAgainButton.onClick.AddListener(PlayAgain);
        _exitButton.onClick.AddListener(ExitGame);
    }

    #endregion

    #region Private methods

    private void ExitGame()
    {
        SceneManager.LoadScene("ExitGame");
    }

    private void PlayAgain()
    {
        SceneManager.LoadScene("StartScene");
    }

    #endregion
}