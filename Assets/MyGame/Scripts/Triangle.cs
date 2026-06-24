using UnityEngine;
using TMPro;

public class Triangle : MonoBehaviour
{
    public TextMeshProUGUI counter;
    private int clickCounter;
    private int limit;

    private void OnMouseDown()
    {
        clickCounter ++;
    }

    private void Update()
    {
        counter.text = "Click Counter: " + clickCounter.ToString();

        if (clickCounter == limit)
        {
            counter.text = "Click Counter: 10";
        }
    }
}
