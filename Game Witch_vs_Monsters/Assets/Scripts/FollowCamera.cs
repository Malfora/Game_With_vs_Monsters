using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public Transform Player;
    public float Distance;

    private void LateUpdate()
    {
        if (Player != null)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, Player.position.z - Distance);
        }
        
        if (Player == null)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        }
    }

}
