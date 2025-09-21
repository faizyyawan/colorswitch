using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public UIManager uiManager;
    public float JumpForce = 10f;
    public Rigidbody2D RB;
    public string currentColor;

    public SpriteRenderer SR;
    public Color ColorCyan;
    public Color ColorYellow;
    public Color ColorPurple;
    public Color ColorPink;
   





   
    

    // Start is called before the first frame update
    void Start()
    {
        SetRandomColor();    
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetButtonDown("Jump") || Input.GetMouseButtonDown(0))
        {
            RB.linearVelocity = Vector2.up * JumpForce;
        }
        
    }

    void OnTriggerEnter2D(Collider2D col)
{
    if (col.tag == "ColorChanger")
    {
        SetRandomColor();
        Destroy(col.gameObject);
        return;
    }

    if (col.tag != currentColor)
    {
        Debug.Log("GAMEEEE OVAAAA");
        uiManager.ShowEndScreen(); // <- Show End Screen here
        return;
    }

    Debug.Log(col.tag);
}

    void SetRandomColor()
    {
        int index = Random.Range(0, 4);

        if (index == 0)
        {
            currentColor = "Cyan";
            SR.color = ColorCyan;
        }
        else if (index == 1)
        {
            currentColor = "Yellow";
            SR.color = ColorYellow;
        }
        else if (index == 2)
        {
            currentColor = "Purple";
            SR.color = ColorPurple;
        }
        else
        {
            currentColor = "Pink";
            SR.color = ColorPink;


        }
      
       
    }
}
