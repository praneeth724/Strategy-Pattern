using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Player player;

    private void Start()
    {
        player = GetComponent<Player>();

        // Set default attack strategy to Melee
        player.SetAttackStrategy(new MeleeAttack());
    }

    private void Update()
    {
        // Switch attack strategies
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            player.SetAttackStrategy(new MeleeAttack());
            Debug.Log("Switched to Melee Attack");
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            player.SetAttackStrategy(new RangedAttack());
            Debug.Log("Switched to Ranged Attack");
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            player.SetAttackStrategy(new MagicAttack());
            Debug.Log("Switched to Magic Attack");
        }

        // Perform attack
        if (Input.GetKeyDown(KeyCode.Space))
        {
            player.PerformAttack();
        }
    }
}
