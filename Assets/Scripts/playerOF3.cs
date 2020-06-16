using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerOF3 : MonoBehaviour
{
  private GameControllerScript gameController;
  public int HitPoint;
  public int Speed;


  private void OnTriggerEnter2D(Collider2D collision)
  {

    Vector3 Apos = collision.gameObject.transform.position;
    Vector3 Bpos = transform.position;
    float dis = Vector3.Distance(Apos,Bpos);
    float disX = Mathf.Abs(Apos.x - Bpos.x);
    float disY = Mathf.Abs(Apos.y - Bpos.y);

    IEnumerator AttackByEnemyOF1()
    {
      int i = 0;
      while(true)
      {

        if((dis < 3f) && (disX < 1f) && (Apos.y - Bpos.y > 0f))
        {
          i++;
          HitPoint -= gameController.enemyOF1Attack;
          Debug.Log("Enemy1 succeeded");
          yield return new WaitForSeconds(gameController.enemyOF1Interval * 0.1f);
        }
        else
        {
          if(i > 0)
          {
            break;
          }
          yield return null;
        }

      }
    }

    IEnumerator AttackByEnemyOF2()
    {
      int i = 0;
      while(true)
      {

        if((dis < 3f) && (disX < 1f) && (Apos.y - Bpos.y > 0f))
        {
          i++;
          HitPoint -= gameController.enemyOF2Attack;
          Debug.Log("Enemy2 succeeded");
          yield return new WaitForSeconds(gameController.enemyOF2Interval * 0.1f);
        }
        else
        {
          if(i > 0)
          {
            break;
          }
          yield return null;
        }
      }
    }

    IEnumerator AttackByEnemyOF3()
    {
      int i = 0;
      while(true)
      {

        if((dis < 3f) && (disX < 1f) && (Apos.y - Bpos.y > 0f))
        {
          i++;
          HitPoint -= gameController.enemyOF3Attack;
          Debug.Log("Enemy3 succeeded");
          yield return new WaitForSeconds(gameController.enemyOF3Interval * 0.1f);
        }
        else
        {
          if(i > 0)
          {
            break;
          }
          yield return null;
        }
      }
    }


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

}
