using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Informaions : MonoBehaviour
{
    [SerializeField] private GameObject panel;
    [SerializeField] private GameObject informations;
    [SerializeField] private GameObject musicButton;
    [SerializeField] private GameObject music;
    [SerializeField] GameObject clickMusic;
    public void ButtonClick()
    {
        Destroy(informations);
        panel.SetActive(true);
        Invoke("DeleteObject",20f);
    }
    public void MusicClick()
    {
        GameObject basicClickMusic = Instantiate(clickMusic, transform.position, Quaternion.identity);
        Destroy(basicClickMusic, 5f);
    }
    private void DeleteObject()
    {
        Destroy(panel);
        musicButton.SetActive(true);
        music.SetActive(true);
    }
}
