using UnityEngine;

public class ArrowTrap : MonoBehaviour
{
    [SerializeField] private GameObject arrow;
    [SerializeField] private Transform firePoint;

    [SerializeField] private float attackCooldown = 2f;

    private float cooldownTimer;

    private void Update()
    {
        cooldownTimer += Time.deltaTime;

        if (cooldownTimer >= attackCooldown)
        {
            ShootArrow();
        }
    }

    private void ShootArrow()
    {
        cooldownTimer = 0;

        arrow.transform.position = firePoint.position;

        arrow.GetComponent<EnemyProjectile>().SetDirection(1);
    }
}