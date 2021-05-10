using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameManager instance;

    private int totalCollectables = 8;
    public int collectedCollectables = 0;

    public Text collectableCounter;
    public bool heldrock = false;

    public AudioClip collectableSFX;
    private AudioSource audSource;
    
    
    // Start is called before the first frame update
    void Start()
    {
        heldrock = false;
        if (instance == null)
        {
            DontDestroyOnLoad(this.gameObject);
            instance = this;
        }

        audSource = this.gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        collectableCounter.text = "Collectables Acquired: " + collectedCollectables + "/" + totalCollectables;
    }
    
    public void collectSFX()
    {
        audSource.PlayOneShot(collectableSFX);
    }
    
}
