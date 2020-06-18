using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyWhiteBox : MonoBehaviour
{
  private GameControllerScript gameController;
  private enemyBlackBox enemyBlackBox;
  private enemyRedBox enemyRedBox;


    // Start is called before the first frame update
    void Start()
    {
      gameController = GameObject
          .FindWithTag("GameController")
          .GetComponent<GameControllerScript>();
      enemyBlackBox = GameObject
                  .FindWithTag("enemyBlackBox")
                  .GetComponent<enemyBlackBox>();
      enemyRedBox = GameObject
                  .FindWithTag("enemyRedBox")
                  .GetComponent<enemyRedBox>();
      StartCoroutine("ChangePosition");
    }

    // Update is called once per frame
    void Update()
    {
      if(gameController.isVictory)
      {
        StopCoroutine("ChangePosition");
      }
    }

    IEnumerator ChangePosition()
    {
      yield return new WaitForSeconds(9f);
      int X = 0;
      Debug.Log("Change3");

      while(true)
      {
        X = Random.Range(-2, 2);

        if(X >= transform.position.x)
        {
          X++;
        }

        if(enemyRedBox.transform.position.x == X)
        {
          enemyRedBox.transform.position = new Vector3(transform.position.x, 3.5f, 1f);
        }

        if(enemyBlackBox.transform.position.x == X)
        {
          enemyBlackBox.transform.position = new Vector3(transform.position.x, 3.5f, 1f);
        }

        transform.position = new Vector3(X, 3.5f, 0f);

        yield return new WaitForSeconds(9f);
      }

    }

}
