using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetection : MonoBehaviour
{
   void OnTriggerEnter(Collider other){
        if(other.gameObject.tag == "Environment"){
            print("Enter");
        }
   }

   void OnTriggerStay(Collider other){
        if(other.gameObject.tag == "Environment"){
            print("Stay");
        }
   }

   void OnTriggerExit(Collider other){
        if(other.gameObject.tag == "Environment"){
            print("Exit");
        }
   }
}
