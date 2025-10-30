using UnityEngine;

public class RandomTeleport : MonoBehaviour
{
    public float teleportInterval = 5f; // every 5 seconds
    public float range = 20f; // how far they can teleport

    private void Start()
    {
        InvokeRepeating(nameof(TeleportRandomly), teleportInterval, teleportInterval);
    }

    private void TeleportRandomly()
    {
        Vector3 randomOffset = new Vector3(
            Random.Range(-range, range),
            0f,
            Random.Range(-range, range)
        );

        transform.position += randomOffset;
        Debug.Log("Teleported to: " + transform.position);
    }
}
