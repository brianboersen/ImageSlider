using UnityEngine;
using System.Collections;
using UnityEngine.UI;

//[RequireComponent (typeof (AudioSource))]
public class MoviePlay : MonoBehaviour
{
    public MovieTexture movie;
    private AudioSource audio;
    void start()
    {
        RawImage currentImage = GetComponent<RawImage>();//.texture = movie as MovieTexture;
        audio = GetComponent<AudioSource>();
        audio.clip = movie.audioClip;
        //movie.Play();
        MovieTexture mt = (MovieTexture)currentImage.mainTexture;
        Debug.Log("test");
        mt.Play();
        audio.Play();
    }
    
}
