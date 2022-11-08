using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NextScene1 : MonoBehaviour 
{
    public int sceneIndex;
    
    void Start()
    {
        GetComponent<Button> ().onClick.AddListener (() => {
            ClickEvent ();
        });
    }
    
    void ClickEvent()
    {
		SceneManager.LoadScene(sceneIndex);
    }
}
