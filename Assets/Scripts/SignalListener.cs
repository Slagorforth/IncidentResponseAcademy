using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

// Diese Klasse repräsentiert einen Listener für ein Signal.
// Wenn das Signal gesendet wird, wird ein UnityEvent ausgelöst.

public class SignalListener : MonoBehaviour {

    // Das Signal, das überwacht wird.
    public Signal signal;

    // Das UnityEvent, das ausgelöst wird, wenn das Signal gesendet wird.
    public UnityEvent signalEvent;

    // Diese Methode wird aufgerufen, wenn das Signal gesendet wird.
    // Sie löst das UnityEvent aus.
    public void OnSignalRaised()
    {
        signalEvent.Invoke();
    }

    // Diese Methode wird aufgerufen, wenn das MonoBehaviour aktiviert wird.
    // Sie registriert diesen Listener beim Signal.
    private void OnEnable()
    {
        signal.RegisterListener(this);
    }

    // Diese Methode wird aufgerufen, wenn das MonoBehaviour deaktiviert wird.
    // Sie deregistriert diesen Listener beim Signal.
    private void Disable()
    {
        signal.DeRegisterListener(this);
    }
}
