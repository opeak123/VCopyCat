using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCotroller : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    Animator animator;
    Rigidbody2D rigidbody2D;
    private float h, v;
    private float playerMoveSpeed = 2f;

    

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        PlayerMove();
    }

    private void PlayerMove()
    {
        h = Input.GetAxis("Horizontal") * playerMoveSpeed * Time.deltaTime;
        v = Input.GetAxis("Vertical") * playerMoveSpeed * Time.deltaTime;

        this.transform.position = new Vector2(transform.position.x + h, 
            transform.position.y + v);

        if (v > 0.001f)
        {
            animator.SetBool("walk", true);
            Debug.Log("top");
        }
        else if (v < -0.001f)
        {
            animator.SetBool("walk",true);
            Debug.Log("bottom");
        }
        else if (h > 0.001f)
        {
            spriteRenderer.flipX = false;
            animator.SetBool("walk", true); 
            Debug.Log("right");
        }
        else if (h < -0.001f)
        {
            animator.SetBool("walk", true);
            spriteRenderer.flipX = true;
            Debug.Log("left");
        }
        else
        {
            animator.SetBool("walk", false);
        }
    }

    private float PlayerSpeed(float _playerSpeed)
    {


        return _playerSpeed; 
    }

    private void PlayerValue()
    {
        PlayerInfo newPlayerinfo = new PlayerInfo();
        
        newPlayerinfo.SetHP = 100;
        newPlayerinfo.SetAtSpeed = 10;
        newPlayerinfo.SetDamage = 5;
        newPlayerinfo.SetDef = 10;
    }
}


public class PlayerInfo
{
    private int playerLevel = 1;
    private int playerMaxLevel = 100;
    private int playerMaxHp = 100;
    private int playerHp;
    private int damage;
    private int attackSpeed;
    private int def;

    public void MyplayerLevel(int m_exp)
    {
        //m_exp = 
        playerLevel += m_exp;

    }

    private int PlayerMaxHP(int _playerMaxhp)
    {
        _playerMaxhp = playerMaxHp;
        return _playerMaxhp;
    }

    public int SetHP
    {
        get { return playerHp; }
        set { playerHp = value; }
    }

    public int SetDamage
    {
        get { return damage; }
        set { damage = value; }
    }

    public int SetAtSpeed
    {
        get { return attackSpeed; }
        set { attackSpeed = value; }
    }
    public int SetDef
    {
        get { return def; }
        set { def = value; }
    }
}

