using System;
using System.Collections.Generic;

namespace LivingBeings
{
	// Базовый класс Живое существо
	public abstract class LivingBeing
	{
		public string Name { get; set; }
		public int Age { get; set; }

		public LivingBeing(string name, int age)
		{
			Name = name;
			Age = age;
		}

		public abstract void Eat();
		public abstract void Sleep();
		public abstract void Move();
	}

	// Класс Животное
	public class Animal : LivingBeing
	{
		public string Species { get; set; }

		public Animal(string name, int age, string species) : base(name, age)
		{
			Species = species;
		}

		public override void Eat()
		{
			Console.WriteLine($"{Name} ест корм.");
		}

		public override void Sleep()
		{
			Console.WriteLine($"{Name} спит в укрытии.");
		}

		public override void Move()
		{
			Console.WriteLine($"{Name} бегает по лесу.");
		}
	}

	// Класс Птица
	public class Bird : LivingBeing
	{
		public double WingSpan { get; set; }

		public Bird(string name, int age, double wingSpan) : base(name, age)
		{
			WingSpan = wingSpan;
		}

		public override void Eat()
		{
			Console.WriteLine($"{Name} клюет зерно.");
		}

		public override void Sleep()
		{
			Console.WriteLine($"{Name} спит на ветке.");
		}

		public override void Move()
		{
			Console.WriteLine($"{Name} летает в небе.");
		}

		public void Sing()
		{
			Console.WriteLine($"{Name} поет красивую песню.");
		}
	}

	// Класс Рыба
	public class Fish : LivingBeing
	{
		public string WaterType { get; set; } // пресная или соленая вода

		public Fish(string name, int age, string waterType) : base(name, age)
		{
			WaterType = waterType;
		}

		public override void Eat()
		{
			Console.WriteLine($"{Name} поедает водоросли.");
		}

		public override void Sleep()
		{
			Console.WriteLine($"{Name} спит на глубине.");
		}

		public override void Move()
		{
			Console.WriteLine($"{Name} плавает в воде.");
		}
	}

	// Класс Растение
	public class Plant
	{
		public string Name { get; set; }
		public double Height { get; set; } // Высота в метрах

		public Plant(string name, double height)
		{
			Name = name;
			Height = height;
		}

		public void Grow()
		{
			Console.WriteLine($"{Name} растет на солнце.");
		}

		public void Photosynthesize()
		{
			Console.WriteLine($"{Name} поглощает свет и производит кислород.");
		}

		public void AbsorbWater()
		{
			Console.WriteLine($"{Name} поглощает воду из почвы.");
		}
	}

	// Класс Насекомое
	public class Insect : LivingBeing
	{
		public int LegCount { get; set; }

		public Insect(string name, int age, int legCount) : base(name, age)
		{
			LegCount = legCount;
		}

		public override void Eat()
		{
			Console.WriteLine($"{Name} питается нектаром.");
		}

		public override void Sleep()
		{
			Console.WriteLine($"{Name} отдыхает под листьями.");
		}

		public override void Move()
		{
			Console.WriteLine($"{Name} ползет по земле.");
		}

		public void Fly()
		{
			Console.WriteLine($"{Name} летает.");
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			Animal dog = new Animal("Собака", 5, "Млекопитающее");
			Bird sparrow = new Bird("Воробей", 2, 0.3);
			Fish goldfish = new Fish("Золотая рыбка", 1, "Пресная");
			Plant oak = new Plant("Дуб", 10);
			Insect bee = new Insect("Пчела", 1, 6);

			dog.Eat();
			sparrow.Sing();
			goldfish.Move();
			oak.Photosynthesize();
			bee.Fly();

			Console.ReadKey();
		}
	}
}
