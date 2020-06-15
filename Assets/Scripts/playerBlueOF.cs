using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerBlueOF : MonoBehaviour
{
  private GameControllerScript gameController;
  public int HitPoint;
  public int Attack;
  public int Interval;
  public int Speed;

  private void OnTriggerExit2D(Collider2D collision)
  {
    if (collision.gameObject.CompareTag("enemyOF"))
    {

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
      float dy = Time.deltaTime * Speed * 0.1f;

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
