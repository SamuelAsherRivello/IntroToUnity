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
		private const string MenuItemTitle = "Tools/Intro To Unity Course/Demos/EditorTools/Arrange Selected Scene Items";
		
		//  Initialization -------------------------------

		//  Unity Methods   ------------------------------

		//  Other Methods --------------------------------
		[MenuItem(MenuItemTitle, validate = false, priority = 0)]
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

		[MenuItem(MenuItemTitle, validate = true)]
		public static bool ArrangeSelectedSceneItems_Validate()
		{
			return Selection.gameObjects.Length > 0;
		}
		
		//  Event Handlers -------------------------------
	}
}