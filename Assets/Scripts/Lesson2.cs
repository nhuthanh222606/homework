using UnityEngine;

public class Lesson2 : MonoBehaviour {
    private int CalculatePerimeterRectangle(int width, int height) {
        int result = (width + height) * 2;
        return result;
    }

    private int CalculateAcreageRectangle(int width, int height) {
        int result = width * height;
        return result;
    }

    private void Start() {
        Debug.Log(CalculateAcreageRectangle(100, 100));
        Debug.Log(CalculatePerimeterRectangle(10, 5));
    }

}