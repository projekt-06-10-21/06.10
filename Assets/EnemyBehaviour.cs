using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    public int hp = 3;
    public float speed = 3;
    GameObject player;
    GameManager gm;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        gm = Camera.main.GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void FixedUpdate()
    {
        Vector3 direction = player.transform.position - transform.position;
        direction.Normalize();
        transform.position += direction * Time.deltaTime * speed;
        //Debug.Log(direction.ToString());
        //Vector2.Lerp(transform.position, player.transform.position, Time.deltaTime);
        //transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(player.transform.position - transform.position), Time.deltaTime);
    }
    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    //    hp--;
    //    if(hp <= 0)
    //        Destroy(transform.gameObject);
    //}
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(collision.collider.gameObject);
        hp--;
        if (hp <= 0)
        {
            Destroy(transform.gameObject);
            gm.score += 100;
        }

    }
}