using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MagicNumbers : MonoBehaviour
{
    #region Variables

    [SerializeField] private int _max = 1000;
    [SerializeField] private int _min = 500;
    [SerializeField] private TextMeshProUGUI _taskText;

    [SerializeField] private TextMeshProUGUI _guessText;

    [SerializeField] private Button _higherButton;
    [SerializeField] private Button _lowerButton;
    [SerializeField] private Button _correctButton;

    public static int _guess;

    #endregion

    #region Properties

    public static int GuessCount { get; private set; }

    #endregion

    #region Unity lifecycle

    private void Start()
    {
        StartGame();
        _lowerButton.onClick.AddListener(LowNumber);
        _higherButton.onClick.AddListener(HighNumber);
        _correctButton.onClick.AddListener(CorrectAnswer);
        GuessCount = 0;
    }

    #endregion

    #region Private methods

    private void CalculateGuessAndLog()
    {
        _guess = (_max + _min) / 2;
        GuessCount++;
        _guessText.text = $"Твое число равно: {_guess}?";
    }

    private void CorrectAnswer()
    {
        SceneManager.LoadScene("WinScene");
    }

    private void HighNumber()
    {
        _min = _guess;
        CalculateGuessAndLog();
    }

    private void LowNumber()
    {
        _max = _guess;
        CalculateGuessAndLog();
    }

    private void StartGame()
    {
        _taskText.text = $"Привет! Я Magic Numbers. Загадай число от {_min} до {_max}";
        CalculateGuessAndLog();
    }

    #endregion
}