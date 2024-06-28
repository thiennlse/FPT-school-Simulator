using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangesSceneController : MonoBehaviour
{
    public float delayTime = 2;
    public string nameScene = "Villages";
    public Vector3 playerPos;
    public VectorValue storagePos;

    // Start is called before the first frame update


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.SetActive(false);
            
            ModeSelect();
        }
    }


    public void ModeSelect()
    {
        storagePos.initialValue = playerPos;
        StartCoroutine(LoadAfterDelay());
    }

    IEnumerator LoadAfterDelay()
    {
        yield return new WaitForSeconds(delayTime);
        
        SceneManager.LoadScene(nameScene);
    }



    /*void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }*/
}
