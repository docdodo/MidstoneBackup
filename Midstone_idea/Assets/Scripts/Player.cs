using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Player : MonoBehaviour
{
    Rigidbody rb;
    public float movespeed;
    public float maxhp;
    public float hp;
    public Slider healthSlider;
    public Slider MpSlider;
    public float Mp;
    public float MaxMp;
    public float MPRechargeDelay;
    public float MPRechargeDelayRate;
    public float MPRechargeDelaymax;
    public float MPRechargeSpeed;
    public float hpRechargeSpeed;
    public float hpRechargedelay;
    public float hpRechargedelaymax;
    public float hpRechargedelayRate;
    public float IceSoldierLifespan;
    public float IceSoldierDamage;
    public bool Icesolidersunlocked;
    public bool HellHoundunlocked;
    public bool Cerberusunlocked;
    public GameObject IceMissleobject;
    public float IceMissledamage;
    public GameObject IceSide;
    public GameObject FireSide;
    public GameObject Icesoldier;
    public GameObject FlameThrowerHbox;
    public float FlameThrowerdamage;
    public float FlameThrowerlifesteal;
    public float FlameTurretdamage;
    public float FlameTurretLifeTime;
    public float FlameTurretAtkSpeedrate;
    public GameObject UI;
    public bool Paused;
    public bool IceBarrage;
    public GameObject IcebarrageM;
    public GameObject HellHoundTurret;
    public GameObject CerberusTurret;


    void Start()
    {
      
        movespeed = 5.0f;
        MaxMp = 100.0f;
        maxhp = 100.0f;
        hp = 100.0f;
        MPRechargeDelay = 1.8f;
        hpRechargedelay = 4.8f;
        MPRechargeDelaymax = 1.8f;
        hpRechargedelaymax = 4.8f;
        MPRechargeDelayRate = 1.0f;
        hpRechargedelayRate = 1.0f;
        hpRechargeSpeed= 0.1f;
        MPRechargeSpeed = 1.0f;
        Mp = MaxMp;
        IceSoldierDamage = 0.5f;
        IceSoldierLifespan = 6.0f;
        IceSide = GameObject.Find("IceSide");
        healthSlider.maxValue = maxhp;
        healthSlider.value = hp;
        MpSlider.maxValue = MaxMp;
        MpSlider.value = Mp;
        IceMissledamage = 5.0f;
        FlameThrowerdamage = 0.3f;
        FlameThrowerlifesteal = 0.00f;
        FlameTurretdamage = 5.0f;
        FlameTurretLifeTime = 10.0f;
        FlameTurretAtkSpeedrate = 1.0f;

        IceBarrage = false;
        
    }


    void Update()
    {
        
        Debug.DrawRay(transform.position, transform.forward);
        transform.Translate(movespeed * Input.GetAxis("Horizontal") * Time.deltaTime, 0f, movespeed * Input.GetAxis("Vertical") * Time.deltaTime);
        
        if (!Input.GetButton("Lightning") & !Input.GetButton("Fire2")&!Input.GetButton("Skill1") & !Input.GetButton("Skill2"))
        {
            if (MPRechargeDelay > 0)
            {
                MPRechargeDelay -= Time.deltaTime * MPRechargeDelayRate;
            }
        }
        else if (MPRechargeDelay!=MPRechargeDelaymax)
        {
            MPRechargeDelay = MPRechargeDelaymax;
        }
        if(MPRechargeDelay<=0&&Mp<MaxMp)
        {
            Mp += MPRechargeSpeed;
            MpSlider.value = Mp;
        }
        if(MaxMp<Mp)
        {
            Mp = MaxMp;
        }
        if (hp < maxhp&&hpRechargedelay>0)
        {
            hpRechargedelay -= Time.deltaTime * hpRechargedelayRate;
        }
        if (hpRechargedelay <= 0 && hp < maxhp)
        {
            hp += hpRechargeSpeed;
            healthSlider.value = hp;
        }

        if (Input.GetButton("Lightning") & Mp > 1.0f && !Paused)
        {

            FlameThrowerHbox.SetActive(true);
            Mp = Mp - (Time.deltaTime * 15);
            MpSlider.value = Mp;

        }
        else if (Input.GetButton("Lightning") & Mp <= 1.0f && !Paused)
        {
            FlameThrowerHbox.SetActive(false);
            Debug.Log("out of mana");
        }
        if (Input.GetButtonUp("Lightning") && !Paused)
        {
            FlameThrowerHbox.SetActive(false);
        }

     
        if (Input.GetButtonDown("Fire2") & Mp > 10.0f && !Paused&&!IceBarrage)
        {
            Instantiate(IceMissleobject, IceSide.transform.position, IceSide.transform.rotation);
            Mp -= 10.0f;
            MpSlider.value = Mp;
        }
        if (Input.GetButtonDown("Fire2") & Mp > 10.0f && !Paused&&IceBarrage)
        {
            Instantiate(IcebarrageM, IceSide.transform.position, IceSide.transform.rotation);
            Instantiate(IcebarrageM, IceSide.transform.position+new Vector3(1,0,0), IceSide.transform.rotation);
            Instantiate(IcebarrageM, IceSide.transform.position+new Vector3(2,0,0), IceSide.transform.rotation);
            Mp -= 10.0f;
            MpSlider.value = Mp;
        }
        if (Input.GetButtonDown("Pause")&&!Paused)
        {
            UI.GetComponent<MenuNavigator>().enterMainMenu();
            Paused = true;
        }
        if (Input.GetButtonDown("Skill1") & Mp > 25.0f && !Paused&&Icesolidersunlocked)
        {
            Instantiate(Icesoldier, IceSide.transform.position, IceSide.transform.rotation);
            Mp -= 25.0f;
            MpSlider.value = Mp;
        }
        if (Input.GetButtonDown("Skill2") & Mp > 15.0f && !Paused && HellHoundunlocked&&!Cerberusunlocked)
        {
            Instantiate(HellHoundTurret, FireSide.transform.position, FireSide.transform.rotation);
            Mp -= 15.0f;
            MpSlider.value = Mp;
        }
        if (Input.GetButtonDown("Skill2") & Mp > 15.0f && !Paused && HellHoundunlocked && Cerberusunlocked)
        {
            Instantiate(CerberusTurret, FireSide.transform.position, FireSide.transform.rotation);
            Mp -= 15.0f;
            MpSlider.value = Mp;
        }
    }








    IEnumerator Charging1()
    {


        yield return new WaitForSeconds(0.5f);
        FlameThrowerHbox.SetActive(true);
        Mp = Mp - 1;
        MpSlider.value = Mp;




    }
    public void takeDamage(float damage)
    {
        hp -= damage;
        healthSlider.value = hp;
        hpRechargedelay = hpRechargedelaymax;
        if(hp<=0)
        {
            Scene scene =SceneManager.GetActiveScene();
            SceneManager.LoadScene(scene.name);
        }
    }
    public void Heal(float Heal)
    {
        hp += Heal;
        healthSlider.value = hp;
       
    }





}
