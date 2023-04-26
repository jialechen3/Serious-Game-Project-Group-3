using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CodeMonkey.Utils;
using UnityEngine.SceneManagement;

public class HealthBar : MonoBehaviour
{

    private Transform bar;
    [SerializeField] private float health = 1f;
    [SerializeField] private float Decreaserate = 0.01f;
    [SerializeField] private float IncreaseRate = 0.3f;

    private void Awake()
    {
        bar = transform.Find("Bar");
    }

    private void Start()
    {

        FunctionPeriodic.Create(() => {
            if (health > .01f)
            {
                health -= Decreaserate;
                SetSize(health);

                if (health < .3f)
                {
                    // Under 30% health
                    if ((int)(health * 100f) % 3 == 0)
                    {
                        SetColor(Color.white);
                    }
                    else
                    {
                        SetColor(Color.red);
                    }
                }
            }
            else if(health < .01f)
            {
                SceneManager.LoadScene("You_Lost_Scene");
            }
            else
            {
                health = 1f;
                SetColor(Color.red);
            }
        }, .05f);
    }


    public void SetSize(float sizeNormalized)
    {
        health = sizeNormalized;
        bar.localScale = new Vector3(sizeNormalized, 1f);
    }

    public void Increase()
    {
        SetSize(health += IncreaseRate);
    }
    public void SetColor(Color color)
    {
        bar.Find("BarSprite").GetComponent<SpriteRenderer>().color = color;
    }
}