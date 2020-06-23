using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyWhiteBox : MonoBehaviour
{
  private GameControllerScript gameController;
  private enemyRedBox enemyRedBox;
  private enemyBlackBox enemyBlackBox;
  public GameObject particleObjectChangePosition;

    // Start is called before the first frame update
    void Start()
    {
      gameController = GameObject
          .FindWithTag("GameController")
          .GetComponent<GameControllerScript>();
      enemyRedBox = GameObject
                  .FindWithTag("enemyBox1")
                  .GetComponent<enemyRedBox>();
      enemyBlackBox = GameObject
                  .FindWithTag("enemyBox2")
                  .GetComponent<enemyBlackBox>();
      StartCoroutine("ChangePosition");
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    IEnumerator ChangePosition()
    {
      yield return new WaitForSeconds(9f);
      int X = 0;

      while(!gameController.isVictory)
      {
        X = Random.Range(-2, 2);

        if(X >= transform.position.x)
        {
          X++;
        }

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

        transform.position = new Vector3(X, 3.5f, 1f);

        Instantiate(
            particleObjectChangePosition,
            new Vector3(transform.position.x, transform.position.y, 3f),
            particleObjectChangePosition.transform.rotation
        ); //パーティクル用ゲームオブジェクト生成


        yield return new WaitForSeconds(9f);
      }

    }

}
