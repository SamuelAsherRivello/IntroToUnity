using System.Collections.Generic;
using UnityEngine;
namespace RMC.IntroToUnity.Demos.OOP
{
	public interface IAnimal
   {
		void Speak();
   }
	public class Animal
	{
		public virtual void Speak()
      {
			Debug.Log("I am an Animal :) ");
      }
	}

	public class Dog : Animal, IAnimal
	{
		public override void Speak()
		{
			Debug.Log("Woof");
		}
	}

	public class Cat : IAnimal
	{
		public void Speak ()
      {
			Debug.Log("Meow");
      }
	}
	public class OOPDemo : MonoBehaviour
	{
		protected void Awake()
		{
			IAnimal animal1 = new Dog();
			IAnimal animal2 = new Cat();
			List<IAnimal> animals = new List<IAnimal>();
			animals.Add(animal1);
			animals.Add(animal2);

			foreach (IAnimal animal in animals)
         {
				animal.Speak();
         }
		}
	}
}