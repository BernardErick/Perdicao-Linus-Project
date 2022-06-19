using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChanger : MonoBehaviour
{
    public Animator animator;

    public int levelToLoad;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    //dispara o FaadeOut
    public void FadeToLevel (int levelIndex)
    {
        levelToLoad = levelIndex;
        animator.SetTrigger("FadeOut");
    }

    //carrega novo level quando FadeToLevel terminar
    public void OnFadeComplete()
    {
        Cursor.visible = true;
        SceneManager.LoadScene("falamansa");
        
    }
}
