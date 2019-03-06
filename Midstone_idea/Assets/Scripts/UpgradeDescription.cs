using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class UpgradeDescription : MonoBehaviour
{
    public TextMeshProUGUI Upgradetext;
    public TextMeshProUGUI Upgradetextamount;
    public GameObject player;
    public void OnMouseEnter()
    {
        Upgradetext.text = gameObject.name;
        
    }
    public void coolerthanyou()
    {
        if(player.GetComponent<LevelSystem>().Coolerthanyou<6&& player.GetComponent<LevelSystem>().skillpoints > 0)
        {
            player.GetComponent<LevelSystem>().UpgradeCoolerthanyou();
            player.GetComponent<Player>().MPRechargeDelayRate += 0.05f;
        }
        Upgradetextamount.text = player.GetComponent<LevelSystem>().Coolerthanyou.ToString() + "/5";
        Debug.Log("clicked");


    }
}
