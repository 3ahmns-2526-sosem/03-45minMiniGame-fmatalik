using UnityEngine;
using TMPro;

public class Triangle : MonoBehaviour
{
    public TextMeshProUGUI counter;
    private int clickCounter;
    private int limit = 10;
    public TextMeshProUGUI winText;

    private void Start()
    {
        winText.enabled = false;
    }

    private void OnMouseDown()
    {
        clickCounter ++;
    }

    private void Update()
    {
        counter.text = "Click Counter: " + clickCounter.ToString();

        if (clickCounter == limit)
        {
            counter.enabled = false;
            winText.enabled = true;
        }
    }
}
