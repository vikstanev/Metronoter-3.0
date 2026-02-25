using UnityEngine;
using TMPro;

public class NotationSwitcher : MonoBehaviour
{
    [Header("Notation Layers")]
    public GameObject GuitarLines;
    public GameObject BassLines;
    public GameObject StaffLines;

    [Header("Buttons")]
    public GameObject TabsButton;
    public GameObject BassButton;
    public GameObject StaffButton;

    [Header("Bass Button Text (TMP)")]
    public TextMeshProUGUI BassButtonText;

    private bool isGuitar = true;

    void Start()
    {
        ShowStaffMode();
    }

    // ================= BUTTON EVENTS =================

    public void OnTabsClicked()
    {
        ShowGuitarMode();
    }

    public void OnBassClicked()
    {
        if (isGuitar)
            ShowBassMode();
        else
            ShowGuitarMode();
    }

    public void OnStaffClicked()
    {
        ShowStaffMode();
    }

    // ================= MODES =================

    void ShowStaffMode()
    {
        StaffLines.SetActive(true);
        GuitarLines.SetActive(false);
        BassLines.SetActive(false);

        TabsButton.SetActive(true);
        BassButton.SetActive(false);
        StaffButton.SetActive(false);

        // Reset toggle state
        isGuitar = true;
        BassButtonText.text = "Бас Китара";
    }

    void ShowGuitarMode()
    {
        StaffLines.SetActive(false);
        GuitarLines.SetActive(true);
        BassLines.SetActive(false);

        TabsButton.SetActive(false);
        BassButton.SetActive(true);
        StaffButton.SetActive(true);

        BassButtonText.text = "Бас Китара"; // shows what you'll switch TO
        isGuitar = true;
    }

    void ShowBassMode()
    {
        StaffLines.SetActive(false);
        GuitarLines.SetActive(false);
        BassLines.SetActive(true);

        TabsButton.SetActive(false);
        BassButton.SetActive(true);
        StaffButton.SetActive(true);

        BassButtonText.text = "Китара"; // shows what you'll switch TO
        isGuitar = false;
    }
}