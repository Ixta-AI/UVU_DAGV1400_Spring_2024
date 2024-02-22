using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingleCharacterScriptPractice : MonoBehaviour
{//can narrow this down/ clean up script by seperating int Inventory
    public class Stuff 
    {
        public int bullets;
        public int greanades;
        public int rockets;

       //Constructor (ctor shortcut)
        public Stuff (int bul, int gre, int roc) 
        { 
            bullets = bul;
            greanades = gre;
            rockets = roc;
        }
    }
    //Creating an Instance(object) of the constructor we built with matching perameders
    public Stuff myStuff = new Stuff(10, 7, 25);
    public float speed;
    public float turnSpeed;
    public Rigidbody bulletPrefab;
    public Transform firePosition;
    public float bulletSpeed;

    // Update is called once per frame
    void Update()
    {
        Movement();
        Shoot();
    }
//movement Controls
    void Movement() 
    {
        float forwardMovement = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        float turnMovement = Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime;

        transform.Translate(Vector3.forward * forwardMovement);
        transform.Rotate(Vector3.forward * turnMovement);
    }
//shooting
    void Shoot() 
    {//Instantiate calculating from where the bullet needs to be fired to its forward momentum and its ammo used.
        if(Input.GetButtonDown("Fire1") && myStuff.bullets > 0) 
        {
            Rigidbody bulletInstance = Instantiate(bulletPrefab, firePosition.position, firePosition.rotation) as Rigidbody;
            bulletInstance.AddForce(firePosition.forward * bulletSpeed);
            myStuff.bullets--;
        }//the projectile is a permanent clone untile it is removed which can be done through a destroy script.
    }//Observation note (I think COD uses rays to tell wether or not the player took damage. meaning the bullets are basic lazers)
}
//Class = container for var and functions. Orginization tool for Obj. oriented Prog.
/*O-O-P splits scripts up into multi. each taking on singe diff responsability
 allowes for cleaner looking scripts, modulorization, reusing certain scripts, and easier to write/read scripts
better to figure out how to properly write a class script so it is not clutterd and needlesly loaded with functions*/