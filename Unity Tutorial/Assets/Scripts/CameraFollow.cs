using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    private Transform player;
    private Vector3 tempPosition;

    [SerializeField]
    private float minX = -40, maxX = 40;

    private string PLAYER_TAG = "Player";

    void Start() // called once before first Update
    {
        player = GameObject.FindWithTag(PLAYER_TAG).transform;
    }

    void LateUpdate() // called once per frame
    {
        tempPosition = transform.position;
        if (player == null) // if player has been deleted
        {
            return; // exit function
        }
        tempPosition.x = player.position.x;
        if (tempPosition.x < minX) // if player moves below the min
        {
            tempPosition.x = minX;
        }
        if (tempPosition.x > maxX) // if player moves above the max
        {
            tempPosition.x = maxX;
        }
        transform.position = tempPosition;
        
    }
}
