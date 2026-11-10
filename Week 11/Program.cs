using UnityEngine;
public class Trap : MonoBehaviour
{
    public PlayerHealth playerHealth;
    public GameObject trappedimage;

    void Start()
    {
        if (trappedimage != null)
        {
            trappedimage.SetActive(false);
        }
    }

    void Update()
    {
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerHealth.health -= 10;

            if (trappedimage != null)
            {
                trappedimage.SetActive(true);
            }
        }
    }
}
