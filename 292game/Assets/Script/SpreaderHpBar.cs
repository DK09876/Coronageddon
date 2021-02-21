using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpreaderHpBar : MonoBehaviour
{
    public Slider slider;

    void Update()
    {
        if (slider.value == 0)
        {
            Destroy(this.gameObject);
        }
    }

    public void SetMaxHp(int hp)
    {
        slider.maxValue = hp;
        slider.value = hp;
    }

    public void SetHp(int hp)
    {
        slider.value = hp;
    }
}
