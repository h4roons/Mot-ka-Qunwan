using System.Collections;
using UnityEngine;

public class stadiumMovement : MonoBehaviour
{
    public static stadiumMovement instance;
    public float initialSpeed = -2f;
    public float maxSpeed = -10f;
    public float speedIncreaseAmount = -2f;
    public float speedIncreaseInterval = 5f;
    [SerializeField] private Transform _cubeAxis;

    private float currentSpeed;
    private int found = 0;
    private bool isIncreasing = true; // Flag to track if speed is currently increasing

    private void Start()
    {
        instance = this;
        currentSpeed = initialSpeed;

        StartCoroutine(UpdateSpeedWithInterval());
        audioManager.instance.PlaySound("Background");
    }

    void Update()
    {
        _cubeAxis.Rotate(0f, 0f, 10 * currentSpeed * Time.deltaTime, Space.Self);
    }

    IEnumerator UpdateSpeedWithInterval()
    {
        while (true)
        {
            if (isIncreasing)
            {
                currentSpeed += speedIncreaseAmount;
                if ((currentSpeed == -6f) && (found == 0)) // Decrease speed at -6
                {
                    speedIncreaseAmount = 2f; // Decrease speed increase amount
                    found = 1;

                }
                else if (currentSpeed == -4f) // Increase speed at -4
                {
                    speedIncreaseAmount = -1f; // Increase speed increase amount
                }
                else if ((currentSpeed == -8f) && (found == 1)) // Decrease speed at -8
                {
                    speedIncreaseAmount = 1f; // Decrease speed increase amount
                    found = 2;
                }
                else if ((currentSpeed == -6f) && (found == 2)) // Increase speed at -6
                {
                    speedIncreaseAmount = -1f; // Increase speed increase amount
                    found = 0;
                }
                else if (currentSpeed == -10f)
                {
                    currentSpeed = -10f; // Limit the speed to the maximum value
                    isIncreasing = false; // Stop increasing speed
                }
            }
            else
            {
                // Speed should not decrease beyond this point
                currentSpeed = Mathf.Max(currentSpeed, -10f);
            }

            Debug.Log("Current Speed: " + currentSpeed);

            if (currentSpeed == maxSpeed)
            {
                break;
            }

            // Wait for the specified interval before increasing speed again
            yield return new WaitForSeconds(speedIncreaseInterval);
        }
    }

}


