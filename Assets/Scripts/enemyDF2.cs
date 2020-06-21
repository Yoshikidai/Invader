using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyDF2 : MonoBehaviour
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
    ElementDamage = 0;

    IEnumerator AttackByPlayerOF1()
    {
      int i = 0;
      while(true)
      {

        if((dis < 4f) && (disX < 1.5f) && (Apos.y - Bpos.y < 0f))
        {
          i++;
          HitPoint -= gameController.playerOF1Attack + ElementDamage;
          Instantiate(
              particleObjectHit,
              new Vector3(transform.position.x, transform.position.y, -3f),
              particleObjectHit.transform.rotation
          ); //パーティクル用ゲームオブジェクト生成
          Debug.Log("Player1 succeeded");
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
          HitPoint -= gameController.playerOF2Attack + ElementDamage;
          Instantiate(
              particleObjectHit,
              new Vector3(transform.position.x, transform.position.y, -3f),
              particleObjectHit.transform.rotation
          ); //パーティクル用ゲームオブジェクト生成
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
          HitPoint -= gameController.playerOF3Attack + ElementDamage;
          Instantiate(
              particleObjectHit,
              new Vector3(transform.position.x, transform.position.y, -3f),
              particleObjectHit.transform.rotation
          ); //パーティクル用ゲームオブジェクト生成
          Debug.Log("Player3 succeeded");
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


    if (collision.gameObject.CompareTag("playerOF1"))
    {
        if(gameController.playerOF1Element == "blue")
        {
          ElementDamage = Mathf.FloorToInt(gameController.playerOF1Attack * 0.2f);
        }

        if(gameController.playerOF1Element == "white")
        {
          ElementDamage = - Mathf.FloorToInt(gameController.playerOF1Attack * 0.2f);
        }

      StartCoroutine(AttackByPlayerOF1());

    }

    if (collision.gameObject.CompareTag("playerOF2"))
    {
      if(gameController.playerOF2Element == "blue")
      {
        ElementDamage = Mathf.FloorToInt(gameController.playerOF2Attack * 0.2f);
      }

      if(gameController.playerOF2Element == "white")
      {
        ElementDamage = - Mathf.FloorToInt(gameController.playerOF2Attack * 0.2f);
      }

      StartCoroutine(AttackByPlayerOF2());

    }

    if (collision.gameObject.CompareTag("playerOF3"))
    {
      if(gameController.playerOF3Element == "blue")
      {
        ElementDamage = Mathf.FloorToInt(gameController.playerOF3Attack * 0.2f);
      }

      if(gameController.playerOF3Element == "white")
      {
        ElementDamage = - Mathf.FloorToInt(gameController.playerOF3Attack * 0.2f);
      }

      StartCoroutine(AttackByPlayerOF3());

    }

  }

    // Start is called before the first frame update
    void Start()
    {
      gameController = GameObject
          .FindWithTag("GameController")
          .GetComponent<GameControllerScript>();
          PositionCorrectionAttack = Mathf.FloorToInt(- transform.position.y + 2.5f);
          PositionCorrectionHitPoint = Mathf.FloorToInt(transform.position.y - 0.5f);
          gameController.enemyDF2Attack = Mathf.FloorToInt(gameController.enemyDF2Attack * (PositionCorrectionAttack * 0.1f + 1f));
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
