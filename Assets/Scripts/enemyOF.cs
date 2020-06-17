using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyOF : MonoBehaviour
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

        if((dis < 4f) && (disX < 1.5f) && (Apos.y - Bpos.y < 0f))
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
      int j = 0;
      while(true)
      {

        if((dis < 4f) && (disX < 1.5f) && (Apos.y - Bpos.y < 0f))
        {
          j++;
          HitPoint -= gameController.playerOF2Attack;
          Debug.Log("Player2 succeeded");
          yield return new WaitForSeconds(gameController.playerOF2Interval * 0.1f);
        }
        else
        {
          if(j > 0)
          {
            break;
          }
          yield return null;
        }
      }

    }

    IEnumerator AttackByPlayerOF3()
    {
      int k = 0;
      while(true)
      {

        if((dis < 4f) && (disX < 1.5f) && (Apos.y - Bpos.y < 0f))
        {
          k++;
          HitPoint -= gameController.playerOF3Attack;
          Debug.Log("player3 succeeded");
          yield return new WaitForSeconds(gameController.playerOF3Interval * 0.1f);
        }
        else
        {
          if(k > 0)
          {
            break;
          }
          yield return null;
        }

      }

    }

    IEnumerator AttackByPlayerDF1()
    {
      int A = 0;
      while(true)
      {

        if(dis < 3f)
        {
          A++;
          HitPoint -= gameController.playerDF1Attack;
          Debug.Log("playerDF1 succeeded");
          yield return new WaitForSeconds(gameController.playerDF1Interval * 0.1f);
        }
        else
        {
          if(A > 0)
          {
            break;
          }
          yield return null;
        }

      }

    }

    IEnumerator AttackByPlayerDF2()
    {
      int B = 0;
      while(true)
      {

        if(dis < 3f)
        {
          B++;
          HitPoint -= gameController.playerDF2Attack;
          Debug.Log("playerDF2 succeeded");
          yield return new WaitForSeconds(gameController.playerDF2Interval * 0.1f);
        }
        else
        {
          if(B > 0)
          {
            break;
          }
          yield return null;
        }

      }

    }

    IEnumerator AttackByPlayerDF3()
    {
      int C = 0;
      while(true)
      {

        if(dis < 3f)
        {
          C++;
          HitPoint -= gameController.playerDF3Attack;
          Debug.Log("playerDF3 succeeded");
          yield return new WaitForSeconds(gameController.playerDF3Interval * 0.1f);
        }
        else
        {
          if(C > 0)
          {
            break;
          }
          yield return null;
        }

      }

    }

    IEnumerator AttackByPlayerDF4()
    {
      int D = 0;
      while(true)
      {

        if(dis < 3f)
        {
          D++;
          HitPoint -= gameController.playerDF4Attack;
          Debug.Log("playerDF4 succeeded");
          yield return new WaitForSeconds(gameController.playerDF4Interval * 0.1f);
        }
        else
        {
          if(D > 0)
          {
            break;
          }
          yield return null;
        }

      }

    }

    IEnumerator AttackByPlayerDF5()
    {
      int E = 0;
      while(true)
      {

        if(dis < 3f)
        {
          E++;
          HitPoint -= gameController.playerDF5Attack;
          Debug.Log("playerDF5 succeeded");
          yield return new WaitForSeconds(gameController.playerDF5Interval * 0.1f);
        }
        else
        {
          if(E > 0)
          {
            break;
          }
          yield return null;
        }

      }

    }

    IEnumerator AttackByPlayerDF6()
    {
      int F = 0;
      while(true)
      {

        if(dis < 3f)
        {
          F++;
          HitPoint -= gameController.playerDF6Attack;
          Debug.Log("playerDF6 succeeded");
          yield return new WaitForSeconds(gameController.playerDF6Interval * 0.1f);
        }
        else
        {
          if(F > 0)
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

    if (collision.gameObject.CompareTag("playerDF1"))
    {
      StartCoroutine(AttackByPlayerDF1());
    }

    if (collision.gameObject.CompareTag("playerDF2"))
    {
      StartCoroutine(AttackByPlayerDF2());
    }

    if (collision.gameObject.CompareTag("playerDF3"))
    {
      StartCoroutine(AttackByPlayerDF3());
    }

    if (collision.gameObject.CompareTag("playerDF4"))
    {
      StartCoroutine(AttackByPlayerDF4());
    }

    if (collision.gameObject.CompareTag("playerDF5"))
    {
      StartCoroutine(AttackByPlayerDF5());
    }

    if (collision.gameObject.CompareTag("playerDF6"))
    {
      StartCoroutine(AttackByPlayerDF6());
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

      if(HitPoint <= 0)
      {
        Destroy(gameObject);
      }

      if(transform.position.y < gameController.transform.position.y)
      {
        gameController.Lose();
      }

      if(gameController.isVictory == true)
      {
        Destroy(gameObject);
      }
    }

}
