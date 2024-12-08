/* 
 * Name: Do Nicer Primitives Creations
 * Filename: DoNicerPrimitives.cs
 * Author(s): DeathwatchGaming
 * License: MIT
 */

// using
using UnityEngine;
using UnityEditor;
using System.Collections;
using System.Collections.Generic;

// public class DoNicerPrimitives
public class DoNicerPrimitives : MonoBehaviour
{
    // MenuItem
    [MenuItem("GameObject/Create Empty (Origin)", false, 0)]
    // EmptyCREATE
    static void EmptyCREATE()
    {
        // Do Create Empty

        // Empty

        // GameObject
        GameObject _emptyCREATE = new GameObject();

        // name
        _emptyCREATE.name = "GameObject";

        // Transforms

        // position
        _emptyCREATE.transform.position = new Vector3(0, 0, 0);

        // rotation
        _emptyCREATE.transform.rotation = Quaternion.identity;

    } // close EmptyCREATE

    // MenuItem
    [MenuItem("GameObject/3D Object/SandBox (Small)", false, -7)]
    // SandBoxSmallCREATE
    static void SandBoxSmallCREATE()
    {
        // Do Create SanBox Small

        // SandBox small

        // GameObject
        GameObject _sandBoxSmallCREATE = new GameObject();

        // name
        _sandBoxSmallCREATE.name = "SandBox Small";

        // Ground cube

        // GameObject
        GameObject _groundCubeCREATE = GameObject.CreatePrimitive(PrimitiveType.Cube);

        // name
        _groundCubeCREATE.name = "GroundCube";

        // Transforms

        // position
        _groundCubeCREATE.transform.position = new Vector3(0, -(0.5f), 0);

        // localScale
        _groundCubeCREATE.transform.localScale = new Vector3(10, 1, 10);

        // rotation
        _groundCubeCREATE.transform.rotation = Quaternion.identity;

        // parent
        _groundCubeCREATE.transform.parent = _sandBoxSmallCREATE.transform;

        // Do Color

        // Renderer
        Renderer _renderedGroundCube = _groundCubeCREATE.GetComponent<Renderer>();

        // SetColor
        _renderedGroundCube.sharedMaterial.SetColor("_Color", Color.gray);        

        // First wall

        // GameObject
        GameObject _sandBoxWallACREATE = GameObject.CreatePrimitive(PrimitiveType.Cube);

        // name
        _sandBoxWallACREATE.name = "Wall A";

        // Transforms

        // localScale
        _sandBoxWallACREATE.transform.localScale = new Vector3(10, 5, 1);

        // position
        _sandBoxWallACREATE.transform.position = new Vector3(4.5f, 2.5f, 0);

        // rotate
        _sandBoxWallACREATE.transform.Rotate(0, -90, 0);

        // parent
        _sandBoxWallACREATE.transform.parent = _sandBoxSmallCREATE.transform;

        // Do Color

        // Renderer
        Renderer _renderedSandBoxWallA = _sandBoxWallACREATE.GetComponent<Renderer>();

        // SetColor
        _renderedSandBoxWallA.sharedMaterial.SetColor("_Color", Color.gray);         

        // Second wall

        // GameObject
        GameObject _sandBoxWallBCREATE = GameObject.CreatePrimitive(PrimitiveType.Cube);

        // name
        _sandBoxWallBCREATE.name = "Wall B";

        // Transforms

        // localScale
        _sandBoxWallBCREATE.transform.localScale = new Vector3(10, 5, 1);

        // position
        _sandBoxWallBCREATE.transform.position = new Vector3(-4.5f, 2.5f, 0);

        // Roatate
        _sandBoxWallBCREATE.transform.Rotate(0, -90, 0);

        //parent
        _sandBoxWallBCREATE.transform.parent = _sandBoxSmallCREATE.transform;

        // Do Color

        // Renderer
        Renderer _renderedSandBoxWallB = _sandBoxWallBCREATE.GetComponent<Renderer>();

        // SetColor
        _renderedSandBoxWallB.sharedMaterial.SetColor("_Color", Color.gray); 

        // Third wall

        // GameObject
        GameObject _sandBoxWallCCREATE = GameObject.CreatePrimitive(PrimitiveType.Cube);

        // name
        _sandBoxWallCCREATE.name = "Wall C";

        // Transforms

        // localScale
        _sandBoxWallCCREATE.transform.localScale = new Vector3(10, 5, 1);

        // position        
        _sandBoxWallCCREATE.transform.position = new Vector3(0, 2.5f, 4.5f);

        // parent
        _sandBoxWallCCREATE.transform.parent = _sandBoxSmallCREATE.transform;

        // Do Color

        // Renderer
        Renderer _renderedSandBoxWallC = _sandBoxWallCCREATE.GetComponent<Renderer>();

        // SetColor
        _renderedSandBoxWallC.sharedMaterial.SetColor("_Color", Color.gray); 

        // Fourth wall

        // GameObject
        GameObject _sandBoxWallDCREATE = GameObject.CreatePrimitive(PrimitiveType.Cube);

        // name
        _sandBoxWallDCREATE.name = "Wall D";

        // Transforms

        // localScale
        _sandBoxWallDCREATE.transform.localScale = new Vector3(10, 5, 1);

        // position        
        _sandBoxWallDCREATE.transform.position = new Vector3(0, 2.5f, -4.5f);

        // parent        
        _sandBoxWallDCREATE.transform.parent = _sandBoxSmallCREATE.transform;

        // Do Color

        // Renderer
        Renderer _renderedSandBoxWallD = _sandBoxWallDCREATE.GetComponent<Renderer>();

        // SetColor
        _renderedSandBoxWallD.sharedMaterial.SetColor("_Color", Color.gray);

    } // close SandBoxSmallCREATE

    // MenuItem
    [MenuItem("GameObject/3D Object/SandBox (Large)", false, -6)]
    // SandBoxLargeCREATE
    static void SandBoxLargeCREATE()
    {
        // Do Create SanBox Large

        // SandBox large

        // GameObject
        GameObject _sandBoxLargeCREATE = new GameObject();

        // name
        _sandBoxLargeCREATE.name = "SandBox Large";

        // Ground cube

        // GameObject
        GameObject _groundCubeCREATE = GameObject.CreatePrimitive(PrimitiveType.Cube);

        // name        
        _groundCubeCREATE.name = "GroundCube";

        // Transforms

        // position
        _groundCubeCREATE.transform.position = new Vector3(0, -(0.5f), 0);

        // localScale
        _groundCubeCREATE.transform.localScale = new Vector3(100, 1, 100);

        // rotation
        _groundCubeCREATE.transform.rotation = Quaternion.identity;

        // parent
        _groundCubeCREATE.transform.parent = _sandBoxLargeCREATE.transform;

        // Do Color

        // Renderer
        Renderer _renderedGroundCube = _groundCubeCREATE.GetComponent<Renderer>();

        // SetColor
        _renderedGroundCube.sharedMaterial.SetColor("_Color", Color.gray);         

        // First wall

        // GameObject
        GameObject _sandBoxWallACREATE = GameObject.CreatePrimitive(PrimitiveType.Cube);

        // name        
        _sandBoxWallACREATE.name = "Wall A";

        // Transforms

        // localScale
        _sandBoxWallACREATE.transform.localScale = new Vector3(100, 5, 1);

        // position
        _sandBoxWallACREATE.transform.position = new Vector3(49.5f, 2.5f, 0);

        // rotate
        _sandBoxWallACREATE.transform.Rotate(0, -90, 0);

        // parent
        _sandBoxWallACREATE.transform.parent = _sandBoxLargeCREATE.transform;

        // Do Color

        // Renderer
        Renderer _renderedSandBoxWallA = _sandBoxWallACREATE.GetComponent<Renderer>();

        // SetColor
        _renderedSandBoxWallA.sharedMaterial.SetColor("_Color", Color.gray);         

        // Second wall

        // GameObject
        GameObject _sandBoxWallBCREATE = GameObject.CreatePrimitive(PrimitiveType.Cube);

        // name
        _sandBoxWallBCREATE.name = "Wall B";

        // Transforms

        // localScale
        _sandBoxWallBCREATE.transform.localScale = new Vector3(100, 5, 1);

        // position
        _sandBoxWallBCREATE.transform.position = new Vector3(-49.5f, 2.5f, 0);

        // rotate
        _sandBoxWallBCREATE.transform.Rotate(0, -90, 0);

        // parent
        _sandBoxWallBCREATE.transform.parent = _sandBoxLargeCREATE.transform;

        // Do Color

        // Renderer
        Renderer _renderedSandBoxWallB = _sandBoxWallBCREATE.GetComponent<Renderer>();

        // SetColor
        _renderedSandBoxWallB.sharedMaterial.SetColor("_Color", Color.gray); 

        // Third wall

        // GameObject
        GameObject _sandBoxWallCCREATE = GameObject.CreatePrimitive(PrimitiveType.Cube);

        // name
        _sandBoxWallCCREATE.name = "Wall C";

        // Transforms

        // localScale
        _sandBoxWallCCREATE.transform.localScale = new Vector3(100, 5, 1);

        // position
        _sandBoxWallCCREATE.transform.position = new Vector3(0, 2.5f, 49.5f);

        // parent
        _sandBoxWallCCREATE.transform.parent = _sandBoxLargeCREATE.transform;

        // Do Color

        // Renderer
        Renderer _renderedSandBoxWallC = _sandBoxWallCCREATE.GetComponent<Renderer>();

        // SetColor
        _renderedSandBoxWallC.sharedMaterial.SetColor("_Color", Color.gray); 

        // Fourth wall

        // GameObject
        GameObject _sandBoxWallDCREATE = GameObject.CreatePrimitive(PrimitiveType.Cube);

        // name
        _sandBoxWallDCREATE.name = "Wall D";

        // Transforms

        // localScale
        _sandBoxWallDCREATE.transform.localScale = new Vector3(100, 5, 1);

        // position
        _sandBoxWallDCREATE.transform.position = new Vector3(0, 2.5f, -49.5f);

        // parent
        _sandBoxWallDCREATE.transform.parent = _sandBoxLargeCREATE.transform;

        // Do Color

        // Renderer
        Renderer _renderedSandBoxWallD = _sandBoxWallDCREATE.GetComponent<Renderer>();

        // SetColor
        _renderedSandBoxWallD.sharedMaterial.SetColor("_Color", Color.gray);

    } // close SandBoxLargeCREATE


    // MenuItem
    [MenuItem("GameObject/3D Object/SandBox (Large)(Tall)", false, -5)]
    // SandBoxLargeTallCREATE
    static void SandBoxLargeTallCREATE()
    {
        // Do Create SanBox LargeTall

        // SandBox large

        // GameObject
        GameObject _sandBoxLargeTallCREATE = new GameObject();

        // name
        _sandBoxLargeTallCREATE.name = "SandBox Large (Tall)";

        // Ground cube

        // GameObject
        GameObject _groundCubeCREATE = GameObject.CreatePrimitive(PrimitiveType.Cube);

        // name        
        _groundCubeCREATE.name = "GroundCube";

        // Transforms

        // position
        _groundCubeCREATE.transform.position = new Vector3(0, -(0.5f), 0);

        // localScale
        _groundCubeCREATE.transform.localScale = new Vector3(100, 1, 100);

        // rotation
        _groundCubeCREATE.transform.rotation = Quaternion.identity;

        // parent
        _groundCubeCREATE.transform.parent = _sandBoxLargeTallCREATE.transform;

        // Do Color

        // Renderer
        Renderer _renderedGroundCube = _groundCubeCREATE.GetComponent<Renderer>();

        // SetColor
        _renderedGroundCube.sharedMaterial.SetColor("_Color", Color.gray);         

        // First wall

        // GameObject
        GameObject _sandBoxWallTallACREATE = GameObject.CreatePrimitive(PrimitiveType.Cube);

        // name        
        _sandBoxWallTallACREATE.name = "Wall A (Tall)";

        // Transforms

        // localScale
        _sandBoxWallTallACREATE.transform.localScale = new Vector3(100, 10, 1);

        // position
        _sandBoxWallTallACREATE.transform.position = new Vector3(49.5f, 5f, 0);

        // rotate
        _sandBoxWallTallACREATE.transform.Rotate(0, -90, 0);

        // parent
        _sandBoxWallTallACREATE.transform.parent = _sandBoxLargeTallCREATE.transform;

        // Do Color

        // Renderer
        Renderer _renderedSandBoxWallTallA = _sandBoxWallTallACREATE.GetComponent<Renderer>();

        // SetColor
        _renderedSandBoxWallTallA.sharedMaterial.SetColor("_Color", Color.gray);         

        // Second wall

        // GameObject
        GameObject _sandBoxWallTallBCREATE = GameObject.CreatePrimitive(PrimitiveType.Cube);

        // name
        _sandBoxWallTallBCREATE.name = "Wall B (Tall)";

        // Transforms

        // localScale
        _sandBoxWallTallBCREATE.transform.localScale = new Vector3(100, 10, 1);

        // position
        _sandBoxWallTallBCREATE.transform.position = new Vector3(-49.5f, 5f, 0);

        // rotate
        _sandBoxWallTallBCREATE.transform.Rotate(0, -90, 0);

        // parent
        _sandBoxWallTallBCREATE.transform.parent = _sandBoxLargeTallCREATE.transform;

        // Do Color

        // Renderer
        Renderer _renderedSandBoxWallTallB = _sandBoxWallTallBCREATE.GetComponent<Renderer>();

        // SetColor
        _renderedSandBoxWallTallB.sharedMaterial.SetColor("_Color", Color.gray); 

        // Third wall

        // GameObject
        GameObject _sandBoxWallTallCCREATE = GameObject.CreatePrimitive(PrimitiveType.Cube);

        // name
        _sandBoxWallTallCCREATE.name = "Wall C (Tall)";

        // Transforms

        // localScale
        _sandBoxWallTallCCREATE.transform.localScale = new Vector3(100, 10, 1);

        // position
        _sandBoxWallTallCCREATE.transform.position = new Vector3(0, 5f, 49.5f);

        // parent
        _sandBoxWallTallCCREATE.transform.parent = _sandBoxLargeTallCREATE.transform;

        // Do Color

        // Renderer
        Renderer _renderedSandBoxWallTallC = _sandBoxWallTallCCREATE.GetComponent<Renderer>();

        // SetColor
        _renderedSandBoxWallTallC.sharedMaterial.SetColor("_Color", Color.gray); 

        // Fourth wall

        // GameObject
        GameObject _sandBoxWallTallDCREATE = GameObject.CreatePrimitive(PrimitiveType.Cube);

        // name
        _sandBoxWallTallDCREATE.name = "Wall D (Tall)";

        // Transforms

        // localScale
        _sandBoxWallTallDCREATE.transform.localScale = new Vector3(100, 10, 1);

        // position
        _sandBoxWallTallDCREATE.transform.position = new Vector3(0, 5f, -49.5f);

        // parent
        _sandBoxWallTallDCREATE.transform.parent = _sandBoxLargeTallCREATE.transform;

        // Do Color

        // Renderer
        Renderer _renderedSandBoxWallTallD = _sandBoxWallTallDCREATE.GetComponent<Renderer>();

        // SetColor
        _renderedSandBoxWallTallD.sharedMaterial.SetColor("_Color", Color.gray);

    } // close SandBoxLargeTallCREATE

    // MenuItem
    [MenuItem("GameObject/3D Object/Ground Cube (Small)", false, -4)]
    // GroundCubeSmallCREATE
    static void GroundCubeSmallCREATE()
    {
        // Do Create GroundCube Small

        // GroundCube Small

        // GameObject       
        GameObject _groundCubeCREATE = GameObject.CreatePrimitive(PrimitiveType.Cube);

        // name
        _groundCubeCREATE.name = "GroundCube Small";

        // Transforms

        // position
        _groundCubeCREATE.transform.position = new Vector3(0, -(0.5f), 0);

        // localScale
        _groundCubeCREATE.transform.localScale = new Vector3(10, 1, 10);

        // rotation
        _groundCubeCREATE.transform.rotation = Quaternion.identity;

        // Do Color

        // Renderer
        Renderer _renderedGroundCubeSmall = _groundCubeCREATE.GetComponent<Renderer>();

        // SetColor
        _renderedGroundCubeSmall.sharedMaterial.SetColor("_Color", Color.gray);

    } // close GroundCubeSmallCREATE

    // MenuItem
    [MenuItem("GameObject/3D Object/Ground Cube (Large)", false, -3)]
    // GroundCubeLargeCREATE
    static void GroundCubeLargeCREATE()
    {
        // Do Create GroundCube Large

        // GroundCube Large

        // GameObject       
        GameObject _groundCubeCREATE = GameObject.CreatePrimitive(PrimitiveType.Cube);

        // name
        _groundCubeCREATE.name = "GroundCube Large";

        // Transforms

        // position
        _groundCubeCREATE.transform.position = new Vector3(0, -(0.5f), 0);

        // localScale
        _groundCubeCREATE.transform.localScale = new Vector3(100, 1, 100);

        // rotation
        _groundCubeCREATE.transform.rotation = Quaternion.identity;

        // Do Color

        // Renderer
        Renderer _renderedGroundCubeLarge = _groundCubeCREATE.GetComponent<Renderer>();

        // SetColor
        _renderedGroundCubeLarge.sharedMaterial.SetColor("_Color", Color.gray);

    } // close GroundCubeLargeCREATE

    // MenuItem
    [MenuItem("GameObject/3D Object/Wall Cube (Origin)", false, -2)]
    // WallCubeCREATE
    static void WallCubeCREATE()
    {
        // Do Create WallCube

        // WallCube

        // GameObject
        GameObject _wallCubeCREATE = GameObject.CreatePrimitive(PrimitiveType.Cube);

        // name
        _wallCubeCREATE.name = "WallCube";

        // Transforms

        // localScale
        _wallCubeCREATE.transform.localScale = new Vector3(10, 5, 1);

        // position
        _wallCubeCREATE.transform.position = new Vector3(0, 2.5f, 0);

        // rotation
        _wallCubeCREATE.transform.rotation = Quaternion.identity;

        // Do Color

        // Renderer
        Renderer _renderedWallCube = _wallCubeCREATE.GetComponent<Renderer>();

        // SetColor
        _renderedWallCube.sharedMaterial.SetColor("_Color", Color.gray);

    } // close WallCubeCREATE

    // MenuItem
    [MenuItem("GameObject/3D Object/Cube (Origin)", false, 1)]
    // CubeCREATE
    static void CubeCREATE()
    {
        // Do Create Cube

        // Cube

        // GameObject       
        GameObject _cubeCREATE = GameObject.CreatePrimitive(PrimitiveType.Cube);

        // name
        _cubeCREATE.name = "Cube";

        // Transforms

        // position
        _cubeCREATE.transform.position = new Vector3(0, 0, 0);

        // rotation
        _cubeCREATE.transform.rotation = Quaternion.identity;

        // Do Color

        // Renderer
        Renderer _renderedCube = _cubeCREATE.GetComponent<Renderer>();

        // SetColor
        _renderedCube.sharedMaterial.SetColor("_Color", Color.gray);

    } // close CubeCREATE

    // MenuItem
    [MenuItem("GameObject/3D Object/Sphere (Origin)", false, 2)]
    // SphereCREATE
    static void SphereCREATE()
    {
        // Do Create Sphere

        // Sphere

        // GameObject        
        GameObject _sphereCREATE = GameObject.CreatePrimitive(PrimitiveType.Sphere);

        // name
        _sphereCREATE.name = "Sphere";

        // Transforms

        // position
        _sphereCREATE.transform.position = new Vector3(0, 0, 0);

        // rotation
        _sphereCREATE.transform.rotation = Quaternion.identity;

        // Do Color

        // Renderer
        Renderer _renderedSphere = _sphereCREATE.GetComponent<Renderer>();

        // SetColor
        _renderedSphere.sharedMaterial.SetColor("_Color", Color.gray);

    } // close SphereCREATE

    // MenuItem
    [MenuItem("GameObject/3D Object/Capsule (Origin)", false, 3)]
    // CapsuleCREATE
    static void CapsuleCREATE()
    {
        // Do Create Capsule

        // Capsule

        // GameObject       
        GameObject _capsuleCREATE = GameObject.CreatePrimitive(PrimitiveType.Capsule);

        // name
        _capsuleCREATE.name = "Capsule";

        // Transforms

        // position
        _capsuleCREATE.transform.position = new Vector3(0, 0, 0);

        // rotation
        _capsuleCREATE.transform.rotation = Quaternion.identity;

        // Do Color

        // Renderer
        Renderer _renderedCapsule = _capsuleCREATE.GetComponent<Renderer>();
        
        // SetColor
        _renderedCapsule.sharedMaterial.SetColor("_Color", Color.gray);

    } // close CapsuleCREATE

    // MenuItem
    [MenuItem("GameObject/3D Object/Cylinder (Origin)", false, 4)]
    // CylinderCREATE
    static void CylinderCREATE()
    {
        // Do Create Cylinder

        // Cylinder

        // GameObject       
        GameObject _cylinderCREATE = GameObject.CreatePrimitive(PrimitiveType.Cylinder);

        // name
        _cylinderCREATE.name = "Cylinder";

        // Transforms

        // position
        _cylinderCREATE.transform.position = new Vector3(0, 0, 0);

        // rotation
        _cylinderCREATE.transform.rotation = Quaternion.identity;

        // Do Color

        // Renderer
        Renderer _renderedCylinder = _cylinderCREATE.GetComponent<Renderer>();

        // SetColor
        _renderedCylinder.sharedMaterial.SetColor("_Color", Color.gray);

    } // close CylinderCREATE

    // MenuItem
    [MenuItem("GameObject/3D Object/Plane (Origin)", false, 5)]
    // PlaneCREATE
    static void PlaneCREATE()
    {
        // Do Create Plane

        // Plane

        // GameObject
        GameObject _planeCREATE = GameObject.CreatePrimitive(PrimitiveType.Plane);

        // name
        _planeCREATE.name = "Plane";

        // Transforms

        // position
        _planeCREATE.transform.position = new Vector3(0, 0, 0);

        // rotation
        _planeCREATE.transform.rotation = Quaternion.identity;

        // Do Color

        // Renderer
        Renderer _renderedPlane = _planeCREATE.GetComponent<Renderer>();

        // SetColor
        _renderedPlane.sharedMaterial.SetColor("_Color", Color.gray);

    } // close PlaneCREATE

    // MenuItem
    [MenuItem("GameObject/3D Object/Quad (Origin)", false, 6)]
    // QuadCREATE
    static void QuadCREATE()
    {
        // Do Create Quad

        // Quad

        // GameObject       
        GameObject _quadCREATE = GameObject.CreatePrimitive(PrimitiveType.Quad);

        // name
        _quadCREATE.name = "Quad";

        // Transforms

        // position
        _quadCREATE.transform.position = new Vector3(0, 0, 0);

        // rotation
        _quadCREATE.transform.rotation = Quaternion.identity;

        // Do Color

        // Renderer
        Renderer _renderedQuad = _quadCREATE.GetComponent<Renderer>();

        // SetColor
        _renderedQuad.sharedMaterial.SetColor("_Color", Color.gray);

    } // close QuadCREATE

} // close public class DoNicerPrimitives
