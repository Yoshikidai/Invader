using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyRedBox : MonoBehaviour
{
  private GameControllerScript gameController;
  private enemyBlackBox enemyBlackBox;
  private enemyWhiteBox enemyWhiteBox;


    // Start is called before the first frame update
    void Start()
    {
      gameController = GameObject
          .FindWithTag("GameController")
          .GetComponent<GameControllerScript>();
      enemyBlackBox = GameObject
                  .FindWithTag("enemyBlackBox")
                  .GetComponent<enemyBlackBox>();
      enemyWhiteBox = GameObject
                  .FindWithTag("enemyWhiteBox")
                  .GetComponent<enemyWhiteBox>();
      StartCoroutine(ChangePosition());
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
      yield return new WaitForSeconds(3f);
      int X = 0;
      Debug.Log("Change1");

      while(true)
      {
        X = Random.Range(-2, 2);

        if(X >= transform.position.x)
        {
          X++;
        }

        if(enemyBlackBox.transform.position.x == X)
        {
          enemyBlackBox.transform.position = new Vector3(transform.position.x, 3.5f, 1f);
        }

        if(enemyWhiteBox.transform.position.x == X)
        {
          enemyWhiteBox.transform.position = new Vector3(transform.position.x, 3.5f, 1f);
        }

        transform.position = new Vector3(X, 3.5f, 1f);

        yield return new WaitForSeconds(9f);
      }

    }

}
