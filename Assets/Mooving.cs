using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mooving : MonoBehaviour
{
    public float moveSpeed = 5f; // Скорость движения платформы
    public float moveDistance = 5f; // Расстояние, на которое платформа будет двигаться вперед и назад
    private Vector3 startPos; // Начальная позиция платформы
    private Vector3 endPos; // Конечная позиция платформы
    private bool movingForward = true; // Флаг, указывающий, движется ли платформа вперед

    void Start()
    {
        // Запоминаем начальную позицию платформы
        startPos = transform.position;
        // Вычисляем конечную позицию платформы
        endPos = startPos + new Vector3(moveDistance, 0f, 0f);
    }

    void Update()
    {
        // Если платформа достигла конечной позиции, меняем направление движения
        if (transform.position.x >= endPos.x && movingForward)
        {
            movingForward = false;
        }
        else if (transform.position.x <= startPos.x && !movingForward)
        {
            movingForward = true;
        }

        // Двигаем платформу вперед или назад в зависимости от флага movingForward
        float direction = movingForward ? 1f : -1f;
        transform.Translate(Vector3.right * direction * moveSpeed * Time.deltaTime);
    }
}
