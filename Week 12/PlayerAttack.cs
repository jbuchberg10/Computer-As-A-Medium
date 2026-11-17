using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerAttack : MonoBehaviour
{
    public Animator animator;

    public GameObject bulletPrefab;
    public Transform firePoint;

    public float cooldown = 0.67f;
    [SerializeField]
    private bool canFire = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Shoot();
    }

    void Attack()
    {
        if (Keyboard.current.fKey.isPressed)
        {
            animator.SetBool("attack", true);
        }
        else
        {
            animator.SetBool("attack", false);
        }
    }

    void Shoot()
    {
        if (Keyboard.current.fKey.wasPressedThisFrame && canFire == true)
        {
            Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
            canFire = false;
            StartCoroutine(AttackCoroutine());
        }
    }

    IEnumerator AttackCoroutine()
    {
        yield return new WaitForSeconds(cooldown);

        canFire = true;

        Debug.Log("Cooldown Finished!");
    }
}
