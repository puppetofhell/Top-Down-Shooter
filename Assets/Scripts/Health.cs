using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int health = 10;
    // Start is called before the first frame update
   
   
    
    // Update is called once per frame
    void OnCollisionEnter(Collision other) {
        if(other.gameObject.CompareTag("Pistol"))
        {
            health--;
        }   
    }

    void Update() {
        if(health <=0 )
        {
            Destroy(gameObject);
        }        
    }
    
}
