using System;
using UnityEngine;

public class Lesson3 : MonoBehaviour {
    private float ConvertCelsiusToFahrenheit(float celsius) {
        float result = (celsius * 9 / 5) + 32;
        return result;
    }

    private void Start() {
        Debug.Log(ConvertCelsiusToFahrenheit(3.6f));
    }
}