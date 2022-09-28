using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterOrbsCollection : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(90 * Time.deltaTime, 0, 0);

    }

    private void OnTriggerEnter(Collider other)
    {
        if (gameObject.CompareTag("MonsterOrbs"))
        {
            other.GetComponent<PplayerMovement>().points--;

        }

        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
}
