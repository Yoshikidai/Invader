using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerSpeedScript : MonoBehaviour
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

      IEnumerator SpeedUpByPlayerDF1()
      {
        int a1 = 0;
        int a2 = 0;

        while(true)
        {
          if(dis < 3f)
          {
            if(a2 == 0)
            {
              if(this.gameObject.GetComponent<DamageScript>().Element == GameObject.FindWithTag("playerDF1").GetComponent<DamageScript>().Element)
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

      IEnumerator SpeedUpByPlayerDF2()
      {
        int a1 = 0;
        int a2 = 0;

        while(true)
        {
          if(dis < 3f)
          {
            if(a2 == 0)
            {
              if(this.gameObject.GetComponent<DamageScript>().Element == GameObject.FindWithTag("playerDF2").GetComponent<DamageScript>().Element)
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

      IEnumerator SpeedUpByPlayerDF3()
      {
        int a1 = 0;
        int a2 = 0;

        while(true)
        {
          if(dis < 3f)
          {
            if(a2 == 0)
            {
              if(this.gameObject.GetComponent<DamageScript>().Element == GameObject.FindWithTag("playerDF3").GetComponent<DamageScript>().Element)
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

      IEnumerator SpeedUpByPlayerDF4()
      {
        int a1 = 0;
        int a2 = 0;

        while(true)
        {
          if(dis < 3f)
          {
            if(a2 == 0)
            {
              if(this.gameObject.GetComponent<DamageScript>().Element == GameObject.FindWithTag("playerDF4").GetComponent<DamageScript>().Element)
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

      IEnumerator SpeedUpByPlayerDF5()
      {
        int a1 = 0;
        int a2 = 0;

        while(true)
        {
          if(dis < 3f)
          {
            if(a2 == 0)
            {
              if(this.gameObject.GetComponent<DamageScript>().Element == GameObject.FindWithTag("playerDF5").GetComponent<DamageScript>().Element)
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

      IEnumerator SpeedUpByPlayerDF6()
      {
        int a1 = 0;
        int a2 = 0;

        while(true)
        {
          if(dis < 3f)
          {
            if(a2 == 0)
            {
              if(this.gameObject.GetComponent<DamageScript>().Element == GameObject.FindWithTag("playerDF6").GetComponent<DamageScript>().Element)
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

      if (collision.gameObject.CompareTag("playerDF1"))
      {
        StartCoroutine(SpeedUpByPlayerDF1());
      }
      if (collision.gameObject.CompareTag("playerDF2"))
      {
        StartCoroutine(SpeedUpByPlayerDF2());
      }
      if (collision.gameObject.CompareTag("playerDF3"))
      {
        StartCoroutine(SpeedUpByPlayerDF3());
      }
      if (collision.gameObject.CompareTag("playerDF4"))
      {
        StartCoroutine(SpeedUpByPlayerDF4());
      }
      if (collision.gameObject.CompareTag("playerDF5"))
      {
        StartCoroutine(SpeedUpByPlayerDF5());
      }
      if (collision.gameObject.CompareTag("playerDF6"))
      {
        StartCoroutine(SpeedUpByPlayerDF6());
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
