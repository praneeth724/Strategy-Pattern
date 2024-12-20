using UnityEngine;

public class Player : MonoBehaviour
{
    private IAttackStrategy attackStrategy;

    // Method to set the attack strategy
    public void SetAttackStrategy(IAttackStrategy strategy)
    {
        attackStrategy = strategy;
    }

    // Method to execute the current attack strategy
    public void PerformAttack()
    {
        if (attackStrategy != null)
        {
            attackStrategy.Attack();
        }
        else
        {
            Debug.Log("No attack strategy set!");
        }
    }
}
