using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewPlayer : PhysicsObject
{
    [SerializeField] private float maxSpeed = 1f;
    [SerializeField] private float jumpPower = 10f;
    public int coinscollected;
    public int health = 10;
    public int ammo;

    public Text Cointext;
    public Image healthbar;
    [SerializeField]private Vector2 healthbaroriginalsize;


    // Start is called before the first frame update
    void Start()
    {
        healthbaroriginalsize = healthbar.rectTransform.sizeDelta;

        
    }

    // Update is called once per frame
    void Update()
    {
        targetVelocity = new Vector2(Input.GetAxis("Horizontal") * maxSpeed , 0);


        //if the player presses jump set velocity to a jump power value 
        if (Input.GetButtonDown("Jump") && grounded == true)
        {
            velocity.y = jumpPower;
        }
    }

    //new function - update ui elements 
    public void updateUI()
    {
        Cointext.text = coinscollected.ToString();

        //healthbar witdth control
        healthbar.rectTransform.sizeDelta = new Vector2(100,healthbar.rectTransform.sizeDelta.y);
    }

}
