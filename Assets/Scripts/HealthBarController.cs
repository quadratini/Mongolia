using System;
using UnityEngine;
using UnityEngine.UIElements;

public class HealthBarController : MonoBehaviour
{
    public UIDocument uiDocument;
    private VisualElement healthFill;
    private Label healthText;

    public GameObject player;

    PlayerController playerController;
    private void Start()
    {
        playerController = player.GetComponent<PlayerController>();
    }

    void OnEnable()
    {
        var root = uiDocument.rootVisualElement;
        healthFill = root.Q<VisualElement>("healthFill");
        healthText = root.Q<Label>("healthText");
    }

    void Update()
    {
        float percent = Mathf.Clamp01(playerController.currentHealth / playerController.maxHealth);
        healthFill.style.width = new Length(percent * 100f, LengthUnit.Percent);
        healthText.text = (percent * 100f).ToString();
    }
}