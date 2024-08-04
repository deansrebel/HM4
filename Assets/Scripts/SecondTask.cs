using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    #region Unity lifecycle

    [SerializeField] private int _max = 9;
    [SerializeField] private int _min = 1;
    private int _goal = 50;
    private int _guess;
    private int _sum;
    
    private void Start()
    {
        Debug.Log($"Пиши числа от {_min} до {_max}");
    }

    // Update is called once per frame
    private void Update()
    {
        for (int i = 1; i <= 9;)
        {
            if(Input.GetKeyDown(i.ToString()))
            {
                Sum(i);
            }
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Start();
        }
    }
    
    #endregion

    private void Sum(int number)
    {
        _sum += number;
        _guess++;
        Debug.Log($"Сумма: {_sum}");

        if (_sum >= _goal)
        {
            Debug.Log($"Сумма: {_goal}");
            Debug.Log($"Игра окончена! Количество ходов: {_guess}");
            Start();
        }
    }
}