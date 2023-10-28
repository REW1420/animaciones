using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{

    private Animator animator;
    private Animation ani;
    private AnimationClip[] animationClips;
    [SerializeField] private Player player;
    private void Start()
    {
        ani = GetComponent<Animation>();
    }
    private void Awake()
    {
        animator = GetComponent<Animator>();

    }

    private void Update()
    {
        animator.SetBool("IsWalking", player.IsWalking());


    }
}
