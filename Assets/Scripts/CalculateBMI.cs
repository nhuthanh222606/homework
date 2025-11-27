using UnityEngine;

public class CalculateBMI : MonoBehaviour {

    private const decimal k_bmiThin = 18.5m;
    private const decimal k_bmiNormal = 24.9m;
    private const decimal k_bmiPreObesity = 29.9m;
    private const decimal k_bmiObesityI = 34.9m;
    private const decimal k_bmiObesityII = 39.9m;
    private const decimal k_bmiObesityIII = 40m;

    [SerializeField] private int _age;
    [SerializeField] private string _name;
    [SerializeField] private string _sex;
    private decimal _weight = 47m;
    private decimal _height = 1.6m;
    private string _advice;
    private string _status;

    private void Start() {
        Debug.Log(_age);
        Debug.Log(_name);
        Debug.Log(_sex);
        BMIResult(_weight, _height);
    }

    private void BMIResult(decimal weight, decimal height) {
        decimal result = _weight / (_height * _height);

        if (result < k_bmiThin) {
            _status = "Gầy";
            _advice = "Nên Tăng Cân";
            Debug.Log(_status);
            Debug.Log(_advice);
        }
        else if (result <= k_bmiNormal) {
            _status = "Chỉ Số BMI Bình Thường";
            Debug.Log(_status);
        }
        else if (result <= k_bmiPreObesity) {
            _status = "Tiền Béo Phì";
            _advice = "Nên Giảm Cân";
            Debug.Log(_status);
            Debug.Log(_advice);
        }
        else if (result <= k_bmiObesityI) {
            _status = "Béo Phì";
            _advice = "Nên Giảm Cân";
            Debug.Log(_status);
            Debug.Log(_advice);
        }
        else if (result <= k_bmiObesityII) {
            _status = "Khá Mập";
            _advice = "Nên Tập Thể Dục";
            Debug.Log(_status);
            Debug.Log(_advice);
        }
        else if (result <= k_bmiObesityIII) {
            _status = "Quá Mập";
            _advice = "Nên Đi Viện";
            Debug.Log(_status);
            Debug.Log(_advice);
        }
    }

}