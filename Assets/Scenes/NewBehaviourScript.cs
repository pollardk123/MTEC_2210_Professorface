using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject Professor;
    private SpriteRenderer beardSprite;
    private SpriteRenderer hairSprite;
    private SpriteRenderer faceSprite;
    // Start is called before the first frame update
    void Start()
    {
        Professor = GameObject.Find("Honsi");
        // beard = professor.transform.Getchild(0).gameObject;
        hairSprite = Professor.transform.GetChild(1).gameObject.GetComponent<SpriteRenderer>();
        faceSprite = Professor.transform.GetChild(2).gameObject.GetComponent<SpriteRenderer>();
        beardSprite = Professor.transform.GetChild(3).gameObject.GetComponent<SpriteRenderer>();


    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(beardSprite.color);
        //beardSprie.color = new Color(50, 150, 100, 50); 
    }
    public void ColorChange()
    {
        beardSprite.color = new Color(0, 100, 50, 255);
        hairSprite.color = new Color(60, 150, 0, 255);
        faceSprite.color = new Color(0, 0, 150, 255);

}    }