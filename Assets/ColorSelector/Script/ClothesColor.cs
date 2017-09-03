using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClothesColor : MonoBehaviour
{

    public SpriteRenderer BodyColor;
    public SpriteRenderer RightColor;
    public SpriteRenderer LeftColor;
    public SpriteRenderer SkirtColor;

    public int currentTapNumber = 0;
  
    public void onClickTap(int tapNumber)
    {
        if (tapNumber == 1)
        {
            currentTapNumber = 1;
        }

        if (tapNumber == 2)
        {
            currentTapNumber = 3;
        }

        if (tapNumber == 3)
        {
            currentTapNumber = 2;
        }

        if (tapNumber == 4)
        {
            currentTapNumber = 4;
        }
    }


    public void ChangeColorCloth (int TapNum)
    {
        switch (TapNum)
        {
            case 1:
                BodyColor.color = ColorSelector.GetColor();
                break;
            case 2:
                RightColor.color = ColorSelector.GetColor();
                LeftColor.color = ColorSelector.GetColor();
                break;
            case 3:
                //LeftColor.color = ColorSelector.GetColor();
                break;
            case 4:
                SkirtColor.color = ColorSelector.GetColor();
                break;
            default:
                break;
        }
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(currentTapNumber);
        ChangeColorCloth(currentTapNumber);
    }
}