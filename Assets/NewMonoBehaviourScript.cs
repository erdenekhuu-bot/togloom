using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for(int i=0; i<10; ++i)
        {
            GameObject go = new GameObject();
            go.transform.parent = transform;
            go.transform.localPosition = new Vector3();
            go.transform.localRotation = Quaternion.identity;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
