using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyWhiteBox : MonoBehaviour
{
  private GameControllerScript gameController;
  private enemyRedBox enemyRedBox;
  private enemyBlackBox enemyBlackBox;
  private enemyBlueBox enemyBlueBox;
  public GameObject particleObjectChangePosition;
  public GameObject enemyOF3;
  public int enemyOF3SpawnTime;
  public string enemyOF3Element;
  public GameObject particleObject2;

    // Start is called before the first frame update
    void Start()
    {
      gameController = GameObject.FindWithTag("GameController").GetComponent<GameControllerScript>();

      if(gameController.enemyBoxNumber == 1)
      {
        enemyBlackBox = GameObject
                    .FindWithTag("enemyBox2")
                    .GetComponent<enemyBlackBox>();
        enemyBlueBox = GameObject
                    .FindWithTag("enemyBox4")
                    .GetComponent<enemyBlueBox>();

      }
      else if(gameController.enemyBoxNumber == 2)
      {
        enemyRedBox = GameObject
                    .FindWithTag("enemyBox1")
                    .GetComponent<enemyRedBox>();
        enemyBlueBox = GameObject
                    .FindWithTag("enemyBox4")
                    .GetComponent<enemyBlueBox>();

      }
      else if(gameController.enemyBoxNumber == 4)
      {
        enemyRedBox = GameObject
                    .FindWithTag("enemyBox1")
                    .GetComponent<enemyRedBox>();
        enemyBlackBox = GameObject
                    .FindWithTag("enemyBox2")
                    .GetComponent<enemyBlackBox>();

      }

      StartCoroutine("ChangePosition");
      StartCoroutine("SpawnEnemyOF3");

    }

    // Update is called once per frame
    void Update()
    {
      if(gameController.isVictory)
      {
        StopCoroutine("SpawnEnemyOF3");
      }

    }

    IEnumerator ChangePosition()
    {
      yield return new WaitForSeconds(6f);
      int X = 0;

      while(!gameController.isVictory)
      {
        X = Random.Range(-2, 2);

        if(X >= transform.position.x)
        {
          X++;
        }

        if(gameController.enemyBoxNumber == 1)
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
        else if(gameController.enemyBoxNumber == 2)
        {
          if(enemyRedBox.transform.position.x == X)
          {
            enemyRedBox.transform.position = new Vector3(transform.position.x, 3.5f, 1f);

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
          if(enemyRedBox.transform.position.x == X)
          {
            enemyRedBox.transform.position = new Vector3(transform.position.x, 3.5f, 1f);

            Instantiate(
                particleObjectChangePosition,
                new Vector3(transform.position.x, transform.position.y, 3f),
                particleObjectChangePosition.transform.rotation
            ); //パーティクル用ゲームオブジェクト生成

          }

          if(enemyBlackBox.transform.position.x == X)
          {
            enemyBlackBox.transform.position = new Vector3(transform.position.x, 3.5f, 1f);

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

    IEnumerator SpawnEnemyOF3()
    {
        while (true)
        {
            Instantiate(
                enemyOF3,
                new Vector3(transform.position.x, transform.position.y, 0f),
                transform.rotation
            );
            Instantiate(
                particleObject2,
                new Vector3(transform.position.x, transform.position.y, -3f),
                particleObject2.transform.rotation
            ); //パーティクル用ゲームオブジェクト生成
            yield return new WaitForSeconds(enemyOF3SpawnTime);
        }

    }

}
