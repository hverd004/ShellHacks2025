using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeScript : MonoBehaviour
{
    public Camera cam = null;
    public bool changeRealities = true;

    public OVRPassthroughLayer passthrough = null;   // MR passthrough layer
    public List<Renderer> fadingObjects = null;          // Objects visible in MR only
    public List<Renderer> appearingObjects = null;       // Objects that fade in when MR fades out

    public float duration = 2f;

    public void VRtoVRMethod()
    {
        StartCoroutine(FadeVRToVR());
    }

    public void MRtoVRMethod()
    {
        StartCoroutine(FadeMRToVR());
    }
    public void ToOpaqueMode(Material material)
    {
        material.SetOverrideTag("RenderType", "");
        material.SetInt("_SrcBlend", (int)UnityEngine.Rendering.BlendMode.One);
        material.SetInt("_DstBlend", (int)UnityEngine.Rendering.BlendMode.Zero);
        material.SetInt("_ZWrite", 1);
        material.DisableKeyword("_ALPHATEST_ON");
        material.DisableKeyword("_ALPHABLEND_ON");
        material.DisableKeyword("_ALPHAPREMULTIPLY_ON");
        material.renderQueue = -1;
    }

    public void ToFadeMode(Material material)
    {
        material.SetOverrideTag("RenderType", "Transparent");
        material.SetInt("_SrcBlend", (int)UnityEngine.Rendering.BlendMode.SrcAlpha);
        material.SetInt("_DstBlend", (int)UnityEngine.Rendering.BlendMode.OneMinusSrcAlpha);
        material.SetInt("_ZWrite", 0);
        material.DisableKeyword("_ALPHATEST_ON");
        material.EnableKeyword("_ALPHABLEND_ON");
        material.DisableKeyword("_ALPHAPREMULTIPLY_ON");
        material.renderQueue = (int)UnityEngine.Rendering.RenderQueue.Transparent;
    }

    IEnumerator FadeMRToVR()
    {
        // Fading objects (out)
        List<Material[]> fadeMatsList = new List<Material[]>();
        List<Color[]> fadeStartColorsList = new List<Color[]>();

        foreach (Renderer r in fadingObjects)
        {
            Material[] mats = r.materials;
            Color[] startColors = new Color[mats.Length];
            for (int i = 0; i < mats.Length; i++)
            {
                startColors[i] = mats[i].color;
                ToFadeMode(mats[i]);
            }
            fadeMatsList.Add(mats);
            fadeStartColorsList.Add(startColors);
        }

        // Appearing objects (in)
        List<Material[]> appearMats = new List<Material[]>();
        List<Color[]> appearStartColors = new List<Color[]>();

        foreach (Renderer r in appearingObjects)
        {
            Material[] mats = r.materials;
            Color[] start = new Color[mats.Length];
            for (int i = 0; i < mats.Length; i++)
            {
                start[i] = mats[i].color;
                Color c = start[i];
                c.a = 0f; // start fully transparent
                mats[i].color = c;
            }
            appearMats.Add(mats);
            appearStartColors.Add(start);
        }

        for (float t = 0; t < duration; t += Time.deltaTime)
        {
            float normalized = t / duration;

            // Passthrough fade (1 → 0)
            float passOpacity = Mathf.Lerp(1f, 0f, normalized);
            passthrough.textureOpacity = passOpacity;

            // Fade out MR-only objects
            for (int obj = 0; obj < fadeMatsList.Count; obj++)
            {
                for (int i = 0; i < fadeMatsList[obj].Length; i++)
                {
                    Color c = fadeStartColorsList[obj][i];
                    c.a = passOpacity;
                    fadeMatsList[obj][i].color = c;
                }
            }

            // Fade in VR objects
            for (int obj = 0; obj < appearMats.Count; obj++)
            {
                for (int i = 0; i < appearMats[obj].Length; i++)
                {
                    Color c = appearStartColors[obj][i];
                    c.a = 1f - passOpacity;
                    appearMats[obj][i].color = c;
                }
            }

            yield return null;
        }

        // Ensure final state
        passthrough.textureOpacity = 0f;

        for (int obj = 0; obj < fadeMatsList.Count; obj++)
        {
            for (int i = 0; i < fadeMatsList[obj].Length; i++)
            {
                Color c = fadeStartColorsList[obj][i];
                c.a = 0f;
                fadeMatsList[obj][i].color = c;
            }
        }
        foreach (Renderer r in fadingObjects)
        {
            r.gameObject.SetActive(false);
        }

        for (int obj = 0; obj < appearMats.Count; obj++)
        {
            for (int i = 0; i < appearMats[obj].Length; i++)
            {
                Color c = appearStartColors[obj][i];
                c.a = 1f;
                appearMats[obj][i].color = c;
                ToOpaqueMode(appearMats[obj][i]);
            }
        }
    }

    IEnumerator FadeVRToVR()
    {
        // Fading objects (out)
        List<Material[]> fadeMatsList = new List<Material[]>();
        List<Color[]> fadeStartColorsList = new List<Color[]>();

        foreach (Renderer r in fadingObjects)
        {
            Material[] mats = r.materials;
            Color[] startColors = new Color[mats.Length];
            for (int i = 0; i < mats.Length; i++)
            {
                startColors[i] = mats[i].color;
                ToFadeMode(mats[i]);
            }
            fadeMatsList.Add(mats);
            fadeStartColorsList.Add(startColors);
        }

        // Appearing objects (in)
        List<Material[]> appearMats = new List<Material[]>();
        List<Color[]> appearStartColors = new List<Color[]>();

        foreach (Renderer r in appearingObjects)
        {
            Material[] mats = r.materials;
            Color[] start = new Color[mats.Length];
            for (int i = 0; i < mats.Length; i++)
            {
                start[i] = mats[i].color;
                Color c = start[i];
                c.a = 0f; // start fully transparent
                mats[i].color = c;
            }
            appearMats.Add(mats);
            appearStartColors.Add(start);
        }

        for (float t = 0; t < duration; t += Time.deltaTime)
        {
            float normalized = t / duration;

            // Passthrough fade (1 → 0)
            float passOpacity = Mathf.Lerp(1f, 0f, normalized);

            // Fade out MR-only objects
            for (int obj = 0; obj < fadeMatsList.Count; obj++)
            {
                for (int i = 0; i < fadeMatsList[obj].Length; i++)
                {
                    Color c = fadeStartColorsList[obj][i];
                    c.a = passOpacity;
                    fadeMatsList[obj][i].color = c;
                }
            }

            // Fade in VR objects
            for (int obj = 0; obj < appearMats.Count; obj++)
            {
                for (int i = 0; i < appearMats[obj].Length; i++)
                {
                    Color c = appearStartColors[obj][i];
                    c.a = 1f - passOpacity;
                    appearMats[obj][i].color = c;
                }
            }

            yield return null;
        }

        for (int obj = 0; obj < fadeMatsList.Count; obj++)
        {
            for (int i = 0; i < fadeMatsList[obj].Length; i++)
            {
                Color c = fadeStartColorsList[obj][i];
                c.a = 0f;
                fadeMatsList[obj][i].color = c;
            }
        }
        foreach (Renderer r in fadingObjects)
        {
            r.gameObject.SetActive(false);
        }

        for (int obj = 0; obj < appearMats.Count; obj++)
        {
            for (int i = 0; i < appearMats[obj].Length; i++)
            {
                Color c = appearStartColors[obj][i];
                c.a = 1f;
                appearMats[obj][i].color = c;
                ToOpaqueMode(appearMats[obj][i]);
            }
        }
    }
}
