using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerOFfinish : MonoBehaviour
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
      if(transform.position.y > -gameController.transform.position.y)
      {
        gameController.Win();
      }

      if(gameController.isDefeat == true)
      {
        Destroy(gameObject);
      }

    }
}
