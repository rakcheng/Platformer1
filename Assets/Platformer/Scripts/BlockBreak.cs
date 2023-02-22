using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BlockBreak : MonoBehaviour
{
    public Camera camera;
    public GameObject coinCounter;
    public int coins = 0;

    // Start is called before the first frame update
    void Start()
    {
        coinCounter.GetComponent<TextMeshProUGUI>().text = "Coins\n" + coins.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out RaycastHit hitInfo))
            {
                if (hitInfo.collider.gameObject.CompareTag("bTag"))
                {
                    Destroy(hitInfo.collider.gameObject);
                }
                else if (hitInfo.collider.gameObject.CompareTag("qTag"))
                {
                    coins++;
                    coinCounter.GetComponent<TextMeshProUGUI>().text = "Coins\n" + coins.ToString();
                }
            }
        }
    }
}