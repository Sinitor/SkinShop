using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSkin : MonoBehaviour
{
    public Sprite apple;
    public Sprite banana;
    public Sprite cherry;
    public Sprite melon;
    public SpriteRenderer sr;

    private void Start()
    {
        if (Money.selectedSkin == 1)
        {
            sr.sprite = banana;
        }
        else if (Money.selectedSkin == 2)
        {
            sr.sprite = cherry;
        } 
        else if (Money.selectedSkin == 3)
        {
            sr.sprite = melon;
        }
        else
        {
            sr.sprite = apple;
        }
    }
}
