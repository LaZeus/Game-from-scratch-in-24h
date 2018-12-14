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
        TextUpdate();
    }

    // Update is called once per frame
    void Update()
    {
        // Used for debugging..Gonna be removed later

        if (Input.GetMouseButtonDown(0))
            InterpolateValue(-25);        
        else if (Input.GetMouseButtonDown(1))
            InterpolateValue(25);
    }

    private void TextUpdate()
    {
        TextValue.text = $"{(int)sanitySlider.value} / 100";
    }

    public void InterpolateValue(float addValue)
    {
        CalculateRealValue(addValue);

        if (interpolation != null)
            StopCoroutine(interpolation);

        interpolation = StartCoroutine(InterpolateValueChange());
    }

    private void CalculateRealValue(float addValue)
    {
        realValue += addValue;

        if (realValue >= 100)
            realValue = 100;
        else if (realValue < 0)
        {
            realValue = 0;
            // die
        }

    }

    IEnumerator InterpolateValueChange()
    {       
        float valuedt = (realValue - sanitySlider.value);

        while (Mathf.Abs(realValue - sanitySlider.value) > 1f)
        {
            sanitySlider.value += valuedt * Time.deltaTime;
            TextUpdate();
            yield return null;
        }

        sanitySlider.value = realValue;
        TextUpdate();

    }
}
