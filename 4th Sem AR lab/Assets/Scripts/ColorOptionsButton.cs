using UnityEngine;

public class ColorOptionsButton : MonoBehaviour
{
    public GameObject MainMenuPannel;
    public Material blueMaterial;
    public Material greenMaterial;
    public Material redMaterial;
    public Material yellowMaterial;
    public Material purpleMaterial;

    public MeshRenderer[] blueParts;
    public MeshRenderer[] greenParts;
    public MeshRenderer[] redParts;
    public MeshRenderer[] yellowParts;
    public MeshRenderer[] purpleParts;

    public void OnBlueButtonClicked()
    {
        SetMaterial(blueParts, blueMaterial);
    }

    public void OnGreenButtonClicked()
    {
        SetMaterial(greenParts, greenMaterial);
    }

    public void OnRedButtonClicked()
    {
        SetMaterial(redParts, redMaterial);
    }

    public void OnYellowButtonClicked()
    {
        SetMaterial(yellowParts, yellowMaterial);
    }

    public void OnPurpleButtonClicked()
    {
        SetMaterial(purpleParts, purpleMaterial);
    }

    private void SetMaterial(MeshRenderer[] meshRenderers, Material material)
    {
        foreach (MeshRenderer meshRenderer in meshRenderers)
        {
            meshRenderer.material = material;
        }
    }

    public void OnBackButton()
    {
        MainMenuPannel.SetActive(true);
    }
}
