using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Scripting.APIUpdating;

public class PlayerController : MonoBehaviour
{
    public float speed = 0.5f;
    public float jumeForce = 5f;
    public LayerMask whatIsground;
    public float groundCheckDistance;
    
    public Rigidbody2D myRig;
    public Respawner respawner;

    public int score = 0;
    public int life = 5;

    public GameManager gm;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        if(h != 0)
        {
            Move(h); 
        }

        if(Input.GetButtonDown("Jump") && GroundCheck())
        {
            myRig.AddForce(Vector2.up * jumeForce, ForceMode2D.Impulse);
        }
    }

    private bool GroundCheck()
    {
        RaycastHit2D[] hitInfos = Physics2D.RaycastAll(transform.position, Vector2.down, groundCheckDistance, whatIsground);
        return hitInfos.Length > 0;
    }

    private void Move(float direction)
    {
       
        myRig.AddTorque(direction * speed * -1f, ForceMode2D.Force);

        //Vector2 fore = new Vecto2(direction = speed, 0);
        //myRig.AddForce(force, ForceMode2D.Force);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log($"{collision.gameObject.name} Hit me!!");
    }

    public void AddScore(int score) 
    {
        this.score += score;
        gm.UpdateScoreUi(this.score);
    }

    public void Die()
    {
        life--; // life = Life -1 => Life -= 1
        if(life <= 0)
        {
            gm.LoseGame();
            this.enabled = false;
        }

        // Respawn Player
        respawner.Respawn();
        gm.UpdateLifeUi(life);
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.cyan;
        Gizmos.DrawLine(transform.position, transform.position + (Vector3.down * groundCheckDistance));
    }
}
