using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class LevelSystem : MonoBehaviour
{
    public Slider ExpSlider;
    public float exp;
    public float maxexp;
    public TextMeshProUGUI skillpointsText;
    public int skillpoints;
    public int Coolerthanyou;
    // Start is called before the first frame update
    void Start()
    {
        exp = 0.0f;
        maxexp = 100.0f;
        ExpSlider.maxValue = maxexp;
        ExpSlider.value = exp;
    }

    public void gainExp(float gain)
    {
        exp = exp + gain;
        ExpSlider.value = exp;
        if (exp >= maxexp)
        {
            exp = 0.0f;
            maxexp += 100.0f;
            skillpoints += 1;
            skillpointsText.text = skillpoints.ToString();
            ExpSlider.maxValue = maxexp;
            ExpSlider.value = exp;
        }
    }

    
    public void UpgradeCoolerthanyou()
    {
        skillpoints -= 1;
        skillpointsText.text = skillpoints.ToString();
        Coolerthanyou += 1;
        
    }



}
