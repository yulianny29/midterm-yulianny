using UnityEngine;

public class WallDeathZone2D : MonoBehaviour
{
    [SerializeField] private string playerTag = "Player";

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag(playerTag))
        {
            Debug.Log("Player touched wall and died!");
            collision.collider.gameObject.SetActive(false);
        }
    }
}
