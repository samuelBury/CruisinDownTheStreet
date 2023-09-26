using UnityEngine;

public class TimeManager: MonoBehaviour
{
    private float startTime;
    private float elapsedTime;
    private bool isRunning = false;

    // Appelé pour démarrer le timer
    public void StartTimer()
    {
        startTime = Time.time;
        isRunning = true;
    }

    // Appelé pour arrêter le timer
    public void StopTimer()
    {
        if (isRunning)
        {
            elapsedTime += Time.time - startTime;
            isRunning = false;
        }
    }

    // Appelé pour réinitialiser le timer
    public void ResetTimer()
    {
        elapsedTime = 0f;
        isRunning = false;
    }

    // Obtient le temps écoulé (en secondes)
    public float GetElapsedTime()
    {
        if (isRunning)
        {
            return elapsedTime + (Time.time - startTime);
        }
        else
        {
            return elapsedTime;
        }
    }

    // Appelé pour afficher le temps formaté
    public string GetFormattedTime()
    {
        float timeInSeconds = GetElapsedTime();
        int minutes = Mathf.FloorToInt(timeInSeconds / 60f);
        int seconds = Mathf.FloorToInt(timeInSeconds % 60f);
        int milliseconds = Mathf.FloorToInt((timeInSeconds * 1000f) % 1000f);

        return string.Format("{0:00}:{1:00}:{2:000}", minutes, seconds, milliseconds);
    }

    // Appelé chaque frame si le timer est en cours
    private void Update()
    {
        if (isRunning)
        {
            elapsedTime += Time.deltaTime;
        }
    }
}
