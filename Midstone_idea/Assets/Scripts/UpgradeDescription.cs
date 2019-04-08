using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class UpgradeDescription : MonoBehaviour
{
    public TextMeshProUGUI Upgradetext;
    public TextMeshProUGUI Upgradetextamount;
    public GameObject player;
   
    void Start()
    {
        
    }

    public void OnMouseEnter()
    {
        Upgradetext.text = gameObject.name;
        
    }
    public void coolerthanyou()
    {
        if(player.GetComponent<LevelSystem>().Coolerthanyou<5&& player.GetComponent<LevelSystem>().skillpoints > 0)
        {
            player.GetComponent<LevelSystem>().UpgradeCoolerthanyou();
            player.GetComponent<Player>().MPRechargeDelayRate += 0.05f;
            
        }
        Upgradetextamount.text = player.GetComponent<LevelSystem>().Coolerthanyou.ToString() + "/5";
 


    }
    public void Reserves()
    {
        if (player.GetComponent<LevelSystem>().Reserves < 5 && player.GetComponent<LevelSystem>().skillpoints > 0&& player.GetComponent<LevelSystem>().PointsInCryo >=5)
        {
            player.GetComponent<LevelSystem>().UpgradeReserves();
            player.GetComponent<Player>().MaxMp += 10.0f;
            player.GetComponent<Player>().Mp+= 10.0f;
            player.GetComponent<Player>().MpSlider.maxValue += 10.0f;
            player.GetComponent<Player>().MpSlider.value += 10.0f;
           

        }
        Upgradetextamount.text = player.GetComponent<LevelSystem>().Reserves.ToString() + "/5";
       


    }
    public void Commander()
    {
        if (player.GetComponent<LevelSystem>().Commander < 5 && player.GetComponent<LevelSystem>().skillpoints > 0&& player.GetComponent<LevelSystem>().PointsInCryo >=10)
        {
            player.GetComponent<LevelSystem>().UpgradeCommander();
            player.GetComponent<Player>().IceSoldierLifespan += 0.3f;
            player.GetComponent<Player>().IceSoldierDamage += 0.05f;
            

        }
        Upgradetextamount.text = player.GetComponent<LevelSystem>().Commander.ToString() + "/5";
       


    }
    public void ReinforcedIce()
    {
        if (player.GetComponent<LevelSystem>().reinforced< 5 && player.GetComponent<LevelSystem>().skillpoints > 0)
        {
            player.GetComponent<LevelSystem>().UpgradeReinforced();
            player.GetComponent<Player>().IceMissledamage += 1.0f;
        


        }
        Upgradetextamount.text = player.GetComponent<LevelSystem>().reinforced.ToString() + "/5";



    }
    public void FreezerBurn()
    {
        if (player.GetComponent<LevelSystem>().freezerburn < 5 && player.GetComponent<LevelSystem>().skillpoints > 0 && player.GetComponent<LevelSystem>().PointsInCryo >= 15)
        {
            player.GetComponent<LevelSystem>().UpgradeFreezerBurn();
            player.GetComponent<Player>().IceMissledamage += 0.5f;
            player.GetComponent<Player>().IceSoldierDamage += 0.05f;
            player.GetComponent<Player>().FlameThrowerdamage += 0.015f;
            player.GetComponent<Player>().FlameTurretdamage += 0.5f;


        }
        Upgradetextamount.text = player.GetComponent<LevelSystem>().freezerburn.ToString() + "/5";



    }
    public void HotBlooded()
    {
        if (player.GetComponent<LevelSystem>().HotBlooded<5 && player.GetComponent<LevelSystem>().skillpoints > 0)
        {
            player.GetComponent<LevelSystem>().UpgradeHotBlooded();
            player.GetComponent<Player>().hpRechargedelayRate += 0.05f;
        }
        Upgradetextamount.text = player.GetComponent<LevelSystem>().HotBlooded.ToString() + "/5";
    }
    public void TemperedSkin()
    {
        if (player.GetComponent<LevelSystem>().TemperedSkin < 5 && player.GetComponent<LevelSystem>().skillpoints > 0 && player.GetComponent<LevelSystem>().PointsInPyro >= 5)
        {
            player.GetComponent<LevelSystem>().UpgradeTemperedSkin();
            player.GetComponent<Player>().maxhp += 10.0f;
            player.GetComponent<Player>().MaxMp += 2.0f;
            player.GetComponent<Player>().healthSlider.maxValue += 10.0f;
            player.GetComponent<Player>().MpSlider.maxValue += 2.0f;
        }
        Upgradetextamount.text = player.GetComponent<LevelSystem>().TemperedSkin.ToString() + "/5";
    }
    public void FierceFire()
    {
        if (player.GetComponent<LevelSystem>().FierceFire < 5 && player.GetComponent<LevelSystem>().skillpoints > 0 && player.GetComponent<LevelSystem>().PointsInPyro >= 5)
        {
            player.GetComponent<LevelSystem>().UpgradeFierceFire();
            player.GetComponent<Player>().FlameThrowerdamage += 0.03f;
            player.GetComponent<Player>().FlameTurretdamage += 0.5f;
           
        }
        Upgradetextamount.text = player.GetComponent<LevelSystem>().FierceFire.ToString() + "/5";
    }
    public void HadesFire()
    {
        if (player.GetComponent<LevelSystem>().HadesFire < 5 && player.GetComponent<LevelSystem>().skillpoints > 0 && player.GetComponent<LevelSystem>().PointsInPyro >= 15)
        {
            player.GetComponent<LevelSystem>().UpgradeHadesFire();
            player.GetComponent<Player>().FlameTurretAtkSpeedrate += 0.05f;
            player.GetComponent<Player>().FlameTurretdamage += 0.5f;

        }
        Upgradetextamount.text = player.GetComponent<LevelSystem>().HadesFire.ToString() + "/5";
    }
    public void AfterGlow()
    {
        if (player.GetComponent<LevelSystem>().AfterGlow < 5 && player.GetComponent<LevelSystem>().skillpoints > 0 && player.GetComponent<LevelSystem>().PointsInPyro >= 10)
        {
            player.GetComponent<LevelSystem>().UpgradeAfterGlow();
            player.GetComponent<Player>().FlameThrowerlifesteal += 0.05f;
          

        }
        Upgradetextamount.text = player.GetComponent<LevelSystem>().AfterGlow.ToString() + "/5";
    }

    public void UnlockIceSoldiers()
    {
        if (player.GetComponent<Player>().Icesolidersunlocked==false && player.GetComponent<LevelSystem>().skillpoints > 0&& player.GetComponent<LevelSystem>().PointsInCryo >=10)
        {

            player.GetComponent<Player>().Icesolidersunlocked = true;
            player.GetComponent<LevelSystem>().Icesoldiers += 1;
            
            player.GetComponent<LevelSystem>().UnlockIceSoldiers();
           
        }
        Upgradetextamount.text = player.GetComponent<LevelSystem>().Icesoldiers + "/1";
       


    }
    public void UnlockHellhoundTurret()
    {
        if (player.GetComponent<Player>().HellHoundunlocked == false && player.GetComponent<LevelSystem>().skillpoints > 0 && player.GetComponent<LevelSystem>().PointsInPyro >= 10)
        {

            player.GetComponent<Player>().HellHoundunlocked = true;
            player.GetComponent<LevelSystem>().UnlockHellHound();

            
            Upgradetextamount.text = "1/1";
        }

    }
    public void UnlockCerberusTurret()
    {
        if (player.GetComponent<Player>().Cerberusunlocked == false && player.GetComponent<LevelSystem>().skillpoints > 0 && player.GetComponent<LevelSystem>().PointsInPyro >= 20)
        {

            player.GetComponent<Player>().Cerberusunlocked = true;
            player.GetComponent<LevelSystem>().UnlockHellHound();

            
            Upgradetextamount.text = "1/1";
        }

    }
    public void UnlockIceBarrage()
    {
        if (player.GetComponent<Player>().IceBarrage == false && player.GetComponent<LevelSystem>().skillpoints > 0 && player.GetComponent<LevelSystem>().PointsInCryo >= 20)
        {

            player.GetComponent<Player>().IceBarrage = true;
            player.GetComponent<LevelSystem>().IceBarrage += 1;

            player.GetComponent<LevelSystem>().UnlockIceSoldiers();

        }
        Upgradetextamount.text = player.GetComponent<LevelSystem>().IceBarrage + "/1";



    }
}
