﻿ using UnityEngine;
 using System.Collections;
 
 public class PlayerMovement : MonoBehaviour
 {
     public float speed = 1.5f;
 
     void Update ()
     {
         if (Input.GetKey(KeyCode.LeftArrow))
         {
             transform.position += Vector3.left * speed * Time.deltaTime;
         }
         if (Input.GetKey(KeyCode.RightArrow))
         {
             transform.position += Vector3.right * speed * Time.deltaTime;
         }
         if (Input.GetKey(KeyCode.UpArrow))
         {
             transform.position += Vector3.forward * speed * Time.deltaTime;
         }
         if (Input.GetKey(KeyCode.DownArrow))
         {
             transform.position += Vector3.back * speed * Time.deltaTime;
         }
     }
 }