package org.example;
public class Player {
    private AttackStrategy attackStrategy;

    // Method to set the attack strategy
    public void setAttackStrategy(AttackStrategy strategy) {
        this.attackStrategy = strategy;
    }

    // Method to execute the current attack strategy
    public void performAttack() {
        if (attackStrategy != null) {
            attackStrategy.attack();
        } else {
            System.out.println("No attack strategy set!");
        }
    }
}
