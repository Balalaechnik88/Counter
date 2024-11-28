using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class Counter : MonoBehaviour
{
    private int _initialValue = 0;
    private float _waitTime = 0.5f;
    private bool isCounting = false;


    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            isCounting = !isCounting;

            if (isCounting)
            {
                StartCoroutine(UpdateValue());
            }
            else
            {
                StopCoroutine(UpdateValue());
            }
        }
    }

    private IEnumerator UpdateValue()
    {
        while (isCounting)
        {
            _initialValue++;
            yield return new WaitForSeconds(_waitTime);
        }
    }

    public int GetValue()
    {
        return _initialValue;
    }
}
