using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Control : MonoBehaviour
{
    
    [SerializeField]private Transform player ; 
    
    private void Update()
    {
       transform.position = new Vector3(player.position.x,player.position.y+1,transform.position.z);
    }
}
