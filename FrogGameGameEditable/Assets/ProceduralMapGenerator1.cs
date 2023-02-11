using UnityEngine;

public class ProceduralMapGenerator1 : MonoBehaviour
{
    // Terrain size
    public int terrainWidth = 256;
    public int terrainHeight = 256;

    // Scale factor for terrain
    public float terrainScale = 20f;

    // Offset values for Perlin noise
    public float offsetX = 100f;
    public float offsetY = 100f;

    // Terrain data object
    private TerrainData terrainData;

    // Start function
    void Start()
    {
        // Assign the Terrain component to a variable
        Terrain terrain = GetComponent<Terrain>();

        // Initialize the terrain data
        terrainData = new TerrainData();
        terrainData.heightmapResolution = terrainWidth + 1;
        terrainData.size = new Vector3(terrainWidth, terrainHeight, terrainWidth);
        terrainData.SetHeights(0, 0, GenerateHeights());

        // Apply the terrain data to the Terrain component
        terrain.terrainData = terrainData;
    }

    // Function to generate the terrain heights
    float[,] GenerateHeights()
    {
        // Create a 2D array for the terrain heights
        float[,] heights = new float[terrainWidth, terrainHeight];

        // Loop through the terrain width and height
        for (int x = 0; x < terrainWidth; x++)
        {
            for (int y = 0; y < terrainHeight; y++)
            {
                // Calculate the height value at this point using Perlin noise
                float xCoord = (float)x / terrainWidth * terrainScale + offsetX;
                float yCoord = (float)y / terrainHeight * terrainScale + offsetY;
                heights[x, y] = Mathf.PerlinNoise(xCoord, yCoord);
            }
        }

        // Return the array of heights
        return heights;
    }
}
