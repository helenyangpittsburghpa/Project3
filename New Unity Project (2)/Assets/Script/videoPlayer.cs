using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class videoPlayer : MonoBehaviour
{
    public RawImage image;
    public VideoPlayer player;
    //https://www.youtube.com/watch?v=zCq0Jt6m8BQ
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(playVideo());
    }

    // Update is called once per frame
   IEnumerator playVideo()
    {
        player.Prepare();
        WaitForSeconds waitForSeconds = new WaitForSeconds(1);
        while(!player.isPrepared)
        {
            yield return waitForSeconds;
            break;
        }
        image.texture = player.texture;
        player.Play();
    }
}
