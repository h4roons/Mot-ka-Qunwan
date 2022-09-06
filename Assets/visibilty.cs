using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class visibilty : MonoBehaviour
{
    public List<SkinnedMeshRenderer> renderes;

    public SkinnedMeshRenderer[] skinMesh;
    private MeshRenderer renderer;
    public Transform body;
    public bool visible;
    private void Awake()
    {
        renderer = this.GetComponent<MeshRenderer>();
    }
    
    public void setVisibilty(bool s)
    {
       
        skinMesh = body.GetComponentsInChildren<SkinnedMeshRenderer>();
        foreach (var renderer in skinMesh)
        {
            renderer.enabled = s;
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (renderer.isVisible)
        {
            setVisibilty(true);
        }
        else
        {
            setVisibilty(false);
        }
    }
    private void OnBecameVisible()
    {
        setVisibilty(true);
        visible = true;
    }
    private void OnBecameInvisible()
    {
        setVisibilty(false);
        visible = false;
    }
}
