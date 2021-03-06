﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour {


    public float lifeTime = 10f;

    void Update() {
        if (lifeTime > 0)
        {
            lifeTime -= Time.deltaTime;
            if (lifeTime <= 0) {
                Destruction();
            }
        }
        if (this.transform.position.x <= -500)
        {
            Destruction();
        }

        if (this.transform.position.y <= -500)
        {
            Destruction();
        }

        if (this.transform.position.z<= -500) {
            Destruction();
        }
                              
    }

    void OnCollisionEnter2D(Collision2D coll){
        if(coll.gameObject.name == "Destroy"){
            Destruction();
        }
    }

    
    void Destruction(){
        Destroy(this.gameObject);

    }
  
}




