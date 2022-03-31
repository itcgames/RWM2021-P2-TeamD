using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class CameraShake
{
    public static IEnumerator Shake(float shakeDuration, float shakeMagnitute, float dampingSpeed, Transform transform, Vector2 initialPos)
    {
        while (shakeDuration > 0.0f)
        {
            transform.position = new Vector3(initialPos.x + Random.insideUnitCircle.x * shakeMagnitute,
                initialPos.y + Random.insideUnitCircle.y * shakeMagnitute, -0.01f);

            shakeDuration -= Time.deltaTime * dampingSpeed;

            yield return null;
        }
        transform.position = new Vector3(initialPos.x, initialPos.y, -0.01f);
    }
}
