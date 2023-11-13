using UnityEngine;
using System.Collections;
public class Enemy : MonoBehaviour
{
    public int hitpoints, damage;
    public string EnemyName;
    public Enemy(int hp, int dmg, string ID)
    { //this constructor assigns hitpoints, damage, and name to
      //the values passed into the constructor
        hitpoints = hp;
        damage = dmg;
        EnemyName = ID;
    }
    public void TakeDamage()
    {
        hitpoints--; //reduce HP by 1

        GetComponent<SpriteRenderer>().color = GetComponent<SpriteRenderer>().color - new Color(0f, 1f, 0f, 0f);
        Debug.Log(EnemyName + "'s HP: " + hitpoints); //print out new hp

        if (hitpoints <= 0) Die();
    }

    public void TakeDamage(int damage)
    {
        hitpoints-=damage; //reduce HP by damage amount

        GetComponent<SpriteRenderer>().color = GetComponent<SpriteRenderer>().color - new Color(0f, 1f, 0f, 0f);
        Debug.Log(EnemyName + "'s HP: " + hitpoints); //print out new hp

        if (hitpoints <= 0) Die();

    }
    public void Die()
    {
        Debug.Log(EnemyName + " Has Died"); //print to the console
    }
}