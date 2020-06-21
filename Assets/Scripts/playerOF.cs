using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerOF : MonoBehaviour
{
  private GameControllerScript gameController;
  public int HitPoint;
  public int beforeSpeed;
  private float afterSpeed;
  public string Element;
  private int ElementDamage;
  public GameObject particleObjectHit;

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

        if((dis < 4f) && (disX < 1.5f) && (Apos.y - Bpos.y > 0f))
        {
          i++;
          HitPoint -= gameController.enemyOF1Attack + ElementDamage;
          Instantiate(
              particleObjectHit,
              new Vector3(transform.position.x, transform.position.y, -3f),
              particleObjectHit.transform.rotation
          ); //パーティクル用ゲームオブジェクト生成
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
      int j = 0;
      while(true)
      {

        if((dis < 4f) && (disX < 1.5f) && (Apos.y - Bpos.y > 0f))
        {
          j++;
          HitPoint -= gameController.enemyOF2Attack + ElementDamage;
          Instantiate(
              particleObjectHit,
              new Vector3(transform.position.x, transform.position.y, -3f),
              particleObjectHit.transform.rotation
          ); //パーティクル用ゲームオブジェクト生成
          Debug.Log("Enemy2 succeeded");
          yield return new WaitForSeconds(gameController.enemyOF2Interval * 0.1f);
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

    IEnumerator AttackByEnemyOF3()
    {
      int k = 0;
      while(true)
      {

        if((dis < 4f) && (disX < 1.5f) && (Apos.y - Bpos.y > 0f))
        {
          k++;
          HitPoint -= gameController.enemyOF3Attack + ElementDamage;
          Instantiate(
              particleObjectHit,
              new Vector3(transform.position.x, transform.position.y, -3f),
              particleObjectHit.transform.rotation
          ); //パーティクル用ゲームオブジェクト生成
          Debug.Log("Enemy3 succeeded");
          yield return new WaitForSeconds(gameController.enemyOF3Interval * 0.1f);
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

    IEnumerator AttackByEnemyDF1()
    {
      int A = 0;
      while(true)
      {

        if(dis < 3f)
        {
          A++;
          HitPoint -= gameController.enemyDF1Attack + ElementDamage;
          Instantiate(
              particleObjectHit,
              new Vector3(transform.position.x, transform.position.y, -3f),
              particleObjectHit.transform.rotation
          ); //パーティクル用ゲームオブジェクト生成
          Debug.Log("EnemyDF1 succeeded");
          yield return new WaitForSeconds(gameController.enemyDF1Interval * 0.1f);
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

    IEnumerator AttackByEnemyDF2()
    {
      int B = 0;
      while(true)
      {

        if(dis < 3f)
        {
          B++;
          HitPoint -= gameController.enemyDF2Attack + ElementDamage;
          Instantiate(
              particleObjectHit,
              new Vector3(transform.position.x, transform.position.y, -3f),
              particleObjectHit.transform.rotation
          ); //パーティクル用ゲームオブジェクト生成
          Debug.Log("EnemyDF2 succeeded");
          yield return new WaitForSeconds(gameController.enemyDF2Interval * 0.1f);
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

    IEnumerator AttackByEnemyDF3()
    {
      int C = 0;
      while(true)
      {

        if(dis < 3f)
        {
          C++;
          HitPoint -= gameController.enemyDF3Attack + ElementDamage;
          Instantiate(
              particleObjectHit,
              new Vector3(transform.position.x, transform.position.y, -3f),
              particleObjectHit.transform.rotation
          ); //パーティクル用ゲームオブジェクト生成
          Debug.Log("EnemyDF3 succeeded");
          yield return new WaitForSeconds(gameController.enemyDF3Interval * 0.1f);
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

    IEnumerator AttackByEnemyDF4()
    {
      int D = 0;
      while(true)
      {

        if(dis < 3f)
        {
          D++;
          HitPoint -= gameController.enemyDF4Attack + ElementDamage;
          Instantiate(
              particleObjectHit,
              new Vector3(transform.position.x, transform.position.y, -3f),
              particleObjectHit.transform.rotation
          ); //パーティクル用ゲームオブジェクト生成
          Debug.Log("EnemyDF4 succeeded");
          yield return new WaitForSeconds(gameController.enemyDF4Interval * 0.1f);
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

    IEnumerator AttackByEnemyDF5()
    {
      int E = 0;
      while(true)
      {

        if(dis < 3f)
        {
          E++;
          HitPoint -= gameController.enemyDF5Attack + ElementDamage;
          Instantiate(
              particleObjectHit,
              new Vector3(transform.position.x, transform.position.y, -3f),
              particleObjectHit.transform.rotation
          ); //パーティクル用ゲームオブジェクト生成
          Debug.Log("EnemyDF5 succeeded");
          yield return new WaitForSeconds(gameController.enemyDF5Interval * 0.1f);
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

    IEnumerator AttackByEnemyDF6()
    {
      int F = 0;
      while(true)
      {

        if(dis < 3f)
        {
          F++;
          HitPoint -= gameController.enemyDF6Attack + ElementDamage;
          Instantiate(
              particleObjectHit,
              new Vector3(transform.position.x, transform.position.y, -3f),
              particleObjectHit.transform.rotation
          ); //パーティクル用ゲームオブジェクト生成
          Debug.Log("EnemyDF6 succeeded");
          yield return new WaitForSeconds(gameController.enemyDF6Interval * 0.1f);
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

    IEnumerator SpeedUpByPlayerDF1()
    {
      int a1 = 0;
      int a2 = 0;

      while(true)
      {
        if(dis < 3f)
        {
          if(a2 == 0)
          {
            if(Element == gameController.playerDF1Element)
            {
              afterSpeed = afterSpeed + beforeSpeed * 0.2f;
              a2++;
            }

          }
          a1++;
        }
        else
        {
          if(a1 > 0)
          {
            if(a2 > 0)
            {
              afterSpeed = afterSpeed - beforeSpeed * 0.2f;
            }
            break;
          }

        }
        yield return null;
      }

    }

    IEnumerator SpeedUpByPlayerDF2()
    {
      int a1 = 0;
      int a2 = 0;

      while(true)
      {
        if(dis < 3f)
        {
          if(a2 == 0)
          {
            if(Element == gameController.playerDF2Element)
            {
              afterSpeed = afterSpeed + beforeSpeed * 0.2f;
              a2++;
            }

          }
          a1++;
        }
        else
        {
          if(a1 > 0)
          {
            if(a2 > 0)
            {
              afterSpeed = afterSpeed - beforeSpeed * 0.2f;
            }
            break;
          }

        }
        yield return null;
      }

    }

    IEnumerator SpeedUpByPlayerDF3()
    {
      int a1 = 0;
      int a2 = 0;

      while(true)
      {
        if(dis < 3f)
        {
          if(a2 == 0)
          {
            if(Element == gameController.playerDF3Element)
            {
              afterSpeed = afterSpeed + beforeSpeed * 0.2f;
              a2++;
            }

          }
          a1++;
        }
        else
        {
          if(a1 > 0)
          {
            if(a2 > 0)
            {
              afterSpeed = afterSpeed - beforeSpeed * 0.2f;
            }
            break;
          }

        }
        yield return null;
      }

    }

    IEnumerator SpeedUpByPlayerDF4()
    {
      int a1 = 0;
      int a2 = 0;

      while(true)
      {
        if(dis < 3f)
        {
          if(a2 == 0)
          {
            if(Element == gameController.playerDF4Element)
            {
              afterSpeed = afterSpeed + beforeSpeed * 0.2f;
              a2++;
            }

          }
          a1++;
        }
        else
        {
          if(a1 > 0)
          {
            if(a2 > 0)
            {
              afterSpeed = afterSpeed - beforeSpeed * 0.2f;
            }
            break;
          }

        }
        yield return null;
      }

    }

    IEnumerator SpeedUpByPlayerDF5()
    {
      int a1 = 0;
      int a2 = 0;

      while(true)
      {
        if(dis < 3f)
        {
          if(a2 == 0)
          {
            if(Element == gameController.playerDF5Element)
            {
              afterSpeed = afterSpeed + beforeSpeed * 0.2f;
              a2++;
            }

          }
          a1++;
        }
        else
        {
          if(a1 > 0)
          {
            if(a2 > 0)
            {
              afterSpeed = afterSpeed - beforeSpeed * 0.2f;
            }
            break;
          }

        }
        yield return null;
      }

    }

    IEnumerator SpeedUpByPlayerDF6()
    {
      int a1 = 0;
      int a2 = 0;

      while(true)
      {
        if(dis < 3f)
        {
          if(a2 == 0)
          {
            if(Element == gameController.playerDF6Element)
            {
              afterSpeed = afterSpeed + beforeSpeed * 0.2f;
              a2++;
            }

          }
          a1++;
        }
        else
        {
          if(a1 > 0)
          {
            if(a2 > 0)
            {
              afterSpeed = afterSpeed - beforeSpeed * 0.2f;
            }
            break;
          }

        }
        yield return null;
      }

    }


    if (collision.gameObject.CompareTag("enemyOF1"))
    {
      if(Element == "black")
      {
        if(gameController.enemyOF1Element == "white")
        {
          ElementDamage = Mathf.FloorToInt(gameController.enemyOF1Attack * 0.2f);
        }

        if(gameController.enemyOF1Element == "blue")
        {
          ElementDamage = - Mathf.FloorToInt(gameController.enemyOF1Attack * 0.2f);
        }

      }

      if(Element == "blue")
      {
        if(gameController.enemyOF1Element == "black")
        {
          ElementDamage = Mathf.FloorToInt(gameController.enemyOF1Attack * 0.2f);
        }

        if(gameController.enemyOF1Element == "red")
        {
          ElementDamage = - Mathf.FloorToInt(gameController.enemyOF1Attack * 0.2f);
        }

      }

      if(Element == "red")
      {
        if(gameController.enemyOF1Element == "blue")
        {
          ElementDamage = Mathf.FloorToInt(gameController.enemyOF1Attack * 0.2f);
        }

        if(gameController.enemyOF1Element == "white")
        {
          ElementDamage = - Mathf.FloorToInt(gameController.enemyOF1Attack * 0.2f);
        }

      }

      if(Element == "white")
      {
        if(gameController.enemyOF1Element == "red")
        {
          ElementDamage = Mathf.FloorToInt(gameController.enemyOF1Attack * 0.2f);
        }

        if(gameController.enemyOF1Element == "black")
        {
          ElementDamage = - Mathf.FloorToInt(gameController.enemyOF1Attack * 0.2f);
        }

      }

      StartCoroutine(AttackByEnemyOF1());
    }

    if (collision.gameObject.CompareTag("enemyOF2"))
    {
      if(Element == "black")
      {
        if(gameController.enemyOF2Element == "white")
        {
          ElementDamage = Mathf.FloorToInt(gameController.enemyOF2Attack * 0.2f);
        }

        if(gameController.enemyOF2Element == "blue")
        {
          ElementDamage = - Mathf.FloorToInt(gameController.enemyOF2Attack * 0.2f);
        }

      }

      if(Element == "blue")
      {
        if(gameController.enemyOF2Element == "black")
        {
          ElementDamage = Mathf.FloorToInt(gameController.enemyOF2Attack * 0.2f);
        }

        if(gameController.enemyOF2Element == "red")
        {
          ElementDamage = - Mathf.FloorToInt(gameController.enemyOF2Attack * 0.2f);
        }

      }

      if(Element == "red")
      {
        if(gameController.enemyOF2Element == "blue")
        {
          ElementDamage = Mathf.FloorToInt(gameController.enemyOF2Attack * 0.2f);
        }

        if(gameController.enemyOF2Element == "white")
        {
          ElementDamage = - Mathf.FloorToInt(gameController.enemyOF2Attack * 0.2f);
        }

      }

      if(Element == "white")
      {
        if(gameController.enemyOF2Element == "red")
        {
          ElementDamage = Mathf.FloorToInt(gameController.enemyOF2Attack * 0.2f);
        }

        if(gameController.enemyOF2Element == "black")
        {
          ElementDamage = - Mathf.FloorToInt(gameController.enemyOF2Attack * 0.2f);
        }

      }

      StartCoroutine(AttackByEnemyOF2());
    }

    if (collision.gameObject.CompareTag("enemyOF3"))
    {
      if(Element == "black")
      {
        if(gameController.enemyOF3Element == "white")
        {
          ElementDamage = Mathf.FloorToInt(gameController.enemyOF3Attack * 0.2f);
        }

        if(gameController.enemyOF3Element == "blue")
        {
          ElementDamage = - Mathf.FloorToInt(gameController.enemyOF3Attack * 0.2f);
        }

      }

      if(Element == "blue")
      {
        if(gameController.enemyOF3Element == "black")
        {
          ElementDamage = Mathf.FloorToInt(gameController.enemyOF3Attack * 0.2f);
        }

        if(gameController.enemyOF3Element == "red")
        {
          ElementDamage = - Mathf.FloorToInt(gameController.enemyOF3Attack * 0.2f);
        }

      }

      if(Element == "red")
      {
        if(gameController.enemyOF3Element == "blue")
        {
          ElementDamage = Mathf.FloorToInt(gameController.enemyOF3Attack * 0.2f);
        }

        if(gameController.enemyOF3Element == "white")
        {
          ElementDamage = - Mathf.FloorToInt(gameController.enemyOF3Attack * 0.2f);
        }

      }

      if(Element == "white")
      {
        if(gameController.enemyOF3Element == "red")
        {
          ElementDamage = Mathf.FloorToInt(gameController.enemyOF3Attack * 0.2f);
        }

        if(gameController.enemyOF3Element == "black")
        {
          ElementDamage = - Mathf.FloorToInt(gameController.enemyOF3Attack * 0.2f);
        }

      }

      StartCoroutine(AttackByEnemyOF3());
    }

    if (collision.gameObject.CompareTag("enemyDF1"))
    {
      if(Element == "black")
      {
        if(gameController.enemyDF1Element == "white")
        {
          ElementDamage = Mathf.FloorToInt(gameController.enemyDF1Attack * 0.2f);
        }

        if(gameController.enemyDF1Element == "blue")
        {
          ElementDamage = - Mathf.FloorToInt(gameController.enemyDF1Attack * 0.2f);
        }

      }

      if(Element == "blue")
      {
        if(gameController.enemyDF1Element == "black")
        {
          ElementDamage = Mathf.FloorToInt(gameController.enemyDF1Attack * 0.2f);
        }

        if(gameController.enemyDF1Element == "red")
        {
          ElementDamage = - Mathf.FloorToInt(gameController.enemyDF1Attack * 0.2f);
        }

      }

      if(Element == "red")
      {
        if(gameController.enemyDF1Element == "blue")
        {
          ElementDamage = Mathf.FloorToInt(gameController.enemyDF1Attack * 0.2f);
        }

        if(gameController.enemyDF1Element == "white")
        {
          ElementDamage = - Mathf.FloorToInt(gameController.enemyDF1Attack * 0.2f);
        }

      }

      if(Element == "white")
      {
        if(gameController.enemyDF1Element == "red")
        {
          ElementDamage = Mathf.FloorToInt(gameController.enemyDF1Attack * 0.2f);
        }

        if(gameController.enemyDF1Element == "black")
        {
          ElementDamage = - Mathf.FloorToInt(gameController.enemyDF1Attack * 0.2f);
        }

      }

      StartCoroutine(AttackByEnemyDF1());
    }

    if (collision.gameObject.CompareTag("enemyDF2"))
    {
      if(Element == "black")
      {
        if(gameController.enemyDF2Element == "white")
        {
          ElementDamage = Mathf.FloorToInt(gameController.enemyDF2Attack * 0.2f);
        }

        if(gameController.enemyDF2Element == "blue")
        {
          ElementDamage = - Mathf.FloorToInt(gameController.enemyDF2Attack * 0.2f);
        }

      }

      if(Element == "blue")
      {
        if(gameController.enemyDF2Element == "black")
        {
          ElementDamage = Mathf.FloorToInt(gameController.enemyDF2Attack * 0.2f);
        }

        if(gameController.enemyDF2Element == "red")
        {
          ElementDamage = - Mathf.FloorToInt(gameController.enemyDF2Attack * 0.2f);
        }

      }

      if(Element == "red")
      {
        if(gameController.enemyDF2Element == "blue")
        {
          ElementDamage = Mathf.FloorToInt(gameController.enemyDF2Attack * 0.2f);
        }

        if(gameController.enemyDF2Element == "white")
        {
          ElementDamage = - Mathf.FloorToInt(gameController.enemyDF2Attack * 0.2f);
        }

      }

      if(Element == "white")
      {
        if(gameController.enemyDF2Element == "red")
        {
          ElementDamage = Mathf.FloorToInt(gameController.enemyDF2Attack * 0.2f);
        }

        if(gameController.enemyDF2Element == "black")
        {
          ElementDamage = - Mathf.FloorToInt(gameController.enemyDF2Attack * 0.2f);
        }

      }

      StartCoroutine(AttackByEnemyDF2());
    }

    if (collision.gameObject.CompareTag("enemyDF3"))
    {
      if(Element == "black")
      {
        if(gameController.enemyDF3Element == "white")
        {
          ElementDamage = Mathf.FloorToInt(gameController.enemyDF3Attack * 0.2f);
        }

        if(gameController.enemyDF3Element == "blue")
        {
          ElementDamage = - Mathf.FloorToInt(gameController.enemyDF3Attack * 0.2f);
        }

      }

      if(Element == "blue")
      {
        if(gameController.enemyDF3Element == "black")
        {
          ElementDamage = Mathf.FloorToInt(gameController.enemyDF3Attack * 0.2f);
        }

        if(gameController.enemyDF3Element == "red")
        {
          ElementDamage = - Mathf.FloorToInt(gameController.enemyDF3Attack * 0.2f);
        }

      }

      if(Element == "red")
      {
        if(gameController.enemyDF3Element == "blue")
        {
          ElementDamage = Mathf.FloorToInt(gameController.enemyDF3Attack * 0.2f);
        }

        if(gameController.enemyDF3Element == "white")
        {
          ElementDamage = - Mathf.FloorToInt(gameController.enemyDF3Attack * 0.2f);
        }

      }

      if(Element == "white")
      {
        if(gameController.enemyDF3Element == "red")
        {
          ElementDamage = Mathf.FloorToInt(gameController.enemyDF3Attack * 0.2f);
        }

        if(gameController.enemyDF3Element == "black")
        {
          ElementDamage = - Mathf.FloorToInt(gameController.enemyDF3Attack * 0.2f);
        }

      }

      StartCoroutine(AttackByEnemyDF3());
    }

    if (collision.gameObject.CompareTag("enemyDF4"))
    {
      if(Element == "black")
      {
        if(gameController.enemyDF4Element == "white")
        {
          ElementDamage = Mathf.FloorToInt(gameController.enemyDF4Attack * 0.2f);
        }

        if(gameController.enemyDF4Element == "blue")
        {
          ElementDamage = - Mathf.FloorToInt(gameController.enemyDF4Attack * 0.2f);
        }

      }

      if(Element == "blue")
      {
        if(gameController.enemyDF4Element == "black")
        {
          ElementDamage = Mathf.FloorToInt(gameController.enemyDF4Attack * 0.2f);
        }

        if(gameController.enemyDF4Element == "red")
        {
          ElementDamage = - Mathf.FloorToInt(gameController.enemyDF4Attack * 0.2f);
        }

      }

      if(Element == "red")
      {
        if(gameController.enemyDF4Element == "blue")
        {
          ElementDamage = Mathf.FloorToInt(gameController.enemyDF4Attack * 0.2f);
        }

        if(gameController.enemyDF4Element == "white")
        {
          ElementDamage = - Mathf.FloorToInt(gameController.enemyDF4Attack * 0.2f);
        }

      }

      if(Element == "white")
      {
        if(gameController.enemyDF4Element == "red")
        {
          ElementDamage = Mathf.FloorToInt(gameController.enemyDF4Attack * 0.2f);
        }

        if(gameController.enemyDF4Element == "black")
        {
          ElementDamage = - Mathf.FloorToInt(gameController.enemyDF4Attack * 0.2f);
        }

      }

      StartCoroutine(AttackByEnemyDF4());
    }

    if (collision.gameObject.CompareTag("enemyDF5"))
    {
      if(Element == "black")
      {
        if(gameController.enemyDF5Element == "white")
        {
          ElementDamage = Mathf.FloorToInt(gameController.enemyDF5Attack * 0.2f);
        }

        if(gameController.enemyDF5Element == "blue")
        {
          ElementDamage = - Mathf.FloorToInt(gameController.enemyDF5Attack * 0.2f);
        }

      }

      if(Element == "blue")
      {
        if(gameController.enemyDF5Element == "black")
        {
          ElementDamage = Mathf.FloorToInt(gameController.enemyDF5Attack * 0.2f);
        }

        if(gameController.enemyDF5Element == "red")
        {
          ElementDamage = - Mathf.FloorToInt(gameController.enemyDF5Attack * 0.2f);
        }

      }

      if(Element == "red")
      {
        if(gameController.enemyDF5Element == "blue")
        {
          ElementDamage = Mathf.FloorToInt(gameController.enemyDF5Attack * 0.2f);
        }

        if(gameController.enemyDF5Element == "white")
        {
          ElementDamage = - Mathf.FloorToInt(gameController.enemyDF5Attack * 0.2f);
        }

      }

      if(Element == "white")
      {
        if(gameController.enemyDF5Element == "red")
        {
          ElementDamage = Mathf.FloorToInt(gameController.enemyDF5Attack * 0.2f);
        }

        if(gameController.enemyDF5Element == "black")
        {
          ElementDamage = - Mathf.FloorToInt(gameController.enemyDF5Attack * 0.2f);
        }

      }

      StartCoroutine(AttackByEnemyDF5());
    }

    if (collision.gameObject.CompareTag("enemyDF6"))
    {
      if(Element == "black")
      {
        if(gameController.enemyDF6Element == "white")
        {
          ElementDamage = Mathf.FloorToInt(gameController.enemyDF6Attack * 0.2f);
        }

        if(gameController.enemyDF6Element == "blue")
        {
          ElementDamage = - Mathf.FloorToInt(gameController.enemyDF6Attack * 0.2f);
        }

      }

      if(Element == "blue")
      {
        if(gameController.enemyDF6Element == "black")
        {
          ElementDamage = Mathf.FloorToInt(gameController.enemyDF6Attack * 0.2f);
        }

        if(gameController.enemyDF6Element == "red")
        {
          ElementDamage = - Mathf.FloorToInt(gameController.enemyDF6Attack * 0.2f);
        }

      }

      if(Element == "red")
      {
        if(gameController.enemyDF6Element == "blue")
        {
          ElementDamage = Mathf.FloorToInt(gameController.enemyDF6Attack * 0.2f);
        }

        if(gameController.enemyDF6Element == "white")
        {
          ElementDamage = - Mathf.FloorToInt(gameController.enemyDF6Attack * 0.2f);
        }

      }

      if(Element == "white")
      {
        if(gameController.enemyDF6Element == "red")
        {
          ElementDamage = Mathf.FloorToInt(gameController.enemyDF6Attack * 0.2f);
        }

        if(gameController.enemyDF6Element == "black")
        {
          ElementDamage = - Mathf.FloorToInt(gameController.enemyDF6Attack * 0.2f);
        }

      }

      StartCoroutine(AttackByEnemyDF6());
    }

    if (collision.gameObject.CompareTag("playerDF1"))
    {
      StartCoroutine(SpeedUpByPlayerDF1());
    }
    if (collision.gameObject.CompareTag("playerDF2"))
    {
      StartCoroutine(SpeedUpByPlayerDF2());
    }
    if (collision.gameObject.CompareTag("playerDF3"))
    {
      StartCoroutine(SpeedUpByPlayerDF3());
    }
    if (collision.gameObject.CompareTag("playerDF4"))
    {
      StartCoroutine(SpeedUpByPlayerDF4());
    }
    if (collision.gameObject.CompareTag("playerDF5"))
    {
      StartCoroutine(SpeedUpByPlayerDF5());
    }
    if (collision.gameObject.CompareTag("playerDF6"))
    {
      StartCoroutine(SpeedUpByPlayerDF6());
    }


  }

    // Start is called before the first frame update
    void Start()
    {
      afterSpeed = beforeSpeed;
      gameController = GameObject
          .FindWithTag("GameController")
          .GetComponent<GameControllerScript>();
    }

    // Update is called once per frame
    void Update()
    {
      float dy = Time.deltaTime * afterSpeed * 0.1f;

      transform.position = new Vector3(
        transform.position.x,
        transform.position.y + dy,
        0f
      );

      if(HitPoint <= 0)
      {
        Destroy(gameObject);
      }

      if(transform.position.y > -gameController.transform.position.y)
      {
        gameController.Win();
      }

      if(gameController.isDefeat == true)
      {
        Destroy(gameObject);
      }
    }

}
