using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class ClickToGame : MonoBehaviour
{
    [SerializeField] private string sceneName;
    [SerializeField] private GameObject gameMusicru;
    private Animator animator;
    private void Start()
    {
        animator = GetComponent<Animator>();
    }
    public void Click()
    {
        
        StartCoroutine(CorClick());
    }
    private IEnumerator CorClick()
    {
        GameObject clickMusic = Instantiate(gameMusicru, transform.position, Quaternion.identity);
        Destroy(clickMusic, 1f);
        yield return new WaitForSeconds(0.2f);
        animator.SetTrigger("Flow");
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(sceneName);


    }
}
