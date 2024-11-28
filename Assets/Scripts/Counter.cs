using System.Collections;
using UnityEngine;

public class Counter : MonoBehaviour
{
    private WaitForSeconds _waitTime = new WaitForSeconds(0.5f);
    private Coroutine _valueCoroutine;
    private bool _isCounting = false;

    public int InitialValue { get; private set; }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (_valueCoroutine == null)
            {
                _isCounting = true;
                _valueCoroutine = StartCoroutine(UpdateValue());
            }
            else
            {
                StopCoroutine(_valueCoroutine);
                _valueCoroutine = null;
                _isCounting = false;
            }
        }
    }

    private IEnumerator UpdateValue()
    {
        while (_isCounting)
        {
            InitialValue++;
            yield return _waitTime;
        }
    }
}
