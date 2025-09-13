using System;
using UnityEngine;

public class UITrigger : MonoBehaviour
{
   
    [SerializeField] private Animator animator;
    [SerializeField] private bool useAnimator;
    
    
    
    private AudioSource audioSource;
    private GameObject ui3DObject;

    private void Awake()
    {
            animator = GetComponentInChildren<Animator>();
            ui3DObject = animator.gameObject;

    }

    void Start()
    {
        
        if (audioSource == null)
        {
            audioSource = GetComponentInChildren<AudioSource>();
        }

        if (!useAnimator)
        {
            ui3DObject.SetActive(false);
        }
     
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
          audioSource.Play();
          if (useAnimator)
            animator.Play("appearing plant");
            
           ui3DObject.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            audioSource.Play();
            if (useAnimator)
            animator.Play("diappearing plant");
            
          ui3DObject.SetActive(false);
        }
    }
}
