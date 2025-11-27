using System;
using UnityEngine;

public class CalculateDateTime : MonoBehaviour {
    private DateTime _birthDay = new DateTime(2005, 6, 26);
    private bool _isValid = false;

    private void Start() {
        CalculateResult();
    }

    private void CalculateResult() {
        if (_birthDay > DateTime.Today) {
            Debug.Log("Error BirthDay");
        }
        else {
            _isValid = true;
        }

        if (_isValid == true) {
            (int year, int month, int day) result = CalculateAge(_birthDay);
            Debug.Log($"Year: {result.year}, Month: {result.month}, Day: {result.day}");
        }
    }

    private (int year, int month, int day) CalculateAge(DateTime birthDay) {
        DateTime toDay = DateTime.Today;

        int year = toDay.Year - birthDay.Year;
        if (toDay.Month < birthDay.Month || (toDay.Month == birthDay.Month && toDay.Day < birthDay.Day)) {
            year--;
        }

        int month = toDay.Month - birthDay.Month;
        // If the month is negative, you need to borrow another year
        if (toDay.Month < birthDay.Month || (toDay.Month == birthDay.Month && toDay.Day < birthDay.Day)) {
            year--;
        }

        if (month < 0) {
            month += 12;
        }

        int day = toDay.Day - birthDay.Day;
        // If the day is negative, you need to borrow another month
        if (toDay.Day < birthDay.Day) {
            month--;
        }

        if (day < 0) {
            DateTime lastDayOfLastMonth = toDay.AddMonths(-1);
            int numberDayOfLastMonth = DateTime.DaysInMonth(lastDayOfLastMonth.Year, lastDayOfLastMonth.Month);
            day += numberDayOfLastMonth;
        }

        return (year, month, day);
    }

}