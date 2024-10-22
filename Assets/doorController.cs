using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorController : MonoBehaviour
{
   [SerializeReference]Animator door;
   private void OnTriggerEnter(Collider other)
   {
        if(other.CompareTag("Player")){
            
            print("Open door!");
            door.SetBool("Isopen", true);
        }
   }

   
   private void OnTriggerExit(Collider other)
   {
    if(other.CompareTag("Player")){

            print("Close door!");
            door.SetBool("Isopen", false);
        }
   }
}
