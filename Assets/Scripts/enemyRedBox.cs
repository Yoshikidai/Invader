using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyRedBox : MonoBehaviour
{
  private GameControllerScript gameController;
  private enemyBlackBox enemyBlackBox;
  private enemyWhiteBox enemyWhiteBox;
  private enemyBlueBox enemyBlueBox;
  public GameObject particleObjectChangePosition;
  public GameObject enemyOF1;
  public int enemyOF1SpawnTime;
  public string enemyOF1Element;
  public GameObject particleObject2;

    // Start is called before the first frame update
    void Start()
    {
      gameController = GameObject.FindWithTag("GameController").GetComponent<GameControllerScript>();

      if(gameController.enemyBoxNumber == 2)
      {
        enemyWhiteBox = GameObject
                    .FindWithTag("enemyBox3")
                    .GetComponent<enemyWhiteBox>();
        enemyBlueBox = GameObject
                    .FindWithTag("enemyBox4")
                    .GetComponent<enemyBlueBox>();

      }
      else if(gameController.enemyBoxNumber == 3)
      {
        enemyBlackBox = GameObject
                    .FindWithTag("enemyBox2")
                    .GetComponent<enemyBlackBox>();
        enemyBlueBox = GameObject
                    .FindWithTag("enemyBox4")
                    .GetComponent<enemyBlueBox>();

      }
      else if(gameController.enemyBoxNumber == 4)
      {
        enemyBlackBox = GameObject
                    .FindWithTag("enemyBox2")
                    .GetComponent<enemyBlackBox>();
        enemyWhiteBox = GameObject
                    .FindWithTag("enemyBox3")
                    .GetComponent<enemyWhiteBox>();

      }

      StartCoroutine("ChangePosition");
      StartCoroutine("SpawnEnemyOF1");
    }

    // Update is called once per frame
    void Update()
    {
      if(gameController.isVictory)
      {
        StopCoroutine("SpawnEnemyOF1");
      }

    }

    IEnumerator ChangePosition()
    {
      yield return new WaitForSeconds(2f);
      int X = 0;

      while(!gameController.isVictory)
      {
        X = Random.Range(-2, 2);

        if(X >= transform.position.x)
        {
          X++;
        }

        if(gameController.enemyBoxNumber == 2)
        {

          if(enemyWhiteBox.transform.position.x == X)
          {
            enemyWhiteBox.transform.position = new Vector3(transform.position.x, 3.5f, 1f);

            Instantiate(
                particleObjectChangePosition,
                new Vector3(transform.position.x, transform.position.y, 3f),
                particleObjectChangePosition.transform.rotation
            ); //パーティクル用ゲームオブジェクト生成

          }

          if(enemyBlueBox.transform.position.x == X)
          {
            enemyBlueBox.transform.position = new Vector3(transform.position.x, 3.5f, 1f);

            Instantiate(
                particleObjectChangePosition,
                new Vector3(transform.position.x, transform.position.y, 3f),
                particleObjectChangePosition.transform.rotation
            ); //パーティクル用ゲームオブジェクト生成

          }

        }
        else if(gameController.enemyBoxNumber == 3)
        {
          if(enemyBlackBox.transform.position.x == X)
          {
            enemyBlackBox.transform.position = new Vector3(transform.position.x, 3.5f, 1f);

            Instantiate(
                particleObjectChangePosition,
                new Vector3(transform.position.x, transform.position.y, 3f),
                particleObjectChangePosition.transform.rotation
            ); //パーティクル用ゲームオブジェクト生成

          }

          if(enemyBlueBox.transform.position.x == X)
          {
            enemyBlueBox.transform.position = new Vector3(transform.position.x, 3.5f, 1f);

            Instantiate(
                particleObjectChangePosition,
                new Vector3(transform.position.x, transform.position.y, 3f),
                particleObjectChangePosition.transform.rotation
            ); //パーティクル用ゲームオブジェクト生成

          }

        }
        else if(gameController.enemyBoxNumber == 4)
        {
          if(enemyBlackBox.transform.position.x == X)
          {
            enemyBlackBox.transform.position = new Vector3(transform.position.x, 3.5f, 1f);

            Instantiate(
                particleObjectChangePosition,
                new Vector3(transform.position.x, transform.position.y, 3f),
                particleObjectChangePosition.transform.rotation
            ); //パーティクル用ゲームオブジェクト生成

          }

          if(enemyWhiteBox.transform.position.x == X)
          {
            enemyWhiteBox.transform.position = new Vector3(transform.position.x, 3.5f, 1f);

            Instantiate(
                particleObjectChangePosition,
                new Vector3(transform.position.x, transform.position.y, 3f),
                particleObjectChangePosition.transform.rotation
            ); //パーティクル用ゲームオブジェクト生成

          }

        }



        transform.position = new Vector3(X, 3.5f, 1f);

        Instantiate(
            particleObjectChangePosition,
            new Vector3(transform.position.x, transform.position.y, 3f),
            particleObjectChangePosition.transform.rotation
        ); //パーティクル用ゲームオブジェクト生成


        yield return new WaitForSeconds(8f);
      }

    }

    IEnumerator SpawnEnemyOF1()
    {
        while (true)
        {
            Instantiate(
                enemyOF1,
                new Vector3(transform.position.x, transform.position.y, 0f),
                transform.rotation
            );
            Instantiate(
                particleObject2,
                new Vector3(transform.position.x, transform.position.y, -3f),
                particleObject2.transform.rotation
            ); //パーティクル用ゲームオブジェクト生成

            yield return new WaitForSeconds(enemyOF1SpawnTime);
        }
    }

}
