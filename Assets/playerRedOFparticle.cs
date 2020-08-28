using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerRedOFparticle : MonoBehaviour
{

  float normalPower;
  private float weakPower;
  private float strongPower;
  private ParticleSystem ps;

  void OnParticleCollision(GameObject obj)
  {
    if(obj.GetComponent<DamageScript>().Element == "blue")
    {
      obj.GetComponent<DamageScript>().Damage(weakPower);
    }
    else if(obj.GetComponent<DamageScript>().Element == "white")
    {
      obj.GetComponent<DamageScript>().Damage(strongPower);
    }
    else
    {
      obj.GetComponent<DamageScript>().Damage(normalPower);
    }

  }

    // Start is called before the first frame update
    void Start()
    {
      normalPower = PlayerPrefs.GetInt("RedOffenceATK", 50);
      weakPower = normalPower * 0.8f;
      strongPower = normalPower * 1.2f;

      ps = this.GetComponent<ParticleSystem>();
      ps.Stop();
      ParticleSystem.MainModule main = ps.main;
      main.duration = PlayerPrefs.GetInt("RedOffenceITV", 50) * 0.1f;
      ps.Play();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
