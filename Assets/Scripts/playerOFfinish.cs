using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerOFfinish : MonoBehaviour
{
  private GameControllerScript gameController;
  bool goal;
  
    // Start is called before the first frame update
    void Start()
    {
      goal = false;
      gameController = GameObject
          .FindWithTag("GameController")
          .GetComponent<GameControllerScript>();

    }

    // Update is called once per frame
    void Update()
    {

      if(transform.position.y > -gameController.transform.position.y)
      {
        if(goal == false)
        {
          gameController.Win();
          goal = true;

        }
      }

      if(gameController.isDefeat == true)
      {
        Destroy(gameObject);
      }

    }
}
