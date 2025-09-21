
using UnityEngine;
using UnityEngine.Windows;

public class FollowPlayer : MonoBehaviour
{
    public Transform Player;

    void Update()
    {

        if (Player.position.y >= transform.position.y)
        {
            transform.position = new Vector3(transform.position.x, Player.position.y, transform.position.z);

        }
    }



}
