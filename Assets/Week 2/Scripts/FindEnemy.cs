using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindEnemy : MonoBehaviour
{
    //----------------------Edit below here --------------------
    public class Enemy : MonoBehaviour
    {
        public float health; // hp enemy
    }
    public List<Enemy> enemies; //list enemy
    public Enemy FindEnemyWithSmallestHealth()
    {
        Enemy smallestEnemy = null; // create

        foreach (Enemy enemy in enemies)
        {
            if (smallestEnemy == null || enemy.health < smallestEnemy.health) //check hp
            {
                smallestEnemy = enemy; //update
            }
        }

        return smallestEnemy;
    }

    public Enemy FindEnemyWithLargestHealth()
    {
        Enemy largestEnemy = null;

        foreach (Enemy enemy in enemies)
        {
            if (largestEnemy == null || enemy.health > largestEnemy.health)
            {
                largestEnemy = enemy;
            }
        }

        return largestEnemy;
    }

    //----------------------Edit above here --------------------
}
