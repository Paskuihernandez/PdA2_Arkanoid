using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {


    public GameObject Player1;
    public GameObject Player2;

    public float moveSpeed = 300;

    private Rigidbody2D playerBody;
    private float ScreenWidth;
    private float ScreenHeight;

    // Use this for initialization
    void Start () {
        ScreenWidth = Screen.width;
        ScreenHeight = Screen.height;
        playerBody = Player1.GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        
    }
}
