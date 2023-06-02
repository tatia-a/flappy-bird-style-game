using System;
using UnityEngine;
using UnityEngine.UI;

public class OnOffButton : MonoBehaviour
{
    private bool isActive = true;
    public bool IsActive { get => isActive; }

    private Image buttonImage;

    private void Awake()
    {
        buttonImage = GetComponent<Image>();
        // получаем состояние кнопки по имени
        isActive = PlayerPrefs.GetInt("IsButtonActive" + gameObject.name, 1) == 1 ? true : false;
        ChangeButtonTint();
    }

    private void ChangeButtonTint()
    {
        if (isActive)
        {
            buttonImage.color = Color.white;
        }
        else
        {
            buttonImage.color = Color.gray;
        }
    }

    public void ChangeButtonState()
    {
        if (isActive)
        {
            isActive = false;
            buttonImage.color = Color.gray;
        }
        else
        {
            isActive = true;
            buttonImage.color = Color.white;
        }
        // Сохраняем состояние кнопки после изменения
        var intIsActive = isActive ? 1 : 0;
        PlayerPrefs.SetInt("IsButtonActive" + gameObject.name, intIsActive);
    }
}
