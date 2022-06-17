using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            this.transform.Translate(-0.2f, 0.0f, 0.0f);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            this.transform.Translate(0.2f, 0.0f, 0.0f);
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            this.transform.Translate(0.2f, 0.0f, -0.5f);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            this.transform.Translate(0.2f, 0.0f, 0.5f);
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
                //SceneManager.LoadScene("Pause");
        }
    }
}