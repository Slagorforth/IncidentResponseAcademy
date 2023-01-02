using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// Diese Klasse ermöglicht es, zwischen Szenen zu wechseln und die Position des Spielers zu speichern, wenn die Szene gewechselt wird.
// Sie kann auch ein Fade-In- und Fade-Out-Panel anzeigen, wenn die Szene gewechselt wird.
public class SceneTransition : MonoBehaviour
{

    // Die Szene, zu der gewechselt werden soll.
    public string sceneToLoad;
    // Die Position des Spielers, wenn die Szene gewechselt wird.
    public Vector2 playerPosition;
    // Der Vektorwert, in dem die Position des Spielers gespeichert wird.
    public VectorValue playerStorage;
    // Das Fade-In-Panel, das angezeigt wird, wenn die Szene geladen wird.
    public GameObject fadeInPanel;
    // Das Fade-Out-Panel, das angezeigt wird, wenn die Szene gewechselt wird.
    public GameObject fadeOutPanel;
    // Die Zeit, die gewartet wird, bevor die Szene gewechselt wird, nachdem das Fade-Out-Panel angezeigt wurde.
    public float fadeWait;

    private void Awake()
    {
        // Wenn das Fade-In-Panel vorhanden ist, wird es instanziiert und nach einer Sekunde zerstört.
        if (fadeInPanel != null)
        {
            GameObject panel = Instantiate(fadeInPanel, Vector3.zero, Quaternion.identity) as GameObject;
            Destroy(panel, 1);
        }
    }

    // Diese Methode wird aufgerufen, wenn ein anderes Collision2D-GameObject in den Trigger eintritt.
    public void OnTriggerEnter2D(Collider2D other)
    {
        // Wenn das GameObject, das den Trigger betritt, das Player-Tag hat und kein Trigger ist, wird die "playerPosition"-Variable in den "playerStorage"-Vektorwert gespeichert.
        // Danach wird die Fade-Coroutine gestartet.
        if (other.CompareTag("Player") && !other.isTrigger)
        {
            playerStorage.initialValue = playerPosition;
            StartCoroutine(FadeCo());
            //SceneManager.LoadScene(sceneToLoad);
        }
    }

    // Diese Coroutine zeigt das Fade-Out-Panel an und lädt die neue Szene asynchron im Hintergrund.
    // Sie wird von der "OnTriggerEnter2D"-Methode aufgerufen, wenn der Spieler in den Trigger eintritt.
    public IEnumerator FadeCo()
    {
        // Wenn das Fade-Out-Panel vorhanden ist, wird es instanziiert.
        if (fadeOutPanel != null)
        {
            Instantiate(fadeOutPanel, Vector3.zero, Quaternion.identity);
        }
        // Warten, bevor die neue Szene geladen wird.
        yield return new WaitForSeconds(fadeWait);
        // Asynchrones Laden der Szene im Hintergrund.
        AsyncOperation asyncOperation = SceneManager.LoadSceneAsync(sceneToLoad);
        // Warten, bis das Laden abgeschlossen ist.
        while (!asyncOperation.isDone)
        {
            yield return null;
        }
    }
}
