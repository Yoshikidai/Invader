using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyBlackBox : MonoBehaviour
{
  private GameControllerScript gameController;
  private enemyRedBox enemyRedBox;
  private enemyWhiteBox enemyWhiteBox;


    // Start is called before the first frame update
    void Start()
    {
      gameController = GameObject
          .FindWithTag("GameController")
          .GetComponent<GameControllerScript>();
      enemyRedBox = GameObject
                  .FindWithTag("enemyRedBox")
                  .GetComponent<enemyRedBox>();
      enemyWhiteBox = GameObject
                  .FindWithTag("enemyWhiteBox")
                  .GetComponent<enemyWhiteBox>();
      StartCoroutine("ChangePosition");
    }

    // Update is called once per frame
    void Update()
    {
      StopCoroutine(ChangePosition());
    }

    IEnumerator ChangePosition()
    {
      yield return new WaitForSeconds(6f);
      int X = 0;
      Debug.Log("Change2");

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

        if(enemyWhiteBox.transform.position.x == X)
        {
          enemyWhiteBox.transform.position = new Vector3(transform.position.x, 3.5f, 1f);
        }

        transform.position = new Vector3(X, 3.5f, 1f);

        yield return new WaitForSeconds(9f);
      }

    }

}
