using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Play_Button : MonoBehaviour
{
    private Animator _anim;

    private void Start()
    {
        _anim = GetComponent<Animator>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            PlayAnim();
        } 

        if (transform.position.y >= 6.8)
        {
            SceneManager.LoadScene(1);
        }
    }
    public void PlayAnim()
    {
            _anim.SetTrigger("Play");
    }
}
