using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickVolume : MonoBehaviour
{
    [SerializeField] private GameObject _slider;
    [SerializeField] private GameObject buttonMusicVolume;
    public void Click()
    {
        GameObject bmv = Instantiate(buttonMusicVolume, transform.position, Quaternion.identity);
        Destroy(bmv, 1f);
        StartCoroutine(ClickVolumeButton());
    }
    
    private IEnumerator ClickVolumeButton()
    {
        _slider.SetActive(true);
        yield return new WaitForSeconds(7f);
        _slider.SetActive(false);
    }
}
