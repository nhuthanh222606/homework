using System;
using UnityEngine;

public class Lesson7 : MonoBehaviour {

    [SerializeField] private string _string;

    private void Start() {
        if (_string == "") _string = null;
        Debug.Log(CheckNull(_string));
    }

    private string CheckNull(string checkString) {
        string newString = checkString?.ToString() ?? "Is Null";
        return newString;
    }

}