using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerOF : MonoBehaviour
{
  private GameControllerScript gameController;
  public int HitPoint;
  public int Speed;

  private void OnTriggerStay2D(Collider2D collision)
  {
    if (collision.gameObject.CompareTag("enemyOF1"))
    {
      StartCoroutine(AttackByEnemyOF1());
    }

    if (collision.gameObject.CompareTag("enemyOF2"))
    {
      StartCoroutine(AttackByEnemyOF2());
    }

    if (collision.gameObject.CompareTag("enemyOF1"))
    {
      StartCoroutine(AttackByEnemyOF3());
    }

    if(HitPoint <= 0)
    {
      Destroy(gameObject);
    }

  }

    // Start is called before the first frame update
    void Start()
    {
      gameController = GameObject
          .FindWithTag("GameController")
          .GetComponent<GameControllerScript>();
    }

    // Update is called once per frame
    void Update()
    {
      float dy = Time.deltaTime * Speed * 0.1f;

      transform.position = new Vector3(
        transform.position.x,
        transform.position.y + dy,
        0f
      );

      if(gameController.isDefeat == true)
      {
        Destroy(gameObject);
      }
    }

    IEnumerator AttackByEnemyOF1()
    {
      while(true)
      {
        HitPoint -= gameController.enemyOF1Attack;
        Debug.Log("Enemy1 succeeded");
        yield return new WaitForSeconds(gameController.enemyOF1Interval);
      }
    }

    IEnumerator AttackByEnemyOF2()
    {
      while(true)
      {
        HitPoint -= gameController.enemyOF2Attack;
        Debug.Log("Enemy2 succeeded");
        yield return new WaitForSeconds(gameController.enemyOF2Interval);
      }
    }

    IEnumerator AttackByEnemyOF3()
    {
      while(true)
      {
        HitPoint -= gameController.enemyOF3Attack;
        Debug.Log("Enemy3 succeeded");
        yield return new WaitForSeconds(gameController.enemyOF3Interval);
      }
    }
}
