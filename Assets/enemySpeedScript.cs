using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpeedScript : MonoBehaviour
{

    public float beforeSpeed;
    private float afterSpeed;

    private void OnTriggerEnter2D(Collider2D collision)
    {
      Vector3 Apos = collision.gameObject.transform.position;
      Vector3 Bpos = transform.position;
      float dis =
        Mathf.Sqrt(Mathf.Pow(Apos.x - Bpos.x, 2) + Mathf.Pow(Apos.y - Bpos.y, 2));
      float disX = Mathf.Abs(Apos.x - Bpos.x);
      float disY = Mathf.Abs(Apos.y - Bpos.y);

      IEnumerator SpeedUpByEnemyDF1()
      {
        int a1 = 0;
        int a2 = 0;

        while(true)
        {
          if(dis < 3f)
          {
            if(a2 == 0)
            {
              if(this.gameObject.GetComponent<DamageScript>().Element == GameObject.FindWithTag("enemyDF1").GetComponent<DamageScript>().Element)
              {
                afterSpeed = afterSpeed + beforeSpeed * 0.1f;
                a2++;
              }

            }
            a1++;
          }
          else
          {
            if(a1 > 0)
            {
              break;
            }

          }
          yield return null;
        }

      }

      IEnumerator SpeedUpByEnemyDF2()
      {
        int a1 = 0;
        int a2 = 0;

        while(true)
        {
          if(dis < 3f)
          {
            if(a2 == 0)
            {
              if(this.gameObject.GetComponent<DamageScript>().Element == GameObject.FindWithTag("enemyDF2").GetComponent<DamageScript>().Element)
              {
                afterSpeed = afterSpeed + beforeSpeed * 0.1f;
                a2++;
              }

            }
            a1++;
          }
          else
          {
            if(a1 > 0)
            {
              break;
            }

          }
          yield return null;
        }

      }

      IEnumerator SpeedUpByEnemyDF3()
      {
        int a1 = 0;
        int a2 = 0;

        while(true)
        {
          if(dis < 3f)
          {
            if(a2 == 0)
            {
              if(this.gameObject.GetComponent<DamageScript>().Element == GameObject.FindWithTag("enemyDF3").GetComponent<DamageScript>().Element)
              {
                afterSpeed = afterSpeed + beforeSpeed * 0.1f;
                a2++;
              }

            }
            a1++;
          }
          else
          {
            if(a1 > 0)
            {
              break;
            }

          }
          yield return null;
        }

      }

      IEnumerator SpeedUpByEnemyDF4()
      {
        int a1 = 0;
        int a2 = 0;

        while(true)
        {
          if(dis < 3f)
          {
            if(a2 == 0)
            {
              if(this.gameObject.GetComponent<DamageScript>().Element == GameObject.FindWithTag("enemyDF4").GetComponent<DamageScript>().Element)
              {
                afterSpeed = afterSpeed + beforeSpeed * 0.1f;
                a2++;
              }

            }
            a1++;
          }
          else
          {
            if(a1 > 0)
            {
              break;
            }

          }
          yield return null;
        }

      }

      IEnumerator SpeedUpByEnemyDF5()
      {
        int a1 = 0;
        int a2 = 0;

        while(true)
        {
          if(dis < 3f)
          {
            if(a2 == 0)
            {
              if(this.gameObject.GetComponent<DamageScript>().Element == GameObject.FindWithTag("enemyDF5").GetComponent<DamageScript>().Element)
              {
                afterSpeed = afterSpeed + beforeSpeed * 0.1f;
                a2++;
              }

            }
            a1++;
          }
          else
          {
            if(a1 > 0)
            {
              break;
            }

          }
          yield return null;
        }

      }

      IEnumerator SpeedUpByEnemyDF6()
      {
        int a1 = 0;
        int a2 = 0;

        while(true)
        {
          if(dis < 3f)
          {
            if(a2 == 0)
            {
              if(this.gameObject.GetComponent<DamageScript>().Element == GameObject.FindWithTag("enemyDF6").GetComponent<DamageScript>().Element)
              {
                afterSpeed = afterSpeed + beforeSpeed * 0.1f;
                a2++;
              }

            }
            a1++;
          }
          else
          {
            if(a1 > 0)
            {
              break;
            }

          }
          yield return null;
        }

      }

      if (collision.gameObject.CompareTag("enemyDF1"))
      {
        StartCoroutine(SpeedUpByEnemyDF1());
      }
      if (collision.gameObject.CompareTag("enemyDF2"))
      {
        StartCoroutine(SpeedUpByEnemyDF2());
      }
      if (collision.gameObject.CompareTag("enemyDF3"))
      {
        StartCoroutine(SpeedUpByEnemyDF3());
      }
      if (collision.gameObject.CompareTag("enemyDF4"))
      {
        StartCoroutine(SpeedUpByEnemyDF4());
      }
      if (collision.gameObject.CompareTag("enemyDF5"))
      {
        StartCoroutine(SpeedUpByEnemyDF5());
      }
      if (collision.gameObject.CompareTag("enemyDF6"))
      {
        StartCoroutine(SpeedUpByEnemyDF6());
      }

    }

    // Start is called before the first frame update
    void Start()
    {
      afterSpeed = beforeSpeed;
    }

    // Update is called once per frame
    void Update()
    {
      float dy = Time.deltaTime * afterSpeed * 0.1f;

      transform.position = new Vector3
      (
        transform.position.x,
        transform.position.y + dy,
        0f
      );
    }
}
