using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyOFfinish : MonoBehaviour
{
  private GameControllerScript gameController;

    // Start is called before the first frame update
    void Start()
    {
      gameController = GameObject
          .FindWithTag("GameController")
          .GetComponent<GameControllerScript>();

    }

    // Update is called once per frame
    void Update()
    {
      if(transform.position.y < gameController.transform.position.y)
      {
        gameController.Lose();
      }

      if(gameController.isVictory == true)
      {
        Destroy(gameObject);
      }

    }
}
