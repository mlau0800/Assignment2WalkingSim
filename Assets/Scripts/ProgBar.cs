using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;

public class ProgBar : MonoBehaviour
{
    Image myImage;
    public float timePassed;
    public float timeRemainingToDeath;
    public int remainingGameTime;
    // Start is called before the first frame update
    void Start()
    {
        remainingGameTime = 90;
        myImage = GetComponent<Image> ();
        myImage.rectTransform.sizeDelta = new Vector2(190,40);
    }

    // Update is called once per frame
    void Update()
    {
      timePassed += Time.deltaTime;
      timeRemainingToDeath = remainingGameTime - timePassed;
      if (timeRemainingToDeath < 0) {
        print("Time for death");
      }
      myImage.rectTransform.sizeDelta = new Vector2(Mathf.Ceil((timeRemainingToDeath/remainingGameTime) * 190), 40);
    }
}
