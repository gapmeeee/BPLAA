using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayCoordinates : MonoBehaviour
{
    public GameObject BPLA;
    public GameObject GhostBPLA;

    public static List<Quaternion> _rotationBPLA = new List<Quaternion>();
    public List<Quaternion> _rotationGhost;
    private Quaternion q = Quaternion.Euler(1f,1f,1f);

    public static List<Vector3> _coordsBPLA = new List<Vector3>();
    public List<Vector3> _coordsGhost;
    public static int i = 0;
    public int count = 0;
    void Awake()
    {   
        GhostBPLA.transform.rotation = Quaternion.Euler(-90f, 0f, 0f);
        _coordsGhost = new List<Vector3>();
        _rotationGhost = new List<Quaternion>();
        count = 0;
        if (i > 0)
        {
            foreach (Vector3 c in _coordsBPLA)
            {
                _coordsGhost.Add(c);
            }
            _coordsGhost = _coordsBPLA;
            _coordsBPLA = new List<Vector3>();
            
            foreach (Quaternion c in _rotationBPLA)
            {
                _rotationGhost.Add(c);
            }
            _rotationGhost = _rotationBPLA;
            _rotationBPLA = new List<Quaternion>();
        }
        i++;
    
    }

    void FixedUpdate()
    {

        if (++count <= _coordsGhost.Count)
        {
            GhostBPLA.transform.position = _coordsGhost[count];
        }

        _coordsBPLA.Add(BPLA.transform.position);
        
        if (++count <= _rotationGhost.Count)
        {
            GhostBPLA.transform.rotation = _rotationGhost[count];
        }

        _rotationBPLA.Add(BPLA.transform.rotation);
    }

}
