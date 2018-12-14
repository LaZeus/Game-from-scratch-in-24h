using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SanityUI : MonoBehaviour
{
    private float realValue { get; set; } = 100;

    private Coroutine interpolation;

    [Header("RequiredComponents")]

    [SerializeField]
    private Slider sanitySlider;

    [SerializeField]
    private TextMeshProUGUI TextValue;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //TextUpdate();
    }

    private void TextUpdate()
    {
        TextValue.text = $"{(int)sanitySlider.value} / 100";
    }

    public void InterpolateValue(float addValue)
    {
        realValue += addValue;
        if (realValue > 100)
            realValue = 100;
        else if (realValue < 0)
            realValue = 0;

        if (interpolation != null)
            StopCoroutine(interpolation);

        interpolation = StartCoroutine(InterpolateValueChange());
    }

    IEnumerator InterpolateValueChange()
    {
        //float sign = Mathf.Sign(realValue - sanitySlider.value);
        float valuedt = (realValue - sanitySlider.value) / 30;

        while (Mathf.Abs(realValue - sanitySlider.value) <= 0.05f)
        {
            sanitySlider.value += valuedt * Time.deltaTime;
            TextUpdate();
            yield return null;
        }
       
    }
}
