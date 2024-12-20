package org.example;
import java.util.Scanner;
public class Main {
    public static void main(String[] args) {
        Player player = new Player();
        Scanner scanner = new Scanner(System.in);

        System.out.println("Choose an attack strategy:");
        System.out.println("1. Melee Attack");
        System.out.println("2. Ranged Attack");
        System.out.println("3. Magic Attack");
        System.out.println("Press '0' to perform an attack or 'q' to quit.");

        while (true) {
            System.out.print("Enter your choice: ");
            String input = scanner.nextLine();

            switch (input) {
                case "1":
                    player.setAttackStrategy(new MeleeAttack());
                    System.out.println("Switched to Melee Attack");
                    break;
                case "2":
                    player.setAttackStrategy(new RangedAttack());
                    System.out.println("Switched to Ranged Attack");
                    break;
                case "3":
                    player.setAttackStrategy(new MagicAttack());
                    System.out.println("Switched to Magic Attack");
                    break;
                case "0":
                    player.performAttack();
                    break;
                case "q":
                    System.out.println("Exiting game...");
                    scanner.close();
                    return;
                default:
                    System.out.println("Invalid choice. Try again.");
                    break;
            }
        }

    }
}