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
    public int PointsInCryo;
    public int PointsInPyro;
    public int MaxPointsInCryo;
    public int MaxPointsInPyro;
    public Slider CryoSlider;
    public Slider PyroSlider;
    public int skillpoints;
    public int Coolerthanyou;
    public int Icesoldiers;
    public int IceBarrage;
    public int Reserves;
    public int Commander;
    public int reinforced;
    public int freezerburn;
    public int HotBlooded;
    public int TemperedSkin;
    public int FierceFire;
    public int HadesFire;
    public int AfterGlow;
    // Start is called before the first frame update
    void Start()
    {
        exp = 0.0f;
        maxexp = 50.0f;
        ExpSlider.maxValue = maxexp;
        ExpSlider.value = exp;
        MaxPointsInCryo = 20;
        MaxPointsInPyro = 20;
        PointsInCryo = 0;
        PointsInPyro = 0;
        CryoSlider.maxValue = MaxPointsInCryo;
        PyroSlider.maxValue = MaxPointsInPyro;
        CryoSlider.value = PointsInCryo;
    }
    void Update()
    {
        if(exp>maxexp)
        {
            gainExp(0.0f);
        }
    }

    public void gainExp(float gain)
    {
        exp = exp + gain;
        ExpSlider.value = exp;
        if (exp >= maxexp)
        {
            
            maxexp += exp*0.2f;
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
        PointsInCryo += 1;
        CryoSlider.value = PointsInCryo;

    }
    public void UpgradeReserves()
    {
        skillpoints -= 1;
        skillpointsText.text = skillpoints.ToString();
        Reserves += 1;
        PointsInCryo += 1;
        CryoSlider.value = PointsInCryo;

    }
    public void UpgradeCommander()
    {
        skillpoints -= 1;
        skillpointsText.text = skillpoints.ToString();
        Commander += 1;
        PointsInCryo += 1;
        CryoSlider.value = PointsInCryo;

    }
    public void UpgradeReinforced()
    {
        skillpoints -= 1;
        skillpointsText.text = skillpoints.ToString();
        reinforced += 1;
        PointsInCryo += 1;
        CryoSlider.value = PointsInCryo;

    }
    public void UpgradeFreezerBurn()
    {
        skillpoints -= 1;
        skillpointsText.text = skillpoints.ToString();
        freezerburn += 1;
        PointsInCryo += 1;
        CryoSlider.value = PointsInCryo;
    }
    public void UpgradeHotBlooded()
    {
        skillpoints -= 1;
        skillpointsText.text = skillpoints.ToString();
        HotBlooded += 1;
        PointsInPyro += 1;
        PyroSlider.value = PointsInPyro;
    }
    public void UpgradeTemperedSkin()
    {
        skillpoints -= 1;
        skillpointsText.text = skillpoints.ToString();
        TemperedSkin += 1;
        PointsInPyro += 1;
        PyroSlider.value = PointsInPyro;
    }
    public void UpgradeFierceFire()
    {
        skillpoints -= 1;
        skillpointsText.text = skillpoints.ToString();
        FierceFire += 1;
        PointsInPyro += 1;
        PyroSlider.value = PointsInPyro;
    }
    public void UpgradeHadesFire()
    {
        skillpoints -= 1;
        skillpointsText.text = skillpoints.ToString();
        HadesFire += 1;
        PointsInPyro += 1;
        PyroSlider.value = PointsInPyro;
    }
    public void UpgradeAfterGlow()
    {
        skillpoints -= 1;
        skillpointsText.text = skillpoints.ToString();
        AfterGlow += 1;
        PointsInPyro += 1;
        PyroSlider.value = PointsInPyro;
    }
    public void UnlockIceSoldiers()
    {
        skillpoints -= 1;
        skillpointsText.text = skillpoints.ToString();
        PointsInCryo += 1;
        CryoSlider.value = PointsInCryo;
    }
    public void UnlockIceBarrage()
    {
        skillpoints -= 1;
        skillpointsText.text = skillpoints.ToString();
        PointsInCryo += 1;
        CryoSlider.value = PointsInCryo;
    }
    public void UnlockHellHound()
    {
        skillpoints -= 1;
        skillpointsText.text = skillpoints.ToString();
        PointsInPyro += 1;
        PyroSlider.value = PointsInPyro;
    }

}
