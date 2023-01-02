using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Diese Klasse repräsentiert ein Signal, das von SignalListeners überwacht werden kann.
// Sie kann auch ein Menüeintrag zum Erstellen von Signal-Instanzen in der Unity-Editor-Oberfläche hinzufügen.
[CreateAssetMenu]
public class Signal : ScriptableObject
{

    // Die Liste der SignalListeners, die dieses Signal überwachen.
    public List<SignalListener> listeners = new List<SignalListener>();

    // Diese Methode sendet das Signal an alle registrierten SignalListeners.
    public void Raise()
    {
        // Die SignalListeners werden von hinten nach vorne durchlaufen, um sicherzustellen, dass sie in der Reihenfolge ausgelöst werden,
        // in der sie hinzugefügt wurden.
        for (int i = listeners.Count - 1; i >= 0; i--)
        {
            listeners[i].OnSignalRaised();
        }
    }

    // Diese Methode registriert einen SignalListener bei diesem Signal.
    public void RegisterListener(SignalListener listener)
    {
        listeners.Add(listener);
    }

    // Diese Methode deregistriert einen SignalListener bei diesem Signal.
    public void DeRegisterListener(SignalListener listener)
    {
        listeners.Remove(listener);
    }
}