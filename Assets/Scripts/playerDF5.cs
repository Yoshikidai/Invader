using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerDF5 : MonoBehaviour
{
  private GameControllerScript gameController;
  public int HitPoint;
  public string Element;
  private int ElementDamage;
  private int PositionCorrectionAttack;
  private int PositionCorrectionHitPoint;
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
          Debug.Log("enemy1 succeeded");
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
          Debug.Log("enemy2 succeeded");
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
          Debug.Log("enemy3 succeeded");
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


    if (collision.gameObject.CompareTag("enemyOF1"))
    {
        if(gameController.enemyOF1Element == "white")
        {
          ElementDamage = Mathf.FloorToInt(gameController.enemyOF1Attack * 0.2f);
        }

        if(gameController.enemyOF1Element == "blue")
        {
          ElementDamage = - Mathf.FloorToInt(gameController.enemyOF1Attack * 0.2f);
        }

      StartCoroutine(AttackByEnemyOF1());

    }

    if (collision.gameObject.CompareTag("enemyOF2"))
    {
      if(gameController.enemyOF2Element == "white")
      {
        ElementDamage = Mathf.FloorToInt(gameController.enemyOF2Attack * 0.2f);
      }

      if(gameController.enemyOF2Element == "blue")
      {
        ElementDamage = - Mathf.FloorToInt(gameController.enemyOF2Attack * 0.2f);
      }

      StartCoroutine(AttackByEnemyOF2());

    }

    if (collision.gameObject.CompareTag("enemyOF3"))
    {
      if(gameController.enemyOF3Element == "white")
      {
        ElementDamage = Mathf.FloorToInt(gameController.enemyOF3Attack * 0.2f);
      }

      if(gameController.enemyOF3Element == "blue")
      {
        ElementDamage = - Mathf.FloorToInt(gameController.enemyOF3Attack * 0.2f);
      }

      StartCoroutine(AttackByEnemyOF3());

    }
  }

    // Start is called before the first frame update
    void Start()
    {
      gameController = GameObject
          .FindWithTag("GameController")
          .GetComponent<GameControllerScript>();

      PositionCorrectionAttack = Mathf.FloorToInt(transform.position.y + 2.5f);
      PositionCorrectionHitPoint = Mathf.FloorToInt(- transform.position.y - 0.5f);
      gameController.playerDF5Attack = Mathf.FloorToInt(gameController.playerDF5Attack * (PositionCorrectionAttack * 0.1f + 1f));
      HitPoint = Mathf.FloorToInt(HitPoint * (PositionCorrectionHitPoint * 0.1f + 1f));

    }

    // Update is called once per frame
    void Update()
    {

      if(HitPoint <= 0)
      {
        Destroy(gameObject);
      }

      if(gameController.isDefeat == true)
      {
        Destroy(gameObject);
      }

    }

}
