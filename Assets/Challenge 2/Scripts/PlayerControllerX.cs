using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float spamTime = 3.0f;

    void Start()
    {
        StartCoroutine("SendDogSystem");
    }

    private IEnumerator SendDogSystem()
    {
        while (true)
        {
            yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.Space));

            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);

            yield return new WaitForSeconds(spamTime);
        }
    }

}
