
using UnityEngine;

public class FollowScript : MonoBehaviour
{
    public Transform Player;

    void FixedUpdate()
    {
        // if (Player.position.x > transform.position.x) { 
            transform.position = new Vector3(Player.position.x, Player.position.y + 0.75f, Player.position.z - 10f);
        
    }
}
