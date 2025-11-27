using System;
using UnityEngine;

public class Calculator : MonoBehaviour {
    [SerializeField] private float _soThuNhat;
    [SerializeField] private float _soThuHai;
    [SerializeField] private string _operation;
    private float _result;
    private bool _isValid = false;

    private void Start() {
        Debug.Log(CalculateNumbers());
    }

    private float CalculateNumbers() {
        if (_operation == "+" || _operation == "-" || _operation == "/" || _operation == "*") {
            _isValid = true;
        }
        else {
            _isValid = false;
        }

        if (_isValid == true) {
            switch (_operation) {
                case "+":
                    _result = _soThuNhat + _soThuHai;
                    break;
                case "-":
                    _result = _soThuHai - _soThuNhat;
                    break;
                case "/":
                    _result = _soThuNhat / _soThuHai;
                    break;
                case "*":
                    _result = _soThuNhat * _soThuHai;
                    break;
            }
        }
        else {
            Debug.Log("Is Not Valid");
        }

        return _result;
    }
}