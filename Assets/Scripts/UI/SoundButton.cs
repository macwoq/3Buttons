using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


[RequireComponent(typeof(AudioSource))]
public class SoundButton : MonoBehaviour
{
    //[SerializeField] Button include1, include2, include3;
    AudioSource source;
    private bool use1, use2, use3;
    //public AudioClip[] clickSounds;
    [SerializeField] AudioClip sound1, sound2, sound3;
    private List<AudioClip> clips;

    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
        clips = new List<AudioClip>(3);
        //AddSound1();
    }

    public void AddSound1()
    {
        use1 = !use1;
        if (use1)
        {
            var include1 = GameObject.Find("Sound1");
            clips.Add(sound1);
            include1.GetComponent<Image>().color = Color.green;
        }
        else
        {
            var include1 = GameObject.Find("Sound1");
            clips.Remove(sound1);
            include1.GetComponent<Image>().color = Color.red;
        }
    }

    public void AddSound2()
    {
        use2 = !use2;
        if (use2)
        {
            var include2 = GameObject.Find("Sound2");
            clips.Add(sound2);
            include2.GetComponent<Image>().color = Color.green;
        }
        else
        {
            var include2 = GameObject.Find("Sound2");
            clips.Remove(sound2);
            include2.GetComponent<Image>().color = Color.red;
        }
    }

    public void AddSound3()
    {
        use3 = !use3;
        if (use3)
        {
            var include3 = GameObject.Find("Sound3");
            clips.Add(sound3);
            include3.GetComponent<Image>().color = Color.green;
        }
        else
        {
            var include3 = GameObject.Find("Sound3");
            clips.Remove(sound3);
            include3.GetComponent<Image>().color = Color.red;
        }
    }

    public void PlayRandom()
    {
        if (clips.Count > 0)
        {
            var soundClip = Random.Range(0, clips.Count);
            source.PlayOneShot(clips[soundClip]);
        }
        else
        {
            return;
        }
    }
}
