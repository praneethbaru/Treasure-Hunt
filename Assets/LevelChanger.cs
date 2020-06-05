
using UnityEngine;
using UnityEngine.SceneManagement;


public class LevelChanger : MonoBehaviour
{

    public Animator animator;

    private int levelToLoad;

    // Update is called once per frame
    void Update()
    {
        if (MasterScore.score == 10)
       
        {
            
            FadeToLevel(1);
        }
        
    }

   
    public void FadeToLevel(int levelIndex)

    {
        
        animator.SetTrigger("FadeOut");
        
    }


    public void OnFadeComplete()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        MasterScore.score = 0;

    }
}
