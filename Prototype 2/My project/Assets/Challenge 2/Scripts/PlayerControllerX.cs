using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;

    bool isReady;

    private void Start()
    {
        isReady = true;
    }

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (isReady && Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine(PreventSpam());
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }
    }

    IEnumerator PreventSpam()
    {
        isReady = false;
        yield return new WaitForSeconds(2f);
        isReady = true;
    }
}
