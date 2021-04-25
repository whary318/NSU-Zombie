using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateCollectedBoxes : MonoBehaviour
{
    public Text boxesText;
    

    public int boxesTotal;
    private int boxesCollected = 0;
    void Start()
    {
        boxesText.text = "Boxes Collected: " + boxesCollected + " / " + boxesTotal;
    }

    // Update is called once per frame


    public void collectBox()
    {
        boxesCollected++;
        boxesText.text = "Boxes Collected: " + boxesCollected + " / " + boxesTotal;
        if (boxesTotal == boxesCollected)
            FindObjectOfType<GameRestart>().winGame();

    }
}
