using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

/// <summary>
/// Class responsible for testing Planet3 exists within view
/// </summary>

public class Planet3Exists : MonoBehaviour
{
private GameObject planet;

/// <summary>
/// Finds the object in game with the Planet4 tag
/// </summary>

    [SetUp]
    public void SetUp()
    {
        // Assuming your planet has the "Planet3" tag
        planet = GameObject.FindWithTag("Planet3");
        Assert.IsNotNull(planet, "Planet with tag 'Planet3' not found in the scene.");
    }

/// <summary>
/// Asserts that the Planet3 exists within view of the camera 
/// </summary>

    [UnityTest]
    public IEnumerator PlanetIsWithinGameBounds()
    {
        // Assert
        Assert.IsTrue(IsVisibleByCamera(), "Planet is Outside Camera View");

        yield return null;
    }

    /// <summary>
    /// In the test, make sure that the object targeted is within view of the Main Camera
    /// </summary>

    bool IsVisibleByCamera()
    {
        // Get the object's position in the viewport
        Vector3 viewportPosition = Camera.main.WorldToViewportPoint(planet.transform.position);

        // Check if the object's position is within the viewport bounds
        return (viewportPosition.x > 0 && viewportPosition.x < 1 && viewportPosition.y > 0 && viewportPosition.y < 1);
    }
}