using UnityEngine;

public class BasicTranslate : MonoBehaviour
{
    [SerializeField] private Vector3 _speed;
    [SerializeField] private bool _fixedupdate;

    // Update is called once per frame
    void Update()
    {
        if(!_fixedupdate)
            transform.Translate(translation:_speed * Time.deltaTime);
    }


    private void FixedUpdate()
    {
        if(_fixedupdate)
            transform.Translate(translation:_speed * Time.fixedDeltaTime);
    }
}