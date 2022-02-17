using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicStart : MonoBehaviour
{
    [SerializeField] private GameObject music;
    [SerializeField] private GameObject partical;
    private bool isButtonClick = true;
    [SerializeField] private GameObject gameMusic;


    public void ClickMusicOpen()
    {
        GameObject clickMusic = Instantiate(gameMusic, transform.position, Quaternion.identity);
        Destroy(clickMusic, 2f);
            music.SetActive(false);
            partical.SetActive(false);
            GetComponent<Animator>().enabled = false;
    }
    
}
