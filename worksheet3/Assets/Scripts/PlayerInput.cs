using UnityEngine;
using System.Collections;
using Unity.VisualScripting;

public class PlayerInput : MonoBehaviour
{         
    GameObject bob, alice; // declare bob and alice
    int playerHP = 10; //This is our hp
    int playerDamage = 3;
    Enemy _bob_instance, _alice_instance;
    void Start()
    {
        bob = Instantiate(Resources.Load("Bob"),new Vector3(-2f,0f, 0f), Quaternion.identity) as GameObject;//Bob has 5 hp, 2 damage, and a name of Bob
        alice = Instantiate(Resources.Load("Alice"), new Vector3(2f, 0f, 0f), Quaternion.identity) as GameObject;//Bob has 5 hp, 2 damage, and a name of Bob
        _bob_instance = bob.GetComponent<Enemy>();
        _alice_instance = alice.GetComponent<Enemy>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            //Bob takes damage if Spacebar is pressed
            _bob_instance.TakeDamage(playerDamage);
        else if (Input.GetKeyDown(KeyCode.LeftShift))
            //Alice takes damage if left shift is pressed
            _alice_instance.TakeDamage();
        else if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            //Player takes damage from bob if left control is pressed
            playerHP -= _bob_instance .damage;
            Debug.Log("Player HP: " + playerHP);
        }
        else if (Input.GetKeyDown(KeyCode.LeftAlt))
        {
            //Player takes damage from alice if left alt is pressed
            playerHP -= _alice_instance .damage;
            Debug.Log("Player HP: " + playerHP);
        }
        if (playerHP < 1) {
            //if our hp is under 1, we die
            Debug.Log("You Died!");
            QuitGame();
        }


        if (_bob_instance.hitpoints <1 && _alice_instance.hitpoints <1)
        {
            Debug.Log("You Won!");
            QuitGame();
        }


    }

    public void QuitGame()
    {
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #endif
        Application.Quit();
    }

}
