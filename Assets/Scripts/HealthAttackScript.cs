using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HealthAttackScript : MonoBehaviour
{
    public Slider healthbar;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Monster" || other.gameObject.tag == "Player")
        {
            if (healthbar.value <= 0)
            {
                SceneManager.LoadScene("GameOver");
                MasterScore.score = 0;
            }
            healthbar.value -= 1;
            
            
        }
    }
}
