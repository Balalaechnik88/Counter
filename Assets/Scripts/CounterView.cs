using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CounterView : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _value;
    [SerializeField] private Counter _counter;

    private string _text = string.Empty;

    private void Update()
    {
        _value.text = _text + _counter.GetValue();
    }
}
