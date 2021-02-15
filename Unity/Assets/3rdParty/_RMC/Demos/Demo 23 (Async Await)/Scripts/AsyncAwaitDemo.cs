using System;
using System.Threading.Tasks;
using UnityEngine;

namespace RMC.IntroToUnity.Demos.AsyncAwait
{
	/// <summary>
	/// Here is how to use Async and Await in C#
	/// 
	/// See <a href="https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/async/">Microsoft MSDN</a> for more info.
	///
	/// </summary>
	public class AsyncAwaitDemo : MonoBehaviour
	{
		//  Properties ------------------------------------


		//  Fields ----------------------------------------
		/// <summary>
		/// Do not allow interactivity WHILE waiting for the
		/// code to complete execution.
		/// </summary>
		private bool _isInteractive = true;

		//  Unity Methods   -------------------------------
		protected void Start()
		{
			ShowText("Press Spacebar");
		}

		protected void Update()
		{
			if (_isInteractive && Input.GetKeyDown(KeyCode.Space))
			{
				// Call the method.
				// "await" is NOT used. 
				// Here the local scope does NOT WAIT...(This is the default Unity behaviour)
				Method01();
			}
		}

		//  Other Methods ---------------------------------
		private void ShowText(string message)
		{
			Debug.Log(message);
		}

		private async void Method01()
		{
			ShowText("Method01() Begins ...");

			// Using Try / Catch around await operations is optional and
			// recommended. Otherwise exceptions may not be found.
			try
			{
				// Call the method.
				// "await" is used. Here the local scope WAITS...
				int delayInMilliseconds = await Method02();

				ShowText($"Method01() Ends.");

			}
			catch (Exception e)
			{
				Debug.LogError($"Method01() Exception={e}");
			}
		}


		/// <summary>
		/// Asynchronously returns an int value
		/// </summary>
		/// <returns></returns>
		private async Task<int> Method02()
		{
			_isInteractive = false;

			ShowText("\tMethod02() Begins ...");

			int delayInMilliseconds = 1000;

			await Task.Delay(delayInMilliseconds);

			ShowText($"\tMethod02() Ends. DelayInMilliseconds = {delayInMilliseconds}");

			_isInteractive = true;

			return delayInMilliseconds;
		}

	}
}
