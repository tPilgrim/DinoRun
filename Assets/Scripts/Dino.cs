using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Dino : MonoBehaviour
{
    private Rigidbody2D Rb;
    private bool IsGrounded = true;
    public float JumpSpeed;

    private Animator Anim;

    public GameObject Over;
    public GameObject Button;
    public Text ScoreText;
    private int ScoreIndex;

    private AudioSource AudioManager;
    public AudioClip JumpSound;
    public AudioClip LandSound;
    public AudioClip DieSound;

    void Start()
    {
        Rb = GetComponent<Rigidbody2D>();
        Anim = GetComponent<Animator>();
        AudioManager = GetComponent<AudioSource>();
    }
    
    // Face ca dinozaurul sa sara
    void Update()
    {
        if(Input.GetMouseButton(0) && IsGrounded == true) // Verifica daca s-a apasat mouse-ul si daca dinozaurul atinge pamantul
        {
            Rb.velocity = new Vector2(0f, JumpSpeed);
        }

        Anim.SetBool("IsJumping", !IsGrounded);

        ScoreText.text = ScoreIndex.ToString();
    }
    //

    // Verifica daca dinozaurul e in aer (ca sa nu poata sarii la infinit si cand e in aer)
    void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.tag == "Ground")
        {
            IsGrounded = false;

            AudioManager.PlayOneShot(JumpSound);
        }
    }
    //

    // Verifica daca dinozaurul a atins pamantul (ca sa poata sarii din nou)
    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "Ground")
        {
            IsGrounded = true;

            AudioManager.PlayOneShot(LandSound);
        }
    }
    //

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Cactus")// Verifica daca dinozaurul a atins vreun cactus ca sa sfarseasca jocul
        {
            Anim.SetTrigger("IsDead");
            AudioManager.PlayOneShot(DieSound);
            Over.SetActive(true);
            Button.SetActive(true);
            Time.timeScale = 0;
        }

        if (other.gameObject.tag == "Score")// Creste scorul cand ai trecut de un cactus
        {
            ScoreIndex++;
        }
    }

    // Butonul de reset
    public void Reset()
    {
        Time.timeScale = 1;
        Scene scene = SceneManager.GetActiveScene(); SceneManager.LoadScene(scene.name);
    }
    //
}
