using UnityEngine;
using TMPro;

public class Triangle : MonoBehaviour
{
    private TextMeshProUGUI counter;
    private int clickCounter;

    private void OnMouseDown()
    {
        clickCounter ++;
    }

    private void Update()
    {
        counter.text = "Click Counter: " + clickCounter.ToString();
    }
}
