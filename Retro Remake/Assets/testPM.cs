using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testPM : MonoBehaviour
{
    public int numberOfItems, score;       // Ints represtents WHOLE NUMBERS
    public float health, weight, speed;    // Floats are DECIMAL NUMBERS
    public string dialogue, characterName;  // Strings represent WORDS
    public bool isEffectActive, isGrounded; // Bools represent values that are TRIE OR FALSE
    public Vector2 size, playerLocation;    // Vector2s represent 2-DIMENSIONAL DECIMALS

    // Start is called before the first frame update

    void Start()
    {
        Debug.Log("Dereks favorte student is" + characterName);

        if (isGrounded)
        {   // Will execute the below code IF THE STATEMENT IN TGE PARENTHESUS CLEARLY

            Debug.Log("On the floor crying");
        }

        {
        }
    }
}
