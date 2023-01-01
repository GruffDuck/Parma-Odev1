using System.Collections;
using System.Collections.Generic;
using Pattern;
using TMPro;
using UnityEngine;

public class Counter : MonoBehaviour
{
    [SerializeField] private int count;
    [SerializeField] private TextMeshProUGUI scoreText;
    
    public void Increase(int increaseValue)
    {
        count += increaseValue;
        scoreText.text = count.ToString();
    }
}
