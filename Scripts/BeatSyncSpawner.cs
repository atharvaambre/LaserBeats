using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeatSyncSpawner : MonoBehaviour
{
//public float size = 10.0f;
//public float amplitude = 1.0f;
//public int cutoffSample = 128; //MUST BE LOWER THAN SAMPLE SIZE
    public float spawnThreshold = 0.5f;
    public int frequency = 0;
    public GameObject placeBeatHere;
    public FFTWindow fftWindow;

    public float debugValue;
    private float [] samples = new float [1024]; //MUST BE A POWER OF TWO
//private LineRenderer lineRenderer;
//private float stepSize;
    void Start()
    {
    }    
    void Update ()
    {   
        AudioListener.GetSpectrumData(samples,0, fftWindow);
        debugValue = samples[frequency];
        if(samples[frequency]>spawnThreshold)
        {
            Instantiate(placeBeatHere,transform.position,transform.rotation);
        }
    }
    
}
