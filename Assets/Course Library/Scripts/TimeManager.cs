using UnityEngine;

public class TimeManager: MonoBehaviour
{
    private float startTime;
    private float elapsedTime;
    private bool isRunning = false;

    // Appel� pour d�marrer le timer
    public void StartTimer()
    {
        startTime = Time.time;
        isRunning = true;
    }

    // Appel� pour arr�ter le timer
    public void StopTimer()
    {
        if (isRunning)
        {
            elapsedTime += Time.time - startTime;
            isRunning = false;
        }
    }

    // Appel� pour r�initialiser le timer
    public void ResetTimer()
    {
        elapsedTime = 0f;
        isRunning = false;
    }

    // Obtient le temps �coul� (en secondes)
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

    // Appel� pour afficher le temps format�
    public string GetFormattedTime()
    {
        float timeInSeconds = GetElapsedTime();
        int minutes = Mathf.FloorToInt(timeInSeconds / 60f);
        int seconds = Mathf.FloorToInt(timeInSeconds % 60f);
        int milliseconds = Mathf.FloorToInt((timeInSeconds * 1000f) % 1000f);

        return string.Format("{0:00}:{1:00}:{2:000}", minutes, seconds, milliseconds);
    }

    // Appel� chaque frame si le timer est en cours
    private void Update()
    {
        if (isRunning)
        {
            elapsedTime += Time.deltaTime;
        }
    }
}
