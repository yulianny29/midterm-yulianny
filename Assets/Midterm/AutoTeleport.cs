using UnityEngine;

public class AutoTeleport : MonoBehaviour
{
    public Vector3 teleportLocation = new Vector3(10f, 0f, 10f);
    public float delay = 5f; // seconds before teleport

    void Start()
    {
        // Start teleport coroutine
        StartCoroutine(TeleportAfterDelay());
    }

    private System.Collections.IEnumerator TeleportAfterDelay()
    {
        yield return new WaitForSeconds(delay);
        transform.position = teleportLocation;
        Debug.Log("Teleported!");
    }
}

    

