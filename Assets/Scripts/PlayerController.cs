using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float maxHealth = 100f;
    public float currentHealth = 100f;

    private float timer = 0f;
    private float damageInterval = 1f; // one second
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Every second, reduce HP by 1
        timer += Time.deltaTime;
        if (timer >= damageInterval)
        {
            timer = 0f;
            currentHealth = Mathf.Max(0, currentHealth - 8f);
        }
    }
}
