using System.Collections;
using TMPro;
using UnityEngine;

public class Counter : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _value;
    private int _initialValue = 0;
    private string _text = string.Empty;
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
            _value.text = _text + _initialValue;  
            yield return new WaitForSeconds(0.5f);
        }
    }
}
