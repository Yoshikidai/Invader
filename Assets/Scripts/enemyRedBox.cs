using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyRedBox : MonoBehaviour
{
  private GameControllerScript gameController;
  private enemyBlackBox enemyBlackBox;
  private enemyWhiteBox enemyWhiteBox;
  public GameObject particleObjectChangePosition;

    // Start is called before the first frame update
    void Start()
    {
      gameController = GameObject
          .FindWithTag("GameController")
          .GetComponent<GameControllerScript>();
      enemyBlackBox = GameObject
                  .FindWithTag("enemyBox2")
                  .GetComponent<enemyBlackBox>();
      enemyWhiteBox = GameObject
                  .FindWithTag("enemyBox3")
                  .GetComponent<enemyWhiteBox>();
      StartCoroutine("ChangePosition");
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator ChangePosition()
    {
      yield return new WaitForSeconds(3f);
      int X = 0;

      while(!gameController.isVictory)
      {
        X = Random.Range(-2, 2);

        if(X >= transform.position.x)
        {
          X++;
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

        if(enemyWhiteBox.transform.position.x == X)
        {
          enemyWhiteBox.transform.position = new Vector3(transform.position.x, 3.5f, 1f);

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
