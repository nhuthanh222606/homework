using System.Collections.Generic;
using UnityEngine;

public class Lesson6 : MonoBehaviour {
    private void Start() {
        CheckNumber(100);
    }

    private void CheckNumber(int number) {
        if (number % 2 == 0) {
            Debug.Log("This is a even number");
        }
        else {
            Debug.Log("This is a odd number");
        }

        if (number < 100) {
            Debug.Log("This is small number");
        }
        else {
            Debug.Log("This is not small number");
        }
    }
}