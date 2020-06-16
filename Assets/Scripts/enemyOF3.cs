using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyOF3 : MonoBehaviour
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

    IEnumerator AttackByPlayerOF1()
    {
      int i = 0;
      while(true)
      {

        if((dis < 3f) && (disX < 1f) && (Apos.y - Bpos.y > 0f))
        {
          i++;
          HitPoint -= gameController.playerOF1Attack;
          Debug.Log("player1 succeeded");
          yield return new WaitForSeconds(gameController.playerOF1Interval * 0.1f);
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

    IEnumerator AttackByPlayerOF2()
    {
      int i = 0;
      while(true)
      {

        if((dis < 3f) && (disX < 1f) && (Apos.y - Bpos.y > 0f))
        {
          i++;
          HitPoint -= gameController.playerOF2Attack;
          Debug.Log("Player2 succeeded");
          yield return new WaitForSeconds(gameController.playerOF2Interval * 0.1f);
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

    IEnumerator AttackByPlayerOF3()
    {
      int i = 0;
      while(true)
      {

        if((dis < 3f) && (disX < 1f) && (Apos.y - Bpos.y > 0f))
        {
          i++;
          HitPoint -= gameController.playerOF3Attack;
          Debug.Log("Player3 succeeded");
          yield return new WaitForSeconds(gameController.playerOF3Interval * 0.1f);
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

    if (collision.gameObject.CompareTag("playerOF1"))
    {
      StartCoroutine(AttackByPlayerOF1());
    }

    if (collision.gameObject.CompareTag("playerOF2"))
    {
      StartCoroutine(AttackByPlayerOF2());
    }

    if (collision.gameObject.CompareTag("playerOF3"))
    {
      StartCoroutine(AttackByPlayerOF3());
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
        transform.position.y - dy,
        0f
      );

      if(gameController.isVictory == true)
      {
        Destroy(gameObject);
      }
    }

    IEnumerator AttackByPlayerOF1()
    {
      while(true)
      {
        HitPoint -= gameController.playerOF1Attack;
        Debug.Log("Player1 succeeded");
        yield return new WaitForSeconds(gameController.enemyOF1Interval);
      }
    }

    IEnumerator AttackByPlayerOF2()
    {
      while(true)
      {
        HitPoint -= gameController.playerOF2Attack;
        Debug.Log("Player2 succeeded");
        yield return new WaitForSeconds(gameController.enemyOF2Interval);
      }
    }

    IEnumerator AttackByPlayerOF3()
    {
      while(true)
      {
        HitPoint -= gameController.playerOF3Attack;
        Debug.Log("Player3 succeeded");
        yield return new WaitForSeconds(gameController.enemyOF3Interval);
      }
    }


}
