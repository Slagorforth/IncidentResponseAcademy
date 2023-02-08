using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Eine Aufzählung von möglichen Spielerzuständen.
public enum PlayerState
{
    walk,
    interact
}

public class PlayerMovement : MonoBehaviour
{

    // Der aktuelle Zustand des Spielers.
    public PlayerState currentState;
    // Die Bewegungsgeschwindigkeit des Spielers.
    public float speed;
    // Das Rigidbody-Komponente des Spielers.
    private Rigidbody2D myRigidbody;
    // Der Vektor3, der die Bewegung des Spielers repräsentiert.
    private Vector3 change;
    // Das Animator-Komponente des Spielers.
    private Animator animator;
    // Die Startposition des Spielers.
    public VectorValue startingPosition;

    void Start()
    {
        // Der aktuelle Zustand des Spielers wird auf "walk" gesetzt.
        currentState = PlayerState.walk;
        // Das Animator-Komponente wird abgefragt.
        animator = GetComponent<Animator>();
        // Das Rigidbody-Komponente wird abgefragt.
        myRigidbody = GetComponent<Rigidbody2D>();
        // Die x-Bewegung des Animators wird auf 0 gesetzt.
        animator.SetFloat("moveX", 0);
        // Die y-Bewegung des Animators wird auf -1 gesetzt (Spieler schaut nach unten).
        animator.SetFloat("moveY", -1);
        transform.position = startingPosition.initialValue;
    }
    
    // Update wird jedes Frame aufgerufen.
    void FixedUpdate()
    {
        // Setzen des Bewegungsvektors auf den Nullvektor.
        change = Vector3.zero;
        // Setzen der x-Bewegung auf den Horizontal-Input.
        change.x = Input.GetAxisRaw("Horizontal");
        // Setzen der y-Bewegung auf den Vertical-Input.
        change.y = Input.GetAxisRaw("Vertical");
        // Aufruf der Methode zum Aktualisieren der Animation und Bewegung.
        UpdateAnimationAndMove();
    }

    // Diese Methode aktualisiert die Animation und Bewegung des Spielers.
    // Diese Methode aktualisiert die Animation und Bewegung des Spielers.
    void UpdateAnimationAndMove()
    {
        // Wenn sich der Bewegungsvektor vom Nullvektor unterscheidet, wird die Bewegung ausgeführt und die Animation aktualisiert.
        if (change != Vector3.zero)
        {
            // Aufruf der Methode zum Bewegen des Spielers.
            MoveCharacter();
            // Setzen der x-Bewegung des Animators auf den x-Wert des Bewegungsvektors.
            animator.SetFloat("moveX", change.x);
            // Setzen der y-Bewegung des Animators auf den y-Wert des Bewegungsvektors.
            animator.SetFloat("moveY", change.y);
            // Setzen des "moving"-Bools des Animators auf true.
            animator.SetBool("moving", true);
        }
        else
        {
            // Setzen des "moving"-Bools des Animators auf false.
            animator.SetBool("moving", false);
        }
    }

    // Diese Methode bewegt den Spieler.
    void MoveCharacter()
    {
        // Normalisierung des Bewegungsvektors.
        change.Normalize();
        // Verschieben der Spielerposition um den Bewegungsvektor mal Geschwindigkeit mal Delta-Zeit.
        myRigidbody.MovePosition(
            transform.position + change * speed * Time.deltaTime
        );
    }
}
