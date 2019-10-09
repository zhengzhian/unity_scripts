using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPS : MonoBehaviour
{

    private float lastTime;
    private float fps;

    private float fpsUpdateInterval = 0.5f;     //FPS刷新间隔
    private float lastUpdateTime;

    // Start is called before the first frame update
    void Start()
    {

    }

    void OnGUI()
    {
        GUILayout.TextField(string.Format("{0} FPS", fps.ToString("F0")));
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.realtimeSinceStartup - lastUpdateTime > fpsUpdateInterval)
        {
            fps = 1 / (Time.realtimeSinceStartup - lastTime);
            lastUpdateTime = Time.realtimeSinceStartup;
        }
        lastTime = Time.realtimeSinceStartup;
    }
}
