using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blueOF : MonoBehaviour
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
      float dy = Time.deltaTime * 0.2f;

      transform.position = new Vector3(
        transform.position.x,
        transform.position.y + dy,
        0f
      );

      if(gameController.isDefeat)
      {
        Destroy(gameObject);
      }
    }
}
