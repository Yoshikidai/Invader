using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoundaryScript : MonoBehaviour
{
  private GameControllerScript gameController;

    private void OnTriggerExit2D(Collider2D collision)
    {
      Destroy(collision.gameObject);

      if (collision.gameObject.CompareTag("playerOF"))
      {
        gameController.Win();
      }

      if (collision.gameObject.CompareTag("enemyOF"))
      {
        gameController.Lose();
      }
    }

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

    }
}
