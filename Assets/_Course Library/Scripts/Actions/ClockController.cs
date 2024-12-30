using UnityEngine;

public class ClockController : MonoBehaviour
{
    [SerializeField] private Transform hourHand;
    [SerializeField] private Transform minuteHand;
    [SerializeField] private Transform secondHand;
    
    private void Update()
    {
        System.DateTime time = System.DateTime.Now;
        
        float hourAngle = ((time.Hour % 12 + time.Minute / 60f) * 360f / 12f) + 90f;
        float minuteAngle = ((time.Minute + time.Second / 60f) * 360f / 60f) + 90f;
        float secondAngle = (time.Second * 360f / 60f) + 90f;

        if (hourHand) hourHand.localRotation = Quaternion.Euler(hourAngle, 0, -90);
        if (minuteHand) minuteHand.localRotation = Quaternion.Euler(minuteAngle, 0, -90);
        if (secondHand) secondHand.localRotation = Quaternion.Euler(secondAngle, 0, -90);
    }
}