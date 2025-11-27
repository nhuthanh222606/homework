using System;
using UnityEngine;

public class Lesson5 : MonoBehaviour {
    private void CheckScoreIfElse(float score) {
        if (score >= 8) {
            Debug.Log("A");
        }
        else if (score >= 6.5f) {
            Debug.Log("B");
        }
        else if (score >= 5) {
            Debug.Log("C");
        }
        else {
            Debug.Log("F");
        }
    }

    private string CheckScoreTernaryOperator(float score) {
        string result = (score >= 8) ? "A" : (score >= 6.5f) ? "B" : (score >= 5) ? "C" : "F";
        return result;
    }

    private void Start() {
        CheckScoreIfElse(6f);
        Debug.Log(CheckScoreTernaryOperator(5f));
    }
}