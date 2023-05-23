using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EasterEgg : MonoBehaviour
{
    [SerializeField] int spScore;
    // Start is called before the first frame update
    void Start()
    {
        spScore = PersistentData.Instance.GetSpScore();
    }

    // Update is called once per frame
    void Update()
    {
        spScore = PersistentData.Instance.GetSpScore();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        spScore = spScore + 1;
        PersistentData.Instance.SetSpecialScore(spScore);
        Destroy(gameObject);
    }
}
