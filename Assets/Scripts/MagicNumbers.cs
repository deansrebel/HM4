using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicNumbers : MonoBehaviour
{
    #region Variables

    [SerializeField] private int _max = 1000;
    [SerializeField] private int _min = 500;

    private int _guess;
    private int _guessCount;

    #endregion

    #region Unity lifecycle

    private void Start()
    {
        Debug.Log($"Привет! Я Magic Numbers. Загадай число от {_min} до {_max}");

        CalculateGuessAndLog();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            _max = _guess;
            CalculateGuessAndLog();
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            _min = _guess;
            CalculateGuessAndLog();
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log($"Ура! Твое число отгадано и равно {_guess}! Число затраченных ходов: {_guessCount}.");
            Start();
        }
    }

    #endregion

    #region Private methods

    private void CalculateGuessAndLog()
    {
        _guess = (_max + _min) / 2;
        _guessCount++;
        Debug.Log($"Твое число равно: {_guess}?");
    }

    #endregion
}
