using System;
using UnityEditor;
using UnityEngine;

namespace RMC.IntroToUnity.Demos.EditorTools
{
	//  Namespace Properties ------------------------------
	//  Class Attributes ----------------------------------

	/// <summary>
	/// Select 1 or more GameObjects in the Scene and run this
	/// menu item to arrange the items in a (row * col) grid.
	/// </summary>
	public class MyCustomEditorTools
	{
		//  Properties -----------------------------------

		//  Fields ---------------------------------------
		private const string MenuItemTitle01 = "Tools/Intro To Unity Course/Demos/EditorTools/Arrange Selected Scene Items";
		private const string MenuItemTitle02 = "Tools/Intro To Unity Course/Demos/EditorTools/Randomize Selected Scene Items";


		//  Initialization -------------------------------

		//  Unity Methods   ------------------------------

		//  Other Methods --------------------------------
		[MenuItem(MenuItemTitle01, validate = false, priority = 0)]
		public static void ArrangeSelectedSceneItems()
		{
			Vector3 center = new Vector3(0, 0, 0);
			Vector3 offsetPerRow = new Vector3(1, 0, 0);
			Vector3 offsetPerCol = new Vector3(0, 0, 1);

			int maxItems = Selection.gameObjects.Length;
			int maxRows = (int)Math.Sqrt(maxItems);
			int maxCols = maxRows;

			int i = 0;
			for (int row = 0; row <= maxRows; row++)
			{
				for (int col = 0; col < maxCols; col++)
				{
					if (i >= maxItems)
					{
						break;
					}

					GameObject go = Selection.gameObjects[i];

					go.transform.position = center +
						offsetPerRow * row +
						offsetPerCol * col;

					i++;
				}
			}
		}

		[MenuItem(MenuItemTitle01, validate = true)]
		public static bool ArrangeSelectedSceneItems_Validate()
		{
			return Selection.gameObjects.Length > 0;
		}

		[MenuItem(MenuItemTitle02, validate = false, priority = 0)]
		public static void RandomizeSelectedSceneItems()
		{
			float x = UnityEngine.Random.Range(-5f, 5f);
			float y = UnityEngine.Random.Range(-5f, 5f);
			float z = 0;

			int maxItems = Selection.gameObjects.Length;

			for (int i = 0; i < maxItems; i++)
			{
				GameObject go = Selection.gameObjects[i];
				go.transform.position = new Vector3(x, y, z);
			}
		}

		[MenuItem(MenuItemTitle02, validate = true)]
		public static bool RandomizeSelectedSceneItems_Validate()
		{
			return Selection.gameObjects.Length > 0;
		}

		//  Event Handlers -------------------------------
	}
}