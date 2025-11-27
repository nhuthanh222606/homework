using System;
using UnityEngine;

public class Lesson4 : MonoBehaviour {
    private decimal CalculateSalaryNet(decimal salaryGross) {
        decimal tax = (10m / 100m) * salaryGross;
        decimal salaryNet = salaryGross - tax;
        return salaryNet;
    }

    private void Start() {
        Debug.Log(CalculateSalaryNet(20000000));
    }
}