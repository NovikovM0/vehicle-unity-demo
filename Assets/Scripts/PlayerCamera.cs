using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    private GameObject player;
    private Vector3 CameraOffset = new Vector3(0, 6, -10);
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + CameraOffset;

    }
}
